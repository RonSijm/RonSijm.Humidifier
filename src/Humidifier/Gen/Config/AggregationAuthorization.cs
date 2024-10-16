namespace Humidifier.Config
{
    using System.Collections.Generic;

    public class AggregationAuthorization : Humidifier.Base.BaseResource, IHaveTags
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
        public dynamic AuthorizedAccountId { get; set; }

        /// <summary>
        /// AuthorizedAwsRegion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-aggregationauthorization.html#cfn-config-aggregationauthorization-authorizedawsregion
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AuthorizedAwsRegion { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-aggregationauthorization.html#cfn-config-aggregationauthorization-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }
}