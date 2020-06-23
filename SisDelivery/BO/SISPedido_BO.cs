using SisDelivery.DAO;
using SisDelivery.Infraestrutura;
using SisDelivery.TO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisDelivery.BO
{
    public class SISPedido_BO
    {
        public bool Save(SISPedido_TO pPedidoTO, bool pOpcao)
        {
            bool lresultado = false;

            try
            {
                using (var transacao = TransactionScopeDefault.CreateTransactionScope())
                {

                    if (pPedidoTO.tag != null)
                    {

                        if (pPedidoTO.tag.Equals("PedidoNovo"))
                        {
                            new SISPedido_DAO().Save(pPedidoTO);
                        }
                        if (pPedidoTO.tag.Equals("PedidoAberto"))
                        {
                            pPedidoTO.query = string.Format("WHERE PED_STATUS = 'ATENDIMENTO'");

                            new SISPedido_DAO().GetPedidoAberto(pPedidoTO);
                        }

                    }

                    transacao.Complete();
                    lresultado = true;

                }

            }
            catch (Exception)
            {

                throw;
            }

            return lresultado;
        }

        public bool Update(SISPedido_TO pSISPedidoTO, bool pOpcao)
        {
            bool lresultado = false;

            try
            {
                using (var transacao = TransactionScopeDefault.CreateTransactionScope())
                {
                    if (pSISPedidoTO.tag != null)
                    {
                        if (pSISPedidoTO.tag.Equals("tag_FecharPedido"))
                        {
                            new SISPedido_DAO().UpDate(pSISPedidoTO);
                        }

                        if (pSISPedidoTO.tag.Equals("AlterarProduto"))
                        {
                            //new SISProduto_DAO().UpDate(pSISPedidoTO);
                        }

                        if (pSISPedidoTO.tag.Equals("ExcluirProduto"))
                        {
                            //new SISProduto_DAO().Delete(pSISPedidoTO);
                        }
                    }
                    transacao.Complete();
                    lresultado = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return lresultado;
        }

        public DataTable GetPedido(SISPedido_TO pSISPedidoTO)
        {
            if (!string.IsNullOrEmpty(pSISPedidoTO.tag))
            {
                if (pSISPedidoTO.tag.Equals("ResumoPedidoItem"))
                {
                    pSISPedidoTO.PED_CODIGO = pSISPedidoTO.PED_CODIGO;
                }
            }
            return new SISPedido_DAO().GetPedidoItem(pSISPedidoTO);
        }
    }
}
