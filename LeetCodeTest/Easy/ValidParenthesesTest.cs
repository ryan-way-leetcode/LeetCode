using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Easy.ValidParentheses;

namespace LeetCodeTest.Easy
{
    [TestClass]
    public class ValidParenthesesTest
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
            Assert.AreEqual(Solution.IsValid("()"), true);
        }

        [TestMethod]
        public void Example2()
        {
            Assert.AreEqual(Solution.IsValid("()[]{}"), true);
        }

        [TestMethod]
        public void Example3()
        {
            Assert.AreEqual(Solution.IsValid("(]"), false);
        }

        [TestMethod]
        public void Example4()
        {
            Assert.AreEqual(Solution.IsValid("([)]"), false);
        }

        [TestMethod]
        public void Example5()
        {
            Assert.AreEqual(Solution.IsValid("{[]}"), true);
        }

        [TestMethod]
        public void Found1()
        {
            Assert.AreEqual(Solution.IsValid(""), true);
        }
    }
}
