using System.Threading.Tasks;
using Humidifier.CodeGen.Lib.Features.JsonToModels.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Humidifier.CodeGen.Lib.Features.InterfaceGenerator
{
    public static class InterfaceGenerator
    {
        public static async Task CreateInterfaces(this Dictionary<string, List<Property>> propertyList, string outputPath)
        {
            var tryFindMostUsedProperties = propertyList
                .Where(x => x.Value.Count > 0)
                .OrderByDescending(x => x.Value.Count)
                .ToList();

            var namespaceDeclaration = NamespaceDeclaration(ParseName("Humidifier.Interfaces"))
                .AddUsings(UsingDirective(ParseName("global::System.Collections.Generic")));
            var interfaceDeclarations = new List<InterfaceDeclarationSyntax>();

            foreach (var tryFindMostUsedProperty in tryFindMostUsedProperties)
            {
                var item = tryFindMostUsedProperty.Value.FirstOrDefault();

                string interfaceName = GetInterfaceName(item);

                var interfaceDeclaration = InterfaceDeclaration(interfaceName)
                    .AddModifiers(Token(SyntaxKind.PublicKeyword))
                    .AddBaseListTypes(SimpleBaseType(ParseTypeName("IResourceInterface")))
                    .AddMembers(PropertyDeclaration(ParseTypeName(item.CsFullTypeName), item.Name)
                        .AddAccessorListAccessors(
                            AccessorDeclaration(SyntaxKind.GetAccessorDeclaration).WithSemicolonToken(Token(SyntaxKind.SemicolonToken)),
                            AccessorDeclaration(SyntaxKind.SetAccessorDeclaration).WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                    ));

                interfaceDeclarations.Add(interfaceDeclaration);
            }

            namespaceDeclaration = namespaceDeclaration.AddMembers(interfaceDeclarations.ToArray());

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

        public static string GetInterfaceName(Property item) => $"IHave{TransformItemName(item)}";

        private static string TransformItemName(Property item)
        {
            // Properties sharing a name can have different schema types. Keep their
            // interfaces distinct instead of merging them through dynamic.
            if (item.PrimitiveType != null)
            {
                return item.PrimitiveType == "String" ? item.Name : $"{item.Name}_{item.PrimitiveType}";
            }

            if (item.IsSystemType)
            {
                if (item.Type == "List")
                {
                    return $"{item.PrimitiveItemType}ListOf{item.Name}";
                }

                if (item.Type == "Map")
                {
                    return $"{item.PrimitiveItemType}DictionaryOf{item.Name}";
                }
            }
            else if (item.CsValueTypeName == "List<Humidifier.Tag>")
            {
                return item.Name is "Tags" or "MatchAnyTag" ? item.Name : $"TagListOf{item.Name}";
            }
            else if (item.CsValueTypeName is "Humidifier.Tag" or "Humidifier.Transfer.Protocol" or "Humidifier.Transfer.StructuredLogDestination")
            {
                var customTypeName = item.CsValueTypeName.Split('.').Last();
                return $"{customTypeName}{item.Name}";
            }

            else if (item.NameSpace != null && item.ParentName != null)
            {
                if (item.ItemType != null)
                {
                    return item.Type switch
                    {
                        "List" => $"ListOf{item.NameSpace}{item.ParentName}{item.ItemType}{item.Name}",
                        "Map" => $"MapOf{item.NameSpace}{item.ParentName}{item.ItemType}{item.Name}",
                        _ => $"{item.NameSpace}{item.ParentName}{item.ItemType}{item.Name}"
                    };
                }

                return $"{item.NameSpace}{item.ParentName}{item.Type}{item.Name}";
            }

            return null;
        }
    }
}
