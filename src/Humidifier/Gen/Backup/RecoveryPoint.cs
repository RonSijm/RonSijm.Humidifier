namespace Humidifier.Backup
{
    using global::System.Collections.Generic;
    using RecoveryPointTypes;

    public class RecoveryPoint : Humidifier.Base.BaseResource, IHaveBackupVaultName
    {
        public class Attributes
        {
            public static string CreationDate =  "CreationDate" ;
            public static string BackupVaultArn =  "BackupVaultArn" ;
            public static string ResourceName =  "ResourceName" ;
            public static string IsEncrypted =  "IsEncrypted" ;
            public static string InitiationDate =  "InitiationDate" ;
            public static string ParentRecoveryPointArn =  "ParentRecoveryPointArn" ;
            public static string IamRoleArn =  "IamRoleArn" ;
            public static string CompletionDate =  "CompletionDate" ;
            public static string Status =  "Status" ;
            public static string CompositeMemberIdentifier =  "CompositeMemberIdentifier" ;
            public static string BackupSizeInBytes =  "BackupSizeInBytes" ;
            public static string EncryptionKeyArn =  "EncryptionKeyArn" ;
            public static string StorageClass =  "StorageClass" ;
            public static string IsParent =  "IsParent" ;
            public static string Lifecycle =  "Lifecycle" ;
            public static string RecoveryPointArn =  "RecoveryPointArn" ;
            public static string CalculatedLifecycle =  "CalculatedLifecycle" ;
            public static string ResourceType =  "ResourceType" ;
            public static string ResourceArn =  "ResourceArn" ;
            public static string VaultType =  "VaultType" ;
            public static string LastRestoreTime =  "LastRestoreTime" ;
            public static string SourceBackupVaultArn =  "SourceBackupVaultArn" ;
        }

        public override string AWSTypeName { get => AWS.Backup.RecoveryPoint; }
        /// <summary>
        /// BackupVaultName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-recoverypoint.html#cfn-backup-recoverypoint-backupvaultname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic BackupVaultName { get; set; }
    }

    namespace RecoveryPointTypes
    {
        public class CalculatedLifecycle : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MoveToColdStorageAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-recoverypoint-calculatedlifecycle.html#cfn-backup-recoverypoint-calculatedlifecycle-movetocoldstorageat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MoveToColdStorageAt { get; set; }
            /// <summary>
            /// DeleteAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-recoverypoint-calculatedlifecycle.html#cfn-backup-recoverypoint-calculatedlifecycle-deleteat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DeleteAt { get; set; }
        }

        public class Lifecycle : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// OptInToArchiveForSupportedResources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-recoverypoint-lifecycle.html#cfn-backup-recoverypoint-lifecycle-optintoarchiveforsupportedresources
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic OptInToArchiveForSupportedResources { get; set; }
            /// <summary>
            /// DeleteAfterDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-recoverypoint-lifecycle.html#cfn-backup-recoverypoint-lifecycle-deleteafterdays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic DeleteAfterDays { get; set; }
            /// <summary>
            /// DeleteAfterEvent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-recoverypoint-lifecycle.html#cfn-backup-recoverypoint-lifecycle-deleteafterevent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DeleteAfterEvent { get; set; }
            /// <summary>
            /// MoveToColdStorageAfterDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-recoverypoint-lifecycle.html#cfn-backup-recoverypoint-lifecycle-movetocoldstorageafterdays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MoveToColdStorageAfterDays { get; set; }
        }
    }
}