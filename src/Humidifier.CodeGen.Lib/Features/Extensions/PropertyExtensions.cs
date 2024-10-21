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
        string typeName;

        if (!string.IsNullOrWhiteSpace(property.PrimitiveType))
        {
            //switch (property.PrimitiveType)
            //{
            //    case "String":
            //        return "DynamicString";
            //        break;

            //}

            // NOTE: We can't actually use strong typing because of the cloudformation intrinsics functions :(
            // I thought about doing something like DynamicInt, DynamicString etc so that you still get a bit of an indication of what the type should be.
            // At least the xmldoc comments show the correct types in intellisense.
            property.NameSpace = nameSpace;
            property.ParentName = propsNamespace;
            property.CsFullTypeName = "dynamic";
            property.IsSystemType = true;
            return;
#if false
                switch (property.PrimitiveType)
                {
                    case "String":
                        typeName = "dynamic";
                        break;
                    case "Long":
                    case "Double":
                        typeName = property.PrimitiveType.ToLower();
                        if (!property.Required) typeName += "?";
                        break;
                    case "Boolean":
                        typeName = "bool";
                        if (!property.Required) typeName += "?";
                        break;
                    case "Integer":
                        typeName = "int";
                        if (!property.Required) typeName += "?";
                        break;
                    case "Timestamp":
                        typeName = "System.DateTime";
                        break;
                    case "Json":
                        typeName = "dynamic";
                        break;
                    default:
                        throw new InvalidOperationException($"Unknown PrimitiveType: {property.PrimitiveType}");
                }
#endif
        }

        Debug.Assert(property.PrimitiveType == null);

        switch (property.Type)
        {
            // TODO: Might have use "List<dynamic>" dynamic[] or dynamic.
            case "List":
                if (property.PrimitiveItemType != null)
                {
                    switch (property.PrimitiveItemType)
                    {
                        case "String":
                            typeName = "dynamic";
                            break;
                        case "Long":
                            typeName = "List<long>";
                            break;
                        case "Double":
                            typeName = "List<double>";
                            break;
                        case "Boolean":
                            typeName = "List<bool>";
                            break;
                        case "Integer":
                            typeName = "List<int>";
                            break;
                        case "Timestamp":
                            typeName = "List<DateTime>";
                            break;
                        case "Json":
                            typeName = "List<dynamic>";
                            break;
                        default:
                            throw new InvalidOperationException(
                                $"Unknown PrimitiveItemType: {property.PrimitiveItemType}");
                    }

                    property.IsSystemType = true;
                }
                else
                {
                    // Hack, SshPublicKey contains object of primitive type String
                    if (property.ItemType == "SshPublicKey")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(
                            $"WARN::Property name: {property.Name} is a primitive type: {property.ItemType}");
                        Console.ResetColor();
                        typeName = "List<dynamic>";
                        property.IsSystemType = true;
                    }
                    else
                    {
                        if (property.ItemType == "Tag" || property.ItemType == "Protocol" || property.ItemType == "StructuredLogDestination")
                        {
                            typeName = $"List<{property.ItemType}>";
                        }
                        else
                        {
                            typeName = $"List<Humidifier.{nameSpace}.{propsNamespace}.{property.ItemType}>";
                        }
                    }
                }

                break;

            // TODO: Might have to use "Dictionary<string, dynamic>"
            case "Map":
                if (property.PrimitiveItemType != null)
                {
                    switch (property.PrimitiveItemType)
                    {
                        case "String":
                            typeName = "Dictionary<string, dynamic>";
                            break;
                        case "Boolean":
                            typeName = "Dictionary<string, bool>";
                            break;

                        // Not sure if this works, but if the specs expect Json,
                        // I guess you can just add a random object and serialize it right?
                        case "Json":
                            typeName = "dynamic";
                            break;

                        default:
                            throw new InvalidOperationException(
                                $"Unknown PrimitiveItemType: {property.PrimitiveItemType}");


                    }

                    property.IsSystemType = true;
                }
                else
                    // Console.WriteLine("Map:: " + property.ItemType);
                    typeName = $"Dictionary<string, Humidifier.{nameSpace}.{propsNamespace}.{property.ItemType}>";

                break;

            default:
                // Console.WriteLine("Struct:: " + property.Type);
                typeName = $"Humidifier.{nameSpace}.{propsNamespace}.{property.Type}";
                break;
        }

        property.NameSpace = nameSpace;
        property.ParentName = propsNamespace;
        property.CsFullTypeName = typeName;
    }
}