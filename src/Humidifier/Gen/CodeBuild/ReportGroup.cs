namespace Humidifier.CodeBuild
{
    using System.Collections.Generic;
    using ReportGroupTypes;

    public class ReportGroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveType
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.CodeBuild.ReportGroup; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-reportgroup.html#cfn-codebuild-reportgroup-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Type { get; set; }

        /// <summary>
        /// ExportConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-reportgroup.html#cfn-codebuild-reportgroup-exportconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ReportExportConfig
        /// </summary>
        [Required]
        public Humidifier.CodeBuild.ReportGroupTypes.ReportExportConfig ExportConfig { get; set; }
        /// <summary>
        /// DeleteReports
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-reportgroup.html#cfn-codebuild-reportgroup-deletereports
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic DeleteReports { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-reportgroup.html#cfn-codebuild-reportgroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace ReportGroupTypes
    {
        public class ReportExportConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-reportgroup-reportexportconfig.html#cfn-codebuild-reportgroup-reportexportconfig-s3destination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3ReportExportConfig
            /// </summary>
            public Humidifier.CodeBuild.ReportGroupTypes.S3ReportExportConfig S3Destination { get; set; }
            /// <summary>
            /// ExportConfigType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-reportgroup-reportexportconfig.html#cfn-codebuild-reportgroup-reportexportconfig-exportconfigtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExportConfigType { get; set; }
        }

        public class S3ReportExportConfig : Humidifier.Base.BaseSubResource, IHaveBucket, IHavePath, IHaveEncryptionKey, IHaveBucketOwner, IHaveEncryptionDisabled, IHavePackaging
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-reportgroup-s3reportexportconfig.html#cfn-codebuild-reportgroup-s3reportexportconfig-path
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Path { get; set; }
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-reportgroup-s3reportexportconfig.html#cfn-codebuild-reportgroup-s3reportexportconfig-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Bucket { get; set; }
            /// <summary>
            /// Packaging
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-reportgroup-s3reportexportconfig.html#cfn-codebuild-reportgroup-s3reportexportconfig-packaging
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Packaging { get; set; }
            /// <summary>
            /// EncryptionKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-reportgroup-s3reportexportconfig.html#cfn-codebuild-reportgroup-s3reportexportconfig-encryptionkey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EncryptionKey { get; set; }
            /// <summary>
            /// BucketOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-reportgroup-s3reportexportconfig.html#cfn-codebuild-reportgroup-s3reportexportconfig-bucketowner
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketOwner { get; set; }
            /// <summary>
            /// EncryptionDisabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-reportgroup-s3reportexportconfig.html#cfn-codebuild-reportgroup-s3reportexportconfig-encryptiondisabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EncryptionDisabled { get; set; }
        }
    }
}