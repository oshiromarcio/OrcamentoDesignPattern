using System;
namespace OrcamentoDesignPatterns.ContaFormatoRequisicao
{
	public enum Formato
	{
		XML,
		CSV,
		PORCENTO
	}

	public class Requisicao
	{
		public Formato Formato { get; private set; }

		public Requisicao(Formato formato)
		{
			this.Formato = formato;
		}
	}
}

