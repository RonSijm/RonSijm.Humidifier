namespace Humidifier.Notifications
{
    using System.Collections.Generic;
    using NotificationHubTypes;

    public class NotificationHub : Humidifier.Base.BaseResource, IHaveRegion
    {
        public class Attributes
        {
            public static string CreationTime =  "CreationTime" ;
            public static string NotificationHubStatusSummary =  "NotificationHubStatusSummary" ;
        }

        public override string AWSTypeName { get => AWS.Notifications.NotificationHub; }

        /// <summary>
        /// Region
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-notifications-notificationhub.html#cfn-notifications-notificationhub-region
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Region { get; set; }
    }

    namespace NotificationHubTypes
    {
        public class NotificationHubStatusSummary : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// NotificationHubStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-notifications-notificationhub-notificationhubstatussummary.html#cfn-notifications-notificationhub-notificationhubstatussummary-notificationhubstatus
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NotificationHubStatus { get; set; }
            /// <summary>
            /// NotificationHubStatusReason
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-notifications-notificationhub-notificationhubstatussummary.html#cfn-notifications-notificationhub-notificationhubstatussummary-notificationhubstatusreason
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NotificationHubStatusReason { get; set; }
        }
    }
}