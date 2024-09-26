using System.Threading.Tasks;

namespace Humidifier.CodeGen.Lib.Features.Init;

public class ServerEtagChecker
{
    public async Task<string> GetServerEtagVersion()
    {
        var request = new HttpRequestMessage(HttpMethod.Head, CodeGeneratorSettings.CloudFormationResourceSpecificationUrl);
        var client = new HttpClient();
        var response = await client.SendAsync(request);
        var serverEtagVersion = response.Headers.ETag.Tag;
        return serverEtagVersion;
    }
}