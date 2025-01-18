namespace Humidifier.Notifications
{
    using System.Collections.Generic;

    public class ChannelAssociation : Humidifier.Base.BaseResource, IHaveArn
    {
        public override string AWSTypeName { get => AWS.Notifications.ChannelAssociation; }

        /// <summary>
        /// NotificationConfigurationArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-notifications-channelassociation.html#cfn-notifications-channelassociation-notificationconfigurationarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic NotificationConfigurationArn { get; set; }

        /// <summary>
        /// Arn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-notifications-channelassociation.html#cfn-notifications-channelassociation-arn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Arn { get; set; }
    }
}