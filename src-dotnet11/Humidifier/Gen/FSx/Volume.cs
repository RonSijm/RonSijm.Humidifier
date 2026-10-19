namespace Humidifier.FSx
{
    using global::System.Collections.Generic;
    using VolumeTypes;

    public class Volume : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveFSxVolumeTypesOpenZFSConfigurationOpenZFSConfiguration, IHaveVolumeType, IHaveBackupId, IHaveFSxVolumeTypesOntapConfigurationOntapConfiguration, IHaveName
    {
        public class Attributes
        {
            public static string ResourceARN =  "ResourceARN" ;
            public static string VolumeId =  "VolumeId" ;
            public static string UUID =  "UUID" ;
        }

        public override string AWSTypeName { get => AWS.FSx.Volume; }
        /// <summary>
        /// OpenZFSConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-volume.html#cfn-fsx-volume-openzfsconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: OpenZFSConfiguration
        /// </summary>
        public Union<Humidifier.FSx.VolumeTypes.OpenZFSConfiguration, BaseFunction>? OpenZFSConfiguration { get; set; }
        /// <summary>
        /// VolumeType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-volume.html#cfn-fsx-volume-volumetype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VolumeType { get; set; }
        /// <summary>
        /// BackupId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-volume.html#cfn-fsx-volume-backupid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? BackupId { get; set; }
        /// <summary>
        /// OntapConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-volume.html#cfn-fsx-volume-ontapconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: OntapConfiguration
        /// </summary>
        public Union<Humidifier.FSx.VolumeTypes.OntapConfiguration, BaseFunction>? OntapConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-volume.html#cfn-fsx-volume-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace VolumeTypes
    {
        public class AggregateConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfAggregates, IHaveConstituentsPerAggregate_Integer
        {
            /// <summary>
            /// Aggregates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-aggregateconfiguration.html#cfn-fsx-volume-aggregateconfiguration-aggregates
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Aggregates { get; set; }
            /// <summary>
            /// ConstituentsPerAggregate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-aggregateconfiguration.html#cfn-fsx-volume-aggregateconfiguration-constituentsperaggregate
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ConstituentsPerAggregate { get; set; }
        }

        public class AutocommitPeriod : Humidifier.Base.BaseSubResource, IHaveType, IHaveValue_Integer
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-autocommitperiod.html#cfn-fsx-volume-autocommitperiod-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-autocommitperiod.html#cfn-fsx-volume-autocommitperiod-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Value { get; set; }
        }

        public class ClientConfigurations : Humidifier.Base.BaseSubResource, IHaveStringListOfOptions, IHaveClients
        {
            /// <summary>
            /// Options
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-clientconfigurations.html#cfn-fsx-volume-clientconfigurations-options
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Options { get; set; }
            /// <summary>
            /// Clients
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-clientconfigurations.html#cfn-fsx-volume-clientconfigurations-clients
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Clients { get; set; }
        }

        public class NfsExports : Humidifier.Base.BaseSubResource, IHaveListOfFSxVolumeTypesClientConfigurationsClientConfigurations
        {
            /// <summary>
            /// ClientConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-nfsexports.html#cfn-fsx-volume-nfsexports-clientconfigurations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ClientConfigurations
            /// </summary>
            public Union<IReadOnlyList<Humidifier.FSx.VolumeTypes.ClientConfigurations>, IReadOnlyList<Union<Humidifier.FSx.VolumeTypes.ClientConfigurations, BaseFunction>>, BaseFunction>? ClientConfigurations { get; set; }
        }

        public class OntapConfiguration : Humidifier.Base.BaseSubResource, IHaveJunctionPath, IHaveStorageVirtualMachineId, IHaveFSxVolumeTypesTieringPolicyTieringPolicy, IHaveSizeInMegabytes, IHaveVolumeStyle, IHaveSizeInBytes, IHaveSecurityStyle, IHaveFSxVolumeTypesSnaplockConfigurationSnaplockConfiguration, IHaveFSxVolumeTypesAggregateConfigurationAggregateConfiguration, IHaveSnapshotPolicy, IHaveStorageEfficiencyEnabled, IHaveCopyTagsToBackups, IHaveOntapVolumeType
        {
            /// <summary>
            /// JunctionPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-ontapconfiguration.html#cfn-fsx-volume-ontapconfiguration-junctionpath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? JunctionPath { get; set; }
            /// <summary>
            /// StorageVirtualMachineId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-ontapconfiguration.html#cfn-fsx-volume-ontapconfiguration-storagevirtualmachineid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StorageVirtualMachineId { get; set; }
            /// <summary>
            /// TieringPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-ontapconfiguration.html#cfn-fsx-volume-ontapconfiguration-tieringpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TieringPolicy
            /// </summary>
            public Union<Humidifier.FSx.VolumeTypes.TieringPolicy, BaseFunction>? TieringPolicy { get; set; }
            /// <summary>
            /// SizeInMegabytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-ontapconfiguration.html#cfn-fsx-volume-ontapconfiguration-sizeinmegabytes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SizeInMegabytes { get; set; }
            /// <summary>
            /// VolumeStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-ontapconfiguration.html#cfn-fsx-volume-ontapconfiguration-volumestyle
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VolumeStyle { get; set; }
            /// <summary>
            /// SizeInBytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-ontapconfiguration.html#cfn-fsx-volume-ontapconfiguration-sizeinbytes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SizeInBytes { get; set; }
            /// <summary>
            /// SecurityStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-ontapconfiguration.html#cfn-fsx-volume-ontapconfiguration-securitystyle
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecurityStyle { get; set; }
            /// <summary>
            /// SnaplockConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-ontapconfiguration.html#cfn-fsx-volume-ontapconfiguration-snaplockconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SnaplockConfiguration
            /// </summary>
            public Union<Humidifier.FSx.VolumeTypes.SnaplockConfiguration, BaseFunction>? SnaplockConfiguration { get; set; }
            /// <summary>
            /// AggregateConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-ontapconfiguration.html#cfn-fsx-volume-ontapconfiguration-aggregateconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AggregateConfiguration
            /// </summary>
            public Union<Humidifier.FSx.VolumeTypes.AggregateConfiguration, BaseFunction>? AggregateConfiguration { get; set; }
            /// <summary>
            /// SnapshotPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-ontapconfiguration.html#cfn-fsx-volume-ontapconfiguration-snapshotpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SnapshotPolicy { get; set; }
            /// <summary>
            /// StorageEfficiencyEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-ontapconfiguration.html#cfn-fsx-volume-ontapconfiguration-storageefficiencyenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StorageEfficiencyEnabled { get; set; }
            /// <summary>
            /// CopyTagsToBackups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-ontapconfiguration.html#cfn-fsx-volume-ontapconfiguration-copytagstobackups
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CopyTagsToBackups { get; set; }
            /// <summary>
            /// OntapVolumeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-ontapconfiguration.html#cfn-fsx-volume-ontapconfiguration-ontapvolumetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OntapVolumeType { get; set; }
        }

        public class OpenZFSConfiguration : Humidifier.Base.BaseSubResource, IHaveReadOnly_Boolean, IHaveStringListOfOptions, IHaveDataCompressionType, IHaveListOfFSxVolumeTypesNfsExportsNfsExports, IHaveStorageCapacityQuotaGiB_Integer, IHaveCopyTagsToSnapshots_Boolean, IHaveParentVolumeId, IHaveStorageCapacityReservationGiB_Integer, IHaveRecordSizeKiB_Integer, IHaveFSxVolumeTypesOriginSnapshotOriginSnapshot, IHaveListOfFSxVolumeTypesUserAndGroupQuotasUserAndGroupQuotas
        {
            /// <summary>
            /// ReadOnly
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-openzfsconfiguration.html#cfn-fsx-volume-openzfsconfiguration-readonly
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ReadOnly { get; set; }
            /// <summary>
            /// Options
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-openzfsconfiguration.html#cfn-fsx-volume-openzfsconfiguration-options
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Options { get; set; }
            /// <summary>
            /// DataCompressionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-openzfsconfiguration.html#cfn-fsx-volume-openzfsconfiguration-datacompressiontype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataCompressionType { get; set; }
            /// <summary>
            /// NfsExports
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-openzfsconfiguration.html#cfn-fsx-volume-openzfsconfiguration-nfsexports
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: NfsExports
            /// </summary>
            public Union<IReadOnlyList<Humidifier.FSx.VolumeTypes.NfsExports>, IReadOnlyList<Union<Humidifier.FSx.VolumeTypes.NfsExports, BaseFunction>>, BaseFunction>? NfsExports { get; set; }
            /// <summary>
            /// StorageCapacityQuotaGiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-openzfsconfiguration.html#cfn-fsx-volume-openzfsconfiguration-storagecapacityquotagib
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? StorageCapacityQuotaGiB { get; set; }
            /// <summary>
            /// CopyTagsToSnapshots
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-openzfsconfiguration.html#cfn-fsx-volume-openzfsconfiguration-copytagstosnapshots
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? CopyTagsToSnapshots { get; set; }
            /// <summary>
            /// ParentVolumeId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-openzfsconfiguration.html#cfn-fsx-volume-openzfsconfiguration-parentvolumeid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ParentVolumeId { get; set; }
            /// <summary>
            /// StorageCapacityReservationGiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-openzfsconfiguration.html#cfn-fsx-volume-openzfsconfiguration-storagecapacityreservationgib
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? StorageCapacityReservationGiB { get; set; }
            /// <summary>
            /// RecordSizeKiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-openzfsconfiguration.html#cfn-fsx-volume-openzfsconfiguration-recordsizekib
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RecordSizeKiB { get; set; }
            /// <summary>
            /// OriginSnapshot
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-openzfsconfiguration.html#cfn-fsx-volume-openzfsconfiguration-originsnapshot
            /// Required: False
            /// UpdateType: Immutable
            /// Type: OriginSnapshot
            /// </summary>
            public Union<Humidifier.FSx.VolumeTypes.OriginSnapshot, BaseFunction>? OriginSnapshot { get; set; }
            /// <summary>
            /// UserAndGroupQuotas
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-openzfsconfiguration.html#cfn-fsx-volume-openzfsconfiguration-userandgroupquotas
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: UserAndGroupQuotas
            /// </summary>
            public Union<IReadOnlyList<Humidifier.FSx.VolumeTypes.UserAndGroupQuotas>, IReadOnlyList<Union<Humidifier.FSx.VolumeTypes.UserAndGroupQuotas, BaseFunction>>, BaseFunction>? UserAndGroupQuotas { get; set; }
        }

        public class OriginSnapshot : Humidifier.Base.BaseSubResource, IHaveCopyStrategy, IHaveSnapshotARN
        {
            /// <summary>
            /// CopyStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-originsnapshot.html#cfn-fsx-volume-originsnapshot-copystrategy
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CopyStrategy { get; set; }
            /// <summary>
            /// SnapshotARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-originsnapshot.html#cfn-fsx-volume-originsnapshot-snapshotarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SnapshotARN { get; set; }
        }

        public class RetentionPeriod : Humidifier.Base.BaseSubResource, IHaveValue_Integer, IHaveType
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-retentionperiod.html#cfn-fsx-volume-retentionperiod-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-retentionperiod.html#cfn-fsx-volume-retentionperiod-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
        }

        public class SnaplockConfiguration : Humidifier.Base.BaseSubResource, IHaveAuditLogVolume, IHaveVolumeAppendModeEnabled, IHaveFSxVolumeTypesAutocommitPeriodAutocommitPeriod, IHaveFSxVolumeTypesSnaplockRetentionPeriodRetentionPeriod, IHavePrivilegedDelete, IHaveSnaplockType
        {
            /// <summary>
            /// AuditLogVolume
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-snaplockconfiguration.html#cfn-fsx-volume-snaplockconfiguration-auditlogvolume
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuditLogVolume { get; set; }
            /// <summary>
            /// VolumeAppendModeEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-snaplockconfiguration.html#cfn-fsx-volume-snaplockconfiguration-volumeappendmodeenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VolumeAppendModeEnabled { get; set; }
            /// <summary>
            /// AutocommitPeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-snaplockconfiguration.html#cfn-fsx-volume-snaplockconfiguration-autocommitperiod
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AutocommitPeriod
            /// </summary>
            public Union<Humidifier.FSx.VolumeTypes.AutocommitPeriod, BaseFunction>? AutocommitPeriod { get; set; }
            /// <summary>
            /// RetentionPeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-snaplockconfiguration.html#cfn-fsx-volume-snaplockconfiguration-retentionperiod
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SnaplockRetentionPeriod
            /// </summary>
            public Union<Humidifier.FSx.VolumeTypes.SnaplockRetentionPeriod, BaseFunction>? RetentionPeriod { get; set; }
            /// <summary>
            /// PrivilegedDelete
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-snaplockconfiguration.html#cfn-fsx-volume-snaplockconfiguration-privilegeddelete
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrivilegedDelete { get; set; }
            /// <summary>
            /// SnaplockType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-snaplockconfiguration.html#cfn-fsx-volume-snaplockconfiguration-snaplocktype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SnaplockType { get; set; }
        }

        public class SnaplockRetentionPeriod : Humidifier.Base.BaseSubResource, IHaveFSxVolumeTypesRetentionPeriodDefaultRetention, IHaveFSxVolumeTypesRetentionPeriodMaximumRetention, IHaveFSxVolumeTypesRetentionPeriodMinimumRetention
        {
            /// <summary>
            /// DefaultRetention
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-snaplockretentionperiod.html#cfn-fsx-volume-snaplockretentionperiod-defaultretention
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RetentionPeriod
            /// </summary>
            public Union<Humidifier.FSx.VolumeTypes.RetentionPeriod, BaseFunction>? DefaultRetention { get; set; }
            /// <summary>
            /// MaximumRetention
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-snaplockretentionperiod.html#cfn-fsx-volume-snaplockretentionperiod-maximumretention
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RetentionPeriod
            /// </summary>
            public Union<Humidifier.FSx.VolumeTypes.RetentionPeriod, BaseFunction>? MaximumRetention { get; set; }
            /// <summary>
            /// MinimumRetention
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-snaplockretentionperiod.html#cfn-fsx-volume-snaplockretentionperiod-minimumretention
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RetentionPeriod
            /// </summary>
            public Union<Humidifier.FSx.VolumeTypes.RetentionPeriod, BaseFunction>? MinimumRetention { get; set; }
        }

        public class TieringPolicy : Humidifier.Base.BaseSubResource, IHaveCoolingPeriod_Integer, IHaveName
        {
            /// <summary>
            /// CoolingPeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-tieringpolicy.html#cfn-fsx-volume-tieringpolicy-coolingperiod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? CoolingPeriod { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-tieringpolicy.html#cfn-fsx-volume-tieringpolicy-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class UserAndGroupQuotas : Humidifier.Base.BaseSubResource, IHaveType, IHaveId_Integer, IHaveStorageCapacityQuotaGiB_Integer
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-userandgroupquotas.html#cfn-fsx-volume-userandgroupquotas-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-userandgroupquotas.html#cfn-fsx-volume-userandgroupquotas-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Id { get; set; }
            /// <summary>
            /// StorageCapacityQuotaGiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-userandgroupquotas.html#cfn-fsx-volume-userandgroupquotas-storagecapacityquotagib
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? StorageCapacityQuotaGiB { get; set; }
        }
    }
}