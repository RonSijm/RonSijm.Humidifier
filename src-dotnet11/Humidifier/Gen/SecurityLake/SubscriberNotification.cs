namespace Humidifier.SecurityLake
{
    using global::System.Collections.Generic;
    using SubscriberNotificationTypes;

    public class SubscriberNotification : Humidifier.Base.BaseResource, IHaveSubscriberArn, IHaveSecurityLakeSubscriberNotificationTypesNotificationConfigurationNotificationConfiguration
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
        public Union<string, BaseFunction>? SubscriberArn { get; set; }

        /// <summary>
        /// NotificationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securitylake-subscribernotification.html#cfn-securitylake-subscribernotification-notificationconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: NotificationConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.SecurityLake.SubscriberNotificationTypes.NotificationConfiguration, BaseFunction>? NotificationConfiguration { get; set; }
    }

    namespace SubscriberNotificationTypes
    {
        public class HttpsNotificationConfiguration : Humidifier.Base.BaseSubResource, IHaveEndpoint, IHaveTargetRoleArn, IHaveAuthorizationApiKeyValue, IHaveAuthorizationApiKeyName, IHaveHttpMethod
        {
            /// <summary>
            /// Endpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securitylake-subscribernotification-httpsnotificationconfiguration.html#cfn-securitylake-subscribernotification-httpsnotificationconfiguration-endpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Endpoint { get; set; }
            /// <summary>
            /// TargetRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securitylake-subscribernotification-httpsnotificationconfiguration.html#cfn-securitylake-subscribernotification-httpsnotificationconfiguration-targetrolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetRoleArn { get; set; }
            /// <summary>
            /// AuthorizationApiKeyValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securitylake-subscribernotification-httpsnotificationconfiguration.html#cfn-securitylake-subscribernotification-httpsnotificationconfiguration-authorizationapikeyvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthorizationApiKeyValue { get; set; }
            /// <summary>
            /// AuthorizationApiKeyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securitylake-subscribernotification-httpsnotificationconfiguration.html#cfn-securitylake-subscribernotification-httpsnotificationconfiguration-authorizationapikeyname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthorizationApiKeyName { get; set; }
            /// <summary>
            /// HttpMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securitylake-subscribernotification-httpsnotificationconfiguration.html#cfn-securitylake-subscribernotification-httpsnotificationconfiguration-httpmethod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HttpMethod { get; set; }
        }

        public class NotificationConfiguration : Humidifier.Base.BaseSubResource, IHaveSecurityLakeSubscriberNotificationTypesHttpsNotificationConfigurationHttpsNotificationConfiguration, IHaveSqsNotificationConfiguration_Json
        {
            /// <summary>
            /// HttpsNotificationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securitylake-subscribernotification-notificationconfiguration.html#cfn-securitylake-subscribernotification-notificationconfiguration-httpsnotificationconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpsNotificationConfiguration
            /// </summary>
            public Union<Humidifier.SecurityLake.SubscriberNotificationTypes.HttpsNotificationConfiguration, BaseFunction>? HttpsNotificationConfiguration { get; set; }
            /// <summary>
            /// SqsNotificationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securitylake-subscribernotification-notificationconfiguration.html#cfn-securitylake-subscribernotification-notificationconfiguration-sqsnotificationconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? SqsNotificationConfiguration { get; set; }
        }
    }
}