namespace Humidifier.Backup
{
    using System.Collections.Generic;
    using LogicallyAirGappedBackupVaultTypes;

    public class LogicallyAirGappedBackupVault : Humidifier.Base.BaseResource, IHaveBackupVaultName, IHaveAccessPolicy, IHaveMaxRetentionDays, IHaveMinRetentionDays
    {
        public class Attributes
        {
            public static string BackupVaultArn =  "BackupVaultArn" ;
            public static string EncryptionKeyArn =  "EncryptionKeyArn" ;
        }

        public override string AWSTypeName { get => AWS.Backup.LogicallyAirGappedBackupVault; }
        /// <summary>
        /// VaultState
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-logicallyairgappedbackupvault.html#cfn-backup-logicallyairgappedbackupvault-vaultstate
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic VaultState { get; set; }
        /// <summary>
        /// BackupVaultTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-logicallyairgappedbackupvault.html#cfn-backup-logicallyairgappedbackupvault-backupvaulttags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> BackupVaultTags { get; set; }
        /// <summary>
        /// VaultType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-logicallyairgappedbackupvault.html#cfn-backup-logicallyairgappedbackupvault-vaulttype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic VaultType { get; set; }

        /// <summary>
        /// BackupVaultName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-logicallyairgappedbackupvault.html#cfn-backup-logicallyairgappedbackupvault-backupvaultname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic BackupVaultName { get; set; }

        /// <summary>
        /// MaxRetentionDays
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-logicallyairgappedbackupvault.html#cfn-backup-logicallyairgappedbackupvault-maxretentiondays
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public dynamic MaxRetentionDays { get; set; }

        /// <summary>
        /// MinRetentionDays
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-logicallyairgappedbackupvault.html#cfn-backup-logicallyairgappedbackupvault-minretentiondays
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public dynamic MinRetentionDays { get; set; }
        /// <summary>
        /// Notifications
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-logicallyairgappedbackupvault.html#cfn-backup-logicallyairgappedbackupvault-notifications
        /// Required: False
        /// UpdateType: Mutable
        /// Type: NotificationObjectType
        /// </summary>
        public Humidifier.Backup.LogicallyAirGappedBackupVaultTypes.NotificationObjectType Notifications { get; set; }
        /// <summary>
        /// AccessPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-logicallyairgappedbackupvault.html#cfn-backup-logicallyairgappedbackupvault-accesspolicy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic AccessPolicy { get; set; }
    }

    namespace LogicallyAirGappedBackupVaultTypes
    {
        public class NotificationObjectType : Humidifier.Base.BaseSubResource, IHaveSNSTopicArn, IHaveBackupVaultEvents
        {
            /// <summary>
            /// SNSTopicArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-logicallyairgappedbackupvault-notificationobjecttype.html#cfn-backup-logicallyairgappedbackupvault-notificationobjecttype-snstopicarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SNSTopicArn { get; set; }
            /// <summary>
            /// BackupVaultEvents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-logicallyairgappedbackupvault-notificationobjecttype.html#cfn-backup-logicallyairgappedbackupvault-notificationobjecttype-backupvaultevents
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic BackupVaultEvents { get; set; }
        }
    }
}