namespace Humidifier.Notifications
{
    using System.Collections.Generic;

    public class ManagedNotificationAdditionalChannelAssociation : Humidifier.Base.BaseResource
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
        public dynamic ChannelArn { get; set; }

        /// <summary>
        /// ManagedNotificationConfigurationArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-notifications-managednotificationadditionalchannelassociation.html#cfn-notifications-managednotificationadditionalchannelassociation-managednotificationconfigurationarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ManagedNotificationConfigurationArn { get; set; }
    }
}