using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class Orcamento
    {
        public double Valor { get; private set; }

        public Orcamento(double valor)
        {
            Valor = valor;
        }
    }
}
