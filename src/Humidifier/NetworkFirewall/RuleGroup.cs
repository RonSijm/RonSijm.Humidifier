namespace Humidifier.NetworkFirewall
{
    using System.Collections.Generic;
    using RuleGroupTypes;

    public class RuleGroup : Humidifier.Resource, IHaveTags, IHaveDescription
    {
        public class Attributes
        {
            public static string RuleGroupId =  "RuleGroupId" ;
            public static string RuleGroupArn =  "RuleGroupArn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::NetworkFirewall::RuleGroup";
            }
        }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-rulegroup.html#cfn-networkfirewall-rulegroup-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Type { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-rulegroup.html#cfn-networkfirewall-rulegroup-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// Capacity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-rulegroup.html#cfn-networkfirewall-rulegroup-capacity
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic Capacity { get; set; }
        /// <summary>
        /// RuleGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-rulegroup.html#cfn-networkfirewall-rulegroup-rulegroupname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RuleGroupName { get; set; }
        /// <summary>
        /// RuleGroup
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-rulegroup.html#cfn-networkfirewall-rulegroup-rulegroup
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RuleGroup
        /// </summary>
        public RuleGroup RuleGroup_ { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkfirewall-rulegroup.html#cfn-networkfirewall-rulegroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace RuleGroupTypes
    {
        public class ActionDefinition
        {
            /// <summary>
            /// PublishMetricAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-actiondefinition.html#cfn-networkfirewall-rulegroup-actiondefinition-publishmetricaction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PublishMetricAction
            /// </summary>
            public PublishMetricAction PublishMetricAction { get; set; }
        }

        public class Address
        {
            /// <summary>
            /// AddressDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-address.html#cfn-networkfirewall-rulegroup-address-addressdefinition
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AddressDefinition { get; set; }
        }

        public class CustomAction
        {
            /// <summary>
            /// ActionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-customaction.html#cfn-networkfirewall-rulegroup-customaction-actionname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ActionName { get; set; }
            /// <summary>
            /// ActionDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-customaction.html#cfn-networkfirewall-rulegroup-customaction-actiondefinition
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ActionDefinition
            /// </summary>
            public ActionDefinition ActionDefinition { get; set; }
        }

        public class Dimension
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-dimension.html#cfn-networkfirewall-rulegroup-dimension-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
        }

        public class Header
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-header.html#cfn-networkfirewall-rulegroup-header-destination
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Destination { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-header.html#cfn-networkfirewall-rulegroup-header-protocol
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Protocol { get; set; }
            /// <summary>
            /// SourcePort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-header.html#cfn-networkfirewall-rulegroup-header-sourceport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourcePort { get; set; }
            /// <summary>
            /// Direction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-header.html#cfn-networkfirewall-rulegroup-header-direction
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Direction { get; set; }
            /// <summary>
            /// DestinationPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-header.html#cfn-networkfirewall-rulegroup-header-destinationport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DestinationPort { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-header.html#cfn-networkfirewall-rulegroup-header-source
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Source { get; set; }
        }

        public class IPSet
        {
            /// <summary>
            /// Definition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-ipset.html#cfn-networkfirewall-rulegroup-ipset-definition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Definition { get; set; }
        }

        public class IPSetReference
        {
            /// <summary>
            /// ReferenceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-ipsetreference.html#cfn-networkfirewall-rulegroup-ipsetreference-referencearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ReferenceArn { get; set; }
        }

        public class MatchAttributes
        {
            /// <summary>
            /// Protocols
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-matchattributes.html#cfn-networkfirewall-rulegroup-matchattributes-protocols
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public List<int> Protocols { get; set; }
            /// <summary>
            /// TCPFlags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-matchattributes.html#cfn-networkfirewall-rulegroup-matchattributes-tcpflags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TCPFlagField
            /// </summary>
            public List<TCPFlagField> TCPFlags { get; set; }
            /// <summary>
            /// DestinationPorts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-matchattributes.html#cfn-networkfirewall-rulegroup-matchattributes-destinationports
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PortRange
            /// </summary>
            public List<PortRange> DestinationPorts { get; set; }
            /// <summary>
            /// Destinations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-matchattributes.html#cfn-networkfirewall-rulegroup-matchattributes-destinations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Address
            /// </summary>
            public List<Address> Destinations { get; set; }
            /// <summary>
            /// Sources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-matchattributes.html#cfn-networkfirewall-rulegroup-matchattributes-sources
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Address
            /// </summary>
            public List<Address> Sources { get; set; }
            /// <summary>
            /// SourcePorts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-matchattributes.html#cfn-networkfirewall-rulegroup-matchattributes-sourceports
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PortRange
            /// </summary>
            public List<PortRange> SourcePorts { get; set; }
        }

        public class PortRange
        {
            /// <summary>
            /// FromPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-portrange.html#cfn-networkfirewall-rulegroup-portrange-fromport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic FromPort { get; set; }
            /// <summary>
            /// ToPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-portrange.html#cfn-networkfirewall-rulegroup-portrange-toport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ToPort { get; set; }
        }

        public class PortSet
        {
            /// <summary>
            /// Definition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-portset.html#cfn-networkfirewall-rulegroup-portset-definition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Definition { get; set; }
        }

        public class PublishMetricAction
        {
            /// <summary>
            /// Dimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-publishmetricaction.html#cfn-networkfirewall-rulegroup-publishmetricaction-dimensions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Dimension
            /// </summary>
            public List<Dimension> Dimensions { get; set; }
        }

        public class ReferenceSets
        {
            /// <summary>
            /// IPSetReferences
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-referencesets.html#cfn-networkfirewall-rulegroup-referencesets-ipsetreferences
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: IPSetReference
            /// </summary>
            public Dictionary<string, IPSetReference> IPSetReferences { get; set; }
        }

        public class RuleDefinition
        {
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-ruledefinition.html#cfn-networkfirewall-rulegroup-ruledefinition-actions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Actions { get; set; }
            /// <summary>
            /// MatchAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-ruledefinition.html#cfn-networkfirewall-rulegroup-ruledefinition-matchattributes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MatchAttributes
            /// </summary>
            public MatchAttributes MatchAttributes { get; set; }
        }

        public class RuleGroup
        {
            /// <summary>
            /// StatefulRuleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-rulegroup.html#cfn-networkfirewall-rulegroup-rulegroup-statefulruleoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StatefulRuleOptions
            /// </summary>
            public StatefulRuleOptions StatefulRuleOptions { get; set; }
            /// <summary>
            /// ReferenceSets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-rulegroup.html#cfn-networkfirewall-rulegroup-rulegroup-referencesets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReferenceSets
            /// </summary>
            public ReferenceSets ReferenceSets { get; set; }
            /// <summary>
            /// RulesSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-rulegroup.html#cfn-networkfirewall-rulegroup-rulegroup-rulessource
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RulesSource
            /// </summary>
            public RulesSource RulesSource { get; set; }
            /// <summary>
            /// RuleVariables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-rulegroup.html#cfn-networkfirewall-rulegroup-rulegroup-rulevariables
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RuleVariables
            /// </summary>
            public RuleVariables RuleVariables { get; set; }
        }

        public class RuleOption
        {
            /// <summary>
            /// Keyword
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-ruleoption.html#cfn-networkfirewall-rulegroup-ruleoption-keyword
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Keyword { get; set; }
            /// <summary>
            /// Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-ruleoption.html#cfn-networkfirewall-rulegroup-ruleoption-settings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Settings { get; set; }
        }

        public class RuleVariables
        {
            /// <summary>
            /// PortSets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-rulevariables.html#cfn-networkfirewall-rulegroup-rulevariables-portsets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: PortSet
            /// </summary>
            public Dictionary<string, PortSet> PortSets { get; set; }
            /// <summary>
            /// IPSets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-rulevariables.html#cfn-networkfirewall-rulegroup-rulevariables-ipsets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: IPSet
            /// </summary>
            public Dictionary<string, IPSet> IPSets { get; set; }
        }

        public class RulesSource
        {
            /// <summary>
            /// StatelessRulesAndCustomActions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-rulessource.html#cfn-networkfirewall-rulegroup-rulessource-statelessrulesandcustomactions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StatelessRulesAndCustomActions
            /// </summary>
            public StatelessRulesAndCustomActions StatelessRulesAndCustomActions { get; set; }
            /// <summary>
            /// StatefulRules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-rulessource.html#cfn-networkfirewall-rulegroup-rulessource-statefulrules
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StatefulRule
            /// </summary>
            public List<StatefulRule> StatefulRules { get; set; }
            /// <summary>
            /// RulesString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-rulessource.html#cfn-networkfirewall-rulegroup-rulessource-rulesstring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RulesString { get; set; }
            /// <summary>
            /// RulesSourceList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-rulessource.html#cfn-networkfirewall-rulegroup-rulessource-rulessourcelist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RulesSourceList
            /// </summary>
            public RulesSourceList RulesSourceList { get; set; }
        }

        public class RulesSourceList
        {
            /// <summary>
            /// GeneratedRulesType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-rulessourcelist.html#cfn-networkfirewall-rulegroup-rulessourcelist-generatedrulestype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GeneratedRulesType { get; set; }
            /// <summary>
            /// TargetTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-rulessourcelist.html#cfn-networkfirewall-rulegroup-rulessourcelist-targettypes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic TargetTypes { get; set; }
            /// <summary>
            /// Targets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-rulessourcelist.html#cfn-networkfirewall-rulegroup-rulessourcelist-targets
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Targets { get; set; }
        }

        public class StatefulRule
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-statefulrule.html#cfn-networkfirewall-rulegroup-statefulrule-action
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Action { get; set; }
            /// <summary>
            /// Header
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-statefulrule.html#cfn-networkfirewall-rulegroup-statefulrule-header
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Header
            /// </summary>
            public Header Header { get; set; }
            /// <summary>
            /// RuleOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-statefulrule.html#cfn-networkfirewall-rulegroup-statefulrule-ruleoptions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RuleOption
            /// </summary>
            public List<RuleOption> RuleOptions { get; set; }
        }

        public class StatefulRuleOptions
        {
            /// <summary>
            /// RuleOrder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-statefulruleoptions.html#cfn-networkfirewall-rulegroup-statefulruleoptions-ruleorder
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RuleOrder { get; set; }
        }

        public class StatelessRule
        {
            /// <summary>
            /// Priority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-statelessrule.html#cfn-networkfirewall-rulegroup-statelessrule-priority
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Priority { get; set; }
            /// <summary>
            /// RuleDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-statelessrule.html#cfn-networkfirewall-rulegroup-statelessrule-ruledefinition
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RuleDefinition
            /// </summary>
            public RuleDefinition RuleDefinition { get; set; }
        }

        public class StatelessRulesAndCustomActions
        {
            /// <summary>
            /// StatelessRules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-statelessrulesandcustomactions.html#cfn-networkfirewall-rulegroup-statelessrulesandcustomactions-statelessrules
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StatelessRule
            /// </summary>
            public List<StatelessRule> StatelessRules { get; set; }
            /// <summary>
            /// CustomActions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-statelessrulesandcustomactions.html#cfn-networkfirewall-rulegroup-statelessrulesandcustomactions-customactions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomAction
            /// </summary>
            public List<CustomAction> CustomActions { get; set; }
        }

        public class TCPFlagField
        {
            /// <summary>
            /// Flags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-tcpflagfield.html#cfn-networkfirewall-rulegroup-tcpflagfield-flags
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Flags { get; set; }
            /// <summary>
            /// Masks
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkfirewall-rulegroup-tcpflagfield.html#cfn-networkfirewall-rulegroup-tcpflagfield-masks
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Masks { get; set; }
        }
    }
}