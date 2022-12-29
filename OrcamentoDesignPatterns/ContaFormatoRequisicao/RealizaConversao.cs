using System;
namespace OrcamentoDesignPatterns.ContaFormatoRequisicao
{
	public class RealizaConversao
	{
		public void RetornaFormato(Conta conta, Formato formato)
        {
            Requisicao req = new Requisicao(formato);
            IRetornaContaFormato xml = new RetornaContaFormatoXml();
            IRetornaContaFormato csv = new RetornaContaFormatoCsv();
            IRetornaContaFormato percentual = new RetornaContaFormatoPercentual();

            xml.Proximo = csv;
            csv.Proximo = percentual;
            xml.RetornaConta(req, conta);
        }
	}
}

