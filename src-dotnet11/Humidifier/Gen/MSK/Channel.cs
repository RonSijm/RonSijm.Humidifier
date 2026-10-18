namespace Humidifier.MSK
{
    using global::System.Collections.Generic;
    using ChannelTypes;

    public class Channel : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveClusterArn, IHaveChannelName, IHaveMSKChannelTypesEncryptionConfigurationEncryptionConfiguration, IHaveMSKChannelTypesIcebergDestinationConfigurationIcebergDestinationConfiguration, IHaveMSKChannelTypesS3DestinationConfigurationS3DestinationConfiguration, IHaveMSKChannelTypesChannelLoggingInfoLoggingInfo, IHaveStringDictionaryOfTags, IHaveListOfMSKChannelTypesTopicConfigurationTopicConfigurationList
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
        public Union<string, BaseFunction>? ClusterArn { get; set; }
        public Union<string, BaseFunction>? ChannelName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// EncryptionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-channel.html#cfn-msk-channel-encryptionconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: EncryptionConfiguration
        /// </summary>
        public Union<Humidifier.MSK.ChannelTypes.EncryptionConfiguration, BaseFunction>? EncryptionConfiguration { get; set; }
        /// <summary>
        /// IcebergDestinationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-channel.html#cfn-msk-channel-icebergdestinationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: IcebergDestinationConfiguration
        /// </summary>
        public Union<Humidifier.MSK.ChannelTypes.IcebergDestinationConfiguration, BaseFunction>? IcebergDestinationConfiguration { get; set; }
        /// <summary>
        /// S3DestinationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-channel.html#cfn-msk-channel-s3destinationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: S3DestinationConfiguration
        /// </summary>
        public Union<Humidifier.MSK.ChannelTypes.S3DestinationConfiguration, BaseFunction>? S3DestinationConfiguration { get; set; }
        /// <summary>
        /// LoggingInfo
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-channel.html#cfn-msk-channel-logginginfo
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ChannelLoggingInfo
        /// </summary>
        public Union<Humidifier.MSK.ChannelTypes.ChannelLoggingInfo, BaseFunction>? LoggingInfo { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-channel.html#cfn-msk-channel-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// TopicConfigurationList
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-channel.html#cfn-msk-channel-topicconfigurationlist
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: TopicConfiguration
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.MSK.ChannelTypes.TopicConfiguration>, IReadOnlyList<Union<Humidifier.MSK.ChannelTypes.TopicConfiguration, BaseFunction>>, BaseFunction>? TopicConfigurationList { get; set; }
    }

    namespace ChannelTypes
    {
        public class Catalog : Humidifier.Base.BaseSubResource, IHaveCatalogArn, IHaveWarehouseLocation
        {
            /// <summary>
            /// CatalogArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-catalog.html#cfn-msk-channel-catalog-catalogarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CatalogArn { get; set; }
            /// <summary>
            /// WarehouseLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-catalog.html#cfn-msk-channel-catalog-warehouselocation
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WarehouseLocation { get; set; }
        }

        public class ChannelLoggingInfo : Humidifier.Base.BaseSubResource, IHaveMSKChannelTypesS3LogDestinationS3, IHaveMSKChannelTypesFirehoseLogDestinationFirehose, IHaveMSKChannelTypesCloudWatchLogsLogDestinationCloudWatchLogs
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-channellogginginfo.html#cfn-msk-channel-channellogginginfo-s3
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3LogDestination
            /// </summary>
            public Union<Humidifier.MSK.ChannelTypes.S3LogDestination, BaseFunction>? S3 { get; set; }
            /// <summary>
            /// Firehose
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-channellogginginfo.html#cfn-msk-channel-channellogginginfo-firehose
            /// Required: False
            /// UpdateType: Immutable
            /// Type: FirehoseLogDestination
            /// </summary>
            public Union<Humidifier.MSK.ChannelTypes.FirehoseLogDestination, BaseFunction>? Firehose { get; set; }
            /// <summary>
            /// CloudWatchLogs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-channellogginginfo.html#cfn-msk-channel-channellogginginfo-cloudwatchlogs
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CloudWatchLogsLogDestination
            /// </summary>
            public Union<Humidifier.MSK.ChannelTypes.CloudWatchLogsLogDestination, BaseFunction>? CloudWatchLogs { get; set; }
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
            public Union<string, BaseFunction>? Message { get; set; }
            /// <summary>
            /// Code
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-channelstateinfo.html#cfn-msk-channel-channelstateinfo-code
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Code { get; set; }
        }

        public class CloudWatchLogsLogDestination : Humidifier.Base.BaseSubResource, IHaveLogGroup, IHaveEnabled_Boolean
        {
            /// <summary>
            /// LogGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-cloudwatchlogslogdestination.html#cfn-msk-channel-cloudwatchlogslogdestination-loggroup
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogGroup { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-cloudwatchlogslogdestination.html#cfn-msk-channel-cloudwatchlogslogdestination-enabled
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class DeadLetterQueueS3 : Humidifier.Base.BaseSubResource, IHaveErrorOutputPrefix, IHaveBucketArn, IHaveExpectedBucketOwner
        {
            /// <summary>
            /// ErrorOutputPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-deadletterqueues3.html#cfn-msk-channel-deadletterqueues3-erroroutputprefix
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ErrorOutputPrefix { get; set; }
            /// <summary>
            /// BucketArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-deadletterqueues3.html#cfn-msk-channel-deadletterqueues3-bucketarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketArn { get; set; }
            /// <summary>
            /// ExpectedBucketOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-deadletterqueues3.html#cfn-msk-channel-deadletterqueues3-expectedbucketowner
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExpectedBucketOwner { get; set; }
        }

        public class DestinationTable : Humidifier.Base.BaseSubResource, IHaveDestinationDatabaseName, IHaveDestinationTableName, IHaveMSKChannelTypesPartitionSpecPartitionSpec
        {
            /// <summary>
            /// DestinationDatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-destinationtable.html#cfn-msk-channel-destinationtable-destinationdatabasename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DestinationDatabaseName { get; set; }
            /// <summary>
            /// DestinationTableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-destinationtable.html#cfn-msk-channel-destinationtable-destinationtablename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DestinationTableName { get; set; }
            /// <summary>
            /// PartitionSpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-destinationtable.html#cfn-msk-channel-destinationtable-partitionspec
            /// Required: False
            /// UpdateType: Immutable
            /// Type: PartitionSpec
            /// </summary>
            public Union<Humidifier.MSK.ChannelTypes.PartitionSpec, BaseFunction>? PartitionSpec { get; set; }
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
            public Union<string, BaseFunction>? KmsKeyArn { get; set; }
        }

        public class FirehoseLogDestination : Humidifier.Base.BaseSubResource, IHaveDeliveryStream, IHaveEnabled_Boolean
        {
            /// <summary>
            /// DeliveryStream
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-firehoselogdestination.html#cfn-msk-channel-firehoselogdestination-deliverystream
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeliveryStream { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-firehoselogdestination.html#cfn-msk-channel-firehoselogdestination-enabled
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class IcebergDestinationConfiguration : Humidifier.Base.BaseSubResource, IHaveMSKChannelTypesDeadLetterQueueS3DeadLetterQueueS3, IHaveServiceExecutionRoleArn, IHaveDataFreshnessInSeconds_Integer, IHaveListOfMSKChannelTypesDestinationTableDestinationTableList, IHaveMSKChannelTypesSchemaEvolutionSchemaEvolution, IHaveMSKChannelTypesTableCreationTableCreation, IHaveAppendOnly_Boolean, IHaveCompressionType, IHaveMSKChannelTypesCatalogCatalog
        {
            /// <summary>
            /// DeadLetterQueueS3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-icebergdestinationconfiguration.html#cfn-msk-channel-icebergdestinationconfiguration-deadletterqueues3
            /// Required: True
            /// UpdateType: Immutable
            /// Type: DeadLetterQueueS3
            /// </summary>
            public Union<Humidifier.MSK.ChannelTypes.DeadLetterQueueS3, BaseFunction>? DeadLetterQueueS3 { get; set; }
            /// <summary>
            /// ServiceExecutionRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-icebergdestinationconfiguration.html#cfn-msk-channel-icebergdestinationconfiguration-serviceexecutionrolearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServiceExecutionRoleArn { get; set; }
            /// <summary>
            /// DataFreshnessInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-icebergdestinationconfiguration.html#cfn-msk-channel-icebergdestinationconfiguration-datafreshnessinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DataFreshnessInSeconds { get; set; }
            /// <summary>
            /// DestinationTableList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-icebergdestinationconfiguration.html#cfn-msk-channel-icebergdestinationconfiguration-destinationtablelist
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: DestinationTable
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MSK.ChannelTypes.DestinationTable>, IReadOnlyList<Union<Humidifier.MSK.ChannelTypes.DestinationTable, BaseFunction>>, BaseFunction>? DestinationTableList { get; set; }
            /// <summary>
            /// SchemaEvolution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-icebergdestinationconfiguration.html#cfn-msk-channel-icebergdestinationconfiguration-schemaevolution
            /// Required: True
            /// UpdateType: Immutable
            /// Type: SchemaEvolution
            /// </summary>
            public Union<Humidifier.MSK.ChannelTypes.SchemaEvolution, BaseFunction>? SchemaEvolution { get; set; }
            /// <summary>
            /// TableCreation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-icebergdestinationconfiguration.html#cfn-msk-channel-icebergdestinationconfiguration-tablecreation
            /// Required: True
            /// UpdateType: Immutable
            /// Type: TableCreation
            /// </summary>
            public Union<Humidifier.MSK.ChannelTypes.TableCreation, BaseFunction>? TableCreation { get; set; }
            /// <summary>
            /// AppendOnly
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-icebergdestinationconfiguration.html#cfn-msk-channel-icebergdestinationconfiguration-appendonly
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AppendOnly { get; set; }
            /// <summary>
            /// CompressionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-icebergdestinationconfiguration.html#cfn-msk-channel-icebergdestinationconfiguration-compressiontype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CompressionType { get; set; }
            /// <summary>
            /// Catalog
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-icebergdestinationconfiguration.html#cfn-msk-channel-icebergdestinationconfiguration-catalog
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Catalog
            /// </summary>
            public Union<Humidifier.MSK.ChannelTypes.Catalog, BaseFunction>? Catalog { get; set; }
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
            public Union<string, BaseFunction>? SourceName { get; set; }
        }

        public class PartitionSpec : Humidifier.Base.BaseSubResource, IHaveListOfMSKChannelTypesPartitionSourceSourceList, IHavePartitionStrategy
        {
            /// <summary>
            /// SourceList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-partitionspec.html#cfn-msk-channel-partitionspec-sourcelist
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: PartitionSource
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MSK.ChannelTypes.PartitionSource>, IReadOnlyList<Union<Humidifier.MSK.ChannelTypes.PartitionSource, BaseFunction>>, BaseFunction>? SourceList { get; set; }
            /// <summary>
            /// PartitionStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-partitionspec.html#cfn-msk-channel-partitionspec-partitionstrategy
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PartitionStrategy { get; set; }
        }

        public class RecordConverter : Humidifier.Base.BaseSubResource, IHaveValueConverter
        {
            /// <summary>
            /// ValueConverter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-recordconverter.html#cfn-msk-channel-recordconverter-valueconverter
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ValueConverter { get; set; }
        }

        public class RecordSchema : Humidifier.Base.BaseSubResource, IHaveGsrArn
        {
            /// <summary>
            /// GsrArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-recordschema.html#cfn-msk-channel-recordschema-gsrarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GsrArn { get; set; }
        }

        public class S3DestinationConfiguration : Humidifier.Base.BaseSubResource, IHaveMSKChannelTypesS3StorageStorage, IHaveMSKChannelTypesDeadLetterQueueS3DeadLetterQueueS3, IHaveDataFreshnessInSeconds_Integer, IHaveServiceExecutionRoleArn
        {
            /// <summary>
            /// Storage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-s3destinationconfiguration.html#cfn-msk-channel-s3destinationconfiguration-storage
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3Storage
            /// </summary>
            public Union<Humidifier.MSK.ChannelTypes.S3Storage, BaseFunction>? Storage { get; set; }
            /// <summary>
            /// DeadLetterQueueS3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-s3destinationconfiguration.html#cfn-msk-channel-s3destinationconfiguration-deadletterqueues3
            /// Required: True
            /// UpdateType: Immutable
            /// Type: DeadLetterQueueS3
            /// </summary>
            public Union<Humidifier.MSK.ChannelTypes.DeadLetterQueueS3, BaseFunction>? DeadLetterQueueS3 { get; set; }
            /// <summary>
            /// DataFreshnessInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-s3destinationconfiguration.html#cfn-msk-channel-s3destinationconfiguration-datafreshnessinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DataFreshnessInSeconds { get; set; }
            /// <summary>
            /// ServiceExecutionRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-s3destinationconfiguration.html#cfn-msk-channel-s3destinationconfiguration-serviceexecutionrolearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServiceExecutionRoleArn { get; set; }
        }

        public class S3LogDestination : Humidifier.Base.BaseSubResource, IHaveBucket, IHaveEnabled_Boolean, IHavePrefix
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-s3logdestination.html#cfn-msk-channel-s3logdestination-bucket
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-s3logdestination.html#cfn-msk-channel-s3logdestination-enabled
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-s3logdestination.html#cfn-msk-channel-s3logdestination-prefix
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Prefix { get; set; }
        }

        public class S3Storage : Humidifier.Base.BaseSubResource, IHaveBucketArn, IHaveOutputPrefix, IHaveStorageClass, IHaveOutputKeyTemplate, IHaveCompressionType, IHaveExpectedBucketOwner
        {
            /// <summary>
            /// BucketArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-s3storage.html#cfn-msk-channel-s3storage-bucketarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketArn { get; set; }
            /// <summary>
            /// OutputPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-s3storage.html#cfn-msk-channel-s3storage-outputprefix
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputPrefix { get; set; }
            /// <summary>
            /// StorageClass
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-s3storage.html#cfn-msk-channel-s3storage-storageclass
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StorageClass { get; set; }
            /// <summary>
            /// OutputKeyTemplate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-s3storage.html#cfn-msk-channel-s3storage-outputkeytemplate
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputKeyTemplate { get; set; }
            /// <summary>
            /// CompressionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-s3storage.html#cfn-msk-channel-s3storage-compressiontype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CompressionType { get; set; }
            /// <summary>
            /// ExpectedBucketOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-s3storage.html#cfn-msk-channel-s3storage-expectedbucketowner
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExpectedBucketOwner { get; set; }
        }

        public class SchemaEvolution : Humidifier.Base.BaseSubResource, IHaveEnableSchemaEvolution_Boolean
        {
            /// <summary>
            /// EnableSchemaEvolution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-schemaevolution.html#cfn-msk-channel-schemaevolution-enableschemaevolution
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableSchemaEvolution { get; set; }
        }

        public class TableCreation : Humidifier.Base.BaseSubResource, IHaveEnableTableCreation_Boolean
        {
            /// <summary>
            /// EnableTableCreation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-tablecreation.html#cfn-msk-channel-tablecreation-enabletablecreation
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableTableCreation { get; set; }
        }

        public class TopicConfiguration : Humidifier.Base.BaseSubResource, IHaveMSKChannelTypesRecordConverterRecordConverter, IHaveTopicArn, IHaveMSKChannelTypesRecordSchemaRecordSchema
        {
            /// <summary>
            /// RecordConverter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-topicconfiguration.html#cfn-msk-channel-topicconfiguration-recordconverter
            /// Required: True
            /// UpdateType: Immutable
            /// Type: RecordConverter
            /// </summary>
            public Union<Humidifier.MSK.ChannelTypes.RecordConverter, BaseFunction>? RecordConverter { get; set; }
            /// <summary>
            /// TopicArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-topicconfiguration.html#cfn-msk-channel-topicconfiguration-topicarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TopicArn { get; set; }
            /// <summary>
            /// RecordSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-channel-topicconfiguration.html#cfn-msk-channel-topicconfiguration-recordschema
            /// Required: False
            /// UpdateType: Immutable
            /// Type: RecordSchema
            /// </summary>
            public Union<Humidifier.MSK.ChannelTypes.RecordSchema, BaseFunction>? RecordSchema { get; set; }
        }
    }
}