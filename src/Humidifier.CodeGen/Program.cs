using System.Threading.Tasks;
using Humidifier.CodeGen.Features.Init;
using Humidifier.CodeGen.Features.JsonToModels;
using Humidifier.CodeGen.Features.ModelToClasses;
using Humidifier.CodeGen.Features.Wiring;
using Microsoft.Extensions.DependencyInjection;

namespace Humidifier.CodeGen;

public static class Program
{
    public static async Task Main(string[] args)
    {
        var serviceCollection = new ServiceCollection();
        serviceCollection.WireEntryImplicit();

        var serviceProvider = serviceCollection.BuildServiceProvider();

        var core = serviceProvider.GetRequiredService<CodeGeneratorCore>();
        await core.Process(args);
    }
}