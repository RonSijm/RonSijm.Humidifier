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
}
