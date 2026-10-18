namespace Humidifier.Comprehend
{
    using global::System.Collections.Generic;
    using EntitiesDetectionJobTypes;

    public class EntitiesDetectionJob : Humidifier.Base.BaseResource, IHaveTags, IHaveLanguageCode, IHaveDataAccessRoleArn, IHaveJobName, IHaveComprehendEntitiesDetectionJobTypesInputDataConfigInputDataConfig
    {
        public class Attributes
        {
            public static string JobArn =  "JobArn" ;
            public static string JobStatus =  "JobStatus" ;
            public static string OutputDataConfig =  "OutputDataConfig" ;
            public static string SubmitTime =  "SubmitTime" ;
            public static string JobId =  "JobId" ;
        }

        public override string AWSTypeName { get => AWS.Comprehend.EntitiesDetectionJob; }

        /// <summary>
        /// LanguageCode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-entitiesdetectionjob.html#cfn-comprehend-entitiesdetectionjob-languagecode
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? LanguageCode { get; set; }

        /// <summary>
        /// DataAccessRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-entitiesdetectionjob.html#cfn-comprehend-entitiesdetectionjob-dataaccessrolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DataAccessRoleArn { get; set; }
        /// <summary>
        /// JobName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-entitiesdetectionjob.html#cfn-comprehend-entitiesdetectionjob-jobname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? JobName { get; set; }

        /// <summary>
        /// InputDataConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-entitiesdetectionjob.html#cfn-comprehend-entitiesdetectionjob-inputdataconfig
        /// Required: True
        /// UpdateType: Immutable
        /// Type: InputDataConfig
        /// </summary>
        [Required]
        public Union<Humidifier.Comprehend.EntitiesDetectionJobTypes.InputDataConfig, BaseFunction>? InputDataConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-entitiesdetectionjob.html#cfn-comprehend-entitiesdetectionjob-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace EntitiesDetectionJobTypes
    {
        public class InputDataConfig : Humidifier.Base.BaseSubResource, IHaveS3Uri, IHaveInputFormat
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-entitiesdetectionjob-inputdataconfig.html#cfn-comprehend-entitiesdetectionjob-inputdataconfig-s3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
            /// <summary>
            /// InputFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-entitiesdetectionjob-inputdataconfig.html#cfn-comprehend-entitiesdetectionjob-inputdataconfig-inputformat
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputFormat { get; set; }
        }

        public class OutputDataConfig : Humidifier.Base.BaseSubResource, IHaveS3Uri
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-entitiesdetectionjob-outputdataconfig.html#cfn-comprehend-entitiesdetectionjob-outputdataconfig-s3uri
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
        }
    }
}