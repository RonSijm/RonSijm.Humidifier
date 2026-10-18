namespace Humidifier.RDS
{
    using global::System.Collections.Generic;
    using DBInstanceAutomatedBackupTypes;

    public class DBInstanceAutomatedBackup : Humidifier.Base.BaseResource, IHaveStorageType, IHaveEncrypted_Boolean, IHavePort_Integer, IHaveMasterUsername, IHaveBackupRetentionPeriod_Integer, IHaveEngine, IHaveDBInstanceIdentifier, IHaveAllocatedStorage_Integer
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string IAMDatabaseAuthenticationEnabled =  "IAMDatabaseAuthenticationEnabled" ;
            public static string LicenseModel =  "LicenseModel" ;
            public static string EngineVersion =  "EngineVersion" ;
            public static string KmsKeyId =  "KmsKeyId" ;
            public static string InstanceCreateTime =  "InstanceCreateTime" ;
            public static string AvailabilityZone =  "AvailabilityZone" ;
            public static string OptionGroupName =  "OptionGroupName" ;
            public static string StorageThroughput =  "StorageThroughput" ;
            public static string Iops =  "Iops" ;
            public static string DbiResourceId =  "DbiResourceId" ;
            public static string BackupTarget =  "BackupTarget" ;
            public static string DBInstanceArn =  "DBInstanceArn" ;
            public static string RestoreWindow =  "RestoreWindow" ;
            public static string VpcId =  "VpcId" ;
            public static string DBInstanceAutomatedBackupsArn =  "DBInstanceAutomatedBackupsArn" ;
            public static string Region =  "Region" ;
            public static string Tags =  "Tags" ;
        }

        public override string AWSTypeName { get => AWS.RDS.DBInstanceAutomatedBackup; }
        /// <summary>
        /// StorageType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbinstanceautomatedbackup.html#cfn-rds-dbinstanceautomatedbackup-storagetype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? StorageType { get; set; }
        /// <summary>
        /// Encrypted
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbinstanceautomatedbackup.html#cfn-rds-dbinstanceautomatedbackup-encrypted
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? Encrypted { get; set; }
        /// <summary>
        /// Port
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbinstanceautomatedbackup.html#cfn-rds-dbinstanceautomatedbackup-port
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? Port { get; set; }
        /// <summary>
        /// MasterUsername
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbinstanceautomatedbackup.html#cfn-rds-dbinstanceautomatedbackup-masterusername
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? MasterUsername { get; set; }
        /// <summary>
        /// BackupRetentionPeriod
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbinstanceautomatedbackup.html#cfn-rds-dbinstanceautomatedbackup-backupretentionperiod
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? BackupRetentionPeriod { get; set; }
        /// <summary>
        /// Engine
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbinstanceautomatedbackup.html#cfn-rds-dbinstanceautomatedbackup-engine
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Engine { get; set; }
        /// <summary>
        /// DBInstanceIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbinstanceautomatedbackup.html#cfn-rds-dbinstanceautomatedbackup-dbinstanceidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DBInstanceIdentifier { get; set; }
        /// <summary>
        /// AllocatedStorage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbinstanceautomatedbackup.html#cfn-rds-dbinstanceautomatedbackup-allocatedstorage
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? AllocatedStorage { get; set; }
    }

    namespace DBInstanceAutomatedBackupTypes
    {
        public class RestoreWindow : Humidifier.Base.BaseSubResource, IHaveEarliestTime, IHaveLatestTime
        {
            /// <summary>
            /// EarliestTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-dbinstanceautomatedbackup-restorewindow.html#cfn-rds-dbinstanceautomatedbackup-restorewindow-earliesttime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EarliestTime { get; set; }
            /// <summary>
            /// LatestTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-dbinstanceautomatedbackup-restorewindow.html#cfn-rds-dbinstanceautomatedbackup-restorewindow-latesttime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LatestTime { get; set; }
        }
    }
}