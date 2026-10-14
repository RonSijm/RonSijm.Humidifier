namespace Humidifier.CloudWatch
{
    using global::System.Collections.Generic;
    using ResourceMetricsConfigurationTypes;

    public class ResourceMetricsConfiguration : Humidifier.Base.BaseResource, IHaveResourceArn
    {
        public class Attributes
        {
            public static string CreatedAt =  "CreatedAt" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.CloudWatch.ResourceMetricsConfiguration; }

        /// <summary>
        /// ResourceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-resourcemetricsconfiguration.html#cfn-cloudwatch-resourcemetricsconfiguration-resourcearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ResourceArn { get; set; }
        /// <summary>
        /// MetricSelections
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-resourcemetricsconfiguration.html#cfn-cloudwatch-resourcemetricsconfiguration-metricselections
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ResourceMetricSelection
        /// </summary>
        public List<Humidifier.CloudWatch.ResourceMetricsConfigurationTypes.ResourceMetricSelection> MetricSelections { get; set; }
    }

    namespace ResourceMetricsConfigurationTypes
    {
        public class ResourceMetricSelection : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// IncludeMetrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-resourcemetricsconfiguration-resourcemetricselection.html#cfn-cloudwatch-resourcemetricsconfiguration-resourcemetricselection-includemetrics
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic IncludeMetrics { get; set; }
        }
    }
}