namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using VPCEndpointTypes;

    public class VPCEndpoint : Humidifier.Base.BaseResource, IHaveTags, IHavePrivateDnsEnabled_Boolean, IHaveIpAddressType, IHaveServiceRegion, IHaveEC2VPCEndpointTypesDnsOptionsSpecificationDnsOptions, IHaveResourceConfigurationArn, IHaveStringListOfSecurityGroupIds, IHaveStringListOfSubnetIds, IHaveServiceNetworkArn, IHaveVpcId, IHaveStringListOfRouteTableIds, IHaveServiceName, IHavePolicyDocument_Json, IHaveVpcEndpointType
    {
        public class Attributes
        {
            public static string CreationTimestamp =  "CreationTimestamp" ;
            public static string NetworkInterfaceIds =  "NetworkInterfaceIds" ;
            public static string DnsEntries =  "DnsEntries" ;
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.EC2.VPCEndpoint; }
        /// <summary>
        /// PrivateDnsEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcendpoint.html#cfn-ec2-vpcendpoint-privatednsenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? PrivateDnsEnabled { get; set; }
        /// <summary>
        /// IpAddressType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcendpoint.html#cfn-ec2-vpcendpoint-ipaddresstype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? IpAddressType { get; set; }
        /// <summary>
        /// ServiceRegion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcendpoint.html#cfn-ec2-vpcendpoint-serviceregion
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ServiceRegion { get; set; }
        /// <summary>
        /// DnsOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcendpoint.html#cfn-ec2-vpcendpoint-dnsoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DnsOptionsSpecification
        /// </summary>
        public Union<Humidifier.EC2.VPCEndpointTypes.DnsOptionsSpecification, BaseFunction>? DnsOptions { get; set; }
        /// <summary>
        /// ResourceConfigurationArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcendpoint.html#cfn-ec2-vpcendpoint-resourceconfigurationarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ResourceConfigurationArn { get; set; }
        /// <summary>
        /// SecurityGroupIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcendpoint.html#cfn-ec2-vpcendpoint-securitygroupids
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        /// <summary>
        /// SubnetIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcendpoint.html#cfn-ec2-vpcendpoint-subnetids
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
        /// <summary>
        /// ServiceNetworkArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcendpoint.html#cfn-ec2-vpcendpoint-servicenetworkarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ServiceNetworkArn { get; set; }

        /// <summary>
        /// VpcId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcendpoint.html#cfn-ec2-vpcendpoint-vpcid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? VpcId { get; set; }
        /// <summary>
        /// RouteTableIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcendpoint.html#cfn-ec2-vpcendpoint-routetableids
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? RouteTableIds { get; set; }
        /// <summary>
        /// ServiceName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcendpoint.html#cfn-ec2-vpcendpoint-servicename
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ServiceName { get; set; }
        /// <summary>
        /// PolicyDocument
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcendpoint.html#cfn-ec2-vpcendpoint-policydocument
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? PolicyDocument { get; set; }
        /// <summary>
        /// VpcEndpointType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcendpoint.html#cfn-ec2-vpcendpoint-vpcendpointtype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VpcEndpointType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcendpoint.html#cfn-ec2-vpcendpoint-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace VPCEndpointTypes
    {
        public class DnsOptionsSpecification : Humidifier.Base.BaseSubResource, IHavePrivateDnsOnlyForInboundResolverEndpoint, IHaveStringListOfPrivateDnsSpecifiedDomains, IHaveDnsRecordIpType, IHavePrivateDnsPreference
        {
            /// <summary>
            /// PrivateDnsOnlyForInboundResolverEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpcendpoint-dnsoptionsspecification.html#cfn-ec2-vpcendpoint-dnsoptionsspecification-privatednsonlyforinboundresolverendpoint
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrivateDnsOnlyForInboundResolverEndpoint { get; set; }
            /// <summary>
            /// PrivateDnsSpecifiedDomains
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpcendpoint-dnsoptionsspecification.html#cfn-ec2-vpcendpoint-dnsoptionsspecification-privatednsspecifieddomains
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? PrivateDnsSpecifiedDomains { get; set; }
            /// <summary>
            /// DnsRecordIpType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpcendpoint-dnsoptionsspecification.html#cfn-ec2-vpcendpoint-dnsoptionsspecification-dnsrecordiptype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DnsRecordIpType { get; set; }
            /// <summary>
            /// PrivateDnsPreference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpcendpoint-dnsoptionsspecification.html#cfn-ec2-vpcendpoint-dnsoptionsspecification-privatednspreference
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrivateDnsPreference { get; set; }
        }
    }
}