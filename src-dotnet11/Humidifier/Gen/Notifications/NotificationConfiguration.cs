namespace Humidifier.Notifications
{
    using global::System.Collections.Generic;

    public class NotificationConfiguration : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveAggregationDuration, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CreationTime =  "CreationTime" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Notifications.NotificationConfiguration; }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-notifications-notificationconfiguration.html#cfn-notifications-notificationconfiguration-description
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// AggregationDuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-notifications-notificationconfiguration.html#cfn-notifications-notificationconfiguration-aggregationduration
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AggregationDuration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-notifications-notificationconfiguration.html#cfn-notifications-notificationconfiguration-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }
}