using System;

namespace MetodoParametroTipo
{
    class Program
    {
        static void Main(string[] args)
        {
            var mClasse = new MinhaClasse();

            string nome = mClasse.MeuMetodo<string>("Felipe");
            int idade = mClasse.MeuMetodo<int>(28);

            Console.WriteLine($"{nome} tem {idade} anos.");

            mClasse.MostrarTipo<double>(18.75);

            mClasse.OutroMetodo<string, double>("Felipe", 19.68, 10);
        }
    }

    class MinhaClasse
    {
        public T MeuMetodo<T>(T valor)
        {
            return valor;
        }

        public void OutroMetodo<T1, T2>(T1 valor1, T2 valor2, int n1)
        {
            Console.WriteLine(valor1.GetType());
            Console.WriteLine(valor2.GetType());
            Console.WriteLine(n1.GetType());
        }

        public void MostrarTipo<T>(T valor)
        {
            Type tipo = valor.GetType();
            Console.WriteLine($"O tipo .NET de {valor} é {tipo}");
        }
    }
}
