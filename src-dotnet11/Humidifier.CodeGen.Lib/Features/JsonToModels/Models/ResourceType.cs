namespace Humidifier.CodeGen.Lib.Features.JsonToModels.Models;

[DebuggerDisplay("{Name} - {ClassName}")]
public class ResourceType : IClassType
{
    private string _name;

    public string Name
    {
        get => _name;
        set
        {
            _name = value;

            Parts = value.Split(new[] { "::" }, StringSplitOptions.RemoveEmptyEntries);

            Group = Parts[1];
            ClassName = Parts[2];
        }
    }

    public string[] Parts { get; private set; }
    public string Group { get; private set; }
    public string ClassName { get; private set; }

    public string Documentation { get; set; }
    public List<Property> Properties { get; set; }
    public List<Attribute> Attributes { get; set; }
    public List<InterfaceType> Interfaces { get; set; }
}