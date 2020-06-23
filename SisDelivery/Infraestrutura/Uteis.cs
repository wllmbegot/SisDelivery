using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data;

namespace SisDelivery.Infraestrutura
{
    public class Uteis
    {
        public static bool ExibirMensagem(String mensagem, String titulo, TipoMensagem tipoMsg)
        {
            MessageBoxIcon tipo;

            switch (tipoMsg)
            {
                case TipoMensagem.Erro:
                    tipo = MessageBoxIcon.Error;
                    break;
                case TipoMensagem.Aviso:
                case TipoMensagem.Alerta:
                    tipo = MessageBoxIcon.Warning;
                    break;
                default:
                    tipo = MessageBoxIcon.Information;
                    break;
            }

            MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, tipo);
            return true;
        }

        public static void LimparFormulario(Label text)
        {
            text.Text = string.Empty;
        }

        public static void LimparMascara(MaskedTextBox mask)
        {
            mask.Text = string.Empty;
        }
        
        public static void LimparFormulario(TextBox text)
        {
            text.Text = string.Empty;
        }



    }
}
