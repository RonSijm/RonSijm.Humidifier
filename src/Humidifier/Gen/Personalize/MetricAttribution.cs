namespace Humidifier.Personalize
{
    using global::System.Collections.Generic;
    using MetricAttributionTypes;

    public class MetricAttribution : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveDatasetGroupArn
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string MetricAttributionArn =  "MetricAttributionArn" ;
        }

        public override string AWSTypeName { get => AWS.Personalize.MetricAttribution; }

        /// <summary>
        /// Metrics
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-metricattribution.html#cfn-personalize-metricattribution-metrics
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: MetricAttribute
        /// </summary>
        [Required]
        public List<Humidifier.Personalize.MetricAttributionTypes.MetricAttribute> Metrics { get; set; }

        /// <summary>
        /// DatasetGroupArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-metricattribution.html#cfn-personalize-metricattribution-datasetgrouparn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DatasetGroupArn { get; set; }

        /// <summary>
        /// MetricsOutputConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-metricattribution.html#cfn-personalize-metricattribution-metricsoutputconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: MetricsOutputConfig
        /// </summary>
        [Required]
        public Humidifier.Personalize.MetricAttributionTypes.MetricsOutputConfig MetricsOutputConfig { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace MetricAttributionTypes
    {
        public class MetricAttribute : Humidifier.Base.BaseSubResource, IHaveExpression, IHaveMetricName, IHaveEventType
        {
            /// <summary>
            /// MetricName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-metricattribution-metricattribute.html#cfn-personalize-metricattribution-metricattribute-metricname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MetricName { get; set; }
            /// <summary>
            /// EventType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-metricattribution-metricattribute.html#cfn-personalize-metricattribution-metricattribute-eventtype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EventType { get; set; }
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-metricattribution-metricattribute.html#cfn-personalize-metricattribution-metricattribute-expression
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Expression { get; set; }
        }

        public class MetricsOutputConfig : Humidifier.Base.BaseSubResource, IHaveRoleArn
        {
            /// <summary>
            /// S3DataDestination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-metricattribution-metricsoutputconfig.html#cfn-personalize-metricattribution-metricsoutputconfig-s3datadestination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3DataDestination
            /// </summary>
            public Humidifier.Personalize.MetricAttributionTypes.S3DataDestination S3DataDestination { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-metricattribution-metricsoutputconfig.html#cfn-personalize-metricattribution-metricsoutputconfig-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn { get; set; }
        }

        public class S3DataDestination : Humidifier.Base.BaseSubResource, IHavePath, IHaveKmsKeyArn
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-metricattribution-s3datadestination.html#cfn-personalize-metricattribution-s3datadestination-path
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Path { get; set; }
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-metricattribution-s3datadestination.html#cfn-personalize-metricattribution-s3datadestination-kmskeyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKeyArn { get; set; }
        }
    }
}