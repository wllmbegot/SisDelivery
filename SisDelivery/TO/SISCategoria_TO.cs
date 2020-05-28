using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisDelivery.TO
{
    [Serializable]
    public class SISCategoria_TO
    {
        public int CAT_CODIGO { get; set; }
        public string CAT_NOME { get; set; }
        public string CAT_DESCRICAO { get; set; }
        public DateTime CAT_DATA_CADASTRO { get; set; }
        public DateTime CAT_DATA_EXPERICAO { get; set; }

        public string tag { get; set; }
        public string query { get; set; }
    }
}
