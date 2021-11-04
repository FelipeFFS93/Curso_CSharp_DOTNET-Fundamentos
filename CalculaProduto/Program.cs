using System;

namespace CalculaProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, mult;

            Console.Clear();

            Console.Write("Digite o primeiro numero: ");

            n1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");

            n2 = double.Parse(Console.ReadLine());

            mult = n1 * n2;

            Console.WriteLine("");
            Console.WriteLine($"O produto de {n1} e {n2} é {mult}");
        }
    }
}
