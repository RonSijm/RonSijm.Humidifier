namespace Humidifier.Comprehend
{
    using global::System.Collections.Generic;
    using DominantLanguageDetectionJobTypes;

    public class DominantLanguageDetectionJob : Humidifier.Base.BaseResource, IHaveTags, IHaveDataAccessRoleArn, IHaveJobName, IHaveVolumeKmsKeyId, IHaveComprehendDominantLanguageDetectionJobTypesInputDataConfigInputDataConfig
    {
        public class Attributes
        {
            public static string JobArn =  "JobArn" ;
            public static string JobStatus =  "JobStatus" ;
            public static string OutputDataConfig =  "OutputDataConfig" ;
            public static string JobId =  "JobId" ;
        }

        public override string AWSTypeName { get => AWS.Comprehend.DominantLanguageDetectionJob; }
        /// <summary>
        /// DataAccessRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-dominantlanguagedetectionjob.html#cfn-comprehend-dominantlanguagedetectionjob-dataaccessrolearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DataAccessRoleArn { get; set; }
        /// <summary>
        /// JobName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-dominantlanguagedetectionjob.html#cfn-comprehend-dominantlanguagedetectionjob-jobname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? JobName { get; set; }
        /// <summary>
        /// VolumeKmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-dominantlanguagedetectionjob.html#cfn-comprehend-dominantlanguagedetectionjob-volumekmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VolumeKmsKeyId { get; set; }
        /// <summary>
        /// InputDataConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-dominantlanguagedetectionjob.html#cfn-comprehend-dominantlanguagedetectionjob-inputdataconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: InputDataConfig
        /// </summary>
        public Union<Humidifier.Comprehend.DominantLanguageDetectionJobTypes.InputDataConfig, BaseFunction>? InputDataConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-dominantlanguagedetectionjob.html#cfn-comprehend-dominantlanguagedetectionjob-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace DominantLanguageDetectionJobTypes
    {
        public class InputDataConfig : Humidifier.Base.BaseSubResource, IHaveS3Uri, IHaveInputFormat
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-dominantlanguagedetectionjob-inputdataconfig.html#cfn-comprehend-dominantlanguagedetectionjob-inputdataconfig-s3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
            /// <summary>
            /// InputFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-dominantlanguagedetectionjob-inputdataconfig.html#cfn-comprehend-dominantlanguagedetectionjob-inputdataconfig-inputformat
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-dominantlanguagedetectionjob-outputdataconfig.html#cfn-comprehend-dominantlanguagedetectionjob-outputdataconfig-kmskeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-dominantlanguagedetectionjob-outputdataconfig.html#cfn-comprehend-dominantlanguagedetectionjob-outputdataconfig-s3uri
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
        }
    }
}