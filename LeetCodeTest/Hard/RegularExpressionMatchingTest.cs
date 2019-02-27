using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Hard.RegularExpressionMatching;

namespace LeetCodeTest.Hard
{
    [TestClass]
    public class RegularExpressionMatchingTest
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
            Assert.AreEqual(false, Solution.IsMatch("aa", "a"));
        }

        [TestMethod]
        public void Example2()
        {
            Assert.AreEqual(true, Solution.IsMatch("aa", "a*"));
        }

        [TestMethod]
        public void Example3()
        {
            Assert.AreEqual(true, Solution.IsMatch("ab", ".*"));
        }

        [TestMethod]
        public void Example4()
        {
            Assert.AreEqual(true, Solution.IsMatch("aab", "c*a*b"));
        }

        [TestMethod]
        public void Example5()
        {
            Assert.AreEqual(false, Solution.IsMatch("mississippi", "mis*is*p*."));
        }

        [TestMethod]
        public void Failed1()
        {
            Assert.AreEqual(true, Solution.IsMatch("aaa", "a*a"));
        }

        [TestMethod]
        public void Failed2()
        {
            Assert.AreEqual(true, Solution.IsMatch("a", "ab*"));
        }

        [TestMethod]
        public void Failed3()
        {
            Assert.AreEqual(true, Solution.IsMatch("", "c*c*"));
        }
    }
}
