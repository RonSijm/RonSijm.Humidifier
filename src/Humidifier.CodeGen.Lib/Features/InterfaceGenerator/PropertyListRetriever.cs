using Humidifier.CodeGen.Lib.Features.JsonToModels.Models;

namespace Humidifier.CodeGen.Lib.Features.InterfaceGenerator
{
    public static class PropertyListRetriever
    {
        public static Dictionary<string, List<Property>> GetPropertyList(this Specification specification)
        {
            var propertyList = new Dictionary<string, List<Property>>();

            foreach (var resource in specification.ResourceTypes)
            {
                if (resource.Properties == null)
                {
                    continue;
                }

                foreach (var property in resource.Properties)
                {
                    var propertyName = $"{property.Name}{property.CsFullTypeName}";
                    var getList = propertyList.TryGetValue(propertyName, out var list);
                    if (!getList)
                    {
                        list = new List<Property>();
                        propertyList.Add(propertyName, new List<Property>());
                    }

                    list.Add(property);
                }
            }

            foreach (var resource in specification.PropertyTypes)
            {
                if (resource.Properties == null)
                {
                    continue;
                }

                foreach (var property in resource.Properties)
                {
                    var propertyName = $"{property.Name}{property.CsFullTypeName}";
                    var getList = propertyList.TryGetValue(propertyName, out var list);
                    if (!getList)
                    {
                        list = new List<Property>();
                        propertyList.Add(propertyName, new List<Property>());
                    }

                    list.Add(property);
                }
            }

            return propertyList;
        }
    }
}
