using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace Humidifier.Json.Converters;

/// <summary>Writes the selected union case without introducing a JSON wrapper.</summary>
public sealed class UnionConverter : JsonConverter
{
    public override bool CanConvert(Type objectType)
        => typeof(IUnion).IsAssignableFrom(Nullable.GetUnderlyingType(objectType) ?? objectType);

    public override bool CanRead => false;

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        serializer.Serialize(writer, Unwrap(value));
    }

    internal static object Unwrap(object value)
    {
        while (value is IUnion union)
        {
            value = union.Value;
        }

        return value;
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        => throw new NotSupportedException("CloudFormation unions support serialization only.");
}
