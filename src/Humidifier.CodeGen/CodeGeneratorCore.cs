using System.Threading.Tasks;
using Humidifier.CodeGen.Features.Init;
using Humidifier.CodeGen.Features.JsonToModels;
using Humidifier.CodeGen.Features.ModelToClasses;

namespace Humidifier.CodeGen
{
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

            existingResultCleaner.CleanupOldGeneratedResults(humidifierPath);

            WriteSpecsToFile(sourcePath, json);

            var result = specsModelToClassConverter.ParseSpecsToCode(specification);

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
}