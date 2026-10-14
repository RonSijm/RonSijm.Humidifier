namespace Humidifier.Backup
{
    using global::System.Collections.Generic;
    using BackupPlanTypes;

    public class BackupPlan : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string VersionId =  "VersionId" ;
            public static string BackupPlanId =  "BackupPlanId" ;
            public static string BackupPlanArn =  "BackupPlanArn" ;
        }

        public override string AWSTypeName { get => AWS.Backup.BackupPlan; }

        /// <summary>
        /// BackupPlan_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-backupplan.html#cfn-backup-backupplan-backupplan
        /// Required: True
        /// UpdateType: Mutable
        /// Type: BackupPlanResourceType
        /// </summary>
        [Required]
        public Humidifier.Backup.BackupPlanTypes.BackupPlanResourceType BackupPlan_ { get; set; }
        /// <summary>
        /// BackupPlanTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-backupplan.html#cfn-backup-backupplan-backupplantags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> BackupPlanTags { get; set; }
    }

    namespace BackupPlanTypes
    {
        public class AdvancedBackupSettingResourceType : Humidifier.Base.BaseSubResource, IHaveResourceType
        {
            /// <summary>
            /// BackupOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-advancedbackupsettingresourcetype.html#cfn-backup-backupplan-advancedbackupsettingresourcetype-backupoptions
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic BackupOptions { get; set; }
            /// <summary>
            /// ResourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-advancedbackupsettingresourcetype.html#cfn-backup-backupplan-advancedbackupsettingresourcetype-resourcetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResourceType { get; set; }
        }

        public class BackupPlanResourceType : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// BackupPlanName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupplanresourcetype.html#cfn-backup-backupplan-backupplanresourcetype-backupplanname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BackupPlanName { get; set; }
            /// <summary>
            /// ScanSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupplanresourcetype.html#cfn-backup-backupplan-backupplanresourcetype-scansettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ScanSettingResourceType
            /// </summary>
            public List<Humidifier.Backup.BackupPlanTypes.ScanSettingResourceType> ScanSettings { get; set; }
            /// <summary>
            /// AdvancedBackupSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupplanresourcetype.html#cfn-backup-backupplan-backupplanresourcetype-advancedbackupsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AdvancedBackupSettingResourceType
            /// </summary>
            public List<Humidifier.Backup.BackupPlanTypes.AdvancedBackupSettingResourceType> AdvancedBackupSettings { get; set; }
            /// <summary>
            /// BackupPlanRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupplanresourcetype.html#cfn-backup-backupplan-backupplanresourcetype-backupplanrule
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: BackupRuleResourceType
            /// </summary>
            public List<Humidifier.Backup.BackupPlanTypes.BackupRuleResourceType> BackupPlanRule { get; set; }
        }

        public class BackupRuleResourceType : Humidifier.Base.BaseSubResource, IHaveScheduleExpression, IHaveRuleName, IHaveScheduleExpressionTimezone, IHaveBackupBackupPlanTypesLifecycleResourceTypeLifecycle
        {
            /// <summary>
            /// CompletionWindowMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupruleresourcetype.html#cfn-backup-backupplan-backupruleresourcetype-completionwindowminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic CompletionWindowMinutes { get; set; }
            /// <summary>
            /// ScheduleExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupruleresourcetype.html#cfn-backup-backupplan-backupruleresourcetype-scheduleexpression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ScheduleExpression { get; set; }
            /// <summary>
            /// RecoveryPointTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupruleresourcetype.html#cfn-backup-backupplan-backupruleresourcetype-recoverypointtags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> RecoveryPointTags { get; set; }
            /// <summary>
            /// CopyActions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupruleresourcetype.html#cfn-backup-backupplan-backupruleresourcetype-copyactions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CopyActionResourceType
            /// </summary>
            public List<Humidifier.Backup.BackupPlanTypes.CopyActionResourceType> CopyActions { get; set; }
            /// <summary>
            /// EnableContinuousBackup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupruleresourcetype.html#cfn-backup-backupplan-backupruleresourcetype-enablecontinuousbackup
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EnableContinuousBackup { get; set; }
            /// <summary>
            /// Lifecycle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupruleresourcetype.html#cfn-backup-backupplan-backupruleresourcetype-lifecycle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LifecycleResourceType
            /// </summary>
            public Humidifier.Backup.BackupPlanTypes.LifecycleResourceType Lifecycle { get; set; }
            /// <summary>
            /// IndexActions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupruleresourcetype.html#cfn-backup-backupplan-backupruleresourcetype-indexactions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: IndexActionsResourceType
            /// </summary>
            public List<Humidifier.Backup.BackupPlanTypes.IndexActionsResourceType> IndexActions { get; set; }
            /// <summary>
            /// StartWindowMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupruleresourcetype.html#cfn-backup-backupplan-backupruleresourcetype-startwindowminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic StartWindowMinutes { get; set; }
            /// <summary>
            /// ScheduleExpressionTimezone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupruleresourcetype.html#cfn-backup-backupplan-backupruleresourcetype-scheduleexpressiontimezone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ScheduleExpressionTimezone { get; set; }
            /// <summary>
            /// TargetLogicallyAirGappedBackupVaultArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupruleresourcetype.html#cfn-backup-backupplan-backupruleresourcetype-targetlogicallyairgappedbackupvaultarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetLogicallyAirGappedBackupVaultArn { get; set; }
            /// <summary>
            /// ScanActions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupruleresourcetype.html#cfn-backup-backupplan-backupruleresourcetype-scanactions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ScanActionResourceType
            /// </summary>
            public List<Humidifier.Backup.BackupPlanTypes.ScanActionResourceType> ScanActions { get; set; }
            /// <summary>
            /// TargetBackupVault
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupruleresourcetype.html#cfn-backup-backupplan-backupruleresourcetype-targetbackupvault
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetBackupVault { get; set; }
            /// <summary>
            /// RuleName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupruleresourcetype.html#cfn-backup-backupplan-backupruleresourcetype-rulename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RuleName { get; set; }
        }

        public class CopyActionResourceType : Humidifier.Base.BaseSubResource, IHaveBackupBackupPlanTypesLifecycleResourceTypeLifecycle
        {
            /// <summary>
            /// Lifecycle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-copyactionresourcetype.html#cfn-backup-backupplan-copyactionresourcetype-lifecycle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LifecycleResourceType
            /// </summary>
            public Humidifier.Backup.BackupPlanTypes.LifecycleResourceType Lifecycle { get; set; }
            /// <summary>
            /// DestinationBackupVaultArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-copyactionresourcetype.html#cfn-backup-backupplan-copyactionresourcetype-destinationbackupvaultarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DestinationBackupVaultArn { get; set; }
        }

        public class IndexActionsResourceType : Humidifier.Base.BaseSubResource, IHaveResourceTypes
        {
            /// <summary>
            /// ResourceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-indexactionsresourcetype.html#cfn-backup-backupplan-indexactionsresourcetype-resourcetypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ResourceTypes { get; set; }
        }

        public class LifecycleResourceType : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// OptInToArchiveForSupportedResources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-lifecycleresourcetype.html#cfn-backup-backupplan-lifecycleresourcetype-optintoarchiveforsupportedresources
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic OptInToArchiveForSupportedResources { get; set; }
            /// <summary>
            /// MoveToColdStorageAfterDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-lifecycleresourcetype.html#cfn-backup-backupplan-lifecycleresourcetype-movetocoldstorageafterdays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MoveToColdStorageAfterDays { get; set; }
            /// <summary>
            /// DeleteAfterDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-lifecycleresourcetype.html#cfn-backup-backupplan-lifecycleresourcetype-deleteafterdays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic DeleteAfterDays { get; set; }
        }

        public class ScanActionResourceType : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ScanMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-scanactionresourcetype.html#cfn-backup-backupplan-scanactionresourcetype-scanmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ScanMode { get; set; }
            /// <summary>
            /// MalwareScanner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-scanactionresourcetype.html#cfn-backup-backupplan-scanactionresourcetype-malwarescanner
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MalwareScanner { get; set; }
        }

        public class ScanSettingResourceType : Humidifier.Base.BaseSubResource, IHaveResourceTypes
        {
            /// <summary>
            /// ResourceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-scansettingresourcetype.html#cfn-backup-backupplan-scansettingresourcetype-resourcetypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ResourceTypes { get; set; }
            /// <summary>
            /// MalwareScanner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-scansettingresourcetype.html#cfn-backup-backupplan-scansettingresourcetype-malwarescanner
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MalwareScanner { get; set; }
            /// <summary>
            /// ScannerRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-scansettingresourcetype.html#cfn-backup-backupplan-scansettingresourcetype-scannerrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ScannerRoleArn { get; set; }
        }
    }
}