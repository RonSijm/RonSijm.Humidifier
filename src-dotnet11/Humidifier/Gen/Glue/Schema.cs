namespace Humidifier.Glue
{
    using global::System.Collections.Generic;
    using SchemaTypes;

    public class Schema : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveSchemaDefinition, IHaveDescription, IHaveDataFormat, IHaveGlueSchemaTypesRegistryRegistry, IHaveCompatibility, IHaveName, IHaveGlueSchemaTypesSchemaVersionCheckpointVersion
    {
        public class Attributes
        {
            public static string InitialSchemaVersionId =  "InitialSchemaVersionId" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Glue.Schema; }
        /// <summary>
        /// SchemaDefinition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-schema.html#cfn-glue-schema-schemadefinition
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SchemaDefinition { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-schema.html#cfn-glue-schema-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// DataFormat
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-schema.html#cfn-glue-schema-dataformat
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DataFormat { get; set; }
        /// <summary>
        /// Registry
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-schema.html#cfn-glue-schema-registry
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Registry
        /// </summary>
        public Union<Humidifier.Glue.SchemaTypes.Registry, BaseFunction>? Registry { get; set; }

        /// <summary>
        /// Compatibility
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-schema.html#cfn-glue-schema-compatibility
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Compatibility { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-schema.html#cfn-glue-schema-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// CheckpointVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-schema.html#cfn-glue-schema-checkpointversion
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SchemaVersion
        /// </summary>
        public Union<Humidifier.Glue.SchemaTypes.SchemaVersion, BaseFunction>? CheckpointVersion { get; set; }
    }

    namespace SchemaTypes
    {
        public class Registry : Humidifier.Base.BaseSubResource, IHaveArn, IHaveName
        {
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-schema-registry.html#cfn-glue-schema-registry-arn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-schema-registry.html#cfn-glue-schema-registry-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class SchemaVersion : Humidifier.Base.BaseSubResource, IHaveIsLatest_Boolean, IHaveVersionNumber_Integer
        {
            /// <summary>
            /// IsLatest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-schema-schemaversion.html#cfn-glue-schema-schemaversion-islatest
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsLatest { get; set; }
            /// <summary>
            /// VersionNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-schema-schemaversion.html#cfn-glue-schema-schemaversion-versionnumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? VersionNumber { get; set; }
        }
    }
}