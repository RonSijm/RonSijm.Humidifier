namespace Humidifier.S3Files
{
    using global::System.Collections.Generic;
    using FileSystemTypes;

    public class FileSystem : Humidifier.Base.BaseResource, IHaveTags, IHaveAcceptBucketWarning_Boolean, IHaveKmsKeyId, IHaveBucket, IHaveS3FilesFileSystemTypesSynchronizationConfigurationSynchronizationConfiguration, IHavePrefix, IHaveClientToken, IHaveRoleArn
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string OwnerId =  "OwnerId" ;
            public static string FileSystemArn =  "FileSystemArn" ;
            public static string CreationTime =  "CreationTime" ;
            public static string FileSystemId =  "FileSystemId" ;
            public static string StatusMessage =  "StatusMessage" ;
        }

        public override string AWSTypeName { get => AWS.S3Files.FileSystem; }
        /// <summary>
        /// AcceptBucketWarning
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3files-filesystem.html#cfn-s3files-filesystem-acceptbucketwarning
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? AcceptBucketWarning { get; set; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3files-filesystem.html#cfn-s3files-filesystem-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyId { get; set; }

        /// <summary>
        /// Bucket
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3files-filesystem.html#cfn-s3files-filesystem-bucket
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Bucket { get; set; }
        /// <summary>
        /// SynchronizationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3files-filesystem.html#cfn-s3files-filesystem-synchronizationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SynchronizationConfiguration
        /// </summary>
        public Union<Humidifier.S3Files.FileSystemTypes.SynchronizationConfiguration, BaseFunction>? SynchronizationConfiguration { get; set; }
        /// <summary>
        /// Prefix
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3files-filesystem.html#cfn-s3files-filesystem-prefix
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Prefix { get; set; }
        /// <summary>
        /// ClientToken
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3files-filesystem.html#cfn-s3files-filesystem-clienttoken
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ClientToken { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3files-filesystem.html#cfn-s3files-filesystem-rolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3files-filesystem.html#cfn-s3files-filesystem-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace FileSystemTypes
    {
        public class ExpirationDataRule : Humidifier.Base.BaseSubResource, IHaveDaysAfterLastAccess_Integer
        {
            /// <summary>
            /// DaysAfterLastAccess
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3files-filesystem-expirationdatarule.html#cfn-s3files-filesystem-expirationdatarule-daysafterlastaccess
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DaysAfterLastAccess { get; set; }
        }

        public class ImportDataRule : Humidifier.Base.BaseSubResource, IHaveTrigger, IHaveSizeLessThan_Long, IHavePrefix
        {
            /// <summary>
            /// Trigger
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3files-filesystem-importdatarule.html#cfn-s3files-filesystem-importdatarule-trigger
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Trigger { get; set; }
            /// <summary>
            /// SizeLessThan
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3files-filesystem-importdatarule.html#cfn-s3files-filesystem-importdatarule-sizelessthan
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Long
            /// </summary>
            public Union<long, BaseFunction>? SizeLessThan { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3files-filesystem-importdatarule.html#cfn-s3files-filesystem-importdatarule-prefix
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Prefix { get; set; }
        }

        public class SynchronizationConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfS3FilesFileSystemTypesImportDataRuleImportDataRules, IHaveLatestVersionNumber_Integer, IHaveListOfS3FilesFileSystemTypesExpirationDataRuleExpirationDataRules
        {
            /// <summary>
            /// ImportDataRules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3files-filesystem-synchronizationconfiguration.html#cfn-s3files-filesystem-synchronizationconfiguration-importdatarules
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ImportDataRule
            /// </summary>
            public Union<IReadOnlyList<Humidifier.S3Files.FileSystemTypes.ImportDataRule>, IReadOnlyList<Union<Humidifier.S3Files.FileSystemTypes.ImportDataRule, BaseFunction>>, BaseFunction>? ImportDataRules { get; set; }
            /// <summary>
            /// LatestVersionNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3files-filesystem-synchronizationconfiguration.html#cfn-s3files-filesystem-synchronizationconfiguration-latestversionnumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? LatestVersionNumber { get; set; }
            /// <summary>
            /// ExpirationDataRules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3files-filesystem-synchronizationconfiguration.html#cfn-s3files-filesystem-synchronizationconfiguration-expirationdatarules
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ExpirationDataRule
            /// </summary>
            public Union<IReadOnlyList<Humidifier.S3Files.FileSystemTypes.ExpirationDataRule>, IReadOnlyList<Union<Humidifier.S3Files.FileSystemTypes.ExpirationDataRule, BaseFunction>>, BaseFunction>? ExpirationDataRules { get; set; }
        }
    }
}