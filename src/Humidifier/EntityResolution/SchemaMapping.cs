namespace Humidifier.EntityResolution
{
    using System.Collections.Generic;
    using SchemaMappingTypes;

    public class SchemaMapping : Humidifier.Resource, IHaveTags, IHaveDescription
    {
        public class Attributes
        {
            public static string CreatedAt =  "CreatedAt" ;
            public static string HasWorkflows =  "HasWorkflows" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string SchemaArn =  "SchemaArn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::EntityResolution::SchemaMapping";
            }
        }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-entityresolution-schemamapping.html#cfn-entityresolution-schemamapping-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// MappedInputFields
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-entityresolution-schemamapping.html#cfn-entityresolution-schemamapping-mappedinputfields
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: SchemaInputAttribute
        /// </summary>
        public List<SchemaInputAttribute> MappedInputFields { get; set; }
        /// <summary>
        /// SchemaName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-entityresolution-schemamapping.html#cfn-entityresolution-schemamapping-schemaname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SchemaName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-entityresolution-schemamapping.html#cfn-entityresolution-schemamapping-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace SchemaMappingTypes
    {
        public class SchemaInputAttribute
        {
            /// <summary>
            /// GroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-schemamapping-schemainputattribute.html#cfn-entityresolution-schemamapping-schemainputattribute-groupname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GroupName { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-schemamapping-schemainputattribute.html#cfn-entityresolution-schemamapping-schemainputattribute-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// SubType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-schemamapping-schemainputattribute.html#cfn-entityresolution-schemamapping-schemainputattribute-subtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SubType { get; set; }
            /// <summary>
            /// Hashed
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-schemamapping-schemainputattribute.html#cfn-entityresolution-schemamapping-schemainputattribute-hashed
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Hashed { get; set; }
            /// <summary>
            /// MatchKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-schemamapping-schemainputattribute.html#cfn-entityresolution-schemamapping-schemainputattribute-matchkey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MatchKey { get; set; }
            /// <summary>
            /// FieldName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-entityresolution-schemamapping-schemainputattribute.html#cfn-entityresolution-schemamapping-schemainputattribute-fieldname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldName { get; set; }
        }
    }
}