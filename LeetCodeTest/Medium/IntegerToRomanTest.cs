using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntegerToRoman;

namespace LeetCodeTest
{
    [TestClass]
    public class IntegerToRomanTest
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
            Assert.AreEqual(Solution.IntToRoman(3), "III");
        }

        [TestMethod]
        public void Example2()
        {
            Assert.AreEqual(Solution.IntToRoman(4), "IV");
        }

        [TestMethod]
        public void Example3()
        {
            Assert.AreEqual(Solution.IntToRoman(9), "IX");
        }

        [TestMethod]
        public void Example4()
        {
            Assert.AreEqual(Solution.IntToRoman(58), "LVIII");
        }

        [TestMethod]
        public void Example5()
        {
            Assert.AreEqual(Solution.IntToRoman(1994), "MCMXCIV");
        }

        [TestMethod]
        public void Failed1()
        {
            Assert.AreEqual(Solution.IntToRoman(10), "X");
        }
    }
}
