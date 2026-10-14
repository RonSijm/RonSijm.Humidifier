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
        public class DestinationInfo : Humidifier.Base.BaseSubResource, IHaveId, IHaveService
        {
            /// <summary>
            /// Service
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-exportsnapshotrecord-destinationinfo.html#cfn-lightsail-exportsnapshotrecord-destinationinfo-service
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Service { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-exportsnapshotrecord-destinationinfo.html#cfn-lightsail-exportsnapshotrecord-destinationinfo-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id { get; set; }
        }

        public class DiskInfo : Humidifier.Base.BaseSubResource, IHavePath, IHaveSizeInGb
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-exportsnapshotrecord-diskinfo.html#cfn-lightsail-exportsnapshotrecord-diskinfo-path
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Path { get; set; }
            /// <summary>
            /// SizeInGb
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-exportsnapshotrecord-diskinfo.html#cfn-lightsail-exportsnapshotrecord-diskinfo-sizeingb
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic SizeInGb { get; set; }
            /// <summary>
            /// IsSystemDisk
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-exportsnapshotrecord-diskinfo.html#cfn-lightsail-exportsnapshotrecord-diskinfo-issystemdisk
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsSystemDisk { get; set; }
        }

        public class ExportSnapshotRecordSourceInfo : Humidifier.Base.BaseSubResource, IHaveName, IHaveArn, IHaveResourceType, IHaveCreatedAt
        {
            /// <summary>
            /// FromResourceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-exportsnapshotrecord-exportsnapshotrecordsourceinfo.html#cfn-lightsail-exportsnapshotrecord-exportsnapshotrecordsourceinfo-fromresourcearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FromResourceArn { get; set; }
            /// <summary>
            /// InstanceSnapshotInfo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-exportsnapshotrecord-exportsnapshotrecordsourceinfo.html#cfn-lightsail-exportsnapshotrecord-exportsnapshotrecordsourceinfo-instancesnapshotinfo
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InstanceSnapshotInfo
            /// </summary>
            public Humidifier.Lightsail.ExportSnapshotRecordTypes.InstanceSnapshotInfo InstanceSnapshotInfo { get; set; }
            /// <summary>
            /// CreatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-exportsnapshotrecord-exportsnapshotrecordsourceinfo.html#cfn-lightsail-exportsnapshotrecord-exportsnapshotrecordsourceinfo-createdat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreatedAt { get; set; }
            /// <summary>
            /// FromResourceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-exportsnapshotrecord-exportsnapshotrecordsourceinfo.html#cfn-lightsail-exportsnapshotrecord-exportsnapshotrecordsourceinfo-fromresourcename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FromResourceName { get; set; }
            /// <summary>
            /// ResourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-exportsnapshotrecord-exportsnapshotrecordsourceinfo.html#cfn-lightsail-exportsnapshotrecord-exportsnapshotrecordsourceinfo-resourcetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResourceType { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-exportsnapshotrecord-exportsnapshotrecordsourceinfo.html#cfn-lightsail-exportsnapshotrecord-exportsnapshotrecordsourceinfo-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-exportsnapshotrecord-exportsnapshotrecordsourceinfo.html#cfn-lightsail-exportsnapshotrecord-exportsnapshotrecordsourceinfo-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class InstanceSnapshotInfo : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FromBundleId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-exportsnapshotrecord-instancesnapshotinfo.html#cfn-lightsail-exportsnapshotrecord-instancesnapshotinfo-frombundleid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FromBundleId { get; set; }
            /// <summary>
            /// FromBlueprintId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-exportsnapshotrecord-instancesnapshotinfo.html#cfn-lightsail-exportsnapshotrecord-instancesnapshotinfo-fromblueprintid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FromBlueprintId { get; set; }
            /// <summary>
            /// FromDiskInfo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-exportsnapshotrecord-instancesnapshotinfo.html#cfn-lightsail-exportsnapshotrecord-instancesnapshotinfo-fromdiskinfo
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DiskInfo
            /// </summary>
            public List<Humidifier.Lightsail.ExportSnapshotRecordTypes.DiskInfo> FromDiskInfo { get; set; }
        }

        public class ResourceLocation : Humidifier.Base.BaseSubResource, IHaveAvailabilityZone, IHaveRegionName
        {
            /// <summary>
            /// RegionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-exportsnapshotrecord-resourcelocation.html#cfn-lightsail-exportsnapshotrecord-resourcelocation-regionname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RegionName { get; set; }
            /// <summary>
            /// AvailabilityZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-exportsnapshotrecord-resourcelocation.html#cfn-lightsail-exportsnapshotrecord-resourcelocation-availabilityzone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AvailabilityZone { get; set; }
        }
    }
}