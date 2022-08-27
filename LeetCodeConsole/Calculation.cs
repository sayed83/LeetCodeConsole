using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            //Hashtable _diffs = new Hashtable();

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    var num = nums[i];
            //    var difference = target - nums[i];

            //    if (_diffs.ContainsKey(difference))
            //    {
            //        return new int[] { i, (int)_diffs[difference] };
            //    }

            //    if (!_diffs.ContainsKey(num))
            //    {
            //        _diffs.Add(num, i);
            //    }
            //}
            //return null;

            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
                if (dictionary.ContainsKey((target - nums[i])))
                    return new[] { dictionary[(target - nums[i])], i };
                else
                    dictionary.TryAdd(nums[i], i);
            return null;
        }
    }
}
