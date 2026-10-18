namespace Humidifier.Connect
{
    using global::System.Collections.Generic;
    using DataTableAttributeTypes;

    public class DataTableAttribute : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveConnectDataTableAttributeTypesValidationValidation, IHaveDescription, IHaveValueType, IHaveInstanceArn, IHavePrimary_Boolean, IHaveDataTableArn, IHaveName
    {
        public class Attributes
        {
            public static string LockVersion =  "LockVersion" ;
            public static string AttributeId =  "AttributeId" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string LastModifiedRegion =  "LastModifiedRegion" ;
        }

        public override string AWSTypeName { get => AWS.Connect.DataTableAttribute; }
        /// <summary>
        /// Validation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-datatableattribute.html#cfn-connect-datatableattribute-validation
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Validation
        /// </summary>
        public Union<Humidifier.Connect.DataTableAttributeTypes.Validation, BaseFunction>? Validation { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-datatableattribute.html#cfn-connect-datatableattribute-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// ValueType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-datatableattribute.html#cfn-connect-datatableattribute-valuetype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ValueType { get; set; }

        /// <summary>
        /// InstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-datatableattribute.html#cfn-connect-datatableattribute-instancearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? InstanceArn { get; set; }
        /// <summary>
        /// Primary
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-datatableattribute.html#cfn-connect-datatableattribute-primary
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? Primary { get; set; }

        /// <summary>
        /// DataTableArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-datatableattribute.html#cfn-connect-datatableattribute-datatablearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DataTableArn { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace DataTableAttributeTypes
    {
        public class Enum : Humidifier.Base.BaseSubResource, IHaveStrict_Boolean, IHaveStringListOfValues
        {
            /// <summary>
            /// Strict
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-datatableattribute-enum.html#cfn-connect-datatableattribute-enum-strict
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Strict { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-datatableattribute-enum.html#cfn-connect-datatableattribute-enum-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
        }

        public class LockVersion : Humidifier.Base.BaseSubResource, IHaveDataTable, IHaveAttribute
        {
            /// <summary>
            /// DataTable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-datatableattribute-lockversion.html#cfn-connect-datatableattribute-lockversion-datatable
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataTable { get; set; }
            /// <summary>
            /// Attribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-datatableattribute-lockversion.html#cfn-connect-datatableattribute-lockversion-attribute
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Attribute { get; set; }
        }

        public class Validation : Humidifier.Base.BaseSubResource, IHaveExclusiveMinimum_Double, IHaveConnectDataTableAttributeTypesEnumEnum, IHaveMinimum_Double, IHaveMaximum_Double, IHaveExclusiveMaximum_Double, IHaveMinLength_Integer, IHaveMaxValues_Integer, IHaveMaxLength_Integer, IHaveMinValues_Integer, IHaveMultipleOf_Double
        {
            /// <summary>
            /// ExclusiveMinimum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-datatableattribute-validation.html#cfn-connect-datatableattribute-validation-exclusiveminimum
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? ExclusiveMinimum { get; set; }
            /// <summary>
            /// Enum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-datatableattribute-validation.html#cfn-connect-datatableattribute-validation-enum
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Enum
            /// </summary>
            public Union<Humidifier.Connect.DataTableAttributeTypes.Enum, BaseFunction>? Enum { get; set; }
            /// <summary>
            /// Minimum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-datatableattribute-validation.html#cfn-connect-datatableattribute-validation-minimum
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Minimum { get; set; }
            /// <summary>
            /// Maximum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-datatableattribute-validation.html#cfn-connect-datatableattribute-validation-maximum
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Maximum { get; set; }
            /// <summary>
            /// ExclusiveMaximum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-datatableattribute-validation.html#cfn-connect-datatableattribute-validation-exclusivemaximum
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? ExclusiveMaximum { get; set; }
            /// <summary>
            /// MinLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-datatableattribute-validation.html#cfn-connect-datatableattribute-validation-minlength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinLength { get; set; }
            /// <summary>
            /// MaxValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-datatableattribute-validation.html#cfn-connect-datatableattribute-validation-maxvalues
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxValues { get; set; }
            /// <summary>
            /// MaxLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-datatableattribute-validation.html#cfn-connect-datatableattribute-validation-maxlength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxLength { get; set; }
            /// <summary>
            /// MinValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-datatableattribute-validation.html#cfn-connect-datatableattribute-validation-minvalues
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinValues { get; set; }
            /// <summary>
            /// MultipleOf
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-datatableattribute-validation.html#cfn-connect-datatableattribute-validation-multipleof
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MultipleOf { get; set; }
        }
    }
}