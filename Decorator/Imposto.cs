using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    abstract class Imposto
    {
        private readonly Imposto OutroImposto;

        protected Imposto()
        {
            OutroImposto = null;
        }
        protected Imposto(Imposto outroImposto)
        {
            OutroImposto = outroImposto;
        }

        public abstract double Calcular(Orcamento orcamento);

        protected double CalculoDoOutroImposto(Orcamento orcamento)
        {
            return (OutroImposto == null ? 0 : OutroImposto.Calcular(orcamento));            
        }
    }
}
