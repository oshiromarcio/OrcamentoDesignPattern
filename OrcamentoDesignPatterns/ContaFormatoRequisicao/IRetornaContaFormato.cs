using System;
namespace OrcamentoDesignPatterns.ContaFormatoRequisicao
{
	public interface IRetornaContaFormato
	{
		IRetornaContaFormato Proximo { get; set; }

		void RetornaConta(Requisicao req, Conta conta);
	}
}

