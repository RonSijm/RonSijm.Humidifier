namespace Humidifier.CodeGen.Lib.Features.JsonToModels.Models;

public class PropertyType : IClassType
{
    private string _name;

    public string Name
    {
        get => _name;
        set
        {
            _name = value;

            Parts = value.Split(new[] { "::" }, StringSplitOptions.RemoveEmptyEntries);

            if (Parts.Length != 3)
            {
                return;
            }

            var strings = Parts[2].Split(new[] { "." }, StringSplitOptions.RemoveEmptyEntries);

            Group = Parts[1];
            ResourceClassName = strings[0];
            ClassName = strings[1];
        }
    }

    public string[] Parts { get; private set; }
    public string Group { get; private set; }
    public string ClassName { get; private set; }

    public string ResourceClassName { get; private set; }

    public string Documentation { get; set; }
    public List<Property> Properties { get; set; }
    public List<InterfaceType> Interfaces { get; set; }
}