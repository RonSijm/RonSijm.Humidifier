namespace Humidifier.NetworkFirewall
{
    using System.Collections.Generic;
    using FirewallPolicyTypes;

    public class FirewallPolicy : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription
    {
        public class Attributes
        {
            public static string FirewallPolicyArn =  "FirewallPolicyArn" ;
            public static string FirewallPolicyId =  "FirewallPolicyId" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::NetworkFirewall::FirewallPolicy";
            }
        }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-firewallpolicy.html#cfn-networkfirewall-firewallpolicy-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        public dynamic FirewallPolicyName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-firewallpolicy.html#cfn-networkfirewall-firewallpolicy-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// FirewallPolicy_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-firewallpolicy.html#cfn-networkfirewall-firewallpolicy-firewallpolicy
        /// Required: True
        /// UpdateType: Mutable
        /// Type: FirewallPolicy
        /// </summary>
        [Required]
        public FirewallPolicyTypes.FirewallPolicy FirewallPolicy_ { get; set; }
    }

    namespace FirewallPolicyTypes
    {
        public class ActionDefinition : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PublishMetricAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-actiondefinition.html#cfn-networkfirewall-firewallpolicy-actiondefinition-publishmetricaction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PublishMetricAction
            /// </summary>
            public FirewallPolicyTypes.PublishMetricAction PublishMetricAction { get; set; }
        }

        public class CustomAction : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ActionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-customaction.html#cfn-networkfirewall-firewallpolicy-customaction-actionname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ActionName { get; set; }
            /// <summary>
            /// ActionDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-customaction.html#cfn-networkfirewall-firewallpolicy-customaction-actiondefinition
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ActionDefinition
            /// </summary>
            public FirewallPolicyTypes.ActionDefinition ActionDefinition { get; set; }
        }

        public class Dimension : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-dimension.html#cfn-networkfirewall-firewallpolicy-dimension-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
        }

        public class FirewallPolicy : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StatelessRuleGroupReferences
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-firewallpolicy.html#cfn-networkfirewall-firewallpolicy-firewallpolicy-statelessrulegroupreferences
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StatelessRuleGroupReference
            /// </summary>
            public List<FirewallPolicyTypes.StatelessRuleGroupReference> StatelessRuleGroupReferences { get; set; }
            /// <summary>
            /// StatefulRuleGroupReferences
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-firewallpolicy.html#cfn-networkfirewall-firewallpolicy-firewallpolicy-statefulrulegroupreferences
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StatefulRuleGroupReference
            /// </summary>
            public List<FirewallPolicyTypes.StatefulRuleGroupReference> StatefulRuleGroupReferences { get; set; }
            /// <summary>
            /// StatelessDefaultActions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-firewallpolicy.html#cfn-networkfirewall-firewallpolicy-firewallpolicy-statelessdefaultactions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic StatelessDefaultActions { get; set; }
            /// <summary>
            /// StatefulEngineOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-firewallpolicy.html#cfn-networkfirewall-firewallpolicy-firewallpolicy-statefulengineoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StatefulEngineOptions
            /// </summary>
            public FirewallPolicyTypes.StatefulEngineOptions StatefulEngineOptions { get; set; }
            /// <summary>
            /// StatelessCustomActions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-firewallpolicy.html#cfn-networkfirewall-firewallpolicy-firewallpolicy-statelesscustomactions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomAction
            /// </summary>
            public List<FirewallPolicyTypes.CustomAction> StatelessCustomActions { get; set; }
            /// <summary>
            /// StatelessFragmentDefaultActions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-firewallpolicy.html#cfn-networkfirewall-firewallpolicy-firewallpolicy-statelessfragmentdefaultactions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic StatelessFragmentDefaultActions { get; set; }
            /// <summary>
            /// PolicyVariables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-firewallpolicy.html#cfn-networkfirewall-firewallpolicy-firewallpolicy-policyvariables
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PolicyVariables
            /// </summary>
            public FirewallPolicyTypes.PolicyVariables PolicyVariables { get; set; }
            /// <summary>
            /// StatefulDefaultActions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-firewallpolicy.html#cfn-networkfirewall-firewallpolicy-firewallpolicy-statefuldefaultactions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic StatefulDefaultActions { get; set; }
            /// <summary>
            /// TLSInspectionConfigurationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-firewallpolicy.html#cfn-networkfirewall-firewallpolicy-firewallpolicy-tlsinspectionconfigurationarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TLSInspectionConfigurationArn { get; set; }
        }

        public class IPSet : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Definition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-ipset.html#cfn-networkfirewall-firewallpolicy-ipset-definition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Definition { get; set; }
        }

        public class PolicyVariables : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RuleVariables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-policyvariables.html#cfn-networkfirewall-firewallpolicy-policyvariables-rulevariables
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: IPSet
            /// </summary>
            public Dictionary<string, FirewallPolicyTypes.IPSet> RuleVariables { get; set; }
        }

        public class PublishMetricAction : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Dimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-publishmetricaction.html#cfn-networkfirewall-firewallpolicy-publishmetricaction-dimensions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Dimension
            /// </summary>
            public List<FirewallPolicyTypes.Dimension> Dimensions { get; set; }
        }

        public class StatefulEngineOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StreamExceptionPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-statefulengineoptions.html#cfn-networkfirewall-firewallpolicy-statefulengineoptions-streamexceptionpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StreamExceptionPolicy { get; set; }
            /// <summary>
            /// RuleOrder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-statefulengineoptions.html#cfn-networkfirewall-firewallpolicy-statefulengineoptions-ruleorder
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RuleOrder { get; set; }
        }

        public class StatefulRuleGroupOverride : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-statefulrulegroupoverride.html#cfn-networkfirewall-firewallpolicy-statefulrulegroupoverride-action
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Action { get; set; }
        }

        public class StatefulRuleGroupReference : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ResourceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-statefulrulegroupreference.html#cfn-networkfirewall-firewallpolicy-statefulrulegroupreference-resourcearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResourceArn { get; set; }
            /// <summary>
            /// Priority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-statefulrulegroupreference.html#cfn-networkfirewall-firewallpolicy-statefulrulegroupreference-priority
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Priority { get; set; }
            /// <summary>
            /// Override
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-statefulrulegroupreference.html#cfn-networkfirewall-firewallpolicy-statefulrulegroupreference-override
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StatefulRuleGroupOverride
            /// </summary>
            public FirewallPolicyTypes.StatefulRuleGroupOverride Override { get; set; }
        }

        public class StatelessRuleGroupReference : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ResourceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-statelessrulegroupreference.html#cfn-networkfirewall-firewallpolicy-statelessrulegroupreference-resourcearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResourceArn { get; set; }
            /// <summary>
            /// Priority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-statelessrulegroupreference.html#cfn-networkfirewall-firewallpolicy-statelessrulegroupreference-priority
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Priority { get; set; }
        }
    }
}