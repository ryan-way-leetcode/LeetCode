using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Medium.RemoveNthNodeFromEndOfList
{

    // Definition for singly-linked list.
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
        public override bool Equals(object obj)
        {
            if (obj is ListNode listNode)
            {
                ListNode this_curr = this;
                ListNode that_curr = listNode;

                while (this_curr != null && that_curr != null)
                {
                    if (this_curr.val != that_curr.val) return false;
                    else
                    {
                        this_curr = this_curr.next;
                        that_curr = that_curr.next;
                    }
                }
                return true;
            }
            else return false;
        }
    }
    public class Solution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode curr = head;
            int length = 0;
            while(curr != null)
            {
                curr = curr.next;
                length++;
            }

            ListNode retVal = null, construct = null;
            int count = 0;
            curr = head;
            while(curr != null)
            {
                if(count + n != length)
                {
                    if (retVal == null)
                    {
                        retVal = new ListNode(curr.val);
                        construct = retVal;
                    }
                    else
                    {
                        construct.next = new ListNode(curr.val);
                        construct = construct.next;
                    }
                }
                curr = curr.next;
                count++;
            }
            return retVal;
        }
    }
}
