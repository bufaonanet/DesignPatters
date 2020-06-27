using System;
using System.Collections.Generic;
using System.Text;

namespace TempleteMethod
{
    class IHIT : TempletaImpostoCondicional
    {
        protected override bool DeveUsarTaxacaoMaxima(Orcamento orcamento)
        {
            var listaItens = new List<string>();

            foreach (var item in orcamento.Itens)
            {
                if (listaItens.Contains(item.Nome))
                    return true;
                else
                {
                    listaItens.Add(item.Nome);
                }
            }
            return false;
        }

        protected override double TaxacaoMaxima(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13 + 100;
        }

        protected override double TaxacaoMinima(Orcamento orcamento)
        {
            return orcamento.Valor * (0.01 * orcamento.Itens.Count);            
        }
    }
}
