﻿using System;
using OrcamentoDesignPatterns.Orcamentos;

namespace OrcamentoDesignPatterns.Descontos
{
    public class SemDesconto : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            return 0;
        }
    }
}

