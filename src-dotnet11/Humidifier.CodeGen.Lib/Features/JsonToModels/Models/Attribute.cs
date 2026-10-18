namespace Humidifier.CodeGen.Lib.Features.JsonToModels.Models;

/// <summary>
///     http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/cfn-resource-specification-format.html#cfn-resource-specification-format-resourcetype
/// </summary>
public class Attribute
{
    public string Name { get; set; }

    /// <summary>
    ///     A link to the AWS CloudFormation User Guide that provides information about the property.
    /// </summary>
    public string Documentation { get; set; }

    /// <summary>
    ///     If the value of the Type field is List, indicates the type of list that the Fn::GetAtt function returns for the
    ///     attribute if the list contains non-primitive types. The valid type is a name of a property.
    /// </summary>
    public string ItemType { get; set; }

    /// <summary>
    ///     For primitive return values, the type of primitive value that the Fn::GetAtt function returns for the attribute.
    ///     A primitive type is a basic data type for resource property values. The valid primitive types are String, Long,
    ///     Integer, Double, Boolean, Timestamp or Json.
    /// </summary>
    public string PrimitiveType { get; set; }

    /// <summary>
    ///     If the value of the Type field is List, indicates the type of list that the Fn::GetAtt function returns for the
    ///     attribute if the list contains primitive types.
    ///     For lists that contain non-primitive types, the ItemType property indicates the valid value type. The valid
    ///     primitive types for lists are String, Long, Integer, Double, Boolean, or Timestamp.
    ///     For example, if the type value is List and the primitive item type value is String, the Fn::GetAtt function returns
    ///     a list of strings.
    /// </summary>
    public string PrimitiveItemType { get; set; }

    /// <summary>
    ///     For non-primitive return values, the type of value that the Fn::GetAtt function returns for the attribute. The
    ///     valid types are a property name or List.
    ///     A list is a comma-separated list of values. The value type for lists are indicated by the ItemType or
    ///     PrimitiveItemType field.
    /// </summary>
    public string Type { get; set; }
}