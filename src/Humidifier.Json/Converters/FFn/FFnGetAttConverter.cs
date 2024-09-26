using Newtonsoft.Json;

namespace Humidifier.Json.Converters;

public class FFnGetAttConverter : BaseTypedJsonConverter<FFnGetAtt>
{
    public override void WriteJson(JsonWriter writer, FFnGetAtt value, JsonSerializer serializer)
    {
        writer.WriteStartObject();
        writer.WritePropertyName("Fn::GetAtt");
        writer.WriteStartArray();
        writer.WriteToken(JsonToken.String, value.Result.Result.ResourceName);
        writer.WriteToken(JsonToken.String, value.AttributeName);
        writer.WriteEndArray();
        writer.WriteEndObject();
    }
}