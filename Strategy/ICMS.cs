using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class ICMS : IImposto
    {
        public double CalcularImposto(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }
    }
}
