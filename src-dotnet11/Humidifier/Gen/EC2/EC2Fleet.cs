namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using EC2FleetTypes;

    public class EC2Fleet : Humidifier.Base.BaseResource, IHaveContext, IHaveEC2EC2FleetTypesTargetCapacitySpecificationRequestTargetCapacitySpecification, IHaveEC2EC2FleetTypesOnDemandOptionsRequestOnDemandOptions, IHaveExcessCapacityTerminationPolicy, IHaveListOfEC2EC2FleetTypesTagSpecificationTagSpecifications, IHaveEC2EC2FleetTypesSpotOptionsRequestSpotOptions, IHaveListOfEC2EC2FleetTypesFleetLaunchTemplateConfigRequestLaunchTemplateConfigs, IHaveTerminateInstancesWithExpiration_Boolean, IHaveValidUntil, IHaveType, IHaveEC2EC2FleetTypesReservedCapacityOptionsRequestReservedCapacityOptions, IHaveValidFrom, IHaveReplaceUnhealthyInstances_Boolean
    {
        public class Attributes
        {
            public static string FleetId =  "FleetId" ;
        }

        public override string AWSTypeName { get => AWS.EC2.EC2Fleet; }
        /// <summary>
        /// Context
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ec2fleet.html#cfn-ec2-ec2fleet-context
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Context { get; set; }

        /// <summary>
        /// TargetCapacitySpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ec2fleet.html#cfn-ec2-ec2fleet-targetcapacityspecification
        /// Required: True
        /// UpdateType: Mutable
        /// Type: TargetCapacitySpecificationRequest
        /// </summary>
        [Required]
        public Union<Humidifier.EC2.EC2FleetTypes.TargetCapacitySpecificationRequest, BaseFunction>? TargetCapacitySpecification { get; set; }
        /// <summary>
        /// OnDemandOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ec2fleet.html#cfn-ec2-ec2fleet-ondemandoptions
        /// Required: False
        /// UpdateType: Immutable
        /// Type: OnDemandOptionsRequest
        /// </summary>
        public Union<Humidifier.EC2.EC2FleetTypes.OnDemandOptionsRequest, BaseFunction>? OnDemandOptions { get; set; }
        /// <summary>
        /// ExcessCapacityTerminationPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ec2fleet.html#cfn-ec2-ec2fleet-excesscapacityterminationpolicy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ExcessCapacityTerminationPolicy { get; set; }
        /// <summary>
        /// TagSpecifications
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ec2fleet.html#cfn-ec2-ec2fleet-tagspecifications
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: TagSpecification
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EC2.EC2FleetTypes.TagSpecification>, IReadOnlyList<Union<Humidifier.EC2.EC2FleetTypes.TagSpecification, BaseFunction>>, BaseFunction>? TagSpecifications { get; set; }
        /// <summary>
        /// SpotOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ec2fleet.html#cfn-ec2-ec2fleet-spotoptions
        /// Required: False
        /// UpdateType: Immutable
        /// Type: SpotOptionsRequest
        /// </summary>
        public Union<Humidifier.EC2.EC2FleetTypes.SpotOptionsRequest, BaseFunction>? SpotOptions { get; set; }

        /// <summary>
        /// LaunchTemplateConfigs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ec2fleet.html#cfn-ec2-ec2fleet-launchtemplateconfigs
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: FleetLaunchTemplateConfigRequest
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.EC2.EC2FleetTypes.FleetLaunchTemplateConfigRequest>, IReadOnlyList<Union<Humidifier.EC2.EC2FleetTypes.FleetLaunchTemplateConfigRequest, BaseFunction>>, BaseFunction>? LaunchTemplateConfigs { get; set; }
        /// <summary>
        /// TerminateInstancesWithExpiration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ec2fleet.html#cfn-ec2-ec2fleet-terminateinstanceswithexpiration
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? TerminateInstancesWithExpiration { get; set; }
        /// <summary>
        /// ValidUntil
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ec2fleet.html#cfn-ec2-ec2fleet-validuntil
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ValidUntil { get; set; }
        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ec2fleet.html#cfn-ec2-ec2fleet-type
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Type { get; set; }
        /// <summary>
        /// ReservedCapacityOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ec2fleet.html#cfn-ec2-ec2fleet-reservedcapacityoptions
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ReservedCapacityOptionsRequest
        /// </summary>
        public Union<Humidifier.EC2.EC2FleetTypes.ReservedCapacityOptionsRequest, BaseFunction>? ReservedCapacityOptions { get; set; }
        /// <summary>
        /// ValidFrom
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ec2fleet.html#cfn-ec2-ec2fleet-validfrom
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ValidFrom { get; set; }
        /// <summary>
        /// ReplaceUnhealthyInstances
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ec2fleet.html#cfn-ec2-ec2fleet-replaceunhealthyinstances
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? ReplaceUnhealthyInstances { get; set; }
    }

    namespace EC2FleetTypes
    {
        public class AcceleratorCountRequest : Humidifier.Base.BaseSubResource, IHaveMin_Integer, IHaveMax_Integer
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-acceleratorcountrequest.html#cfn-ec2-ec2fleet-acceleratorcountrequest-min
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-acceleratorcountrequest.html#cfn-ec2-ec2fleet-acceleratorcountrequest-max
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Max { get; set; }
        }

        public class AcceleratorTotalMemoryMiBRequest : Humidifier.Base.BaseSubResource, IHaveMin_Integer, IHaveMax_Integer
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-acceleratortotalmemorymibrequest.html#cfn-ec2-ec2fleet-acceleratortotalmemorymibrequest-min
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-acceleratortotalmemorymibrequest.html#cfn-ec2-ec2fleet-acceleratortotalmemorymibrequest-max
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Max { get; set; }
        }

        public class BaselineEbsBandwidthMbpsRequest : Humidifier.Base.BaseSubResource, IHaveMin_Integer, IHaveMax_Integer
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-baselineebsbandwidthmbpsrequest.html#cfn-ec2-ec2fleet-baselineebsbandwidthmbpsrequest-min
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-baselineebsbandwidthmbpsrequest.html#cfn-ec2-ec2fleet-baselineebsbandwidthmbpsrequest-max
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Max { get; set; }
        }

        public class BaselinePerformanceFactorsRequest : Humidifier.Base.BaseSubResource, IHaveEC2EC2FleetTypesCpuPerformanceFactorRequestCpu
        {
            /// <summary>
            /// Cpu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-baselineperformancefactorsrequest.html#cfn-ec2-ec2fleet-baselineperformancefactorsrequest-cpu
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CpuPerformanceFactorRequest
            /// </summary>
            public Union<Humidifier.EC2.EC2FleetTypes.CpuPerformanceFactorRequest, BaseFunction>? Cpu { get; set; }
        }

        public class BlockDeviceMapping : Humidifier.Base.BaseSubResource, IHaveEC2EC2FleetTypesEbsBlockDeviceEbs, IHaveNoDevice, IHaveVirtualName, IHaveDeviceName
        {
            /// <summary>
            /// Ebs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-blockdevicemapping.html#cfn-ec2-ec2fleet-blockdevicemapping-ebs
            /// Required: False
            /// UpdateType: Immutable
            /// Type: EbsBlockDevice
            /// </summary>
            public Union<Humidifier.EC2.EC2FleetTypes.EbsBlockDevice, BaseFunction>? Ebs { get; set; }
            /// <summary>
            /// NoDevice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-blockdevicemapping.html#cfn-ec2-ec2fleet-blockdevicemapping-nodevice
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NoDevice { get; set; }
            /// <summary>
            /// VirtualName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-blockdevicemapping.html#cfn-ec2-ec2fleet-blockdevicemapping-virtualname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VirtualName { get; set; }
            /// <summary>
            /// DeviceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-blockdevicemapping.html#cfn-ec2-ec2fleet-blockdevicemapping-devicename
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeviceName { get; set; }
        }

        public class CapacityRebalance : Humidifier.Base.BaseSubResource, IHaveTerminationDelay_Integer, IHaveReplacementStrategy
        {
            /// <summary>
            /// TerminationDelay
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-capacityrebalance.html#cfn-ec2-ec2fleet-capacityrebalance-terminationdelay
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TerminationDelay { get; set; }
            /// <summary>
            /// ReplacementStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-capacityrebalance.html#cfn-ec2-ec2fleet-capacityrebalance-replacementstrategy
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ReplacementStrategy { get; set; }
        }

        public class CapacityReservationOptionsRequest : Humidifier.Base.BaseSubResource, IHaveUsageStrategy
        {
            /// <summary>
            /// UsageStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-capacityreservationoptionsrequest.html#cfn-ec2-ec2fleet-capacityreservationoptionsrequest-usagestrategy
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UsageStrategy { get; set; }
        }

        public class CapacityReservationTargetRequest : Humidifier.Base.BaseSubResource, IHaveStringListOfCapacityReservationIds, IHaveStringListOfCapacityReservationResourceGroupArns
        {
            /// <summary>
            /// CapacityReservationIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-capacityreservationtargetrequest.html#cfn-ec2-ec2fleet-capacityreservationtargetrequest-capacityreservationids
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CapacityReservationIds { get; set; }
            /// <summary>
            /// CapacityReservationResourceGroupArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-capacityreservationtargetrequest.html#cfn-ec2-ec2fleet-capacityreservationtargetrequest-capacityreservationresourcegrouparns
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CapacityReservationResourceGroupArns { get; set; }
        }

        public class CpuPerformanceFactorRequest : Humidifier.Base.BaseSubResource, IHaveListOfEC2EC2FleetTypesPerformanceFactorReferenceRequestReferences
        {
            /// <summary>
            /// References
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-cpuperformancefactorrequest.html#cfn-ec2-ec2fleet-cpuperformancefactorrequest-references
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: PerformanceFactorReferenceRequest
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.EC2FleetTypes.PerformanceFactorReferenceRequest>, IReadOnlyList<Union<Humidifier.EC2.EC2FleetTypes.PerformanceFactorReferenceRequest, BaseFunction>>, BaseFunction>? References { get; set; }
        }

        public class EbsBlockDevice : Humidifier.Base.BaseSubResource, IHaveSnapshotId, IHaveVolumeType, IHaveKmsKeyId, IHaveEncrypted_Boolean, IHaveEC2EC2FleetTypesMultiAvailabilityZoneConfigurationMultiAvailabilityZoneConfiguration, IHaveIops_Integer, IHaveVolumeSize_Integer, IHaveDeleteOnTermination_Boolean
        {
            /// <summary>
            /// SnapshotId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-ebsblockdevice.html#cfn-ec2-ec2fleet-ebsblockdevice-snapshotid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SnapshotId { get; set; }
            /// <summary>
            /// VolumeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-ebsblockdevice.html#cfn-ec2-ec2fleet-ebsblockdevice-volumetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VolumeType { get; set; }
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-ebsblockdevice.html#cfn-ec2-ec2fleet-ebsblockdevice-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
            /// <summary>
            /// Encrypted
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-ebsblockdevice.html#cfn-ec2-ec2fleet-ebsblockdevice-encrypted
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Encrypted { get; set; }
            /// <summary>
            /// MultiAvailabilityZoneConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-ebsblockdevice.html#cfn-ec2-ec2fleet-ebsblockdevice-multiavailabilityzoneconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MultiAvailabilityZoneConfiguration
            /// </summary>
            public Union<Humidifier.EC2.EC2FleetTypes.MultiAvailabilityZoneConfiguration, BaseFunction>? MultiAvailabilityZoneConfiguration { get; set; }
            /// <summary>
            /// Iops
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-ebsblockdevice.html#cfn-ec2-ec2fleet-ebsblockdevice-iops
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Iops { get; set; }
            /// <summary>
            /// VolumeSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-ebsblockdevice.html#cfn-ec2-ec2fleet-ebsblockdevice-volumesize
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? VolumeSize { get; set; }
            /// <summary>
            /// DeleteOnTermination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-ebsblockdevice.html#cfn-ec2-ec2fleet-ebsblockdevice-deleteontermination
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DeleteOnTermination { get; set; }
        }

        public class FleetLaunchTemplateConfigRequest : Humidifier.Base.BaseSubResource, IHaveEC2EC2FleetTypesFleetLaunchTemplateSpecificationRequestLaunchTemplateSpecification, IHaveListOfEC2EC2FleetTypesFleetLaunchTemplateOverridesRequestOverrides
        {
            /// <summary>
            /// LaunchTemplateSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-fleetlaunchtemplateconfigrequest.html#cfn-ec2-ec2fleet-fleetlaunchtemplateconfigrequest-launchtemplatespecification
            /// Required: False
            /// UpdateType: Immutable
            /// Type: FleetLaunchTemplateSpecificationRequest
            /// </summary>
            public Union<Humidifier.EC2.EC2FleetTypes.FleetLaunchTemplateSpecificationRequest, BaseFunction>? LaunchTemplateSpecification { get; set; }
            /// <summary>
            /// Overrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-fleetlaunchtemplateconfigrequest.html#cfn-ec2-ec2fleet-fleetlaunchtemplateconfigrequest-overrides
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: FleetLaunchTemplateOverridesRequest
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.EC2FleetTypes.FleetLaunchTemplateOverridesRequest>, IReadOnlyList<Union<Humidifier.EC2.EC2FleetTypes.FleetLaunchTemplateOverridesRequest, BaseFunction>>, BaseFunction>? Overrides { get; set; }
        }

        public class FleetLaunchTemplateOverridesRequest : Humidifier.Base.BaseSubResource, IHaveEC2EC2FleetTypesInstanceMetadataOptionsRequestMetadataOptions, IHavePriority_Double, IHaveAvailabilityZoneId, IHaveListOfEC2EC2FleetTypesBlockDeviceMappingBlockDeviceMappings, IHaveAvailabilityZone, IHaveEC2EC2FleetTypesIamInstanceProfileSpecificationIamInstanceProfile, IHaveSubnetId, IHaveKeyName, IHaveWeightedCapacity_Double, IHaveEC2EC2FleetTypesPlacementPlacement, IHaveListOfEC2EC2FleetTypesNetworkInterfaceSpecificationRequestNetworkInterfaces, IHaveEC2EC2FleetTypesInstanceRequirementsRequestInstanceRequirements, IHaveInstanceType, IHaveMaxPrice
        {
            /// <summary>
            /// MetadataOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-fleetlaunchtemplateoverridesrequest.html#cfn-ec2-ec2fleet-fleetlaunchtemplateoverridesrequest-metadataoptions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: InstanceMetadataOptionsRequest
            /// </summary>
            public Union<Humidifier.EC2.EC2FleetTypes.InstanceMetadataOptionsRequest, BaseFunction>? MetadataOptions { get; set; }
            /// <summary>
            /// Priority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-fleetlaunchtemplateoverridesrequest.html#cfn-ec2-ec2fleet-fleetlaunchtemplateoverridesrequest-priority
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Priority { get; set; }
            /// <summary>
            /// AvailabilityZoneId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-fleetlaunchtemplateoverridesrequest.html#cfn-ec2-ec2fleet-fleetlaunchtemplateoverridesrequest-availabilityzoneid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AvailabilityZoneId { get; set; }
            /// <summary>
            /// BlockDeviceMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-fleetlaunchtemplateoverridesrequest.html#cfn-ec2-ec2fleet-fleetlaunchtemplateoverridesrequest-blockdevicemappings
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: BlockDeviceMapping
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.EC2FleetTypes.BlockDeviceMapping>, IReadOnlyList<Union<Humidifier.EC2.EC2FleetTypes.BlockDeviceMapping, BaseFunction>>, BaseFunction>? BlockDeviceMappings { get; set; }
            /// <summary>
            /// AvailabilityZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-fleetlaunchtemplateoverridesrequest.html#cfn-ec2-ec2fleet-fleetlaunchtemplateoverridesrequest-availabilityzone
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AvailabilityZone { get; set; }
            /// <summary>
            /// IamInstanceProfile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-fleetlaunchtemplateoverridesrequest.html#cfn-ec2-ec2fleet-fleetlaunchtemplateoverridesrequest-iaminstanceprofile
            /// Required: False
            /// UpdateType: Immutable
            /// Type: IamInstanceProfileSpecification
            /// </summary>
            public Union<Humidifier.EC2.EC2FleetTypes.IamInstanceProfileSpecification, BaseFunction>? IamInstanceProfile { get; set; }
            /// <summary>
            /// SubnetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-fleetlaunchtemplateoverridesrequest.html#cfn-ec2-ec2fleet-fleetlaunchtemplateoverridesrequest-subnetid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SubnetId { get; set; }
            /// <summary>
            /// KeyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-fleetlaunchtemplateoverridesrequest.html#cfn-ec2-ec2fleet-fleetlaunchtemplateoverridesrequest-keyname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KeyName { get; set; }
            /// <summary>
            /// WeightedCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-fleetlaunchtemplateoverridesrequest.html#cfn-ec2-ec2fleet-fleetlaunchtemplateoverridesrequest-weightedcapacity
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? WeightedCapacity { get; set; }
            /// <summary>
            /// Placement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-fleetlaunchtemplateoverridesrequest.html#cfn-ec2-ec2fleet-fleetlaunchtemplateoverridesrequest-placement
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Placement
            /// </summary>
            public Union<Humidifier.EC2.EC2FleetTypes.Placement, BaseFunction>? Placement { get; set; }
            /// <summary>
            /// NetworkInterfaces
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-fleetlaunchtemplateoverridesrequest.html#cfn-ec2-ec2fleet-fleetlaunchtemplateoverridesrequest-networkinterfaces
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: NetworkInterfaceSpecificationRequest
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.EC2FleetTypes.NetworkInterfaceSpecificationRequest>, IReadOnlyList<Union<Humidifier.EC2.EC2FleetTypes.NetworkInterfaceSpecificationRequest, BaseFunction>>, BaseFunction>? NetworkInterfaces { get; set; }
            /// <summary>
            /// InstanceRequirements
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-fleetlaunchtemplateoverridesrequest.html#cfn-ec2-ec2fleet-fleetlaunchtemplateoverridesrequest-instancerequirements
            /// Required: False
            /// UpdateType: Immutable
            /// Type: InstanceRequirementsRequest
            /// </summary>
            public Union<Humidifier.EC2.EC2FleetTypes.InstanceRequirementsRequest, BaseFunction>? InstanceRequirements { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-fleetlaunchtemplateoverridesrequest.html#cfn-ec2-ec2fleet-fleetlaunchtemplateoverridesrequest-instancetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceType { get; set; }
            /// <summary>
            /// MaxPrice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-fleetlaunchtemplateoverridesrequest.html#cfn-ec2-ec2fleet-fleetlaunchtemplateoverridesrequest-maxprice
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MaxPrice { get; set; }
        }

        public class FleetLaunchTemplateSpecificationRequest : Humidifier.Base.BaseSubResource, IHaveLaunchTemplateName, IHaveVersion, IHaveLaunchTemplateId, IHaveLaunchTemplateSpecificationUserData
        {
            /// <summary>
            /// LaunchTemplateName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-fleetlaunchtemplatespecificationrequest.html#cfn-ec2-ec2fleet-fleetlaunchtemplatespecificationrequest-launchtemplatename
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LaunchTemplateName { get; set; }
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-fleetlaunchtemplatespecificationrequest.html#cfn-ec2-ec2fleet-fleetlaunchtemplatespecificationrequest-version
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Version { get; set; }
            /// <summary>
            /// LaunchTemplateId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-fleetlaunchtemplatespecificationrequest.html#cfn-ec2-ec2fleet-fleetlaunchtemplatespecificationrequest-launchtemplateid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LaunchTemplateId { get; set; }
            /// <summary>
            /// LaunchTemplateSpecificationUserData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-fleetlaunchtemplatespecificationrequest.html#cfn-ec2-ec2fleet-fleetlaunchtemplatespecificationrequest-launchtemplatespecificationuserdata
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LaunchTemplateSpecificationUserData { get; set; }
        }

        public class IamInstanceProfileSpecification : Humidifier.Base.BaseSubResource, IHaveArn, IHaveName
        {
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-iaminstanceprofilespecification.html#cfn-ec2-ec2fleet-iaminstanceprofilespecification-arn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-iaminstanceprofilespecification.html#cfn-ec2-ec2fleet-iaminstanceprofilespecification-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class InstanceMetadataOptionsRequest : Humidifier.Base.BaseSubResource, IHaveHttpPutResponseHopLimit_Integer, IHaveHttpTokens, IHaveHttpEndpoint
        {
            /// <summary>
            /// HttpPutResponseHopLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-instancemetadataoptionsrequest.html#cfn-ec2-ec2fleet-instancemetadataoptionsrequest-httpputresponsehoplimit
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? HttpPutResponseHopLimit { get; set; }
            /// <summary>
            /// HttpTokens
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-instancemetadataoptionsrequest.html#cfn-ec2-ec2fleet-instancemetadataoptionsrequest-httptokens
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HttpTokens { get; set; }
            /// <summary>
            /// HttpEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-instancemetadataoptionsrequest.html#cfn-ec2-ec2fleet-instancemetadataoptionsrequest-httpendpoint
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HttpEndpoint { get; set; }
        }

        public class InstanceRequirementsRequest : Humidifier.Base.BaseSubResource, IHaveStringListOfInstanceGenerations, IHaveRequireEncryptionInTransit_Boolean, IHaveEC2EC2FleetTypesMemoryGiBPerVCpuRequestMemoryGiBPerVCpu, IHaveStringListOfAcceleratorTypes, IHaveEC2EC2FleetTypesVCpuCountRangeRequestVCpuCount, IHaveStringListOfAcceleratorManufacturers, IHaveLocalStorage, IHaveStringListOfCpuManufacturers, IHaveBareMetal, IHaveRequireHibernateSupport_Boolean, IHaveMaxSpotPriceAsPercentageOfOptimalOnDemandPrice_Integer, IHaveOnDemandMaxPricePercentageOverLowestPrice_Integer, IHaveEC2EC2FleetTypesMemoryMiBRequestMemoryMiB, IHaveStringListOfLocalStorageTypes, IHaveEC2EC2FleetTypesNetworkInterfaceCountRequestNetworkInterfaceCount, IHaveStringListOfExcludedInstanceTypes, IHaveStringListOfAllowedInstanceTypes, IHaveEC2EC2FleetTypesNetworkBandwidthGbpsRequestNetworkBandwidthGbps, IHaveEC2EC2FleetTypesAcceleratorCountRequestAcceleratorCount, IHaveEC2EC2FleetTypesBaselinePerformanceFactorsRequestBaselinePerformanceFactors, IHaveSpotMaxPricePercentageOverLowestPrice_Integer, IHaveEC2EC2FleetTypesBaselineEbsBandwidthMbpsRequestBaselineEbsBandwidthMbps, IHaveStringListOfAcceleratorNames, IHaveEC2EC2FleetTypesAcceleratorTotalMemoryMiBRequestAcceleratorTotalMemoryMiB, IHaveBurstablePerformance, IHaveEC2EC2FleetTypesTotalLocalStorageGBRequestTotalLocalStorageGB
        {
            /// <summary>
            /// InstanceGenerations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-instancerequirementsrequest.html#cfn-ec2-ec2fleet-instancerequirementsrequest-instancegenerations
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? InstanceGenerations { get; set; }
            /// <summary>
            /// RequireEncryptionInTransit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-instancerequirementsrequest.html#cfn-ec2-ec2fleet-instancerequirementsrequest-requireencryptionintransit
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? RequireEncryptionInTransit { get; set; }
            /// <summary>
            /// MemoryGiBPerVCpu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-instancerequirementsrequest.html#cfn-ec2-ec2fleet-instancerequirementsrequest-memorygibpervcpu
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MemoryGiBPerVCpuRequest
            /// </summary>
            public Union<Humidifier.EC2.EC2FleetTypes.MemoryGiBPerVCpuRequest, BaseFunction>? MemoryGiBPerVCpu { get; set; }
            /// <summary>
            /// AcceleratorTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-instancerequirementsrequest.html#cfn-ec2-ec2fleet-instancerequirementsrequest-acceleratortypes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AcceleratorTypes { get; set; }
            /// <summary>
            /// VCpuCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-instancerequirementsrequest.html#cfn-ec2-ec2fleet-instancerequirementsrequest-vcpucount
            /// Required: False
            /// UpdateType: Immutable
            /// Type: VCpuCountRangeRequest
            /// </summary>
            public Union<Humidifier.EC2.EC2FleetTypes.VCpuCountRangeRequest, BaseFunction>? VCpuCount { get; set; }
            /// <summary>
            /// AcceleratorManufacturers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-instancerequirementsrequest.html#cfn-ec2-ec2fleet-instancerequirementsrequest-acceleratormanufacturers
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AcceleratorManufacturers { get; set; }
            /// <summary>
            /// LocalStorage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-instancerequirementsrequest.html#cfn-ec2-ec2fleet-instancerequirementsrequest-localstorage
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LocalStorage { get; set; }
            /// <summary>
            /// CpuManufacturers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-instancerequirementsrequest.html#cfn-ec2-ec2fleet-instancerequirementsrequest-cpumanufacturers
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CpuManufacturers { get; set; }
            /// <summary>
            /// BareMetal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-instancerequirementsrequest.html#cfn-ec2-ec2fleet-instancerequirementsrequest-baremetal
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BareMetal { get; set; }
            /// <summary>
            /// RequireHibernateSupport
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-instancerequirementsrequest.html#cfn-ec2-ec2fleet-instancerequirementsrequest-requirehibernatesupport
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? RequireHibernateSupport { get; set; }
            /// <summary>
            /// MaxSpotPriceAsPercentageOfOptimalOnDemandPrice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-instancerequirementsrequest.html#cfn-ec2-ec2fleet-instancerequirementsrequest-maxspotpriceaspercentageofoptimalondemandprice
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxSpotPriceAsPercentageOfOptimalOnDemandPrice { get; set; }
            /// <summary>
            /// OnDemandMaxPricePercentageOverLowestPrice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-instancerequirementsrequest.html#cfn-ec2-ec2fleet-instancerequirementsrequest-ondemandmaxpricepercentageoverlowestprice
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? OnDemandMaxPricePercentageOverLowestPrice { get; set; }
            /// <summary>
            /// MemoryMiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-instancerequirementsrequest.html#cfn-ec2-ec2fleet-instancerequirementsrequest-memorymib
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MemoryMiBRequest
            /// </summary>
            public Union<Humidifier.EC2.EC2FleetTypes.MemoryMiBRequest, BaseFunction>? MemoryMiB { get; set; }
            /// <summary>
            /// LocalStorageTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-instancerequirementsrequest.html#cfn-ec2-ec2fleet-instancerequirementsrequest-localstoragetypes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LocalStorageTypes { get; set; }
            /// <summary>
            /// NetworkInterfaceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-instancerequirementsrequest.html#cfn-ec2-ec2fleet-instancerequirementsrequest-networkinterfacecount
            /// Required: False
            /// UpdateType: Immutable
            /// Type: NetworkInterfaceCountRequest
            /// </summary>
            public Union<Humidifier.EC2.EC2FleetTypes.NetworkInterfaceCountRequest, BaseFunction>? NetworkInterfaceCount { get; set; }
            /// <summary>
            /// ExcludedInstanceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-instancerequirementsrequest.html#cfn-ec2-ec2fleet-instancerequirementsrequest-excludedinstancetypes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ExcludedInstanceTypes { get; set; }
            /// <summary>
            /// AllowedInstanceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-instancerequirementsrequest.html#cfn-ec2-ec2fleet-instancerequirementsrequest-allowedinstancetypes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedInstanceTypes { get; set; }
            /// <summary>
            /// NetworkBandwidthGbps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-instancerequirementsrequest.html#cfn-ec2-ec2fleet-instancerequirementsrequest-networkbandwidthgbps
            /// Required: False
            /// UpdateType: Immutable
            /// Type: NetworkBandwidthGbpsRequest
            /// </summary>
            public Union<Humidifier.EC2.EC2FleetTypes.NetworkBandwidthGbpsRequest, BaseFunction>? NetworkBandwidthGbps { get; set; }
            /// <summary>
            /// AcceleratorCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-instancerequirementsrequest.html#cfn-ec2-ec2fleet-instancerequirementsrequest-acceleratorcount
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AcceleratorCountRequest
            /// </summary>
            public Union<Humidifier.EC2.EC2FleetTypes.AcceleratorCountRequest, BaseFunction>? AcceleratorCount { get; set; }
            /// <summary>
            /// BaselinePerformanceFactors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-instancerequirementsrequest.html#cfn-ec2-ec2fleet-instancerequirementsrequest-baselineperformancefactors
            /// Required: False
            /// UpdateType: Immutable
            /// Type: BaselinePerformanceFactorsRequest
            /// </summary>
            public Union<Humidifier.EC2.EC2FleetTypes.BaselinePerformanceFactorsRequest, BaseFunction>? BaselinePerformanceFactors { get; set; }
            /// <summary>
            /// SpotMaxPricePercentageOverLowestPrice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-instancerequirementsrequest.html#cfn-ec2-ec2fleet-instancerequirementsrequest-spotmaxpricepercentageoverlowestprice
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SpotMaxPricePercentageOverLowestPrice { get; set; }
            /// <summary>
            /// BaselineEbsBandwidthMbps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-instancerequirementsrequest.html#cfn-ec2-ec2fleet-instancerequirementsrequest-baselineebsbandwidthmbps
            /// Required: False
            /// UpdateType: Immutable
            /// Type: BaselineEbsBandwidthMbpsRequest
            /// </summary>
            public Union<Humidifier.EC2.EC2FleetTypes.BaselineEbsBandwidthMbpsRequest, BaseFunction>? BaselineEbsBandwidthMbps { get; set; }
            /// <summary>
            /// AcceleratorNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-instancerequirementsrequest.html#cfn-ec2-ec2fleet-instancerequirementsrequest-acceleratornames
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AcceleratorNames { get; set; }
            /// <summary>
            /// AcceleratorTotalMemoryMiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-instancerequirementsrequest.html#cfn-ec2-ec2fleet-instancerequirementsrequest-acceleratortotalmemorymib
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AcceleratorTotalMemoryMiBRequest
            /// </summary>
            public Union<Humidifier.EC2.EC2FleetTypes.AcceleratorTotalMemoryMiBRequest, BaseFunction>? AcceleratorTotalMemoryMiB { get; set; }
            /// <summary>
            /// BurstablePerformance
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-instancerequirementsrequest.html#cfn-ec2-ec2fleet-instancerequirementsrequest-burstableperformance
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BurstablePerformance { get; set; }
            /// <summary>
            /// TotalLocalStorageGB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-instancerequirementsrequest.html#cfn-ec2-ec2fleet-instancerequirementsrequest-totallocalstoragegb
            /// Required: False
            /// UpdateType: Immutable
            /// Type: TotalLocalStorageGBRequest
            /// </summary>
            public Union<Humidifier.EC2.EC2FleetTypes.TotalLocalStorageGBRequest, BaseFunction>? TotalLocalStorageGB { get; set; }
        }

        public class Ipv6AddressRequest : Humidifier.Base.BaseSubResource, IHaveIpv6Address
        {
            /// <summary>
            /// Ipv6Address
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-ipv6addressrequest.html#cfn-ec2-ec2fleet-ipv6addressrequest-ipv6address
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Ipv6Address { get; set; }
        }

        public class MaintenanceStrategies : Humidifier.Base.BaseSubResource, IHaveEC2EC2FleetTypesCapacityRebalanceCapacityRebalance
        {
            /// <summary>
            /// CapacityRebalance
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-maintenancestrategies.html#cfn-ec2-ec2fleet-maintenancestrategies-capacityrebalance
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CapacityRebalance
            /// </summary>
            public Union<Humidifier.EC2.EC2FleetTypes.CapacityRebalance, BaseFunction>? CapacityRebalance { get; set; }
        }

        public class MemoryGiBPerVCpuRequest : Humidifier.Base.BaseSubResource, IHaveMin_Double, IHaveMax_Double
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-memorygibpervcpurequest.html#cfn-ec2-ec2fleet-memorygibpervcpurequest-min
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-memorygibpervcpurequest.html#cfn-ec2-ec2fleet-memorygibpervcpurequest-max
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Max { get; set; }
        }

        public class MemoryMiBRequest : Humidifier.Base.BaseSubResource, IHaveMin_Integer, IHaveMax_Integer
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-memorymibrequest.html#cfn-ec2-ec2fleet-memorymibrequest-min
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-memorymibrequest.html#cfn-ec2-ec2fleet-memorymibrequest-max
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Max { get; set; }
        }

        public class MultiAvailabilityZoneConfiguration : Humidifier.Base.BaseSubResource, IHaveConfigurationType, IHaveListOfEC2EC2FleetTypesStandbyAvailabilityZoneStandbyAvailabilityZones
        {
            /// <summary>
            /// ConfigurationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-multiavailabilityzoneconfiguration.html#cfn-ec2-ec2fleet-multiavailabilityzoneconfiguration-configurationtype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConfigurationType { get; set; }
            /// <summary>
            /// StandbyAvailabilityZones
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-multiavailabilityzoneconfiguration.html#cfn-ec2-ec2fleet-multiavailabilityzoneconfiguration-standbyavailabilityzones
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: StandbyAvailabilityZone
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.EC2FleetTypes.StandbyAvailabilityZone>, IReadOnlyList<Union<Humidifier.EC2.EC2FleetTypes.StandbyAvailabilityZone, BaseFunction>>, BaseFunction>? StandbyAvailabilityZones { get; set; }
        }

        public class NetworkBandwidthGbpsRequest : Humidifier.Base.BaseSubResource, IHaveMin_Double, IHaveMax_Double
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-networkbandwidthgbpsrequest.html#cfn-ec2-ec2fleet-networkbandwidthgbpsrequest-min
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-networkbandwidthgbpsrequest.html#cfn-ec2-ec2fleet-networkbandwidthgbpsrequest-max
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Max { get; set; }
        }

        public class NetworkInterfaceCountRequest : Humidifier.Base.BaseSubResource, IHaveMin_Integer, IHaveMax_Integer
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-networkinterfacecountrequest.html#cfn-ec2-ec2fleet-networkinterfacecountrequest-min
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-networkinterfacecountrequest.html#cfn-ec2-ec2fleet-networkinterfacecountrequest-max
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Max { get; set; }
        }

        public class NetworkInterfaceSpecificationRequest : Humidifier.Base.BaseSubResource, IHaveDescription, IHavePrivateIpAddress, IHaveListOfEC2EC2FleetTypesPrivateIpAddressSpecificationRequestPrivateIpAddresses, IHaveSecondaryPrivateIpAddressCount_Integer, IHaveDeviceIndex_Integer, IHaveListOfEC2EC2FleetTypesIpv6AddressRequestIpv6Addresses, IHaveSubnetId, IHaveAssociatePublicIpAddress_Boolean, IHaveNetworkCardIndex_Integer, IHaveNetworkInterfaceId, IHaveInterfaceType, IHaveStringListOfGroups, IHaveIpv6AddressCount_Integer, IHaveDeleteOnTermination_Boolean
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-networkinterfacespecificationrequest.html#cfn-ec2-ec2fleet-networkinterfacespecificationrequest-description
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// PrivateIpAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-networkinterfacespecificationrequest.html#cfn-ec2-ec2fleet-networkinterfacespecificationrequest-privateipaddress
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrivateIpAddress { get; set; }
            /// <summary>
            /// PrivateIpAddresses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-networkinterfacespecificationrequest.html#cfn-ec2-ec2fleet-networkinterfacespecificationrequest-privateipaddresses
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: PrivateIpAddressSpecificationRequest
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.EC2FleetTypes.PrivateIpAddressSpecificationRequest>, IReadOnlyList<Union<Humidifier.EC2.EC2FleetTypes.PrivateIpAddressSpecificationRequest, BaseFunction>>, BaseFunction>? PrivateIpAddresses { get; set; }
            /// <summary>
            /// SecondaryPrivateIpAddressCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-networkinterfacespecificationrequest.html#cfn-ec2-ec2fleet-networkinterfacespecificationrequest-secondaryprivateipaddresscount
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SecondaryPrivateIpAddressCount { get; set; }
            /// <summary>
            /// DeviceIndex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-networkinterfacespecificationrequest.html#cfn-ec2-ec2fleet-networkinterfacespecificationrequest-deviceindex
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DeviceIndex { get; set; }
            /// <summary>
            /// Ipv6Addresses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-networkinterfacespecificationrequest.html#cfn-ec2-ec2fleet-networkinterfacespecificationrequest-ipv6addresses
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Ipv6AddressRequest
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.EC2FleetTypes.Ipv6AddressRequest>, IReadOnlyList<Union<Humidifier.EC2.EC2FleetTypes.Ipv6AddressRequest, BaseFunction>>, BaseFunction>? Ipv6Addresses { get; set; }
            /// <summary>
            /// SubnetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-networkinterfacespecificationrequest.html#cfn-ec2-ec2fleet-networkinterfacespecificationrequest-subnetid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SubnetId { get; set; }
            /// <summary>
            /// AssociatePublicIpAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-networkinterfacespecificationrequest.html#cfn-ec2-ec2fleet-networkinterfacespecificationrequest-associatepublicipaddress
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AssociatePublicIpAddress { get; set; }
            /// <summary>
            /// NetworkCardIndex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-networkinterfacespecificationrequest.html#cfn-ec2-ec2fleet-networkinterfacespecificationrequest-networkcardindex
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? NetworkCardIndex { get; set; }
            /// <summary>
            /// NetworkInterfaceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-networkinterfacespecificationrequest.html#cfn-ec2-ec2fleet-networkinterfacespecificationrequest-networkinterfaceid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NetworkInterfaceId { get; set; }
            /// <summary>
            /// InterfaceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-networkinterfacespecificationrequest.html#cfn-ec2-ec2fleet-networkinterfacespecificationrequest-interfacetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InterfaceType { get; set; }
            /// <summary>
            /// Groups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-networkinterfacespecificationrequest.html#cfn-ec2-ec2fleet-networkinterfacespecificationrequest-groups
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Groups { get; set; }
            /// <summary>
            /// Ipv6AddressCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-networkinterfacespecificationrequest.html#cfn-ec2-ec2fleet-networkinterfacespecificationrequest-ipv6addresscount
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Ipv6AddressCount { get; set; }
            /// <summary>
            /// DeleteOnTermination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-networkinterfacespecificationrequest.html#cfn-ec2-ec2fleet-networkinterfacespecificationrequest-deleteontermination
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DeleteOnTermination { get; set; }
        }

        public class OnDemandOptionsRequest : Humidifier.Base.BaseSubResource, IHaveSingleAvailabilityZone_Boolean, IHaveAllocationStrategy, IHaveSingleInstanceType_Boolean, IHaveMinTargetCapacity_Integer, IHaveMaxTotalPrice, IHaveEC2EC2FleetTypesCapacityReservationOptionsRequestCapacityReservationOptions
        {
            /// <summary>
            /// SingleAvailabilityZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-ondemandoptionsrequest.html#cfn-ec2-ec2fleet-ondemandoptionsrequest-singleavailabilityzone
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? SingleAvailabilityZone { get; set; }
            /// <summary>
            /// AllocationStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-ondemandoptionsrequest.html#cfn-ec2-ec2fleet-ondemandoptionsrequest-allocationstrategy
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AllocationStrategy { get; set; }
            /// <summary>
            /// SingleInstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-ondemandoptionsrequest.html#cfn-ec2-ec2fleet-ondemandoptionsrequest-singleinstancetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? SingleInstanceType { get; set; }
            /// <summary>
            /// MinTargetCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-ondemandoptionsrequest.html#cfn-ec2-ec2fleet-ondemandoptionsrequest-mintargetcapacity
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinTargetCapacity { get; set; }
            /// <summary>
            /// MaxTotalPrice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-ondemandoptionsrequest.html#cfn-ec2-ec2fleet-ondemandoptionsrequest-maxtotalprice
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MaxTotalPrice { get; set; }
            /// <summary>
            /// CapacityReservationOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-ondemandoptionsrequest.html#cfn-ec2-ec2fleet-ondemandoptionsrequest-capacityreservationoptions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CapacityReservationOptionsRequest
            /// </summary>
            public Union<Humidifier.EC2.EC2FleetTypes.CapacityReservationOptionsRequest, BaseFunction>? CapacityReservationOptions { get; set; }
        }

        public class PerformanceFactorReferenceRequest : Humidifier.Base.BaseSubResource, IHaveInstanceFamily
        {
            /// <summary>
            /// InstanceFamily
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-performancefactorreferencerequest.html#cfn-ec2-ec2fleet-performancefactorreferencerequest-instancefamily
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceFamily { get; set; }
        }

        public class Placement : Humidifier.Base.BaseSubResource, IHaveGroupName, IHaveTenancy, IHaveSpreadDomain, IHavePartitionNumber_Integer, IHaveAvailabilityZone, IHaveAffinity, IHaveHostId, IHaveHostResourceGroupArn
        {
            /// <summary>
            /// GroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-placement.html#cfn-ec2-ec2fleet-placement-groupname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GroupName { get; set; }
            /// <summary>
            /// Tenancy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-placement.html#cfn-ec2-ec2fleet-placement-tenancy
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Tenancy { get; set; }
            /// <summary>
            /// SpreadDomain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-placement.html#cfn-ec2-ec2fleet-placement-spreaddomain
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SpreadDomain { get; set; }
            /// <summary>
            /// PartitionNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-placement.html#cfn-ec2-ec2fleet-placement-partitionnumber
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? PartitionNumber { get; set; }
            /// <summary>
            /// AvailabilityZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-placement.html#cfn-ec2-ec2fleet-placement-availabilityzone
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AvailabilityZone { get; set; }
            /// <summary>
            /// Affinity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-placement.html#cfn-ec2-ec2fleet-placement-affinity
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Affinity { get; set; }
            /// <summary>
            /// HostId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-placement.html#cfn-ec2-ec2fleet-placement-hostid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HostId { get; set; }
            /// <summary>
            /// HostResourceGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-placement.html#cfn-ec2-ec2fleet-placement-hostresourcegrouparn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HostResourceGroupArn { get; set; }
        }

        public class PrivateIpAddressSpecificationRequest : Humidifier.Base.BaseSubResource, IHavePrivateIpAddress, IHavePrimary_Boolean
        {
            /// <summary>
            /// PrivateIpAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-privateipaddressspecificationrequest.html#cfn-ec2-ec2fleet-privateipaddressspecificationrequest-privateipaddress
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrivateIpAddress { get; set; }
            /// <summary>
            /// Primary
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-privateipaddressspecificationrequest.html#cfn-ec2-ec2fleet-privateipaddressspecificationrequest-primary
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Primary { get; set; }
        }

        public class ReservedCapacityFallbackOptionsRequest : Humidifier.Base.BaseSubResource, IHaveStringListOfMarketTypes
        {
            /// <summary>
            /// MarketTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-reservedcapacityfallbackoptionsrequest.html#cfn-ec2-ec2fleet-reservedcapacityfallbackoptionsrequest-markettypes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? MarketTypes { get; set; }
        }

        public class ReservedCapacityOptionsRequest : Humidifier.Base.BaseSubResource, IHaveAllocationStrategy, IHaveEC2EC2FleetTypesReservedCapacityFallbackOptionsRequestReservedCapacityFallbackOptions, IHaveStringListOfReservationTypes, IHaveEC2EC2FleetTypesCapacityReservationTargetRequestCapacityReservationTarget
        {
            /// <summary>
            /// AllocationStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-reservedcapacityoptionsrequest.html#cfn-ec2-ec2fleet-reservedcapacityoptionsrequest-allocationstrategy
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AllocationStrategy { get; set; }
            /// <summary>
            /// ReservedCapacityFallbackOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-reservedcapacityoptionsrequest.html#cfn-ec2-ec2fleet-reservedcapacityoptionsrequest-reservedcapacityfallbackoptions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ReservedCapacityFallbackOptionsRequest
            /// </summary>
            public Union<Humidifier.EC2.EC2FleetTypes.ReservedCapacityFallbackOptionsRequest, BaseFunction>? ReservedCapacityFallbackOptions { get; set; }
            /// <summary>
            /// ReservationTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-reservedcapacityoptionsrequest.html#cfn-ec2-ec2fleet-reservedcapacityoptionsrequest-reservationtypes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ReservationTypes { get; set; }
            /// <summary>
            /// CapacityReservationTarget
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-reservedcapacityoptionsrequest.html#cfn-ec2-ec2fleet-reservedcapacityoptionsrequest-capacityreservationtarget
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CapacityReservationTargetRequest
            /// </summary>
            public Union<Humidifier.EC2.EC2FleetTypes.CapacityReservationTargetRequest, BaseFunction>? CapacityReservationTarget { get; set; }
        }

        public class SpotOptionsRequest : Humidifier.Base.BaseSubResource, IHaveSingleAvailabilityZone_Boolean, IHaveAllocationStrategy, IHaveSingleInstanceType_Boolean, IHaveMinTargetCapacity_Integer, IHaveMaxTotalPrice, IHaveEC2EC2FleetTypesMaintenanceStrategiesMaintenanceStrategies, IHaveInstanceInterruptionBehavior, IHaveInstancePoolsToUseCount_Integer
        {
            /// <summary>
            /// SingleAvailabilityZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-spotoptionsrequest.html#cfn-ec2-ec2fleet-spotoptionsrequest-singleavailabilityzone
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? SingleAvailabilityZone { get; set; }
            /// <summary>
            /// AllocationStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-spotoptionsrequest.html#cfn-ec2-ec2fleet-spotoptionsrequest-allocationstrategy
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AllocationStrategy { get; set; }
            /// <summary>
            /// SingleInstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-spotoptionsrequest.html#cfn-ec2-ec2fleet-spotoptionsrequest-singleinstancetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? SingleInstanceType { get; set; }
            /// <summary>
            /// MinTargetCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-spotoptionsrequest.html#cfn-ec2-ec2fleet-spotoptionsrequest-mintargetcapacity
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinTargetCapacity { get; set; }
            /// <summary>
            /// MaxTotalPrice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-spotoptionsrequest.html#cfn-ec2-ec2fleet-spotoptionsrequest-maxtotalprice
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MaxTotalPrice { get; set; }
            /// <summary>
            /// MaintenanceStrategies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-spotoptionsrequest.html#cfn-ec2-ec2fleet-spotoptionsrequest-maintenancestrategies
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MaintenanceStrategies
            /// </summary>
            public Union<Humidifier.EC2.EC2FleetTypes.MaintenanceStrategies, BaseFunction>? MaintenanceStrategies { get; set; }
            /// <summary>
            /// InstanceInterruptionBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-spotoptionsrequest.html#cfn-ec2-ec2fleet-spotoptionsrequest-instanceinterruptionbehavior
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceInterruptionBehavior { get; set; }
            /// <summary>
            /// InstancePoolsToUseCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-spotoptionsrequest.html#cfn-ec2-ec2fleet-spotoptionsrequest-instancepoolstousecount
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? InstancePoolsToUseCount { get; set; }
        }

        public class StandbyAvailabilityZone : Humidifier.Base.BaseSubResource, IHaveAvailabilityZoneId, IHaveAvailabilityZone
        {
            /// <summary>
            /// AvailabilityZoneId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-standbyavailabilityzone.html#cfn-ec2-ec2fleet-standbyavailabilityzone-availabilityzoneid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AvailabilityZoneId { get; set; }
            /// <summary>
            /// AvailabilityZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-standbyavailabilityzone.html#cfn-ec2-ec2fleet-standbyavailabilityzone-availabilityzone
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AvailabilityZone { get; set; }
        }

        public class TagSpecification : Humidifier.Base.BaseSubResource, IHaveTags, IHaveResourceType
        {
            /// <summary>
            /// ResourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-tagspecification.html#cfn-ec2-ec2fleet-tagspecification-resourcetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceType { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-tagspecification.html#cfn-ec2-ec2fleet-tagspecification-tags
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        }

        public class TargetCapacitySpecificationRequest : Humidifier.Base.BaseSubResource, IHaveDefaultTargetCapacityType, IHaveTotalTargetCapacity_Integer, IHaveOnDemandTargetCapacity_Integer, IHaveSpotTargetCapacity_Integer, IHaveTargetCapacityUnitType
        {
            /// <summary>
            /// DefaultTargetCapacityType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-targetcapacityspecificationrequest.html#cfn-ec2-ec2fleet-targetcapacityspecificationrequest-defaulttargetcapacitytype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DefaultTargetCapacityType { get; set; }
            /// <summary>
            /// TotalTargetCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-targetcapacityspecificationrequest.html#cfn-ec2-ec2fleet-targetcapacityspecificationrequest-totaltargetcapacity
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TotalTargetCapacity { get; set; }
            /// <summary>
            /// OnDemandTargetCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-targetcapacityspecificationrequest.html#cfn-ec2-ec2fleet-targetcapacityspecificationrequest-ondemandtargetcapacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? OnDemandTargetCapacity { get; set; }
            /// <summary>
            /// SpotTargetCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-targetcapacityspecificationrequest.html#cfn-ec2-ec2fleet-targetcapacityspecificationrequest-spottargetcapacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SpotTargetCapacity { get; set; }
            /// <summary>
            /// TargetCapacityUnitType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-targetcapacityspecificationrequest.html#cfn-ec2-ec2fleet-targetcapacityspecificationrequest-targetcapacityunittype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetCapacityUnitType { get; set; }
        }

        public class TotalLocalStorageGBRequest : Humidifier.Base.BaseSubResource, IHaveMin_Double, IHaveMax_Double
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-totallocalstoragegbrequest.html#cfn-ec2-ec2fleet-totallocalstoragegbrequest-min
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-totallocalstoragegbrequest.html#cfn-ec2-ec2fleet-totallocalstoragegbrequest-max
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Max { get; set; }
        }

        public class VCpuCountRangeRequest : Humidifier.Base.BaseSubResource, IHaveMin_Integer, IHaveMax_Integer
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-vcpucountrangerequest.html#cfn-ec2-ec2fleet-vcpucountrangerequest-min
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ec2fleet-vcpucountrangerequest.html#cfn-ec2-ec2fleet-vcpucountrangerequest-max
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Max { get; set; }
        }
    }
}