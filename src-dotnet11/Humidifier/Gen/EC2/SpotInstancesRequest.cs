namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using SpotInstancesRequestTypes;

    public class SpotInstancesRequest : Humidifier.Base.BaseResource, IHaveTags, IHaveSpotPrice, IHaveAvailabilityZoneGroup, IHaveType, IHaveLaunchGroup, IHaveInstanceInterruptionBehavior, IHaveEC2SpotInstancesRequestTypesLaunchSpecificationLaunchSpecification, IHaveValidFrom, IHaveValidUntil
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string LaunchedAvailabilityZoneId =  "LaunchedAvailabilityZoneId" ;
            public static string SpotInstanceRequestId =  "SpotInstanceRequestId" ;
            public static string InstanceId =  "InstanceId" ;
            public static string State =  "State" ;
            public static string CreateTime =  "CreateTime" ;
            public static string LaunchedAvailabilityZone =  "LaunchedAvailabilityZone" ;
            public static string ProductDescription =  "ProductDescription" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.EC2.SpotInstancesRequest; }
        /// <summary>
        /// SpotPrice
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-spotinstancesrequest.html#cfn-ec2-spotinstancesrequest-spotprice
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SpotPrice { get; set; }
        /// <summary>
        /// AvailabilityZoneGroup
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-spotinstancesrequest.html#cfn-ec2-spotinstancesrequest-availabilityzonegroup
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AvailabilityZoneGroup { get; set; }
        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-spotinstancesrequest.html#cfn-ec2-spotinstancesrequest-type
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Type { get; set; }
        /// <summary>
        /// LaunchGroup
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-spotinstancesrequest.html#cfn-ec2-spotinstancesrequest-launchgroup
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LaunchGroup { get; set; }
        /// <summary>
        /// InstanceInterruptionBehavior
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-spotinstancesrequest.html#cfn-ec2-spotinstancesrequest-instanceinterruptionbehavior
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? InstanceInterruptionBehavior { get; set; }
        /// <summary>
        /// LaunchSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-spotinstancesrequest.html#cfn-ec2-spotinstancesrequest-launchspecification
        /// Required: False
        /// UpdateType: Immutable
        /// Type: LaunchSpecification
        /// </summary>
        public Union<Humidifier.EC2.SpotInstancesRequestTypes.LaunchSpecification, BaseFunction>? LaunchSpecification { get; set; }
        /// <summary>
        /// ValidFrom
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-spotinstancesrequest.html#cfn-ec2-spotinstancesrequest-validfrom
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ValidFrom { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-spotinstancesrequest.html#cfn-ec2-spotinstancesrequest-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// ValidUntil
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-spotinstancesrequest.html#cfn-ec2-spotinstancesrequest-validuntil
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ValidUntil { get; set; }
    }

    namespace SpotInstancesRequestTypes
    {
        public class BlockDeviceMapping : Humidifier.Base.BaseSubResource, IHaveEC2SpotInstancesRequestTypesEbsBlockDeviceEbs, IHaveNoDevice, IHaveVirtualName, IHaveDeviceName
        {
            /// <summary>
            /// Ebs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-blockdevicemapping.html#cfn-ec2-spotinstancesrequest-blockdevicemapping-ebs
            /// Required: False
            /// UpdateType: Immutable
            /// Type: EbsBlockDevice
            /// </summary>
            public Union<Humidifier.EC2.SpotInstancesRequestTypes.EbsBlockDevice, BaseFunction>? Ebs { get; set; }
            /// <summary>
            /// NoDevice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-blockdevicemapping.html#cfn-ec2-spotinstancesrequest-blockdevicemapping-nodevice
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NoDevice { get; set; }
            /// <summary>
            /// VirtualName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-blockdevicemapping.html#cfn-ec2-spotinstancesrequest-blockdevicemapping-virtualname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VirtualName { get; set; }
            /// <summary>
            /// DeviceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-blockdevicemapping.html#cfn-ec2-spotinstancesrequest-blockdevicemapping-devicename
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeviceName { get; set; }
        }

        public class EbsBlockDevice : Humidifier.Base.BaseSubResource, IHaveSnapshotId, IHaveVolumeType, IHaveKmsKeyId, IHaveEncrypted_Boolean, IHaveThroughput_Integer, IHaveIops_Integer, IHaveVolumeSize_Integer, IHaveDeleteOnTermination_Boolean
        {
            /// <summary>
            /// SnapshotId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-ebsblockdevice.html#cfn-ec2-spotinstancesrequest-ebsblockdevice-snapshotid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SnapshotId { get; set; }
            /// <summary>
            /// VolumeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-ebsblockdevice.html#cfn-ec2-spotinstancesrequest-ebsblockdevice-volumetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VolumeType { get; set; }
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-ebsblockdevice.html#cfn-ec2-spotinstancesrequest-ebsblockdevice-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
            /// <summary>
            /// Encrypted
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-ebsblockdevice.html#cfn-ec2-spotinstancesrequest-ebsblockdevice-encrypted
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Encrypted { get; set; }
            /// <summary>
            /// Throughput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-ebsblockdevice.html#cfn-ec2-spotinstancesrequest-ebsblockdevice-throughput
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Throughput { get; set; }
            /// <summary>
            /// Iops
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-ebsblockdevice.html#cfn-ec2-spotinstancesrequest-ebsblockdevice-iops
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Iops { get; set; }
            /// <summary>
            /// VolumeSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-ebsblockdevice.html#cfn-ec2-spotinstancesrequest-ebsblockdevice-volumesize
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? VolumeSize { get; set; }
            /// <summary>
            /// DeleteOnTermination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-ebsblockdevice.html#cfn-ec2-spotinstancesrequest-ebsblockdevice-deleteontermination
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DeleteOnTermination { get; set; }
        }

        public class GroupIdentifier : Humidifier.Base.BaseSubResource, IHaveGroupName, IHaveGroupId
        {
            /// <summary>
            /// GroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-groupidentifier.html#cfn-ec2-spotinstancesrequest-groupidentifier-groupname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GroupName { get; set; }
            /// <summary>
            /// GroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-groupidentifier.html#cfn-ec2-spotinstancesrequest-groupidentifier-groupid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GroupId { get; set; }
        }

        public class IamInstanceProfileSpecification : Humidifier.Base.BaseSubResource, IHaveArn, IHaveName
        {
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-iaminstanceprofilespecification.html#cfn-ec2-spotinstancesrequest-iaminstanceprofilespecification-arn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-iaminstanceprofilespecification.html#cfn-ec2-spotinstancesrequest-iaminstanceprofilespecification-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class InstanceIpv6Address : Humidifier.Base.BaseSubResource, IHaveIpv6Address
        {
            /// <summary>
            /// Ipv6Address
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-instanceipv6address.html#cfn-ec2-spotinstancesrequest-instanceipv6address-ipv6address
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Ipv6Address { get; set; }
        }

        public class InstanceNetworkInterfaceSpecification : Humidifier.Base.BaseSubResource, IHaveDescription, IHavePrivateIpAddress, IHaveListOfEC2SpotInstancesRequestTypesPrivateIpAddressSpecificationPrivateIpAddresses, IHaveSecondaryPrivateIpAddressCount_Integer, IHaveDeviceIndex_Integer, IHaveIpv6AddressCount_Integer, IHaveListOfEC2SpotInstancesRequestTypesInstanceIpv6AddressIpv6Addresses, IHaveSubnetId, IHaveAssociatePublicIpAddress_Boolean, IHaveNetworkInterfaceId, IHaveDeleteOnTermination_Boolean
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-instancenetworkinterfacespecification.html#cfn-ec2-spotinstancesrequest-instancenetworkinterfacespecification-description
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// PrivateIpAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-instancenetworkinterfacespecification.html#cfn-ec2-spotinstancesrequest-instancenetworkinterfacespecification-privateipaddress
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrivateIpAddress { get; set; }
            /// <summary>
            /// PrivateIpAddresses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-instancenetworkinterfacespecification.html#cfn-ec2-spotinstancesrequest-instancenetworkinterfacespecification-privateipaddresses
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: PrivateIpAddressSpecification
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.SpotInstancesRequestTypes.PrivateIpAddressSpecification>, IReadOnlyList<Union<Humidifier.EC2.SpotInstancesRequestTypes.PrivateIpAddressSpecification, BaseFunction>>, BaseFunction>? PrivateIpAddresses { get; set; }
            /// <summary>
            /// SecondaryPrivateIpAddressCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-instancenetworkinterfacespecification.html#cfn-ec2-spotinstancesrequest-instancenetworkinterfacespecification-secondaryprivateipaddresscount
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SecondaryPrivateIpAddressCount { get; set; }
            /// <summary>
            /// DeviceIndex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-instancenetworkinterfacespecification.html#cfn-ec2-spotinstancesrequest-instancenetworkinterfacespecification-deviceindex
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DeviceIndex { get; set; }
            /// <summary>
            /// Ipv6AddressCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-instancenetworkinterfacespecification.html#cfn-ec2-spotinstancesrequest-instancenetworkinterfacespecification-ipv6addresscount
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Ipv6AddressCount { get; set; }
            /// <summary>
            /// Ipv6Addresses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-instancenetworkinterfacespecification.html#cfn-ec2-spotinstancesrequest-instancenetworkinterfacespecification-ipv6addresses
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: InstanceIpv6Address
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.SpotInstancesRequestTypes.InstanceIpv6Address>, IReadOnlyList<Union<Humidifier.EC2.SpotInstancesRequestTypes.InstanceIpv6Address, BaseFunction>>, BaseFunction>? Ipv6Addresses { get; set; }
            /// <summary>
            /// SubnetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-instancenetworkinterfacespecification.html#cfn-ec2-spotinstancesrequest-instancenetworkinterfacespecification-subnetid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SubnetId { get; set; }
            /// <summary>
            /// AssociatePublicIpAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-instancenetworkinterfacespecification.html#cfn-ec2-spotinstancesrequest-instancenetworkinterfacespecification-associatepublicipaddress
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AssociatePublicIpAddress { get; set; }
            /// <summary>
            /// NetworkInterfaceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-instancenetworkinterfacespecification.html#cfn-ec2-spotinstancesrequest-instancenetworkinterfacespecification-networkinterfaceid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NetworkInterfaceId { get; set; }
            /// <summary>
            /// DeleteOnTermination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-instancenetworkinterfacespecification.html#cfn-ec2-spotinstancesrequest-instancenetworkinterfacespecification-deleteontermination
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DeleteOnTermination { get; set; }
        }

        public class LaunchSpecification : Humidifier.Base.BaseSubResource, IHaveListOfEC2SpotInstancesRequestTypesGroupIdentifierSecurityGroups, IHaveListOfEC2SpotInstancesRequestTypesBlockDeviceMappingBlockDeviceMappings, IHaveEC2SpotInstancesRequestTypesIamInstanceProfileSpecificationIamInstanceProfile, IHaveKernelId, IHaveSubnetId, IHaveEbsOptimized_Boolean, IHaveKeyName, IHaveRamdiskId, IHaveEC2SpotInstancesRequestTypesSpotPlacementPlacement, IHaveListOfEC2SpotInstancesRequestTypesInstanceNetworkInterfaceSpecificationNetworkInterfaces, IHaveAddressingType, IHaveImageId, IHaveInstanceType, IHaveEC2SpotInstancesRequestTypesMonitoringEnabledMonitoring
        {
            /// <summary>
            /// SecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-launchspecification.html#cfn-ec2-spotinstancesrequest-launchspecification-securitygroups
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: GroupIdentifier
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.SpotInstancesRequestTypes.GroupIdentifier>, IReadOnlyList<Union<Humidifier.EC2.SpotInstancesRequestTypes.GroupIdentifier, BaseFunction>>, BaseFunction>? SecurityGroups { get; set; }
            /// <summary>
            /// BlockDeviceMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-launchspecification.html#cfn-ec2-spotinstancesrequest-launchspecification-blockdevicemappings
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: BlockDeviceMapping
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.SpotInstancesRequestTypes.BlockDeviceMapping>, IReadOnlyList<Union<Humidifier.EC2.SpotInstancesRequestTypes.BlockDeviceMapping, BaseFunction>>, BaseFunction>? BlockDeviceMappings { get; set; }
            /// <summary>
            /// IamInstanceProfile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-launchspecification.html#cfn-ec2-spotinstancesrequest-launchspecification-iaminstanceprofile
            /// Required: False
            /// UpdateType: Immutable
            /// Type: IamInstanceProfileSpecification
            /// </summary>
            public Union<Humidifier.EC2.SpotInstancesRequestTypes.IamInstanceProfileSpecification, BaseFunction>? IamInstanceProfile { get; set; }
            /// <summary>
            /// KernelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-launchspecification.html#cfn-ec2-spotinstancesrequest-launchspecification-kernelid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KernelId { get; set; }
            /// <summary>
            /// SubnetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-launchspecification.html#cfn-ec2-spotinstancesrequest-launchspecification-subnetid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SubnetId { get; set; }
            /// <summary>
            /// EbsOptimized
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-launchspecification.html#cfn-ec2-spotinstancesrequest-launchspecification-ebsoptimized
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EbsOptimized { get; set; }
            /// <summary>
            /// KeyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-launchspecification.html#cfn-ec2-spotinstancesrequest-launchspecification-keyname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KeyName { get; set; }
            /// <summary>
            /// RamdiskId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-launchspecification.html#cfn-ec2-spotinstancesrequest-launchspecification-ramdiskid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RamdiskId { get; set; }
            /// <summary>
            /// Placement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-launchspecification.html#cfn-ec2-spotinstancesrequest-launchspecification-placement
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SpotPlacement
            /// </summary>
            public Union<Humidifier.EC2.SpotInstancesRequestTypes.SpotPlacement, BaseFunction>? Placement { get; set; }
            /// <summary>
            /// NetworkInterfaces
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-launchspecification.html#cfn-ec2-spotinstancesrequest-launchspecification-networkinterfaces
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: InstanceNetworkInterfaceSpecification
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.SpotInstancesRequestTypes.InstanceNetworkInterfaceSpecification>, IReadOnlyList<Union<Humidifier.EC2.SpotInstancesRequestTypes.InstanceNetworkInterfaceSpecification, BaseFunction>>, BaseFunction>? NetworkInterfaces { get; set; }
            /// <summary>
            /// AddressingType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-launchspecification.html#cfn-ec2-spotinstancesrequest-launchspecification-addressingtype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AddressingType { get; set; }
            /// <summary>
            /// ImageId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-launchspecification.html#cfn-ec2-spotinstancesrequest-launchspecification-imageid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImageId { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-launchspecification.html#cfn-ec2-spotinstancesrequest-launchspecification-instancetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceType { get; set; }
            /// <summary>
            /// Monitoring
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-launchspecification.html#cfn-ec2-spotinstancesrequest-launchspecification-monitoring
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MonitoringEnabled
            /// </summary>
            public Union<Humidifier.EC2.SpotInstancesRequestTypes.MonitoringEnabled, BaseFunction>? Monitoring { get; set; }
        }

        public class MonitoringEnabled : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-monitoringenabled.html#cfn-ec2-spotinstancesrequest-monitoringenabled-enabled
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class PrivateIpAddressSpecification : Humidifier.Base.BaseSubResource, IHavePrivateIpAddress, IHavePrimary_Boolean
        {
            /// <summary>
            /// PrivateIpAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-privateipaddressspecification.html#cfn-ec2-spotinstancesrequest-privateipaddressspecification-privateipaddress
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrivateIpAddress { get; set; }
            /// <summary>
            /// Primary
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-privateipaddressspecification.html#cfn-ec2-spotinstancesrequest-privateipaddressspecification-primary
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Primary { get; set; }
        }

        public class SpotInstanceStatus : Humidifier.Base.BaseSubResource, IHaveMessage, IHaveUpdateTime, IHaveCode
        {
            /// <summary>
            /// Message
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-spotinstancestatus.html#cfn-ec2-spotinstancesrequest-spotinstancestatus-message
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Message { get; set; }
            /// <summary>
            /// UpdateTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-spotinstancestatus.html#cfn-ec2-spotinstancesrequest-spotinstancestatus-updatetime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateTime { get; set; }
            /// <summary>
            /// Code
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-spotinstancestatus.html#cfn-ec2-spotinstancesrequest-spotinstancestatus-code
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Code { get; set; }
        }

        public class SpotPlacement : Humidifier.Base.BaseSubResource, IHaveGroupName, IHaveTenancy, IHaveAvailabilityZoneId, IHaveAvailabilityZone
        {
            /// <summary>
            /// GroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-spotplacement.html#cfn-ec2-spotinstancesrequest-spotplacement-groupname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GroupName { get; set; }
            /// <summary>
            /// Tenancy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-spotplacement.html#cfn-ec2-spotinstancesrequest-spotplacement-tenancy
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Tenancy { get; set; }
            /// <summary>
            /// AvailabilityZoneId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-spotplacement.html#cfn-ec2-spotinstancesrequest-spotplacement-availabilityzoneid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AvailabilityZoneId { get; set; }
            /// <summary>
            /// AvailabilityZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-spotplacement.html#cfn-ec2-spotinstancesrequest-spotplacement-availabilityzone
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AvailabilityZone { get; set; }
        }
    }
}