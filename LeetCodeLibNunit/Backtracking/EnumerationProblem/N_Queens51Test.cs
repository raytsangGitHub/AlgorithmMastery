using LeetCode150Lib.Backtracking.OptimizationProblems;
using Microsoft.Extensions.DependencyInjection;

namespace LeetCodeLibNunit.Backtracking.EnumerationProblem
{
    public class N_Queens51Test : TestBase
    {
        //aggregation
        private IBacktrackingOperation<IList<IList<string>>>? _nQueens51;

        [SetUp]
        public void TestSetup()
        {
            //Property DI:  get the service from IServiceProvider
            _nQueens51 = ServiceProvider.GetService<IBacktrackingOperation<IList<IList<string>>>>() ?? throw new InvalidOperationException("Service not found.");
        }

        // *** Test Data
        // Create a test case source
        private static readonly object[] _testCaseSource =
        {
            new object[]
            {
                3,
                new string[][]
                {
                    new string[] {".Q..", "...Q", "Q...", "..Q." },
                    new string[] {"..Q.", "Q...", "...Q", ".Q.."}
            }   }
        };

        // *** validation testing
        // Test method using TestCaseSource
        //[TestCaseSource(nameof(_testCaseSource))]
        //public void N_QueensTest(int n, int expected)
        //{
        //    var res = _nQueens51?.Execute(n);
        //    // Assert.That(res, Is.EqualTo(expected.));
        //}
    }
}