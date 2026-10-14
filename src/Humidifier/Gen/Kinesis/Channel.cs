namespace Humidifier.Kinesis
{
    using global::System.Collections.Generic;
    using ChannelTypes;

    public class Channel : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveChannelName
    {
        public class Attributes
        {
            public static string ChannelARN =  "ChannelARN" ;
            public static string ChannelCreationTimestamp =  "ChannelCreationTimestamp" ;
            public static string ChannelStatus =  "ChannelStatus" ;
            public static string ChannelId =  "ChannelId" ;
        }

        public override string AWSTypeName { get => AWS.Kinesis.Channel; }
        public dynamic ChannelName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// EncryptionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesis-channel.html#cfn-kinesis-channel-encryptionconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: EncryptionConfiguration
        /// </summary>
        public Humidifier.Kinesis.ChannelTypes.EncryptionConfiguration EncryptionConfiguration { get; set; }
        /// <summary>
        /// S3DestinationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesis-channel.html#cfn-kinesis-channel-s3destinationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: S3DestinationConfiguration
        /// </summary>
        public Humidifier.Kinesis.ChannelTypes.S3DestinationConfiguration S3DestinationConfiguration { get; set; }
        /// <summary>
        /// LoggingConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesis-channel.html#cfn-kinesis-channel-loggingconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LoggingConfiguration
        /// </summary>
        public Humidifier.Kinesis.ChannelTypes.LoggingConfiguration LoggingConfiguration { get; set; }

        /// <summary>
        /// StreamConfigurationList
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesis-channel.html#cfn-kinesis-channel-streamconfigurationlist
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: StreamConfiguration
        /// </summary>
        [Required]
        public List<Humidifier.Kinesis.ChannelTypes.StreamConfiguration> StreamConfigurationList { get; set; }

        /// <summary>
        /// ServiceExecutionRoleARN
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesis-channel.html#cfn-kinesis-channel-serviceexecutionrolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ServiceExecutionRoleARN { get; set; }
        /// <summary>
        /// S3TablesDestinationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesis-channel.html#cfn-kinesis-channel-s3tablesdestinationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: S3TablesDestinationConfiguration
        /// </summary>
        public Humidifier.Kinesis.ChannelTypes.S3TablesDestinationConfiguration S3TablesDestinationConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesis-channel.html#cfn-kinesis-channel-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace ChannelTypes
    {
        public class CloudWatchLogsConfiguration : Humidifier.Base.BaseSubResource, IHaveEnabled, IHaveLogGroupName, IHaveLogStreamName
        {
            /// <summary>
            /// LogStreamName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-cloudwatchlogsconfiguration.html#cfn-kinesis-channel-cloudwatchlogsconfiguration-logstreamname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogStreamName { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-cloudwatchlogsconfiguration.html#cfn-kinesis-channel-cloudwatchlogsconfiguration-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
            /// <summary>
            /// LogGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-cloudwatchlogsconfiguration.html#cfn-kinesis-channel-cloudwatchlogsconfiguration-loggroupname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogGroupName { get; set; }
        }

        public class DeadLetterQueueS3Configuration : Humidifier.Base.BaseSubResource, IHaveBucketARN, IHaveExpectedBucketOwner, IHaveErrorOutputPrefix
        {
            /// <summary>
            /// ErrorOutputPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-deadletterqueues3configuration.html#cfn-kinesis-channel-deadletterqueues3configuration-erroroutputprefix
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ErrorOutputPrefix { get; set; }
            /// <summary>
            /// BucketARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-deadletterqueues3configuration.html#cfn-kinesis-channel-deadletterqueues3configuration-bucketarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketARN { get; set; }
            /// <summary>
            /// ExpectedBucketOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-deadletterqueues3configuration.html#cfn-kinesis-channel-deadletterqueues3configuration-expectedbucketowner
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExpectedBucketOwner { get; set; }
        }

        public class EncryptionConfiguration : Humidifier.Base.BaseSubResource, IHaveEncryptionType, IHaveKeyId
        {
            /// <summary>
            /// EncryptionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-encryptionconfiguration.html#cfn-kinesis-channel-encryptionconfiguration-encryptiontype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EncryptionType { get; set; }
            /// <summary>
            /// KeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-encryptionconfiguration.html#cfn-kinesis-channel-encryptionconfiguration-keyid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KeyId { get; set; }
        }

        public class LoggingConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CloudWatchLogs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-loggingconfiguration.html#cfn-kinesis-channel-loggingconfiguration-cloudwatchlogs
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CloudWatchLogsConfiguration
            /// </summary>
            public Humidifier.Kinesis.ChannelTypes.CloudWatchLogsConfiguration CloudWatchLogs { get; set; }
        }

        public class PartitionField : Humidifier.Base.BaseSubResource, IHaveSourceName
        {
            /// <summary>
            /// SourceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-partitionfield.html#cfn-kinesis-channel-partitionfield-sourcename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceName { get; set; }
            /// <summary>
            /// Transform
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-partitionfield.html#cfn-kinesis-channel-partitionfield-transform
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Transform { get; set; }
        }

        public class PartitionSpec : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PartitionFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-partitionspec.html#cfn-kinesis-channel-partitionspec-partitionfields
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: PartitionField
            /// </summary>
            public List<Humidifier.Kinesis.ChannelTypes.PartitionField> PartitionFields { get; set; }
        }

        public class RecordConfiguration : Humidifier.Base.BaseSubResource, IHaveRecordFormatType
        {
            /// <summary>
            /// GSRSchemaARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-recordconfiguration.html#cfn-kinesis-channel-recordconfiguration-gsrschemaarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GSRSchemaARN { get; set; }
            /// <summary>
            /// RecordFormatType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-recordconfiguration.html#cfn-kinesis-channel-recordconfiguration-recordformattype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RecordFormatType { get; set; }
        }

        public class S3DestinationConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DeadLetterQueueS3Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-s3destinationconfiguration.html#cfn-kinesis-channel-s3destinationconfiguration-deadletterqueues3configuration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: DeadLetterQueueS3Configuration
            /// </summary>
            public Humidifier.Kinesis.ChannelTypes.DeadLetterQueueS3Configuration DeadLetterQueueS3Configuration { get; set; }
            /// <summary>
            /// DataFreshnessInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-s3destinationconfiguration.html#cfn-kinesis-channel-s3destinationconfiguration-datafreshnessinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DataFreshnessInSeconds { get; set; }
            /// <summary>
            /// StorageConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-s3destinationconfiguration.html#cfn-kinesis-channel-s3destinationconfiguration-storageconfiguration
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3StorageConfiguration
            /// </summary>
            public Humidifier.Kinesis.ChannelTypes.S3StorageConfiguration StorageConfiguration { get; set; }
        }

        public class S3StorageConfiguration : Humidifier.Base.BaseSubResource, IHaveBucketARN, IHaveCompressionType, IHaveStorageClass, IHaveExpectedBucketOwner
        {
            /// <summary>
            /// BucketARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-s3storageconfiguration.html#cfn-kinesis-channel-s3storageconfiguration-bucketarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketARN { get; set; }
            /// <summary>
            /// StorageClass
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-s3storageconfiguration.html#cfn-kinesis-channel-s3storageconfiguration-storageclass
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StorageClass { get; set; }
            /// <summary>
            /// OutputKeyTemplate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-s3storageconfiguration.html#cfn-kinesis-channel-s3storageconfiguration-outputkeytemplate
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OutputKeyTemplate { get; set; }
            /// <summary>
            /// CompressionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-s3storageconfiguration.html#cfn-kinesis-channel-s3storageconfiguration-compressiontype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CompressionType { get; set; }
            /// <summary>
            /// ExpectedBucketOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-s3storageconfiguration.html#cfn-kinesis-channel-s3storageconfiguration-expectedbucketowner
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExpectedBucketOwner { get; set; }
        }

        public class S3TableConfiguration : Humidifier.Base.BaseSubResource, IHaveTableName, IHaveNamespace_, IHaveCompressionType
        {
            /// <summary>
            /// TableBucketARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-s3tableconfiguration.html#cfn-kinesis-channel-s3tableconfiguration-tablebucketarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TableBucketARN { get; set; }
            /// <summary>
            /// TableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-s3tableconfiguration.html#cfn-kinesis-channel-s3tableconfiguration-tablename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TableName { get; set; }
            /// <summary>
            /// CompressionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-s3tableconfiguration.html#cfn-kinesis-channel-s3tableconfiguration-compressiontype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CompressionType { get; set; }
            /// <summary>
            /// PartitionSpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-s3tableconfiguration.html#cfn-kinesis-channel-s3tableconfiguration-partitionspec
            /// Required: False
            /// UpdateType: Immutable
            /// Type: PartitionSpec
            /// </summary>
            public Humidifier.Kinesis.ChannelTypes.PartitionSpec PartitionSpec { get; set; }
            /// <summary>
            /// Namespace_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-s3tableconfiguration.html#cfn-kinesis-channel-s3tableconfiguration-namespace
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Namespace_ { get; set; }
        }

        public class S3TablesDestinationConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3TablesConfigurationList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-s3tablesdestinationconfiguration.html#cfn-kinesis-channel-s3tablesdestinationconfiguration-s3tablesconfigurationlist
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: S3TableConfiguration
            /// </summary>
            public List<Humidifier.Kinesis.ChannelTypes.S3TableConfiguration> S3TablesConfigurationList { get; set; }
            /// <summary>
            /// DeadLetterQueueS3Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-s3tablesdestinationconfiguration.html#cfn-kinesis-channel-s3tablesdestinationconfiguration-deadletterqueues3configuration
            /// Required: True
            /// UpdateType: Immutable
            /// Type: DeadLetterQueueS3Configuration
            /// </summary>
            public Humidifier.Kinesis.ChannelTypes.DeadLetterQueueS3Configuration DeadLetterQueueS3Configuration { get; set; }
            /// <summary>
            /// DataFreshnessInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-s3tablesdestinationconfiguration.html#cfn-kinesis-channel-s3tablesdestinationconfiguration-datafreshnessinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DataFreshnessInSeconds { get; set; }
        }

        public class StreamConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RecordConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-streamconfiguration.html#cfn-kinesis-channel-streamconfiguration-recordconfiguration
            /// Required: True
            /// UpdateType: Immutable
            /// Type: RecordConfiguration
            /// </summary>
            public Humidifier.Kinesis.ChannelTypes.RecordConfiguration RecordConfiguration { get; set; }
            /// <summary>
            /// StreamARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-streamconfiguration.html#cfn-kinesis-channel-streamconfiguration-streamarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StreamARN { get; set; }
        }
    }
}