namespace Humidifier.Route53GlobalResolver
{
    using global::System.Collections.Generic;

    public class FirewallRule : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveAction, IHaveDescription, IHavePriority_Integer, IHaveDnsAdvancedProtection, IHaveBlockOverrideTtl_Integer, IHaveBlockOverrideDnsType, IHaveName, IHaveBlockOverrideDomain, IHaveQType, IHaveFirewallDomainListId, IHaveConfidenceThreshold, IHaveDnsViewId, IHaveBlockResponse, IHaveClientToken
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string FirewallRuleId =  "FirewallRuleId" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string QueryType =  "QueryType" ;
        }

        public override string AWSTypeName { get => AWS.Route53GlobalResolver.FirewallRule; }

        /// <summary>
        /// Action
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53globalresolver-firewallrule.html#cfn-route53globalresolver-firewallrule-action
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Action { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53globalresolver-firewallrule.html#cfn-route53globalresolver-firewallrule-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// Priority
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53globalresolver-firewallrule.html#cfn-route53globalresolver-firewallrule-priority
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? Priority { get; set; }
        /// <summary>
        /// DnsAdvancedProtection
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53globalresolver-firewallrule.html#cfn-route53globalresolver-firewallrule-dnsadvancedprotection
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DnsAdvancedProtection { get; set; }
        /// <summary>
        /// BlockOverrideTtl
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53globalresolver-firewallrule.html#cfn-route53globalresolver-firewallrule-blockoverridettl
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? BlockOverrideTtl { get; set; }
        /// <summary>
        /// BlockOverrideDnsType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53globalresolver-firewallrule.html#cfn-route53globalresolver-firewallrule-blockoverridednstype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? BlockOverrideDnsType { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// BlockOverrideDomain
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53globalresolver-firewallrule.html#cfn-route53globalresolver-firewallrule-blockoverridedomain
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? BlockOverrideDomain { get; set; }
        /// <summary>
        /// QType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53globalresolver-firewallrule.html#cfn-route53globalresolver-firewallrule-qtype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? QType { get; set; }
        /// <summary>
        /// FirewallDomainListId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53globalresolver-firewallrule.html#cfn-route53globalresolver-firewallrule-firewalldomainlistid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? FirewallDomainListId { get; set; }
        /// <summary>
        /// ConfidenceThreshold
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53globalresolver-firewallrule.html#cfn-route53globalresolver-firewallrule-confidencethreshold
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ConfidenceThreshold { get; set; }

        /// <summary>
        /// DnsViewId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53globalresolver-firewallrule.html#cfn-route53globalresolver-firewallrule-dnsviewid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DnsViewId { get; set; }
        /// <summary>
        /// BlockResponse
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53globalresolver-firewallrule.html#cfn-route53globalresolver-firewallrule-blockresponse
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? BlockResponse { get; set; }
        /// <summary>
        /// ClientToken
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53globalresolver-firewallrule.html#cfn-route53globalresolver-firewallrule-clienttoken
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ClientToken { get; set; }
    }
}