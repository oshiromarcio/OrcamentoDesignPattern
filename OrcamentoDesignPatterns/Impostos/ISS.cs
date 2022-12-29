using System;
using OrcamentoDesignPatterns.Orcamentos;

namespace OrcamentoDesignPatterns.Impostos
{
    public class ISS : Imposto
    {
        public ISS() : base() { }
        public ISS(Imposto outroImposto) : base(outroImposto) { }

        public override double RealizaCalculo(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06 + this.CalculoOutroImposto(orcamento);
        }
    }
}

