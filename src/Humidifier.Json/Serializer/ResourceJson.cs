using Humidifier.Base;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Humidifier.Json.Serializer;

public class ResourceJson
{
    public string Type { get; set; }
    public string Condition { get; set; }
    public BaseResource Properties { get; set; }
    public dynamic DependsOn { get; set; }
    public CreationPolicy CreationPolicy { get; set; }
    public UpdatePolicy UpdatePolicy { get; set; }
    [JsonConverter(typeof(StringEnumConverter))]
    public DeletionPolicy? DeletionPolicy { get; set; }
    public dynamic Metadata { get; set; }
}