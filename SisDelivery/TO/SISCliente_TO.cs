using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisDelivery.TO
{
    [Serializable]
    public class SISCliente_TO
    {

        public int CLI_CODIGO { get; set; }
        public string CLI_NOME { get; set; }
        public string CLI_TELEFONE { get; set; }
        public DateTime CLI_CADASTRO_DATA { get; set; }
        public string CLI_REDE_SOCIAL { get; set; }
        public string CLI_EMAIL { get; set; }

        public string tag { get; set; }
        public string query { get; set; }
                
    }
}
