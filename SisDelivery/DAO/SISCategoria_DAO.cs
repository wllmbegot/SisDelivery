using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SisDelivery.Infraestrutura;
using System.Data.SqlClient;
using SisDelivery.TO;
using System.Data;

namespace SisDelivery.DAO
{
    internal class SISCategoria_DAO
    {
        internal bool Save(SISCategoria_TO pCategoriaTO)
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

            sql.AppendLine("INSERT INTO CATEGORIA ");
            sql.AppendLine("VALUES (@CAT_NOME");
            sql.AppendLine(" ,@CAT_DESCRICAO");
            sql.AppendLine(" ,GETDATE() ");
            sql.AppendLine(" ,GETDATE() )");

            sql.Append(" SELECT @@IDENTITY AS 'ULTIMO_CAT_CODIGO' ");

            try
            {
                command = new SqlCommand(sql.ToString(), connection);
                command.Parameters.AddWithValue("@CAT_NOME", pCategoriaTO.CAT_NOME);
                command.Parameters.AddWithValue("@CAT_DESCRICAO", pCategoriaTO.CAT_DESCRICAO);

                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    pCategoriaTO.CAT_CODIGO = Convert.ToInt32(reader["ULTIMO_CAT_CODIGO"]);
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

        internal bool UpDate(SISCategoria_TO pSISCategoriaTO)
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
                sql.AppendLine("UPDATE CATEGORIA SET ");
                sql.AppendLine("CAT_NOME = @CAT_NOME ,");
                sql.AppendLine("CAT_DESCRICAO = @CAT_DESCRICAO ");
                sql.AppendLine("WHERE CAT_CODIGO = @CAT_CODIGO");

                command = new SqlCommand(sql.ToString(), connection);
                command.Parameters.AddWithValue("@CAT_NOME", pSISCategoriaTO.CAT_NOME);
                command.Parameters.AddWithValue("@CAT_DESCRICAO", pSISCategoriaTO.CAT_DESCRICAO);
                command.Parameters.AddWithValue("@CAT_CODIGO", pSISCategoriaTO.CAT_CODIGO);

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

        internal bool Delete(SISCategoria_TO pSISCategoriaTO)
        {

            bool retorno = false;

            SqlConnection connection = null;

            try
            {
                connection = new SqlConnection(UtilConexion.GetConnectionString("strConexao"));
                connection.Open();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


            SqlCommand command = null;
            StringBuilder sql = new StringBuilder();
            try
            {

                sql.AppendLine("DELETE TOP (1) FROM CATEGORIA ");
                sql.AppendLine(" WHERE CAT_CODIGO = @CAT_CODIGO ");

                command = new SqlCommand(sql.ToString(), connection);
                command.Parameters.AddWithValue("@CAT_CODIGO", pSISCategoriaTO.CAT_CODIGO);

                command.ExecuteNonQuery();

                retorno = true;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                command.Dispose();
                connection.Close();
                connection.Dispose();

            }

            return retorno;
        }

        internal DataTable GetCategoriaProduto(SISCategoria_TO pSISCategoriaTO)
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

            if (pSISCategoriaTO.tag.Equals("PopularGridCategoria"))
            {
                sql.Append(" SELECT ");
                sql.Append(" CAT_NOME, CAT_DESCRICAO , CAT_CODIGO ");
                sql.AppendFormat(" FROM CATEGORIA  ");
            }
            if (pSISCategoriaTO.tag.Equals("PopularLookupCategoria"))
            {
                sql.Append(" SELECT ");
                sql.Append(" CAT_CODIGO, (CAST(CAT_CODIGO AS CHAR(3)) + ' -' + CAT_NOME) AS CAT_NOME ");
                sql.AppendFormat(" FROM CATEGORIA  ");
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
    }
}
