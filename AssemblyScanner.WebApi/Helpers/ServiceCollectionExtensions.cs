using System.Linq;
using AssemblyScanner.WebApi.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace AssemblyScanner.WebApi.Helpers
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterServicesFromAssembly<T>(this IServiceCollection services)
        {
            var injectableTypes = typeof(T).Assembly.DefinedTypes
                .Where(x => x.GetCustomAttributes(typeof(InjectAttribute), false).FirstOrDefault() != null && x.IsClass);

            foreach(var injectableType in injectableTypes)
            {
                var injectAttributeData = injectableType.GetCustomAttributes(typeof(InjectAttribute), false).First() as InjectAttribute;
                foreach(var implementedInterface in injectableType.ImplementedInterfaces)
                {
                    services.Add(new ServiceDescriptor(implementedInterface, injectableType, injectAttributeData.ServiceLifetime));
                }
            }
        }
    }
}
