namespace Humidifier.CodeBuild
{
    using global::System.Collections.Generic;
    using ReportGroupTypes;

    public class ReportGroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveType, IHaveCodeBuildReportGroupTypesReportExportConfigExportConfig, IHaveDeleteReports_Boolean, IHaveName
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
        public Union<string, BaseFunction>? Type { get; set; }

        /// <summary>
        /// ExportConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-reportgroup.html#cfn-codebuild-reportgroup-exportconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ReportExportConfig
        /// </summary>
        [Required]
        public Union<Humidifier.CodeBuild.ReportGroupTypes.ReportExportConfig, BaseFunction>? ExportConfig { get; set; }
        /// <summary>
        /// DeleteReports
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-reportgroup.html#cfn-codebuild-reportgroup-deletereports
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? DeleteReports { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-reportgroup.html#cfn-codebuild-reportgroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ReportGroupTypes
    {
        public class ReportExportConfig : Humidifier.Base.BaseSubResource, IHaveCodeBuildReportGroupTypesS3ReportExportConfigS3Destination, IHaveExportConfigType
        {
            /// <summary>
            /// S3Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-reportgroup-reportexportconfig.html#cfn-codebuild-reportgroup-reportexportconfig-s3destination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3ReportExportConfig
            /// </summary>
            public Union<Humidifier.CodeBuild.ReportGroupTypes.S3ReportExportConfig, BaseFunction>? S3Destination { get; set; }
            /// <summary>
            /// ExportConfigType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-reportgroup-reportexportconfig.html#cfn-codebuild-reportgroup-reportexportconfig-exportconfigtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExportConfigType { get; set; }
        }

        public class S3ReportExportConfig : Humidifier.Base.BaseSubResource, IHavePath, IHaveBucket, IHavePackaging, IHaveEncryptionKey, IHaveBucketOwner, IHaveEncryptionDisabled_Boolean
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-reportgroup-s3reportexportconfig.html#cfn-codebuild-reportgroup-s3reportexportconfig-path
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Path { get; set; }
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-reportgroup-s3reportexportconfig.html#cfn-codebuild-reportgroup-s3reportexportconfig-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// Packaging
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-reportgroup-s3reportexportconfig.html#cfn-codebuild-reportgroup-s3reportexportconfig-packaging
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Packaging { get; set; }
            /// <summary>
            /// EncryptionKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-reportgroup-s3reportexportconfig.html#cfn-codebuild-reportgroup-s3reportexportconfig-encryptionkey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncryptionKey { get; set; }
            /// <summary>
            /// BucketOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-reportgroup-s3reportexportconfig.html#cfn-codebuild-reportgroup-s3reportexportconfig-bucketowner
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketOwner { get; set; }
            /// <summary>
            /// EncryptionDisabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-reportgroup-s3reportexportconfig.html#cfn-codebuild-reportgroup-s3reportexportconfig-encryptiondisabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EncryptionDisabled { get; set; }
        }
    }
}