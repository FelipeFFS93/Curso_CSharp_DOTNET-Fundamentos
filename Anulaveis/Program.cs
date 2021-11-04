using System;

#nullable enable

namespace Anulaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            int? optionalInt = null;

            optionalInt =5;

            Console.WriteLine(optionalInt);

            string? optionalTxt = default;
            Console.WriteLine(optionalTxt);

        }
    }
}
