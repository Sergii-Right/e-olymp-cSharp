using System;
using System.Linq;

namespace Scalar_product_7449
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var s = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var a = s[0];
            var b = s[1];
            var c = s[2];
            var d = s[3];

            var scalar = a * c + b * d;
            Console.WriteLine(scalar);
            var mod1 = Math.Sqrt(a * a + b * b);
            var mod2 = Math.Sqrt(c * c + d * d);
            Console.WriteLine("{0:f5}", Math.Acos(scalar / (mod1 * mod2)));
        }
    }
}