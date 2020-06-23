using SisDelivery.BO;
using SisDelivery.DAO;
using SisDelivery.Infraestrutura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisDelivery
{
    public partial class FrmVendas : Form
    {
        const string titulo = "ERP Sis Delivery";
        public FrmVendas()
        {
            InitializeComponent();
            //carrega_MenuProduto();
        }



        private IEnumerable<string> GetProdutosMenu()
        {
            throw new NotImplementedException();
        }

        //Cardápio - Menu de produtos -INI
        //private void carrega_MenuProduto()
        //{
        //    SISProduto_TO SISProdutoTO = new SISProduto_TO();
        //    SISProdutoTO.tag = "NavBarControl_MenuProduto";

        //    DataTable dt = new SISProduto_BO().GetProdutoAtivo(SISProdutoTO);

        //    string groupName;
        //    string itemCaption;
        //    string eventMethod;

        //    foreach (DataRow row in dt.Rows)
        //    {
        //        itemCaption = row["PRO_NOME"].ToString();
        //        groupName = row["CAT_NOME"].ToString();
        //        eventMethod = row["PRO_CODIGO"].ToString();

        //        if (row["PRO_NOME"].ToString() != null)
        //        {
        //            if (String.IsNullOrEmpty(groupName))
        //            {
        //                AddItem("SEM CATEGORIA", row["PRO_NOME"].ToString(), eventMethod);
        //            }
        //            else
        //            {
        //                AddItem(row["CAT_NOME"].ToString(), row["PRO_NOME"].ToString(), eventMethod);
        //            }
        //        }
        //    }
        //}

        //private void MenuProduto()
        //{
        //    try
        //    {
        //        // Create a MenuStrip control 
        //        MenuStrip ms = new MenuStrip();

        //        ToolStripMenuItem windowMenu = new ToolStripMenuItem("Window");
        //        ToolStripMenuItem windowNewMenu = new ToolStripMenuItem("New", null, new EventHandler(WindowNewMenu_Click));
        //        windowMenu.DropDownItems.Add(windowNewMenu);
        //        ((ToolStripDropDownMenu)(windowMenu.DropDown)).ShowImageMargin = false;
        //        ((ToolStripDropDownMenu)(windowMenu.DropDown)).ShowCheckMargin = true;

        //        // Assign the ToolStripMenuItem that displays 
        //        // the list of child forms.
        //        ms.MdiWindowListItem = windowMenu;

        //        // Add the window ToolStripMenuItem to the MenuStrip.
        //        ms.Items.Add(windowMenu);

        //        // Dock the MenuStrip to the top of the form.
        //        ms.Dock = DockStyle.Top;

        //        // The Form.MainMenuStrip property determines the merge target.
        //        this.MainMenuStrip = ms;

        //    }
        //    catch (Exception Ex)
        //    {

        //        Uteis.ExibirMensagem(Ex.Message, titulo, TipoMensagem.Erro);
        //    }
        //}

        // This event handler is invoked when 
        // the "New" ToolStripMenuItem is clicked.
        // It creates a new Form and sets its MdiParent 
        // property to the main form.
        void WindowNewMenu_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f.MdiParent = this;
            f.Text = "Form - " + this.MdiChildren.Length.ToString();
            f.Show();
        }



        //public void AddItem(string groupName, string caption, string eventMethod)
        //{

        //    NavBarGroup group = GetNavBarGroup(groupName);
        //    group.Expanded = true;
        //    NavBarItem item = new NavBarItem(caption);
        //    if (groupName == "HAMBURGERS")
        //    {
        //        item.Tag = eventMethod;
        //        item.SmallImageIndex = 0;
        //        group.ItemLinks.Add(item);
        //        return;
        //    }
        //    if (groupName == "BEBIDAS")
        //    {
        //        item.Tag = eventMethod;
        //        item.SmallImageIndex = 1;
        //        group.ItemLinks.Add(item);
        //        return;
        //    }
        //    else
        //    {
        //        item.Tag = eventMethod;
        //        item.SmallImageIndex = 2;
        //        group.ItemLinks.Add(item);
        //    }
        //}

        //private void menuStripProdutos_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        //{
        //    Form f = new Form();
        //    f.MdiParent = this;
        //    f.Text = "Form - " + this.MdiChildren.Length.ToString();
        //    f.Show();
        //}

        //private void menuStripProdutos_MouseClick(object sender, MouseEventArgs e)
        //{
        //    MenuStrip ms = new MenuStrip();
        //    ToolStripMenuItem windowMenu = new ToolStripMenuItem("Window");
        //    ToolStripMenuItem windowNewMenu = new ToolStripMenuItem("New", null, new EventHandler(windowMenu));
        //    windowMenu.DropDownItems.Add(windowNewMenu);
        //    ((ToolStripDropDownMenu)(windowMenu.DropDown)).ShowImageMargin = false;
        //    ((ToolStripDropDownMenu)(windowMenu.DropDown)).ShowCheckMargin = true;

        //    // Assign the ToolStripMenuItem that displays 
        //    // the list of child forms.
        //    ms.MdiWindowListItem = windowMenu;

        //    // Add the window ToolStripMenuItem to the MenuStrip.
        //    ms.Items.Add(windowMenu);

        //    // Dock the MenuStrip to the top of the form.
        //    ms.Dock = DockStyle.Top;

        //    // The Form.MainMenuStrip property determines the merge target.
        //    this.MainMenuStrip = ms;
        //}
    }
}
