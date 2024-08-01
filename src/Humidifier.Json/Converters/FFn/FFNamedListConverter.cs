using System;
using System.Linq;
using Newtonsoft.Json;

namespace Humidifier.Json.Converters;

public class FFNamedListConverter : JsonConverter
{
    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        var fn = (FFNamedList)value;
        var factories = fn.Results;
        var resultObjects = factories.Select(x => x.Result).ToList();

        writer.WriteStartArray();

        foreach (var resultObject in resultObjects)
        {
            writer.WriteValue(resultObject.ResourceName);
        }

        writer.WriteEndArray();
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        throw new NotImplementedException();
    }

    public override bool CanConvert(Type objectType) => objectType == typeof(FFNamedList);
}