using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeConsole
{
    public static class LeetCodes
    {
        
        public static int[] twoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == target - nums[i])
                    {
                        result[i] = i;
                        return result;
                    }
                }
            }
            throw new Exception("error");
        }

        public static void Rotate(int[] nums, int k)
        {
            //Input: nums = [1,2,3,4,5,6,7], k = 3
            //Output: [5,6,7,1,2,3,4]
            // Solution 1 -- Time: O(n), Space: O(n)
            int[] output = new int[nums.Length];
            int length = nums.Length;
            for (int i = 0; i < nums.Length; i++)
            {
                output[(i + k) % length] = nums[i];
            }
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = output[i];
            }
        }

        // 1480. Running Sum of 1d Array
        //Input: nums = [1,2,3,4]
        //Output: [1,3,6,10]
        //Explanation: Running sum is obtained as follows: [1, 1+2, 1+2+3, 1+2+3+4].
        public static int[] RunningSum(int[] nums)
        {
            int[] ints = new int[nums.Length];
            var num = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                num += nums[i];
                ints[i] = num;                
            }
            return ints;
        }

        //724. Find Pivot Index
        //Input: nums = [1,7,3,6,5,6]
        //Output: 3
        //Explanation:
        //The pivot index is 3.
        //Left sum = nums[0] + nums[1] + nums[2] = 1 + 7 + 3 = 11
        //Right sum = nums[4] + nums[5] = 5 + 6 = 11

        public static int PivotIndex1(int[] nums)
        {
            if (nums.Length == 1) return 0;
            int left = 0;
            int right = nums.Skip(1).Sum(); 
            int len = nums.Length;

            if (left == right)
                return 0;

            for (int i = 1; i < len; i++)
            {
                left += nums[i - 1];
                right -= nums[i];
                if (left == right)
                    return i;
            }
            return -1;
        }
        // 60% ok
        public static int PivotIndex(int[] nums)
        {
            int left = 0;
            int right = nums.Skip(1).Sum();

            if (nums == null || nums.Length == 0)
            {
                return -1;
            }
            for (int i = 1; i < nums.Length; i++){
                left += nums[i - 1];
                right -= nums[i];
                if (left == right)
                {
                    return i;
                }
            }
            return -1;
        }
        // 100% ok
        public static int PivotIndex3(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return -1;
            int sum = nums.Sum();
            int leftsum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if ((sum = (sum - nums[i])) == leftsum)
                    return i;
                else
                    leftsum += nums[i];
            }
            return -1;
        }
    }
}
