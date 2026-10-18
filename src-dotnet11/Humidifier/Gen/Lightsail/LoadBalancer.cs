namespace Humidifier.Lightsail
{
    using global::System.Collections.Generic;

    public class LoadBalancer : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveIpAddressType, IHaveSessionStickinessLBCookieDurationSeconds, IHaveLoadBalancerName, IHaveStringListOfAttachedInstances, IHaveInstancePort_Integer, IHaveHealthCheckPath, IHaveSessionStickinessEnabled_Boolean, IHaveTlsPolicyName
    {
        public class Attributes
        {
            public static string LoadBalancerArn =  "LoadBalancerArn" ;
        }

        public override string AWSTypeName { get => AWS.Lightsail.LoadBalancer; }
        /// <summary>
        /// IpAddressType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-loadbalancer.html#cfn-lightsail-loadbalancer-ipaddresstype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? IpAddressType { get; set; }
        /// <summary>
        /// SessionStickinessLBCookieDurationSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-loadbalancer.html#cfn-lightsail-loadbalancer-sessionstickinesslbcookiedurationseconds
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SessionStickinessLBCookieDurationSeconds { get; set; }
        public Union<string, BaseFunction>? LoadBalancerName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// AttachedInstances
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-loadbalancer.html#cfn-lightsail-loadbalancer-attachedinstances
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AttachedInstances { get; set; }

        /// <summary>
        /// InstancePort
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-loadbalancer.html#cfn-lightsail-loadbalancer-instanceport
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? InstancePort { get; set; }
        /// <summary>
        /// HealthCheckPath
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-loadbalancer.html#cfn-lightsail-loadbalancer-healthcheckpath
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? HealthCheckPath { get; set; }
        /// <summary>
        /// SessionStickinessEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-loadbalancer.html#cfn-lightsail-loadbalancer-sessionstickinessenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? SessionStickinessEnabled { get; set; }
        /// <summary>
        /// TlsPolicyName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-loadbalancer.html#cfn-lightsail-loadbalancer-tlspolicyname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TlsPolicyName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-loadbalancer.html#cfn-lightsail-loadbalancer-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}