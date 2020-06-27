using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            var orcamento = new Orcamento(100.00);

            CalculadorImposto.RealizaCalculo(orcamento, new ICMS());
            CalculadorImposto.RealizaCalculo(orcamento, new ISS());
        }
    }
}
