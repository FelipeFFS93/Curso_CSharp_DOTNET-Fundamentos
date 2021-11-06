using System;

namespace DelegadosELambda
{
    class Program
    {
        delegate double Function(double a,double b);
        static void Main(string[] args)
        {
            Function operation = Somar;

            Console.WriteLine(operation(10,7));

            operation = (x,y) => x*y;

            Console.WriteLine(operation(5,3));

        }

        public static double Somar(double n1, double n2)
        {
            return n1 + n2;
        }
    }
}
