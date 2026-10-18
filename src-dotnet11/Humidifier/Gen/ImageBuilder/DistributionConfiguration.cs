namespace Humidifier.ImageBuilder
{
    using global::System.Collections.Generic;
    using DistributionConfigurationTypes;

    public class DistributionConfiguration : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription, IHaveStringDictionaryOfTags, IHaveName, IHaveListOfImageBuilderDistributionConfigurationTypesDistributionDistributions
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.ImageBuilder.DistributionConfiguration; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-distributionconfiguration.html#cfn-imagebuilder-distributionconfiguration-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-distributionconfiguration.html#cfn-imagebuilder-distributionconfiguration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// Distributions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-distributionconfiguration.html#cfn-imagebuilder-distributionconfiguration-distributions
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Distribution
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.ImageBuilder.DistributionConfigurationTypes.Distribution>, IReadOnlyList<Union<Humidifier.ImageBuilder.DistributionConfigurationTypes.Distribution, BaseFunction>>, BaseFunction>? Distributions { get; set; }
    }

    namespace DistributionConfigurationTypes
    {
        public class AmiDistributionConfiguration : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfAmiTags, IHaveDescription, IHaveKmsKeyId, IHaveImageBuilderDistributionConfigurationTypesLaunchPermissionConfigurationLaunchPermissionConfiguration, IHaveStringListOfTargetAccountIds, IHaveName
        {
            /// <summary>
            /// AmiTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-distributionconfiguration-amidistributionconfiguration.html#cfn-imagebuilder-distributionconfiguration-amidistributionconfiguration-amitags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? AmiTags { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-distributionconfiguration-amidistributionconfiguration.html#cfn-imagebuilder-distributionconfiguration-amidistributionconfiguration-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-distributionconfiguration-amidistributionconfiguration.html#cfn-imagebuilder-distributionconfiguration-amidistributionconfiguration-kmskeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
            /// <summary>
            /// LaunchPermissionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-distributionconfiguration-amidistributionconfiguration.html#cfn-imagebuilder-distributionconfiguration-amidistributionconfiguration-launchpermissionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LaunchPermissionConfiguration
            /// </summary>
            public Union<Humidifier.ImageBuilder.DistributionConfigurationTypes.LaunchPermissionConfiguration, BaseFunction>? LaunchPermissionConfiguration { get; set; }
            /// <summary>
            /// TargetAccountIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-distributionconfiguration-amidistributionconfiguration.html#cfn-imagebuilder-distributionconfiguration-amidistributionconfiguration-targetaccountids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? TargetAccountIds { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-distributionconfiguration-amidistributionconfiguration.html#cfn-imagebuilder-distributionconfiguration-amidistributionconfiguration-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class ContainerDistributionConfiguration : Humidifier.Base.BaseSubResource, IHaveImageBuilderDistributionConfigurationTypesTargetContainerRepositoryTargetRepository, IHaveStringListOfContainerTags, IHaveDescription
        {
            /// <summary>
            /// TargetRepository
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-distributionconfiguration-containerdistributionconfiguration.html#cfn-imagebuilder-distributionconfiguration-containerdistributionconfiguration-targetrepository
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TargetContainerRepository
            /// </summary>
            public Union<Humidifier.ImageBuilder.DistributionConfigurationTypes.TargetContainerRepository, BaseFunction>? TargetRepository { get; set; }
            /// <summary>
            /// ContainerTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-distributionconfiguration-containerdistributionconfiguration.html#cfn-imagebuilder-distributionconfiguration-containerdistributionconfiguration-containertags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ContainerTags { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-distributionconfiguration-containerdistributionconfiguration.html#cfn-imagebuilder-distributionconfiguration-containerdistributionconfiguration-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
        }

        public class Distribution : Humidifier.Base.BaseSubResource, IHaveImageBuilderDistributionConfigurationTypesAmiDistributionConfigurationAmiDistributionConfiguration, IHaveImageBuilderDistributionConfigurationTypesContainerDistributionConfigurationContainerDistributionConfiguration, IHaveListOfImageBuilderDistributionConfigurationTypesFastLaunchConfigurationFastLaunchConfigurations, IHaveListOfImageBuilderDistributionConfigurationTypesLaunchTemplateConfigurationLaunchTemplateConfigurations, IHaveStringListOfLicenseConfigurationArns, IHaveRegion, IHaveListOfImageBuilderDistributionConfigurationTypesSsmParameterConfigurationSsmParameterConfigurations
        {
            /// <summary>
            /// AmiDistributionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-distributionconfiguration-distribution.html#cfn-imagebuilder-distributionconfiguration-distribution-amidistributionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AmiDistributionConfiguration
            /// </summary>
            public Union<Humidifier.ImageBuilder.DistributionConfigurationTypes.AmiDistributionConfiguration, BaseFunction>? AmiDistributionConfiguration { get; set; }
            /// <summary>
            /// ContainerDistributionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-distributionconfiguration-distribution.html#cfn-imagebuilder-distributionconfiguration-distribution-containerdistributionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ContainerDistributionConfiguration
            /// </summary>
            public Union<Humidifier.ImageBuilder.DistributionConfigurationTypes.ContainerDistributionConfiguration, BaseFunction>? ContainerDistributionConfiguration { get; set; }
            /// <summary>
            /// FastLaunchConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-distributionconfiguration-distribution.html#cfn-imagebuilder-distributionconfiguration-distribution-fastlaunchconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FastLaunchConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ImageBuilder.DistributionConfigurationTypes.FastLaunchConfiguration>, IReadOnlyList<Union<Humidifier.ImageBuilder.DistributionConfigurationTypes.FastLaunchConfiguration, BaseFunction>>, BaseFunction>? FastLaunchConfigurations { get; set; }
            /// <summary>
            /// LaunchTemplateConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-distributionconfiguration-distribution.html#cfn-imagebuilder-distributionconfiguration-distribution-launchtemplateconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: LaunchTemplateConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ImageBuilder.DistributionConfigurationTypes.LaunchTemplateConfiguration>, IReadOnlyList<Union<Humidifier.ImageBuilder.DistributionConfigurationTypes.LaunchTemplateConfiguration, BaseFunction>>, BaseFunction>? LaunchTemplateConfigurations { get; set; }
            /// <summary>
            /// LicenseConfigurationArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-distributionconfiguration-distribution.html#cfn-imagebuilder-distributionconfiguration-distribution-licenseconfigurationarns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LicenseConfigurationArns { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-distributionconfiguration-distribution.html#cfn-imagebuilder-distributionconfiguration-distribution-region
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Region { get; set; }
            /// <summary>
            /// SsmParameterConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-distributionconfiguration-distribution.html#cfn-imagebuilder-distributionconfiguration-distribution-ssmparameterconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SsmParameterConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ImageBuilder.DistributionConfigurationTypes.SsmParameterConfiguration>, IReadOnlyList<Union<Humidifier.ImageBuilder.DistributionConfigurationTypes.SsmParameterConfiguration, BaseFunction>>, BaseFunction>? SsmParameterConfigurations { get; set; }
        }

        public class FastLaunchConfiguration : Humidifier.Base.BaseSubResource, IHaveAccountId, IHaveImageBuilderDistributionConfigurationTypesFastLaunchLaunchTemplateSpecificationLaunchTemplate, IHaveEnabled_Boolean, IHaveMaxParallelLaunches_Integer, IHaveImageBuilderDistributionConfigurationTypesFastLaunchSnapshotConfigurationSnapshotConfiguration
        {
            /// <summary>
            /// AccountId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-distributionconfiguration-fastlaunchconfiguration.html#cfn-imagebuilder-distributionconfiguration-fastlaunchconfiguration-accountid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccountId { get; set; }
            /// <summary>
            /// LaunchTemplate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-distributionconfiguration-fastlaunchconfiguration.html#cfn-imagebuilder-distributionconfiguration-fastlaunchconfiguration-launchtemplate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FastLaunchLaunchTemplateSpecification
            /// </summary>
            public Union<Humidifier.ImageBuilder.DistributionConfigurationTypes.FastLaunchLaunchTemplateSpecification, BaseFunction>? LaunchTemplate { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-distributionconfiguration-fastlaunchconfiguration.html#cfn-imagebuilder-distributionconfiguration-fastlaunchconfiguration-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// MaxParallelLaunches
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-distributionconfiguration-fastlaunchconfiguration.html#cfn-imagebuilder-distributionconfiguration-fastlaunchconfiguration-maxparallellaunches
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxParallelLaunches { get; set; }
            /// <summary>
            /// SnapshotConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-distributionconfiguration-fastlaunchconfiguration.html#cfn-imagebuilder-distributionconfiguration-fastlaunchconfiguration-snapshotconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FastLaunchSnapshotConfiguration
            /// </summary>
            public Union<Humidifier.ImageBuilder.DistributionConfigurationTypes.FastLaunchSnapshotConfiguration, BaseFunction>? SnapshotConfiguration { get; set; }
        }

        public class FastLaunchLaunchTemplateSpecification : Humidifier.Base.BaseSubResource, IHaveLaunchTemplateName, IHaveLaunchTemplateVersion, IHaveLaunchTemplateId
        {
            /// <summary>
            /// LaunchTemplateName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-distributionconfiguration-fastlaunchlaunchtemplatespecification.html#cfn-imagebuilder-distributionconfiguration-fastlaunchlaunchtemplatespecification-launchtemplatename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LaunchTemplateName { get; set; }
            /// <summary>
            /// LaunchTemplateVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-distributionconfiguration-fastlaunchlaunchtemplatespecification.html#cfn-imagebuilder-distributionconfiguration-fastlaunchlaunchtemplatespecification-launchtemplateversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LaunchTemplateVersion { get; set; }
            /// <summary>
            /// LaunchTemplateId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-distributionconfiguration-fastlaunchlaunchtemplatespecification.html#cfn-imagebuilder-distributionconfiguration-fastlaunchlaunchtemplatespecification-launchtemplateid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LaunchTemplateId { get; set; }
        }

        public class FastLaunchSnapshotConfiguration : Humidifier.Base.BaseSubResource, IHaveTargetResourceCount_Integer
        {
            /// <summary>
            /// TargetResourceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-distributionconfiguration-fastlaunchsnapshotconfiguration.html#cfn-imagebuilder-distributionconfiguration-fastlaunchsnapshotconfiguration-targetresourcecount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TargetResourceCount { get; set; }
        }

        public class LaunchPermissionConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfOrganizationArns, IHaveStringListOfOrganizationalUnitArns, IHaveStringListOfUserIds, IHaveStringListOfUserGroups
        {
            /// <summary>
            /// OrganizationArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-distributionconfiguration-launchpermissionconfiguration.html#cfn-imagebuilder-distributionconfiguration-launchpermissionconfiguration-organizationarns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? OrganizationArns { get; set; }
            /// <summary>
            /// OrganizationalUnitArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-distributionconfiguration-launchpermissionconfiguration.html#cfn-imagebuilder-distributionconfiguration-launchpermissionconfiguration-organizationalunitarns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? OrganizationalUnitArns { get; set; }
            /// <summary>
            /// UserIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-distributionconfiguration-launchpermissionconfiguration.html#cfn-imagebuilder-distributionconfiguration-launchpermissionconfiguration-userids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? UserIds { get; set; }
            /// <summary>
            /// UserGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-distributionconfiguration-launchpermissionconfiguration.html#cfn-imagebuilder-distributionconfiguration-launchpermissionconfiguration-usergroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? UserGroups { get; set; }
        }

        public class LaunchTemplateConfiguration : Humidifier.Base.BaseSubResource, IHaveSetDefaultVersion_Boolean, IHaveAccountId, IHaveLaunchTemplateId
        {
            /// <summary>
            /// SetDefaultVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-distributionconfiguration-launchtemplateconfiguration.html#cfn-imagebuilder-distributionconfiguration-launchtemplateconfiguration-setdefaultversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? SetDefaultVersion { get; set; }
            /// <summary>
            /// AccountId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-distributionconfiguration-launchtemplateconfiguration.html#cfn-imagebuilder-distributionconfiguration-launchtemplateconfiguration-accountid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccountId { get; set; }
            /// <summary>
            /// LaunchTemplateId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-distributionconfiguration-launchtemplateconfiguration.html#cfn-imagebuilder-distributionconfiguration-launchtemplateconfiguration-launchtemplateid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LaunchTemplateId { get; set; }
        }

        public class SsmParameterConfiguration : Humidifier.Base.BaseSubResource, IHaveDataType, IHaveParameterName, IHaveAmiAccountId
        {
            /// <summary>
            /// DataType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-distributionconfiguration-ssmparameterconfiguration.html#cfn-imagebuilder-distributionconfiguration-ssmparameterconfiguration-datatype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataType { get; set; }
            /// <summary>
            /// ParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-distributionconfiguration-ssmparameterconfiguration.html#cfn-imagebuilder-distributionconfiguration-ssmparameterconfiguration-parametername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ParameterName { get; set; }
            /// <summary>
            /// AmiAccountId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-distributionconfiguration-ssmparameterconfiguration.html#cfn-imagebuilder-distributionconfiguration-ssmparameterconfiguration-amiaccountid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AmiAccountId { get; set; }
        }

        public class TargetContainerRepository : Humidifier.Base.BaseSubResource, IHaveService, IHaveRepositoryName
        {
            /// <summary>
            /// Service
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-distributionconfiguration-targetcontainerrepository.html#cfn-imagebuilder-distributionconfiguration-targetcontainerrepository-service
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Service { get; set; }
            /// <summary>
            /// RepositoryName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-distributionconfiguration-targetcontainerrepository.html#cfn-imagebuilder-distributionconfiguration-targetcontainerrepository-repositoryname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RepositoryName { get; set; }
        }
    }
}