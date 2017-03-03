using System;
using System.Collections.Generic;

namespace box_697
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var lst = new List<double>();
            for (var i = 0; i < n; i++)
            {
                var a = double.Parse(Console.ReadLine());
                var x1 = 12 * a / 24;
                var x2 = 4 * a / 24;
                var s1 = (a - x1 * 2) * (a - x1 * 2) * x1;
                var s2 = (a - x2 * 2) * (a - x2 * 2) * x2;
                lst.Add(s1 > s2 ? x1 : x2);
            }

            foreach (var i in lst)
            {
                Console.WriteLine("{0:f10}", i);
            }
        }
    }
}