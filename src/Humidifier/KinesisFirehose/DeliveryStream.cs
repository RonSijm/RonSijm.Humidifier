namespace Humidifier.KinesisFirehose
{
    using System.Collections.Generic;
    using DeliveryStreamTypes;

    public class DeliveryStream : Humidifier.Resource, IHaveTags
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::KinesisFirehose::DeliveryStream";
            }
        }

        /// <summary>
        /// DeliveryStreamEncryptionConfigurationInput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisfirehose-deliverystream.html#cfn-kinesisfirehose-deliverystream-deliverystreamencryptionconfigurationinput
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DeliveryStreamEncryptionConfigurationInput
        /// </summary>
        public DeliveryStreamEncryptionConfigurationInput DeliveryStreamEncryptionConfigurationInput { get; set; }
        /// <summary>
        /// HttpEndpointDestinationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisfirehose-deliverystream.html#cfn-kinesisfirehose-deliverystream-httpendpointdestinationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: HttpEndpointDestinationConfiguration
        /// </summary>
        public HttpEndpointDestinationConfiguration HttpEndpointDestinationConfiguration { get; set; }
        /// <summary>
        /// KinesisStreamSourceConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisfirehose-deliverystream.html#cfn-kinesisfirehose-deliverystream-kinesisstreamsourceconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: KinesisStreamSourceConfiguration
        /// </summary>
        public KinesisStreamSourceConfiguration KinesisStreamSourceConfiguration { get; set; }
        /// <summary>
        /// DeliveryStreamType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisfirehose-deliverystream.html#cfn-kinesisfirehose-deliverystream-deliverystreamtype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DeliveryStreamType { get; set; }
        /// <summary>
        /// RedshiftDestinationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisfirehose-deliverystream.html#cfn-kinesisfirehose-deliverystream-redshiftdestinationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RedshiftDestinationConfiguration
        /// </summary>
        public RedshiftDestinationConfiguration RedshiftDestinationConfiguration { get; set; }
        /// <summary>
        /// AmazonopensearchserviceDestinationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisfirehose-deliverystream.html#cfn-kinesisfirehose-deliverystream-amazonopensearchservicedestinationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AmazonopensearchserviceDestinationConfiguration
        /// </summary>
        public AmazonopensearchserviceDestinationConfiguration AmazonopensearchserviceDestinationConfiguration { get; set; }
        /// <summary>
        /// MSKSourceConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisfirehose-deliverystream.html#cfn-kinesisfirehose-deliverystream-msksourceconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: MSKSourceConfiguration
        /// </summary>
        public MSKSourceConfiguration MSKSourceConfiguration { get; set; }
        /// <summary>
        /// SplunkDestinationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisfirehose-deliverystream.html#cfn-kinesisfirehose-deliverystream-splunkdestinationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SplunkDestinationConfiguration
        /// </summary>
        public SplunkDestinationConfiguration SplunkDestinationConfiguration { get; set; }
        /// <summary>
        /// ExtendedS3DestinationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisfirehose-deliverystream.html#cfn-kinesisfirehose-deliverystream-extendeds3destinationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ExtendedS3DestinationConfiguration
        /// </summary>
        public ExtendedS3DestinationConfiguration ExtendedS3DestinationConfiguration { get; set; }
        /// <summary>
        /// AmazonOpenSearchServerlessDestinationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisfirehose-deliverystream.html#cfn-kinesisfirehose-deliverystream-amazonopensearchserverlessdestinationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AmazonOpenSearchServerlessDestinationConfiguration
        /// </summary>
        public AmazonOpenSearchServerlessDestinationConfiguration AmazonOpenSearchServerlessDestinationConfiguration { get; set; }
        /// <summary>
        /// ElasticsearchDestinationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisfirehose-deliverystream.html#cfn-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ElasticsearchDestinationConfiguration
        /// </summary>
        public ElasticsearchDestinationConfiguration ElasticsearchDestinationConfiguration { get; set; }
        /// <summary>
        /// SnowflakeDestinationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisfirehose-deliverystream.html#cfn-kinesisfirehose-deliverystream-snowflakedestinationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SnowflakeDestinationConfiguration
        /// </summary>
        public SnowflakeDestinationConfiguration SnowflakeDestinationConfiguration { get; set; }
        /// <summary>
        /// S3DestinationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisfirehose-deliverystream.html#cfn-kinesisfirehose-deliverystream-s3destinationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: S3DestinationConfiguration
        /// </summary>
        public S3DestinationConfiguration S3DestinationConfiguration { get; set; }
        /// <summary>
        /// DeliveryStreamName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisfirehose-deliverystream.html#cfn-kinesisfirehose-deliverystream-deliverystreamname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DeliveryStreamName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisfirehose-deliverystream.html#cfn-kinesisfirehose-deliverystream-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace DeliveryStreamTypes
    {
        public class AmazonOpenSearchServerlessBufferingHints
        {
            /// <summary>
            /// IntervalInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-amazonopensearchserverlessbufferinghints.html#cfn-kinesisfirehose-deliverystream-amazonopensearchserverlessbufferinghints-intervalinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic IntervalInSeconds { get; set; }
            /// <summary>
            /// SizeInMBs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-amazonopensearchserverlessbufferinghints.html#cfn-kinesisfirehose-deliverystream-amazonopensearchserverlessbufferinghints-sizeinmbs
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic SizeInMBs { get; set; }
        }

        public class AmazonOpenSearchServerlessDestinationConfiguration
        {
            /// <summary>
            /// IndexName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-amazonopensearchserverlessdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-amazonopensearchserverlessdestinationconfiguration-indexname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IndexName { get; set; }
            /// <summary>
            /// S3Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-amazonopensearchserverlessdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-amazonopensearchserverlessdestinationconfiguration-s3configuration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: S3DestinationConfiguration
            /// </summary>
            public S3DestinationConfiguration S3Configuration { get; set; }
            /// <summary>
            /// BufferingHints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-amazonopensearchserverlessdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-amazonopensearchserverlessdestinationconfiguration-bufferinghints
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AmazonOpenSearchServerlessBufferingHints
            /// </summary>
            public AmazonOpenSearchServerlessBufferingHints BufferingHints { get; set; }
            /// <summary>
            /// RetryOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-amazonopensearchserverlessdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-amazonopensearchserverlessdestinationconfiguration-retryoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AmazonOpenSearchServerlessRetryOptions
            /// </summary>
            public AmazonOpenSearchServerlessRetryOptions RetryOptions { get; set; }
            /// <summary>
            /// CollectionEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-amazonopensearchserverlessdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-amazonopensearchserverlessdestinationconfiguration-collectionendpoint
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CollectionEndpoint { get; set; }
            /// <summary>
            /// VpcConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-amazonopensearchserverlessdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-amazonopensearchserverlessdestinationconfiguration-vpcconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: VpcConfiguration
            /// </summary>
            public VpcConfiguration VpcConfiguration { get; set; }
            /// <summary>
            /// ProcessingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-amazonopensearchserverlessdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-amazonopensearchserverlessdestinationconfiguration-processingconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ProcessingConfiguration
            /// </summary>
            public ProcessingConfiguration ProcessingConfiguration { get; set; }
            /// <summary>
            /// CloudWatchLoggingOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-amazonopensearchserverlessdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-amazonopensearchserverlessdestinationconfiguration-cloudwatchloggingoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudWatchLoggingOptions
            /// </summary>
            public CloudWatchLoggingOptions CloudWatchLoggingOptions { get; set; }
            /// <summary>
            /// RoleARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-amazonopensearchserverlessdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-amazonopensearchserverlessdestinationconfiguration-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleARN { get; set; }
            /// <summary>
            /// S3BackupMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-amazonopensearchserverlessdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-amazonopensearchserverlessdestinationconfiguration-s3backupmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3BackupMode { get; set; }
        }

        public class AmazonOpenSearchServerlessRetryOptions
        {
            /// <summary>
            /// DurationInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-amazonopensearchserverlessretryoptions.html#cfn-kinesisfirehose-deliverystream-amazonopensearchserverlessretryoptions-durationinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DurationInSeconds { get; set; }
        }

        public class AmazonopensearchserviceBufferingHints
        {
            /// <summary>
            /// IntervalInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-amazonopensearchservicebufferinghints.html#cfn-kinesisfirehose-deliverystream-amazonopensearchservicebufferinghints-intervalinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic IntervalInSeconds { get; set; }
            /// <summary>
            /// SizeInMBs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-amazonopensearchservicebufferinghints.html#cfn-kinesisfirehose-deliverystream-amazonopensearchservicebufferinghints-sizeinmbs
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic SizeInMBs { get; set; }
        }

        public class AmazonopensearchserviceDestinationConfiguration
        {
            /// <summary>
            /// TypeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-amazonopensearchservicedestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-amazonopensearchservicedestinationconfiguration-typename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TypeName { get; set; }
            /// <summary>
            /// IndexRotationPeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-amazonopensearchservicedestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-amazonopensearchservicedestinationconfiguration-indexrotationperiod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IndexRotationPeriod { get; set; }
            /// <summary>
            /// ProcessingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-amazonopensearchservicedestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-amazonopensearchservicedestinationconfiguration-processingconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ProcessingConfiguration
            /// </summary>
            public ProcessingConfiguration ProcessingConfiguration { get; set; }
            /// <summary>
            /// ClusterEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-amazonopensearchservicedestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-amazonopensearchservicedestinationconfiguration-clusterendpoint
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClusterEndpoint { get; set; }
            /// <summary>
            /// DomainARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-amazonopensearchservicedestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-amazonopensearchservicedestinationconfiguration-domainarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DomainARN { get; set; }
            /// <summary>
            /// RoleARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-amazonopensearchservicedestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-amazonopensearchservicedestinationconfiguration-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleARN { get; set; }
            /// <summary>
            /// S3BackupMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-amazonopensearchservicedestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-amazonopensearchservicedestinationconfiguration-s3backupmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3BackupMode { get; set; }
            /// <summary>
            /// IndexName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-amazonopensearchservicedestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-amazonopensearchservicedestinationconfiguration-indexname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IndexName { get; set; }
            /// <summary>
            /// DocumentIdOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-amazonopensearchservicedestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-amazonopensearchservicedestinationconfiguration-documentidoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentIdOptions
            /// </summary>
            public DocumentIdOptions DocumentIdOptions { get; set; }
            /// <summary>
            /// S3Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-amazonopensearchservicedestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-amazonopensearchservicedestinationconfiguration-s3configuration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: S3DestinationConfiguration
            /// </summary>
            public S3DestinationConfiguration S3Configuration { get; set; }
            /// <summary>
            /// BufferingHints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-amazonopensearchservicedestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-amazonopensearchservicedestinationconfiguration-bufferinghints
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AmazonopensearchserviceBufferingHints
            /// </summary>
            public AmazonopensearchserviceBufferingHints BufferingHints { get; set; }
            /// <summary>
            /// RetryOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-amazonopensearchservicedestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-amazonopensearchservicedestinationconfiguration-retryoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AmazonopensearchserviceRetryOptions
            /// </summary>
            public AmazonopensearchserviceRetryOptions RetryOptions { get; set; }
            /// <summary>
            /// VpcConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-amazonopensearchservicedestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-amazonopensearchservicedestinationconfiguration-vpcconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: VpcConfiguration
            /// </summary>
            public VpcConfiguration VpcConfiguration { get; set; }
            /// <summary>
            /// CloudWatchLoggingOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-amazonopensearchservicedestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-amazonopensearchservicedestinationconfiguration-cloudwatchloggingoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudWatchLoggingOptions
            /// </summary>
            public CloudWatchLoggingOptions CloudWatchLoggingOptions { get; set; }
        }

        public class AmazonopensearchserviceRetryOptions
        {
            /// <summary>
            /// DurationInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-amazonopensearchserviceretryoptions.html#cfn-kinesisfirehose-deliverystream-amazonopensearchserviceretryoptions-durationinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DurationInSeconds { get; set; }
        }

        public class AuthenticationConfiguration
        {
            /// <summary>
            /// Connectivity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-authenticationconfiguration.html#cfn-kinesisfirehose-deliverystream-authenticationconfiguration-connectivity
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Connectivity { get; set; }
            /// <summary>
            /// RoleARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-authenticationconfiguration.html#cfn-kinesisfirehose-deliverystream-authenticationconfiguration-rolearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleARN { get; set; }
        }

        public class BufferingHints
        {
            /// <summary>
            /// IntervalInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-bufferinghints.html#cfn-kinesisfirehose-deliverystream-bufferinghints-intervalinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic IntervalInSeconds { get; set; }
            /// <summary>
            /// SizeInMBs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-bufferinghints.html#cfn-kinesisfirehose-deliverystream-bufferinghints-sizeinmbs
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic SizeInMBs { get; set; }
        }

        public class CloudWatchLoggingOptions
        {
            /// <summary>
            /// LogStreamName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-cloudwatchloggingoptions.html#cfn-kinesisfirehose-deliverystream-cloudwatchloggingoptions-logstreamname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogStreamName { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-cloudwatchloggingoptions.html#cfn-kinesisfirehose-deliverystream-cloudwatchloggingoptions-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
            /// <summary>
            /// LogGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-cloudwatchloggingoptions.html#cfn-kinesisfirehose-deliverystream-cloudwatchloggingoptions-loggroupname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogGroupName { get; set; }
        }

        public class CopyCommand
        {
            /// <summary>
            /// DataTableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-copycommand.html#cfn-kinesisfirehose-deliverystream-copycommand-datatablename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataTableName { get; set; }
            /// <summary>
            /// CopyOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-copycommand.html#cfn-kinesisfirehose-deliverystream-copycommand-copyoptions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CopyOptions { get; set; }
            /// <summary>
            /// DataTableColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-copycommand.html#cfn-kinesisfirehose-deliverystream-copycommand-datatablecolumns
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataTableColumns { get; set; }
        }

        public class DataFormatConversionConfiguration
        {
            /// <summary>
            /// InputFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-dataformatconversionconfiguration.html#cfn-kinesisfirehose-deliverystream-dataformatconversionconfiguration-inputformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InputFormatConfiguration
            /// </summary>
            public InputFormatConfiguration InputFormatConfiguration { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-dataformatconversionconfiguration.html#cfn-kinesisfirehose-deliverystream-dataformatconversionconfiguration-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
            /// <summary>
            /// SchemaConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-dataformatconversionconfiguration.html#cfn-kinesisfirehose-deliverystream-dataformatconversionconfiguration-schemaconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SchemaConfiguration
            /// </summary>
            public SchemaConfiguration SchemaConfiguration { get; set; }
            /// <summary>
            /// OutputFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-dataformatconversionconfiguration.html#cfn-kinesisfirehose-deliverystream-dataformatconversionconfiguration-outputformatconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OutputFormatConfiguration
            /// </summary>
            public OutputFormatConfiguration OutputFormatConfiguration { get; set; }
        }

        public class DeliveryStreamEncryptionConfigurationInput
        {
            /// <summary>
            /// KeyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-deliverystreamencryptionconfigurationinput.html#cfn-kinesisfirehose-deliverystream-deliverystreamencryptionconfigurationinput-keytype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KeyType { get; set; }
            /// <summary>
            /// KeyARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-deliverystreamencryptionconfigurationinput.html#cfn-kinesisfirehose-deliverystream-deliverystreamencryptionconfigurationinput-keyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KeyARN { get; set; }
        }

        public class Deserializer
        {
            /// <summary>
            /// HiveJsonSerDe
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-deserializer.html#cfn-kinesisfirehose-deliverystream-deserializer-hivejsonserde
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HiveJsonSerDe
            /// </summary>
            public HiveJsonSerDe HiveJsonSerDe { get; set; }
            /// <summary>
            /// OpenXJsonSerDe
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-deserializer.html#cfn-kinesisfirehose-deliverystream-deserializer-openxjsonserde
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OpenXJsonSerDe
            /// </summary>
            public OpenXJsonSerDe OpenXJsonSerDe { get; set; }
        }

        public class DocumentIdOptions
        {
            /// <summary>
            /// DefaultDocumentIdFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-documentidoptions.html#cfn-kinesisfirehose-deliverystream-documentidoptions-defaultdocumentidformat
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DefaultDocumentIdFormat { get; set; }
        }

        public class DynamicPartitioningConfiguration
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-dynamicpartitioningconfiguration.html#cfn-kinesisfirehose-deliverystream-dynamicpartitioningconfiguration-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
            /// <summary>
            /// RetryOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-dynamicpartitioningconfiguration.html#cfn-kinesisfirehose-deliverystream-dynamicpartitioningconfiguration-retryoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RetryOptions
            /// </summary>
            public RetryOptions RetryOptions { get; set; }
        }

        public class ElasticsearchBufferingHints
        {
            /// <summary>
            /// IntervalInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-elasticsearchbufferinghints.html#cfn-kinesisfirehose-deliverystream-elasticsearchbufferinghints-intervalinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic IntervalInSeconds { get; set; }
            /// <summary>
            /// SizeInMBs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-elasticsearchbufferinghints.html#cfn-kinesisfirehose-deliverystream-elasticsearchbufferinghints-sizeinmbs
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic SizeInMBs { get; set; }
        }

        public class ElasticsearchDestinationConfiguration
        {
            /// <summary>
            /// TypeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration-typename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TypeName { get; set; }
            /// <summary>
            /// IndexRotationPeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration-indexrotationperiod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IndexRotationPeriod { get; set; }
            /// <summary>
            /// ProcessingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration-processingconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ProcessingConfiguration
            /// </summary>
            public ProcessingConfiguration ProcessingConfiguration { get; set; }
            /// <summary>
            /// ClusterEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration-clusterendpoint
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClusterEndpoint { get; set; }
            /// <summary>
            /// DomainARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration-domainarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DomainARN { get; set; }
            /// <summary>
            /// RoleARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleARN { get; set; }
            /// <summary>
            /// S3BackupMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration-s3backupmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3BackupMode { get; set; }
            /// <summary>
            /// IndexName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration-indexname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IndexName { get; set; }
            /// <summary>
            /// DocumentIdOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration-documentidoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DocumentIdOptions
            /// </summary>
            public DocumentIdOptions DocumentIdOptions { get; set; }
            /// <summary>
            /// S3Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration-s3configuration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: S3DestinationConfiguration
            /// </summary>
            public S3DestinationConfiguration S3Configuration { get; set; }
            /// <summary>
            /// BufferingHints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration-bufferinghints
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ElasticsearchBufferingHints
            /// </summary>
            public ElasticsearchBufferingHints BufferingHints { get; set; }
            /// <summary>
            /// RetryOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration-retryoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ElasticsearchRetryOptions
            /// </summary>
            public ElasticsearchRetryOptions RetryOptions { get; set; }
            /// <summary>
            /// VpcConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration-vpcconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: VpcConfiguration
            /// </summary>
            public VpcConfiguration VpcConfiguration { get; set; }
            /// <summary>
            /// CloudWatchLoggingOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration-cloudwatchloggingoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudWatchLoggingOptions
            /// </summary>
            public CloudWatchLoggingOptions CloudWatchLoggingOptions { get; set; }
        }

        public class ElasticsearchRetryOptions
        {
            /// <summary>
            /// DurationInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-elasticsearchretryoptions.html#cfn-kinesisfirehose-deliverystream-elasticsearchretryoptions-durationinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DurationInSeconds { get; set; }
        }

        public class EncryptionConfiguration
        {
            /// <summary>
            /// KMSEncryptionConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-encryptionconfiguration.html#cfn-kinesisfirehose-deliverystream-encryptionconfiguration-kmsencryptionconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KMSEncryptionConfig
            /// </summary>
            public KMSEncryptionConfig KMSEncryptionConfig { get; set; }
            /// <summary>
            /// NoEncryptionConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-encryptionconfiguration.html#cfn-kinesisfirehose-deliverystream-encryptionconfiguration-noencryptionconfig
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NoEncryptionConfig { get; set; }
        }

        public class ExtendedS3DestinationConfiguration
        {
            /// <summary>
            /// ErrorOutputPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-extendeds3destinationconfiguration.html#cfn-kinesisfirehose-deliverystream-extendeds3destinationconfiguration-erroroutputprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ErrorOutputPrefix { get; set; }
            /// <summary>
            /// S3BackupConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-extendeds3destinationconfiguration.html#cfn-kinesisfirehose-deliverystream-extendeds3destinationconfiguration-s3backupconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3DestinationConfiguration
            /// </summary>
            public S3DestinationConfiguration S3BackupConfiguration { get; set; }
            /// <summary>
            /// BucketARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-extendeds3destinationconfiguration.html#cfn-kinesisfirehose-deliverystream-extendeds3destinationconfiguration-bucketarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketARN { get; set; }
            /// <summary>
            /// CompressionFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-extendeds3destinationconfiguration.html#cfn-kinesisfirehose-deliverystream-extendeds3destinationconfiguration-compressionformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CompressionFormat { get; set; }
            /// <summary>
            /// DataFormatConversionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-extendeds3destinationconfiguration.html#cfn-kinesisfirehose-deliverystream-extendeds3destinationconfiguration-dataformatconversionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataFormatConversionConfiguration
            /// </summary>
            public DataFormatConversionConfiguration DataFormatConversionConfiguration { get; set; }
            /// <summary>
            /// EncryptionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-extendeds3destinationconfiguration.html#cfn-kinesisfirehose-deliverystream-extendeds3destinationconfiguration-encryptionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EncryptionConfiguration
            /// </summary>
            public EncryptionConfiguration EncryptionConfiguration { get; set; }
            /// <summary>
            /// CustomTimeZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-extendeds3destinationconfiguration.html#cfn-kinesisfirehose-deliverystream-extendeds3destinationconfiguration-customtimezone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomTimeZone { get; set; }
            /// <summary>
            /// DynamicPartitioningConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-extendeds3destinationconfiguration.html#cfn-kinesisfirehose-deliverystream-extendeds3destinationconfiguration-dynamicpartitioningconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DynamicPartitioningConfiguration
            /// </summary>
            public DynamicPartitioningConfiguration DynamicPartitioningConfiguration { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-extendeds3destinationconfiguration.html#cfn-kinesisfirehose-deliverystream-extendeds3destinationconfiguration-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix { get; set; }
            /// <summary>
            /// ProcessingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-extendeds3destinationconfiguration.html#cfn-kinesisfirehose-deliverystream-extendeds3destinationconfiguration-processingconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ProcessingConfiguration
            /// </summary>
            public ProcessingConfiguration ProcessingConfiguration { get; set; }
            /// <summary>
            /// RoleARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-extendeds3destinationconfiguration.html#cfn-kinesisfirehose-deliverystream-extendeds3destinationconfiguration-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleARN { get; set; }
            /// <summary>
            /// S3BackupMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-extendeds3destinationconfiguration.html#cfn-kinesisfirehose-deliverystream-extendeds3destinationconfiguration-s3backupmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3BackupMode { get; set; }
            /// <summary>
            /// BufferingHints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-extendeds3destinationconfiguration.html#cfn-kinesisfirehose-deliverystream-extendeds3destinationconfiguration-bufferinghints
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BufferingHints
            /// </summary>
            public BufferingHints BufferingHints { get; set; }
            /// <summary>
            /// FileExtension
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-extendeds3destinationconfiguration.html#cfn-kinesisfirehose-deliverystream-extendeds3destinationconfiguration-fileextension
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FileExtension { get; set; }
            /// <summary>
            /// CloudWatchLoggingOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-extendeds3destinationconfiguration.html#cfn-kinesisfirehose-deliverystream-extendeds3destinationconfiguration-cloudwatchloggingoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudWatchLoggingOptions
            /// </summary>
            public CloudWatchLoggingOptions CloudWatchLoggingOptions { get; set; }
        }

        public class HiveJsonSerDe
        {
            /// <summary>
            /// TimestampFormats
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-hivejsonserde.html#cfn-kinesisfirehose-deliverystream-hivejsonserde-timestampformats
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic TimestampFormats { get; set; }
        }

        public class HttpEndpointCommonAttribute
        {
            /// <summary>
            /// AttributeValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-httpendpointcommonattribute.html#cfn-kinesisfirehose-deliverystream-httpendpointcommonattribute-attributevalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AttributeValue { get; set; }
            /// <summary>
            /// AttributeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-httpendpointcommonattribute.html#cfn-kinesisfirehose-deliverystream-httpendpointcommonattribute-attributename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AttributeName { get; set; }
        }

        public class HttpEndpointConfiguration
        {
            /// <summary>
            /// AccessKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-httpendpointconfiguration.html#cfn-kinesisfirehose-deliverystream-httpendpointconfiguration-accesskey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AccessKey { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-httpendpointconfiguration.html#cfn-kinesisfirehose-deliverystream-httpendpointconfiguration-url
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Url { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-httpendpointconfiguration.html#cfn-kinesisfirehose-deliverystream-httpendpointconfiguration-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class HttpEndpointDestinationConfiguration
        {
            /// <summary>
            /// RequestConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-httpendpointdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-httpendpointdestinationconfiguration-requestconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpEndpointRequestConfiguration
            /// </summary>
            public HttpEndpointRequestConfiguration RequestConfiguration { get; set; }
            /// <summary>
            /// S3Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-httpendpointdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-httpendpointdestinationconfiguration-s3configuration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: S3DestinationConfiguration
            /// </summary>
            public S3DestinationConfiguration S3Configuration { get; set; }
            /// <summary>
            /// BufferingHints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-httpendpointdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-httpendpointdestinationconfiguration-bufferinghints
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BufferingHints
            /// </summary>
            public BufferingHints BufferingHints { get; set; }
            /// <summary>
            /// RetryOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-httpendpointdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-httpendpointdestinationconfiguration-retryoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RetryOptions
            /// </summary>
            public RetryOptions RetryOptions { get; set; }
            /// <summary>
            /// SecretsManagerConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-httpendpointdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-httpendpointdestinationconfiguration-secretsmanagerconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecretsManagerConfiguration
            /// </summary>
            public SecretsManagerConfiguration SecretsManagerConfiguration { get; set; }
            /// <summary>
            /// EndpointConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-httpendpointdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-httpendpointdestinationconfiguration-endpointconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: HttpEndpointConfiguration
            /// </summary>
            public HttpEndpointConfiguration EndpointConfiguration { get; set; }
            /// <summary>
            /// ProcessingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-httpendpointdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-httpendpointdestinationconfiguration-processingconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ProcessingConfiguration
            /// </summary>
            public ProcessingConfiguration ProcessingConfiguration { get; set; }
            /// <summary>
            /// RoleARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-httpendpointdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-httpendpointdestinationconfiguration-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleARN { get; set; }
            /// <summary>
            /// CloudWatchLoggingOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-httpendpointdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-httpendpointdestinationconfiguration-cloudwatchloggingoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudWatchLoggingOptions
            /// </summary>
            public CloudWatchLoggingOptions CloudWatchLoggingOptions { get; set; }
            /// <summary>
            /// S3BackupMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-httpendpointdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-httpendpointdestinationconfiguration-s3backupmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3BackupMode { get; set; }
        }

        public class HttpEndpointRequestConfiguration
        {
            /// <summary>
            /// CommonAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-httpendpointrequestconfiguration.html#cfn-kinesisfirehose-deliverystream-httpendpointrequestconfiguration-commonattributes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: HttpEndpointCommonAttribute
            /// </summary>
            public List<HttpEndpointCommonAttribute> CommonAttributes { get; set; }
            /// <summary>
            /// ContentEncoding
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-httpendpointrequestconfiguration.html#cfn-kinesisfirehose-deliverystream-httpendpointrequestconfiguration-contentencoding
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentEncoding { get; set; }
        }

        public class InputFormatConfiguration
        {
            /// <summary>
            /// Deserializer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-inputformatconfiguration.html#cfn-kinesisfirehose-deliverystream-inputformatconfiguration-deserializer
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Deserializer
            /// </summary>
            public Deserializer Deserializer { get; set; }
        }

        public class KMSEncryptionConfig
        {
            /// <summary>
            /// AWSKMSKeyARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-kmsencryptionconfig.html#cfn-kinesisfirehose-deliverystream-kmsencryptionconfig-awskmskeyarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AWSKMSKeyARN { get; set; }
        }

        public class KinesisStreamSourceConfiguration
        {
            /// <summary>
            /// KinesisStreamARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-kinesisstreamsourceconfiguration.html#cfn-kinesisfirehose-deliverystream-kinesisstreamsourceconfiguration-kinesisstreamarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KinesisStreamARN { get; set; }
            /// <summary>
            /// RoleARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-kinesisstreamsourceconfiguration.html#cfn-kinesisfirehose-deliverystream-kinesisstreamsourceconfiguration-rolearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleARN { get; set; }
        }

        public class MSKSourceConfiguration
        {
            /// <summary>
            /// AuthenticationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-msksourceconfiguration.html#cfn-kinesisfirehose-deliverystream-msksourceconfiguration-authenticationconfiguration
            /// Required: True
            /// UpdateType: Immutable
            /// Type: AuthenticationConfiguration
            /// </summary>
            public AuthenticationConfiguration AuthenticationConfiguration { get; set; }
            /// <summary>
            /// MSKClusterARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-msksourceconfiguration.html#cfn-kinesisfirehose-deliverystream-msksourceconfiguration-mskclusterarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MSKClusterARN { get; set; }
            /// <summary>
            /// TopicName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-msksourceconfiguration.html#cfn-kinesisfirehose-deliverystream-msksourceconfiguration-topicname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TopicName { get; set; }
        }

        public class OpenXJsonSerDe
        {
            /// <summary>
            /// ConvertDotsInJsonKeysToUnderscores
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-openxjsonserde.html#cfn-kinesisfirehose-deliverystream-openxjsonserde-convertdotsinjsonkeystounderscores
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ConvertDotsInJsonKeysToUnderscores { get; set; }
            /// <summary>
            /// ColumnToJsonKeyMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-openxjsonserde.html#cfn-kinesisfirehose-deliverystream-openxjsonserde-columntojsonkeymappings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> ColumnToJsonKeyMappings { get; set; }
            /// <summary>
            /// CaseInsensitive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-openxjsonserde.html#cfn-kinesisfirehose-deliverystream-openxjsonserde-caseinsensitive
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic CaseInsensitive { get; set; }
        }

        public class OrcSerDe
        {
            /// <summary>
            /// PaddingTolerance
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-orcserde.html#cfn-kinesisfirehose-deliverystream-orcserde-paddingtolerance
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic PaddingTolerance { get; set; }
            /// <summary>
            /// Compression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-orcserde.html#cfn-kinesisfirehose-deliverystream-orcserde-compression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Compression { get; set; }
            /// <summary>
            /// StripeSizeBytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-orcserde.html#cfn-kinesisfirehose-deliverystream-orcserde-stripesizebytes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic StripeSizeBytes { get; set; }
            /// <summary>
            /// BloomFilterColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-orcserde.html#cfn-kinesisfirehose-deliverystream-orcserde-bloomfiltercolumns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic BloomFilterColumns { get; set; }
            /// <summary>
            /// BloomFilterFalsePositiveProbability
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-orcserde.html#cfn-kinesisfirehose-deliverystream-orcserde-bloomfilterfalsepositiveprobability
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic BloomFilterFalsePositiveProbability { get; set; }
            /// <summary>
            /// EnablePadding
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-orcserde.html#cfn-kinesisfirehose-deliverystream-orcserde-enablepadding
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EnablePadding { get; set; }
            /// <summary>
            /// FormatVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-orcserde.html#cfn-kinesisfirehose-deliverystream-orcserde-formatversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FormatVersion { get; set; }
            /// <summary>
            /// RowIndexStride
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-orcserde.html#cfn-kinesisfirehose-deliverystream-orcserde-rowindexstride
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RowIndexStride { get; set; }
            /// <summary>
            /// BlockSizeBytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-orcserde.html#cfn-kinesisfirehose-deliverystream-orcserde-blocksizebytes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic BlockSizeBytes { get; set; }
            /// <summary>
            /// DictionaryKeyThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-orcserde.html#cfn-kinesisfirehose-deliverystream-orcserde-dictionarykeythreshold
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic DictionaryKeyThreshold { get; set; }
        }

        public class OutputFormatConfiguration
        {
            /// <summary>
            /// Serializer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-outputformatconfiguration.html#cfn-kinesisfirehose-deliverystream-outputformatconfiguration-serializer
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Serializer
            /// </summary>
            public Serializer Serializer { get; set; }
        }

        public class ParquetSerDe
        {
            /// <summary>
            /// Compression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-parquetserde.html#cfn-kinesisfirehose-deliverystream-parquetserde-compression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Compression { get; set; }
            /// <summary>
            /// BlockSizeBytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-parquetserde.html#cfn-kinesisfirehose-deliverystream-parquetserde-blocksizebytes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic BlockSizeBytes { get; set; }
            /// <summary>
            /// EnableDictionaryCompression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-parquetserde.html#cfn-kinesisfirehose-deliverystream-parquetserde-enabledictionarycompression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EnableDictionaryCompression { get; set; }
            /// <summary>
            /// PageSizeBytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-parquetserde.html#cfn-kinesisfirehose-deliverystream-parquetserde-pagesizebytes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic PageSizeBytes { get; set; }
            /// <summary>
            /// MaxPaddingBytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-parquetserde.html#cfn-kinesisfirehose-deliverystream-parquetserde-maxpaddingbytes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxPaddingBytes { get; set; }
            /// <summary>
            /// WriterVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-parquetserde.html#cfn-kinesisfirehose-deliverystream-parquetserde-writerversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WriterVersion { get; set; }
        }

        public class ProcessingConfiguration
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-processingconfiguration.html#cfn-kinesisfirehose-deliverystream-processingconfiguration-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
            /// <summary>
            /// Processors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-processingconfiguration.html#cfn-kinesisfirehose-deliverystream-processingconfiguration-processors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Processor
            /// </summary>
            public List<Processor> Processors { get; set; }
        }

        public class Processor
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-processor.html#cfn-kinesisfirehose-deliverystream-processor-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-processor.html#cfn-kinesisfirehose-deliverystream-processor-parameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ProcessorParameter
            /// </summary>
            public List<ProcessorParameter> Parameters { get; set; }
        }

        public class ProcessorParameter
        {
            /// <summary>
            /// ParameterValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-processorparameter.html#cfn-kinesisfirehose-deliverystream-processorparameter-parametervalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterValue { get; set; }
            /// <summary>
            /// ParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-processorparameter.html#cfn-kinesisfirehose-deliverystream-processorparameter-parametername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterName { get; set; }
        }

        public class RedshiftDestinationConfiguration
        {
            /// <summary>
            /// S3BackupConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-redshiftdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-redshiftdestinationconfiguration-s3backupconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3DestinationConfiguration
            /// </summary>
            public S3DestinationConfiguration S3BackupConfiguration { get; set; }
            /// <summary>
            /// S3Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-redshiftdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-redshiftdestinationconfiguration-s3configuration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: S3DestinationConfiguration
            /// </summary>
            public S3DestinationConfiguration S3Configuration { get; set; }
            /// <summary>
            /// Username
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-redshiftdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-redshiftdestinationconfiguration-username
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Username { get; set; }
            /// <summary>
            /// CopyCommand
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-redshiftdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-redshiftdestinationconfiguration-copycommand
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CopyCommand
            /// </summary>
            public CopyCommand CopyCommand { get; set; }
            /// <summary>
            /// RetryOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-redshiftdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-redshiftdestinationconfiguration-retryoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RedshiftRetryOptions
            /// </summary>
            public RedshiftRetryOptions RetryOptions { get; set; }
            /// <summary>
            /// SecretsManagerConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-redshiftdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-redshiftdestinationconfiguration-secretsmanagerconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecretsManagerConfiguration
            /// </summary>
            public SecretsManagerConfiguration SecretsManagerConfiguration { get; set; }
            /// <summary>
            /// ProcessingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-redshiftdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-redshiftdestinationconfiguration-processingconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ProcessingConfiguration
            /// </summary>
            public ProcessingConfiguration ProcessingConfiguration { get; set; }
            /// <summary>
            /// CloudWatchLoggingOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-redshiftdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-redshiftdestinationconfiguration-cloudwatchloggingoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudWatchLoggingOptions
            /// </summary>
            public CloudWatchLoggingOptions CloudWatchLoggingOptions { get; set; }
            /// <summary>
            /// ClusterJDBCURL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-redshiftdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-redshiftdestinationconfiguration-clusterjdbcurl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClusterJDBCURL { get; set; }
            /// <summary>
            /// RoleARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-redshiftdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-redshiftdestinationconfiguration-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleARN { get; set; }
            /// <summary>
            /// Password
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-redshiftdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-redshiftdestinationconfiguration-password
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Password { get; set; }
            /// <summary>
            /// S3BackupMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-redshiftdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-redshiftdestinationconfiguration-s3backupmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3BackupMode { get; set; }
        }

        public class RedshiftRetryOptions
        {
            /// <summary>
            /// DurationInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-redshiftretryoptions.html#cfn-kinesisfirehose-deliverystream-redshiftretryoptions-durationinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DurationInSeconds { get; set; }
        }

        public class RetryOptions
        {
            /// <summary>
            /// DurationInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-retryoptions.html#cfn-kinesisfirehose-deliverystream-retryoptions-durationinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DurationInSeconds { get; set; }
        }

        public class S3DestinationConfiguration
        {
            /// <summary>
            /// ErrorOutputPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-s3destinationconfiguration.html#cfn-kinesisfirehose-deliverystream-s3destinationconfiguration-erroroutputprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ErrorOutputPrefix { get; set; }
            /// <summary>
            /// BucketARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-s3destinationconfiguration.html#cfn-kinesisfirehose-deliverystream-s3destinationconfiguration-bucketarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketARN { get; set; }
            /// <summary>
            /// BufferingHints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-s3destinationconfiguration.html#cfn-kinesisfirehose-deliverystream-s3destinationconfiguration-bufferinghints
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BufferingHints
            /// </summary>
            public BufferingHints BufferingHints { get; set; }
            /// <summary>
            /// CompressionFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-s3destinationconfiguration.html#cfn-kinesisfirehose-deliverystream-s3destinationconfiguration-compressionformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CompressionFormat { get; set; }
            /// <summary>
            /// EncryptionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-s3destinationconfiguration.html#cfn-kinesisfirehose-deliverystream-s3destinationconfiguration-encryptionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EncryptionConfiguration
            /// </summary>
            public EncryptionConfiguration EncryptionConfiguration { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-s3destinationconfiguration.html#cfn-kinesisfirehose-deliverystream-s3destinationconfiguration-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix { get; set; }
            /// <summary>
            /// CloudWatchLoggingOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-s3destinationconfiguration.html#cfn-kinesisfirehose-deliverystream-s3destinationconfiguration-cloudwatchloggingoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudWatchLoggingOptions
            /// </summary>
            public CloudWatchLoggingOptions CloudWatchLoggingOptions { get; set; }
            /// <summary>
            /// RoleARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-s3destinationconfiguration.html#cfn-kinesisfirehose-deliverystream-s3destinationconfiguration-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleARN { get; set; }
        }

        public class SchemaConfiguration
        {
            /// <summary>
            /// VersionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-schemaconfiguration.html#cfn-kinesisfirehose-deliverystream-schemaconfiguration-versionid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VersionId { get; set; }
            /// <summary>
            /// TableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-schemaconfiguration.html#cfn-kinesisfirehose-deliverystream-schemaconfiguration-tablename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TableName { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-schemaconfiguration.html#cfn-kinesisfirehose-deliverystream-schemaconfiguration-databasename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DatabaseName { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-schemaconfiguration.html#cfn-kinesisfirehose-deliverystream-schemaconfiguration-region
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Region { get; set; }
            /// <summary>
            /// CatalogId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-schemaconfiguration.html#cfn-kinesisfirehose-deliverystream-schemaconfiguration-catalogid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CatalogId { get; set; }
            /// <summary>
            /// RoleARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-schemaconfiguration.html#cfn-kinesisfirehose-deliverystream-schemaconfiguration-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleARN { get; set; }
        }

        public class SecretsManagerConfiguration
        {
            /// <summary>
            /// SecretARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-secretsmanagerconfiguration.html#cfn-kinesisfirehose-deliverystream-secretsmanagerconfiguration-secretarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecretARN { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-secretsmanagerconfiguration.html#cfn-kinesisfirehose-deliverystream-secretsmanagerconfiguration-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
            /// <summary>
            /// RoleARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-secretsmanagerconfiguration.html#cfn-kinesisfirehose-deliverystream-secretsmanagerconfiguration-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleARN { get; set; }
        }

        public class Serializer
        {
            /// <summary>
            /// OrcSerDe
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-serializer.html#cfn-kinesisfirehose-deliverystream-serializer-orcserde
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OrcSerDe
            /// </summary>
            public OrcSerDe OrcSerDe { get; set; }
            /// <summary>
            /// ParquetSerDe
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-serializer.html#cfn-kinesisfirehose-deliverystream-serializer-parquetserde
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParquetSerDe
            /// </summary>
            public ParquetSerDe ParquetSerDe { get; set; }
        }

        public class SnowflakeDestinationConfiguration
        {
            /// <summary>
            /// PrivateKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-snowflakedestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-snowflakedestinationconfiguration-privatekey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PrivateKey { get; set; }
            /// <summary>
            /// User
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-snowflakedestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-snowflakedestinationconfiguration-user
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic User { get; set; }
            /// <summary>
            /// Table
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-snowflakedestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-snowflakedestinationconfiguration-table
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Table { get; set; }
            /// <summary>
            /// SnowflakeVpcConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-snowflakedestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-snowflakedestinationconfiguration-snowflakevpcconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SnowflakeVpcConfiguration
            /// </summary>
            public SnowflakeVpcConfiguration SnowflakeVpcConfiguration { get; set; }
            /// <summary>
            /// DataLoadingOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-snowflakedestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-snowflakedestinationconfiguration-dataloadingoption
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataLoadingOption { get; set; }
            /// <summary>
            /// Schema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-snowflakedestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-snowflakedestinationconfiguration-schema
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Schema { get; set; }
            /// <summary>
            /// ContentColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-snowflakedestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-snowflakedestinationconfiguration-contentcolumnname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentColumnName { get; set; }
            /// <summary>
            /// SecretsManagerConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-snowflakedestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-snowflakedestinationconfiguration-secretsmanagerconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecretsManagerConfiguration
            /// </summary>
            public SecretsManagerConfiguration SecretsManagerConfiguration { get; set; }
            /// <summary>
            /// SnowflakeRoleConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-snowflakedestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-snowflakedestinationconfiguration-snowflakeroleconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SnowflakeRoleConfiguration
            /// </summary>
            public SnowflakeRoleConfiguration SnowflakeRoleConfiguration { get; set; }
            /// <summary>
            /// ProcessingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-snowflakedestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-snowflakedestinationconfiguration-processingconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ProcessingConfiguration
            /// </summary>
            public ProcessingConfiguration ProcessingConfiguration { get; set; }
            /// <summary>
            /// AccountUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-snowflakedestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-snowflakedestinationconfiguration-accounturl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AccountUrl { get; set; }
            /// <summary>
            /// RoleARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-snowflakedestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-snowflakedestinationconfiguration-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleARN { get; set; }
            /// <summary>
            /// S3BackupMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-snowflakedestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-snowflakedestinationconfiguration-s3backupmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3BackupMode { get; set; }
            /// <summary>
            /// S3Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-snowflakedestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-snowflakedestinationconfiguration-s3configuration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: S3DestinationConfiguration
            /// </summary>
            public S3DestinationConfiguration S3Configuration { get; set; }
            /// <summary>
            /// MetaDataColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-snowflakedestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-snowflakedestinationconfiguration-metadatacolumnname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MetaDataColumnName { get; set; }
            /// <summary>
            /// Database
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-snowflakedestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-snowflakedestinationconfiguration-database
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Database { get; set; }
            /// <summary>
            /// RetryOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-snowflakedestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-snowflakedestinationconfiguration-retryoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SnowflakeRetryOptions
            /// </summary>
            public SnowflakeRetryOptions RetryOptions { get; set; }
            /// <summary>
            /// KeyPassphrase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-snowflakedestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-snowflakedestinationconfiguration-keypassphrase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KeyPassphrase { get; set; }
            /// <summary>
            /// CloudWatchLoggingOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-snowflakedestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-snowflakedestinationconfiguration-cloudwatchloggingoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudWatchLoggingOptions
            /// </summary>
            public CloudWatchLoggingOptions CloudWatchLoggingOptions { get; set; }
        }

        public class SnowflakeRetryOptions
        {
            /// <summary>
            /// DurationInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-snowflakeretryoptions.html#cfn-kinesisfirehose-deliverystream-snowflakeretryoptions-durationinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DurationInSeconds { get; set; }
        }

        public class SnowflakeRoleConfiguration
        {
            /// <summary>
            /// SnowflakeRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-snowflakeroleconfiguration.html#cfn-kinesisfirehose-deliverystream-snowflakeroleconfiguration-snowflakerole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SnowflakeRole { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-snowflakeroleconfiguration.html#cfn-kinesisfirehose-deliverystream-snowflakeroleconfiguration-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
        }

        public class SnowflakeVpcConfiguration
        {
            /// <summary>
            /// PrivateLinkVpceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-snowflakevpcconfiguration.html#cfn-kinesisfirehose-deliverystream-snowflakevpcconfiguration-privatelinkvpceid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PrivateLinkVpceId { get; set; }
        }

        public class SplunkBufferingHints
        {
            /// <summary>
            /// IntervalInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-splunkbufferinghints.html#cfn-kinesisfirehose-deliverystream-splunkbufferinghints-intervalinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic IntervalInSeconds { get; set; }
            /// <summary>
            /// SizeInMBs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-splunkbufferinghints.html#cfn-kinesisfirehose-deliverystream-splunkbufferinghints-sizeinmbs
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic SizeInMBs { get; set; }
        }

        public class SplunkDestinationConfiguration
        {
            /// <summary>
            /// HECEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-splunkdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-splunkdestinationconfiguration-hecendpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HECEndpoint { get; set; }
            /// <summary>
            /// S3Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-splunkdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-splunkdestinationconfiguration-s3configuration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: S3DestinationConfiguration
            /// </summary>
            public S3DestinationConfiguration S3Configuration { get; set; }
            /// <summary>
            /// BufferingHints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-splunkdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-splunkdestinationconfiguration-bufferinghints
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SplunkBufferingHints
            /// </summary>
            public SplunkBufferingHints BufferingHints { get; set; }
            /// <summary>
            /// HECToken
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-splunkdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-splunkdestinationconfiguration-hectoken
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HECToken { get; set; }
            /// <summary>
            /// RetryOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-splunkdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-splunkdestinationconfiguration-retryoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SplunkRetryOptions
            /// </summary>
            public SplunkRetryOptions RetryOptions { get; set; }
            /// <summary>
            /// HECEndpointType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-splunkdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-splunkdestinationconfiguration-hecendpointtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HECEndpointType { get; set; }
            /// <summary>
            /// SecretsManagerConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-splunkdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-splunkdestinationconfiguration-secretsmanagerconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecretsManagerConfiguration
            /// </summary>
            public SecretsManagerConfiguration SecretsManagerConfiguration { get; set; }
            /// <summary>
            /// HECAcknowledgmentTimeoutInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-splunkdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-splunkdestinationconfiguration-hecacknowledgmenttimeoutinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic HECAcknowledgmentTimeoutInSeconds { get; set; }
            /// <summary>
            /// ProcessingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-splunkdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-splunkdestinationconfiguration-processingconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ProcessingConfiguration
            /// </summary>
            public ProcessingConfiguration ProcessingConfiguration { get; set; }
            /// <summary>
            /// CloudWatchLoggingOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-splunkdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-splunkdestinationconfiguration-cloudwatchloggingoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudWatchLoggingOptions
            /// </summary>
            public CloudWatchLoggingOptions CloudWatchLoggingOptions { get; set; }
            /// <summary>
            /// S3BackupMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-splunkdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-splunkdestinationconfiguration-s3backupmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3BackupMode { get; set; }
        }

        public class SplunkRetryOptions
        {
            /// <summary>
            /// DurationInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-splunkretryoptions.html#cfn-kinesisfirehose-deliverystream-splunkretryoptions-durationinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DurationInSeconds { get; set; }
        }

        public class VpcConfiguration
        {
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-vpcconfiguration.html#cfn-kinesisfirehose-deliverystream-vpcconfiguration-subnetids
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SubnetIds { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-vpcconfiguration.html#cfn-kinesisfirehose-deliverystream-vpcconfiguration-securitygroupids
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroupIds { get; set; }
            /// <summary>
            /// RoleARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-vpcconfiguration.html#cfn-kinesisfirehose-deliverystream-vpcconfiguration-rolearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleARN { get; set; }
        }
    }
}