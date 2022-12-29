using System;
using OrcamentoDesignPatterns.Orcamentos;

namespace OrcamentoDesignPatterns.Impostos
{
    public abstract class Imposto
    {
        public Imposto? OutroImposto { get; set; }

        public Imposto()
        {
            this.OutroImposto = null;
        }

        public Imposto(Imposto outroImposto)
        {
            this.OutroImposto = outroImposto;
        }

        protected double CalculoOutroImposto(Orcamento orcamento)
        {
            if (this.OutroImposto == null) return 0;
            return this.OutroImposto.RealizaCalculo(orcamento);
        }

        public abstract double RealizaCalculo(Orcamento orcamento);
    }
}

