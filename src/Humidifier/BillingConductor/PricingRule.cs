namespace Humidifier.BillingConductor
{
    using System.Collections.Generic;
    using PricingRuleTypes;

    public class PricingRule : Humidifier.Resource, IHaveTags, IHaveDescription
    {
        public class Attributes
        {
            public static string CreationTime =  "CreationTime" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string AssociatedPricingPlanCount =  "AssociatedPricingPlanCount" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::BillingConductor::PricingRule";
            }
        }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billingconductor-pricingrule.html#cfn-billingconductor-pricingrule-type
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Type { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billingconductor-pricingrule.html#cfn-billingconductor-pricingrule-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// Scope
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billingconductor-pricingrule.html#cfn-billingconductor-pricingrule-scope
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Scope { get; set; }
        /// <summary>
        /// Service
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billingconductor-pricingrule.html#cfn-billingconductor-pricingrule-service
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Service { get; set; }
        /// <summary>
        /// ModifierPercentage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billingconductor-pricingrule.html#cfn-billingconductor-pricingrule-modifierpercentage
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Double
        /// </summary>
        public dynamic ModifierPercentage { get; set; }
        /// <summary>
        /// Operation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billingconductor-pricingrule.html#cfn-billingconductor-pricingrule-operation
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Operation { get; set; }
        /// <summary>
        /// Tiering
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billingconductor-pricingrule.html#cfn-billingconductor-pricingrule-tiering
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Tiering
        /// </summary>
        public Tiering Tiering { get; set; }
        /// <summary>
        /// BillingEntity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billingconductor-pricingrule.html#cfn-billingconductor-pricingrule-billingentity
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic BillingEntity { get; set; }
        /// <summary>
        /// UsageType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billingconductor-pricingrule.html#cfn-billingconductor-pricingrule-usagetype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic UsageType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billingconductor-pricingrule.html#cfn-billingconductor-pricingrule-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billingconductor-pricingrule.html#cfn-billingconductor-pricingrule-name
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name { get; set; }
    }

    namespace PricingRuleTypes
    {
        public class FreeTier
        {
            /// <summary>
            /// Activated
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billingconductor-pricingrule-freetier.html#cfn-billingconductor-pricingrule-freetier-activated
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Activated { get; set; }
        }

        public class Tiering
        {
            /// <summary>
            /// FreeTier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billingconductor-pricingrule-tiering.html#cfn-billingconductor-pricingrule-tiering-freetier
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FreeTier
            /// </summary>
            public FreeTier FreeTier { get; set; }
        }
    }
}