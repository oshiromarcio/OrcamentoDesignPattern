// See https://aka.ms/new-console-template for more information
using OrcamentoDesignPatterns;
using OrcamentoDesignPatterns.Orcamentos;
using OrcamentoDesignPatterns.ContaFormatoRequisicao;
using OrcamentoDesignPatterns.Descontos;
using OrcamentoDesignPatterns.Impostos;
using OrcamentoDesignPatterns.Investimentos;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Hello, World!");

            Orcamento orcamento = new Orcamento();
            orcamento.AdicionaItem(new Item("CANETA", 105));
            orcamento.AdicionaItem(new Item("NINTENDO SWITCH", 1650));
            orcamento.AdicionaItem(new Item("GAME MARIO KART 8 DELUXE", 260));
            orcamento.AdicionaItem(new Item("GAME ZELDA BOTW", 305));
            orcamento.AdicionaItem(new Item("GAME SUPER MARIO ODYSSEY", 230));
            /*
            Imposto iss = new ISS();
            Imposto icms = new ICMS();
            Imposto iccc = new ICCC();

            // PADRÃO STRATEGY
            CalculadorDeImpostos calculadoraImpostos = new CalculadorDeImpostos();
            double valorIss = calculadoraImpostos.Calcula(orcamento, iss);
            double valorIcms = calculadoraImpostos.Calcula(orcamento, icms);
            double valorIccc = calculadoraImpostos.Calcula(orcamento, iccc);
            Console.WriteLine("ISS: R$ " + valorIss);
            Console.WriteLine("ICMS: R$ " + valorIcms);
            Console.WriteLine("ICCC: R$ " + valorIccc);
            */
            // CHAIN OF RESPONSABILITY
            CalculadorDeDescontos calculadoraDescontos = new CalculadorDeDescontos();
            double desconto = calculadoraDescontos.Calcula(orcamento);
            Console.WriteLine("Total do Pedido: " + orcamento.Valor);
            Console.WriteLine("Desconto Total: " + desconto);

            // PADRÃO STRATEGY
            Investimento conservador = new Conservador();
            Investimento moderado = new Moderado();
            Investimento arrojado = new Arrojado();

            double valorInvestido = 3000;
            RealizadorDeInvestimentos invest = new RealizadorDeInvestimentos();
            double retornoConservador = invest.Retorno(valorInvestido, conservador);
            double retornoModerado = invest.Retorno(valorInvestido, moderado);
            double retornoArrojado = invest.Retorno(valorInvestido, arrojado);
            Console.WriteLine("Conservador: R$ " + retornoConservador);
            Console.WriteLine("Moderado: R$ " + retornoModerado);
            Console.WriteLine("Arrojado: R$ " + retornoArrojado);

            // CHAIN OF RESPONSABILITY
            /*Conta conta = new Conta("Neymar");
            conta.Deposita(1000000);
            RealizaConversao realiza = new RealizaConversao();
            realiza.RetornaFormato(conta, Formato.XML);*/

            // DECORATOR
            Console.WriteLine("Valor Orçamento: " + orcamento.Valor);
            Imposto impostoComplexo = new IKCV(new ICPP());
            double valorImpostoComplexo = impostoComplexo.RealizaCalculo(orcamento);
            Console.WriteLine("Decorator: R$ " + valorImpostoComplexo);

            Orcamento reforma = new Orcamento();
            reforma.AdicionaItem(new Item("CANETA", 105));
            reforma.AdicionaItem(new Item("NINTENDO SWITCH", 1650));
            reforma.AdicionaItem(new Item("GAME MARIO KART 8 DELUXE", 260));
            reforma.AdicionaItem(new Item("GAME ZELDA BOTW", 305));
            reforma.AdicionaItem(new Item("GAME SUPER MARIO ODYSSEY", 230));
            Console.WriteLine(reforma.Valor);
            // STATE PATTERN
            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor);
            reforma.Aprova();
            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor);
            reforma.Finaliza();

            Conta novaConta = new Conta("taki");
            novaConta.Deposita(300);
            novaConta.Deposita(50);
            novaConta.Retira(200);
            novaConta.Retira(200);
            novaConta.Retira(100);
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}