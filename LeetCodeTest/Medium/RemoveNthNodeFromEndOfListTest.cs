using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Medium.RemoveNthNodeFromEndOfList;
using System.Collections.Generic;

namespace LeetCodeTest.Medium
{
    [TestClass]
    public class RemoveNthNodeFromEndOfListTest
    {
        public Solution Solution;

        public ListNode ListToLinked(List<int> list)
        {
            ListNode head = null, curr = null;
            foreach (var item in list)
            {
                if (head == null)
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
        public void MyTestMethod()
        {
            ListNode expected = ListToLinked(new List<int>() { 1, 2, 3, 5 });
            ListNode actual = Solution.RemoveNthFromEnd(ListToLinked(new List<int>() { 1, 2, 3, 4, 5 }), 2);
            Assert.AreEqual(expected, actual);
        }

    }
}
