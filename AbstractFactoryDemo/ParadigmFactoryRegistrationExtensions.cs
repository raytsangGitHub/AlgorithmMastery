using AbstractFactoryDemo.Concrete;
using AbstractFactoryDemo.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace AbstractFactoryDemo
{
    public static class ParadigmFactoryRegistrationExtensions
    {
        public static IServiceCollection AddParadigmFactories(this IServiceCollection services)
        {
            // Register individual factories
            services.AddSingleton<DynamicProgrammingFactory>();
            services.AddSingleton<BacktrackingFactory>();

            // Register the dictionary to map string keys to factory instances
            services.AddSingleton(provider => new Dictionary<string, IProblemSolverFactory>
        {
            { "DynamicProgramming", provider.GetRequiredService<DynamicProgrammingFactory>() },
            { "Backtracking", provider.GetRequiredService<BacktrackingFactory>() }
            // Add more factories as needed
        });
            // Register additional factories as needed

            return services;
        }

        // Register the ParadigmFactoryProvider with the service collection
        public static IServiceCollection AddParadigmFactoryProvider(this IServiceCollection services)
        {
            services.AddSingleton<ParadigmFactoryProvider>();
            return services;
        }
    }
}