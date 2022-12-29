using System;
using OrcamentoDesignPatterns.Orcamentos;

namespace OrcamentoDesignPatterns.Impostos
{
    public class IHIT : TemplateImpostoCondicional
    {
        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.13) + 100;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * (0.01 * orcamento.Itens.Count);
        }

        protected override bool UsaMaximaTaxacao(Orcamento orcamento)
        {
            foreach (Item primeiroItem in orcamento.Itens)
            {
                foreach (Item segundoItem in orcamento.Itens)
                {
                    if (primeiroItem.Nome == segundoItem.Nome) return true;
                }
            }

            return false;
        }
    }
}

