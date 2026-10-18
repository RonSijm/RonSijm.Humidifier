namespace Humidifier.SNS
{
    using global::System.Collections.Generic;
    using TopicTypes;

    public class Topic : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveKmsMasterKeyId, IHaveTracingConfig, IHaveMaximumMessageSize_Integer, IHaveFifoTopic_Boolean, IHaveDataProtectionPolicy_Json, IHaveTopicName, IHaveSignatureVersion, IHaveListOfSNSTopicTypesLoggingConfigDeliveryStatusLogging, IHaveDisplayName, IHaveContentBasedDeduplication_Boolean, IHaveListOfSNSTopicTypesSubscriptionSubscription, IHaveFifoThroughputScope, IHaveArchivePolicy_Json
    {
        public class Attributes
        {
            public static string TopicArn =  "TopicArn" ;
            public static string TopicName =  "TopicName" ;
        }

        public override string AWSTypeName { get => AWS.SNS.Topic; }
        /// <summary>
        /// KmsMasterKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sns-topic.html#cfn-sns-topic-kmsmasterkeyid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsMasterKeyId { get; set; }
        /// <summary>
        /// TracingConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sns-topic.html#cfn-sns-topic-tracingconfig
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TracingConfig { get; set; }
        /// <summary>
        /// MaximumMessageSize
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sns-topic.html#cfn-sns-topic-maximummessagesize
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MaximumMessageSize { get; set; }
        /// <summary>
        /// FifoTopic
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sns-topic.html#cfn-sns-topic-fifotopic
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? FifoTopic { get; set; }
        /// <summary>
        /// DataProtectionPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sns-topic.html#cfn-sns-topic-dataprotectionpolicy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? DataProtectionPolicy { get; set; }
        public Union<string, BaseFunction>? TopicName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// SignatureVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sns-topic.html#cfn-sns-topic-signatureversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SignatureVersion { get; set; }
        /// <summary>
        /// DeliveryStatusLogging
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sns-topic.html#cfn-sns-topic-deliverystatuslogging
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: LoggingConfig
        /// </summary>
        public Union<IReadOnlyList<Humidifier.SNS.TopicTypes.LoggingConfig>, IReadOnlyList<Union<Humidifier.SNS.TopicTypes.LoggingConfig, BaseFunction>>, BaseFunction>? DeliveryStatusLogging { get; set; }
        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sns-topic.html#cfn-sns-topic-displayname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DisplayName { get; set; }
        /// <summary>
        /// ContentBasedDeduplication
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sns-topic.html#cfn-sns-topic-contentbaseddeduplication
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? ContentBasedDeduplication { get; set; }
        /// <summary>
        /// Subscription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sns-topic.html#cfn-sns-topic-subscription
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Subscription
        /// </summary>
        public Union<IReadOnlyList<Humidifier.SNS.TopicTypes.Subscription>, IReadOnlyList<Union<Humidifier.SNS.TopicTypes.Subscription, BaseFunction>>, BaseFunction>? Subscription { get; set; }
        /// <summary>
        /// FifoThroughputScope
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sns-topic.html#cfn-sns-topic-fifothroughputscope
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? FifoThroughputScope { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sns-topic.html#cfn-sns-topic-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// ArchivePolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sns-topic.html#cfn-sns-topic-archivepolicy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? ArchivePolicy { get; set; }
    }

    namespace TopicTypes
    {
        public class LoggingConfig : Humidifier.Base.BaseSubResource, IHaveFailureFeedbackRoleArn, IHaveSuccessFeedbackSampleRate, IHaveSuccessFeedbackRoleArn, IHaveProtocol
        {
            /// <summary>
            /// FailureFeedbackRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sns-topic-loggingconfig.html#cfn-sns-topic-loggingconfig-failurefeedbackrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FailureFeedbackRoleArn { get; set; }
            /// <summary>
            /// SuccessFeedbackSampleRate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sns-topic-loggingconfig.html#cfn-sns-topic-loggingconfig-successfeedbacksamplerate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SuccessFeedbackSampleRate { get; set; }
            /// <summary>
            /// SuccessFeedbackRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sns-topic-loggingconfig.html#cfn-sns-topic-loggingconfig-successfeedbackrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SuccessFeedbackRoleArn { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sns-topic-loggingconfig.html#cfn-sns-topic-loggingconfig-protocol
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Protocol { get; set; }
        }

        public class Subscription : Humidifier.Base.BaseSubResource, IHaveEndpoint, IHaveProtocol
        {
            /// <summary>
            /// Endpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sns-topic-subscription.html#cfn-sns-topic-subscription-endpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Endpoint { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sns-topic-subscription.html#cfn-sns-topic-subscription-protocol
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Protocol { get; set; }
        }
    }
}