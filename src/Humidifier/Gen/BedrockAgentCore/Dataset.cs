namespace Humidifier.BedrockAgentCore
{
    using global::System.Collections.Generic;
    using DatasetTypes;

    public class Dataset : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveKmsKeyArn, IHaveDatasetName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string DatasetArn =  "DatasetArn" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string ExampleCount =  "ExampleCount" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string DatasetId =  "DatasetId" ;
        }

        public override string AWSTypeName { get => AWS.BedrockAgentCore.Dataset; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-dataset.html#cfn-bedrockagentcore-dataset-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// KmsKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-dataset.html#cfn-bedrockagentcore-dataset-kmskeyarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KmsKeyArn { get; set; }
        public dynamic DatasetName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// SchemaType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-dataset.html#cfn-bedrockagentcore-dataset-schematype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic SchemaType { get; set; }
        /// <summary>
        /// Source
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-dataset.html#cfn-bedrockagentcore-dataset-source
        /// Required: False
        /// UpdateType: Immutable
        /// Type: DataSourceType
        /// </summary>
        public Humidifier.BedrockAgentCore.DatasetTypes.DataSourceType Source { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-dataset.html#cfn-bedrockagentcore-dataset-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace DatasetTypes
    {
        public class DataSourceType : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// InlineExamples
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-dataset-datasourcetype.html#cfn-bedrockagentcore-dataset-datasourcetype-inlineexamples
            /// Required: False
            /// UpdateType: Immutable
            /// Type: InlineExamplesSource
            /// </summary>
            public Humidifier.BedrockAgentCore.DatasetTypes.InlineExamplesSource InlineExamples { get; set; }
            /// <summary>
            /// S3Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-dataset-datasourcetype.html#cfn-bedrockagentcore-dataset-datasourcetype-s3source
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3Source
            /// </summary>
            public Humidifier.BedrockAgentCore.DatasetTypes.S3Source S3Source { get; set; }
        }

        public class InlineExamplesSource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Examples
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-dataset-inlineexamplessource.html#cfn-bedrockagentcore-dataset-inlineexamplessource-examples
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: Json
            /// </summary>
            public List<dynamic> Examples { get; set; }
        }

        public class S3Source : Humidifier.Base.BaseSubResource, IHaveS3Uri
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-dataset-s3source.html#cfn-bedrockagentcore-dataset-s3source-s3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3Uri { get; set; }
        }
    }
}