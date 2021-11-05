using System;

namespace MetodosArrayParametros
{
    class Program
    {
        static void Main(string[] args)
        {
            var mClasse = new MinhaClasse();

            mClasse.Parametros("Felipe", 27, 1993);

            Console.WriteLine();

            mClasse.ListaNomes("Felipe", "Bete", "Miguel", "Carol", "Jaqueline");
        }
    }

    class MinhaClasse
    {
        public void Parametros(params object[] argumentos)
        {
            foreach (var item in argumentos)
            {
                Console.WriteLine(item);
            }
        }

        public void ListaNomes(params string[] nomes)
        {
            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }
        }
    }
}
