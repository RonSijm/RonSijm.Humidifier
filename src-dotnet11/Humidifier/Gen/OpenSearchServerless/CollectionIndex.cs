namespace Humidifier.OpenSearchServerless
{
    using global::System.Collections.Generic;

    public class CollectionIndex : Humidifier.Base.BaseResource, IHaveIndexName, IHaveIndexSchema, IHaveId
    {
        public override string AWSTypeName { get => AWS.OpenSearchServerless.CollectionIndex; }

        /// <summary>
        /// IndexName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchserverless-collectionindex.html#cfn-opensearchserverless-collectionindex-indexname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? IndexName { get; set; }
        /// <summary>
        /// IndexSchema
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchserverless-collectionindex.html#cfn-opensearchserverless-collectionindex-indexschema
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? IndexSchema { get; set; }

        /// <summary>
        /// Id
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchserverless-collectionindex.html#cfn-opensearchserverless-collectionindex-id
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Id { get; set; }
    }
}