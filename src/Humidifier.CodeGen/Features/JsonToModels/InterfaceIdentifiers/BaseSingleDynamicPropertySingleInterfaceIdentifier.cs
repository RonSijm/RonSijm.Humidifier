using Humidifier.CodeGen.Features.JsonToModels.Models;

namespace Humidifier.CodeGen.Features.JsonToModels.InterfaceIdentifiers;

public abstract class BaseSingleDynamicPropertySingleInterfaceIdentifier(string propertyName, string interfaceName) : IInterfaceIdentifier
{
    public void FindInterface(ResourceType specificationResourceType)
    {
        foreach (var property in specificationResourceType.Properties.Where(property => property.Name == propertyName && property.ItemType == null))
        {
            specificationResourceType.Interfaces ??= [];
            specificationResourceType.Interfaces.Add(new InterfaceType { Name = interfaceName });
        }
    }
}