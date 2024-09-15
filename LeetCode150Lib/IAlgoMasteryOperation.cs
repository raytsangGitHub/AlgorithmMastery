namespace LeetCode150Lib
{
    /// <summary>
    /// An interface designed for all algorithm problems, implemented using generics and params to add flexibility for future methods that may require more than one parameter.
    /// </summary>
    /// <typeparam name="TResult"></typeparam>
    public interface IAlgoMasteryOperation<TResult>
    {
        public TResult Execute(params object[] parameters);
    }
}