using System;

namespace ForAninhado
{
    class Program
    {
        static void Main(string[] args)
        {
            // for (int row = 0; row < 11; row++)
            // {
            //     Console.WriteLine($"{row}..");
            // }

            // Console.WriteLine();

            // for (char column = 'a'; column < 'k'; column++)
            // {
            //     Console.WriteLine($"{column}..");
            // }

            // for (int row = 1; row < 11; row++)
            // {
            //     for (char column = 'a'; column < 'k'; column++)
            //     {
            //         Console.WriteLine($"Celula ({row},{column})");
            //     }
            // }

            for (int row = 1; row < 11; row++)
            {
                for (char column = 'a'; column < 'k'; column++)
                {
                    Console.Write($"({row},{column})");
                }
                Console.WriteLine();
            }
        }
    }
}
