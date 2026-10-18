namespace Humidifier.EMR
{
    using global::System.Collections.Generic;
    using SessionTypes;

    public class Session : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveSessionIdleTimeoutInMinutes_Double, IHaveExecutionRoleArn, IHaveEMRSessionTypesSessionMonitoringConfigurationMonitoringConfiguration, IHaveListOfEMRSessionTypesConfigurationEngineConfigurations, IHaveName
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
        public Union<double, BaseFunction>? SessionIdleTimeoutInMinutes { get; set; }
        /// <summary>
        /// ExecutionRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-session.html#cfn-emr-session-executionrolearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ExecutionRoleArn { get; set; }
        /// <summary>
        /// MonitoringConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-session.html#cfn-emr-session-monitoringconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: SessionMonitoringConfiguration
        /// </summary>
        public Union<Humidifier.EMR.SessionTypes.SessionMonitoringConfiguration, BaseFunction>? MonitoringConfiguration { get; set; }
        /// <summary>
        /// EngineConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-session.html#cfn-emr-session-engineconfigurations
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Configuration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EMR.SessionTypes.Configuration>, IReadOnlyList<Union<Humidifier.EMR.SessionTypes.Configuration, BaseFunction>>, BaseFunction>? EngineConfigurations { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-session.html#cfn-emr-session-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace SessionTypes
    {
        public class Configuration : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfProperties, IHaveListOfEMRSessionTypesConfigurationConfigurations, IHaveClassification
        {
            /// <summary>
            /// Properties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-session-configuration.html#cfn-emr-session-configuration-properties
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Properties { get; set; }
            /// <summary>
            /// Configurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-session-configuration.html#cfn-emr-session-configuration-configurations
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Configuration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EMR.SessionTypes.Configuration>, IReadOnlyList<Union<Humidifier.EMR.SessionTypes.Configuration, BaseFunction>>, BaseFunction>? Configurations { get; set; }
            /// <summary>
            /// Classification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-session-configuration.html#cfn-emr-session-configuration-classification
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Classification { get; set; }
        }

        public class SessionCloudWatchLoggingConfiguration : Humidifier.Base.BaseSubResource, IHaveLogGroup, IHaveEncryptionKeyArn, IHaveEnabled_Boolean, IHaveLogStreamNamePrefix, IHaveLogTypes_Json
        {
            /// <summary>
            /// LogGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-session-sessioncloudwatchloggingconfiguration.html#cfn-emr-session-sessioncloudwatchloggingconfiguration-loggroup
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogGroup { get; set; }
            /// <summary>
            /// EncryptionKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-session-sessioncloudwatchloggingconfiguration.html#cfn-emr-session-sessioncloudwatchloggingconfiguration-encryptionkeyarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncryptionKeyArn { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-session-sessioncloudwatchloggingconfiguration.html#cfn-emr-session-sessioncloudwatchloggingconfiguration-enabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// LogStreamNamePrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-session-sessioncloudwatchloggingconfiguration.html#cfn-emr-session-sessioncloudwatchloggingconfiguration-logstreamnameprefix
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogStreamNamePrefix { get; set; }
            /// <summary>
            /// LogTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-session-sessioncloudwatchloggingconfiguration.html#cfn-emr-session-sessioncloudwatchloggingconfiguration-logtypes
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? LogTypes { get; set; }
        }

        public class SessionManagedLoggingConfiguration : Humidifier.Base.BaseSubResource, IHaveEncryptionKeyArn, IHaveEnabled_Boolean
        {
            /// <summary>
            /// EncryptionKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-session-sessionmanagedloggingconfiguration.html#cfn-emr-session-sessionmanagedloggingconfiguration-encryptionkeyarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncryptionKeyArn { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-session-sessionmanagedloggingconfiguration.html#cfn-emr-session-sessionmanagedloggingconfiguration-enabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class SessionMonitoringConfiguration : Humidifier.Base.BaseSubResource, IHaveEMRSessionTypesSessionS3LoggingConfigurationS3LoggingConfiguration, IHaveEMRSessionTypesSessionManagedLoggingConfigurationManagedLoggingConfiguration, IHaveEMRSessionTypesSessionCloudWatchLoggingConfigurationCloudWatchLoggingConfiguration
        {
            /// <summary>
            /// S3LoggingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-session-sessionmonitoringconfiguration.html#cfn-emr-session-sessionmonitoringconfiguration-s3loggingconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SessionS3LoggingConfiguration
            /// </summary>
            public Union<Humidifier.EMR.SessionTypes.SessionS3LoggingConfiguration, BaseFunction>? S3LoggingConfiguration { get; set; }
            /// <summary>
            /// ManagedLoggingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-session-sessionmonitoringconfiguration.html#cfn-emr-session-sessionmonitoringconfiguration-managedloggingconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SessionManagedLoggingConfiguration
            /// </summary>
            public Union<Humidifier.EMR.SessionTypes.SessionManagedLoggingConfiguration, BaseFunction>? ManagedLoggingConfiguration { get; set; }
            /// <summary>
            /// CloudWatchLoggingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-session-sessionmonitoringconfiguration.html#cfn-emr-session-sessionmonitoringconfiguration-cloudwatchloggingconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SessionCloudWatchLoggingConfiguration
            /// </summary>
            public Union<Humidifier.EMR.SessionTypes.SessionCloudWatchLoggingConfiguration, BaseFunction>? CloudWatchLoggingConfiguration { get; set; }
        }

        public class SessionS3LoggingConfiguration : Humidifier.Base.BaseSubResource, IHaveLogUri, IHaveEncryptionKeyArn, IHaveEnabled_Boolean, IHaveLogTypes_Json
        {
            /// <summary>
            /// LogUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-session-sessions3loggingconfiguration.html#cfn-emr-session-sessions3loggingconfiguration-loguri
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogUri { get; set; }
            /// <summary>
            /// EncryptionKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-session-sessions3loggingconfiguration.html#cfn-emr-session-sessions3loggingconfiguration-encryptionkeyarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncryptionKeyArn { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-session-sessions3loggingconfiguration.html#cfn-emr-session-sessions3loggingconfiguration-enabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// LogTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-session-sessions3loggingconfiguration.html#cfn-emr-session-sessions3loggingconfiguration-logtypes
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? LogTypes { get; set; }
        }
    }
}