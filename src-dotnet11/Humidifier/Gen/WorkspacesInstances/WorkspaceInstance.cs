namespace Humidifier.WorkspacesInstances
{
    using global::System.Collections.Generic;
    using WorkspaceInstanceTypes;

    public class WorkspaceInstance : Humidifier.Base.BaseResource, IHaveTags, IHaveWorkspacesInstancesWorkspaceInstanceTypesManagedInstanceManagedInstance
    {
        public class Attributes
        {
            public static string WorkspaceInstanceId =  "WorkspaceInstanceId" ;
            public static string EC2ManagedInstance =  "EC2ManagedInstance" ;
            public static string ProvisionState =  "ProvisionState" ;
        }

        public override string AWSTypeName { get => AWS.WorkspacesInstances.WorkspaceInstance; }
        /// <summary>
        /// ManagedInstance
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesinstances-workspaceinstance.html#cfn-workspacesinstances-workspaceinstance-managedinstance
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ManagedInstance
        /// </summary>
        public Union<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.ManagedInstance, BaseFunction>? ManagedInstance { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesinstances-workspaceinstance.html#cfn-workspacesinstances-workspaceinstance-tags
        /// Required: False
        /// UpdateType: Conditional
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace WorkspaceInstanceTypes
    {
        public class BlockDeviceMapping : Humidifier.Base.BaseSubResource, IHaveWorkspacesInstancesWorkspaceInstanceTypesEbsBlockDeviceEbs, IHaveNoDevice, IHaveVirtualName, IHaveDeviceName
        {
            /// <summary>
            /// Ebs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-blockdevicemapping.html#cfn-workspacesinstances-workspaceinstance-blockdevicemapping-ebs
            /// Required: False
            /// UpdateType: Immutable
            /// Type: EbsBlockDevice
            /// </summary>
            public Union<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.EbsBlockDevice, BaseFunction>? Ebs { get; set; }
            /// <summary>
            /// NoDevice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-blockdevicemapping.html#cfn-workspacesinstances-workspaceinstance-blockdevicemapping-nodevice
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NoDevice { get; set; }
            /// <summary>
            /// VirtualName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-blockdevicemapping.html#cfn-workspacesinstances-workspaceinstance-blockdevicemapping-virtualname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VirtualName { get; set; }
            /// <summary>
            /// DeviceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-blockdevicemapping.html#cfn-workspacesinstances-workspaceinstance-blockdevicemapping-devicename
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeviceName { get; set; }
        }

        public class CapacityReservationSpecification : Humidifier.Base.BaseSubResource, IHaveCapacityReservationPreference, IHaveWorkspacesInstancesWorkspaceInstanceTypesCapacityReservationTargetCapacityReservationTarget
        {
            /// <summary>
            /// CapacityReservationPreference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-capacityreservationspecification.html#cfn-workspacesinstances-workspaceinstance-capacityreservationspecification-capacityreservationpreference
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CapacityReservationPreference { get; set; }
            /// <summary>
            /// CapacityReservationTarget
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-capacityreservationspecification.html#cfn-workspacesinstances-workspaceinstance-capacityreservationspecification-capacityreservationtarget
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CapacityReservationTarget
            /// </summary>
            public Union<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.CapacityReservationTarget, BaseFunction>? CapacityReservationTarget { get; set; }
        }

        public class CapacityReservationTarget : Humidifier.Base.BaseSubResource, IHaveCapacityReservationResourceGroupArn, IHaveCapacityReservationId
        {
            /// <summary>
            /// CapacityReservationResourceGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-capacityreservationtarget.html#cfn-workspacesinstances-workspaceinstance-capacityreservationtarget-capacityreservationresourcegrouparn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CapacityReservationResourceGroupArn { get; set; }
            /// <summary>
            /// CapacityReservationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-capacityreservationtarget.html#cfn-workspacesinstances-workspaceinstance-capacityreservationtarget-capacityreservationid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CapacityReservationId { get; set; }
        }

        public class CpuOptionsRequest : Humidifier.Base.BaseSubResource, IHaveThreadsPerCore_Integer, IHaveCoreCount_Integer
        {
            /// <summary>
            /// ThreadsPerCore
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-cpuoptionsrequest.html#cfn-workspacesinstances-workspaceinstance-cpuoptionsrequest-threadspercore
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ThreadsPerCore { get; set; }
            /// <summary>
            /// CoreCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-cpuoptionsrequest.html#cfn-workspacesinstances-workspaceinstance-cpuoptionsrequest-corecount
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? CoreCount { get; set; }
        }

        public class CreditSpecificationRequest : Humidifier.Base.BaseSubResource, IHaveCpuCredits
        {
            /// <summary>
            /// CpuCredits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-creditspecificationrequest.html#cfn-workspacesinstances-workspaceinstance-creditspecificationrequest-cpucredits
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CpuCredits { get; set; }
        }

        public class EC2ManagedInstance : Humidifier.Base.BaseSubResource, IHaveInstanceId
        {
            /// <summary>
            /// InstanceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-ec2managedinstance.html#cfn-workspacesinstances-workspaceinstance-ec2managedinstance-instanceid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceId { get; set; }
        }

        public class EbsBlockDevice : Humidifier.Base.BaseSubResource, IHaveVolumeType, IHaveKmsKeyId, IHaveEncrypted_Boolean, IHaveThroughput_Integer, IHaveIops_Integer, IHaveVolumeSize_Integer
        {
            /// <summary>
            /// VolumeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-ebsblockdevice.html#cfn-workspacesinstances-workspaceinstance-ebsblockdevice-volumetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VolumeType { get; set; }
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-ebsblockdevice.html#cfn-workspacesinstances-workspaceinstance-ebsblockdevice-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
            /// <summary>
            /// Encrypted
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-ebsblockdevice.html#cfn-workspacesinstances-workspaceinstance-ebsblockdevice-encrypted
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Encrypted { get; set; }
            /// <summary>
            /// Throughput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-ebsblockdevice.html#cfn-workspacesinstances-workspaceinstance-ebsblockdevice-throughput
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Throughput { get; set; }
            /// <summary>
            /// Iops
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-ebsblockdevice.html#cfn-workspacesinstances-workspaceinstance-ebsblockdevice-iops
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Iops { get; set; }
            /// <summary>
            /// VolumeSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-ebsblockdevice.html#cfn-workspacesinstances-workspaceinstance-ebsblockdevice-volumesize
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? VolumeSize { get; set; }
        }

        public class EnclaveOptionsRequest : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-enclaveoptionsrequest.html#cfn-workspacesinstances-workspaceinstance-enclaveoptionsrequest-enabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class HibernationOptionsRequest : Humidifier.Base.BaseSubResource, IHaveConfigured_Boolean
        {
            /// <summary>
            /// Configured
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-hibernationoptionsrequest.html#cfn-workspacesinstances-workspaceinstance-hibernationoptionsrequest-configured
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Configured { get; set; }
        }

        public class IamInstanceProfileSpecification : Humidifier.Base.BaseSubResource, IHaveArn, IHaveName
        {
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-iaminstanceprofilespecification.html#cfn-workspacesinstances-workspaceinstance-iaminstanceprofilespecification-arn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-iaminstanceprofilespecification.html#cfn-workspacesinstances-workspaceinstance-iaminstanceprofilespecification-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class InstanceMaintenanceOptionsRequest : Humidifier.Base.BaseSubResource, IHaveAutoRecovery
        {
            /// <summary>
            /// AutoRecovery
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-instancemaintenanceoptionsrequest.html#cfn-workspacesinstances-workspaceinstance-instancemaintenanceoptionsrequest-autorecovery
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AutoRecovery { get; set; }
        }

        public class InstanceMetadataOptionsRequest : Humidifier.Base.BaseSubResource, IHaveHttpPutResponseHopLimit_Integer, IHaveHttpProtocolIpv6, IHaveHttpTokens, IHaveInstanceMetadataTags, IHaveHttpEndpoint
        {
            /// <summary>
            /// HttpPutResponseHopLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-instancemetadataoptionsrequest.html#cfn-workspacesinstances-workspaceinstance-instancemetadataoptionsrequest-httpputresponsehoplimit
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? HttpPutResponseHopLimit { get; set; }
            /// <summary>
            /// HttpProtocolIpv6
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-instancemetadataoptionsrequest.html#cfn-workspacesinstances-workspaceinstance-instancemetadataoptionsrequest-httpprotocolipv6
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HttpProtocolIpv6 { get; set; }
            /// <summary>
            /// HttpTokens
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-instancemetadataoptionsrequest.html#cfn-workspacesinstances-workspaceinstance-instancemetadataoptionsrequest-httptokens
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HttpTokens { get; set; }
            /// <summary>
            /// InstanceMetadataTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-instancemetadataoptionsrequest.html#cfn-workspacesinstances-workspaceinstance-instancemetadataoptionsrequest-instancemetadatatags
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceMetadataTags { get; set; }
            /// <summary>
            /// HttpEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-instancemetadataoptionsrequest.html#cfn-workspacesinstances-workspaceinstance-instancemetadataoptionsrequest-httpendpoint
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HttpEndpoint { get; set; }
        }

        public class InstanceNetworkInterfaceSpecification : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveDeviceIndex_Integer, IHaveStringListOfGroups, IHaveSubnetId
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-instancenetworkinterfacespecification.html#cfn-workspacesinstances-workspaceinstance-instancenetworkinterfacespecification-description
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// DeviceIndex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-instancenetworkinterfacespecification.html#cfn-workspacesinstances-workspaceinstance-instancenetworkinterfacespecification-deviceindex
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DeviceIndex { get; set; }
            /// <summary>
            /// Groups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-instancenetworkinterfacespecification.html#cfn-workspacesinstances-workspaceinstance-instancenetworkinterfacespecification-groups
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Groups { get; set; }
            /// <summary>
            /// SubnetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-instancenetworkinterfacespecification.html#cfn-workspacesinstances-workspaceinstance-instancenetworkinterfacespecification-subnetid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SubnetId { get; set; }
        }

        public class InstanceNetworkPerformanceOptionsRequest : Humidifier.Base.BaseSubResource, IHaveBandwidthWeighting
        {
            /// <summary>
            /// BandwidthWeighting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-instancenetworkperformanceoptionsrequest.html#cfn-workspacesinstances-workspaceinstance-instancenetworkperformanceoptionsrequest-bandwidthweighting
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BandwidthWeighting { get; set; }
        }

        public class LicenseConfigurationRequest : Humidifier.Base.BaseSubResource, IHaveLicenseConfigurationArn
        {
            /// <summary>
            /// LicenseConfigurationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-licenseconfigurationrequest.html#cfn-workspacesinstances-workspaceinstance-licenseconfigurationrequest-licenseconfigurationarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LicenseConfigurationArn { get; set; }
        }

        public class ManagedInstance : Humidifier.Base.BaseSubResource, IHaveWorkspacesInstancesWorkspaceInstanceTypesInstanceNetworkPerformanceOptionsRequestNetworkPerformanceOptions, IHaveListOfWorkspacesInstancesWorkspaceInstanceTypesTagSpecificationTagSpecifications, IHaveUserData, IHaveListOfWorkspacesInstancesWorkspaceInstanceTypesBlockDeviceMappingBlockDeviceMappings, IHaveWorkspacesInstancesWorkspaceInstanceTypesInstanceMaintenanceOptionsRequestMaintenanceOptions, IHaveWorkspacesInstancesWorkspaceInstanceTypesIamInstanceProfileSpecificationIamInstanceProfile, IHaveSubnetId, IHaveEbsOptimized_Boolean, IHaveWorkspacesInstancesWorkspaceInstanceTypesPlacementPlacement, IHaveIpv6AddressCount_Integer, IHaveWorkspacesInstancesWorkspaceInstanceTypesEnclaveOptionsRequestEnclaveOptions, IHaveListOfWorkspacesInstancesWorkspaceInstanceTypesInstanceNetworkInterfaceSpecificationNetworkInterfaces, IHaveImageId, IHaveInstanceType, IHaveWorkspacesInstancesWorkspaceInstanceTypesRunInstancesMonitoringEnabledMonitoring, IHaveWorkspacesInstancesWorkspaceInstanceTypesHibernationOptionsRequestHibernationOptions, IHaveListOfWorkspacesInstancesWorkspaceInstanceTypesLicenseConfigurationRequestLicenseSpecifications, IHaveWorkspacesInstancesWorkspaceInstanceTypesInstanceMetadataOptionsRequestMetadataOptions, IHaveDisableApiStop_Boolean, IHaveWorkspacesInstancesWorkspaceInstanceTypesCpuOptionsRequestCpuOptions, IHaveWorkspacesInstancesWorkspaceInstanceTypesPrivateDnsNameOptionsRequestPrivateDnsNameOptions, IHaveEnablePrimaryIpv6_Boolean, IHaveKeyName, IHaveWorkspacesInstancesWorkspaceInstanceTypesCapacityReservationSpecificationCapacityReservationSpecification, IHaveWorkspacesInstancesWorkspaceInstanceTypesCreditSpecificationRequestCreditSpecification
        {
            /// <summary>
            /// NetworkPerformanceOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-managedinstance.html#cfn-workspacesinstances-workspaceinstance-managedinstance-networkperformanceoptions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: InstanceNetworkPerformanceOptionsRequest
            /// </summary>
            public Union<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.InstanceNetworkPerformanceOptionsRequest, BaseFunction>? NetworkPerformanceOptions { get; set; }
            /// <summary>
            /// TagSpecifications
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-managedinstance.html#cfn-workspacesinstances-workspaceinstance-managedinstance-tagspecifications
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: TagSpecification
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.TagSpecification>, IReadOnlyList<Union<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.TagSpecification, BaseFunction>>, BaseFunction>? TagSpecifications { get; set; }
            /// <summary>
            /// UserData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-managedinstance.html#cfn-workspacesinstances-workspaceinstance-managedinstance-userdata
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserData { get; set; }
            /// <summary>
            /// BlockDeviceMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-managedinstance.html#cfn-workspacesinstances-workspaceinstance-managedinstance-blockdevicemappings
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: BlockDeviceMapping
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.BlockDeviceMapping>, IReadOnlyList<Union<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.BlockDeviceMapping, BaseFunction>>, BaseFunction>? BlockDeviceMappings { get; set; }
            /// <summary>
            /// MaintenanceOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-managedinstance.html#cfn-workspacesinstances-workspaceinstance-managedinstance-maintenanceoptions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: InstanceMaintenanceOptionsRequest
            /// </summary>
            public Union<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.InstanceMaintenanceOptionsRequest, BaseFunction>? MaintenanceOptions { get; set; }
            /// <summary>
            /// IamInstanceProfile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-managedinstance.html#cfn-workspacesinstances-workspaceinstance-managedinstance-iaminstanceprofile
            /// Required: False
            /// UpdateType: Immutable
            /// Type: IamInstanceProfileSpecification
            /// </summary>
            public Union<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.IamInstanceProfileSpecification, BaseFunction>? IamInstanceProfile { get; set; }
            /// <summary>
            /// SubnetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-managedinstance.html#cfn-workspacesinstances-workspaceinstance-managedinstance-subnetid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SubnetId { get; set; }
            /// <summary>
            /// EbsOptimized
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-managedinstance.html#cfn-workspacesinstances-workspaceinstance-managedinstance-ebsoptimized
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EbsOptimized { get; set; }
            /// <summary>
            /// Placement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-managedinstance.html#cfn-workspacesinstances-workspaceinstance-managedinstance-placement
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Placement
            /// </summary>
            public Union<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.Placement, BaseFunction>? Placement { get; set; }
            /// <summary>
            /// Ipv6AddressCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-managedinstance.html#cfn-workspacesinstances-workspaceinstance-managedinstance-ipv6addresscount
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Ipv6AddressCount { get; set; }
            /// <summary>
            /// EnclaveOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-managedinstance.html#cfn-workspacesinstances-workspaceinstance-managedinstance-enclaveoptions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: EnclaveOptionsRequest
            /// </summary>
            public Union<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.EnclaveOptionsRequest, BaseFunction>? EnclaveOptions { get; set; }
            /// <summary>
            /// NetworkInterfaces
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-managedinstance.html#cfn-workspacesinstances-workspaceinstance-managedinstance-networkinterfaces
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: InstanceNetworkInterfaceSpecification
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.InstanceNetworkInterfaceSpecification>, IReadOnlyList<Union<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.InstanceNetworkInterfaceSpecification, BaseFunction>>, BaseFunction>? NetworkInterfaces { get; set; }
            /// <summary>
            /// ImageId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-managedinstance.html#cfn-workspacesinstances-workspaceinstance-managedinstance-imageid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImageId { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-managedinstance.html#cfn-workspacesinstances-workspaceinstance-managedinstance-instancetype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceType { get; set; }
            /// <summary>
            /// Monitoring
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-managedinstance.html#cfn-workspacesinstances-workspaceinstance-managedinstance-monitoring
            /// Required: False
            /// UpdateType: Immutable
            /// Type: RunInstancesMonitoringEnabled
            /// </summary>
            public Union<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.RunInstancesMonitoringEnabled, BaseFunction>? Monitoring { get; set; }
            /// <summary>
            /// HibernationOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-managedinstance.html#cfn-workspacesinstances-workspaceinstance-managedinstance-hibernationoptions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: HibernationOptionsRequest
            /// </summary>
            public Union<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.HibernationOptionsRequest, BaseFunction>? HibernationOptions { get; set; }
            /// <summary>
            /// LicenseSpecifications
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-managedinstance.html#cfn-workspacesinstances-workspaceinstance-managedinstance-licensespecifications
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: LicenseConfigurationRequest
            /// </summary>
            public Union<IReadOnlyList<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.LicenseConfigurationRequest>, IReadOnlyList<Union<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.LicenseConfigurationRequest, BaseFunction>>, BaseFunction>? LicenseSpecifications { get; set; }
            /// <summary>
            /// MetadataOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-managedinstance.html#cfn-workspacesinstances-workspaceinstance-managedinstance-metadataoptions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: InstanceMetadataOptionsRequest
            /// </summary>
            public Union<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.InstanceMetadataOptionsRequest, BaseFunction>? MetadataOptions { get; set; }
            /// <summary>
            /// DisableApiStop
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-managedinstance.html#cfn-workspacesinstances-workspaceinstance-managedinstance-disableapistop
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DisableApiStop { get; set; }
            /// <summary>
            /// CpuOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-managedinstance.html#cfn-workspacesinstances-workspaceinstance-managedinstance-cpuoptions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CpuOptionsRequest
            /// </summary>
            public Union<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.CpuOptionsRequest, BaseFunction>? CpuOptions { get; set; }
            /// <summary>
            /// PrivateDnsNameOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-managedinstance.html#cfn-workspacesinstances-workspaceinstance-managedinstance-privatednsnameoptions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: PrivateDnsNameOptionsRequest
            /// </summary>
            public Union<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.PrivateDnsNameOptionsRequest, BaseFunction>? PrivateDnsNameOptions { get; set; }
            /// <summary>
            /// EnablePrimaryIpv6
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-managedinstance.html#cfn-workspacesinstances-workspaceinstance-managedinstance-enableprimaryipv6
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnablePrimaryIpv6 { get; set; }
            /// <summary>
            /// KeyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-managedinstance.html#cfn-workspacesinstances-workspaceinstance-managedinstance-keyname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KeyName { get; set; }
            /// <summary>
            /// CapacityReservationSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-managedinstance.html#cfn-workspacesinstances-workspaceinstance-managedinstance-capacityreservationspecification
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CapacityReservationSpecification
            /// </summary>
            public Union<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.CapacityReservationSpecification, BaseFunction>? CapacityReservationSpecification { get; set; }
            /// <summary>
            /// CreditSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-managedinstance.html#cfn-workspacesinstances-workspaceinstance-managedinstance-creditspecification
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CreditSpecificationRequest
            /// </summary>
            public Union<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.CreditSpecificationRequest, BaseFunction>? CreditSpecification { get; set; }
        }

        public class Placement : Humidifier.Base.BaseSubResource, IHaveGroupName, IHaveTenancy, IHavePartitionNumber_Integer, IHaveAvailabilityZone, IHaveGroupId
        {
            /// <summary>
            /// GroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-placement.html#cfn-workspacesinstances-workspaceinstance-placement-groupname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GroupName { get; set; }
            /// <summary>
            /// Tenancy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-placement.html#cfn-workspacesinstances-workspaceinstance-placement-tenancy
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Tenancy { get; set; }
            /// <summary>
            /// PartitionNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-placement.html#cfn-workspacesinstances-workspaceinstance-placement-partitionnumber
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? PartitionNumber { get; set; }
            /// <summary>
            /// AvailabilityZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-placement.html#cfn-workspacesinstances-workspaceinstance-placement-availabilityzone
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AvailabilityZone { get; set; }
            /// <summary>
            /// GroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-placement.html#cfn-workspacesinstances-workspaceinstance-placement-groupid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GroupId { get; set; }
        }

        public class PrivateDnsNameOptionsRequest : Humidifier.Base.BaseSubResource, IHaveEnableResourceNameDnsARecord_Boolean, IHaveHostnameType, IHaveEnableResourceNameDnsAAAARecord_Boolean
        {
            /// <summary>
            /// EnableResourceNameDnsARecord
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-privatednsnameoptionsrequest.html#cfn-workspacesinstances-workspaceinstance-privatednsnameoptionsrequest-enableresourcenamednsarecord
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableResourceNameDnsARecord { get; set; }
            /// <summary>
            /// HostnameType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-privatednsnameoptionsrequest.html#cfn-workspacesinstances-workspaceinstance-privatednsnameoptionsrequest-hostnametype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HostnameType { get; set; }
            /// <summary>
            /// EnableResourceNameDnsAAAARecord
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-privatednsnameoptionsrequest.html#cfn-workspacesinstances-workspaceinstance-privatednsnameoptionsrequest-enableresourcenamednsaaaarecord
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableResourceNameDnsAAAARecord { get; set; }
        }

        public class RunInstancesMonitoringEnabled : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-runinstancesmonitoringenabled.html#cfn-workspacesinstances-workspaceinstance-runinstancesmonitoringenabled-enabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class TagSpecification : Humidifier.Base.BaseSubResource, IHaveTags, IHaveResourceType
        {
            /// <summary>
            /// ResourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-tagspecification.html#cfn-workspacesinstances-workspaceinstance-tagspecification-resourcetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceType { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesinstances-workspaceinstance-tagspecification.html#cfn-workspacesinstances-workspaceinstance-tagspecification-tags
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        }
    }
}