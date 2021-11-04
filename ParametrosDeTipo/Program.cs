using System;

namespace ParametrosDeTipo
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Pair<int,string>(1, "Um");
            int i = p1.First;
            string s = p1.Second;

            var p2 = new Pair<string, double>("Teclado", 45.75);
            // string produto = p2.First;
            // double valor = p2.Second;

            Console.WriteLine($"Produto: {p2.First} - Valor: {p2.Second}");
        }
    }

    public class Pair<Primeiro, Segundo>
    {
        public Primeiro First { get; }
        public Segundo Second { get; }

        public Pair(Primeiro first, Segundo second) => (First, Second) = (first, second);
    }
}
