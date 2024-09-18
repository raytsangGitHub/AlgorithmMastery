using LeetCode150Lib;
using Microsoft.Extensions.DependencyInjection;

namespace LeetCodeLibNunit.SharedOperations.Merge.LinkedList
{
    public class MergeTwoSortedLists_InPlace_21_test : TestBase
    {
        private IAlgoMasteryOperation<List<int>>? _mergeTwoListInPlace;

        [SetUp]
        public void TestSetup()
        {
            _mergeTwoListInPlace = ServiceProvider.GetService<IAlgoMasteryOperation<List<int>>>();
        }

        public static IEnumerable<TestCaseData> LinkedListTestData
        {
            get
            {
                //test for Two List Have Different Length
                yield return new TestCaseData(
                    new LinkedList<int>(new[] { 2, 4 }),
                    new LinkedList<int>(new[] { 1, 3, 4 }),
                    new List<int>(new[] { 1, 2, 3, 4, 4 })
                );
                //test for lists have duplicate value
                yield return new TestCaseData(
                    new LinkedList<int>(new[] { 1, 2, 4 }),
                    new LinkedList<int>(new[] { 1, 3, 4 }),
                    new List<int>(new[] { 1, 1, 2, 3, 4, 4 })
                );
                //test for One Of The List Is Empty
                yield return new TestCaseData(
                    new LinkedList<int>(),
                    new LinkedList<int>(new[] { 1, 3, 4 }),
                    new List<int>(new[] { 1, 3, 4 })
                );
                //Both List Are Empty
                yield return new TestCaseData(
                    new LinkedList<int>(),
                    new LinkedList<int>(),
                    new List<int>()
                );
            }
        }

        [TestCaseSource(nameof(LinkedListTestData))]
        public void MergeTwoList(LinkedList<int> list1, LinkedList<int> list2, List<int> expectedResult)
        {
            var actual = _mergeTwoListInPlace?.Execute(list1, list2);

            // Assert
            Assert.That(actual, Is.EqualTo(expectedResult));
        }
    }
}