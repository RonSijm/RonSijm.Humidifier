namespace Humidifier.Personalize
{
    using global::System.Collections.Generic;
    using DatasetExportJobTypes;

    public class DatasetExportJob : Humidifier.Base.BaseResource, IHaveTags, IHaveRoleArn, IHaveJobName, IHaveDatasetArn
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CreationDateTime =  "CreationDateTime" ;
            public static string DatasetExportJobArn =  "DatasetExportJobArn" ;
            public static string LastUpdatedDateTime =  "LastUpdatedDateTime" ;
        }

        public override string AWSTypeName { get => AWS.Personalize.DatasetExportJob; }

        /// <summary>
        /// DatasetArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-datasetexportjob.html#cfn-personalize-datasetexportjob-datasetarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DatasetArn { get; set; }
        /// <summary>
        /// IngestionMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-datasetexportjob.html#cfn-personalize-datasetexportjob-ingestionmode
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic IngestionMode { get; set; }

        /// <summary>
        /// JobName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-datasetexportjob.html#cfn-personalize-datasetexportjob-jobname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic JobName { get; set; }

        /// <summary>
        /// JobOutput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-datasetexportjob.html#cfn-personalize-datasetexportjob-joboutput
        /// Required: True
        /// UpdateType: Immutable
        /// Type: DatasetExportJobOutput
        /// </summary>
        [Required]
        public Humidifier.Personalize.DatasetExportJobTypes.DatasetExportJobOutput JobOutput { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-datasetexportjob.html#cfn-personalize-datasetexportjob-rolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-datasetexportjob.html#cfn-personalize-datasetexportjob-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace DatasetExportJobTypes
    {
        public class DatasetExportJobOutput : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3DataDestination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-datasetexportjob-datasetexportjoboutput.html#cfn-personalize-datasetexportjob-datasetexportjoboutput-s3datadestination
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3DataConfig
            /// </summary>
            public Humidifier.Personalize.DatasetExportJobTypes.S3DataConfig S3DataDestination { get; set; }
        }

        public class S3DataConfig : Humidifier.Base.BaseSubResource, IHavePath, IHaveKmsKeyArn
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-datasetexportjob-s3dataconfig.html#cfn-personalize-datasetexportjob-s3dataconfig-path
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Path { get; set; }
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-datasetexportjob-s3dataconfig.html#cfn-personalize-datasetexportjob-s3dataconfig-kmskeyarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKeyArn { get; set; }
        }
    }
}