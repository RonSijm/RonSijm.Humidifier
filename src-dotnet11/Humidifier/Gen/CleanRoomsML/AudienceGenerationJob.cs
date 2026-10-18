namespace Humidifier.CleanRoomsML
{
    using global::System.Collections.Generic;
    using AudienceGenerationJobTypes;

    public class AudienceGenerationJob : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveIncludeSeedInOutput_Boolean
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string Metrics =  "Metrics" ;
            public static string AudienceGenerationJobArn =  "AudienceGenerationJobArn" ;
            public static string StartedBy =  "StartedBy" ;
            public static string CreateTime =  "CreateTime" ;
            public static string UpdateTime =  "UpdateTime" ;
            public static string ConfiguredAudienceModelArn =  "ConfiguredAudienceModelArn" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.CleanRoomsML.AudienceGenerationJob; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanroomsml-audiencegenerationjob.html#cfn-cleanroomsml-audiencegenerationjob-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// IncludeSeedInOutput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanroomsml-audiencegenerationjob.html#cfn-cleanroomsml-audiencegenerationjob-includeseedinoutput
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? IncludeSeedInOutput { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanroomsml-audiencegenerationjob.html#cfn-cleanroomsml-audiencegenerationjob-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace AudienceGenerationJobTypes
    {
        public class AudienceQualityMetrics : Humidifier.Base.BaseSubResource, IHaveRecallMetric_Double, IHaveListOfCleanRoomsMLAudienceGenerationJobTypesRelevanceMetricRelevanceMetrics
        {
            /// <summary>
            /// RecallMetric
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-audiencegenerationjob-audiencequalitymetrics.html#cfn-cleanroomsml-audiencegenerationjob-audiencequalitymetrics-recallmetric
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? RecallMetric { get; set; }
            /// <summary>
            /// RelevanceMetrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-audiencegenerationjob-audiencequalitymetrics.html#cfn-cleanroomsml-audiencegenerationjob-audiencequalitymetrics-relevancemetrics
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RelevanceMetric
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CleanRoomsML.AudienceGenerationJobTypes.RelevanceMetric>, IReadOnlyList<Union<Humidifier.CleanRoomsML.AudienceGenerationJobTypes.RelevanceMetric, BaseFunction>>, BaseFunction>? RelevanceMetrics { get; set; }
        }

        public class AudienceSize : Humidifier.Base.BaseSubResource, IHaveType, IHaveValue_Integer
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-audiencegenerationjob-audiencesize.html#cfn-cleanroomsml-audiencegenerationjob-audiencesize-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-audiencegenerationjob-audiencesize.html#cfn-cleanroomsml-audiencegenerationjob-audiencesize-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Value { get; set; }
        }

        public class RelevanceMetric : Humidifier.Base.BaseSubResource, IHaveScore_Double, IHaveCleanRoomsMLAudienceGenerationJobTypesAudienceSizeAudienceSize
        {
            /// <summary>
            /// Score
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-audiencegenerationjob-relevancemetric.html#cfn-cleanroomsml-audiencegenerationjob-relevancemetric-score
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Score { get; set; }
            /// <summary>
            /// AudienceSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-audiencegenerationjob-relevancemetric.html#cfn-cleanroomsml-audiencegenerationjob-relevancemetric-audiencesize
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AudienceSize
            /// </summary>
            public Union<Humidifier.CleanRoomsML.AudienceGenerationJobTypes.AudienceSize, BaseFunction>? AudienceSize { get; set; }
        }
    }
}