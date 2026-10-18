namespace Humidifier.EMRContainers
{
    using global::System.Collections.Generic;
    using JobTemplateTypes;

    public class JobTemplate : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveEMRContainersJobTemplateTypesJobTemplateDataJobTemplateData, IHaveName
    {
        public class Attributes
        {
            public static string CreatedBy =  "CreatedBy" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.EMRContainers.JobTemplate; }

        /// <summary>
        /// JobTemplateData
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrcontainers-jobtemplate.html#cfn-emrcontainers-jobtemplate-jobtemplatedata
        /// Required: True
        /// UpdateType: Immutable
        /// Type: JobTemplateData
        /// </summary>
        [Required]
        public Union<Humidifier.EMRContainers.JobTemplateTypes.JobTemplateData, BaseFunction>? JobTemplateData { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrcontainers-jobtemplate.html#cfn-emrcontainers-jobtemplate-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace JobTemplateTypes
    {
        public class Configuration : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfProperties, IHaveListOfEMRContainersJobTemplateTypesConfigurationConfigurations, IHaveClassification
        {
            /// <summary>
            /// Properties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-configuration.html#cfn-emrcontainers-jobtemplate-configuration-properties
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Properties { get; set; }
            /// <summary>
            /// Configurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-configuration.html#cfn-emrcontainers-jobtemplate-configuration-configurations
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Configuration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EMRContainers.JobTemplateTypes.Configuration>, IReadOnlyList<Union<Humidifier.EMRContainers.JobTemplateTypes.Configuration, BaseFunction>>, BaseFunction>? Configurations { get; set; }
            /// <summary>
            /// Classification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-configuration.html#cfn-emrcontainers-jobtemplate-configuration-classification
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Classification { get; set; }
        }

        public class JobDriver : Humidifier.Base.BaseSubResource, IHaveEMRContainersJobTemplateTypesSparkSqlJobDriverSparkSqlJobDriver, IHaveEMRContainersJobTemplateTypesSparkSubmitJobDriverSparkSubmitJobDriver
        {
            /// <summary>
            /// SparkSqlJobDriver
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-jobdriver.html#cfn-emrcontainers-jobtemplate-jobdriver-sparksqljobdriver
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SparkSqlJobDriver
            /// </summary>
            public Union<Humidifier.EMRContainers.JobTemplateTypes.SparkSqlJobDriver, BaseFunction>? SparkSqlJobDriver { get; set; }
            /// <summary>
            /// SparkSubmitJobDriver
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-jobdriver.html#cfn-emrcontainers-jobtemplate-jobdriver-sparksubmitjobdriver
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SparkSubmitJobDriver
            /// </summary>
            public Union<Humidifier.EMRContainers.JobTemplateTypes.SparkSubmitJobDriver, BaseFunction>? SparkSubmitJobDriver { get; set; }
        }

        public class JobTemplateData : Humidifier.Base.BaseSubResource, IHaveExecutionRoleArn, IHaveStringDictionaryOfJobTags, IHaveEMRContainersJobTemplateTypesParametricConfigurationOverridesConfigurationOverrides, IHaveEMRContainersJobTemplateTypesJobDriverJobDriver, IHaveReleaseLabel, IHaveMapOfEMRContainersJobTemplateTypesTemplateParameterConfigurationParameterConfiguration
        {
            /// <summary>
            /// ExecutionRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-jobtemplatedata.html#cfn-emrcontainers-jobtemplate-jobtemplatedata-executionrolearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExecutionRoleArn { get; set; }
            /// <summary>
            /// JobTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-jobtemplatedata.html#cfn-emrcontainers-jobtemplate-jobtemplatedata-jobtags
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? JobTags { get; set; }
            /// <summary>
            /// ConfigurationOverrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-jobtemplatedata.html#cfn-emrcontainers-jobtemplate-jobtemplatedata-configurationoverrides
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ParametricConfigurationOverrides
            /// </summary>
            public Union<Humidifier.EMRContainers.JobTemplateTypes.ParametricConfigurationOverrides, BaseFunction>? ConfigurationOverrides { get; set; }
            /// <summary>
            /// JobDriver
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-jobtemplatedata.html#cfn-emrcontainers-jobtemplate-jobtemplatedata-jobdriver
            /// Required: True
            /// UpdateType: Immutable
            /// Type: JobDriver
            /// </summary>
            public Union<Humidifier.EMRContainers.JobTemplateTypes.JobDriver, BaseFunction>? JobDriver { get; set; }
            /// <summary>
            /// ReleaseLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-jobtemplatedata.html#cfn-emrcontainers-jobtemplate-jobtemplatedata-releaselabel
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ReleaseLabel { get; set; }
            /// <summary>
            /// ParameterConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-jobtemplatedata.html#cfn-emrcontainers-jobtemplate-jobtemplatedata-parameterconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// ItemType: TemplateParameterConfiguration
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.EMRContainers.JobTemplateTypes.TemplateParameterConfiguration>, IReadOnlyDictionary<string, Union<Humidifier.EMRContainers.JobTemplateTypes.TemplateParameterConfiguration, BaseFunction>>, BaseFunction>? ParameterConfiguration { get; set; }
        }

        public class ParametricCloudWatchMonitoringConfiguration : Humidifier.Base.BaseSubResource, IHaveLogStreamNamePrefix, IHaveLogGroupName
        {
            /// <summary>
            /// LogStreamNamePrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-parametriccloudwatchmonitoringconfiguration.html#cfn-emrcontainers-jobtemplate-parametriccloudwatchmonitoringconfiguration-logstreamnameprefix
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogStreamNamePrefix { get; set; }
            /// <summary>
            /// LogGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-parametriccloudwatchmonitoringconfiguration.html#cfn-emrcontainers-jobtemplate-parametriccloudwatchmonitoringconfiguration-loggroupname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogGroupName { get; set; }
        }

        public class ParametricConfigurationOverrides : Humidifier.Base.BaseSubResource, IHaveEMRContainersJobTemplateTypesParametricMonitoringConfigurationMonitoringConfiguration, IHaveListOfEMRContainersJobTemplateTypesConfigurationApplicationConfiguration
        {
            /// <summary>
            /// MonitoringConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-parametricconfigurationoverrides.html#cfn-emrcontainers-jobtemplate-parametricconfigurationoverrides-monitoringconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ParametricMonitoringConfiguration
            /// </summary>
            public Union<Humidifier.EMRContainers.JobTemplateTypes.ParametricMonitoringConfiguration, BaseFunction>? MonitoringConfiguration { get; set; }
            /// <summary>
            /// ApplicationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-parametricconfigurationoverrides.html#cfn-emrcontainers-jobtemplate-parametricconfigurationoverrides-applicationconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Configuration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EMRContainers.JobTemplateTypes.Configuration>, IReadOnlyList<Union<Humidifier.EMRContainers.JobTemplateTypes.Configuration, BaseFunction>>, BaseFunction>? ApplicationConfiguration { get; set; }
        }

        public class ParametricMonitoringConfiguration : Humidifier.Base.BaseSubResource, IHaveEMRContainersJobTemplateTypesParametricS3MonitoringConfigurationS3MonitoringConfiguration, IHaveEMRContainersJobTemplateTypesParametricCloudWatchMonitoringConfigurationCloudWatchMonitoringConfiguration, IHavePersistentAppUI
        {
            /// <summary>
            /// S3MonitoringConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-parametricmonitoringconfiguration.html#cfn-emrcontainers-jobtemplate-parametricmonitoringconfiguration-s3monitoringconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ParametricS3MonitoringConfiguration
            /// </summary>
            public Union<Humidifier.EMRContainers.JobTemplateTypes.ParametricS3MonitoringConfiguration, BaseFunction>? S3MonitoringConfiguration { get; set; }
            /// <summary>
            /// CloudWatchMonitoringConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-parametricmonitoringconfiguration.html#cfn-emrcontainers-jobtemplate-parametricmonitoringconfiguration-cloudwatchmonitoringconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ParametricCloudWatchMonitoringConfiguration
            /// </summary>
            public Union<Humidifier.EMRContainers.JobTemplateTypes.ParametricCloudWatchMonitoringConfiguration, BaseFunction>? CloudWatchMonitoringConfiguration { get; set; }
            /// <summary>
            /// PersistentAppUI
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-parametricmonitoringconfiguration.html#cfn-emrcontainers-jobtemplate-parametricmonitoringconfiguration-persistentappui
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PersistentAppUI { get; set; }
        }

        public class ParametricS3MonitoringConfiguration : Humidifier.Base.BaseSubResource, IHaveLogUri
        {
            /// <summary>
            /// LogUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-parametrics3monitoringconfiguration.html#cfn-emrcontainers-jobtemplate-parametrics3monitoringconfiguration-loguri
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogUri { get; set; }
        }

        public class SparkSqlJobDriver : Humidifier.Base.BaseSubResource, IHaveEntryPoint, IHaveSparkSqlParameters
        {
            /// <summary>
            /// EntryPoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-sparksqljobdriver.html#cfn-emrcontainers-jobtemplate-sparksqljobdriver-entrypoint
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EntryPoint { get; set; }
            /// <summary>
            /// SparkSqlParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-sparksqljobdriver.html#cfn-emrcontainers-jobtemplate-sparksqljobdriver-sparksqlparameters
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-sparksubmitjobdriver.html#cfn-emrcontainers-jobtemplate-sparksubmitjobdriver-entrypoint
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EntryPoint { get; set; }
            /// <summary>
            /// SparkSubmitParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-sparksubmitjobdriver.html#cfn-emrcontainers-jobtemplate-sparksubmitjobdriver-sparksubmitparameters
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SparkSubmitParameters { get; set; }
            /// <summary>
            /// EntryPointArguments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-sparksubmitjobdriver.html#cfn-emrcontainers-jobtemplate-sparksubmitjobdriver-entrypointarguments
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EntryPointArguments { get; set; }
        }

        public class TemplateParameterConfiguration : Humidifier.Base.BaseSubResource, IHaveDefaultValue, IHaveType
        {
            /// <summary>
            /// DefaultValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-templateparameterconfiguration.html#cfn-emrcontainers-jobtemplate-templateparameterconfiguration-defaultvalue
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DefaultValue { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-templateparameterconfiguration.html#cfn-emrcontainers-jobtemplate-templateparameterconfiguration-type
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
        }
    }
}