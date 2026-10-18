namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using SpotFleetTypes;

    public class SpotFleet : Humidifier.Base.BaseResource, IHaveTags, IHaveEC2SpotFleetTypesSpotFleetRequestConfigDataSpotFleetRequestConfigData
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.EC2.SpotFleet; }

        /// <summary>
        /// SpotFleetRequestConfigData
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-spotfleet.html#cfn-ec2-spotfleet-spotfleetrequestconfigdata
        /// Required: True
        /// UpdateType: Mutable
        /// Type: SpotFleetRequestConfigData
        /// </summary>
        [Required]
        public Union<Humidifier.EC2.SpotFleetTypes.SpotFleetRequestConfigData, BaseFunction>? SpotFleetRequestConfigData { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-spotfleet.html#cfn-ec2-spotfleet-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace SpotFleetTypes
    {
        public class AcceleratorCountRequest : Humidifier.Base.BaseSubResource, IHaveMin_Integer, IHaveMax_Integer
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-acceleratorcountrequest.html#cfn-ec2-spotfleet-acceleratorcountrequest-min
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-acceleratorcountrequest.html#cfn-ec2-spotfleet-acceleratorcountrequest-max
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Max { get; set; }
        }

        public class AcceleratorTotalMemoryMiBRequest : Humidifier.Base.BaseSubResource, IHaveMin_Integer, IHaveMax_Integer
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-acceleratortotalmemorymibrequest.html#cfn-ec2-spotfleet-acceleratortotalmemorymibrequest-min
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-acceleratortotalmemorymibrequest.html#cfn-ec2-spotfleet-acceleratortotalmemorymibrequest-max
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Max { get; set; }
        }

        public class BaselineEbsBandwidthMbpsRequest : Humidifier.Base.BaseSubResource, IHaveMin_Integer, IHaveMax_Integer
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-baselineebsbandwidthmbpsrequest.html#cfn-ec2-spotfleet-baselineebsbandwidthmbpsrequest-min
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-baselineebsbandwidthmbpsrequest.html#cfn-ec2-spotfleet-baselineebsbandwidthmbpsrequest-max
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Max { get; set; }
        }

        public class BaselinePerformanceFactorsRequest : Humidifier.Base.BaseSubResource, IHaveEC2SpotFleetTypesCpuPerformanceFactorRequestCpu
        {
            /// <summary>
            /// Cpu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-baselineperformancefactorsrequest.html#cfn-ec2-spotfleet-baselineperformancefactorsrequest-cpu
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CpuPerformanceFactorRequest
            /// </summary>
            public Union<Humidifier.EC2.SpotFleetTypes.CpuPerformanceFactorRequest, BaseFunction>? Cpu { get; set; }
        }

        public class BlockDeviceMapping : Humidifier.Base.BaseSubResource, IHaveEC2SpotFleetTypesEbsBlockDeviceEbs, IHaveNoDevice, IHaveVirtualName, IHaveDeviceName
        {
            /// <summary>
            /// Ebs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-blockdevicemapping.html#cfn-ec2-spotfleet-blockdevicemapping-ebs
            /// Required: False
            /// UpdateType: Immutable
            /// Type: EbsBlockDevice
            /// </summary>
            public Union<Humidifier.EC2.SpotFleetTypes.EbsBlockDevice, BaseFunction>? Ebs { get; set; }
            /// <summary>
            /// NoDevice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-blockdevicemapping.html#cfn-ec2-spotfleet-blockdevicemapping-nodevice
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NoDevice { get; set; }
            /// <summary>
            /// VirtualName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-blockdevicemapping.html#cfn-ec2-spotfleet-blockdevicemapping-virtualname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VirtualName { get; set; }
            /// <summary>
            /// DeviceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-blockdevicemapping.html#cfn-ec2-spotfleet-blockdevicemapping-devicename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeviceName { get; set; }
        }

        public class ClassicLoadBalancer : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-classicloadbalancer.html#cfn-ec2-spotfleet-classicloadbalancer-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class ClassicLoadBalancersConfig : Humidifier.Base.BaseSubResource, IHaveListOfEC2SpotFleetTypesClassicLoadBalancerClassicLoadBalancers
        {
            /// <summary>
            /// ClassicLoadBalancers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-classicloadbalancersconfig.html#cfn-ec2-spotfleet-classicloadbalancersconfig-classicloadbalancers
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ClassicLoadBalancer
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.SpotFleetTypes.ClassicLoadBalancer>, IReadOnlyList<Union<Humidifier.EC2.SpotFleetTypes.ClassicLoadBalancer, BaseFunction>>, BaseFunction>? ClassicLoadBalancers { get; set; }
        }

        public class CpuPerformanceFactorRequest : Humidifier.Base.BaseSubResource, IHaveListOfEC2SpotFleetTypesPerformanceFactorReferenceRequestReferences
        {
            /// <summary>
            /// References
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-cpuperformancefactorrequest.html#cfn-ec2-spotfleet-cpuperformancefactorrequest-references
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PerformanceFactorReferenceRequest
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.SpotFleetTypes.PerformanceFactorReferenceRequest>, IReadOnlyList<Union<Humidifier.EC2.SpotFleetTypes.PerformanceFactorReferenceRequest, BaseFunction>>, BaseFunction>? References { get; set; }
        }

        public class EbsBlockDevice : Humidifier.Base.BaseSubResource, IHaveSnapshotId, IHaveVolumeType, IHaveEncrypted_Boolean, IHaveIops_Integer, IHaveVolumeSize_Integer, IHaveDeleteOnTermination_Boolean
        {
            /// <summary>
            /// SnapshotId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-ebsblockdevice.html#cfn-ec2-spotfleet-ebsblockdevice-snapshotid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SnapshotId { get; set; }
            /// <summary>
            /// VolumeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-ebsblockdevice.html#cfn-ec2-spotfleet-ebsblockdevice-volumetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VolumeType { get; set; }
            /// <summary>
            /// Encrypted
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-ebsblockdevice.html#cfn-ec2-spotfleet-ebsblockdevice-encrypted
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Encrypted { get; set; }
            /// <summary>
            /// Iops
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-ebsblockdevice.html#cfn-ec2-spotfleet-ebsblockdevice-iops
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Iops { get; set; }
            /// <summary>
            /// VolumeSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-ebsblockdevice.html#cfn-ec2-spotfleet-ebsblockdevice-volumesize
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? VolumeSize { get; set; }
            /// <summary>
            /// DeleteOnTermination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-ebsblockdevice.html#cfn-ec2-spotfleet-ebsblockdevice-deleteontermination
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DeleteOnTermination { get; set; }
        }

        public class FleetLaunchTemplateSpecification : Humidifier.Base.BaseSubResource, IHaveLaunchTemplateName, IHaveVersion, IHaveLaunchTemplateId
        {
            /// <summary>
            /// LaunchTemplateName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-fleetlaunchtemplatespecification.html#cfn-ec2-spotfleet-fleetlaunchtemplatespecification-launchtemplatename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LaunchTemplateName { get; set; }
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-fleetlaunchtemplatespecification.html#cfn-ec2-spotfleet-fleetlaunchtemplatespecification-version
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Version { get; set; }
            /// <summary>
            /// LaunchTemplateId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-fleetlaunchtemplatespecification.html#cfn-ec2-spotfleet-fleetlaunchtemplatespecification-launchtemplateid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LaunchTemplateId { get; set; }
        }

        public class GroupIdentifier : Humidifier.Base.BaseSubResource, IHaveGroupId
        {
            /// <summary>
            /// GroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-groupidentifier.html#cfn-ec2-spotfleet-groupidentifier-groupid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GroupId { get; set; }
        }

        public class IamInstanceProfileSpecification : Humidifier.Base.BaseSubResource, IHaveArn
        {
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-iaminstanceprofilespecification.html#cfn-ec2-spotfleet-iaminstanceprofilespecification-arn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
        }

        public class InstanceIpv6Address : Humidifier.Base.BaseSubResource, IHaveIpv6Address
        {
            /// <summary>
            /// Ipv6Address
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-instanceipv6address.html#cfn-ec2-spotfleet-instanceipv6address-ipv6address
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Ipv6Address { get; set; }
        }

        public class InstanceNetworkInterfaceSpecification : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveListOfEC2SpotFleetTypesPrivateIpAddressSpecificationPrivateIpAddresses, IHaveSecondaryPrivateIpAddressCount_Integer, IHaveDeviceIndex_Integer, IHaveStringListOfGroups, IHaveIpv6AddressCount_Integer, IHaveListOfEC2SpotFleetTypesInstanceIpv6AddressIpv6Addresses, IHaveSubnetId, IHaveAssociatePublicIpAddress_Boolean, IHaveNetworkInterfaceId, IHaveDeleteOnTermination_Boolean
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-instancenetworkinterfacespecification.html#cfn-ec2-spotfleet-instancenetworkinterfacespecification-description
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// PrivateIpAddresses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-instancenetworkinterfacespecification.html#cfn-ec2-spotfleet-instancenetworkinterfacespecification-privateipaddresses
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: PrivateIpAddressSpecification
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.SpotFleetTypes.PrivateIpAddressSpecification>, IReadOnlyList<Union<Humidifier.EC2.SpotFleetTypes.PrivateIpAddressSpecification, BaseFunction>>, BaseFunction>? PrivateIpAddresses { get; set; }
            /// <summary>
            /// SecondaryPrivateIpAddressCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-instancenetworkinterfacespecification.html#cfn-ec2-spotfleet-instancenetworkinterfacespecification-secondaryprivateipaddresscount
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SecondaryPrivateIpAddressCount { get; set; }
            /// <summary>
            /// DeviceIndex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-instancenetworkinterfacespecification.html#cfn-ec2-spotfleet-instancenetworkinterfacespecification-deviceindex
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DeviceIndex { get; set; }
            /// <summary>
            /// Groups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-instancenetworkinterfacespecification.html#cfn-ec2-spotfleet-instancenetworkinterfacespecification-groups
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Groups { get; set; }
            /// <summary>
            /// Ipv6AddressCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-instancenetworkinterfacespecification.html#cfn-ec2-spotfleet-instancenetworkinterfacespecification-ipv6addresscount
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Ipv6AddressCount { get; set; }
            /// <summary>
            /// Ipv6Addresses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-instancenetworkinterfacespecification.html#cfn-ec2-spotfleet-instancenetworkinterfacespecification-ipv6addresses
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: InstanceIpv6Address
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.SpotFleetTypes.InstanceIpv6Address>, IReadOnlyList<Union<Humidifier.EC2.SpotFleetTypes.InstanceIpv6Address, BaseFunction>>, BaseFunction>? Ipv6Addresses { get; set; }
            /// <summary>
            /// SubnetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-instancenetworkinterfacespecification.html#cfn-ec2-spotfleet-instancenetworkinterfacespecification-subnetid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SubnetId { get; set; }
            /// <summary>
            /// AssociatePublicIpAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-instancenetworkinterfacespecification.html#cfn-ec2-spotfleet-instancenetworkinterfacespecification-associatepublicipaddress
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AssociatePublicIpAddress { get; set; }
            /// <summary>
            /// NetworkInterfaceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-instancenetworkinterfacespecification.html#cfn-ec2-spotfleet-instancenetworkinterfacespecification-networkinterfaceid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NetworkInterfaceId { get; set; }
            /// <summary>
            /// DeleteOnTermination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-instancenetworkinterfacespecification.html#cfn-ec2-spotfleet-instancenetworkinterfacespecification-deleteontermination
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DeleteOnTermination { get; set; }
        }

        public class InstanceRequirementsRequest : Humidifier.Base.BaseSubResource, IHaveStringListOfInstanceGenerations, IHaveRequireEncryptionInTransit_Boolean, IHaveEC2SpotFleetTypesMemoryGiBPerVCpuRequestMemoryGiBPerVCpu, IHaveStringListOfAcceleratorTypes, IHaveEC2SpotFleetTypesVCpuCountRangeRequestVCpuCount, IHaveStringListOfAcceleratorManufacturers, IHaveLocalStorage, IHaveStringListOfCpuManufacturers, IHaveBareMetal, IHaveRequireHibernateSupport_Boolean, IHaveMaxSpotPriceAsPercentageOfOptimalOnDemandPrice_Integer, IHaveOnDemandMaxPricePercentageOverLowestPrice_Integer, IHaveEC2SpotFleetTypesMemoryMiBRequestMemoryMiB, IHaveStringListOfLocalStorageTypes, IHaveEC2SpotFleetTypesNetworkInterfaceCountRequestNetworkInterfaceCount, IHaveStringListOfExcludedInstanceTypes, IHaveStringListOfAllowedInstanceTypes, IHaveEC2SpotFleetTypesNetworkBandwidthGbpsRequestNetworkBandwidthGbps, IHaveEC2SpotFleetTypesAcceleratorCountRequestAcceleratorCount, IHaveEC2SpotFleetTypesBaselinePerformanceFactorsRequestBaselinePerformanceFactors, IHaveSpotMaxPricePercentageOverLowestPrice_Integer, IHaveEC2SpotFleetTypesBaselineEbsBandwidthMbpsRequestBaselineEbsBandwidthMbps, IHaveStringListOfAcceleratorNames, IHaveEC2SpotFleetTypesAcceleratorTotalMemoryMiBRequestAcceleratorTotalMemoryMiB, IHaveBurstablePerformance, IHaveEC2SpotFleetTypesTotalLocalStorageGBRequestTotalLocalStorageGB
        {
            /// <summary>
            /// InstanceGenerations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-instancerequirementsrequest.html#cfn-ec2-spotfleet-instancerequirementsrequest-instancegenerations
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? InstanceGenerations { get; set; }
            /// <summary>
            /// RequireEncryptionInTransit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-instancerequirementsrequest.html#cfn-ec2-spotfleet-instancerequirementsrequest-requireencryptionintransit
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? RequireEncryptionInTransit { get; set; }
            /// <summary>
            /// MemoryGiBPerVCpu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-instancerequirementsrequest.html#cfn-ec2-spotfleet-instancerequirementsrequest-memorygibpervcpu
            /// Required: False
            /// UpdateType: Conditional
            /// Type: MemoryGiBPerVCpuRequest
            /// </summary>
            public Union<Humidifier.EC2.SpotFleetTypes.MemoryGiBPerVCpuRequest, BaseFunction>? MemoryGiBPerVCpu { get; set; }
            /// <summary>
            /// AcceleratorTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-instancerequirementsrequest.html#cfn-ec2-spotfleet-instancerequirementsrequest-acceleratortypes
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AcceleratorTypes { get; set; }
            /// <summary>
            /// VCpuCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-instancerequirementsrequest.html#cfn-ec2-spotfleet-instancerequirementsrequest-vcpucount
            /// Required: False
            /// UpdateType: Conditional
            /// Type: VCpuCountRangeRequest
            /// </summary>
            public Union<Humidifier.EC2.SpotFleetTypes.VCpuCountRangeRequest, BaseFunction>? VCpuCount { get; set; }
            /// <summary>
            /// AcceleratorManufacturers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-instancerequirementsrequest.html#cfn-ec2-spotfleet-instancerequirementsrequest-acceleratormanufacturers
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AcceleratorManufacturers { get; set; }
            /// <summary>
            /// LocalStorage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-instancerequirementsrequest.html#cfn-ec2-spotfleet-instancerequirementsrequest-localstorage
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LocalStorage { get; set; }
            /// <summary>
            /// CpuManufacturers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-instancerequirementsrequest.html#cfn-ec2-spotfleet-instancerequirementsrequest-cpumanufacturers
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CpuManufacturers { get; set; }
            /// <summary>
            /// BareMetal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-instancerequirementsrequest.html#cfn-ec2-spotfleet-instancerequirementsrequest-baremetal
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BareMetal { get; set; }
            /// <summary>
            /// RequireHibernateSupport
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-instancerequirementsrequest.html#cfn-ec2-spotfleet-instancerequirementsrequest-requirehibernatesupport
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? RequireHibernateSupport { get; set; }
            /// <summary>
            /// MaxSpotPriceAsPercentageOfOptimalOnDemandPrice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-instancerequirementsrequest.html#cfn-ec2-spotfleet-instancerequirementsrequest-maxspotpriceaspercentageofoptimalondemandprice
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxSpotPriceAsPercentageOfOptimalOnDemandPrice { get; set; }
            /// <summary>
            /// OnDemandMaxPricePercentageOverLowestPrice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-instancerequirementsrequest.html#cfn-ec2-spotfleet-instancerequirementsrequest-ondemandmaxpricepercentageoverlowestprice
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? OnDemandMaxPricePercentageOverLowestPrice { get; set; }
            /// <summary>
            /// MemoryMiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-instancerequirementsrequest.html#cfn-ec2-spotfleet-instancerequirementsrequest-memorymib
            /// Required: False
            /// UpdateType: Conditional
            /// Type: MemoryMiBRequest
            /// </summary>
            public Union<Humidifier.EC2.SpotFleetTypes.MemoryMiBRequest, BaseFunction>? MemoryMiB { get; set; }
            /// <summary>
            /// LocalStorageTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-instancerequirementsrequest.html#cfn-ec2-spotfleet-instancerequirementsrequest-localstoragetypes
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LocalStorageTypes { get; set; }
            /// <summary>
            /// NetworkInterfaceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-instancerequirementsrequest.html#cfn-ec2-spotfleet-instancerequirementsrequest-networkinterfacecount
            /// Required: False
            /// UpdateType: Conditional
            /// Type: NetworkInterfaceCountRequest
            /// </summary>
            public Union<Humidifier.EC2.SpotFleetTypes.NetworkInterfaceCountRequest, BaseFunction>? NetworkInterfaceCount { get; set; }
            /// <summary>
            /// ExcludedInstanceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-instancerequirementsrequest.html#cfn-ec2-spotfleet-instancerequirementsrequest-excludedinstancetypes
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ExcludedInstanceTypes { get; set; }
            /// <summary>
            /// AllowedInstanceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-instancerequirementsrequest.html#cfn-ec2-spotfleet-instancerequirementsrequest-allowedinstancetypes
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedInstanceTypes { get; set; }
            /// <summary>
            /// NetworkBandwidthGbps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-instancerequirementsrequest.html#cfn-ec2-spotfleet-instancerequirementsrequest-networkbandwidthgbps
            /// Required: False
            /// UpdateType: Conditional
            /// Type: NetworkBandwidthGbpsRequest
            /// </summary>
            public Union<Humidifier.EC2.SpotFleetTypes.NetworkBandwidthGbpsRequest, BaseFunction>? NetworkBandwidthGbps { get; set; }
            /// <summary>
            /// AcceleratorCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-instancerequirementsrequest.html#cfn-ec2-spotfleet-instancerequirementsrequest-acceleratorcount
            /// Required: False
            /// UpdateType: Conditional
            /// Type: AcceleratorCountRequest
            /// </summary>
            public Union<Humidifier.EC2.SpotFleetTypes.AcceleratorCountRequest, BaseFunction>? AcceleratorCount { get; set; }
            /// <summary>
            /// BaselinePerformanceFactors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-instancerequirementsrequest.html#cfn-ec2-spotfleet-instancerequirementsrequest-baselineperformancefactors
            /// Required: False
            /// UpdateType: Conditional
            /// Type: BaselinePerformanceFactorsRequest
            /// </summary>
            public Union<Humidifier.EC2.SpotFleetTypes.BaselinePerformanceFactorsRequest, BaseFunction>? BaselinePerformanceFactors { get; set; }
            /// <summary>
            /// SpotMaxPricePercentageOverLowestPrice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-instancerequirementsrequest.html#cfn-ec2-spotfleet-instancerequirementsrequest-spotmaxpricepercentageoverlowestprice
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SpotMaxPricePercentageOverLowestPrice { get; set; }
            /// <summary>
            /// BaselineEbsBandwidthMbps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-instancerequirementsrequest.html#cfn-ec2-spotfleet-instancerequirementsrequest-baselineebsbandwidthmbps
            /// Required: False
            /// UpdateType: Conditional
            /// Type: BaselineEbsBandwidthMbpsRequest
            /// </summary>
            public Union<Humidifier.EC2.SpotFleetTypes.BaselineEbsBandwidthMbpsRequest, BaseFunction>? BaselineEbsBandwidthMbps { get; set; }
            /// <summary>
            /// AcceleratorNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-instancerequirementsrequest.html#cfn-ec2-spotfleet-instancerequirementsrequest-acceleratornames
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AcceleratorNames { get; set; }
            /// <summary>
            /// AcceleratorTotalMemoryMiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-instancerequirementsrequest.html#cfn-ec2-spotfleet-instancerequirementsrequest-acceleratortotalmemorymib
            /// Required: False
            /// UpdateType: Conditional
            /// Type: AcceleratorTotalMemoryMiBRequest
            /// </summary>
            public Union<Humidifier.EC2.SpotFleetTypes.AcceleratorTotalMemoryMiBRequest, BaseFunction>? AcceleratorTotalMemoryMiB { get; set; }
            /// <summary>
            /// BurstablePerformance
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-instancerequirementsrequest.html#cfn-ec2-spotfleet-instancerequirementsrequest-burstableperformance
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BurstablePerformance { get; set; }
            /// <summary>
            /// TotalLocalStorageGB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-instancerequirementsrequest.html#cfn-ec2-spotfleet-instancerequirementsrequest-totallocalstoragegb
            /// Required: False
            /// UpdateType: Conditional
            /// Type: TotalLocalStorageGBRequest
            /// </summary>
            public Union<Humidifier.EC2.SpotFleetTypes.TotalLocalStorageGBRequest, BaseFunction>? TotalLocalStorageGB { get; set; }
        }

        public class LaunchTemplateConfig : Humidifier.Base.BaseSubResource, IHaveEC2SpotFleetTypesFleetLaunchTemplateSpecificationLaunchTemplateSpecification, IHaveListOfEC2SpotFleetTypesLaunchTemplateOverridesOverrides
        {
            /// <summary>
            /// LaunchTemplateSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-launchtemplateconfig.html#cfn-ec2-spotfleet-launchtemplateconfig-launchtemplatespecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FleetLaunchTemplateSpecification
            /// </summary>
            public Union<Humidifier.EC2.SpotFleetTypes.FleetLaunchTemplateSpecification, BaseFunction>? LaunchTemplateSpecification { get; set; }
            /// <summary>
            /// Overrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-launchtemplateconfig.html#cfn-ec2-spotfleet-launchtemplateconfig-overrides
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: LaunchTemplateOverrides
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.SpotFleetTypes.LaunchTemplateOverrides>, IReadOnlyList<Union<Humidifier.EC2.SpotFleetTypes.LaunchTemplateOverrides, BaseFunction>>, BaseFunction>? Overrides { get; set; }
        }

        public class LaunchTemplateOverrides : Humidifier.Base.BaseSubResource, IHaveSpotPrice, IHaveWeightedCapacity_Double, IHavePriority_Double, IHaveAvailabilityZoneId, IHaveAvailabilityZone, IHaveSubnetId, IHaveEC2SpotFleetTypesInstanceRequirementsRequestInstanceRequirements, IHaveInstanceType
        {
            /// <summary>
            /// SpotPrice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-launchtemplateoverrides.html#cfn-ec2-spotfleet-launchtemplateoverrides-spotprice
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SpotPrice { get; set; }
            /// <summary>
            /// WeightedCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-launchtemplateoverrides.html#cfn-ec2-spotfleet-launchtemplateoverrides-weightedcapacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? WeightedCapacity { get; set; }
            /// <summary>
            /// Priority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-launchtemplateoverrides.html#cfn-ec2-spotfleet-launchtemplateoverrides-priority
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Priority { get; set; }
            /// <summary>
            /// AvailabilityZoneId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-launchtemplateoverrides.html#cfn-ec2-spotfleet-launchtemplateoverrides-availabilityzoneid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AvailabilityZoneId { get; set; }
            /// <summary>
            /// AvailabilityZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-launchtemplateoverrides.html#cfn-ec2-spotfleet-launchtemplateoverrides-availabilityzone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AvailabilityZone { get; set; }
            /// <summary>
            /// SubnetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-launchtemplateoverrides.html#cfn-ec2-spotfleet-launchtemplateoverrides-subnetid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SubnetId { get; set; }
            /// <summary>
            /// InstanceRequirements
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-launchtemplateoverrides.html#cfn-ec2-spotfleet-launchtemplateoverrides-instancerequirements
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InstanceRequirementsRequest
            /// </summary>
            public Union<Humidifier.EC2.SpotFleetTypes.InstanceRequirementsRequest, BaseFunction>? InstanceRequirements { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-launchtemplateoverrides.html#cfn-ec2-spotfleet-launchtemplateoverrides-instancetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceType { get; set; }
        }

        public class LoadBalancersConfig : Humidifier.Base.BaseSubResource, IHaveEC2SpotFleetTypesClassicLoadBalancersConfigClassicLoadBalancersConfig, IHaveEC2SpotFleetTypesTargetGroupsConfigTargetGroupsConfig
        {
            /// <summary>
            /// ClassicLoadBalancersConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-loadbalancersconfig.html#cfn-ec2-spotfleet-loadbalancersconfig-classicloadbalancersconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ClassicLoadBalancersConfig
            /// </summary>
            public Union<Humidifier.EC2.SpotFleetTypes.ClassicLoadBalancersConfig, BaseFunction>? ClassicLoadBalancersConfig { get; set; }
            /// <summary>
            /// TargetGroupsConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-loadbalancersconfig.html#cfn-ec2-spotfleet-loadbalancersconfig-targetgroupsconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: TargetGroupsConfig
            /// </summary>
            public Union<Humidifier.EC2.SpotFleetTypes.TargetGroupsConfig, BaseFunction>? TargetGroupsConfig { get; set; }
        }

        public class MemoryGiBPerVCpuRequest : Humidifier.Base.BaseSubResource, IHaveMin_Double, IHaveMax_Double
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-memorygibpervcpurequest.html#cfn-ec2-spotfleet-memorygibpervcpurequest-min
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-memorygibpervcpurequest.html#cfn-ec2-spotfleet-memorygibpervcpurequest-max
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Max { get; set; }
        }

        public class MemoryMiBRequest : Humidifier.Base.BaseSubResource, IHaveMin_Integer, IHaveMax_Integer
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-memorymibrequest.html#cfn-ec2-spotfleet-memorymibrequest-min
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-memorymibrequest.html#cfn-ec2-spotfleet-memorymibrequest-max
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Max { get; set; }
        }

        public class NetworkBandwidthGbpsRequest : Humidifier.Base.BaseSubResource, IHaveMin_Double, IHaveMax_Double
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-networkbandwidthgbpsrequest.html#cfn-ec2-spotfleet-networkbandwidthgbpsrequest-min
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-networkbandwidthgbpsrequest.html#cfn-ec2-spotfleet-networkbandwidthgbpsrequest-max
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Max { get; set; }
        }

        public class NetworkInterfaceCountRequest : Humidifier.Base.BaseSubResource, IHaveMin_Integer, IHaveMax_Integer
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-networkinterfacecountrequest.html#cfn-ec2-spotfleet-networkinterfacecountrequest-min
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-networkinterfacecountrequest.html#cfn-ec2-spotfleet-networkinterfacecountrequest-max
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Max { get; set; }
        }

        public class PerformanceFactorReferenceRequest : Humidifier.Base.BaseSubResource, IHaveInstanceFamily
        {
            /// <summary>
            /// InstanceFamily
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-performancefactorreferencerequest.html#cfn-ec2-spotfleet-performancefactorreferencerequest-instancefamily
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceFamily { get; set; }
        }

        public class PrivateIpAddressSpecification : Humidifier.Base.BaseSubResource, IHavePrivateIpAddress, IHavePrimary_Boolean
        {
            /// <summary>
            /// PrivateIpAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-privateipaddressspecification.html#cfn-ec2-spotfleet-privateipaddressspecification-privateipaddress
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrivateIpAddress { get; set; }
            /// <summary>
            /// Primary
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-privateipaddressspecification.html#cfn-ec2-spotfleet-privateipaddressspecification-primary
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Primary { get; set; }
        }

        public class SpotCapacityRebalance : Humidifier.Base.BaseSubResource, IHaveTerminationDelay_Integer, IHaveReplacementStrategy
        {
            /// <summary>
            /// TerminationDelay
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotcapacityrebalance.html#cfn-ec2-spotfleet-spotcapacityrebalance-terminationdelay
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TerminationDelay { get; set; }
            /// <summary>
            /// ReplacementStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotcapacityrebalance.html#cfn-ec2-spotfleet-spotcapacityrebalance-replacementstrategy
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ReplacementStrategy { get; set; }
        }

        public class SpotFleetLaunchSpecification : Humidifier.Base.BaseSubResource, IHaveListOfEC2SpotFleetTypesGroupIdentifierSecurityGroups, IHaveListOfEC2SpotFleetTypesSpotFleetTagSpecificationTagSpecifications, IHaveUserData, IHaveListOfEC2SpotFleetTypesBlockDeviceMappingBlockDeviceMappings, IHaveEC2SpotFleetTypesIamInstanceProfileSpecificationIamInstanceProfile, IHaveKernelId, IHaveSubnetId, IHaveEbsOptimized_Boolean, IHaveKeyName, IHaveRamdiskId, IHaveSpotPrice, IHaveWeightedCapacity_Double, IHaveEC2SpotFleetTypesSpotPlacementPlacement, IHaveListOfEC2SpotFleetTypesInstanceNetworkInterfaceSpecificationNetworkInterfaces, IHaveImageId, IHaveEC2SpotFleetTypesInstanceRequirementsRequestInstanceRequirements, IHaveInstanceType, IHaveEC2SpotFleetTypesSpotFleetMonitoringMonitoring
        {
            /// <summary>
            /// SecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetlaunchspecification.html#cfn-ec2-spotfleet-spotfleetlaunchspecification-securitygroups
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: GroupIdentifier
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.SpotFleetTypes.GroupIdentifier>, IReadOnlyList<Union<Humidifier.EC2.SpotFleetTypes.GroupIdentifier, BaseFunction>>, BaseFunction>? SecurityGroups { get; set; }
            /// <summary>
            /// TagSpecifications
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetlaunchspecification.html#cfn-ec2-spotfleet-spotfleetlaunchspecification-tagspecifications
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: SpotFleetTagSpecification
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.SpotFleetTypes.SpotFleetTagSpecification>, IReadOnlyList<Union<Humidifier.EC2.SpotFleetTypes.SpotFleetTagSpecification, BaseFunction>>, BaseFunction>? TagSpecifications { get; set; }
            /// <summary>
            /// UserData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetlaunchspecification.html#cfn-ec2-spotfleet-spotfleetlaunchspecification-userdata
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserData { get; set; }
            /// <summary>
            /// BlockDeviceMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetlaunchspecification.html#cfn-ec2-spotfleet-spotfleetlaunchspecification-blockdevicemappings
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: BlockDeviceMapping
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.SpotFleetTypes.BlockDeviceMapping>, IReadOnlyList<Union<Humidifier.EC2.SpotFleetTypes.BlockDeviceMapping, BaseFunction>>, BaseFunction>? BlockDeviceMappings { get; set; }
            /// <summary>
            /// IamInstanceProfile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetlaunchspecification.html#cfn-ec2-spotfleet-spotfleetlaunchspecification-iaminstanceprofile
            /// Required: False
            /// UpdateType: Immutable
            /// Type: IamInstanceProfileSpecification
            /// </summary>
            public Union<Humidifier.EC2.SpotFleetTypes.IamInstanceProfileSpecification, BaseFunction>? IamInstanceProfile { get; set; }
            /// <summary>
            /// KernelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetlaunchspecification.html#cfn-ec2-spotfleet-spotfleetlaunchspecification-kernelid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KernelId { get; set; }
            /// <summary>
            /// SubnetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetlaunchspecification.html#cfn-ec2-spotfleet-spotfleetlaunchspecification-subnetid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SubnetId { get; set; }
            /// <summary>
            /// EbsOptimized
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetlaunchspecification.html#cfn-ec2-spotfleet-spotfleetlaunchspecification-ebsoptimized
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EbsOptimized { get; set; }
            /// <summary>
            /// KeyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetlaunchspecification.html#cfn-ec2-spotfleet-spotfleetlaunchspecification-keyname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KeyName { get; set; }
            /// <summary>
            /// RamdiskId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetlaunchspecification.html#cfn-ec2-spotfleet-spotfleetlaunchspecification-ramdiskid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RamdiskId { get; set; }
            /// <summary>
            /// SpotPrice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetlaunchspecification.html#cfn-ec2-spotfleet-spotfleetlaunchspecification-spotprice
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SpotPrice { get; set; }
            /// <summary>
            /// WeightedCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetlaunchspecification.html#cfn-ec2-spotfleet-spotfleetlaunchspecification-weightedcapacity
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? WeightedCapacity { get; set; }
            /// <summary>
            /// Placement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetlaunchspecification.html#cfn-ec2-spotfleet-spotfleetlaunchspecification-placement
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SpotPlacement
            /// </summary>
            public Union<Humidifier.EC2.SpotFleetTypes.SpotPlacement, BaseFunction>? Placement { get; set; }
            /// <summary>
            /// NetworkInterfaces
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetlaunchspecification.html#cfn-ec2-spotfleet-spotfleetlaunchspecification-networkinterfaces
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: InstanceNetworkInterfaceSpecification
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.SpotFleetTypes.InstanceNetworkInterfaceSpecification>, IReadOnlyList<Union<Humidifier.EC2.SpotFleetTypes.InstanceNetworkInterfaceSpecification, BaseFunction>>, BaseFunction>? NetworkInterfaces { get; set; }
            /// <summary>
            /// ImageId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetlaunchspecification.html#cfn-ec2-spotfleet-spotfleetlaunchspecification-imageid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImageId { get; set; }
            /// <summary>
            /// InstanceRequirements
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetlaunchspecification.html#cfn-ec2-spotfleet-spotfleetlaunchspecification-instancerequirements
            /// Required: False
            /// UpdateType: Immutable
            /// Type: InstanceRequirementsRequest
            /// </summary>
            public Union<Humidifier.EC2.SpotFleetTypes.InstanceRequirementsRequest, BaseFunction>? InstanceRequirements { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetlaunchspecification.html#cfn-ec2-spotfleet-spotfleetlaunchspecification-instancetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceType { get; set; }
            /// <summary>
            /// Monitoring
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetlaunchspecification.html#cfn-ec2-spotfleet-spotfleetlaunchspecification-monitoring
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SpotFleetMonitoring
            /// </summary>
            public Union<Humidifier.EC2.SpotFleetTypes.SpotFleetMonitoring, BaseFunction>? Monitoring { get; set; }
        }

        public class SpotFleetMonitoring : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetmonitoring.html#cfn-ec2-spotfleet-spotfleetmonitoring-enabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class SpotFleetRequestConfigData : Humidifier.Base.BaseSubResource, IHaveContext, IHaveSpotMaxTotalPrice, IHaveExcessCapacityTerminationPolicy, IHaveListOfEC2SpotFleetTypesSpotFleetTagSpecificationTagSpecifications, IHaveInstancePoolsToUseCount_Integer, IHaveListOfEC2SpotFleetTypesLaunchTemplateConfigLaunchTemplateConfigs, IHaveTargetCapacityUnitType, IHaveIamFleetRole, IHaveEC2SpotFleetTypesSpotMaintenanceStrategiesSpotMaintenanceStrategies, IHaveTerminateInstancesWithExpiration_Boolean, IHaveValidUntil, IHaveOnDemandMaxTotalPrice, IHaveOnDemandAllocationStrategy, IHaveSpotPrice, IHaveAllocationStrategy, IHaveOnDemandTargetCapacity_Integer, IHaveType, IHaveListOfEC2SpotFleetTypesSpotFleetLaunchSpecificationLaunchSpecifications, IHaveInstanceInterruptionBehavior, IHaveEC2SpotFleetTypesLoadBalancersConfigLoadBalancersConfig, IHaveValidFrom, IHaveReplaceUnhealthyInstances_Boolean, IHaveTargetCapacity_Integer
        {
            /// <summary>
            /// Context
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata.html#cfn-ec2-spotfleet-spotfleetrequestconfigdata-context
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Context { get; set; }
            /// <summary>
            /// SpotMaxTotalPrice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata.html#cfn-ec2-spotfleet-spotfleetrequestconfigdata-spotmaxtotalprice
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SpotMaxTotalPrice { get; set; }
            /// <summary>
            /// ExcessCapacityTerminationPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata.html#cfn-ec2-spotfleet-spotfleetrequestconfigdata-excesscapacityterminationpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExcessCapacityTerminationPolicy { get; set; }
            /// <summary>
            /// TagSpecifications
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata.html#cfn-ec2-spotfleet-spotfleetrequestconfigdata-tagspecifications
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: SpotFleetTagSpecification
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.SpotFleetTypes.SpotFleetTagSpecification>, IReadOnlyList<Union<Humidifier.EC2.SpotFleetTypes.SpotFleetTagSpecification, BaseFunction>>, BaseFunction>? TagSpecifications { get; set; }
            /// <summary>
            /// InstancePoolsToUseCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata.html#cfn-ec2-spotfleet-spotfleetrequestconfigdata-instancepoolstousecount
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? InstancePoolsToUseCount { get; set; }
            /// <summary>
            /// LaunchTemplateConfigs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata.html#cfn-ec2-spotfleet-spotfleetrequestconfigdata-launchtemplateconfigs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: LaunchTemplateConfig
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.SpotFleetTypes.LaunchTemplateConfig>, IReadOnlyList<Union<Humidifier.EC2.SpotFleetTypes.LaunchTemplateConfig, BaseFunction>>, BaseFunction>? LaunchTemplateConfigs { get; set; }
            /// <summary>
            /// TargetCapacityUnitType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata.html#cfn-ec2-spotfleet-spotfleetrequestconfigdata-targetcapacityunittype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetCapacityUnitType { get; set; }
            /// <summary>
            /// IamFleetRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata.html#cfn-ec2-spotfleet-spotfleetrequestconfigdata-iamfleetrole
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IamFleetRole { get; set; }
            /// <summary>
            /// SpotMaintenanceStrategies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata.html#cfn-ec2-spotfleet-spotfleetrequestconfigdata-spotmaintenancestrategies
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SpotMaintenanceStrategies
            /// </summary>
            public Union<Humidifier.EC2.SpotFleetTypes.SpotMaintenanceStrategies, BaseFunction>? SpotMaintenanceStrategies { get; set; }
            /// <summary>
            /// TerminateInstancesWithExpiration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata.html#cfn-ec2-spotfleet-spotfleetrequestconfigdata-terminateinstanceswithexpiration
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? TerminateInstancesWithExpiration { get; set; }
            /// <summary>
            /// ValidUntil
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata.html#cfn-ec2-spotfleet-spotfleetrequestconfigdata-validuntil
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ValidUntil { get; set; }
            /// <summary>
            /// OnDemandMaxTotalPrice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata.html#cfn-ec2-spotfleet-spotfleetrequestconfigdata-ondemandmaxtotalprice
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OnDemandMaxTotalPrice { get; set; }
            /// <summary>
            /// OnDemandAllocationStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata.html#cfn-ec2-spotfleet-spotfleetrequestconfigdata-ondemandallocationstrategy
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OnDemandAllocationStrategy { get; set; }
            /// <summary>
            /// SpotPrice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata.html#cfn-ec2-spotfleet-spotfleetrequestconfigdata-spotprice
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SpotPrice { get; set; }
            /// <summary>
            /// AllocationStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata.html#cfn-ec2-spotfleet-spotfleetrequestconfigdata-allocationstrategy
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AllocationStrategy { get; set; }
            /// <summary>
            /// OnDemandTargetCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata.html#cfn-ec2-spotfleet-spotfleetrequestconfigdata-ondemandtargetcapacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? OnDemandTargetCapacity { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata.html#cfn-ec2-spotfleet-spotfleetrequestconfigdata-type
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// LaunchSpecifications
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata.html#cfn-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: SpotFleetLaunchSpecification
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.SpotFleetTypes.SpotFleetLaunchSpecification>, IReadOnlyList<Union<Humidifier.EC2.SpotFleetTypes.SpotFleetLaunchSpecification, BaseFunction>>, BaseFunction>? LaunchSpecifications { get; set; }
            /// <summary>
            /// InstanceInterruptionBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata.html#cfn-ec2-spotfleet-spotfleetrequestconfigdata-instanceinterruptionbehavior
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceInterruptionBehavior { get; set; }
            /// <summary>
            /// LoadBalancersConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata.html#cfn-ec2-spotfleet-spotfleetrequestconfigdata-loadbalancersconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: LoadBalancersConfig
            /// </summary>
            public Union<Humidifier.EC2.SpotFleetTypes.LoadBalancersConfig, BaseFunction>? LoadBalancersConfig { get; set; }
            /// <summary>
            /// ValidFrom
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata.html#cfn-ec2-spotfleet-spotfleetrequestconfigdata-validfrom
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ValidFrom { get; set; }
            /// <summary>
            /// ReplaceUnhealthyInstances
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata.html#cfn-ec2-spotfleet-spotfleetrequestconfigdata-replaceunhealthyinstances
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ReplaceUnhealthyInstances { get; set; }
            /// <summary>
            /// TargetCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata.html#cfn-ec2-spotfleet-spotfleetrequestconfigdata-targetcapacity
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TargetCapacity { get; set; }
        }

        public class SpotFleetTagSpecification : Humidifier.Base.BaseSubResource, IHaveTags, IHaveResourceType
        {
            /// <summary>
            /// ResourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleettagspecification.html#cfn-ec2-spotfleet-spotfleettagspecification-resourcetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceType { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleettagspecification.html#cfn-ec2-spotfleet-spotfleettagspecification-tags
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        }

        public class SpotMaintenanceStrategies : Humidifier.Base.BaseSubResource, IHaveEC2SpotFleetTypesSpotCapacityRebalanceCapacityRebalance
        {
            /// <summary>
            /// CapacityRebalance
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotmaintenancestrategies.html#cfn-ec2-spotfleet-spotmaintenancestrategies-capacityrebalance
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SpotCapacityRebalance
            /// </summary>
            public Union<Humidifier.EC2.SpotFleetTypes.SpotCapacityRebalance, BaseFunction>? CapacityRebalance { get; set; }
        }

        public class SpotPlacement : Humidifier.Base.BaseSubResource, IHaveGroupName, IHaveTenancy, IHaveAvailabilityZoneId, IHaveAvailabilityZone
        {
            /// <summary>
            /// GroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotplacement.html#cfn-ec2-spotfleet-spotplacement-groupname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GroupName { get; set; }
            /// <summary>
            /// Tenancy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotplacement.html#cfn-ec2-spotfleet-spotplacement-tenancy
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Tenancy { get; set; }
            /// <summary>
            /// AvailabilityZoneId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotplacement.html#cfn-ec2-spotfleet-spotplacement-availabilityzoneid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AvailabilityZoneId { get; set; }
            /// <summary>
            /// AvailabilityZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotplacement.html#cfn-ec2-spotfleet-spotplacement-availabilityzone
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AvailabilityZone { get; set; }
        }

        public class TargetGroup : Humidifier.Base.BaseSubResource, IHaveArn
        {
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-targetgroup.html#cfn-ec2-spotfleet-targetgroup-arn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
        }

        public class TargetGroupsConfig : Humidifier.Base.BaseSubResource, IHaveListOfEC2SpotFleetTypesTargetGroupTargetGroups
        {
            /// <summary>
            /// TargetGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-targetgroupsconfig.html#cfn-ec2-spotfleet-targetgroupsconfig-targetgroups
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: TargetGroup
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.SpotFleetTypes.TargetGroup>, IReadOnlyList<Union<Humidifier.EC2.SpotFleetTypes.TargetGroup, BaseFunction>>, BaseFunction>? TargetGroups { get; set; }
        }

        public class TotalLocalStorageGBRequest : Humidifier.Base.BaseSubResource, IHaveMin_Double, IHaveMax_Double
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-totallocalstoragegbrequest.html#cfn-ec2-spotfleet-totallocalstoragegbrequest-min
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-totallocalstoragegbrequest.html#cfn-ec2-spotfleet-totallocalstoragegbrequest-max
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Max { get; set; }
        }

        public class VCpuCountRangeRequest : Humidifier.Base.BaseSubResource, IHaveMin_Integer, IHaveMax_Integer
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-vcpucountrangerequest.html#cfn-ec2-spotfleet-vcpucountrangerequest-min
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-vcpucountrangerequest.html#cfn-ec2-spotfleet-vcpucountrangerequest-max
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Max { get; set; }
        }
    }
}