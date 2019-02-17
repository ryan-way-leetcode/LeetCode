using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeNumber;

namespace LeetCodeTest.Easy
{
    [TestClass]
    public class PalindromeNumberTest
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
            Assert.AreEqual(Solution.IsPalindrome(121), true);
        }

        [TestMethod]
        public void Example2()
        {
            Assert.AreEqual(Solution.IsPalindrome(-121), false);
        }

        [TestMethod]
        public void Example3()
        {
            Assert.AreEqual(Solution.IsPalindrome(10), false);
        }
    }
}
