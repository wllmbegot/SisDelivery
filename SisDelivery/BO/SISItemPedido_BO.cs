using SisDelivery.DAO;
using SisDelivery.Infraestrutura;
using SisDelivery.TO;
using System;

namespace SisDelivery.BO
{
    public class SISItemPedido_BO
    {
        public bool Save(SISItemPedido_TO pItemPedidoTO, bool pOpcao)
        {
            bool lresultado = false;

            try
            {
                using (var transacao = TransactionScopeDefault.CreateTransactionScope())
                {

                    if (pItemPedidoTO.tag != null)
                    {
                        if (pItemPedidoTO.tag.Equals("ItemNovo"))
                        {

                            new SISItemPedido_DAO().Save(pItemPedidoTO);
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

        public bool Delete(SISItemPedido_TO pSISItemPedidoTO, bool pOpcao)
        {
            bool lresultado = false;

            try
            {
                using (var transacao = TransactionScopeDefault.CreateTransactionScope())
                {

                    if (pSISItemPedidoTO.tag != null)
                    {

                        if (pSISItemPedidoTO.tag.Equals("ExcluirItemDrag"))
                        {
                            new SISItemPedido_DAO().Delete(pSISItemPedidoTO);

                        }
                        if (pSISItemPedidoTO.tag.Equals("tag_ExcluirItem"))
                        {
                            new SISItemPedido_DAO().Delete(pSISItemPedidoTO);

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

        public bool Update(SISItemPedido_TO pSISItemPedidoTO, bool pOpcao)
        {
            bool lresultado = false;

            try
            {
                using (var transacao = TransactionScopeDefault.CreateTransactionScope())
                {
                    if (pSISItemPedidoTO.tag != null)
                    {
                        if (pSISItemPedidoTO.tag.Equals("tag_AtualizarCodItemNovo"))
                        {
                            new SISItemPedido_DAO().UpDate(pSISItemPedidoTO);
                        }

                        if (pSISItemPedidoTO.tag.Equals("AlterarProduto"))
                        {
                            //new SISProduto_DAO().UpDate(pSISPedidoTO);
                        }

                        if (pSISItemPedidoTO.tag.Equals("ExcluirProduto"))
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
    }
}
