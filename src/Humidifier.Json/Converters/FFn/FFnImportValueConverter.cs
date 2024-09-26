using Humidifier.Base;
using Newtonsoft.Json;

namespace Humidifier.Json.Converters;

public class FFnImportValueConverter : BaseResultFactoryJsonConverter<FFnImportValue>
{
    public override void WriteJson(JsonWriter writer, BaseResource value, JsonSerializer serializer)
    {
        writer.WriteStartObject();
        writer.WritePropertyName("Fn::ImportValue");
        writer.WriteToken(JsonToken.String, value.ResourceName);
        writer.WriteEndObject();
    }
}