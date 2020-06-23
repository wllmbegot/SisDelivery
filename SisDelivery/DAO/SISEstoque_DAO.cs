using System;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using SisDelivery.TO;
using SisDelivery.Infraestrutura;

namespace SisDelivery.DAO
{
    internal class SISEstoque_DAO
    {
        internal DataTable GetEstoqueProduto(SISEstoque_TO pSISEstoqueTO)
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

            if (pSISEstoqueTO.tag.Equals("PopularGridEstoque"))
            {

                sql.Append(" SELECT ");
                sql.Append(" P.PRO_NOME, P.PRO_UNIDADE, C.CAT_NOME, P.PRO_VALOR, E.EST_QTD_MINIMA, ");
                sql.Append(" E.EST_QTD, E.EST_CODIGO, E.EST_DATA_CADASTRO, E.PRO_CODIGO ");
                sql.Append(" FROM PRODUTO P ");
                sql.Append(" INNER JOIN ESTOQUE E ");
                sql.Append(" ON P.PRO_CODIGO = E.PRO_CODIGO ");
                sql.Append(" LEFT JOIN CATEGORIA C ");
                sql.AppendFormat(" ON P.CAT_CODIGO = C.CAT_CODIGO ");
            }

            else if (pSISEstoqueTO.tag.Equals("PopularItemEstoque"))
            {
                sql.Append(" SELECT ");
                sql.Append(" P.PRO_NOME, E.EST_CODIGO, E.PRO_CODIGO ");
                sql.Append(" FROM PRODUTO P ");
                sql.Append(" INNER JOIN ESTOQUE E ");
                sql.AppendFormat(" ON P.PRO_CODIGO = E.PRO_CODIGO  {0} ", pSISEstoqueTO.query);
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

        internal bool Save(SISEstoque_TO pSISEstoqueTO)
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

            sql.AppendLine("INSERT INTO ESTOQUE ");
            sql.AppendLine("VALUES (@PRO_CODIGO");
            sql.AppendLine(" ,@EST_QTD");
            sql.AppendLine(" ,@EST_QTD_MINIMA");
            sql.AppendLine(" ,GETDATE() ");
            sql.AppendLine(" ,@EST_OBSERVACAO )");

            sql.Append(" SELECT @@IDENTITY AS 'ULTIMO_EST_CODIGO' ");

            try
            {
                command = new SqlCommand(sql.ToString(), connection);
                command.Parameters.AddWithValue("@PRO_CODIGO", pSISEstoqueTO.SISProdutoTO.PRO_CODIGO);
                command.Parameters.AddWithValue("@EST_QTD", pSISEstoqueTO.EST_QTD);
                command.Parameters.AddWithValue("@EST_QTD_MINIMA", pSISEstoqueTO.EST_QTD_MINIMA);
                command.Parameters.AddWithValue("@EST_OBSERVACAO", pSISEstoqueTO.EST_OBSERVACAO);


                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    pSISEstoqueTO.EST_CODIGO = Convert.ToInt32(reader["ULTIMO_EST_CODIGO"]);
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

        internal bool UpDate(SISEstoque_TO pSISEstoqueTO)
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
                sql.AppendLine("UPDATE ESTOQUE SET ");
                sql.AppendLine("EST_QTD = @EST_QTD ,");
                sql.AppendLine("EST_OBSERVACAO = @EST_OBSERVACAO ");
                sql.AppendLine("WHERE EST_CODIGO = @EST_CODIGO");

                command = new SqlCommand(sql.ToString(), connection);
                command.Parameters.AddWithValue("@EST_QTD", pSISEstoqueTO.EST_QTD);
                command.Parameters.AddWithValue("@EST_OBSERVACAO", pSISEstoqueTO.EST_OBSERVACAO);
                command.Parameters.AddWithValue("@EST_CODIGO", pSISEstoqueTO.EST_CODIGO);

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
