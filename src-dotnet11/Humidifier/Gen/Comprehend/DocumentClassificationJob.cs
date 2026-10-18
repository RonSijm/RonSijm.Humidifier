namespace Humidifier.Comprehend
{
    using global::System.Collections.Generic;
    using DocumentClassificationJobTypes;

    public class DocumentClassificationJob : Humidifier.Base.BaseResource, IHaveTags, IHaveDataAccessRoleArn, IHaveJobName, IHaveDocumentClassifierArn, IHaveComprehendDocumentClassificationJobTypesInputDataConfigInputDataConfig
    {
        public class Attributes
        {
            public static string JobArn =  "JobArn" ;
            public static string JobStatus =  "JobStatus" ;
            public static string OutputDataConfig =  "OutputDataConfig" ;
            public static string SubmitTime =  "SubmitTime" ;
            public static string JobId =  "JobId" ;
        }

        public override string AWSTypeName { get => AWS.Comprehend.DocumentClassificationJob; }

        /// <summary>
        /// DataAccessRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-documentclassificationjob.html#cfn-comprehend-documentclassificationjob-dataaccessrolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DataAccessRoleArn { get; set; }
        /// <summary>
        /// JobName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-documentclassificationjob.html#cfn-comprehend-documentclassificationjob-jobname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? JobName { get; set; }

        /// <summary>
        /// DocumentClassifierArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-documentclassificationjob.html#cfn-comprehend-documentclassificationjob-documentclassifierarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DocumentClassifierArn { get; set; }

        /// <summary>
        /// InputDataConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-documentclassificationjob.html#cfn-comprehend-documentclassificationjob-inputdataconfig
        /// Required: True
        /// UpdateType: Immutable
        /// Type: InputDataConfig
        /// </summary>
        [Required]
        public Union<Humidifier.Comprehend.DocumentClassificationJobTypes.InputDataConfig, BaseFunction>? InputDataConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-comprehend-documentclassificationjob.html#cfn-comprehend-documentclassificationjob-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace DocumentClassificationJobTypes
    {
        public class InputDataConfig : Humidifier.Base.BaseSubResource, IHaveS3Uri, IHaveInputFormat
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-documentclassificationjob-inputdataconfig.html#cfn-comprehend-documentclassificationjob-inputdataconfig-s3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
            /// <summary>
            /// InputFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-documentclassificationjob-inputdataconfig.html#cfn-comprehend-documentclassificationjob-inputdataconfig-inputformat
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-comprehend-documentclassificationjob-outputdataconfig.html#cfn-comprehend-documentclassificationjob-outputdataconfig-s3uri
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
        }
    }
}