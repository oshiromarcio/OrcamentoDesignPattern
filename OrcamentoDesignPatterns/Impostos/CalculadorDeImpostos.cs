using System;
using OrcamentoDesignPatterns.Impostos;
using OrcamentoDesignPatterns.Orcamentos;

namespace OrcamentoDesignPatterns
{
    public class CalculadorDeImpostos
    {
        public double Calcula(Orcamento orcamento, Imposto imposto)
        {
            return imposto.RealizaCalculo(orcamento);
        }
    }
}

