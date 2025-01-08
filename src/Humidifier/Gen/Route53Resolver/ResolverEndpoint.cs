namespace Humidifier.Route53Resolver
{
    using System.Collections.Generic;
    using ResolverEndpointTypes;

    public class ResolverEndpoint : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveSecurityGroupIds, IHaveDirection, IHaveOutpostArn, IHaveProtocols, IHavePreferredInstanceType
    {
        public class Attributes
        {
            public static string ResolverEndpointId =  "ResolverEndpointId" ;
            public static string IpAddressCount =  "IpAddressCount" ;
            public static string OutpostArn =  "OutpostArn" ;
            public static string PreferredInstanceType =  "PreferredInstanceType" ;
            public static string ResolverEndpointType =  "ResolverEndpointType" ;
            public static string Arn =  "Arn" ;
            public static string Direction =  "Direction" ;
            public static string HostVPCId =  "HostVPCId" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.Route53Resolver.ResolverEndpoint; }

        /// <summary>
        /// IpAddresses
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-resolverendpoint.html#cfn-route53resolver-resolverendpoint-ipaddresses
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: IpAddressRequest
        /// </summary>
        [Required]
        public List<Humidifier.Route53Resolver.ResolverEndpointTypes.IpAddressRequest> IpAddresses { get; set; }
        /// <summary>
        /// Protocols
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-resolverendpoint.html#cfn-route53resolver-resolverendpoint-protocols
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic Protocols { get; set; }
        /// <summary>
        /// OutpostArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-resolverendpoint.html#cfn-route53resolver-resolverendpoint-outpostarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic OutpostArn { get; set; }
        /// <summary>
        /// PreferredInstanceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-resolverendpoint.html#cfn-route53resolver-resolverendpoint-preferredinstancetype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PreferredInstanceType { get; set; }
        /// <summary>
        /// ResolverEndpointType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-resolverendpoint.html#cfn-route53resolver-resolverendpoint-resolverendpointtype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ResolverEndpointType { get; set; }

        /// <summary>
        /// Direction
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-resolverendpoint.html#cfn-route53resolver-resolverendpoint-direction
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Direction { get; set; }

        /// <summary>
        /// SecurityGroupIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-resolverendpoint.html#cfn-route53resolver-resolverendpoint-securitygroupids
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public dynamic SecurityGroupIds { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-resolverendpoint.html#cfn-route53resolver-resolverendpoint-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace ResolverEndpointTypes
    {
        public class IpAddressRequest : Humidifier.Base.BaseSubResource, IHaveSubnetId, IHaveIp, IHaveIpv6
        {
            /// <summary>
            /// Ipv6
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53resolver-resolverendpoint-ipaddressrequest.html#cfn-route53resolver-resolverendpoint-ipaddressrequest-ipv6
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Ipv6 { get; set; }
            /// <summary>
            /// Ip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53resolver-resolverendpoint-ipaddressrequest.html#cfn-route53resolver-resolverendpoint-ipaddressrequest-ip
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Ip { get; set; }
            /// <summary>
            /// SubnetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53resolver-resolverendpoint-ipaddressrequest.html#cfn-route53resolver-resolverendpoint-ipaddressrequest-subnetid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SubnetId { get; set; }
        }
    }
}