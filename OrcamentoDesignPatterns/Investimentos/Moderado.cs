using System;
namespace OrcamentoDesignPatterns.Investimentos
{
	public class Moderado : Investimento
	{
        public double RetornoInvestido(double valorInvestido)
        {
            return new Random().Next(101) > 50 ? valorInvestido * 0.025 : valorInvestido * 0.007;
        }
    }
}

