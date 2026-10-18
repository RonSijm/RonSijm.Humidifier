namespace Humidifier.MGN
{
    using global::System.Collections.Generic;
    using ImportTypes;

    public class Import : Humidifier.Base.BaseResource, IHaveTags, IHaveMGNImportTypesS3BucketSourceS3BucketSource
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string ProgressPercentage =  "ProgressPercentage" ;
            public static string ImportID =  "ImportID" ;
            public static string CreationDateTime =  "CreationDateTime" ;
            public static string EndDateTime =  "EndDateTime" ;
            public static string Summary =  "Summary" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.MGN.Import; }

        /// <summary>
        /// S3BucketSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-import.html#cfn-mgn-import-s3bucketsource
        /// Required: True
        /// UpdateType: Immutable
        /// Type: S3BucketSource
        /// </summary>
        [Required]
        public Union<Humidifier.MGN.ImportTypes.S3BucketSource, BaseFunction>? S3BucketSource { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-import.html#cfn-mgn-import-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ImportTypes
    {
        public class ImportTaskSummary : Humidifier.Base.BaseSubResource, IHaveMGNImportTypesImportTaskSummaryCategoryApplications, IHaveMGNImportTypesImportTaskSummaryCategoryServers, IHaveMGNImportTypesImportTaskSummaryCategoryWaves
        {
            /// <summary>
            /// Applications
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-import-importtasksummary.html#cfn-mgn-import-importtasksummary-applications
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ImportTaskSummaryCategory
            /// </summary>
            public Union<Humidifier.MGN.ImportTypes.ImportTaskSummaryCategory, BaseFunction>? Applications { get; set; }
            /// <summary>
            /// Servers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-import-importtasksummary.html#cfn-mgn-import-importtasksummary-servers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ImportTaskSummaryCategory
            /// </summary>
            public Union<Humidifier.MGN.ImportTypes.ImportTaskSummaryCategory, BaseFunction>? Servers { get; set; }
            /// <summary>
            /// Waves
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-import-importtasksummary.html#cfn-mgn-import-importtasksummary-waves
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ImportTaskSummaryCategory
            /// </summary>
            public Union<Humidifier.MGN.ImportTypes.ImportTaskSummaryCategory, BaseFunction>? Waves { get; set; }
        }

        public class ImportTaskSummaryCategory : Humidifier.Base.BaseSubResource, IHaveModifiedCount_Integer, IHaveCreatedCount_Integer
        {
            /// <summary>
            /// ModifiedCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-import-importtasksummarycategory.html#cfn-mgn-import-importtasksummarycategory-modifiedcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ModifiedCount { get; set; }
            /// <summary>
            /// CreatedCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-import-importtasksummarycategory.html#cfn-mgn-import-importtasksummarycategory-createdcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? CreatedCount { get; set; }
        }

        public class S3BucketSource : Humidifier.Base.BaseSubResource, IHaveS3Bucket, IHaveS3Key, IHaveS3BucketOwner
        {
            /// <summary>
            /// S3Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-import-s3bucketsource.html#cfn-mgn-import-s3bucketsource-s3bucket
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Bucket { get; set; }
            /// <summary>
            /// S3Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-import-s3bucketsource.html#cfn-mgn-import-s3bucketsource-s3key
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Key { get; set; }
            /// <summary>
            /// S3BucketOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-import-s3bucketsource.html#cfn-mgn-import-s3bucketsource-s3bucketowner
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3BucketOwner { get; set; }
        }
    }
}