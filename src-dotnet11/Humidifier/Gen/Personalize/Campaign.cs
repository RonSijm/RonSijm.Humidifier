namespace Humidifier.Personalize
{
    using global::System.Collections.Generic;
    using CampaignTypes;

    public class Campaign : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHavePersonalizeCampaignTypesCampaignConfigCampaignConfig, IHaveSolutionVersionArn, IHaveMinProvisionedTPS_Integer, IHaveName
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
        public Union<Humidifier.Personalize.CampaignTypes.CampaignConfig, BaseFunction>? CampaignConfig { get; set; }

        /// <summary>
        /// SolutionVersionArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-campaign.html#cfn-personalize-campaign-solutionversionarn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SolutionVersionArn { get; set; }
        /// <summary>
        /// MinProvisionedTPS
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-campaign.html#cfn-personalize-campaign-minprovisionedtps
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MinProvisionedTPS { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-campaign.html#cfn-personalize-campaign-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace CampaignTypes
    {
        public class CampaignConfig : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfItemExplorationConfig, IHaveSyncWithLatestSolutionVersion_Boolean, IHaveEnableMetadataWithRecommendations_Boolean, IHaveDoubleDictionaryOfRankingInfluence
        {
            /// <summary>
            /// ItemExplorationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-campaign-campaignconfig.html#cfn-personalize-campaign-campaignconfig-itemexplorationconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? ItemExplorationConfig { get; set; }
            /// <summary>
            /// SyncWithLatestSolutionVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-campaign-campaignconfig.html#cfn-personalize-campaign-campaignconfig-syncwithlatestsolutionversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? SyncWithLatestSolutionVersion { get; set; }
            /// <summary>
            /// EnableMetadataWithRecommendations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-campaign-campaignconfig.html#cfn-personalize-campaign-campaignconfig-enablemetadatawithrecommendations
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableMetadataWithRecommendations { get; set; }
            /// <summary>
            /// RankingInfluence
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-campaign-campaignconfig.html#cfn-personalize-campaign-campaignconfig-rankinginfluence
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: Double
            /// </summary>
            public Union<IReadOnlyDictionary<string, double>, IReadOnlyDictionary<string, Union<double, BaseFunction>>, BaseFunction>? RankingInfluence { get; set; }
        }
    }
}