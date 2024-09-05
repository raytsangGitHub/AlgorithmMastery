using AbstractFactoryDemo.Interface;

namespace AbstractFactoryDemo.Concrete
{
    public class DynamicProgrammingFactory : IProblemSolverFactory
    {
        public IProblemSolver<TInput, TResult> CreateSolver<TInput, TResult>(string problemName)
        {
            return problemName switch
            {
                "Problem1" => (IProblemSolver<TInput, TResult>)new DynamicProgrammingProblem1Solver(),
                _ => throw new ArgumentException("Unknown problem name")
            };
        }
    }
}