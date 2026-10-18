namespace Humidifier.Backup
{
    using global::System.Collections.Generic;
    using BackupPlanTypes;

    public class BackupPlan : Humidifier.Base.BaseResource, IHaveBackupBackupPlanTypesBackupPlanResourceTypeBackupPlan_, IHaveStringDictionaryOfBackupPlanTags
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
        public Union<Humidifier.Backup.BackupPlanTypes.BackupPlanResourceType, BaseFunction>? BackupPlan_ { get; set; }
        /// <summary>
        /// BackupPlanTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-backupplan.html#cfn-backup-backupplan-backupplantags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? BackupPlanTags { get; set; }
    }

    namespace BackupPlanTypes
    {
        public class AdvancedBackupSettingResourceType : Humidifier.Base.BaseSubResource, IHaveBackupOptions_Json, IHaveResourceType
        {
            /// <summary>
            /// BackupOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-advancedbackupsettingresourcetype.html#cfn-backup-backupplan-advancedbackupsettingresourcetype-backupoptions
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? BackupOptions { get; set; }
            /// <summary>
            /// ResourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-advancedbackupsettingresourcetype.html#cfn-backup-backupplan-advancedbackupsettingresourcetype-resourcetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceType { get; set; }
        }

        public class BackupPlanResourceType : Humidifier.Base.BaseSubResource, IHaveBackupPlanName, IHaveListOfBackupBackupPlanTypesScanSettingResourceTypeScanSettings, IHaveListOfBackupBackupPlanTypesAdvancedBackupSettingResourceTypeAdvancedBackupSettings, IHaveListOfBackupBackupPlanTypesBackupRuleResourceTypeBackupPlanRule
        {
            /// <summary>
            /// BackupPlanName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupplanresourcetype.html#cfn-backup-backupplan-backupplanresourcetype-backupplanname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BackupPlanName { get; set; }
            /// <summary>
            /// ScanSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupplanresourcetype.html#cfn-backup-backupplan-backupplanresourcetype-scansettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ScanSettingResourceType
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Backup.BackupPlanTypes.ScanSettingResourceType>, IReadOnlyList<Union<Humidifier.Backup.BackupPlanTypes.ScanSettingResourceType, BaseFunction>>, BaseFunction>? ScanSettings { get; set; }
            /// <summary>
            /// AdvancedBackupSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupplanresourcetype.html#cfn-backup-backupplan-backupplanresourcetype-advancedbackupsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AdvancedBackupSettingResourceType
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Backup.BackupPlanTypes.AdvancedBackupSettingResourceType>, IReadOnlyList<Union<Humidifier.Backup.BackupPlanTypes.AdvancedBackupSettingResourceType, BaseFunction>>, BaseFunction>? AdvancedBackupSettings { get; set; }
            /// <summary>
            /// BackupPlanRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupplanresourcetype.html#cfn-backup-backupplan-backupplanresourcetype-backupplanrule
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: BackupRuleResourceType
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Backup.BackupPlanTypes.BackupRuleResourceType>, IReadOnlyList<Union<Humidifier.Backup.BackupPlanTypes.BackupRuleResourceType, BaseFunction>>, BaseFunction>? BackupPlanRule { get; set; }
        }

        public class BackupRuleResourceType : Humidifier.Base.BaseSubResource, IHaveCompletionWindowMinutes_Double, IHaveScheduleExpression, IHaveStringDictionaryOfRecoveryPointTags, IHaveListOfBackupBackupPlanTypesCopyActionResourceTypeCopyActions, IHaveEnableContinuousBackup_Boolean, IHaveBackupBackupPlanTypesLifecycleResourceTypeLifecycle, IHaveListOfBackupBackupPlanTypesIndexActionsResourceTypeIndexActions, IHaveStartWindowMinutes_Double, IHaveScheduleExpressionTimezone, IHaveTargetLogicallyAirGappedBackupVaultArn, IHaveListOfBackupBackupPlanTypesScanActionResourceTypeScanActions, IHaveTargetBackupVault, IHaveRuleName
        {
            /// <summary>
            /// CompletionWindowMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupruleresourcetype.html#cfn-backup-backupplan-backupruleresourcetype-completionwindowminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? CompletionWindowMinutes { get; set; }
            /// <summary>
            /// ScheduleExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupruleresourcetype.html#cfn-backup-backupplan-backupruleresourcetype-scheduleexpression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScheduleExpression { get; set; }
            /// <summary>
            /// RecoveryPointTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupruleresourcetype.html#cfn-backup-backupplan-backupruleresourcetype-recoverypointtags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? RecoveryPointTags { get; set; }
            /// <summary>
            /// CopyActions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupruleresourcetype.html#cfn-backup-backupplan-backupruleresourcetype-copyactions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CopyActionResourceType
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Backup.BackupPlanTypes.CopyActionResourceType>, IReadOnlyList<Union<Humidifier.Backup.BackupPlanTypes.CopyActionResourceType, BaseFunction>>, BaseFunction>? CopyActions { get; set; }
            /// <summary>
            /// EnableContinuousBackup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupruleresourcetype.html#cfn-backup-backupplan-backupruleresourcetype-enablecontinuousbackup
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableContinuousBackup { get; set; }
            /// <summary>
            /// Lifecycle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupruleresourcetype.html#cfn-backup-backupplan-backupruleresourcetype-lifecycle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LifecycleResourceType
            /// </summary>
            public Union<Humidifier.Backup.BackupPlanTypes.LifecycleResourceType, BaseFunction>? Lifecycle { get; set; }
            /// <summary>
            /// IndexActions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupruleresourcetype.html#cfn-backup-backupplan-backupruleresourcetype-indexactions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: IndexActionsResourceType
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Backup.BackupPlanTypes.IndexActionsResourceType>, IReadOnlyList<Union<Humidifier.Backup.BackupPlanTypes.IndexActionsResourceType, BaseFunction>>, BaseFunction>? IndexActions { get; set; }
            /// <summary>
            /// StartWindowMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupruleresourcetype.html#cfn-backup-backupplan-backupruleresourcetype-startwindowminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? StartWindowMinutes { get; set; }
            /// <summary>
            /// ScheduleExpressionTimezone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupruleresourcetype.html#cfn-backup-backupplan-backupruleresourcetype-scheduleexpressiontimezone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScheduleExpressionTimezone { get; set; }
            /// <summary>
            /// TargetLogicallyAirGappedBackupVaultArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupruleresourcetype.html#cfn-backup-backupplan-backupruleresourcetype-targetlogicallyairgappedbackupvaultarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetLogicallyAirGappedBackupVaultArn { get; set; }
            /// <summary>
            /// ScanActions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupruleresourcetype.html#cfn-backup-backupplan-backupruleresourcetype-scanactions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ScanActionResourceType
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Backup.BackupPlanTypes.ScanActionResourceType>, IReadOnlyList<Union<Humidifier.Backup.BackupPlanTypes.ScanActionResourceType, BaseFunction>>, BaseFunction>? ScanActions { get; set; }
            /// <summary>
            /// TargetBackupVault
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupruleresourcetype.html#cfn-backup-backupplan-backupruleresourcetype-targetbackupvault
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetBackupVault { get; set; }
            /// <summary>
            /// RuleName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupruleresourcetype.html#cfn-backup-backupplan-backupruleresourcetype-rulename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RuleName { get; set; }
        }

        public class CopyActionResourceType : Humidifier.Base.BaseSubResource, IHaveBackupBackupPlanTypesLifecycleResourceTypeLifecycle, IHaveDestinationBackupVaultArn
        {
            /// <summary>
            /// Lifecycle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-copyactionresourcetype.html#cfn-backup-backupplan-copyactionresourcetype-lifecycle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LifecycleResourceType
            /// </summary>
            public Union<Humidifier.Backup.BackupPlanTypes.LifecycleResourceType, BaseFunction>? Lifecycle { get; set; }
            /// <summary>
            /// DestinationBackupVaultArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-copyactionresourcetype.html#cfn-backup-backupplan-copyactionresourcetype-destinationbackupvaultarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DestinationBackupVaultArn { get; set; }
        }

        public class IndexActionsResourceType : Humidifier.Base.BaseSubResource, IHaveStringListOfResourceTypes
        {
            /// <summary>
            /// ResourceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-indexactionsresourcetype.html#cfn-backup-backupplan-indexactionsresourcetype-resourcetypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ResourceTypes { get; set; }
        }

        public class LifecycleResourceType : Humidifier.Base.BaseSubResource, IHaveOptInToArchiveForSupportedResources_Boolean, IHaveMoveToColdStorageAfterDays_Double, IHaveDeleteAfterDays_Double
        {
            /// <summary>
            /// OptInToArchiveForSupportedResources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-lifecycleresourcetype.html#cfn-backup-backupplan-lifecycleresourcetype-optintoarchiveforsupportedresources
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? OptInToArchiveForSupportedResources { get; set; }
            /// <summary>
            /// MoveToColdStorageAfterDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-lifecycleresourcetype.html#cfn-backup-backupplan-lifecycleresourcetype-movetocoldstorageafterdays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MoveToColdStorageAfterDays { get; set; }
            /// <summary>
            /// DeleteAfterDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-lifecycleresourcetype.html#cfn-backup-backupplan-lifecycleresourcetype-deleteafterdays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? DeleteAfterDays { get; set; }
        }

        public class ScanActionResourceType : Humidifier.Base.BaseSubResource, IHaveScanMode, IHaveMalwareScanner
        {
            /// <summary>
            /// ScanMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-scanactionresourcetype.html#cfn-backup-backupplan-scanactionresourcetype-scanmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScanMode { get; set; }
            /// <summary>
            /// MalwareScanner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-scanactionresourcetype.html#cfn-backup-backupplan-scanactionresourcetype-malwarescanner
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MalwareScanner { get; set; }
        }

        public class ScanSettingResourceType : Humidifier.Base.BaseSubResource, IHaveStringListOfResourceTypes, IHaveMalwareScanner, IHaveScannerRoleArn
        {
            /// <summary>
            /// ResourceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-scansettingresourcetype.html#cfn-backup-backupplan-scansettingresourcetype-resourcetypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ResourceTypes { get; set; }
            /// <summary>
            /// MalwareScanner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-scansettingresourcetype.html#cfn-backup-backupplan-scansettingresourcetype-malwarescanner
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MalwareScanner { get; set; }
            /// <summary>
            /// ScannerRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-scansettingresourcetype.html#cfn-backup-backupplan-scansettingresourcetype-scannerrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScannerRoleArn { get; set; }
        }
    }
}