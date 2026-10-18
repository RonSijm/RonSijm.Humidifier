namespace Humidifier.IVSChat
{
    using global::System.Collections.Generic;
    using LoggingConfigurationTypes;

    public class LoggingConfiguration : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveIVSChatLoggingConfigurationTypesDestinationConfigurationDestinationConfiguration, IHaveName
    {
        public class Attributes
        {
            public static string State =  "State" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.IVSChat.LoggingConfiguration; }

        /// <summary>
        /// DestinationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ivschat-loggingconfiguration.html#cfn-ivschat-loggingconfiguration-destinationconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: DestinationConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.IVSChat.LoggingConfigurationTypes.DestinationConfiguration, BaseFunction>? DestinationConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ivschat-loggingconfiguration.html#cfn-ivschat-loggingconfiguration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace LoggingConfigurationTypes
    {
        public class CloudWatchLogsDestinationConfiguration : Humidifier.Base.BaseSubResource, IHaveLogGroupName
        {
            /// <summary>
            /// LogGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivschat-loggingconfiguration-cloudwatchlogsdestinationconfiguration.html#cfn-ivschat-loggingconfiguration-cloudwatchlogsdestinationconfiguration-loggroupname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogGroupName { get; set; }
        }

        public class DestinationConfiguration : Humidifier.Base.BaseSubResource, IHaveIVSChatLoggingConfigurationTypesS3DestinationConfigurationS3, IHaveIVSChatLoggingConfigurationTypesFirehoseDestinationConfigurationFirehose, IHaveIVSChatLoggingConfigurationTypesCloudWatchLogsDestinationConfigurationCloudWatchLogs
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivschat-loggingconfiguration-destinationconfiguration.html#cfn-ivschat-loggingconfiguration-destinationconfiguration-s3
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3DestinationConfiguration
            /// </summary>
            public Union<Humidifier.IVSChat.LoggingConfigurationTypes.S3DestinationConfiguration, BaseFunction>? S3 { get; set; }
            /// <summary>
            /// Firehose
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivschat-loggingconfiguration-destinationconfiguration.html#cfn-ivschat-loggingconfiguration-destinationconfiguration-firehose
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FirehoseDestinationConfiguration
            /// </summary>
            public Union<Humidifier.IVSChat.LoggingConfigurationTypes.FirehoseDestinationConfiguration, BaseFunction>? Firehose { get; set; }
            /// <summary>
            /// CloudWatchLogs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivschat-loggingconfiguration-destinationconfiguration.html#cfn-ivschat-loggingconfiguration-destinationconfiguration-cloudwatchlogs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudWatchLogsDestinationConfiguration
            /// </summary>
            public Union<Humidifier.IVSChat.LoggingConfigurationTypes.CloudWatchLogsDestinationConfiguration, BaseFunction>? CloudWatchLogs { get; set; }
        }

        public class FirehoseDestinationConfiguration : Humidifier.Base.BaseSubResource, IHaveDeliveryStreamName
        {
            /// <summary>
            /// DeliveryStreamName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivschat-loggingconfiguration-firehosedestinationconfiguration.html#cfn-ivschat-loggingconfiguration-firehosedestinationconfiguration-deliverystreamname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeliveryStreamName { get; set; }
        }

        public class S3DestinationConfiguration : Humidifier.Base.BaseSubResource, IHaveBucketName
        {
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivschat-loggingconfiguration-s3destinationconfiguration.html#cfn-ivschat-loggingconfiguration-s3destinationconfiguration-bucketname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketName { get; set; }
        }
    }
}