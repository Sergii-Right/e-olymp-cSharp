using System;
using System.Collections.Generic;
using System.Linq;

namespace Units_622
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var lst = new List<int>();
            for (;;)
            {
                lst.Add(n % 2);
                n /= 2;
                if(n == 0) break;
            }

            Console.WriteLine(lst.Count(c => c == 1));
        }
    }
}