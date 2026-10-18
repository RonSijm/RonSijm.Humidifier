namespace Humidifier.MediaStore
{
    using global::System.Collections.Generic;
    using ContainerTypes;

    public class Container : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHavePolicy, IHaveMediaStoreContainerTypesMetricPolicyMetricPolicy, IHaveContainerName, IHaveListOfMediaStoreContainerTypesCorsRuleCorsPolicy, IHaveLifecyclePolicy, IHaveAccessLoggingEnabled_Boolean
    {
        public class Attributes
        {
            public static string Endpoint =  "Endpoint" ;
        }

        public override string AWSTypeName { get => AWS.MediaStore.Container; }
        /// <summary>
        /// Policy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediastore-container.html#cfn-mediastore-container-policy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Policy { get; set; }
        /// <summary>
        /// MetricPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediastore-container.html#cfn-mediastore-container-metricpolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MetricPolicy
        /// </summary>
        public Union<Humidifier.MediaStore.ContainerTypes.MetricPolicy, BaseFunction>? MetricPolicy { get; set; }
        public Union<string, BaseFunction>? ContainerName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// CorsPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediastore-container.html#cfn-mediastore-container-corspolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: CorsRule
        /// </summary>
        public Union<IReadOnlyList<Humidifier.MediaStore.ContainerTypes.CorsRule>, IReadOnlyList<Union<Humidifier.MediaStore.ContainerTypes.CorsRule, BaseFunction>>, BaseFunction>? CorsPolicy { get; set; }
        /// <summary>
        /// LifecyclePolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediastore-container.html#cfn-mediastore-container-lifecyclepolicy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LifecyclePolicy { get; set; }
        /// <summary>
        /// AccessLoggingEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediastore-container.html#cfn-mediastore-container-accessloggingenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? AccessLoggingEnabled { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediastore-container.html#cfn-mediastore-container-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ContainerTypes
    {
        public class CorsRule : Humidifier.Base.BaseSubResource, IHaveStringListOfAllowedMethods, IHaveStringListOfAllowedOrigins, IHaveStringListOfExposeHeaders, IHaveMaxAgeSeconds_Integer, IHaveStringListOfAllowedHeaders
        {
            /// <summary>
            /// AllowedMethods
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediastore-container-corsrule.html#cfn-mediastore-container-corsrule-allowedmethods
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedMethods { get; set; }
            /// <summary>
            /// AllowedOrigins
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediastore-container-corsrule.html#cfn-mediastore-container-corsrule-allowedorigins
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedOrigins { get; set; }
            /// <summary>
            /// ExposeHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediastore-container-corsrule.html#cfn-mediastore-container-corsrule-exposeheaders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ExposeHeaders { get; set; }
            /// <summary>
            /// MaxAgeSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediastore-container-corsrule.html#cfn-mediastore-container-corsrule-maxageseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxAgeSeconds { get; set; }
            /// <summary>
            /// AllowedHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediastore-container-corsrule.html#cfn-mediastore-container-corsrule-allowedheaders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedHeaders { get; set; }
        }

        public class MetricPolicy : Humidifier.Base.BaseSubResource, IHaveContainerLevelMetrics, IHaveListOfMediaStoreContainerTypesMetricPolicyRuleMetricPolicyRules
        {
            /// <summary>
            /// ContainerLevelMetrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediastore-container-metricpolicy.html#cfn-mediastore-container-metricpolicy-containerlevelmetrics
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContainerLevelMetrics { get; set; }
            /// <summary>
            /// MetricPolicyRules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediastore-container-metricpolicy.html#cfn-mediastore-container-metricpolicy-metricpolicyrules
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MetricPolicyRule
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaStore.ContainerTypes.MetricPolicyRule>, IReadOnlyList<Union<Humidifier.MediaStore.ContainerTypes.MetricPolicyRule, BaseFunction>>, BaseFunction>? MetricPolicyRules { get; set; }
        }

        public class MetricPolicyRule : Humidifier.Base.BaseSubResource, IHaveObjectGroup, IHaveObjectGroupName
        {
            /// <summary>
            /// ObjectGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediastore-container-metricpolicyrule.html#cfn-mediastore-container-metricpolicyrule-objectgroup
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ObjectGroup { get; set; }
            /// <summary>
            /// ObjectGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediastore-container-metricpolicyrule.html#cfn-mediastore-container-metricpolicyrule-objectgroupname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ObjectGroupName { get; set; }
        }
    }
}