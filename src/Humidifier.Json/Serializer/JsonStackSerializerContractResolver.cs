using System;
using System.Collections.Generic;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Humidifier.Json.Serializer;


public class JsonStackSerializerContractResolver : DefaultContractResolver
{
    protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
    {
        var properties = base.CreateProperties(type, memberSerialization);

        foreach (var jsonProperty in properties)
        {
            // Removes trailing underscore from property names
            if (jsonProperty.PropertyName.EndsWith("_"))
            {
                jsonProperty.PropertyName = jsonProperty.PropertyName.TrimEnd('_');
            }
        }

        return properties;
    }

    protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
    {
        var property = base.CreateProperty(member, memberSerialization);

        if (property.AttributeProvider.GetAttributes(typeof(JsonIgnore), true).Count > 0)
        {
            //property.Ignored = true;
            property.ShouldSerialize = _ => false;
        }

        if (member.MemberType != MemberTypes.Property)
        {
            return property;
        }

        var propInfo = member as PropertyInfo;

        var baseProperty = member.DeclaringType.BaseType?.GetProperty(member.Name, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

        if (baseProperty == null)
        {
            return property;
        }

        var baseHasJsonIgnore = baseProperty.GetCustomAttribute<JsonIgnore>() != null;

        if (baseHasJsonIgnore)
        {
            //property.Ignored = true; // Ignore the property
            property.ShouldSerialize = _ => false;
        }

        return property;
    }
}