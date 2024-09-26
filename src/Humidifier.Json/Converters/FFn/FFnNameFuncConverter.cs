using Newtonsoft.Json;

namespace Humidifier.Json.Converters;

public class FFnNameFuncConverter : BaseTypedJsonConverter<FFnRawFunc>
{
    public override void WriteJson(JsonWriter writer, FFnRawFunc value, JsonSerializer serializer)
    {
        var text = value.StringFunction(value.Result.Result.ResourceName);
        writer.WriteRaw(text);
    }
}