﻿using System;
using Newtonsoft.Json;

namespace Humidifier.Json.Converters;

public class ConditionConverter : JsonConverter
{
    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) => throw new NotImplementedException();
    public override bool CanConvert(Type objectType) => objectType == typeof(Condition);

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        var condition = (Condition)value;
        serializer.Serialize(writer, condition.Fn);
    }
}