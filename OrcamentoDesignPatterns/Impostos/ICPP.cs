using System;
using OrcamentoDesignPatterns.Orcamentos;

namespace OrcamentoDesignPatterns.Impostos
{
    public class ICPP : TemplateImpostoCondicional
    {
        public ICPP() : base() { }
        public ICPP(Imposto outroImposto) : base(outroImposto) { }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07 + this.CalculoOutroImposto(orcamento);
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05 + this.CalculoOutroImposto(orcamento);
        }

        protected override bool UsaMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor >= 500;
        }
    }
}

