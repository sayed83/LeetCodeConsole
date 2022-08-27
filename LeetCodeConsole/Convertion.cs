using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeConsole
{
    public class Convertion
    {
        public int RomanToInt(string s)
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
            // solution 1 accepted
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
        public int RomanToInt1(string r)
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
            // solution 2 convertion error
            char nextChar = 'I';
            for (int index = r.Length - 1; index >= 0; index--)
            {
                char currentChar = r[index];
                result += dictionary[currentChar] >= dictionary[nextChar] ? dictionary[currentChar] : -dictionary[currentChar];
                nextChar = currentChar;
            }
            return result;
        }

        public string IntToRoman(int num)
        {
            if (num >= 1000) return "M" + IntToRoman(num - 1000);

            if (num >= 500) return num >= 900 ? ("CM" + IntToRoman(num - 900)) : ("D" + IntToRoman(num - 500));

            if (num >= 100) return num >= 400 ? ("CD" + IntToRoman(num - 400)) : ("C" + IntToRoman(num - 100));

            if (num >= 50) return num >= 90 ? ("XC" + IntToRoman(num - 90)) : ("L" + IntToRoman(num - 50));

            if (num >= 10) return num >= 40 ? ("XL" + IntToRoman(num - 40)) : ("X" + IntToRoman(num - 10));

            if (num >= 5) return num == 9 ? "IX" : "V" + IntToRoman(num - 5);

            if (num > 0) return num == 4 ? "IV" : "I" + IntToRoman(num - 1);

            return "";
        }

        public string IntToRoman1(int num)
        {

            if (num < 1)
                throw new ArgumentException("Invaid Input.");

            string[] roman = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] nums = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

            string res = "";
            int i = 0;

            while (num > 0)
            {
                while (num >= nums[i])
                {
                    res += roman[i];
                    num -= nums[i];
                }
                i++;
            }

            return res;
        }

        public string IntToRoman2(int num)
        {
            StringBuilder result = new StringBuilder();
            int i = 0;

            i = num / 1000;
            for (; i > 0; i--)
                result.Append("M");

            num %= 1000;

            if (num / 900 == 1)
            {
                result.Append("CM");
                num %= 900;
            }

            if (num / 500 == 1)
            {
                result.Append("D");
                num %= 500;
            }

            if (num / 400 == 1)
            {
                result.Append("CD");
                num %= 400;
            }

            i = num / 100;
            for (; i > 0; i--)
                result.Append("C");

            num %= 100;

            if (num / 90 == 1)
            {
                result.Append("XC");
                num %= 90;
            }

            if (num / 50 == 1)
            {
                result.Append("L");
                num %= 50;
            }

            if (num / 40 == 1)
            {
                result.Append("XL");
                num %= 40;
            }

            i = num / 10;
            for (; i > 0; i--)
                result.Append("X");

            num %= 10;

            if (num / 9 == 1)
            {
                result.Append("IX");
                num %= 9;
            }

            if (num / 5 == 1)
            {
                result.Append("V");
                num %= 5;
            }

            if (num / 4 == 1)
            {
                result.Append("IV");
                num %= 4;
            }

            for (; num > 0; num--)
                result.Append("I");

            return result.ToString();
        }

        public string IntToRoman4(int num)
        {
            string result = string.Empty;
            string[] baseFive = { "V", "L", "D" };
            string[] baseNum = { "I", "X", "C", "M" };
            int pos = 0;
            while (num > 0)
            {
                int pop = num % 10;
                num /= 10;

                if (pop == 5)
                {
                    result = baseFive[pos] + result;
                }
                else if (pop > 5)
                {
                    if (pop == 6)
                    {
                        result = (baseFive[pos] + baseNum[pos] + result);
                    }
                    else if (pop == 9)
                    {
                        result = (baseNum[pos] + baseNum[pos + 1] + result);
                    }
                    else
                    {
                        var temp = string.Empty;
                        var reminder = pop % 5;
                        for (int i = 0; i < reminder; i++)
                        {
                            temp += baseNum[pos];
                        }
                        result = (baseFive[pos] + temp + result);
                    }
                }
                else
                {
                    if (pop == 4)
                    {
                        result = (baseNum[pos] + baseFive[pos] + result);
                    }
                    else
                    {
                        var temp = string.Empty;
                        var reminder = pop % 5;
                        for (int i = 0; i < reminder; i++)
                        {
                            temp += baseNum[pos];
                        }
                        result = (temp + result);
                    }
                }
                pos++;
            }
            return result;
        }

        private int[] integers = { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };
        private string[] romans = { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };
        public string IntToRoman5(int num)
        {
            var sb = new StringBuilder();
            int len = integers.Length;
            for (int i = integers.Length - 1; i >= 0 && num >= 0; i--)
            {
                while (integers[i] <= num)
                {
                    num -= integers[i];
                    sb.Append(romans[i]);
                }
            }
            return sb.ToString();
        }

        public string IntToRoman6(int num)
        {
            var symList = new List<KeyValuePair<int, string>>()
        {
             new KeyValuePair<int, string>(1000, "M"),
             new KeyValuePair<int, string>(900, "CM"),
             new KeyValuePair<int, string>(500, "D"),
             new KeyValuePair<int, string>(400, "CD"),
             new KeyValuePair<int, string>(100, "C"),
             new KeyValuePair<int, string>(90, "XC"),
             new KeyValuePair<int, string>(50, "L"),
             new KeyValuePair<int, string>(40, "XL"),
             new KeyValuePair<int, string>(10, "X"),
             new KeyValuePair<int, string>(9, "IX"),
             new KeyValuePair<int, string>(5, "V"),
             new KeyValuePair<int, string>(4, "IV"),
             new KeyValuePair<int, string>(1, "I")
        };
            string result = "";
            foreach (var item in symList)
            {
                while (num >= item.Key)
                {
                    result += item.Value;
                    num -= item.Key;
                }
            }
            return result;
        }
    }
}
