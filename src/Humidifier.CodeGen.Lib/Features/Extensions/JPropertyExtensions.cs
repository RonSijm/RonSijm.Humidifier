using Humidifier.CodeGen.Lib.Features.JsonToModels.Models;
using Attribute = Humidifier.CodeGen.Lib.Features.JsonToModels.Models.Attribute;

namespace Humidifier.CodeGen.Lib.Features.Extensions;

public static class JPropertyExtensions
{
    public static Attribute ParseAttribute(this JProperty attr)
    {
        var attribute = new Attribute
        {
            Name = attr.Name,
            ItemType = attr.Value.SelectToken("ItemType")?.Value<string>(),
            PrimitiveItemType = attr.Value.SelectToken("PrimitiveItemType")?.Value<string>(),
            PrimitiveType = attr.Value.SelectToken("PrimitiveType")?.Value<string>(),
            Type = attr.Value.SelectToken("Type")?.Value<string>()
        };

        return attribute;
    }

    public static Property ParseProperty(this JProperty prop)
    {
        var property = new Property
        {
            Name = prop.Name,
            Documentation = prop.Value.SelectToken("Documentation").Value<string>(),
            Required = prop.Value.SelectToken("Required").Value<bool>(),
            UpdateType = prop.Value.SelectToken("UpdateType").Value<string>(),
            PrimitiveType = prop.Value.SelectToken("PrimitiveType")?.Value<string>(),
            PrimitiveItemType = prop.Value.SelectToken("PrimitiveItemType")?.Value<string>(),
            Type = prop.Value.SelectToken("Type")?.Value<string>(),
            ItemType = prop.Value.SelectToken("ItemType")?.Value<string>(),
            DuplicatesAllowed = prop.Value.SelectToken("DuplicatesAllowed")?.Value<bool>()
        };

        // Hack, CapacityReservationPreference has no properties
        if (string.Equals(property.Name, "CapacityReservationPreference"))
        {
            property.Type = "dynamic";
        }
        else if (property.PrimitiveType == null)
        {
            Debug.Assert(property.Type != null);
        }
        else
        {
            Debug.Assert(property.Type == null);
        }

        if (property.PrimitiveItemType != null)
        {
            Debug.Assert(property.Type != null);
            Debug.Assert(property.Type == "List" || property.Type == "Map");
        }

        return property;
    }
}