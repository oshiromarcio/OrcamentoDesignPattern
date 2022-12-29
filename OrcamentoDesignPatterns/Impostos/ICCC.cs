using System;
using OrcamentoDesignPatterns.Orcamentos;

namespace OrcamentoDesignPatterns.Impostos
{
    public class ICCC : Imposto
    {
        public ICCC() : base() { }
        public ICCC(Imposto outroImposto) : base(outroImposto) { }

        public override double RealizaCalculo(Orcamento orcamento)
        {
            double impostoIccc;
            switch (orcamento.Valor)
            {
                case double n when (n < 1000):
                    impostoIccc = orcamento.Valor * 0.05;
                    break;

                case double n when (n >= 1000 && n <= 3000):
                    impostoIccc = orcamento.Valor * 0.07;
                    break;

                default:
                    impostoIccc = orcamento.Valor * 0.08 + 30;
                    break;
            }

            return impostoIccc + this.CalculoOutroImposto(orcamento);
        }
    }
}

