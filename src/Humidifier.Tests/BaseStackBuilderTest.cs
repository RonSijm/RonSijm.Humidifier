using Humidifier.Json.Serializer;
using Newtonsoft.Json;

namespace Humidifier.Tests;

public abstract class BaseStackBuilderTest
{
    [Fact]
    public async Task CanBuildStack()
    {
        var stack = await BuildStack();

        var serializer = new JsonStackSerializer(new List<JsonConverter>());
        var template = serializer.Serialize(stack);

        var settings = new VerifySettings();
        settings.UseDirectory("VerificationResults");

        await Verify(template, extension: "json", settings);
    }

    protected abstract Task<Stack> BuildStack();
}