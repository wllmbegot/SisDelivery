using System;
using SisDelivery.DAO;
using SisDelivery.Infraestrutura;
using System.Data;
using SisDelivery.TO;

namespace SisDelivery.BO
{
    public class SISProduto_BO
    {
        public bool Save(SISProduto_TO pProdutoTO, bool pOpcao)
        {
            bool lresultado = false;

            try
            {
                //SISCliente_TO SISClienteTO = new SISCliente_TO();
                //SISEndereco_TO SISEnderecoTO = new SISEndereco_TO();

                using (var transacao = TransactionScopeDefault.CreateTransactionScope())
                {

                    if (pProdutoTO.tag != null)
                    {

                        if (pProdutoTO.tag.Equals("ProdutoNovo"))
                        {
                            new SISProduto_DAO().Save(pProdutoTO);
                        }

                        if (pProdutoTO.tag.Equals("AlterarProduto"))
                        {
                            new SISProduto_DAO().UpDate(pProdutoTO);
                        }

                        if (pProdutoTO.tag.Equals("ExcluirProduto"))
                        {
                            new SISProduto_DAO().Delete(pProdutoTO);
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
        public bool Delete(SISProduto_TO pSISProdutoBO, bool pOpcao)
        {
            try
            {
                return new SISProduto_DAO().Delete(pSISProdutoBO);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable GetProdutos(SISProduto_TO pSISProdutoTO)
        {
            if (!string.IsNullOrEmpty(pSISProdutoTO.tag))
            {
                if (pSISProdutoTO.tag.Equals("PopGridCadProduto"))
                {
                    pSISProdutoTO.query = " AND EMP_STATUS = 'A' ";
                }

            }

            return new SISProduto_DAO().GetProdutos(pSISProdutoTO);
        }
        public DataTable GetProdutoAtivo(SISProduto_TO pSISProdutoTO)
        {
            if (!string.IsNullOrEmpty(pSISProdutoTO.tag))
            {
                if (pSISProdutoTO.tag.Equals("PopComboxProduto"))
                {
                    pSISProdutoTO.query = " ORDER BY PROD.CAT_CODIGO ";
                }
                if (pSISProdutoTO.tag.Equals("LookUpEstoqueProduto"))
                {
                    pSISProdutoTO.query = " WHERE EST.EST_CODIGO IS NULL ";
                }
                if (pSISProdutoTO.tag.Equals("PopularMenuProduto"))
                {

                }
                if (pSISProdutoTO.tag.Equals("PopularComboBoxProduto"))
                {

                }

            }

            return new SISProduto_DAO().GetProdutoAtivo(pSISProdutoTO);
        }


    }
}
