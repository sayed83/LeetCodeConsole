using System;
using System.Collections;

namespace LeetCodeConsole
{
    public class Calculation
    {
        public int[] TwoSum(int[] nums, int target)
        {
            //if (nums == null || nums.Length < 2)
            //    return new int[2];

            //Dictionary<int, int> dic = new Dictionary<int, int>();

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (dic.ContainsKey(target - nums[i]))
            //        return new int[] { i, dic[target - nums[i]] };
            //    else if (!dic.ContainsKey(nums[i]))
            //        dic.Add(nums[i], i);
            //}
            //return new int[2];

            Hashtable _diffs = new Hashtable();

            for (int i = 0; i < nums.Length; i++)
            {
                var num = nums[i];
                var difference = target - nums[i];

                if (_diffs.ContainsKey(difference))
                {
                    return new int[] { i, (int)_diffs[difference] };
                }

                if (!_diffs.ContainsKey(num))
                {
                    _diffs.Add(num, i);
                }
            }
            return null;

            ////Dictionary<int, int> dictionary = new Dictionary<int, int>();

            ////for (int i = 0; i < nums.Length; i++)
            ////    if (dictionary.ContainsKey((target - nums[i])))
            ////        return new[] { dictionary[(target - nums[i])], i };
            ////    else
            ////        dictionary.TryAdd(nums[i], i);
            ////return null;
        }

        public static bool lessThan100(int a, int b)
        {
            var sum = a + b;

            if (sum < 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int HowManySeconds(int hours)
        {
            int minute = hours * 60;
            int second = minute * 60;
            return second;
        }

        public static int CircuitPower(int voltage, int current)
        {
            return voltage * current;
        }

        

        public static int Addition(int num)
        {
            var total = num + 1;
            //return total;
            return ++num;
        }

        public static long CalculateExponent1(long number, long exponent)
        {
            if (exponent > 0)
            {                
                long result = (long)Math.Pow(number, exponent);
                return result;
            }
            return 1;
        }
        public static long CalculateExponent(long number, long exponent)
        {
            if (exponent > 0)
            {
                double ret = 1;
                for (int i = 1; i <= exponent; ++i)
                {
                    ret *= number;                    
                }
                return (long)ret;
            }
            return 1;
        }

        public static long CalculateExponent2(long number, long exponent)
        {
            var newNumber = number;
            for (var i = exponent; i > 1; i--)
                newNumber *= number;

            return newNumber;
        }
        public static long CalculateExponent3(long number, long exponent)
        {
            long result = 1;
            for (long i = 0; i < exponent; i++)
            {
                result *= number;
            }
            return result;
        }
        public static long CalculateExponent4(long number, long exponent)
        {
            long a = (long)Math.Pow(number, exponent);
            return a;
        }

        public static long CalculateExponent5(long number, long exponent)
        {
            long dbltemp = 0;
            for (int i = 1; i < exponent; i++)
            {
                if (i == 1)
                {
                    dbltemp = number * number;
                }
                else
                {
                    dbltemp = dbltemp * number;
                }
            }
            return dbltemp;
        }

        public static long CalculateExponent6(long number, long exponent)
        {
            long sum = number;
            for (int i = 1; i < exponent; i++)
            {
                sum = sum * exponent;
            }
            return sum;
        }

        public static long CalculateExponent7(long number, long exponent)
        {
            long result = 1;
            while (exponent-- > 0)
            {
                result *= number;
            }
            return result;
        }
    }
}
