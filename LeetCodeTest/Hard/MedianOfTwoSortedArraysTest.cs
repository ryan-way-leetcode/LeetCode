using Microsoft.VisualStudio.TestTools.UnitTesting;
using MedianOfTwoSortedArrays;

namespace LeetCodeTest.Hard
{
    [TestClass]
    public class MedianOfTwoSortedArraysTest
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
            double actual = Solution.FindMedianSortedArrays(new int[] { 1, 3 }, new int[] { 2 });
            Assert.AreEqual(2.0, actual);
            actual = Solution.FindMedianSortedArrays(new int[] { 2 }, new int[] { 1, 3 });
            Assert.AreEqual(2.0, actual);
        }

        [TestMethod]
        public void Example2()
        {
            double actual = Solution.FindMedianSortedArrays(new int[] { 1, 2 }, new int[] { 3, 4 });
            Assert.AreEqual(2.0, actual);
            actual = Solution.FindMedianSortedArrays(new int[] { 3, 4 }, new int[] { 1, 2 });
            Assert.AreEqual(2.0, actual);
        }

        [TestMethod]
        public void Failed1()
        {
            double actual = Solution.FindMedianSortedArrays(new int[] { }, new int[] { 1 });
            Assert.AreEqual(1.0, actual);
            actual = Solution.FindMedianSortedArrays(new int[] { 1 }, new int[] { });
            Assert.AreEqual(1.0, actual);
        }

        [TestMethod]
        public void Failed2()
        {
            double actual = Solution.FindMedianSortedArrays(new int[] { 1 }, new int[] { 1 });
            Assert.AreEqual(1.0, actual);
        }
    }
}
