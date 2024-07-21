namespace Humidifier.CodeGen.Features.JsonToModels.Models;

public class PropertyType
{
    public string Name { get; set; }
    public string Documentation { get; set; }
    public List<Property> Properties { get; set; }
}