namespace Humidifier.NetworkSecurityManager
{
    using global::System.Collections.Generic;
    using PolicyTypes;

    public class Policy : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHavePolicyDescription, IHavePriority_Integer, IHavePolicyName, IHaveFirewallType, IHaveListOfNetworkSecurityManagerPolicyTypesAssociatedTemplateAndRuleAssociatedTemplateAndRuleList, IHaveNetworkSecurityManagerPolicyTypesPolicyConfigurationPolicyConfiguration, IHaveDescription
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string PolicyArn =  "PolicyArn" ;
            public static string Version =  "Version" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string PolicyId =  "PolicyId" ;
        }

        public override string AWSTypeName { get => AWS.NetworkSecurityManager.Policy; }
        /// <summary>
        /// PolicyDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networksecuritymanager-policy.html#cfn-networksecuritymanager-policy-policydescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PolicyDescription { get; set; }

        [Ignore]
        public Union<string, BaseFunction>? Description { get => PolicyDescription; set => PolicyDescription = value; }

        /// <summary>
        /// Priority
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networksecuritymanager-policy.html#cfn-networksecuritymanager-policy-priority
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? Priority { get; set; }
        public Union<string, BaseFunction>? PolicyName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// FirewallType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networksecuritymanager-policy.html#cfn-networksecuritymanager-policy-firewalltype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? FirewallType { get; set; }
        /// <summary>
        /// AssociatedTemplateAndRuleList
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networksecuritymanager-policy.html#cfn-networksecuritymanager-policy-associatedtemplateandrulelist
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AssociatedTemplateAndRule
        /// </summary>
        public Union<IReadOnlyList<Humidifier.NetworkSecurityManager.PolicyTypes.AssociatedTemplateAndRule>, IReadOnlyList<Union<Humidifier.NetworkSecurityManager.PolicyTypes.AssociatedTemplateAndRule, BaseFunction>>, BaseFunction>? AssociatedTemplateAndRuleList { get; set; }

        /// <summary>
        /// PolicyConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networksecuritymanager-policy.html#cfn-networksecuritymanager-policy-policyconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: PolicyConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.NetworkSecurityManager.PolicyTypes.PolicyConfiguration, BaseFunction>? PolicyConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networksecuritymanager-policy.html#cfn-networksecuritymanager-policy-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace PolicyTypes
    {
        public class AssociatedTemplateAndRule : Humidifier.Base.BaseSubResource, IHaveTemplateArn, IHaveRuleArn
        {
            /// <summary>
            /// TemplateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networksecuritymanager-policy-associatedtemplateandrule.html#cfn-networksecuritymanager-policy-associatedtemplateandrule-templatearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TemplateArn { get; set; }
            /// <summary>
            /// RuleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networksecuritymanager-policy-associatedtemplateandrule.html#cfn-networksecuritymanager-policy-associatedtemplateandrule-rulearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RuleArn { get; set; }
        }

        public class PolicyConfiguration : Humidifier.Base.BaseSubResource, IHaveResourcesCleanUp_Boolean, IHaveRemediationEnabled_Boolean, IHaveNetworkSecurityManagerPolicyTypesWafConfigWafConfig
        {
            /// <summary>
            /// ResourcesCleanUp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networksecuritymanager-policy-policyconfiguration.html#cfn-networksecuritymanager-policy-policyconfiguration-resourcescleanup
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ResourcesCleanUp { get; set; }
            /// <summary>
            /// RemediationEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networksecuritymanager-policy-policyconfiguration.html#cfn-networksecuritymanager-policy-policyconfiguration-remediationenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? RemediationEnabled { get; set; }
            /// <summary>
            /// WafConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networksecuritymanager-policy-policyconfiguration.html#cfn-networksecuritymanager-policy-policyconfiguration-wafconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WafConfig
            /// </summary>
            public Union<Humidifier.NetworkSecurityManager.PolicyTypes.WafConfig, BaseFunction>? WafConfig { get; set; }
        }

        public class WafConfig : Humidifier.Base.BaseSubResource, IHaveExistingCustomerWebACLResolution, IHaveConflictResolution
        {
            /// <summary>
            /// ExistingCustomerWebACLResolution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networksecuritymanager-policy-wafconfig.html#cfn-networksecuritymanager-policy-wafconfig-existingcustomerwebaclresolution
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExistingCustomerWebACLResolution { get; set; }
            /// <summary>
            /// ConflictResolution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networksecuritymanager-policy-wafconfig.html#cfn-networksecuritymanager-policy-wafconfig-conflictresolution
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConflictResolution { get; set; }
        }
    }
}