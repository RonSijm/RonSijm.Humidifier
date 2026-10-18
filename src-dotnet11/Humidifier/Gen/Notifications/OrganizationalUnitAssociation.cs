namespace Humidifier.Notifications
{
    using global::System.Collections.Generic;

    public class OrganizationalUnitAssociation : Humidifier.Base.BaseResource, IHaveOrganizationalUnitId, IHaveNotificationConfigurationArn
    {
        public override string AWSTypeName { get => AWS.Notifications.OrganizationalUnitAssociation; }

        /// <summary>
        /// OrganizationalUnitId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-notifications-organizationalunitassociation.html#cfn-notifications-organizationalunitassociation-organizationalunitid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? OrganizationalUnitId { get; set; }

        /// <summary>
        /// NotificationConfigurationArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-notifications-organizationalunitassociation.html#cfn-notifications-organizationalunitassociation-notificationconfigurationarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? NotificationConfigurationArn { get; set; }
    }
}