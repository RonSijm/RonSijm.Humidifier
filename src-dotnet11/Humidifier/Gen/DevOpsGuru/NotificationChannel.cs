namespace Humidifier.DevOpsGuru
{
    using global::System.Collections.Generic;
    using NotificationChannelTypes;

    public class NotificationChannel : Humidifier.Base.BaseResource, IHaveDevOpsGuruNotificationChannelTypesNotificationChannelConfigConfig
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.DevOpsGuru.NotificationChannel; }

        /// <summary>
        /// Config
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-devopsguru-notificationchannel.html#cfn-devopsguru-notificationchannel-config
        /// Required: True
        /// UpdateType: Immutable
        /// Type: NotificationChannelConfig
        /// </summary>
        [Required]
        public Union<Humidifier.DevOpsGuru.NotificationChannelTypes.NotificationChannelConfig, BaseFunction>? Config { get; set; }
    }

    namespace NotificationChannelTypes
    {
        public class NotificationChannelConfig : Humidifier.Base.BaseSubResource, IHaveDevOpsGuruNotificationChannelTypesNotificationFilterConfigFilters, IHaveDevOpsGuruNotificationChannelTypesSnsChannelConfigSns
        {
            /// <summary>
            /// Filters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsguru-notificationchannel-notificationchannelconfig.html#cfn-devopsguru-notificationchannel-notificationchannelconfig-filters
            /// Required: False
            /// UpdateType: Immutable
            /// Type: NotificationFilterConfig
            /// </summary>
            public Union<Humidifier.DevOpsGuru.NotificationChannelTypes.NotificationFilterConfig, BaseFunction>? Filters { get; set; }
            /// <summary>
            /// Sns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsguru-notificationchannel-notificationchannelconfig.html#cfn-devopsguru-notificationchannel-notificationchannelconfig-sns
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SnsChannelConfig
            /// </summary>
            public Union<Humidifier.DevOpsGuru.NotificationChannelTypes.SnsChannelConfig, BaseFunction>? Sns { get; set; }
        }

        public class NotificationFilterConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfMessageTypes, IHaveStringListOfSeverities
        {
            /// <summary>
            /// MessageTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsguru-notificationchannel-notificationfilterconfig.html#cfn-devopsguru-notificationchannel-notificationfilterconfig-messagetypes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? MessageTypes { get; set; }
            /// <summary>
            /// Severities
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsguru-notificationchannel-notificationfilterconfig.html#cfn-devopsguru-notificationchannel-notificationfilterconfig-severities
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Severities { get; set; }
        }

        public class SnsChannelConfig : Humidifier.Base.BaseSubResource, IHaveTopicArn
        {
            /// <summary>
            /// TopicArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsguru-notificationchannel-snschannelconfig.html#cfn-devopsguru-notificationchannel-snschannelconfig-topicarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TopicArn { get; set; }
        }
    }
}