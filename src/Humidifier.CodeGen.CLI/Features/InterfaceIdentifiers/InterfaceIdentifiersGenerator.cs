#if !WithoutReferences
using System.Runtime.CompilerServices;
namespace Humidifier.CodeGen.CLI.Features.InterfaceIdentifiers;

public static class InterfaceIdentifiersGenerator
{
    public static void Generate()
    {
        var customInterfaces = typeof(Interfaces.IHaveDescription).Assembly.GetTypes().Where(x => x.IsInterface && x != typeof(Interfaces.IResourceInterface) && typeof(Interfaces.IResourceInterface).IsAssignableFrom(x)).ToList();

        var bob = new StringBuilder();
        bob.AppendLine("namespace Humidifier.CodeGen.Lib.Features.JsonToModels.InterfaceIdentifiers;");
        bob.AppendLine();

        foreach (var customInterface in customInterfaces)
        {
            var propertyInfo = customInterface.GetProperties().First();
            var isDynamic = propertyInfo.PropertyType.Name == "Object" && propertyInfo.CustomAttributes.Any(x => x.AttributeType == typeof(DynamicAttribute));

            if (isDynamic)
            {
                bob.AppendLine($"public class Have{customInterface.Name}InterfaceIdentifier() : BaseSingleDynamicPropertySingleInterfaceIdentifier(\"{propertyInfo.Name}\", \"{customInterface.Name}\");");
            }
            else
            {
                if (propertyInfo.PropertyType.Name == "List`1")
                {
                    var itemType = propertyInfo.PropertyType.GetGenericArguments().First();

                    var itemName = itemType.FullName;
                    if (itemName == "Humidifier.Tag")
                    {
                        itemName = "Tag";
                    }

                    bob.AppendLine($"public class Have{customInterface.Name}InterfaceIdentifier() : BaseSingleListPropertySingleInterfaceIdentifier(\"{propertyInfo.Name}\", \"{itemName}\", \"{customInterface.Name}\");");
                }
                else if (propertyInfo.PropertyType.Name == "Dictionary`2")
                {

                }
                else
                {
                    bob.AppendLine($"public class  Have{customInterface.Name}InterfaceIdentifier() : BaseTypePropertySingleInterfaceIdentifier(\"{propertyInfo.Name}\", \"{propertyInfo.PropertyType.FullName}\", \"{customInterface.Name}\");");
                }

            }
        }

        var result = bob.ToString();

        // TODO: This will fail when properties are removed, but the InterfaceIdentifier is not
        //File.WriteAllText("D:\\RonSijm\\RonSijm.Humidifier\\src\\Humidifier.CodeGen.Lib\\Features\\JsonToModels\\InterfaceIdentifiers\\InterfaceIdentifiers.cs", result);
    }
}
#endif