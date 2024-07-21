namespace Humidifier.Bedrock
{
    using System.Collections.Generic;
    using DataSourceTypes;

    public class DataSource : Humidifier.Resource, IHaveDescription
    {
        public class Attributes
        {
            public static string CreatedAt =  "CreatedAt" ;
            public static string DataSourceStatus =  "DataSourceStatus" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string FailureReasons =  "FailureReasons" ;
            public static string DataSourceId =  "DataSourceId" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::Bedrock::DataSource";
            }
        }

        /// <summary>
        /// DataDeletionPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-datasource.html#cfn-bedrock-datasource-datadeletionpolicy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DataDeletionPolicy { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-datasource.html#cfn-bedrock-datasource-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// KnowledgeBaseId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-datasource.html#cfn-bedrock-datasource-knowledgebaseid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KnowledgeBaseId { get; set; }
        /// <summary>
        /// ServerSideEncryptionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-datasource.html#cfn-bedrock-datasource-serversideencryptionconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ServerSideEncryptionConfiguration
        /// </summary>
        public ServerSideEncryptionConfiguration ServerSideEncryptionConfiguration { get; set; }
        /// <summary>
        /// VectorIngestionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-datasource.html#cfn-bedrock-datasource-vectoringestionconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: VectorIngestionConfiguration
        /// </summary>
        public VectorIngestionConfiguration VectorIngestionConfiguration { get; set; }
        /// <summary>
        /// DataSourceConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-datasource.html#cfn-bedrock-datasource-datasourceconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: DataSourceConfiguration
        /// </summary>
        public DataSourceConfiguration DataSourceConfiguration { get; set; }
        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-datasource.html#cfn-bedrock-datasource-name
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name { get; set; }
    }

    namespace DataSourceTypes
    {
        public class ChunkingConfiguration
        {
            /// <summary>
            /// ChunkingStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-chunkingconfiguration.html#cfn-bedrock-datasource-chunkingconfiguration-chunkingstrategy
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ChunkingStrategy { get; set; }
            /// <summary>
            /// FixedSizeChunkingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-chunkingconfiguration.html#cfn-bedrock-datasource-chunkingconfiguration-fixedsizechunkingconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: FixedSizeChunkingConfiguration
            /// </summary>
            public FixedSizeChunkingConfiguration FixedSizeChunkingConfiguration { get; set; }
        }

        public class DataSourceConfiguration
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-datasourceconfiguration.html#cfn-bedrock-datasource-datasourceconfiguration-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// S3Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-datasourceconfiguration.html#cfn-bedrock-datasource-datasourceconfiguration-s3configuration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: S3DataSourceConfiguration
            /// </summary>
            public S3DataSourceConfiguration S3Configuration { get; set; }
        }

        public class FixedSizeChunkingConfiguration
        {
            /// <summary>
            /// OverlapPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-fixedsizechunkingconfiguration.html#cfn-bedrock-datasource-fixedsizechunkingconfiguration-overlappercentage
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic OverlapPercentage { get; set; }
            /// <summary>
            /// MaxTokens
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-fixedsizechunkingconfiguration.html#cfn-bedrock-datasource-fixedsizechunkingconfiguration-maxtokens
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxTokens { get; set; }
        }

        public class S3DataSourceConfiguration
        {
            /// <summary>
            /// BucketArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-s3datasourceconfiguration.html#cfn-bedrock-datasource-s3datasourceconfiguration-bucketarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketArn { get; set; }
            /// <summary>
            /// BucketOwnerAccountId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-s3datasourceconfiguration.html#cfn-bedrock-datasource-s3datasourceconfiguration-bucketowneraccountid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketOwnerAccountId { get; set; }
            /// <summary>
            /// InclusionPrefixes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-s3datasourceconfiguration.html#cfn-bedrock-datasource-s3datasourceconfiguration-inclusionprefixes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic InclusionPrefixes { get; set; }
        }

        public class ServerSideEncryptionConfiguration
        {
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-serversideencryptionconfiguration.html#cfn-bedrock-datasource-serversideencryptionconfiguration-kmskeyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKeyArn { get; set; }
        }

        public class VectorIngestionConfiguration
        {
            /// <summary>
            /// ChunkingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-vectoringestionconfiguration.html#cfn-bedrock-datasource-vectoringestionconfiguration-chunkingconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ChunkingConfiguration
            /// </summary>
            public ChunkingConfiguration ChunkingConfiguration { get; set; }
        }
    }
}