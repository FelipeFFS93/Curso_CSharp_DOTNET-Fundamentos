using System;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
           var mClasse = new MinhaClasse();

           mClasse.MeuMetodo();
           mClasse.MeuOutroMetodo();
           string retorno = mClasse.ToString();

           Console.WriteLine(retorno);
        }
    }

    class MinhaClasse
    {
        public void MeuMetodo() // => Console.WriteLine("Metodo em execução!!");
        {
            Console.WriteLine("Metodo em execução!!");
        }

        public void MeuOutroMetodo()
        {
            Console.WriteLine("Outro metodo em execução!!");
            Console.WriteLine("Esse tem mais de uma instrução!!");

        }

        public override string ToString() => "Este é um objeto";
        
    }
}
