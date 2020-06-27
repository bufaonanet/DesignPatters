using State;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsability
{
    class DescontoPorMaisDeQuinhentosReais : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            // verifica segunda regra de possível desconto
            if (orcamento.Valor >= 1000.00)
            {
                return orcamento.Valor * 0.07;
            }
            else
            {
                return Proximo.Desconta(orcamento);
            }

        }
    }
}
