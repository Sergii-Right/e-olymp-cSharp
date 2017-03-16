using System;
using System.Collections.Generic;
using System.Linq;

namespace How_6413
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var t = 0;
            var lst = new List<int>();
            int.TryParse(Console.ReadLine(), out t);
            for (var i = 0; i < t; i++)
            {
                int sum = 0, n = 0;
                int.TryParse(Console.ReadLine(), out sum);
                int.TryParse(Console.ReadLine(), out n);
                for (var j = 0; j < n; j++)
                {
                    var arr = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
                    sum += arr[0] * arr[1];
                }
                lst.Add(sum);
            }
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }
        }
    }
}