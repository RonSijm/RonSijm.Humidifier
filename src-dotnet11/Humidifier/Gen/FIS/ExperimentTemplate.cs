namespace Humidifier.FIS
{
    using global::System.Collections.Generic;
    using ExperimentTemplateTypes;

    public class ExperimentTemplate : Humidifier.Base.BaseResource, IHaveFISExperimentTemplateTypesExperimentTemplateExperimentReportConfigurationExperimentReportConfiguration, IHaveDescription, IHaveMapOfFISExperimentTemplateTypesExperimentTemplateActionActions, IHaveFISExperimentTemplateTypesExperimentTemplateExperimentOptionsExperimentOptions, IHaveListOfFISExperimentTemplateTypesExperimentTemplateStopConditionStopConditions, IHaveMapOfFISExperimentTemplateTypesExperimentTemplateTargetTargets, IHaveFISExperimentTemplateTypesExperimentTemplateLogConfigurationLogConfiguration, IHaveRoleArn, IHaveStringDictionaryOfTags
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.FIS.ExperimentTemplate; }
        /// <summary>
        /// ExperimentReportConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fis-experimenttemplate.html#cfn-fis-experimenttemplate-experimentreportconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ExperimentTemplateExperimentReportConfiguration
        /// </summary>
        public Union<Humidifier.FIS.ExperimentTemplateTypes.ExperimentTemplateExperimentReportConfiguration, BaseFunction>? ExperimentReportConfiguration { get; set; }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fis-experimenttemplate.html#cfn-fis-experimenttemplate-description
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// Actions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fis-experimenttemplate.html#cfn-fis-experimenttemplate-actions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// ItemType: ExperimentTemplateAction
        /// </summary>
        public Union<IReadOnlyDictionary<string, Humidifier.FIS.ExperimentTemplateTypes.ExperimentTemplateAction>, IReadOnlyDictionary<string, Union<Humidifier.FIS.ExperimentTemplateTypes.ExperimentTemplateAction, BaseFunction>>, BaseFunction>? Actions { get; set; }
        /// <summary>
        /// ExperimentOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fis-experimenttemplate.html#cfn-fis-experimenttemplate-experimentoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ExperimentTemplateExperimentOptions
        /// </summary>
        public Union<Humidifier.FIS.ExperimentTemplateTypes.ExperimentTemplateExperimentOptions, BaseFunction>? ExperimentOptions { get; set; }

        /// <summary>
        /// StopConditions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fis-experimenttemplate.html#cfn-fis-experimenttemplate-stopconditions
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ExperimentTemplateStopCondition
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.FIS.ExperimentTemplateTypes.ExperimentTemplateStopCondition>, IReadOnlyList<Union<Humidifier.FIS.ExperimentTemplateTypes.ExperimentTemplateStopCondition, BaseFunction>>, BaseFunction>? StopConditions { get; set; }

        /// <summary>
        /// Targets
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fis-experimenttemplate.html#cfn-fis-experimenttemplate-targets
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Map
        /// ItemType: ExperimentTemplateTarget
        /// </summary>
        [Required]
        public Union<IReadOnlyDictionary<string, Humidifier.FIS.ExperimentTemplateTypes.ExperimentTemplateTarget>, IReadOnlyDictionary<string, Union<Humidifier.FIS.ExperimentTemplateTypes.ExperimentTemplateTarget, BaseFunction>>, BaseFunction>? Targets { get; set; }
        /// <summary>
        /// LogConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fis-experimenttemplate.html#cfn-fis-experimenttemplate-logconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ExperimentTemplateLogConfiguration
        /// </summary>
        public Union<Humidifier.FIS.ExperimentTemplateTypes.ExperimentTemplateLogConfiguration, BaseFunction>? LogConfiguration { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fis-experimenttemplate.html#cfn-fis-experimenttemplate-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fis-experimenttemplate.html#cfn-fis-experimenttemplate-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ExperimentTemplateTypes
    {
        public class CloudWatchDashboard : Humidifier.Base.BaseSubResource, IHaveDashboardIdentifier
        {
            /// <summary>
            /// DashboardIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fis-experimenttemplate-cloudwatchdashboard.html#cfn-fis-experimenttemplate-cloudwatchdashboard-dashboardidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DashboardIdentifier { get; set; }
        }

        public class CloudWatchLogsConfiguration : Humidifier.Base.BaseSubResource, IHaveLogGroupArn
        {
            /// <summary>
            /// LogGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fis-experimenttemplate-cloudwatchlogsconfiguration.html#cfn-fis-experimenttemplate-cloudwatchlogsconfiguration-loggrouparn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogGroupArn { get; set; }
        }

        public class DataSources : Humidifier.Base.BaseSubResource, IHaveListOfFISExperimentTemplateTypesCloudWatchDashboardCloudWatchDashboards
        {
            /// <summary>
            /// CloudWatchDashboards
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fis-experimenttemplate-datasources.html#cfn-fis-experimenttemplate-datasources-cloudwatchdashboards
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CloudWatchDashboard
            /// </summary>
            public Union<IReadOnlyList<Humidifier.FIS.ExperimentTemplateTypes.CloudWatchDashboard>, IReadOnlyList<Union<Humidifier.FIS.ExperimentTemplateTypes.CloudWatchDashboard, BaseFunction>>, BaseFunction>? CloudWatchDashboards { get; set; }
        }

        public class ExperimentReportS3Configuration : Humidifier.Base.BaseSubResource, IHaveBucketName, IHavePrefix
        {
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fis-experimenttemplate-experimentreports3configuration.html#cfn-fis-experimenttemplate-experimentreports3configuration-bucketname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketName { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fis-experimenttemplate-experimentreports3configuration.html#cfn-fis-experimenttemplate-experimentreports3configuration-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Prefix { get; set; }
        }

        public class ExperimentTemplateAction : Humidifier.Base.BaseSubResource, IHaveActionId, IHaveDescription, IHaveStringDictionaryOfParameters, IHaveStringDictionaryOfTargets, IHaveStringListOfStartAfter
        {
            /// <summary>
            /// ActionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fis-experimenttemplate-experimenttemplateaction.html#cfn-fis-experimenttemplate-experimenttemplateaction-actionid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ActionId { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fis-experimenttemplate-experimenttemplateaction.html#cfn-fis-experimenttemplate-experimenttemplateaction-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fis-experimenttemplate-experimenttemplateaction.html#cfn-fis-experimenttemplate-experimenttemplateaction-parameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Parameters { get; set; }
            /// <summary>
            /// Targets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fis-experimenttemplate-experimenttemplateaction.html#cfn-fis-experimenttemplate-experimenttemplateaction-targets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Targets { get; set; }
            /// <summary>
            /// StartAfter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fis-experimenttemplate-experimenttemplateaction.html#cfn-fis-experimenttemplate-experimenttemplateaction-startafter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? StartAfter { get; set; }
        }

        public class ExperimentTemplateExperimentOptions : Humidifier.Base.BaseSubResource, IHaveEmptyTargetResolutionMode, IHaveAccountTargeting
        {
            /// <summary>
            /// EmptyTargetResolutionMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fis-experimenttemplate-experimenttemplateexperimentoptions.html#cfn-fis-experimenttemplate-experimenttemplateexperimentoptions-emptytargetresolutionmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EmptyTargetResolutionMode { get; set; }
            /// <summary>
            /// AccountTargeting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fis-experimenttemplate-experimenttemplateexperimentoptions.html#cfn-fis-experimenttemplate-experimenttemplateexperimentoptions-accounttargeting
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccountTargeting { get; set; }
        }

        public class ExperimentTemplateExperimentReportConfiguration : Humidifier.Base.BaseSubResource, IHaveFISExperimentTemplateTypesDataSourcesDataSources, IHavePostExperimentDuration, IHaveFISExperimentTemplateTypesOutputsOutputs, IHavePreExperimentDuration
        {
            /// <summary>
            /// DataSources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fis-experimenttemplate-experimenttemplateexperimentreportconfiguration.html#cfn-fis-experimenttemplate-experimenttemplateexperimentreportconfiguration-datasources
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataSources
            /// </summary>
            public Union<Humidifier.FIS.ExperimentTemplateTypes.DataSources, BaseFunction>? DataSources { get; set; }
            /// <summary>
            /// PostExperimentDuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fis-experimenttemplate-experimenttemplateexperimentreportconfiguration.html#cfn-fis-experimenttemplate-experimenttemplateexperimentreportconfiguration-postexperimentduration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PostExperimentDuration { get; set; }
            /// <summary>
            /// Outputs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fis-experimenttemplate-experimenttemplateexperimentreportconfiguration.html#cfn-fis-experimenttemplate-experimenttemplateexperimentreportconfiguration-outputs
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Outputs
            /// </summary>
            public Union<Humidifier.FIS.ExperimentTemplateTypes.Outputs, BaseFunction>? Outputs { get; set; }
            /// <summary>
            /// PreExperimentDuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fis-experimenttemplate-experimenttemplateexperimentreportconfiguration.html#cfn-fis-experimenttemplate-experimenttemplateexperimentreportconfiguration-preexperimentduration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PreExperimentDuration { get; set; }
        }

        public class ExperimentTemplateLogConfiguration : Humidifier.Base.BaseSubResource, IHaveFISExperimentTemplateTypesS3ConfigurationS3Configuration, IHaveLogSchemaVersion_Integer, IHaveFISExperimentTemplateTypesCloudWatchLogsConfigurationCloudWatchLogsConfiguration
        {
            /// <summary>
            /// S3Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fis-experimenttemplate-experimenttemplatelogconfiguration.html#cfn-fis-experimenttemplate-experimenttemplatelogconfiguration-s3configuration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Configuration
            /// </summary>
            public Union<Humidifier.FIS.ExperimentTemplateTypes.S3Configuration, BaseFunction>? S3Configuration { get; set; }
            /// <summary>
            /// LogSchemaVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fis-experimenttemplate-experimenttemplatelogconfiguration.html#cfn-fis-experimenttemplate-experimenttemplatelogconfiguration-logschemaversion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? LogSchemaVersion { get; set; }
            /// <summary>
            /// CloudWatchLogsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fis-experimenttemplate-experimenttemplatelogconfiguration.html#cfn-fis-experimenttemplate-experimenttemplatelogconfiguration-cloudwatchlogsconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudWatchLogsConfiguration
            /// </summary>
            public Union<Humidifier.FIS.ExperimentTemplateTypes.CloudWatchLogsConfiguration, BaseFunction>? CloudWatchLogsConfiguration { get; set; }
        }

        public class ExperimentTemplateStopCondition : Humidifier.Base.BaseSubResource, IHaveValue, IHaveSource
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fis-experimenttemplate-experimenttemplatestopcondition.html#cfn-fis-experimenttemplate-experimenttemplatestopcondition-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fis-experimenttemplate-experimenttemplatestopcondition.html#cfn-fis-experimenttemplate-experimenttemplatestopcondition-source
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Source { get; set; }
        }

        public class ExperimentTemplateTarget : Humidifier.Base.BaseSubResource, IHaveListOfFISExperimentTemplateTypesExperimentTemplateTargetFilterFilters, IHaveStringDictionaryOfParameters, IHaveStringDictionaryOfResourceTags, IHaveResourceType, IHaveStringListOfResourceArns, IHaveSelectionMode
        {
            /// <summary>
            /// Filters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fis-experimenttemplate-experimenttemplatetarget.html#cfn-fis-experimenttemplate-experimenttemplatetarget-filters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ExperimentTemplateTargetFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.FIS.ExperimentTemplateTypes.ExperimentTemplateTargetFilter>, IReadOnlyList<Union<Humidifier.FIS.ExperimentTemplateTypes.ExperimentTemplateTargetFilter, BaseFunction>>, BaseFunction>? Filters { get; set; }
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fis-experimenttemplate-experimenttemplatetarget.html#cfn-fis-experimenttemplate-experimenttemplatetarget-parameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Parameters { get; set; }
            /// <summary>
            /// ResourceTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fis-experimenttemplate-experimenttemplatetarget.html#cfn-fis-experimenttemplate-experimenttemplatetarget-resourcetags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? ResourceTags { get; set; }
            /// <summary>
            /// ResourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fis-experimenttemplate-experimenttemplatetarget.html#cfn-fis-experimenttemplate-experimenttemplatetarget-resourcetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceType { get; set; }
            /// <summary>
            /// ResourceArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fis-experimenttemplate-experimenttemplatetarget.html#cfn-fis-experimenttemplate-experimenttemplatetarget-resourcearns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ResourceArns { get; set; }
            /// <summary>
            /// SelectionMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fis-experimenttemplate-experimenttemplatetarget.html#cfn-fis-experimenttemplate-experimenttemplatetarget-selectionmode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SelectionMode { get; set; }
        }

        public class ExperimentTemplateTargetFilter : Humidifier.Base.BaseSubResource, IHavePath, IHaveStringListOfValues
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fis-experimenttemplate-experimenttemplatetargetfilter.html#cfn-fis-experimenttemplate-experimenttemplatetargetfilter-path
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Path { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fis-experimenttemplate-experimenttemplatetargetfilter.html#cfn-fis-experimenttemplate-experimenttemplatetargetfilter-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
        }

        public class Outputs : Humidifier.Base.BaseSubResource, IHaveFISExperimentTemplateTypesExperimentReportS3ConfigurationExperimentReportS3Configuration
        {
            /// <summary>
            /// ExperimentReportS3Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fis-experimenttemplate-outputs.html#cfn-fis-experimenttemplate-outputs-experimentreports3configuration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ExperimentReportS3Configuration
            /// </summary>
            public Union<Humidifier.FIS.ExperimentTemplateTypes.ExperimentReportS3Configuration, BaseFunction>? ExperimentReportS3Configuration { get; set; }
        }

        public class S3Configuration : Humidifier.Base.BaseSubResource, IHaveBucketName, IHavePrefix
        {
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fis-experimenttemplate-s3configuration.html#cfn-fis-experimenttemplate-s3configuration-bucketname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketName { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fis-experimenttemplate-s3configuration.html#cfn-fis-experimenttemplate-s3configuration-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Prefix { get; set; }
        }
    }
}