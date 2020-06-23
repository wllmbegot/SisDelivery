using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisDelivery.Infraestrutura
{
    public class Globais
    {
        //Parâmetros da string de conexão com Banco de Dados
        public static string NomeServidor { get; set; }
        public static string BancoDados { get; set; }
        public static string UsuarioBd { get; set; }
        public static string Senha { get; set; }
        public static string VersaoPrograma { get; set; }
        public static string UsuarioRede { get; set; }

        public static string ipMatriz { get; set; }
        public static string ipTeste { get; set; }
        public static string ipHomologacao { get; set; }
        public static string ipTruck { get; set; }

        public static string pDirArquivoCfg { get; set; }
        public static string DiretorioPadrao { get; set; }
        public static string CodigoServidorBD { get; set; }
        public static string pNomeArquivoCfg { get; set; }

        public static string p_ConnectionString { get; set; }


    }
}
