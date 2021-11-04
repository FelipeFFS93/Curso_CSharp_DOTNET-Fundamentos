using System;

namespace Estruturas // estrutura não pode interagir como classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(15.2,7.5);
        }
    }

    public struct Point
    {
        public double x { get; }
        public double y { get; }
        public Point(int n1, int n2) => (x,y) = (n1,n2);

    }
}
