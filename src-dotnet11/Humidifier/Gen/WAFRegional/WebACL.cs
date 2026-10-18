namespace Humidifier.WAFRegional
{
    using global::System.Collections.Generic;
    using WebACLTypes;

    public class WebACL : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveMetricName, IHaveWAFRegionalWebACLTypesActionDefaultAction, IHaveListOfWAFRegionalWebACLTypesRuleRules, IHaveName
    {
        public override string AWSTypeName { get => AWS.WAFRegional.WebACL; }

        /// <summary>
        /// MetricName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-webacl.html#cfn-wafregional-webacl-metricname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? MetricName { get; set; }

        /// <summary>
        /// DefaultAction
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-webacl.html#cfn-wafregional-webacl-defaultaction
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Action
        /// </summary>
        [Required]
        public Union<Humidifier.WAFRegional.WebACLTypes.Action, BaseFunction>? DefaultAction { get; set; }
        /// <summary>
        /// Rules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-webacl.html#cfn-wafregional-webacl-rules
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Rule
        /// </summary>
        public Union<IReadOnlyList<Humidifier.WAFRegional.WebACLTypes.Rule>, IReadOnlyList<Union<Humidifier.WAFRegional.WebACLTypes.Rule, BaseFunction>>, BaseFunction>? Rules { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace WebACLTypes
    {
        public class Action : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-webacl-action.html#cfn-wafregional-webacl-action-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
        }

        public class Rule : Humidifier.Base.BaseSubResource, IHaveWAFRegionalWebACLTypesActionAction, IHavePriority_Integer, IHaveRuleId
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-webacl-rule.html#cfn-wafregional-webacl-rule-action
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Action
            /// </summary>
            public Union<Humidifier.WAFRegional.WebACLTypes.Action, BaseFunction>? Action { get; set; }
            /// <summary>
            /// Priority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-webacl-rule.html#cfn-wafregional-webacl-rule-priority
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Priority { get; set; }
            /// <summary>
            /// RuleId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-webacl-rule.html#cfn-wafregional-webacl-rule-ruleid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RuleId { get; set; }
        }
    }
}