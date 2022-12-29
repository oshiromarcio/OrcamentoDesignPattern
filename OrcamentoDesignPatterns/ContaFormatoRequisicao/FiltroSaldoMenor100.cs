using System;

namespace OrcamentoDesignPatterns.ContaFormatoRequisicao
{
	public class FiltroSaldoMenor100 : Filtro
	{
		public FiltroSaldoMenor100() : base() { }
        public FiltroSaldoMenor100(Filtro outroFiltro) : base(outroFiltro) { }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            List<Conta> contasSaldoMenor100 = new List<Conta>();
            foreach(Conta conta in contas)
            {
                if (conta.Saldo < 100)
                    contasSaldoMenor100.Add(conta);
            }
            foreach (Conta conta in Proximo(contas))
            {
                contasSaldoMenor100.Add(conta);
            }
            return contasSaldoMenor100;
        }
    }
}

