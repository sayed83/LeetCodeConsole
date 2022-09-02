using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeConsole
{
    public class Problem
    {
        /// <summary>
        /// 4. Median of Two Sorted Arrays
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            List<int> merged = nums1.Concat(nums2).ToList();
            merged.Sort();
            int mid = merged.Count / 2;
            var m = merged.Count() % 2;
            if (m != 0)
            {
                return Convert.ToDouble(merged[mid]);
            }
            int c = merged[mid - 1];
            int b = merged[mid];
            double oMid = Convert.ToDouble((c + b) / 2.0);

            return oMid;
        }

        /// <summary>
        /// 11. Container With Most Water
        /// </summary>
        public void MaxArea()
        {
            int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            int max = 0;
            int left = 0;
            int right = height.Length - 1;
            while (left < right)
            {
                int area = Math.Min(height[left], height[right]) * (right - left);
                max = Math.Max(max, area);
                if (height[left] < height[right])
                {                    
                    left++;
                }
                else
                {
                    right--;
                }                
            }
            Console.WriteLine(max);
        }

        public IList<IList<int>> ThreeSum(int[] nums)
        {
            //this is where final result will live.
            var reslist = new List<IList<int>>();
            //sort the array so search is quicker
            Array.Sort(nums);
            var pre = 0; //keep track previous number
            //start from end of array
            for (var i = nums.Length - 1; i > 1; i--)
            {
                //if not at the start of loop and previous number equals to current number
                //no need to continue, the triplet (if there is one) will be the same
                if (i != nums.Length - 1 && nums[i] == pre)
                {
                    continue;
                }
                //calculate how many we still need to compose the triplet
                var remain = 0 - nums[i];
                //update the previous number
                pre = nums[i];
                //the previous tracking for inner loop
                var prev = 0;
                for (var j = i - 1; j > 0; j--)
                {
                    //same as outer loop, if number is same
                    //would yield same triplet, skip it.
                    if (j != i - 1 && nums[j] == prev)
                    {
                        continue;
                    }
                    //calculate the last number needed
                    var last = remain - nums[j];
                    //update the previous
                    prev = nums[j];
                    //binary search the last number
                    var exist = Array.BinarySearch<int>(nums, 0, j, last);
                    //if found add the triplet
                    if (exist >= 0)
                    {
                        reslist.Add(new List<int>() { nums[i], nums[j], last });
                    }
                }
            }
            foreach (var item in reslist)
            {
                Console.WriteLine(item);
            }
            
            return reslist;
        }

        public IList<IList<int>> ThreeSum1(int[] nums)
        {

            List<IList<int>> res = new List<IList<int>>();
            if (nums == null || nums.Length < 3)
                return res;

            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 2; i++)
            {
                // If nums[i] > 0, we can't find a valid triplet, since nums is sorted and nums[i] the smallest number.
                // To avoid duplicate triplets, we should skip nums[i] if nums[i] == nums[i-1]
                if (nums[i] > 0 || (i > 0 && nums[i] == nums[i - 1]))
                    continue;

                int left = i + 1, right = nums.Length - 1;
                while (left < right)
                {
                    if (nums[i] + nums[left] + nums[right] == 0)
                    {
                        res.Add(new List<int>() { nums[i], nums[left], nums[right] });
                        left++;
                        right--;

                        while (left < right && nums[left] == nums[left - 1])
                            left++;
                        while (left < right && nums[right] == nums[right + 1])
                            right--;
                    }
                    else if (nums[i] + nums[left] + nums[right] > 0)
                        right--;
                    else
                        left++;
                }
            }
            foreach (var item in res)
            {
                foreach (var i in item)
                {
                    Console.WriteLine(i);
                }
            }            
            return res;
        }

        public void GenarateRendomNumber(int minnum, int maxnum)
        {
            List<double> lstrandom = new List<double>();
            Random r = new Random();
            int num = r.Next();
            lstrandom.Add(num);
            int num1 = r.Next(maxnum);
            lstrandom.Add(num1);
            int num2 = r.Next(minnum, maxnum);
            lstrandom.Add(num2);
            double num3 = r.NextDouble();
            lstrandom.Add(num3);

            foreach (var item in lstrandom)
            {
                Console.WriteLine(item);
            }
        }

        public void Genarate10RendomNumber()
        {
            Random r = new Random();
            int[] num = new int[10];
            for (int i = 0; i < 10; i++)
            {
                num[i] = r.Next(1, 1000);
            }
            foreach (var item in num)
            {
                Console.WriteLine(item);
            }
        }

        public void Genarate10NumberGetMaxNumber()
        {
            Random random = new Random();
            var arrayindex = Console.ReadLine();
            int[] num = new int[Convert.ToInt32(arrayindex)];
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = random.Next(1, 5000);
            }
            int max = num[0];
            foreach (var item in num)
            {
                if (max < item)
                {
                    max = item;
                }
                Console.WriteLine("Number :" + item);
            }
            Console.WriteLine("Max :" + max);
        }

        public void Genarate3NumberFindBigger()
        {
            int[] num = new int[3];
            Random random = new Random();
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = random.Next(1000, 5000);
            }
            if (num[0] > num[1])
            {
                if (num[0] > num[2])
                    Console.WriteLine("num[0] = {0} bigger.", num[0]);
                else
                    Console.WriteLine("num[2] = {0} bigger.", num[2]);
            }
            else
            {
                if (num[1] > num[2])
                    Console.WriteLine("num[1] = {0} bigger.", num[1]);
                else
                    Console.WriteLine("num[2] = {0} bigger.", num[2]);
            }
            Console.WriteLine("num[0] = {0}, num[1] = {1}, num[2] = {2}", num[0], num[1], num[2]);
        }

        public void FindEvenOrOddNumber()
        {
            var num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("The Number {0} is Even.", num);
            }
            else
            {
                Console.WriteLine("The Number {0} is Odd.", num);
            }
        }

        public void LowerBetweenTwoNumber()
        {
            Console.WriteLine("Input 1st Number");
            var num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input 2st Number");
            var num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
                Console.WriteLine("Number2 {0} is Lower", num2);
            else
                Console.WriteLine("Number1 {0} is Lower", num1);

            Console.WriteLine("Number1 is {0} and Number2 is {1}", num1, num2);
        }

        public void CalculateTotalSalary()
        {
            Console.WriteLine("Input Salary");
            double salary = Convert.ToDouble(Console.ReadLine());
            double houserand = (40 * salary) / 100;
            Console.WriteLine("40% HouseRand Of Salary is {0}",houserand);
            double medical = (10 * salary) / 100;
            Console.WriteLine("10% Medical Of Salary is {0}",medical);
            double totalsalary = salary + houserand + medical;
            Console.WriteLine("Total Salary is {0}", totalsalary);
        }

        public void ShowNumberInRange()
        {
            Console.WriteLine("Input Number Length for Show Number");
            int max = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[max];
            StringBuilder n = new StringBuilder();
            for (int i = 0; i < max; i++)
            {
                num[i] = i + 1;
                n.Append(i + 1 + " ,");
            }
            
            Console.WriteLine($@"the Number is {n}");
        }
    }
}
