using System;

namespace Humidifier.Attributes;

/// <summary>
/// We're using a custom attribute, so I don't have to reference entire Newtonsoft.Json in this project
/// </summary>
public class JsonIgnoreAttribute : Attribute
{
}