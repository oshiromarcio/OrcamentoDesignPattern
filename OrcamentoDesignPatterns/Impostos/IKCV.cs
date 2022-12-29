using System;
using OrcamentoDesignPatterns.Orcamentos;

namespace OrcamentoDesignPatterns.Impostos
{
	public class IKCV : TemplateImpostoCondicional
    {
        public IKCV() : base() { }
        public IKCV(Imposto outroImposto) : base(outroImposto) { }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1 + this.CalculoOutroImposto(orcamento);
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06 + this.CalculoOutroImposto(orcamento);
        }

        protected override bool UsaMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && this.TemItemMaiorValor100Reais(orcamento);
        }

        private bool TemItemMaiorValor100Reais(Orcamento orcamento)
        {
            foreach(Item item in orcamento.Itens)
            {
                if (item.Valor > 100) return true;
            }

            return false;
        }
    }
}

