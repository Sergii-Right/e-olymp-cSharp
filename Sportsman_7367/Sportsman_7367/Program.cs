using System;

namespace Sportsman_7367
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var count = 0;
            double sum = 0;
            for (double i = 10; sum < n; i += i * 0.1)
            {
                sum += i;
                count++;
            }
            Console.WriteLine(count);
        }
    }
}