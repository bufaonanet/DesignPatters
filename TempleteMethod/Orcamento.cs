using System.Collections.Generic;

namespace TempleteMethod
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
