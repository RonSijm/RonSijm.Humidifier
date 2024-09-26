namespace Humidifier.CloudFront
{
    using System.Collections.Generic;
    using MonitoringSubscriptionTypes;

    public class MonitoringSubscription : Humidifier.Base.BaseResource
    {
        public override string AWSTypeName { get => AWS.CloudFront.MonitoringSubscription; }

        /// <summary>
        /// MonitoringSubscription_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-monitoringsubscription.html#cfn-cloudfront-monitoringsubscription-monitoringsubscription
        /// Required: True
        /// UpdateType: Mutable
        /// Type: MonitoringSubscription
        /// </summary>
        [Required]
        public Humidifier.CloudFront.MonitoringSubscriptionTypes.MonitoringSubscription MonitoringSubscription_ { get; set; }

        /// <summary>
        /// DistributionId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-monitoringsubscription.html#cfn-cloudfront-monitoringsubscription-distributionid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DistributionId { get; set; }
    }

    namespace MonitoringSubscriptionTypes
    {
        public class MonitoringSubscription : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RealtimeMetricsSubscriptionConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-monitoringsubscription-monitoringsubscription.html#cfn-cloudfront-monitoringsubscription-monitoringsubscription-realtimemetricssubscriptionconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RealtimeMetricsSubscriptionConfig
            /// </summary>
            public Humidifier.CloudFront.MonitoringSubscriptionTypes.RealtimeMetricsSubscriptionConfig RealtimeMetricsSubscriptionConfig { get; set; }
        }

        public class RealtimeMetricsSubscriptionConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RealtimeMetricsSubscriptionStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-monitoringsubscription-realtimemetricssubscriptionconfig.html#cfn-cloudfront-monitoringsubscription-realtimemetricssubscriptionconfig-realtimemetricssubscriptionstatus
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RealtimeMetricsSubscriptionStatus { get; set; }
        }
    }
}