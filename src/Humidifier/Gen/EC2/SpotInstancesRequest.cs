namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using SpotInstancesRequestTypes;

    public class SpotInstancesRequest : Humidifier.Base.BaseResource, IHaveTags, IHaveType, IHaveSpotPrice, IHaveValidUntil, IHaveInstanceInterruptionBehavior, IHaveValidFrom
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
        public dynamic SpotPrice { get; set; }
        /// <summary>
        /// AvailabilityZoneGroup
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-spotinstancesrequest.html#cfn-ec2-spotinstancesrequest-availabilityzonegroup
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AvailabilityZoneGroup { get; set; }
        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-spotinstancesrequest.html#cfn-ec2-spotinstancesrequest-type
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Type { get; set; }
        /// <summary>
        /// LaunchGroup
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-spotinstancesrequest.html#cfn-ec2-spotinstancesrequest-launchgroup
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic LaunchGroup { get; set; }
        /// <summary>
        /// InstanceInterruptionBehavior
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-spotinstancesrequest.html#cfn-ec2-spotinstancesrequest-instanceinterruptionbehavior
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic InstanceInterruptionBehavior { get; set; }
        /// <summary>
        /// LaunchSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-spotinstancesrequest.html#cfn-ec2-spotinstancesrequest-launchspecification
        /// Required: False
        /// UpdateType: Immutable
        /// Type: LaunchSpecification
        /// </summary>
        public Humidifier.EC2.SpotInstancesRequestTypes.LaunchSpecification LaunchSpecification { get; set; }
        /// <summary>
        /// ValidFrom
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-spotinstancesrequest.html#cfn-ec2-spotinstancesrequest-validfrom
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ValidFrom { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-spotinstancesrequest.html#cfn-ec2-spotinstancesrequest-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        /// <summary>
        /// ValidUntil
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-spotinstancesrequest.html#cfn-ec2-spotinstancesrequest-validuntil
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ValidUntil { get; set; }
    }

    namespace SpotInstancesRequestTypes
    {
        public class BlockDeviceMapping : Humidifier.Base.BaseSubResource, IHaveDeviceName, IHaveNoDevice, IHaveVirtualName
        {
            /// <summary>
            /// Ebs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-blockdevicemapping.html#cfn-ec2-spotinstancesrequest-blockdevicemapping-ebs
            /// Required: False
            /// UpdateType: Immutable
            /// Type: EbsBlockDevice
            /// </summary>
            public Humidifier.EC2.SpotInstancesRequestTypes.EbsBlockDevice Ebs { get; set; }
            /// <summary>
            /// NoDevice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-blockdevicemapping.html#cfn-ec2-spotinstancesrequest-blockdevicemapping-nodevice
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NoDevice { get; set; }
            /// <summary>
            /// VirtualName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-blockdevicemapping.html#cfn-ec2-spotinstancesrequest-blockdevicemapping-virtualname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VirtualName { get; set; }
            /// <summary>
            /// DeviceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-blockdevicemapping.html#cfn-ec2-spotinstancesrequest-blockdevicemapping-devicename
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DeviceName { get; set; }
        }

        public class EbsBlockDevice : Humidifier.Base.BaseSubResource, IHaveKmsKeyId, IHaveIops, IHaveVolumeType, IHaveEncrypted, IHaveDeleteOnTermination, IHaveThroughput, IHaveVolumeSize, IHaveSnapshotId
        {
            /// <summary>
            /// SnapshotId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-ebsblockdevice.html#cfn-ec2-spotinstancesrequest-ebsblockdevice-snapshotid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SnapshotId { get; set; }
            /// <summary>
            /// VolumeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-ebsblockdevice.html#cfn-ec2-spotinstancesrequest-ebsblockdevice-volumetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VolumeType { get; set; }
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-ebsblockdevice.html#cfn-ec2-spotinstancesrequest-ebsblockdevice-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKeyId { get; set; }
            /// <summary>
            /// Encrypted
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-ebsblockdevice.html#cfn-ec2-spotinstancesrequest-ebsblockdevice-encrypted
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Encrypted { get; set; }
            /// <summary>
            /// Throughput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-ebsblockdevice.html#cfn-ec2-spotinstancesrequest-ebsblockdevice-throughput
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Throughput { get; set; }
            /// <summary>
            /// Iops
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-ebsblockdevice.html#cfn-ec2-spotinstancesrequest-ebsblockdevice-iops
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Iops { get; set; }
            /// <summary>
            /// VolumeSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-ebsblockdevice.html#cfn-ec2-spotinstancesrequest-ebsblockdevice-volumesize
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic VolumeSize { get; set; }
            /// <summary>
            /// DeleteOnTermination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-ebsblockdevice.html#cfn-ec2-spotinstancesrequest-ebsblockdevice-deleteontermination
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic DeleteOnTermination { get; set; }
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
            public dynamic GroupName { get; set; }
            /// <summary>
            /// GroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-groupidentifier.html#cfn-ec2-spotinstancesrequest-groupidentifier-groupid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GroupId { get; set; }
        }

        public class IamInstanceProfileSpecification : Humidifier.Base.BaseSubResource, IHaveName, IHaveArn
        {
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-iaminstanceprofilespecification.html#cfn-ec2-spotinstancesrequest-iaminstanceprofilespecification-arn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-iaminstanceprofilespecification.html#cfn-ec2-spotinstancesrequest-iaminstanceprofilespecification-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
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
            public dynamic Ipv6Address { get; set; }
        }

        public class InstanceNetworkInterfaceSpecification : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveSubnetId, IHaveNetworkInterfaceId, IHavePrivateIpAddress, IHaveDeleteOnTermination, IHaveAssociatePublicIpAddress, IHaveIpv6AddressCount, IHaveSecondaryPrivateIpAddressCount, IHaveDeviceIndex
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-instancenetworkinterfacespecification.html#cfn-ec2-spotinstancesrequest-instancenetworkinterfacespecification-description
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// PrivateIpAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-instancenetworkinterfacespecification.html#cfn-ec2-spotinstancesrequest-instancenetworkinterfacespecification-privateipaddress
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PrivateIpAddress { get; set; }
            /// <summary>
            /// PrivateIpAddresses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-instancenetworkinterfacespecification.html#cfn-ec2-spotinstancesrequest-instancenetworkinterfacespecification-privateipaddresses
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: PrivateIpAddressSpecification
            /// </summary>
            public List<Humidifier.EC2.SpotInstancesRequestTypes.PrivateIpAddressSpecification> PrivateIpAddresses { get; set; }
            /// <summary>
            /// SecondaryPrivateIpAddressCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-instancenetworkinterfacespecification.html#cfn-ec2-spotinstancesrequest-instancenetworkinterfacespecification-secondaryprivateipaddresscount
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic SecondaryPrivateIpAddressCount { get; set; }
            /// <summary>
            /// DeviceIndex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-instancenetworkinterfacespecification.html#cfn-ec2-spotinstancesrequest-instancenetworkinterfacespecification-deviceindex
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DeviceIndex { get; set; }
            /// <summary>
            /// Ipv6AddressCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-instancenetworkinterfacespecification.html#cfn-ec2-spotinstancesrequest-instancenetworkinterfacespecification-ipv6addresscount
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Ipv6AddressCount { get; set; }
            /// <summary>
            /// Ipv6Addresses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-instancenetworkinterfacespecification.html#cfn-ec2-spotinstancesrequest-instancenetworkinterfacespecification-ipv6addresses
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: InstanceIpv6Address
            /// </summary>
            public List<Humidifier.EC2.SpotInstancesRequestTypes.InstanceIpv6Address> Ipv6Addresses { get; set; }
            /// <summary>
            /// SubnetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-instancenetworkinterfacespecification.html#cfn-ec2-spotinstancesrequest-instancenetworkinterfacespecification-subnetid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SubnetId { get; set; }
            /// <summary>
            /// AssociatePublicIpAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-instancenetworkinterfacespecification.html#cfn-ec2-spotinstancesrequest-instancenetworkinterfacespecification-associatepublicipaddress
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AssociatePublicIpAddress { get; set; }
            /// <summary>
            /// NetworkInterfaceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-instancenetworkinterfacespecification.html#cfn-ec2-spotinstancesrequest-instancenetworkinterfacespecification-networkinterfaceid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NetworkInterfaceId { get; set; }
            /// <summary>
            /// DeleteOnTermination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-instancenetworkinterfacespecification.html#cfn-ec2-spotinstancesrequest-instancenetworkinterfacespecification-deleteontermination
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic DeleteOnTermination { get; set; }
        }

        public class LaunchSpecification : Humidifier.Base.BaseSubResource, IHaveInstanceType, IHaveSubnetId, IHaveEbsOptimized, IHaveImageId, IHaveKeyName, IHaveKernelId, IHaveRamdiskId
        {
            /// <summary>
            /// SecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-launchspecification.html#cfn-ec2-spotinstancesrequest-launchspecification-securitygroups
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: GroupIdentifier
            /// </summary>
            public List<Humidifier.EC2.SpotInstancesRequestTypes.GroupIdentifier> SecurityGroups { get; set; }
            /// <summary>
            /// BlockDeviceMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-launchspecification.html#cfn-ec2-spotinstancesrequest-launchspecification-blockdevicemappings
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: BlockDeviceMapping
            /// </summary>
            public List<Humidifier.EC2.SpotInstancesRequestTypes.BlockDeviceMapping> BlockDeviceMappings { get; set; }
            /// <summary>
            /// IamInstanceProfile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-launchspecification.html#cfn-ec2-spotinstancesrequest-launchspecification-iaminstanceprofile
            /// Required: False
            /// UpdateType: Immutable
            /// Type: IamInstanceProfileSpecification
            /// </summary>
            public Humidifier.EC2.SpotInstancesRequestTypes.IamInstanceProfileSpecification IamInstanceProfile { get; set; }
            /// <summary>
            /// KernelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-launchspecification.html#cfn-ec2-spotinstancesrequest-launchspecification-kernelid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KernelId { get; set; }
            /// <summary>
            /// SubnetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-launchspecification.html#cfn-ec2-spotinstancesrequest-launchspecification-subnetid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SubnetId { get; set; }
            /// <summary>
            /// EbsOptimized
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-launchspecification.html#cfn-ec2-spotinstancesrequest-launchspecification-ebsoptimized
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EbsOptimized { get; set; }
            /// <summary>
            /// KeyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-launchspecification.html#cfn-ec2-spotinstancesrequest-launchspecification-keyname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KeyName { get; set; }
            /// <summary>
            /// RamdiskId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-launchspecification.html#cfn-ec2-spotinstancesrequest-launchspecification-ramdiskid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RamdiskId { get; set; }
            /// <summary>
            /// Placement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-launchspecification.html#cfn-ec2-spotinstancesrequest-launchspecification-placement
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SpotPlacement
            /// </summary>
            public Humidifier.EC2.SpotInstancesRequestTypes.SpotPlacement Placement { get; set; }
            /// <summary>
            /// NetworkInterfaces
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-launchspecification.html#cfn-ec2-spotinstancesrequest-launchspecification-networkinterfaces
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: InstanceNetworkInterfaceSpecification
            /// </summary>
            public List<Humidifier.EC2.SpotInstancesRequestTypes.InstanceNetworkInterfaceSpecification> NetworkInterfaces { get; set; }
            /// <summary>
            /// AddressingType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-launchspecification.html#cfn-ec2-spotinstancesrequest-launchspecification-addressingtype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AddressingType { get; set; }
            /// <summary>
            /// ImageId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-launchspecification.html#cfn-ec2-spotinstancesrequest-launchspecification-imageid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ImageId { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-launchspecification.html#cfn-ec2-spotinstancesrequest-launchspecification-instancetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InstanceType { get; set; }
            /// <summary>
            /// Monitoring
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-launchspecification.html#cfn-ec2-spotinstancesrequest-launchspecification-monitoring
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MonitoringEnabled
            /// </summary>
            public Humidifier.EC2.SpotInstancesRequestTypes.MonitoringEnabled Monitoring { get; set; }
        }

        public class MonitoringEnabled : Humidifier.Base.BaseSubResource, IHaveEnabled
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-monitoringenabled.html#cfn-ec2-spotinstancesrequest-monitoringenabled-enabled
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
        }

        public class PrivateIpAddressSpecification : Humidifier.Base.BaseSubResource, IHavePrivateIpAddress, IHavePrimary
        {
            /// <summary>
            /// PrivateIpAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-privateipaddressspecification.html#cfn-ec2-spotinstancesrequest-privateipaddressspecification-privateipaddress
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PrivateIpAddress { get; set; }
            /// <summary>
            /// Primary
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-privateipaddressspecification.html#cfn-ec2-spotinstancesrequest-privateipaddressspecification-primary
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Primary { get; set; }
        }

        public class SpotInstanceStatus : Humidifier.Base.BaseSubResource, IHaveMessage, IHaveCode
        {
            /// <summary>
            /// Message
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-spotinstancestatus.html#cfn-ec2-spotinstancesrequest-spotinstancestatus-message
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Message { get; set; }
            /// <summary>
            /// UpdateTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-spotinstancestatus.html#cfn-ec2-spotinstancesrequest-spotinstancestatus-updatetime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateTime { get; set; }
            /// <summary>
            /// Code
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-spotinstancestatus.html#cfn-ec2-spotinstancesrequest-spotinstancestatus-code
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Code { get; set; }
        }

        public class SpotPlacement : Humidifier.Base.BaseSubResource, IHaveAvailabilityZone, IHaveGroupName, IHaveTenancy, IHaveAvailabilityZoneId
        {
            /// <summary>
            /// GroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-spotplacement.html#cfn-ec2-spotinstancesrequest-spotplacement-groupname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GroupName { get; set; }
            /// <summary>
            /// Tenancy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-spotplacement.html#cfn-ec2-spotinstancesrequest-spotplacement-tenancy
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Tenancy { get; set; }
            /// <summary>
            /// AvailabilityZoneId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-spotplacement.html#cfn-ec2-spotinstancesrequest-spotplacement-availabilityzoneid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AvailabilityZoneId { get; set; }
            /// <summary>
            /// AvailabilityZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotinstancesrequest-spotplacement.html#cfn-ec2-spotinstancesrequest-spotplacement-availabilityzone
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AvailabilityZone { get; set; }
        }
    }
}