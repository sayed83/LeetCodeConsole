using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeConsole
{
    public class edabit_challenges
    {
        public static int convert(int minutes)
        {
            int second = 60;
            return minutes * second;
        }

        public static int Factorial(int num)
        {
            var result = 1;
            for (int i = 1; i <= num; i++)
            {
                result = result * i;
            }
            return result;
        }

        public static int triArea1(int b, int h)
        {
            return (b * h) / 2;
        }

        public static int triArea(int b, int h) => (b * h) / 2;

        public static string smallerNum(string n1, string n2)
        {
            int no1 = 0;
            int no2 = 0;
            for (int i = 0; i <= n1.Length; i++)
            {
                no1 += n1[i];
            }
            return no1.ToString();
        }
        public static string smallerNum1(string n1, string n2)
        {
            // 100 % not ok
            var num = string.Compare(n1, n2);
            if (string.Compare(n1, n2) == 0) return n2;
            if (string.Compare(n1, n2) < 0) return n1;
            if (string.Compare(n1, n2) > 0) return n2;
            return "";
        }
        Func<int, int> factorial = n => n == 0 ? 1 : Enumerable.Range(1, n).Aggregate((acc, x) => acc * x);
    }
}
