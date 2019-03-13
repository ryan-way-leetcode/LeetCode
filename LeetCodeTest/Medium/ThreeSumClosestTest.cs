using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Medium.ThreeSumClosest;
using System.Collections.Generic;

namespace LeetCodeTest.Medium
{
    [TestClass]
    public class ThreeSumClosestTest
    {
        public Solution Solution;

        [TestInitialize]
        public void Initialization()
        {
            Solution = new Solution();
        }

        [TestMethod]
        public void Example1()
        {
            Assert.AreEqual(Solution.ThreeSumClosest(new int[] { -1, 2, 1, -4 }, 1), 2);
        }

        [TestMethod]
        public void Failed1()
        {
            Assert.AreEqual(Solution.ThreeSumClosest(new int[] { 1, 1, 1, 1 }, -100), 3);
        }

        [TestMethod]
        public void Failed2()
        {
            Assert.AreEqual(Solution.ThreeSumClosest(new int[] { 1, 1, -1, -1, 3 }, -1), 1);
        }
        
    }
}
