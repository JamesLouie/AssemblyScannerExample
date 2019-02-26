using AssemblyScanner.WebApi.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace AssemblyScanner.WebApi.Services
{
    [Inject(ServiceLifetime.Transient)]
    public class ExampleService1 : IExampleService1
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
