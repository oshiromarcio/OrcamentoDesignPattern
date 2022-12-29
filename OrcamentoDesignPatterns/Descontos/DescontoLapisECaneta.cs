using System;
using OrcamentoDesignPatterns.Orcamentos;

namespace OrcamentoDesignPatterns.Descontos
{
	public class DescontoLapisECaneta : IDesconto
	{
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            bool existeLapis = false;
            bool existeCaneta = false;

            foreach(Item item in orcamento.Itens)
            {
                existeLapis = item.Nome.Contains("LAPIS") ? true : false;
                existeCaneta = item.Nome.Contains("CANETA") ? true : false;
            }

            return existeLapis && existeCaneta ? orcamento.Valor * 0.05 : Proximo.Desconta(orcamento);
        }
    }
}

