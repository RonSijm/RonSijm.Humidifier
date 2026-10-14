namespace Humidifier.EMRContainers
{
    using global::System.Collections.Generic;
    using JobTemplateTypes;

    public class JobTemplate : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags
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
        public Humidifier.EMRContainers.JobTemplateTypes.JobTemplateData JobTemplateData { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emrcontainers-jobtemplate.html#cfn-emrcontainers-jobtemplate-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace JobTemplateTypes
    {
        public class Configuration : Humidifier.Base.BaseSubResource, IHaveClassification
        {
            /// <summary>
            /// Properties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-configuration.html#cfn-emrcontainers-jobtemplate-configuration-properties
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> Properties { get; set; }
            /// <summary>
            /// Configurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-configuration.html#cfn-emrcontainers-jobtemplate-configuration-configurations
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Configuration
            /// </summary>
            public List<Humidifier.EMRContainers.JobTemplateTypes.Configuration> Configurations { get; set; }
            /// <summary>
            /// Classification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-configuration.html#cfn-emrcontainers-jobtemplate-configuration-classification
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Classification { get; set; }
        }

        public class JobDriver : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SparkSqlJobDriver
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-jobdriver.html#cfn-emrcontainers-jobtemplate-jobdriver-sparksqljobdriver
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SparkSqlJobDriver
            /// </summary>
            public Humidifier.EMRContainers.JobTemplateTypes.SparkSqlJobDriver SparkSqlJobDriver { get; set; }
            /// <summary>
            /// SparkSubmitJobDriver
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-jobdriver.html#cfn-emrcontainers-jobtemplate-jobdriver-sparksubmitjobdriver
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SparkSubmitJobDriver
            /// </summary>
            public Humidifier.EMRContainers.JobTemplateTypes.SparkSubmitJobDriver SparkSubmitJobDriver { get; set; }
        }

        public class JobTemplateData : Humidifier.Base.BaseSubResource, IHaveExecutionRoleArn, IHaveReleaseLabel
        {
            /// <summary>
            /// ExecutionRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-jobtemplatedata.html#cfn-emrcontainers-jobtemplate-jobtemplatedata-executionrolearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExecutionRoleArn { get; set; }
            /// <summary>
            /// JobTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-jobtemplatedata.html#cfn-emrcontainers-jobtemplate-jobtemplatedata-jobtags
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> JobTags { get; set; }
            /// <summary>
            /// ConfigurationOverrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-jobtemplatedata.html#cfn-emrcontainers-jobtemplate-jobtemplatedata-configurationoverrides
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ParametricConfigurationOverrides
            /// </summary>
            public Humidifier.EMRContainers.JobTemplateTypes.ParametricConfigurationOverrides ConfigurationOverrides { get; set; }
            /// <summary>
            /// JobDriver
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-jobtemplatedata.html#cfn-emrcontainers-jobtemplate-jobtemplatedata-jobdriver
            /// Required: True
            /// UpdateType: Immutable
            /// Type: JobDriver
            /// </summary>
            public Humidifier.EMRContainers.JobTemplateTypes.JobDriver JobDriver { get; set; }
            /// <summary>
            /// ReleaseLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-jobtemplatedata.html#cfn-emrcontainers-jobtemplate-jobtemplatedata-releaselabel
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ReleaseLabel { get; set; }
            /// <summary>
            /// ParameterConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-jobtemplatedata.html#cfn-emrcontainers-jobtemplate-jobtemplatedata-parameterconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// ItemType: TemplateParameterConfiguration
            /// </summary>
            public Dictionary<string, Humidifier.EMRContainers.JobTemplateTypes.TemplateParameterConfiguration> ParameterConfiguration { get; set; }
        }

        public class ParametricCloudWatchMonitoringConfiguration : Humidifier.Base.BaseSubResource, IHaveLogGroupName
        {
            /// <summary>
            /// LogStreamNamePrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-parametriccloudwatchmonitoringconfiguration.html#cfn-emrcontainers-jobtemplate-parametriccloudwatchmonitoringconfiguration-logstreamnameprefix
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogStreamNamePrefix { get; set; }
            /// <summary>
            /// LogGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-parametriccloudwatchmonitoringconfiguration.html#cfn-emrcontainers-jobtemplate-parametriccloudwatchmonitoringconfiguration-loggroupname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogGroupName { get; set; }
        }

        public class ParametricConfigurationOverrides : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MonitoringConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-parametricconfigurationoverrides.html#cfn-emrcontainers-jobtemplate-parametricconfigurationoverrides-monitoringconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ParametricMonitoringConfiguration
            /// </summary>
            public Humidifier.EMRContainers.JobTemplateTypes.ParametricMonitoringConfiguration MonitoringConfiguration { get; set; }
            /// <summary>
            /// ApplicationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-parametricconfigurationoverrides.html#cfn-emrcontainers-jobtemplate-parametricconfigurationoverrides-applicationconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Configuration
            /// </summary>
            public List<Humidifier.EMRContainers.JobTemplateTypes.Configuration> ApplicationConfiguration { get; set; }
        }

        public class ParametricMonitoringConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3MonitoringConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-parametricmonitoringconfiguration.html#cfn-emrcontainers-jobtemplate-parametricmonitoringconfiguration-s3monitoringconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ParametricS3MonitoringConfiguration
            /// </summary>
            public Humidifier.EMRContainers.JobTemplateTypes.ParametricS3MonitoringConfiguration S3MonitoringConfiguration { get; set; }
            /// <summary>
            /// CloudWatchMonitoringConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-parametricmonitoringconfiguration.html#cfn-emrcontainers-jobtemplate-parametricmonitoringconfiguration-cloudwatchmonitoringconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ParametricCloudWatchMonitoringConfiguration
            /// </summary>
            public Humidifier.EMRContainers.JobTemplateTypes.ParametricCloudWatchMonitoringConfiguration CloudWatchMonitoringConfiguration { get; set; }
            /// <summary>
            /// PersistentAppUI
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-parametricmonitoringconfiguration.html#cfn-emrcontainers-jobtemplate-parametricmonitoringconfiguration-persistentappui
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PersistentAppUI { get; set; }
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
            public dynamic LogUri { get; set; }
        }

        public class SparkSqlJobDriver : Humidifier.Base.BaseSubResource, IHaveEntryPoint
        {
            /// <summary>
            /// EntryPoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-sparksqljobdriver.html#cfn-emrcontainers-jobtemplate-sparksqljobdriver-entrypoint
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EntryPoint { get; set; }
            /// <summary>
            /// SparkSqlParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-sparksqljobdriver.html#cfn-emrcontainers-jobtemplate-sparksqljobdriver-sparksqlparameters
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-sparksubmitjobdriver.html#cfn-emrcontainers-jobtemplate-sparksubmitjobdriver-entrypoint
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EntryPoint { get; set; }
            /// <summary>
            /// SparkSubmitParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-sparksubmitjobdriver.html#cfn-emrcontainers-jobtemplate-sparksubmitjobdriver-sparksubmitparameters
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SparkSubmitParameters { get; set; }
            /// <summary>
            /// EntryPointArguments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-sparksubmitjobdriver.html#cfn-emrcontainers-jobtemplate-sparksubmitjobdriver-entrypointarguments
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic EntryPointArguments { get; set; }
        }

        public class TemplateParameterConfiguration : Humidifier.Base.BaseSubResource, IHaveType, IHaveDefaultValue
        {
            /// <summary>
            /// DefaultValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-templateparameterconfiguration.html#cfn-emrcontainers-jobtemplate-templateparameterconfiguration-defaultvalue
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DefaultValue { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emrcontainers-jobtemplate-templateparameterconfiguration.html#cfn-emrcontainers-jobtemplate-templateparameterconfiguration-type
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
        }
    }
}