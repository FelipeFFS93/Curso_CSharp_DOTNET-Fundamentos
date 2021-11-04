using System;
using System.Collections.Generic;

namespace ModificarLista
{
    class Program
    {
        static void Main(string[] args)
        {
            var nomes = new List<string> { "Felipe", "Miguel", "Jaqueline" };

            foreach (var nome in nomes)
            {
                Console.WriteLine($"Olá {nome}!");

            }

            Console.WriteLine();
            nomes.Add("Carol");
            nomes.Add("Beth");
            nomes.Remove("Jaqueline");

            foreach (var nome in nomes)
            {
                Console.WriteLine($"Olá {nome}!");

            }

            Console.WriteLine($"Meu nome é {nomes[0]}");
            Console.WriteLine($"Eu adicionei {nomes[2]} e {nomes[3]} na lista");

            Console.WriteLine($"A lista tem {nomes.Count} nomes nela");

        }
    }
}
