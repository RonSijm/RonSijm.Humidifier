namespace Humidifier.Glue
{
    using global::System.Collections.Generic;

    public class SchemaVersionMetadata : Humidifier.Base.BaseResource, IHaveSchemaVersionId, IHaveValue, IHaveKey
    {
        public override string AWSTypeName { get => AWS.Glue.SchemaVersionMetadata; }

        /// <summary>
        /// SchemaVersionId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-schemaversionmetadata.html#cfn-glue-schemaversionmetadata-schemaversionid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SchemaVersionId { get; set; }

        /// <summary>
        /// Value
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-schemaversionmetadata.html#cfn-glue-schemaversionmetadata-value
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Value { get; set; }

        /// <summary>
        /// Key
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-schemaversionmetadata.html#cfn-glue-schemaversionmetadata-key
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Key { get; set; }
    }
}