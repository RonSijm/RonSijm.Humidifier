using System.Threading.Tasks;

namespace Humidifier.CodeGen.Features.Init;

public static class SpecsJsonRetriever
{
    public static async Task<string> GetSpecsJson(string[] args, string sourcePath)
    {
        var etagVersionFile = Path.Combine(sourcePath, "etag-version.txt");
        var etagLocalVersion = await File.ReadAllTextAsync(etagVersionFile);

        var serverEtagVersion = await ServerEtagChecker.GetServerEtagVersion();

        if (etagLocalVersion != serverEtagVersion || args != null && args.Any(x => x.Contains("redownload")))
        {
            var (downloadedJson, etag) = await SpecDownloader.DownloadSpecs();
            await File.WriteAllTextAsync(etagVersionFile, etag);

            return downloadedJson;
        }

        var codegenPath = Path.Combine(sourcePath, "Humidifier.CodeGen");
        var specFile = Path.Combine(codegenPath, "Specification.json");

        return await File.ReadAllTextAsync(specFile);
    }
}