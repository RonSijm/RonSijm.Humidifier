namespace Humidifier.FSx
{
    using System.Collections.Generic;
    using VolumeTypes;

    public class Volume : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveVolumeType, IHaveBackupId
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
        public Humidifier.FSx.VolumeTypes.OpenZFSConfiguration OpenZFSConfiguration { get; set; }
        /// <summary>
        /// VolumeType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-volume.html#cfn-fsx-volume-volumetype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic VolumeType { get; set; }
        /// <summary>
        /// BackupId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-volume.html#cfn-fsx-volume-backupid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic BackupId { get; set; }
        /// <summary>
        /// OntapConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-volume.html#cfn-fsx-volume-ontapconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: OntapConfiguration
        /// </summary>
        public Humidifier.FSx.VolumeTypes.OntapConfiguration OntapConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-volume.html#cfn-fsx-volume-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace VolumeTypes
    {
        public class AggregateConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Aggregates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-ontapconfiguration-aggregateconfiguration.html#cfn-fsx-volume-ontapconfiguration-aggregateconfiguration-aggregates
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Aggregates { get; set; }
            /// <summary>
            /// ConstituentsPerAggregate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-ontapconfiguration-aggregateconfiguration.html#cfn-fsx-volume-ontapconfiguration-aggregateconfiguration-constituentsperaggregate
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ConstituentsPerAggregate { get; set; }
        }

        public class AutocommitPeriod : Humidifier.Base.BaseSubResource, IHaveType, IHaveValue
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-ontapconfiguration-snaplockconfiguration-autocommitperiod.html#cfn-fsx-volume-ontapconfiguration-snaplockconfiguration-autocommitperiod-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-ontapconfiguration-snaplockconfiguration-autocommitperiod.html#cfn-fsx-volume-ontapconfiguration-snaplockconfiguration-autocommitperiod-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Value { get; set; }
        }

        public class ClientConfigurations : Humidifier.Base.BaseSubResource, IHaveOptions, IHaveClients
        {
            /// <summary>
            /// Options
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-openzfsconfiguration-nfsexports-clientconfigurations.html#cfn-fsx-volume-openzfsconfiguration-nfsexports-clientconfigurations-options
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Options { get; set; }
            /// <summary>
            /// Clients
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-openzfsconfiguration-nfsexports-clientconfigurations.html#cfn-fsx-volume-openzfsconfiguration-nfsexports-clientconfigurations-clients
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Clients { get; set; }
        }

        public class NfsExports : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ClientConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-openzfsconfiguration-nfsexports.html#cfn-fsx-volume-openzfsconfiguration-nfsexports-clientconfigurations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ClientConfigurations
            /// </summary>
            public List<Humidifier.FSx.VolumeTypes.ClientConfigurations> ClientConfigurations { get; set; }
        }

        public class OntapConfiguration : Humidifier.Base.BaseSubResource, IHaveCopyTagsToBackups
        {
            /// <summary>
            /// JunctionPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-ontapconfiguration.html#cfn-fsx-volume-ontapconfiguration-junctionpath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic JunctionPath { get; set; }
            /// <summary>
            /// StorageVirtualMachineId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-ontapconfiguration.html#cfn-fsx-volume-ontapconfiguration-storagevirtualmachineid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StorageVirtualMachineId { get; set; }
            /// <summary>
            /// TieringPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-ontapconfiguration.html#cfn-fsx-volume-ontapconfiguration-tieringpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TieringPolicy
            /// </summary>
            public Humidifier.FSx.VolumeTypes.TieringPolicy TieringPolicy { get; set; }
            /// <summary>
            /// SizeInMegabytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-ontapconfiguration.html#cfn-fsx-volume-ontapconfiguration-sizeinmegabytes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SizeInMegabytes { get; set; }
            /// <summary>
            /// VolumeStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-ontapconfiguration.html#cfn-fsx-volume-ontapconfiguration-volumestyle
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VolumeStyle { get; set; }
            /// <summary>
            /// SizeInBytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-ontapconfiguration.html#cfn-fsx-volume-ontapconfiguration-sizeinbytes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SizeInBytes { get; set; }
            /// <summary>
            /// SecurityStyle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-ontapconfiguration.html#cfn-fsx-volume-ontapconfiguration-securitystyle
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecurityStyle { get; set; }
            /// <summary>
            /// SnaplockConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-ontapconfiguration.html#cfn-fsx-volume-ontapconfiguration-snaplockconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SnaplockConfiguration
            /// </summary>
            public Humidifier.FSx.VolumeTypes.SnaplockConfiguration SnaplockConfiguration { get; set; }
            /// <summary>
            /// AggregateConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-ontapconfiguration.html#cfn-fsx-volume-ontapconfiguration-aggregateconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AggregateConfiguration
            /// </summary>
            public Humidifier.FSx.VolumeTypes.AggregateConfiguration AggregateConfiguration { get; set; }
            /// <summary>
            /// SnapshotPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-ontapconfiguration.html#cfn-fsx-volume-ontapconfiguration-snapshotpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SnapshotPolicy { get; set; }
            /// <summary>
            /// StorageEfficiencyEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-ontapconfiguration.html#cfn-fsx-volume-ontapconfiguration-storageefficiencyenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StorageEfficiencyEnabled { get; set; }
            /// <summary>
            /// CopyTagsToBackups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-ontapconfiguration.html#cfn-fsx-volume-ontapconfiguration-copytagstobackups
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CopyTagsToBackups { get; set; }
            /// <summary>
            /// OntapVolumeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-ontapconfiguration.html#cfn-fsx-volume-ontapconfiguration-ontapvolumetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OntapVolumeType { get; set; }
        }

        public class OpenZFSConfiguration : Humidifier.Base.BaseSubResource, IHaveReadOnly, IHaveOptions, IHaveDataCompressionType, IHaveStorageCapacityQuotaGiB, IHaveCopyTagsToSnapshots, IHaveRecordSizeKiB
        {
            /// <summary>
            /// ReadOnly
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-openzfsconfiguration.html#cfn-fsx-volume-openzfsconfiguration-readonly
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ReadOnly { get; set; }
            /// <summary>
            /// Options
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-openzfsconfiguration.html#cfn-fsx-volume-openzfsconfiguration-options
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Options { get; set; }
            /// <summary>
            /// DataCompressionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-openzfsconfiguration.html#cfn-fsx-volume-openzfsconfiguration-datacompressiontype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataCompressionType { get; set; }
            /// <summary>
            /// NfsExports
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-openzfsconfiguration.html#cfn-fsx-volume-openzfsconfiguration-nfsexports
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: NfsExports
            /// </summary>
            public List<Humidifier.FSx.VolumeTypes.NfsExports> NfsExports { get; set; }
            /// <summary>
            /// StorageCapacityQuotaGiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-openzfsconfiguration.html#cfn-fsx-volume-openzfsconfiguration-storagecapacityquotagib
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic StorageCapacityQuotaGiB { get; set; }
            /// <summary>
            /// CopyTagsToSnapshots
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-openzfsconfiguration.html#cfn-fsx-volume-openzfsconfiguration-copytagstosnapshots
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic CopyTagsToSnapshots { get; set; }
            /// <summary>
            /// ParentVolumeId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-openzfsconfiguration.html#cfn-fsx-volume-openzfsconfiguration-parentvolumeid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParentVolumeId { get; set; }
            /// <summary>
            /// StorageCapacityReservationGiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-openzfsconfiguration.html#cfn-fsx-volume-openzfsconfiguration-storagecapacityreservationgib
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic StorageCapacityReservationGiB { get; set; }
            /// <summary>
            /// RecordSizeKiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-openzfsconfiguration.html#cfn-fsx-volume-openzfsconfiguration-recordsizekib
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RecordSizeKiB { get; set; }
            /// <summary>
            /// OriginSnapshot
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-openzfsconfiguration.html#cfn-fsx-volume-openzfsconfiguration-originsnapshot
            /// Required: False
            /// UpdateType: Immutable
            /// Type: OriginSnapshot
            /// </summary>
            public Humidifier.FSx.VolumeTypes.OriginSnapshot OriginSnapshot { get; set; }
            /// <summary>
            /// UserAndGroupQuotas
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-openzfsconfiguration.html#cfn-fsx-volume-openzfsconfiguration-userandgroupquotas
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: UserAndGroupQuotas
            /// </summary>
            public List<Humidifier.FSx.VolumeTypes.UserAndGroupQuotas> UserAndGroupQuotas { get; set; }
        }

        public class OriginSnapshot : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CopyStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-openzfsconfiguration-originsnapshot.html#cfn-fsx-volume-openzfsconfiguration-originsnapshot-copystrategy
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CopyStrategy { get; set; }
            /// <summary>
            /// SnapshotARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-openzfsconfiguration-originsnapshot.html#cfn-fsx-volume-openzfsconfiguration-originsnapshot-snapshotarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SnapshotARN { get; set; }
        }

        public class RetentionPeriod : Humidifier.Base.BaseSubResource, IHaveType, IHaveValue
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-retentionperiod.html#cfn-fsx-volume-retentionperiod-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-retentionperiod.html#cfn-fsx-volume-retentionperiod-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Value { get; set; }
        }

        public class SnaplockConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AuditLogVolume
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-ontapconfiguration-snaplockconfiguration.html#cfn-fsx-volume-ontapconfiguration-snaplockconfiguration-auditlogvolume
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AuditLogVolume { get; set; }
            /// <summary>
            /// VolumeAppendModeEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-ontapconfiguration-snaplockconfiguration.html#cfn-fsx-volume-ontapconfiguration-snaplockconfiguration-volumeappendmodeenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VolumeAppendModeEnabled { get; set; }
            /// <summary>
            /// AutocommitPeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-ontapconfiguration-snaplockconfiguration.html#cfn-fsx-volume-ontapconfiguration-snaplockconfiguration-autocommitperiod
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AutocommitPeriod
            /// </summary>
            public Humidifier.FSx.VolumeTypes.AutocommitPeriod AutocommitPeriod { get; set; }
            /// <summary>
            /// RetentionPeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-ontapconfiguration-snaplockconfiguration.html#cfn-fsx-volume-ontapconfiguration-snaplockconfiguration-retentionperiod
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SnaplockRetentionPeriod
            /// </summary>
            public Humidifier.FSx.VolumeTypes.SnaplockRetentionPeriod RetentionPeriod { get; set; }
            /// <summary>
            /// PrivilegedDelete
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-ontapconfiguration-snaplockconfiguration.html#cfn-fsx-volume-ontapconfiguration-snaplockconfiguration-privilegeddelete
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PrivilegedDelete { get; set; }
            /// <summary>
            /// SnaplockType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-ontapconfiguration-snaplockconfiguration.html#cfn-fsx-volume-ontapconfiguration-snaplockconfiguration-snaplocktype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SnaplockType { get; set; }
        }

        public class SnaplockRetentionPeriod : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DefaultRetention
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-snaplockretentionperiod.html#cfn-fsx-volume-snaplockretentionperiod-defaultretention
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RetentionPeriod
            /// </summary>
            public Humidifier.FSx.VolumeTypes.RetentionPeriod DefaultRetention { get; set; }
            /// <summary>
            /// MaximumRetention
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-snaplockretentionperiod.html#cfn-fsx-volume-snaplockretentionperiod-maximumretention
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RetentionPeriod
            /// </summary>
            public Humidifier.FSx.VolumeTypes.RetentionPeriod MaximumRetention { get; set; }
            /// <summary>
            /// MinimumRetention
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-snaplockretentionperiod.html#cfn-fsx-volume-snaplockretentionperiod-minimumretention
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RetentionPeriod
            /// </summary>
            public Humidifier.FSx.VolumeTypes.RetentionPeriod MinimumRetention { get; set; }
        }

        public class TieringPolicy : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// CoolingPeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-ontapconfiguration-tieringpolicy.html#cfn-fsx-volume-ontapconfiguration-tieringpolicy-coolingperiod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic CoolingPeriod { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-ontapconfiguration-tieringpolicy.html#cfn-fsx-volume-ontapconfiguration-tieringpolicy-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class UserAndGroupQuotas : Humidifier.Base.BaseSubResource, IHaveType, IHaveId, IHaveStorageCapacityQuotaGiB
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-openzfsconfiguration-userandgroupquotas.html#cfn-fsx-volume-openzfsconfiguration-userandgroupquotas-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-openzfsconfiguration-userandgroupquotas.html#cfn-fsx-volume-openzfsconfiguration-userandgroupquotas-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Id { get; set; }
            /// <summary>
            /// StorageCapacityQuotaGiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-volume-openzfsconfiguration-userandgroupquotas.html#cfn-fsx-volume-openzfsconfiguration-userandgroupquotas-storagecapacityquotagib
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic StorageCapacityQuotaGiB { get; set; }
        }
    }
}