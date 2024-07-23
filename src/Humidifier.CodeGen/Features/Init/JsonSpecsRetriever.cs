using System.Threading.Tasks;

namespace Humidifier.CodeGen.Features.Init;

public class JsonSpecsRetriever(ServerEtagChecker serverEtagChecker, JsonFromServerRetriever jsonFromServerRetriever, JsonFromFileRetriever jsonFromFileRetriever)
{
    public async Task<string> GetSpecsJson(string[] args, string sourcePath)
    {
        var etagVersionFile = Path.Combine(sourcePath, "etag-version.txt");
        var etagLocalVersion = await File.ReadAllTextAsync(etagVersionFile);

        var serverEtagVersion = await serverEtagChecker.GetServerEtagVersion();

        if (etagLocalVersion != serverEtagVersion || args != null && args.Any(x => x.Contains("redownload")))
        {
            var (downloadedJson, etag) = await jsonFromServerRetriever.DownloadSpecs();
            await File.WriteAllTextAsync(etagVersionFile, etag);

            return downloadedJson;
        }

        return await jsonFromFileRetriever.GetJson(sourcePath);
    }
}