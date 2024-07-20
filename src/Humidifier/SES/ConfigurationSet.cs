namespace Humidifier.SES
{
    using System.Collections.Generic;
    using ConfigurationSetTypes;

    public class ConfigurationSet : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::SES::ConfigurationSet";
            }
        }

        /// <summary>
        /// SendingOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-configurationset.html#cfn-ses-configurationset-sendingoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SendingOptions
        /// </summary>
        public SendingOptions SendingOptions { get; set; }
        /// <summary>
        /// SuppressionOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-configurationset.html#cfn-ses-configurationset-suppressionoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SuppressionOptions
        /// </summary>
        public SuppressionOptions SuppressionOptions { get; set; }
        /// <summary>
        /// TrackingOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-configurationset.html#cfn-ses-configurationset-trackingoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TrackingOptions
        /// </summary>
        public TrackingOptions TrackingOptions { get; set; }
        /// <summary>
        /// ReputationOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-configurationset.html#cfn-ses-configurationset-reputationoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ReputationOptions
        /// </summary>
        public ReputationOptions ReputationOptions { get; set; }
        /// <summary>
        /// VdmOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-configurationset.html#cfn-ses-configurationset-vdmoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: VdmOptions
        /// </summary>
        public VdmOptions VdmOptions { get; set; }
        /// <summary>
        /// DeliveryOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-configurationset.html#cfn-ses-configurationset-deliveryoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DeliveryOptions
        /// </summary>
        public DeliveryOptions DeliveryOptions { get; set; }
        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-configurationset.html#cfn-ses-configurationset-name
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name { get; set; }
    }

    namespace ConfigurationSetTypes
    {
        public class DashboardOptions
        {
            /// <summary>
            /// EngagementMetrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-configurationset-dashboardoptions.html#cfn-ses-configurationset-dashboardoptions-engagementmetrics
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EngagementMetrics { get; set; }
        }

        public class DeliveryOptions
        {
            /// <summary>
            /// SendingPoolName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-configurationset-deliveryoptions.html#cfn-ses-configurationset-deliveryoptions-sendingpoolname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SendingPoolName { get; set; }
            /// <summary>
            /// TlsPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-configurationset-deliveryoptions.html#cfn-ses-configurationset-deliveryoptions-tlspolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TlsPolicy { get; set; }
        }

        public class GuardianOptions
        {
            /// <summary>
            /// OptimizedSharedDelivery
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-configurationset-guardianoptions.html#cfn-ses-configurationset-guardianoptions-optimizedshareddelivery
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OptimizedSharedDelivery { get; set; }
        }

        public class ReputationOptions
        {
            /// <summary>
            /// ReputationMetricsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-configurationset-reputationoptions.html#cfn-ses-configurationset-reputationoptions-reputationmetricsenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ReputationMetricsEnabled { get; set; }
        }

        public class SendingOptions
        {
            /// <summary>
            /// SendingEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-configurationset-sendingoptions.html#cfn-ses-configurationset-sendingoptions-sendingenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic SendingEnabled { get; set; }
        }

        public class SuppressionOptions
        {
            /// <summary>
            /// SuppressedReasons
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-configurationset-suppressionoptions.html#cfn-ses-configurationset-suppressionoptions-suppressedreasons
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SuppressedReasons { get; set; }
        }

        public class TrackingOptions
        {
            /// <summary>
            /// CustomRedirectDomain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-configurationset-trackingoptions.html#cfn-ses-configurationset-trackingoptions-customredirectdomain
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomRedirectDomain { get; set; }
        }

        public class VdmOptions
        {
            /// <summary>
            /// DashboardOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-configurationset-vdmoptions.html#cfn-ses-configurationset-vdmoptions-dashboardoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DashboardOptions
            /// </summary>
            public DashboardOptions DashboardOptions { get; set; }
            /// <summary>
            /// GuardianOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-configurationset-vdmoptions.html#cfn-ses-configurationset-vdmoptions-guardianoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GuardianOptions
            /// </summary>
            public GuardianOptions GuardianOptions { get; set; }
        }
    }
}