namespace Humidifier.BedrockAgentCore
{
    using global::System.Collections.Generic;
    using CapacityProviderTypes;

    public class CapacityProvider : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveBedrockAgentCoreCapacityProviderTypesPermissionsConfigurationPermissionsConfiguration, IHaveBedrockAgentCoreCapacityProviderTypesComputeConfigurationComputeConfiguration, IHaveName
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
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// PermissionsConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-capacityprovider.html#cfn-bedrockagentcore-capacityprovider-permissionsconfiguration
        /// Required: True
        /// UpdateType: Immutable
        /// Type: PermissionsConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.BedrockAgentCore.CapacityProviderTypes.PermissionsConfiguration, BaseFunction>? PermissionsConfiguration { get; set; }

        /// <summary>
        /// ComputeConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-capacityprovider.html#cfn-bedrockagentcore-capacityprovider-computeconfiguration
        /// Required: True
        /// UpdateType: Immutable
        /// Type: ComputeConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.BedrockAgentCore.CapacityProviderTypes.ComputeConfiguration, BaseFunction>? ComputeConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-capacityprovider.html#cfn-bedrockagentcore-capacityprovider-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace CapacityProviderTypes
    {
        public class CapacityReservationSpecification : Humidifier.Base.BaseSubResource, IHaveCapacityReservationPreference, IHaveBedrockAgentCoreCapacityProviderTypesCapacityReservationTargetCapacityReservationTarget
        {
            /// <summary>
            /// CapacityReservationPreference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-capacityreservationspecification.html#cfn-bedrockagentcore-capacityprovider-capacityreservationspecification-capacityreservationpreference
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CapacityReservationPreference { get; set; }
            /// <summary>
            /// CapacityReservationTarget
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-capacityreservationspecification.html#cfn-bedrockagentcore-capacityprovider-capacityreservationspecification-capacityreservationtarget
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CapacityReservationTarget
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.CapacityProviderTypes.CapacityReservationTarget, BaseFunction>? CapacityReservationTarget { get; set; }
        }

        public class CapacityReservationTarget : Humidifier.Base.BaseSubResource, IHaveCapacityReservationResourceGroupArn, IHaveCapacityReservationId
        {
            /// <summary>
            /// CapacityReservationResourceGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-capacityreservationtarget.html#cfn-bedrockagentcore-capacityprovider-capacityreservationtarget-capacityreservationresourcegrouparn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CapacityReservationResourceGroupArn { get; set; }
            /// <summary>
            /// CapacityReservationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-capacityreservationtarget.html#cfn-bedrockagentcore-capacityprovider-capacityreservationtarget-capacityreservationid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CapacityReservationId { get; set; }
        }

        public class ComputeConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreCapacityProviderTypesEc2ConfigurationEc2Configuration
        {
            /// <summary>
            /// Ec2Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-computeconfiguration.html#cfn-bedrockagentcore-capacityprovider-computeconfiguration-ec2configuration
            /// Required: True
            /// UpdateType: Immutable
            /// Type: Ec2Configuration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.CapacityProviderTypes.Ec2Configuration, BaseFunction>? Ec2Configuration { get; set; }
        }

        public class EbsVolumeConfiguration : Humidifier.Base.BaseSubResource, IHaveSnapshotId, IHaveVolumeType, IHaveKmsKeyId, IHaveEncrypted_Boolean, IHaveSizeGiB_Integer, IHaveThroughput_Integer, IHaveIops_Integer, IHaveName
        {
            /// <summary>
            /// SnapshotId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ebsvolumeconfiguration.html#cfn-bedrockagentcore-capacityprovider-ebsvolumeconfiguration-snapshotid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SnapshotId { get; set; }
            /// <summary>
            /// VolumeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ebsvolumeconfiguration.html#cfn-bedrockagentcore-capacityprovider-ebsvolumeconfiguration-volumetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VolumeType { get; set; }
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ebsvolumeconfiguration.html#cfn-bedrockagentcore-capacityprovider-ebsvolumeconfiguration-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
            /// <summary>
            /// Encrypted
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ebsvolumeconfiguration.html#cfn-bedrockagentcore-capacityprovider-ebsvolumeconfiguration-encrypted
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Encrypted { get; set; }
            /// <summary>
            /// SizeGiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ebsvolumeconfiguration.html#cfn-bedrockagentcore-capacityprovider-ebsvolumeconfiguration-sizegib
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SizeGiB { get; set; }
            /// <summary>
            /// Throughput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ebsvolumeconfiguration.html#cfn-bedrockagentcore-capacityprovider-ebsvolumeconfiguration-throughput
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Throughput { get; set; }
            /// <summary>
            /// Iops
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ebsvolumeconfiguration.html#cfn-bedrockagentcore-capacityprovider-ebsvolumeconfiguration-iops
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Iops { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ebsvolumeconfiguration.html#cfn-bedrockagentcore-capacityprovider-ebsvolumeconfiguration-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class Ec2Configuration : Humidifier.Base.BaseSubResource, IHaveListOfBedrockAgentCoreCapacityProviderTypesVolumeConfigurationVolumes, IHaveBedrockAgentCoreCapacityProviderTypesInstanceLifecycleConfigurationLifecycleConfiguration, IHaveBedrockAgentCoreCapacityProviderTypesVpcConfigurationVpcConfiguration, IHaveBedrockAgentCoreCapacityProviderTypesRootVolumeConfigurationRootVolume, IHaveBedrockAgentCoreCapacityProviderTypesLaunchTemplateSourceLaunchTemplateSource
        {
            /// <summary>
            /// Volumes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ec2configuration.html#cfn-bedrockagentcore-capacityprovider-ec2configuration-volumes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: VolumeConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.BedrockAgentCore.CapacityProviderTypes.VolumeConfiguration>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.CapacityProviderTypes.VolumeConfiguration, BaseFunction>>, BaseFunction>? Volumes { get; set; }
            /// <summary>
            /// LifecycleConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ec2configuration.html#cfn-bedrockagentcore-capacityprovider-ec2configuration-lifecycleconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: InstanceLifecycleConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.CapacityProviderTypes.InstanceLifecycleConfiguration, BaseFunction>? LifecycleConfiguration { get; set; }
            /// <summary>
            /// VpcConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ec2configuration.html#cfn-bedrockagentcore-capacityprovider-ec2configuration-vpcconfiguration
            /// Required: True
            /// UpdateType: Immutable
            /// Type: VpcConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.CapacityProviderTypes.VpcConfiguration, BaseFunction>? VpcConfiguration { get; set; }
            /// <summary>
            /// RootVolume
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ec2configuration.html#cfn-bedrockagentcore-capacityprovider-ec2configuration-rootvolume
            /// Required: False
            /// UpdateType: Immutable
            /// Type: RootVolumeConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.CapacityProviderTypes.RootVolumeConfiguration, BaseFunction>? RootVolume { get; set; }
            /// <summary>
            /// LaunchTemplateSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ec2configuration.html#cfn-bedrockagentcore-capacityprovider-ec2configuration-launchtemplatesource
            /// Required: True
            /// UpdateType: Immutable
            /// Type: LaunchTemplateSource
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.CapacityProviderTypes.LaunchTemplateSource, BaseFunction>? LaunchTemplateSource { get; set; }
        }

        public class EphemeralBlockDeviceMapping : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreCapacityProviderTypesEphemeralEBSVolumeConfigurationEbs, IHaveVirtualName, IHaveDeviceName
        {
            /// <summary>
            /// Ebs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ephemeralblockdevicemapping.html#cfn-bedrockagentcore-capacityprovider-ephemeralblockdevicemapping-ebs
            /// Required: False
            /// UpdateType: Immutable
            /// Type: EphemeralEBSVolumeConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.CapacityProviderTypes.EphemeralEBSVolumeConfiguration, BaseFunction>? Ebs { get; set; }
            /// <summary>
            /// VirtualName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ephemeralblockdevicemapping.html#cfn-bedrockagentcore-capacityprovider-ephemeralblockdevicemapping-virtualname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VirtualName { get; set; }
            /// <summary>
            /// DeviceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ephemeralblockdevicemapping.html#cfn-bedrockagentcore-capacityprovider-ephemeralblockdevicemapping-devicename
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeviceName { get; set; }
        }

        public class EphemeralEBSVolumeConfiguration : Humidifier.Base.BaseSubResource, IHaveSnapshotId, IHaveVolumeType, IHaveKmsKeyId, IHaveEncrypted_Boolean, IHaveEbsCardIndex_Integer, IHaveThroughput_Integer, IHaveIops_Integer, IHaveVolumeInitializationRate_Integer, IHaveVolumeSize_Integer
        {
            /// <summary>
            /// SnapshotId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ephemeralebsvolumeconfiguration.html#cfn-bedrockagentcore-capacityprovider-ephemeralebsvolumeconfiguration-snapshotid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SnapshotId { get; set; }
            /// <summary>
            /// VolumeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ephemeralebsvolumeconfiguration.html#cfn-bedrockagentcore-capacityprovider-ephemeralebsvolumeconfiguration-volumetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VolumeType { get; set; }
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ephemeralebsvolumeconfiguration.html#cfn-bedrockagentcore-capacityprovider-ephemeralebsvolumeconfiguration-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
            /// <summary>
            /// Encrypted
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ephemeralebsvolumeconfiguration.html#cfn-bedrockagentcore-capacityprovider-ephemeralebsvolumeconfiguration-encrypted
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Encrypted { get; set; }
            /// <summary>
            /// EbsCardIndex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ephemeralebsvolumeconfiguration.html#cfn-bedrockagentcore-capacityprovider-ephemeralebsvolumeconfiguration-ebscardindex
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? EbsCardIndex { get; set; }
            /// <summary>
            /// Throughput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ephemeralebsvolumeconfiguration.html#cfn-bedrockagentcore-capacityprovider-ephemeralebsvolumeconfiguration-throughput
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Throughput { get; set; }
            /// <summary>
            /// Iops
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ephemeralebsvolumeconfiguration.html#cfn-bedrockagentcore-capacityprovider-ephemeralebsvolumeconfiguration-iops
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Iops { get; set; }
            /// <summary>
            /// VolumeInitializationRate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ephemeralebsvolumeconfiguration.html#cfn-bedrockagentcore-capacityprovider-ephemeralebsvolumeconfiguration-volumeinitializationrate
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? VolumeInitializationRate { get; set; }
            /// <summary>
            /// VolumeSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-ephemeralebsvolumeconfiguration.html#cfn-bedrockagentcore-capacityprovider-ephemeralebsvolumeconfiguration-volumesize
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? VolumeSize { get; set; }
        }

        public class InstanceLifecycleConfiguration : Humidifier.Base.BaseSubResource, IHaveMaxLifetime_Integer, IHaveIdleInstanceTimeout_Integer
        {
            /// <summary>
            /// MaxLifetime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-instancelifecycleconfiguration.html#cfn-bedrockagentcore-capacityprovider-instancelifecycleconfiguration-maxlifetime
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxLifetime { get; set; }
            /// <summary>
            /// IdleInstanceTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-instancelifecycleconfiguration.html#cfn-bedrockagentcore-capacityprovider-instancelifecycleconfiguration-idleinstancetimeout
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? IdleInstanceTimeout { get; set; }
        }

        public class InstanceRequirements : Humidifier.Base.BaseSubResource, IHaveStringListOfAllowedInstanceTypes
        {
            /// <summary>
            /// AllowedInstanceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-instancerequirements.html#cfn-bedrockagentcore-capacityprovider-instancerequirements-allowedinstancetypes
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedInstanceTypes { get; set; }
        }

        public class LaunchParameters : Humidifier.Base.BaseSubResource, IHaveOperatingSystem, IHaveSshKeyName, IHaveListOfBedrockAgentCoreCapacityProviderTypesLicenseSpecificationLicenseSpecifications, IHaveStringDictionaryOfPropagatedTags, IHaveListOfBedrockAgentCoreCapacityProviderTypesEphemeralBlockDeviceMappingEphemeralVolumes, IHaveBedrockAgentCoreCapacityProviderTypesInstanceRequirementsInstanceRequirements, IHaveInstanceProfileArn, IHaveBedrockAgentCoreCapacityProviderTypesCapacityReservationSpecificationCapacityReservationSpecification, IHaveMonitoring
        {
            /// <summary>
            /// OperatingSystem
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-launchparameters.html#cfn-bedrockagentcore-capacityprovider-launchparameters-operatingsystem
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OperatingSystem { get; set; }
            /// <summary>
            /// SshKeyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-launchparameters.html#cfn-bedrockagentcore-capacityprovider-launchparameters-sshkeyname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SshKeyName { get; set; }
            /// <summary>
            /// LicenseSpecifications
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-launchparameters.html#cfn-bedrockagentcore-capacityprovider-launchparameters-licensespecifications
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: LicenseSpecification
            /// </summary>
            public Union<IReadOnlyList<Humidifier.BedrockAgentCore.CapacityProviderTypes.LicenseSpecification>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.CapacityProviderTypes.LicenseSpecification, BaseFunction>>, BaseFunction>? LicenseSpecifications { get; set; }
            /// <summary>
            /// PropagatedTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-launchparameters.html#cfn-bedrockagentcore-capacityprovider-launchparameters-propagatedtags
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? PropagatedTags { get; set; }
            /// <summary>
            /// EphemeralVolumes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-launchparameters.html#cfn-bedrockagentcore-capacityprovider-launchparameters-ephemeralvolumes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: EphemeralBlockDeviceMapping
            /// </summary>
            public Union<IReadOnlyList<Humidifier.BedrockAgentCore.CapacityProviderTypes.EphemeralBlockDeviceMapping>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.CapacityProviderTypes.EphemeralBlockDeviceMapping, BaseFunction>>, BaseFunction>? EphemeralVolumes { get; set; }
            /// <summary>
            /// InstanceRequirements
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-launchparameters.html#cfn-bedrockagentcore-capacityprovider-launchparameters-instancerequirements
            /// Required: True
            /// UpdateType: Immutable
            /// Type: InstanceRequirements
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.CapacityProviderTypes.InstanceRequirements, BaseFunction>? InstanceRequirements { get; set; }
            /// <summary>
            /// InstanceProfileArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-launchparameters.html#cfn-bedrockagentcore-capacityprovider-launchparameters-instanceprofilearn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceProfileArn { get; set; }
            /// <summary>
            /// CapacityReservationSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-launchparameters.html#cfn-bedrockagentcore-capacityprovider-launchparameters-capacityreservationspecification
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CapacityReservationSpecification
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.CapacityProviderTypes.CapacityReservationSpecification, BaseFunction>? CapacityReservationSpecification { get; set; }
            /// <summary>
            /// Monitoring
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-launchparameters.html#cfn-bedrockagentcore-capacityprovider-launchparameters-monitoring
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Monitoring { get; set; }
        }

        public class LaunchTemplateSource : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreCapacityProviderTypesLaunchParametersLaunchParameters
        {
            /// <summary>
            /// LaunchParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-launchtemplatesource.html#cfn-bedrockagentcore-capacityprovider-launchtemplatesource-launchparameters
            /// Required: True
            /// UpdateType: Immutable
            /// Type: LaunchParameters
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.CapacityProviderTypes.LaunchParameters, BaseFunction>? LaunchParameters { get; set; }
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
            public Union<string, BaseFunction>? LicenseConfigurationArn { get; set; }
        }

        public class PermissionsConfiguration : Humidifier.Base.BaseSubResource, IHaveCapacityProviderOperatorRoleArn
        {
            /// <summary>
            /// CapacityProviderOperatorRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-permissionsconfiguration.html#cfn-bedrockagentcore-capacityprovider-permissionsconfiguration-capacityprovideroperatorrolearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CapacityProviderOperatorRoleArn { get; set; }
        }

        public class RootVolumeConfiguration : Humidifier.Base.BaseSubResource, IHaveFreeSpaceGiB_Integer, IHaveVolumeType, IHaveKmsKeyId, IHaveEncrypted_Boolean, IHaveThroughput_Integer, IHaveIops_Integer
        {
            /// <summary>
            /// FreeSpaceGiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-rootvolumeconfiguration.html#cfn-bedrockagentcore-capacityprovider-rootvolumeconfiguration-freespacegib
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FreeSpaceGiB { get; set; }
            /// <summary>
            /// VolumeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-rootvolumeconfiguration.html#cfn-bedrockagentcore-capacityprovider-rootvolumeconfiguration-volumetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VolumeType { get; set; }
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-rootvolumeconfiguration.html#cfn-bedrockagentcore-capacityprovider-rootvolumeconfiguration-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
            /// <summary>
            /// Encrypted
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-rootvolumeconfiguration.html#cfn-bedrockagentcore-capacityprovider-rootvolumeconfiguration-encrypted
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Encrypted { get; set; }
            /// <summary>
            /// Throughput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-rootvolumeconfiguration.html#cfn-bedrockagentcore-capacityprovider-rootvolumeconfiguration-throughput
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Throughput { get; set; }
            /// <summary>
            /// Iops
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-rootvolumeconfiguration.html#cfn-bedrockagentcore-capacityprovider-rootvolumeconfiguration-iops
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Iops { get; set; }
        }

        public class VolumeConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreCapacityProviderTypesEbsVolumeConfigurationEbsConfiguration
        {
            /// <summary>
            /// EbsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-volumeconfiguration.html#cfn-bedrockagentcore-capacityprovider-volumeconfiguration-ebsconfiguration
            /// Required: True
            /// UpdateType: Immutable
            /// Type: EbsVolumeConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.CapacityProviderTypes.EbsVolumeConfiguration, BaseFunction>? EbsConfiguration { get; set; }
        }

        public class VpcConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfSecurityGroups, IHaveStringListOfSubnets
        {
            /// <summary>
            /// SecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-vpcconfiguration.html#cfn-bedrockagentcore-capacityprovider-vpcconfiguration-securitygroups
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroups { get; set; }
            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-capacityprovider-vpcconfiguration.html#cfn-bedrockagentcore-capacityprovider-vpcconfiguration-subnets
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Subnets { get; set; }
        }
    }
}