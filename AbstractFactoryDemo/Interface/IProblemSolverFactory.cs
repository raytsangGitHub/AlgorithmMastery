namespace AbstractFactoryDemo.Interface
{
    public interface IProblemSolverFactory
    {
        IProblemSolver<TInput, TResult> CreateSolver<TInput, TResult>(string problemName);
    }
}