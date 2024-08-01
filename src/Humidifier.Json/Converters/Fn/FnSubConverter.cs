using System.Linq;
using Newtonsoft.Json;

namespace Humidifier.Json.Converters;

public class FnSubConverter : BaseTypedJsonConverter<FnSub>
{
    public override void WriteJson(JsonWriter writer, FnSub fn, JsonSerializer serializer)
    {
        writer.WriteStartObject();
        writer.WritePropertyName("Fn::Sub");

        if (fn.Variables != null && fn.Variables.Any())
        {
            // { "Fn::Sub" : [ String, { Var1Name: Var1Value, Var2Name: Var2Value } ] } 
            writer.WriteStartArray();
            writer.WriteToken(JsonToken.String, fn.String);
            serializer.Serialize(writer, fn.Variables);
            writer.WriteEndArray();
        }
        else
        {
            // { "Fn::Sub" : String }
            writer.WriteToken(JsonToken.String, fn.String);
        }

        writer.WriteEndObject();
    }
}