using System;
using System.Collections.Generic;

namespace ListaTutorial
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
        }
    }
}
