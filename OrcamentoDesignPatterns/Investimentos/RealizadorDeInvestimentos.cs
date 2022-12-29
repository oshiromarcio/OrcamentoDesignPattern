using System;
namespace OrcamentoDesignPatterns.Investimentos
{
	public class RealizadorDeInvestimentos
	{
		public double Retorno(double valorInvestido, Investimento tipoInvestimento)
		{
			// retorno do investimento após o IR de 25%
			return tipoInvestimento.RetornoInvestido(valorInvestido) * 0.75;
		}
	}
}

