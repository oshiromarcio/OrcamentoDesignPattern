using System;
using OrcamentoDesignPatterns.Orcamentos;

namespace OrcamentoDesignPatterns.Descontos
{
	public class CalculadorDeDescontos
	{
		public double Calcula(Orcamento orcamento)
		{
			IDesconto d1 = new DescontoPorCincoItens();
			IDesconto d2 = new DescontoPorMaisDeQuinhentosReais();
			IDesconto d3 = new DescontoLapisECaneta();
			IDesconto dl = new SemDesconto();

			d1.Proximo = d2;
			d2.Proximo = d3;
			d3.Proximo = dl;
			return d1.Desconta(orcamento);
		}
	}
}

