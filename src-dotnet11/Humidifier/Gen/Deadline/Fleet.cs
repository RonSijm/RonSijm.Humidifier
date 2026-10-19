namespace Humidifier.Deadline
{
    using global::System.Collections.Generic;
    using FleetTypes;

    public class Fleet : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveDeadlineFleetTypesFleetConfigurationConfiguration, IHaveDeadlineFleetTypesHostConfigurationHostConfiguration, IHaveMaxWorkerCount_Integer, IHaveDisplayName, IHaveMinWorkerCount_Integer, IHaveFarmId, IHaveRoleArn
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string Capabilities =  "Capabilities" ;
            public static string FleetId =  "FleetId" ;
            public static string WorkerCount =  "WorkerCount" ;
            public static string Arn =  "Arn" ;
            public static string StatusMessage =  "StatusMessage" ;
        }

        public override string AWSTypeName { get => AWS.Deadline.Fleet; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-fleet.html#cfn-deadline-fleet-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-fleet.html#cfn-deadline-fleet-configuration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: FleetConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.Deadline.FleetTypes.FleetConfiguration, BaseFunction>? Configuration { get; set; }
        /// <summary>
        /// HostConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-fleet.html#cfn-deadline-fleet-hostconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: HostConfiguration
        /// </summary>
        public Union<Humidifier.Deadline.FleetTypes.HostConfiguration, BaseFunction>? HostConfiguration { get; set; }

        /// <summary>
        /// MaxWorkerCount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-fleet.html#cfn-deadline-fleet-maxworkercount
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? MaxWorkerCount { get; set; }

        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-fleet.html#cfn-deadline-fleet-displayname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DisplayName { get; set; }
        /// <summary>
        /// MinWorkerCount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-fleet.html#cfn-deadline-fleet-minworkercount
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MinWorkerCount { get; set; }

        /// <summary>
        /// FarmId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-fleet.html#cfn-deadline-fleet-farmid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? FarmId { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-fleet.html#cfn-deadline-fleet-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-fleet.html#cfn-deadline-fleet-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace FleetTypes
    {
        public class AcceleratorCapabilities : Humidifier.Base.BaseSubResource, IHaveListOfDeadlineFleetTypesAcceleratorSelectionSelections, IHaveDeadlineFleetTypesAcceleratorCountRangeCount
        {
            /// <summary>
            /// Selections
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-acceleratorcapabilities.html#cfn-deadline-fleet-acceleratorcapabilities-selections
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AcceleratorSelection
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Deadline.FleetTypes.AcceleratorSelection>, IReadOnlyList<Union<Humidifier.Deadline.FleetTypes.AcceleratorSelection, BaseFunction>>, BaseFunction>? Selections { get; set; }
            /// <summary>
            /// Count
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-acceleratorcapabilities.html#cfn-deadline-fleet-acceleratorcapabilities-count
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AcceleratorCountRange
            /// </summary>
            public Union<Humidifier.Deadline.FleetTypes.AcceleratorCountRange, BaseFunction>? Count { get; set; }
        }

        public class AcceleratorCountRange : Humidifier.Base.BaseSubResource, IHaveMax_Integer, IHaveMin_Integer
        {
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-acceleratorcountrange.html#cfn-deadline-fleet-acceleratorcountrange-max
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Max { get; set; }
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-acceleratorcountrange.html#cfn-deadline-fleet-acceleratorcountrange-min
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Min { get; set; }
        }

        public class AcceleratorSelection : Humidifier.Base.BaseSubResource, IHaveRuntime, IHaveName
        {
            /// <summary>
            /// Runtime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-acceleratorselection.html#cfn-deadline-fleet-acceleratorselection-runtime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Runtime { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-acceleratorselection.html#cfn-deadline-fleet-acceleratorselection-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class AcceleratorTotalMemoryMiBRange : Humidifier.Base.BaseSubResource, IHaveMin_Integer, IHaveMax_Integer
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-acceleratortotalmemorymibrange.html#cfn-deadline-fleet-acceleratortotalmemorymibrange-min
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-acceleratortotalmemorymibrange.html#cfn-deadline-fleet-acceleratortotalmemorymibrange-max
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Max { get; set; }
        }

        public class CustomerManagedAutoScalingConfiguration : Humidifier.Base.BaseSubResource, IHaveStandbyWorkerCount_Integer, IHaveScaleOutWorkersPerMinute_Integer, IHaveWorkerIdleDurationSeconds_Integer
        {
            /// <summary>
            /// StandbyWorkerCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-customermanagedautoscalingconfiguration.html#cfn-deadline-fleet-customermanagedautoscalingconfiguration-standbyworkercount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? StandbyWorkerCount { get; set; }
            /// <summary>
            /// ScaleOutWorkersPerMinute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-customermanagedautoscalingconfiguration.html#cfn-deadline-fleet-customermanagedautoscalingconfiguration-scaleoutworkersperminute
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ScaleOutWorkersPerMinute { get; set; }
            /// <summary>
            /// WorkerIdleDurationSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-customermanagedautoscalingconfiguration.html#cfn-deadline-fleet-customermanagedautoscalingconfiguration-workeridledurationseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? WorkerIdleDurationSeconds { get; set; }
        }

        public class CustomerManagedFleetConfiguration : Humidifier.Base.BaseSubResource, IHaveStorageProfileId, IHaveMode, IHaveDeadlineFleetTypesCustomerManagedWorkerCapabilitiesWorkerCapabilities, IHaveTagPropagationMode, IHaveDeadlineFleetTypesCustomerManagedAutoScalingConfigurationAutoScalingConfiguration
        {
            /// <summary>
            /// StorageProfileId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-customermanagedfleetconfiguration.html#cfn-deadline-fleet-customermanagedfleetconfiguration-storageprofileid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StorageProfileId { get; set; }
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-customermanagedfleetconfiguration.html#cfn-deadline-fleet-customermanagedfleetconfiguration-mode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Mode { get; set; }
            /// <summary>
            /// WorkerCapabilities
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-customermanagedfleetconfiguration.html#cfn-deadline-fleet-customermanagedfleetconfiguration-workercapabilities
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CustomerManagedWorkerCapabilities
            /// </summary>
            public Union<Humidifier.Deadline.FleetTypes.CustomerManagedWorkerCapabilities, BaseFunction>? WorkerCapabilities { get; set; }
            /// <summary>
            /// TagPropagationMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-customermanagedfleetconfiguration.html#cfn-deadline-fleet-customermanagedfleetconfiguration-tagpropagationmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TagPropagationMode { get; set; }
            /// <summary>
            /// AutoScalingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-customermanagedfleetconfiguration.html#cfn-deadline-fleet-customermanagedfleetconfiguration-autoscalingconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomerManagedAutoScalingConfiguration
            /// </summary>
            public Union<Humidifier.Deadline.FleetTypes.CustomerManagedAutoScalingConfiguration, BaseFunction>? AutoScalingConfiguration { get; set; }
        }

        public class CustomerManagedWorkerCapabilities : Humidifier.Base.BaseSubResource, IHaveListOfDeadlineFleetTypesFleetAttributeCapabilityCustomAttributes, IHaveDeadlineFleetTypesAcceleratorCountRangeAcceleratorCount, IHaveListOfDeadlineFleetTypesFleetAmountCapabilityCustomAmounts, IHaveStringListOfAcceleratorTypes, IHaveDeadlineFleetTypesAcceleratorTotalMemoryMiBRangeAcceleratorTotalMemoryMiB, IHaveDeadlineFleetTypesVCpuCountRangeVCpuCount, IHaveDeadlineFleetTypesMemoryMiBRangeMemoryMiB, IHaveOsFamily, IHaveCpuArchitectureType
        {
            /// <summary>
            /// CustomAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-customermanagedworkercapabilities.html#cfn-deadline-fleet-customermanagedworkercapabilities-customattributes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FleetAttributeCapability
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Deadline.FleetTypes.FleetAttributeCapability>, IReadOnlyList<Union<Humidifier.Deadline.FleetTypes.FleetAttributeCapability, BaseFunction>>, BaseFunction>? CustomAttributes { get; set; }
            /// <summary>
            /// AcceleratorCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-customermanagedworkercapabilities.html#cfn-deadline-fleet-customermanagedworkercapabilities-acceleratorcount
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AcceleratorCountRange
            /// </summary>
            public Union<Humidifier.Deadline.FleetTypes.AcceleratorCountRange, BaseFunction>? AcceleratorCount { get; set; }
            /// <summary>
            /// CustomAmounts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-customermanagedworkercapabilities.html#cfn-deadline-fleet-customermanagedworkercapabilities-customamounts
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FleetAmountCapability
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Deadline.FleetTypes.FleetAmountCapability>, IReadOnlyList<Union<Humidifier.Deadline.FleetTypes.FleetAmountCapability, BaseFunction>>, BaseFunction>? CustomAmounts { get; set; }
            /// <summary>
            /// AcceleratorTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-customermanagedworkercapabilities.html#cfn-deadline-fleet-customermanagedworkercapabilities-acceleratortypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AcceleratorTypes { get; set; }
            /// <summary>
            /// AcceleratorTotalMemoryMiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-customermanagedworkercapabilities.html#cfn-deadline-fleet-customermanagedworkercapabilities-acceleratortotalmemorymib
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AcceleratorTotalMemoryMiBRange
            /// </summary>
            public Union<Humidifier.Deadline.FleetTypes.AcceleratorTotalMemoryMiBRange, BaseFunction>? AcceleratorTotalMemoryMiB { get; set; }
            /// <summary>
            /// VCpuCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-customermanagedworkercapabilities.html#cfn-deadline-fleet-customermanagedworkercapabilities-vcpucount
            /// Required: True
            /// UpdateType: Mutable
            /// Type: VCpuCountRange
            /// </summary>
            public Union<Humidifier.Deadline.FleetTypes.VCpuCountRange, BaseFunction>? VCpuCount { get; set; }
            /// <summary>
            /// MemoryMiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-customermanagedworkercapabilities.html#cfn-deadline-fleet-customermanagedworkercapabilities-memorymib
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MemoryMiBRange
            /// </summary>
            public Union<Humidifier.Deadline.FleetTypes.MemoryMiBRange, BaseFunction>? MemoryMiB { get; set; }
            /// <summary>
            /// OsFamily
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-customermanagedworkercapabilities.html#cfn-deadline-fleet-customermanagedworkercapabilities-osfamily
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OsFamily { get; set; }
            /// <summary>
            /// CpuArchitectureType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-customermanagedworkercapabilities.html#cfn-deadline-fleet-customermanagedworkercapabilities-cpuarchitecturetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CpuArchitectureType { get; set; }
        }

        public class Ec2EbsVolume : Humidifier.Base.BaseSubResource, IHaveSizeGiB_Integer, IHaveThroughputMiB_Integer, IHaveIops_Integer
        {
            /// <summary>
            /// SizeGiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-ec2ebsvolume.html#cfn-deadline-fleet-ec2ebsvolume-sizegib
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SizeGiB { get; set; }
            /// <summary>
            /// ThroughputMiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-ec2ebsvolume.html#cfn-deadline-fleet-ec2ebsvolume-throughputmib
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ThroughputMiB { get; set; }
            /// <summary>
            /// Iops
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-ec2ebsvolume.html#cfn-deadline-fleet-ec2ebsvolume-iops
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Iops { get; set; }
        }

        public class FleetAmountCapability : Humidifier.Base.BaseSubResource, IHaveMax_Double, IHaveMin_Double, IHaveName
        {
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-fleetamountcapability.html#cfn-deadline-fleet-fleetamountcapability-max
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Max { get; set; }
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-fleetamountcapability.html#cfn-deadline-fleet-fleetamountcapability-min
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Min { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-fleetamountcapability.html#cfn-deadline-fleet-fleetamountcapability-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class FleetAttributeCapability : Humidifier.Base.BaseSubResource, IHaveStringListOfValues, IHaveName
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-fleetattributecapability.html#cfn-deadline-fleet-fleetattributecapability-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-fleetattributecapability.html#cfn-deadline-fleet-fleetattributecapability-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class FleetCapabilities : Humidifier.Base.BaseSubResource, IHaveListOfDeadlineFleetTypesFleetAmountCapabilityAmounts, IHaveListOfDeadlineFleetTypesFleetAttributeCapabilityAttributes_
        {
            /// <summary>
            /// Amounts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-fleetcapabilities.html#cfn-deadline-fleet-fleetcapabilities-amounts
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FleetAmountCapability
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Deadline.FleetTypes.FleetAmountCapability>, IReadOnlyList<Union<Humidifier.Deadline.FleetTypes.FleetAmountCapability, BaseFunction>>, BaseFunction>? Amounts { get; set; }
            /// <summary>
            /// Attributes_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-fleetcapabilities.html#cfn-deadline-fleet-fleetcapabilities-attributes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FleetAttributeCapability
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Deadline.FleetTypes.FleetAttributeCapability>, IReadOnlyList<Union<Humidifier.Deadline.FleetTypes.FleetAttributeCapability, BaseFunction>>, BaseFunction>? Attributes_ { get; set; }
        }

        public class FleetConfiguration : Humidifier.Base.BaseSubResource, IHaveDeadlineFleetTypesServiceManagedEc2FleetConfigurationServiceManagedEc2, IHaveDeadlineFleetTypesCustomerManagedFleetConfigurationCustomerManaged
        {
            /// <summary>
            /// ServiceManagedEc2
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-fleetconfiguration.html#cfn-deadline-fleet-fleetconfiguration-servicemanagedec2
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ServiceManagedEc2FleetConfiguration
            /// </summary>
            public Union<Humidifier.Deadline.FleetTypes.ServiceManagedEc2FleetConfiguration, BaseFunction>? ServiceManagedEc2 { get; set; }
            /// <summary>
            /// CustomerManaged
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-fleetconfiguration.html#cfn-deadline-fleet-fleetconfiguration-customermanaged
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomerManagedFleetConfiguration
            /// </summary>
            public Union<Humidifier.Deadline.FleetTypes.CustomerManagedFleetConfiguration, BaseFunction>? CustomerManaged { get; set; }
        }

        public class FleetSoftwareAddOn : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-fleetsoftwareaddon.html#cfn-deadline-fleet-fleetsoftwareaddon-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class HostConfiguration : Humidifier.Base.BaseSubResource, IHaveScriptTimeoutSeconds_Integer, IHaveScriptBody
        {
            /// <summary>
            /// ScriptTimeoutSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-hostconfiguration.html#cfn-deadline-fleet-hostconfiguration-scripttimeoutseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ScriptTimeoutSeconds { get; set; }
            /// <summary>
            /// ScriptBody
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-hostconfiguration.html#cfn-deadline-fleet-hostconfiguration-scriptbody
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScriptBody { get; set; }
        }

        public class MemoryMiBRange : Humidifier.Base.BaseSubResource, IHaveMax_Integer, IHaveMin_Integer
        {
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-memorymibrange.html#cfn-deadline-fleet-memorymibrange-max
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Max { get; set; }
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-memorymibrange.html#cfn-deadline-fleet-memorymibrange-min
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Min { get; set; }
        }

        public class PersistentVolumeConfiguration : Humidifier.Base.BaseSubResource, IHaveMountPath, IHaveSizeGiB_Integer, IHaveThroughputMiB_Integer, IHaveIops_Integer, IHaveLastUsedTtlHours_Integer
        {
            /// <summary>
            /// MountPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-persistentvolumeconfiguration.html#cfn-deadline-fleet-persistentvolumeconfiguration-mountpath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MountPath { get; set; }
            /// <summary>
            /// SizeGiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-persistentvolumeconfiguration.html#cfn-deadline-fleet-persistentvolumeconfiguration-sizegib
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SizeGiB { get; set; }
            /// <summary>
            /// ThroughputMiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-persistentvolumeconfiguration.html#cfn-deadline-fleet-persistentvolumeconfiguration-throughputmib
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ThroughputMiB { get; set; }
            /// <summary>
            /// Iops
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-persistentvolumeconfiguration.html#cfn-deadline-fleet-persistentvolumeconfiguration-iops
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Iops { get; set; }
            /// <summary>
            /// LastUsedTtlHours
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-persistentvolumeconfiguration.html#cfn-deadline-fleet-persistentvolumeconfiguration-lastusedttlhours
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? LastUsedTtlHours { get; set; }
        }

        public class ServiceManagedEc2AutoScalingConfiguration : Humidifier.Base.BaseSubResource, IHaveStandbyWorkerCount_Integer, IHaveScaleOutWorkersPerMinute_Integer, IHaveWorkerIdleDurationSeconds_Integer
        {
            /// <summary>
            /// StandbyWorkerCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-servicemanagedec2autoscalingconfiguration.html#cfn-deadline-fleet-servicemanagedec2autoscalingconfiguration-standbyworkercount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? StandbyWorkerCount { get; set; }
            /// <summary>
            /// ScaleOutWorkersPerMinute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-servicemanagedec2autoscalingconfiguration.html#cfn-deadline-fleet-servicemanagedec2autoscalingconfiguration-scaleoutworkersperminute
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ScaleOutWorkersPerMinute { get; set; }
            /// <summary>
            /// WorkerIdleDurationSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-servicemanagedec2autoscalingconfiguration.html#cfn-deadline-fleet-servicemanagedec2autoscalingconfiguration-workeridledurationseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? WorkerIdleDurationSeconds { get; set; }
        }

        public class ServiceManagedEc2FleetConfiguration : Humidifier.Base.BaseSubResource, IHaveDeadlineFleetTypesPersistentVolumeConfigurationPersistentVolumeConfiguration, IHaveStorageProfileId, IHaveDeadlineFleetTypesServiceManagedEc2InstanceMarketOptionsInstanceMarketOptions, IHaveDeadlineFleetTypesServiceManagedEc2InstanceCapabilitiesInstanceCapabilities, IHaveDeadlineFleetTypesVpcConfigurationVpcConfiguration, IHaveDeadlineFleetTypesServiceManagedEc2AutoScalingConfigurationAutoScalingConfiguration
        {
            /// <summary>
            /// PersistentVolumeConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-servicemanagedec2fleetconfiguration.html#cfn-deadline-fleet-servicemanagedec2fleetconfiguration-persistentvolumeconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PersistentVolumeConfiguration
            /// </summary>
            public Union<Humidifier.Deadline.FleetTypes.PersistentVolumeConfiguration, BaseFunction>? PersistentVolumeConfiguration { get; set; }
            /// <summary>
            /// StorageProfileId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-servicemanagedec2fleetconfiguration.html#cfn-deadline-fleet-servicemanagedec2fleetconfiguration-storageprofileid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StorageProfileId { get; set; }
            /// <summary>
            /// InstanceMarketOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-servicemanagedec2fleetconfiguration.html#cfn-deadline-fleet-servicemanagedec2fleetconfiguration-instancemarketoptions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ServiceManagedEc2InstanceMarketOptions
            /// </summary>
            public Union<Humidifier.Deadline.FleetTypes.ServiceManagedEc2InstanceMarketOptions, BaseFunction>? InstanceMarketOptions { get; set; }
            /// <summary>
            /// InstanceCapabilities
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-servicemanagedec2fleetconfiguration.html#cfn-deadline-fleet-servicemanagedec2fleetconfiguration-instancecapabilities
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ServiceManagedEc2InstanceCapabilities
            /// </summary>
            public Union<Humidifier.Deadline.FleetTypes.ServiceManagedEc2InstanceCapabilities, BaseFunction>? InstanceCapabilities { get; set; }
            /// <summary>
            /// VpcConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-servicemanagedec2fleetconfiguration.html#cfn-deadline-fleet-servicemanagedec2fleetconfiguration-vpcconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VpcConfiguration
            /// </summary>
            public Union<Humidifier.Deadline.FleetTypes.VpcConfiguration, BaseFunction>? VpcConfiguration { get; set; }
            /// <summary>
            /// AutoScalingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-servicemanagedec2fleetconfiguration.html#cfn-deadline-fleet-servicemanagedec2fleetconfiguration-autoscalingconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ServiceManagedEc2AutoScalingConfiguration
            /// </summary>
            public Union<Humidifier.Deadline.FleetTypes.ServiceManagedEc2AutoScalingConfiguration, BaseFunction>? AutoScalingConfiguration { get; set; }
        }

        public class ServiceManagedEc2InstanceCapabilities : Humidifier.Base.BaseSubResource, IHaveStringListOfAllowedInstanceTypes, IHaveListOfDeadlineFleetTypesFleetSoftwareAddOnSoftwareAddOns, IHaveListOfDeadlineFleetTypesFleetAttributeCapabilityCustomAttributes, IHaveDeadlineFleetTypesAcceleratorCapabilitiesAcceleratorCapabilities, IHaveListOfDeadlineFleetTypesFleetAmountCapabilityCustomAmounts, IHaveDeadlineFleetTypesVCpuCountRangeVCpuCount, IHaveStringListOfExcludedInstanceTypes, IHaveDeadlineFleetTypesMemoryMiBRangeMemoryMiB, IHaveOsFamily, IHaveCpuArchitectureType, IHaveDeadlineFleetTypesEc2EbsVolumeRootEbsVolume
        {
            /// <summary>
            /// AllowedInstanceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-servicemanagedec2instancecapabilities.html#cfn-deadline-fleet-servicemanagedec2instancecapabilities-allowedinstancetypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedInstanceTypes { get; set; }
            /// <summary>
            /// SoftwareAddOns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-servicemanagedec2instancecapabilities.html#cfn-deadline-fleet-servicemanagedec2instancecapabilities-softwareaddons
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FleetSoftwareAddOn
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Deadline.FleetTypes.FleetSoftwareAddOn>, IReadOnlyList<Union<Humidifier.Deadline.FleetTypes.FleetSoftwareAddOn, BaseFunction>>, BaseFunction>? SoftwareAddOns { get; set; }
            /// <summary>
            /// CustomAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-servicemanagedec2instancecapabilities.html#cfn-deadline-fleet-servicemanagedec2instancecapabilities-customattributes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FleetAttributeCapability
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Deadline.FleetTypes.FleetAttributeCapability>, IReadOnlyList<Union<Humidifier.Deadline.FleetTypes.FleetAttributeCapability, BaseFunction>>, BaseFunction>? CustomAttributes { get; set; }
            /// <summary>
            /// AcceleratorCapabilities
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-servicemanagedec2instancecapabilities.html#cfn-deadline-fleet-servicemanagedec2instancecapabilities-acceleratorcapabilities
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AcceleratorCapabilities
            /// </summary>
            public Union<Humidifier.Deadline.FleetTypes.AcceleratorCapabilities, BaseFunction>? AcceleratorCapabilities { get; set; }
            /// <summary>
            /// CustomAmounts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-servicemanagedec2instancecapabilities.html#cfn-deadline-fleet-servicemanagedec2instancecapabilities-customamounts
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FleetAmountCapability
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Deadline.FleetTypes.FleetAmountCapability>, IReadOnlyList<Union<Humidifier.Deadline.FleetTypes.FleetAmountCapability, BaseFunction>>, BaseFunction>? CustomAmounts { get; set; }
            /// <summary>
            /// VCpuCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-servicemanagedec2instancecapabilities.html#cfn-deadline-fleet-servicemanagedec2instancecapabilities-vcpucount
            /// Required: True
            /// UpdateType: Mutable
            /// Type: VCpuCountRange
            /// </summary>
            public Union<Humidifier.Deadline.FleetTypes.VCpuCountRange, BaseFunction>? VCpuCount { get; set; }
            /// <summary>
            /// ExcludedInstanceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-servicemanagedec2instancecapabilities.html#cfn-deadline-fleet-servicemanagedec2instancecapabilities-excludedinstancetypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ExcludedInstanceTypes { get; set; }
            /// <summary>
            /// MemoryMiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-servicemanagedec2instancecapabilities.html#cfn-deadline-fleet-servicemanagedec2instancecapabilities-memorymib
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MemoryMiBRange
            /// </summary>
            public Union<Humidifier.Deadline.FleetTypes.MemoryMiBRange, BaseFunction>? MemoryMiB { get; set; }
            /// <summary>
            /// OsFamily
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-servicemanagedec2instancecapabilities.html#cfn-deadline-fleet-servicemanagedec2instancecapabilities-osfamily
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OsFamily { get; set; }
            /// <summary>
            /// CpuArchitectureType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-servicemanagedec2instancecapabilities.html#cfn-deadline-fleet-servicemanagedec2instancecapabilities-cpuarchitecturetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CpuArchitectureType { get; set; }
            /// <summary>
            /// RootEbsVolume
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-servicemanagedec2instancecapabilities.html#cfn-deadline-fleet-servicemanagedec2instancecapabilities-rootebsvolume
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Ec2EbsVolume
            /// </summary>
            public Union<Humidifier.Deadline.FleetTypes.Ec2EbsVolume, BaseFunction>? RootEbsVolume { get; set; }
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
            public Union<string, BaseFunction>? Type { get; set; }
        }

        public class VCpuCountRange : Humidifier.Base.BaseSubResource, IHaveMax_Integer, IHaveMin_Integer
        {
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-vcpucountrange.html#cfn-deadline-fleet-vcpucountrange-max
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Max { get; set; }
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-vcpucountrange.html#cfn-deadline-fleet-vcpucountrange-min
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Min { get; set; }
        }

        public class VpcConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfResourceConfigurationArns
        {
            /// <summary>
            /// ResourceConfigurationArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-fleet-vpcconfiguration.html#cfn-deadline-fleet-vpcconfiguration-resourceconfigurationarns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ResourceConfigurationArns { get; set; }
        }
    }
}