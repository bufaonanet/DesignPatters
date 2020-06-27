using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    interface IImposto
    {        
        double CalcularImposto(Orcamento orcamento);
    }
}
