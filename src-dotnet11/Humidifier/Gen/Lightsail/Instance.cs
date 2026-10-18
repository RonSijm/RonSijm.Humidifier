namespace Humidifier.Lightsail
{
    using global::System.Collections.Generic;
    using InstanceTypes;

    public class Instance : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveInstanceName, IHaveKeyPairName, IHaveBundleId, IHaveBlueprintId, IHaveLightsailInstanceTypesNetworkingNetworking, IHaveUserData, IHaveLightsailInstanceTypesStateState, IHaveAvailabilityZone, IHaveListOfLightsailInstanceTypesAddOnAddOns, IHaveLightsailInstanceTypesHardwareHardware, IHaveLightsailInstanceTypesLocationLocation
    {
        public class Attributes
        {
            public static string SshKeyName =  "SshKeyName" ;
            public static string IsStaticIp =  "IsStaticIp" ;
            public static string PrivateIpAddress =  "PrivateIpAddress" ;
            public static string UserName =  "UserName" ;
            public static string ResourceType =  "ResourceType" ;
            public static string Ipv6Addresses =  "Ipv6Addresses" ;
            public static string PublicIpAddress =  "PublicIpAddress" ;
            public static string SupportCode =  "SupportCode" ;
            public static string InstanceArn =  "InstanceArn" ;
        }

        public override string AWSTypeName { get => AWS.Lightsail.Instance; }
        public Union<string, BaseFunction>? InstanceName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// KeyPairName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-instance.html#cfn-lightsail-instance-keypairname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KeyPairName { get; set; }

        /// <summary>
        /// BundleId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-instance.html#cfn-lightsail-instance-bundleid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? BundleId { get; set; }

        /// <summary>
        /// BlueprintId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-instance.html#cfn-lightsail-instance-blueprintid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? BlueprintId { get; set; }
        /// <summary>
        /// Networking
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-instance.html#cfn-lightsail-instance-networking
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Networking
        /// </summary>
        public Union<Humidifier.Lightsail.InstanceTypes.Networking, BaseFunction>? Networking { get; set; }
        /// <summary>
        /// UserData
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-instance.html#cfn-lightsail-instance-userdata
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? UserData { get; set; }
        /// <summary>
        /// State
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-instance.html#cfn-lightsail-instance-state
        /// Required: False
        /// UpdateType: Mutable
        /// Type: State
        /// </summary>
        public Union<Humidifier.Lightsail.InstanceTypes.State, BaseFunction>? State { get; set; }
        /// <summary>
        /// AvailabilityZone
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-instance.html#cfn-lightsail-instance-availabilityzone
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AvailabilityZone { get; set; }
        /// <summary>
        /// AddOns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-instance.html#cfn-lightsail-instance-addons
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AddOn
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Lightsail.InstanceTypes.AddOn>, IReadOnlyList<Union<Humidifier.Lightsail.InstanceTypes.AddOn, BaseFunction>>, BaseFunction>? AddOns { get; set; }
        /// <summary>
        /// Hardware
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-instance.html#cfn-lightsail-instance-hardware
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Hardware
        /// </summary>
        public Union<Humidifier.Lightsail.InstanceTypes.Hardware, BaseFunction>? Hardware { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-instance.html#cfn-lightsail-instance-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// Location
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-instance.html#cfn-lightsail-instance-location
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Location
        /// </summary>
        public Union<Humidifier.Lightsail.InstanceTypes.Location, BaseFunction>? Location { get; set; }
    }

    namespace InstanceTypes
    {
        public class AddOn : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveAddOnType, IHaveLightsailInstanceTypesAutoSnapshotAddOnAutoSnapshotAddOnRequest
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-instance-addon.html#cfn-lightsail-instance-addon-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// AddOnType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-instance-addon.html#cfn-lightsail-instance-addon-addontype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AddOnType { get; set; }
            /// <summary>
            /// AutoSnapshotAddOnRequest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-instance-addon.html#cfn-lightsail-instance-addon-autosnapshotaddonrequest
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AutoSnapshotAddOn
            /// </summary>
            public Union<Humidifier.Lightsail.InstanceTypes.AutoSnapshotAddOn, BaseFunction>? AutoSnapshotAddOnRequest { get; set; }
        }

        public class AutoSnapshotAddOn : Humidifier.Base.BaseSubResource, IHaveSnapshotTimeOfDay
        {
            /// <summary>
            /// SnapshotTimeOfDay
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-instance-autosnapshotaddon.html#cfn-lightsail-instance-autosnapshotaddon-snapshottimeofday
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SnapshotTimeOfDay { get; set; }
        }

        public class Disk : Humidifier.Base.BaseSubResource, IHaveSizeInGb, IHavePath, IHaveAttachmentState, IHaveIsSystemDisk_Boolean, IHaveAttachedTo, IHaveIOPS_Integer, IHaveDiskName
        {
            /// <summary>
            /// SizeInGb
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-instance-disk.html#cfn-lightsail-instance-disk-sizeingb
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SizeInGb { get; set; }
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-instance-disk.html#cfn-lightsail-instance-disk-path
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Path { get; set; }
            /// <summary>
            /// AttachmentState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-instance-disk.html#cfn-lightsail-instance-disk-attachmentstate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AttachmentState { get; set; }
            /// <summary>
            /// IsSystemDisk
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-instance-disk.html#cfn-lightsail-instance-disk-issystemdisk
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsSystemDisk { get; set; }
            /// <summary>
            /// AttachedTo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-instance-disk.html#cfn-lightsail-instance-disk-attachedto
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AttachedTo { get; set; }
            /// <summary>
            /// IOPS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-instance-disk.html#cfn-lightsail-instance-disk-iops
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? IOPS { get; set; }
            /// <summary>
            /// DiskName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-instance-disk.html#cfn-lightsail-instance-disk-diskname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DiskName { get; set; }
        }

        public class Hardware : Humidifier.Base.BaseSubResource, IHaveCpuCount_Integer, IHaveRamSizeInGb_Integer, IHaveListOfLightsailInstanceTypesDiskDisks
        {
            /// <summary>
            /// CpuCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-instance-hardware.html#cfn-lightsail-instance-hardware-cpucount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? CpuCount { get; set; }
            /// <summary>
            /// RamSizeInGb
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-instance-hardware.html#cfn-lightsail-instance-hardware-ramsizeingb
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RamSizeInGb { get; set; }
            /// <summary>
            /// Disks
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-instance-hardware.html#cfn-lightsail-instance-hardware-disks
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Disk
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Lightsail.InstanceTypes.Disk>, IReadOnlyList<Union<Humidifier.Lightsail.InstanceTypes.Disk, BaseFunction>>, BaseFunction>? Disks { get; set; }
        }

        public class Location : Humidifier.Base.BaseSubResource, IHaveRegionName, IHaveAvailabilityZone
        {
            /// <summary>
            /// RegionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-instance-location.html#cfn-lightsail-instance-location-regionname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RegionName { get; set; }
            /// <summary>
            /// AvailabilityZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-instance-location.html#cfn-lightsail-instance-location-availabilityzone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AvailabilityZone { get; set; }
        }

        public class MonthlyTransfer : Humidifier.Base.BaseSubResource, IHaveGbPerMonthAllocated
        {
            /// <summary>
            /// GbPerMonthAllocated
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-instance-monthlytransfer.html#cfn-lightsail-instance-monthlytransfer-gbpermonthallocated
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GbPerMonthAllocated { get; set; }
        }

        public class Networking : Humidifier.Base.BaseSubResource, IHaveListOfLightsailInstanceTypesPortPorts, IHaveLightsailInstanceTypesMonthlyTransferMonthlyTransfer
        {
            /// <summary>
            /// Ports
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-instance-networking.html#cfn-lightsail-instance-networking-ports
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Port
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Lightsail.InstanceTypes.Port>, IReadOnlyList<Union<Humidifier.Lightsail.InstanceTypes.Port, BaseFunction>>, BaseFunction>? Ports { get; set; }
            /// <summary>
            /// MonthlyTransfer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-instance-networking.html#cfn-lightsail-instance-networking-monthlytransfer
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MonthlyTransfer
            /// </summary>
            public Union<Humidifier.Lightsail.InstanceTypes.MonthlyTransfer, BaseFunction>? MonthlyTransfer { get; set; }
        }

        public class Port : Humidifier.Base.BaseSubResource, IHaveFromPort_Integer, IHaveAccessDirection, IHaveStringListOfCidrListAliases, IHaveToPort_Integer, IHaveStringListOfIpv6Cidrs, IHaveAccessFrom, IHaveProtocol, IHaveAccessType, IHaveStringListOfCidrs, IHaveCommonName
        {
            /// <summary>
            /// FromPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-instance-port.html#cfn-lightsail-instance-port-fromport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FromPort { get; set; }
            /// <summary>
            /// AccessDirection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-instance-port.html#cfn-lightsail-instance-port-accessdirection
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccessDirection { get; set; }
            /// <summary>
            /// CidrListAliases
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-instance-port.html#cfn-lightsail-instance-port-cidrlistaliases
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CidrListAliases { get; set; }
            /// <summary>
            /// ToPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-instance-port.html#cfn-lightsail-instance-port-toport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ToPort { get; set; }
            /// <summary>
            /// Ipv6Cidrs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-instance-port.html#cfn-lightsail-instance-port-ipv6cidrs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Ipv6Cidrs { get; set; }
            /// <summary>
            /// AccessFrom
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-instance-port.html#cfn-lightsail-instance-port-accessfrom
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccessFrom { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-instance-port.html#cfn-lightsail-instance-port-protocol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Protocol { get; set; }
            /// <summary>
            /// AccessType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-instance-port.html#cfn-lightsail-instance-port-accesstype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccessType { get; set; }
            /// <summary>
            /// Cidrs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-instance-port.html#cfn-lightsail-instance-port-cidrs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Cidrs { get; set; }
            /// <summary>
            /// CommonName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-instance-port.html#cfn-lightsail-instance-port-commonname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CommonName { get; set; }
        }

        public class State : Humidifier.Base.BaseSubResource, IHaveCode_Integer, IHaveName
        {
            /// <summary>
            /// Code
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-instance-state.html#cfn-lightsail-instance-state-code
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Code { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-instance-state.html#cfn-lightsail-instance-state-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }
    }
}