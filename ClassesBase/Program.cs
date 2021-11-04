using System;

namespace ClassesBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(10,20);

            Point3D p2 = new Point3D(5,8,25);

            Point p3 = new Point3D(4,6,2);

            Console.WriteLine($"P1 - X: {p1.x} e Y: {p1.y}");
            Console.WriteLine($"P2 - X: {p2.x}, Y: {p2.y} e Z: {p2.z}");

        }
    }

    public class Point
    {
        public int x { get; }
        public int y { get; }

        public Point(int n1, int n2) => (x,y) = (n1,n2);
        
    }

    public class Point3D : Point
    {
        public int z { get; }

        public Point3D(int n1, int n2, int n3) : base (n1, n2)
        {
            z = n3;
        }


    }
}
