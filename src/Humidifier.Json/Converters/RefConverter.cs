using System;
using Newtonsoft.Json;

namespace Humidifier.Json.Converters
{
    public class FnORefConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var fn = (FnORef)value;
            var factory = fn.Result;
            var resultObject = factory.Result;
            var resourceName = resultObject.ResourceName;

            var typeName = resultObject.AWSTypeName.ToLower();
            var split = typeName.Split("::");

            writer.WriteStartObject();
            writer.WritePropertyName("Fn::Sub");
            var arnTemplate = $"arn:{split[0]}:{split[1]}:${{AWS::Region}}:${{AWS::AccountId}}:{split[2]}/{resourceName}";
            writer.WriteValue(arnTemplate);
            writer.WriteEndObject();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override bool CanConvert(Type objectType) => objectType == typeof(FnORef);
    }
}
