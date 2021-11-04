using System;

namespace CadeiaCaracteres
{
    class Program
    {
        static void Main(string[] args)
        {

            string primeiroNome = "Felipe";
            string segundoNome = "Freire";


            Console.WriteLine($"Meu nome é {primeiroNome} {segundoNome}");

            Console.Write("Digite o seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine($"Olá {nome}, bem vindo ao curso");
            Console.WriteLine($"Seu nome tem {nome.Length} letras!");

            
        }
    }
}
