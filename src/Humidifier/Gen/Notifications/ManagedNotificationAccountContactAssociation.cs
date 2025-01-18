namespace Humidifier.Notifications
{
    using System.Collections.Generic;

    public class ManagedNotificationAccountContactAssociation : Humidifier.Base.BaseResource
    {
        public override string AWSTypeName { get => AWS.Notifications.ManagedNotificationAccountContactAssociation; }

        /// <summary>
        /// ContactIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-notifications-managednotificationaccountcontactassociation.html#cfn-notifications-managednotificationaccountcontactassociation-contactidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ContactIdentifier { get; set; }

        /// <summary>
        /// ManagedNotificationConfigurationArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-notifications-managednotificationaccountcontactassociation.html#cfn-notifications-managednotificationaccountcontactassociation-managednotificationconfigurationarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ManagedNotificationConfigurationArn { get; set; }
    }
}