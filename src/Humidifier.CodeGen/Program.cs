using System.Threading.Tasks;
using Humidifier.CodeGen.Features.Init;
using Humidifier.CodeGen.Features.JsonToModels;
using Humidifier.CodeGen.Features.ModelToClasses;

namespace Humidifier.CodeGen;

public static class Program
{
    public static async Task Main(string[] args)
    {
        var sourcePath = SourceDirectoryLocator.TryFindSourcePath(args);
        var json = await SpecsJsonRetriever.GetSpecsJson(args, sourcePath);

        var specification = SpecificationToModelParser.ParseSpecification(json);

        var versionFile = await SpecVersionChecker.CheckSpecVersion(args, specification, sourcePath);

        if (versionFile == null)
        {
            return;
        }

        var humidifierPath = Path.Combine(sourcePath, "Humidifier");

        CleanupHelper.CleanupOldGeneratedResults(humidifierPath);

        WriteSpecsToFile(sourcePath, json);

        var result = ModelToClassConverter.ParseSpecs(specification);

        foreach (var (resourceType, code) in result)
        {
            var resourcePath = Path.Combine(humidifierPath, resourceType.Group);
            var filePath = $"{resourcePath}/{resourceType.ResourceClassName}.cs";

            Directory.CreateDirectory(resourcePath);

            await File.WriteAllTextAsync(filePath, code);
        }

        // Write the version file last, so we regenerate if something goes wrong.
        await File.WriteAllTextAsync(versionFile, specification.ResourceSpecificationVersion);

        Console.WriteLine("Done");
        Console.ResetColor();
    }

    private static void WriteSpecsToFile(string srcPath, string json)
    {
        var codegenPath = Path.Combine(srcPath, "Humidifier.CodeGen");
        File.WriteAllText(Path.Combine(codegenPath, "Specification.json"), json);
    }
}