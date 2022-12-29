using System;
namespace OrcamentoDesignPatterns.Orcamentos
{
	public class EstadoAprovado : IEstadoDeUmOrcamento
    {
        public bool DescontoAplicado { get; set; }

        public EstadoAprovado()
        {
            this.DescontoAplicado = false;
        }

        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (this.DescontoAplicado)
                throw new Exception("Desconto de Estado Aprovado já aplicado.");
            orcamento.Valor -= orcamento.Valor * 0.02;
            this.DescontoAplicado = true;
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está em estado de aprovação");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new EstadoFinalizado();
            this.DescontoAplicado = false;
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento está em estado de aprovação e não pode ser reprovado");
        }
    }
}

