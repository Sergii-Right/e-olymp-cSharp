using System;
using System.Collections.Generic;
using System.Linq;

namespace Avarage_of_scaters_7368
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var s = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<double> lst = new List<double>();
            for (var i = 0; i < s[1]; i++)
            {
                var l = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
                lst.Add(l.Where(c => c != l.Max() && c != l.Min()).Average());
            }

            foreach (var item in lst)
            {
                Console.Write("{0:f2} ", item);
            }
        }
    }
}