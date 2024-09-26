using Humidifier.CodeGen.Lib.Features.JsonToModels.Models;

namespace Humidifier.CodeGen.Lib.Features.JsonToModels.InterfaceIdentifiers;

public abstract class BaseSingleDynamicPropertySingleInterfaceIdentifier(string propertyName, string interfaceName) : IInterfaceIdentifier
{
    public void FindInterface(IClassType specificationResourceType)
    {
        if (specificationResourceType.Properties == null)
        {
            return;
        }

        foreach (var property in specificationResourceType.Properties.Where(property => property.Name == propertyName && property.CsFullTypeName == "dynamic"))
        {
            specificationResourceType.Interfaces ??= [];
            specificationResourceType.Interfaces.Add(new InterfaceType { Name = interfaceName });
        }
    }
}