using System;

namespace MaisCaracteres
{
    class Program
    {
        static void Main(string[] args)
        {

            string greeting = "            Hello Wolrd!            ";

            Console.WriteLine($"[{greeting}]");

            string trimmedGreeting = greeting.TrimStart();

            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.TrimEnd();

            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.Trim();

            Console.WriteLine($"[{trimmedGreeting}]");


            string sayHello = "Oi Mundão!";

            Console.WriteLine(sayHello);

            sayHello = sayHello.Replace("Oi", "Eai");

            Console.WriteLine(sayHello);


            Console.WriteLine(sayHello.ToUpper());

            Console.WriteLine(sayHello.ToLower());
        }
    }
}
