using System;
using OrcamentoDesignPatterns.Orcamentos;

namespace OrcamentoDesignPatterns.Impostos
{
    // TEMPLATE METHOD
    public abstract class TemplateImpostoCondicional : Imposto
    {
        public TemplateImpostoCondicional() : base() { }
        public TemplateImpostoCondicional(Imposto outroImposto) : base(outroImposto) { }

        protected abstract bool UsaMaximaTaxacao(Orcamento orcamento);
        protected abstract double MaximaTaxacao(Orcamento orcamento);
        protected abstract double MinimaTaxacao(Orcamento orcamento);

        public override double RealizaCalculo(Orcamento orcamento)
        {
            if (UsaMaximaTaxacao(orcamento))
            {
                return MaximaTaxacao(orcamento);
            }
            return MinimaTaxacao(orcamento);
        }
    }
}

