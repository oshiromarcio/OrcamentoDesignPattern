using System;
namespace OrcamentoDesignPatterns.Orcamentos
{
    public class Orcamento
    {
        public double Valor { get; set; }
        public IList<Item> Itens { get; private set; }
        public IEstadoDeUmOrcamento EstadoAtual { get; set; }

        public Orcamento()
        {
            this.Valor = 0;
            this.Itens = new List<Item>();
            this.EstadoAtual = new EstadoEmAprovacao();
        }

        public void AdicionaItem(Item item)
        {
            this.Itens.Add(item);
            this.Valor += item.Valor;
        }

        public void AplicaDescontoExtra()
        {
            this.EstadoAtual.AplicaDescontoExtra(this);
        }

        public void Aprova()
        {
            this.EstadoAtual = new EstadoAprovado();
        }

        public void Reprova()
        {
            this.EstadoAtual = new EstadoReprovado();
        }

        public void Finaliza()
        {
            this.EstadoAtual = new EstadoFinalizado();
        }
    }
}

