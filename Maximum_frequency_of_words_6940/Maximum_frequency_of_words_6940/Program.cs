using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximum_frequency_of_words_6940
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, int>();
            for (var i = 0; i < n; i++)
            {
                var str = Console.ReadLine();
                if (dict.ContainsKey(str))
                {
                    dict[str]++;
                }
                else
                {
                    dict.Add(str, 1);
                }
            }
            var lst = dict.Where(c => c.Value == dict.Values.Max()).ToList();
            Console.WriteLine($"{lst.Max(c => c.Key)} {lst.First().Value}");
        }
    }
}