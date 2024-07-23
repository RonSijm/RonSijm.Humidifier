using Humidifier.CodeGen.Features.Extensions;
using Humidifier.CodeGen.Features.JsonToModels.InterfaceIdentifiers;
using Humidifier.CodeGen.Features.JsonToModels.Models;

namespace Humidifier.CodeGen.Features.JsonToModels;

public class SpecificationToModelParser(IEnumerable<IInterfaceIdentifier> interfaceIdentifiers)
{
    private readonly List<IInterfaceIdentifier> _interfaceIdentifiers = interfaceIdentifiers.ToList();

    public Specification ParseSpecification(string json)
    {
        var parsed = JsonConvert.DeserializeObject<JObject>(json);

        var specification = new Specification
        {
            ResourceSpecificationVersion = parsed.SelectToken("ResourceSpecificationVersion").Value<string>()
        };

        if (string.IsNullOrWhiteSpace(specification.ResourceSpecificationVersion))
        {
            throw new InvalidOperationException("Error: ResourceSpecificationVersion");
        }

        foreach (var propType in parsed.SelectToken("PropertyTypes").Children<JProperty>())
        {
            var primitiveType = propType.Value.SelectToken("PrimitiveType");

            if (primitiveType != null)
            {
                var primitiveTypeValue = primitiveType.Value<string>();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"WARN::Property name: {propType.Name} is a primitive type: {primitiveTypeValue}");
                Console.ResetColor();
                continue;
            }

            var docs = propType.Value.SelectToken("Documentation");
            if (docs == null)
            {
                throw new InvalidOperationException($"Missing docs{propType.Name}");
            }

            var propertyType = new PropertyType
            {
                Name = propType.Name,
                Documentation = docs.ToString()
            };

            DecoratePropertyWithProperties(propType, propertyType);

            specification.PropertyTypes.Add(propertyType);
        }

        foreach (var resType in parsed.SelectToken("ResourceTypes").Children<JProperty>())
        {
            var resourceType = new ResourceType
            {
                Name = resType.Name,
                Documentation = resType.Value.SelectToken("Documentation").Value<string>(),
            };

            DecorateResourceWithProperties(resType, resourceType);
            DecorateResourceWithAttributes(resType, resourceType);

            specification.ResourceTypes.Add(resourceType);
        }

        foreach (var specificationResourceType in specification.ResourceTypes)
        {
            foreach (var interfaceIdentifier in _interfaceIdentifiers)
            {
                interfaceIdentifier.FindInterface(specificationResourceType);
            }
        }

        return specification;
    }

    private void DecoratePropertyWithProperties(JProperty propType, PropertyType propertyType)
    {
        var properties = propType.Value.SelectToken("Properties");

        if (properties == null)
        {
            return;
        }

        if (propertyType.Properties == null)
        {
            propertyType.Properties = [];
        }

        foreach (var prop in properties.Children<JProperty>())
        {
            var property = prop.ParseProperty();
            propertyType.Properties.Add(property);
        }
    }

    private void DecorateResourceWithProperties(JProperty resType, ResourceType resourceType)
    {
        var properties = resType.Value.SelectToken("Properties");
        resourceType.Properties = [];

        foreach (var prop in properties.Children<JProperty>())
        {
            var property = prop.ParseProperty();
            resourceType.Properties.Add(property);
        }
    }

    public void DecorateResourceWithAttributes(JProperty resType, ResourceType resourceType)
    {
        var attributes = resType.Value.SelectToken("Attributes");

        if (attributes == null)
        {
            return;
        }

        resourceType.Attributes = [];

        foreach (var attr in attributes.Children<JProperty>())
        {
            var attribute = attr.ParseAttribute();
            resourceType.Attributes.Add(attribute);
        }
    }
}