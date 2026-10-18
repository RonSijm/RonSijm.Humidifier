namespace Humidifier.CloudWatch
{
    using global::System.Collections.Generic;
    using AnomalyDetectorTypes;

    public class AnomalyDetector : Humidifier.Base.BaseResource, IHaveCloudWatchAnomalyDetectorTypesMetricCharacteristicsMetricCharacteristics, IHaveMetricName, IHaveStat, IHaveCloudWatchAnomalyDetectorTypesMetricConfigurationConfiguration, IHaveCloudWatchAnomalyDetectorTypesMetricMathAnomalyDetectorMetricMathAnomalyDetector, IHaveListOfCloudWatchAnomalyDetectorTypesDimensionDimensions, IHaveNamespace_, IHaveCloudWatchAnomalyDetectorTypesSingleMetricAnomalyDetectorSingleMetricAnomalyDetector
    {
        public class Attributes
        {
            public static string AnomalyDetectorId =  "AnomalyDetectorId" ;
        }

        public override string AWSTypeName { get => AWS.CloudWatch.AnomalyDetector; }
        /// <summary>
        /// MetricCharacteristics
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-anomalydetector.html#cfn-cloudwatch-anomalydetector-metriccharacteristics
        /// Required: False
        /// UpdateType: Immutable
        /// Type: MetricCharacteristics
        /// </summary>
        public Union<Humidifier.CloudWatch.AnomalyDetectorTypes.MetricCharacteristics, BaseFunction>? MetricCharacteristics { get; set; }
        /// <summary>
        /// MetricName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-anomalydetector.html#cfn-cloudwatch-anomalydetector-metricname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? MetricName { get; set; }
        /// <summary>
        /// Stat
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-anomalydetector.html#cfn-cloudwatch-anomalydetector-stat
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Stat { get; set; }
        /// <summary>
        /// Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-anomalydetector.html#cfn-cloudwatch-anomalydetector-configuration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MetricConfiguration
        /// </summary>
        public Union<Humidifier.CloudWatch.AnomalyDetectorTypes.MetricConfiguration, BaseFunction>? Configuration { get; set; }
        /// <summary>
        /// MetricMathAnomalyDetector
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-anomalydetector.html#cfn-cloudwatch-anomalydetector-metricmathanomalydetector
        /// Required: False
        /// UpdateType: Immutable
        /// Type: MetricMathAnomalyDetector
        /// </summary>
        public Union<Humidifier.CloudWatch.AnomalyDetectorTypes.MetricMathAnomalyDetector, BaseFunction>? MetricMathAnomalyDetector { get; set; }
        /// <summary>
        /// Dimensions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-anomalydetector.html#cfn-cloudwatch-anomalydetector-dimensions
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Dimension
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CloudWatch.AnomalyDetectorTypes.Dimension>, IReadOnlyList<Union<Humidifier.CloudWatch.AnomalyDetectorTypes.Dimension, BaseFunction>>, BaseFunction>? Dimensions { get; set; }
        /// <summary>
        /// Namespace_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-anomalydetector.html#cfn-cloudwatch-anomalydetector-namespace
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Namespace_ { get; set; }
        /// <summary>
        /// SingleMetricAnomalyDetector
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-anomalydetector.html#cfn-cloudwatch-anomalydetector-singlemetricanomalydetector
        /// Required: False
        /// UpdateType: Immutable
        /// Type: SingleMetricAnomalyDetector
        /// </summary>
        public Union<Humidifier.CloudWatch.AnomalyDetectorTypes.SingleMetricAnomalyDetector, BaseFunction>? SingleMetricAnomalyDetector { get; set; }
    }

    namespace AnomalyDetectorTypes
    {
        public class Dimension : Humidifier.Base.BaseSubResource, IHaveValue, IHaveName
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-anomalydetector-dimension.html#cfn-cloudwatch-anomalydetector-dimension-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-anomalydetector-dimension.html#cfn-cloudwatch-anomalydetector-dimension-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class Metric : Humidifier.Base.BaseSubResource, IHaveMetricName, IHaveListOfCloudWatchAnomalyDetectorTypesDimensionDimensions, IHaveNamespace_
        {
            /// <summary>
            /// MetricName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-anomalydetector-metric.html#cfn-cloudwatch-anomalydetector-metric-metricname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetricName { get; set; }
            /// <summary>
            /// Dimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-anomalydetector-metric.html#cfn-cloudwatch-anomalydetector-metric-dimensions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Dimension
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CloudWatch.AnomalyDetectorTypes.Dimension>, IReadOnlyList<Union<Humidifier.CloudWatch.AnomalyDetectorTypes.Dimension, BaseFunction>>, BaseFunction>? Dimensions { get; set; }
            /// <summary>
            /// Namespace_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-anomalydetector-metric.html#cfn-cloudwatch-anomalydetector-metric-namespace
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Namespace_ { get; set; }
        }

        public class MetricCharacteristics : Humidifier.Base.BaseSubResource, IHavePeriodicSpikes_Boolean
        {
            /// <summary>
            /// PeriodicSpikes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-anomalydetector-metriccharacteristics.html#cfn-cloudwatch-anomalydetector-metriccharacteristics-periodicspikes
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? PeriodicSpikes { get; set; }
        }

        public class MetricConfiguration : Humidifier.Base.BaseSubResource, IHaveMetricTimeZone, IHaveListOfCloudWatchAnomalyDetectorTypesRangeExcludedTimeRanges
        {
            /// <summary>
            /// MetricTimeZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-anomalydetector-metricconfiguration.html#cfn-cloudwatch-anomalydetector-metricconfiguration-metrictimezone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetricTimeZone { get; set; }
            /// <summary>
            /// ExcludedTimeRanges
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-anomalydetector-metricconfiguration.html#cfn-cloudwatch-anomalydetector-metricconfiguration-excludedtimeranges
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Range
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CloudWatch.AnomalyDetectorTypes.Range>, IReadOnlyList<Union<Humidifier.CloudWatch.AnomalyDetectorTypes.Range, BaseFunction>>, BaseFunction>? ExcludedTimeRanges { get; set; }
        }

        public class MetricDataQuery : Humidifier.Base.BaseSubResource, IHaveAccountId, IHaveReturnData_Boolean, IHaveExpression, IHaveCloudWatchAnomalyDetectorTypesMetricStatMetricStat, IHaveLabel, IHavePeriod_Integer, IHaveId
        {
            /// <summary>
            /// AccountId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-anomalydetector-metricdataquery.html#cfn-cloudwatch-anomalydetector-metricdataquery-accountid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccountId { get; set; }
            /// <summary>
            /// ReturnData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-anomalydetector-metricdataquery.html#cfn-cloudwatch-anomalydetector-metricdataquery-returndata
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ReturnData { get; set; }
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-anomalydetector-metricdataquery.html#cfn-cloudwatch-anomalydetector-metricdataquery-expression
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Expression { get; set; }
            /// <summary>
            /// MetricStat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-anomalydetector-metricdataquery.html#cfn-cloudwatch-anomalydetector-metricdataquery-metricstat
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MetricStat
            /// </summary>
            public Union<Humidifier.CloudWatch.AnomalyDetectorTypes.MetricStat, BaseFunction>? MetricStat { get; set; }
            /// <summary>
            /// Label
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-anomalydetector-metricdataquery.html#cfn-cloudwatch-anomalydetector-metricdataquery-label
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Label { get; set; }
            /// <summary>
            /// Period
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-anomalydetector-metricdataquery.html#cfn-cloudwatch-anomalydetector-metricdataquery-period
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Period { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-anomalydetector-metricdataquery.html#cfn-cloudwatch-anomalydetector-metricdataquery-id
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
        }

        public class MetricMathAnomalyDetector : Humidifier.Base.BaseSubResource, IHaveListOfCloudWatchAnomalyDetectorTypesMetricDataQueryMetricDataQueries
        {
            /// <summary>
            /// MetricDataQueries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-anomalydetector-metricmathanomalydetector.html#cfn-cloudwatch-anomalydetector-metricmathanomalydetector-metricdataqueries
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: MetricDataQuery
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CloudWatch.AnomalyDetectorTypes.MetricDataQuery>, IReadOnlyList<Union<Humidifier.CloudWatch.AnomalyDetectorTypes.MetricDataQuery, BaseFunction>>, BaseFunction>? MetricDataQueries { get; set; }
        }

        public class MetricStat : Humidifier.Base.BaseSubResource, IHaveStat, IHavePeriod_Integer, IHaveCloudWatchAnomalyDetectorTypesMetricMetric, IHaveUnit
        {
            /// <summary>
            /// Stat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-anomalydetector-metricstat.html#cfn-cloudwatch-anomalydetector-metricstat-stat
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Stat { get; set; }
            /// <summary>
            /// Period
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-anomalydetector-metricstat.html#cfn-cloudwatch-anomalydetector-metricstat-period
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Period { get; set; }
            /// <summary>
            /// Metric
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-anomalydetector-metricstat.html#cfn-cloudwatch-anomalydetector-metricstat-metric
            /// Required: True
            /// UpdateType: Immutable
            /// Type: Metric
            /// </summary>
            public Union<Humidifier.CloudWatch.AnomalyDetectorTypes.Metric, BaseFunction>? Metric { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-anomalydetector-metricstat.html#cfn-cloudwatch-anomalydetector-metricstat-unit
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Unit { get; set; }
        }

        public class Range : Humidifier.Base.BaseSubResource, IHaveEndTime, IHaveStartTime
        {
            /// <summary>
            /// EndTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-anomalydetector-range.html#cfn-cloudwatch-anomalydetector-range-endtime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndTime { get; set; }
            /// <summary>
            /// StartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-anomalydetector-range.html#cfn-cloudwatch-anomalydetector-range-starttime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StartTime { get; set; }
        }

        public class SingleMetricAnomalyDetector : Humidifier.Base.BaseSubResource, IHaveMetricName, IHaveAccountId, IHaveStat, IHaveListOfCloudWatchAnomalyDetectorTypesDimensionDimensions, IHaveNamespace_
        {
            /// <summary>
            /// MetricName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-anomalydetector-singlemetricanomalydetector.html#cfn-cloudwatch-anomalydetector-singlemetricanomalydetector-metricname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetricName { get; set; }
            /// <summary>
            /// AccountId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-anomalydetector-singlemetricanomalydetector.html#cfn-cloudwatch-anomalydetector-singlemetricanomalydetector-accountid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccountId { get; set; }
            /// <summary>
            /// Stat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-anomalydetector-singlemetricanomalydetector.html#cfn-cloudwatch-anomalydetector-singlemetricanomalydetector-stat
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Stat { get; set; }
            /// <summary>
            /// Dimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-anomalydetector-singlemetricanomalydetector.html#cfn-cloudwatch-anomalydetector-singlemetricanomalydetector-dimensions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Dimension
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CloudWatch.AnomalyDetectorTypes.Dimension>, IReadOnlyList<Union<Humidifier.CloudWatch.AnomalyDetectorTypes.Dimension, BaseFunction>>, BaseFunction>? Dimensions { get; set; }
            /// <summary>
            /// Namespace_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-anomalydetector-singlemetricanomalydetector.html#cfn-cloudwatch-anomalydetector-singlemetricanomalydetector-namespace
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Namespace_ { get; set; }
        }
    }
}