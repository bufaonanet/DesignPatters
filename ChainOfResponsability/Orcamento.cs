using ChainOfResponsability;
using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class Orcamento
    {
        public IList<Item> Itens { get; private set; }
        public double Valor { get; private set; }

        public Orcamento(double valor)
        {
            Valor = valor;
            Itens = new List<Item>();
        }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }
    }
}
