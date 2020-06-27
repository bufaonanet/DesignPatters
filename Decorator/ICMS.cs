using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class ICMS : Imposto
    {
        public ICMS() { }
        public ICMS(Imposto outroImposto) : base(outroImposto)
        {
        }

        public override double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1 + CalculoDoOutroImposto(orcamento);
        }
    }
}
