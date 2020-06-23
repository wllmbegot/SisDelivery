using System;
using SisDelivery.DAO;
using SisDelivery.Infraestrutura;
using SisDelivery.TO;
using System.Data;

namespace SisDelivery.BO
{
    public class SISCategoria_BO
    {
        public bool Save(SISCategoria_TO pCategoriaTO, bool pOpcao)
        {
            bool lresultado = false;

            try
            {

                using (var transacao = TransactionScopeDefault.CreateTransactionScope())
                {

                    if (pCategoriaTO.tag != null)
                    {

                        if (pCategoriaTO.tag.Equals("SalvarCategoria"))
                        {
                            new SISCategoria_DAO().Save(pCategoriaTO);

                        }

                        if (pCategoriaTO.tag.Equals("AtualizaCategoria"))
                        {
                            new SISCategoria_DAO().UpDate(pCategoriaTO);
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
        
        public bool Delete(SISCategoria_TO pSISCategoriaTO, bool pOpcao)
        {
            bool lresultado = false;

            try
            {
                using (var transacao = TransactionScopeDefault.CreateTransactionScope())
                {

                    if (pSISCategoriaTO.tag != null)
                    {

                        if (pSISCategoriaTO.tag.Equals("tag_ExcluirCategoria"))
                        {
                            new SISCategoria_DAO().Delete(pSISCategoriaTO);

                        }
                        if (pSISCategoriaTO.tag.Equals("tag_ExcluirItem"))
                        {
                            new SISCategoria_DAO().Delete(pSISCategoriaTO);

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

        public DataTable GetCategoria(SISCategoria_TO pSISCategoriaTO)
        {

            if (!string.IsNullOrEmpty(pSISCategoriaTO.tag))
            {
                if (pSISCategoriaTO.tag.Equals("PopularComboBoxCategoria"))
                {

                }

                else if (pSISCategoriaTO.tag.Equals("PopularCoqmboBoxCategoria"))
                {

                }

            }

            return new SISCategoria_DAO().GetCategoriaProduto(pSISCategoriaTO);
        }



    }
}
