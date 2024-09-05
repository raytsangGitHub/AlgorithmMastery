using LeetCode150Lib.Backtracking.OptimizationProblems;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Reflection;

namespace LeetCode150Lib
{
    public static class HostBuilderRegisterService
    {
        public static IHostBuilder ConfigRegisterService(this IHostBuilder hostBuilder)
        {
            return hostBuilder.ConfigureServices((context, services) =>
            {
                //get the assembly contiaining the problem solvers
                var assembly = Assembly.GetAssembly(typeof(HostBuilderRegisterService));

                //list of generic interfaces to register
                var interfaceTypes = new[]
                {
                    typeof(IBacktrackingOperation<IList<string>>),
                    typeof(IBacktrackingOperation<IList<IList<int>>>),
                    typeof(IBacktrackingOperation<IList<IList<string>>>)
                };

                foreach (var interfaceType in interfaceTypes)
                {
                    if (assembly != null)
                    {
                        var implementations = assembly.GetTypes()
                            .Where(type => interfaceType.IsAssignableFrom(type) && !type.IsInterface && !type.IsAbstract);

                        foreach (var implementation in implementations)
                        {
                            //register
                            services.AddTransient(interfaceType, implementation);
                        }
                    }
                }
            });
        }
    }
}