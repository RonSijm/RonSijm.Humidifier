using Humidifier.CodeGen.Lib.Features.Extensions;
using Humidifier.CodeGen.Lib.Features.InterfaceGenerator;
using Humidifier.CodeGen.Lib.Features.JsonToModels.Models;

namespace Humidifier.Tests;

public class UnionGeneratorTests
{
    [Theory]
    [InlineData("String", "string")]
    [InlineData("Integer", "int")]
    [InlineData("Long", "long")]
    [InlineData("Double", "double")]
    [InlineData("Boolean", "bool")]
    [InlineData("Timestamp", "System.DateTime")]
    [InlineData("Json", "object")]
    public void PrimitivesRetainTheirSchemaTypes(string primitiveType, string expectedType)
    {
        var property = new Property { Name = "Value", PrimitiveType = primitiveType };
        property.SetTypeName("ExampleTypes", "Example");

        Assert.Equal($"Union<{expectedType}, BaseFunction>?", property.CsFullTypeName);
    }

    [Theory]
    [InlineData("List", "IReadOnlyList<string>", "IReadOnlyList<Union<string, BaseFunction>>")]
    [InlineData("Map", "IReadOnlyDictionary<string, string>", "IReadOnlyDictionary<string, Union<string, BaseFunction>>")]
    public void CollectionsSupportLiteralAndExpressionEntries(string type, string literal, string mixed)
    {
        var property = new Property { Name = "Values", Type = type, PrimitiveItemType = "String" };
        property.SetTypeName("ExampleTypes", "Example");

        Assert.Equal($"Union<{literal}, {mixed}, BaseFunction>?", property.CsFullTypeName);
    }

    [Fact]
    public void ComplexPropertiesAlsoAcceptExpressions()
    {
        var property = new Property { Name = "Code", Type = "Code" };
        property.SetTypeName("FunctionTypes", "Lambda");
        Assert.Equal("Union<Humidifier.Lambda.FunctionTypes.Code, BaseFunction>?", property.CsFullTypeName);
    }

    [Fact]
    public void InterfacesDoNotMergeDifferentSchemaTypes()
    {
        var names = new[] { "String", "Integer", "Boolean", "Json" }.Select(primitive =>
        {
            var property = new Property { Name = "Value", PrimitiveType = primitive };
            property.SetTypeName("ExampleTypes", "Example");
            return InterfaceGenerator.GetInterfaceName(property);
        }).ToArray();

        Assert.Equal(names.Length, names.Distinct().Count());
    }

    [Theory]
    [InlineData("Value", "Double", "DoubleValue")]
    [InlineData("Value", "Integer", "IntegerValue")]
    [InlineData("Value", "Boolean", "BooleanValue")]
    [InlineData("Body", "Json", "JsonBody")]
    public void TypedInterfaceNamesDoNotCollideWithExistingPropertyNames(string name, string primitive, string otherName)
    {
        var typed = new Property { Name = name, PrimitiveType = primitive };
        var text = new Property { Name = otherName, PrimitiveType = "String" };
        typed.SetTypeName("ExampleTypes", "Example");
        text.SetTypeName("ExampleTypes", "Example");

        Assert.NotEqual(InterfaceGenerator.GetInterfaceName(typed), InterfaceGenerator.GetInterfaceName(text));
    }
}
