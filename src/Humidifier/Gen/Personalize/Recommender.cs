namespace Humidifier.Personalize
{
    using global::System.Collections.Generic;
    using RecommenderTypes;

    public class Recommender : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDatasetGroupArn
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CreationDateTime =  "CreationDateTime" ;
            public static string RecommenderArn =  "RecommenderArn" ;
            public static string LastUpdatedDateTime =  "LastUpdatedDateTime" ;
        }

        public override string AWSTypeName { get => AWS.Personalize.Recommender; }

        /// <summary>
        /// DatasetGroupArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-recommender.html#cfn-personalize-recommender-datasetgrouparn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DatasetGroupArn { get; set; }
        /// <summary>
        /// RecommenderConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-recommender.html#cfn-personalize-recommender-recommenderconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RecommenderConfig
        /// </summary>
        public Humidifier.Personalize.RecommenderTypes.RecommenderConfig RecommenderConfig { get; set; }

        /// <summary>
        /// RecipeArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-recommender.html#cfn-personalize-recommender-recipearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RecipeArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-recommender.html#cfn-personalize-recommender-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace RecommenderTypes
    {
        public class RecommenderConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ItemExplorationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-recommender-recommenderconfig.html#cfn-personalize-recommender-recommenderconfig-itemexplorationconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> ItemExplorationConfig { get; set; }
            /// <summary>
            /// TrainingDataConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-recommender-recommenderconfig.html#cfn-personalize-recommender-recommenderconfig-trainingdataconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TrainingDataConfig
            /// </summary>
            public Humidifier.Personalize.RecommenderTypes.TrainingDataConfig TrainingDataConfig { get; set; }
            /// <summary>
            /// EnableMetadataWithRecommendations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-recommender-recommenderconfig.html#cfn-personalize-recommender-recommenderconfig-enablemetadatawithrecommendations
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EnableMetadataWithRecommendations { get; set; }
            /// <summary>
            /// MinRecommendationRequestsPerSecond
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-recommender-recommenderconfig.html#cfn-personalize-recommender-recommenderconfig-minrecommendationrequestspersecond
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinRecommendationRequestsPerSecond { get; set; }
        }

        public class TrainingDataConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ExcludedDatasetColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-recommender-trainingdataconfig.html#cfn-personalize-recommender-trainingdataconfig-excludeddatasetcolumns
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic ExcludedDatasetColumns { get; set; }
        }
    }
}