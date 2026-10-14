namespace Humidifier.NetworkSecurityManager
{
    using global::System.Collections.Generic;
    using PolicyTypes;

    public class Policy : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHavePriority, IHavePolicyName, IHavePolicyDescription, IHaveDescription
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
        public dynamic PolicyDescription { get; set; }

        [Ignore]
        public dynamic Description { get => PolicyDescription; set => PolicyDescription = value; }

        /// <summary>
        /// Priority
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networksecuritymanager-policy.html#cfn-networksecuritymanager-policy-priority
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public dynamic Priority { get; set; }
        public dynamic PolicyName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// FirewallType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networksecuritymanager-policy.html#cfn-networksecuritymanager-policy-firewalltype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic FirewallType { get; set; }
        /// <summary>
        /// AssociatedTemplateAndRuleList
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networksecuritymanager-policy.html#cfn-networksecuritymanager-policy-associatedtemplateandrulelist
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AssociatedTemplateAndRule
        /// </summary>
        public List<Humidifier.NetworkSecurityManager.PolicyTypes.AssociatedTemplateAndRule> AssociatedTemplateAndRuleList { get; set; }

        /// <summary>
        /// PolicyConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networksecuritymanager-policy.html#cfn-networksecuritymanager-policy-policyconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: PolicyConfiguration
        /// </summary>
        [Required]
        public Humidifier.NetworkSecurityManager.PolicyTypes.PolicyConfiguration PolicyConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networksecuritymanager-policy.html#cfn-networksecuritymanager-policy-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace PolicyTypes
    {
        public class AssociatedTemplateAndRule : Humidifier.Base.BaseSubResource, IHaveTemplateArn
        {
            /// <summary>
            /// TemplateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networksecuritymanager-policy-associatedtemplateandrule.html#cfn-networksecuritymanager-policy-associatedtemplateandrule-templatearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TemplateArn { get; set; }
            /// <summary>
            /// RuleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networksecuritymanager-policy-associatedtemplateandrule.html#cfn-networksecuritymanager-policy-associatedtemplateandrule-rulearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RuleArn { get; set; }
        }

        public class PolicyConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ResourcesCleanUp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networksecuritymanager-policy-policyconfiguration.html#cfn-networksecuritymanager-policy-policyconfiguration-resourcescleanup
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ResourcesCleanUp { get; set; }
            /// <summary>
            /// RemediationEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networksecuritymanager-policy-policyconfiguration.html#cfn-networksecuritymanager-policy-policyconfiguration-remediationenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic RemediationEnabled { get; set; }
            /// <summary>
            /// WafConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networksecuritymanager-policy-policyconfiguration.html#cfn-networksecuritymanager-policy-policyconfiguration-wafconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WafConfig
            /// </summary>
            public Humidifier.NetworkSecurityManager.PolicyTypes.WafConfig WafConfig { get; set; }
        }

        public class WafConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ExistingCustomerWebACLResolution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networksecuritymanager-policy-wafconfig.html#cfn-networksecuritymanager-policy-wafconfig-existingcustomerwebaclresolution
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExistingCustomerWebACLResolution { get; set; }
            /// <summary>
            /// ConflictResolution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networksecuritymanager-policy-wafconfig.html#cfn-networksecuritymanager-policy-wafconfig-conflictresolution
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConflictResolution { get; set; }
        }
    }
}