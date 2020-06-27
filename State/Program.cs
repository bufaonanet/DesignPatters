using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var reforma = new Orcamento(100);
                reforma.AplicaDescontoExtra();
                Console.WriteLine("Valor: " + reforma.Valor);

                reforma.Aprova();
                reforma.AplicaDescontoExtra();
                Console.WriteLine("Valor: " + reforma.Valor);

                reforma.Finaliza();
                reforma.AplicaDescontoExtra();
                Console.WriteLine("Valor: " + reforma.Valor);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); 
            }
            


        }
    }
}
