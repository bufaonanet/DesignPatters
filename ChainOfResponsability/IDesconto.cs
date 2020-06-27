using State;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsability
{
    interface IDesconto
    {
        public IDesconto Proximo { get; set; }
        public double Desconta(Orcamento orcamento);
    }
}
