using System;

namespace OrcamentoDesignPatterns.ContaFormatoRequisicao
{
	public class FiltroSaldoMaior500Mil : Filtro
	{
		public FiltroSaldoMaior500Mil() : base() { }
        public FiltroSaldoMaior500Mil(Filtro outroFiltro) : base(outroFiltro) { }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            List<Conta> contasSaldoMaior500Mil = new List<Conta>();
            foreach (Conta conta in contas)
            {
                if (conta.Saldo > 500000)
                    contasSaldoMaior500Mil.Add(conta);
            }
            foreach (Conta conta in Proximo(contas))
            {
                contasSaldoMaior500Mil.Add(conta);
            }
            return contasSaldoMaior500Mil;
        }
    }
}

