using System;
using System.Linq;

namespace Greatest_common_divisor_571
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var arr = Console.ReadLine().Split(' ');
            var a = new int[n];
            for (var i = 0; i < n; i++)
            {
                a[i] = int.Parse(arr[i]);
            }
            var d = 0;

            var min = a.Min();
            for (var i = min; i > 0; i--)
            {
                var check = true;
                d = i;
                for (var j = 0; j < n; j++)
                {
                    if (a[j] % i == 0) continue;
                    check = false;
                    break;
                }
                if(check) break;
            }

            Console.WriteLine(d);
        }
    }
}