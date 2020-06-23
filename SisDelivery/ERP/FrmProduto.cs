using SisDelivery.BO;
using SisDelivery.Infraestrutura;
using SisDelivery.TO;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace SisDelivery
{
    public partial class FrmProduto : Form
    {

        private string titulo = "ERP - SIS Delivery - Cadastro de Produtos";
        private string _Cod;
        public FrmProduto()
        {
            InitializeComponent();
            PopularGridProduto();
            ComboBoxCategoria();
            //Criar um método só para esses tratamentos de componentes da tela (falta fazer)
            //Carrega a mascara da moeda
            this.txtProdPreco.Mask = "$ 999,999.00";
            this.txtProdPreco.Focus();
            //Desativar na tela a exibicação do TextCodigo e Label Código
            this.txtProdCodigo.Visible = false;
            this.lblProdCodigo.Visible = false;                  
        }

        public void PopularGridProduto()
        {
            SISProduto_TO SISProdutoTO = new SISProduto_TO();

            try
            {
                SISProdutoTO.tag = "PopGridCadProduto";

                using (DataTable dt = new SISProduto_BO().GetProdutos(SISProdutoTO))
                {
                    gridViewProdutos.DataSource = dt;
                };

                gridViewProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                gridViewProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Esse erro:'" + Ex + "'Verificar" + titulo);
            }
        }

        private void btnProdSalvar_Click(object sender, EventArgs e)
        {
            SalvarProduto(sender);
        }

        private void SalvarProduto(object sender)
        {
            string localCod = txtProdCodigo.Text;

            if ((String.IsNullOrEmpty(localCod)) && (!String.IsNullOrEmpty(txtProdNome.Text)))
            {
                try
                {
                    {
                        bool lNovo = true;

                        txtProdPreco.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals; // tira a formatação

                        SISProduto_TO SISProdutoTO = new SISProduto_TO();
                        SISProdutoTO.PRO_NOME = txtProdNome.Text;
                        SISProdutoTO.PRO_VALOR = int.Parse(txtProdPreco.Text); //texto não formatado
                        SISProdutoTO.PRO_UNIDADE = cmbProUni.Text;
                        SISProdutoTO.CAT_CODIGO = Convert.ToInt16(cmbProCategoria.SelectedIndex);
                        SISProdutoTO.tag = "ProdutoNovo";

                        if (new SISProduto_BO().Save(SISProdutoTO, lNovo))
                        {
                            txtProdPreco.TextMaskFormat = MaskFormat.IncludeLiterals; // retorna a formatação
                            LimparFormulario();
                            PopularGridProduto();
                            MessageBox.Show("Produto salvo com sucesso.");
                            return;
                        }
                    }

                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Esse erro:'" + Ex + "'Ok");
                }
            }
            else
            {
                MessageBox.Show("Produto já existe ou não informado.");
                return;
            }
        }       

        private void LimparFormulario()
        {
            lblProdCodigo.Text = String.Empty;
            this.txtProdCodigo.Visible = false;
            this.lblProdCodigo.Visible = false;


            cmbProCategoria.SelectedIndex = -1;
            cmbProUni.SelectedIndex = -1;
            Uteis.LimparFormulario(txtProdNome);
            Uteis.LimparMascara(txtProdPreco);
            
        }

        private void GridViewProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.txtProdCodigo.Visible = true;
                this.lblProdCodigo.Visible = true;

                this.lblProdCodigo.Size = new System.Drawing.Size(20, 20);
                DataGridViewRow row = gridViewProdutos.Rows[e.RowIndex];
                txtProdCodigo.Text = row.Cells[0].Value.ToString();
                txtProdNome.Text = row.Cells[1].Value.ToString();
                cmbProUni.Text = row.Cells[2].Value.ToString();
                txtProdPreco.Text = row.Cells[3].Value.ToString();
                cmbProCategoria.Text = row.Cells[4].Value.ToString();
            }                                   
        }

        private void BtnProdExcluir_Click(object sender, EventArgs e)
        {
            SISProduto_TO SISProdutoTO = new SISProduto_TO();
            _Cod = txtProdCodigo.Text;

            try
            {
                bool lNovo = true;

                SISProdutoTO.PRO_CODIGO = int.Parse(_Cod.ToString());
                SISProdutoTO.tag = "ExcluirProduto";

                if ((!String.IsNullOrEmpty(_Cod)))
                {
                    if (MessageBox.Show("Você realmente quer excluir o produto '" + txtProdNome.Text + "' Certo?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                    else
                    {

                        if (new SISProduto_BO().Delete(SISProdutoTO, lNovo))
                        {
                            PopularGridProduto();
                            LimparFormulario();

                            MessageBox.Show("Produto excluído com sucesso.");
                            return;
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Esse erro:'" + Ex + "'Ok?");
            }
        }

        private void btnProdAlterar_Click(object sender, EventArgs e)
        {
            SISProduto_TO SISProdutoTO = new SISProduto_TO();

            _Cod = txtProdCodigo.Text;

            if (txtProdNome != null)
                try
                {
                    bool lNovo = true;

                    txtProdPreco.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals; // tira a formatação

                    SISProdutoTO.PRO_CODIGO = int.Parse(_Cod.ToString());
                    SISProdutoTO.PRO_NOME = txtProdNome.Text;
                    SISProdutoTO.PRO_VALOR = int.Parse(txtProdPreco.Text); //texto não formatado
                    SISProdutoTO.PRO_UNIDADE = cmbProUni.Text;
                    SISProdutoTO.tag = "AlterarProduto";

                    if (new SISProduto_BO().Save(SISProdutoTO, lNovo))
                    {
                        txtProdPreco.TextMaskFormat = MaskFormat.IncludeLiterals; // retorna a formatação                     
                        MessageBox.Show("Produto salvo com sucesso.");
                        PopularGridProduto();
                        LimparFormulario();
                        return;
                    }

                }
                catch (Exception)
                {

                    throw;
                }
        }

        private void ComboBoxCategoria()
        {
            SISCategoria_TO SISCategoriaTO = new SISCategoria_TO();

            SISCategoriaTO.tag = "PopularComboBoxCategoria";

            DataTable dt = new SISCategoria_BO().GetCategoria(SISCategoriaTO);
           
            foreach (DataRow row in dt.Rows)
            {

                if (row["CAT_NOME"].ToString() != null)
                {
                    string input = row["CAT_NOME"].ToString();          
                    var myInt = int.Parse(row["CAT_CODIGO"].ToString());

                    input.Replace(" ", "");
                    string pattern = @"(?i)[^0-9a-záéíóúàèìòùâêîôûãõç\s]";
                    string replacement = "";
                    Regex rgx = new Regex(pattern);
                    string result = rgx.Replace(input, replacement);

                    


                    this.cmbProCategoria.Items.Insert(myInt, input);
                }   

            }

        }
    }
}
