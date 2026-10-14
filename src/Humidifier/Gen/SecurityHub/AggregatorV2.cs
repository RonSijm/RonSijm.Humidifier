namespace Humidifier.SecurityHub
{
    using global::System.Collections.Generic;

    public class AggregatorV2 : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string AggregationRegion =  "AggregationRegion" ;
            public static string AggregatorV2Arn =  "AggregatorV2Arn" ;
        }

        public override string AWSTypeName { get => AWS.SecurityHub.AggregatorV2; }

        /// <summary>
        /// RegionLinkingMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-aggregatorv2.html#cfn-securityhub-aggregatorv2-regionlinkingmode
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RegionLinkingMode { get; set; }

        /// <summary>
        /// LinkedRegions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-aggregatorv2.html#cfn-securityhub-aggregatorv2-linkedregions
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public dynamic LinkedRegions { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-aggregatorv2.html#cfn-securityhub-aggregatorv2-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Tags { get; set; }
    }
}