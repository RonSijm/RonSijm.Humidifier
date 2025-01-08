namespace Humidifier.Cognito
{
    using System.Collections.Generic;
    using LogDeliveryConfigurationTypes;

    public class LogDeliveryConfiguration : Humidifier.Base.BaseResource, IHaveUserPoolId
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.Cognito.LogDeliveryConfiguration; }

        /// <summary>
        /// UserPoolId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-logdeliveryconfiguration.html#cfn-cognito-logdeliveryconfiguration-userpoolid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic UserPoolId { get; set; }
        /// <summary>
        /// LogConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-logdeliveryconfiguration.html#cfn-cognito-logdeliveryconfiguration-logconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: LogConfiguration
        /// </summary>
        public List<Humidifier.Cognito.LogDeliveryConfigurationTypes.LogConfiguration> LogConfigurations { get; set; }
    }

    namespace LogDeliveryConfigurationTypes
    {
        public class CloudWatchLogsConfiguration : Humidifier.Base.BaseSubResource, IHaveLogGroupArn
        {
            /// <summary>
            /// LogGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-logdeliveryconfiguration-cloudwatchlogsconfiguration.html#cfn-cognito-logdeliveryconfiguration-cloudwatchlogsconfiguration-loggrouparn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogGroupArn { get; set; }
        }

        public class FirehoseConfiguration : Humidifier.Base.BaseSubResource, IHaveStreamArn
        {
            /// <summary>
            /// StreamArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-logdeliveryconfiguration-firehoseconfiguration.html#cfn-cognito-logdeliveryconfiguration-firehoseconfiguration-streamarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StreamArn { get; set; }
        }

        public class LogConfiguration : Humidifier.Base.BaseSubResource, IHaveLogLevel, IHaveEventSource
        {
            /// <summary>
            /// FirehoseConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-logdeliveryconfiguration-logconfiguration.html#cfn-cognito-logdeliveryconfiguration-logconfiguration-firehoseconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FirehoseConfiguration
            /// </summary>
            public Humidifier.Cognito.LogDeliveryConfigurationTypes.FirehoseConfiguration FirehoseConfiguration { get; set; }
            /// <summary>
            /// EventSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-logdeliveryconfiguration-logconfiguration.html#cfn-cognito-logdeliveryconfiguration-logconfiguration-eventsource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EventSource { get; set; }
            /// <summary>
            /// S3Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-logdeliveryconfiguration-logconfiguration.html#cfn-cognito-logdeliveryconfiguration-logconfiguration-s3configuration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Configuration
            /// </summary>
            public Humidifier.Cognito.LogDeliveryConfigurationTypes.S3Configuration S3Configuration { get; set; }
            /// <summary>
            /// CloudWatchLogsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-logdeliveryconfiguration-logconfiguration.html#cfn-cognito-logdeliveryconfiguration-logconfiguration-cloudwatchlogsconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudWatchLogsConfiguration
            /// </summary>
            public Humidifier.Cognito.LogDeliveryConfigurationTypes.CloudWatchLogsConfiguration CloudWatchLogsConfiguration { get; set; }
            /// <summary>
            /// LogLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-logdeliveryconfiguration-logconfiguration.html#cfn-cognito-logdeliveryconfiguration-logconfiguration-loglevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogLevel { get; set; }
        }

        public class S3Configuration : Humidifier.Base.BaseSubResource, IHaveBucketArn
        {
            /// <summary>
            /// BucketArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-logdeliveryconfiguration-s3configuration.html#cfn-cognito-logdeliveryconfiguration-s3configuration-bucketarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketArn { get; set; }
        }
    }
}