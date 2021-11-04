using System;

namespace DecidirIF
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;

            if ((a + b) > 10)
            {
                Console.WriteLine("A resposta é maior do que 10");
            }else{
                Console.WriteLine("A resposta não é maior do que 10");
            }

            int c = 4;

            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("A resposta é maior do que 10");
                Console.WriteLine("O primeiro número é igual ao segundo");
            }else{
                Console.WriteLine("A resposta não é maior do que 10");
                Console.WriteLine("O primeiro número é diferente do segundo");
            }

            Console.WriteLine();

            if ((a + b + c > 10) || (a == b))
            {
                Console.WriteLine("A resposta é maior do que 10");
                Console.WriteLine("O primeiro número é igual ao segundo");
            }else{
                Console.WriteLine("A resposta não é maior do que 10");
                Console.WriteLine("O primeiro número é diferente do segundo");
            }

        }
    }
}
