using Humidifier.Base;
using Newtonsoft.Json;

namespace Humidifier.Json.Converters;

public abstract class BaseResultFactoryJsonConverter<T> : BaseTypedJsonConverter<T> where T : IHaveResultFactory
{
    public override void WriteJson(JsonWriter writer, T value, JsonSerializer serializer)
    {
        var factory = value.Result;
        var baseResource = factory.Result;

        WriteJson(writer, baseResource, serializer);
    }

    public abstract void WriteJson(JsonWriter writer, BaseResource value, JsonSerializer serializer);
}