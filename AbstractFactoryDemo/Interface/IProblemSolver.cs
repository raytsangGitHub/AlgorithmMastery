namespace AbstractFactoryDemo.Interface
{
    public interface IProblemSolver<TInput, TResult>
    {
        TResult Solve(TInput input);
    }
}