using System;
namespace OrcamentoDesignPatterns.Investimentos
{
    public class Arrojado : Investimento
    {
        public double RetornoInvestido(double valorInvestido)
        {
            int resultado = new Random().Next(101);
            double retorno = 0;
            switch (resultado)
            {
                case int n when (n <= 20):
                    retorno = valorInvestido * 0.05;
                    break;

                case int n when (n > 20 && n <= 50):
                    retorno = valorInvestido * 0.03;
                    break;

                default:
                    retorno = valorInvestido * 0.006;
                    break;
            }

            return retorno;
        }
    }
}

