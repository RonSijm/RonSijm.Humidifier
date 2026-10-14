namespace Humidifier.BedrockAgentCore
{
    using global::System.Collections.Generic;
    using OnlineEvaluationConfigTypes;

    public class OnlineEvaluationConfig : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription
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
        public dynamic OnlineEvaluationConfigName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-onlineevaluationconfig.html#cfn-bedrockagentcore-onlineevaluationconfig-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// Insights
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-onlineevaluationconfig.html#cfn-bedrockagentcore-onlineevaluationconfig-insights
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Insight
        /// </summary>
        public List<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.Insight> Insights { get; set; }
        /// <summary>
        /// OutputConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-onlineevaluationconfig.html#cfn-bedrockagentcore-onlineevaluationconfig-outputconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: OutputConfig
        /// </summary>
        public Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.OutputConfig OutputConfig { get; set; }
        /// <summary>
        /// ExecutionStatus
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-onlineevaluationconfig.html#cfn-bedrockagentcore-onlineevaluationconfig-executionstatus
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ExecutionStatus { get; set; }

        /// <summary>
        /// DataSourceConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-onlineevaluationconfig.html#cfn-bedrockagentcore-onlineevaluationconfig-datasourceconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: DataSourceConfig
        /// </summary>
        [Required]
        public Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.DataSourceConfig DataSourceConfig { get; set; }
        /// <summary>
        /// ClusteringConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-onlineevaluationconfig.html#cfn-bedrockagentcore-onlineevaluationconfig-clusteringconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ClusteringConfig
        /// </summary>
        public Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.ClusteringConfig ClusteringConfig { get; set; }

        /// <summary>
        /// EvaluationExecutionRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-onlineevaluationconfig.html#cfn-bedrockagentcore-onlineevaluationconfig-evaluationexecutionrolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic EvaluationExecutionRoleArn { get; set; }
        /// <summary>
        /// Evaluators
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-onlineevaluationconfig.html#cfn-bedrockagentcore-onlineevaluationconfig-evaluators
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: EvaluatorReference
        /// </summary>
        public List<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.EvaluatorReference> Evaluators { get; set; }

        /// <summary>
        /// Rule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-onlineevaluationconfig.html#cfn-bedrockagentcore-onlineevaluationconfig-rule
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Rule
        /// </summary>
        [Required]
        public Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.Rule Rule { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-onlineevaluationconfig.html#cfn-bedrockagentcore-onlineevaluationconfig-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace OnlineEvaluationConfigTypes
    {
        public class CloudWatchLogsInputConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LogGroupNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-onlineevaluationconfig-cloudwatchlogsinputconfig.html#cfn-bedrockagentcore-onlineevaluationconfig-cloudwatchlogsinputconfig-loggroupnames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic LogGroupNames { get; set; }
            /// <summary>
            /// LogGroupNamePrefixes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-onlineevaluationconfig-cloudwatchlogsinputconfig.html#cfn-bedrockagentcore-onlineevaluationconfig-cloudwatchlogsinputconfig-loggroupnameprefixes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic LogGroupNamePrefixes { get; set; }
            /// <summary>
            /// ServiceNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-onlineevaluationconfig-cloudwatchlogsinputconfig.html#cfn-bedrockagentcore-onlineevaluationconfig-cloudwatchlogsinputconfig-servicenames
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ServiceNames { get; set; }
        }

        public class CloudWatchOutputConfig : Humidifier.Base.BaseSubResource, IHaveLogGroupName
        {
            /// <summary>
            /// MetricsNamespace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-onlineevaluationconfig-cloudwatchoutputconfig.html#cfn-bedrockagentcore-onlineevaluationconfig-cloudwatchoutputconfig-metricsnamespace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MetricsNamespace { get; set; }
            /// <summary>
            /// ResultDestination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-onlineevaluationconfig-cloudwatchoutputconfig.html#cfn-bedrockagentcore-onlineevaluationconfig-cloudwatchoutputconfig-resultdestination
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResultDestination { get; set; }
            /// <summary>
            /// LogGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-onlineevaluationconfig-cloudwatchoutputconfig.html#cfn-bedrockagentcore-onlineevaluationconfig-cloudwatchoutputconfig-loggroupname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogGroupName { get; set; }
        }

        public class ClusteringConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Frequencies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-onlineevaluationconfig-clusteringconfig.html#cfn-bedrockagentcore-onlineevaluationconfig-clusteringconfig-frequencies
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Frequencies { get; set; }
        }

        public class DataSourceConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CloudWatchLogs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-onlineevaluationconfig-datasourceconfig.html#cfn-bedrockagentcore-onlineevaluationconfig-datasourceconfig-cloudwatchlogs
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CloudWatchLogsInputConfig
            /// </summary>
            public Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.CloudWatchLogsInputConfig CloudWatchLogs { get; set; }
        }

        public class EvaluatorReference : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EvaluatorId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-onlineevaluationconfig-evaluatorreference.html#cfn-bedrockagentcore-onlineevaluationconfig-evaluatorreference-evaluatorid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EvaluatorId { get; set; }
        }

        public class Filter : Humidifier.Base.BaseSubResource, IHaveKey, IHaveOperator
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-onlineevaluationconfig-filter.html#cfn-bedrockagentcore-onlineevaluationconfig-filter-operator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Operator { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-onlineevaluationconfig-filter.html#cfn-bedrockagentcore-onlineevaluationconfig-filter-value
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FilterValue
            /// </summary>
            public Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.FilterValue Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-onlineevaluationconfig-filter.html#cfn-bedrockagentcore-onlineevaluationconfig-filter-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class FilterValue : Humidifier.Base.BaseSubResource, IHaveStringValue, IHaveDoubleValue, IHaveBooleanValue
        {
            /// <summary>
            /// DoubleValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-onlineevaluationconfig-filtervalue.html#cfn-bedrockagentcore-onlineevaluationconfig-filtervalue-doublevalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic DoubleValue { get; set; }
            /// <summary>
            /// BooleanValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-onlineevaluationconfig-filtervalue.html#cfn-bedrockagentcore-onlineevaluationconfig-filtervalue-booleanvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic BooleanValue { get; set; }
            /// <summary>
            /// StringValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-onlineevaluationconfig-filtervalue.html#cfn-bedrockagentcore-onlineevaluationconfig-filtervalue-stringvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StringValue { get; set; }
        }

        public class Insight : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// InsightId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-onlineevaluationconfig-insight.html#cfn-bedrockagentcore-onlineevaluationconfig-insight-insightid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InsightId { get; set; }
        }

        public class OutputConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CloudWatchConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-onlineevaluationconfig-outputconfig.html#cfn-bedrockagentcore-onlineevaluationconfig-outputconfig-cloudwatchconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudWatchOutputConfig
            /// </summary>
            public Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.CloudWatchOutputConfig CloudWatchConfig { get; set; }
        }

        public class Rule : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Filters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-onlineevaluationconfig-rule.html#cfn-bedrockagentcore-onlineevaluationconfig-rule-filters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Filter
            /// </summary>
            public List<Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.Filter> Filters { get; set; }
            /// <summary>
            /// SessionConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-onlineevaluationconfig-rule.html#cfn-bedrockagentcore-onlineevaluationconfig-rule-sessionconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SessionConfig
            /// </summary>
            public Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.SessionConfig SessionConfig { get; set; }
            /// <summary>
            /// SamplingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-onlineevaluationconfig-rule.html#cfn-bedrockagentcore-onlineevaluationconfig-rule-samplingconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SamplingConfig
            /// </summary>
            public Humidifier.BedrockAgentCore.OnlineEvaluationConfigTypes.SamplingConfig SamplingConfig { get; set; }
        }

        public class SamplingConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SamplingPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-onlineevaluationconfig-samplingconfig.html#cfn-bedrockagentcore-onlineevaluationconfig-samplingconfig-samplingpercentage
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic SamplingPercentage { get; set; }
        }

        public class SessionConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SessionTimeoutMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-onlineevaluationconfig-sessionconfig.html#cfn-bedrockagentcore-onlineevaluationconfig-sessionconfig-sessiontimeoutminutes
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic SessionTimeoutMinutes { get; set; }
        }
    }
}