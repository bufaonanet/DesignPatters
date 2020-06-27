using State;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsability
{
    class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (AconteceuVendaCasada(orcamento))
            {
                return orcamento.Valor * 0.05;
            }
            else
            {
                return Proximo.Desconta(orcamento);
            }
        }

        private bool AconteceuVendaCasada(Orcamento orcamento)
        {
            return Existe(orcamento, "LAPIS") && Existe(orcamento, "CANETA");
        }

        private bool Existe(Orcamento orcamento, string nomeItem)
        {
            foreach (var item in orcamento.Itens)
            {
                if (nomeItem.ToUpper().Equals(item.Nome.ToUpper()))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
