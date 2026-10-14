namespace Humidifier.EMR
{
    using global::System.Collections.Generic;
    using SessionTypes;

    public class Session : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveExecutionRoleArn
    {
        public class Attributes
        {
            public static string ServerUrl =  "ServerUrl" ;
            public static string AccountId =  "AccountId" ;
            public static string ClusterId =  "ClusterId" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string IdleSince =  "IdleSince" ;
            public static string State =  "State" ;
            public static string Id =  "Id" ;
            public static string StartedAt =  "StartedAt" ;
            public static string Arn =  "Arn" ;
            public static string ReleaseLabel =  "ReleaseLabel" ;
            public static string StateChangeReason =  "StateChangeReason" ;
            public static string EndedAt =  "EndedAt" ;
        }

        public override string AWSTypeName { get => AWS.EMR.Session; }
        /// <summary>
        /// SessionIdleTimeoutInMinutes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-session.html#cfn-emr-session-sessionidletimeoutinminutes
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Double
        /// </summary>
        public dynamic SessionIdleTimeoutInMinutes { get; set; }
        /// <summary>
        /// ExecutionRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-session.html#cfn-emr-session-executionrolearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ExecutionRoleArn { get; set; }
        /// <summary>
        /// MonitoringConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-session.html#cfn-emr-session-monitoringconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: SessionMonitoringConfiguration
        /// </summary>
        public Humidifier.EMR.SessionTypes.SessionMonitoringConfiguration MonitoringConfiguration { get; set; }
        /// <summary>
        /// EngineConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-session.html#cfn-emr-session-engineconfigurations
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Configuration
        /// </summary>
        public List<Humidifier.EMR.SessionTypes.Configuration> EngineConfigurations { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-session.html#cfn-emr-session-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace SessionTypes
    {
        public class Configuration : Humidifier.Base.BaseSubResource, IHaveClassification
        {
            /// <summary>
            /// Properties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-session-configuration.html#cfn-emr-session-configuration-properties
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> Properties { get; set; }
            /// <summary>
            /// Configurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-session-configuration.html#cfn-emr-session-configuration-configurations
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Configuration
            /// </summary>
            public List<Humidifier.EMR.SessionTypes.Configuration> Configurations { get; set; }
            /// <summary>
            /// Classification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-session-configuration.html#cfn-emr-session-configuration-classification
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Classification { get; set; }
        }

        public class SessionCloudWatchLoggingConfiguration : Humidifier.Base.BaseSubResource, IHaveEnabled, IHaveLogGroup, IHaveEncryptionKeyArn
        {
            /// <summary>
            /// LogGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-session-sessioncloudwatchloggingconfiguration.html#cfn-emr-session-sessioncloudwatchloggingconfiguration-loggroup
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogGroup { get; set; }
            /// <summary>
            /// EncryptionKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-session-sessioncloudwatchloggingconfiguration.html#cfn-emr-session-sessioncloudwatchloggingconfiguration-encryptionkeyarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EncryptionKeyArn { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-session-sessioncloudwatchloggingconfiguration.html#cfn-emr-session-sessioncloudwatchloggingconfiguration-enabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
            /// <summary>
            /// LogStreamNamePrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-session-sessioncloudwatchloggingconfiguration.html#cfn-emr-session-sessioncloudwatchloggingconfiguration-logstreamnameprefix
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogStreamNamePrefix { get; set; }
            /// <summary>
            /// LogTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-session-sessioncloudwatchloggingconfiguration.html#cfn-emr-session-sessioncloudwatchloggingconfiguration-logtypes
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic LogTypes { get; set; }
        }

        public class SessionManagedLoggingConfiguration : Humidifier.Base.BaseSubResource, IHaveEnabled, IHaveEncryptionKeyArn
        {
            /// <summary>
            /// EncryptionKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-session-sessionmanagedloggingconfiguration.html#cfn-emr-session-sessionmanagedloggingconfiguration-encryptionkeyarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EncryptionKeyArn { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-session-sessionmanagedloggingconfiguration.html#cfn-emr-session-sessionmanagedloggingconfiguration-enabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
        }

        public class SessionMonitoringConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3LoggingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-session-sessionmonitoringconfiguration.html#cfn-emr-session-sessionmonitoringconfiguration-s3loggingconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SessionS3LoggingConfiguration
            /// </summary>
            public Humidifier.EMR.SessionTypes.SessionS3LoggingConfiguration S3LoggingConfiguration { get; set; }
            /// <summary>
            /// ManagedLoggingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-session-sessionmonitoringconfiguration.html#cfn-emr-session-sessionmonitoringconfiguration-managedloggingconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SessionManagedLoggingConfiguration
            /// </summary>
            public Humidifier.EMR.SessionTypes.SessionManagedLoggingConfiguration ManagedLoggingConfiguration { get; set; }
            /// <summary>
            /// CloudWatchLoggingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-session-sessionmonitoringconfiguration.html#cfn-emr-session-sessionmonitoringconfiguration-cloudwatchloggingconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SessionCloudWatchLoggingConfiguration
            /// </summary>
            public Humidifier.EMR.SessionTypes.SessionCloudWatchLoggingConfiguration CloudWatchLoggingConfiguration { get; set; }
        }

        public class SessionS3LoggingConfiguration : Humidifier.Base.BaseSubResource, IHaveEnabled, IHaveEncryptionKeyArn, IHaveLogUri
        {
            /// <summary>
            /// LogUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-session-sessions3loggingconfiguration.html#cfn-emr-session-sessions3loggingconfiguration-loguri
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogUri { get; set; }
            /// <summary>
            /// EncryptionKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-session-sessions3loggingconfiguration.html#cfn-emr-session-sessions3loggingconfiguration-encryptionkeyarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EncryptionKeyArn { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-session-sessions3loggingconfiguration.html#cfn-emr-session-sessions3loggingconfiguration-enabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
            /// <summary>
            /// LogTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-session-sessions3loggingconfiguration.html#cfn-emr-session-sessions3loggingconfiguration-logtypes
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic LogTypes { get; set; }
        }
    }
}