namespace Humidifier.Personalize
{
    using global::System.Collections.Generic;
    using DatasetExportJobTypes;

    public class DatasetExportJob : Humidifier.Base.BaseResource, IHaveTags, IHaveDatasetArn, IHaveIngestionMode, IHaveJobName, IHavePersonalizeDatasetExportJobTypesDatasetExportJobOutputJobOutput, IHaveRoleArn
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
        public Union<string, BaseFunction>? DatasetArn { get; set; }
        /// <summary>
        /// IngestionMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-datasetexportjob.html#cfn-personalize-datasetexportjob-ingestionmode
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? IngestionMode { get; set; }

        /// <summary>
        /// JobName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-datasetexportjob.html#cfn-personalize-datasetexportjob-jobname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? JobName { get; set; }

        /// <summary>
        /// JobOutput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-datasetexportjob.html#cfn-personalize-datasetexportjob-joboutput
        /// Required: True
        /// UpdateType: Immutable
        /// Type: DatasetExportJobOutput
        /// </summary>
        [Required]
        public Union<Humidifier.Personalize.DatasetExportJobTypes.DatasetExportJobOutput, BaseFunction>? JobOutput { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-datasetexportjob.html#cfn-personalize-datasetexportjob-rolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-datasetexportjob.html#cfn-personalize-datasetexportjob-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace DatasetExportJobTypes
    {
        public class DatasetExportJobOutput : Humidifier.Base.BaseSubResource, IHavePersonalizeDatasetExportJobTypesS3DataConfigS3DataDestination
        {
            /// <summary>
            /// S3DataDestination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-datasetexportjob-datasetexportjoboutput.html#cfn-personalize-datasetexportjob-datasetexportjoboutput-s3datadestination
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3DataConfig
            /// </summary>
            public Union<Humidifier.Personalize.DatasetExportJobTypes.S3DataConfig, BaseFunction>? S3DataDestination { get; set; }
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
            public Union<string, BaseFunction>? Path { get; set; }
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-datasetexportjob-s3dataconfig.html#cfn-personalize-datasetexportjob-s3dataconfig-kmskeyarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyArn { get; set; }
        }
    }
}