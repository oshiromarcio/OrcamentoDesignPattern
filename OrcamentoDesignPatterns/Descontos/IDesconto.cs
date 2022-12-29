using System;
using OrcamentoDesignPatterns.Orcamentos;

namespace OrcamentoDesignPatterns.Descontos
{
	public interface IDesconto
	{
		IDesconto Proximo { get; set; }

		double Desconta(Orcamento orcamento);
	}
}
