namespace LeetCode150Lib.SharedPatterns.TwoPointers
{
    /// <summary>
    /// An interface designed for all Two Pointer problems, implemented using generics and params to add flexibility for future methods that may require more than one parameter.
    /// </summary>
    /// <typeparam name="TResult"></typeparam>
    public interface ITwoPointerOperation<TResult>
    {
        public TResult Execute(params object[] parameters);
    }
}