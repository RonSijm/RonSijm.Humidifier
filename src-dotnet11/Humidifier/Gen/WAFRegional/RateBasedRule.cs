namespace Humidifier.WAFRegional
{
    using global::System.Collections.Generic;
    using RateBasedRuleTypes;

    public class RateBasedRule : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveMetricName, IHaveRateLimit_Integer, IHaveListOfWAFRegionalRateBasedRuleTypesPredicateMatchPredicates, IHaveRateKey, IHaveName
    {
        public override string AWSTypeName { get => AWS.WAFRegional.RateBasedRule; }

        /// <summary>
        /// MetricName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-ratebasedrule.html#cfn-wafregional-ratebasedrule-metricname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? MetricName { get; set; }

        /// <summary>
        /// RateLimit
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-ratebasedrule.html#cfn-wafregional-ratebasedrule-ratelimit
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? RateLimit { get; set; }
        /// <summary>
        /// MatchPredicates
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-ratebasedrule.html#cfn-wafregional-ratebasedrule-matchpredicates
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Predicate
        /// </summary>
        public Union<IReadOnlyList<Humidifier.WAFRegional.RateBasedRuleTypes.Predicate>, IReadOnlyList<Union<Humidifier.WAFRegional.RateBasedRuleTypes.Predicate, BaseFunction>>, BaseFunction>? MatchPredicates { get; set; }

        /// <summary>
        /// RateKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-ratebasedrule.html#cfn-wafregional-ratebasedrule-ratekey
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RateKey { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace RateBasedRuleTypes
    {
        public class Predicate : Humidifier.Base.BaseSubResource, IHaveType, IHaveDataId, IHaveNegated_Boolean
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-ratebasedrule-predicate.html#cfn-wafregional-ratebasedrule-predicate-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// DataId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-ratebasedrule-predicate.html#cfn-wafregional-ratebasedrule-predicate-dataid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataId { get; set; }
            /// <summary>
            /// Negated
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-ratebasedrule-predicate.html#cfn-wafregional-ratebasedrule-predicate-negated
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Negated { get; set; }
        }
    }
}