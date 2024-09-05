using AbstractFactoryDemo.Interface;

namespace AbstractFactoryDemo.Concrete
{
    public class BacktrackingFactory : IProblemSolverFactory
    {
        public IProblemSolver<TInput, TResult> CreateSolver<TInput, TResult>(string problemName)
        {
            return problemName switch
            {
                "Problem2" => (IProblemSolver<TInput, TResult>)new BacktrackingProblem2Solver(),
                _ => throw new ArgumentException("Unknown problem name")
            };
        }
    }
}