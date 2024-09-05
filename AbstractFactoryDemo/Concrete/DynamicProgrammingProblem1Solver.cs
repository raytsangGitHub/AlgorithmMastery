using AbstractFactoryDemo.Interface;

namespace AbstractFactoryDemo.Concrete
{
    public class DynamicProgrammingProblem1Solver : IProblemSolver<int[], int>
    {
        public int Solve(int[] input)
        {
            // Implementation for the specific problem
            return input.Sum(); // Example
        }
    }
}