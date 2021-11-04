using System;

namespace VerificarIf
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 5;
            int b = 6;

            if ((a + b) > 10)
            {
                Console.WriteLine("A resposta é maior do que 10");
            }

            string nome = "Felipe";

            if ((a * 2) == (b + 4))
            {
                Console.WriteLine("A resposta é verdadeira");
                Console.WriteLine("Os resultados das expressões são iguais");

                if (nome.StartsWith("F"))
                {
                    Console.WriteLine("E também o nome começa com F");

                }
            }
        }
    }
}
