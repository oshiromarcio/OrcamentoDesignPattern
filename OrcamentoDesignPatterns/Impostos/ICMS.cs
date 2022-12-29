using System;
using OrcamentoDesignPatterns.Orcamentos;

namespace OrcamentoDesignPatterns.Impostos
{
    public class ICMS : Imposto
    {
        public ICMS() : base() { }
        public ICMS(Imposto outroImposto) : base(outroImposto) { }

        public override double RealizaCalculo(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.05) + 50 + this.CalculoOutroImposto(orcamento);
        }
    }
}

