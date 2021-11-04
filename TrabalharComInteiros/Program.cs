using System;

namespace TrabalharComInteiros
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 18;
            int b = 6;

            //Soma.

            int soma = a + b;
            Console.WriteLine($"{a} + {b} = {soma}");

            //Subtração

            int sub = a - b;
            Console.WriteLine($"{a} - {b} = {sub}");

            //Multiplicação

            int mult = a * b;
            Console.WriteLine($"{a} * {b} = {mult}");

            //Divisão

            int div = a / b;
            Console.WriteLine($"{a} / {b} = {div}");

            //Resto da Divisão

            int rest = a % b;
            Console.WriteLine($"{a} resto de {b} = {rest}");

        }
    }
}
