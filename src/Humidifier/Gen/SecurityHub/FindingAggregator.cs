namespace Humidifier.SecurityHub
{
    using System.Collections.Generic;

    public class FindingAggregator : Humidifier.Base.BaseResource, IHaveRegions
    {
        public class Attributes
        {
            public static string FindingAggregationRegion =  "FindingAggregationRegion" ;
            public static string FindingAggregatorArn =  "FindingAggregatorArn" ;
        }

        public override string AWSTypeName { get => AWS.SecurityHub.FindingAggregator; }

        /// <summary>
        /// RegionLinkingMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-findingaggregator.html#cfn-securityhub-findingaggregator-regionlinkingmode
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RegionLinkingMode { get; set; }
        /// <summary>
        /// Regions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-findingaggregator.html#cfn-securityhub-findingaggregator-regions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic Regions { get; set; }
    }
}