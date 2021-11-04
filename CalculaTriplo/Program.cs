using System;

namespace CalculaTriplo
{
    class Program
    {
        static void Main(string[] args)
        {
            double num, triplo;

            Console.Clear();

            Console.Write("Digite o numero: ");

            num = double.Parse(Console.ReadLine());

            triplo = num * 3;

            Console.WriteLine("");
            Console.WriteLine($"O triplo do {num} é {triplo}");


        }
    }
}
