namespace Humidifier.APS
{
    using global::System.Collections.Generic;
    using WorkspaceTypes;

    public class Workspace : Humidifier.Base.BaseResource, IHaveTags, IHaveKmsKeyArn, IHaveAlias
    {
        public class Attributes
        {
            public static string PrometheusEndpoint =  "PrometheusEndpoint" ;
            public static string WorkspaceId =  "WorkspaceId" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.APS.Workspace; }
        /// <summary>
        /// KmsKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-aps-workspace.html#cfn-aps-workspace-kmskeyarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KmsKeyArn { get; set; }
        /// <summary>
        /// QueryLoggingConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-aps-workspace.html#cfn-aps-workspace-queryloggingconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: QueryLoggingConfiguration
        /// </summary>
        public Humidifier.APS.WorkspaceTypes.QueryLoggingConfiguration QueryLoggingConfiguration { get; set; }
        /// <summary>
        /// Alias
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-aps-workspace.html#cfn-aps-workspace-alias
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Alias { get; set; }
        /// <summary>
        /// LoggingConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-aps-workspace.html#cfn-aps-workspace-loggingconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LoggingConfiguration
        /// </summary>
        public Humidifier.APS.WorkspaceTypes.LoggingConfiguration LoggingConfiguration { get; set; }
        /// <summary>
        /// WorkspaceConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-aps-workspace.html#cfn-aps-workspace-workspaceconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: WorkspaceConfiguration
        /// </summary>
        public Humidifier.APS.WorkspaceTypes.WorkspaceConfiguration WorkspaceConfiguration { get; set; }
        /// <summary>
        /// AlertManagerDefinition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-aps-workspace.html#cfn-aps-workspace-alertmanagerdefinition
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AlertManagerDefinition { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-aps-workspace.html#cfn-aps-workspace-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace WorkspaceTypes
    {
        public class CloudWatchLogDestination : Humidifier.Base.BaseSubResource, IHaveLogGroupArn
        {
            /// <summary>
            /// LogGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-workspace-cloudwatchlogdestination.html#cfn-aps-workspace-cloudwatchlogdestination-loggrouparn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogGroupArn { get; set; }
        }

        public class Label : Humidifier.Base.BaseSubResource, IHaveName, IHaveValue
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-workspace-label.html#cfn-aps-workspace-label-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-workspace-label.html#cfn-aps-workspace-label-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class LimitsPerLabelSet : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Limits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-workspace-limitsperlabelset.html#cfn-aps-workspace-limitsperlabelset-limits
            /// Required: True
            /// UpdateType: Mutable
            /// Type: LimitsPerLabelSetEntry
            /// </summary>
            public Humidifier.APS.WorkspaceTypes.LimitsPerLabelSetEntry Limits { get; set; }
            /// <summary>
            /// LabelSet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-workspace-limitsperlabelset.html#cfn-aps-workspace-limitsperlabelset-labelset
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Label
            /// </summary>
            public List<Humidifier.APS.WorkspaceTypes.Label> LabelSet { get; set; }
        }

        public class LimitsPerLabelSetEntry : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MaxSeries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-workspace-limitsperlabelsetentry.html#cfn-aps-workspace-limitsperlabelsetentry-maxseries
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxSeries { get; set; }
        }

        public class LoggingConfiguration : Humidifier.Base.BaseSubResource, IHaveLogGroupArn
        {
            /// <summary>
            /// LogGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-workspace-loggingconfiguration.html#cfn-aps-workspace-loggingconfiguration-loggrouparn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogGroupArn { get; set; }
        }

        public class LoggingDestination : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Filters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-workspace-loggingdestination.html#cfn-aps-workspace-loggingdestination-filters
            /// Required: True
            /// UpdateType: Mutable
            /// Type: LoggingFilter
            /// </summary>
            public Humidifier.APS.WorkspaceTypes.LoggingFilter Filters { get; set; }
            /// <summary>
            /// CloudWatchLogs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-workspace-loggingdestination.html#cfn-aps-workspace-loggingdestination-cloudwatchlogs
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CloudWatchLogDestination
            /// </summary>
            public Humidifier.APS.WorkspaceTypes.CloudWatchLogDestination CloudWatchLogs { get; set; }
        }

        public class LoggingFilter : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// QspThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-workspace-loggingfilter.html#cfn-aps-workspace-loggingfilter-qspthreshold
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic QspThreshold { get; set; }
        }

        public class QueryLoggingConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Destinations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-workspace-queryloggingconfiguration.html#cfn-aps-workspace-queryloggingconfiguration-destinations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: LoggingDestination
            /// </summary>
            public List<Humidifier.APS.WorkspaceTypes.LoggingDestination> Destinations { get; set; }
        }

        public class WorkspaceConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RuleQueryOffsetInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-workspace-workspaceconfiguration.html#cfn-aps-workspace-workspaceconfiguration-rulequeryoffsetinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RuleQueryOffsetInSeconds { get; set; }
            /// <summary>
            /// RetentionPeriodInDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-workspace-workspaceconfiguration.html#cfn-aps-workspace-workspaceconfiguration-retentionperiodindays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RetentionPeriodInDays { get; set; }
            /// <summary>
            /// OutOfOrderTimeWindowInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-workspace-workspaceconfiguration.html#cfn-aps-workspace-workspaceconfiguration-outofordertimewindowinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic OutOfOrderTimeWindowInSeconds { get; set; }
            /// <summary>
            /// LimitsPerLabelSets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-workspace-workspaceconfiguration.html#cfn-aps-workspace-workspaceconfiguration-limitsperlabelsets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: LimitsPerLabelSet
            /// </summary>
            public List<Humidifier.APS.WorkspaceTypes.LimitsPerLabelSet> LimitsPerLabelSets { get; set; }
        }
    }
}