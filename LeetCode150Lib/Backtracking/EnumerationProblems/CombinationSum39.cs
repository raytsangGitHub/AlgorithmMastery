namespace LeetCode150Lib.Backtracking.EnumerationProblems
{
    /// <summary>
    /// 1. Given an array of distinct integers candidates and a target integer target, return a list of all unique combinations of candidates where the chosen numbers sum to target. You may return the combinations in any order.
    /// 2. The same number may be chosen from candidates an unlimited number of times. Two combinations are unique if the frequency of at least one of the chosen numbers is different.
    /// 3. The test cases are generated such that the number of unique combinations that sum up to target is less than 150 combinations for the given input.
    /// </summary>
    public class CombinationSum39 : IAlgoMasteryOperation<IList<IList<int>>>
    {
        private static readonly IList<IList<int>>? _res = new List<IList<int>>();
        private static List<int>? _isValid;
        private int idx = 0;

        public CombinationSum39()
        {
            _isValid = new List<int>();
        }

        //public IList<IList<int>> Execute(int[] candidates, int target)
        public IList<IList<int>> Execute(params object[] parameters)
        {
            int[] candidates = (int[])parameters[0];
            int target = (int)parameters[1];
            Array.Sort(candidates);
            BackTracking(candidates, idx, target);
            return _res;
        }

        //start back tracking -recursive
        private static void BackTracking(int[] candidates, int idx, int target)
        {
            Console.WriteLine(new string('-', target) + "Entering Backtrack: index = " + idx + " target = " + target);
            // *** static method can not access instance fields/properties.
            //There are two ways to fix it:
            //1)To access the instance fields/properties, it must create an instance.
            //2) make the class fiels/properties static.
            //Demo: res is static and isValid.
            //   CombinationSum39 combinationSum39 = new CombinationSum39();

            if (target == 0)
            {
                _res.Add(_isValid.ToList());
                return;
            }
            else
            {
                //use a for loop is better, if we set the start point at 0. no need to pass in idx in the method.
                while (idx < candidates.Length)
                {
                    //This is the base case, it breaks out from recursion if the condition is false.
                    if (candidates[idx] > target)
                    {
                        break;
                    }
                    _isValid.Add(candidates[idx]);
                    BackTracking(candidates, idx, target - candidates[idx]);
                    //remove the last added number, because the total > 7.
                    _isValid.RemoveAt(_isValid.Count - 1);
                    idx++;  //increment to the next number in candidate.
                }
            }
            Console.WriteLine(new string('-', target) + "Exiting Backtrack: index = " + idx + " target = " + target);
        }
    }
}