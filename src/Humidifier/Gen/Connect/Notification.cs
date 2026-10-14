namespace Humidifier.Connect
{
    using global::System.Collections.Generic;
    using NotificationTypes;

    public class Notification : Humidifier.Base.BaseResource, IHaveTags, IHavePriority, IHaveInstanceArn
    {
        public class Attributes
        {
            public static string CreatedAt =  "CreatedAt" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Connect.Notification; }
        /// <summary>
        /// Recipients
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-notification.html#cfn-connect-notification-recipients
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic Recipients { get; set; }

        /// <summary>
        /// Content
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-notification.html#cfn-connect-notification-content
        /// Required: True
        /// UpdateType: Mutable
        /// Type: NotificationContent
        /// </summary>
        [Required]
        public Humidifier.Connect.NotificationTypes.NotificationContent Content { get; set; }
        /// <summary>
        /// Priority
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-notification.html#cfn-connect-notification-priority
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Priority { get; set; }

        /// <summary>
        /// InstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-notification.html#cfn-connect-notification-instancearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic InstanceArn { get; set; }
        /// <summary>
        /// ExpiresAt
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-notification.html#cfn-connect-notification-expiresat
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ExpiresAt { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-notification.html#cfn-connect-notification-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace NotificationTypes
    {
        public class NotificationContent : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DeDE
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-notification-notificationcontent.html#cfn-connect-notification-notificationcontent-dede
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DeDE { get; set; }
            /// <summary>
            /// PtBR
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-notification-notificationcontent.html#cfn-connect-notification-notificationcontent-ptbr
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PtBR { get; set; }
            /// <summary>
            /// ZhCN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-notification-notificationcontent.html#cfn-connect-notification-notificationcontent-zhcn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ZhCN { get; set; }
            /// <summary>
            /// IdID
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-notification-notificationcontent.html#cfn-connect-notification-notificationcontent-idid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IdID { get; set; }
            /// <summary>
            /// ItIT
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-notification-notificationcontent.html#cfn-connect-notification-notificationcontent-itit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ItIT { get; set; }
            /// <summary>
            /// EnUS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-notification-notificationcontent.html#cfn-connect-notification-notificationcontent-enus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EnUS { get; set; }
            /// <summary>
            /// KoKR
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-notification-notificationcontent.html#cfn-connect-notification-notificationcontent-kokr
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KoKR { get; set; }
            /// <summary>
            /// FrFR
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-notification-notificationcontent.html#cfn-connect-notification-notificationcontent-frfr
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FrFR { get; set; }
            /// <summary>
            /// ZhTW
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-notification-notificationcontent.html#cfn-connect-notification-notificationcontent-zhtw
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ZhTW { get; set; }
            /// <summary>
            /// EsES
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-notification-notificationcontent.html#cfn-connect-notification-notificationcontent-eses
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EsES { get; set; }
            /// <summary>
            /// JaJP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-notification-notificationcontent.html#cfn-connect-notification-notificationcontent-jajp
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic JaJP { get; set; }
        }
    }
}