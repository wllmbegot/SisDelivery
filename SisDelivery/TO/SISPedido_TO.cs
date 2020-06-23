using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisDelivery.TO
{
    [Serializable]
    public class SISPedido_TO
    {
        public int PED_CODIGO { get; set; }
        public decimal PED_TOTAL { get; set; }
        public decimal? PED_TROCO { get; set; }
        public int PED_ORDEM_ATENDIMENTO { get; set; }
        public string PED_STATUS { get; set; }
        public DateTime PED_CAD_DATA { get; set; }
        public decimal? PED_FRETE { get; set; }
        public int? PAG_CODIGO { get; set; }

        public SISCliente_TO CLI_CODIGO;

        public string tag { get; set; }
        public string query { get; set; }

    }
}
