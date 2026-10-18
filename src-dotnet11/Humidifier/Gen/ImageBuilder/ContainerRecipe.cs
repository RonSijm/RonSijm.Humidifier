namespace Humidifier.ImageBuilder
{
    using global::System.Collections.Generic;
    using ContainerRecipeTypes;

    public class ContainerRecipe : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveWorkingDirectory, IHaveParentImage, IHaveDescription, IHaveKmsKeyId, IHaveImageBuilderContainerRecipeTypesInstanceConfigurationInstanceConfiguration, IHaveContainerType, IHaveName, IHaveDockerfileTemplateData, IHaveListOfImageBuilderContainerRecipeTypesComponentConfigurationComponents, IHaveImageBuilderContainerRecipeTypesTargetContainerRepositoryTargetRepository, IHaveVersion, IHavePlatformOverride, IHaveImageOsVersionOverride, IHaveStringDictionaryOfTags, IHaveDockerfileTemplateUri
    {
        public class Attributes
        {
            public static string LatestVersion =  "LatestVersion" ;
            public static string Arn =  "Arn" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.ImageBuilder.ContainerRecipe; }
        /// <summary>
        /// WorkingDirectory
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-containerrecipe.html#cfn-imagebuilder-containerrecipe-workingdirectory
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? WorkingDirectory { get; set; }

        /// <summary>
        /// ParentImage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-containerrecipe.html#cfn-imagebuilder-containerrecipe-parentimage
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ParentImage { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-containerrecipe.html#cfn-imagebuilder-containerrecipe-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-containerrecipe.html#cfn-imagebuilder-containerrecipe-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyId { get; set; }
        /// <summary>
        /// InstanceConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-containerrecipe.html#cfn-imagebuilder-containerrecipe-instanceconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: InstanceConfiguration
        /// </summary>
        public Union<Humidifier.ImageBuilder.ContainerRecipeTypes.InstanceConfiguration, BaseFunction>? InstanceConfiguration { get; set; }

        /// <summary>
        /// ContainerType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-containerrecipe.html#cfn-imagebuilder-containerrecipe-containertype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ContainerType { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// DockerfileTemplateData
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-containerrecipe.html#cfn-imagebuilder-containerrecipe-dockerfiletemplatedata
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DockerfileTemplateData { get; set; }
        /// <summary>
        /// Components
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-containerrecipe.html#cfn-imagebuilder-containerrecipe-components
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: ComponentConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ImageBuilder.ContainerRecipeTypes.ComponentConfiguration>, IReadOnlyList<Union<Humidifier.ImageBuilder.ContainerRecipeTypes.ComponentConfiguration, BaseFunction>>, BaseFunction>? Components { get; set; }

        /// <summary>
        /// TargetRepository
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-containerrecipe.html#cfn-imagebuilder-containerrecipe-targetrepository
        /// Required: True
        /// UpdateType: Immutable
        /// Type: TargetContainerRepository
        /// </summary>
        [Required]
        public Union<Humidifier.ImageBuilder.ContainerRecipeTypes.TargetContainerRepository, BaseFunction>? TargetRepository { get; set; }

        /// <summary>
        /// Version
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-containerrecipe.html#cfn-imagebuilder-containerrecipe-version
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Version { get; set; }
        /// <summary>
        /// PlatformOverride
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-containerrecipe.html#cfn-imagebuilder-containerrecipe-platformoverride
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PlatformOverride { get; set; }
        /// <summary>
        /// ImageOsVersionOverride
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-containerrecipe.html#cfn-imagebuilder-containerrecipe-imageosversionoverride
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ImageOsVersionOverride { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-containerrecipe.html#cfn-imagebuilder-containerrecipe-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// DockerfileTemplateUri
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-containerrecipe.html#cfn-imagebuilder-containerrecipe-dockerfiletemplateuri
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DockerfileTemplateUri { get; set; }
    }

    namespace ContainerRecipeTypes
    {
        public class ComponentConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfImageBuilderContainerRecipeTypesComponentParameterParameters, IHaveComponentArn
        {
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-containerrecipe-componentconfiguration.html#cfn-imagebuilder-containerrecipe-componentconfiguration-parameters
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ComponentParameter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ImageBuilder.ContainerRecipeTypes.ComponentParameter>, IReadOnlyList<Union<Humidifier.ImageBuilder.ContainerRecipeTypes.ComponentParameter, BaseFunction>>, BaseFunction>? Parameters { get; set; }
            /// <summary>
            /// ComponentArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-containerrecipe-componentconfiguration.html#cfn-imagebuilder-containerrecipe-componentconfiguration-componentarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComponentArn { get; set; }
        }

        public class ComponentParameter : Humidifier.Base.BaseSubResource, IHaveStringListOfValue, IHaveName
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-containerrecipe-componentparameter.html#cfn-imagebuilder-containerrecipe-componentparameter-value
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-containerrecipe-componentparameter.html#cfn-imagebuilder-containerrecipe-componentparameter-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class EbsInstanceBlockDeviceSpecification : Humidifier.Base.BaseSubResource, IHaveSnapshotId, IHaveVolumeType, IHaveKmsKeyId, IHaveEncrypted_Boolean, IHaveThroughput_Integer, IHaveIops_Integer, IHaveVolumeSize_Integer, IHaveDeleteOnTermination_Boolean
        {
            /// <summary>
            /// SnapshotId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-containerrecipe-ebsinstanceblockdevicespecification.html#cfn-imagebuilder-containerrecipe-ebsinstanceblockdevicespecification-snapshotid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SnapshotId { get; set; }
            /// <summary>
            /// VolumeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-containerrecipe-ebsinstanceblockdevicespecification.html#cfn-imagebuilder-containerrecipe-ebsinstanceblockdevicespecification-volumetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VolumeType { get; set; }
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-containerrecipe-ebsinstanceblockdevicespecification.html#cfn-imagebuilder-containerrecipe-ebsinstanceblockdevicespecification-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
            /// <summary>
            /// Encrypted
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-containerrecipe-ebsinstanceblockdevicespecification.html#cfn-imagebuilder-containerrecipe-ebsinstanceblockdevicespecification-encrypted
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Encrypted { get; set; }
            /// <summary>
            /// Throughput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-containerrecipe-ebsinstanceblockdevicespecification.html#cfn-imagebuilder-containerrecipe-ebsinstanceblockdevicespecification-throughput
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Throughput { get; set; }
            /// <summary>
            /// Iops
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-containerrecipe-ebsinstanceblockdevicespecification.html#cfn-imagebuilder-containerrecipe-ebsinstanceblockdevicespecification-iops
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Iops { get; set; }
            /// <summary>
            /// VolumeSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-containerrecipe-ebsinstanceblockdevicespecification.html#cfn-imagebuilder-containerrecipe-ebsinstanceblockdevicespecification-volumesize
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? VolumeSize { get; set; }
            /// <summary>
            /// DeleteOnTermination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-containerrecipe-ebsinstanceblockdevicespecification.html#cfn-imagebuilder-containerrecipe-ebsinstanceblockdevicespecification-deleteontermination
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DeleteOnTermination { get; set; }
        }

        public class InstanceBlockDeviceMapping : Humidifier.Base.BaseSubResource, IHaveImageBuilderContainerRecipeTypesEbsInstanceBlockDeviceSpecificationEbs, IHaveNoDevice, IHaveVirtualName, IHaveDeviceName
        {
            /// <summary>
            /// Ebs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-containerrecipe-instanceblockdevicemapping.html#cfn-imagebuilder-containerrecipe-instanceblockdevicemapping-ebs
            /// Required: False
            /// UpdateType: Immutable
            /// Type: EbsInstanceBlockDeviceSpecification
            /// </summary>
            public Union<Humidifier.ImageBuilder.ContainerRecipeTypes.EbsInstanceBlockDeviceSpecification, BaseFunction>? Ebs { get; set; }
            /// <summary>
            /// NoDevice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-containerrecipe-instanceblockdevicemapping.html#cfn-imagebuilder-containerrecipe-instanceblockdevicemapping-nodevice
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NoDevice { get; set; }
            /// <summary>
            /// VirtualName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-containerrecipe-instanceblockdevicemapping.html#cfn-imagebuilder-containerrecipe-instanceblockdevicemapping-virtualname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VirtualName { get; set; }
            /// <summary>
            /// DeviceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-containerrecipe-instanceblockdevicemapping.html#cfn-imagebuilder-containerrecipe-instanceblockdevicemapping-devicename
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeviceName { get; set; }
        }

        public class InstanceConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfImageBuilderContainerRecipeTypesInstanceBlockDeviceMappingBlockDeviceMappings, IHaveImage
        {
            /// <summary>
            /// BlockDeviceMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-containerrecipe-instanceconfiguration.html#cfn-imagebuilder-containerrecipe-instanceconfiguration-blockdevicemappings
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: InstanceBlockDeviceMapping
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ImageBuilder.ContainerRecipeTypes.InstanceBlockDeviceMapping>, IReadOnlyList<Union<Humidifier.ImageBuilder.ContainerRecipeTypes.InstanceBlockDeviceMapping, BaseFunction>>, BaseFunction>? BlockDeviceMappings { get; set; }
            /// <summary>
            /// Image
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-containerrecipe-instanceconfiguration.html#cfn-imagebuilder-containerrecipe-instanceconfiguration-image
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Image { get; set; }
        }

        public class LatestVersion : Humidifier.Base.BaseSubResource, IHaveMajor, IHaveMinor, IHaveArn, IHavePatch
        {
            /// <summary>
            /// Major
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-containerrecipe-latestversion.html#cfn-imagebuilder-containerrecipe-latestversion-major
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Major { get; set; }
            /// <summary>
            /// Minor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-containerrecipe-latestversion.html#cfn-imagebuilder-containerrecipe-latestversion-minor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Minor { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-containerrecipe-latestversion.html#cfn-imagebuilder-containerrecipe-latestversion-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
            /// <summary>
            /// Patch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-containerrecipe-latestversion.html#cfn-imagebuilder-containerrecipe-latestversion-patch
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Patch { get; set; }
        }

        public class TargetContainerRepository : Humidifier.Base.BaseSubResource, IHaveService, IHaveRepositoryName
        {
            /// <summary>
            /// Service
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-containerrecipe-targetcontainerrepository.html#cfn-imagebuilder-containerrecipe-targetcontainerrepository-service
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Service { get; set; }
            /// <summary>
            /// RepositoryName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-containerrecipe-targetcontainerrepository.html#cfn-imagebuilder-containerrecipe-targetcontainerrepository-repositoryname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RepositoryName { get; set; }
        }
    }
}