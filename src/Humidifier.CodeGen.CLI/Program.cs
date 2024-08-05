using System.Threading.Tasks;
using Humidifier.CodeGen.CLI.Features.Wiring;
using Humidifier.CodeGen.Lib;
using Humidifier.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Humidifier.CodeGen.CLI;

public static class Program
{
    public static async Task Main(string[] args)
    {
        var serviceCollection = new ServiceCollection();
        serviceCollection.WireImplicit<CodeGeneratorCore>();

        // TODO: Infer interfaces


        var serviceProvider = serviceCollection.BuildServiceProvider();

#if WithoutReferences

#else
        var customInterfaces = typeof(Interfaces.IHaveDescription).Assembly.GetTypes().Where(x => x.IsInterface && typeof(IResourceInterface).IsAssignableFrom(x)).ToList();

        foreach (var customInterface in customInterfaces)
        {
            var properties = customInterface.GetProperties().ToList();

        }

#endif


        var core = serviceProvider.GetRequiredService<CodeGeneratorCore>();

        var interfaces = new List<Type>();

        var config = ConfigArgParser.CreateConfig(args);
        await core.Process(config);
    }
}