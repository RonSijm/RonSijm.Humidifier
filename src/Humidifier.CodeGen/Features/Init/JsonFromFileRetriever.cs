using System.Threading.Tasks;

namespace Humidifier.CodeGen.Features.Init
{
    public class JsonFromFileRetriever
    {
        public async Task<string> GetJson(string sourcePath)
        {
            var codegenPath = Path.Combine(sourcePath, "Humidifier.CodeGen");
            var specFile = Path.Combine(codegenPath, "Specification.json");

            return await File.ReadAllTextAsync(specFile);
        }
    }
}
