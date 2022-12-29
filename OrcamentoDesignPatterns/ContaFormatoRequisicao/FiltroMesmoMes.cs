using System;

namespace OrcamentoDesignPatterns.ContaFormatoRequisicao
{
	public class FiltroMesmoMes : Filtro
	{
		public FiltroMesmoMes() : base() { }
        public FiltroMesmoMes(Filtro outroFiltro) : base(outroFiltro) { }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            List<Conta> contasMesmoMes = new List<Conta>();
            foreach (Conta conta in contas)
            {
                if (conta.DataAbertura > (DateTime.Now.Date.AddDays(-30)))
                    contasMesmoMes.Add(conta);
            }
            foreach (Conta conta in Proximo(contas))
            {
                contasMesmoMes.Add(conta);
            }
            return contasMesmoMes;
        }
    }
}

