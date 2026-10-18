namespace Humidifier.CE
{
    using global::System.Collections.Generic;
    using AnomalySubscriptionTypes;

    public class AnomalySubscription : Humidifier.Base.BaseResource, IHaveStringListOfMonitorArnList, IHaveListOfCEAnomalySubscriptionTypesResourceTagResourceTags, IHaveFrequency, IHaveSubscriptionName, IHaveListOfCEAnomalySubscriptionTypesSubscriberSubscribers, IHaveThreshold_Double, IHaveThresholdExpression
    {
        public class Attributes
        {
            public static string AccountId =  "AccountId" ;
            public static string SubscriptionArn =  "SubscriptionArn" ;
        }

        public override string AWSTypeName { get => AWS.CE.AnomalySubscription; }

        /// <summary>
        /// MonitorArnList
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ce-anomalysubscription.html#cfn-ce-anomalysubscription-monitorarnlist
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? MonitorArnList { get; set; }
        /// <summary>
        /// ResourceTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ce-anomalysubscription.html#cfn-ce-anomalysubscription-resourcetags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: ResourceTag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CE.AnomalySubscriptionTypes.ResourceTag>, IReadOnlyList<Union<Humidifier.CE.AnomalySubscriptionTypes.ResourceTag, BaseFunction>>, BaseFunction>? ResourceTags { get; set; }

        /// <summary>
        /// Frequency
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ce-anomalysubscription.html#cfn-ce-anomalysubscription-frequency
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Frequency { get; set; }

        /// <summary>
        /// SubscriptionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ce-anomalysubscription.html#cfn-ce-anomalysubscription-subscriptionname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SubscriptionName { get; set; }

        /// <summary>
        /// Subscribers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ce-anomalysubscription.html#cfn-ce-anomalysubscription-subscribers
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Subscriber
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.CE.AnomalySubscriptionTypes.Subscriber>, IReadOnlyList<Union<Humidifier.CE.AnomalySubscriptionTypes.Subscriber, BaseFunction>>, BaseFunction>? Subscribers { get; set; }
        /// <summary>
        /// Threshold
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ce-anomalysubscription.html#cfn-ce-anomalysubscription-threshold
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Double
        /// </summary>
        public Union<double, BaseFunction>? Threshold { get; set; }
        /// <summary>
        /// ThresholdExpression
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ce-anomalysubscription.html#cfn-ce-anomalysubscription-thresholdexpression
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ThresholdExpression { get; set; }
    }

    namespace AnomalySubscriptionTypes
    {
        public class ResourceTag : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ce-anomalysubscription-resourcetag.html#cfn-ce-anomalysubscription-resourcetag-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ce-anomalysubscription-resourcetag.html#cfn-ce-anomalysubscription-resourcetag-key
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class Subscriber : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveType, IHaveAddress
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ce-anomalysubscription-subscriber.html#cfn-ce-anomalysubscription-subscriber-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ce-anomalysubscription-subscriber.html#cfn-ce-anomalysubscription-subscriber-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Address
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ce-anomalysubscription-subscriber.html#cfn-ce-anomalysubscription-subscriber-address
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Address { get; set; }
        }
    }
}