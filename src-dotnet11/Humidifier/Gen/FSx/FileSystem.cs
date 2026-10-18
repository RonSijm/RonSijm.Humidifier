namespace Humidifier.FSx
{
    using global::System.Collections.Generic;
    using FileSystemTypes;

    public class FileSystem : Humidifier.Base.BaseResource, IHaveTags, IHaveStorageType, IHaveKmsKeyId, IHaveStorageCapacity_Integer, IHaveFSxFileSystemTypesLustreConfigurationLustreConfiguration, IHaveBackupId, IHaveFSxFileSystemTypesOntapConfigurationOntapConfiguration, IHaveStringListOfSubnetIds, IHaveStringListOfSecurityGroupIds, IHaveFSxFileSystemTypesWindowsConfigurationWindowsConfiguration, IHaveFileSystemTypeVersion, IHaveFSxFileSystemTypesOpenZFSConfigurationOpenZFSConfiguration, IHaveNetworkType, IHaveFileSystemType
    {
        public class Attributes
        {
            public static string ResourceARN =  "ResourceARN" ;
            public static string RootVolumeId =  "RootVolumeId" ;
            public static string DNSName =  "DNSName" ;
            public static string LustreMountName =  "LustreMountName" ;
        }

        public override string AWSTypeName { get => AWS.FSx.FileSystem; }
        /// <summary>
        /// StorageType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-filesystem.html#cfn-fsx-filesystem-storagetype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? StorageType { get; set; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-filesystem.html#cfn-fsx-filesystem-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyId { get; set; }
        /// <summary>
        /// StorageCapacity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-filesystem.html#cfn-fsx-filesystem-storagecapacity
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? StorageCapacity { get; set; }
        /// <summary>
        /// LustreConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-filesystem.html#cfn-fsx-filesystem-lustreconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LustreConfiguration
        /// </summary>
        public Union<Humidifier.FSx.FileSystemTypes.LustreConfiguration, BaseFunction>? LustreConfiguration { get; set; }
        /// <summary>
        /// BackupId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-filesystem.html#cfn-fsx-filesystem-backupid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? BackupId { get; set; }
        /// <summary>
        /// OntapConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-filesystem.html#cfn-fsx-filesystem-ontapconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: OntapConfiguration
        /// </summary>
        public Union<Humidifier.FSx.FileSystemTypes.OntapConfiguration, BaseFunction>? OntapConfiguration { get; set; }

        /// <summary>
        /// SubnetIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-filesystem.html#cfn-fsx-filesystem-subnetids
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
        /// <summary>
        /// SecurityGroupIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-filesystem.html#cfn-fsx-filesystem-securitygroupids
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        /// <summary>
        /// WindowsConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-filesystem.html#cfn-fsx-filesystem-windowsconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: WindowsConfiguration
        /// </summary>
        public Union<Humidifier.FSx.FileSystemTypes.WindowsConfiguration, BaseFunction>? WindowsConfiguration { get; set; }
        /// <summary>
        /// FileSystemTypeVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-filesystem.html#cfn-fsx-filesystem-filesystemtypeversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? FileSystemTypeVersion { get; set; }
        /// <summary>
        /// OpenZFSConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-filesystem.html#cfn-fsx-filesystem-openzfsconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: OpenZFSConfiguration
        /// </summary>
        public Union<Humidifier.FSx.FileSystemTypes.OpenZFSConfiguration, BaseFunction>? OpenZFSConfiguration { get; set; }
        /// <summary>
        /// NetworkType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-filesystem.html#cfn-fsx-filesystem-networktype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? NetworkType { get; set; }

        /// <summary>
        /// FileSystemType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-filesystem.html#cfn-fsx-filesystem-filesystemtype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? FileSystemType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-filesystem.html#cfn-fsx-filesystem-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace FileSystemTypes
    {
        public class AuditLogConfiguration : Humidifier.Base.BaseSubResource, IHaveFileAccessAuditLogLevel, IHaveFileShareAccessAuditLogLevel, IHaveAuditLogDestination
        {
            /// <summary>
            /// FileAccessAuditLogLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-windowsconfiguration-auditlogconfiguration.html#cfn-fsx-filesystem-windowsconfiguration-auditlogconfiguration-fileaccessauditloglevel
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FileAccessAuditLogLevel { get; set; }
            /// <summary>
            /// FileShareAccessAuditLogLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-windowsconfiguration-auditlogconfiguration.html#cfn-fsx-filesystem-windowsconfiguration-auditlogconfiguration-fileshareaccessauditloglevel
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FileShareAccessAuditLogLevel { get; set; }
            /// <summary>
            /// AuditLogDestination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-windowsconfiguration-auditlogconfiguration.html#cfn-fsx-filesystem-windowsconfiguration-auditlogconfiguration-auditlogdestination
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuditLogDestination { get; set; }
        }

        public class ClientConfigurations : Humidifier.Base.BaseSubResource, IHaveStringListOfOptions, IHaveClients
        {
            /// <summary>
            /// Options
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-openzfsconfiguration-rootvolumeconfiguration-nfsexports-clientconfigurations.html#cfn-fsx-filesystem-openzfsconfiguration-rootvolumeconfiguration-nfsexports-clientconfigurations-options
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Options { get; set; }
            /// <summary>
            /// Clients
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-openzfsconfiguration-rootvolumeconfiguration-nfsexports-clientconfigurations.html#cfn-fsx-filesystem-openzfsconfiguration-rootvolumeconfiguration-nfsexports-clientconfigurations-clients
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Clients { get; set; }
        }

        public class DataReadCacheConfiguration : Humidifier.Base.BaseSubResource, IHaveSizingMode, IHaveSizeGiB_Integer
        {
            /// <summary>
            /// SizingMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-lustreconfiguration-datareadcacheconfiguration.html#cfn-fsx-filesystem-lustreconfiguration-datareadcacheconfiguration-sizingmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SizingMode { get; set; }
            /// <summary>
            /// SizeGiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-lustreconfiguration-datareadcacheconfiguration.html#cfn-fsx-filesystem-lustreconfiguration-datareadcacheconfiguration-sizegib
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SizeGiB { get; set; }
        }

        public class DiskIopsConfiguration : Humidifier.Base.BaseSubResource, IHaveMode, IHaveIops_Integer
        {
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-openzfsconfiguration-diskiopsconfiguration.html#cfn-fsx-filesystem-openzfsconfiguration-diskiopsconfiguration-mode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Mode { get; set; }
            /// <summary>
            /// Iops
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-openzfsconfiguration-diskiopsconfiguration.html#cfn-fsx-filesystem-openzfsconfiguration-diskiopsconfiguration-iops
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Iops { get; set; }
        }

        public class FsrmConfiguration : Humidifier.Base.BaseSubResource, IHaveFsrmServiceEnabled_Boolean, IHaveEventLogDestination
        {
            /// <summary>
            /// FsrmServiceEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-windowsconfiguration-fsrmconfiguration.html#cfn-fsx-filesystem-windowsconfiguration-fsrmconfiguration-fsrmserviceenabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? FsrmServiceEnabled { get; set; }
            /// <summary>
            /// EventLogDestination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-windowsconfiguration-fsrmconfiguration.html#cfn-fsx-filesystem-windowsconfiguration-fsrmconfiguration-eventlogdestination
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EventLogDestination { get; set; }
        }

        public class LogConfiguration : Humidifier.Base.BaseSubResource, IHaveDestination, IHaveLevel
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-lustreconfiguration-logconfiguration.html#cfn-fsx-filesystem-lustreconfiguration-logconfiguration-destination
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Destination { get; set; }
            /// <summary>
            /// Level
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-lustreconfiguration-logconfiguration.html#cfn-fsx-filesystem-lustreconfiguration-logconfiguration-level
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Level { get; set; }
        }

        public class LustreConfiguration : Humidifier.Base.BaseSubResource, IHaveDriveCacheType, IHaveAutoImportPolicy, IHaveEfaEnabled_Boolean, IHaveImportedFileChunkSize_Integer, IHaveDeploymentType, IHaveThroughputCapacity_Integer, IHaveFSxFileSystemTypesLogConfigurationLogConfiguration, IHaveDataCompressionType, IHaveFSxFileSystemTypesDataReadCacheConfigurationDataReadCacheConfiguration, IHaveImportPath, IHaveWeeklyMaintenanceStartTime, IHaveFSxFileSystemTypesMetadataConfigurationMetadataConfiguration, IHaveDailyAutomaticBackupStartTime, IHaveCopyTagsToBackups_Boolean, IHaveExportPath, IHavePerUnitStorageThroughput_Integer, IHaveAutomaticBackupRetentionDays_Integer
        {
            /// <summary>
            /// DriveCacheType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-lustreconfiguration.html#cfn-fsx-filesystem-lustreconfiguration-drivecachetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DriveCacheType { get; set; }
            /// <summary>
            /// AutoImportPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-lustreconfiguration.html#cfn-fsx-filesystem-lustreconfiguration-autoimportpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AutoImportPolicy { get; set; }
            /// <summary>
            /// EfaEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-lustreconfiguration.html#cfn-fsx-filesystem-lustreconfiguration-efaenabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EfaEnabled { get; set; }
            /// <summary>
            /// ImportedFileChunkSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-lustreconfiguration.html#cfn-fsx-filesystem-lustreconfiguration-importedfilechunksize
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ImportedFileChunkSize { get; set; }
            /// <summary>
            /// DeploymentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-lustreconfiguration.html#cfn-fsx-filesystem-lustreconfiguration-deploymenttype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeploymentType { get; set; }
            /// <summary>
            /// ThroughputCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-lustreconfiguration.html#cfn-fsx-filesystem-lustreconfiguration-throughputcapacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ThroughputCapacity { get; set; }
            /// <summary>
            /// LogConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-lustreconfiguration.html#cfn-fsx-filesystem-lustreconfiguration-logconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LogConfiguration
            /// </summary>
            public Union<Humidifier.FSx.FileSystemTypes.LogConfiguration, BaseFunction>? LogConfiguration { get; set; }
            /// <summary>
            /// DataCompressionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-lustreconfiguration.html#cfn-fsx-filesystem-lustreconfiguration-datacompressiontype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataCompressionType { get; set; }
            /// <summary>
            /// DataReadCacheConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-lustreconfiguration.html#cfn-fsx-filesystem-lustreconfiguration-datareadcacheconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataReadCacheConfiguration
            /// </summary>
            public Union<Humidifier.FSx.FileSystemTypes.DataReadCacheConfiguration, BaseFunction>? DataReadCacheConfiguration { get; set; }
            /// <summary>
            /// ImportPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-lustreconfiguration.html#cfn-fsx-filesystem-lustreconfiguration-importpath
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImportPath { get; set; }
            /// <summary>
            /// WeeklyMaintenanceStartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-lustreconfiguration.html#cfn-fsx-filesystem-lustreconfiguration-weeklymaintenancestarttime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WeeklyMaintenanceStartTime { get; set; }
            /// <summary>
            /// MetadataConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-lustreconfiguration.html#cfn-fsx-filesystem-lustreconfiguration-metadataconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MetadataConfiguration
            /// </summary>
            public Union<Humidifier.FSx.FileSystemTypes.MetadataConfiguration, BaseFunction>? MetadataConfiguration { get; set; }
            /// <summary>
            /// DailyAutomaticBackupStartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-lustreconfiguration.html#cfn-fsx-filesystem-lustreconfiguration-dailyautomaticbackupstarttime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DailyAutomaticBackupStartTime { get; set; }
            /// <summary>
            /// CopyTagsToBackups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-lustreconfiguration.html#cfn-fsx-filesystem-lustreconfiguration-copytagstobackups
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? CopyTagsToBackups { get; set; }
            /// <summary>
            /// ExportPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-lustreconfiguration.html#cfn-fsx-filesystem-lustreconfiguration-exportpath
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExportPath { get; set; }
            /// <summary>
            /// PerUnitStorageThroughput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-lustreconfiguration.html#cfn-fsx-filesystem-lustreconfiguration-perunitstoragethroughput
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? PerUnitStorageThroughput { get; set; }
            /// <summary>
            /// AutomaticBackupRetentionDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-lustreconfiguration.html#cfn-fsx-filesystem-lustreconfiguration-automaticbackupretentiondays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? AutomaticBackupRetentionDays { get; set; }
        }

        public class MetadataConfiguration : Humidifier.Base.BaseSubResource, IHaveMode, IHaveIops_Integer
        {
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-lustreconfiguration-metadataconfiguration.html#cfn-fsx-filesystem-lustreconfiguration-metadataconfiguration-mode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Mode { get; set; }
            /// <summary>
            /// Iops
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-lustreconfiguration-metadataconfiguration.html#cfn-fsx-filesystem-lustreconfiguration-metadataconfiguration-iops
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Iops { get; set; }
        }

        public class NfsExports : Humidifier.Base.BaseSubResource, IHaveListOfFSxFileSystemTypesClientConfigurationsClientConfigurations
        {
            /// <summary>
            /// ClientConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-openzfsconfiguration-rootvolumeconfiguration-nfsexports.html#cfn-fsx-filesystem-openzfsconfiguration-rootvolumeconfiguration-nfsexports-clientconfigurations
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ClientConfigurations
            /// </summary>
            public Union<IReadOnlyList<Humidifier.FSx.FileSystemTypes.ClientConfigurations>, IReadOnlyList<Union<Humidifier.FSx.FileSystemTypes.ClientConfigurations, BaseFunction>>, BaseFunction>? ClientConfigurations { get; set; }
        }

        public class OntapConfiguration : Humidifier.Base.BaseSubResource, IHaveHAPairs_Integer, IHaveFsxAdminPassword, IHaveThroughputCapacityPerHAPair_Integer, IHaveDeploymentType, IHaveThroughputCapacity_Integer, IHaveEndpointIpAddressRange, IHaveStringListOfRouteTableIds, IHaveWeeklyMaintenanceStartTime, IHaveFSxFileSystemTypesDiskIopsConfigurationDiskIopsConfiguration, IHaveDailyAutomaticBackupStartTime, IHaveAutomaticBackupRetentionDays_Integer, IHaveEndpointIpv6AddressRange, IHavePreferredSubnetId
        {
            /// <summary>
            /// HAPairs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-ontapconfiguration.html#cfn-fsx-filesystem-ontapconfiguration-hapairs
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? HAPairs { get; set; }
            /// <summary>
            /// FsxAdminPassword
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-ontapconfiguration.html#cfn-fsx-filesystem-ontapconfiguration-fsxadminpassword
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FsxAdminPassword { get; set; }
            /// <summary>
            /// ThroughputCapacityPerHAPair
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-ontapconfiguration.html#cfn-fsx-filesystem-ontapconfiguration-throughputcapacityperhapair
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ThroughputCapacityPerHAPair { get; set; }
            /// <summary>
            /// DeploymentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-ontapconfiguration.html#cfn-fsx-filesystem-ontapconfiguration-deploymenttype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeploymentType { get; set; }
            /// <summary>
            /// ThroughputCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-ontapconfiguration.html#cfn-fsx-filesystem-ontapconfiguration-throughputcapacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ThroughputCapacity { get; set; }
            /// <summary>
            /// EndpointIpAddressRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-ontapconfiguration.html#cfn-fsx-filesystem-ontapconfiguration-endpointipaddressrange
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndpointIpAddressRange { get; set; }
            /// <summary>
            /// RouteTableIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-ontapconfiguration.html#cfn-fsx-filesystem-ontapconfiguration-routetableids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? RouteTableIds { get; set; }
            /// <summary>
            /// WeeklyMaintenanceStartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-ontapconfiguration.html#cfn-fsx-filesystem-ontapconfiguration-weeklymaintenancestarttime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WeeklyMaintenanceStartTime { get; set; }
            /// <summary>
            /// DiskIopsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-ontapconfiguration.html#cfn-fsx-filesystem-ontapconfiguration-diskiopsconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DiskIopsConfiguration
            /// </summary>
            public Union<Humidifier.FSx.FileSystemTypes.DiskIopsConfiguration, BaseFunction>? DiskIopsConfiguration { get; set; }
            /// <summary>
            /// DailyAutomaticBackupStartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-ontapconfiguration.html#cfn-fsx-filesystem-ontapconfiguration-dailyautomaticbackupstarttime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DailyAutomaticBackupStartTime { get; set; }
            /// <summary>
            /// AutomaticBackupRetentionDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-ontapconfiguration.html#cfn-fsx-filesystem-ontapconfiguration-automaticbackupretentiondays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? AutomaticBackupRetentionDays { get; set; }
            /// <summary>
            /// EndpointIpv6AddressRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-ontapconfiguration.html#cfn-fsx-filesystem-ontapconfiguration-endpointipv6addressrange
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndpointIpv6AddressRange { get; set; }
            /// <summary>
            /// PreferredSubnetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-ontapconfiguration.html#cfn-fsx-filesystem-ontapconfiguration-preferredsubnetid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PreferredSubnetId { get; set; }
        }

        public class OpenZFSConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfOptions, IHaveCopyTagsToVolumes_Boolean, IHaveDeploymentType, IHaveThroughputCapacity_Integer, IHaveFSxFileSystemTypesRootVolumeConfigurationRootVolumeConfiguration, IHaveEndpointIpAddressRange, IHaveFSxFileSystemTypesReadCacheConfigurationReadCacheConfiguration, IHaveStringListOfRouteTableIds, IHaveWeeklyMaintenanceStartTime, IHaveFSxFileSystemTypesDiskIopsConfigurationDiskIopsConfiguration, IHaveDailyAutomaticBackupStartTime, IHaveCopyTagsToBackups_Boolean, IHaveAutomaticBackupRetentionDays_Integer, IHaveEndpointIpv6AddressRange, IHavePreferredSubnetId
        {
            /// <summary>
            /// Options
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-openzfsconfiguration.html#cfn-fsx-filesystem-openzfsconfiguration-options
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Options { get; set; }
            /// <summary>
            /// CopyTagsToVolumes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-openzfsconfiguration.html#cfn-fsx-filesystem-openzfsconfiguration-copytagstovolumes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? CopyTagsToVolumes { get; set; }
            /// <summary>
            /// DeploymentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-openzfsconfiguration.html#cfn-fsx-filesystem-openzfsconfiguration-deploymenttype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeploymentType { get; set; }
            /// <summary>
            /// ThroughputCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-openzfsconfiguration.html#cfn-fsx-filesystem-openzfsconfiguration-throughputcapacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ThroughputCapacity { get; set; }
            /// <summary>
            /// RootVolumeConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-openzfsconfiguration.html#cfn-fsx-filesystem-openzfsconfiguration-rootvolumeconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RootVolumeConfiguration
            /// </summary>
            public Union<Humidifier.FSx.FileSystemTypes.RootVolumeConfiguration, BaseFunction>? RootVolumeConfiguration { get; set; }
            /// <summary>
            /// EndpointIpAddressRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-openzfsconfiguration.html#cfn-fsx-filesystem-openzfsconfiguration-endpointipaddressrange
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndpointIpAddressRange { get; set; }
            /// <summary>
            /// ReadCacheConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-openzfsconfiguration.html#cfn-fsx-filesystem-openzfsconfiguration-readcacheconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReadCacheConfiguration
            /// </summary>
            public Union<Humidifier.FSx.FileSystemTypes.ReadCacheConfiguration, BaseFunction>? ReadCacheConfiguration { get; set; }
            /// <summary>
            /// RouteTableIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-openzfsconfiguration.html#cfn-fsx-filesystem-openzfsconfiguration-routetableids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? RouteTableIds { get; set; }
            /// <summary>
            /// WeeklyMaintenanceStartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-openzfsconfiguration.html#cfn-fsx-filesystem-openzfsconfiguration-weeklymaintenancestarttime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WeeklyMaintenanceStartTime { get; set; }
            /// <summary>
            /// DiskIopsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-openzfsconfiguration.html#cfn-fsx-filesystem-openzfsconfiguration-diskiopsconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DiskIopsConfiguration
            /// </summary>
            public Union<Humidifier.FSx.FileSystemTypes.DiskIopsConfiguration, BaseFunction>? DiskIopsConfiguration { get; set; }
            /// <summary>
            /// DailyAutomaticBackupStartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-openzfsconfiguration.html#cfn-fsx-filesystem-openzfsconfiguration-dailyautomaticbackupstarttime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DailyAutomaticBackupStartTime { get; set; }
            /// <summary>
            /// CopyTagsToBackups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-openzfsconfiguration.html#cfn-fsx-filesystem-openzfsconfiguration-copytagstobackups
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? CopyTagsToBackups { get; set; }
            /// <summary>
            /// AutomaticBackupRetentionDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-openzfsconfiguration.html#cfn-fsx-filesystem-openzfsconfiguration-automaticbackupretentiondays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? AutomaticBackupRetentionDays { get; set; }
            /// <summary>
            /// EndpointIpv6AddressRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-openzfsconfiguration.html#cfn-fsx-filesystem-openzfsconfiguration-endpointipv6addressrange
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndpointIpv6AddressRange { get; set; }
            /// <summary>
            /// PreferredSubnetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-openzfsconfiguration.html#cfn-fsx-filesystem-openzfsconfiguration-preferredsubnetid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PreferredSubnetId { get; set; }
        }

        public class ReadCacheConfiguration : Humidifier.Base.BaseSubResource, IHaveSizingMode, IHaveSizeGiB_Integer
        {
            /// <summary>
            /// SizingMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-openzfsconfiguration-readcacheconfiguration.html#cfn-fsx-filesystem-openzfsconfiguration-readcacheconfiguration-sizingmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SizingMode { get; set; }
            /// <summary>
            /// SizeGiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-openzfsconfiguration-readcacheconfiguration.html#cfn-fsx-filesystem-openzfsconfiguration-readcacheconfiguration-sizegib
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SizeGiB { get; set; }
        }

        public class RootVolumeConfiguration : Humidifier.Base.BaseSubResource, IHaveReadOnly_Boolean, IHaveDataCompressionType, IHaveListOfFSxFileSystemTypesNfsExportsNfsExports, IHaveCopyTagsToSnapshots_Boolean, IHaveRecordSizeKiB_Integer, IHaveListOfFSxFileSystemTypesUserAndGroupQuotasUserAndGroupQuotas
        {
            /// <summary>
            /// ReadOnly
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-openzfsconfiguration-rootvolumeconfiguration.html#cfn-fsx-filesystem-openzfsconfiguration-rootvolumeconfiguration-readonly
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ReadOnly { get; set; }
            /// <summary>
            /// DataCompressionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-openzfsconfiguration-rootvolumeconfiguration.html#cfn-fsx-filesystem-openzfsconfiguration-rootvolumeconfiguration-datacompressiontype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataCompressionType { get; set; }
            /// <summary>
            /// NfsExports
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-openzfsconfiguration-rootvolumeconfiguration.html#cfn-fsx-filesystem-openzfsconfiguration-rootvolumeconfiguration-nfsexports
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: NfsExports
            /// </summary>
            public Union<IReadOnlyList<Humidifier.FSx.FileSystemTypes.NfsExports>, IReadOnlyList<Union<Humidifier.FSx.FileSystemTypes.NfsExports, BaseFunction>>, BaseFunction>? NfsExports { get; set; }
            /// <summary>
            /// CopyTagsToSnapshots
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-openzfsconfiguration-rootvolumeconfiguration.html#cfn-fsx-filesystem-openzfsconfiguration-rootvolumeconfiguration-copytagstosnapshots
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? CopyTagsToSnapshots { get; set; }
            /// <summary>
            /// RecordSizeKiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-openzfsconfiguration-rootvolumeconfiguration.html#cfn-fsx-filesystem-openzfsconfiguration-rootvolumeconfiguration-recordsizekib
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RecordSizeKiB { get; set; }
            /// <summary>
            /// UserAndGroupQuotas
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-openzfsconfiguration-rootvolumeconfiguration.html#cfn-fsx-filesystem-openzfsconfiguration-rootvolumeconfiguration-userandgroupquotas
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: UserAndGroupQuotas
            /// </summary>
            public Union<IReadOnlyList<Humidifier.FSx.FileSystemTypes.UserAndGroupQuotas>, IReadOnlyList<Union<Humidifier.FSx.FileSystemTypes.UserAndGroupQuotas, BaseFunction>>, BaseFunction>? UserAndGroupQuotas { get; set; }
        }

        public class SelfManagedActiveDirectoryConfiguration : Humidifier.Base.BaseSubResource, IHaveFileSystemAdministratorsGroup, IHaveUserName, IHaveDomainName, IHaveOrganizationalUnitDistinguishedName, IHaveDomainJoinServiceAccountSecret, IHaveStringListOfDnsIps, IHavePassword
        {
            /// <summary>
            /// FileSystemAdministratorsGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-windowsconfiguration-selfmanagedactivedirectoryconfiguration.html#cfn-fsx-filesystem-windowsconfiguration-selfmanagedactivedirectoryconfiguration-filesystemadministratorsgroup
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FileSystemAdministratorsGroup { get; set; }
            /// <summary>
            /// UserName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-windowsconfiguration-selfmanagedactivedirectoryconfiguration.html#cfn-fsx-filesystem-windowsconfiguration-selfmanagedactivedirectoryconfiguration-username
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserName { get; set; }
            /// <summary>
            /// DomainName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-windowsconfiguration-selfmanagedactivedirectoryconfiguration.html#cfn-fsx-filesystem-windowsconfiguration-selfmanagedactivedirectoryconfiguration-domainname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DomainName { get; set; }
            /// <summary>
            /// OrganizationalUnitDistinguishedName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-windowsconfiguration-selfmanagedactivedirectoryconfiguration.html#cfn-fsx-filesystem-windowsconfiguration-selfmanagedactivedirectoryconfiguration-organizationalunitdistinguishedname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OrganizationalUnitDistinguishedName { get; set; }
            /// <summary>
            /// DomainJoinServiceAccountSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-windowsconfiguration-selfmanagedactivedirectoryconfiguration.html#cfn-fsx-filesystem-windowsconfiguration-selfmanagedactivedirectoryconfiguration-domainjoinserviceaccountsecret
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DomainJoinServiceAccountSecret { get; set; }
            /// <summary>
            /// DnsIps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-windowsconfiguration-selfmanagedactivedirectoryconfiguration.html#cfn-fsx-filesystem-windowsconfiguration-selfmanagedactivedirectoryconfiguration-dnsips
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DnsIps { get; set; }
            /// <summary>
            /// Password
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-windowsconfiguration-selfmanagedactivedirectoryconfiguration.html#cfn-fsx-filesystem-windowsconfiguration-selfmanagedactivedirectoryconfiguration-password
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Password { get; set; }
        }

        public class UserAndGroupQuotas : Humidifier.Base.BaseSubResource, IHaveType, IHaveId_Integer, IHaveStorageCapacityQuotaGiB_Integer
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-openzfsconfiguration-rootvolumeconfiguration-userandgroupquotas.html#cfn-fsx-filesystem-openzfsconfiguration-rootvolumeconfiguration-userandgroupquotas-type
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-openzfsconfiguration-rootvolumeconfiguration-userandgroupquotas.html#cfn-fsx-filesystem-openzfsconfiguration-rootvolumeconfiguration-userandgroupquotas-id
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Id { get; set; }
            /// <summary>
            /// StorageCapacityQuotaGiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-openzfsconfiguration-rootvolumeconfiguration-userandgroupquotas.html#cfn-fsx-filesystem-openzfsconfiguration-rootvolumeconfiguration-userandgroupquotas-storagecapacityquotagib
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? StorageCapacityQuotaGiB { get; set; }
        }

        public class WindowsConfiguration : Humidifier.Base.BaseSubResource, IHaveFSxFileSystemTypesSelfManagedActiveDirectoryConfigurationSelfManagedActiveDirectoryConfiguration, IHaveFSxFileSystemTypesAuditLogConfigurationAuditLogConfiguration, IHaveActiveDirectoryId, IHaveDeploymentType, IHaveStringListOfAliases, IHaveThroughputCapacity_Integer, IHaveWeeklyMaintenanceStartTime, IHaveFSxFileSystemTypesDiskIopsConfigurationDiskIopsConfiguration, IHaveCopyTagsToBackups_Boolean, IHaveDailyAutomaticBackupStartTime, IHaveAutomaticBackupRetentionDays_Integer, IHaveFSxFileSystemTypesFsrmConfigurationFsrmConfiguration, IHavePreferredSubnetId
        {
            /// <summary>
            /// SelfManagedActiveDirectoryConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-windowsconfiguration.html#cfn-fsx-filesystem-windowsconfiguration-selfmanagedactivedirectoryconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SelfManagedActiveDirectoryConfiguration
            /// </summary>
            public Union<Humidifier.FSx.FileSystemTypes.SelfManagedActiveDirectoryConfiguration, BaseFunction>? SelfManagedActiveDirectoryConfiguration { get; set; }
            /// <summary>
            /// AuditLogConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-windowsconfiguration.html#cfn-fsx-filesystem-windowsconfiguration-auditlogconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuditLogConfiguration
            /// </summary>
            public Union<Humidifier.FSx.FileSystemTypes.AuditLogConfiguration, BaseFunction>? AuditLogConfiguration { get; set; }
            /// <summary>
            /// ActiveDirectoryId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-windowsconfiguration.html#cfn-fsx-filesystem-windowsconfiguration-activedirectoryid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ActiveDirectoryId { get; set; }
            /// <summary>
            /// DeploymentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-windowsconfiguration.html#cfn-fsx-filesystem-windowsconfiguration-deploymenttype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeploymentType { get; set; }
            /// <summary>
            /// Aliases
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-windowsconfiguration.html#cfn-fsx-filesystem-windowsconfiguration-aliases
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Aliases { get; set; }
            /// <summary>
            /// ThroughputCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-windowsconfiguration.html#cfn-fsx-filesystem-windowsconfiguration-throughputcapacity
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ThroughputCapacity { get; set; }
            /// <summary>
            /// WeeklyMaintenanceStartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-windowsconfiguration.html#cfn-fsx-filesystem-windowsconfiguration-weeklymaintenancestarttime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WeeklyMaintenanceStartTime { get; set; }
            /// <summary>
            /// DiskIopsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-windowsconfiguration.html#cfn-fsx-filesystem-windowsconfiguration-diskiopsconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DiskIopsConfiguration
            /// </summary>
            public Union<Humidifier.FSx.FileSystemTypes.DiskIopsConfiguration, BaseFunction>? DiskIopsConfiguration { get; set; }
            /// <summary>
            /// CopyTagsToBackups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-windowsconfiguration.html#cfn-fsx-filesystem-windowsconfiguration-copytagstobackups
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? CopyTagsToBackups { get; set; }
            /// <summary>
            /// DailyAutomaticBackupStartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-windowsconfiguration.html#cfn-fsx-filesystem-windowsconfiguration-dailyautomaticbackupstarttime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DailyAutomaticBackupStartTime { get; set; }
            /// <summary>
            /// AutomaticBackupRetentionDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-windowsconfiguration.html#cfn-fsx-filesystem-windowsconfiguration-automaticbackupretentiondays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? AutomaticBackupRetentionDays { get; set; }
            /// <summary>
            /// FsrmConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-windowsconfiguration.html#cfn-fsx-filesystem-windowsconfiguration-fsrmconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FsrmConfiguration
            /// </summary>
            public Union<Humidifier.FSx.FileSystemTypes.FsrmConfiguration, BaseFunction>? FsrmConfiguration { get; set; }
            /// <summary>
            /// PreferredSubnetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-filesystem-windowsconfiguration.html#cfn-fsx-filesystem-windowsconfiguration-preferredsubnetid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PreferredSubnetId { get; set; }
        }
    }
}