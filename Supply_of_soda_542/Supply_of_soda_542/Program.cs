using System;

namespace Supply_of_soda_542
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ');
            var e = int.Parse(arr[0]) + int.Parse(arr[1]);
            var c = int.Parse(arr[2]);
            var sum = 0;
            for (;;)
            {
                e -= c;
                if (e >= 0)
                {
                    sum++;
                    e++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
