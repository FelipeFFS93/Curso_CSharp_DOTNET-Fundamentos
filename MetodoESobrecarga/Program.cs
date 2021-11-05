﻿using System;

namespace MetodoESobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            OverloadingExample.F(15);

            OverloadingExample.UsageExample();
        }
    }

    class OverloadingExample
    {
        public static void F() => Console.WriteLine("F()");
        public static void F(object x) => Console.WriteLine("F(object)");
        public static void F(int x) => Console.WriteLine("F(int)");
        public static void F(double x) => Console.WriteLine("F(double)");
        public static void F<T>(T x) => Console.WriteLine("F<T>(T)");
        public static void F(double x, double y) => Console.WriteLine("F(double, double)");

        public static void UsageExample()
        {
            F();
            F(1);
            F(1.0);
            F((object)1);
            F<int>(1);
            F("abc");
            F(1, 1);
        }
    }
}
