namespace Humidifier.BcmPricingCalculator
{
    using global::System.Collections.Generic;
    using BillScenarioTypes;

    public class BillScenario : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveCostCategoryGroupSharingPreferenceArn, IHaveGroupSharingPreference, IHaveExpiresAt, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string BillInterval =  "BillInterval" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string FailureMessage =  "FailureMessage" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.BcmPricingCalculator.BillScenario; }
        /// <summary>
        /// CostCategoryGroupSharingPreferenceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bcmpricingcalculator-billscenario.html#cfn-bcmpricingcalculator-billscenario-costcategorygroupsharingpreferencearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CostCategoryGroupSharingPreferenceArn { get; set; }
        /// <summary>
        /// GroupSharingPreference
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bcmpricingcalculator-billscenario.html#cfn-bcmpricingcalculator-billscenario-groupsharingpreference
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? GroupSharingPreference { get; set; }
        /// <summary>
        /// ExpiresAt
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bcmpricingcalculator-billscenario.html#cfn-bcmpricingcalculator-billscenario-expiresat
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ExpiresAt { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bcmpricingcalculator-billscenario.html#cfn-bcmpricingcalculator-billscenario-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace BillScenarioTypes
    {
        public class BillInterval : Humidifier.Base.BaseSubResource, IHaveStart, IHaveEnd
        {
            /// <summary>
            /// Start
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcmpricingcalculator-billscenario-billinterval.html#cfn-bcmpricingcalculator-billscenario-billinterval-start
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Start { get; set; }
            /// <summary>
            /// End
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcmpricingcalculator-billscenario-billinterval.html#cfn-bcmpricingcalculator-billscenario-billinterval-end
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? End { get; set; }
        }
    }
}