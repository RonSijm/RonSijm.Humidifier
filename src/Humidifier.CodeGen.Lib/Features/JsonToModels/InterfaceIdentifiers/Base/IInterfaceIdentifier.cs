using Humidifier.CodeGen.Lib.Features.JsonToModels.Models;

namespace Humidifier.CodeGen.Lib.Features.JsonToModels.InterfaceIdentifiers;

[UsedImplicitly(ImplicitUseTargetFlags.WithInheritors)]
public interface IInterfaceIdentifier
{
    void FindInterface(IClassType specificationResourceType);
}