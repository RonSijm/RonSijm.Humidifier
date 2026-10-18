namespace Humidifier.EMRServerless
{
    using global::System.Collections.Generic;
    using JobRunTypes;

    public class JobRun : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveExecutionRoleArn, IHaveExecutionTimeoutMinutes_Integer, IHaveMode, IHaveEMRServerlessJobRunTypesConfigurationOverridesConfigurationOverrides, IHaveEMRServerlessJobRunTypesJobDriverJobDriver, IHaveApplicationId, IHaveName
    {
        public class Attributes
        {
            public static string CreatedBy =  "CreatedBy" ;
            public static string JobRunId =  "JobRunId" ;
            public static string State =  "State" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string StateDetails =  "StateDetails" ;
            public static string Arn =  "Arn" ;
            public static string ReleaseLabel =  "ReleaseLabel" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.EMRServerless.JobRun; }
        /// <summary>
        /// ExecutionRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrserverless-jobrun.html#cfn-emrserverless-jobrun-executionrolearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ExecutionRoleArn { get; set; }
        /// <summary>
        /// ExecutionTimeoutMinutes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrserverless-jobrun.html#cfn-emrserverless-jobrun-executiontimeoutminutes
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? ExecutionTimeoutMinutes { get; set; }
        /// <summary>
        /// Mode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrserverless-jobrun.html#cfn-emrserverless-jobrun-mode
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Mode { get; set; }
        /// <summary>
        /// ConfigurationOverrides
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrserverless-jobrun.html#cfn-emrserverless-jobrun-configurationoverrides
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ConfigurationOverrides
        /// </summary>
        public Union<Humidifier.EMRServerless.JobRunTypes.ConfigurationOverrides, BaseFunction>? ConfigurationOverrides { get; set; }
        /// <summary>
        /// JobDriver
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrserverless-jobrun.html#cfn-emrserverless-jobrun-jobdriver
        /// Required: False
        /// UpdateType: Immutable
        /// Type: JobDriver
        /// </summary>
        public Union<Humidifier.EMRServerless.JobRunTypes.JobDriver, BaseFunction>? JobDriver { get; set; }
        /// <summary>
        /// ApplicationId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrserverless-jobrun.html#cfn-emrserverless-jobrun-applicationid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ApplicationId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrserverless-jobrun.html#cfn-emrserverless-jobrun-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace JobRunTypes
    {
        public class Configuration : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfProperties, IHaveListOfEMRServerlessJobRunTypesConfigurationConfigurations, IHaveClassification
        {
            /// <summary>
            /// Properties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-jobrun-configuration.html#cfn-emrserverless-jobrun-configuration-properties
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Properties { get; set; }
            /// <summary>
            /// Configurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-jobrun-configuration.html#cfn-emrserverless-jobrun-configuration-configurations
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Configuration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EMRServerless.JobRunTypes.Configuration>, IReadOnlyList<Union<Humidifier.EMRServerless.JobRunTypes.Configuration, BaseFunction>>, BaseFunction>? Configurations { get; set; }
            /// <summary>
            /// Classification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-jobrun-configuration.html#cfn-emrserverless-jobrun-configuration-classification
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Classification { get; set; }
        }

        public class ConfigurationOverrides : Humidifier.Base.BaseSubResource, IHaveEMRServerlessJobRunTypesMonitoringConfigurationMonitoringConfiguration, IHaveListOfEMRServerlessJobRunTypesConfigurationApplicationConfiguration
        {
            /// <summary>
            /// MonitoringConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-jobrun-configurationoverrides.html#cfn-emrserverless-jobrun-configurationoverrides-monitoringconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MonitoringConfiguration
            /// </summary>
            public Union<Humidifier.EMRServerless.JobRunTypes.MonitoringConfiguration, BaseFunction>? MonitoringConfiguration { get; set; }
            /// <summary>
            /// ApplicationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-jobrun-configurationoverrides.html#cfn-emrserverless-jobrun-configurationoverrides-applicationconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Configuration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EMRServerless.JobRunTypes.Configuration>, IReadOnlyList<Union<Humidifier.EMRServerless.JobRunTypes.Configuration, BaseFunction>>, BaseFunction>? ApplicationConfiguration { get; set; }
        }

        public class Hive : Humidifier.Base.BaseSubResource, IHaveParameters, IHaveQuery, IHaveInitQueryFile
        {
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-jobrun-hive.html#cfn-emrserverless-jobrun-hive-parameters
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Parameters { get; set; }
            /// <summary>
            /// Query
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-jobrun-hive.html#cfn-emrserverless-jobrun-hive-query
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Query { get; set; }
            /// <summary>
            /// InitQueryFile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-jobrun-hive.html#cfn-emrserverless-jobrun-hive-initqueryfile
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InitQueryFile { get; set; }
        }

        public class JobDriver : Humidifier.Base.BaseSubResource, IHaveEMRServerlessJobRunTypesSparkSubmitSparkSubmit, IHaveEMRServerlessJobRunTypesHiveHive
        {
            /// <summary>
            /// SparkSubmit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-jobrun-jobdriver.html#cfn-emrserverless-jobrun-jobdriver-sparksubmit
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SparkSubmit
            /// </summary>
            public Union<Humidifier.EMRServerless.JobRunTypes.SparkSubmit, BaseFunction>? SparkSubmit { get; set; }
            /// <summary>
            /// Hive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-jobrun-jobdriver.html#cfn-emrserverless-jobrun-jobdriver-hive
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Hive
            /// </summary>
            public Union<Humidifier.EMRServerless.JobRunTypes.Hive, BaseFunction>? Hive { get; set; }
        }

        public class ManagedPersistenceMonitoringConfiguration : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-jobrun-managedpersistencemonitoringconfiguration.html#cfn-emrserverless-jobrun-managedpersistencemonitoringconfiguration-enabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class MonitoringConfiguration : Humidifier.Base.BaseSubResource, IHaveEMRServerlessJobRunTypesS3MonitoringConfigurationS3MonitoringConfiguration, IHaveEMRServerlessJobRunTypesManagedPersistenceMonitoringConfigurationManagedPersistenceMonitoringConfiguration
        {
            /// <summary>
            /// S3MonitoringConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-jobrun-monitoringconfiguration.html#cfn-emrserverless-jobrun-monitoringconfiguration-s3monitoringconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3MonitoringConfiguration
            /// </summary>
            public Union<Humidifier.EMRServerless.JobRunTypes.S3MonitoringConfiguration, BaseFunction>? S3MonitoringConfiguration { get; set; }
            /// <summary>
            /// ManagedPersistenceMonitoringConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-jobrun-monitoringconfiguration.html#cfn-emrserverless-jobrun-monitoringconfiguration-managedpersistencemonitoringconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ManagedPersistenceMonitoringConfiguration
            /// </summary>
            public Union<Humidifier.EMRServerless.JobRunTypes.ManagedPersistenceMonitoringConfiguration, BaseFunction>? ManagedPersistenceMonitoringConfiguration { get; set; }
        }

        public class S3MonitoringConfiguration : Humidifier.Base.BaseSubResource, IHaveLogUri
        {
            /// <summary>
            /// LogUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-jobrun-s3monitoringconfiguration.html#cfn-emrserverless-jobrun-s3monitoringconfiguration-loguri
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogUri { get; set; }
        }

        public class SparkSubmit : Humidifier.Base.BaseSubResource, IHaveEntryPoint, IHaveSparkSubmitParameters, IHaveStringListOfEntryPointArguments
        {
            /// <summary>
            /// EntryPoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-jobrun-sparksubmit.html#cfn-emrserverless-jobrun-sparksubmit-entrypoint
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EntryPoint { get; set; }
            /// <summary>
            /// SparkSubmitParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-jobrun-sparksubmit.html#cfn-emrserverless-jobrun-sparksubmit-sparksubmitparameters
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SparkSubmitParameters { get; set; }
            /// <summary>
            /// EntryPointArguments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrserverless-jobrun-sparksubmit.html#cfn-emrserverless-jobrun-sparksubmit-entrypointarguments
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EntryPointArguments { get; set; }
        }
    }
}