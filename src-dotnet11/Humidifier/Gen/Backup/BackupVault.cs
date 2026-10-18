namespace Humidifier.Backup
{
    using global::System.Collections.Generic;
    using BackupVaultTypes;

    public class BackupVault : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveStringDictionaryOfBackupVaultTags, IHaveBackupVaultName, IHaveEncryptionKeyArn, IHaveBackupBackupVaultTypesLockConfigurationTypeLockConfiguration, IHaveBackupBackupVaultTypesNotificationObjectTypeNotifications, IHaveAccessPolicy_Json
    {
        public class Attributes
        {
            public static string BackupVaultName =  "BackupVaultName" ;
            public static string BackupVaultArn =  "BackupVaultArn" ;
        }

        public override string AWSTypeName { get => AWS.Backup.BackupVault; }
        /// <summary>
        /// BackupVaultTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-backupvault.html#cfn-backup-backupvault-backupvaulttags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? BackupVaultTags { get; set; }
        public Union<string, BaseFunction>? BackupVaultName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// EncryptionKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-backupvault.html#cfn-backup-backupvault-encryptionkeyarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EncryptionKeyArn { get; set; }
        /// <summary>
        /// LockConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-backupvault.html#cfn-backup-backupvault-lockconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LockConfigurationType
        /// </summary>
        public Union<Humidifier.Backup.BackupVaultTypes.LockConfigurationType, BaseFunction>? LockConfiguration { get; set; }
        /// <summary>
        /// Notifications
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-backupvault.html#cfn-backup-backupvault-notifications
        /// Required: False
        /// UpdateType: Mutable
        /// Type: NotificationObjectType
        /// </summary>
        public Union<Humidifier.Backup.BackupVaultTypes.NotificationObjectType, BaseFunction>? Notifications { get; set; }
        /// <summary>
        /// AccessPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-backupvault.html#cfn-backup-backupvault-accesspolicy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? AccessPolicy { get; set; }
    }

    namespace BackupVaultTypes
    {
        public class LockConfigurationType : Humidifier.Base.BaseSubResource, IHaveChangeableForDays_Integer, IHaveMaxRetentionDays_Integer, IHaveMinRetentionDays_Integer
        {
            /// <summary>
            /// ChangeableForDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupvault-lockconfigurationtype.html#cfn-backup-backupvault-lockconfigurationtype-changeablefordays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ChangeableForDays { get; set; }
            /// <summary>
            /// MaxRetentionDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupvault-lockconfigurationtype.html#cfn-backup-backupvault-lockconfigurationtype-maxretentiondays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxRetentionDays { get; set; }
            /// <summary>
            /// MinRetentionDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupvault-lockconfigurationtype.html#cfn-backup-backupvault-lockconfigurationtype-minretentiondays
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinRetentionDays { get; set; }
        }

        public class NotificationObjectType : Humidifier.Base.BaseSubResource, IHaveSNSTopicArn, IHaveStringListOfBackupVaultEvents
        {
            /// <summary>
            /// SNSTopicArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupvault-notificationobjecttype.html#cfn-backup-backupvault-notificationobjecttype-snstopicarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SNSTopicArn { get; set; }
            /// <summary>
            /// BackupVaultEvents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupvault-notificationobjecttype.html#cfn-backup-backupvault-notificationobjecttype-backupvaultevents
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? BackupVaultEvents { get; set; }
        }
    }
}