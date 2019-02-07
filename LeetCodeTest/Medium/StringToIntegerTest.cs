using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringToInteger;

namespace LeetCodeTest
{
    [TestClass]
    public class StringToIntegerTest
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
            Assert.AreEqual(Solution.MyAtoi("42"), 42);
        }

        [TestMethod]
        public void Example2()
        {
            Assert.AreEqual(Solution.MyAtoi("   -42"), -42);
        }

        [TestMethod]
        public void Example3()
        {
            Assert.AreEqual(Solution.MyAtoi("4193 with words"), 4193);
        }

        [TestMethod]
        public void Example4()
        {
            Assert.AreEqual(Solution.MyAtoi("words and 987"), 0);
        }

        [TestMethod]
        public void Example5()
        {
            Assert.AreEqual(Solution.MyAtoi("-91283472332"), int.MinValue);
        }
    }
}
