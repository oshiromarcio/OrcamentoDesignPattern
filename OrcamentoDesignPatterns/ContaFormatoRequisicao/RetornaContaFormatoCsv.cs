using System;
namespace OrcamentoDesignPatterns.ContaFormatoRequisicao
{
	public class RetornaContaFormatoCsv : IRetornaContaFormato
	{
        public IRetornaContaFormato Proximo { get; set; }

        public void RetornaConta(Requisicao req, Conta conta)
        {
            if(req.Formato == Formato.CSV)
            {
                string resultado = conta.NomeTitular + ";" + conta.Saldo;
                Console.WriteLine(resultado);
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

