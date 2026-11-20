namespace Humidifier.Route53GlobalResolver
{
    using global::System.Collections.Generic;
    using CoreNetworkEndpointTypes;

    public class CoreNetworkEndpoint : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveListOfRoute53GlobalResolverCoreNetworkEndpointTypesIpAddressIpAddresses, IHaveGlobalResolverId, IHaveClientToken, IHaveCoreNetworkArn, IHaveName
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
        public Union<IReadOnlyList<Humidifier.Route53GlobalResolver.CoreNetworkEndpointTypes.IpAddress>, IReadOnlyList<Union<Humidifier.Route53GlobalResolver.CoreNetworkEndpointTypes.IpAddress, BaseFunction>>, BaseFunction>? IpAddresses { get; set; }

        /// <summary>
        /// GlobalResolverId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53globalresolver-corenetworkendpoint.html#cfn-route53globalresolver-corenetworkendpoint-globalresolverid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? GlobalResolverId { get; set; }
        /// <summary>
        /// ClientToken
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53globalresolver-corenetworkendpoint.html#cfn-route53globalresolver-corenetworkendpoint-clienttoken
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ClientToken { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53globalresolver-corenetworkendpoint.html#cfn-route53globalresolver-corenetworkendpoint-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// CoreNetworkArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53globalresolver-corenetworkendpoint.html#cfn-route53globalresolver-corenetworkendpoint-corenetworkarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? CoreNetworkArn { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace CoreNetworkEndpointTypes
    {
        public class IpAddress : Humidifier.Base.BaseSubResource, IHaveRegionScope, IHaveStringListOfRegions, IHaveDnsLabel, IHaveIpv6Address, IHaveIpv4Address
        {
            /// <summary>
            /// RegionScope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53globalresolver-corenetworkendpoint-ipaddress.html#cfn-route53globalresolver-corenetworkendpoint-ipaddress-regionscope
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RegionScope { get; set; }
            /// <summary>
            /// Regions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53globalresolver-corenetworkendpoint-ipaddress.html#cfn-route53globalresolver-corenetworkendpoint-ipaddress-regions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Regions { get; set; }
            /// <summary>
            /// DnsLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53globalresolver-corenetworkendpoint-ipaddress.html#cfn-route53globalresolver-corenetworkendpoint-ipaddress-dnslabel
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DnsLabel { get; set; }
            /// <summary>
            /// Ipv6Address
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53globalresolver-corenetworkendpoint-ipaddress.html#cfn-route53globalresolver-corenetworkendpoint-ipaddress-ipv6address
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Ipv6Address { get; set; }
            /// <summary>
            /// Ipv4Address
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53globalresolver-corenetworkendpoint-ipaddress.html#cfn-route53globalresolver-corenetworkendpoint-ipaddress-ipv4address
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Ipv4Address { get; set; }
        }
    }
}