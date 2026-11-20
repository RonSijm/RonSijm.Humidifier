namespace Humidifier.Route53GlobalResolver
{
    using global::System.Collections.Generic;
    using CoreNetworkEndpointTypes;

    public class CoreNetworkEndpoint : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveClientToken
    {
        public class Attributes
        {
            public static string CoreNetworkEndpointId =  "CoreNetworkEndpointId" ;
            public static string Status =  "Status" ;
            public static string AvailableRegions =  "AvailableRegions" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Arn =  "Arn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.Route53GlobalResolver.CoreNetworkEndpoint; }

        /// <summary>
        /// IpAddresses
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53globalresolver-corenetworkendpoint.html#cfn-route53globalresolver-corenetworkendpoint-ipaddresses
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: IpAddress
        /// </summary>
        [Required]
        public List<Humidifier.Route53GlobalResolver.CoreNetworkEndpointTypes.IpAddress> IpAddresses { get; set; }

        /// <summary>
        /// GlobalResolverId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53globalresolver-corenetworkendpoint.html#cfn-route53globalresolver-corenetworkendpoint-globalresolverid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic GlobalResolverId { get; set; }
        /// <summary>
        /// ClientToken
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53globalresolver-corenetworkendpoint.html#cfn-route53globalresolver-corenetworkendpoint-clienttoken
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ClientToken { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53globalresolver-corenetworkendpoint.html#cfn-route53globalresolver-corenetworkendpoint-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }

        /// <summary>
        /// CoreNetworkArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53globalresolver-corenetworkendpoint.html#cfn-route53globalresolver-corenetworkendpoint-corenetworkarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic CoreNetworkArn { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace CoreNetworkEndpointTypes
    {
        public class IpAddress : Humidifier.Base.BaseSubResource, IHaveRegions, IHaveIpv6Address
        {
            /// <summary>
            /// RegionScope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53globalresolver-corenetworkendpoint-ipaddress.html#cfn-route53globalresolver-corenetworkendpoint-ipaddress-regionscope
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RegionScope { get; set; }
            /// <summary>
            /// Regions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53globalresolver-corenetworkendpoint-ipaddress.html#cfn-route53globalresolver-corenetworkendpoint-ipaddress-regions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Regions { get; set; }
            /// <summary>
            /// DnsLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53globalresolver-corenetworkendpoint-ipaddress.html#cfn-route53globalresolver-corenetworkendpoint-ipaddress-dnslabel
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DnsLabel { get; set; }
            /// <summary>
            /// Ipv6Address
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53globalresolver-corenetworkendpoint-ipaddress.html#cfn-route53globalresolver-corenetworkendpoint-ipaddress-ipv6address
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Ipv6Address { get; set; }
            /// <summary>
            /// Ipv4Address
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53globalresolver-corenetworkendpoint-ipaddress.html#cfn-route53globalresolver-corenetworkendpoint-ipaddress-ipv4address
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Ipv4Address { get; set; }
        }
    }
}