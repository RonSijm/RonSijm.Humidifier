namespace Humidifier.SecurityHub
{
    using global::System.Collections.Generic;

    public class FindingAggregator : Humidifier.Base.BaseResource, IHaveRegionLinkingMode, IHaveStringListOfRegions
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
        public Union<string, BaseFunction>? RegionLinkingMode { get; set; }
        /// <summary>
        /// Regions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-findingaggregator.html#cfn-securityhub-findingaggregator-regions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Regions { get; set; }
    }
}