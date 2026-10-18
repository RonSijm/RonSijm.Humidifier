namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using ImportImageTaskTypes;

    public class ImportImageTask : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveKmsKeyId, IHaveListOfEC2ImportImageTaskTypesImportImageLicenseConfigurationLicenseSpecifications, IHaveEncrypted_Boolean, IHaveBootMode, IHaveUsageOperation, IHaveLicenseType
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string ImportTaskId =  "ImportTaskId" ;
            public static string ImageId =  "ImageId" ;
            public static string SnapshotDetails =  "SnapshotDetails" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.EC2.ImportImageTask; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-importimagetask.html#cfn-ec2-importimagetask-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-importimagetask.html#cfn-ec2-importimagetask-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyId { get; set; }
        /// <summary>
        /// LicenseSpecifications
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-importimagetask.html#cfn-ec2-importimagetask-licensespecifications
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: ImportImageLicenseConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EC2.ImportImageTaskTypes.ImportImageLicenseConfiguration>, IReadOnlyList<Union<Humidifier.EC2.ImportImageTaskTypes.ImportImageLicenseConfiguration, BaseFunction>>, BaseFunction>? LicenseSpecifications { get; set; }
        /// <summary>
        /// Encrypted
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-importimagetask.html#cfn-ec2-importimagetask-encrypted
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? Encrypted { get; set; }
        /// <summary>
        /// BootMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-importimagetask.html#cfn-ec2-importimagetask-bootmode
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? BootMode { get; set; }
        /// <summary>
        /// UsageOperation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-importimagetask.html#cfn-ec2-importimagetask-usageoperation
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? UsageOperation { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-importimagetask.html#cfn-ec2-importimagetask-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// LicenseType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-importimagetask.html#cfn-ec2-importimagetask-licensetype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LicenseType { get; set; }
    }

    namespace ImportImageTaskTypes
    {
        public class ImportImageLicenseConfiguration : Humidifier.Base.BaseSubResource, IHaveLicenseConfigurationArn
        {
            /// <summary>
            /// LicenseConfigurationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-importimagetask-importimagelicenseconfiguration.html#cfn-ec2-importimagetask-importimagelicenseconfiguration-licenseconfigurationarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LicenseConfigurationArn { get; set; }
        }

        public class SnapshotDetail : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveSnapshotId, IHaveFormat, IHaveEC2ImportImageTaskTypesUserBucketUserBucket, IHaveDiskImageSize_Double
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-importimagetask-snapshotdetail.html#cfn-ec2-importimagetask-snapshotdetail-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// SnapshotId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-importimagetask-snapshotdetail.html#cfn-ec2-importimagetask-snapshotdetail-snapshotid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SnapshotId { get; set; }
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-importimagetask-snapshotdetail.html#cfn-ec2-importimagetask-snapshotdetail-format
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Format { get; set; }
            /// <summary>
            /// UserBucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-importimagetask-snapshotdetail.html#cfn-ec2-importimagetask-snapshotdetail-userbucket
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UserBucket
            /// </summary>
            public Union<Humidifier.EC2.ImportImageTaskTypes.UserBucket, BaseFunction>? UserBucket { get; set; }
            /// <summary>
            /// DiskImageSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-importimagetask-snapshotdetail.html#cfn-ec2-importimagetask-snapshotdetail-diskimagesize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? DiskImageSize { get; set; }
        }

        public class UserBucket : Humidifier.Base.BaseSubResource, IHaveS3Bucket, IHaveS3Key
        {
            /// <summary>
            /// S3Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-importimagetask-userbucket.html#cfn-ec2-importimagetask-userbucket-s3bucket
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Bucket { get; set; }
            /// <summary>
            /// S3Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-importimagetask-userbucket.html#cfn-ec2-importimagetask-userbucket-s3key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Key { get; set; }
        }
    }
}