using LeetCode150Lib;
using Microsoft.Extensions.DependencyInjection;

namespace LeetCodeLibNunit.TwoPointers
{
    public class TwoSumII167Test : TestBase
    {
        private IAlgoMasteryOperation<int[]>? _twoPointerOperation;

        [SetUp]
        public void TestSetup()
        {
            _twoPointerOperation = ServiceProvider.GetService<IAlgoMasteryOperation<int[]>>();
        }

        [TestCase(new int[] { 2, 7, 11, 15 }, 9, new int[] { 1, 2 })]
        public void validTest(int[] input, int k, int[] expected)
        {
            var result = _twoPointerOperation?.Execute(input, k);
            Assert.AreEqual(expected, result);
        }

        //The expected is {0, 0 }, because code initialize the array to 2.
        [TestCase(new int[] { 2, 3, 4 }, 10, new int[] { 0, 0 })]
        public void NoneExisted(int[] input, int k, int[] expected)
        {
            var result = _twoPointerOperation.Execute(input, k);
            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] { -1, 0 }, -1, new int[] { 1, 2 })]
        public void EdgeTest(int[] input, int k, int[] expected)
        {
            var result = _twoPointerOperation.Execute(input, k);
            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] { 2, 15, 7, 11 }, 9, new int[] { 1, 2 })]
        public void MethodSortInputAscending(int[] input, int k, int[] expected)
        {
            var result = _twoPointerOperation?.Execute(input, k);
            Assert.AreEqual(expected, result);
        }
    }
}