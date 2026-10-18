using System.Threading.Tasks;

namespace Humidifier.CodeGen.Lib.Features.Init;

public class JsonSpecsRetriever(ServerEtagChecker serverEtagChecker, JsonFromServerRetriever jsonFromServerRetriever, JsonFromFileRetriever jsonFromFileRetriever)
{
    public async Task<string> GetSpecsJson(string sourcePath, bool noUpdateCheck, bool forceRedownload)
    {
        if (noUpdateCheck)
        {
            return await jsonFromFileRetriever.GetJson(sourcePath);
        }

        var etagVersionFile = Path.Combine(sourcePath, "etag-version.txt");
        var etagLocalVersion = await File.ReadAllTextAsync(etagVersionFile);

        var serverEtagVersion = await serverEtagChecker.GetServerEtagVersion();

        if (etagLocalVersion == serverEtagVersion && !forceRedownload)
        {
            return await jsonFromFileRetriever.GetJson(sourcePath);
        }

        var (downloadedJson, etag) = await jsonFromServerRetriever.DownloadSpecs();
        await File.WriteAllTextAsync(etagVersionFile, etag);

        return downloadedJson;

    }
}