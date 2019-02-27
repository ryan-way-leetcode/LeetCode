using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Easy.RomanToInteger;

namespace LeetCodeTest.Easy
{
    [TestClass]
    public class RomanToIntegerTest
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
            Assert.AreEqual(Solution.RomanToInt("III"), 3);
        }

        [TestMethod]
        public void Example2()
        {
            Assert.AreEqual(Solution.RomanToInt("IV"), 4);
        }

        [TestMethod]
        public void Example3()
        {
            Assert.AreEqual(Solution.RomanToInt("IX"), 9);
        }

        [TestMethod]
        public void Example4()
        {
            Assert.AreEqual(Solution.RomanToInt("LVIII"), 58);
        }

        [TestMethod]
        public void Example5()
        {
            Assert.AreEqual(Solution.RomanToInt("MCMXCIV"), 1994);
        }
    }
}
