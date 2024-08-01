using Newtonsoft.Json;
using System;

namespace Humidifier.Json.Converters
{
    public abstract class BaseTypedJsonConverter<T> : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var typedObject = (T)value;
            WriteJson(writer, typedObject, serializer);
        }

        public abstract void WriteJson(JsonWriter writer, T value, JsonSerializer serializer);

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(T);
        }
    }
}