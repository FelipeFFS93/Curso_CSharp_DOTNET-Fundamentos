using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = i * i;
            }

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"a[{i}] = {a[i]}");
            }

            int[] b = new int[10];
            int[,] c = new int[10,5];
            int[,,] d = new int[10,5,2];

            c[0,0] = 10;
            d[9,4,1] = 20;

            int[][] e = new int [3][];

            e[0] = new int [10];
            e[1] = new int [5];
            e[2] = new int [20];

            e[0][9] = 20;
            e[1][4] = 20;
            e[2][19] = 20;

            int[] f = new int[] { 1,2,3 };
            int[] g = { 1,2,3 };

            int[] h = new int[3];
            h[0] = 1;
            h[1] = 2;
            h[2] = 3;
            int[] collection = h;

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
