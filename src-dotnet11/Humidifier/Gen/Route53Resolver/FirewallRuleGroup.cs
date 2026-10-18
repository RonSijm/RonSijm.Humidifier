namespace Humidifier.Route53Resolver
{
    using global::System.Collections.Generic;
    using FirewallRuleGroupTypes;

    public class FirewallRuleGroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveListOfRoute53ResolverFirewallRuleGroupTypesFirewallRuleFirewallRules, IHaveName
    {
        public class Attributes
        {
            public static string RuleCount =  "RuleCount" ;
            public static string Status =  "Status" ;
            public static string OwnerId =  "OwnerId" ;
            public static string CreationTime =  "CreationTime" ;
            public static string ShareStatus =  "ShareStatus" ;
            public static string ModificationTime =  "ModificationTime" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string CreatorRequestId =  "CreatorRequestId" ;
            public static string StatusMessage =  "StatusMessage" ;
        }

        public override string AWSTypeName { get => AWS.Route53Resolver.FirewallRuleGroup; }
        /// <summary>
        /// FirewallRules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-firewallrulegroup.html#cfn-route53resolver-firewallrulegroup-firewallrules
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: FirewallRule
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallRule>, IReadOnlyList<Union<Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallRule, BaseFunction>>, BaseFunction>? FirewallRules { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-firewallrulegroup.html#cfn-route53resolver-firewallrulegroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace FirewallRuleGroupTypes
    {
        public class FirewallAdvancedContentCategoryConfig : Humidifier.Base.BaseSubResource, IHaveCategory
        {
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53resolver-firewallrulegroup-firewalladvancedcontentcategoryconfig.html#cfn-route53resolver-firewallrulegroup-firewalladvancedcontentcategoryconfig-category
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Category { get; set; }
        }

        public class FirewallAdvancedThreatCategoryConfig : Humidifier.Base.BaseSubResource, IHaveCategory
        {
            /// <summary>
            /// Category
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53resolver-firewallrulegroup-firewalladvancedthreatcategoryconfig.html#cfn-route53resolver-firewallrulegroup-firewalladvancedthreatcategoryconfig-category
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Category { get; set; }
        }

        public class FirewallRule : Humidifier.Base.BaseSubResource, IHaveQtype, IHaveStatus, IHaveAction, IHavePriority_Integer, IHaveBlockOverrideTtl_Integer, IHaveBlockOverrideDnsType, IHaveBlockOverrideDomain, IHaveDnsThreatProtection, IHaveFirewallDomainListId, IHaveFirewallThreatProtectionId, IHaveConfidenceThreshold, IHaveBlockResponse, IHaveRoute53ResolverFirewallRuleGroupTypesFirewallRuleTypeFirewallRuleType, IHaveFirewallDomainRedirectionAction
        {
            /// <summary>
            /// Qtype
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53resolver-firewallrulegroup-firewallrule.html#cfn-route53resolver-firewallrulegroup-firewallrule-qtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Qtype { get; set; }
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53resolver-firewallrulegroup-firewallrule.html#cfn-route53resolver-firewallrulegroup-firewallrule-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53resolver-firewallrulegroup-firewallrule.html#cfn-route53resolver-firewallrulegroup-firewallrule-action
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Action { get; set; }
            /// <summary>
            /// Priority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53resolver-firewallrulegroup-firewallrule.html#cfn-route53resolver-firewallrulegroup-firewallrule-priority
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Priority { get; set; }
            /// <summary>
            /// BlockOverrideTtl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53resolver-firewallrulegroup-firewallrule.html#cfn-route53resolver-firewallrulegroup-firewallrule-blockoverridettl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? BlockOverrideTtl { get; set; }
            /// <summary>
            /// BlockOverrideDnsType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53resolver-firewallrulegroup-firewallrule.html#cfn-route53resolver-firewallrulegroup-firewallrule-blockoverridednstype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BlockOverrideDnsType { get; set; }
            /// <summary>
            /// BlockOverrideDomain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53resolver-firewallrulegroup-firewallrule.html#cfn-route53resolver-firewallrulegroup-firewallrule-blockoverridedomain
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BlockOverrideDomain { get; set; }
            /// <summary>
            /// DnsThreatProtection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53resolver-firewallrulegroup-firewallrule.html#cfn-route53resolver-firewallrulegroup-firewallrule-dnsthreatprotection
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DnsThreatProtection { get; set; }
            /// <summary>
            /// FirewallDomainListId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53resolver-firewallrulegroup-firewallrule.html#cfn-route53resolver-firewallrulegroup-firewallrule-firewalldomainlistid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FirewallDomainListId { get; set; }
            /// <summary>
            /// FirewallThreatProtectionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53resolver-firewallrulegroup-firewallrule.html#cfn-route53resolver-firewallrulegroup-firewallrule-firewallthreatprotectionid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FirewallThreatProtectionId { get; set; }
            /// <summary>
            /// ConfidenceThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53resolver-firewallrulegroup-firewallrule.html#cfn-route53resolver-firewallrulegroup-firewallrule-confidencethreshold
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConfidenceThreshold { get; set; }
            /// <summary>
            /// BlockResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53resolver-firewallrulegroup-firewallrule.html#cfn-route53resolver-firewallrulegroup-firewallrule-blockresponse
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BlockResponse { get; set; }
            /// <summary>
            /// FirewallRuleType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53resolver-firewallrulegroup-firewallrule.html#cfn-route53resolver-firewallrulegroup-firewallrule-firewallruletype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FirewallRuleType
            /// </summary>
            public Union<Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallRuleType, BaseFunction>? FirewallRuleType { get; set; }
            /// <summary>
            /// FirewallDomainRedirectionAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53resolver-firewallrulegroup-firewallrule.html#cfn-route53resolver-firewallrulegroup-firewallrule-firewalldomainredirectionaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FirewallDomainRedirectionAction { get; set; }
        }

        public class FirewallRuleType : Humidifier.Base.BaseSubResource, IHaveRoute53ResolverFirewallRuleGroupTypesFirewallAdvancedThreatCategoryConfigFirewallAdvancedThreatCategory, IHaveRoute53ResolverFirewallRuleGroupTypesPartnerThreatProtectionConfigPartnerThreatProtection, IHaveRoute53ResolverFirewallRuleGroupTypesFirewallAdvancedContentCategoryConfigFirewallAdvancedContentCategory
        {
            /// <summary>
            /// FirewallAdvancedThreatCategory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53resolver-firewallrulegroup-firewallruletype.html#cfn-route53resolver-firewallrulegroup-firewallruletype-firewalladvancedthreatcategory
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FirewallAdvancedThreatCategoryConfig
            /// </summary>
            public Union<Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallAdvancedThreatCategoryConfig, BaseFunction>? FirewallAdvancedThreatCategory { get; set; }
            /// <summary>
            /// PartnerThreatProtection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53resolver-firewallrulegroup-firewallruletype.html#cfn-route53resolver-firewallrulegroup-firewallruletype-partnerthreatprotection
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PartnerThreatProtectionConfig
            /// </summary>
            public Union<Humidifier.Route53Resolver.FirewallRuleGroupTypes.PartnerThreatProtectionConfig, BaseFunction>? PartnerThreatProtection { get; set; }
            /// <summary>
            /// FirewallAdvancedContentCategory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53resolver-firewallrulegroup-firewallruletype.html#cfn-route53resolver-firewallrulegroup-firewallruletype-firewalladvancedcontentcategory
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FirewallAdvancedContentCategoryConfig
            /// </summary>
            public Union<Humidifier.Route53Resolver.FirewallRuleGroupTypes.FirewallAdvancedContentCategoryConfig, BaseFunction>? FirewallAdvancedContentCategory { get; set; }
        }

        public class PartnerThreatProtectionConfig : Humidifier.Base.BaseSubResource, IHavePartner
        {
            /// <summary>
            /// Partner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53resolver-firewallrulegroup-partnerthreatprotectionconfig.html#cfn-route53resolver-firewallrulegroup-partnerthreatprotectionconfig-partner
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Partner { get; set; }
        }
    }
}