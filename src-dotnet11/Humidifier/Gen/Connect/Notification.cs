namespace Humidifier.Connect
{
    using global::System.Collections.Generic;
    using NotificationTypes;

    public class Notification : Humidifier.Base.BaseResource, IHaveTags, IHaveStringListOfRecipients, IHaveConnectNotificationTypesNotificationContentContent, IHavePriority, IHaveInstanceArn, IHaveExpiresAt
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
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Recipients { get; set; }

        /// <summary>
        /// Content
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-notification.html#cfn-connect-notification-content
        /// Required: True
        /// UpdateType: Mutable
        /// Type: NotificationContent
        /// </summary>
        [Required]
        public Union<Humidifier.Connect.NotificationTypes.NotificationContent, BaseFunction>? Content { get; set; }
        /// <summary>
        /// Priority
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-notification.html#cfn-connect-notification-priority
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Priority { get; set; }

        /// <summary>
        /// InstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-notification.html#cfn-connect-notification-instancearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? InstanceArn { get; set; }
        /// <summary>
        /// ExpiresAt
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-notification.html#cfn-connect-notification-expiresat
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ExpiresAt { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-notification.html#cfn-connect-notification-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace NotificationTypes
    {
        public class NotificationContent : Humidifier.Base.BaseSubResource, IHaveDeDE, IHavePtBR, IHaveZhCN, IHaveIdID, IHaveItIT, IHaveEnUS, IHaveKoKR, IHaveFrFR, IHaveZhTW, IHaveEsES, IHaveJaJP
        {
            /// <summary>
            /// DeDE
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-notification-notificationcontent.html#cfn-connect-notification-notificationcontent-dede
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeDE { get; set; }
            /// <summary>
            /// PtBR
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-notification-notificationcontent.html#cfn-connect-notification-notificationcontent-ptbr
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PtBR { get; set; }
            /// <summary>
            /// ZhCN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-notification-notificationcontent.html#cfn-connect-notification-notificationcontent-zhcn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ZhCN { get; set; }
            /// <summary>
            /// IdID
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-notification-notificationcontent.html#cfn-connect-notification-notificationcontent-idid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IdID { get; set; }
            /// <summary>
            /// ItIT
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-notification-notificationcontent.html#cfn-connect-notification-notificationcontent-itit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ItIT { get; set; }
            /// <summary>
            /// EnUS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-notification-notificationcontent.html#cfn-connect-notification-notificationcontent-enus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EnUS { get; set; }
            /// <summary>
            /// KoKR
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-notification-notificationcontent.html#cfn-connect-notification-notificationcontent-kokr
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KoKR { get; set; }
            /// <summary>
            /// FrFR
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-notification-notificationcontent.html#cfn-connect-notification-notificationcontent-frfr
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FrFR { get; set; }
            /// <summary>
            /// ZhTW
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-notification-notificationcontent.html#cfn-connect-notification-notificationcontent-zhtw
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ZhTW { get; set; }
            /// <summary>
            /// EsES
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-notification-notificationcontent.html#cfn-connect-notification-notificationcontent-eses
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EsES { get; set; }
            /// <summary>
            /// JaJP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-notification-notificationcontent.html#cfn-connect-notification-notificationcontent-jajp
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? JaJP { get; set; }
        }
    }
}