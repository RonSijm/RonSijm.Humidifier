namespace Humidifier.ElasticLoadBalancingV2
{
    using global::System.Collections.Generic;
    using LoadBalancerTypes;

    public class LoadBalancer : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveIpAddressType, IHaveStringListOfSecurityGroups, IHaveListOfElasticLoadBalancingV2LoadBalancerTypesLoadBalancerAttributeLoadBalancerAttributes, IHaveScheme, IHaveName, IHaveEnableCapacityReservationProvisionStabilize_Boolean, IHaveStringListOfSubnets, IHaveType, IHaveElasticLoadBalancingV2LoadBalancerTypesMinimumLoadBalancerCapacityMinimumLoadBalancerCapacity, IHaveEnablePrefixForIpv6SourceNat, IHaveIpv4IpamPoolId, IHaveEnforceSecurityGroupInboundRulesOnPrivateLinkTraffic, IHaveListOfElasticLoadBalancingV2LoadBalancerTypesSubnetMappingSubnetMappings
    {
        public class Attributes
        {
            public static string SecurityGroups =  "SecurityGroups" ;
            public static string LoadBalancerName =  "LoadBalancerName" ;
            public static string CanonicalHostedZoneID =  "CanonicalHostedZoneID" ;
            public static string LoadBalancerArn =  "LoadBalancerArn" ;
            public static string DNSName =  "DNSName" ;
            public static string LoadBalancerFullName =  "LoadBalancerFullName" ;
        }

        public override string AWSTypeName { get => AWS.ElasticLoadBalancingV2.LoadBalancer; }
        /// <summary>
        /// IpAddressType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-loadbalancer.html#cfn-elasticloadbalancingv2-loadbalancer-ipaddresstype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? IpAddressType { get; set; }
        /// <summary>
        /// SecurityGroups
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-loadbalancer.html#cfn-elasticloadbalancingv2-loadbalancer-securitygroups
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroups { get; set; }
        /// <summary>
        /// LoadBalancerAttributes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-loadbalancer.html#cfn-elasticloadbalancingv2-loadbalancer-loadbalancerattributes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: LoadBalancerAttribute
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.LoadBalancerAttribute>, IReadOnlyList<Union<Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.LoadBalancerAttribute, BaseFunction>>, BaseFunction>? LoadBalancerAttributes { get; set; }
        /// <summary>
        /// Scheme
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-loadbalancer.html#cfn-elasticloadbalancingv2-loadbalancer-scheme
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Scheme { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// EnableCapacityReservationProvisionStabilize
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-loadbalancer.html#cfn-elasticloadbalancingv2-loadbalancer-enablecapacityreservationprovisionstabilize
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? EnableCapacityReservationProvisionStabilize { get; set; }
        /// <summary>
        /// Subnets
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-loadbalancer.html#cfn-elasticloadbalancingv2-loadbalancer-subnets
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Subnets { get; set; }
        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-loadbalancer.html#cfn-elasticloadbalancingv2-loadbalancer-type
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Type { get; set; }
        /// <summary>
        /// MinimumLoadBalancerCapacity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-loadbalancer.html#cfn-elasticloadbalancingv2-loadbalancer-minimumloadbalancercapacity
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MinimumLoadBalancerCapacity
        /// </summary>
        public Union<Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.MinimumLoadBalancerCapacity, BaseFunction>? MinimumLoadBalancerCapacity { get; set; }
        /// <summary>
        /// EnablePrefixForIpv6SourceNat
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-loadbalancer.html#cfn-elasticloadbalancingv2-loadbalancer-enableprefixforipv6sourcenat
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EnablePrefixForIpv6SourceNat { get; set; }
        /// <summary>
        /// Ipv4IpamPoolId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-loadbalancer.html#cfn-elasticloadbalancingv2-loadbalancer-ipv4ipampoolid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Ipv4IpamPoolId { get; set; }
        /// <summary>
        /// EnforceSecurityGroupInboundRulesOnPrivateLinkTraffic
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-loadbalancer.html#cfn-elasticloadbalancingv2-loadbalancer-enforcesecuritygroupinboundrulesonprivatelinktraffic
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EnforceSecurityGroupInboundRulesOnPrivateLinkTraffic { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-loadbalancer.html#cfn-elasticloadbalancingv2-loadbalancer-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// SubnetMappings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-loadbalancer.html#cfn-elasticloadbalancingv2-loadbalancer-subnetmappings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: SubnetMapping
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.SubnetMapping>, IReadOnlyList<Union<Humidifier.ElasticLoadBalancingV2.LoadBalancerTypes.SubnetMapping, BaseFunction>>, BaseFunction>? SubnetMappings { get; set; }
    }

    namespace LoadBalancerTypes
    {
        public class LoadBalancerAttribute : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-loadbalancer-loadbalancerattribute.html#cfn-elasticloadbalancingv2-loadbalancer-loadbalancerattribute-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-loadbalancer-loadbalancerattribute.html#cfn-elasticloadbalancingv2-loadbalancer-loadbalancerattribute-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class MinimumLoadBalancerCapacity : Humidifier.Base.BaseSubResource, IHaveCapacityUnits_Integer
        {
            /// <summary>
            /// CapacityUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-loadbalancer-minimumloadbalancercapacity.html#cfn-elasticloadbalancingv2-loadbalancer-minimumloadbalancercapacity-capacityunits
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? CapacityUnits { get; set; }
        }

        public class SubnetMapping : Humidifier.Base.BaseSubResource, IHaveAllocationId, IHaveIPv6Address, IHaveSubnetId, IHaveSourceNatIpv6Prefix, IHavePrivateIPv4Address
        {
            /// <summary>
            /// AllocationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-loadbalancer-subnetmapping.html#cfn-elasticloadbalancingv2-loadbalancer-subnetmapping-allocationid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AllocationId { get; set; }
            /// <summary>
            /// IPv6Address
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-loadbalancer-subnetmapping.html#cfn-elasticloadbalancingv2-loadbalancer-subnetmapping-ipv6address
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IPv6Address { get; set; }
            /// <summary>
            /// SubnetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-loadbalancer-subnetmapping.html#cfn-elasticloadbalancingv2-loadbalancer-subnetmapping-subnetid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SubnetId { get; set; }
            /// <summary>
            /// SourceNatIpv6Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-loadbalancer-subnetmapping.html#cfn-elasticloadbalancingv2-loadbalancer-subnetmapping-sourcenatipv6prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceNatIpv6Prefix { get; set; }
            /// <summary>
            /// PrivateIPv4Address
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-loadbalancer-subnetmapping.html#cfn-elasticloadbalancingv2-loadbalancer-subnetmapping-privateipv4address
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrivateIPv4Address { get; set; }
        }
    }
}