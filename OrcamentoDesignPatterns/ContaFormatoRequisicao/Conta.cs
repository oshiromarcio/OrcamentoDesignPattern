using System;
using System.Xml.Serialization;

namespace OrcamentoDesignPatterns.ContaFormatoRequisicao
{
	public class Conta
	{
        [XmlAttribute]
        public double Saldo { get; private set; }
        [XmlAttribute]
        public string NomeTitular { get; set; }
		[XmlAttribute]
		public DateTime DataAbertura { get; set; }
		public IStatusConta Status { get; private set; }

		public Conta(string nomeTitular)
		{
			this.NomeTitular = nomeTitular;
			this.DataAbertura = DateTime.Now.Date;
			this.Saldo = 0;
			this.Status = new StatusPositivo();
		}

		public void Deposita(double valor)
		{
			this.Status.Deposita(this, valor);
		}

		public void Retira(double valor)
		{
			try
            {
                this.Status.Retira(this, valor);
            }
			catch(Exception)
			{
				throw;
			}
		}

        public interface IStatusConta
        {
            void Deposita(Conta conta, double valor);
            void Retira(Conta conta, double valor);
        }

        public class StatusPositivo : IStatusConta
        {
            public void Deposita(Conta conta, double valor)
            {
                conta.Saldo += valor * 0.98;
                Console.WriteLine("Novo saldo: " + conta.Saldo);
            }

            public void Retira(Conta conta, double valor)
            {
                conta.Saldo -= valor;
                Console.WriteLine("Novo saldo: " + conta.Saldo);
                if (conta.Saldo < 0)
                    conta.Status = new StatusNegativo();
            }
        }

        public class StatusNegativo : IStatusConta
        {
            public void Deposita(Conta conta, double valor)
            {
                conta.Saldo += valor * 0.95;
                Console.WriteLine("Novo saldo: " + conta.Saldo);
                if (conta.Saldo >= 0)
                    conta.Status = new StatusPositivo();
            }

            public void Retira(Conta conta, double valor)
            {
                throw new Exception("Saldo negativo, não é possível fazer o saque.");
            }
        }
    }
}

