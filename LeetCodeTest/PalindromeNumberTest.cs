using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeNumberS;

namespace LeetCodeTest
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
    }
}
