using System;
using Newtonsoft.Json;

namespace Humidifier.Json.Converters;

internal class FnAndConverter : JsonConverter
{
    public override bool CanConvert(Type objectType) => objectType == typeof(FnAnd);
    public override bool CanRead => false;
    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) => throw new NotImplementedException();
    public override bool CanWrite => true;
    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        // { "Fn::And": [{condition}, {...}] }

        var fn = (FnAnd)value;
        writer.WriteStartObject();
        writer.WritePropertyName("Fn::And");
        writer.WriteStartArray();
        foreach (var condition in fn.Conditions)
        {
            serializer.Serialize(writer, condition);
        }
        writer.WriteEndArray();
        writer.WriteEndObject();
    }
}

internal class FnStringJoinConverter : JsonConverter
{
    public override bool CanConvert(Type objectType) => objectType == typeof(FnStringJoin);
    public override bool CanRead => false;
    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) => throw new NotImplementedException();
    public override bool CanWrite => true;
    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        var fn = (FnStringJoin)value;

        // StringBuilder to concatenate the string representations
        // of all conditions.
        var stringBuilder = new System.Text.StringBuilder();

        foreach (var condition in fn.Conditions)
        {
            if (condition != null)
            {
                string conditionString;

                if (condition.GetType().IsPrimitive || condition is string)
                {
                    conditionString = condition.ToString();
                }
                else
                {
                    var tempStringBuilder = new System.Text.StringBuilder();
                    var stringWriter = new System.IO.StringWriter(tempStringBuilder);
                    serializer.Serialize(stringWriter, condition);
                    conditionString = tempStringBuilder.ToString();
                }

                stringBuilder.Append(conditionString);
            }
        }

        writer.WriteValue(stringBuilder.ToString());
    }
}