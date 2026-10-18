namespace Humidifier.ApplicationSignals
{
    using global::System.Collections.Generic;
    using ServiceLevelObjectiveTypes;

    public class ServiceLevelObjective : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveListOfApplicationSignalsServiceLevelObjectiveTypesBurnRateConfigurationBurnRateConfigurations, IHaveApplicationSignalsServiceLevelObjectiveTypesSliSli, IHaveApplicationSignalsServiceLevelObjectiveTypesGoalGoal, IHaveDescription, IHaveApplicationSignalsServiceLevelObjectiveTypesRequestBasedSliRequestBasedSli, IHaveListOfApplicationSignalsServiceLevelObjectiveTypesExclusionWindowExclusionWindows, IHaveName
    {
        public class Attributes
        {
            public static string CreatedTime =  "CreatedTime" ;
            public static string LastUpdatedTime =  "LastUpdatedTime" ;
            public static string EvaluationType =  "EvaluationType" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.ApplicationSignals.ServiceLevelObjective; }
        /// <summary>
        /// BurnRateConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationsignals-servicelevelobjective.html#cfn-applicationsignals-servicelevelobjective-burnrateconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: BurnRateConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.BurnRateConfiguration>, IReadOnlyList<Union<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.BurnRateConfiguration, BaseFunction>>, BaseFunction>? BurnRateConfigurations { get; set; }
        /// <summary>
        /// Sli
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationsignals-servicelevelobjective.html#cfn-applicationsignals-servicelevelobjective-sli
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Sli
        /// </summary>
        public Union<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.Sli, BaseFunction>? Sli { get; set; }
        /// <summary>
        /// Goal
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationsignals-servicelevelobjective.html#cfn-applicationsignals-servicelevelobjective-goal
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Goal
        /// </summary>
        public Union<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.Goal, BaseFunction>? Goal { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationsignals-servicelevelobjective.html#cfn-applicationsignals-servicelevelobjective-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// RequestBasedSli
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationsignals-servicelevelobjective.html#cfn-applicationsignals-servicelevelobjective-requestbasedsli
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RequestBasedSli
        /// </summary>
        public Union<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.RequestBasedSli, BaseFunction>? RequestBasedSli { get; set; }
        /// <summary>
        /// ExclusionWindows
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationsignals-servicelevelobjective.html#cfn-applicationsignals-servicelevelobjective-exclusionwindows
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ExclusionWindow
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.ExclusionWindow>, IReadOnlyList<Union<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.ExclusionWindow, BaseFunction>>, BaseFunction>? ExclusionWindows { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationsignals-servicelevelobjective.html#cfn-applicationsignals-servicelevelobjective-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ServiceLevelObjectiveTypes
    {
        public class BurnRateConfiguration : Humidifier.Base.BaseSubResource, IHaveLookBackWindowMinutes_Integer
        {
            /// <summary>
            /// LookBackWindowMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-burnrateconfiguration.html#cfn-applicationsignals-servicelevelobjective-burnrateconfiguration-lookbackwindowminutes
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? LookBackWindowMinutes { get; set; }
        }

        public class CalendarInterval : Humidifier.Base.BaseSubResource, IHaveDurationUnit, IHaveStartTime_Integer, IHaveDuration_Integer
        {
            /// <summary>
            /// DurationUnit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-calendarinterval.html#cfn-applicationsignals-servicelevelobjective-calendarinterval-durationunit
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DurationUnit { get; set; }
            /// <summary>
            /// StartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-calendarinterval.html#cfn-applicationsignals-servicelevelobjective-calendarinterval-starttime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? StartTime { get; set; }
            /// <summary>
            /// Duration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-calendarinterval.html#cfn-applicationsignals-servicelevelobjective-calendarinterval-duration
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Duration { get; set; }
        }

        public class CompositeSliComponent : Humidifier.Base.BaseSubResource, IHaveOperationName
        {
            /// <summary>
            /// OperationName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-compositeslicomponent.html#cfn-applicationsignals-servicelevelobjective-compositeslicomponent-operationname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OperationName { get; set; }
        }

        public class CompositeSliConfig : Humidifier.Base.BaseSubResource, IHaveApplicationSignalsServiceLevelObjectiveTypesSelectionConfigSelectionConfig, IHaveListOfApplicationSignalsServiceLevelObjectiveTypesCompositeSliComponentCompositeSliComponents
        {
            /// <summary>
            /// SelectionConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-compositesliconfig.html#cfn-applicationsignals-servicelevelobjective-compositesliconfig-selectionconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SelectionConfig
            /// </summary>
            public Union<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.SelectionConfig, BaseFunction>? SelectionConfig { get; set; }
            /// <summary>
            /// CompositeSliComponents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-compositesliconfig.html#cfn-applicationsignals-servicelevelobjective-compositesliconfig-compositeslicomponents
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CompositeSliComponent
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.CompositeSliComponent>, IReadOnlyList<Union<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.CompositeSliComponent, BaseFunction>>, BaseFunction>? CompositeSliComponents { get; set; }
        }

        public class DependencyConfig : Humidifier.Base.BaseSubResource, IHaveDependencyOperationName, IHaveStringDictionaryOfDependencyKeyAttributes
        {
            /// <summary>
            /// DependencyOperationName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-dependencyconfig.html#cfn-applicationsignals-servicelevelobjective-dependencyconfig-dependencyoperationname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DependencyOperationName { get; set; }
            /// <summary>
            /// DependencyKeyAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-dependencyconfig.html#cfn-applicationsignals-servicelevelobjective-dependencyconfig-dependencykeyattributes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? DependencyKeyAttributes { get; set; }
        }

        public class Dimension : Humidifier.Base.BaseSubResource, IHaveValue, IHaveName
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-dimension.html#cfn-applicationsignals-servicelevelobjective-dimension-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-dimension.html#cfn-applicationsignals-servicelevelobjective-dimension-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class ExclusionWindow : Humidifier.Base.BaseSubResource, IHaveApplicationSignalsServiceLevelObjectiveTypesWindowWindow, IHaveApplicationSignalsServiceLevelObjectiveTypesRecurrenceRuleRecurrenceRule, IHaveStartTime, IHaveReason
        {
            /// <summary>
            /// Window
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-exclusionwindow.html#cfn-applicationsignals-servicelevelobjective-exclusionwindow-window
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Window
            /// </summary>
            public Union<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.Window, BaseFunction>? Window { get; set; }
            /// <summary>
            /// RecurrenceRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-exclusionwindow.html#cfn-applicationsignals-servicelevelobjective-exclusionwindow-recurrencerule
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RecurrenceRule
            /// </summary>
            public Union<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.RecurrenceRule, BaseFunction>? RecurrenceRule { get; set; }
            /// <summary>
            /// StartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-exclusionwindow.html#cfn-applicationsignals-servicelevelobjective-exclusionwindow-starttime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StartTime { get; set; }
            /// <summary>
            /// Reason
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-exclusionwindow.html#cfn-applicationsignals-servicelevelobjective-exclusionwindow-reason
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Reason { get; set; }
        }

        public class Goal : Humidifier.Base.BaseSubResource, IHaveWarningThreshold_Double, IHaveAttainmentGoal_Double, IHaveApplicationSignalsServiceLevelObjectiveTypesIntervalInterval
        {
            /// <summary>
            /// WarningThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-goal.html#cfn-applicationsignals-servicelevelobjective-goal-warningthreshold
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? WarningThreshold { get; set; }
            /// <summary>
            /// AttainmentGoal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-goal.html#cfn-applicationsignals-servicelevelobjective-goal-attainmentgoal
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? AttainmentGoal { get; set; }
            /// <summary>
            /// Interval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-goal.html#cfn-applicationsignals-servicelevelobjective-goal-interval
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Interval
            /// </summary>
            public Union<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.Interval, BaseFunction>? Interval { get; set; }
        }

        public class Interval : Humidifier.Base.BaseSubResource, IHaveApplicationSignalsServiceLevelObjectiveTypesRollingIntervalRollingInterval, IHaveApplicationSignalsServiceLevelObjectiveTypesCalendarIntervalCalendarInterval
        {
            /// <summary>
            /// RollingInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-interval.html#cfn-applicationsignals-servicelevelobjective-interval-rollinginterval
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RollingInterval
            /// </summary>
            public Union<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.RollingInterval, BaseFunction>? RollingInterval { get; set; }
            /// <summary>
            /// CalendarInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-interval.html#cfn-applicationsignals-servicelevelobjective-interval-calendarinterval
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CalendarInterval
            /// </summary>
            public Union<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.CalendarInterval, BaseFunction>? CalendarInterval { get; set; }
        }

        public class Metric : Humidifier.Base.BaseSubResource, IHaveMetricName, IHaveListOfApplicationSignalsServiceLevelObjectiveTypesDimensionDimensions, IHaveNamespace_
        {
            /// <summary>
            /// MetricName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-metric.html#cfn-applicationsignals-servicelevelobjective-metric-metricname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetricName { get; set; }
            /// <summary>
            /// Dimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-metric.html#cfn-applicationsignals-servicelevelobjective-metric-dimensions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Dimension
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.Dimension>, IReadOnlyList<Union<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.Dimension, BaseFunction>>, BaseFunction>? Dimensions { get; set; }
            /// <summary>
            /// Namespace_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-metric.html#cfn-applicationsignals-servicelevelobjective-metric-namespace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Namespace_ { get; set; }
        }

        public class MetricDataQuery : Humidifier.Base.BaseSubResource, IHaveApplicationSignalsServiceLevelObjectiveTypesMetricStatMetricStat, IHaveAccountId, IHaveId, IHaveReturnData_Boolean, IHaveExpression
        {
            /// <summary>
            /// MetricStat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-metricdataquery.html#cfn-applicationsignals-servicelevelobjective-metricdataquery-metricstat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MetricStat
            /// </summary>
            public Union<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.MetricStat, BaseFunction>? MetricStat { get; set; }
            /// <summary>
            /// AccountId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-metricdataquery.html#cfn-applicationsignals-servicelevelobjective-metricdataquery-accountid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccountId { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-metricdataquery.html#cfn-applicationsignals-servicelevelobjective-metricdataquery-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// ReturnData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-metricdataquery.html#cfn-applicationsignals-servicelevelobjective-metricdataquery-returndata
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ReturnData { get; set; }
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-metricdataquery.html#cfn-applicationsignals-servicelevelobjective-metricdataquery-expression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Expression { get; set; }
        }

        public class MetricSource : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfMetricSourceKeyAttributes, IHaveStringDictionaryOfMetricSourceAttributes
        {
            /// <summary>
            /// MetricSourceKeyAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-metricsource.html#cfn-applicationsignals-servicelevelobjective-metricsource-metricsourcekeyattributes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? MetricSourceKeyAttributes { get; set; }
            /// <summary>
            /// MetricSourceAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-metricsource.html#cfn-applicationsignals-servicelevelobjective-metricsource-metricsourceattributes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? MetricSourceAttributes { get; set; }
        }

        public class MetricStat : Humidifier.Base.BaseSubResource, IHaveStat, IHavePeriod_Integer, IHaveApplicationSignalsServiceLevelObjectiveTypesMetricMetric, IHaveUnit
        {
            /// <summary>
            /// Stat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-metricstat.html#cfn-applicationsignals-servicelevelobjective-metricstat-stat
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Stat { get; set; }
            /// <summary>
            /// Period
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-metricstat.html#cfn-applicationsignals-servicelevelobjective-metricstat-period
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Period { get; set; }
            /// <summary>
            /// Metric
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-metricstat.html#cfn-applicationsignals-servicelevelobjective-metricstat-metric
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Metric
            /// </summary>
            public Union<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.Metric, BaseFunction>? Metric { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-metricstat.html#cfn-applicationsignals-servicelevelobjective-metricstat-unit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Unit { get; set; }
        }

        public class MonitoredRequestCountMetric : Humidifier.Base.BaseSubResource, IHaveListOfApplicationSignalsServiceLevelObjectiveTypesMetricDataQueryGoodCountMetric, IHaveListOfApplicationSignalsServiceLevelObjectiveTypesMetricDataQueryBadCountMetric
        {
            /// <summary>
            /// GoodCountMetric
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-monitoredrequestcountmetric.html#cfn-applicationsignals-servicelevelobjective-monitoredrequestcountmetric-goodcountmetric
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MetricDataQuery
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.MetricDataQuery>, IReadOnlyList<Union<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.MetricDataQuery, BaseFunction>>, BaseFunction>? GoodCountMetric { get; set; }
            /// <summary>
            /// BadCountMetric
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-monitoredrequestcountmetric.html#cfn-applicationsignals-servicelevelobjective-monitoredrequestcountmetric-badcountmetric
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MetricDataQuery
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.MetricDataQuery>, IReadOnlyList<Union<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.MetricDataQuery, BaseFunction>>, BaseFunction>? BadCountMetric { get; set; }
        }

        public class RecurrenceRule : Humidifier.Base.BaseSubResource, IHaveExpression
        {
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-recurrencerule.html#cfn-applicationsignals-servicelevelobjective-recurrencerule-expression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Expression { get; set; }
        }

        public class RequestBasedSli : Humidifier.Base.BaseSubResource, IHaveComparisonOperator, IHaveApplicationSignalsServiceLevelObjectiveTypesRequestBasedSliMetricRequestBasedSliMetric, IHaveMetricThreshold_Double
        {
            /// <summary>
            /// ComparisonOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-requestbasedsli.html#cfn-applicationsignals-servicelevelobjective-requestbasedsli-comparisonoperator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComparisonOperator { get; set; }
            /// <summary>
            /// RequestBasedSliMetric
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-requestbasedsli.html#cfn-applicationsignals-servicelevelobjective-requestbasedsli-requestbasedslimetric
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RequestBasedSliMetric
            /// </summary>
            public Union<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.RequestBasedSliMetric, BaseFunction>? RequestBasedSliMetric { get; set; }
            /// <summary>
            /// MetricThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-requestbasedsli.html#cfn-applicationsignals-servicelevelobjective-requestbasedsli-metricthreshold
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MetricThreshold { get; set; }
        }

        public class RequestBasedSliMetric : Humidifier.Base.BaseSubResource, IHaveApplicationSignalsServiceLevelObjectiveTypesMonitoredRequestCountMetricMonitoredRequestCountMetric, IHaveMetricName, IHaveOperationName, IHaveApplicationSignalsServiceLevelObjectiveTypesCompositeSliConfigCompositeSliConfig, IHaveListOfApplicationSignalsServiceLevelObjectiveTypesMetricDataQueryTotalRequestCountMetric, IHaveStringDictionaryOfKeyAttributes, IHaveMetricType, IHaveApplicationSignalsServiceLevelObjectiveTypesMetricSourceMetricSource, IHaveApplicationSignalsServiceLevelObjectiveTypesDependencyConfigDependencyConfig
        {
            /// <summary>
            /// MonitoredRequestCountMetric
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-requestbasedslimetric.html#cfn-applicationsignals-servicelevelobjective-requestbasedslimetric-monitoredrequestcountmetric
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MonitoredRequestCountMetric
            /// </summary>
            public Union<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.MonitoredRequestCountMetric, BaseFunction>? MonitoredRequestCountMetric { get; set; }
            /// <summary>
            /// MetricName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-requestbasedslimetric.html#cfn-applicationsignals-servicelevelobjective-requestbasedslimetric-metricname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetricName { get; set; }
            /// <summary>
            /// OperationName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-requestbasedslimetric.html#cfn-applicationsignals-servicelevelobjective-requestbasedslimetric-operationname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OperationName { get; set; }
            /// <summary>
            /// CompositeSliConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-requestbasedslimetric.html#cfn-applicationsignals-servicelevelobjective-requestbasedslimetric-compositesliconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CompositeSliConfig
            /// </summary>
            public Union<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.CompositeSliConfig, BaseFunction>? CompositeSliConfig { get; set; }
            /// <summary>
            /// TotalRequestCountMetric
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-requestbasedslimetric.html#cfn-applicationsignals-servicelevelobjective-requestbasedslimetric-totalrequestcountmetric
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MetricDataQuery
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.MetricDataQuery>, IReadOnlyList<Union<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.MetricDataQuery, BaseFunction>>, BaseFunction>? TotalRequestCountMetric { get; set; }
            /// <summary>
            /// KeyAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-requestbasedslimetric.html#cfn-applicationsignals-servicelevelobjective-requestbasedslimetric-keyattributes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? KeyAttributes { get; set; }
            /// <summary>
            /// MetricType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-requestbasedslimetric.html#cfn-applicationsignals-servicelevelobjective-requestbasedslimetric-metrictype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetricType { get; set; }
            /// <summary>
            /// MetricSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-requestbasedslimetric.html#cfn-applicationsignals-servicelevelobjective-requestbasedslimetric-metricsource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MetricSource
            /// </summary>
            public Union<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.MetricSource, BaseFunction>? MetricSource { get; set; }
            /// <summary>
            /// DependencyConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-requestbasedslimetric.html#cfn-applicationsignals-servicelevelobjective-requestbasedslimetric-dependencyconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DependencyConfig
            /// </summary>
            public Union<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.DependencyConfig, BaseFunction>? DependencyConfig { get; set; }
        }

        public class RollingInterval : Humidifier.Base.BaseSubResource, IHaveDurationUnit, IHaveDuration_Integer
        {
            /// <summary>
            /// DurationUnit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-rollinginterval.html#cfn-applicationsignals-servicelevelobjective-rollinginterval-durationunit
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DurationUnit { get; set; }
            /// <summary>
            /// Duration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-rollinginterval.html#cfn-applicationsignals-servicelevelobjective-rollinginterval-duration
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Duration { get; set; }
        }

        public class SelectionConfig : Humidifier.Base.BaseSubResource, IHavePattern, IHaveType
        {
            /// <summary>
            /// Pattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-selectionconfig.html#cfn-applicationsignals-servicelevelobjective-selectionconfig-pattern
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Pattern { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-selectionconfig.html#cfn-applicationsignals-servicelevelobjective-selectionconfig-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
        }

        public class Sli : Humidifier.Base.BaseSubResource, IHaveComparisonOperator, IHaveApplicationSignalsServiceLevelObjectiveTypesSliMetricSliMetric, IHaveMetricThreshold_Double
        {
            /// <summary>
            /// ComparisonOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-sli.html#cfn-applicationsignals-servicelevelobjective-sli-comparisonoperator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComparisonOperator { get; set; }
            /// <summary>
            /// SliMetric
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-sli.html#cfn-applicationsignals-servicelevelobjective-sli-slimetric
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SliMetric
            /// </summary>
            public Union<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.SliMetric, BaseFunction>? SliMetric { get; set; }
            /// <summary>
            /// MetricThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-sli.html#cfn-applicationsignals-servicelevelobjective-sli-metricthreshold
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MetricThreshold { get; set; }
        }

        public class SliMetric : Humidifier.Base.BaseSubResource, IHaveMetricName, IHaveStatistic, IHaveOperationName, IHaveApplicationSignalsServiceLevelObjectiveTypesCompositeSliConfigCompositeSliConfig, IHaveStringDictionaryOfKeyAttributes, IHaveMetricType, IHavePeriodSeconds_Integer, IHaveApplicationSignalsServiceLevelObjectiveTypesMetricSourceMetricSource, IHaveListOfApplicationSignalsServiceLevelObjectiveTypesMetricDataQueryMetricDataQueries, IHaveApplicationSignalsServiceLevelObjectiveTypesDependencyConfigDependencyConfig
        {
            /// <summary>
            /// MetricName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-slimetric.html#cfn-applicationsignals-servicelevelobjective-slimetric-metricname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetricName { get; set; }
            /// <summary>
            /// Statistic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-slimetric.html#cfn-applicationsignals-servicelevelobjective-slimetric-statistic
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Statistic { get; set; }
            /// <summary>
            /// OperationName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-slimetric.html#cfn-applicationsignals-servicelevelobjective-slimetric-operationname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OperationName { get; set; }
            /// <summary>
            /// CompositeSliConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-slimetric.html#cfn-applicationsignals-servicelevelobjective-slimetric-compositesliconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CompositeSliConfig
            /// </summary>
            public Union<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.CompositeSliConfig, BaseFunction>? CompositeSliConfig { get; set; }
            /// <summary>
            /// KeyAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-slimetric.html#cfn-applicationsignals-servicelevelobjective-slimetric-keyattributes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? KeyAttributes { get; set; }
            /// <summary>
            /// MetricType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-slimetric.html#cfn-applicationsignals-servicelevelobjective-slimetric-metrictype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetricType { get; set; }
            /// <summary>
            /// PeriodSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-slimetric.html#cfn-applicationsignals-servicelevelobjective-slimetric-periodseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? PeriodSeconds { get; set; }
            /// <summary>
            /// MetricSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-slimetric.html#cfn-applicationsignals-servicelevelobjective-slimetric-metricsource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MetricSource
            /// </summary>
            public Union<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.MetricSource, BaseFunction>? MetricSource { get; set; }
            /// <summary>
            /// MetricDataQueries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-slimetric.html#cfn-applicationsignals-servicelevelobjective-slimetric-metricdataqueries
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MetricDataQuery
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.MetricDataQuery>, IReadOnlyList<Union<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.MetricDataQuery, BaseFunction>>, BaseFunction>? MetricDataQueries { get; set; }
            /// <summary>
            /// DependencyConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-slimetric.html#cfn-applicationsignals-servicelevelobjective-slimetric-dependencyconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DependencyConfig
            /// </summary>
            public Union<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.DependencyConfig, BaseFunction>? DependencyConfig { get; set; }
        }

        public class Window : Humidifier.Base.BaseSubResource, IHaveDurationUnit, IHaveDuration_Integer
        {
            /// <summary>
            /// DurationUnit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-window.html#cfn-applicationsignals-servicelevelobjective-window-durationunit
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DurationUnit { get; set; }
            /// <summary>
            /// Duration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationsignals-servicelevelobjective-window.html#cfn-applicationsignals-servicelevelobjective-window-duration
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Duration { get; set; }
        }
    }
}