using System.Threading.Tasks;
using Humidifier.CodeGen.Lib.Features.Extensions;
using Humidifier.CodeGen.Lib.Features.Init;
using Humidifier.CodeGen.Lib.Features.InterfaceGenerator;
using Humidifier.CodeGen.Lib.Features.JsonToModels;
using Humidifier.CodeGen.Lib.Features.JsonToModels.Models;
using Humidifier.CodeGen.Lib.Features.ModelToClasses;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Humidifier.CodeGen.Lib;

public class CodeGeneratorCore(SourceDirectoryLocator sourceDirectoryLocator,
    JsonSpecsRetriever jsonSpecsRetriever,
    SpecificationToModelParser specificationToModelParser,
    ExistingResultCleaner existingResultCleaner,
    SpecVersionChecker specVersionChecker,
    SpecsModelToClassConverter specsModelToClassConverter)
{
    public async Task Process(CodeGeneratorCoreSettings settings)
    {
        var sourcePath = sourceDirectoryLocator.TryFindSourcePath(settings.Directory);
        var json = await jsonSpecsRetriever.GetSpecsJson(sourcePath, settings.NoUpdateCheck, settings.ForceRedownload);

        var specification = specificationToModelParser.ParseSpecification(json);

        var versionFile = await specVersionChecker.CheckSpecVersion(specification, sourcePath, settings.ForceRegenerate);

        if (versionFile == null)
        {
            return;
        }

        var humidifierPath = Path.Combine(sourcePath, "Humidifier");
        var outputPath = Path.Combine(humidifierPath, "Gen");

        WriteSpecsToFile(humidifierPath, json);

        var treeResult = specsModelToClassConverter.ParseSpecsToTrees(specification);

        // Trying to see which property is used most, so I can add interfaces to it

        var propertyList = specification.GetPropertyList();
        await propertyList.CreateInterfaces(outputPath);

        var typeNameResults = CreateTreeForNamespaces(treeResult);
        var codeResults = specsModelToClassConverter.ToCode(treeResult);

        // Generate everything first before cleaning up the old files and start writing.
        // Because if the generating crashes, we prefer to just keep the old files.
        existingResultCleaner.CleanupOldGeneratedResults(outputPath);

        await CreateTypesOutputFile(typeNameResults, outputPath);

        foreach (var (resourceType, code) in codeResults)
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

    private static Dictionary<string, Dictionary<string, List<string>>> CreateTreeForNamespaces(List<(ResourceType, NamespaceDeclarationSyntax)> treeResult)
    {
        var resultNames = new Dictionary<string, Dictionary<string, List<string>>>();

        foreach (var (resource, _) in treeResult)
        {
            if (resource.Parts.Length != 3)
            {
                continue;
            }

            if (!resultNames.ContainsKey(resource.Parts[0]))
            {
                resultNames.Add(resource.Parts[0], new Dictionary<string, List<string>>());
            }

            if (!resultNames[resource.Parts[0]].ContainsKey(resource.Parts[1]))
            {
                resultNames[resource.Parts[0]].Add(resource.Parts[1], new List<string>());
            }

            resultNames[resource.Parts[0]][resource.Parts[1]].Add(resource.Parts[2]);
        }

        return resultNames;
    }

    private static async Task CreateTypesOutputFile(Dictionary<string, Dictionary<string, List<string>>> resultNames, string outputPath)
    {
        var bob = new StringBuilder();

        bob.AppendLineCRLF("namespace Humidifier;");

        foreach (var namespaceName in resultNames)
        {
            bob.AppendLineCRLF($"public class {namespaceName.Key}");
            bob.AppendLineCRLF($"{{");

            foreach (var subClasses in namespaceName.Value)
            {
                bob.AppendLineCRLF($"    public class {subClasses.Key}");
                bob.AppendLineCRLF($"    {{");

                foreach (var service in subClasses.Value)
                {
                    bob.AppendLineCRLF($"        public const string {service} = \"{namespaceName.Key}::{subClasses.Key}::{service}\";");
                }

                bob.AppendLineCRLF($"    }}");
            }


            bob.AppendLineCRLF($"}}");
        }

        var typeNames = bob.ToString();

        var typenameResourcePath = Path.Combine(outputPath, "TypeNames");
        var typenamePath = "TypeNames.cs";

        Directory.CreateDirectory(typenameResourcePath);

        var typenameOutputResourcePath = Path.Combine(typenameResourcePath, typenamePath);
        await File.WriteAllTextAsync(typenameOutputResourcePath, typeNames);
    }

    private static void WriteSpecsToFile(string srcPath, string json)
    {
        var repoPath = Path.GetFullPath(Path.Combine(srcPath, ".."));
        var codegenPath = Path.Combine(repoPath, "Humidifier.CodeGen.Lib");
        File.WriteAllText(Path.Combine(codegenPath, "Specification.json"), json);
    }
}