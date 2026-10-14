namespace Humidifier.RTBFabric
{
    using global::System.Collections.Generic;
    using LinkRoutingRuleTypes;

    public class LinkRoutingRule : Humidifier.Base.BaseResource, IHaveTags, IHavePriority, IHaveGatewayId, IHaveLinkId
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string UpdatedTimestamp =  "UpdatedTimestamp" ;
            public static string CreatedTimestamp =  "CreatedTimestamp" ;
            public static string RuleId =  "RuleId" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.RTBFabric.LinkRoutingRule; }

        /// <summary>
        /// Priority
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rtbfabric-linkroutingrule.html#cfn-rtbfabric-linkroutingrule-priority
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public dynamic Priority { get; set; }

        /// <summary>
        /// GatewayId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rtbfabric-linkroutingrule.html#cfn-rtbfabric-linkroutingrule-gatewayid
        /// Required: True
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic GatewayId { get; set; }

        /// <summary>
        /// LinkId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rtbfabric-linkroutingrule.html#cfn-rtbfabric-linkroutingrule-linkid
        /// Required: True
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic LinkId { get; set; }

        /// <summary>
        /// Conditions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rtbfabric-linkroutingrule.html#cfn-rtbfabric-linkroutingrule-conditions
        /// Required: True
        /// UpdateType: Mutable
        /// Type: RuleCondition
        /// </summary>
        [Required]
        public Humidifier.RTBFabric.LinkRoutingRuleTypes.RuleCondition Conditions { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rtbfabric-linkroutingrule.html#cfn-rtbfabric-linkroutingrule-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace LinkRoutingRuleTypes
    {
        public class QueryStringKeyValuePair : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-linkroutingrule-querystringkeyvaluepair.html#cfn-rtbfabric-linkroutingrule-querystringkeyvaluepair-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-linkroutingrule-querystringkeyvaluepair.html#cfn-rtbfabric-linkroutingrule-querystringkeyvaluepair-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class RuleCondition : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// HostHeader
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-linkroutingrule-rulecondition.html#cfn-rtbfabric-linkroutingrule-rulecondition-hostheader
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HostHeader { get; set; }
            /// <summary>
            /// HostHeaderWildcard
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-linkroutingrule-rulecondition.html#cfn-rtbfabric-linkroutingrule-rulecondition-hostheaderwildcard
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HostHeaderWildcard { get; set; }
            /// <summary>
            /// QueryStringEquals
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-linkroutingrule-rulecondition.html#cfn-rtbfabric-linkroutingrule-rulecondition-querystringequals
            /// Required: False
            /// UpdateType: Mutable
            /// Type: QueryStringKeyValuePair
            /// </summary>
            public Humidifier.RTBFabric.LinkRoutingRuleTypes.QueryStringKeyValuePair QueryStringEquals { get; set; }
            /// <summary>
            /// PathExact
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-linkroutingrule-rulecondition.html#cfn-rtbfabric-linkroutingrule-rulecondition-pathexact
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PathExact { get; set; }
            /// <summary>
            /// PathPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-linkroutingrule-rulecondition.html#cfn-rtbfabric-linkroutingrule-rulecondition-pathprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PathPrefix { get; set; }
            /// <summary>
            /// QueryStringExists
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-linkroutingrule-rulecondition.html#cfn-rtbfabric-linkroutingrule-rulecondition-querystringexists
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic QueryStringExists { get; set; }
        }
    }
}