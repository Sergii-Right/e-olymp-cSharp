using System;
using System.Linq;

namespace Storks_7288
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var max = arr[0] > arr[1] ? arr[0] : arr[1];
            var min = arr[0] < arr[1] ? arr[0] : arr[1];
            max = max % 2 == 0 ? max / 2 : (max + 1) / 2;
            min = min % (2 + 1) == 0 ? min : min - 1;

            Console.WriteLine($"{max} {min}");
        }
    }
}