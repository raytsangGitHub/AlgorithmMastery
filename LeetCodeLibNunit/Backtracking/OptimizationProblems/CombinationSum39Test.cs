using LeetCode150Lib.Backtracking.OptimizationProblems;
using Microsoft.Extensions.DependencyInjection;

namespace LeetCodeLibNunit.Backtracking.OptimizationProblems
{
    public class CombinationSum39Test : TestBase
    {
        private IBacktrackingOperation<IList<IList<int>>>? _combinationSum39;

        [SetUp]
        public void TestSetup()
        {
            //get the service from ServiceProvider
            _combinationSum39 = ServiceProvider.GetService<IBacktrackingOperation<IList<IList<int>>>>();
        }

        //validation testing
        //Input: candidates = [2,3,6,7], target = 7
        // Output: [[2, 2, 3],[7]]
        [TestCase()]
        public void CombinationSum()
        {
            int[] cand = { 8, 2, 3, 6, 7 };
            int target = 7;
            int expectedCount = 2;
            var res = _combinationSum39?.Execute(cand, target);
            Assert.That(res.Count, Is.EqualTo(expectedCount));
        }

        //Input: candidates = [2,3,5], target = 8
        // Output: [[2, 2, 2, 2],[2, 3, 3],[3, 5]]

        //Input: candidates = [2], target = 1
        //Output: []
        //[Test]
    }
}