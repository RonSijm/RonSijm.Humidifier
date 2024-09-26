using System.Collections.Generic;

namespace Humidifier.Json.Serializer;

public class StackJson
{
    public string AWSTemplateFormatVersion { get; set; }
    public string Description { get; set; }
    public string Transform { get; set; }
    public Dictionary<string, Parameter> Parameters { get; set; }
    public Dictionary<string, ResourceJson> Resources { get; set; }
    public Dictionary<string, Output> Outputs { get; set; }
    public Dictionary<string, Mapping> Mappings { get; set; }
    public Dictionary<string, Condition> Conditions { get; set; }
    public Dictionary<string, dynamic> Metadata { get; set; }
}