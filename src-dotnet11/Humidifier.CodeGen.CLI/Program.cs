using System.Threading.Tasks;
using Humidifier.CodeGen.CLI.Features.InterfaceIdentifiers;
using Humidifier.CodeGen.CLI.Features.Wiring;
using Humidifier.CodeGen.Lib;
using Microsoft.Extensions.DependencyInjection;

namespace Humidifier.CodeGen.CLI;

public static class Program
{
    public static async Task Main(string[] args)
    {
        InterfaceIdentifiersGenerator.Generate();

        var serviceCollection = new ServiceCollection();
        serviceCollection.WireImplicit<CodeGeneratorCore>();

        var serviceProvider = serviceCollection.BuildServiceProvider();
        var core = serviceProvider.GetRequiredService<CodeGeneratorCore>();

        var config = ConfigArgParser.CreateConfig(args);
        await core.Process(config);
    }
}