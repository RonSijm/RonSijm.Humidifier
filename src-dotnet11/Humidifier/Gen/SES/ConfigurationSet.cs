namespace Humidifier.SES
{
    using global::System.Collections.Generic;
    using ConfigurationSetTypes;

    public class ConfigurationSet : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveSESConfigurationSetTypesSendingOptionsSendingOptions, IHaveSESConfigurationSetTypesSuppressionOptionsSuppressionOptions, IHaveSESConfigurationSetTypesTrackingOptionsTrackingOptions, IHaveSESConfigurationSetTypesReputationOptionsReputationOptions, IHaveSESConfigurationSetTypesVdmOptionsVdmOptions, IHaveSESConfigurationSetTypesArchivingOptionsArchivingOptions, IHaveSESConfigurationSetTypesDeliveryOptionsDeliveryOptions, IHaveName
    {
        public override string AWSTypeName { get => AWS.SES.ConfigurationSet; }
        /// <summary>
        /// SendingOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-configurationset.html#cfn-ses-configurationset-sendingoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SendingOptions
        /// </summary>
        public Union<Humidifier.SES.ConfigurationSetTypes.SendingOptions, BaseFunction>? SendingOptions { get; set; }
        /// <summary>
        /// SuppressionOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-configurationset.html#cfn-ses-configurationset-suppressionoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SuppressionOptions
        /// </summary>
        public Union<Humidifier.SES.ConfigurationSetTypes.SuppressionOptions, BaseFunction>? SuppressionOptions { get; set; }
        /// <summary>
        /// TrackingOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-configurationset.html#cfn-ses-configurationset-trackingoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TrackingOptions
        /// </summary>
        public Union<Humidifier.SES.ConfigurationSetTypes.TrackingOptions, BaseFunction>? TrackingOptions { get; set; }
        /// <summary>
        /// ReputationOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-configurationset.html#cfn-ses-configurationset-reputationoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ReputationOptions
        /// </summary>
        public Union<Humidifier.SES.ConfigurationSetTypes.ReputationOptions, BaseFunction>? ReputationOptions { get; set; }
        /// <summary>
        /// VdmOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-configurationset.html#cfn-ses-configurationset-vdmoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: VdmOptions
        /// </summary>
        public Union<Humidifier.SES.ConfigurationSetTypes.VdmOptions, BaseFunction>? VdmOptions { get; set; }
        /// <summary>
        /// ArchivingOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-configurationset.html#cfn-ses-configurationset-archivingoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ArchivingOptions
        /// </summary>
        public Union<Humidifier.SES.ConfigurationSetTypes.ArchivingOptions, BaseFunction>? ArchivingOptions { get; set; }
        /// <summary>
        /// DeliveryOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-configurationset.html#cfn-ses-configurationset-deliveryoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DeliveryOptions
        /// </summary>
        public Union<Humidifier.SES.ConfigurationSetTypes.DeliveryOptions, BaseFunction>? DeliveryOptions { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-configurationset.html#cfn-ses-configurationset-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ConfigurationSetTypes
    {
        public class ArchivingOptions : Humidifier.Base.BaseSubResource, IHaveArchiveArn
        {
            /// <summary>
            /// ArchiveArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-configurationset-archivingoptions.html#cfn-ses-configurationset-archivingoptions-archivearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ArchiveArn { get; set; }
        }

        public class ConditionThreshold : Humidifier.Base.BaseSubResource, IHaveSESConfigurationSetTypesOverallConfidenceThresholdOverallConfidenceThreshold, IHaveConditionThresholdEnabled
        {
            /// <summary>
            /// OverallConfidenceThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-configurationset-conditionthreshold.html#cfn-ses-configurationset-conditionthreshold-overallconfidencethreshold
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OverallConfidenceThreshold
            /// </summary>
            public Union<Humidifier.SES.ConfigurationSetTypes.OverallConfidenceThreshold, BaseFunction>? OverallConfidenceThreshold { get; set; }
            /// <summary>
            /// ConditionThresholdEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-configurationset-conditionthreshold.html#cfn-ses-configurationset-conditionthreshold-conditionthresholdenabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConditionThresholdEnabled { get; set; }
        }

        public class DashboardOptions : Humidifier.Base.BaseSubResource, IHaveEngagementMetrics
        {
            /// <summary>
            /// EngagementMetrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-configurationset-dashboardoptions.html#cfn-ses-configurationset-dashboardoptions-engagementmetrics
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EngagementMetrics { get; set; }
        }

        public class DeliveryOptions : Humidifier.Base.BaseSubResource, IHaveMaxDeliverySeconds_Double, IHaveSendingPoolName, IHaveTlsPolicy
        {
            /// <summary>
            /// MaxDeliverySeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-configurationset-deliveryoptions.html#cfn-ses-configurationset-deliveryoptions-maxdeliveryseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MaxDeliverySeconds { get; set; }
            /// <summary>
            /// SendingPoolName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-configurationset-deliveryoptions.html#cfn-ses-configurationset-deliveryoptions-sendingpoolname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SendingPoolName { get; set; }
            /// <summary>
            /// TlsPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-configurationset-deliveryoptions.html#cfn-ses-configurationset-deliveryoptions-tlspolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TlsPolicy { get; set; }
        }

        public class GuardianOptions : Humidifier.Base.BaseSubResource, IHaveOptimizedSharedDelivery
        {
            /// <summary>
            /// OptimizedSharedDelivery
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-configurationset-guardianoptions.html#cfn-ses-configurationset-guardianoptions-optimizedshareddelivery
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OptimizedSharedDelivery { get; set; }
        }

        public class OverallConfidenceThreshold : Humidifier.Base.BaseSubResource, IHaveConfidenceVerdictThreshold
        {
            /// <summary>
            /// ConfidenceVerdictThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-configurationset-overallconfidencethreshold.html#cfn-ses-configurationset-overallconfidencethreshold-confidenceverdictthreshold
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConfidenceVerdictThreshold { get; set; }
        }

        public class ReputationOptions : Humidifier.Base.BaseSubResource, IHaveReputationMetricsEnabled_Boolean
        {
            /// <summary>
            /// ReputationMetricsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-configurationset-reputationoptions.html#cfn-ses-configurationset-reputationoptions-reputationmetricsenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ReputationMetricsEnabled { get; set; }
        }

        public class SendingOptions : Humidifier.Base.BaseSubResource, IHaveSendingEnabled_Boolean
        {
            /// <summary>
            /// SendingEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-configurationset-sendingoptions.html#cfn-ses-configurationset-sendingoptions-sendingenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? SendingEnabled { get; set; }
        }

        public class SuppressionOptions : Humidifier.Base.BaseSubResource, IHaveStringListOfSuppressedReasons, IHaveSESConfigurationSetTypesValidationOptionsValidationOptions
        {
            /// <summary>
            /// SuppressedReasons
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-configurationset-suppressionoptions.html#cfn-ses-configurationset-suppressionoptions-suppressedreasons
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SuppressedReasons { get; set; }
            /// <summary>
            /// ValidationOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-configurationset-suppressionoptions.html#cfn-ses-configurationset-suppressionoptions-validationoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ValidationOptions
            /// </summary>
            public Union<Humidifier.SES.ConfigurationSetTypes.ValidationOptions, BaseFunction>? ValidationOptions { get; set; }
        }

        public class TrackingOptions : Humidifier.Base.BaseSubResource, IHaveHttpsPolicy, IHaveCustomRedirectDomain
        {
            /// <summary>
            /// HttpsPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-configurationset-trackingoptions.html#cfn-ses-configurationset-trackingoptions-httpspolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HttpsPolicy { get; set; }
            /// <summary>
            /// CustomRedirectDomain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-configurationset-trackingoptions.html#cfn-ses-configurationset-trackingoptions-customredirectdomain
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CustomRedirectDomain { get; set; }
        }

        public class ValidationOptions : Humidifier.Base.BaseSubResource, IHaveSESConfigurationSetTypesConditionThresholdConditionThreshold
        {
            /// <summary>
            /// ConditionThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-configurationset-validationoptions.html#cfn-ses-configurationset-validationoptions-conditionthreshold
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ConditionThreshold
            /// </summary>
            public Union<Humidifier.SES.ConfigurationSetTypes.ConditionThreshold, BaseFunction>? ConditionThreshold { get; set; }
        }

        public class VdmOptions : Humidifier.Base.BaseSubResource, IHaveSESConfigurationSetTypesDashboardOptionsDashboardOptions, IHaveSESConfigurationSetTypesGuardianOptionsGuardianOptions
        {
            /// <summary>
            /// DashboardOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-configurationset-vdmoptions.html#cfn-ses-configurationset-vdmoptions-dashboardoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DashboardOptions
            /// </summary>
            public Union<Humidifier.SES.ConfigurationSetTypes.DashboardOptions, BaseFunction>? DashboardOptions { get; set; }
            /// <summary>
            /// GuardianOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-configurationset-vdmoptions.html#cfn-ses-configurationset-vdmoptions-guardianoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GuardianOptions
            /// </summary>
            public Union<Humidifier.SES.ConfigurationSetTypes.GuardianOptions, BaseFunction>? GuardianOptions { get; set; }
        }
    }
}