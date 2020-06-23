using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Xml;


namespace SisDelivery.Infraestrutura
{
    public class UtilConexion
    {
                
        private XmlDocument xmlDocument;
        private string ArquivoConfig = "\\Begoos.xml";
        public string pathArquivocfg;
        private XmlNode _Node;

        public static string p_ConnectionString;

        public static string GetConnectionString(string pAnyConnectionString)
        {

            string connectionstring = null;
            var connstring = ConfigurationManager.ConnectionStrings["strConexao"].ConnectionString;
            connectionstring = ConfigurationManager.AppSettings[pAnyConnectionString];

            
            //return connectionstring;
            return connstring;
        }

        public static bool StringConexao(string p_Servidor, string p_BancodeDados, string p_Usuario, string p_Senha)
        {
            string p_ConnectionString;
            try
            {


                if (string.IsNullOrEmpty(p_Servidor))
                    throw new Exception("Nome ou Ip do servidor é OBRIGATÓRIO");

                if (string.IsNullOrEmpty(p_BancodeDados))
                    throw new Exception("Nome do Banco de Dados é OBRIGATÓRIO");


                if (string.IsNullOrEmpty(p_Usuario))
                    throw new Exception("Nome do Usuário é OBRIGATÓRIO");

                if (string.IsNullOrEmpty(p_Senha))
                    throw new Exception("Senha de Acesso do Servidor é OBRIGATÓRIO");
                

                //ParametroConexao.p_ConnectionString = String.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;  Connect Timeout=30;User ID={2};Password={3}", p_Servidor, p_BancodeDados, p_Usuario, p_Senha);
                p_ConnectionString = String.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True; Application Name=db_delivery; Connect Timeout=1200;User ID={2};Password={3}", p_Servidor, p_BancodeDados, p_Usuario, p_Senha);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public static List<String> obterParametroConfiguracao(String sistema, String modulo, String item)
        {
            List<String> parametros = new List<String>();
            String query = String.Format("SELECT parametro FROM {0} WHERE sistema='{1}' AND modulo='{2}' AND item='{3}' ORDER BY parametro DESC",
                                          "ParametrosConfiguracao", sistema, modulo, item);

            SqlConnection connection = null;

            try
            {
                connection = new SqlConnection(UtilConexion.GetConnectionString("strConexao"));
                connection.Open();
                SqlDataReader consulta = new SqlCommand(query, connection).ExecuteReader();

                if (consulta.HasRows)
                {
                    while (consulta.Read())
                        parametros.Add(consulta["parametro"].ToString());

                    consulta.Close();
                }
                else
                {

                    throw new Exception("Não há parâmetros cadastrados para o item " + item + " do módulo " + modulo + " (" + sistema + ").");
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return parametros;
        }

        public static bool CarregarConfiguracaoSistema()
        {
            try
            {
                Globais.pDirArquivoCfg = Environment.CurrentDirectory;
                Globais.DiretorioPadrao = Globais.pDirArquivoCfg;
                Globais.pDirArquivoCfg = (Globais.pDirArquivoCfg.EndsWith(@"\") ? string.Empty : Globais.pDirArquivoCfg + @"\");
                const string _ArquivoConfiguracao = "Begoos.xml";
                var _ArquivoConfiguracaoComPath = Globais.pDirArquivoCfg + _ArquivoConfiguracao;

                string _ArquivoCfg = (Globais.pDirArquivoCfg + _ArquivoConfiguracao);

                if (ArquivoExiste(_ArquivoConfiguracaoComPath))
                {
                    //throw new Exception(String.Format("Arquivo Begoos.xml em {0}{1} Não será possível configurar o sistema.", Globais.pDirArquivoCfg, Environment.NewLine));
                }

                var xmlConf = new XMLConfiguracaoERP(Globais.pDirArquivoCfg);


                Globais.CodigoServidorBD = xmlConf.GetParametro(Globais.pDirArquivoCfg, "Pdv", "ServidorDefault", "CodigoServidorDefault");

                Globais.ipMatriz = xmlConf.GetParametro(Globais.pDirArquivoCfg, "Pdv", "ServidorMatriz", "NomeServidor");
                //Globais.ipTeste = xmlConf.GetParametro(Globais.pDirArquivoCfg, "Pdv", "ServidorTeste", "NomeServidor");
                //Globais.ipTruck = xmlConf.GetParametro(Globais.pDirArquivoCfg, "Pdv", "ServidorTruck", "NomeServidor");

                string usuarioAtualCript = xmlConf.GetParametro(Globais.pDirArquivoCfg, "Pdv", "Servidor", "Usuario");

                if (usuarioAtualCript.Equals("sa"))
                {
                    switch (Globais.CodigoServidorBD)
                    {



                    }

                    xmlConf.SalvarConfiguracao("ServidorMatriz", "Usuario", GestorCriptografia.Criptografar(xmlConf.GetParametro(Globais.pDirArquivoCfg, "Pdv", "ServidorMatriz", "Usuario")));
                    xmlConf.SalvarConfiguracao("ServidorMatriz", "Senha", GestorCriptografia.Criptografar(xmlConf.GetParametro(Globais.pDirArquivoCfg, "Pdv", "ServidorMatriz", "Senha")));

                    xmlConf.SalvarConfiguracao("ServidorTeste", "Usuario", GestorCriptografia.Criptografar(xmlConf.GetParametro(Globais.pDirArquivoCfg, "Pdv", "ServidorTeste", "Usuario")));
                    xmlConf.SalvarConfiguracao("ServidorTeste", "Senha", GestorCriptografia.Criptografar(xmlConf.GetParametro(Globais.pDirArquivoCfg, "Pdv", "ServidorTeste", "Senha")));

                    xmlConf.SalvarConfiguracao("ServidorHomologacao", "Usuario", GestorCriptografia.Criptografar(xmlConf.GetParametro(Globais.pDirArquivoCfg, "Pdv", "ServidorTruck", "Usuario")));
                    xmlConf.SalvarConfiguracao("ServidorHomologacao", "Senha", GestorCriptografia.Criptografar(xmlConf.GetParametro(Globais.pDirArquivoCfg, "Pdv", "ServidorTruck", "Senha")));

                }
                else
                {
                    switch (Globais.CodigoServidorBD)
                    {

                    }

                    //xmlConf.SalvarConfiguracao2("Servidor", "Usuario", GestorCriptografia.Criptografar("sa"));
                    //xmlConf.SalvarConfiguracao2("Servidor", "Senha", GestorCriptografia.Criptografar("12345"));

                    Globais.NomeServidor = xmlConf.GetParametro(Globais.pDirArquivoCfg, "Pdv", "Servidor", "NomeServidor");
                    Globais.BancoDados = xmlConf.GetParametro(Globais.pDirArquivoCfg, "Pdv", "Servidor", "BancoDados");
                    Globais.UsuarioBd = GestorCriptografia.Descriptografar(xmlConf.GetParametro(Globais.pDirArquivoCfg, "Pdv", "Servidor", "Usuario"));
                    Globais.Senha = GestorCriptografia.Descriptografar(xmlConf.GetParametro(Globais.pDirArquivoCfg, "Pdv", "Servidor", "Senha"));
                }


                return true;


                if (usuarioAtualCript.Equals("sa") || usuarioAtualCript.Equals("saef"))
                {
                    switch (Globais.CodigoServidorBD)
                    {

                        default:
                            Uteis.ExibirMensagem("Código do do Servidor Default não foi encontrado", "ERP", TipoMensagem.Erro);
                            return false;
                    }

                    xmlConf.SalvarConfiguracao("ServidorPA", "Usuario", GestorCriptografia.Criptografar(xmlConf.GetParametro(Globais.pDirArquivoCfg, "Extrafarma", "ServidorPA", "Usuario")));
                    xmlConf.SalvarConfiguracao("ServidorPA", "Senha", GestorCriptografia.Criptografar(xmlConf.GetParametro(Globais.pDirArquivoCfg, "Extrafarma", "ServidorPA", "Senha")));

                    xmlConf.SalvarConfiguracao("ServidorMA", "Usuario", GestorCriptografia.Criptografar(xmlConf.GetParametro(Globais.pDirArquivoCfg, "Extrafarma", "ServidorMA", "Usuario")));
                    xmlConf.SalvarConfiguracao("ServidorMA", "Senha", GestorCriptografia.Criptografar(xmlConf.GetParametro(Globais.pDirArquivoCfg, "Extrafarma", "ServidorMA", "Senha")));

                    xmlConf.SalvarConfiguracao("ServidorCE", "Usuario", GestorCriptografia.Criptografar(xmlConf.GetParametro(Globais.pDirArquivoCfg, "Extrafarma", "ServidorCE", "Usuario")));
                    xmlConf.SalvarConfiguracao("ServidorCE", "Senha", GestorCriptografia.Criptografar(xmlConf.GetParametro(Globais.pDirArquivoCfg, "Extrafarma", "ServidorCE", "Senha")));



                }
                else
                {


                    switch (Globais.CodigoServidorBD)
                    {

                        default:
                            Uteis.ExibirMensagem("Código do do Servidor Default não foi encontrado", "ERP", TipoMensagem.Erro);
                            return false;
                    }
                }

                var _toReturn = UtilConexion.StringConexao(Globais.NomeServidor, Globais.BancoDados, Globais.UsuarioBd, Globais.Senha);

                return _toReturn;


            }
            catch (Exception ex)
            {
                Uteis.ExibirMensagem(ex.Message, "ERP", TipoMensagem.Erro);
                return false;
            }

        }

        public static bool ArquivoExiste(string sourceFile)
        {
            try
            {

                if (File.Exists(sourceFile))
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }


    }
}
