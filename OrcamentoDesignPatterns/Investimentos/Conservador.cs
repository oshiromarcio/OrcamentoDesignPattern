using System;
namespace OrcamentoDesignPatterns.Investimentos
{
	public class Conservador : Investimento
	{
        public double RetornoInvestido(double valorInvestido)
        {
            return valorInvestido * 0.008;
        }
    }
}

