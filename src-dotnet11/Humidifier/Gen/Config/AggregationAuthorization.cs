namespace Humidifier.Config
{
    using global::System.Collections.Generic;

    public class AggregationAuthorization : Humidifier.Base.BaseResource, IHaveTags, IHaveAuthorizedAccountId, IHaveAuthorizedAwsRegion
    {
        public class Attributes
        {
            public static string AggregationAuthorizationArn =  "AggregationAuthorizationArn" ;
        }

        public override string AWSTypeName { get => AWS.Config.AggregationAuthorization; }

        /// <summary>
        /// AuthorizedAccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-aggregationauthorization.html#cfn-config-aggregationauthorization-authorizedaccountid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AuthorizedAccountId { get; set; }

        /// <summary>
        /// AuthorizedAwsRegion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-aggregationauthorization.html#cfn-config-aggregationauthorization-authorizedawsregion
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AuthorizedAwsRegion { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-aggregationauthorization.html#cfn-config-aggregationauthorization-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}