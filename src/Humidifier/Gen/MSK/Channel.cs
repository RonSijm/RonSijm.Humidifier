namespace Humidifier.MSK
{
    using global::System.Collections.Generic;
    using ChannelTypes;

    public class Channel : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveChannelName, IHaveClusterArn
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string ChannelArn =  "ChannelArn" ;
            public static string StateInfo =  "StateInfo" ;
        }

        public override string AWSTypeName { get => AWS.MSK.Channel; }
        /// <summary>
        /// ClusterArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-channel.html#cfn-msk-channel-clusterarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ClusterArn { get; set; }
        public dynamic ChannelName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// EncryptionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-channel.html#cfn-msk-channel-encryptionconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: EncryptionConfiguration
        /// </summary>
        public Humidifier.MSK.ChannelTypes.EncryptionConfiguration EncryptionConfiguration { get; set; }
        /// <summary>
        /// IcebergDestinationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-channel.html#cfn-msk-channel-icebergdestinationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: IcebergDestinationConfiguration
        /// </summary>
        public Humidifier.MSK.ChannelTypes.IcebergDestinationConfiguration IcebergDestinationConfiguration { get; set; }
        /// <summary>
        /// S3DestinationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-channel.html#cfn-msk-channel-s3destinationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: S3DestinationConfiguration
        /// </summary>
        public Humidifier.MSK.ChannelTypes.S3DestinationConfiguration S3DestinationConfiguration { get; set; }
        /// <summary>
        /// LoggingInfo
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-channel.html#cfn-msk-channel-logginginfo
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ChannelLoggingInfo
        /// </summary>
        public Humidifier.MSK.ChannelTypes.ChannelLoggingInfo LoggingInfo { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-channel.html#cfn-msk-channel-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Tags { get; set; }

        /// <summary>
        /// TopicConfigurationList
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-channel.html#cfn-msk-channel-topicconfigurationlist
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: TopicConfiguration
        /// </summary>
        [Required]
        public List<Humidifier.MSK.ChannelTypes.TopicConfiguration> TopicConfigurationList { get; set; }
    }

    namespace ChannelTypes
    {
        public class Catalog : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CatalogArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-catalog.html#cfn-msk-channel-catalog-catalogarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CatalogArn { get; set; }
            /// <summary>
            /// WarehouseLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-catalog.html#cfn-msk-channel-catalog-warehouselocation
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WarehouseLocation { get; set; }
        }

        public class ChannelLoggingInfo : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-channellogginginfo.html#cfn-msk-channel-channellogginginfo-s3
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3LogDestination
            /// </summary>
            public Humidifier.MSK.ChannelTypes.S3LogDestination S3 { get; set; }
            /// <summary>
            /// Firehose
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-channellogginginfo.html#cfn-msk-channel-channellogginginfo-firehose
            /// Required: False
            /// UpdateType: Immutable
            /// Type: FirehoseLogDestination
            /// </summary>
            public Humidifier.MSK.ChannelTypes.FirehoseLogDestination Firehose { get; set; }
            /// <summary>
            /// CloudWatchLogs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-channellogginginfo.html#cfn-msk-channel-channellogginginfo-cloudwatchlogs
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CloudWatchLogsLogDestination
            /// </summary>
            public Humidifier.MSK.ChannelTypes.CloudWatchLogsLogDestination CloudWatchLogs { get; set; }
        }

        public class ChannelStateInfo : Humidifier.Base.BaseSubResource, IHaveMessage, IHaveCode
        {
            /// <summary>
            /// Message
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-channelstateinfo.html#cfn-msk-channel-channelstateinfo-message
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Message { get; set; }
            /// <summary>
            /// Code
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-channelstateinfo.html#cfn-msk-channel-channelstateinfo-code
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Code { get; set; }
        }

        public class CloudWatchLogsLogDestination : Humidifier.Base.BaseSubResource, IHaveEnabled, IHaveLogGroup
        {
            /// <summary>
            /// LogGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-cloudwatchlogslogdestination.html#cfn-msk-channel-cloudwatchlogslogdestination-loggroup
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogGroup { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-cloudwatchlogslogdestination.html#cfn-msk-channel-cloudwatchlogslogdestination-enabled
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
        }

        public class DeadLetterQueueS3 : Humidifier.Base.BaseSubResource, IHaveBucketArn, IHaveExpectedBucketOwner, IHaveErrorOutputPrefix
        {
            /// <summary>
            /// ErrorOutputPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-deadletterqueues3.html#cfn-msk-channel-deadletterqueues3-erroroutputprefix
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ErrorOutputPrefix { get; set; }
            /// <summary>
            /// BucketArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-deadletterqueues3.html#cfn-msk-channel-deadletterqueues3-bucketarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketArn { get; set; }
            /// <summary>
            /// ExpectedBucketOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-deadletterqueues3.html#cfn-msk-channel-deadletterqueues3-expectedbucketowner
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExpectedBucketOwner { get; set; }
        }

        public class DestinationTable : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DestinationDatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-destinationtable.html#cfn-msk-channel-destinationtable-destinationdatabasename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DestinationDatabaseName { get; set; }
            /// <summary>
            /// DestinationTableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-destinationtable.html#cfn-msk-channel-destinationtable-destinationtablename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DestinationTableName { get; set; }
            /// <summary>
            /// PartitionSpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-destinationtable.html#cfn-msk-channel-destinationtable-partitionspec
            /// Required: False
            /// UpdateType: Immutable
            /// Type: PartitionSpec
            /// </summary>
            public Humidifier.MSK.ChannelTypes.PartitionSpec PartitionSpec { get; set; }
        }

        public class EncryptionConfiguration : Humidifier.Base.BaseSubResource, IHaveKmsKeyArn
        {
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-encryptionconfiguration.html#cfn-msk-channel-encryptionconfiguration-kmskeyarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKeyArn { get; set; }
        }

        public class FirehoseLogDestination : Humidifier.Base.BaseSubResource, IHaveEnabled, IHaveDeliveryStream
        {
            /// <summary>
            /// DeliveryStream
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-firehoselogdestination.html#cfn-msk-channel-firehoselogdestination-deliverystream
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DeliveryStream { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-firehoselogdestination.html#cfn-msk-channel-firehoselogdestination-enabled
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
        }

        public class IcebergDestinationConfiguration : Humidifier.Base.BaseSubResource, IHaveCompressionType, IHaveServiceExecutionRoleArn
        {
            /// <summary>
            /// DeadLetterQueueS3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-icebergdestinationconfiguration.html#cfn-msk-channel-icebergdestinationconfiguration-deadletterqueues3
            /// Required: True
            /// UpdateType: Immutable
            /// Type: DeadLetterQueueS3
            /// </summary>
            public Humidifier.MSK.ChannelTypes.DeadLetterQueueS3 DeadLetterQueueS3 { get; set; }
            /// <summary>
            /// ServiceExecutionRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-icebergdestinationconfiguration.html#cfn-msk-channel-icebergdestinationconfiguration-serviceexecutionrolearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ServiceExecutionRoleArn { get; set; }
            /// <summary>
            /// DataFreshnessInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-icebergdestinationconfiguration.html#cfn-msk-channel-icebergdestinationconfiguration-datafreshnessinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DataFreshnessInSeconds { get; set; }
            /// <summary>
            /// DestinationTableList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-icebergdestinationconfiguration.html#cfn-msk-channel-icebergdestinationconfiguration-destinationtablelist
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: DestinationTable
            /// </summary>
            public List<Humidifier.MSK.ChannelTypes.DestinationTable> DestinationTableList { get; set; }
            /// <summary>
            /// SchemaEvolution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-icebergdestinationconfiguration.html#cfn-msk-channel-icebergdestinationconfiguration-schemaevolution
            /// Required: True
            /// UpdateType: Immutable
            /// Type: SchemaEvolution
            /// </summary>
            public Humidifier.MSK.ChannelTypes.SchemaEvolution SchemaEvolution { get; set; }
            /// <summary>
            /// TableCreation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-icebergdestinationconfiguration.html#cfn-msk-channel-icebergdestinationconfiguration-tablecreation
            /// Required: True
            /// UpdateType: Immutable
            /// Type: TableCreation
            /// </summary>
            public Humidifier.MSK.ChannelTypes.TableCreation TableCreation { get; set; }
            /// <summary>
            /// AppendOnly
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-icebergdestinationconfiguration.html#cfn-msk-channel-icebergdestinationconfiguration-appendonly
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AppendOnly { get; set; }
            /// <summary>
            /// CompressionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-icebergdestinationconfiguration.html#cfn-msk-channel-icebergdestinationconfiguration-compressiontype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CompressionType { get; set; }
            /// <summary>
            /// Catalog
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-icebergdestinationconfiguration.html#cfn-msk-channel-icebergdestinationconfiguration-catalog
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Catalog
            /// </summary>
            public Humidifier.MSK.ChannelTypes.Catalog Catalog { get; set; }
        }

        public class PartitionSource : Humidifier.Base.BaseSubResource, IHaveSourceName
        {
            /// <summary>
            /// SourceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-partitionsource.html#cfn-msk-channel-partitionsource-sourcename
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceName { get; set; }
        }

        public class PartitionSpec : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SourceList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-partitionspec.html#cfn-msk-channel-partitionspec-sourcelist
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: PartitionSource
            /// </summary>
            public List<Humidifier.MSK.ChannelTypes.PartitionSource> SourceList { get; set; }
            /// <summary>
            /// PartitionStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-partitionspec.html#cfn-msk-channel-partitionspec-partitionstrategy
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PartitionStrategy { get; set; }
        }

        public class RecordConverter : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ValueConverter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-recordconverter.html#cfn-msk-channel-recordconverter-valueconverter
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ValueConverter { get; set; }
        }

        public class RecordSchema : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// GsrArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-recordschema.html#cfn-msk-channel-recordschema-gsrarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GsrArn { get; set; }
        }

        public class S3DestinationConfiguration : Humidifier.Base.BaseSubResource, IHaveServiceExecutionRoleArn
        {
            /// <summary>
            /// Storage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-s3destinationconfiguration.html#cfn-msk-channel-s3destinationconfiguration-storage
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3Storage
            /// </summary>
            public Humidifier.MSK.ChannelTypes.S3Storage Storage { get; set; }
            /// <summary>
            /// DeadLetterQueueS3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-s3destinationconfiguration.html#cfn-msk-channel-s3destinationconfiguration-deadletterqueues3
            /// Required: True
            /// UpdateType: Immutable
            /// Type: DeadLetterQueueS3
            /// </summary>
            public Humidifier.MSK.ChannelTypes.DeadLetterQueueS3 DeadLetterQueueS3 { get; set; }
            /// <summary>
            /// DataFreshnessInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-s3destinationconfiguration.html#cfn-msk-channel-s3destinationconfiguration-datafreshnessinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DataFreshnessInSeconds { get; set; }
            /// <summary>
            /// ServiceExecutionRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-s3destinationconfiguration.html#cfn-msk-channel-s3destinationconfiguration-serviceexecutionrolearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ServiceExecutionRoleArn { get; set; }
        }

        public class S3LogDestination : Humidifier.Base.BaseSubResource, IHaveEnabled, IHavePrefix, IHaveBucket
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-s3logdestination.html#cfn-msk-channel-s3logdestination-bucket
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Bucket { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-s3logdestination.html#cfn-msk-channel-s3logdestination-enabled
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-s3logdestination.html#cfn-msk-channel-s3logdestination-prefix
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix { get; set; }
        }

        public class S3Storage : Humidifier.Base.BaseSubResource, IHaveBucketArn, IHaveCompressionType, IHaveStorageClass, IHaveExpectedBucketOwner
        {
            /// <summary>
            /// BucketArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-s3storage.html#cfn-msk-channel-s3storage-bucketarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketArn { get; set; }
            /// <summary>
            /// OutputPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-s3storage.html#cfn-msk-channel-s3storage-outputprefix
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OutputPrefix { get; set; }
            /// <summary>
            /// StorageClass
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-s3storage.html#cfn-msk-channel-s3storage-storageclass
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StorageClass { get; set; }
            /// <summary>
            /// OutputKeyTemplate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-s3storage.html#cfn-msk-channel-s3storage-outputkeytemplate
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OutputKeyTemplate { get; set; }
            /// <summary>
            /// CompressionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-s3storage.html#cfn-msk-channel-s3storage-compressiontype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CompressionType { get; set; }
            /// <summary>
            /// ExpectedBucketOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-s3storage.html#cfn-msk-channel-s3storage-expectedbucketowner
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExpectedBucketOwner { get; set; }
        }

        public class SchemaEvolution : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EnableSchemaEvolution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-schemaevolution.html#cfn-msk-channel-schemaevolution-enableschemaevolution
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EnableSchemaEvolution { get; set; }
        }

        public class TableCreation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EnableTableCreation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-tablecreation.html#cfn-msk-channel-tablecreation-enabletablecreation
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EnableTableCreation { get; set; }
        }

        public class TopicConfiguration : Humidifier.Base.BaseSubResource, IHaveTopicArn
        {
            /// <summary>
            /// RecordConverter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-topicconfiguration.html#cfn-msk-channel-topicconfiguration-recordconverter
            /// Required: True
            /// UpdateType: Immutable
            /// Type: RecordConverter
            /// </summary>
            public Humidifier.MSK.ChannelTypes.RecordConverter RecordConverter { get; set; }
            /// <summary>
            /// TopicArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-topicconfiguration.html#cfn-msk-channel-topicconfiguration-topicarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TopicArn { get; set; }
            /// <summary>
            /// RecordSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-topicconfiguration.html#cfn-msk-channel-topicconfiguration-recordschema
            /// Required: False
            /// UpdateType: Immutable
            /// Type: RecordSchema
            /// </summary>
            public Humidifier.MSK.ChannelTypes.RecordSchema RecordSchema { get; set; }
        }
    }
}