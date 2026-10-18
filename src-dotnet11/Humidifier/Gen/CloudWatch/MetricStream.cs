namespace Humidifier.CloudWatch
{
    using global::System.Collections.Generic;
    using MetricStreamTypes;

    public class MetricStream : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveListOfCloudWatchMetricStreamTypesMetricStreamStatisticsConfigurationStatisticsConfigurations, IHaveFirehoseArn, IHaveIncludeLinkedAccountsMetrics_Boolean, IHaveListOfCloudWatchMetricStreamTypesMetricStreamFilterIncludeFilters, IHaveOutputFormat, IHaveListOfCloudWatchMetricStreamTypesMetricStreamFilterExcludeFilters, IHaveRoleArn, IHaveName
    {
        public class Attributes
        {
            public static string CreationDate =  "CreationDate" ;
            public static string State =  "State" ;
            public static string Arn =  "Arn" ;
            public static string LastUpdateDate =  "LastUpdateDate" ;
        }

        public override string AWSTypeName { get => AWS.CloudWatch.MetricStream; }
        /// <summary>
        /// StatisticsConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-metricstream.html#cfn-cloudwatch-metricstream-statisticsconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: MetricStreamStatisticsConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CloudWatch.MetricStreamTypes.MetricStreamStatisticsConfiguration>, IReadOnlyList<Union<Humidifier.CloudWatch.MetricStreamTypes.MetricStreamStatisticsConfiguration, BaseFunction>>, BaseFunction>? StatisticsConfigurations { get; set; }

        /// <summary>
        /// FirehoseArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-metricstream.html#cfn-cloudwatch-metricstream-firehosearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? FirehoseArn { get; set; }
        /// <summary>
        /// IncludeLinkedAccountsMetrics
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-metricstream.html#cfn-cloudwatch-metricstream-includelinkedaccountsmetrics
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? IncludeLinkedAccountsMetrics { get; set; }
        /// <summary>
        /// IncludeFilters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-metricstream.html#cfn-cloudwatch-metricstream-includefilters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: MetricStreamFilter
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CloudWatch.MetricStreamTypes.MetricStreamFilter>, IReadOnlyList<Union<Humidifier.CloudWatch.MetricStreamTypes.MetricStreamFilter, BaseFunction>>, BaseFunction>? IncludeFilters { get; set; }

        /// <summary>
        /// OutputFormat
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-metricstream.html#cfn-cloudwatch-metricstream-outputformat
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? OutputFormat { get; set; }
        /// <summary>
        /// ExcludeFilters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-metricstream.html#cfn-cloudwatch-metricstream-excludefilters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: MetricStreamFilter
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CloudWatch.MetricStreamTypes.MetricStreamFilter>, IReadOnlyList<Union<Humidifier.CloudWatch.MetricStreamTypes.MetricStreamFilter, BaseFunction>>, BaseFunction>? ExcludeFilters { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-metricstream.html#cfn-cloudwatch-metricstream-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-metricstream.html#cfn-cloudwatch-metricstream-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace MetricStreamTypes
    {
        public class MetricStreamFilter : Humidifier.Base.BaseSubResource, IHaveStringListOfMetricNames, IHaveNamespace_
        {
            /// <summary>
            /// MetricNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-metricstream-metricstreamfilter.html#cfn-cloudwatch-metricstream-metricstreamfilter-metricnames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? MetricNames { get; set; }
            /// <summary>
            /// Namespace_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-metricstream-metricstreamfilter.html#cfn-cloudwatch-metricstream-metricstreamfilter-namespace
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Namespace_ { get; set; }
        }

        public class MetricStreamStatisticsConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfCloudWatchMetricStreamTypesMetricStreamStatisticsMetricIncludeMetrics, IHaveStringListOfAdditionalStatistics
        {
            /// <summary>
            /// IncludeMetrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-metricstream-metricstreamstatisticsconfiguration.html#cfn-cloudwatch-metricstream-metricstreamstatisticsconfiguration-includemetrics
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MetricStreamStatisticsMetric
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CloudWatch.MetricStreamTypes.MetricStreamStatisticsMetric>, IReadOnlyList<Union<Humidifier.CloudWatch.MetricStreamTypes.MetricStreamStatisticsMetric, BaseFunction>>, BaseFunction>? IncludeMetrics { get; set; }
            /// <summary>
            /// AdditionalStatistics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-metricstream-metricstreamstatisticsconfiguration.html#cfn-cloudwatch-metricstream-metricstreamstatisticsconfiguration-additionalstatistics
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AdditionalStatistics { get; set; }
        }

        public class MetricStreamStatisticsMetric : Humidifier.Base.BaseSubResource, IHaveMetricName, IHaveNamespace_
        {
            /// <summary>
            /// MetricName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-metricstream-metricstreamstatisticsmetric.html#cfn-cloudwatch-metricstream-metricstreamstatisticsmetric-metricname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetricName { get; set; }
            /// <summary>
            /// Namespace_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-metricstream-metricstreamstatisticsmetric.html#cfn-cloudwatch-metricstream-metricstreamstatisticsmetric-namespace
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Namespace_ { get; set; }
        }
    }
}