namespace Humidifier.CloudWatch
{
    using global::System.Collections.Generic;
    using LogAlarmTypes;

    public class LogAlarm : Humidifier.Base.BaseResource, IHaveTags, IHaveComparisonOperator, IHaveTreatMissingData, IHaveCloudWatchLogAlarmTypesScheduledQueryConfigurationScheduledQueryConfiguration, IHaveQueryResultsToEvaluate_Integer, IHaveStringListOfOKActions, IHaveStringListOfAlarmActions, IHaveActionsEnabled_Boolean, IHaveActionLogLineRoleArn, IHaveAlarmName, IHaveAlarmDescription, IHaveCloudWatchLogAlarmTypesWarmUpConfigurationWarmUpConfiguration, IHaveActionLogLineCount_Integer, IHaveStringListOfInsufficientDataActions, IHaveQueryResultsToAlarm_Integer, IHaveCloudWatchLogAlarmTypesActionConfigurationActionConfiguration, IHaveThreshold_Double
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.CloudWatch.LogAlarm; }

        /// <summary>
        /// ComparisonOperator
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-logalarm.html#cfn-cloudwatch-logalarm-comparisonoperator
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ComparisonOperator { get; set; }
        /// <summary>
        /// TreatMissingData
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-logalarm.html#cfn-cloudwatch-logalarm-treatmissingdata
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TreatMissingData { get; set; }

        /// <summary>
        /// ScheduledQueryConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-logalarm.html#cfn-cloudwatch-logalarm-scheduledqueryconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ScheduledQueryConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.CloudWatch.LogAlarmTypes.ScheduledQueryConfiguration, BaseFunction>? ScheduledQueryConfiguration { get; set; }

        /// <summary>
        /// QueryResultsToEvaluate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-logalarm.html#cfn-cloudwatch-logalarm-queryresultstoevaluate
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? QueryResultsToEvaluate { get; set; }
        /// <summary>
        /// OKActions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-logalarm.html#cfn-cloudwatch-logalarm-okactions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? OKActions { get; set; }
        /// <summary>
        /// AlarmActions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-logalarm.html#cfn-cloudwatch-logalarm-alarmactions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AlarmActions { get; set; }
        /// <summary>
        /// ActionsEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-logalarm.html#cfn-cloudwatch-logalarm-actionsenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? ActionsEnabled { get; set; }
        /// <summary>
        /// ActionLogLineRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-logalarm.html#cfn-cloudwatch-logalarm-actionloglinerolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ActionLogLineRoleArn { get; set; }
        /// <summary>
        /// AlarmName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-logalarm.html#cfn-cloudwatch-logalarm-alarmname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AlarmName { get; set; }
        /// <summary>
        /// AlarmDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-logalarm.html#cfn-cloudwatch-logalarm-alarmdescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AlarmDescription { get; set; }
        /// <summary>
        /// WarmUpConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-logalarm.html#cfn-cloudwatch-logalarm-warmupconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: WarmUpConfiguration
        /// </summary>
        public Union<Humidifier.CloudWatch.LogAlarmTypes.WarmUpConfiguration, BaseFunction>? WarmUpConfiguration { get; set; }
        /// <summary>
        /// ActionLogLineCount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-logalarm.html#cfn-cloudwatch-logalarm-actionloglinecount
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? ActionLogLineCount { get; set; }
        /// <summary>
        /// InsufficientDataActions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-logalarm.html#cfn-cloudwatch-logalarm-insufficientdataactions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? InsufficientDataActions { get; set; }

        /// <summary>
        /// QueryResultsToAlarm
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-logalarm.html#cfn-cloudwatch-logalarm-queryresultstoalarm
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? QueryResultsToAlarm { get; set; }
        /// <summary>
        /// ActionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-logalarm.html#cfn-cloudwatch-logalarm-actionconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ActionConfiguration
        /// </summary>
        public Union<Humidifier.CloudWatch.LogAlarmTypes.ActionConfiguration, BaseFunction>? ActionConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-logalarm.html#cfn-cloudwatch-logalarm-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// Threshold
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-logalarm.html#cfn-cloudwatch-logalarm-threshold
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Double
        /// </summary>
        [Required]
        public Union<double, BaseFunction>? Threshold { get; set; }
    }

    namespace LogAlarmTypes
    {
        public class ActionConfiguration : Humidifier.Base.BaseSubResource, IHaveCloudWatchLogAlarmTypesAlarmTagsPropagationAlarmTagsPropagation
        {
            /// <summary>
            /// AlarmTagsPropagation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-logalarm-actionconfiguration.html#cfn-cloudwatch-logalarm-actionconfiguration-alarmtagspropagation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AlarmTagsPropagation
            /// </summary>
            public Union<Humidifier.CloudWatch.LogAlarmTypes.AlarmTagsPropagation, BaseFunction>? AlarmTagsPropagation { get; set; }
        }

        public class AlarmTagsPropagation : Humidifier.Base.BaseSubResource, IHaveStringListOfIncludedTagKeys, IHaveStringListOfExcludedTagKeys, IHaveEnabled_Boolean
        {
            /// <summary>
            /// IncludedTagKeys
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-logalarm-alarmtagspropagation.html#cfn-cloudwatch-logalarm-alarmtagspropagation-includedtagkeys
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? IncludedTagKeys { get; set; }
            /// <summary>
            /// ExcludedTagKeys
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-logalarm-alarmtagspropagation.html#cfn-cloudwatch-logalarm-alarmtagspropagation-excludedtagkeys
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ExcludedTagKeys { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-logalarm-alarmtagspropagation.html#cfn-cloudwatch-logalarm-alarmtagspropagation-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class ScheduleConfiguration : Humidifier.Base.BaseSubResource, IHaveScheduleExpression, IHaveStartTimeOffset_Integer, IHaveEndTimeOffset_Integer
        {
            /// <summary>
            /// ScheduleExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-logalarm-scheduleconfiguration.html#cfn-cloudwatch-logalarm-scheduleconfiguration-scheduleexpression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScheduleExpression { get; set; }
            /// <summary>
            /// StartTimeOffset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-logalarm-scheduleconfiguration.html#cfn-cloudwatch-logalarm-scheduleconfiguration-starttimeoffset
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? StartTimeOffset { get; set; }
            /// <summary>
            /// EndTimeOffset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-logalarm-scheduleconfiguration.html#cfn-cloudwatch-logalarm-scheduleconfiguration-endtimeoffset
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? EndTimeOffset { get; set; }
        }

        public class ScheduledQueryConfiguration : Humidifier.Base.BaseSubResource, IHaveTags, IHaveScheduledQueryRoleARN, IHaveCloudWatchLogAlarmTypesScheduleConfigurationScheduleConfiguration, IHaveQueryString, IHaveStringListOfLogGroupIdentifiers, IHaveAggregationExpression
        {
            /// <summary>
            /// ScheduledQueryRoleARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-logalarm-scheduledqueryconfiguration.html#cfn-cloudwatch-logalarm-scheduledqueryconfiguration-scheduledqueryrolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScheduledQueryRoleARN { get; set; }
            /// <summary>
            /// ScheduleConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-logalarm-scheduledqueryconfiguration.html#cfn-cloudwatch-logalarm-scheduledqueryconfiguration-scheduleconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ScheduleConfiguration
            /// </summary>
            public Union<Humidifier.CloudWatch.LogAlarmTypes.ScheduleConfiguration, BaseFunction>? ScheduleConfiguration { get; set; }
            /// <summary>
            /// QueryString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-logalarm-scheduledqueryconfiguration.html#cfn-cloudwatch-logalarm-scheduledqueryconfiguration-querystring
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? QueryString { get; set; }
            /// <summary>
            /// LogGroupIdentifiers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-logalarm-scheduledqueryconfiguration.html#cfn-cloudwatch-logalarm-scheduledqueryconfiguration-loggroupidentifiers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LogGroupIdentifiers { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-logalarm-scheduledqueryconfiguration.html#cfn-cloudwatch-logalarm-scheduledqueryconfiguration-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
            /// <summary>
            /// AggregationExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-logalarm-scheduledqueryconfiguration.html#cfn-cloudwatch-logalarm-scheduledqueryconfiguration-aggregationexpression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AggregationExpression { get; set; }
        }

        public class WarmUpConfiguration : Humidifier.Base.BaseSubResource, IHaveWarmUpPeriodDurationInMinutes_Integer, IHaveOnlyStartEvaluatingAfterWarmUpPeriodEnds_Boolean
        {
            /// <summary>
            /// WarmUpPeriodDurationInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-logalarm-warmupconfiguration.html#cfn-cloudwatch-logalarm-warmupconfiguration-warmupperioddurationinminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? WarmUpPeriodDurationInMinutes { get; set; }
            /// <summary>
            /// OnlyStartEvaluatingAfterWarmUpPeriodEnds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-logalarm-warmupconfiguration.html#cfn-cloudwatch-logalarm-warmupconfiguration-onlystartevaluatingafterwarmupperiodends
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? OnlyStartEvaluatingAfterWarmUpPeriodEnds { get; set; }
        }
    }
}