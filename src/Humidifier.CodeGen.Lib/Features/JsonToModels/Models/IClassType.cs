namespace Humidifier.CodeGen.Lib.Features.JsonToModels.Models;

public interface IClassType
{
    string Group { get; }
    string ClassName { get; }
    List<Property> Properties { get; }
    public List<InterfaceType> Interfaces { get; set; }
}