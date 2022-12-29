using System;
namespace OrcamentoDesignPatterns.Orcamentos
{
	public interface IEstadoDeUmOrcamento
	{
		public bool DescontoAplicado { get; set; }
		void AplicaDescontoExtra(Orcamento orcamento);
		void Aprova(Orcamento orcamento);
        void Reprova(Orcamento orcamento);
        void Finaliza(Orcamento orcamento);
    }
}
