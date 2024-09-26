using Humidifier.CodeGen.Lib.Features.Extensions;
using Humidifier.CodeGen.Lib.Features.JsonToModels.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Humidifier.CodeGen.Lib.Features.ModelToClasses;

public class SpecsModelToClassConverter
{
    public List<(ResourceType, string)> ParseSpecsToCode(Specification specification)
    {
        Console.WriteLine("Parsing spec");

        var syntaxTreeResults = ParseSpecsToTrees(specification);

        var syntaxTreesToCode = ToCode(syntaxTreeResults);

        return syntaxTreesToCode;
    }

    public List<(ResourceType, string)> ToCode(List<(ResourceType, NamespaceDeclarationSyntax)> syntaxTreeResults)
    {
        var syntaxTreesToCode = syntaxTreeResults
            .Select(result => (result.Item1, result.Item2.NormalizeWhitespace().ToFullString())).ToList();

        return syntaxTreesToCode;
    }

    public List<(ResourceType, NamespaceDeclarationSyntax)> ParseSpecsToTrees(Specification specification)
    {
        var syntaxTreeResults = new List<(ResourceType, NamespaceDeclarationSyntax)>();

        foreach (var resourceType in specification.ResourceTypes)
        {
            var propsNamespace = $"{resourceType.ClassName}Types";

            var namespaceDecl = NamespaceDeclaration(ParseName($"Humidifier.{resourceType.Group}"))
                .AddUsings(UsingDirective(ParseName("System.Collections.Generic")));

            var propertyTypes = specification.PropertyTypes.Where(x => x.Name.StartsWith($"{resourceType.Name}.")).ToList();

            if (propertyTypes.Any())
            {
                namespaceDecl = namespaceDecl.AddUsings(UsingDirective(ParseName(propsNamespace)));
            }

            var resourceClassDecl = ClassDeclaration(resourceType.ClassName)
                .AddModifiers(Token(SyntaxKind.PublicKeyword))
                .AddBaseListTypes(SimpleBaseType(ParseTypeName("Humidifier.Base.BaseResource")));

            if (resourceType.Attributes != null)
            {
                var attributesClassDecl = ClassDeclaration("Attributes")
                        .AddModifiers(Token(SyntaxKind.PublicKeyword))
                    //.AddModifiers(Token(SyntaxKind.StaticKeyword))
                    ;

                foreach (var attribute in resourceType.Attributes)
                {
                    if (attribute.Name.Contains(".") && attribute.Name != resourceType.ClassName)
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

            var propertyDecAWSType = PropertyDeclaration(ParseTypeName("string"), "AWSTypeName")
                .AddModifiers(Token(SyntaxKind.PublicKeyword))
                .AddModifiers(Token(SyntaxKind.OverrideKeyword))
                .AddAccessorListAccessors(
                    AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
                        .WithExpressionBody(ArrowExpressionClause(
                            IdentifierName($"{resourceType.Parts[0]}.{resourceType.Parts[1]}.{resourceType.Parts[2]}")))
                        .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                    );

            //var propertyDecAWSType2 = PropertyDeclaration(ParseTypeName("string"), "AWSTypeName")
            //    .AddModifiers(Token(SyntaxKind.PublicKeyword))
            //    .AddModifiers(Token(SyntaxKind.OverrideKeyword))
            //    .AddAccessorListAccessors(
            //        AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
            //            .WithExpressionBody(ArrowExpressionClause(
            //                IdentifierName("GivenName")))
            //            .WithSemicolonToken(Token(SyntaxKind.SemicolonToken)),
            //        AccessorDeclaration(SyntaxKind.SetAccessorDeclaration)
            //            .WithExpressionBody(ArrowExpressionClause(
            //                AssignmentExpression(
            //                    SyntaxKind.SimpleAssignmentExpression,
            //                    IdentifierName("GivenName"),
            //                    IdentifierName("value"))))
            //            .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))



resourceClassDecl = resourceClassDecl.AddMembers(propertyDecAWSType);


            var hasImpliedResourceName = false;

            foreach (var property in resourceType.Properties)
            {
                if (property.Name == resourceType.ClassName || property.Name == "Attributes")
                {
                    property.Name += "_";
                }

                var commentDecl = ParseLeadingTrivia(property.GetComment());

                if (property.Name == "Name" || property.Name == $"{resourceType.ClassName}Name" && !hasImpliedResourceName)
                {
                    hasImpliedResourceName = true;

                    var propertyDecl = PropertyDeclaration(IdentifierName("dynamic"), property.Name)
                        .AddModifiers(Token(SyntaxKind.PublicKeyword))
                        .AddAccessorListAccessors(
                            AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
                                .WithExpressionBody(ArrowExpressionClause(
                                    IdentifierName("GivenName")))
                                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken)),
                            AccessorDeclaration(SyntaxKind.SetAccessorDeclaration)
                                .WithExpressionBody(ArrowExpressionClause(
                                    AssignmentExpression(
                                        SyntaxKind.SimpleAssignmentExpression,
                                        IdentifierName("GivenName"),
                                        IdentifierName("value"))))
                                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                        );

                    resourceClassDecl = resourceClassDecl.AddMembers(propertyDecl);



                }
                else if (property.Name == $"{resourceType.ClassName}Description")
                {
                    resourceClassDecl = AddTypeProperty(property.CsFullTypeName, property, commentDecl, resourceClassDecl);

                    var propertyDecl = PropertyDeclaration(IdentifierName("dynamic"), "Description")
                        .AddModifiers(Token(SyntaxKind.PublicKeyword))
                        .AddAttributeLists(
                            AttributeList(
                                SingletonSeparatedList(
                                    Attribute(
                                        IdentifierName("Ignore"))
                                )
                            )
                        )
                        .AddAccessorListAccessors(
                            AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
                                .WithExpressionBody(ArrowExpressionClause(
                                    IdentifierName(property.Name)))
                                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken)),
                            AccessorDeclaration(SyntaxKind.SetAccessorDeclaration)
                                .WithExpressionBody(ArrowExpressionClause(
                                    AssignmentExpression(
                                        SyntaxKind.SimpleAssignmentExpression,
                                        IdentifierName(property.Name),
                                        IdentifierName("value"))))
                                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                        );

                    resourceClassDecl = resourceClassDecl.AddMembers(propertyDecl);

                    resourceType.Interfaces ??= [];
                    resourceType.Interfaces.Add(new InterfaceType() { Name = "IHaveDescription" });
                }
                else
                {
                    resourceClassDecl = AddTypeProperty(property.CsFullTypeName, property, commentDecl, resourceClassDecl);
                }
            }

            if (hasImpliedResourceName)
            {
                resourceClassDecl = resourceClassDecl.AddBaseListTypes(SimpleBaseType(ParseTypeName("IHaveImpliedResourceName")));
            }

            var propertyTypesNamespace = NamespaceDeclaration(ParseName(propsNamespace));

            foreach (var propertyType in propertyTypes)
            {
                var propertyTypeClassDecl = ClassDeclaration(propertyType.ClassName)
                    .AddModifiers(Token(SyntaxKind.PublicKeyword))
                    .AddBaseListTypes(SimpleBaseType(ParseTypeName("Humidifier.Base.BaseSubResource")));

                if (propertyType.Interfaces != null)
                {
                    foreach (var interfaceType in propertyType.Interfaces)
                    {
                        propertyTypeClassDecl = propertyTypeClassDecl.AddBaseListTypes(SimpleBaseType(ParseTypeName(interfaceType.Name)));
                    }
                }

                if (propertyType.Properties != null)
                {
                    foreach (var property in propertyType.Properties)
                    {
                        if (property.Name == propertyType.ClassName || property.Name == "Attributes")
                        {
                            property.Name += "_";
                        }

                        var commentDecl = ParseLeadingTrivia(property.GetComment());

                        var propertyDecl = PropertyDeclaration(ParseTypeName(property.CsFullTypeName), property.Name)
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

            if (resourceType.Interfaces != null)
            {
                foreach (var interfaceType in resourceType.Interfaces)
                {
                    resourceClassDecl = resourceClassDecl.AddBaseListTypes(SimpleBaseType(ParseTypeName(interfaceType.Name)));
                }
            }

            // Don't modify resourceClassDecl below here, it has no effect after it's been added to the namespace.
            namespaceDecl = namespaceDecl.AddMembers(resourceClassDecl);

            if (propertyTypes.Any())
            {
                namespaceDecl = namespaceDecl.AddMembers(propertyTypesNamespace);
            }

            syntaxTreeResults.Add((resourceType, namespaceDecl));
        }

        return syntaxTreeResults;
    }

    private static ClassDeclarationSyntax AddTypeProperty(string typeName, Property property, SyntaxTriviaList commentDecl, ClassDeclarationSyntax resourceClassDecl)
    {
        var propertyDecl = PropertyDeclaration(ParseTypeName(typeName), $"{property.Name}").AddModifiers(Token(SyntaxKind.PublicKeyword));

        if (property.Required)
        {
            propertyDecl = propertyDecl.AddAttributeLists(
                AttributeList(
                    SingletonSeparatedList(
                        Attribute(
                            IdentifierName("Required"))
                    )
                )
            );
        }

        propertyDecl = propertyDecl.AddAccessorListAccessors(
                    AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
                        .WithSemicolonToken(Token(SyntaxKind.SemicolonToken)),
                    AccessorDeclaration(SyntaxKind.SetAccessorDeclaration)
                        .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                )
                .WithLeadingTrivia(TriviaList(commentDecl))
            ;

        resourceClassDecl = resourceClassDecl.AddMembers(propertyDecl);
        return resourceClassDecl;
    }
}