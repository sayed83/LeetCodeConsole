using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeConsole
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class PalindromeLinkedList
    {        
        public bool IsPalindrome(ListNode head)
        {

            if (head == null)
                return true;

            Stack<int> stack = new Stack<int>();
            ListNode curr = head;
            while (curr != null)
            {
                stack.Push(curr.val);
                curr = curr.next;
            }

            curr = head;
            while (curr != null)
            {
                if (stack.Count == 0 || stack.Peek() != curr.val)
                    return false;

                stack.Pop();
                curr = curr.next;
            }

            return stack.Count == 0;
        }
    }
}
