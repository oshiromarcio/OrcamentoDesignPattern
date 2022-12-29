using System;
namespace OrcamentoDesignPatterns.Orcamentos
{
	public class EstadoFinalizado : IEstadoDeUmOrcamento
    {
        public bool DescontoAplicado { get; set; }

        public EstadoFinalizado()
		{
		}

        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos finalizados não recebem desconto extra!");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento está em estado de finalizado e não pode ser aprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está em estado finalizado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento está em estado de finalizado e não pode ser reprovado");
        }
    }
}

