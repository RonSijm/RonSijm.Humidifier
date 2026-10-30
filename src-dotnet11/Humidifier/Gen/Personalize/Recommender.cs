namespace Humidifier.Personalize
{
    using global::System.Collections.Generic;
    using RecommenderTypes;

    public class Recommender : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDatasetGroupArn, IHavePersonalizeRecommenderTypesRecommenderConfigRecommenderConfig, IHaveRecipeArn, IHaveName
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
        public Union<string, BaseFunction>? DatasetGroupArn { get; set; }
        /// <summary>
        /// RecommenderConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-recommender.html#cfn-personalize-recommender-recommenderconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RecommenderConfig
        /// </summary>
        public Union<Humidifier.Personalize.RecommenderTypes.RecommenderConfig, BaseFunction>? RecommenderConfig { get; set; }

        /// <summary>
        /// RecipeArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-recommender.html#cfn-personalize-recommender-recipearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RecipeArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-recommender.html#cfn-personalize-recommender-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace RecommenderTypes
    {
        public class RecommenderConfig : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfItemExplorationConfig, IHavePersonalizeRecommenderTypesTrainingDataConfigTrainingDataConfig, IHaveEnableMetadataWithRecommendations_Boolean, IHaveMinRecommendationRequestsPerSecond_Integer
        {
            /// <summary>
            /// ItemExplorationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-recommender-recommenderconfig.html#cfn-personalize-recommender-recommenderconfig-itemexplorationconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? ItemExplorationConfig { get; set; }
            /// <summary>
            /// TrainingDataConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-recommender-recommenderconfig.html#cfn-personalize-recommender-recommenderconfig-trainingdataconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TrainingDataConfig
            /// </summary>
            public Union<Humidifier.Personalize.RecommenderTypes.TrainingDataConfig, BaseFunction>? TrainingDataConfig { get; set; }
            /// <summary>
            /// EnableMetadataWithRecommendations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-recommender-recommenderconfig.html#cfn-personalize-recommender-recommenderconfig-enablemetadatawithrecommendations
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableMetadataWithRecommendations { get; set; }
            /// <summary>
            /// MinRecommendationRequestsPerSecond
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-recommender-recommenderconfig.html#cfn-personalize-recommender-recommenderconfig-minrecommendationrequestspersecond
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinRecommendationRequestsPerSecond { get; set; }
        }

        public class TrainingDataConfig : Humidifier.Base.BaseSubResource, IHaveExcludedDatasetColumns_Json
        {
            /// <summary>
            /// ExcludedDatasetColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-recommender-trainingdataconfig.html#cfn-personalize-recommender-trainingdataconfig-excludeddatasetcolumns
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? ExcludedDatasetColumns { get; set; }
        }
    }
}