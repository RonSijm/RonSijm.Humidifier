namespace Humidifier.DevOpsGuru
{
    using System.Collections.Generic;
    using NotificationChannelTypes;

    public class NotificationChannel : Humidifier.Resource
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::DevOpsGuru::NotificationChannel";
            }
        }

        /// <summary>
        /// Config
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-devopsguru-notificationchannel.html#cfn-devopsguru-notificationchannel-config
        /// Required: True
        /// UpdateType: Immutable
        /// Type: NotificationChannelConfig
        /// </summary>
        public NotificationChannelConfig Config { get; set; }
    }

    namespace NotificationChannelTypes
    {
        public class NotificationChannelConfig
        {
            /// <summary>
            /// Filters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsguru-notificationchannel-notificationchannelconfig.html#cfn-devopsguru-notificationchannel-notificationchannelconfig-filters
            /// Required: False
            /// UpdateType: Immutable
            /// Type: NotificationFilterConfig
            /// </summary>
            public NotificationFilterConfig Filters { get; set; }
            /// <summary>
            /// Sns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsguru-notificationchannel-notificationchannelconfig.html#cfn-devopsguru-notificationchannel-notificationchannelconfig-sns
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SnsChannelConfig
            /// </summary>
            public SnsChannelConfig Sns { get; set; }
        }

        public class NotificationFilterConfig
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

        public class SnsChannelConfig
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