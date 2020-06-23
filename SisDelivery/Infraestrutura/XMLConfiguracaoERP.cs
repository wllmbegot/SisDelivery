using System;
using System.Xml;

namespace SisDelivery.Infraestrutura
{
    public class XMLConfiguracaoERP
    {
        private static XMLConfiguracaoERP instance = null;
        private XmlDocument xmlDocument;
        private string ArquivoConfig = "\\Begoos.xml";
        public string pathArquivocfg;
        private XmlNode _Node;

        public XMLConfiguracaoERP(string pathArqcfg)
        {
            try
            {
                xmlDocument = new XmlDocument();
                pathArquivocfg = pathArqcfg;
                xmlDocument.Load(pathArqcfg + @ArquivoConfig);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public string GetParametro(string pPathArquivoConfiguracao, string pSeccaoPrincipal, string pSeccao, string pChave)
        {
            try
            {
                GetInstance(pPathArquivoConfiguracao);
                string xPathQuery = String.Format("/{0}/{1}/{2}", pSeccaoPrincipal, pSeccao, pChave);
                _Node = xmlDocument.SelectSingleNode(xPathQuery);
                if (_Node != null)
                    return xmlDocument.SelectSingleNode(xPathQuery).InnerText;
                else
                    return string.Empty;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static XMLConfiguracaoERP GetInstance(string pathArqcfg)
        {
            if (instance == null)
            {
                instance = new XMLConfiguracaoERP(pathArqcfg);
            }
            return instance;
        }

        public bool SalvarConfiguracao(string p_Node, string p_Chave, string p_Valor)
        {
            try
            {
                xmlDocument.Load(pathArquivocfg + ArquivoConfig);

                xmlDocument.SelectSingleNode(string.Format("//{0}/{1}", p_Node, p_Chave)).InnerText = p_Valor;

                xmlDocument.Save(pathArquivocfg + ArquivoConfig);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }


    }
}
