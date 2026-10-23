namespace Humidifier.BcmPricingCalculator
{
    using global::System.Collections.Generic;
    using BillEstimateTypes;

    public class BillEstimate : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string BillInterval =  "BillInterval" ;
            public static string CostCategoryGroupSharingPreferenceEffectiveDate =  "CostCategoryGroupSharingPreferenceEffectiveDate" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string CostCategoryGroupSharingPreferenceArn =  "CostCategoryGroupSharingPreferenceArn" ;
            public static string Id =  "Id" ;
            public static string GroupSharingPreference =  "GroupSharingPreference" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.BcmPricingCalculator.BillEstimate; }
        /// <summary>
        /// BillScenarioId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bcmpricingcalculator-billestimate.html#cfn-bcmpricingcalculator-billestimate-billscenarioid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic BillScenarioId { get; set; }
        /// <summary>
        /// ExpiresAt
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bcmpricingcalculator-billestimate.html#cfn-bcmpricingcalculator-billestimate-expiresat
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ExpiresAt { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bcmpricingcalculator-billestimate.html#cfn-bcmpricingcalculator-billestimate-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace BillEstimateTypes
    {
        public class BillInterval : Humidifier.Base.BaseSubResource, IHaveEnd, IHaveStart
        {
            /// <summary>
            /// Start
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcmpricingcalculator-billestimate-billinterval.html#cfn-bcmpricingcalculator-billestimate-billinterval-start
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Start { get; set; }
            /// <summary>
            /// End
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcmpricingcalculator-billestimate-billinterval.html#cfn-bcmpricingcalculator-billestimate-billinterval-end
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic End { get; set; }
        }
    }
}