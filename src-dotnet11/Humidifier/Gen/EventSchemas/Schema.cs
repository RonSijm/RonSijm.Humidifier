namespace Humidifier.EventSchemas
{
    using global::System.Collections.Generic;
    using SchemaTypes;

    public class Schema : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveType, IHaveDescription, IHaveContent, IHaveRegistryName, IHaveSchemaName, IHaveListOfEventSchemasSchemaTypesTagsEntryTags
    {
        public class Attributes
        {
            public static string LastModified =  "LastModified" ;
            public static string SchemaVersion =  "SchemaVersion" ;
            public static string VersionCreatedDate =  "VersionCreatedDate" ;
            public static string SchemaArn =  "SchemaArn" ;
            public static string SchemaName =  "SchemaName" ;
        }

        public override string AWSTypeName { get => AWS.EventSchemas.Schema; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventschemas-schema.html#cfn-eventschemas-schema-type
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Type { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventschemas-schema.html#cfn-eventschemas-schema-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// Content
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventschemas-schema.html#cfn-eventschemas-schema-content
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Content { get; set; }

        /// <summary>
        /// RegistryName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventschemas-schema.html#cfn-eventschemas-schema-registryname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RegistryName { get; set; }
        public Union<string, BaseFunction>? SchemaName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventschemas-schema.html#cfn-eventschemas-schema-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TagsEntry
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EventSchemas.SchemaTypes.TagsEntry>, IReadOnlyList<Union<Humidifier.EventSchemas.SchemaTypes.TagsEntry, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace SchemaTypes
    {
        public class TagsEntry : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventschemas-schema-tagsentry.html#cfn-eventschemas-schema-tagsentry-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventschemas-schema-tagsentry.html#cfn-eventschemas-schema-tagsentry-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}