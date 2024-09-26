using System;
using Newtonsoft.Json;

namespace Humidifier.Json.Converters;

public class FnLazyStringConverter : BaseTypedJsonConverter<Lazy<string>>
{
    public override void WriteJson(JsonWriter writer, Lazy<string> value, JsonSerializer serializer)
    {
        var stringValue = value.Value;
        serializer.Serialize(writer, stringValue);
    }
}