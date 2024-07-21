using System.Threading.Tasks;
using Humidifier.CodeGen.Features.JsonToModels.Models;

namespace Humidifier.CodeGen.Features.Init;

public static class SpecVersionChecker
{
    public static async Task<string> CheckSpecVersion(string[] args, Specification specification, string sourcePath)
    {
        Console.WriteLine($"ResourceSpecificationVersion: {specification.ResourceSpecificationVersion}");

        var versionFile = Path.Combine(sourcePath, "spec-version.txt");
        var currentVersion = await File.ReadAllTextAsync(versionFile);

        if (currentVersion != specification.ResourceSpecificationVersion)
        {
            return versionFile;
        }

        if (args != null && args.Any(x => x.Contains("force")))
        {
            Console.WriteLine($"Current version is already {currentVersion}.");
            Console.WriteLine($"But used 'Force' argument to regenerate anyways.");

            return versionFile;
        }

        // If we're already using this version, we don't have to regenerate
        // Unless something was actually changed to the generator.
        Console.WriteLine($"Current version is already {currentVersion}.");
        Console.WriteLine($"Use 'Force' argument to regenerate anyways.");

        return null;
    }
}