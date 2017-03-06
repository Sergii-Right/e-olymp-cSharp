using System;

namespace Chess_olympiad_7671
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round(n / 3) + 1);
        }
    }
}