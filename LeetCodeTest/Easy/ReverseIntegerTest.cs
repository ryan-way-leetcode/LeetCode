using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReverseInteger;

namespace LeetCodeTest.Easy
{
    [TestClass]
    public class ReverseIntegerTest
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
            Assert.AreEqual(Solution.Reverse(123), 321);
        }

        [TestMethod]
        public void Example2()
        {
            Assert.AreEqual(Solution.Reverse(-123), -321);
        }

        [TestMethod]
        public void Example3()
        {
            Assert.AreEqual(Solution.Reverse(120), 21);
        }

        [TestMethod]
        public void Failed1()
        {
            Assert.AreEqual(Solution.Reverse(-2147483412), -2143847412);
        }

        [TestMethod]
        public void Failed2()
        {
            Assert.AreEqual(Solution.Reverse(-2147483648), 0);
        }

        [TestMethod]
        public void Failed3()
        {
            Assert.AreEqual(Solution.Reverse(1), 1);
        }
    }
}
