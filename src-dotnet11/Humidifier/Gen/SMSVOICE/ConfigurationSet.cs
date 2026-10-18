namespace Humidifier.SMSVOICE
{
    using global::System.Collections.Generic;
    using ConfigurationSetTypes;

    public class ConfigurationSet : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveListOfSMSVOICEConfigurationSetTypesEventDestinationEventDestinations, IHaveMessageFeedbackEnabled_Boolean, IHaveConfigurationSetName, IHaveDefaultSenderId, IHaveProtectConfigurationId
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.SMSVOICE.ConfigurationSet; }
        /// <summary>
        /// EventDestinations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-configurationset.html#cfn-smsvoice-configurationset-eventdestinations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: EventDestination
        /// </summary>
        public Union<IReadOnlyList<Humidifier.SMSVOICE.ConfigurationSetTypes.EventDestination>, IReadOnlyList<Union<Humidifier.SMSVOICE.ConfigurationSetTypes.EventDestination, BaseFunction>>, BaseFunction>? EventDestinations { get; set; }
        /// <summary>
        /// MessageFeedbackEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-configurationset.html#cfn-smsvoice-configurationset-messagefeedbackenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? MessageFeedbackEnabled { get; set; }
        public Union<string, BaseFunction>? ConfigurationSetName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// DefaultSenderId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-configurationset.html#cfn-smsvoice-configurationset-defaultsenderid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DefaultSenderId { get; set; }
        /// <summary>
        /// ProtectConfigurationId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-configurationset.html#cfn-smsvoice-configurationset-protectconfigurationid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ProtectConfigurationId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-configurationset.html#cfn-smsvoice-configurationset-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ConfigurationSetTypes
    {
        public class CloudWatchLogsDestination : Humidifier.Base.BaseSubResource, IHaveIamRoleArn, IHaveLogGroupArn
        {
            /// <summary>
            /// IamRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-configurationset-cloudwatchlogsdestination.html#cfn-smsvoice-configurationset-cloudwatchlogsdestination-iamrolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IamRoleArn { get; set; }
            /// <summary>
            /// LogGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-configurationset-cloudwatchlogsdestination.html#cfn-smsvoice-configurationset-cloudwatchlogsdestination-loggrouparn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogGroupArn { get; set; }
        }

        public class EventDestination : Humidifier.Base.BaseSubResource, IHaveEventDestinationName, IHaveSMSVOICEConfigurationSetTypesSnsDestinationSnsDestination, IHaveEnabled_Boolean, IHaveStringListOfMatchingEventTypes, IHaveSMSVOICEConfigurationSetTypesCloudWatchLogsDestinationCloudWatchLogsDestination, IHaveSMSVOICEConfigurationSetTypesKinesisFirehoseDestinationKinesisFirehoseDestination
        {
            /// <summary>
            /// EventDestinationName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-configurationset-eventdestination.html#cfn-smsvoice-configurationset-eventdestination-eventdestinationname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EventDestinationName { get; set; }
            /// <summary>
            /// SnsDestination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-configurationset-eventdestination.html#cfn-smsvoice-configurationset-eventdestination-snsdestination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SnsDestination
            /// </summary>
            public Union<Humidifier.SMSVOICE.ConfigurationSetTypes.SnsDestination, BaseFunction>? SnsDestination { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-configurationset-eventdestination.html#cfn-smsvoice-configurationset-eventdestination-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// MatchingEventTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-configurationset-eventdestination.html#cfn-smsvoice-configurationset-eventdestination-matchingeventtypes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? MatchingEventTypes { get; set; }
            /// <summary>
            /// CloudWatchLogsDestination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-configurationset-eventdestination.html#cfn-smsvoice-configurationset-eventdestination-cloudwatchlogsdestination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudWatchLogsDestination
            /// </summary>
            public Union<Humidifier.SMSVOICE.ConfigurationSetTypes.CloudWatchLogsDestination, BaseFunction>? CloudWatchLogsDestination { get; set; }
            /// <summary>
            /// KinesisFirehoseDestination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-configurationset-eventdestination.html#cfn-smsvoice-configurationset-eventdestination-kinesisfirehosedestination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KinesisFirehoseDestination
            /// </summary>
            public Union<Humidifier.SMSVOICE.ConfigurationSetTypes.KinesisFirehoseDestination, BaseFunction>? KinesisFirehoseDestination { get; set; }
        }

        public class KinesisFirehoseDestination : Humidifier.Base.BaseSubResource, IHaveDeliveryStreamArn, IHaveIamRoleArn
        {
            /// <summary>
            /// DeliveryStreamArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-configurationset-kinesisfirehosedestination.html#cfn-smsvoice-configurationset-kinesisfirehosedestination-deliverystreamarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeliveryStreamArn { get; set; }
            /// <summary>
            /// IamRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-configurationset-kinesisfirehosedestination.html#cfn-smsvoice-configurationset-kinesisfirehosedestination-iamrolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IamRoleArn { get; set; }
        }

        public class SnsDestination : Humidifier.Base.BaseSubResource, IHaveTopicArn
        {
            /// <summary>
            /// TopicArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-configurationset-snsdestination.html#cfn-smsvoice-configurationset-snsdestination-topicarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TopicArn { get; set; }
        }
    }
}