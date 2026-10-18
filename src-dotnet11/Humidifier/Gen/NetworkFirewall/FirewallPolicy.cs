namespace Humidifier.NetworkFirewall
{
    using global::System.Collections.Generic;
    using FirewallPolicyTypes;

    public class FirewallPolicy : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveFirewallPolicyName, IHaveNetworkFirewallFirewallPolicyTypesFirewallPolicyFirewallPolicy_
    {
        public class Attributes
        {
            public static string FirewallPolicyArn =  "FirewallPolicyArn" ;
            public static string FirewallPolicyId =  "FirewallPolicyId" ;
        }

        public override string AWSTypeName { get => AWS.NetworkFirewall.FirewallPolicy; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-firewallpolicy.html#cfn-networkfirewall-firewallpolicy-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        public Union<string, BaseFunction>? FirewallPolicyName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-firewallpolicy.html#cfn-networkfirewall-firewallpolicy-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// FirewallPolicy_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-firewallpolicy.html#cfn-networkfirewall-firewallpolicy-firewallpolicy
        /// Required: True
        /// UpdateType: Mutable
        /// Type: FirewallPolicy
        /// </summary>
        [Required]
        public Union<Humidifier.NetworkFirewall.FirewallPolicyTypes.FirewallPolicy, BaseFunction>? FirewallPolicy_ { get; set; }
    }

    namespace FirewallPolicyTypes
    {
        public class ActionDefinition : Humidifier.Base.BaseSubResource, IHaveNetworkFirewallFirewallPolicyTypesPublishMetricActionPublishMetricAction
        {
            /// <summary>
            /// PublishMetricAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-actiondefinition.html#cfn-networkfirewall-firewallpolicy-actiondefinition-publishmetricaction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PublishMetricAction
            /// </summary>
            public Union<Humidifier.NetworkFirewall.FirewallPolicyTypes.PublishMetricAction, BaseFunction>? PublishMetricAction { get; set; }
        }

        public class CustomAction : Humidifier.Base.BaseSubResource, IHaveActionName, IHaveNetworkFirewallFirewallPolicyTypesActionDefinitionActionDefinition
        {
            /// <summary>
            /// ActionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-customaction.html#cfn-networkfirewall-firewallpolicy-customaction-actionname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ActionName { get; set; }
            /// <summary>
            /// ActionDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-customaction.html#cfn-networkfirewall-firewallpolicy-customaction-actiondefinition
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ActionDefinition
            /// </summary>
            public Union<Humidifier.NetworkFirewall.FirewallPolicyTypes.ActionDefinition, BaseFunction>? ActionDefinition { get; set; }
        }

        public class Dimension : Humidifier.Base.BaseSubResource, IHaveValue
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-dimension.html#cfn-networkfirewall-firewallpolicy-dimension-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
        }

        public class FirewallPolicy : Humidifier.Base.BaseSubResource, IHaveListOfNetworkFirewallFirewallPolicyTypesStatelessRuleGroupReferenceStatelessRuleGroupReferences, IHaveListOfNetworkFirewallFirewallPolicyTypesStatefulRuleGroupReferenceStatefulRuleGroupReferences, IHaveEnableTLSSessionHolding_Boolean, IHaveStringListOfStatelessDefaultActions, IHaveNetworkFirewallFirewallPolicyTypesStatefulEngineOptionsStatefulEngineOptions, IHaveListOfNetworkFirewallFirewallPolicyTypesCustomActionStatelessCustomActions, IHaveStringListOfStatelessFragmentDefaultActions, IHaveNetworkFirewallFirewallPolicyTypesPolicyVariablesPolicyVariables, IHaveStringListOfStatefulDefaultActions, IHaveTLSInspectionConfigurationArn
        {
            /// <summary>
            /// StatelessRuleGroupReferences
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-firewallpolicy.html#cfn-networkfirewall-firewallpolicy-firewallpolicy-statelessrulegroupreferences
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StatelessRuleGroupReference
            /// </summary>
            public Union<IReadOnlyList<Humidifier.NetworkFirewall.FirewallPolicyTypes.StatelessRuleGroupReference>, IReadOnlyList<Union<Humidifier.NetworkFirewall.FirewallPolicyTypes.StatelessRuleGroupReference, BaseFunction>>, BaseFunction>? StatelessRuleGroupReferences { get; set; }
            /// <summary>
            /// StatefulRuleGroupReferences
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-firewallpolicy.html#cfn-networkfirewall-firewallpolicy-firewallpolicy-statefulrulegroupreferences
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StatefulRuleGroupReference
            /// </summary>
            public Union<IReadOnlyList<Humidifier.NetworkFirewall.FirewallPolicyTypes.StatefulRuleGroupReference>, IReadOnlyList<Union<Humidifier.NetworkFirewall.FirewallPolicyTypes.StatefulRuleGroupReference, BaseFunction>>, BaseFunction>? StatefulRuleGroupReferences { get; set; }
            /// <summary>
            /// EnableTLSSessionHolding
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-firewallpolicy.html#cfn-networkfirewall-firewallpolicy-firewallpolicy-enabletlssessionholding
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableTLSSessionHolding { get; set; }
            /// <summary>
            /// StatelessDefaultActions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-firewallpolicy.html#cfn-networkfirewall-firewallpolicy-firewallpolicy-statelessdefaultactions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? StatelessDefaultActions { get; set; }
            /// <summary>
            /// StatefulEngineOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-firewallpolicy.html#cfn-networkfirewall-firewallpolicy-firewallpolicy-statefulengineoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StatefulEngineOptions
            /// </summary>
            public Union<Humidifier.NetworkFirewall.FirewallPolicyTypes.StatefulEngineOptions, BaseFunction>? StatefulEngineOptions { get; set; }
            /// <summary>
            /// StatelessCustomActions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-firewallpolicy.html#cfn-networkfirewall-firewallpolicy-firewallpolicy-statelesscustomactions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomAction
            /// </summary>
            public Union<IReadOnlyList<Humidifier.NetworkFirewall.FirewallPolicyTypes.CustomAction>, IReadOnlyList<Union<Humidifier.NetworkFirewall.FirewallPolicyTypes.CustomAction, BaseFunction>>, BaseFunction>? StatelessCustomActions { get; set; }
            /// <summary>
            /// StatelessFragmentDefaultActions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-firewallpolicy.html#cfn-networkfirewall-firewallpolicy-firewallpolicy-statelessfragmentdefaultactions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? StatelessFragmentDefaultActions { get; set; }
            /// <summary>
            /// PolicyVariables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-firewallpolicy.html#cfn-networkfirewall-firewallpolicy-firewallpolicy-policyvariables
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PolicyVariables
            /// </summary>
            public Union<Humidifier.NetworkFirewall.FirewallPolicyTypes.PolicyVariables, BaseFunction>? PolicyVariables { get; set; }
            /// <summary>
            /// StatefulDefaultActions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-firewallpolicy.html#cfn-networkfirewall-firewallpolicy-firewallpolicy-statefuldefaultactions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? StatefulDefaultActions { get; set; }
            /// <summary>
            /// TLSInspectionConfigurationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-firewallpolicy.html#cfn-networkfirewall-firewallpolicy-firewallpolicy-tlsinspectionconfigurationarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TLSInspectionConfigurationArn { get; set; }
        }

        public class FlowTimeouts : Humidifier.Base.BaseSubResource, IHaveTcpIdleTimeoutSeconds_Integer
        {
            /// <summary>
            /// TcpIdleTimeoutSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-flowtimeouts.html#cfn-networkfirewall-firewallpolicy-flowtimeouts-tcpidletimeoutseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TcpIdleTimeoutSeconds { get; set; }
        }

        public class IPSet : Humidifier.Base.BaseSubResource, IHaveStringListOfDefinition
        {
            /// <summary>
            /// Definition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-ipset.html#cfn-networkfirewall-firewallpolicy-ipset-definition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Definition { get; set; }
        }

        public class PolicyVariables : Humidifier.Base.BaseSubResource, IHaveMapOfNetworkFirewallFirewallPolicyTypesIPSetRuleVariables
        {
            /// <summary>
            /// RuleVariables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-policyvariables.html#cfn-networkfirewall-firewallpolicy-policyvariables-rulevariables
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: IPSet
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.NetworkFirewall.FirewallPolicyTypes.IPSet>, IReadOnlyDictionary<string, Union<Humidifier.NetworkFirewall.FirewallPolicyTypes.IPSet, BaseFunction>>, BaseFunction>? RuleVariables { get; set; }
        }

        public class PublishMetricAction : Humidifier.Base.BaseSubResource, IHaveListOfNetworkFirewallFirewallPolicyTypesDimensionDimensions
        {
            /// <summary>
            /// Dimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-publishmetricaction.html#cfn-networkfirewall-firewallpolicy-publishmetricaction-dimensions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Dimension
            /// </summary>
            public Union<IReadOnlyList<Humidifier.NetworkFirewall.FirewallPolicyTypes.Dimension>, IReadOnlyList<Union<Humidifier.NetworkFirewall.FirewallPolicyTypes.Dimension, BaseFunction>>, BaseFunction>? Dimensions { get; set; }
        }

        public class StatefulEngineOptions : Humidifier.Base.BaseSubResource, IHaveStreamExceptionPolicy, IHaveNetworkFirewallFirewallPolicyTypesFlowTimeoutsFlowTimeouts, IHaveRuleOrder
        {
            /// <summary>
            /// StreamExceptionPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-statefulengineoptions.html#cfn-networkfirewall-firewallpolicy-statefulengineoptions-streamexceptionpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StreamExceptionPolicy { get; set; }
            /// <summary>
            /// FlowTimeouts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-statefulengineoptions.html#cfn-networkfirewall-firewallpolicy-statefulengineoptions-flowtimeouts
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FlowTimeouts
            /// </summary>
            public Union<Humidifier.NetworkFirewall.FirewallPolicyTypes.FlowTimeouts, BaseFunction>? FlowTimeouts { get; set; }
            /// <summary>
            /// RuleOrder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-statefulengineoptions.html#cfn-networkfirewall-firewallpolicy-statefulengineoptions-ruleorder
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RuleOrder { get; set; }
        }

        public class StatefulRuleGroupOverride : Humidifier.Base.BaseSubResource, IHaveAction
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-statefulrulegroupoverride.html#cfn-networkfirewall-firewallpolicy-statefulrulegroupoverride-action
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Action { get; set; }
        }

        public class StatefulRuleGroupReference : Humidifier.Base.BaseSubResource, IHaveResourceArn, IHavePriority_Integer, IHaveNetworkFirewallFirewallPolicyTypesStatefulRuleGroupOverrideOverride, IHaveDeepThreatInspection_Boolean
        {
            /// <summary>
            /// ResourceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-statefulrulegroupreference.html#cfn-networkfirewall-firewallpolicy-statefulrulegroupreference-resourcearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceArn { get; set; }
            /// <summary>
            /// Priority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-statefulrulegroupreference.html#cfn-networkfirewall-firewallpolicy-statefulrulegroupreference-priority
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Priority { get; set; }
            /// <summary>
            /// Override
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-statefulrulegroupreference.html#cfn-networkfirewall-firewallpolicy-statefulrulegroupreference-override
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StatefulRuleGroupOverride
            /// </summary>
            public Union<Humidifier.NetworkFirewall.FirewallPolicyTypes.StatefulRuleGroupOverride, BaseFunction>? Override { get; set; }
            /// <summary>
            /// DeepThreatInspection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-statefulrulegroupreference.html#cfn-networkfirewall-firewallpolicy-statefulrulegroupreference-deepthreatinspection
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DeepThreatInspection { get; set; }
        }

        public class StatelessRuleGroupReference : Humidifier.Base.BaseSubResource, IHaveResourceArn, IHavePriority_Integer
        {
            /// <summary>
            /// ResourceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-statelessrulegroupreference.html#cfn-networkfirewall-firewallpolicy-statelessrulegroupreference-resourcearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceArn { get; set; }
            /// <summary>
            /// Priority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-firewallpolicy-statelessrulegroupreference.html#cfn-networkfirewall-firewallpolicy-statelessrulegroupreference-priority
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Priority { get; set; }
        }
    }
}