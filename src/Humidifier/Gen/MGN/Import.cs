namespace Humidifier.MGN
{
    using global::System.Collections.Generic;
    using ImportTypes;

    public class Import : Humidifier.Base.BaseResource, IHaveTags
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
        public Humidifier.MGN.ImportTypes.S3BucketSource S3BucketSource { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-import.html#cfn-mgn-import-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace ImportTypes
    {
        public class ImportTaskSummary : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Applications
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-import-importtasksummary.html#cfn-mgn-import-importtasksummary-applications
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ImportTaskSummaryCategory
            /// </summary>
            public Humidifier.MGN.ImportTypes.ImportTaskSummaryCategory Applications { get; set; }
            /// <summary>
            /// Servers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-import-importtasksummary.html#cfn-mgn-import-importtasksummary-servers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ImportTaskSummaryCategory
            /// </summary>
            public Humidifier.MGN.ImportTypes.ImportTaskSummaryCategory Servers { get; set; }
            /// <summary>
            /// Waves
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-import-importtasksummary.html#cfn-mgn-import-importtasksummary-waves
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ImportTaskSummaryCategory
            /// </summary>
            public Humidifier.MGN.ImportTypes.ImportTaskSummaryCategory Waves { get; set; }
        }

        public class ImportTaskSummaryCategory : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ModifiedCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-import-importtasksummarycategory.html#cfn-mgn-import-importtasksummarycategory-modifiedcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ModifiedCount { get; set; }
            /// <summary>
            /// CreatedCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-import-importtasksummarycategory.html#cfn-mgn-import-importtasksummarycategory-createdcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic CreatedCount { get; set; }
        }

        public class S3BucketSource : Humidifier.Base.BaseSubResource, IHaveS3Bucket, IHaveS3Key
        {
            /// <summary>
            /// S3Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-import-s3bucketsource.html#cfn-mgn-import-s3bucketsource-s3bucket
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3Bucket { get; set; }
            /// <summary>
            /// S3Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-import-s3bucketsource.html#cfn-mgn-import-s3bucketsource-s3key
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3Key { get; set; }
            /// <summary>
            /// S3BucketOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-import-s3bucketsource.html#cfn-mgn-import-s3bucketsource-s3bucketowner
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3BucketOwner { get; set; }
        }
    }
}