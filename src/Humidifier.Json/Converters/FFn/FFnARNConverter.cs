using Humidifier.Base;
using Newtonsoft.Json;

namespace Humidifier.Json.Converters
{
    public class FFnARNConverter : BaseResultFactoryJsonConverter<FFnARN>
    {
        public override void WriteJson(JsonWriter writer, BaseResource value, JsonSerializer serializer)
        {
            var resourceName = value.ResourceName;

            var typeName = value.AWSTypeName.ToLower();
            var split = typeName.Split("::");

            writer.WriteStartObject();
            writer.WritePropertyName("Fn::Sub");
            var arnTemplate = $"arn:{split[0]}:{split[1]}:${{AWS::Region}}:${{AWS::AccountId}}:{split[2]}/{resourceName}";
            writer.WriteValue(arnTemplate);
            writer.WriteEndObject();
        }
    }
}