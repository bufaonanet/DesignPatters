using State;
using System;

namespace ChainOfResponsability
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Orcamento orcamento = new Orcamento(100.00);
            orcamento.AdicionaItem(new Item { Nome="Guitarra" , Valor = 500.00});
            orcamento.AdicionaItem(new Item { Nome="PS4" , Valor = 500.00});
            orcamento.AdicionaItem(new Item { Nome="lapi" , Valor = 500.00});
            orcamento.AdicionaItem(new Item { Nome="caneta" , Valor = 500.00});

            double desconto = CalculadorDeDesconto.Calcula(orcamento);

            Console.WriteLine("Desconto = " + desconto);
        }
    }
}
