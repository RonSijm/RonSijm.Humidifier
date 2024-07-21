using System.Threading.Tasks;

namespace Humidifier.CodeGen.Features.Init;

public static class ServerEtagChecker
{
    public static async Task<string> GetServerEtagVersion()
    {
        var request = new HttpRequestMessage(HttpMethod.Head, CodeGenConfig.CloudFormationResourceSpecificationUrl);
        var client = new HttpClient();
        var response = await client.SendAsync(request);
        var serverEtagVersion = response.Headers.ETag.Tag;
        return serverEtagVersion;
    }
}