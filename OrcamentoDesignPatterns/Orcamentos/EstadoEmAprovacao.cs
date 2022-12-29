using System;
namespace OrcamentoDesignPatterns.Orcamentos
{
	public class EstadoEmAprovacao : IEstadoDeUmOrcamento
    {
        public bool DescontoAplicado { get; set; }

        public EstadoEmAprovacao()
		{
            this.DescontoAplicado = false;
		}

        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (this.DescontoAplicado)
                throw new Exception("Desconto de Estado Em Aprovação já aplicado.");
            orcamento.Valor -= orcamento.Valor * 0.05;
            this.DescontoAplicado = true;
        }

        public void Aprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new EstadoAprovado();
            this.DescontoAplicado = false;
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orcamento em aprovação não podem ir para finalizado diretamente");
        }

        public void Reprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new EstadoReprovado();
            this.DescontoAplicado = false;
        }
    }
}

