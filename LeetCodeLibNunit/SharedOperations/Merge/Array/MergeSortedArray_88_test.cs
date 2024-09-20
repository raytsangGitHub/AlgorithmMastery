using LeetCode150Lib;
using Microsoft.Extensions.DependencyInjection;

namespace LeetCodeLibNunit.SharedOperations.Merge.Array
{
    public class MergeSortedArray_88_test : TestBase
    {
        private IAlgoMasteryOperation<int[]>? _algoMasteryOperation;

        [SetUp]
        public void TestSetup()
        {
            _algoMasteryOperation =
                ServiceProvider.GetService<IAlgoMasteryOperation<int[]>>();
        }

        public static IEnumerable<TestCaseData> MergeArrayData
        {
            get
            {
                //test for Two List Have Different Length
                yield return new TestCaseData(
                    new[] { 1, 3, 7, 10 },
                    new[] { 4, 8, 20 },
                    new[] { 1, 3, 4, 7, 8, 10, 20 }
                );
                yield return new TestCaseData(
                    new[] { 1 },
                    new int[] { },
                    new[] { 1 }
                );
                yield return new TestCaseData(
                    new int[] { },
                    new[] { 1 },
                    new[] { 1 }
                );
                //both array empty
                yield return new TestCaseData(
                    new int[] { },
                    new int[] { },
                    new int[] { }
                );
            }
        }

        [TestCaseSource(nameof(MergeArrayData))]
        public void MergeSortedArray(int[] input1, int[] input2, int[] expected)
        {
            int[] actual = (_algoMasteryOperation).Execute(input1, input2);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}