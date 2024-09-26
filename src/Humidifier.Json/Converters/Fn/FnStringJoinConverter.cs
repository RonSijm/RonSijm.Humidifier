using Newtonsoft.Json;

namespace Humidifier.Json.Converters;

internal class FnStringJoinConverter : BaseTypedJsonConverter<FnStringJoin>
{
    public override void WriteJson(JsonWriter writer, FnStringJoin fn, JsonSerializer serializer)
    {
        // StringBuilder to concatenate the string representations
        // of all conditions.
        var stringBuilder = new System.Text.StringBuilder();

        foreach (var condition in fn.Values)
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