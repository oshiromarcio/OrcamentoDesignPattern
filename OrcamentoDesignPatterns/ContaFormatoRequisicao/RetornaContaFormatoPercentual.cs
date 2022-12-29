using System;
namespace OrcamentoDesignPatterns.ContaFormatoRequisicao
{
	public class RetornaContaFormatoPercentual : IRetornaContaFormato
	{
        public IRetornaContaFormato Proximo { get; set; }

        public void RetornaConta(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.PORCENTO)
            {
                Console.WriteLine(conta.NomeTitular + "%" + conta.Saldo);
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

