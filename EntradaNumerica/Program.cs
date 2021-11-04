using System;

namespace EntradaNumerica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro numero: ");
            string pConver = Console.ReadLine();
            int n1 = int.Parse(pConver);

            Console.WriteLine("Digite o segundo numero: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{n1} / {n2} = {n1 / n2 } e sobra {n1 % n2}");

            Console.WriteLine("Digite o valor de double: ");
            double n3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de decimal: ");
            decimal n4 = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"O valor digitado para double foi: {n3}");
            Console.WriteLine($"O valor digitado para decimal foi: {n4}");
        }
    }
}
