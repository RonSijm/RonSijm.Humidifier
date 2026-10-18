namespace Humidifier.Backup
{
    using global::System.Collections.Generic;
    using ManagedRecoveryPointTypes;

    public class ManagedRecoveryPoint : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string CreationDate =  "CreationDate" ;
            public static string BackupVaultArn =  "BackupVaultArn" ;
            public static string ResourceName =  "ResourceName" ;
            public static string IsEncrypted =  "IsEncrypted" ;
            public static string InitiationDate =  "InitiationDate" ;
            public static string EncryptionKeyType =  "EncryptionKeyType" ;
            public static string BackupVaultName =  "BackupVaultName" ;
            public static string ParentRecoveryPointArn =  "ParentRecoveryPointArn" ;
            public static string IamRoleArn =  "IamRoleArn" ;
            public static string CompletionDate =  "CompletionDate" ;
            public static string Tags =  "Tags" ;
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

        public override string AWSTypeName { get => AWS.Backup.ManagedRecoveryPoint; }
    }

    namespace ManagedRecoveryPointTypes
    {
        public class CalculatedLifecycle : Humidifier.Base.BaseSubResource, IHaveMoveToColdStorageAt, IHaveDeleteAt
        {
            /// <summary>
            /// MoveToColdStorageAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-managedrecoverypoint-calculatedlifecycle.html#cfn-backup-managedrecoverypoint-calculatedlifecycle-movetocoldstorageat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MoveToColdStorageAt { get; set; }
            /// <summary>
            /// DeleteAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-managedrecoverypoint-calculatedlifecycle.html#cfn-backup-managedrecoverypoint-calculatedlifecycle-deleteat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeleteAt { get; set; }
        }

        public class Lifecycle : Humidifier.Base.BaseSubResource, IHaveOptInToArchiveForSupportedResources_Boolean, IHaveDeleteAfterDays_Double, IHaveDeleteAfterEvent, IHaveMoveToColdStorageAfterDays_Double
        {
            /// <summary>
            /// OptInToArchiveForSupportedResources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-managedrecoverypoint-lifecycle.html#cfn-backup-managedrecoverypoint-lifecycle-optintoarchiveforsupportedresources
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? OptInToArchiveForSupportedResources { get; set; }
            /// <summary>
            /// DeleteAfterDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-managedrecoverypoint-lifecycle.html#cfn-backup-managedrecoverypoint-lifecycle-deleteafterdays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? DeleteAfterDays { get; set; }
            /// <summary>
            /// DeleteAfterEvent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-managedrecoverypoint-lifecycle.html#cfn-backup-managedrecoverypoint-lifecycle-deleteafterevent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeleteAfterEvent { get; set; }
            /// <summary>
            /// MoveToColdStorageAfterDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-managedrecoverypoint-lifecycle.html#cfn-backup-managedrecoverypoint-lifecycle-movetocoldstorageafterdays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MoveToColdStorageAfterDays { get; set; }
        }
    }
}