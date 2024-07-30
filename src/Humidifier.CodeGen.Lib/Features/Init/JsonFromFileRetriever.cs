using System.Threading.Tasks;

namespace Humidifier.CodeGen.Lib.Features.Init;

public class JsonFromFileRetriever
{
    public async Task<string> GetJson(string sourcePath)
    {
        var codegenPath = Path.Combine(sourcePath, "Humidifier.CodeGen.Lib");
        var specFile = Path.Combine(codegenPath, "Specification.json");

        return await File.ReadAllTextAsync(specFile);
    }
}