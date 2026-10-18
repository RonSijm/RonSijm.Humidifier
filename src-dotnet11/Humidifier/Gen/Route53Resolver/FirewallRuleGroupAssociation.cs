namespace Humidifier.Route53Resolver
{
    using global::System.Collections.Generic;

    public class FirewallRuleGroupAssociation : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveVpcId, IHaveFirewallRuleGroupId, IHavePriority_Integer, IHaveMutationProtection, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CreationTime =  "CreationTime" ;
            public static string ManagedOwnerName =  "ManagedOwnerName" ;
            public static string ModificationTime =  "ModificationTime" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string CreatorRequestId =  "CreatorRequestId" ;
            public static string StatusMessage =  "StatusMessage" ;
        }

        public override string AWSTypeName { get => AWS.Route53Resolver.FirewallRuleGroupAssociation; }

        /// <summary>
        /// VpcId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-firewallrulegroupassociation.html#cfn-route53resolver-firewallrulegroupassociation-vpcid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? VpcId { get; set; }

        /// <summary>
        /// FirewallRuleGroupId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-firewallrulegroupassociation.html#cfn-route53resolver-firewallrulegroupassociation-firewallrulegroupid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? FirewallRuleGroupId { get; set; }

        /// <summary>
        /// Priority
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-firewallrulegroupassociation.html#cfn-route53resolver-firewallrulegroupassociation-priority
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? Priority { get; set; }
        /// <summary>
        /// MutationProtection
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-firewallrulegroupassociation.html#cfn-route53resolver-firewallrulegroupassociation-mutationprotection
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? MutationProtection { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-firewallrulegroupassociation.html#cfn-route53resolver-firewallrulegroupassociation-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }
}