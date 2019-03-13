using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Medium.ThreeSum;
using System.Collections.Generic;

namespace LeetCodeTest.Medium
{
    [TestClass]
    public class ThreeSumTest
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
            List<List<int>> expected = new List<List<int>>()
            {
                new List<int>(){-1, 0, 1 },
                new List<int>(){-1, -1, 2 },
            };
            Assert.AreEqual(expected, Solution.ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 }));
        }

        [TestMethod]
        public void Failed1()
        {
            Assert.AreEqual(new List<List<int>>(), Solution.ThreeSum(new int[] { 0, 0, 0 }));
        }
        
    }
}
