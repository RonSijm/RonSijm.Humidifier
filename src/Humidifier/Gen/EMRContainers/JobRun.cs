namespace Humidifier.EMRContainers
{
    using global::System.Collections.Generic;
    using JobRunTypes;

    public class JobRun : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveExecutionRoleArn, IHaveReleaseLabel
    {
        public class Attributes
        {
            public static string CreatedBy =  "CreatedBy" ;
            public static string State =  "State" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string FailureReason =  "FailureReason" ;
            public static string FinishedAt =  "FinishedAt" ;
            public static string Id =  "Id" ;
            public static string RetryPolicyExecution =  "RetryPolicyExecution" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.EMRContainers.JobRun; }
        /// <summary>
        /// ExecutionRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrcontainers-jobrun.html#cfn-emrcontainers-jobrun-executionrolearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ExecutionRoleArn { get; set; }
        /// <summary>
        /// ConfigurationOverrides
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrcontainers-jobrun.html#cfn-emrcontainers-jobrun-configurationoverrides
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ConfigurationOverrides
        /// </summary>
        public Humidifier.EMRContainers.JobRunTypes.ConfigurationOverrides ConfigurationOverrides { get; set; }
        /// <summary>
        /// JobDriver
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrcontainers-jobrun.html#cfn-emrcontainers-jobrun-jobdriver
        /// Required: False
        /// UpdateType: Immutable
        /// Type: JobDriver
        /// </summary>
        public Humidifier.EMRContainers.JobRunTypes.JobDriver JobDriver { get; set; }
        /// <summary>
        /// VirtualClusterId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrcontainers-jobrun.html#cfn-emrcontainers-jobrun-virtualclusterid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic VirtualClusterId { get; set; }
        /// <summary>
        /// ReleaseLabel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrcontainers-jobrun.html#cfn-emrcontainers-jobrun-releaselabel
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ReleaseLabel { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrcontainers-jobrun.html#cfn-emrcontainers-jobrun-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// RetryPolicyConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrcontainers-jobrun.html#cfn-emrcontainers-jobrun-retrypolicyconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: RetryPolicyConfiguration
        /// </summary>
        public Humidifier.EMRContainers.JobRunTypes.RetryPolicyConfiguration RetryPolicyConfiguration { get; set; }
    }

    namespace JobRunTypes
    {
        public class CloudWatchMonitoringConfiguration : Humidifier.Base.BaseSubResource, IHaveLogGroupName
        {
            /// <summary>
            /// LogStreamNamePrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-cloudwatchmonitoringconfiguration.html#cfn-emrcontainers-jobrun-cloudwatchmonitoringconfiguration-logstreamnameprefix
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogStreamNamePrefix { get; set; }
            /// <summary>
            /// LogGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-cloudwatchmonitoringconfiguration.html#cfn-emrcontainers-jobrun-cloudwatchmonitoringconfiguration-loggroupname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogGroupName { get; set; }
        }

        public class Configuration : Humidifier.Base.BaseSubResource, IHaveClassification
        {
            /// <summary>
            /// Properties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-configuration.html#cfn-emrcontainers-jobrun-configuration-properties
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> Properties { get; set; }
            /// <summary>
            /// Configurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-configuration.html#cfn-emrcontainers-jobrun-configuration-configurations
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Configuration
            /// </summary>
            public List<Humidifier.EMRContainers.JobRunTypes.Configuration> Configurations { get; set; }
            /// <summary>
            /// Classification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-configuration.html#cfn-emrcontainers-jobrun-configuration-classification
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Classification { get; set; }
        }

        public class ConfigurationOverrides : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MonitoringConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-configurationoverrides.html#cfn-emrcontainers-jobrun-configurationoverrides-monitoringconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MonitoringConfiguration
            /// </summary>
            public Humidifier.EMRContainers.JobRunTypes.MonitoringConfiguration MonitoringConfiguration { get; set; }
            /// <summary>
            /// ApplicationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-configurationoverrides.html#cfn-emrcontainers-jobrun-configurationoverrides-applicationconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Configuration
            /// </summary>
            public List<Humidifier.EMRContainers.JobRunTypes.Configuration> ApplicationConfiguration { get; set; }
        }

        public class ContainerLogRotationConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MaxFilesToKeep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-containerlogrotationconfiguration.html#cfn-emrcontainers-jobrun-containerlogrotationconfiguration-maxfilestokeep
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxFilesToKeep { get; set; }
            /// <summary>
            /// RotationSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-containerlogrotationconfiguration.html#cfn-emrcontainers-jobrun-containerlogrotationconfiguration-rotationsize
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RotationSize { get; set; }
        }

        public class JobDriver : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SparkSqlJobDriver
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-jobdriver.html#cfn-emrcontainers-jobrun-jobdriver-sparksqljobdriver
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SparkSqlJobDriver
            /// </summary>
            public Humidifier.EMRContainers.JobRunTypes.SparkSqlJobDriver SparkSqlJobDriver { get; set; }
            /// <summary>
            /// SparkSubmitJobDriver
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-jobdriver.html#cfn-emrcontainers-jobrun-jobdriver-sparksubmitjobdriver
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SparkSubmitJobDriver
            /// </summary>
            public Humidifier.EMRContainers.JobRunTypes.SparkSubmitJobDriver SparkSubmitJobDriver { get; set; }
        }

        public class ManagedLogs : Humidifier.Base.BaseSubResource, IHaveEncryptionKeyArn
        {
            /// <summary>
            /// AllowAWSToRetainLogs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-managedlogs.html#cfn-emrcontainers-jobrun-managedlogs-allowawstoretainlogs
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AllowAWSToRetainLogs { get; set; }
            /// <summary>
            /// EncryptionKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-managedlogs.html#cfn-emrcontainers-jobrun-managedlogs-encryptionkeyarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EncryptionKeyArn { get; set; }
        }

        public class MonitoringConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3MonitoringConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-monitoringconfiguration.html#cfn-emrcontainers-jobrun-monitoringconfiguration-s3monitoringconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3MonitoringConfiguration
            /// </summary>
            public Humidifier.EMRContainers.JobRunTypes.S3MonitoringConfiguration S3MonitoringConfiguration { get; set; }
            /// <summary>
            /// ContainerLogRotationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-monitoringconfiguration.html#cfn-emrcontainers-jobrun-monitoringconfiguration-containerlogrotationconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ContainerLogRotationConfiguration
            /// </summary>
            public Humidifier.EMRContainers.JobRunTypes.ContainerLogRotationConfiguration ContainerLogRotationConfiguration { get; set; }
            /// <summary>
            /// CloudWatchMonitoringConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-monitoringconfiguration.html#cfn-emrcontainers-jobrun-monitoringconfiguration-cloudwatchmonitoringconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CloudWatchMonitoringConfiguration
            /// </summary>
            public Humidifier.EMRContainers.JobRunTypes.CloudWatchMonitoringConfiguration CloudWatchMonitoringConfiguration { get; set; }
            /// <summary>
            /// ManagedLogs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-monitoringconfiguration.html#cfn-emrcontainers-jobrun-monitoringconfiguration-managedlogs
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ManagedLogs
            /// </summary>
            public Humidifier.EMRContainers.JobRunTypes.ManagedLogs ManagedLogs { get; set; }
            /// <summary>
            /// PersistentAppUI
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-monitoringconfiguration.html#cfn-emrcontainers-jobrun-monitoringconfiguration-persistentappui
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PersistentAppUI { get; set; }
        }

        public class RetryPolicyConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MaxAttempts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-retrypolicyconfiguration.html#cfn-emrcontainers-jobrun-retrypolicyconfiguration-maxattempts
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxAttempts { get; set; }
        }

        public class RetryPolicyExecution : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CurrentAttemptCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-retrypolicyexecution.html#cfn-emrcontainers-jobrun-retrypolicyexecution-currentattemptcount
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic CurrentAttemptCount { get; set; }
        }

        public class S3MonitoringConfiguration : Humidifier.Base.BaseSubResource, IHaveLogUri
        {
            /// <summary>
            /// LogUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-s3monitoringconfiguration.html#cfn-emrcontainers-jobrun-s3monitoringconfiguration-loguri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogUri { get; set; }
        }

        public class SparkSqlJobDriver : Humidifier.Base.BaseSubResource, IHaveEntryPoint
        {
            /// <summary>
            /// EntryPoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-sparksqljobdriver.html#cfn-emrcontainers-jobrun-sparksqljobdriver-entrypoint
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EntryPoint { get; set; }
            /// <summary>
            /// SparkSqlParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-sparksqljobdriver.html#cfn-emrcontainers-jobrun-sparksqljobdriver-sparksqlparameters
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SparkSqlParameters { get; set; }
        }

        public class SparkSubmitJobDriver : Humidifier.Base.BaseSubResource, IHaveEntryPoint
        {
            /// <summary>
            /// EntryPoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-sparksubmitjobdriver.html#cfn-emrcontainers-jobrun-sparksubmitjobdriver-entrypoint
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EntryPoint { get; set; }
            /// <summary>
            /// SparkSubmitParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-sparksubmitjobdriver.html#cfn-emrcontainers-jobrun-sparksubmitjobdriver-sparksubmitparameters
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SparkSubmitParameters { get; set; }
            /// <summary>
            /// EntryPointArguments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-sparksubmitjobdriver.html#cfn-emrcontainers-jobrun-sparksubmitjobdriver-entrypointarguments
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic EntryPointArguments { get; set; }
        }
    }
}