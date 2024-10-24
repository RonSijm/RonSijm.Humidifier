﻿namespace Humidifier.CodeGen.Lib.Features.JsonToModels.Models;

/// <summary>
///     http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/cfn-resource-specification-format.html#cfn-resource-specification-format-propertytypes
/// </summary>
[DebuggerDisplay("{Name} - {Type} - {PrimitiveType} - {PrimitiveItemType}")]
public class Property
{
    public string Name { get; set; }

    /// <summary>
    ///     A link to the AWS CloudFormation User Guide that provides information about the property.
    /// </summary>
    public string Documentation { get; set; }

    /// <summary>
    ///     Indicates whether the property is required.
    /// </summary>
    public bool Required { get; set; }

    /// <summary>
    ///     During a stack update, the update behavior when you add, remove, or modify the property.  AWS CloudFormation
    ///     replaces the
    ///     resource when you change Immutable properties. AWS CloudFormation doesn't replace the resource when you change
    ///     mutable properties.
    ///     Conditional updates can be mutable or immutable, depending on, for example, which other properties you updated.
    /// </summary>
    public string UpdateType { get; set; }

    /// <summary>
    ///     For primitive values, the valid primitive type for the property. A primitive type is a basic data type for resource
    ///     property values.
    ///     The valid primitive types are String, Long, Integer, Double, Boolean, Timestamp or Json.
    ///     If valid values are a non-primitive type, this field is omitted and the Type field indicates the valid value type.
    /// </summary>
    public string PrimitiveType { get; set; }

    /// <summary>
    ///     If the value of the Type field is List or Map, indicates the type of list or map if they contain primitive types.
    ///     Otherwise, this field is omitted. For lists or maps that contain non-primitive types, the ItemType property
    ///     indicates
    ///     the valid value type.
    ///     The valid primitive types for lists and maps are String, Long, Integer, Double, Boolean, or Timestamp.
    ///     For example, if the type value is List and the item type value is String, you can specify a list of strings for the
    ///     property. If the type value is Map and the item type value is Boolean, you can specify a string to Boolean mapping
    ///     for the property.
    /// </summary>
    public string PrimitiveItemType { get; set; }

    /// <summary>
    ///     For non-primitive types, valid values for the property. The valid types are a subproperty name, List or Map.
    ///     If valid values are a primitive type, this field is omitted and the PrimitiveType field indicates the valid value
    ///     type.
    ///     A list is a comma-separated list of values. A map is a set of key-value pairs, where the keys are always strings.
    ///     The value type for lists and maps are indicated by the ItemType or PrimitiveItemType field.
    /// </summary>
    public string Type { get; set; }

    /// <summary>
    ///     If the value of the Type field is List or Map, indicates the type of list or map if they contain non-primitive
    ///     types.
    ///     Otherwise, this field is omitted. For lists or maps that contain primitive types, the PrimitiveItemType property
    ///     indicates
    ///     the valid value type. A subproperty name is a valid item type.For example, if the type value is List and the item
    ///     type
    ///     value is PortMapping, you can specify a list of port mapping properties.
    /// </summary>
    public string ItemType { get; set; }

    /// <summary>
    ///     If the value of the Type field is List, indicates whether AWS CloudFormation allows duplicate values.
    ///     If the value is true, AWS CloudFormation ignores duplicate values.
    ///     If the value is false, AWS CloudFormation returns an error if you submit duplicate values.
    /// </summary>
    public bool? DuplicatesAllowed { get; set; }

    public string CsFullTypeName { get; set; }
    public string NameSpace { get; set; }
    public string ParentName { get; set; }
    public bool IsSystemType { get; set; }
}