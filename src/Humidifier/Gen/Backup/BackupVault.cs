namespace Humidifier.Backup
{
    using System.Collections.Generic;
    using BackupVaultTypes;

    public class BackupVault : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveEncryptionKeyArn, IHaveBackupVaultName, IHaveAccessPolicy
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
        public Dictionary<string, dynamic> BackupVaultTags { get; set; }
        public dynamic BackupVaultName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// EncryptionKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-backupvault.html#cfn-backup-backupvault-encryptionkeyarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic EncryptionKeyArn { get; set; }
        /// <summary>
        /// LockConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-backupvault.html#cfn-backup-backupvault-lockconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LockConfigurationType
        /// </summary>
        public Humidifier.Backup.BackupVaultTypes.LockConfigurationType LockConfiguration { get; set; }
        /// <summary>
        /// Notifications
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-backupvault.html#cfn-backup-backupvault-notifications
        /// Required: False
        /// UpdateType: Mutable
        /// Type: NotificationObjectType
        /// </summary>
        public Humidifier.Backup.BackupVaultTypes.NotificationObjectType Notifications { get; set; }
        /// <summary>
        /// AccessPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-backupvault.html#cfn-backup-backupvault-accesspolicy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic AccessPolicy { get; set; }
    }

    namespace BackupVaultTypes
    {
        public class LockConfigurationType : Humidifier.Base.BaseSubResource, IHaveMaxRetentionDays, IHaveMinRetentionDays
        {
            /// <summary>
            /// ChangeableForDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupvault-lockconfigurationtype.html#cfn-backup-backupvault-lockconfigurationtype-changeablefordays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ChangeableForDays { get; set; }
            /// <summary>
            /// MaxRetentionDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupvault-lockconfigurationtype.html#cfn-backup-backupvault-lockconfigurationtype-maxretentiondays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxRetentionDays { get; set; }
            /// <summary>
            /// MinRetentionDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupvault-lockconfigurationtype.html#cfn-backup-backupvault-lockconfigurationtype-minretentiondays
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinRetentionDays { get; set; }
        }

        public class NotificationObjectType : Humidifier.Base.BaseSubResource, IHaveSNSTopicArn, IHaveBackupVaultEvents
        {
            /// <summary>
            /// SNSTopicArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupvault-notificationobjecttype.html#cfn-backup-backupvault-notificationobjecttype-snstopicarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SNSTopicArn { get; set; }
            /// <summary>
            /// BackupVaultEvents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupvault-notificationobjecttype.html#cfn-backup-backupvault-notificationobjecttype-backupvaultevents
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic BackupVaultEvents { get; set; }
        }
    }
}