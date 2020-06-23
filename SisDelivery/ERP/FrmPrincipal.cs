using System;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using SisDelivery.Infraestrutura;

namespace SisDelivery
{
    public partial class FrmPrincipal : Form
    {
        const string titulo = "ERP Sis Delivery";
        public FrmPrincipal()
        {
            InitializeComponent();
            CarregaStatusBar();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void AbrirFormNoPanel<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = panelConteudo.Controls.OfType<Forms>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new Forms();

                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelConteudo.Controls.Add(formulario);
                panelConteudo.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                if (formulario.WindowState == FormWindowState.Minimized)
                    formulario.WindowState = FormWindowState.Normal;
                formulario.BringToFront();
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<FrmProduto>();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<FrmCategoria>();
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<FrmCliente>();
        }
        private void btnPedidos_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<FrmPedidos>();
        }
        private void BtnEstoque_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<FrmEstoque>();
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm = new FrmPrincipal();
            frm.Closed += (s, args) => this.Close();
            frm.Show();            
        }

        private void panelCabecalho_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void CarregaStatusBar()
        {
            try
            {
                if (UtilConexion.CarregarConfiguracaoSistema() == true)
                {
                    var vrs = new Version(Application.ProductVersion);
                    Globais.VersaoPrograma = String.Format("{0}.{1}.{2}", vrs.Major, vrs.Minor, vrs.Revision);

                    string teste;

                    teste = string.Format("Servidor: {0}    Database : {1}    Usuário Banco: {2}  Versão:{3}",
                        Globais.NomeServidor,
                        Globais.BancoDados,
                        Globais.UsuarioBd,
                        Globais.VersaoPrograma).ToString();
                    txtSistema.Text = teste.ToString();                    

                    Refresh();
                }
            }
            catch (Exception ex)
            {
                Uteis.ExibirMensagem(ex.Message, titulo, TipoMensagem.Erro);
            }
        }


    }

}
