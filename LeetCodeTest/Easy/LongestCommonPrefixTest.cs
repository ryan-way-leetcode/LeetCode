using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Easy.LongestCommonPrefix;

namespace LeetCodeTest.Easy
{
    [TestClass]
    public class LongestCommonPrefixTest
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
            Assert.AreEqual(Solution.LongestCommonPrefix(new string[3] { "flower", "flow", "flight" }), "fl");
        }

        [TestMethod]
        public void Example2()
        {
            Assert.AreEqual(Solution.LongestCommonPrefix(new string[3] { "dog", "racecar", "car" }), "");
        }

        [TestMethod]
        public void Failed1()
        {
            Assert.AreEqual(Solution.LongestCommonPrefix(new string[0] { }), "");
        }

        [TestMethod]
        public void Found1()
        {
            Assert.AreEqual(Solution.LongestCommonPrefix(new string[1] { "something" }), "something");
        }
    }
}
