using System;
using System.Linq;

namespace Lazy_student_7290
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var str = Console.ReadLine();
            var count = str.Count(c => c == 'a' || c == 'e' || c == 'o' || c == 'g' || c == 'p' || c == 'q' || c == 'b' || c == 'd');
            Console.WriteLine(count);
        }
    }
}