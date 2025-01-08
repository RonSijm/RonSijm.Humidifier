namespace Humidifier.Glue
{
    using System.Collections.Generic;
    using SchemaVersionTypes;

    public class SchemaVersion : Humidifier.Base.BaseResource, IHaveSchemaDefinition
    {
        public class Attributes
        {
            public static string VersionId =  "VersionId" ;
        }

        public override string AWSTypeName { get => AWS.Glue.SchemaVersion; }

        /// <summary>
        /// SchemaDefinition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-schemaversion.html#cfn-glue-schemaversion-schemadefinition
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic SchemaDefinition { get; set; }

        /// <summary>
        /// Schema
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-schemaversion.html#cfn-glue-schemaversion-schema
        /// Required: True
        /// UpdateType: Immutable
        /// Type: Schema
        /// </summary>
        [Required]
        public Humidifier.Glue.SchemaVersionTypes.Schema Schema { get; set; }
    }

    namespace SchemaVersionTypes
    {
        public class Schema : Humidifier.Base.BaseSubResource, IHaveSchemaName, IHaveRegistryName, IHaveSchemaArn
        {
            /// <summary>
            /// RegistryName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-schemaversion-schema.html#cfn-glue-schemaversion-schema-registryname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RegistryName { get; set; }
            /// <summary>
            /// SchemaArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-schemaversion-schema.html#cfn-glue-schemaversion-schema-schemaarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SchemaArn { get; set; }
            /// <summary>
            /// SchemaName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-schemaversion-schema.html#cfn-glue-schemaversion-schema-schemaname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SchemaName { get; set; }
        }
    }
}