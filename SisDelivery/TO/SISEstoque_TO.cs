using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisDelivery.TO
{
    [Serializable]
    public class SISEstoque_TO
    {
        public int EST_CODIGO { get; set; }
        public int EST_QTD { get; set; }
        public int EST_QTD_MINIMA { get; set; }
        public string EST_OBSERVACAO { get; set; }

        public string tag { get; set; }
        public string query { get; set; }
        
        public SISProduto_TO SISProdutoTO;
    }
}
