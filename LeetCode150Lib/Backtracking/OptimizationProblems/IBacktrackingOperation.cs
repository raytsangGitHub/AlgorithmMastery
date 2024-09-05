namespace LeetCode150Lib.Backtracking.OptimizationProblems
{
    /// <summary>
    /// An interface designed for all backtracking problems, implemented using generics and params to add flexibility for future methods that may require more than one parameter.
    /// </summary>
    /// <typeparam name="TResult"></typeparam>
    public interface IBacktrackingOperation<TResult>
    {
        public TResult Execute(params object[] parameters);

        // public IList<IList<int>> CombinationSum(int[] candidates, int target);
    }
}