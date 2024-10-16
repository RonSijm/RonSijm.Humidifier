using System.Threading.Tasks;
using Humidifier.CodeGen.Lib.Features.JsonToModels.Models;

namespace Humidifier.CodeGen.Lib.Features.InterfaceGenerator
{
    public static class InterfaceGenerator
    {
        public static async Task CreateInterfaces(this Dictionary<string, List<Property>> propertyList, string outputPath)
        {
            var tryFindMostUsedProperties = propertyList
                .Where(x => x.Value.Count > 1)
                .OrderByDescending(x => x.Value.Count)
                .ToList();

            var namespaceDeclaration = NamespaceDeclaration(ParseName("Humidifier.Interfaces"))
                .AddUsings(UsingDirective(ParseName("System.Collections.Generic")));

            foreach (var tryFindMostUsedProperty in tryFindMostUsedProperties)
            {
                var item = tryFindMostUsedProperty.Value.FirstOrDefault();
                string interfaceName = $"IHave{TransformItemName(item)}";

                var interfaceDeclaration = InterfaceDeclaration(interfaceName)
                    .AddModifiers(Token(SyntaxKind.PublicKeyword))
                    .AddBaseListTypes(SimpleBaseType(ParseTypeName("IResourceInterface")))
                    .AddMembers(PropertyDeclaration(ParseTypeName(item.CsFullTypeName), item.Name)
                        .AddAccessorListAccessors(
                            AccessorDeclaration(SyntaxKind.GetAccessorDeclaration).WithSemicolonToken(Token(SyntaxKind.SemicolonToken)),
                            AccessorDeclaration(SyntaxKind.SetAccessorDeclaration).WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                    ));

                namespaceDeclaration = namespaceDeclaration.AddMembers(interfaceDeclaration);
            }

            var compilationUnit = CompilationUnit()
                .AddUsings(UsingDirective(ParseName("System")))
                .AddMembers(namespaceDeclaration)
                .NormalizeWhitespace();

            var code = compilationUnit.ToFullString();

            var interfacePath = Path.Combine(outputPath, "Interfaces");
            var interfaceFilePath = Path.Combine(interfacePath, "ResourceInterfaces.cs");

            Directory.CreateDirectory(interfacePath);
            await File.WriteAllTextAsync(interfaceFilePath, code);
        }

        private static string TransformItemName(Property item)
        {
            if (item.IsSystemType)
            {
                switch (item.CsFullTypeName)
                {
                    case "dynamic" when item.Name == "Tags":
                        return $"Dynamic{item.Name}";
                    case "dynamic":
                        return $"{item.Name}";
                    case "Dictionary<string, dynamic>":
                        return $"DynDicOf{item.Name}";
                    default:
                    {
                        if (item.Type == "List")
                        {
                            return $"{item.PrimitiveItemType}ListOf{item.Name}";
                        }

                        break;
                    }
                }
            }
            else if (item.CsFullTypeName == "List<Tag>")
            {
                return item.Name;
            }

            else if (item.NameSpace != null && item.ParentName != null)
            {
                if (item.ItemType != null)
                {
                    return item.Type == "List" ? $"ListOf{item.NameSpace}{item.ParentName}{item.ItemType}{item.Name}" : $"{item.NameSpace}{item.ParentName}{item.ItemType}{item.Name}";
                }

                return $"{item.NameSpace}{item.ParentName}{item.Type}{item.Name}";
            }

            return null;
        }
    }
}
