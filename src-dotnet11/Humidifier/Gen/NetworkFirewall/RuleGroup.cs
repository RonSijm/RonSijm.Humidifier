namespace Humidifier.NetworkFirewall
{
    using global::System.Collections.Generic;
    using RuleGroupTypes;

    public class RuleGroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveType, IHaveDescription, IHaveCapacity_Integer, IHaveRuleGroupName, IHaveNetworkFirewallRuleGroupTypesSummaryConfigurationSummaryConfiguration, IHaveNetworkFirewallRuleGroupTypesRuleGroupRuleGroup_
    {
        public class Attributes
        {
            public static string RuleGroupId =  "RuleGroupId" ;
            public static string RuleGroupArn =  "RuleGroupArn" ;
        }

        public override string AWSTypeName { get => AWS.NetworkFirewall.RuleGroup; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-rulegroup.html#cfn-networkfirewall-rulegroup-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Type { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-rulegroup.html#cfn-networkfirewall-rulegroup-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// Capacity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-rulegroup.html#cfn-networkfirewall-rulegroup-capacity
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? Capacity { get; set; }
        public Union<string, BaseFunction>? RuleGroupName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// SummaryConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-rulegroup.html#cfn-networkfirewall-rulegroup-summaryconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SummaryConfiguration
        /// </summary>
        public Union<Humidifier.NetworkFirewall.RuleGroupTypes.SummaryConfiguration, BaseFunction>? SummaryConfiguration { get; set; }
        /// <summary>
        /// RuleGroup_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-rulegroup.html#cfn-networkfirewall-rulegroup-rulegroup
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RuleGroup
        /// </summary>
        public Union<Humidifier.NetworkFirewall.RuleGroupTypes.RuleGroup, BaseFunction>? RuleGroup_ { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-rulegroup.html#cfn-networkfirewall-rulegroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace RuleGroupTypes
    {
        public class ActionDefinition : Humidifier.Base.BaseSubResource, IHaveNetworkFirewallRuleGroupTypesPublishMetricActionPublishMetricAction
        {
            /// <summary>
            /// PublishMetricAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-actiondefinition.html#cfn-networkfirewall-rulegroup-actiondefinition-publishmetricaction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PublishMetricAction
            /// </summary>
            public Union<Humidifier.NetworkFirewall.RuleGroupTypes.PublishMetricAction, BaseFunction>? PublishMetricAction { get; set; }
        }

        public class Address : Humidifier.Base.BaseSubResource, IHaveAddressDefinition
        {
            /// <summary>
            /// AddressDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-address.html#cfn-networkfirewall-rulegroup-address-addressdefinition
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AddressDefinition { get; set; }
        }

        public class CustomAction : Humidifier.Base.BaseSubResource, IHaveActionName, IHaveNetworkFirewallRuleGroupTypesActionDefinitionActionDefinition
        {
            /// <summary>
            /// ActionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-customaction.html#cfn-networkfirewall-rulegroup-customaction-actionname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ActionName { get; set; }
            /// <summary>
            /// ActionDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-customaction.html#cfn-networkfirewall-rulegroup-customaction-actiondefinition
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ActionDefinition
            /// </summary>
            public Union<Humidifier.NetworkFirewall.RuleGroupTypes.ActionDefinition, BaseFunction>? ActionDefinition { get; set; }
        }

        public class Dimension : Humidifier.Base.BaseSubResource, IHaveValue
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-dimension.html#cfn-networkfirewall-rulegroup-dimension-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
        }

        public class Header : Humidifier.Base.BaseSubResource, IHaveDestination, IHaveProtocol, IHaveSourcePort, IHaveDirection, IHaveDestinationPort, IHaveSource
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-header.html#cfn-networkfirewall-rulegroup-header-destination
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Destination { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-header.html#cfn-networkfirewall-rulegroup-header-protocol
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Protocol { get; set; }
            /// <summary>
            /// SourcePort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-header.html#cfn-networkfirewall-rulegroup-header-sourceport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourcePort { get; set; }
            /// <summary>
            /// Direction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-header.html#cfn-networkfirewall-rulegroup-header-direction
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Direction { get; set; }
            /// <summary>
            /// DestinationPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-header.html#cfn-networkfirewall-rulegroup-header-destinationport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DestinationPort { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-header.html#cfn-networkfirewall-rulegroup-header-source
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Source { get; set; }
        }

        public class IPSet : Humidifier.Base.BaseSubResource, IHaveStringListOfDefinition
        {
            /// <summary>
            /// Definition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-ipset.html#cfn-networkfirewall-rulegroup-ipset-definition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Definition { get; set; }
        }

        public class IPSetReference : Humidifier.Base.BaseSubResource, IHaveReferenceArn
        {
            /// <summary>
            /// ReferenceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-ipsetreference.html#cfn-networkfirewall-rulegroup-ipsetreference-referencearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ReferenceArn { get; set; }
        }

        public class MatchAttributes : Humidifier.Base.BaseSubResource, IHaveIntegerListOfProtocols, IHaveListOfNetworkFirewallRuleGroupTypesTCPFlagFieldTCPFlags, IHaveListOfNetworkFirewallRuleGroupTypesPortRangeDestinationPorts, IHaveListOfNetworkFirewallRuleGroupTypesAddressDestinations, IHaveListOfNetworkFirewallRuleGroupTypesAddressSources, IHaveListOfNetworkFirewallRuleGroupTypesPortRangeSourcePorts
        {
            /// <summary>
            /// Protocols
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-matchattributes.html#cfn-networkfirewall-rulegroup-matchattributes-protocols
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public Union<IReadOnlyList<int>, IReadOnlyList<Union<int, BaseFunction>>, BaseFunction>? Protocols { get; set; }
            /// <summary>
            /// TCPFlags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-matchattributes.html#cfn-networkfirewall-rulegroup-matchattributes-tcpflags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TCPFlagField
            /// </summary>
            public Union<IReadOnlyList<Humidifier.NetworkFirewall.RuleGroupTypes.TCPFlagField>, IReadOnlyList<Union<Humidifier.NetworkFirewall.RuleGroupTypes.TCPFlagField, BaseFunction>>, BaseFunction>? TCPFlags { get; set; }
            /// <summary>
            /// DestinationPorts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-matchattributes.html#cfn-networkfirewall-rulegroup-matchattributes-destinationports
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PortRange
            /// </summary>
            public Union<IReadOnlyList<Humidifier.NetworkFirewall.RuleGroupTypes.PortRange>, IReadOnlyList<Union<Humidifier.NetworkFirewall.RuleGroupTypes.PortRange, BaseFunction>>, BaseFunction>? DestinationPorts { get; set; }
            /// <summary>
            /// Destinations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-matchattributes.html#cfn-networkfirewall-rulegroup-matchattributes-destinations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Address
            /// </summary>
            public Union<IReadOnlyList<Humidifier.NetworkFirewall.RuleGroupTypes.Address>, IReadOnlyList<Union<Humidifier.NetworkFirewall.RuleGroupTypes.Address, BaseFunction>>, BaseFunction>? Destinations { get; set; }
            /// <summary>
            /// Sources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-matchattributes.html#cfn-networkfirewall-rulegroup-matchattributes-sources
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Address
            /// </summary>
            public Union<IReadOnlyList<Humidifier.NetworkFirewall.RuleGroupTypes.Address>, IReadOnlyList<Union<Humidifier.NetworkFirewall.RuleGroupTypes.Address, BaseFunction>>, BaseFunction>? Sources { get; set; }
            /// <summary>
            /// SourcePorts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-matchattributes.html#cfn-networkfirewall-rulegroup-matchattributes-sourceports
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PortRange
            /// </summary>
            public Union<IReadOnlyList<Humidifier.NetworkFirewall.RuleGroupTypes.PortRange>, IReadOnlyList<Union<Humidifier.NetworkFirewall.RuleGroupTypes.PortRange, BaseFunction>>, BaseFunction>? SourcePorts { get; set; }
        }

        public class PortRange : Humidifier.Base.BaseSubResource, IHaveToPort_Integer, IHaveFromPort_Integer
        {
            /// <summary>
            /// ToPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-portrange.html#cfn-networkfirewall-rulegroup-portrange-toport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ToPort { get; set; }
            /// <summary>
            /// FromPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-portrange.html#cfn-networkfirewall-rulegroup-portrange-fromport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FromPort { get; set; }
        }

        public class PortSet : Humidifier.Base.BaseSubResource, IHaveStringListOfDefinition
        {
            /// <summary>
            /// Definition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-portset.html#cfn-networkfirewall-rulegroup-portset-definition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Definition { get; set; }
        }

        public class PublishMetricAction : Humidifier.Base.BaseSubResource, IHaveListOfNetworkFirewallRuleGroupTypesDimensionDimensions
        {
            /// <summary>
            /// Dimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-publishmetricaction.html#cfn-networkfirewall-rulegroup-publishmetricaction-dimensions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Dimension
            /// </summary>
            public Union<IReadOnlyList<Humidifier.NetworkFirewall.RuleGroupTypes.Dimension>, IReadOnlyList<Union<Humidifier.NetworkFirewall.RuleGroupTypes.Dimension, BaseFunction>>, BaseFunction>? Dimensions { get; set; }
        }

        public class ReferenceSets : Humidifier.Base.BaseSubResource, IHaveMapOfNetworkFirewallRuleGroupTypesIPSetReferenceIPSetReferences
        {
            /// <summary>
            /// IPSetReferences
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-referencesets.html#cfn-networkfirewall-rulegroup-referencesets-ipsetreferences
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: IPSetReference
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.NetworkFirewall.RuleGroupTypes.IPSetReference>, IReadOnlyDictionary<string, Union<Humidifier.NetworkFirewall.RuleGroupTypes.IPSetReference, BaseFunction>>, BaseFunction>? IPSetReferences { get; set; }
        }

        public class RuleDefinition : Humidifier.Base.BaseSubResource, IHaveStringListOfActions, IHaveNetworkFirewallRuleGroupTypesMatchAttributesMatchAttributes
        {
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-ruledefinition.html#cfn-networkfirewall-rulegroup-ruledefinition-actions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Actions { get; set; }
            /// <summary>
            /// MatchAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-ruledefinition.html#cfn-networkfirewall-rulegroup-ruledefinition-matchattributes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MatchAttributes
            /// </summary>
            public Union<Humidifier.NetworkFirewall.RuleGroupTypes.MatchAttributes, BaseFunction>? MatchAttributes { get; set; }
        }

        public class RuleGroup : Humidifier.Base.BaseSubResource, IHaveNetworkFirewallRuleGroupTypesStatefulRuleOptionsStatefulRuleOptions, IHaveNetworkFirewallRuleGroupTypesReferenceSetsReferenceSets, IHaveNetworkFirewallRuleGroupTypesRulesSourceRulesSource, IHaveNetworkFirewallRuleGroupTypesRuleVariablesRuleVariables
        {
            /// <summary>
            /// StatefulRuleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-rulegroup.html#cfn-networkfirewall-rulegroup-rulegroup-statefulruleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StatefulRuleOptions
            /// </summary>
            public Union<Humidifier.NetworkFirewall.RuleGroupTypes.StatefulRuleOptions, BaseFunction>? StatefulRuleOptions { get; set; }
            /// <summary>
            /// ReferenceSets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-rulegroup.html#cfn-networkfirewall-rulegroup-rulegroup-referencesets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReferenceSets
            /// </summary>
            public Union<Humidifier.NetworkFirewall.RuleGroupTypes.ReferenceSets, BaseFunction>? ReferenceSets { get; set; }
            /// <summary>
            /// RulesSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-rulegroup.html#cfn-networkfirewall-rulegroup-rulegroup-rulessource
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RulesSource
            /// </summary>
            public Union<Humidifier.NetworkFirewall.RuleGroupTypes.RulesSource, BaseFunction>? RulesSource { get; set; }
            /// <summary>
            /// RuleVariables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-rulegroup.html#cfn-networkfirewall-rulegroup-rulegroup-rulevariables
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RuleVariables
            /// </summary>
            public Union<Humidifier.NetworkFirewall.RuleGroupTypes.RuleVariables, BaseFunction>? RuleVariables { get; set; }
        }

        public class RuleOption : Humidifier.Base.BaseSubResource, IHaveKeyword, IHaveStringListOfSettings
        {
            /// <summary>
            /// Keyword
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-ruleoption.html#cfn-networkfirewall-rulegroup-ruleoption-keyword
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Keyword { get; set; }
            /// <summary>
            /// Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-ruleoption.html#cfn-networkfirewall-rulegroup-ruleoption-settings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Settings { get; set; }
        }

        public class RuleVariables : Humidifier.Base.BaseSubResource, IHaveMapOfNetworkFirewallRuleGroupTypesPortSetPortSets, IHaveMapOfNetworkFirewallRuleGroupTypesIPSetIPSets
        {
            /// <summary>
            /// PortSets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-rulevariables.html#cfn-networkfirewall-rulegroup-rulevariables-portsets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: PortSet
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.NetworkFirewall.RuleGroupTypes.PortSet>, IReadOnlyDictionary<string, Union<Humidifier.NetworkFirewall.RuleGroupTypes.PortSet, BaseFunction>>, BaseFunction>? PortSets { get; set; }
            /// <summary>
            /// IPSets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-rulevariables.html#cfn-networkfirewall-rulegroup-rulevariables-ipsets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: IPSet
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.NetworkFirewall.RuleGroupTypes.IPSet>, IReadOnlyDictionary<string, Union<Humidifier.NetworkFirewall.RuleGroupTypes.IPSet, BaseFunction>>, BaseFunction>? IPSets { get; set; }
        }

        public class RulesSource : Humidifier.Base.BaseSubResource, IHaveNetworkFirewallRuleGroupTypesStatelessRulesAndCustomActionsStatelessRulesAndCustomActions, IHaveListOfNetworkFirewallRuleGroupTypesStatefulRuleStatefulRules, IHaveRulesString, IHaveNetworkFirewallRuleGroupTypesRulesSourceListRulesSourceList
        {
            /// <summary>
            /// StatelessRulesAndCustomActions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-rulessource.html#cfn-networkfirewall-rulegroup-rulessource-statelessrulesandcustomactions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StatelessRulesAndCustomActions
            /// </summary>
            public Union<Humidifier.NetworkFirewall.RuleGroupTypes.StatelessRulesAndCustomActions, BaseFunction>? StatelessRulesAndCustomActions { get; set; }
            /// <summary>
            /// StatefulRules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-rulessource.html#cfn-networkfirewall-rulegroup-rulessource-statefulrules
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StatefulRule
            /// </summary>
            public Union<IReadOnlyList<Humidifier.NetworkFirewall.RuleGroupTypes.StatefulRule>, IReadOnlyList<Union<Humidifier.NetworkFirewall.RuleGroupTypes.StatefulRule, BaseFunction>>, BaseFunction>? StatefulRules { get; set; }
            /// <summary>
            /// RulesString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-rulessource.html#cfn-networkfirewall-rulegroup-rulessource-rulesstring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RulesString { get; set; }
            /// <summary>
            /// RulesSourceList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-rulessource.html#cfn-networkfirewall-rulegroup-rulessource-rulessourcelist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RulesSourceList
            /// </summary>
            public Union<Humidifier.NetworkFirewall.RuleGroupTypes.RulesSourceList, BaseFunction>? RulesSourceList { get; set; }
        }

        public class RulesSourceList : Humidifier.Base.BaseSubResource, IHaveGeneratedRulesType, IHaveStringListOfTargetTypes, IHaveStringListOfTargets
        {
            /// <summary>
            /// GeneratedRulesType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-rulessourcelist.html#cfn-networkfirewall-rulegroup-rulessourcelist-generatedrulestype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GeneratedRulesType { get; set; }
            /// <summary>
            /// TargetTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-rulessourcelist.html#cfn-networkfirewall-rulegroup-rulessourcelist-targettypes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? TargetTypes { get; set; }
            /// <summary>
            /// Targets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-rulessourcelist.html#cfn-networkfirewall-rulegroup-rulessourcelist-targets
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Targets { get; set; }
        }

        public class StatefulRule : Humidifier.Base.BaseSubResource, IHaveAction, IHaveNetworkFirewallRuleGroupTypesHeaderHeader, IHaveListOfNetworkFirewallRuleGroupTypesRuleOptionRuleOptions
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-statefulrule.html#cfn-networkfirewall-rulegroup-statefulrule-action
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Action { get; set; }
            /// <summary>
            /// Header
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-statefulrule.html#cfn-networkfirewall-rulegroup-statefulrule-header
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Header
            /// </summary>
            public Union<Humidifier.NetworkFirewall.RuleGroupTypes.Header, BaseFunction>? Header { get; set; }
            /// <summary>
            /// RuleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-statefulrule.html#cfn-networkfirewall-rulegroup-statefulrule-ruleoptions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RuleOption
            /// </summary>
            public Union<IReadOnlyList<Humidifier.NetworkFirewall.RuleGroupTypes.RuleOption>, IReadOnlyList<Union<Humidifier.NetworkFirewall.RuleGroupTypes.RuleOption, BaseFunction>>, BaseFunction>? RuleOptions { get; set; }
        }

        public class StatefulRuleOptions : Humidifier.Base.BaseSubResource, IHaveRuleOrder
        {
            /// <summary>
            /// RuleOrder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-statefulruleoptions.html#cfn-networkfirewall-rulegroup-statefulruleoptions-ruleorder
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RuleOrder { get; set; }
        }

        public class StatelessRule : Humidifier.Base.BaseSubResource, IHavePriority_Integer, IHaveNetworkFirewallRuleGroupTypesRuleDefinitionRuleDefinition
        {
            /// <summary>
            /// Priority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-statelessrule.html#cfn-networkfirewall-rulegroup-statelessrule-priority
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Priority { get; set; }
            /// <summary>
            /// RuleDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-statelessrule.html#cfn-networkfirewall-rulegroup-statelessrule-ruledefinition
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RuleDefinition
            /// </summary>
            public Union<Humidifier.NetworkFirewall.RuleGroupTypes.RuleDefinition, BaseFunction>? RuleDefinition { get; set; }
        }

        public class StatelessRulesAndCustomActions : Humidifier.Base.BaseSubResource, IHaveListOfNetworkFirewallRuleGroupTypesStatelessRuleStatelessRules, IHaveListOfNetworkFirewallRuleGroupTypesCustomActionCustomActions
        {
            /// <summary>
            /// StatelessRules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-statelessrulesandcustomactions.html#cfn-networkfirewall-rulegroup-statelessrulesandcustomactions-statelessrules
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StatelessRule
            /// </summary>
            public Union<IReadOnlyList<Humidifier.NetworkFirewall.RuleGroupTypes.StatelessRule>, IReadOnlyList<Union<Humidifier.NetworkFirewall.RuleGroupTypes.StatelessRule, BaseFunction>>, BaseFunction>? StatelessRules { get; set; }
            /// <summary>
            /// CustomActions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-statelessrulesandcustomactions.html#cfn-networkfirewall-rulegroup-statelessrulesandcustomactions-customactions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomAction
            /// </summary>
            public Union<IReadOnlyList<Humidifier.NetworkFirewall.RuleGroupTypes.CustomAction>, IReadOnlyList<Union<Humidifier.NetworkFirewall.RuleGroupTypes.CustomAction, BaseFunction>>, BaseFunction>? CustomActions { get; set; }
        }

        public class SummaryConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfRuleOptions
        {
            /// <summary>
            /// RuleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-summaryconfiguration.html#cfn-networkfirewall-rulegroup-summaryconfiguration-ruleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? RuleOptions { get; set; }
        }

        public class TCPFlagField : Humidifier.Base.BaseSubResource, IHaveStringListOfFlags, IHaveStringListOfMasks
        {
            /// <summary>
            /// Flags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-tcpflagfield.html#cfn-networkfirewall-rulegroup-tcpflagfield-flags
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Flags { get; set; }
            /// <summary>
            /// Masks
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-tcpflagfield.html#cfn-networkfirewall-rulegroup-tcpflagfield-masks
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Masks { get; set; }
        }
    }
}