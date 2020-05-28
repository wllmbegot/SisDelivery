using SisDelivery.TO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SisDelivery.BO;


namespace SisDelivery
{
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void btnCatSalvar_Click(object sender, EventArgs e)
        {
            SalvarCategoria(sender);
            IniciarTela();
        }

        private void IniciarTela()
        {
            throw new NotImplementedException();
        }

        private void SalvarCategoria(object sender, EventArgs e = null)
        {
            try
            {
                bool lNovo = true;

                SISCategoria_TO SISCategoriaTO = new SISCategoria_TO();

                SISCategoriaTO.tag = "SalvarCategoria";
                SISCategoriaTO.CAT_NOME = txtCatNome.Text;
                SISCategoriaTO.CAT_DESCRICAO = txtCatDescricao.Text;

                if(new SISCategoria_BO().Save(SISCategoriaTO, lNovo))
                {
                    MessageBox.Show("Categoria salva com sucesso.");



                }


               


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
