using AbstractFactoryDemo.Interface;

namespace AbstractFactoryDemo.Concrete
{
    public class BacktrackingProblem2Solver : IProblemSolver<(int, int), bool>
    {
        public bool Solve((int, int) input)
        {
            // Implementation for the specific problem
            return input.Item1 == input.Item2; // Example
        }
    }
}