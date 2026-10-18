namespace Humidifier.Notifications
{
    using global::System.Collections.Generic;

    public class ManagedNotificationAdditionalChannelAssociation : Humidifier.Base.BaseResource, IHaveChannelArn, IHaveManagedNotificationConfigurationArn, IHaveIsSensitiveEventsSubscribed_Boolean
    {
        public override string AWSTypeName { get => AWS.Notifications.ManagedNotificationAdditionalChannelAssociation; }

        /// <summary>
        /// ChannelArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-notifications-managednotificationadditionalchannelassociation.html#cfn-notifications-managednotificationadditionalchannelassociation-channelarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ChannelArn { get; set; }

        /// <summary>
        /// ManagedNotificationConfigurationArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-notifications-managednotificationadditionalchannelassociation.html#cfn-notifications-managednotificationadditionalchannelassociation-managednotificationconfigurationarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ManagedNotificationConfigurationArn { get; set; }
        /// <summary>
        /// IsSensitiveEventsSubscribed
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-notifications-managednotificationadditionalchannelassociation.html#cfn-notifications-managednotificationadditionalchannelassociation-issensitiveeventssubscribed
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? IsSensitiveEventsSubscribed { get; set; }
    }
}