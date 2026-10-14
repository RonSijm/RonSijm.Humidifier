namespace Humidifier.Personalize
{
    using global::System.Collections.Generic;
    using CampaignTypes;

    public class Campaign : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags
    {
        public class Attributes
        {
            public static string CampaignArn =  "CampaignArn" ;
            public static string Status =  "Status" ;
            public static string CreationDateTime =  "CreationDateTime" ;
            public static string LastUpdatedDateTime =  "LastUpdatedDateTime" ;
        }

        public override string AWSTypeName { get => AWS.Personalize.Campaign; }
        /// <summary>
        /// CampaignConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-campaign.html#cfn-personalize-campaign-campaignconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CampaignConfig
        /// </summary>
        public Humidifier.Personalize.CampaignTypes.CampaignConfig CampaignConfig { get; set; }

        /// <summary>
        /// SolutionVersionArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-campaign.html#cfn-personalize-campaign-solutionversionarn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic SolutionVersionArn { get; set; }
        /// <summary>
        /// MinProvisionedTPS
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-campaign.html#cfn-personalize-campaign-minprovisionedtps
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic MinProvisionedTPS { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-campaign.html#cfn-personalize-campaign-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace CampaignTypes
    {
        public class CampaignConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ItemExplorationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-campaign-campaignconfig.html#cfn-personalize-campaign-campaignconfig-itemexplorationconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> ItemExplorationConfig { get; set; }
            /// <summary>
            /// SyncWithLatestSolutionVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-campaign-campaignconfig.html#cfn-personalize-campaign-campaignconfig-syncwithlatestsolutionversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic SyncWithLatestSolutionVersion { get; set; }
            /// <summary>
            /// EnableMetadataWithRecommendations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-campaign-campaignconfig.html#cfn-personalize-campaign-campaignconfig-enablemetadatawithrecommendations
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EnableMetadataWithRecommendations { get; set; }
            /// <summary>
            /// RankingInfluence
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-campaign-campaignconfig.html#cfn-personalize-campaign-campaignconfig-rankinginfluence
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: Double
            /// </summary>
            public Dictionary<string, double> RankingInfluence { get; set; }
        }
    }
}