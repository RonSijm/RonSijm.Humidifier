using Humidifier.CodeGen.Lib.Features.JsonToModels.Models;

namespace Humidifier.CodeGen.Lib.Features.Extensions;

public static class PropertyExtensions
{
    public static string GetComment(this Property property)
    {
            var sb = new StringBuilder();

            sb.AppendLine("/// <summary>");
            sb.AppendLine($"/// {property.Name}");
            sb.AppendLine($"/// {property.Documentation}");
            sb.AppendLine($"/// Required: {property.Required}");
            sb.AppendLine($"/// UpdateType: {property.UpdateType}");

            if (!string.IsNullOrWhiteSpace(property.Type))
            {
                sb.AppendLine($"/// Type: {property.Type}");
            }

            if (!string.IsNullOrWhiteSpace(property.ItemType))
            {
                sb.AppendLine($"/// ItemType: {property.ItemType}");
            }

            if (!string.IsNullOrWhiteSpace(property.PrimitiveItemType))
            {
                sb.AppendLine($"/// PrimitiveItemType: {property.PrimitiveItemType}");
            }

            if (!string.IsNullOrWhiteSpace(property.PrimitiveType))
            {
                sb.AppendLine($"/// PrimitiveType: {property.PrimitiveType}");
            }

            sb.AppendLine("/// </summary>");

            return sb.ToString();
        }


    public static string GetTypeName(this Property property, string propsNamespace)
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
                    return "dynamic";
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
                    }
                    else
                    {
                        if (property.ItemType == "Tag" || property.ItemType == "Protocol" || property.ItemType == "StructuredLogDestination")
                        {
                            typeName = $"List<{property.ItemType}>";
                        }
                        else
                        {
                            typeName = $"List<{propsNamespace}.{property.ItemType}>";
                        }
                    }
                }

                break;

            // TODO: Might have to use "Dictionary<string, dynamic>"
            case "Map":
                if (property.PrimitiveItemType != null)
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
                else
                    // Console.WriteLine("Map:: " + property.ItemType);
                    typeName = $"Dictionary<string, {propsNamespace}.{property.ItemType}>";

                break;

            default:
                // Console.WriteLine("Struct:: " + property.Type);
                typeName = $"{propsNamespace}.{property.Type}";
                break;
        }

        return typeName;
    }
}