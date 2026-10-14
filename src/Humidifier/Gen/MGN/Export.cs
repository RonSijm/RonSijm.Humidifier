namespace Humidifier.MGN
{
    using global::System.Collections.Generic;
    using ExportTypes;

    public class Export : Humidifier.Base.BaseResource, IHaveTags, IHaveS3Bucket, IHaveS3Key
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string ExportID =  "ExportID" ;
            public static string CreationDateTime =  "CreationDateTime" ;
            public static string EndDateTime =  "EndDateTime" ;
            public static string ProgressPercentage =  "ProgressPercentage" ;
            public static string Summary =  "Summary" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.MGN.Export; }
        /// <summary>
        /// S3Bucket
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-export.html#cfn-mgn-export-s3bucket
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic S3Bucket { get; set; }
        /// <summary>
        /// S3Key
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-export.html#cfn-mgn-export-s3key
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic S3Key { get; set; }
        /// <summary>
        /// S3BucketOwner
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-export.html#cfn-mgn-export-s3bucketowner
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic S3BucketOwner { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-export.html#cfn-mgn-export-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace ExportTypes
    {
        public class ExportTaskSummary : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// WavesCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-export-exporttasksummary.html#cfn-mgn-export-exporttasksummary-wavescount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic WavesCount { get; set; }
            /// <summary>
            /// ApplicationsCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-export-exporttasksummary.html#cfn-mgn-export-exporttasksummary-applicationscount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ApplicationsCount { get; set; }
            /// <summary>
            /// ServersCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mgn-export-exporttasksummary.html#cfn-mgn-export-exporttasksummary-serverscount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ServersCount { get; set; }
        }
    }
}