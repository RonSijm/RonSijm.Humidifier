using Humidifier.CodeGen.Features.Extensions;
using Humidifier.CodeGen.Features.JsonToModels.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Humidifier.CodeGen.Features.ModelToClasses;

public class SpecsModelToClassConverter
{
    public List<(ResourceType, string)> ParseSpecsToCode(Specification specification)
    {
        Console.WriteLine("Parsing spec");

        var syntaxTreeResults = ParseSpecsToTrees(specification);

        var syntaxTreesToCode = syntaxTreeResults
            .Select(result => (result.Item1, result.Item2.NormalizeWhitespace().ToFullString())).ToList();

        return syntaxTreesToCode;
    }

    public List<(ResourceType, NamespaceDeclarationSyntax)> ParseSpecsToTrees(Specification specification)
    {
        var syntaxTreeResults = new List<(ResourceType, NamespaceDeclarationSyntax)>();

        foreach (var resourceType in specification.ResourceTypes)
        {
            var propsNamespace = $"{resourceType.ResourceClassName}Types";

            var namespaceDecl = NamespaceDeclaration(ParseName($"Humidifier.{resourceType.Group}"))
                .AddUsings(UsingDirective(ParseName("System.Collections.Generic"))
                );

            var propertyTypes = specification.PropertyTypes.Where(x => x.Name.StartsWith($"{resourceType.Name}."))
                .ToList();

            if (propertyTypes.Any())
            {
                namespaceDecl = namespaceDecl.AddUsings(UsingDirective(ParseName(propsNamespace)));

            }

            var resourceClassDecl = ClassDeclaration(resourceType.ResourceClassName)
                .AddModifiers(Token(SyntaxKind.PublicKeyword))
                .AddBaseListTypes(SimpleBaseType(ParseTypeName("Humidifier.Resource")));

            if (resourceType.Interfaces != null)
            {
                foreach (var interfaceType in resourceType.Interfaces)
                {
                    resourceClassDecl = resourceClassDecl.AddBaseListTypes(SimpleBaseType(ParseTypeName(interfaceType.Name)));
                }
            }

            if (resourceType.Attributes != null)
            {
                var attributesClassDecl = ClassDeclaration("Attributes")
                        .AddModifiers(Token(SyntaxKind.PublicKeyword))
                    //.AddModifiers(Token(SyntaxKind.StaticKeyword))
                    ;

                foreach (var attribute in resourceType.Attributes)
                {
                    if (attribute.Name.Contains(".") && attribute.Name != resourceType.ResourceClassName)
                    {
                        continue;
                    }

                    var tokens = attribute.Name.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
                    var attributeName = tokens.Length == 2 ? tokens[1] : tokens[0];

                    var propertyDecl = PropertyDeclaration(ParseTypeName("string"), attributeName)
                        .WithTrailingTrivia(
                            Trivia(SkippedTokensTrivia().WithTokens(TokenList(Token(SyntaxKind.EqualsToken)))),
                            Trivia(SkippedTokensTrivia().WithTokens(TokenList(Literal(attributeName))))
                        )
                        .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                        .AddModifiers(Token(SyntaxKind.PublicKeyword))
                        .AddModifiers(Token(SyntaxKind.StaticKeyword));

                    attributesClassDecl = attributesClassDecl.AddMembers(propertyDecl);
                }

                resourceClassDecl = resourceClassDecl.AddMembers(attributesClassDecl);
            }

            {
                var propertyDecAWSType = PropertyDeclaration(ParseTypeName("string"), "AWSTypeName")
                    .AddModifiers(Token(SyntaxKind.PublicKeyword))
                    .AddModifiers(Token(SyntaxKind.OverrideKeyword))
                    .AddAccessorListAccessors(
                        AccessorDeclaration(SyntaxKind.GetAccessorDeclaration).WithBody(Block(
                                ReturnStatement(
                                    LiteralExpression(
                                        SyntaxKind.StringLiteralExpression,
                                        Literal($@"@""{resourceType.Name}""", resourceType.Name)
                                    )
                                )
                            )
                        )
                    );

                resourceClassDecl = resourceClassDecl.AddMembers(propertyDecAWSType);
            }

            foreach (var property in resourceType.Properties)
            {
                var typeName = property.GetTypeName();

                var propertyName = property.Name;
                if (propertyName == resourceType.ResourceClassName || propertyName == "Attributes")
                {
                    propertyName += "_";
                }

                var commentDecl = ParseLeadingTrivia(property.GetComment());

                var propertyDecl = PropertyDeclaration(ParseTypeName(typeName), propertyName)
                        .AddModifiers(Token(SyntaxKind.PublicKeyword))
                        .AddAccessorListAccessors(
                            AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
                                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken)),
                            AccessorDeclaration(SyntaxKind.SetAccessorDeclaration)
                                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                        )
                        .WithLeadingTrivia(TriviaList(commentDecl))
                    ;

                resourceClassDecl = resourceClassDecl.AddMembers(propertyDecl);
            }

            var propertyTypesNamespace = NamespaceDeclaration(ParseName(propsNamespace));

            foreach (var propertyType in propertyTypes)
            {
                var split = propertyType.Name.Split(new[] { "::" }, StringSplitOptions.RemoveEmptyEntries);
                var propertyTypeClassName = split[2].Split(new[] { "." }, StringSplitOptions.RemoveEmptyEntries)[1];

                var propertyTypeClassDecl = ClassDeclaration(propertyTypeClassName)
                    .AddModifiers(Token(SyntaxKind.PublicKeyword));

                if (propertyType.Properties != null)
                {
                    foreach (var property in propertyType.Properties)
                    {
                        var typeName = property.GetTypeName();

                        var propertyName = property.Name;
                        if (property.Name == propertyTypeClassName || propertyName == "Attributes")
                            propertyName += "_";

                        var commentDecl = ParseLeadingTrivia(property.GetComment());

                        var propertyDecl = PropertyDeclaration(ParseTypeName(typeName), propertyName)
                                .AddModifiers(Token(SyntaxKind.PublicKeyword))
                                .AddAccessorListAccessors(
                                    AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
                                        .WithSemicolonToken(Token(SyntaxKind.SemicolonToken)),
                                    AccessorDeclaration(SyntaxKind.SetAccessorDeclaration)
                                        .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                                )
                                .WithLeadingTrivia(TriviaList(commentDecl))
                            ;

                        propertyTypeClassDecl = propertyTypeClassDecl.AddMembers(propertyDecl);
                    }
                }

                propertyTypesNamespace = propertyTypesNamespace.AddMembers(propertyTypeClassDecl);
            }

            namespaceDecl = namespaceDecl.AddMembers(resourceClassDecl);

            if (propertyTypes.Any())
            {
                namespaceDecl = namespaceDecl.AddMembers(propertyTypesNamespace);
            }


            syntaxTreeResults.Add((resourceType, namespaceDecl));
        }

        return syntaxTreeResults;
    }
}