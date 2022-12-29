using System;
using OrcamentoDesignPatterns.Orcamentos;

namespace OrcamentoDesignPatterns.Impostos
{
	public class IMA : Imposto
	{
		public IMA() : base() { }
        public IMA(Imposto outroImposto) : base(outroImposto) { }

        public override double RealizaCalculo(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.2) + this.CalculoOutroImposto(orcamento);
        }
    }
}

