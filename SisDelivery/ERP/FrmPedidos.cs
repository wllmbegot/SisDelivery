using SisDelivery.BO;
using SisDelivery.DAO;
using SisDelivery.Infraestrutura;
using SisDelivery.TO;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SisDelivery
{
    public partial class FrmPedidos : Form
    {
        #region[Variáveis]

        public static int NumPed;
        public static int NumItem;
        public static int _codProd;
        public static decimal ValorResumoItem;
        #endregion
        public FrmPedidos()
        {
            InitializeComponent();
            CarregaMenuProdutos();
        }

        private void CarregaMenuProdutos()
        {
            
            SISProduto_TO SISProdutoTO = new SISProduto_TO();
            SISProdutoTO.tag = "PopularMenuProduto";
            DataTable dt = new SISProduto_BO().GetProdutoAtivo(SISProdutoTO);
            
            foreach (DataRow item in dt.Rows)
            {                
                ToolStripMenuItem novoItemMenu = new ToolStripMenuItem();
                novoItemMenu.Text = item["PRO_NOME"].ToString();
                novoItemMenu.Tag = item["PRO_CODIGO"].ToString();
                novoItemMenu.BackColor = Color.LightGreen;
                novoItemMenu.ForeColor = Color.DarkBlue;
                menuStrip1.Items.Add(novoItemMenu);

                
                //songsDataGridView.Columns[0].Name = "Release Date";

            }
        }

        #region [Métodos - Drag Drop Itens]

        Point mDown = new Point(-10000, -10000);

        private ToolStripMenuItem PegaItemMenu(IDataObject data)
        {
            ToolStripMenuItem ret = data.GetData(typeof(ToolStripMenuItem)) as ToolStripMenuItem;
            return ret;
        }

        private ListView.SelectedListViewItemCollection GetListViewItems(IDataObject data)
        {
            ListView.SelectedListViewItemCollection ret = data.GetData(typeof(ListView.SelectedListViewItemCollection)) as ListView.SelectedListViewItemCollection;
            return ret;
        }

        private void listView1_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {

            listView1.Items.Add(e.Data.ToString());


            MenuStrip menu = new MenuStrip();

            ToolStripMenuItem link = PegaItemMenu(e.Data);

            if (link != null && link.CanSelect)
                listView1.Items.Add(link.Name, link.Text);//(link.Caption, link.Item.SmallImageIndex); link.Item.Tag.ToString()

            if (listView1.Items.Count == 1)
            {

                int x = Convert.ToInt16(link.Text);
                //salvar_NovoPedido(x);
                //chkComplemento(x);

            }
            else
            {
                int x = Convert.ToInt16(link.Text);
                //salvar_NovoItem(NumPed, x);
                //chkComplemento(x);
            }


        }

        private void listView1_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {

            //var menuItem = (ToolStripItem)sender;
            //var links = menuItem.Text;

            ToolStripItem link = PegaItemMenu(e.Data);
            var item = (ListViewItem)e.Data.GetData(typeof(ListViewItem));

            if (link != null && link.OwnerItem.Enabled)
                e.Effect = DragDropEffects.Copy;
            else e.Effect = DragDropEffects.None;
        }

        private void listView1_DragLeave(object sender, EventArgs e)
        {
            for (int i = listView1.Items.Count - 1; i >= 0; i--)
            {
                if (listView1.Items[i].Selected)
                {
                    listView1.Items[i].Remove();
                }
            }
        }
        #endregion

        #region [Métodos -  Mouse Move / Mouse Down]

        private void listView1_MouseMove(object sender, MouseEventArgs e)
        {
            listView1.Focus();
            mDown = new Point(e.X, e.Y);
        }
        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            if ((Math.Abs(e.X - mDown.X) > 5 || Math.Abs(e.Y - mDown.Y) > 5))
            {
                int selectedItemsCount = listView1.SelectedItems.Count;
                if (selectedItemsCount < 0 || e.Button != MouseButtons.Left) return;
                listView1.DoDragDrop(listView1.SelectedItems, DragDropEffects.Copy);
            }
        }
        
        #endregion
         private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
            ToolStripMenuItem myObj = new ToolStripMenuItem();
            ListViewItem item = new ListViewItem();

            if (myObj != null && myObj.Enabled)
            {
                item.Text = e.ClickedItem.Text;
                item.Tag = e.ClickedItem.Tag;
                listView1.Items.Add(item);
            }
            if (listView1.Items.Count == 1)
            {
                _codProd = Convert.ToInt16(item.Tag);
                Salvar_NovoPedido(_codProd);
            }
            else
            {
                int codProd = Convert.ToInt16(item.Tag);
                Salvar_NovoItem(NumPed, codProd);
            }            

        }

        private void Salvar_NovoPedido(int codProd)
        {
            try
            {

                SISPedido_TO SISPedidoTO = new SISPedido_TO();

                bool lNovo = true;

                SISPedidoTO.PED_TOTAL = 00001;
                SISPedidoTO.PED_TROCO = 00001;
                SISPedidoTO.PED_ORDEM_ATENDIMENTO = 1;
                SISPedidoTO.PED_CAD_DATA = DateTime.Now;
                SISPedidoTO.PED_STATUS = "ATENDIMENTO";
                SISPedidoTO.PED_FRETE = 12;
                SISPedidoTO.PAG_CODIGO = 1;

                SISPedidoTO.tag = "PedidoNovo";

                if (new SISPedido_BO().Save(SISPedidoTO, lNovo))
                {
                    int numPed = SISPedidoTO.PED_CODIGO;

                    Salvar_NovoItem(numPed, codProd);
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void Salvar_NovoItem(int numPed, int codProd)
        {
            SISItemPedido_TO SISItemPedidoTO = new SISItemPedido_TO();

            bool lNovo = true;

            var objNulo = (int?)null;

            SISItemPedidoTO.COMP_ITENS = string.Empty;
            SISItemPedidoTO.ITE_OBS = string.Empty;
            SISItemPedidoTO.PED_CODIGO = numPed;
            SISItemPedidoTO.PRO_CODIGO = codProd;
            SISItemPedidoTO.ITE_ADICIONAL = objNulo;
            SISItemPedidoTO.tag = "ItemNovo";

            new SISItemPedido_BO().Save(SISItemPedidoTO, lNovo);
            {
                NumPed = numPed;
                NumItem = SISItemPedidoTO.ITE_CODIGO;

            }
            Calcular_ValoresProdutos();

        }

        private void Calcular_ValoresProdutos()
        {
            try
            {
                decimal valorItem = 0;
                decimal valorTotal = 0;
                string nomeItem = "";

                SISPedido_TO SISPedidoTO = new SISPedido_TO();
                SISPedidoTO.tag = "ResumoPedidoItem";
                SISPedidoTO.PED_CODIGO = NumPed;

                DataTable dt = new SISPedido_BO().GetPedido(SISPedidoTO);

                foreach (DataRow itemPedido in dt.Rows)
                {
                    nomeItem = itemPedido["PRO_NOME"].ToString();
                    valorItem = itemPedido["PRO_VALOR"].NullOrDecimal();
                    valorTotal += (+1 * itemPedido["PRO_VALOR"].NullOrDecimal());

                    ValorResumoItem = valorItem;
                    Popular_ResumoItem();

                }

                txtResumoTotal.Text = valorTotal.ToString("c");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Popular_ResumoItem()
        {
            SISPedido_TO SISPedidoTO = new SISPedido_TO();
            SISPedidoTO.tag = "GridResumoPedidoItem";
            SISPedidoTO.PED_CODIGO = NumPed;

            using (DataTable dt = new SISPedido_BO().GetPedido(SISPedidoTO))
            {                  
                gridResumoItem.BackColor = Color.DeepSkyBlue;
                gridResumoItem.DataSource = dt;

                //DataGridView dgPedido = new DataGridView();
                //dgPedido.Columns[0].Name = "Item";
                //dgPedido.Columns[1].Name = "Valor";
                //gridResumoItem.ColumnAdded

            }
        }
    }
}

