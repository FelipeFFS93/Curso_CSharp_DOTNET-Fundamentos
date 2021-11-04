using System;

namespace PesquisarCaracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            string songs = "Você disse adeus, e eu disse olá!";

            Console.WriteLine(songs.Contains("adeus"));
            Console.WriteLine(songs.Contains("felipe"));

            Console.WriteLine(songs.StartsWith("adeus"));
            Console.WriteLine(songs.StartsWith("Você"));

            Console.WriteLine(songs.EndsWith("olá!"));
            Console.WriteLine(songs.EndsWith("Você")); 



        }
    }
}
