namespace Humidifier.PricingPlanManager
{
    using global::System.Collections.Generic;

    public class Subscription : Humidifier.Base.BaseResource, IHaveResourceArns
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CurrentPlanTier =  "CurrentPlanTier" ;
            public static string StatusReason =  "StatusReason" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Arn =  "Arn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.PricingPlanManager.Subscription; }

        /// <summary>
        /// PlanTier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pricingplanmanager-subscription.html#cfn-pricingplanmanager-subscription-plantier
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic PlanTier { get; set; }

        /// <summary>
        /// PlanFamily
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pricingplanmanager-subscription.html#cfn-pricingplanmanager-subscription-planfamily
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic PlanFamily { get; set; }

        /// <summary>
        /// ResourceArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pricingplanmanager-subscription.html#cfn-pricingplanmanager-subscription-resourcearns
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public dynamic ResourceArns { get; set; }
        /// <summary>
        /// UsageLevel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pricingplanmanager-subscription.html#cfn-pricingplanmanager-subscription-usagelevel
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic UsageLevel { get; set; }
    }
}