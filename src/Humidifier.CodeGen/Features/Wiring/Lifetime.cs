using Microsoft.Extensions.DependencyInjection;

namespace Appical.Libs.Infrastructure.Wiring;

public abstract class Lifetime
{
    public class SingletonAttribute() : ServiceLifetimeAttribute(ServiceLifetime.Singleton);

    public class ServiceLifetimeAttribute(ServiceLifetime serviceLifetime) : Attribute
    {
        public ServiceLifetime ServiceLifetime { get; } = serviceLifetime;
    }
}