namespace Humidifier.BedrockAgentCore
{
    using global::System.Collections.Generic;
    using CapacityProviderTypes;

    public class CapacityProvider : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CapacityProviderId =  "CapacityProviderId" ;
            public static string LastUpdatedAt =  "LastUpdatedAt" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.BedrockAgentCore.CapacityProvider; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-capacityprovider.html#cfn-bedrockagentcore-capacityprovider-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// PermissionsConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-capacityprovider.html#cfn-bedrockagentcore-capacityprovider-permissionsconfiguration
        /// Required: True
        /// UpdateType: Immutable
        /// Type: PermissionsConfiguration
        /// </summary>
        [Required]
        public Humidifier.BedrockAgentCore.CapacityProviderTypes.PermissionsConfiguration PermissionsConfiguration { get; set; }

        /// <summary>
        /// ComputeConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-capacityprovider.html#cfn-bedrockagentcore-capacityprovider-computeconfiguration
        /// Required: True
        /// UpdateType: Immutable
        /// Type: ComputeConfiguration
        /// </summary>
        [Required]
        public Humidifier.BedrockAgentCore.CapacityProviderTypes.ComputeConfiguration ComputeConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-capacityprovider.html#cfn-bedrockagentcore-capacityprovider-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace CapacityProviderTypes
    {
        public class CapacityReservationSpecification : Humidifier.Base.BaseSubResource, IHaveCapacityReservationPreference
        {
            /// <summary>
            /// CapacityReservationPreference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-capacityreservationspecification.html#cfn-bedrockagentcore-capacityprovider-capacityreservationspecification-capacityreservationpreference
            /// Required: False
            /// UpdateType: Immutable
            /// Type: dynamic
            /// PrimitiveType: String
            /// </summary>
            public dynamic CapacityReservationPreference { get; set; }
            /// <summary>
            /// CapacityReservationTarget
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-capacityreservationspecification.html#cfn-bedrockagentcore-capacityprovider-capacityreservationspecification-capacityreservationtarget
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CapacityReservationTarget
            /// </summary>
            public Humidifier.BedrockAgentCore.CapacityProviderTypes.CapacityReservationTarget CapacityReservationTarget { get; set; }
        }

        public class CapacityReservationTarget : Humidifier.Base.BaseSubResource, IHaveCapacityReservationResourceGroupArn
        {
            /// <summary>
            /// CapacityReservationResourceGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-capacityreservationtarget.html#cfn-bedrockagentcore-capacityprovider-capacityreservationtarget-capacityreservationresourcegrouparn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CapacityReservationResourceGroupArn { get; set; }
            /// <summary>
            /// CapacityReservationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-capacityreservationtarget.html#cfn-bedrockagentcore-capacityprovider-capacityreservationtarget-capacityreservationid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CapacityReservationId { get; set; }
        }

        public class ComputeConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Ec2Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-computeconfiguration.html#cfn-bedrockagentcore-capacityprovider-computeconfiguration-ec2configuration
            /// Required: True
            /// UpdateType: Immutable
            /// Type: Ec2Configuration
            /// </summary>
            public Humidifier.BedrockAgentCore.CapacityProviderTypes.Ec2Configuration Ec2Configuration { get; set; }
        }

        public class EbsVolumeConfiguration : Humidifier.Base.BaseSubResource, IHaveName, IHaveKmsKeyId, IHaveIops, IHaveVolumeType, IHaveEncrypted, IHaveThroughput, IHaveSnapshotId, IHaveSizeGiB
        {
            /// <summary>
            /// SnapshotId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ebsvolumeconfiguration.html#cfn-bedrockagentcore-capacityprovider-ebsvolumeconfiguration-snapshotid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SnapshotId { get; set; }
            /// <summary>
            /// VolumeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ebsvolumeconfiguration.html#cfn-bedrockagentcore-capacityprovider-ebsvolumeconfiguration-volumetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VolumeType { get; set; }
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ebsvolumeconfiguration.html#cfn-bedrockagentcore-capacityprovider-ebsvolumeconfiguration-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKeyId { get; set; }
            /// <summary>
            /// Encrypted
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ebsvolumeconfiguration.html#cfn-bedrockagentcore-capacityprovider-ebsvolumeconfiguration-encrypted
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Encrypted { get; set; }
            /// <summary>
            /// SizeGiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ebsvolumeconfiguration.html#cfn-bedrockagentcore-capacityprovider-ebsvolumeconfiguration-sizegib
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic SizeGiB { get; set; }
            /// <summary>
            /// Throughput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ebsvolumeconfiguration.html#cfn-bedrockagentcore-capacityprovider-ebsvolumeconfiguration-throughput
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Throughput { get; set; }
            /// <summary>
            /// Iops
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ebsvolumeconfiguration.html#cfn-bedrockagentcore-capacityprovider-ebsvolumeconfiguration-iops
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Iops { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ebsvolumeconfiguration.html#cfn-bedrockagentcore-capacityprovider-ebsvolumeconfiguration-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class Ec2Configuration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Volumes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ec2configuration.html#cfn-bedrockagentcore-capacityprovider-ec2configuration-volumes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: VolumeConfiguration
            /// </summary>
            public List<Humidifier.BedrockAgentCore.CapacityProviderTypes.VolumeConfiguration> Volumes { get; set; }
            /// <summary>
            /// LifecycleConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ec2configuration.html#cfn-bedrockagentcore-capacityprovider-ec2configuration-lifecycleconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: InstanceLifecycleConfiguration
            /// </summary>
            public Humidifier.BedrockAgentCore.CapacityProviderTypes.InstanceLifecycleConfiguration LifecycleConfiguration { get; set; }
            /// <summary>
            /// VpcConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ec2configuration.html#cfn-bedrockagentcore-capacityprovider-ec2configuration-vpcconfiguration
            /// Required: True
            /// UpdateType: Immutable
            /// Type: VpcConfiguration
            /// </summary>
            public Humidifier.BedrockAgentCore.CapacityProviderTypes.VpcConfiguration VpcConfiguration { get; set; }
            /// <summary>
            /// RootVolume
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ec2configuration.html#cfn-bedrockagentcore-capacityprovider-ec2configuration-rootvolume
            /// Required: False
            /// UpdateType: Immutable
            /// Type: RootVolumeConfiguration
            /// </summary>
            public Humidifier.BedrockAgentCore.CapacityProviderTypes.RootVolumeConfiguration RootVolume { get; set; }
            /// <summary>
            /// LaunchTemplateSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ec2configuration.html#cfn-bedrockagentcore-capacityprovider-ec2configuration-launchtemplatesource
            /// Required: True
            /// UpdateType: Immutable
            /// Type: LaunchTemplateSource
            /// </summary>
            public Humidifier.BedrockAgentCore.CapacityProviderTypes.LaunchTemplateSource LaunchTemplateSource { get; set; }
        }

        public class EphemeralBlockDeviceMapping : Humidifier.Base.BaseSubResource, IHaveDeviceName, IHaveVirtualName
        {
            /// <summary>
            /// Ebs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ephemeralblockdevicemapping.html#cfn-bedrockagentcore-capacityprovider-ephemeralblockdevicemapping-ebs
            /// Required: False
            /// UpdateType: Immutable
            /// Type: EphemeralEBSVolumeConfiguration
            /// </summary>
            public Humidifier.BedrockAgentCore.CapacityProviderTypes.EphemeralEBSVolumeConfiguration Ebs { get; set; }
            /// <summary>
            /// VirtualName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ephemeralblockdevicemapping.html#cfn-bedrockagentcore-capacityprovider-ephemeralblockdevicemapping-virtualname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VirtualName { get; set; }
            /// <summary>
            /// DeviceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ephemeralblockdevicemapping.html#cfn-bedrockagentcore-capacityprovider-ephemeralblockdevicemapping-devicename
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DeviceName { get; set; }
        }

        public class EphemeralEBSVolumeConfiguration : Humidifier.Base.BaseSubResource, IHaveKmsKeyId, IHaveIops, IHaveVolumeType, IHaveEncrypted, IHaveThroughput, IHaveVolumeSize, IHaveSnapshotId
        {
            /// <summary>
            /// SnapshotId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ephemeralebsvolumeconfiguration.html#cfn-bedrockagentcore-capacityprovider-ephemeralebsvolumeconfiguration-snapshotid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SnapshotId { get; set; }
            /// <summary>
            /// VolumeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ephemeralebsvolumeconfiguration.html#cfn-bedrockagentcore-capacityprovider-ephemeralebsvolumeconfiguration-volumetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VolumeType { get; set; }
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ephemeralebsvolumeconfiguration.html#cfn-bedrockagentcore-capacityprovider-ephemeralebsvolumeconfiguration-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKeyId { get; set; }
            /// <summary>
            /// Encrypted
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ephemeralebsvolumeconfiguration.html#cfn-bedrockagentcore-capacityprovider-ephemeralebsvolumeconfiguration-encrypted
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Encrypted { get; set; }
            /// <summary>
            /// EbsCardIndex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ephemeralebsvolumeconfiguration.html#cfn-bedrockagentcore-capacityprovider-ephemeralebsvolumeconfiguration-ebscardindex
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic EbsCardIndex { get; set; }
            /// <summary>
            /// Throughput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ephemeralebsvolumeconfiguration.html#cfn-bedrockagentcore-capacityprovider-ephemeralebsvolumeconfiguration-throughput
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Throughput { get; set; }
            /// <summary>
            /// Iops
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ephemeralebsvolumeconfiguration.html#cfn-bedrockagentcore-capacityprovider-ephemeralebsvolumeconfiguration-iops
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Iops { get; set; }
            /// <summary>
            /// VolumeInitializationRate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ephemeralebsvolumeconfiguration.html#cfn-bedrockagentcore-capacityprovider-ephemeralebsvolumeconfiguration-volumeinitializationrate
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic VolumeInitializationRate { get; set; }
            /// <summary>
            /// VolumeSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ephemeralebsvolumeconfiguration.html#cfn-bedrockagentcore-capacityprovider-ephemeralebsvolumeconfiguration-volumesize
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic VolumeSize { get; set; }
        }

        public class InstanceLifecycleConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MaxLifetime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-instancelifecycleconfiguration.html#cfn-bedrockagentcore-capacityprovider-instancelifecycleconfiguration-maxlifetime
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxLifetime { get; set; }
            /// <summary>
            /// IdleInstanceTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-instancelifecycleconfiguration.html#cfn-bedrockagentcore-capacityprovider-instancelifecycleconfiguration-idleinstancetimeout
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic IdleInstanceTimeout { get; set; }
        }

        public class InstanceRequirements : Humidifier.Base.BaseSubResource, IHaveAllowedInstanceTypes
        {
            /// <summary>
            /// AllowedInstanceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-instancerequirements.html#cfn-bedrockagentcore-capacityprovider-instancerequirements-allowedinstancetypes
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AllowedInstanceTypes { get; set; }
        }

        public class LaunchParameters : Humidifier.Base.BaseSubResource, IHaveOperatingSystem, IHaveInstanceProfileArn
        {
            /// <summary>
            /// OperatingSystem
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-launchparameters.html#cfn-bedrockagentcore-capacityprovider-launchparameters-operatingsystem
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OperatingSystem { get; set; }
            /// <summary>
            /// SshKeyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-launchparameters.html#cfn-bedrockagentcore-capacityprovider-launchparameters-sshkeyname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SshKeyName { get; set; }
            /// <summary>
            /// LicenseSpecifications
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-launchparameters.html#cfn-bedrockagentcore-capacityprovider-launchparameters-licensespecifications
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: LicenseSpecification
            /// </summary>
            public List<Humidifier.BedrockAgentCore.CapacityProviderTypes.LicenseSpecification> LicenseSpecifications { get; set; }
            /// <summary>
            /// PropagatedTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-launchparameters.html#cfn-bedrockagentcore-capacityprovider-launchparameters-propagatedtags
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> PropagatedTags { get; set; }
            /// <summary>
            /// EphemeralVolumes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-launchparameters.html#cfn-bedrockagentcore-capacityprovider-launchparameters-ephemeralvolumes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: EphemeralBlockDeviceMapping
            /// </summary>
            public List<Humidifier.BedrockAgentCore.CapacityProviderTypes.EphemeralBlockDeviceMapping> EphemeralVolumes { get; set; }
            /// <summary>
            /// InstanceRequirements
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-launchparameters.html#cfn-bedrockagentcore-capacityprovider-launchparameters-instancerequirements
            /// Required: True
            /// UpdateType: Immutable
            /// Type: InstanceRequirements
            /// </summary>
            public Humidifier.BedrockAgentCore.CapacityProviderTypes.InstanceRequirements InstanceRequirements { get; set; }
            /// <summary>
            /// InstanceProfileArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-launchparameters.html#cfn-bedrockagentcore-capacityprovider-launchparameters-instanceprofilearn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InstanceProfileArn { get; set; }
            /// <summary>
            /// CapacityReservationSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-launchparameters.html#cfn-bedrockagentcore-capacityprovider-launchparameters-capacityreservationspecification
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CapacityReservationSpecification
            /// </summary>
            public Humidifier.BedrockAgentCore.CapacityProviderTypes.CapacityReservationSpecification CapacityReservationSpecification { get; set; }
            /// <summary>
            /// Monitoring
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-launchparameters.html#cfn-bedrockagentcore-capacityprovider-launchparameters-monitoring
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Monitoring { get; set; }
        }

        public class LaunchTemplateSource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LaunchParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-launchtemplatesource.html#cfn-bedrockagentcore-capacityprovider-launchtemplatesource-launchparameters
            /// Required: True
            /// UpdateType: Immutable
            /// Type: LaunchParameters
            /// </summary>
            public Humidifier.BedrockAgentCore.CapacityProviderTypes.LaunchParameters LaunchParameters { get; set; }
        }

        public class LicenseSpecification : Humidifier.Base.BaseSubResource, IHaveLicenseConfigurationArn
        {
            /// <summary>
            /// LicenseConfigurationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-licensespecification.html#cfn-bedrockagentcore-capacityprovider-licensespecification-licenseconfigurationarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LicenseConfigurationArn { get; set; }
        }

        public class PermissionsConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CapacityProviderOperatorRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-permissionsconfiguration.html#cfn-bedrockagentcore-capacityprovider-permissionsconfiguration-capacityprovideroperatorrolearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CapacityProviderOperatorRoleArn { get; set; }
        }

        public class RootVolumeConfiguration : Humidifier.Base.BaseSubResource, IHaveKmsKeyId, IHaveIops, IHaveVolumeType, IHaveEncrypted, IHaveThroughput
        {
            /// <summary>
            /// FreeSpaceGiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-rootvolumeconfiguration.html#cfn-bedrockagentcore-capacityprovider-rootvolumeconfiguration-freespacegib
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic FreeSpaceGiB { get; set; }
            /// <summary>
            /// VolumeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-rootvolumeconfiguration.html#cfn-bedrockagentcore-capacityprovider-rootvolumeconfiguration-volumetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VolumeType { get; set; }
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-rootvolumeconfiguration.html#cfn-bedrockagentcore-capacityprovider-rootvolumeconfiguration-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKeyId { get; set; }
            /// <summary>
            /// Encrypted
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-rootvolumeconfiguration.html#cfn-bedrockagentcore-capacityprovider-rootvolumeconfiguration-encrypted
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Encrypted { get; set; }
            /// <summary>
            /// Throughput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-rootvolumeconfiguration.html#cfn-bedrockagentcore-capacityprovider-rootvolumeconfiguration-throughput
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Throughput { get; set; }
            /// <summary>
            /// Iops
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-rootvolumeconfiguration.html#cfn-bedrockagentcore-capacityprovider-rootvolumeconfiguration-iops
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Iops { get; set; }
        }

        public class VolumeConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EbsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-volumeconfiguration.html#cfn-bedrockagentcore-capacityprovider-volumeconfiguration-ebsconfiguration
            /// Required: True
            /// UpdateType: Immutable
            /// Type: EbsVolumeConfiguration
            /// </summary>
            public Humidifier.BedrockAgentCore.CapacityProviderTypes.EbsVolumeConfiguration EbsConfiguration { get; set; }
        }

        public class VpcConfiguration : Humidifier.Base.BaseSubResource, IHaveSubnets, IHaveSecurityGroups
        {
            /// <summary>
            /// SecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-vpcconfiguration.html#cfn-bedrockagentcore-capacityprovider-vpcconfiguration-securitygroups
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroups { get; set; }
            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-vpcconfiguration.html#cfn-bedrockagentcore-capacityprovider-vpcconfiguration-subnets
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Subnets { get; set; }
        }
    }
}