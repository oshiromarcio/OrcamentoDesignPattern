using System;
namespace OrcamentoDesignPatterns.ContaFormatoRequisicao
{
	public abstract class Filtro
    {
        public Filtro? OutroFiltro { get; set; }

        public Filtro() { }
        public Filtro(Filtro outroFiltro)
        {
            this.OutroFiltro = outroFiltro;
        }

        public abstract IList<Conta> Filtra(IList<Conta> contas);

        protected IList<Conta> Proximo(IList<Conta> contas)
        {
            if (this.OutroFiltro != null)
                return this.OutroFiltro.Filtra(contas);
            return new List<Conta>();
        }
    }
}

