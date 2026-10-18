namespace Humidifier.Greengrass
{
    using global::System.Collections.Generic;
    using SubscriptionDefinitionVersionTypes;

    public class SubscriptionDefinitionVersion : Humidifier.Base.BaseResource, IHaveSubscriptionDefinitionId, IHaveListOfGreengrassSubscriptionDefinitionVersionTypesSubscriptionSubscriptions
    {
        public override string AWSTypeName { get => AWS.Greengrass.SubscriptionDefinitionVersion; }

        /// <summary>
        /// SubscriptionDefinitionId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-subscriptiondefinitionversion.html#cfn-greengrass-subscriptiondefinitionversion-subscriptiondefinitionid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SubscriptionDefinitionId { get; set; }

        /// <summary>
        /// Subscriptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-subscriptiondefinitionversion.html#cfn-greengrass-subscriptiondefinitionversion-subscriptions
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Subscription
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.Greengrass.SubscriptionDefinitionVersionTypes.Subscription>, IReadOnlyList<Union<Humidifier.Greengrass.SubscriptionDefinitionVersionTypes.Subscription, BaseFunction>>, BaseFunction>? Subscriptions { get; set; }
    }

    namespace SubscriptionDefinitionVersionTypes
    {
        public class Subscription : Humidifier.Base.BaseSubResource, IHaveTarget, IHaveId, IHaveSource, IHaveSubject
        {
            /// <summary>
            /// Target
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-subscriptiondefinitionversion-subscription.html#cfn-greengrass-subscriptiondefinitionversion-subscription-target
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Target { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-subscriptiondefinitionversion-subscription.html#cfn-greengrass-subscriptiondefinitionversion-subscription-id
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-subscriptiondefinitionversion-subscription.html#cfn-greengrass-subscriptiondefinitionversion-subscription-source
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Source { get; set; }
            /// <summary>
            /// Subject
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-subscriptiondefinitionversion-subscription.html#cfn-greengrass-subscriptiondefinitionversion-subscription-subject
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Subject { get; set; }
        }
    }
}