namespace Humidifier.S3Files
{
    using global::System.Collections.Generic;
    using FileSystemTypes;

    public class FileSystem : Humidifier.Base.BaseResource, IHaveTags, IHaveRoleArn, IHaveKmsKeyId, IHavePrefix, IHaveBucket, IHaveClientToken
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
        public dynamic AcceptBucketWarning { get; set; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3files-filesystem.html#cfn-s3files-filesystem-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KmsKeyId { get; set; }

        /// <summary>
        /// Bucket
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3files-filesystem.html#cfn-s3files-filesystem-bucket
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Bucket { get; set; }
        /// <summary>
        /// SynchronizationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3files-filesystem.html#cfn-s3files-filesystem-synchronizationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SynchronizationConfiguration
        /// </summary>
        public Humidifier.S3Files.FileSystemTypes.SynchronizationConfiguration SynchronizationConfiguration { get; set; }
        /// <summary>
        /// Prefix
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3files-filesystem.html#cfn-s3files-filesystem-prefix
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Prefix { get; set; }
        /// <summary>
        /// ClientToken
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3files-filesystem.html#cfn-s3files-filesystem-clienttoken
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ClientToken { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3files-filesystem.html#cfn-s3files-filesystem-rolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3files-filesystem.html#cfn-s3files-filesystem-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace FileSystemTypes
    {
        public class ExpirationDataRule : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DaysAfterLastAccess
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3files-filesystem-expirationdatarule.html#cfn-s3files-filesystem-expirationdatarule-daysafterlastaccess
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DaysAfterLastAccess { get; set; }
        }

        public class ImportDataRule : Humidifier.Base.BaseSubResource, IHavePrefix, IHaveTrigger
        {
            /// <summary>
            /// Trigger
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3files-filesystem-importdatarule.html#cfn-s3files-filesystem-importdatarule-trigger
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Trigger { get; set; }
            /// <summary>
            /// SizeLessThan
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3files-filesystem-importdatarule.html#cfn-s3files-filesystem-importdatarule-sizelessthan
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Long
            /// </summary>
            public dynamic SizeLessThan { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3files-filesystem-importdatarule.html#cfn-s3files-filesystem-importdatarule-prefix
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix { get; set; }
        }

        public class SynchronizationConfiguration : Humidifier.Base.BaseSubResource, IHaveLatestVersionNumber
        {
            /// <summary>
            /// ImportDataRules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3files-filesystem-synchronizationconfiguration.html#cfn-s3files-filesystem-synchronizationconfiguration-importdatarules
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ImportDataRule
            /// </summary>
            public List<Humidifier.S3Files.FileSystemTypes.ImportDataRule> ImportDataRules { get; set; }
            /// <summary>
            /// LatestVersionNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3files-filesystem-synchronizationconfiguration.html#cfn-s3files-filesystem-synchronizationconfiguration-latestversionnumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic LatestVersionNumber { get; set; }
            /// <summary>
            /// ExpirationDataRules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3files-filesystem-synchronizationconfiguration.html#cfn-s3files-filesystem-synchronizationconfiguration-expirationdatarules
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ExpirationDataRule
            /// </summary>
            public List<Humidifier.S3Files.FileSystemTypes.ExpirationDataRule> ExpirationDataRules { get; set; }
        }
    }
}