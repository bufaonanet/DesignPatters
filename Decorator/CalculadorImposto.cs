using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class CalculadorImposto
    {
        public static void RealizaCalculo(Orcamento orcamento, Imposto imposto)
        {
            var valor = imposto.Calcular(orcamento);

            Console.WriteLine($"O imposto do orçamento é : {valor}");
        }
    }
}
