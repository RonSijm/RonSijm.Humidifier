namespace Humidifier.NetworkSecurityManager
{
    using global::System.Collections.Generic;

    public class Rule : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveRuleDescription, IHaveConfiguration, IHaveFirewallType, IHaveRuleType, IHaveRuleName, IHaveDescription
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string Version =  "Version" ;
            public static string RuleId =  "RuleId" ;
            public static string RuleArn =  "RuleArn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.NetworkSecurityManager.Rule; }
        /// <summary>
        /// RuleDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networksecuritymanager-rule.html#cfn-networksecuritymanager-rule-ruledescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RuleDescription { get; set; }

        [Ignore]
        public Union<string, BaseFunction>? Description { get => RuleDescription; set => RuleDescription = value; }
        /// <summary>
        /// Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networksecuritymanager-rule.html#cfn-networksecuritymanager-rule-configuration
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Configuration { get; set; }
        /// <summary>
        /// FirewallType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networksecuritymanager-rule.html#cfn-networksecuritymanager-rule-firewalltype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? FirewallType { get; set; }
        /// <summary>
        /// RuleType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networksecuritymanager-rule.html#cfn-networksecuritymanager-rule-ruletype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RuleType { get; set; }
        public Union<string, BaseFunction>? RuleName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networksecuritymanager-rule.html#cfn-networksecuritymanager-rule-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}