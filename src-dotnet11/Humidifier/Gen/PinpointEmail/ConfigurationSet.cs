namespace Humidifier.PinpointEmail
{
    using global::System.Collections.Generic;
    using ConfigurationSetTypes;

    public class ConfigurationSet : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHavePinpointEmailConfigurationSetTypesSendingOptionsSendingOptions, IHavePinpointEmailConfigurationSetTypesTrackingOptionsTrackingOptions, IHavePinpointEmailConfigurationSetTypesReputationOptionsReputationOptions, IHavePinpointEmailConfigurationSetTypesDeliveryOptionsDeliveryOptions, IHaveListOfPinpointEmailConfigurationSetTypesTagsTags, IHaveName
    {
        public override string AWSTypeName { get => AWS.PinpointEmail.ConfigurationSet; }
        /// <summary>
        /// SendingOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpointemail-configurationset.html#cfn-pinpointemail-configurationset-sendingoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SendingOptions
        /// </summary>
        public Union<Humidifier.PinpointEmail.ConfigurationSetTypes.SendingOptions, BaseFunction>? SendingOptions { get; set; }
        /// <summary>
        /// TrackingOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpointemail-configurationset.html#cfn-pinpointemail-configurationset-trackingoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TrackingOptions
        /// </summary>
        public Union<Humidifier.PinpointEmail.ConfigurationSetTypes.TrackingOptions, BaseFunction>? TrackingOptions { get; set; }
        /// <summary>
        /// ReputationOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpointemail-configurationset.html#cfn-pinpointemail-configurationset-reputationoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ReputationOptions
        /// </summary>
        public Union<Humidifier.PinpointEmail.ConfigurationSetTypes.ReputationOptions, BaseFunction>? ReputationOptions { get; set; }
        /// <summary>
        /// DeliveryOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpointemail-configurationset.html#cfn-pinpointemail-configurationset-deliveryoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DeliveryOptions
        /// </summary>
        public Union<Humidifier.PinpointEmail.ConfigurationSetTypes.DeliveryOptions, BaseFunction>? DeliveryOptions { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpointemail-configurationset.html#cfn-pinpointemail-configurationset-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tags
        /// </summary>
        public Union<IReadOnlyList<Humidifier.PinpointEmail.ConfigurationSetTypes.Tags>, IReadOnlyList<Union<Humidifier.PinpointEmail.ConfigurationSetTypes.Tags, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ConfigurationSetTypes
    {
        public class DeliveryOptions : Humidifier.Base.BaseSubResource, IHaveSendingPoolName
        {
            /// <summary>
            /// SendingPoolName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpointemail-configurationset-deliveryoptions.html#cfn-pinpointemail-configurationset-deliveryoptions-sendingpoolname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SendingPoolName { get; set; }
        }

        public class ReputationOptions : Humidifier.Base.BaseSubResource, IHaveReputationMetricsEnabled_Boolean
        {
            /// <summary>
            /// ReputationMetricsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpointemail-configurationset-reputationoptions.html#cfn-pinpointemail-configurationset-reputationoptions-reputationmetricsenabled
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpointemail-configurationset-sendingoptions.html#cfn-pinpointemail-configurationset-sendingoptions-sendingenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? SendingEnabled { get; set; }
        }

        public class Tags : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpointemail-configurationset-tags.html#cfn-pinpointemail-configurationset-tags-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpointemail-configurationset-tags.html#cfn-pinpointemail-configurationset-tags-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class TrackingOptions : Humidifier.Base.BaseSubResource, IHaveCustomRedirectDomain
        {
            /// <summary>
            /// CustomRedirectDomain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpointemail-configurationset-trackingoptions.html#cfn-pinpointemail-configurationset-trackingoptions-customredirectdomain
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CustomRedirectDomain { get; set; }
        }
    }
}