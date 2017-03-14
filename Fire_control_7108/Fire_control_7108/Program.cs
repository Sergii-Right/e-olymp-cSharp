using System;

namespace Fire_control_7108
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var num = Console.ReadLine();
            var str = "";
            if (num != null)
                foreach (var c in num)
                {
                    if (int.Parse(c.ToString()) == 0 || int.Parse(c.ToString()) == 1)
                    {
                        str += c;
                    }
                    for (var j = 0; j < int.Parse(c.ToString()); j++)
                    {
                        str += c;
                    }
                }
            Console.WriteLine(str);
        }
    }
}