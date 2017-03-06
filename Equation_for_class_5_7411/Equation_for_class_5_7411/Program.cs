using System;

namespace Equation_for_class_5_7411
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var str = Console.ReadLine();
            int x = 0;
            if (str[1] == '+')
            {
                if (str[0] == 'x')
                {
                    x = int.Parse(str[4].ToString()) - int.Parse(str[2].ToString());
                }
                else if (str[2] == 'x')
                {
                    x = int.Parse(str[4].ToString()) - int.Parse(str[0].ToString());
                }
                else if(str[4] == 'x')
                {
                    x = int.Parse(str[0].ToString()) + int.Parse(str[2].ToString());
                }
            }
            else
            {
                if (str[0] == 'x')
                {
                    x = int.Parse(str[2].ToString()) + int.Parse(str[4].ToString());
                }
                else if (str[2] == 'x')
                {
                    x = int.Parse(str[0].ToString()) - int.Parse(str[4].ToString());
                }
                else if(str[4] == 'x')
                {
                    x = int.Parse(str[0].ToString()) - int.Parse(str[2].ToString());
                }
            }
            Console.WriteLine(x);
        }
    }
}