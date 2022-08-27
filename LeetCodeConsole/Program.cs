using System;
using System.Collections.Generic;

namespace LeetCodeConsole
{
    public class Program
    {

        static void Main(string[] args)
        {
            // Convertion convertion = new Convertion();
            Calculation cal = new Calculation();
            //var result = convertion.RomanToInt("IXL");
            int[] nums = { 2, 7, 11, 15 };
           var target = 9;
            //var result = convertion.IntToRoman1(Convert.ToInt32(input));
            var result = cal.TwoSum(nums, target);
            Console.WriteLine(result);
        }


    }
}
