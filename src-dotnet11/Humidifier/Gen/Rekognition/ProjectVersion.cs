namespace Humidifier.Rekognition
{
    using global::System.Collections.Generic;
    using ProjectVersionTypes;

    public class ProjectVersion : Humidifier.Base.BaseResource, IHaveProjectArn, IHaveVersionDescription, IHaveRekognitionProjectVersionTypesOutputConfigOutputConfig, IHaveKmsKeyId, IHaveRekognitionProjectVersionTypesCustomizationFeatureConfigFeatureConfig, IHaveVersionName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CreationTimestamp =  "CreationTimestamp" ;
            public static string BillableTrainingTimeInSeconds =  "BillableTrainingTimeInSeconds" ;
            public static string BaseModelVersion =  "BaseModelVersion" ;
            public static string TrainingEndTimestamp =  "TrainingEndTimestamp" ;
            public static string ProjectVersionArn =  "ProjectVersionArn" ;
            public static string Feature =  "Feature" ;
            public static string EvaluationResult =  "EvaluationResult" ;
            public static string Tags =  "Tags" ;
        }

        public override string AWSTypeName { get => AWS.Rekognition.ProjectVersion; }
        /// <summary>
        /// ProjectArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rekognition-projectversion.html#cfn-rekognition-projectversion-projectarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ProjectArn { get; set; }
        /// <summary>
        /// VersionDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rekognition-projectversion.html#cfn-rekognition-projectversion-versiondescription
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VersionDescription { get; set; }
        /// <summary>
        /// OutputConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rekognition-projectversion.html#cfn-rekognition-projectversion-outputconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: OutputConfig
        /// </summary>
        public Union<Humidifier.Rekognition.ProjectVersionTypes.OutputConfig, BaseFunction>? OutputConfig { get; set; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rekognition-projectversion.html#cfn-rekognition-projectversion-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyId { get; set; }
        /// <summary>
        /// FeatureConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rekognition-projectversion.html#cfn-rekognition-projectversion-featureconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: CustomizationFeatureConfig
        /// </summary>
        public Union<Humidifier.Rekognition.ProjectVersionTypes.CustomizationFeatureConfig, BaseFunction>? FeatureConfig { get; set; }
        /// <summary>
        /// VersionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rekognition-projectversion.html#cfn-rekognition-projectversion-versionname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VersionName { get; set; }
    }

    namespace ProjectVersionTypes
    {
        public class ContentModerationConfig : Humidifier.Base.BaseSubResource, IHaveConfidenceThreshold_Double
        {
            /// <summary>
            /// ConfidenceThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rekognition-projectversion-contentmoderationconfig.html#cfn-rekognition-projectversion-contentmoderationconfig-confidencethreshold
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? ConfidenceThreshold { get; set; }
        }

        public class CustomizationFeatureConfig : Humidifier.Base.BaseSubResource, IHaveRekognitionProjectVersionTypesContentModerationConfigContentModeration
        {
            /// <summary>
            /// ContentModeration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rekognition-projectversion-customizationfeatureconfig.html#cfn-rekognition-projectversion-customizationfeatureconfig-contentmoderation
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ContentModerationConfig
            /// </summary>
            public Union<Humidifier.Rekognition.ProjectVersionTypes.ContentModerationConfig, BaseFunction>? ContentModeration { get; set; }
        }

        public class EvaluationResult : Humidifier.Base.BaseSubResource, IHaveF1Score_Double
        {
            /// <summary>
            /// F1Score
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rekognition-projectversion-evaluationresult.html#cfn-rekognition-projectversion-evaluationresult-f1score
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? F1Score { get; set; }
        }

        public class OutputConfig : Humidifier.Base.BaseSubResource, IHaveS3Bucket, IHaveS3KeyPrefix
        {
            /// <summary>
            /// S3Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rekognition-projectversion-outputconfig.html#cfn-rekognition-projectversion-outputconfig-s3bucket
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Bucket { get; set; }
            /// <summary>
            /// S3KeyPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rekognition-projectversion-outputconfig.html#cfn-rekognition-projectversion-outputconfig-s3keyprefix
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3KeyPrefix { get; set; }
        }
    }
}