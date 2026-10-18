namespace Humidifier.WAF
{
    using global::System.Collections.Generic;
    using WebACLTypes;

    public class WebACL : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveWAFWebACLTypesWafActionDefaultAction, IHaveMetricName, IHaveName, IHaveListOfWAFWebACLTypesActivatedRuleRules
    {
        public override string AWSTypeName { get => AWS.WAF.WebACL; }

        /// <summary>
        /// DefaultAction
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-webacl.html#cfn-waf-webacl-defaultaction
        /// Required: True
        /// UpdateType: Mutable
        /// Type: WafAction
        /// </summary>
        [Required]
        public Union<Humidifier.WAF.WebACLTypes.WafAction, BaseFunction>? DefaultAction { get; set; }

        /// <summary>
        /// MetricName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-webacl.html#cfn-waf-webacl-metricname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? MetricName { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Rules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-webacl.html#cfn-waf-webacl-rules
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ActivatedRule
        /// </summary>
        public Union<IReadOnlyList<Humidifier.WAF.WebACLTypes.ActivatedRule>, IReadOnlyList<Union<Humidifier.WAF.WebACLTypes.ActivatedRule, BaseFunction>>, BaseFunction>? Rules { get; set; }
    }

    namespace WebACLTypes
    {
        public class ActivatedRule : Humidifier.Base.BaseSubResource, IHaveWAFWebACLTypesWafActionAction, IHavePriority_Integer, IHaveRuleId
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-webacl-rules.html#cfn-waf-webacl-rules-action
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WafAction
            /// </summary>
            public Union<Humidifier.WAF.WebACLTypes.WafAction, BaseFunction>? Action { get; set; }
            /// <summary>
            /// Priority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-webacl-rules.html#cfn-waf-webacl-rules-priority
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Priority { get; set; }
            /// <summary>
            /// RuleId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-webacl-rules.html#cfn-waf-webacl-rules-ruleid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RuleId { get; set; }
        }

        public class WafAction : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-webacl-action.html#cfn-waf-webacl-action-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
        }
    }
}