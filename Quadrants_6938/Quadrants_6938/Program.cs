using System;
using System.Linq;

namespace Quadrants_6938
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var n = 0;
            int.TryParse(Console.ReadLine(), out n);
            int Q1 = 0, Q2 = 0, Q3 = 0, Q4 = 0, AXIS = 0;

            for (var i = 0; i < n; i++)
            {
                var str = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
                if (str[0] == 0 || str[1] == 0)
                {
                    AXIS++;
                }
                else
                {
                    if (str[0] > 0)
                    {
                        if (str[1] > 0)
                        {
                            Q1++;
                        }
                        else
                        {
                            Q4++;
                        }
                    }
                    else
                    {
                        if (str[1] > 0)
                        {
                            Q2++;
                        }
                        else
                        {
                            Q3++;
                        }
                    }
                }
            }

            Console.WriteLine($"Q1: {Q1}");
            Console.WriteLine($"Q2: {Q2}");
            Console.WriteLine($"Q3: {Q3}");
            Console.WriteLine($"Q4: {Q4}");
            Console.WriteLine($"AXIS: {AXIS}");
        }
    }
}