using System;
using System.Collections.Generic;
using System.Linq;

namespace Counting_sort_2327
{
    internal class Program
    {
        public static void CountingSort(int[]a, Dictionary<int, int> dict)
        {
            foreach (var i in a)
            {
                dict[i]++;
            }
        }
        public static void Main(string[] args)
        {
            int n;
            int.TryParse(Console.ReadLine(), out n);
            var a = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            var dict = new Dictionary<int, int>();
            for (var i = 0; i <= 100000; i++)
            {
                dict.Add(i, 0);
            }
            CountingSort(a, dict);
            var count = 0;
            foreach (var item in dict)
            {
                for (var j = 0; j < item.Value; j++)
                {
//                    a[count++] = item.Key;
                    Console.Write(item.Key);
                    if(count++ < n - 1) Console.Write(' ');
                }
            }
//            for (var i = 0; i < a.Length; i++)
//            {
//                Console.Write(a[i]);
//                if (i < a.Length - 1) Console.Write(" ");
//            }

            Console.WriteLine();
        }
    }
}