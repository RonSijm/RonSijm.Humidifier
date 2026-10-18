namespace Humidifier.Cognito
{
    using global::System.Collections.Generic;
    using LogDeliveryConfigurationTypes;

    public class LogDeliveryConfiguration : Humidifier.Base.BaseResource, IHaveUserPoolId, IHaveListOfCognitoLogDeliveryConfigurationTypesLogConfigurationLogConfigurations
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
        public Union<string, BaseFunction>? UserPoolId { get; set; }
        /// <summary>
        /// LogConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-logdeliveryconfiguration.html#cfn-cognito-logdeliveryconfiguration-logconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: LogConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Cognito.LogDeliveryConfigurationTypes.LogConfiguration>, IReadOnlyList<Union<Humidifier.Cognito.LogDeliveryConfigurationTypes.LogConfiguration, BaseFunction>>, BaseFunction>? LogConfigurations { get; set; }
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
            public Union<string, BaseFunction>? LogGroupArn { get; set; }
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
            public Union<string, BaseFunction>? StreamArn { get; set; }
        }

        public class LogConfiguration : Humidifier.Base.BaseSubResource, IHaveCognitoLogDeliveryConfigurationTypesFirehoseConfigurationFirehoseConfiguration, IHaveEventSource, IHaveCognitoLogDeliveryConfigurationTypesS3ConfigurationS3Configuration, IHaveCognitoLogDeliveryConfigurationTypesCloudWatchLogsConfigurationCloudWatchLogsConfiguration, IHaveLogLevel
        {
            /// <summary>
            /// FirehoseConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-logdeliveryconfiguration-logconfiguration.html#cfn-cognito-logdeliveryconfiguration-logconfiguration-firehoseconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FirehoseConfiguration
            /// </summary>
            public Union<Humidifier.Cognito.LogDeliveryConfigurationTypes.FirehoseConfiguration, BaseFunction>? FirehoseConfiguration { get; set; }
            /// <summary>
            /// EventSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-logdeliveryconfiguration-logconfiguration.html#cfn-cognito-logdeliveryconfiguration-logconfiguration-eventsource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EventSource { get; set; }
            /// <summary>
            /// S3Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-logdeliveryconfiguration-logconfiguration.html#cfn-cognito-logdeliveryconfiguration-logconfiguration-s3configuration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Configuration
            /// </summary>
            public Union<Humidifier.Cognito.LogDeliveryConfigurationTypes.S3Configuration, BaseFunction>? S3Configuration { get; set; }
            /// <summary>
            /// CloudWatchLogsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-logdeliveryconfiguration-logconfiguration.html#cfn-cognito-logdeliveryconfiguration-logconfiguration-cloudwatchlogsconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudWatchLogsConfiguration
            /// </summary>
            public Union<Humidifier.Cognito.LogDeliveryConfigurationTypes.CloudWatchLogsConfiguration, BaseFunction>? CloudWatchLogsConfiguration { get; set; }
            /// <summary>
            /// LogLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-logdeliveryconfiguration-logconfiguration.html#cfn-cognito-logdeliveryconfiguration-logconfiguration-loglevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogLevel { get; set; }
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
            public Union<string, BaseFunction>? BucketArn { get; set; }
        }
    }
}