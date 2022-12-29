using System;
namespace OrcamentoDesignPatterns.Orcamentos
{
	public class EstadoReprovado : IEstadoDeUmOrcamento
    {
        public bool DescontoAplicado { get; set; }

        public EstadoReprovado()
		{
		}

        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos reprovados não recebem desconto extra!");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento está em estado de reprovação e não pode ser aprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento está em estado de finalizado e não pode ser reprovado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está em estado de reprovação");
        }
    }
}

