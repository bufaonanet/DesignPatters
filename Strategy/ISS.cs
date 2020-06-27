using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class ISS : IImposto
    {
        public double CalcularImposto(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
    }
}
