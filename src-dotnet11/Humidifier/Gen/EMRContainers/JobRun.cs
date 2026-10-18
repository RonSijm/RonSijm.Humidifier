namespace Humidifier.EMRContainers
{
    using global::System.Collections.Generic;
    using JobRunTypes;

    public class JobRun : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveExecutionRoleArn, IHaveEMRContainersJobRunTypesConfigurationOverridesConfigurationOverrides, IHaveEMRContainersJobRunTypesJobDriverJobDriver, IHaveVirtualClusterId, IHaveReleaseLabel, IHaveName, IHaveEMRContainersJobRunTypesRetryPolicyConfigurationRetryPolicyConfiguration
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
        public Union<string, BaseFunction>? ExecutionRoleArn { get; set; }
        /// <summary>
        /// ConfigurationOverrides
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrcontainers-jobrun.html#cfn-emrcontainers-jobrun-configurationoverrides
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ConfigurationOverrides
        /// </summary>
        public Union<Humidifier.EMRContainers.JobRunTypes.ConfigurationOverrides, BaseFunction>? ConfigurationOverrides { get; set; }
        /// <summary>
        /// JobDriver
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrcontainers-jobrun.html#cfn-emrcontainers-jobrun-jobdriver
        /// Required: False
        /// UpdateType: Immutable
        /// Type: JobDriver
        /// </summary>
        public Union<Humidifier.EMRContainers.JobRunTypes.JobDriver, BaseFunction>? JobDriver { get; set; }
        /// <summary>
        /// VirtualClusterId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrcontainers-jobrun.html#cfn-emrcontainers-jobrun-virtualclusterid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VirtualClusterId { get; set; }
        /// <summary>
        /// ReleaseLabel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrcontainers-jobrun.html#cfn-emrcontainers-jobrun-releaselabel
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ReleaseLabel { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrcontainers-jobrun.html#cfn-emrcontainers-jobrun-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// RetryPolicyConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrcontainers-jobrun.html#cfn-emrcontainers-jobrun-retrypolicyconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: RetryPolicyConfiguration
        /// </summary>
        public Union<Humidifier.EMRContainers.JobRunTypes.RetryPolicyConfiguration, BaseFunction>? RetryPolicyConfiguration { get; set; }
    }

    namespace JobRunTypes
    {
        public class CloudWatchMonitoringConfiguration : Humidifier.Base.BaseSubResource, IHaveLogStreamNamePrefix, IHaveLogGroupName
        {
            /// <summary>
            /// LogStreamNamePrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-cloudwatchmonitoringconfiguration.html#cfn-emrcontainers-jobrun-cloudwatchmonitoringconfiguration-logstreamnameprefix
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogStreamNamePrefix { get; set; }
            /// <summary>
            /// LogGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-cloudwatchmonitoringconfiguration.html#cfn-emrcontainers-jobrun-cloudwatchmonitoringconfiguration-loggroupname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogGroupName { get; set; }
        }

        public class Configuration : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfProperties, IHaveListOfEMRContainersJobRunTypesConfigurationConfigurations, IHaveClassification
        {
            /// <summary>
            /// Properties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-configuration.html#cfn-emrcontainers-jobrun-configuration-properties
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Properties { get; set; }
            /// <summary>
            /// Configurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-configuration.html#cfn-emrcontainers-jobrun-configuration-configurations
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Configuration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EMRContainers.JobRunTypes.Configuration>, IReadOnlyList<Union<Humidifier.EMRContainers.JobRunTypes.Configuration, BaseFunction>>, BaseFunction>? Configurations { get; set; }
            /// <summary>
            /// Classification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-configuration.html#cfn-emrcontainers-jobrun-configuration-classification
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Classification { get; set; }
        }

        public class ConfigurationOverrides : Humidifier.Base.BaseSubResource, IHaveEMRContainersJobRunTypesMonitoringConfigurationMonitoringConfiguration, IHaveListOfEMRContainersJobRunTypesConfigurationApplicationConfiguration
        {
            /// <summary>
            /// MonitoringConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-configurationoverrides.html#cfn-emrcontainers-jobrun-configurationoverrides-monitoringconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MonitoringConfiguration
            /// </summary>
            public Union<Humidifier.EMRContainers.JobRunTypes.MonitoringConfiguration, BaseFunction>? MonitoringConfiguration { get; set; }
            /// <summary>
            /// ApplicationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-configurationoverrides.html#cfn-emrcontainers-jobrun-configurationoverrides-applicationconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Configuration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EMRContainers.JobRunTypes.Configuration>, IReadOnlyList<Union<Humidifier.EMRContainers.JobRunTypes.Configuration, BaseFunction>>, BaseFunction>? ApplicationConfiguration { get; set; }
        }

        public class ContainerLogRotationConfiguration : Humidifier.Base.BaseSubResource, IHaveMaxFilesToKeep_Integer, IHaveRotationSize
        {
            /// <summary>
            /// MaxFilesToKeep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-containerlogrotationconfiguration.html#cfn-emrcontainers-jobrun-containerlogrotationconfiguration-maxfilestokeep
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxFilesToKeep { get; set; }
            /// <summary>
            /// RotationSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-containerlogrotationconfiguration.html#cfn-emrcontainers-jobrun-containerlogrotationconfiguration-rotationsize
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RotationSize { get; set; }
        }

        public class JobDriver : Humidifier.Base.BaseSubResource, IHaveEMRContainersJobRunTypesSparkSqlJobDriverSparkSqlJobDriver, IHaveEMRContainersJobRunTypesSparkSubmitJobDriverSparkSubmitJobDriver
        {
            /// <summary>
            /// SparkSqlJobDriver
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-jobdriver.html#cfn-emrcontainers-jobrun-jobdriver-sparksqljobdriver
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SparkSqlJobDriver
            /// </summary>
            public Union<Humidifier.EMRContainers.JobRunTypes.SparkSqlJobDriver, BaseFunction>? SparkSqlJobDriver { get; set; }
            /// <summary>
            /// SparkSubmitJobDriver
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-jobdriver.html#cfn-emrcontainers-jobrun-jobdriver-sparksubmitjobdriver
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SparkSubmitJobDriver
            /// </summary>
            public Union<Humidifier.EMRContainers.JobRunTypes.SparkSubmitJobDriver, BaseFunction>? SparkSubmitJobDriver { get; set; }
        }

        public class ManagedLogs : Humidifier.Base.BaseSubResource, IHaveAllowAWSToRetainLogs, IHaveEncryptionKeyArn
        {
            /// <summary>
            /// AllowAWSToRetainLogs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-managedlogs.html#cfn-emrcontainers-jobrun-managedlogs-allowawstoretainlogs
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AllowAWSToRetainLogs { get; set; }
            /// <summary>
            /// EncryptionKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-managedlogs.html#cfn-emrcontainers-jobrun-managedlogs-encryptionkeyarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncryptionKeyArn { get; set; }
        }

        public class MonitoringConfiguration : Humidifier.Base.BaseSubResource, IHaveEMRContainersJobRunTypesS3MonitoringConfigurationS3MonitoringConfiguration, IHaveEMRContainersJobRunTypesContainerLogRotationConfigurationContainerLogRotationConfiguration, IHaveEMRContainersJobRunTypesCloudWatchMonitoringConfigurationCloudWatchMonitoringConfiguration, IHaveEMRContainersJobRunTypesManagedLogsManagedLogs, IHavePersistentAppUI
        {
            /// <summary>
            /// S3MonitoringConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-monitoringconfiguration.html#cfn-emrcontainers-jobrun-monitoringconfiguration-s3monitoringconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3MonitoringConfiguration
            /// </summary>
            public Union<Humidifier.EMRContainers.JobRunTypes.S3MonitoringConfiguration, BaseFunction>? S3MonitoringConfiguration { get; set; }
            /// <summary>
            /// ContainerLogRotationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-monitoringconfiguration.html#cfn-emrcontainers-jobrun-monitoringconfiguration-containerlogrotationconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ContainerLogRotationConfiguration
            /// </summary>
            public Union<Humidifier.EMRContainers.JobRunTypes.ContainerLogRotationConfiguration, BaseFunction>? ContainerLogRotationConfiguration { get; set; }
            /// <summary>
            /// CloudWatchMonitoringConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-monitoringconfiguration.html#cfn-emrcontainers-jobrun-monitoringconfiguration-cloudwatchmonitoringconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CloudWatchMonitoringConfiguration
            /// </summary>
            public Union<Humidifier.EMRContainers.JobRunTypes.CloudWatchMonitoringConfiguration, BaseFunction>? CloudWatchMonitoringConfiguration { get; set; }
            /// <summary>
            /// ManagedLogs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-monitoringconfiguration.html#cfn-emrcontainers-jobrun-monitoringconfiguration-managedlogs
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ManagedLogs
            /// </summary>
            public Union<Humidifier.EMRContainers.JobRunTypes.ManagedLogs, BaseFunction>? ManagedLogs { get; set; }
            /// <summary>
            /// PersistentAppUI
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-monitoringconfiguration.html#cfn-emrcontainers-jobrun-monitoringconfiguration-persistentappui
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PersistentAppUI { get; set; }
        }

        public class RetryPolicyConfiguration : Humidifier.Base.BaseSubResource, IHaveMaxAttempts_Integer
        {
            /// <summary>
            /// MaxAttempts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-retrypolicyconfiguration.html#cfn-emrcontainers-jobrun-retrypolicyconfiguration-maxattempts
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxAttempts { get; set; }
        }

        public class RetryPolicyExecution : Humidifier.Base.BaseSubResource, IHaveCurrentAttemptCount_Integer
        {
            /// <summary>
            /// CurrentAttemptCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-retrypolicyexecution.html#cfn-emrcontainers-jobrun-retrypolicyexecution-currentattemptcount
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? CurrentAttemptCount { get; set; }
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
            public Union<string, BaseFunction>? LogUri { get; set; }
        }

        public class SparkSqlJobDriver : Humidifier.Base.BaseSubResource, IHaveEntryPoint, IHaveSparkSqlParameters
        {
            /// <summary>
            /// EntryPoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-sparksqljobdriver.html#cfn-emrcontainers-jobrun-sparksqljobdriver-entrypoint
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EntryPoint { get; set; }
            /// <summary>
            /// SparkSqlParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-sparksqljobdriver.html#cfn-emrcontainers-jobrun-sparksqljobdriver-sparksqlparameters
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SparkSqlParameters { get; set; }
        }

        public class SparkSubmitJobDriver : Humidifier.Base.BaseSubResource, IHaveEntryPoint, IHaveSparkSubmitParameters, IHaveStringListOfEntryPointArguments
        {
            /// <summary>
            /// EntryPoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-sparksubmitjobdriver.html#cfn-emrcontainers-jobrun-sparksubmitjobdriver-entrypoint
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EntryPoint { get; set; }
            /// <summary>
            /// SparkSubmitParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-sparksubmitjobdriver.html#cfn-emrcontainers-jobrun-sparksubmitjobdriver-sparksubmitparameters
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SparkSubmitParameters { get; set; }
            /// <summary>
            /// EntryPointArguments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobrun-sparksubmitjobdriver.html#cfn-emrcontainers-jobrun-sparksubmitjobdriver-entrypointarguments
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EntryPointArguments { get; set; }
        }
    }
}