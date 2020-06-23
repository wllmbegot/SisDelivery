using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisDelivery.TO
{
    [Serializable]
    public class SISItemPedido_TO
    {
        public int ITE_CODIGO { get; set; }
        public int PED_CODIGO { get; set; }
        public int PRO_CODIGO { get; set; }
        public int? ITE_ADICIONAL { get; set; }

        public string COMP_ITENS { get; set; }
        public string ITE_OBS { get; set; }

        public string tag { get; set; }
        public string query { get; set; }

        public SISPedido_TO SISPedidoTO;

    }
}
