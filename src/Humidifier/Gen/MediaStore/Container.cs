namespace Humidifier.MediaStore
{
    using System.Collections.Generic;
    using ContainerTypes;

    public class Container : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHavePolicy, IHaveContainerName, IHaveLifecyclePolicy
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
        public dynamic Policy { get; set; }
        /// <summary>
        /// MetricPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediastore-container.html#cfn-mediastore-container-metricpolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MetricPolicy
        /// </summary>
        public Humidifier.MediaStore.ContainerTypes.MetricPolicy MetricPolicy { get; set; }
        public dynamic ContainerName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// CorsPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediastore-container.html#cfn-mediastore-container-corspolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: CorsRule
        /// </summary>
        public List<Humidifier.MediaStore.ContainerTypes.CorsRule> CorsPolicy { get; set; }
        /// <summary>
        /// LifecyclePolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediastore-container.html#cfn-mediastore-container-lifecyclepolicy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic LifecyclePolicy { get; set; }
        /// <summary>
        /// AccessLoggingEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediastore-container.html#cfn-mediastore-container-accessloggingenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic AccessLoggingEnabled { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediastore-container.html#cfn-mediastore-container-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace ContainerTypes
    {
        public class CorsRule : Humidifier.Base.BaseSubResource, IHaveAllowedMethods, IHaveAllowedOrigins, IHaveExposeHeaders, IHaveAllowedHeaders
        {
            /// <summary>
            /// AllowedMethods
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediastore-container-corsrule.html#cfn-mediastore-container-corsrule-allowedmethods
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AllowedMethods { get; set; }
            /// <summary>
            /// AllowedOrigins
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediastore-container-corsrule.html#cfn-mediastore-container-corsrule-allowedorigins
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AllowedOrigins { get; set; }
            /// <summary>
            /// ExposeHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediastore-container-corsrule.html#cfn-mediastore-container-corsrule-exposeheaders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ExposeHeaders { get; set; }
            /// <summary>
            /// MaxAgeSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediastore-container-corsrule.html#cfn-mediastore-container-corsrule-maxageseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxAgeSeconds { get; set; }
            /// <summary>
            /// AllowedHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediastore-container-corsrule.html#cfn-mediastore-container-corsrule-allowedheaders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AllowedHeaders { get; set; }
        }

        public class MetricPolicy : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ContainerLevelMetrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediastore-container-metricpolicy.html#cfn-mediastore-container-metricpolicy-containerlevelmetrics
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContainerLevelMetrics { get; set; }
            /// <summary>
            /// MetricPolicyRules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediastore-container-metricpolicy.html#cfn-mediastore-container-metricpolicy-metricpolicyrules
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MetricPolicyRule
            /// </summary>
            public List<Humidifier.MediaStore.ContainerTypes.MetricPolicyRule> MetricPolicyRules { get; set; }
        }

        public class MetricPolicyRule : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ObjectGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediastore-container-metricpolicyrule.html#cfn-mediastore-container-metricpolicyrule-objectgroup
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ObjectGroup { get; set; }
            /// <summary>
            /// ObjectGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediastore-container-metricpolicyrule.html#cfn-mediastore-container-metricpolicyrule-objectgroupname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ObjectGroupName { get; set; }
        }
    }
}