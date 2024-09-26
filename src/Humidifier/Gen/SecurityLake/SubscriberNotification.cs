namespace Humidifier.SecurityLake
{
    using System.Collections.Generic;
    using SubscriberNotificationTypes;

    public class SubscriberNotification : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string SubscriberEndpoint =  "SubscriberEndpoint" ;
        }

        public override string AWSTypeName { get => AWS.SecurityLake.SubscriberNotification; }

        /// <summary>
        /// SubscriberArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securitylake-subscribernotification.html#cfn-securitylake-subscribernotification-subscriberarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic SubscriberArn { get; set; }

        /// <summary>
        /// NotificationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securitylake-subscribernotification.html#cfn-securitylake-subscribernotification-notificationconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: NotificationConfiguration
        /// </summary>
        [Required]
        public Humidifier.SecurityLake.SubscriberNotificationTypes.NotificationConfiguration NotificationConfiguration { get; set; }
    }

    namespace SubscriberNotificationTypes
    {
        public class HttpsNotificationConfiguration : Humidifier.Base.BaseSubResource, IHaveEndpoint, IHaveHttpMethod
        {
            /// <summary>
            /// Endpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securitylake-subscribernotification-httpsnotificationconfiguration.html#cfn-securitylake-subscribernotification-httpsnotificationconfiguration-endpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Endpoint { get; set; }
            /// <summary>
            /// TargetRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securitylake-subscribernotification-httpsnotificationconfiguration.html#cfn-securitylake-subscribernotification-httpsnotificationconfiguration-targetrolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetRoleArn { get; set; }
            /// <summary>
            /// AuthorizationApiKeyValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securitylake-subscribernotification-httpsnotificationconfiguration.html#cfn-securitylake-subscribernotification-httpsnotificationconfiguration-authorizationapikeyvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AuthorizationApiKeyValue { get; set; }
            /// <summary>
            /// AuthorizationApiKeyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securitylake-subscribernotification-httpsnotificationconfiguration.html#cfn-securitylake-subscribernotification-httpsnotificationconfiguration-authorizationapikeyname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AuthorizationApiKeyName { get; set; }
            /// <summary>
            /// HttpMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securitylake-subscribernotification-httpsnotificationconfiguration.html#cfn-securitylake-subscribernotification-httpsnotificationconfiguration-httpmethod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HttpMethod { get; set; }
        }

        public class NotificationConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// HttpsNotificationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securitylake-subscribernotification-notificationconfiguration.html#cfn-securitylake-subscribernotification-notificationconfiguration-httpsnotificationconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpsNotificationConfiguration
            /// </summary>
            public Humidifier.SecurityLake.SubscriberNotificationTypes.HttpsNotificationConfiguration HttpsNotificationConfiguration { get; set; }
            /// <summary>
            /// SqsNotificationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securitylake-subscribernotification-notificationconfiguration.html#cfn-securitylake-subscribernotification-notificationconfiguration-sqsnotificationconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic SqsNotificationConfiguration { get; set; }
        }
    }
}