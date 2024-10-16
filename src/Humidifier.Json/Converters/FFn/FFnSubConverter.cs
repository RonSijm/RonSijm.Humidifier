using System.Linq;
using Newtonsoft.Json;

namespace Humidifier.Json.Converters;

public class FFnSubConverter : BaseTypedJsonConverter<FFnSubNameFunc>
{
    public override void WriteJson(JsonWriter writer, FFnSubNameFunc value, JsonSerializer serializer)
    {
        writer.WriteStartObject();
        writer.WritePropertyName("Fn::Sub");

        if (value.Variables != null && value.Variables.Any())
        {
            // { "Fn::Sub" : [ String, { Var1Name: Var1Value, Var2Name: Var2Value } ] } 
            writer.WriteStartArray();

            var text = value.StringFunction(value.Result.Result.ResourceName);

            writer.WriteToken(JsonToken.String, text);
            serializer.Serialize(writer, value.Variables);
            writer.WriteEndArray();
        }
        else
        {
            // { "Fn::Sub" : String }
            var text = value.StringFunction(value.Result.Result.ResourceName);
            writer.WriteToken(JsonToken.String, text);
        }

        writer.WriteEndObject();
    }
}