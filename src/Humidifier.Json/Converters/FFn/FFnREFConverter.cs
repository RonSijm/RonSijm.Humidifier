using System;
using System.Linq;
using Humidifier.Base;
using Newtonsoft.Json;

namespace Humidifier.Json.Converters
{
    public class FFnREFConverter : BaseResultFactoryJsonConverter<FFnREF>
    {
        public override void WriteJson(JsonWriter writer, BaseResource value, JsonSerializer serializer)
        {
            var resourceName = value.ResourceName;

            writer.WriteStartObject();
            writer.WritePropertyName("Ref");
            writer.WriteToken(JsonToken.String, resourceName);
            writer.WriteEndObject();
        }
    }

    public class FFnNameConverter : BaseResultFactoryJsonConverter<FFnName>
    {
        public override void WriteJson(JsonWriter writer, BaseResource value, JsonSerializer serializer)
        {
            var resourceName = value.ResourceName;
            writer.WriteRaw(resourceName);
        }
    }

    public class FFnREFListConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var fn = (FFnREFList)value;
            var factories = fn.Results;
            var resultObjects = factories.Select(x => x.Result).ToList();

            writer.WriteStartArray();

            foreach (var resultObject in resultObjects)
            {
                writer.WriteStartObject();
                writer.WritePropertyName("Ref");
                writer.WriteValue(resultObject.ResourceName);
                writer.WriteEndObject();
            }

            writer.WriteEndArray();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override bool CanConvert(Type objectType) => objectType == typeof(FFnREFList);
    }
}
