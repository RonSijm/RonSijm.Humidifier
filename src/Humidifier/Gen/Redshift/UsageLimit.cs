namespace Humidifier.Redshift
{
    using global::System.Collections.Generic;

    public class UsageLimit : Humidifier.Base.BaseResource, IHaveTags, IHavePeriod, IHaveClusterIdentifier, IHaveAmount
    {
        public class Attributes
        {
            public static string UsageLimitId =  "UsageLimitId" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Redshift.UsageLimit; }

        /// <summary>
        /// FeatureType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-usagelimit.html#cfn-redshift-usagelimit-featuretype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic FeatureType { get; set; }

        /// <summary>
        /// Amount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-usagelimit.html#cfn-redshift-usagelimit-amount
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Double
        /// </summary>
        [Required]
        public dynamic Amount { get; set; }
        /// <summary>
        /// Period
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-usagelimit.html#cfn-redshift-usagelimit-period
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Period { get; set; }
        /// <summary>
        /// BreachAction
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-usagelimit.html#cfn-redshift-usagelimit-breachaction
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic BreachAction { get; set; }

        /// <summary>
        /// ClusterIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-usagelimit.html#cfn-redshift-usagelimit-clusteridentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ClusterIdentifier { get; set; }

        /// <summary>
        /// LimitType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-usagelimit.html#cfn-redshift-usagelimit-limittype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic LimitType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-usagelimit.html#cfn-redshift-usagelimit-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }
}