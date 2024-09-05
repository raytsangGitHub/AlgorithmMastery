using AbstractFactoryDemo.Interface;

namespace AbstractFactoryDemo
{
    public class ParadigmFactoryProvider
    {
        private readonly Dictionary<string, IProblemSolverFactory> _factories;

        public ParadigmFactoryProvider(Dictionary<string, IProblemSolverFactory> factories)
        {
            _factories = factories;
        }

        public IProblemSolver<TInput, TResult> GetSolver<TInput, TResult>(string paradigm, string problemName)
        {
            if (_factories.TryGetValue(paradigm, out var factory))
            {
                return factory.CreateSolver<TInput, TResult>(problemName);
            }

            throw new ArgumentException($"Unknown paradigm: {paradigm}");
        }
    }
}