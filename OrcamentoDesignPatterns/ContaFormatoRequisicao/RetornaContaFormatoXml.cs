using System;
using System.Xml.Serialization;

namespace OrcamentoDesignPatterns.ContaFormatoRequisicao
{
	public class RetornaContaFormatoXml : IRetornaContaFormato
	{

        public IRetornaContaFormato Proximo { get; set; }

        public void RetornaConta(Requisicao req, Conta conta)
        {
            if(req.Formato == Formato.XML)
            {
                var serializer = new XmlSerializer(conta.GetType());
                string result;
                using (var writer = new System.IO.StringWriter())
                {
                    serializer.Serialize(writer, conta);
                    result = writer.ToString();
                }
                Console.WriteLine(result);
            }
            else if (Proximo != null)
            {
                Proximo.RetornaConta(req, conta);
            }
            else
            {
                throw new Exception("Formato desconhecido.");
            }
        }
    }
}

