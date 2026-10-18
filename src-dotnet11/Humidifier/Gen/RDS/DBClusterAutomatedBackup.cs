namespace Humidifier.RDS
{
    using global::System.Collections.Generic;
    using DBClusterAutomatedBackupTypes;

    public class DBClusterAutomatedBackup : Humidifier.Base.BaseResource, IHaveStorageEncrypted_Boolean, IHaveIAMDatabaseAuthenticationEnabled_Boolean, IHaveEngineVersion, IHaveEngineMode, IHavePort_Integer, IHaveDBClusterIdentifier, IHaveMasterUsername, IHaveBackupRetentionPeriod_Integer, IHaveEngine
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string ClusterCreateTime =  "ClusterCreateTime" ;
            public static string KmsKeyId =  "KmsKeyId" ;
            public static string AvailabilityZones =  "AvailabilityZones" ;
            public static string DBClusterArn =  "DBClusterArn" ;
            public static string DBClusterAutomatedBackupsArn =  "DBClusterAutomatedBackupsArn" ;
            public static string DbClusterResourceId =  "DbClusterResourceId" ;
            public static string AllocatedStorage =  "AllocatedStorage" ;
            public static string RestoreWindow =  "RestoreWindow" ;
            public static string Region =  "Region" ;
            public static string Tags =  "Tags" ;
        }

        public override string AWSTypeName { get => AWS.RDS.DBClusterAutomatedBackup; }
        /// <summary>
        /// StorageEncrypted
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbclusterautomatedbackup.html#cfn-rds-dbclusterautomatedbackup-storageencrypted
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? StorageEncrypted { get; set; }
        /// <summary>
        /// IAMDatabaseAuthenticationEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbclusterautomatedbackup.html#cfn-rds-dbclusterautomatedbackup-iamdatabaseauthenticationenabled
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? IAMDatabaseAuthenticationEnabled { get; set; }
        /// <summary>
        /// EngineVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbclusterautomatedbackup.html#cfn-rds-dbclusterautomatedbackup-engineversion
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EngineVersion { get; set; }
        /// <summary>
        /// EngineMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbclusterautomatedbackup.html#cfn-rds-dbclusterautomatedbackup-enginemode
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EngineMode { get; set; }
        /// <summary>
        /// Port
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbclusterautomatedbackup.html#cfn-rds-dbclusterautomatedbackup-port
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? Port { get; set; }
        /// <summary>
        /// DBClusterIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbclusterautomatedbackup.html#cfn-rds-dbclusterautomatedbackup-dbclusteridentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DBClusterIdentifier { get; set; }
        /// <summary>
        /// MasterUsername
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbclusterautomatedbackup.html#cfn-rds-dbclusterautomatedbackup-masterusername
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? MasterUsername { get; set; }
        /// <summary>
        /// BackupRetentionPeriod
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbclusterautomatedbackup.html#cfn-rds-dbclusterautomatedbackup-backupretentionperiod
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? BackupRetentionPeriod { get; set; }
        /// <summary>
        /// Engine
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbclusterautomatedbackup.html#cfn-rds-dbclusterautomatedbackup-engine
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Engine { get; set; }
    }

    namespace DBClusterAutomatedBackupTypes
    {
        public class RestoreWindow : Humidifier.Base.BaseSubResource, IHaveEarliestTime, IHaveLatestTime
        {
            /// <summary>
            /// EarliestTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-dbclusterautomatedbackup-restorewindow.html#cfn-rds-dbclusterautomatedbackup-restorewindow-earliesttime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EarliestTime { get; set; }
            /// <summary>
            /// LatestTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-dbclusterautomatedbackup-restorewindow.html#cfn-rds-dbclusterautomatedbackup-restorewindow-latesttime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LatestTime { get; set; }
        }
    }
}