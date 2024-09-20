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
                    typeof(IAlgoMasteryOperation<IList<string>>),
                    typeof(IAlgoMasteryOperation<IList<IList<int>>>),
                    typeof(IAlgoMasteryOperation<IList<IList<string>>>),
                    typeof(IAlgoMasteryOperation<IList<int>>),
                    typeof(IAlgoMasteryOperation<bool>),
                    typeof(IAlgoMasteryOperation<int[]>)
                };

                foreach (var interfaceType in interfaceTypes)
                {
                    if (assembly != null)
                    {  //examing type with reflection
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