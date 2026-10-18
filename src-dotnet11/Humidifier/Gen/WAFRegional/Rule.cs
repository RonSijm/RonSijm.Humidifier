namespace Humidifier.WAFRegional
{
    using global::System.Collections.Generic;
    using RuleTypes;

    public class Rule : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveMetricName, IHaveListOfWAFRegionalRuleTypesPredicatePredicates, IHaveName
    {
        public override string AWSTypeName { get => AWS.WAFRegional.Rule; }

        /// <summary>
        /// MetricName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-rule.html#cfn-wafregional-rule-metricname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? MetricName { get; set; }
        /// <summary>
        /// Predicates
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-rule.html#cfn-wafregional-rule-predicates
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Predicate
        /// </summary>
        public Union<IReadOnlyList<Humidifier.WAFRegional.RuleTypes.Predicate>, IReadOnlyList<Union<Humidifier.WAFRegional.RuleTypes.Predicate, BaseFunction>>, BaseFunction>? Predicates { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace RuleTypes
    {
        public class Predicate : Humidifier.Base.BaseSubResource, IHaveType, IHaveDataId, IHaveNegated_Boolean
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-rule-predicate.html#cfn-wafregional-rule-predicate-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// DataId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-rule-predicate.html#cfn-wafregional-rule-predicate-dataid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataId { get; set; }
            /// <summary>
            /// Negated
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-rule-predicate.html#cfn-wafregional-rule-predicate-negated
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Negated { get; set; }
        }
    }
}