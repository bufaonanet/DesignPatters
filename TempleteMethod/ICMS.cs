﻿namespace TempleteMethod
{
    class ICMS : IImposto
    {
        public double CalcularImposto(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }
    }
}
