namespace Humidifier.Backup
{
    using global::System.Collections.Generic;
    using LogicallyAirGappedBackupVaultTypes;

    public class LogicallyAirGappedBackupVault : Humidifier.Base.BaseResource, IHaveStringDictionaryOfBackupVaultTags, IHaveBackupVaultName, IHaveEncryptionKeyArn, IHaveMaxRetentionDays_Integer, IHaveMinRetentionDays_Integer, IHaveBackupLogicallyAirGappedBackupVaultTypesNotificationObjectTypeNotifications, IHaveMpaApprovalTeamArn, IHaveAccessPolicy_Json
    {
        public class Attributes
        {
            public static string VaultState =  "VaultState" ;
            public static string VaultType =  "VaultType" ;
            public static string BackupVaultArn =  "BackupVaultArn" ;
        }

        public override string AWSTypeName { get => AWS.Backup.LogicallyAirGappedBackupVault; }
        /// <summary>
        /// BackupVaultTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-logicallyairgappedbackupvault.html#cfn-backup-logicallyairgappedbackupvault-backupvaulttags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? BackupVaultTags { get; set; }

        /// <summary>
        /// BackupVaultName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-logicallyairgappedbackupvault.html#cfn-backup-logicallyairgappedbackupvault-backupvaultname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? BackupVaultName { get; set; }
        /// <summary>
        /// EncryptionKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-logicallyairgappedbackupvault.html#cfn-backup-logicallyairgappedbackupvault-encryptionkeyarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EncryptionKeyArn { get; set; }

        /// <summary>
        /// MaxRetentionDays
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-logicallyairgappedbackupvault.html#cfn-backup-logicallyairgappedbackupvault-maxretentiondays
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? MaxRetentionDays { get; set; }

        /// <summary>
        /// MinRetentionDays
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-logicallyairgappedbackupvault.html#cfn-backup-logicallyairgappedbackupvault-minretentiondays
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? MinRetentionDays { get; set; }
        /// <summary>
        /// Notifications
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-logicallyairgappedbackupvault.html#cfn-backup-logicallyairgappedbackupvault-notifications
        /// Required: False
        /// UpdateType: Mutable
        /// Type: NotificationObjectType
        /// </summary>
        public Union<Humidifier.Backup.LogicallyAirGappedBackupVaultTypes.NotificationObjectType, BaseFunction>? Notifications { get; set; }
        /// <summary>
        /// MpaApprovalTeamArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-logicallyairgappedbackupvault.html#cfn-backup-logicallyairgappedbackupvault-mpaapprovalteamarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? MpaApprovalTeamArn { get; set; }
        /// <summary>
        /// AccessPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-logicallyairgappedbackupvault.html#cfn-backup-logicallyairgappedbackupvault-accesspolicy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? AccessPolicy { get; set; }
    }

    namespace LogicallyAirGappedBackupVaultTypes
    {
        public class NotificationObjectType : Humidifier.Base.BaseSubResource, IHaveSNSTopicArn, IHaveStringListOfBackupVaultEvents
        {
            /// <summary>
            /// SNSTopicArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-logicallyairgappedbackupvault-notificationobjecttype.html#cfn-backup-logicallyairgappedbackupvault-notificationobjecttype-snstopicarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SNSTopicArn { get; set; }
            /// <summary>
            /// BackupVaultEvents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-logicallyairgappedbackupvault-notificationobjecttype.html#cfn-backup-logicallyairgappedbackupvault-notificationobjecttype-backupvaultevents
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? BackupVaultEvents { get; set; }
        }
    }
}