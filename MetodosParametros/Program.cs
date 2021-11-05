using System;

namespace MetodosParametros
{
    class Program
    {
        static void Main(string[] args)
        {
            var mClasse = new MinhaClasse();

            int n1 = 10;

            mClasse.ParametrosValor(n1);
            Console.WriteLine($"Variavel original {n1}");

            mClasse.ParametrosReferencia(ref n1);
            Console.WriteLine($"Variavel original {n1}");
        }
    }

    class MinhaClasse
    {
        public void ParametrosValor(int num)
        {
            num *= 2;
            Console.WriteLine($"O dobro do valor digitado é: {num}");
        }

        public void ParametrosReferencia (ref int num)
        {
            num *= 2;
            Console.WriteLine($"O dobro do valor digitado é: {num}");
        }
    }
}
