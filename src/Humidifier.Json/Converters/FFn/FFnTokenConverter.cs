using Newtonsoft.Json;

namespace Humidifier.Json.Converters;

public class FFnTokenConverter : BaseTypedJsonConverter<FFnTokenFunc>
{
    public override void WriteJson(JsonWriter writer, FFnTokenFunc value, JsonSerializer serializer)
    {
        var text = value.StringFunction(value.Result.Result.ResourceName);
        writer.WriteToken(JsonToken.String, text);
    }
}