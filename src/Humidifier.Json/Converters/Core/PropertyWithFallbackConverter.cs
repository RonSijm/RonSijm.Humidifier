using System;
using Humidifier.Helpers;
using Newtonsoft.Json;

namespace Humidifier.Json.Converters;

public class PropertyWithFallbackConverter : JsonConverter
{
    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) => throw new NotImplementedException();
    public override bool CanConvert(Type objectType)
    {
        if (!objectType.IsGenericType)
        {
            return false;
        }

        var genericTypeDefinition = objectType.GetGenericTypeDefinition();
        return genericTypeDefinition == typeof(WithFallback<>);
    }

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        var valueType = value.GetType().GetGenericArguments()[0];
        var propertyValue = value.GetType().GetProperty("Value").GetValue(value, null);
        serializer.Serialize(writer, propertyValue, valueType);
    }
}