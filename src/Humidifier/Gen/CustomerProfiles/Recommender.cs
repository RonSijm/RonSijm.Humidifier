namespace Humidifier.CustomerProfiles
{
    using global::System.Collections.Generic;
    using RecommenderTypes;

    public class Recommender : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveDomainName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string LastUpdatedAt =  "LastUpdatedAt" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string LatestRecommenderUpdate =  "LatestRecommenderUpdate" ;
            public static string TrainingMetrics =  "TrainingMetrics" ;
            public static string FailureReason =  "FailureReason" ;
            public static string RecommenderArn =  "RecommenderArn" ;
        }

        public override string AWSTypeName { get => AWS.CustomerProfiles.Recommender; }
        public dynamic RecommenderName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// RecommenderRecipeName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-recommender.html#cfn-customerprofiles-recommender-recommenderrecipename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RecommenderRecipeName { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-recommender.html#cfn-customerprofiles-recommender-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// DomainName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-recommender.html#cfn-customerprofiles-recommender-domainname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DomainName { get; set; }
        /// <summary>
        /// RecommenderConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-recommender.html#cfn-customerprofiles-recommender-recommenderconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RecommenderConfig
        /// </summary>
        public Humidifier.CustomerProfiles.RecommenderTypes.RecommenderConfig RecommenderConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-recommender.html#cfn-customerprofiles-recommender-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace RecommenderTypes
    {
        public class EventParameters : Humidifier.Base.BaseSubResource, IHaveEventType
        {
            /// <summary>
            /// EventValueThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-recommender-eventparameters.html#cfn-customerprofiles-recommender-eventparameters-eventvaluethreshold
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic EventValueThreshold { get; set; }
            /// <summary>
            /// EventType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-recommender-eventparameters.html#cfn-customerprofiles-recommender-eventparameters-eventtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EventType { get; set; }
        }

        public class EventsConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EventParametersList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-recommender-eventsconfig.html#cfn-customerprofiles-recommender-eventsconfig-eventparameterslist
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EventParameters
            /// </summary>
            public List<Humidifier.CustomerProfiles.RecommenderTypes.EventParameters> EventParametersList { get; set; }
        }

        public class Metrics : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// coverage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-recommender-metrics.html#cfn-customerprofiles-recommender-metrics-coverage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic coverage { get; set; }
            /// <summary>
            /// hit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-recommender-metrics.html#cfn-customerprofiles-recommender-metrics-hit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic hit { get; set; }
            /// <summary>
            /// similarity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-recommender-metrics.html#cfn-customerprofiles-recommender-metrics-similarity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic similarity { get; set; }
            /// <summary>
            /// recall
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-recommender-metrics.html#cfn-customerprofiles-recommender-metrics-recall
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic recall { get; set; }
            /// <summary>
            /// popularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-recommender-metrics.html#cfn-customerprofiles-recommender-metrics-popularity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic popularity { get; set; }
            /// <summary>
            /// freshness
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-recommender-metrics.html#cfn-customerprofiles-recommender-metrics-freshness
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic freshness { get; set; }
        }

        public class RecommenderConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EventsConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-recommender-recommenderconfig.html#cfn-customerprofiles-recommender-recommenderconfig-eventsconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EventsConfig
            /// </summary>
            public Humidifier.CustomerProfiles.RecommenderTypes.EventsConfig EventsConfig { get; set; }
        }

        public class RecommenderUpdate : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveFailureReason
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-recommender-recommenderupdate.html#cfn-customerprofiles-recommender-recommenderupdate-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// CreationDateTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-recommender-recommenderupdate.html#cfn-customerprofiles-recommender-recommenderupdate-creationdatetime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreationDateTime { get; set; }
            /// <summary>
            /// RecommenderConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-recommender-recommenderupdate.html#cfn-customerprofiles-recommender-recommenderupdate-recommenderconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RecommenderConfig
            /// </summary>
            public Humidifier.CustomerProfiles.RecommenderTypes.RecommenderConfig RecommenderConfig { get; set; }
            /// <summary>
            /// FailureReason
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-recommender-recommenderupdate.html#cfn-customerprofiles-recommender-recommenderupdate-failurereason
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FailureReason { get; set; }
            /// <summary>
            /// LastUpdatedDateTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-recommender-recommenderupdate.html#cfn-customerprofiles-recommender-recommenderupdate-lastupdateddatetime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LastUpdatedDateTime { get; set; }
        }

        public class TrainingMetrics : Humidifier.Base.BaseSubResource, IHaveTime
        {
            /// <summary>
            /// Metrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-recommender-trainingmetrics.html#cfn-customerprofiles-recommender-trainingmetrics-metrics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Metrics
            /// </summary>
            public Humidifier.CustomerProfiles.RecommenderTypes.Metrics Metrics { get; set; }
            /// <summary>
            /// Time
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-recommender-trainingmetrics.html#cfn-customerprofiles-recommender-trainingmetrics-time
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Time { get; set; }
        }
    }
}