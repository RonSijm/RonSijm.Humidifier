namespace Humidifier.EC2
{
    using global::System.Collections.Generic;

    public class NetworkPerformanceMetricSubscription : Humidifier.Base.BaseResource, IHaveDestination, IHaveStatistic, IHaveMetric, IHaveSource
    {
        public override string AWSTypeName { get => AWS.EC2.NetworkPerformanceMetricSubscription; }

        /// <summary>
        /// Destination
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkperformancemetricsubscription.html#cfn-ec2-networkperformancemetricsubscription-destination
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Destination { get; set; }

        /// <summary>
        /// Statistic
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkperformancemetricsubscription.html#cfn-ec2-networkperformancemetricsubscription-statistic
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Statistic { get; set; }

        /// <summary>
        /// Metric
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkperformancemetricsubscription.html#cfn-ec2-networkperformancemetricsubscription-metric
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Metric { get; set; }

        /// <summary>
        /// Source
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-networkperformancemetricsubscription.html#cfn-ec2-networkperformancemetricsubscription-source
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Source { get; set; }
    }
}