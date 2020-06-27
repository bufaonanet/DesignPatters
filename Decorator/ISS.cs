﻿using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class ISS : Imposto
    {
        public ISS() { }
        public ISS(Imposto outroImposto) : base(outroImposto)
        {
        }
        public override double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05 + CalculoDoOutroImposto(orcamento);
        }
        
    }
}
