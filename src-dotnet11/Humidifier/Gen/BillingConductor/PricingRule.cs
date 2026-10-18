namespace Humidifier.BillingConductor
{
    using global::System.Collections.Generic;
    using PricingRuleTypes;

    public class PricingRule : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveType, IHaveDescription, IHaveScope, IHaveService, IHaveModifierPercentage_Double, IHaveOperation, IHaveBillingConductorPricingRuleTypesTieringTiering, IHaveBillingEntity, IHaveUsageType, IHaveName
    {
        public class Attributes
        {
            public static string CreationTime =  "CreationTime" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string AssociatedPricingPlanCount =  "AssociatedPricingPlanCount" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.BillingConductor.PricingRule; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billingconductor-pricingrule.html#cfn-billingconductor-pricingrule-type
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Type { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billingconductor-pricingrule.html#cfn-billingconductor-pricingrule-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// Scope
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billingconductor-pricingrule.html#cfn-billingconductor-pricingrule-scope
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Scope { get; set; }
        /// <summary>
        /// Service
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billingconductor-pricingrule.html#cfn-billingconductor-pricingrule-service
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Service { get; set; }
        /// <summary>
        /// ModifierPercentage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billingconductor-pricingrule.html#cfn-billingconductor-pricingrule-modifierpercentage
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Double
        /// </summary>
        public Union<double, BaseFunction>? ModifierPercentage { get; set; }
        /// <summary>
        /// Operation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billingconductor-pricingrule.html#cfn-billingconductor-pricingrule-operation
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Operation { get; set; }
        /// <summary>
        /// Tiering
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billingconductor-pricingrule.html#cfn-billingconductor-pricingrule-tiering
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Tiering
        /// </summary>
        public Union<Humidifier.BillingConductor.PricingRuleTypes.Tiering, BaseFunction>? Tiering { get; set; }
        /// <summary>
        /// BillingEntity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billingconductor-pricingrule.html#cfn-billingconductor-pricingrule-billingentity
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? BillingEntity { get; set; }
        /// <summary>
        /// UsageType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billingconductor-pricingrule.html#cfn-billingconductor-pricingrule-usagetype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? UsageType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billingconductor-pricingrule.html#cfn-billingconductor-pricingrule-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace PricingRuleTypes
    {
        public class CustomTier : Humidifier.Base.BaseSubResource, IHaveRateValue_Double, IHaveEndRangeExclusive_Double, IHaveBeginRangeInclusive_Double
        {
            /// <summary>
            /// RateValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billingconductor-pricingrule-customtier.html#cfn-billingconductor-pricingrule-customtier-ratevalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? RateValue { get; set; }
            /// <summary>
            /// EndRangeExclusive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billingconductor-pricingrule-customtier.html#cfn-billingconductor-pricingrule-customtier-endrangeexclusive
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? EndRangeExclusive { get; set; }
            /// <summary>
            /// BeginRangeInclusive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billingconductor-pricingrule-customtier.html#cfn-billingconductor-pricingrule-customtier-beginrangeinclusive
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? BeginRangeInclusive { get; set; }
        }

        public class FreeTier : Humidifier.Base.BaseSubResource, IHaveActivated_Boolean
        {
            /// <summary>
            /// Activated
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billingconductor-pricingrule-freetier.html#cfn-billingconductor-pricingrule-freetier-activated
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Activated { get; set; }
        }

        public class Tiering : Humidifier.Base.BaseSubResource, IHaveListOfBillingConductorPricingRuleTypesCustomTierCustomTiers, IHaveBillingConductorPricingRuleTypesFreeTierFreeTier
        {
            /// <summary>
            /// CustomTiers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billingconductor-pricingrule-tiering.html#cfn-billingconductor-pricingrule-tiering-customtiers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomTier
            /// </summary>
            public Union<IReadOnlyList<Humidifier.BillingConductor.PricingRuleTypes.CustomTier>, IReadOnlyList<Union<Humidifier.BillingConductor.PricingRuleTypes.CustomTier, BaseFunction>>, BaseFunction>? CustomTiers { get; set; }
            /// <summary>
            /// FreeTier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billingconductor-pricingrule-tiering.html#cfn-billingconductor-pricingrule-tiering-freetier
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FreeTier
            /// </summary>
            public Union<Humidifier.BillingConductor.PricingRuleTypes.FreeTier, BaseFunction>? FreeTier { get; set; }
        }
    }
}