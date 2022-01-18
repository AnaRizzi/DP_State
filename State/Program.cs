using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Variações de estado de um orçamento!");

            var orcamento = new Orcamento(100);
            Console.WriteLine(orcamento.Valor);

            orcamento.AplicaDescontoExtra();
            Console.WriteLine(orcamento.Valor);

            orcamento.Aprova();
            orcamento.AplicaDescontoExtra();
            Console.WriteLine(orcamento.Valor);

            orcamento.Finaliza();

            Console.ReadKey();
        }
    }
}
