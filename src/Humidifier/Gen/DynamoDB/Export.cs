namespace Humidifier.DynamoDB
{
    using global::System.Collections.Generic;

    public class Export : Humidifier.Base.BaseResource, IHaveS3Bucket, IHaveS3Prefix
    {
        public class Attributes
        {
            public static string TableId =  "TableId" ;
            public static string BilledSizeBytes =  "BilledSizeBytes" ;
            public static string TableName =  "TableName" ;
            public static string ExportId =  "ExportId" ;
            public static string EndTime =  "EndTime" ;
            public static string ExportArn =  "ExportArn" ;
            public static string ExportStatus =  "ExportStatus" ;
            public static string ExportTime =  "ExportTime" ;
            public static string StartTime =  "StartTime" ;
            public static string ItemCount =  "ItemCount" ;
            public static string ExportManifest =  "ExportManifest" ;
        }

        public override string AWSTypeName { get => AWS.DynamoDB.Export; }

        /// <summary>
        /// S3Bucket
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-export.html#cfn-dynamodb-export-s3bucket
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic S3Bucket { get; set; }

        /// <summary>
        /// TableArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-export.html#cfn-dynamodb-export-tablearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic TableArn { get; set; }
        /// <summary>
        /// ExportType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-export.html#cfn-dynamodb-export-exporttype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ExportType { get; set; }
        /// <summary>
        /// S3Prefix
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-export.html#cfn-dynamodb-export-s3prefix
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic S3Prefix { get; set; }
        /// <summary>
        /// S3BucketOwner
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-export.html#cfn-dynamodb-export-s3bucketowner
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic S3BucketOwner { get; set; }
        /// <summary>
        /// ExportFormat
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-export.html#cfn-dynamodb-export-exportformat
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ExportFormat { get; set; }
        /// <summary>
        /// S3SseAlgorithm
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-export.html#cfn-dynamodb-export-s3ssealgorithm
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic S3SseAlgorithm { get; set; }
    }
}