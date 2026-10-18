namespace Humidifier.Kinesis
{
    using global::System.Collections.Generic;
    using ChannelTypes;

    public class Channel : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveChannelName, IHaveKinesisChannelTypesEncryptionConfigurationEncryptionConfiguration, IHaveKinesisChannelTypesS3DestinationConfigurationS3DestinationConfiguration, IHaveKinesisChannelTypesLoggingConfigurationLoggingConfiguration, IHaveListOfKinesisChannelTypesStreamConfigurationStreamConfigurationList, IHaveServiceExecutionRoleARN, IHaveKinesisChannelTypesS3TablesDestinationConfigurationS3TablesDestinationConfiguration
    {
        public class Attributes
        {
            public static string ChannelARN =  "ChannelARN" ;
            public static string ChannelCreationTimestamp =  "ChannelCreationTimestamp" ;
            public static string ChannelStatus =  "ChannelStatus" ;
            public static string ChannelId =  "ChannelId" ;
        }

        public override string AWSTypeName { get => AWS.Kinesis.Channel; }
        public Union<string, BaseFunction>? ChannelName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// EncryptionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesis-channel.html#cfn-kinesis-channel-encryptionconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: EncryptionConfiguration
        /// </summary>
        public Union<Humidifier.Kinesis.ChannelTypes.EncryptionConfiguration, BaseFunction>? EncryptionConfiguration { get; set; }
        /// <summary>
        /// S3DestinationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesis-channel.html#cfn-kinesis-channel-s3destinationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: S3DestinationConfiguration
        /// </summary>
        public Union<Humidifier.Kinesis.ChannelTypes.S3DestinationConfiguration, BaseFunction>? S3DestinationConfiguration { get; set; }
        /// <summary>
        /// LoggingConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesis-channel.html#cfn-kinesis-channel-loggingconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LoggingConfiguration
        /// </summary>
        public Union<Humidifier.Kinesis.ChannelTypes.LoggingConfiguration, BaseFunction>? LoggingConfiguration { get; set; }

        /// <summary>
        /// StreamConfigurationList
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesis-channel.html#cfn-kinesis-channel-streamconfigurationlist
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: StreamConfiguration
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.Kinesis.ChannelTypes.StreamConfiguration>, IReadOnlyList<Union<Humidifier.Kinesis.ChannelTypes.StreamConfiguration, BaseFunction>>, BaseFunction>? StreamConfigurationList { get; set; }

        /// <summary>
        /// ServiceExecutionRoleARN
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesis-channel.html#cfn-kinesis-channel-serviceexecutionrolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ServiceExecutionRoleARN { get; set; }
        /// <summary>
        /// S3TablesDestinationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesis-channel.html#cfn-kinesis-channel-s3tablesdestinationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: S3TablesDestinationConfiguration
        /// </summary>
        public Union<Humidifier.Kinesis.ChannelTypes.S3TablesDestinationConfiguration, BaseFunction>? S3TablesDestinationConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesis-channel.html#cfn-kinesis-channel-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ChannelTypes
    {
        public class CloudWatchLogsConfiguration : Humidifier.Base.BaseSubResource, IHaveLogStreamName, IHaveEnabled_Boolean, IHaveLogGroupName
        {
            /// <summary>
            /// LogStreamName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-cloudwatchlogsconfiguration.html#cfn-kinesis-channel-cloudwatchlogsconfiguration-logstreamname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogStreamName { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-cloudwatchlogsconfiguration.html#cfn-kinesis-channel-cloudwatchlogsconfiguration-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// LogGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-cloudwatchlogsconfiguration.html#cfn-kinesis-channel-cloudwatchlogsconfiguration-loggroupname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogGroupName { get; set; }
        }

        public class DeadLetterQueueS3Configuration : Humidifier.Base.BaseSubResource, IHaveErrorOutputPrefix, IHaveBucketARN, IHaveExpectedBucketOwner
        {
            /// <summary>
            /// ErrorOutputPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-deadletterqueues3configuration.html#cfn-kinesis-channel-deadletterqueues3configuration-erroroutputprefix
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ErrorOutputPrefix { get; set; }
            /// <summary>
            /// BucketARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-deadletterqueues3configuration.html#cfn-kinesis-channel-deadletterqueues3configuration-bucketarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketARN { get; set; }
            /// <summary>
            /// ExpectedBucketOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-deadletterqueues3configuration.html#cfn-kinesis-channel-deadletterqueues3configuration-expectedbucketowner
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExpectedBucketOwner { get; set; }
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
            public Union<string, BaseFunction>? EncryptionType { get; set; }
            /// <summary>
            /// KeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-encryptionconfiguration.html#cfn-kinesis-channel-encryptionconfiguration-keyid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KeyId { get; set; }
        }

        public class LoggingConfiguration : Humidifier.Base.BaseSubResource, IHaveKinesisChannelTypesCloudWatchLogsConfigurationCloudWatchLogs
        {
            /// <summary>
            /// CloudWatchLogs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-loggingconfiguration.html#cfn-kinesis-channel-loggingconfiguration-cloudwatchlogs
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CloudWatchLogsConfiguration
            /// </summary>
            public Union<Humidifier.Kinesis.ChannelTypes.CloudWatchLogsConfiguration, BaseFunction>? CloudWatchLogs { get; set; }
        }

        public class PartitionField : Humidifier.Base.BaseSubResource, IHaveSourceName, IHaveTransform
        {
            /// <summary>
            /// SourceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-partitionfield.html#cfn-kinesis-channel-partitionfield-sourcename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceName { get; set; }
            /// <summary>
            /// Transform
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-partitionfield.html#cfn-kinesis-channel-partitionfield-transform
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Transform { get; set; }
        }

        public class PartitionSpec : Humidifier.Base.BaseSubResource, IHaveListOfKinesisChannelTypesPartitionFieldPartitionFields
        {
            /// <summary>
            /// PartitionFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-partitionspec.html#cfn-kinesis-channel-partitionspec-partitionfields
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: PartitionField
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Kinesis.ChannelTypes.PartitionField>, IReadOnlyList<Union<Humidifier.Kinesis.ChannelTypes.PartitionField, BaseFunction>>, BaseFunction>? PartitionFields { get; set; }
        }

        public class RecordConfiguration : Humidifier.Base.BaseSubResource, IHaveGSRSchemaARN, IHaveRecordFormatType
        {
            /// <summary>
            /// GSRSchemaARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-recordconfiguration.html#cfn-kinesis-channel-recordconfiguration-gsrschemaarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GSRSchemaARN { get; set; }
            /// <summary>
            /// RecordFormatType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-recordconfiguration.html#cfn-kinesis-channel-recordconfiguration-recordformattype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RecordFormatType { get; set; }
        }

        public class S3DestinationConfiguration : Humidifier.Base.BaseSubResource, IHaveKinesisChannelTypesDeadLetterQueueS3ConfigurationDeadLetterQueueS3Configuration, IHaveDataFreshnessInSeconds_Integer, IHaveKinesisChannelTypesS3StorageConfigurationStorageConfiguration
        {
            /// <summary>
            /// DeadLetterQueueS3Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-s3destinationconfiguration.html#cfn-kinesis-channel-s3destinationconfiguration-deadletterqueues3configuration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: DeadLetterQueueS3Configuration
            /// </summary>
            public Union<Humidifier.Kinesis.ChannelTypes.DeadLetterQueueS3Configuration, BaseFunction>? DeadLetterQueueS3Configuration { get; set; }
            /// <summary>
            /// DataFreshnessInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-s3destinationconfiguration.html#cfn-kinesis-channel-s3destinationconfiguration-datafreshnessinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DataFreshnessInSeconds { get; set; }
            /// <summary>
            /// StorageConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-s3destinationconfiguration.html#cfn-kinesis-channel-s3destinationconfiguration-storageconfiguration
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3StorageConfiguration
            /// </summary>
            public Union<Humidifier.Kinesis.ChannelTypes.S3StorageConfiguration, BaseFunction>? StorageConfiguration { get; set; }
        }

        public class S3StorageConfiguration : Humidifier.Base.BaseSubResource, IHaveBucketARN, IHaveStorageClass, IHaveOutputKeyTemplate, IHaveCompressionType, IHaveExpectedBucketOwner
        {
            /// <summary>
            /// BucketARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-s3storageconfiguration.html#cfn-kinesis-channel-s3storageconfiguration-bucketarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketARN { get; set; }
            /// <summary>
            /// StorageClass
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-s3storageconfiguration.html#cfn-kinesis-channel-s3storageconfiguration-storageclass
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StorageClass { get; set; }
            /// <summary>
            /// OutputKeyTemplate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-s3storageconfiguration.html#cfn-kinesis-channel-s3storageconfiguration-outputkeytemplate
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputKeyTemplate { get; set; }
            /// <summary>
            /// CompressionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-s3storageconfiguration.html#cfn-kinesis-channel-s3storageconfiguration-compressiontype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CompressionType { get; set; }
            /// <summary>
            /// ExpectedBucketOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-s3storageconfiguration.html#cfn-kinesis-channel-s3storageconfiguration-expectedbucketowner
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExpectedBucketOwner { get; set; }
        }

        public class S3TableConfiguration : Humidifier.Base.BaseSubResource, IHaveTableBucketARN, IHaveTableName, IHaveCompressionType, IHaveKinesisChannelTypesPartitionSpecPartitionSpec, IHaveNamespace_
        {
            /// <summary>
            /// TableBucketARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-s3tableconfiguration.html#cfn-kinesis-channel-s3tableconfiguration-tablebucketarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TableBucketARN { get; set; }
            /// <summary>
            /// TableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-s3tableconfiguration.html#cfn-kinesis-channel-s3tableconfiguration-tablename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TableName { get; set; }
            /// <summary>
            /// CompressionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-s3tableconfiguration.html#cfn-kinesis-channel-s3tableconfiguration-compressiontype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CompressionType { get; set; }
            /// <summary>
            /// PartitionSpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-s3tableconfiguration.html#cfn-kinesis-channel-s3tableconfiguration-partitionspec
            /// Required: False
            /// UpdateType: Immutable
            /// Type: PartitionSpec
            /// </summary>
            public Union<Humidifier.Kinesis.ChannelTypes.PartitionSpec, BaseFunction>? PartitionSpec { get; set; }
            /// <summary>
            /// Namespace_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-s3tableconfiguration.html#cfn-kinesis-channel-s3tableconfiguration-namespace
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Namespace_ { get; set; }
        }

        public class S3TablesDestinationConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfKinesisChannelTypesS3TableConfigurationS3TablesConfigurationList, IHaveKinesisChannelTypesDeadLetterQueueS3ConfigurationDeadLetterQueueS3Configuration, IHaveDataFreshnessInSeconds_Integer
        {
            /// <summary>
            /// S3TablesConfigurationList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-s3tablesdestinationconfiguration.html#cfn-kinesis-channel-s3tablesdestinationconfiguration-s3tablesconfigurationlist
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: S3TableConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Kinesis.ChannelTypes.S3TableConfiguration>, IReadOnlyList<Union<Humidifier.Kinesis.ChannelTypes.S3TableConfiguration, BaseFunction>>, BaseFunction>? S3TablesConfigurationList { get; set; }
            /// <summary>
            /// DeadLetterQueueS3Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-s3tablesdestinationconfiguration.html#cfn-kinesis-channel-s3tablesdestinationconfiguration-deadletterqueues3configuration
            /// Required: True
            /// UpdateType: Immutable
            /// Type: DeadLetterQueueS3Configuration
            /// </summary>
            public Union<Humidifier.Kinesis.ChannelTypes.DeadLetterQueueS3Configuration, BaseFunction>? DeadLetterQueueS3Configuration { get; set; }
            /// <summary>
            /// DataFreshnessInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-s3tablesdestinationconfiguration.html#cfn-kinesis-channel-s3tablesdestinationconfiguration-datafreshnessinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DataFreshnessInSeconds { get; set; }
        }

        public class StreamConfiguration : Humidifier.Base.BaseSubResource, IHaveKinesisChannelTypesRecordConfigurationRecordConfiguration, IHaveStreamARN
        {
            /// <summary>
            /// RecordConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-streamconfiguration.html#cfn-kinesis-channel-streamconfiguration-recordconfiguration
            /// Required: True
            /// UpdateType: Immutable
            /// Type: RecordConfiguration
            /// </summary>
            public Union<Humidifier.Kinesis.ChannelTypes.RecordConfiguration, BaseFunction>? RecordConfiguration { get; set; }
            /// <summary>
            /// StreamARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-channel-streamconfiguration.html#cfn-kinesis-channel-streamconfiguration-streamarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StreamARN { get; set; }
        }
    }
}