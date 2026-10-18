namespace Humidifier.Route53GlobalResolver
{
    using global::System.Collections.Generic;

    public class AccessSource : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveIpAddressType, IHaveCidr, IHaveDnsViewId, IHaveProtocol, IHaveClientToken, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string AccessSourceId =  "AccessSourceId" ;
            public static string Arn =  "Arn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.Route53GlobalResolver.AccessSource; }
        /// <summary>
        /// IpAddressType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53globalresolver-accesssource.html#cfn-route53globalresolver-accesssource-ipaddresstype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? IpAddressType { get; set; }

        /// <summary>
        /// Cidr
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53globalresolver-accesssource.html#cfn-route53globalresolver-accesssource-cidr
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Cidr { get; set; }

        /// <summary>
        /// DnsViewId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53globalresolver-accesssource.html#cfn-route53globalresolver-accesssource-dnsviewid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DnsViewId { get; set; }

        /// <summary>
        /// Protocol
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53globalresolver-accesssource.html#cfn-route53globalresolver-accesssource-protocol
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Protocol { get; set; }
        /// <summary>
        /// ClientToken
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53globalresolver-accesssource.html#cfn-route53globalresolver-accesssource-clienttoken
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ClientToken { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53globalresolver-accesssource.html#cfn-route53globalresolver-accesssource-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }
}