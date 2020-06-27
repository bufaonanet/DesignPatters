using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class CalculadorImposto
    {
        public static void RealizaCalculo(Orcamento orcamento, IImposto imposto)
        {
            var valor = imposto.CalcularImposto(orcamento);

            Console.WriteLine($"O imposto do orçamento é : {valor}");
        }
    }
}
