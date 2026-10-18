namespace Humidifier.Lightsail
{
    using global::System.Collections.Generic;
    using ExportSnapshotRecordTypes;

    public class ExportSnapshotRecord : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string DestinationInfo =  "DestinationInfo" ;
            public static string SourceInfo =  "SourceInfo" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string ResourceType =  "ResourceType" ;
            public static string Name =  "Name" ;
            public static string State =  "State" ;
            public static string RecordId =  "RecordId" ;
            public static string Arn =  "Arn" ;
            public static string Location =  "Location" ;
        }

        public override string AWSTypeName { get => AWS.Lightsail.ExportSnapshotRecord; }
    }

    namespace ExportSnapshotRecordTypes
    {
        public class DestinationInfo : Humidifier.Base.BaseSubResource, IHaveService, IHaveId
        {
            /// <summary>
            /// Service
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-exportsnapshotrecord-destinationinfo.html#cfn-lightsail-exportsnapshotrecord-destinationinfo-service
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Service { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-exportsnapshotrecord-destinationinfo.html#cfn-lightsail-exportsnapshotrecord-destinationinfo-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
        }

        public class DiskInfo : Humidifier.Base.BaseSubResource, IHavePath, IHaveSizeInGb_Integer, IHaveIsSystemDisk_Boolean
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-exportsnapshotrecord-diskinfo.html#cfn-lightsail-exportsnapshotrecord-diskinfo-path
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Path { get; set; }
            /// <summary>
            /// SizeInGb
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-exportsnapshotrecord-diskinfo.html#cfn-lightsail-exportsnapshotrecord-diskinfo-sizeingb
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SizeInGb { get; set; }
            /// <summary>
            /// IsSystemDisk
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-exportsnapshotrecord-diskinfo.html#cfn-lightsail-exportsnapshotrecord-diskinfo-issystemdisk
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsSystemDisk { get; set; }
        }

        public class ExportSnapshotRecordSourceInfo : Humidifier.Base.BaseSubResource, IHaveFromResourceArn, IHaveLightsailExportSnapshotRecordTypesInstanceSnapshotInfoInstanceSnapshotInfo, IHaveCreatedAt, IHaveFromResourceName, IHaveResourceType, IHaveArn, IHaveName
        {
            /// <summary>
            /// FromResourceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-exportsnapshotrecord-exportsnapshotrecordsourceinfo.html#cfn-lightsail-exportsnapshotrecord-exportsnapshotrecordsourceinfo-fromresourcearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FromResourceArn { get; set; }
            /// <summary>
            /// InstanceSnapshotInfo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-exportsnapshotrecord-exportsnapshotrecordsourceinfo.html#cfn-lightsail-exportsnapshotrecord-exportsnapshotrecordsourceinfo-instancesnapshotinfo
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InstanceSnapshotInfo
            /// </summary>
            public Union<Humidifier.Lightsail.ExportSnapshotRecordTypes.InstanceSnapshotInfo, BaseFunction>? InstanceSnapshotInfo { get; set; }
            /// <summary>
            /// CreatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-exportsnapshotrecord-exportsnapshotrecordsourceinfo.html#cfn-lightsail-exportsnapshotrecord-exportsnapshotrecordsourceinfo-createdat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreatedAt { get; set; }
            /// <summary>
            /// FromResourceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-exportsnapshotrecord-exportsnapshotrecordsourceinfo.html#cfn-lightsail-exportsnapshotrecord-exportsnapshotrecordsourceinfo-fromresourcename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FromResourceName { get; set; }
            /// <summary>
            /// ResourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-exportsnapshotrecord-exportsnapshotrecordsourceinfo.html#cfn-lightsail-exportsnapshotrecord-exportsnapshotrecordsourceinfo-resourcetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceType { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-exportsnapshotrecord-exportsnapshotrecordsourceinfo.html#cfn-lightsail-exportsnapshotrecord-exportsnapshotrecordsourceinfo-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-exportsnapshotrecord-exportsnapshotrecordsourceinfo.html#cfn-lightsail-exportsnapshotrecord-exportsnapshotrecordsourceinfo-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class InstanceSnapshotInfo : Humidifier.Base.BaseSubResource, IHaveFromBundleId, IHaveFromBlueprintId, IHaveListOfLightsailExportSnapshotRecordTypesDiskInfoFromDiskInfo
        {
            /// <summary>
            /// FromBundleId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-exportsnapshotrecord-instancesnapshotinfo.html#cfn-lightsail-exportsnapshotrecord-instancesnapshotinfo-frombundleid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FromBundleId { get; set; }
            /// <summary>
            /// FromBlueprintId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-exportsnapshotrecord-instancesnapshotinfo.html#cfn-lightsail-exportsnapshotrecord-instancesnapshotinfo-fromblueprintid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FromBlueprintId { get; set; }
            /// <summary>
            /// FromDiskInfo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-exportsnapshotrecord-instancesnapshotinfo.html#cfn-lightsail-exportsnapshotrecord-instancesnapshotinfo-fromdiskinfo
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DiskInfo
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Lightsail.ExportSnapshotRecordTypes.DiskInfo>, IReadOnlyList<Union<Humidifier.Lightsail.ExportSnapshotRecordTypes.DiskInfo, BaseFunction>>, BaseFunction>? FromDiskInfo { get; set; }
        }

        public class ResourceLocation : Humidifier.Base.BaseSubResource, IHaveRegionName, IHaveAvailabilityZone
        {
            /// <summary>
            /// RegionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-exportsnapshotrecord-resourcelocation.html#cfn-lightsail-exportsnapshotrecord-resourcelocation-regionname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RegionName { get; set; }
            /// <summary>
            /// AvailabilityZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-exportsnapshotrecord-resourcelocation.html#cfn-lightsail-exportsnapshotrecord-resourcelocation-availabilityzone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AvailabilityZone { get; set; }
        }
    }
}