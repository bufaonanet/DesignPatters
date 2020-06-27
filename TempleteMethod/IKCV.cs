using System;
using System.Collections.Generic;
using System.Text;

namespace TempleteMethod
{
    class IKCV : TempletaImpostoCondicional
    {
        protected override bool DeveUsarTaxacaoMaxima(Orcamento orcamento)
        {
            foreach (var item in orcamento.Itens)
            {
                if (item.Valor > 100)
                {
                    return true;
                }
            };
            return false;
        }       

        protected override double TaxacaoMinima(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13 + 100;
        }

        protected override double TaxacaoMaxima(Orcamento orcamento)
        {
            return orcamento.Valor * 0.10;
        }
    }
}
