using SisDelivery.DAO;
using SisDelivery.Infraestrutura;
using SisDelivery.TO;
using System;
using System.Data;

namespace SisDelivery.BO
{
    public class SISEstoque_BO
    {
        public bool Save(SISEstoque_TO pEstoqueTO, bool pOpcao)
        {
            bool lresultado = false;

            try
            {
                //SISCliente_TO SISClienteTO = new SISCliente_TO();
                //SISEndereco_TO SISEnderecoTO = new SISEndereco_TO();

                using (var transacao = TransactionScopeDefault.CreateTransactionScope())
                {

                    if (pEstoqueTO.tag != null)
                    {

                        if (pEstoqueTO.tag.Equals("ProdNovoEstoque"))
                        {
                            new SISEstoque_DAO().Save(pEstoqueTO);

                        }

                        if (pEstoqueTO.tag.Equals("ProdAtualizarEstoque"))
                        {
                            new SISEstoque_DAO().UpDate(pEstoqueTO);
                        }

                        //if (pEstoqueTO.tag.Equals("ExcluirProduto"))
                        //{
                        //    new SISEstoque_DAO().Delete(pEstoqueTO);
                        //}

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

        public DataTable GetEstoque(SISEstoque_TO pSISEstoqueTO)
        {

            if (!string.IsNullOrEmpty(pSISEstoqueTO.tag))
            {
                if (pSISEstoqueTO.tag.Equals("PopularGridEstoque"))
                {
                    //pSISPedidoTO.query = " AND EMP_STATUS = 'A' ";
                    //pSISEstoqueTO.PED_CODIGO = pSISEstoqueTO.PED_CODIGO; 
                }
                if (pSISEstoqueTO.tag.Equals("PopularItemEstoque"))
                {
                    pSISEstoqueTO.query = string.Format(" WHERE P.PRO_CODIGO = '{0}' ", pSISEstoqueTO.SISProdutoTO.PRO_CODIGO);
                }
            }

            return new SISEstoque_DAO().GetEstoqueProduto(pSISEstoqueTO);
            //return new SISPedido_DAO().GetPedidoItem(pSISPedidoTO);
        }

    }
}
