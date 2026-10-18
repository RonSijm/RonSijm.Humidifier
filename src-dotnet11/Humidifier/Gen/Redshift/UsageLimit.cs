namespace Humidifier.Redshift
{
    using global::System.Collections.Generic;

    public class UsageLimit : Humidifier.Base.BaseResource, IHaveTags, IHaveFeatureType, IHaveAmount_Double, IHavePeriod, IHaveBreachAction, IHaveClusterIdentifier, IHaveLimitType
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
        public Union<string, BaseFunction>? FeatureType { get; set; }

        /// <summary>
        /// Amount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-usagelimit.html#cfn-redshift-usagelimit-amount
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Double
        /// </summary>
        [Required]
        public Union<double, BaseFunction>? Amount { get; set; }
        /// <summary>
        /// Period
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-usagelimit.html#cfn-redshift-usagelimit-period
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Period { get; set; }
        /// <summary>
        /// BreachAction
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-usagelimit.html#cfn-redshift-usagelimit-breachaction
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? BreachAction { get; set; }

        /// <summary>
        /// ClusterIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-usagelimit.html#cfn-redshift-usagelimit-clusteridentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ClusterIdentifier { get; set; }

        /// <summary>
        /// LimitType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-usagelimit.html#cfn-redshift-usagelimit-limittype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? LimitType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-usagelimit.html#cfn-redshift-usagelimit-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}