using LeetCode150Lib;
using Microsoft.Extensions.DependencyInjection;

namespace LeetCodeLibNunit.Backtracking.EnumerationProblem
{
    public class GenerateParentheses22Test : TestBase
    {
        private IAlgoMasteryOperation<IList<string>>? _generateParentheses22;

        [SetUp]
        public void TestSetup()
        {
            // get the service from IServiceProvider
            _generateParentheses22 = ServiceProvider.GetService<IAlgoMasteryOperation<IList<string>>>();
        }

        // *** Test Data
        // Create a test case source
        private static readonly object[] _testCaseSource =
        [
            new object[] { 3, new string[] { "((()))", "(()())", "(())()", "()(())", "()()()" } },
            new object[] { 2, new string[] { "(())", "()()" } }
        ];

        // *** validation testing
        // Test method using TestCaseSource
        [TestCaseSource(nameof(_testCaseSource))]
        public void GenerateParentheses(int n, string[]? expected)
        {
            var res = _generateParentheses22?.Execute(n);
            Assert.That(res, Is.EqualTo(expected));
        }

        //Edge case testing
        [TestCase(-1, null)]
        [TestCase(0, null)]
        public void GenerateParenthesesEdge(int n, string[]? expected)
        {
            var res = _generateParentheses22?.Execute(n);
            Assert.That(res, Is.EqualTo(expected));
        }
    }
}