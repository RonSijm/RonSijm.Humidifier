using Newtonsoft.Json;

namespace Humidifier.Json.Converters;

internal sealed class FnLiteralConverter : BaseTypedJsonConverter<FnLiteral>
{
    public override void WriteJson(JsonWriter writer, FnLiteral value, JsonSerializer serializer)
        => serializer.Serialize(writer, value.Value);
}
