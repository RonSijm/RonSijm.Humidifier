namespace Humidifier.WAFRegional
{
    using System.Collections.Generic;
    using RateBasedRuleTypes;

    public class RateBasedRule : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveMetricName, IHaveRateLimit
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
        public dynamic MetricName { get; set; }

        /// <summary>
        /// RateLimit
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-ratebasedrule.html#cfn-wafregional-ratebasedrule-ratelimit
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public dynamic RateLimit { get; set; }
        /// <summary>
        /// MatchPredicates
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-ratebasedrule.html#cfn-wafregional-ratebasedrule-matchpredicates
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Predicate
        /// </summary>
        public List<Humidifier.WAFRegional.RateBasedRuleTypes.Predicate> MatchPredicates { get; set; }

        /// <summary>
        /// RateKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-ratebasedrule.html#cfn-wafregional-ratebasedrule-ratekey
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RateKey { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace RateBasedRuleTypes
    {
        public class Predicate : Humidifier.Base.BaseSubResource, IHaveType, IHaveDataId, IHaveNegated
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-ratebasedrule-predicate.html#cfn-wafregional-ratebasedrule-predicate-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// DataId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-ratebasedrule-predicate.html#cfn-wafregional-ratebasedrule-predicate-dataid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataId { get; set; }
            /// <summary>
            /// Negated
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-ratebasedrule-predicate.html#cfn-wafregional-ratebasedrule-predicate-negated
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Negated { get; set; }
        }
    }
}