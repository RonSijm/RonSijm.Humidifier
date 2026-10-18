namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using InstanceTypes;

    public class Instance : Humidifier.Base.BaseResource, IHaveTags, IHaveTenancy, IHaveStringListOfSecurityGroups, IHavePrivateIpAddress, IHaveUserData, IHaveListOfEC2InstanceTypesBlockDeviceMappingBlockDeviceMappings, IHaveIamInstanceProfile, IHaveListOfEC2InstanceTypesInstanceIpv6AddressIpv6Addresses, IHaveKernelId, IHaveSubnetId, IHaveEbsOptimized_Boolean, IHavePropagateTagsToVolumeOnCreation_Boolean, IHaveListOfEC2InstanceTypesElasticGpuSpecificationElasticGpuSpecifications, IHaveListOfEC2InstanceTypesElasticInferenceAcceleratorElasticInferenceAccelerators, IHaveListOfEC2InstanceTypesVolumeVolumes, IHaveIpv6AddressCount_Integer, IHaveEC2InstanceTypesLaunchTemplateSpecificationLaunchTemplate, IHaveEC2InstanceTypesEnclaveOptionsEnclaveOptions, IHaveListOfEC2InstanceTypesNetworkInterfaceNetworkInterfaces, IHaveImageId, IHaveInstanceType, IHaveMonitoring_Boolean, IHaveAdditionalInfo, IHaveEC2InstanceTypesHibernationOptionsHibernationOptions, IHaveListOfEC2InstanceTypesLicenseSpecificationLicenseSpecifications, IHaveEC2InstanceTypesMetadataOptionsMetadataOptions, IHaveInstanceInitiatedShutdownBehavior, IHaveEC2InstanceTypesCpuOptionsCpuOptions, IHaveAvailabilityZone, IHaveEC2InstanceTypesPrivateDnsNameOptionsPrivateDnsNameOptions, IHaveHostId, IHaveHostResourceGroupArn, IHaveStringListOfSecurityGroupIds, IHaveDisableApiTermination_Boolean, IHaveKeyName, IHaveRamdiskId, IHaveSourceDestCheck_Boolean, IHavePlacementGroupName, IHaveListOfEC2InstanceTypesSsmAssociationSsmAssociations, IHaveAffinity, IHaveEC2InstanceTypesCreditSpecificationCreditSpecification
    {
        public class Attributes
        {
            public static string PrivateDnsName =  "PrivateDnsName" ;
            public static string VpcId =  "VpcId" ;
            public static string PrivateIp =  "PrivateIp" ;
            public static string InstanceId =  "InstanceId" ;
            public static string PublicIp =  "PublicIp" ;
            public static string State =  "State" ;
            public static string AvailabilityZone =  "AvailabilityZone" ;
            public static string PublicDnsName =  "PublicDnsName" ;
        }

        public override string AWSTypeName { get => AWS.EC2.Instance; }
        /// <summary>
        /// Tenancy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instance.html#cfn-ec2-instance-tenancy
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Tenancy { get; set; }
        /// <summary>
        /// SecurityGroups
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instance.html#cfn-ec2-instance-securitygroups
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroups { get; set; }
        /// <summary>
        /// PrivateIpAddress
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instance.html#cfn-ec2-instance-privateipaddress
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PrivateIpAddress { get; set; }
        /// <summary>
        /// UserData
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instance.html#cfn-ec2-instance-userdata
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? UserData { get; set; }
        /// <summary>
        /// BlockDeviceMappings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instance.html#cfn-ec2-instance-blockdevicemappings
        /// Required: False
        /// UpdateType: Conditional
        /// Type: List
        /// ItemType: BlockDeviceMapping
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EC2.InstanceTypes.BlockDeviceMapping>, IReadOnlyList<Union<Humidifier.EC2.InstanceTypes.BlockDeviceMapping, BaseFunction>>, BaseFunction>? BlockDeviceMappings { get; set; }
        /// <summary>
        /// IamInstanceProfile
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instance.html#cfn-ec2-instance-iaminstanceprofile
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? IamInstanceProfile { get; set; }
        /// <summary>
        /// Ipv6Addresses
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instance.html#cfn-ec2-instance-ipv6addresses
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: InstanceIpv6Address
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EC2.InstanceTypes.InstanceIpv6Address>, IReadOnlyList<Union<Humidifier.EC2.InstanceTypes.InstanceIpv6Address, BaseFunction>>, BaseFunction>? Ipv6Addresses { get; set; }
        /// <summary>
        /// KernelId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instance.html#cfn-ec2-instance-kernelid
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KernelId { get; set; }
        /// <summary>
        /// SubnetId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instance.html#cfn-ec2-instance-subnetid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SubnetId { get; set; }
        /// <summary>
        /// EbsOptimized
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instance.html#cfn-ec2-instance-ebsoptimized
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? EbsOptimized { get; set; }
        /// <summary>
        /// PropagateTagsToVolumeOnCreation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instance.html#cfn-ec2-instance-propagatetagstovolumeoncreation
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? PropagateTagsToVolumeOnCreation { get; set; }
        /// <summary>
        /// ElasticGpuSpecifications
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instance.html#cfn-ec2-instance-elasticgpuspecifications
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: ElasticGpuSpecification
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EC2.InstanceTypes.ElasticGpuSpecification>, IReadOnlyList<Union<Humidifier.EC2.InstanceTypes.ElasticGpuSpecification, BaseFunction>>, BaseFunction>? ElasticGpuSpecifications { get; set; }
        /// <summary>
        /// ElasticInferenceAccelerators
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instance.html#cfn-ec2-instance-elasticinferenceaccelerators
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: ElasticInferenceAccelerator
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EC2.InstanceTypes.ElasticInferenceAccelerator>, IReadOnlyList<Union<Humidifier.EC2.InstanceTypes.ElasticInferenceAccelerator, BaseFunction>>, BaseFunction>? ElasticInferenceAccelerators { get; set; }
        /// <summary>
        /// Volumes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instance.html#cfn-ec2-instance-volumes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Volume
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EC2.InstanceTypes.Volume>, IReadOnlyList<Union<Humidifier.EC2.InstanceTypes.Volume, BaseFunction>>, BaseFunction>? Volumes { get; set; }
        /// <summary>
        /// Ipv6AddressCount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instance.html#cfn-ec2-instance-ipv6addresscount
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? Ipv6AddressCount { get; set; }
        /// <summary>
        /// LaunchTemplate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instance.html#cfn-ec2-instance-launchtemplate
        /// Required: False
        /// UpdateType: Immutable
        /// Type: LaunchTemplateSpecification
        /// </summary>
        public Union<Humidifier.EC2.InstanceTypes.LaunchTemplateSpecification, BaseFunction>? LaunchTemplate { get; set; }
        /// <summary>
        /// EnclaveOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instance.html#cfn-ec2-instance-enclaveoptions
        /// Required: False
        /// UpdateType: Immutable
        /// Type: EnclaveOptions
        /// </summary>
        public Union<Humidifier.EC2.InstanceTypes.EnclaveOptions, BaseFunction>? EnclaveOptions { get; set; }
        /// <summary>
        /// NetworkInterfaces
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instance.html#cfn-ec2-instance-networkinterfaces
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: NetworkInterface
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EC2.InstanceTypes.NetworkInterface>, IReadOnlyList<Union<Humidifier.EC2.InstanceTypes.NetworkInterface, BaseFunction>>, BaseFunction>? NetworkInterfaces { get; set; }
        /// <summary>
        /// ImageId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instance.html#cfn-ec2-instance-imageid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ImageId { get; set; }
        /// <summary>
        /// InstanceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instance.html#cfn-ec2-instance-instancetype
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? InstanceType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instance.html#cfn-ec2-instance-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// Monitoring
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instance.html#cfn-ec2-instance-monitoring
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? Monitoring { get; set; }
        /// <summary>
        /// AdditionalInfo
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instance.html#cfn-ec2-instance-additionalinfo
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AdditionalInfo { get; set; }
        /// <summary>
        /// HibernationOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instance.html#cfn-ec2-instance-hibernationoptions
        /// Required: False
        /// UpdateType: Immutable
        /// Type: HibernationOptions
        /// </summary>
        public Union<Humidifier.EC2.InstanceTypes.HibernationOptions, BaseFunction>? HibernationOptions { get; set; }
        /// <summary>
        /// LicenseSpecifications
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instance.html#cfn-ec2-instance-licensespecifications
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: LicenseSpecification
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EC2.InstanceTypes.LicenseSpecification>, IReadOnlyList<Union<Humidifier.EC2.InstanceTypes.LicenseSpecification, BaseFunction>>, BaseFunction>? LicenseSpecifications { get; set; }
        /// <summary>
        /// MetadataOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instance.html#cfn-ec2-instance-metadataoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MetadataOptions
        /// </summary>
        public Union<Humidifier.EC2.InstanceTypes.MetadataOptions, BaseFunction>? MetadataOptions { get; set; }
        /// <summary>
        /// InstanceInitiatedShutdownBehavior
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instance.html#cfn-ec2-instance-instanceinitiatedshutdownbehavior
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? InstanceInitiatedShutdownBehavior { get; set; }
        /// <summary>
        /// CpuOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instance.html#cfn-ec2-instance-cpuoptions
        /// Required: False
        /// UpdateType: Immutable
        /// Type: CpuOptions
        /// </summary>
        public Union<Humidifier.EC2.InstanceTypes.CpuOptions, BaseFunction>? CpuOptions { get; set; }
        /// <summary>
        /// AvailabilityZone
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instance.html#cfn-ec2-instance-availabilityzone
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AvailabilityZone { get; set; }
        /// <summary>
        /// PrivateDnsNameOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instance.html#cfn-ec2-instance-privatednsnameoptions
        /// Required: False
        /// UpdateType: Conditional
        /// Type: PrivateDnsNameOptions
        /// </summary>
        public Union<Humidifier.EC2.InstanceTypes.PrivateDnsNameOptions, BaseFunction>? PrivateDnsNameOptions { get; set; }
        /// <summary>
        /// HostId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instance.html#cfn-ec2-instance-hostid
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? HostId { get; set; }
        /// <summary>
        /// HostResourceGroupArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instance.html#cfn-ec2-instance-hostresourcegrouparn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? HostResourceGroupArn { get; set; }
        /// <summary>
        /// SecurityGroupIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instance.html#cfn-ec2-instance-securitygroupids
        /// Required: False
        /// UpdateType: Conditional
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        /// <summary>
        /// DisableApiTermination
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instance.html#cfn-ec2-instance-disableapitermination
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? DisableApiTermination { get; set; }
        /// <summary>
        /// KeyName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instance.html#cfn-ec2-instance-keyname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KeyName { get; set; }
        /// <summary>
        /// RamdiskId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instance.html#cfn-ec2-instance-ramdiskid
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RamdiskId { get; set; }
        /// <summary>
        /// SourceDestCheck
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instance.html#cfn-ec2-instance-sourcedestcheck
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? SourceDestCheck { get; set; }
        /// <summary>
        /// PlacementGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instance.html#cfn-ec2-instance-placementgroupname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PlacementGroupName { get; set; }
        /// <summary>
        /// SsmAssociations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instance.html#cfn-ec2-instance-ssmassociations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: SsmAssociation
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EC2.InstanceTypes.SsmAssociation>, IReadOnlyList<Union<Humidifier.EC2.InstanceTypes.SsmAssociation, BaseFunction>>, BaseFunction>? SsmAssociations { get; set; }
        /// <summary>
        /// Affinity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instance.html#cfn-ec2-instance-affinity
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Affinity { get; set; }
        /// <summary>
        /// CreditSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instance.html#cfn-ec2-instance-creditspecification
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CreditSpecification
        /// </summary>
        public Union<Humidifier.EC2.InstanceTypes.CreditSpecification, BaseFunction>? CreditSpecification { get; set; }
    }

    namespace InstanceTypes
    {
        public class AssociationParameter : Humidifier.Base.BaseSubResource, IHaveStringListOfValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-associationparameter.html#cfn-ec2-instance-associationparameter-value
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-associationparameter.html#cfn-ec2-instance-associationparameter-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class BlockDeviceMapping : Humidifier.Base.BaseSubResource, IHaveEC2InstanceTypesEbsEbs, IHaveNoDevice_Json, IHaveVirtualName, IHaveDeviceName
        {
            /// <summary>
            /// Ebs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-blockdevicemapping.html#cfn-ec2-instance-blockdevicemapping-ebs
            /// Required: False
            /// UpdateType: Conditional
            /// Type: Ebs
            /// </summary>
            public Union<Humidifier.EC2.InstanceTypes.Ebs, BaseFunction>? Ebs { get; set; }
            /// <summary>
            /// NoDevice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-blockdevicemapping.html#cfn-ec2-instance-blockdevicemapping-nodevice
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? NoDevice { get; set; }
            /// <summary>
            /// VirtualName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-blockdevicemapping.html#cfn-ec2-instance-blockdevicemapping-virtualname
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VirtualName { get; set; }
            /// <summary>
            /// DeviceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-blockdevicemapping.html#cfn-ec2-instance-blockdevicemapping-devicename
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeviceName { get; set; }
        }

        public class CpuOptions : Humidifier.Base.BaseSubResource, IHaveThreadsPerCore_Integer, IHaveCoreCount_Integer
        {
            /// <summary>
            /// ThreadsPerCore
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-cpuoptions.html#cfn-ec2-instance-cpuoptions-threadspercore
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ThreadsPerCore { get; set; }
            /// <summary>
            /// CoreCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-cpuoptions.html#cfn-ec2-instance-cpuoptions-corecount
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? CoreCount { get; set; }
        }

        public class CreditSpecification : Humidifier.Base.BaseSubResource, IHaveCPUCredits
        {
            /// <summary>
            /// CPUCredits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-creditspecification.html#cfn-ec2-instance-creditspecification-cpucredits
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CPUCredits { get; set; }
        }

        public class Ebs : Humidifier.Base.BaseSubResource, IHaveSnapshotId, IHaveVolumeType, IHaveKmsKeyId, IHaveEncrypted_Boolean, IHaveIops_Integer, IHaveVolumeSize_Integer, IHaveDeleteOnTermination_Boolean
        {
            /// <summary>
            /// SnapshotId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-ebs.html#cfn-ec2-instance-ebs-snapshotid
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SnapshotId { get; set; }
            /// <summary>
            /// VolumeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-ebs.html#cfn-ec2-instance-ebs-volumetype
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VolumeType { get; set; }
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-ebs.html#cfn-ec2-instance-ebs-kmskeyid
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
            /// <summary>
            /// Encrypted
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-ebs.html#cfn-ec2-instance-ebs-encrypted
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Encrypted { get; set; }
            /// <summary>
            /// Iops
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-ebs.html#cfn-ec2-instance-ebs-iops
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Iops { get; set; }
            /// <summary>
            /// VolumeSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-ebs.html#cfn-ec2-instance-ebs-volumesize
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? VolumeSize { get; set; }
            /// <summary>
            /// DeleteOnTermination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-ebs.html#cfn-ec2-instance-ebs-deleteontermination
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DeleteOnTermination { get; set; }
        }

        public class ElasticGpuSpecification : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-elasticgpuspecification.html#cfn-ec2-instance-elasticgpuspecification-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
        }

        public class ElasticInferenceAccelerator : Humidifier.Base.BaseSubResource, IHaveType, IHaveCount_Integer
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-elasticinferenceaccelerator.html#cfn-ec2-instance-elasticinferenceaccelerator-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Count
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-elasticinferenceaccelerator.html#cfn-ec2-instance-elasticinferenceaccelerator-count
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Count { get; set; }
        }

        public class EnaSrdSpecification : Humidifier.Base.BaseSubResource, IHaveEnaSrdEnabled_Boolean, IHaveEC2InstanceTypesEnaSrdUdpSpecificationEnaSrdUdpSpecification
        {
            /// <summary>
            /// EnaSrdEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-enasrdspecification.html#cfn-ec2-instance-enasrdspecification-enasrdenabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnaSrdEnabled { get; set; }
            /// <summary>
            /// EnaSrdUdpSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-enasrdspecification.html#cfn-ec2-instance-enasrdspecification-enasrdudpspecification
            /// Required: False
            /// UpdateType: Immutable
            /// Type: EnaSrdUdpSpecification
            /// </summary>
            public Union<Humidifier.EC2.InstanceTypes.EnaSrdUdpSpecification, BaseFunction>? EnaSrdUdpSpecification { get; set; }
        }

        public class EnaSrdUdpSpecification : Humidifier.Base.BaseSubResource, IHaveEnaSrdUdpEnabled_Boolean
        {
            /// <summary>
            /// EnaSrdUdpEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-enasrdudpspecification.html#cfn-ec2-instance-enasrdudpspecification-enasrdudpenabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnaSrdUdpEnabled { get; set; }
        }

        public class EnclaveOptions : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-enclaveoptions.html#cfn-ec2-instance-enclaveoptions-enabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class HibernationOptions : Humidifier.Base.BaseSubResource, IHaveConfigured_Boolean
        {
            /// <summary>
            /// Configured
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-hibernationoptions.html#cfn-ec2-instance-hibernationoptions-configured
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Configured { get; set; }
        }

        public class InstanceIpv6Address : Humidifier.Base.BaseSubResource, IHaveIpv6Address
        {
            /// <summary>
            /// Ipv6Address
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-instanceipv6address.html#cfn-ec2-instance-instanceipv6address-ipv6address
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Ipv6Address { get; set; }
        }

        public class LaunchTemplateSpecification : Humidifier.Base.BaseSubResource, IHaveLaunchTemplateName, IHaveVersion, IHaveLaunchTemplateId
        {
            /// <summary>
            /// LaunchTemplateName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-launchtemplatespecification.html#cfn-ec2-instance-launchtemplatespecification-launchtemplatename
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LaunchTemplateName { get; set; }
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-launchtemplatespecification.html#cfn-ec2-instance-launchtemplatespecification-version
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Version { get; set; }
            /// <summary>
            /// LaunchTemplateId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-launchtemplatespecification.html#cfn-ec2-instance-launchtemplatespecification-launchtemplateid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LaunchTemplateId { get; set; }
        }

        public class LicenseSpecification : Humidifier.Base.BaseSubResource, IHaveLicenseConfigurationArn
        {
            /// <summary>
            /// LicenseConfigurationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-licensespecification.html#cfn-ec2-instance-licensespecification-licenseconfigurationarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LicenseConfigurationArn { get; set; }
        }

        public class MetadataOptions : Humidifier.Base.BaseSubResource, IHaveHttpPutResponseHopLimit_Integer, IHaveHttpProtocolIpv6, IHaveHttpTokens, IHaveInstanceMetadataTags, IHaveHttpEndpoint
        {
            /// <summary>
            /// HttpPutResponseHopLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-metadataoptions.html#cfn-ec2-instance-metadataoptions-httpputresponsehoplimit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? HttpPutResponseHopLimit { get; set; }
            /// <summary>
            /// HttpProtocolIpv6
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-metadataoptions.html#cfn-ec2-instance-metadataoptions-httpprotocolipv6
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HttpProtocolIpv6 { get; set; }
            /// <summary>
            /// HttpTokens
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-metadataoptions.html#cfn-ec2-instance-metadataoptions-httptokens
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HttpTokens { get; set; }
            /// <summary>
            /// InstanceMetadataTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-metadataoptions.html#cfn-ec2-instance-metadataoptions-instancemetadatatags
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceMetadataTags { get; set; }
            /// <summary>
            /// HttpEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-metadataoptions.html#cfn-ec2-instance-metadataoptions-httpendpoint
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HttpEndpoint { get; set; }
        }

        public class NetworkInterface : Humidifier.Base.BaseSubResource, IHaveDescription, IHavePrivateIpAddress, IHaveListOfEC2InstanceTypesPrivateIpAddressSpecificationPrivateIpAddresses, IHaveSecondaryPrivateIpAddressCount_Integer, IHaveDeviceIndex, IHaveStringListOfGroupSet, IHaveListOfEC2InstanceTypesInstanceIpv6AddressIpv6Addresses, IHaveSubnetId, IHaveAssociatePublicIpAddress_Boolean, IHaveNetworkInterfaceId, IHaveAssociateCarrierIpAddress_Boolean, IHaveEC2InstanceTypesEnaSrdSpecificationEnaSrdSpecification, IHaveIpv6AddressCount_Integer, IHaveDeleteOnTermination_Boolean
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-networkinterface.html#cfn-ec2-instance-networkinterface-description
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// PrivateIpAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-networkinterface.html#cfn-ec2-instance-networkinterface-privateipaddress
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrivateIpAddress { get; set; }
            /// <summary>
            /// PrivateIpAddresses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-networkinterface.html#cfn-ec2-instance-networkinterface-privateipaddresses
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: PrivateIpAddressSpecification
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.InstanceTypes.PrivateIpAddressSpecification>, IReadOnlyList<Union<Humidifier.EC2.InstanceTypes.PrivateIpAddressSpecification, BaseFunction>>, BaseFunction>? PrivateIpAddresses { get; set; }
            /// <summary>
            /// SecondaryPrivateIpAddressCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-networkinterface.html#cfn-ec2-instance-networkinterface-secondaryprivateipaddresscount
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SecondaryPrivateIpAddressCount { get; set; }
            /// <summary>
            /// DeviceIndex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-networkinterface.html#cfn-ec2-instance-networkinterface-deviceindex
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeviceIndex { get; set; }
            /// <summary>
            /// GroupSet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-networkinterface.html#cfn-ec2-instance-networkinterface-groupset
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? GroupSet { get; set; }
            /// <summary>
            /// Ipv6Addresses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-networkinterface.html#cfn-ec2-instance-networkinterface-ipv6addresses
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: InstanceIpv6Address
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.InstanceTypes.InstanceIpv6Address>, IReadOnlyList<Union<Humidifier.EC2.InstanceTypes.InstanceIpv6Address, BaseFunction>>, BaseFunction>? Ipv6Addresses { get; set; }
            /// <summary>
            /// SubnetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-networkinterface.html#cfn-ec2-instance-networkinterface-subnetid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SubnetId { get; set; }
            /// <summary>
            /// AssociatePublicIpAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-networkinterface.html#cfn-ec2-instance-networkinterface-associatepublicipaddress
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AssociatePublicIpAddress { get; set; }
            /// <summary>
            /// NetworkInterfaceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-networkinterface.html#cfn-ec2-instance-networkinterface-networkinterfaceid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NetworkInterfaceId { get; set; }
            /// <summary>
            /// AssociateCarrierIpAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-networkinterface.html#cfn-ec2-instance-networkinterface-associatecarrieripaddress
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AssociateCarrierIpAddress { get; set; }
            /// <summary>
            /// EnaSrdSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-networkinterface.html#cfn-ec2-instance-networkinterface-enasrdspecification
            /// Required: False
            /// UpdateType: Immutable
            /// Type: EnaSrdSpecification
            /// </summary>
            public Union<Humidifier.EC2.InstanceTypes.EnaSrdSpecification, BaseFunction>? EnaSrdSpecification { get; set; }
            /// <summary>
            /// Ipv6AddressCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-networkinterface.html#cfn-ec2-instance-networkinterface-ipv6addresscount
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Ipv6AddressCount { get; set; }
            /// <summary>
            /// DeleteOnTermination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-networkinterface.html#cfn-ec2-instance-networkinterface-deleteontermination
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DeleteOnTermination { get; set; }
        }

        public class PrivateDnsNameOptions : Humidifier.Base.BaseSubResource, IHaveEnableResourceNameDnsARecord_Boolean, IHaveHostnameType, IHaveEnableResourceNameDnsAAAARecord_Boolean
        {
            /// <summary>
            /// EnableResourceNameDnsARecord
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-privatednsnameoptions.html#cfn-ec2-instance-privatednsnameoptions-enableresourcenamednsarecord
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableResourceNameDnsARecord { get; set; }
            /// <summary>
            /// HostnameType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-privatednsnameoptions.html#cfn-ec2-instance-privatednsnameoptions-hostnametype
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HostnameType { get; set; }
            /// <summary>
            /// EnableResourceNameDnsAAAARecord
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-privatednsnameoptions.html#cfn-ec2-instance-privatednsnameoptions-enableresourcenamednsaaaarecord
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableResourceNameDnsAAAARecord { get; set; }
        }

        public class PrivateIpAddressSpecification : Humidifier.Base.BaseSubResource, IHavePrivateIpAddress, IHavePrimary_Boolean
        {
            /// <summary>
            /// PrivateIpAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-privateipaddressspecification.html#cfn-ec2-instance-privateipaddressspecification-privateipaddress
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrivateIpAddress { get; set; }
            /// <summary>
            /// Primary
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-privateipaddressspecification.html#cfn-ec2-instance-privateipaddressspecification-primary
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Primary { get; set; }
        }

        public class SsmAssociation : Humidifier.Base.BaseSubResource, IHaveListOfEC2InstanceTypesAssociationParameterAssociationParameters, IHaveDocumentName
        {
            /// <summary>
            /// AssociationParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-ssmassociation.html#cfn-ec2-instance-ssmassociation-associationparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AssociationParameter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.InstanceTypes.AssociationParameter>, IReadOnlyList<Union<Humidifier.EC2.InstanceTypes.AssociationParameter, BaseFunction>>, BaseFunction>? AssociationParameters { get; set; }
            /// <summary>
            /// DocumentName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-ssmassociation.html#cfn-ec2-instance-ssmassociation-documentname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DocumentName { get; set; }
        }

        public class State : Humidifier.Base.BaseSubResource, IHaveCode, IHaveName
        {
            /// <summary>
            /// Code
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-state.html#cfn-ec2-instance-state-code
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Code { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-state.html#cfn-ec2-instance-state-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class Volume : Humidifier.Base.BaseSubResource, IHaveVolumeId, IHaveDevice
        {
            /// <summary>
            /// VolumeId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-volume.html#cfn-ec2-instance-volume-volumeid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VolumeId { get; set; }
            /// <summary>
            /// Device
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance-volume.html#cfn-ec2-instance-volume-device
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Device { get; set; }
        }
    }
}