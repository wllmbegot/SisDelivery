using System;
using System.Text;
using System.Data.SqlClient;
using SisDelivery.Infraestrutura;
using SisDelivery.TO;

namespace SisDelivery.DAO
{
    internal class SISItemPedido_DAO
    {

        internal bool Save(SISItemPedido_TO pSISItemPedido_TO)
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

            sql.AppendLine("INSERT INTO ITEM_PEDIDO ");
            sql.AppendLine("VALUES (@PED_CODIGO");
            sql.AppendLine(",@PRO_CODIGO");
            sql.AppendLine(",@ITE_ADICIONAL");
            sql.AppendLine(",@COMP_ITENS");
            sql.AppendLine(",@ITE_OBS)");

            sql.Append("SELECT @@IDENTITY AS 'ULTIMO_ITE_CODIGO'");

            try
            {
                command = new SqlCommand(sql.ToString(), connection);
                command.Parameters.AddWithValue("@PED_CODIGO", pSISItemPedido_TO.PED_CODIGO);
                command.Parameters.AddWithValue("@PRO_CODIGO", pSISItemPedido_TO.PRO_CODIGO);
                command.Parameters.AddWithValue("@ITE_ADICIONAL", pSISItemPedido_TO.ITE_ADICIONAL ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@COMP_ITENS", pSISItemPedido_TO.COMP_ITENS ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@ITE_OBS", pSISItemPedido_TO.ITE_OBS ?? (object)DBNull.Value);

                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    pSISItemPedido_TO.ITE_CODIGO = Convert.ToInt32(reader["ULTIMO_ITE_CODIGO"]);
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

        internal bool Delete(SISItemPedido_TO pSISItemPedido_TO)
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

                sql.AppendLine("IF EXISTS (SELECT * FROM Item_Pedido WHERE ITE_ADICIONAL = @ITE_CODIGO) ");
                sql.AppendLine("BEGIN ");
                sql.AppendLine("DELETE Item_Pedido WHERE ITE_ADICIONAL IN (SELECT ITE_CODIGO FROM Item_Pedido WHERE ITE_ADICIONAL = @ITE_CODIGO ) ");
                sql.AppendLine("END ");
                sql.AppendLine("ELSE ");
                sql.AppendLine("BEGIN ");
                sql.AppendLine("DELETE TOP (1) FROM ITEM_PEDIDO WHERE PED_CODIGO = @PED_CODIGO AND ITE_CODIGO = @ITE_CODIGO ");
                sql.AppendLine("END ");


                command = new SqlCommand(sql.ToString(), connection);
                command.Parameters.AddWithValue("@ITE_CODIGO", pSISItemPedido_TO.ITE_CODIGO);
                command.Parameters.AddWithValue("@PED_CODIGO", pSISItemPedido_TO.PED_CODIGO);

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

        internal bool UpDate(SISItemPedido_TO pSISItemPedidoTO)
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
                sql.AppendLine(" UPDATE ITEMPEDIDO SET");
                sql.AppendLine(" ITE_ADICIONAL = @ITE_ADICIONAL");
                sql.AppendLine(" WHERE ITE_CODIGO = @ITE_CODIGO ");

                command = new SqlCommand(sql.ToString(), connection);
                command.Parameters.AddWithValue("@ITE_ADICIONAL", pSISItemPedidoTO.ITE_ADICIONAL);
                command.Parameters.AddWithValue("@ITE_CODIGO", pSISItemPedidoTO.ITE_CODIGO);
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
