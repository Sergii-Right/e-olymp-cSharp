using System;
using System.Linq;

namespace The_sum_of_fraction_7363
{
    internal class Program
    {
        public static int Euclid(int a, int b)
        {
            while (true)
            {
                if (a % b != 0)
                {
                    var a1 = a;
                    a = b;
                    b = a1 % b;
                    continue;
                }
                return b;
            }
        }

        public static void Main(string[] args)
        {
            var str = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (str[1] != str[3])
            {
                str[0] *= str[3];
                str[2] *= str[1];
                str[1] *= str[3];
            }
            var numerator = str[0] + str[2];
            var denominator = str[1];
            if (numerator % denominator == 0)
            {
                numerator /= denominator;
                Console.WriteLine(numerator);
            }
            else
            {
                int ev;
                do
                {
                    ev = Euclid(numerator, denominator);
                    numerator /= ev;
                    denominator /= ev;

                } while (ev != 1);
                Console.WriteLine("{0} {1}", numerator, denominator);
            }
        }
    }
}