namespace Humidifier.Backup
{
    using global::System.Collections.Generic;
    using BackupAccessPointTypes;

    public class BackupAccessPoint : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags
    {
        public class Attributes
        {
            public static string AccessPointMetadata =  "AccessPointMetadata" ;
            public static string Status =  "Status" ;
            public static string ResourceArn =  "ResourceArn" ;
            public static string BackupVaultArn =  "BackupVaultArn" ;
            public static string BackupVaultName =  "BackupVaultName" ;
            public static string CreationTime =  "CreationTime" ;
            public static string ResourceType =  "ResourceType" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Backup.BackupAccessPoint; }
        /// <summary>
        /// AccessPointInTime
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-backupaccesspoint.html#cfn-backup-backupaccesspoint-accesspointintime
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AccessPointInTime { get; set; }

        /// <summary>
        /// RecoveryPointArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-backupaccesspoint.html#cfn-backup-backupaccesspoint-recoverypointarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RecoveryPointArn { get; set; }
        /// <summary>
        /// AccessPointPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-backupaccesspoint.html#cfn-backup-backupaccesspoint-accesspointpolicy
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic AccessPointPolicy { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-backupaccesspoint.html#cfn-backup-backupaccesspoint-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace BackupAccessPointTypes
    {
        public class AccessPointMetadata : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AccessPointInTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupaccesspoint-accesspointmetadata.html#cfn-backup-backupaccesspoint-accesspointmetadata-accesspointintime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AccessPointInTime { get; set; }
            /// <summary>
            /// S3AccessPointArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupaccesspoint-accesspointmetadata.html#cfn-backup-backupaccesspoint-accesspointmetadata-s3accesspointarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3AccessPointArn { get; set; }
            /// <summary>
            /// S3AccessPointAlias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupaccesspoint-accesspointmetadata.html#cfn-backup-backupaccesspoint-accesspointmetadata-s3accesspointalias
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3AccessPointAlias { get; set; }
        }
    }
}