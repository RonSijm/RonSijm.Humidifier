namespace Humidifier.DataSync
{
    using global::System.Collections.Generic;
    using LocationS3Types;

    public class LocationS3 : Humidifier.Base.BaseResource, IHaveTags, IHaveS3StorageClass, IHaveDataSyncLocationS3TypesS3ConfigS3Config, IHaveSubdirectory, IHaveS3BucketArn
    {
        public class Attributes
        {
            public static string LocationUri =  "LocationUri" ;
            public static string LocationArn =  "LocationArn" ;
        }

        public override string AWSTypeName { get => AWS.DataSync.LocationS3; }
        /// <summary>
        /// S3StorageClass
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locations3.html#cfn-datasync-locations3-s3storageclass
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? S3StorageClass { get; set; }

        /// <summary>
        /// S3Config
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locations3.html#cfn-datasync-locations3-s3config
        /// Required: True
        /// UpdateType: Mutable
        /// Type: S3Config
        /// </summary>
        [Required]
        public Union<Humidifier.DataSync.LocationS3Types.S3Config, BaseFunction>? S3Config { get; set; }
        /// <summary>
        /// Subdirectory
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locations3.html#cfn-datasync-locations3-subdirectory
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Subdirectory { get; set; }
        /// <summary>
        /// S3BucketArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locations3.html#cfn-datasync-locations3-s3bucketarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? S3BucketArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locations3.html#cfn-datasync-locations3-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace LocationS3Types
    {
        public class S3Config : Humidifier.Base.BaseSubResource, IHaveBucketAccessRoleArn
        {
            /// <summary>
            /// BucketAccessRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locations3-s3config.html#cfn-datasync-locations3-s3config-bucketaccessrolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketAccessRoleArn { get; set; }
        }
    }
}