using System;

namespace MetodosParametrosSaida
{
    class Program
    {
        static void Main(string[] args)
        {
            var mClasse = new MinhaClasse();
            double valor1 = 10, valor2 = 5, resultado;

            mClasse.Calcular(valor1, valor2, out resultado);

            Console.WriteLine($"{valor1} + {valor2} = {resultado}");
        }
    }

    class MinhaClasse
    {
        public void Calcular(double n1, double n2, out double res)
        {
            res = n1 + n2;
        }
    }
}
