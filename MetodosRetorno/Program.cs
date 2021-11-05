using System;

namespace MetodosRetorno
{
    class Program
    {
        static void Main(string[] args)
        {
            var mClasse = new MinhaClasse();

            mClasse.MetodoSemRetorno();

            int valor = 10;
            int dobroValor = mClasse.DobrarValor(valor);
            Console.WriteLine($"O dobro de {valor} é {dobroValor}.");

            double valor2 = 100;
            double div = 2;
            double res = mClasse.Dividir(valor2,div);
            Console.WriteLine($"A divisão de {valor2} por {div} é: {res}");

            int qtd = mClasse.QuantidadeCaracteres("Felipe");
            Console.WriteLine($"O nome tem {qtd} letras.");
        }
    }

    class MinhaClasse
    {
        public void MetodoSemRetorno()
        {
            Console.WriteLine("Esse metodo não tem retorno de valores");
        }

        public int DobrarValor(int n1)
        {
            int res = n1 *2;
            return res;
        }

        public double Dividir(double n1, double n2) => n1 / n2;
        // {
        //     return n1 / n2;
        // }

        public int QuantidadeCaracteres(string nome) => nome.Length;
    }
}
