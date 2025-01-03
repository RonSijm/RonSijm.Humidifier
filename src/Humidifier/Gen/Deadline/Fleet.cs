namespace Humidifier.Deadline
{
    using System.Collections.Generic;
    using FleetTypes;

    public class Fleet : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveRoleArn, IHaveDisplayName, IHaveFarmId
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string Capabilities =  "Capabilities" ;
            public static string FleetId =  "FleetId" ;
            public static string WorkerCount =  "WorkerCount" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Deadline.Fleet; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-fleet.html#cfn-deadline-fleet-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-fleet.html#cfn-deadline-fleet-configuration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: FleetConfiguration
        /// </summary>
        [Required]
        public Humidifier.Deadline.FleetTypes.FleetConfiguration Configuration { get; set; }

        /// <summary>
        /// MaxWorkerCount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-fleet.html#cfn-deadline-fleet-maxworkercount
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public dynamic MaxWorkerCount { get; set; }

        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-fleet.html#cfn-deadline-fleet-displayname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DisplayName { get; set; }
        /// <summary>
        /// MinWorkerCount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-fleet.html#cfn-deadline-fleet-minworkercount
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic MinWorkerCount { get; set; }

        /// <summary>
        /// FarmId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-fleet.html#cfn-deadline-fleet-farmid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic FarmId { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-fleet.html#cfn-deadline-fleet-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-fleet.html#cfn-deadline-fleet-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace FleetTypes
    {
        public class AcceleratorCapabilities : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Selections
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-acceleratorcapabilities.html#cfn-deadline-fleet-acceleratorcapabilities-selections
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AcceleratorSelection
            /// </summary>
            public List<Humidifier.Deadline.FleetTypes.AcceleratorSelection> Selections { get; set; }
            /// <summary>
            /// Count
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-acceleratorcapabilities.html#cfn-deadline-fleet-acceleratorcapabilities-count
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AcceleratorCountRange
            /// </summary>
            public Humidifier.Deadline.FleetTypes.AcceleratorCountRange Count { get; set; }
        }

        public class AcceleratorCountRange : Humidifier.Base.BaseSubResource, IHaveMin, IHaveMax
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-acceleratorcountrange.html#cfn-deadline-fleet-acceleratorcountrange-min
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-acceleratorcountrange.html#cfn-deadline-fleet-acceleratorcountrange-max
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Max { get; set; }
        }

        public class AcceleratorSelection : Humidifier.Base.BaseSubResource, IHaveName, IHaveRuntime
        {
            /// <summary>
            /// Runtime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-acceleratorselection.html#cfn-deadline-fleet-acceleratorselection-runtime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Runtime { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-acceleratorselection.html#cfn-deadline-fleet-acceleratorselection-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class AcceleratorTotalMemoryMiBRange : Humidifier.Base.BaseSubResource, IHaveMin, IHaveMax
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-acceleratortotalmemorymibrange.html#cfn-deadline-fleet-acceleratortotalmemorymibrange-min
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-acceleratortotalmemorymibrange.html#cfn-deadline-fleet-acceleratortotalmemorymibrange-max
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Max { get; set; }
        }

        public class CustomerManagedFleetConfiguration : Humidifier.Base.BaseSubResource, IHaveMode
        {
            /// <summary>
            /// StorageProfileId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-customermanagedfleetconfiguration.html#cfn-deadline-fleet-customermanagedfleetconfiguration-storageprofileid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StorageProfileId { get; set; }
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-customermanagedfleetconfiguration.html#cfn-deadline-fleet-customermanagedfleetconfiguration-mode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Mode { get; set; }
            /// <summary>
            /// WorkerCapabilities
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-customermanagedfleetconfiguration.html#cfn-deadline-fleet-customermanagedfleetconfiguration-workercapabilities
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CustomerManagedWorkerCapabilities
            /// </summary>
            public Humidifier.Deadline.FleetTypes.CustomerManagedWorkerCapabilities WorkerCapabilities { get; set; }
        }

        public class CustomerManagedWorkerCapabilities : Humidifier.Base.BaseSubResource, IHaveAcceleratorTypes, IHaveOsFamily
        {
            /// <summary>
            /// CustomAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-customermanagedworkercapabilities.html#cfn-deadline-fleet-customermanagedworkercapabilities-customattributes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FleetAttributeCapability
            /// </summary>
            public List<Humidifier.Deadline.FleetTypes.FleetAttributeCapability> CustomAttributes { get; set; }
            /// <summary>
            /// AcceleratorCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-customermanagedworkercapabilities.html#cfn-deadline-fleet-customermanagedworkercapabilities-acceleratorcount
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AcceleratorCountRange
            /// </summary>
            public Humidifier.Deadline.FleetTypes.AcceleratorCountRange AcceleratorCount { get; set; }
            /// <summary>
            /// CustomAmounts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-customermanagedworkercapabilities.html#cfn-deadline-fleet-customermanagedworkercapabilities-customamounts
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FleetAmountCapability
            /// </summary>
            public List<Humidifier.Deadline.FleetTypes.FleetAmountCapability> CustomAmounts { get; set; }
            /// <summary>
            /// AcceleratorTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-customermanagedworkercapabilities.html#cfn-deadline-fleet-customermanagedworkercapabilities-acceleratortypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AcceleratorTypes { get; set; }
            /// <summary>
            /// AcceleratorTotalMemoryMiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-customermanagedworkercapabilities.html#cfn-deadline-fleet-customermanagedworkercapabilities-acceleratortotalmemorymib
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AcceleratorTotalMemoryMiBRange
            /// </summary>
            public Humidifier.Deadline.FleetTypes.AcceleratorTotalMemoryMiBRange AcceleratorTotalMemoryMiB { get; set; }
            /// <summary>
            /// VCpuCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-customermanagedworkercapabilities.html#cfn-deadline-fleet-customermanagedworkercapabilities-vcpucount
            /// Required: True
            /// UpdateType: Mutable
            /// Type: VCpuCountRange
            /// </summary>
            public Humidifier.Deadline.FleetTypes.VCpuCountRange VCpuCount { get; set; }
            /// <summary>
            /// MemoryMiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-customermanagedworkercapabilities.html#cfn-deadline-fleet-customermanagedworkercapabilities-memorymib
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MemoryMiBRange
            /// </summary>
            public Humidifier.Deadline.FleetTypes.MemoryMiBRange MemoryMiB { get; set; }
            /// <summary>
            /// OsFamily
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-customermanagedworkercapabilities.html#cfn-deadline-fleet-customermanagedworkercapabilities-osfamily
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OsFamily { get; set; }
            /// <summary>
            /// CpuArchitectureType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-customermanagedworkercapabilities.html#cfn-deadline-fleet-customermanagedworkercapabilities-cpuarchitecturetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CpuArchitectureType { get; set; }
        }

        public class Ec2EbsVolume : Humidifier.Base.BaseSubResource, IHaveIops
        {
            /// <summary>
            /// SizeGiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-ec2ebsvolume.html#cfn-deadline-fleet-ec2ebsvolume-sizegib
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic SizeGiB { get; set; }
            /// <summary>
            /// ThroughputMiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-ec2ebsvolume.html#cfn-deadline-fleet-ec2ebsvolume-throughputmib
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ThroughputMiB { get; set; }
            /// <summary>
            /// Iops
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-ec2ebsvolume.html#cfn-deadline-fleet-ec2ebsvolume-iops
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Iops { get; set; }
        }

        public class FleetAmountCapability : Humidifier.Base.BaseSubResource, IHaveName, IHaveMin, IHaveMax
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-fleetamountcapability.html#cfn-deadline-fleet-fleetamountcapability-min
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-fleetamountcapability.html#cfn-deadline-fleet-fleetamountcapability-max
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Max { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-fleetamountcapability.html#cfn-deadline-fleet-fleetamountcapability-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class FleetAttributeCapability : Humidifier.Base.BaseSubResource, IHaveName, IHaveValues
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-fleetattributecapability.html#cfn-deadline-fleet-fleetattributecapability-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Values { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-fleetattributecapability.html#cfn-deadline-fleet-fleetattributecapability-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class FleetCapabilities : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Amounts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-fleetcapabilities.html#cfn-deadline-fleet-fleetcapabilities-amounts
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FleetAmountCapability
            /// </summary>
            public List<Humidifier.Deadline.FleetTypes.FleetAmountCapability> Amounts { get; set; }
            /// <summary>
            /// Attributes_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-fleetcapabilities.html#cfn-deadline-fleet-fleetcapabilities-attributes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FleetAttributeCapability
            /// </summary>
            public List<Humidifier.Deadline.FleetTypes.FleetAttributeCapability> Attributes_ { get; set; }
        }

        public class FleetConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ServiceManagedEc2
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-fleetconfiguration.html#cfn-deadline-fleet-fleetconfiguration-servicemanagedec2
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ServiceManagedEc2FleetConfiguration
            /// </summary>
            public Humidifier.Deadline.FleetTypes.ServiceManagedEc2FleetConfiguration ServiceManagedEc2 { get; set; }
            /// <summary>
            /// CustomerManaged
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-fleetconfiguration.html#cfn-deadline-fleet-fleetconfiguration-customermanaged
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomerManagedFleetConfiguration
            /// </summary>
            public Humidifier.Deadline.FleetTypes.CustomerManagedFleetConfiguration CustomerManaged { get; set; }
        }

        public class MemoryMiBRange : Humidifier.Base.BaseSubResource, IHaveMin, IHaveMax
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-memorymibrange.html#cfn-deadline-fleet-memorymibrange-min
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-memorymibrange.html#cfn-deadline-fleet-memorymibrange-max
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Max { get; set; }
        }

        public class ServiceManagedEc2FleetConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// InstanceMarketOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-servicemanagedec2fleetconfiguration.html#cfn-deadline-fleet-servicemanagedec2fleetconfiguration-instancemarketoptions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ServiceManagedEc2InstanceMarketOptions
            /// </summary>
            public Humidifier.Deadline.FleetTypes.ServiceManagedEc2InstanceMarketOptions InstanceMarketOptions { get; set; }
            /// <summary>
            /// InstanceCapabilities
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-servicemanagedec2fleetconfiguration.html#cfn-deadline-fleet-servicemanagedec2fleetconfiguration-instancecapabilities
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ServiceManagedEc2InstanceCapabilities
            /// </summary>
            public Humidifier.Deadline.FleetTypes.ServiceManagedEc2InstanceCapabilities InstanceCapabilities { get; set; }
        }

        public class ServiceManagedEc2InstanceCapabilities : Humidifier.Base.BaseSubResource, IHaveExcludedInstanceTypes, IHaveAllowedInstanceTypes, IHaveOsFamily
        {
            /// <summary>
            /// AllowedInstanceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-servicemanagedec2instancecapabilities.html#cfn-deadline-fleet-servicemanagedec2instancecapabilities-allowedinstancetypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AllowedInstanceTypes { get; set; }
            /// <summary>
            /// CustomAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-servicemanagedec2instancecapabilities.html#cfn-deadline-fleet-servicemanagedec2instancecapabilities-customattributes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FleetAttributeCapability
            /// </summary>
            public List<Humidifier.Deadline.FleetTypes.FleetAttributeCapability> CustomAttributes { get; set; }
            /// <summary>
            /// AcceleratorCapabilities
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-servicemanagedec2instancecapabilities.html#cfn-deadline-fleet-servicemanagedec2instancecapabilities-acceleratorcapabilities
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AcceleratorCapabilities
            /// </summary>
            public Humidifier.Deadline.FleetTypes.AcceleratorCapabilities AcceleratorCapabilities { get; set; }
            /// <summary>
            /// CustomAmounts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-servicemanagedec2instancecapabilities.html#cfn-deadline-fleet-servicemanagedec2instancecapabilities-customamounts
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FleetAmountCapability
            /// </summary>
            public List<Humidifier.Deadline.FleetTypes.FleetAmountCapability> CustomAmounts { get; set; }
            /// <summary>
            /// VCpuCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-servicemanagedec2instancecapabilities.html#cfn-deadline-fleet-servicemanagedec2instancecapabilities-vcpucount
            /// Required: True
            /// UpdateType: Mutable
            /// Type: VCpuCountRange
            /// </summary>
            public Humidifier.Deadline.FleetTypes.VCpuCountRange VCpuCount { get; set; }
            /// <summary>
            /// ExcludedInstanceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-servicemanagedec2instancecapabilities.html#cfn-deadline-fleet-servicemanagedec2instancecapabilities-excludedinstancetypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ExcludedInstanceTypes { get; set; }
            /// <summary>
            /// MemoryMiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-servicemanagedec2instancecapabilities.html#cfn-deadline-fleet-servicemanagedec2instancecapabilities-memorymib
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MemoryMiBRange
            /// </summary>
            public Humidifier.Deadline.FleetTypes.MemoryMiBRange MemoryMiB { get; set; }
            /// <summary>
            /// OsFamily
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-servicemanagedec2instancecapabilities.html#cfn-deadline-fleet-servicemanagedec2instancecapabilities-osfamily
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OsFamily { get; set; }
            /// <summary>
            /// CpuArchitectureType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-servicemanagedec2instancecapabilities.html#cfn-deadline-fleet-servicemanagedec2instancecapabilities-cpuarchitecturetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CpuArchitectureType { get; set; }
            /// <summary>
            /// RootEbsVolume
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-servicemanagedec2instancecapabilities.html#cfn-deadline-fleet-servicemanagedec2instancecapabilities-rootebsvolume
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Ec2EbsVolume
            /// </summary>
            public Humidifier.Deadline.FleetTypes.Ec2EbsVolume RootEbsVolume { get; set; }
        }

        public class ServiceManagedEc2InstanceMarketOptions : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-servicemanagedec2instancemarketoptions.html#cfn-deadline-fleet-servicemanagedec2instancemarketoptions-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
        }

        public class VCpuCountRange : Humidifier.Base.BaseSubResource, IHaveMin, IHaveMax
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-vcpucountrange.html#cfn-deadline-fleet-vcpucountrange-min
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-vcpucountrange.html#cfn-deadline-fleet-vcpucountrange-max
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Max { get; set; }
        }
    }
}