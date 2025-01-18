namespace Humidifier.Notifications
{
    using System.Collections.Generic;
    using EventRuleTypes;

    public class EventRule : Humidifier.Base.BaseResource, IHaveSource, IHaveRegions, IHaveEventType, IHaveEventPattern
    {
        public class Attributes
        {
            public static string StatusSummaryByRegion =  "StatusSummaryByRegion" ;
            public static string CreationTime =  "CreationTime" ;
            public static string ManagedRules =  "ManagedRules" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Notifications.EventRule; }
        /// <summary>
        /// EventPattern
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-notifications-eventrule.html#cfn-notifications-eventrule-eventpattern
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic EventPattern { get; set; }

        /// <summary>
        /// EventType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-notifications-eventrule.html#cfn-notifications-eventrule-eventtype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic EventType { get; set; }

        /// <summary>
        /// NotificationConfigurationArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-notifications-eventrule.html#cfn-notifications-eventrule-notificationconfigurationarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic NotificationConfigurationArn { get; set; }

        /// <summary>
        /// Regions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-notifications-eventrule.html#cfn-notifications-eventrule-regions
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public dynamic Regions { get; set; }

        /// <summary>
        /// Source
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-notifications-eventrule.html#cfn-notifications-eventrule-source
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Source { get; set; }
    }

    namespace EventRuleTypes
    {
        public class EventRuleStatusSummary : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveReason
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-notifications-eventrule-eventrulestatussummary.html#cfn-notifications-eventrule-eventrulestatussummary-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// Reason
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-notifications-eventrule-eventrulestatussummary.html#cfn-notifications-eventrule-eventrulestatussummary-reason
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Reason { get; set; }
        }
    }
}