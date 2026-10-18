namespace Humidifier.Greengrass
{
    using global::System.Collections.Generic;
    using SubscriptionDefinitionTypes;

    public class SubscriptionDefinition : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveGreengrassSubscriptionDefinitionTypesSubscriptionDefinitionVersionInitialVersion, IHaveTags_Json, IHaveName
    {
        public class Attributes
        {
            public static string LatestVersionArn =  "LatestVersionArn" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.Greengrass.SubscriptionDefinition; }
        /// <summary>
        /// InitialVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-subscriptiondefinition.html#cfn-greengrass-subscriptiondefinition-initialversion
        /// Required: False
        /// UpdateType: Immutable
        /// Type: SubscriptionDefinitionVersion
        /// </summary>
        public Union<Humidifier.Greengrass.SubscriptionDefinitionTypes.SubscriptionDefinitionVersion, BaseFunction>? InitialVersion { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-subscriptiondefinition.html#cfn-greengrass-subscriptiondefinition-tags
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace SubscriptionDefinitionTypes
    {
        public class Subscription : Humidifier.Base.BaseSubResource, IHaveTarget, IHaveId, IHaveSource, IHaveSubject
        {
            /// <summary>
            /// Target
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-subscriptiondefinition-subscription.html#cfn-greengrass-subscriptiondefinition-subscription-target
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Target { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-subscriptiondefinition-subscription.html#cfn-greengrass-subscriptiondefinition-subscription-id
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-subscriptiondefinition-subscription.html#cfn-greengrass-subscriptiondefinition-subscription-source
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Source { get; set; }
            /// <summary>
            /// Subject
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-subscriptiondefinition-subscription.html#cfn-greengrass-subscriptiondefinition-subscription-subject
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Subject { get; set; }
        }

        public class SubscriptionDefinitionVersion : Humidifier.Base.BaseSubResource, IHaveListOfGreengrassSubscriptionDefinitionTypesSubscriptionSubscriptions
        {
            /// <summary>
            /// Subscriptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-subscriptiondefinition-subscriptiondefinitionversion.html#cfn-greengrass-subscriptiondefinition-subscriptiondefinitionversion-subscriptions
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Subscription
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Greengrass.SubscriptionDefinitionTypes.Subscription>, IReadOnlyList<Union<Humidifier.Greengrass.SubscriptionDefinitionTypes.Subscription, BaseFunction>>, BaseFunction>? Subscriptions { get; set; }
        }
    }
}