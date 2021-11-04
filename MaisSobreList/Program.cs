using System;
using System.Collections.Generic;

namespace MaisSobreList
{
    class Program
    {
        static void Main(string[] args)
        {
            var nomes = new List<string> { "Felipe", "Miguel", "Jaqueline", "Carol", "Bete" };

            var index = nomes.IndexOf("Jaqueline");

            // foreach (var nome in nomes)
            // {
            //     Console.WriteLine($"Olá {nome}!");
            // }

            if (index == -1)
            {
                Console.WriteLine($"Quando um item não é encontrado, IndexOf retorna{index}");
            }else{
                Console.WriteLine($"O nome {nomes[index]} está no indice {index}");
            }

            index = nomes.IndexOf("Carlos");

            if (index == -1)
            {
                Console.WriteLine($"Quando um item não é encontrado, IndexOf retorna {index}");
            }else{
                Console.WriteLine($"O nome {nomes[index]} está no indice {index}");
            }

            nomes.Sort();

            foreach (var nome in nomes)
            {
                Console.WriteLine($"Olá {nome}!");
            }
        }
    }
}
