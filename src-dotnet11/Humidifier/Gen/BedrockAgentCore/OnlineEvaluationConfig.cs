namespace Humidifier.BedrockAgentCore
{
    using global::System.Collections.Generic;
    using OnlineEvaluationConfigTypes;

    public class OnlineEvaluationConfig : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveOnlineEvaluationConfigName, IHaveDescription, IHaveListOfBedrockAgentCoreOnlineEvaluationConfigTypesInsightInsights, IHaveBedrockAgentCoreOnlineEvaluationConfigTypesOutputConfigOutputConfig, IHaveExecutionStatus, IHaveBedrockAgentCoreOnlineEvaluationConfigTypesDataSourceConfigDataSourceConfig, IHaveBedrockAgentCoreOnlineEvaluationConfigTypesClusteringConfigClusteringConfig, IHaveEvaluationExecutionRoleArn, IHaveListOfBedrockAgentCoreOnlineEvaluationConfigTypesEvaluatorReferenceEvaluators, IHaveBedrockAgentCoreOnlineEvaluationConfigTypesRuleRule
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string OnlineEvaluationConfigId =  "OnlineEvaluationConfigId" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string OnlineEvaluationConfigArn =  "OnlineEvaluationConfigArn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.BedrockAgentCore.OnlineEvaluationConfig; }
        public Union<string, BaseFunction>? OnlineEvaluationConfigName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-onlineevaluationconfig.html#cfn-bedrockagentcore-onlineevaluationconfig-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// Insights
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-onlineevaluationconfig.html#cfn-bedrockagentcore-onlineevaluationconfig-insights
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Insight
        /// </summary>
        public Union<IReadOnlyList<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.Insight>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.Insight, BaseFunction>>, BaseFunction>? Insights { get; set; }
        /// <summary>
        /// OutputConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-onlineevaluationconfig.html#cfn-bedrockagentcore-onlineevaluationconfig-outputconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: OutputConfig
        /// </summary>
        public Union<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.OutputConfig, BaseFunction>? OutputConfig { get; set; }
        /// <summary>
        /// ExecutionStatus
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-onlineevaluationconfig.html#cfn-bedrockagentcore-onlineevaluationconfig-executionstatus
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ExecutionStatus { get; set; }

        /// <summary>
        /// DataSourceConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-onlineevaluationconfig.html#cfn-bedrockagentcore-onlineevaluationconfig-datasourceconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: DataSourceConfig
        /// </summary>
        [Required]
        public Union<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.DataSourceConfig, BaseFunction>? DataSourceConfig { get; set; }
        /// <summary>
        /// ClusteringConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-onlineevaluationconfig.html#cfn-bedrockagentcore-onlineevaluationconfig-clusteringconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ClusteringConfig
        /// </summary>
        public Union<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.ClusteringConfig, BaseFunction>? ClusteringConfig { get; set; }

        /// <summary>
        /// EvaluationExecutionRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-onlineevaluationconfig.html#cfn-bedrockagentcore-onlineevaluationconfig-evaluationexecutionrolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? EvaluationExecutionRoleArn { get; set; }
        /// <summary>
        /// Evaluators
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-onlineevaluationconfig.html#cfn-bedrockagentcore-onlineevaluationconfig-evaluators
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: EvaluatorReference
        /// </summary>
        public Union<IReadOnlyList<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.EvaluatorReference>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.EvaluatorReference, BaseFunction>>, BaseFunction>? Evaluators { get; set; }

        /// <summary>
        /// Rule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-onlineevaluationconfig.html#cfn-bedrockagentcore-onlineevaluationconfig-rule
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Rule
        /// </summary>
        [Required]
        public Union<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.Rule, BaseFunction>? Rule { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-onlineevaluationconfig.html#cfn-bedrockagentcore-onlineevaluationconfig-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace OnlineEvaluationConfigTypes
    {
        public class CloudWatchLogsInputConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfLogGroupNames, IHaveStringListOfLogGroupNamePrefixes, IHaveStringListOfServiceNames
        {
            /// <summary>
            /// LogGroupNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-onlineevaluationconfig-cloudwatchlogsinputconfig.html#cfn-bedrockagentcore-onlineevaluationconfig-cloudwatchlogsinputconfig-loggroupnames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LogGroupNames { get; set; }
            /// <summary>
            /// LogGroupNamePrefixes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-onlineevaluationconfig-cloudwatchlogsinputconfig.html#cfn-bedrockagentcore-onlineevaluationconfig-cloudwatchlogsinputconfig-loggroupnameprefixes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LogGroupNamePrefixes { get; set; }
            /// <summary>
            /// ServiceNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-onlineevaluationconfig-cloudwatchlogsinputconfig.html#cfn-bedrockagentcore-onlineevaluationconfig-cloudwatchlogsinputconfig-servicenames
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ServiceNames { get; set; }
        }

        public class CloudWatchOutputConfig : Humidifier.Base.BaseSubResource, IHaveMetricsNamespace, IHaveResultDestination, IHaveLogGroupName
        {
            /// <summary>
            /// MetricsNamespace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-onlineevaluationconfig-cloudwatchoutputconfig.html#cfn-bedrockagentcore-onlineevaluationconfig-cloudwatchoutputconfig-metricsnamespace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetricsNamespace { get; set; }
            /// <summary>
            /// ResultDestination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-onlineevaluationconfig-cloudwatchoutputconfig.html#cfn-bedrockagentcore-onlineevaluationconfig-cloudwatchoutputconfig-resultdestination
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResultDestination { get; set; }
            /// <summary>
            /// LogGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-onlineevaluationconfig-cloudwatchoutputconfig.html#cfn-bedrockagentcore-onlineevaluationconfig-cloudwatchoutputconfig-loggroupname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogGroupName { get; set; }
        }

        public class ClusteringConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfFrequencies
        {
            /// <summary>
            /// Frequencies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-onlineevaluationconfig-clusteringconfig.html#cfn-bedrockagentcore-onlineevaluationconfig-clusteringconfig-frequencies
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Frequencies { get; set; }
        }

        public class DataSourceConfig : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreOnlineEvaluationConfigTypesCloudWatchLogsInputConfigCloudWatchLogs
        {
            /// <summary>
            /// CloudWatchLogs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-onlineevaluationconfig-datasourceconfig.html#cfn-bedrockagentcore-onlineevaluationconfig-datasourceconfig-cloudwatchlogs
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CloudWatchLogsInputConfig
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.CloudWatchLogsInputConfig, BaseFunction>? CloudWatchLogs { get; set; }
        }

        public class EvaluatorReference : Humidifier.Base.BaseSubResource, IHaveEvaluatorId
        {
            /// <summary>
            /// EvaluatorId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-onlineevaluationconfig-evaluatorreference.html#cfn-bedrockagentcore-onlineevaluationconfig-evaluatorreference-evaluatorid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EvaluatorId { get; set; }
        }

        public class Filter : Humidifier.Base.BaseSubResource, IHaveOperator, IHaveBedrockAgentCoreOnlineEvaluationConfigTypesFilterValueValue, IHaveKey
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-onlineevaluationconfig-filter.html#cfn-bedrockagentcore-onlineevaluationconfig-filter-operator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Operator { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-onlineevaluationconfig-filter.html#cfn-bedrockagentcore-onlineevaluationconfig-filter-value
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FilterValue
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.FilterValue, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-onlineevaluationconfig-filter.html#cfn-bedrockagentcore-onlineevaluationconfig-filter-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class FilterValue : Humidifier.Base.BaseSubResource, IHaveDoubleValue_Double, IHaveBooleanValue_Boolean, IHaveStringValue
        {
            /// <summary>
            /// DoubleValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-onlineevaluationconfig-filtervalue.html#cfn-bedrockagentcore-onlineevaluationconfig-filtervalue-doublevalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? DoubleValue { get; set; }
            /// <summary>
            /// BooleanValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-onlineevaluationconfig-filtervalue.html#cfn-bedrockagentcore-onlineevaluationconfig-filtervalue-booleanvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? BooleanValue { get; set; }
            /// <summary>
            /// StringValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-onlineevaluationconfig-filtervalue.html#cfn-bedrockagentcore-onlineevaluationconfig-filtervalue-stringvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StringValue { get; set; }
        }

        public class Insight : Humidifier.Base.BaseSubResource, IHaveInsightId
        {
            /// <summary>
            /// InsightId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-onlineevaluationconfig-insight.html#cfn-bedrockagentcore-onlineevaluationconfig-insight-insightid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InsightId { get; set; }
        }

        public class OutputConfig : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreOnlineEvaluationConfigTypesCloudWatchOutputConfigCloudWatchConfig
        {
            /// <summary>
            /// CloudWatchConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-onlineevaluationconfig-outputconfig.html#cfn-bedrockagentcore-onlineevaluationconfig-outputconfig-cloudwatchconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudWatchOutputConfig
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.CloudWatchOutputConfig, BaseFunction>? CloudWatchConfig { get; set; }
        }

        public class Rule : Humidifier.Base.BaseSubResource, IHaveListOfBedrockAgentCoreOnlineEvaluationConfigTypesFilterFilters, IHaveBedrockAgentCoreOnlineEvaluationConfigTypesSessionConfigSessionConfig, IHaveBedrockAgentCoreOnlineEvaluationConfigTypesSamplingConfigSamplingConfig
        {
            /// <summary>
            /// Filters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-onlineevaluationconfig-rule.html#cfn-bedrockagentcore-onlineevaluationconfig-rule-filters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Filter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.Filter>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.Filter, BaseFunction>>, BaseFunction>? Filters { get; set; }
            /// <summary>
            /// SessionConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-onlineevaluationconfig-rule.html#cfn-bedrockagentcore-onlineevaluationconfig-rule-sessionconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SessionConfig
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.SessionConfig, BaseFunction>? SessionConfig { get; set; }
            /// <summary>
            /// SamplingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-onlineevaluationconfig-rule.html#cfn-bedrockagentcore-onlineevaluationconfig-rule-samplingconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SamplingConfig
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.SamplingConfig, BaseFunction>? SamplingConfig { get; set; }
        }

        public class SamplingConfig : Humidifier.Base.BaseSubResource, IHaveSamplingPercentage_Double
        {
            /// <summary>
            /// SamplingPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-onlineevaluationconfig-samplingconfig.html#cfn-bedrockagentcore-onlineevaluationconfig-samplingconfig-samplingpercentage
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? SamplingPercentage { get; set; }
        }

        public class SessionConfig : Humidifier.Base.BaseSubResource, IHaveSessionTimeoutMinutes_Integer
        {
            /// <summary>
            /// SessionTimeoutMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-onlineevaluationconfig-sessionconfig.html#cfn-bedrockagentcore-onlineevaluationconfig-sessionconfig-sessiontimeoutminutes
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SessionTimeoutMinutes { get; set; }
        }
    }
}