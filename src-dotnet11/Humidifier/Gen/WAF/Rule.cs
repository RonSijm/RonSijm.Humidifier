namespace Humidifier.WAF
{
    using global::System.Collections.Generic;
    using RuleTypes;

    public class Rule : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveMetricName, IHaveName, IHaveListOfWAFRuleTypesPredicatePredicates
    {
        public override string AWSTypeName { get => AWS.WAF.Rule; }

        /// <summary>
        /// MetricName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-rule.html#cfn-waf-rule-metricname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? MetricName { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Predicates
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-rule.html#cfn-waf-rule-predicates
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Predicate
        /// </summary>
        public Union<IReadOnlyList<Humidifier.WAF.RuleTypes.Predicate>, IReadOnlyList<Union<Humidifier.WAF.RuleTypes.Predicate, BaseFunction>>, BaseFunction>? Predicates { get; set; }
    }

    namespace RuleTypes
    {
        public class Predicate : Humidifier.Base.BaseSubResource, IHaveDataId, IHaveNegated_Boolean, IHaveType
        {
            /// <summary>
            /// DataId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-rule-predicates.html#cfn-waf-rule-predicates-dataid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataId { get; set; }
            /// <summary>
            /// Negated
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-rule-predicates.html#cfn-waf-rule-predicates-negated
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Negated { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-rule-predicates.html#cfn-waf-rule-predicates-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
        }
    }
}