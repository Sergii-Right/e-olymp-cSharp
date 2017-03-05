using System;
using System.Linq;

namespace Greater_among_the_four_7812
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var lst = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            Console.WriteLine(lst.Max());
        }
    }
}