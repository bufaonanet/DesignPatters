using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto iss = new ICMS(new ICMS());

            Orcamento orcamento = new Orcamento(100);

            var valor = iss.Calcular(orcamento);


            Console.WriteLine("Valor do imposto é " + valor);
        }
    }
}
