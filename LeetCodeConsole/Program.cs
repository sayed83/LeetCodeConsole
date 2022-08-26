using System;
using System.Collections.Generic;

namespace LeetCodeConsole
{
    public class Program
    {
        
        static void Main(string[] args)
        {

            var result = RomanToInt("IXL");
            int RomanToInt(string s)
            {
                var result = 0;
                var dictionary = new Dictionary<char, int>
            {
                {'I',1 },
                {'V',5 },
                {'X',10 },
                {'L',50 },
                {'C',100 },
                {'D',500 },
                {'M',1000 },
            };
                for (int i = 0; i < s.Length; i++)
                {
                    if (i == 0)
                    {
                        result += dictionary[s[i]];
                        continue;
                    }
                    if (dictionary[s[i - 1]] >= dictionary[s[i]])
                    {
                        result += dictionary[s[i]];
                    }
                    else
                    {
                        result = result + dictionary[s[i]] - (2 * dictionary[s[i - 1]]);
                    }
                }
                return result;
            }
            Console.WriteLine(result);
        }

        
    }
}
