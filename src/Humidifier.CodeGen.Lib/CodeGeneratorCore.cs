using System.Threading.Tasks;
using Humidifier.CodeGen.Lib.Features.Init;
using Humidifier.CodeGen.Lib.Features.JsonToModels;
using Humidifier.CodeGen.Lib.Features.ModelToClasses;

namespace Humidifier.CodeGen.Lib;

public class CodeGeneratorCore(SourceDirectoryLocator sourceDirectoryLocator, 
    JsonSpecsRetriever jsonSpecsRetriever, 
    SpecificationToModelParser specificationToModelParser, 
    ExistingResultCleaner existingResultCleaner,
    SpecVersionChecker specVersionChecker,
    SpecsModelToClassConverter specsModelToClassConverter)
{
    public async Task Process(string[] args)
    {
        var sourcePath = sourceDirectoryLocator.TryFindSourcePath(args);
        var json = await jsonSpecsRetriever.GetSpecsJson(args, sourcePath);

        var specification = specificationToModelParser.ParseSpecification(json);

        var versionFile = await specVersionChecker.CheckSpecVersion(args, specification, sourcePath);

        if (versionFile == null)
        {
            return;
        }

        var humidifierPath = Path.Combine(sourcePath, "Humidifier");
        var outputPath = Path.Combine(humidifierPath, "Gen");

        existingResultCleaner.CleanupOldGeneratedResults(outputPath);

        WriteSpecsToFile(humidifierPath, json);

        var treeResult = specsModelToClassConverter.ParseSpecsToTrees(specification);

        // Trying to see which property is used most, so I can add interfaces to it

        //var propertyList = new Dictionary<string, List<Property>>();

        //foreach (var valueTuple in treeResult)
        //{
        //    foreach (var property in valueTuple.Item1.Properties)
        //    {
        //        var getList = propertyList.TryGetValue(property.Name, out var list);
        //        if (!getList)
        //        {
        //            list = new List<Property>();
        //            propertyList.Add(property.Name, new List<Property>());
        //        }

        //        list.Add(property);
        //    }
        //}

        //var tryFindMostUsedProperties = propertyList.OrderByDescending(x => x.Value.Count).ToList();


        var result = specsModelToClassConverter.ToCode(treeResult);

        foreach (var (resourceType, code) in result)
        {
            var resourcePath = Path.Combine(outputPath, resourceType.Group);
            var filePath = $"{resourcePath}/{resourceType.ClassName}.cs";

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
        var repoPath = Path.Combine(srcPath, "..\\");
        var codegenPath = Path.Combine(repoPath, "Humidifier.CodeGen.Lib");
        File.WriteAllText(Path.Combine(codegenPath, "Specification.json"), json);
    }
}