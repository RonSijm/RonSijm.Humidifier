using Humidifier.CodeGen.Lib.Features.JsonToModels.Models;

namespace Humidifier.CodeGen.Lib.Features.JsonToModels.InterfaceIdentifiers;

public abstract class BaseSingleListPropertySingleInterfaceIdentifier(string propertyName, string itemType, string interfaceName) : IInterfaceIdentifier
{
    public void FindInterface(IClassType specificationResourceType)
    {
        if (specificationResourceType.Properties == null)
        {
            return;
        }

        foreach (var property in specificationResourceType.Properties.Where(property => property.Name == propertyName && property.Type == "List" && property.ItemType == itemType))
        {
            specificationResourceType.Interfaces ??= [];
            specificationResourceType.Interfaces.Add(new InterfaceType { Name = interfaceName });
        }
    }
}

public abstract class BaseTypePropertySingleInterfaceIdentifier(string propertyName, string itemType, string interfaceName) : IInterfaceIdentifier
{
    public void FindInterface(IClassType specificationResourceType)
    {
        if (specificationResourceType.Properties == null)
        {
            return;
        }

        foreach (var property in specificationResourceType.Properties.Where(property => property.Name == propertyName && property.CsFullTypeName == itemType))
        {
            specificationResourceType.Interfaces ??= [];
            specificationResourceType.Interfaces.Add(new InterfaceType { Name = interfaceName });
        }
    }
}