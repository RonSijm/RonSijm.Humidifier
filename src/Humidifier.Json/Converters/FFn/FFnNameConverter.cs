using Humidifier.Base;
using Newtonsoft.Json;

namespace Humidifier.Json.Converters;

public class FFnNameConverter : BaseResultFactoryJsonConverter<FFnName>
{
    public override void WriteJson(JsonWriter writer, BaseResource value, JsonSerializer serializer)
    {
        var resourceName = value.ResourceName;
        writer.WriteRaw(resourceName);
    }
}