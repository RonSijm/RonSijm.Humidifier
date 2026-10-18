namespace Humidifier.CloudFront
{
    using global::System.Collections.Generic;
    using MonitoringSubscriptionTypes;

    public class MonitoringSubscription : Humidifier.Base.BaseResource, IHaveCloudFrontMonitoringSubscriptionTypesMonitoringSubscriptionMonitoringSubscription_, IHaveDistributionId
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
        public Union<Humidifier.CloudFront.MonitoringSubscriptionTypes.MonitoringSubscription, BaseFunction>? MonitoringSubscription_ { get; set; }

        /// <summary>
        /// DistributionId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-monitoringsubscription.html#cfn-cloudfront-monitoringsubscription-distributionid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DistributionId { get; set; }
    }

    namespace MonitoringSubscriptionTypes
    {
        public class MonitoringSubscription : Humidifier.Base.BaseSubResource, IHaveCloudFrontMonitoringSubscriptionTypesRealtimeMetricsSubscriptionConfigRealtimeMetricsSubscriptionConfig
        {
            /// <summary>
            /// RealtimeMetricsSubscriptionConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-monitoringsubscription-monitoringsubscription.html#cfn-cloudfront-monitoringsubscription-monitoringsubscription-realtimemetricssubscriptionconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RealtimeMetricsSubscriptionConfig
            /// </summary>
            public Union<Humidifier.CloudFront.MonitoringSubscriptionTypes.RealtimeMetricsSubscriptionConfig, BaseFunction>? RealtimeMetricsSubscriptionConfig { get; set; }
        }

        public class RealtimeMetricsSubscriptionConfig : Humidifier.Base.BaseSubResource, IHaveRealtimeMetricsSubscriptionStatus
        {
            /// <summary>
            /// RealtimeMetricsSubscriptionStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-monitoringsubscription-realtimemetricssubscriptionconfig.html#cfn-cloudfront-monitoringsubscription-realtimemetricssubscriptionconfig-realtimemetricssubscriptionstatus
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RealtimeMetricsSubscriptionStatus { get; set; }
        }
    }
}