using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SisDelivery.TO;
using SisDelivery.Infraestrutura;

namespace SisDelivery.DAO
{
    internal class SISPedido_DAO
    {
        internal bool Save(SISPedido_TO pSISPedido_TO)
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

            sql.AppendLine("INSERT INTO PEDIDO ");
            sql.AppendLine("VALUES (@PED_TOTAL");
            sql.AppendLine(",@PED_TROCO");
            sql.AppendLine(",@PED_ORDEM_ATENDIMENTO");
            sql.AppendLine(",@PED_CAD_DATA");
            sql.AppendLine(",@PED_STATUS");
            sql.AppendLine(" ,@PED_FRETE");
            sql.AppendLine(" ,@PAG_CODIGO)");

            sql.Append(" SELECT @@IDENTITY AS 'ULTIMO_PED_CODIGO'");

            try
            {
                command = new SqlCommand(sql.ToString(), connection);
                command.Parameters.AddWithValue("@PED_TOTAL", pSISPedido_TO.PED_TOTAL);
                command.Parameters.AddWithValue("@PED_TROCO", pSISPedido_TO.PED_TROCO ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@PED_ORDEM_ATENDIMENTO", pSISPedido_TO.PED_ORDEM_ATENDIMENTO);
                command.Parameters.AddWithValue("@PED_CAD_DATA", pSISPedido_TO.PED_CAD_DATA);
                command.Parameters.AddWithValue("@PED_STATUS", pSISPedido_TO.PED_STATUS);
                command.Parameters.AddWithValue("@PED_FRETE", pSISPedido_TO.PED_FRETE ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@PAG_CODIGO", pSISPedido_TO.PAG_CODIGO ?? (object)DBNull.Value);


                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    pSISPedido_TO.PED_CODIGO = Convert.ToInt32(reader["ULTIMO_PED_CODIGO"]);
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

        internal bool UpDate(SISPedido_TO pSISPedidoTO)
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
                sql.AppendLine(" UPDATE PEDIDO SET");
                sql.AppendLine(" PED_STATUS = @MESA_HIST_STATUS");
                sql.AppendLine(" ,PED_TOTAL = @PED_TOTAL");
                sql.AppendLine(" ,PED_TROCO = @PED_TROCO");
                sql.AppendLine(" ,PED_FRETE = @PED_FRETE");
                sql.AppendLine(" ,PAG_CODIGO = @PAG_CODIGO");
                sql.AppendLine(" WHERE PED_CODIGO = @PED_CODIGO ");

                command = new SqlCommand(sql.ToString(), connection);
                command.Parameters.AddWithValue("@PED_CODIGO", pSISPedidoTO.PED_CODIGO);
                command.Parameters.AddWithValue("@MESA_HIST_STATUS", pSISPedidoTO.PED_STATUS);
                command.Parameters.AddWithValue("@PED_TOTAL", pSISPedidoTO.PED_TOTAL);
                command.Parameters.AddWithValue("@PED_TROCO", pSISPedidoTO.PED_TROCO ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@PED_FRETE", pSISPedidoTO.PED_FRETE ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@PAG_CODIGO", pSISPedidoTO.PAG_CODIGO ?? (object)DBNull.Value);
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

        internal SISPedido_TO GetPedidoAberto(SISPedido_TO pSISPedidoTO)
        {
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
            SqlDataReader reader = null;

            sql.Append("SELECT PED_CODIGO ");
            sql.AppendFormat("FROM PEDIDO {0}", pSISPedidoTO.query);


            try
            {
                command = new SqlCommand(sql.ToString(), connection);


                reader = command.ExecuteReader();

                if (reader.Read())
                {

                    pSISPedidoTO.PED_CODIGO = Convert.ToInt32(reader["PED_CODIGO"]);

                }

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

            return pSISPedidoTO;
        }

        internal DataTable GetPedidoItem(SISPedido_TO pSISPedidoTO)
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

            if (pSISPedidoTO.tag.Equals("ResumoPedidoItem"))
            {
                sql.Append("SELECT * FROM PEDIDO ped ");
                sql.Append("INNER JOIN ITEM_PEDIDO ite ");
                sql.Append("ON ped.PED_CODIGO = ITE.PED_CODIGO ");
                sql.Append("INNER JOIN PRODUTO pro ");
                sql.Append("ON ITE.PRO_CODIGO = pro.PRO_CODIGO ");
                sql.AppendFormat("WHERE PED.PED_CODIGO = @PED_CODIGO ");
            }

            if (pSISPedidoTO.tag.Equals("GridResumoPedidoItem"))
            {
                sql.Append("SELECT pro.PRO_NOME as Item, CONVERT(MONEY, pro.PRO_VALOR) as Valor ");
                sql.Append("FROM PEDIDO ped ");
                sql.Append("INNER JOIN ITEM_PEDIDO ite ");
                sql.Append("ON ped.PED_CODIGO = ITE.PED_CODIGO ");
                sql.Append("INNER JOIN PRODUTO pro ");
                sql.Append("ON ITE.PRO_CODIGO = pro.PRO_CODIGO ");
                sql.AppendFormat("WHERE PED.PED_CODIGO = @PED_CODIGO ");
            }

            try
            {
                command = new SqlCommand(sql.ToString(), connection);
                command.Parameters.AddWithValue("@PED_CODIGO", pSISPedidoTO.PED_CODIGO);
                
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
