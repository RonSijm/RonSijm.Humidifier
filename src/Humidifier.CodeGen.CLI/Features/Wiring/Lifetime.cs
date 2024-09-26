using Microsoft.Extensions.DependencyInjection;

namespace Humidifier.CodeGen.CLI.Features.Wiring;

public abstract class Lifetime
{
    public class SingletonAttribute() : ServiceLifetimeAttribute(ServiceLifetime.Singleton);

    public class ServiceLifetimeAttribute(ServiceLifetime serviceLifetime) : Attribute
    {
        public ServiceLifetime ServiceLifetime { get; } = serviceLifetime;
    }
}