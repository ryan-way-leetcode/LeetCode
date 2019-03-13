using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Medium.ZigZagConversion;

namespace LeetCodeTest.Medium
{
    [TestClass]
    public class ZigZagConversionTest
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
            Assert.AreEqual("PAHNAPLSIIGYIR", Solution.Convert("PAYPALISHIRING", 3));
        }

        [TestMethod]
        public void Example2()
        {
            Assert.AreEqual("PINALSIGYAHRPI", Solution.Convert("PAYPALISHIRING", 4));
        }

        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual("", Solution.Convert("", 4));
        }

        [TestMethod]
        public void Failed1()
        {
            Assert.AreEqual("A", Solution.Convert("A", 1));
        }
        
    }
}
