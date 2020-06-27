using System;
using System.Collections.Generic;

namespace TempleteMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Orcamento orcamento = new Orcamento(100.00);
            orcamento.Itens.Add(new Item { Valor = 250.00, Nome = "Impressora" });
            orcamento.Itens.Add(new Item { Valor = 1050.00, Nome = "notebook" });
            orcamento.Itens.Add(new Item { Valor = 1050.00, Nome = "notebook" });

            IHIT ikcv = new IHIT();
            var imposto = ikcv.CalcularImposto(orcamento);

            Console.WriteLine(imposto);

        }
    }
}
