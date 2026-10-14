namespace Humidifier.UserNotifications
{
    using global::System.Collections.Generic;
    using NotificationEventTypes;

    public class NotificationEvent : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string SchemaVersion =  "SchemaVersion" ;
            public static string NotificationConfigurationArn =  "NotificationConfigurationArn" ;
            public static string EventStatus =  "EventStatus" ;
            public static string MessageComponents =  "MessageComponents" ;
            public static string AggregationEventType =  "AggregationEventType" ;
            public static string SourceEventDetailUrl =  "SourceEventDetailUrl" ;
            public static string NotificationType =  "NotificationType" ;
            public static string CreationTime =  "CreationTime" ;
            public static string SourceEventMetadata =  "SourceEventMetadata" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.UserNotifications.NotificationEvent; }
    }

    namespace NotificationEventTypes
    {
        public class Dimension : Humidifier.Base.BaseSubResource, IHaveName, IHaveValue
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-usernotifications-notificationevent-dimension.html#cfn-usernotifications-notificationevent-dimension-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-usernotifications-notificationevent-dimension.html#cfn-usernotifications-notificationevent-dimension-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class MessageComponents : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Headline
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-usernotifications-notificationevent-messagecomponents.html#cfn-usernotifications-notificationevent-messagecomponents-headline
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Headline { get; set; }
            /// <summary>
            /// ParagraphSummary
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-usernotifications-notificationevent-messagecomponents.html#cfn-usernotifications-notificationevent-messagecomponents-paragraphsummary
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParagraphSummary { get; set; }
            /// <summary>
            /// Dimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-usernotifications-notificationevent-messagecomponents.html#cfn-usernotifications-notificationevent-messagecomponents-dimensions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Dimension
            /// </summary>
            public List<Humidifier.UserNotifications.NotificationEventTypes.Dimension> Dimensions { get; set; }
        }

        public class Resource : Humidifier.Base.BaseSubResource, IHaveArn
        {
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-usernotifications-notificationevent-resource.html#cfn-usernotifications-notificationevent-resource-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
        }

        public class SourceEventMetadata : Humidifier.Base.BaseSubResource, IHaveSource, IHaveEventType
        {
            /// <summary>
            /// EventTypeVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-usernotifications-notificationevent-sourceeventmetadata.html#cfn-usernotifications-notificationevent-sourceeventmetadata-eventtypeversion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EventTypeVersion { get; set; }
            /// <summary>
            /// RelatedResources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-usernotifications-notificationevent-sourceeventmetadata.html#cfn-usernotifications-notificationevent-sourceeventmetadata-relatedresources
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Resource
            /// </summary>
            public List<Humidifier.UserNotifications.NotificationEventTypes.Resource> RelatedResources { get; set; }
            /// <summary>
            /// EventType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-usernotifications-notificationevent-sourceeventmetadata.html#cfn-usernotifications-notificationevent-sourceeventmetadata-eventtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EventType { get; set; }
            /// <summary>
            /// SourceEventId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-usernotifications-notificationevent-sourceeventmetadata.html#cfn-usernotifications-notificationevent-sourceeventmetadata-sourceeventid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceEventId { get; set; }
            /// <summary>
            /// RelatedAccount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-usernotifications-notificationevent-sourceeventmetadata.html#cfn-usernotifications-notificationevent-sourceeventmetadata-relatedaccount
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RelatedAccount { get; set; }
            /// <summary>
            /// EventOriginRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-usernotifications-notificationevent-sourceeventmetadata.html#cfn-usernotifications-notificationevent-sourceeventmetadata-eventoriginregion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EventOriginRegion { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-usernotifications-notificationevent-sourceeventmetadata.html#cfn-usernotifications-notificationevent-sourceeventmetadata-source
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Source { get; set; }
            /// <summary>
            /// EventOccurrenceTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-usernotifications-notificationevent-sourceeventmetadata.html#cfn-usernotifications-notificationevent-sourceeventmetadata-eventoccurrencetime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EventOccurrenceTime { get; set; }
        }
    }
}