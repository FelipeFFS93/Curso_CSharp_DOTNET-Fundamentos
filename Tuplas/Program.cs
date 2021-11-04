using System;

namespace Tuplas
{
    class Program
    {
        static void Main(string[] args)
        {
            (double sum,  int count) t1 = (4.5, 3);
            Console.WriteLine($"A soma de {t1.count} elementos é {t1.sum}.");

            (int cod, string produto, double valor) p1 = (100, "Mouse", 45.90);
            Console.WriteLine($"Produto: {p1.cod}");
            Console.WriteLine($"Produto: {p1.produto}");
            Console.WriteLine($"Produto: {p1.valor}");
        }
    }
}
