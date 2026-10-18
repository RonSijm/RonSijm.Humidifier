namespace Humidifier.EntityResolution
{
    using global::System.Collections.Generic;
    using SchemaMappingTypes;

    public class SchemaMapping : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveListOfEntityResolutionSchemaMappingTypesSchemaInputAttributeMappedInputFields, IHaveSchemaName
    {
        public class Attributes
        {
            public static string CreatedAt =  "CreatedAt" ;
            public static string HasWorkflows =  "HasWorkflows" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string SchemaArn =  "SchemaArn" ;
        }

        public override string AWSTypeName { get => AWS.EntityResolution.SchemaMapping; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-entityresolution-schemamapping.html#cfn-entityresolution-schemamapping-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// MappedInputFields
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-entityresolution-schemamapping.html#cfn-entityresolution-schemamapping-mappedinputfields
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: SchemaInputAttribute
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.EntityResolution.SchemaMappingTypes.SchemaInputAttribute>, IReadOnlyList<Union<Humidifier.EntityResolution.SchemaMappingTypes.SchemaInputAttribute, BaseFunction>>, BaseFunction>? MappedInputFields { get; set; }

        /// <summary>
        /// SchemaName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-entityresolution-schemamapping.html#cfn-entityresolution-schemamapping-schemaname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SchemaName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-entityresolution-schemamapping.html#cfn-entityresolution-schemamapping-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace SchemaMappingTypes
    {
        public class SchemaInputAttribute : Humidifier.Base.BaseSubResource, IHaveGroupName, IHaveType, IHaveSubType, IHaveHashed_Boolean, IHaveMatchKey, IHaveFieldName
        {
            /// <summary>
            /// GroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-schemamapping-schemainputattribute.html#cfn-entityresolution-schemamapping-schemainputattribute-groupname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GroupName { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-schemamapping-schemainputattribute.html#cfn-entityresolution-schemamapping-schemainputattribute-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// SubType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-schemamapping-schemainputattribute.html#cfn-entityresolution-schemamapping-schemainputattribute-subtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SubType { get; set; }
            /// <summary>
            /// Hashed
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-schemamapping-schemainputattribute.html#cfn-entityresolution-schemamapping-schemainputattribute-hashed
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Hashed { get; set; }
            /// <summary>
            /// MatchKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-schemamapping-schemainputattribute.html#cfn-entityresolution-schemamapping-schemainputattribute-matchkey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MatchKey { get; set; }
            /// <summary>
            /// FieldName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-schemamapping-schemainputattribute.html#cfn-entityresolution-schemamapping-schemainputattribute-fieldname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FieldName { get; set; }
        }
    }
}