using System.Threading.Tasks;
using Humidifier.CodeGen.CLI.Features.Wiring;
using Humidifier.CodeGen.Lib;
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
        var customInterfaces = typeof(Interfaces.IHaveDescription).Assembly.GetTypes().Where(x => x.IsInterface && x.Name.StartsWith("IHave")).ToList();
#endif


        var core = serviceProvider.GetRequiredService<CodeGeneratorCore>();

        var interfaces = new List<Type>();

        await core.Process(args);
    }
}