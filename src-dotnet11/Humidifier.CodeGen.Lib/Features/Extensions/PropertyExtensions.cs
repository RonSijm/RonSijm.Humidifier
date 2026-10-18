using Humidifier.CodeGen.Lib.Features.JsonToModels.Models;

namespace Humidifier.CodeGen.Lib.Features.Extensions;

public static class PropertyExtensions
{
    public static string GetComment(this Property property)
    {
            var sb = new StringBuilder();

            sb.AppendLineCRLF("/// <summary>");
            sb.AppendLineCRLF($"/// {property.Name}");
            sb.AppendLineCRLF($"/// {property.Documentation}");
            sb.AppendLineCRLF($"/// Required: {property.Required}");
            sb.AppendLineCRLF($"/// UpdateType: {property.UpdateType}");

            if (!string.IsNullOrWhiteSpace(property.Type))
            {
                sb.AppendLineCRLF($"/// Type: {property.Type}");
            }

            if (!string.IsNullOrWhiteSpace(property.ItemType))
            {
                sb.AppendLineCRLF($"/// ItemType: {property.ItemType}");
            }

            if (!string.IsNullOrWhiteSpace(property.PrimitiveItemType))
            {
                sb.AppendLineCRLF($"/// PrimitiveItemType: {property.PrimitiveItemType}");
            }

            if (!string.IsNullOrWhiteSpace(property.PrimitiveType))
            {
                sb.AppendLineCRLF($"/// PrimitiveType: {property.PrimitiveType}");
            }

            sb.AppendLineCRLF("/// </summary>");

            return sb.ToString();
        }


    public static void SetTypeName(this Property property, string propsNamespace, string nameSpace)
    {
        property.NameSpace = nameSpace;
        property.ParentName = propsNamespace;
        property.IsSystemType = property.PrimitiveType != null || property.PrimitiveItemType != null;

        if (property.PrimitiveType != null)
        {
            property.CsValueTypeName = GetPrimitiveType(property.PrimitiveType);
            property.CsFullTypeName = $"Union<{property.CsValueTypeName}, BaseFunction>?";
            return;
        }

        if (property.Type is "List" or "Map")
        {
            // The specification describes SshPublicKey as a property type containing a string.
            var itemType = property.PrimitiveItemType != null
                ? GetPrimitiveType(property.PrimitiveItemType)
                : property.ItemType == "SshPublicKey"
                    ? "string"
                    : GetObjectType(property.ItemType, propsNamespace, nameSpace);

            if (property.Type == "List")
            {
                property.CsValueTypeName = $"List<{itemType}>";
                property.CsFullTypeName = $"Union<IReadOnlyList<{itemType}>, IReadOnlyList<Union<{itemType}, BaseFunction>>, BaseFunction>?";
            }
            else
            {
                property.CsValueTypeName = $"Dictionary<string, {itemType}>";
                property.CsFullTypeName = $"Union<IReadOnlyDictionary<string, {itemType}>, IReadOnlyDictionary<string, Union<{itemType}, BaseFunction>>, BaseFunction>?";
            }

            return;
        }

        property.CsValueTypeName = GetObjectType(property.Type, propsNamespace, nameSpace);
        property.CsFullTypeName = $"Union<{property.CsValueTypeName}, BaseFunction>?";
    }

    private static string GetPrimitiveType(string primitiveType) => primitiveType switch
    {
        "String" => "string",
        "Long" => "long",
        "Double" => "double",
        "Boolean" => "bool",
        "Integer" => "int",
        "Timestamp" => "System.DateTime",
        // AWS explicitly permits arbitrary JSON here, including policy DTOs and anonymous objects.
        "Json" => "object",
        _ => throw new InvalidOperationException($"Unknown primitive type: {primitiveType}")
    };

    private static string GetObjectType(string type, string propsNamespace, string nameSpace) => type switch
    {
        "Tag" => "Humidifier.Tag",
        "Protocol" or "StructuredLogDestination" => $"Humidifier.Transfer.{type}",
        _ => $"Humidifier.{nameSpace}.{propsNamespace}.{type}"
    };
}
