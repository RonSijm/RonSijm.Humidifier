namespace Humidifier.Route53GlobalResolver
{
    using global::System.Collections.Generic;

    public class DnsView : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveEdnsClientSubnet, IHaveFirewallRulesFailOpen, IHaveDescription, IHaveDnssecValidation, IHaveGlobalResolverId, IHaveClientToken, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string DnsViewId =  "DnsViewId" ;
            public static string Arn =  "Arn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.Route53GlobalResolver.DnsView; }
        /// <summary>
        /// EdnsClientSubnet
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53globalresolver-dnsview.html#cfn-route53globalresolver-dnsview-ednsclientsubnet
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EdnsClientSubnet { get; set; }
        /// <summary>
        /// FirewallRulesFailOpen
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53globalresolver-dnsview.html#cfn-route53globalresolver-dnsview-firewallrulesfailopen
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? FirewallRulesFailOpen { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53globalresolver-dnsview.html#cfn-route53globalresolver-dnsview-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// DnssecValidation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53globalresolver-dnsview.html#cfn-route53globalresolver-dnsview-dnssecvalidation
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DnssecValidation { get; set; }

        /// <summary>
        /// GlobalResolverId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53globalresolver-dnsview.html#cfn-route53globalresolver-dnsview-globalresolverid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? GlobalResolverId { get; set; }
        /// <summary>
        /// ClientToken
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53globalresolver-dnsview.html#cfn-route53globalresolver-dnsview-clienttoken
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ClientToken { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53globalresolver-dnsview.html#cfn-route53globalresolver-dnsview-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }
}