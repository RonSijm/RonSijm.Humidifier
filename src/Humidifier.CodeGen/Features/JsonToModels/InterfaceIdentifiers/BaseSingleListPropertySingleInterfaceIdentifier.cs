using Humidifier.CodeGen.Features.JsonToModels.Models;

namespace Humidifier.CodeGen.Features.JsonToModels.InterfaceIdentifiers;

public abstract class BaseSingleListPropertySingleInterfaceIdentifier(string propertyName, string itemType, string interfaceName) : IInterfaceIdentifier
{
    public void FindInterface(ResourceType specificationResourceType)
    {
        foreach (var property in specificationResourceType.Properties.Where(property => property.Name == propertyName && property.Type == "List" && property.ItemType == itemType))
        {
            specificationResourceType.Interfaces ??= [];
            specificationResourceType.Interfaces.Add(new InterfaceType { Name = interfaceName });
        }
    }
}