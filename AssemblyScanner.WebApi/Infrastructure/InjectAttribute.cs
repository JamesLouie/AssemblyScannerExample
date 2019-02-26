using System;
using Microsoft.Extensions.DependencyInjection;

namespace AssemblyScanner.WebApi.Infrastructure
{
    [AttributeUsage(AttributeTargets.Class)]
    public class InjectAttribute : Attribute
    {
        public ServiceLifetime ServiceLifetime { get; }

        public InjectAttribute(ServiceLifetime serviceLifetime = ServiceLifetime.Transient)
        {
            ServiceLifetime = serviceLifetime;
        }
    }
}
