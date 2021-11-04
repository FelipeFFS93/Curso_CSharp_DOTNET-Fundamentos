using System;

namespace ClassesEObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point(25, 68);
            p1.x = 10;
            p1.y = 50;

            Console.WriteLine("Coordenadas de P1");
            Console.WriteLine($"X: {p1.x}");
            Console.WriteLine($"Y: {p1.y}");
        }
    }

    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }

        public Point(int n1, int n2) => (x,y) = (n1,n2);
        // {
        //     x = n1;
        //     y = n2;
        // }
    }
}
