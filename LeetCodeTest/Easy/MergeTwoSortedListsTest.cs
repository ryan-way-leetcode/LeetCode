using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Easy.MergeTwoSortedLists;
using System.Collections.Generic;

namespace LeetCodeTest.Easy
{
    [TestClass]
    public class MergeTwoSortedListsTest
    {
        public Solution Solution;

        public ListNode ListToLinked(List<int> list)
        {
            ListNode head = null, curr = null;
            foreach (var item in list)
            {
                if(head == null)
                {
                    head = new ListNode(item);
                    curr = new ListNode(item);
                }
                else
                {
                    curr.next = new ListNode(item);
                    curr = curr.next;
                }
            }
            return head;
        }

        [TestInitialize]
        public void Initialization()
        {
            Solution = new Solution();
        }

        [TestMethod]
        public void HelperTest1()
        {
            Assert.AreEqual(ListToLinked(new List<int>() { 1, 2, 3 }), ListToLinked(new List<int> { 1, 2, 3 }));
        }
        [TestMethod]
        public void Example1()
        {
            ListNode param1 = ListToLinked(new List<int>() { 1, 2, 4 });
            ListNode param2 = ListToLinked(new List<int>() { 1, 3, 4 });
            ListNode expected = ListToLinked(new List<int>() { 1, 1, 2, 3, 4, 4 });
            Assert.AreEqual(expected, Solution.MergeTwoLists(param1, param2));
        }
    }
}
