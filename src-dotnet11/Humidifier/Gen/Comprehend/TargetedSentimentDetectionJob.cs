namespace Humidifier.Comprehend
{
    using global::System.Collections.Generic;
    using TargetedSentimentDetectionJobTypes;

    public class TargetedSentimentDetectionJob : Humidifier.Base.BaseResource, IHaveLanguageCode, IHaveDataAccessRoleArn, IHaveJobName, IHaveVolumeKmsKeyId, IHaveComprehendTargetedSentimentDetectionJobTypesInputDataConfigInputDataConfig, IHaveListOfComprehendTargetedSentimentDetectionJobTypesTagsItemsTags
    {
        public class Attributes
        {
            public static string JobArn =  "JobArn" ;
            public static string JobStatus =  "JobStatus" ;
            public static string EndTime =  "EndTime" ;
            public static string OutputDataConfig =  "OutputDataConfig" ;
            public static string SubmitTime =  "SubmitTime" ;
            public static string JobId =  "JobId" ;
        }

        public override string AWSTypeName { get => AWS.Comprehend.TargetedSentimentDetectionJob; }

        /// <summary>
        /// LanguageCode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-targetedsentimentdetectionjob.html#cfn-comprehend-targetedsentimentdetectionjob-languagecode
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? LanguageCode { get; set; }

        /// <summary>
        /// DataAccessRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-targetedsentimentdetectionjob.html#cfn-comprehend-targetedsentimentdetectionjob-dataaccessrolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DataAccessRoleArn { get; set; }
        /// <summary>
        /// JobName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-targetedsentimentdetectionjob.html#cfn-comprehend-targetedsentimentdetectionjob-jobname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? JobName { get; set; }
        /// <summary>
        /// VolumeKmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-targetedsentimentdetectionjob.html#cfn-comprehend-targetedsentimentdetectionjob-volumekmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VolumeKmsKeyId { get; set; }

        /// <summary>
        /// InputDataConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-targetedsentimentdetectionjob.html#cfn-comprehend-targetedsentimentdetectionjob-inputdataconfig
        /// Required: True
        /// UpdateType: Immutable
        /// Type: InputDataConfig
        /// </summary>
        [Required]
        public Union<Humidifier.Comprehend.TargetedSentimentDetectionJobTypes.InputDataConfig, BaseFunction>? InputDataConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-targetedsentimentdetectionjob.html#cfn-comprehend-targetedsentimentdetectionjob-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: TagsItems
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Comprehend.TargetedSentimentDetectionJobTypes.TagsItems>, IReadOnlyList<Union<Humidifier.Comprehend.TargetedSentimentDetectionJobTypes.TagsItems, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace TargetedSentimentDetectionJobTypes
    {
        public class InputDataConfig : Humidifier.Base.BaseSubResource, IHaveS3Uri, IHaveInputFormat
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-targetedsentimentdetectionjob-inputdataconfig.html#cfn-comprehend-targetedsentimentdetectionjob-inputdataconfig-s3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
            /// <summary>
            /// InputFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-targetedsentimentdetectionjob-inputdataconfig.html#cfn-comprehend-targetedsentimentdetectionjob-inputdataconfig-inputformat
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputFormat { get; set; }
        }

        public class OutputDataConfig : Humidifier.Base.BaseSubResource, IHaveKmsKeyId, IHaveS3Uri
        {
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-targetedsentimentdetectionjob-outputdataconfig.html#cfn-comprehend-targetedsentimentdetectionjob-outputdataconfig-kmskeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-targetedsentimentdetectionjob-outputdataconfig.html#cfn-comprehend-targetedsentimentdetectionjob-outputdataconfig-s3uri
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
        }

        public class TagsItems : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-targetedsentimentdetectionjob-tagsitems.html#cfn-comprehend-targetedsentimentdetectionjob-tagsitems-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-targetedsentimentdetectionjob-tagsitems.html#cfn-comprehend-targetedsentimentdetectionjob-tagsitems-key
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}