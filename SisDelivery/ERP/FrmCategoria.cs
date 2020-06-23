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
using SisDelivery.Infraestrutura;

namespace SisDelivery
{
    public partial class FrmCategoria : Form
    {
        private string titulo = "ERP - Begoos Burger - Cadastro de Categoria";
        public FrmCategoria()
        {
            InitializeComponent();
            PopularGridCategoria();
        }

        private void PopularGridCategoria()
        {
            SISCategoria_TO SISCategoriaTO = new SISCategoria_TO();

            try
            {
                SISCategoriaTO.tag = "PopularComboBoxCategoria";

                using (DataTable dt = new SISCategoria_BO().GetCategoria(SISCategoriaTO))
                {
                    gridViewCategoria.DataSource = dt;
                };

            }
            catch (Exception ex)
            {

                Uteis.ExibirMensagem(ex.Message, titulo, TipoMensagem.Erro);
            }
        }

        private void btnCatSalvar_Click(object sender, EventArgs e)
        {
            SalvarCategoria(sender);
            IniciarTela();
        }

        private void IniciarTela()
        {
            Uteis.LimparFormulario(txtCatNome);
            Uteis.LimparFormulario(txtCatDescricao);
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
            catch (Exception Ex)
            {

                MessageBox.Show("Esse erro:'" + Ex + "'Ok");
            }
        }
    }
}
