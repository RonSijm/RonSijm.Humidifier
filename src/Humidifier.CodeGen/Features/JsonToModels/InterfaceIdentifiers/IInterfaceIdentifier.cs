using Humidifier.CodeGen.Features.JsonToModels.Models;

namespace Humidifier.CodeGen.Features.JsonToModels.InterfaceIdentifiers;

public interface IInterfaceIdentifier
{
    void FindInterface(ResourceType specificationResourceType);
}