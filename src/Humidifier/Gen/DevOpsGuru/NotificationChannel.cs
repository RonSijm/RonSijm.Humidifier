namespace Humidifier.DevOpsGuru
{
    using System.Collections.Generic;
    using NotificationChannelTypes;

    public class NotificationChannel : Humidifier.Base.BaseResource
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
        public Humidifier.DevOpsGuru.NotificationChannelTypes.NotificationChannelConfig Config { get; set; }
    }

    namespace NotificationChannelTypes
    {
        public class NotificationChannelConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Filters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsguru-notificationchannel-notificationchannelconfig.html#cfn-devopsguru-notificationchannel-notificationchannelconfig-filters
            /// Required: False
            /// UpdateType: Immutable
            /// Type: NotificationFilterConfig
            /// </summary>
            public Humidifier.DevOpsGuru.NotificationChannelTypes.NotificationFilterConfig Filters { get; set; }
            /// <summary>
            /// Sns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsguru-notificationchannel-notificationchannelconfig.html#cfn-devopsguru-notificationchannel-notificationchannelconfig-sns
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SnsChannelConfig
            /// </summary>
            public Humidifier.DevOpsGuru.NotificationChannelTypes.SnsChannelConfig Sns { get; set; }
        }

        public class NotificationFilterConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MessageTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsguru-notificationchannel-notificationfilterconfig.html#cfn-devopsguru-notificationchannel-notificationfilterconfig-messagetypes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic MessageTypes { get; set; }
            /// <summary>
            /// Severities
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsguru-notificationchannel-notificationfilterconfig.html#cfn-devopsguru-notificationchannel-notificationfilterconfig-severities
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Severities { get; set; }
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
            public dynamic TopicArn { get; set; }
        }
    }
}