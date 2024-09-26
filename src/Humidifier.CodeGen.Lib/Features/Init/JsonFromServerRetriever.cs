using System.Threading.Tasks;

namespace Humidifier.CodeGen.Lib.Features.Init;

public class JsonFromServerRetriever
{
    public async Task<(string, string)> DownloadSpecs()
    {
            Console.WriteLine($"Downloading spec from {CodeGeneratorSettings.CloudFormationResourceSpecificationUrl}");

            var handler = new HttpClientHandler
            {
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
            };

            var client = new HttpClient(handler);

            var request = new HttpRequestMessage(HttpMethod.Get, CodeGeneratorSettings.CloudFormationResourceSpecificationUrl);
            request.Headers.AcceptEncoding.Add(new StringWithQualityHeaderValue("gzip"));

            var response = await client.SendAsync(request);
            var json = await response.Content.ReadAsStringAsync();

            // https://github.com/jakejscott/Humidifier/issues/12
            json = json.Replace("VPCEndpointType", "VpcEndpointType");
            var etag = response.Headers.ETag.Tag;

            return (json, etag);
        }
}