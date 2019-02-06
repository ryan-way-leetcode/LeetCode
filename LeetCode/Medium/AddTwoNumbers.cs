using System;
using System.Collections.Generic;
using System.Text;

namespace AddTwoNumbers
{
   
    ///Definition for singly-linked list.
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
   
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int carry = 0;
            ListNode Head = new ListNode(l1.val + l2.val);
            carry = Head.val / 10;
            Head.val %= 10;
            l1 = l1.next;
            l2 = l2.next;
            ListNode Solution = Head;
            while (l1 != null && l2 != null)
            {
                Solution.next = new ListNode(l1.val + l2.val + carry);
                Solution = Solution.next;
                carry = Solution.val / 10;
                Solution.val %= 10;
                l1 = l1.next;
                l2 = l2.next;
            }
            if (l1 != null) Solution.next = l1;
            else if (l2 != null) Solution.next = l2;

            while (carry != 0)
            {
                if (Solution.next == null) Solution.next = new ListNode(carry);
                else Solution.next.val = Solution.next.val + carry;
                Solution = Solution.next;
                carry = Solution.val / 10;
                Solution.val %= 10;
            }


            return Head;
        }
    }
}
