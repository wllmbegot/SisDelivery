using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisDelivery.DAO
{
    [Serializable]
    public class SISProduto_TO
    {
        public int PRO_CODIGO { get; set; }
        public string PRO_NOME { get; set; }
        public decimal PRO_VALOR { get; set; }
        public string PRO_UNIDADE { get; set; }
        public int CAT_CODIGO { get; set; }

        public string tag { get; set; }
        public string query { get; set; }
    }
}