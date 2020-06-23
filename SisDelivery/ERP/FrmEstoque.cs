using SisDelivery.BO;
using SisDelivery.TO;
using System;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SisDelivery
{
    public partial class FrmEstoque : Form
    {
        public FrmEstoque()
        {
            InitializeComponent();
            ComboBoxProduto();



        }

        private void BtnEstSalvar_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxProduto()
        {
            SISProduto_TO SISProdutoTO = new SISProduto_TO();

            SISProdutoTO.tag = "PopularComboBoxProduto";

            DataTable dt = new SISProduto_BO().GetProdutoAtivo(SISProdutoTO);

            foreach (DataRow row in dt.Rows)
            {

                if (row["PRO_NOME"].ToString() != null)
                {
                    string input = row["PRO_NOME"].ToString();
                    var myInt = int.Parse(row["PRO_CODIGO"].ToString());

                    input.Replace(" ", "");
                    string pattern = @"(?i)[^0-9a-záéíóúàèìòùâêîôûãõç\s]";
                    string replacement = "";
                    Regex rgx = new Regex(pattern);
                    string result = rgx.Replace(input, replacement);

                    ComboBox comboProduto = new ComboBox();


                    this.cmbEstoqProduto.Items.Insert(myInt, input);
                }

            }
        }
    }
}
