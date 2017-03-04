using System;

namespace Cat_Dog_and_Rabbit_7813
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var s = Console.ReadLine().Split(' ');
            var a = int.Parse(s[0]);
            var b = int.Parse(s[1]);
            var c = int.Parse(s[2]);

            var z = (c + b - a) / 2.0;
            var y = b - z;
            var x = a - y;

            Console.WriteLine("{0:f2} {1:f2} {2:f2}", x, y, z);
        }
    }
}