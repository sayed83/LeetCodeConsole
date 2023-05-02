using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LeetCodeConsole
{    
    public static class LeetCodes
    {
        //21. Merge Two Sorted Lists
        //Input: list1 = [1,2,4], list2 = [1,3,4]
        //Output: [1,1,2,3,4,4]
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null)
                return list2;
            if (list2 == null)
                return list1;


            if (list2.val > list1.val)
            {
                list1.next = MergeTwoLists(list1.next, list2);

                return list1;
            }

            list2.next = MergeTwoLists(list1, list2.next);
            return list2;
        }

        public static ListNode MergeTwoLists1(ListNode l1, ListNode l2)
        {
            ListNode sentinel = new ListNode();
            ListNode p1 = l1, p2 = l2, p3 = sentinel;
            while (p1 != null && p2 != null)
            {
                if (p1.val < p2.val)
                {
                    AppendNode(ref p1, ref p3);
                }
                else
                {
                    AppendNode(ref p2, ref p3);
                }
            }

            while (p1 != null)
            {
                AppendNode(ref p1, ref p3);
            }

            while (p2 != null)
            {
                AppendNode(ref p2, ref p3);
            }

            return sentinel.next;
        }

        private static void AppendNode(ref ListNode src, ref ListNode dst)
        {
            ListNode t = new ListNode(src.val);
            dst.next = t;
            dst = dst.next;
            src = src.next;
        }

        //392. Is Subsequence
        //Input: s = "abc", t = "ahbgdc"
        //Output: true
        //public static bool IsSubsequence(string s, string t)
        //{

        //}
        //205. Isomorphic Strings
        //Input: s = "egg", t = "add"
        //Output: true
        public static bool IsIsomorphic(string s, string t)
        {
            var d = new Dictionary<char, char>();
            var h = new HashSet<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (d.ContainsKey(s[i])){
                    if (d[s[i]] != t[i])
                    {
                        return false;
                    }
                }
                else
                {
                    if (h.Contains(t[i]))
                    {
                        return false;
                    }
                    d.Add(s[i], t[i]);
                    h.Add(t[i]);
                }
            }
            return true;
        }

        //844. Backspace String Compare
        //Input: s = "ab#c", t = "ad#c"
        //Output: true
        //Explanation: Both s and t become "ac".

        //69 / 114 test cases passed.
        //Wrong Answer
        public static bool BackspaceCompare(string s, string t)
        {
            Stack<char> s1 = new Stack<char>();
            Stack<char> s2 = new Stack<char>();
            foreach (char c in s)
            {
                if (c != '#')
                {
                    s1.Push(c);
                }
                else if (s1.Count > 0)
                {
                    s1.Pop();
                }
            }

            foreach (char c in s)
            {
                if (c != '#')
                { 
                    s2.Push(c); 
                }
                else if (s2.Count > 0)
                {
                    s2.Pop();
                }
            }
            if (s1.Count != s2.Count)
            {
                return false;
            }
                
            while (s1.Count > 0)
            {
                if (s1.Pop() != s2.Pop())
                {
                    return false;
                }                    
            }                
            return true;
        }
        // Accepted
        public static bool BackspaceCompare1(string s, string t)
        {
            string s2 = RemoveBackSpace(s);
            string t2 = RemoveBackSpace(t);
            return s2 == t2;
        }
        private static string RemoveBackSpace(string S)
        {
            int skipChars = 0;
            StringBuilder str = new StringBuilder();
            for (int i = S.Length - 1; i >= 0; i--)
            {
                if (S[i] == '#')
                    skipChars++;
                else if (skipChars > 0)
                    skipChars--;
                else
                    str.Append(S[i]);
            }

            return str.ToString();
        }

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
            for (int i = 1; i < nums.Length; i++)
            {
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
