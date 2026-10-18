namespace Humidifier.Notifications
{
    using global::System.Collections.Generic;

    public class ChannelAssociation : Humidifier.Base.BaseResource, IHaveNotificationConfigurationArn, IHaveArn
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
        public Union<string, BaseFunction>? NotificationConfigurationArn { get; set; }

        /// <summary>
        /// Arn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-notifications-channelassociation.html#cfn-notifications-channelassociation-arn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Arn { get; set; }
    }
}