namespace Humidifier.ResilienceHub
{
    using global::System.Collections.Generic;
    using RecommendationTemplateTypes;

    public class RecommendationTemplate : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveFormat
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
        public dynamic Format { get; set; }

        /// <summary>
        /// AssessmentArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehub-recommendationtemplate.html#cfn-resiliencehub-recommendationtemplate-assessmentarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AssessmentArn { get; set; }

        /// <summary>
        /// RecommendationTypes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehub-recommendationtemplate.html#cfn-resiliencehub-recommendationtemplate-recommendationtypes
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public dynamic RecommendationTypes { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehub-recommendationtemplate.html#cfn-resiliencehub-recommendationtemplate-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace RecommendationTemplateTypes
    {
        public class S3Location : Humidifier.Base.BaseSubResource, IHavePrefix, IHaveBucket
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-recommendationtemplate-s3location.html#cfn-resiliencehub-recommendationtemplate-s3location-bucket
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Bucket { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-recommendationtemplate-s3location.html#cfn-resiliencehub-recommendationtemplate-s3location-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix { get; set; }
        }
    }
}