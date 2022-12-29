using System;
using OrcamentoDesignPatterns.Orcamentos;

namespace OrcamentoDesignPatterns.Descontos
{
	public class DescontoPorCincoItens : IDesconto
	{
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            return orcamento.Itens.Count > 5 ? orcamento.Valor * 0.1 : Proximo.Desconta(orcamento);
        }
    }
}

