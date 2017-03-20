using System;
using System.Collections.Generic;

namespace Original_messages_6412
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<char, int>();
            for (var i = 0; i < n; i++)
            {
                var str = Console.ReadLine();
                var check = true;
                if (str == null) continue;
                long len = str.Length;
                for (var j = 0; j < len; j++)
                {
                    if (!dict.ContainsKey(str[j]))
                    {
                        dict.Add(str[j], 1);
                    }
                    else
                    {
                        dict[str[j]]++;
                        if (dict[str[j]] != 3) continue;
                        if (j < len - 1)
                        {
                            if (str[j + 1] != str[j])
                            {
                                check = false;
                                break;
                            }
                            j++;
                        }
                        else
                        {
                            check = false;
                            break;
                        }
                        dict[str[j]] = 1;
                    }
                }
                dict.Clear();
                Console.WriteLine(check ? "OK" : "FAKE");
            }
        }
    }
}