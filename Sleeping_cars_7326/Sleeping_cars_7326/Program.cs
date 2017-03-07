using System;

namespace Sleeping_cars_7326
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var str = Console.ReadLine();
            int st = 0, count = 0;
            foreach (var ch in str)
            {
                if (ch == 'k')
                {
                    count++;
                }
                else
                {
                    count = 0;
                }
                if (count > st) st = count;
            }
            Console.WriteLine(st);
        }
    }
}