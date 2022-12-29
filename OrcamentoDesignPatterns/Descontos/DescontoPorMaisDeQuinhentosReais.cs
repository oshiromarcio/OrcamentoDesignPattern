using System;
using OrcamentoDesignPatterns.Orcamentos;

namespace OrcamentoDesignPatterns.Descontos
{
    public class DescontoPorMaisDeQuinhentosReais : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            return orcamento.Valor > 500 ? orcamento.Valor * 0.07 : Proximo.Desconta(orcamento);
        }
    }
}

