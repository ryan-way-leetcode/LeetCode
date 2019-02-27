using System;
using System.Collections.Generic;

namespace LeetCode.Easy.MergeTwoSortedLists
{
     //Definition for singly-linked list.
     public class ListNode
     {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
        public override bool Equals(object obj)
        {
            if (obj is ListNode listNode)
            {
                ListNode this_curr = this;
                ListNode that_curr = listNode;

                while(this_curr != null && that_curr != null)
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
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null) return l2;
            if (l2 == null) return l1;
            ListNode head = null, curr_ret = null, curr1 = l1, curr2 = l2;
            while(curr1 != null && curr2 != null)
            {
                if(head == null)
                {
                    int min;
                    if(curr1.val < curr2.val)
                    {
                        min = curr1.val;
                        curr1 = curr1.next;
                    }
                    else
                    {
                        min = curr2.val;
                        curr2 = curr2.next;
                    }
                    head = new ListNode(min);
                    curr_ret = head;
                }
                else
                {
                    int min;
                    if (curr1.val < curr2.val)
                    {
                        min = curr1.val;
                        curr1 = curr1.next;
                    }
                    else
                    {
                        min = curr2.val;
                        curr2 = curr2.next;
                    }
                    curr_ret.next = new ListNode(min);
                    curr_ret = curr_ret.next;
                }
            }

            while (curr1 != null)
            {
                curr_ret.next = new ListNode(curr1.val);
                curr_ret = curr_ret.next;
                curr1 = curr1.next;
            }
            while (curr2 != null)
            {
                curr_ret.next = new ListNode(curr2.val);
                curr_ret = curr_ret.next;
                curr2 = curr2.next;
            }
            return head;
        }
    }
}
