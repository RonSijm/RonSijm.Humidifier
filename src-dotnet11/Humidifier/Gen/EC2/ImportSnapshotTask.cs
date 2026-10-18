namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using ImportSnapshotTaskTypes;

    public class ImportSnapshotTask : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveFormat, IHaveEncrypted_Boolean, IHaveEC2ImportSnapshotTaskTypesUserBucketUserBucket
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string SnapshotId =  "SnapshotId" ;
            public static string ImportTaskId =  "ImportTaskId" ;
            public static string Arn =  "Arn" ;
            public static string DiskImageSize =  "DiskImageSize" ;
        }

        public override string AWSTypeName { get => AWS.EC2.ImportSnapshotTask; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-importsnapshottask.html#cfn-ec2-importsnapshottask-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// Format
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-importsnapshottask.html#cfn-ec2-importsnapshottask-format
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Format { get; set; }
        /// <summary>
        /// Encrypted
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-importsnapshottask.html#cfn-ec2-importsnapshottask-encrypted
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? Encrypted { get; set; }
        /// <summary>
        /// UserBucket
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-importsnapshottask.html#cfn-ec2-importsnapshottask-userbucket
        /// Required: False
        /// UpdateType: Immutable
        /// Type: UserBucket
        /// </summary>
        public Union<Humidifier.EC2.ImportSnapshotTaskTypes.UserBucket, BaseFunction>? UserBucket { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-importsnapshottask.html#cfn-ec2-importsnapshottask-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ImportSnapshotTaskTypes
    {
        public class UserBucket : Humidifier.Base.BaseSubResource, IHaveS3Bucket, IHaveS3Key
        {
            /// <summary>
            /// S3Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-importsnapshottask-userbucket.html#cfn-ec2-importsnapshottask-userbucket-s3bucket
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Bucket { get; set; }
            /// <summary>
            /// S3Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-importsnapshottask-userbucket.html#cfn-ec2-importsnapshottask-userbucket-s3key
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Key { get; set; }
        }
    }
}