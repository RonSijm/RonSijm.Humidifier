namespace Humidifier.ResilienceHub
{
    using global::System.Collections.Generic;
    using RecommendationTemplateTypes;

    public class RecommendationTemplate : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveFormat, IHaveAssessmentArn, IHaveStringListOfRecommendationTypes, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string AppArn =  "AppArn" ;
            public static string RecommendationTemplateArn =  "RecommendationTemplateArn" ;
            public static string TemplatesLocation =  "TemplatesLocation" ;
        }

        public override string AWSTypeName { get => AWS.ResilienceHub.RecommendationTemplate; }

        /// <summary>
        /// Format
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehub-recommendationtemplate.html#cfn-resiliencehub-recommendationtemplate-format
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Format { get; set; }

        /// <summary>
        /// AssessmentArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehub-recommendationtemplate.html#cfn-resiliencehub-recommendationtemplate-assessmentarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AssessmentArn { get; set; }

        /// <summary>
        /// RecommendationTypes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehub-recommendationtemplate.html#cfn-resiliencehub-recommendationtemplate-recommendationtypes
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? RecommendationTypes { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehub-recommendationtemplate.html#cfn-resiliencehub-recommendationtemplate-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace RecommendationTemplateTypes
    {
        public class S3Location : Humidifier.Base.BaseSubResource, IHaveBucket, IHavePrefix
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-recommendationtemplate-s3location.html#cfn-resiliencehub-recommendationtemplate-s3location-bucket
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-recommendationtemplate-s3location.html#cfn-resiliencehub-recommendationtemplate-s3location-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Prefix { get; set; }
        }
    }
}