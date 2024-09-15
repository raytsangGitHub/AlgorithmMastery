using LeetCode150Lib;
using Microsoft.Extensions.DependencyInjection;

namespace LeetCodeLibNunit.TwoPointers
{
    public class ValidPalindrome125Test : TestBase
    {
        private IAlgoMasteryOperation<bool>? _validPalindrome;

        [SetUp]
        public void TestSetup()
        {
            _validPalindrome = ServiceProvider.GetService<IAlgoMasteryOperation<bool>>();
        }

        [TestCase("A man, a plan, a canal: Panama", true)]
        [TestCase("race a car", false)]
        [TestCase("", true)]
        public void GenerateParenthesesEdge(string n, bool expected)
        {
            var res = _validPalindrome?.Execute(n);
            Assert.AreEqual(expected, res);
        }
    }
}