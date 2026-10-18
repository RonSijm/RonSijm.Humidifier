namespace Humidifier.CodeGen.Lib.Features.JsonToModels.Models;

public class Specification
{
    public string ResourceSpecificationVersion { get; set; }
    public List<PropertyType> PropertyTypes { get; set; } = new List<PropertyType>();
    public List<ResourceType> ResourceTypes { get; set; } = new List<ResourceType>();
}