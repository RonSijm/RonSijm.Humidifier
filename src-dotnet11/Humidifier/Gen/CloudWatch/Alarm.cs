namespace Humidifier.CloudWatch
{
    using global::System.Collections.Generic;
    using AlarmTypes;

    public class Alarm : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveThresholdMetricId, IHaveComparisonOperator, IHaveEvaluationPeriods_Integer, IHaveUnit, IHaveStringListOfOKActions, IHaveMetricName, IHaveActionsEnabled_Boolean, IHaveListOfCloudWatchAlarmTypesMetricDataQueryMetrics, IHaveAlarmName, IHaveStatistic, IHaveCloudWatchAlarmTypesWarmUpConfigurationWarmUpConfiguration, IHaveCloudWatchAlarmTypesEvaluationWindowEvaluationWindow, IHaveStringListOfInsufficientDataActions, IHaveEvaluationInterval_Integer, IHaveDatapointsToAlarm_Integer, IHaveThreshold_Double, IHaveEvaluateLowSampleCountPercentile, IHaveExtendedStatistic, IHaveTreatMissingData, IHaveListOfCloudWatchAlarmTypesDimensionDimensions, IHavePeriod_Integer, IHaveCloudWatchAlarmTypesEvaluationCriteriaEvaluationCriteria, IHaveNamespace_, IHaveStringListOfAlarmActions, IHaveAlarmDescription, IHaveDescription
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.CloudWatch.Alarm; }
        /// <summary>
        /// ThresholdMetricId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-alarm.html#cfn-cloudwatch-alarm-thresholdmetricid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ThresholdMetricId { get; set; }
        /// <summary>
        /// ComparisonOperator
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-alarm.html#cfn-cloudwatch-alarm-comparisonoperator
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ComparisonOperator { get; set; }
        /// <summary>
        /// EvaluationPeriods
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-alarm.html#cfn-cloudwatch-alarm-evaluationperiods
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? EvaluationPeriods { get; set; }
        /// <summary>
        /// Unit
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-alarm.html#cfn-cloudwatch-alarm-unit
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Unit { get; set; }
        /// <summary>
        /// OKActions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-alarm.html#cfn-cloudwatch-alarm-okactions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? OKActions { get; set; }
        /// <summary>
        /// MetricName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-alarm.html#cfn-cloudwatch-alarm-metricname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? MetricName { get; set; }
        /// <summary>
        /// ActionsEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-alarm.html#cfn-cloudwatch-alarm-actionsenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? ActionsEnabled { get; set; }
        /// <summary>
        /// Metrics
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-alarm.html#cfn-cloudwatch-alarm-metrics
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: MetricDataQuery
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CloudWatch.AlarmTypes.MetricDataQuery>, IReadOnlyList<Union<Humidifier.CloudWatch.AlarmTypes.MetricDataQuery, BaseFunction>>, BaseFunction>? Metrics { get; set; }
        public Union<string, BaseFunction>? AlarmName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Statistic
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-alarm.html#cfn-cloudwatch-alarm-statistic
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Statistic { get; set; }
        /// <summary>
        /// WarmUpConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-alarm.html#cfn-cloudwatch-alarm-warmupconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: WarmUpConfiguration
        /// </summary>
        public Union<Humidifier.CloudWatch.AlarmTypes.WarmUpConfiguration, BaseFunction>? WarmUpConfiguration { get; set; }
        /// <summary>
        /// EvaluationWindow
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-alarm.html#cfn-cloudwatch-alarm-evaluationwindow
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EvaluationWindow
        /// </summary>
        public Union<Humidifier.CloudWatch.AlarmTypes.EvaluationWindow, BaseFunction>? EvaluationWindow { get; set; }
        /// <summary>
        /// InsufficientDataActions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-alarm.html#cfn-cloudwatch-alarm-insufficientdataactions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? InsufficientDataActions { get; set; }
        /// <summary>
        /// EvaluationInterval
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-alarm.html#cfn-cloudwatch-alarm-evaluationinterval
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? EvaluationInterval { get; set; }
        /// <summary>
        /// DatapointsToAlarm
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-alarm.html#cfn-cloudwatch-alarm-datapointstoalarm
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? DatapointsToAlarm { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-alarm.html#cfn-cloudwatch-alarm-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// Threshold
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-alarm.html#cfn-cloudwatch-alarm-threshold
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Double
        /// </summary>
        public Union<double, BaseFunction>? Threshold { get; set; }
        /// <summary>
        /// EvaluateLowSampleCountPercentile
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-alarm.html#cfn-cloudwatch-alarm-evaluatelowsamplecountpercentile
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EvaluateLowSampleCountPercentile { get; set; }
        /// <summary>
        /// ExtendedStatistic
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-alarm.html#cfn-cloudwatch-alarm-extendedstatistic
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ExtendedStatistic { get; set; }
        /// <summary>
        /// TreatMissingData
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-alarm.html#cfn-cloudwatch-alarm-treatmissingdata
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TreatMissingData { get; set; }
        /// <summary>
        /// Dimensions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-alarm.html#cfn-cloudwatch-alarm-dimensions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Dimension
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CloudWatch.AlarmTypes.Dimension>, IReadOnlyList<Union<Humidifier.CloudWatch.AlarmTypes.Dimension, BaseFunction>>, BaseFunction>? Dimensions { get; set; }
        /// <summary>
        /// Period
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-alarm.html#cfn-cloudwatch-alarm-period
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? Period { get; set; }
        /// <summary>
        /// EvaluationCriteria
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-alarm.html#cfn-cloudwatch-alarm-evaluationcriteria
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EvaluationCriteria
        /// </summary>
        public Union<Humidifier.CloudWatch.AlarmTypes.EvaluationCriteria, BaseFunction>? EvaluationCriteria { get; set; }
        /// <summary>
        /// Namespace_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-alarm.html#cfn-cloudwatch-alarm-namespace
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Namespace_ { get; set; }
        /// <summary>
        /// AlarmActions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-alarm.html#cfn-cloudwatch-alarm-alarmactions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AlarmActions { get; set; }
        /// <summary>
        /// AlarmDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-alarm.html#cfn-cloudwatch-alarm-alarmdescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AlarmDescription { get; set; }

        [Ignore]
        public Union<string, BaseFunction>? Description { get => AlarmDescription; set => AlarmDescription = value; }
    }

    namespace AlarmTypes
    {
        public class AlarmPromQLCriteria : Humidifier.Base.BaseSubResource, IHavePendingPeriod_Integer, IHaveQuery, IHaveRecoveryPeriod_Integer
        {
            /// <summary>
            /// PendingPeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alarm-alarmpromqlcriteria.html#cfn-cloudwatch-alarm-alarmpromqlcriteria-pendingperiod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? PendingPeriod { get; set; }
            /// <summary>
            /// Query
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alarm-alarmpromqlcriteria.html#cfn-cloudwatch-alarm-alarmpromqlcriteria-query
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Query { get; set; }
            /// <summary>
            /// RecoveryPeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alarm-alarmpromqlcriteria.html#cfn-cloudwatch-alarm-alarmpromqlcriteria-recoveryperiod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RecoveryPeriod { get; set; }
        }

        public class Dimension : Humidifier.Base.BaseSubResource, IHaveValue, IHaveName
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alarm-dimension.html#cfn-cloudwatch-alarm-dimension-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alarm-dimension.html#cfn-cloudwatch-alarm-dimension-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class EvaluationCriteria : Humidifier.Base.BaseSubResource, IHaveCloudWatchAlarmTypesAlarmPromQLCriteriaPromQLCriteria
        {
            /// <summary>
            /// PromQLCriteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alarm-evaluationcriteria.html#cfn-cloudwatch-alarm-evaluationcriteria-promqlcriteria
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AlarmPromQLCriteria
            /// </summary>
            public Union<Humidifier.CloudWatch.AlarmTypes.AlarmPromQLCriteria, BaseFunction>? PromQLCriteria { get; set; }
        }

        public class EvaluationWindow : Humidifier.Base.BaseSubResource, IHaveCloudWatchAlarmTypesWallClockWindowWallClockWindow, IHaveSlidingWindow_Json
        {
            /// <summary>
            /// WallClockWindow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alarm-evaluationwindow.html#cfn-cloudwatch-alarm-evaluationwindow-wallclockwindow
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WallClockWindow
            /// </summary>
            public Union<Humidifier.CloudWatch.AlarmTypes.WallClockWindow, BaseFunction>? WallClockWindow { get; set; }
            /// <summary>
            /// SlidingWindow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alarm-evaluationwindow.html#cfn-cloudwatch-alarm-evaluationwindow-slidingwindow
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? SlidingWindow { get; set; }
        }

        public class Metric : Humidifier.Base.BaseSubResource, IHaveMetricName, IHaveListOfCloudWatchAlarmTypesDimensionDimensions, IHaveNamespace_
        {
            /// <summary>
            /// MetricName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alarm-metric.html#cfn-cloudwatch-alarm-metric-metricname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetricName { get; set; }
            /// <summary>
            /// Dimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alarm-metric.html#cfn-cloudwatch-alarm-metric-dimensions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Dimension
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CloudWatch.AlarmTypes.Dimension>, IReadOnlyList<Union<Humidifier.CloudWatch.AlarmTypes.Dimension, BaseFunction>>, BaseFunction>? Dimensions { get; set; }
            /// <summary>
            /// Namespace_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alarm-metric.html#cfn-cloudwatch-alarm-metric-namespace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Namespace_ { get; set; }
        }

        public class MetricDataQuery : Humidifier.Base.BaseSubResource, IHaveAccountId, IHaveReturnData_Boolean, IHaveExpression, IHaveLabel, IHaveCloudWatchAlarmTypesMetricStatMetricStat, IHavePeriod_Integer, IHaveId
        {
            /// <summary>
            /// AccountId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alarm-metricdataquery.html#cfn-cloudwatch-alarm-metricdataquery-accountid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccountId { get; set; }
            /// <summary>
            /// ReturnData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alarm-metricdataquery.html#cfn-cloudwatch-alarm-metricdataquery-returndata
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ReturnData { get; set; }
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alarm-metricdataquery.html#cfn-cloudwatch-alarm-metricdataquery-expression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Expression { get; set; }
            /// <summary>
            /// Label
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alarm-metricdataquery.html#cfn-cloudwatch-alarm-metricdataquery-label
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Label { get; set; }
            /// <summary>
            /// MetricStat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alarm-metricdataquery.html#cfn-cloudwatch-alarm-metricdataquery-metricstat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MetricStat
            /// </summary>
            public Union<Humidifier.CloudWatch.AlarmTypes.MetricStat, BaseFunction>? MetricStat { get; set; }
            /// <summary>
            /// Period
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alarm-metricdataquery.html#cfn-cloudwatch-alarm-metricdataquery-period
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Period { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alarm-metricdataquery.html#cfn-cloudwatch-alarm-metricdataquery-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
        }

        public class MetricStat : Humidifier.Base.BaseSubResource, IHaveStat, IHavePeriod_Integer, IHaveCloudWatchAlarmTypesMetricMetric, IHaveUnit
        {
            /// <summary>
            /// Stat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alarm-metricstat.html#cfn-cloudwatch-alarm-metricstat-stat
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Stat { get; set; }
            /// <summary>
            /// Period
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alarm-metricstat.html#cfn-cloudwatch-alarm-metricstat-period
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Period { get; set; }
            /// <summary>
            /// Metric
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alarm-metricstat.html#cfn-cloudwatch-alarm-metricstat-metric
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Metric
            /// </summary>
            public Union<Humidifier.CloudWatch.AlarmTypes.Metric, BaseFunction>? Metric { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alarm-metricstat.html#cfn-cloudwatch-alarm-metricstat-unit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Unit { get; set; }
        }

        public class WallClockWindow : Humidifier.Base.BaseSubResource, IHaveTimezone
        {
            /// <summary>
            /// Timezone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alarm-wallclockwindow.html#cfn-cloudwatch-alarm-wallclockwindow-timezone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Timezone { get; set; }
        }

        public class WarmUpConfiguration : Humidifier.Base.BaseSubResource, IHaveWarmUpPeriodDurationInMinutes_Integer, IHaveOnlyStartEvaluatingAfterWarmUpPeriodEnds_Boolean
        {
            /// <summary>
            /// WarmUpPeriodDurationInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alarm-warmupconfiguration.html#cfn-cloudwatch-alarm-warmupconfiguration-warmupperioddurationinminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? WarmUpPeriodDurationInMinutes { get; set; }
            /// <summary>
            /// OnlyStartEvaluatingAfterWarmUpPeriodEnds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alarm-warmupconfiguration.html#cfn-cloudwatch-alarm-warmupconfiguration-onlystartevaluatingafterwarmupperiodends
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? OnlyStartEvaluatingAfterWarmUpPeriodEnds { get; set; }
        }
    }
}