using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SisDelivery.Infraestrutura
{
    public class UtilConexion
    {
        public static string p_ConnectionString;

        public static string GetConnectionString(string pAnyConnectionString)
        {

            string connectionstring = null;

            connectionstring = ConfigurationManager.AppSettings[pAnyConnectionString];

            
            return connectionstring;
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

    }
}
