using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SisDelivery.Infraestrutura;
using System.Data.SqlClient;
using System.Data;

namespace SisDelivery.DAO
{
    internal class SISProduto_DAO
    {
        internal bool Save(SISProduto_TO pSisProdutoTO)
        {
            bool retorno = false;

            SqlConnection connection = null;

            try
            {
                connection = new SqlConnection(UtilConexion.GetConnectionString("strConexao"));
                connection.Open();
            }
            catch (Exception)
            {
                throw;
            }

            SqlCommand command = null;
            StringBuilder sql = new StringBuilder();
            SqlDataReader reader = null;

            sql.AppendLine("INSERT INTO PRODUTO ");
            sql.AppendLine("VALUES (@PRO_NOME");
            sql.AppendLine(",@PRO_VALOR");
            sql.AppendLine(",@PRO_UNIDADE");
            sql.AppendLine(",@CAT_CODIGO)");


            sql.Append("SELECT @@IDENTITY AS 'ULTIMO_PRO_CODIGO'");

            try
            {
                command = new SqlCommand(sql.ToString(), connection);
                command.Parameters.AddWithValue("@PRO_NOME", pSisProdutoTO.PRO_NOME);
                command.Parameters.AddWithValue("@PRO_VALOR", pSisProdutoTO.PRO_VALOR);
                command.Parameters.AddWithValue("@PRO_UNIDADE", pSisProdutoTO.PRO_UNIDADE);
                command.Parameters.AddWithValue("@CAT_CODIGO", pSisProdutoTO.CAT_CODIGO);

                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    pSisProdutoTO.PRO_CODIGO = Convert.ToInt32(reader["ULTIMO_PRO_CODIGO"]);
                    retorno = true;

                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                command.Dispose();
                connection.Close();
                connection.Dispose();

            }

            return retorno;


        }

        internal bool Delete(SISProduto_TO pSISProdutoTO)
        {
            bool retorno = false;
            SqlConnection connection = null;

            try
            {
                // criando e abrindo a conexão
                connection = new SqlConnection(UtilConexion.GetConnectionString("strConexao"));
                connection.Open();
            }
            catch (Exception)
            {
                throw;
            }

            SqlCommand command = null;
            StringBuilder sql = new StringBuilder();
            try
            {

                sql.AppendLine("DELETE PRODUTO ");
                sql.AppendLine(" WHERE PRO_CODIGO = @PRO_CODIGO ");


                command = new SqlCommand(sql.ToString(), connection);
                command.Parameters.AddWithValue("@PRO_CODIGO", pSISProdutoTO.PRO_CODIGO);

                command.ExecuteNonQuery();

                retorno = true;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                command.Dispose();
                connection.Close();
                connection.Dispose();

            }

            return retorno;

        }

        internal DataTable GetProdutos(SISProduto_TO pSISProdutoTO)
        {
            SqlConnection connection = null;
            DataTable ldt = new DataTable();
            try
            {
                // criando e abrindo a conexão
                connection = new SqlConnection(UtilConexion.GetConnectionString("strConexao"));
                connection.Open();
            }
            catch (Exception)
            {
                throw;
            }

            SqlCommand command = null;
            StringBuilder sql = new StringBuilder();

            if (pSISProdutoTO.tag.Equals("PopGridCadProduto"))
            {
                sql.Append("SELECT PRO.PRO_CODIGO, ");
                sql.Append("PRO.PRO_NOME, ");
                sql.Append("PRO.PRO_UNIDADE, ");
                sql.Append("PRO.PRO_VALOR, ");
                sql.Append("CAT.CAT_NOME, ");
                sql.Append("EST.EST_QTD, EST.EST_QTD_MINIMA ");
                sql.Append("FROM PRODUTO PRO ");
                sql.Append("LEFT JOIN CATEGORIA CAT ");
                sql.Append("ON PRO.CAT_CODIGO = CAT.CAT_CODIGO ");
                sql.Append("LEFT JOIN Estoque EST ");
                sql.AppendFormat("ON PRO.PRO_CODIGO = EST.PRO_CODIGO ", pSISProdutoTO.query);
            }

            if (pSISProdutoTO.tag.Equals("PopComboxProduto"))
            {

                sql.Append(" SELECT ");
                sql.Append(" PROD.PRO_CODIGO,");
                sql.Append(" PROD.PRO_NOME,");
                sql.AppendFormat(" FROM PRODUTO PROD ", pSISProdutoTO.query);
            }

            try
            {
                command = new SqlCommand(sql.ToString(), connection);

                SqlDataAdapter a = new SqlDataAdapter(command);
                a.Fill(ldt);

            }


            catch (Exception)
            {
                throw;
            }
            finally
            {
                command.Dispose();
                connection.Close();
                connection.Dispose();
            }

            return ldt;
        }

        internal bool UpDate(SISProduto_TO pSISProdutoTO)
        {
            bool retorno = false;

            SqlConnection connection = null;

            try
            {
                connection = new SqlConnection(UtilConexion.GetConnectionString("strConexao"));
                connection.Open();
            }
            catch (Exception)
            {

                throw;
            }

            SqlCommand command = null;
            StringBuilder sql = new StringBuilder();
            try
            {

                sql.AppendLine("UPDATE PRODUTO SET");

                sql.AppendLine(" PRO_NOME = @PRO_NOME");
                sql.AppendLine(",PRO_UNIDADE = @PRO_UNIDADE");
                sql.AppendLine(",PRO_VALOR = @PRO_VALOR");
                sql.AppendLine(",CAT_CODIGO = @CAT_CODIGO");
                sql.AppendLine(" WHERE PRO_CODIGO = @PRO_CODIGO ");


                command = new SqlCommand(sql.ToString(), connection);
                command.Parameters.AddWithValue("@PRO_CODIGO", pSISProdutoTO.PRO_CODIGO);
                command.Parameters.AddWithValue("@PRO_NOME", pSISProdutoTO.PRO_NOME);
                command.Parameters.AddWithValue("@PRO_UNIDADE", pSISProdutoTO.PRO_UNIDADE);
                command.Parameters.AddWithValue("@PRO_VALOR", pSISProdutoTO.PRO_VALOR);
                command.Parameters.AddWithValue("@CAT_CODIGO", pSISProdutoTO.CAT_CODIGO);

                command.ExecuteNonQuery();

                retorno = true;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                command.Dispose();
                connection.Close();
                connection.Dispose();

            }

            return retorno;


        }


    }
}
