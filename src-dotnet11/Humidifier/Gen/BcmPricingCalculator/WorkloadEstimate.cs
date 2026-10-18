namespace Humidifier.BcmPricingCalculator
{
    using global::System.Collections.Generic;

    public class WorkloadEstimate : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveRateType, IHaveExpiresAt, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string TotalCost =  "TotalCost" ;
            public static string CostCurrency =  "CostCurrency" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string FailureMessage =  "FailureMessage" ;
            public static string Id =  "Id" ;
            public static string RateTimestamp =  "RateTimestamp" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.BcmPricingCalculator.WorkloadEstimate; }
        /// <summary>
        /// RateType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bcmpricingcalculator-workloadestimate.html#cfn-bcmpricingcalculator-workloadestimate-ratetype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RateType { get; set; }
        /// <summary>
        /// ExpiresAt
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bcmpricingcalculator-workloadestimate.html#cfn-bcmpricingcalculator-workloadestimate-expiresat
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ExpiresAt { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bcmpricingcalculator-workloadestimate.html#cfn-bcmpricingcalculator-workloadestimate-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }
}