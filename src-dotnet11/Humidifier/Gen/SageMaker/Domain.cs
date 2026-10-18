namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using DomainTypes;

    public class Domain : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveAppNetworkAccessType, IHaveSageMakerDomainTypesDefaultSpaceSettingsDefaultSpaceSettings, IHaveKmsKeyId, IHaveDomainName, IHaveAppSecurityGroupManagement, IHaveSageMakerDomainTypesUserSettingsDefaultUserSettings, IHaveStringListOfSubnetIds, IHaveSageMakerDomainTypesDomainSettingsDomainSettings, IHaveVpcId, IHaveHomeEfsFileSystemCreation, IHaveAuthMode, IHaveTagPropagation
    {
        public class Attributes
        {
            public static string HomeEfsFileSystemId =  "HomeEfsFileSystemId" ;
            public static string DomainId =  "DomainId" ;
            public static string SecurityGroupIdForDomainBoundary =  "SecurityGroupIdForDomainBoundary" ;
            public static string SingleSignOnManagedApplicationInstanceId =  "SingleSignOnManagedApplicationInstanceId" ;
            public static string SingleSignOnApplicationArn =  "SingleSignOnApplicationArn" ;
            public static string DomainArn =  "DomainArn" ;
            public static string Url =  "Url" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.Domain; }
        /// <summary>
        /// AppNetworkAccessType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-domain.html#cfn-sagemaker-domain-appnetworkaccesstype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AppNetworkAccessType { get; set; }
        /// <summary>
        /// DefaultSpaceSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-domain.html#cfn-sagemaker-domain-defaultspacesettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DefaultSpaceSettings
        /// </summary>
        public Union<Humidifier.SageMaker.DomainTypes.DefaultSpaceSettings, BaseFunction>? DefaultSpaceSettings { get; set; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-domain.html#cfn-sagemaker-domain-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyId { get; set; }
        public Union<string, BaseFunction>? DomainName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// AppSecurityGroupManagement
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-domain.html#cfn-sagemaker-domain-appsecuritygroupmanagement
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AppSecurityGroupManagement { get; set; }

        /// <summary>
        /// DefaultUserSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-domain.html#cfn-sagemaker-domain-defaultusersettings
        /// Required: True
        /// UpdateType: Mutable
        /// Type: UserSettings
        /// </summary>
        [Required]
        public Union<Humidifier.SageMaker.DomainTypes.UserSettings, BaseFunction>? DefaultUserSettings { get; set; }
        /// <summary>
        /// SubnetIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-domain.html#cfn-sagemaker-domain-subnetids
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
        /// <summary>
        /// DomainSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-domain.html#cfn-sagemaker-domain-domainsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DomainSettings
        /// </summary>
        public Union<Humidifier.SageMaker.DomainTypes.DomainSettings, BaseFunction>? DomainSettings { get; set; }
        /// <summary>
        /// VpcId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-domain.html#cfn-sagemaker-domain-vpcid
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VpcId { get; set; }
        /// <summary>
        /// HomeEfsFileSystemCreation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-domain.html#cfn-sagemaker-domain-homeefsfilesystemcreation
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? HomeEfsFileSystemCreation { get; set; }

        /// <summary>
        /// AuthMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-domain.html#cfn-sagemaker-domain-authmode
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AuthMode { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-domain.html#cfn-sagemaker-domain-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// TagPropagation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-domain.html#cfn-sagemaker-domain-tagpropagation
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TagPropagation { get; set; }
    }

    namespace DomainTypes
    {
        public class AppLifecycleManagement : Humidifier.Base.BaseSubResource, IHaveSageMakerDomainTypesIdleSettingsIdleSettings
        {
            /// <summary>
            /// IdleSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-applifecyclemanagement.html#cfn-sagemaker-domain-applifecyclemanagement-idlesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IdleSettings
            /// </summary>
            public Union<Humidifier.SageMaker.DomainTypes.IdleSettings, BaseFunction>? IdleSettings { get; set; }
        }

        public class CodeEditorAppSettings : Humidifier.Base.BaseSubResource, IHaveListOfSageMakerDomainTypesCustomImageCustomImages, IHaveSageMakerDomainTypesResourceSpecDefaultResourceSpec, IHaveStringListOfLifecycleConfigArns, IHaveBuiltInLifecycleConfigArn, IHaveSageMakerDomainTypesAppLifecycleManagementAppLifecycleManagement
        {
            /// <summary>
            /// CustomImages
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-codeeditorappsettings.html#cfn-sagemaker-domain-codeeditorappsettings-customimages
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomImage
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.DomainTypes.CustomImage>, IReadOnlyList<Union<Humidifier.SageMaker.DomainTypes.CustomImage, BaseFunction>>, BaseFunction>? CustomImages { get; set; }
            /// <summary>
            /// DefaultResourceSpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-codeeditorappsettings.html#cfn-sagemaker-domain-codeeditorappsettings-defaultresourcespec
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResourceSpec
            /// </summary>
            public Union<Humidifier.SageMaker.DomainTypes.ResourceSpec, BaseFunction>? DefaultResourceSpec { get; set; }
            /// <summary>
            /// LifecycleConfigArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-codeeditorappsettings.html#cfn-sagemaker-domain-codeeditorappsettings-lifecycleconfigarns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LifecycleConfigArns { get; set; }
            /// <summary>
            /// BuiltInLifecycleConfigArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-codeeditorappsettings.html#cfn-sagemaker-domain-codeeditorappsettings-builtinlifecycleconfigarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BuiltInLifecycleConfigArn { get; set; }
            /// <summary>
            /// AppLifecycleManagement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-codeeditorappsettings.html#cfn-sagemaker-domain-codeeditorappsettings-applifecyclemanagement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AppLifecycleManagement
            /// </summary>
            public Union<Humidifier.SageMaker.DomainTypes.AppLifecycleManagement, BaseFunction>? AppLifecycleManagement { get; set; }
        }

        public class CodeRepository : Humidifier.Base.BaseSubResource, IHaveRepositoryUrl
        {
            /// <summary>
            /// RepositoryUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-coderepository.html#cfn-sagemaker-domain-coderepository-repositoryurl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RepositoryUrl { get; set; }
        }

        public class CustomFileSystemConfig : Humidifier.Base.BaseSubResource, IHaveSageMakerDomainTypesEFSFileSystemConfigEFSFileSystemConfig, IHaveSageMakerDomainTypesFSxLustreFileSystemConfigFSxLustreFileSystemConfig, IHaveSageMakerDomainTypesS3FileSystemConfigS3FileSystemConfig
        {
            /// <summary>
            /// EFSFileSystemConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-customfilesystemconfig.html#cfn-sagemaker-domain-customfilesystemconfig-efsfilesystemconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EFSFileSystemConfig
            /// </summary>
            public Union<Humidifier.SageMaker.DomainTypes.EFSFileSystemConfig, BaseFunction>? EFSFileSystemConfig { get; set; }
            /// <summary>
            /// FSxLustreFileSystemConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-customfilesystemconfig.html#cfn-sagemaker-domain-customfilesystemconfig-fsxlustrefilesystemconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FSxLustreFileSystemConfig
            /// </summary>
            public Union<Humidifier.SageMaker.DomainTypes.FSxLustreFileSystemConfig, BaseFunction>? FSxLustreFileSystemConfig { get; set; }
            /// <summary>
            /// S3FileSystemConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-customfilesystemconfig.html#cfn-sagemaker-domain-customfilesystemconfig-s3filesystemconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3FileSystemConfig
            /// </summary>
            public Union<Humidifier.SageMaker.DomainTypes.S3FileSystemConfig, BaseFunction>? S3FileSystemConfig { get; set; }
        }

        public class CustomImage : Humidifier.Base.BaseSubResource, IHaveImageName, IHaveAppImageConfigName, IHaveImageVersionNumber_Integer
        {
            /// <summary>
            /// ImageName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-customimage.html#cfn-sagemaker-domain-customimage-imagename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImageName { get; set; }
            /// <summary>
            /// AppImageConfigName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-customimage.html#cfn-sagemaker-domain-customimage-appimageconfigname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AppImageConfigName { get; set; }
            /// <summary>
            /// ImageVersionNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-customimage.html#cfn-sagemaker-domain-customimage-imageversionnumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ImageVersionNumber { get; set; }
        }

        public class CustomPosixUserConfig : Humidifier.Base.BaseSubResource, IHaveUid_Integer, IHaveGid_Integer
        {
            /// <summary>
            /// Uid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-customposixuserconfig.html#cfn-sagemaker-domain-customposixuserconfig-uid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Uid { get; set; }
            /// <summary>
            /// Gid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-customposixuserconfig.html#cfn-sagemaker-domain-customposixuserconfig-gid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Gid { get; set; }
        }

        public class DefaultEbsStorageSettings : Humidifier.Base.BaseSubResource, IHaveMaximumEbsVolumeSizeInGb_Integer, IHaveDefaultEbsVolumeSizeInGb_Integer
        {
            /// <summary>
            /// MaximumEbsVolumeSizeInGb
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-defaultebsstoragesettings.html#cfn-sagemaker-domain-defaultebsstoragesettings-maximumebsvolumesizeingb
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaximumEbsVolumeSizeInGb { get; set; }
            /// <summary>
            /// DefaultEbsVolumeSizeInGb
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-defaultebsstoragesettings.html#cfn-sagemaker-domain-defaultebsstoragesettings-defaultebsvolumesizeingb
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DefaultEbsVolumeSizeInGb { get; set; }
        }

        public class DefaultSpaceSettings : Humidifier.Base.BaseSubResource, IHaveStringListOfSecurityGroups, IHaveSageMakerDomainTypesJupyterLabAppSettingsJupyterLabAppSettings, IHaveSageMakerDomainTypesKernelGatewayAppSettingsKernelGatewayAppSettings, IHaveSageMakerDomainTypesJupyterServerAppSettingsJupyterServerAppSettings, IHaveListOfSageMakerDomainTypesCustomFileSystemConfigCustomFileSystemConfigs, IHaveExecutionRole, IHaveSageMakerDomainTypesDefaultSpaceStorageSettingsSpaceStorageSettings, IHaveSageMakerDomainTypesCustomPosixUserConfigCustomPosixUserConfig
        {
            /// <summary>
            /// SecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-defaultspacesettings.html#cfn-sagemaker-domain-defaultspacesettings-securitygroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroups { get; set; }
            /// <summary>
            /// JupyterLabAppSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-defaultspacesettings.html#cfn-sagemaker-domain-defaultspacesettings-jupyterlabappsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JupyterLabAppSettings
            /// </summary>
            public Union<Humidifier.SageMaker.DomainTypes.JupyterLabAppSettings, BaseFunction>? JupyterLabAppSettings { get; set; }
            /// <summary>
            /// KernelGatewayAppSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-defaultspacesettings.html#cfn-sagemaker-domain-defaultspacesettings-kernelgatewayappsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KernelGatewayAppSettings
            /// </summary>
            public Union<Humidifier.SageMaker.DomainTypes.KernelGatewayAppSettings, BaseFunction>? KernelGatewayAppSettings { get; set; }
            /// <summary>
            /// JupyterServerAppSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-defaultspacesettings.html#cfn-sagemaker-domain-defaultspacesettings-jupyterserverappsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JupyterServerAppSettings
            /// </summary>
            public Union<Humidifier.SageMaker.DomainTypes.JupyterServerAppSettings, BaseFunction>? JupyterServerAppSettings { get; set; }
            /// <summary>
            /// CustomFileSystemConfigs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-defaultspacesettings.html#cfn-sagemaker-domain-defaultspacesettings-customfilesystemconfigs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomFileSystemConfig
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.DomainTypes.CustomFileSystemConfig>, IReadOnlyList<Union<Humidifier.SageMaker.DomainTypes.CustomFileSystemConfig, BaseFunction>>, BaseFunction>? CustomFileSystemConfigs { get; set; }
            /// <summary>
            /// ExecutionRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-defaultspacesettings.html#cfn-sagemaker-domain-defaultspacesettings-executionrole
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExecutionRole { get; set; }
            /// <summary>
            /// SpaceStorageSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-defaultspacesettings.html#cfn-sagemaker-domain-defaultspacesettings-spacestoragesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultSpaceStorageSettings
            /// </summary>
            public Union<Humidifier.SageMaker.DomainTypes.DefaultSpaceStorageSettings, BaseFunction>? SpaceStorageSettings { get; set; }
            /// <summary>
            /// CustomPosixUserConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-defaultspacesettings.html#cfn-sagemaker-domain-defaultspacesettings-customposixuserconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomPosixUserConfig
            /// </summary>
            public Union<Humidifier.SageMaker.DomainTypes.CustomPosixUserConfig, BaseFunction>? CustomPosixUserConfig { get; set; }
        }

        public class DefaultSpaceStorageSettings : Humidifier.Base.BaseSubResource, IHaveSageMakerDomainTypesDefaultEbsStorageSettingsDefaultEbsStorageSettings
        {
            /// <summary>
            /// DefaultEbsStorageSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-defaultspacestoragesettings.html#cfn-sagemaker-domain-defaultspacestoragesettings-defaultebsstoragesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultEbsStorageSettings
            /// </summary>
            public Union<Humidifier.SageMaker.DomainTypes.DefaultEbsStorageSettings, BaseFunction>? DefaultEbsStorageSettings { get; set; }
        }

        public class DockerSettings : Humidifier.Base.BaseSubResource, IHaveStringListOfVpcOnlyTrustedAccounts, IHaveEnableDockerAccess
        {
            /// <summary>
            /// VpcOnlyTrustedAccounts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-dockersettings.html#cfn-sagemaker-domain-dockersettings-vpconlytrustedaccounts
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? VpcOnlyTrustedAccounts { get; set; }
            /// <summary>
            /// EnableDockerAccess
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-dockersettings.html#cfn-sagemaker-domain-dockersettings-enabledockeraccess
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EnableDockerAccess { get; set; }
        }

        public class DomainSettings : Humidifier.Base.BaseSubResource, IHaveSageMakerDomainTypesDockerSettingsDockerSettings, IHaveIpAddressType, IHaveExecutionRoleIdentityConfig, IHaveSageMakerDomainTypesUnifiedStudioSettingsUnifiedStudioSettings, IHaveSageMakerDomainTypesRStudioServerProDomainSettingsRStudioServerProDomainSettings, IHaveStringListOfSecurityGroupIds
        {
            /// <summary>
            /// DockerSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-domainsettings.html#cfn-sagemaker-domain-domainsettings-dockersettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DockerSettings
            /// </summary>
            public Union<Humidifier.SageMaker.DomainTypes.DockerSettings, BaseFunction>? DockerSettings { get; set; }
            /// <summary>
            /// IpAddressType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-domainsettings.html#cfn-sagemaker-domain-domainsettings-ipaddresstype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IpAddressType { get; set; }
            /// <summary>
            /// ExecutionRoleIdentityConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-domainsettings.html#cfn-sagemaker-domain-domainsettings-executionroleidentityconfig
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExecutionRoleIdentityConfig { get; set; }
            /// <summary>
            /// UnifiedStudioSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-domainsettings.html#cfn-sagemaker-domain-domainsettings-unifiedstudiosettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UnifiedStudioSettings
            /// </summary>
            public Union<Humidifier.SageMaker.DomainTypes.UnifiedStudioSettings, BaseFunction>? UnifiedStudioSettings { get; set; }
            /// <summary>
            /// RStudioServerProDomainSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-domainsettings.html#cfn-sagemaker-domain-domainsettings-rstudioserverprodomainsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RStudioServerProDomainSettings
            /// </summary>
            public Union<Humidifier.SageMaker.DomainTypes.RStudioServerProDomainSettings, BaseFunction>? RStudioServerProDomainSettings { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-domainsettings.html#cfn-sagemaker-domain-domainsettings-securitygroupids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        }

        public class EFSFileSystemConfig : Humidifier.Base.BaseSubResource, IHaveFileSystemPath, IHaveFileSystemId
        {
            /// <summary>
            /// FileSystemPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-efsfilesystemconfig.html#cfn-sagemaker-domain-efsfilesystemconfig-filesystempath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FileSystemPath { get; set; }
            /// <summary>
            /// FileSystemId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-efsfilesystemconfig.html#cfn-sagemaker-domain-efsfilesystemconfig-filesystemid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FileSystemId { get; set; }
        }

        public class FSxLustreFileSystemConfig : Humidifier.Base.BaseSubResource, IHaveFileSystemPath, IHaveFileSystemId
        {
            /// <summary>
            /// FileSystemPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-fsxlustrefilesystemconfig.html#cfn-sagemaker-domain-fsxlustrefilesystemconfig-filesystempath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FileSystemPath { get; set; }
            /// <summary>
            /// FileSystemId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-fsxlustrefilesystemconfig.html#cfn-sagemaker-domain-fsxlustrefilesystemconfig-filesystemid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FileSystemId { get; set; }
        }

        public class HiddenSageMakerImage : Humidifier.Base.BaseSubResource, IHaveSageMakerImageName, IHaveStringListOfVersionAliases
        {
            /// <summary>
            /// SageMakerImageName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-hiddensagemakerimage.html#cfn-sagemaker-domain-hiddensagemakerimage-sagemakerimagename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SageMakerImageName { get; set; }
            /// <summary>
            /// VersionAliases
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-hiddensagemakerimage.html#cfn-sagemaker-domain-hiddensagemakerimage-versionaliases
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? VersionAliases { get; set; }
        }

        public class IdleSettings : Humidifier.Base.BaseSubResource, IHaveMaxIdleTimeoutInMinutes_Integer, IHaveIdleTimeoutInMinutes_Integer, IHaveMinIdleTimeoutInMinutes_Integer, IHaveLifecycleManagement
        {
            /// <summary>
            /// MaxIdleTimeoutInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-idlesettings.html#cfn-sagemaker-domain-idlesettings-maxidletimeoutinminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxIdleTimeoutInMinutes { get; set; }
            /// <summary>
            /// IdleTimeoutInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-idlesettings.html#cfn-sagemaker-domain-idlesettings-idletimeoutinminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? IdleTimeoutInMinutes { get; set; }
            /// <summary>
            /// MinIdleTimeoutInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-idlesettings.html#cfn-sagemaker-domain-idlesettings-minidletimeoutinminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinIdleTimeoutInMinutes { get; set; }
            /// <summary>
            /// LifecycleManagement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-idlesettings.html#cfn-sagemaker-domain-idlesettings-lifecyclemanagement
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LifecycleManagement { get; set; }
        }

        public class JupyterLabAppSettings : Humidifier.Base.BaseSubResource, IHaveBuiltInLifecycleConfigArn, IHaveListOfSageMakerDomainTypesCodeRepositoryCodeRepositories, IHaveListOfSageMakerDomainTypesCustomImageCustomImages, IHaveSageMakerDomainTypesAppLifecycleManagementAppLifecycleManagement, IHaveSageMakerDomainTypesResourceSpecDefaultResourceSpec, IHaveStringListOfLifecycleConfigArns
        {
            /// <summary>
            /// BuiltInLifecycleConfigArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-jupyterlabappsettings.html#cfn-sagemaker-domain-jupyterlabappsettings-builtinlifecycleconfigarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BuiltInLifecycleConfigArn { get; set; }
            /// <summary>
            /// CodeRepositories
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-jupyterlabappsettings.html#cfn-sagemaker-domain-jupyterlabappsettings-coderepositories
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CodeRepository
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.DomainTypes.CodeRepository>, IReadOnlyList<Union<Humidifier.SageMaker.DomainTypes.CodeRepository, BaseFunction>>, BaseFunction>? CodeRepositories { get; set; }
            /// <summary>
            /// CustomImages
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-jupyterlabappsettings.html#cfn-sagemaker-domain-jupyterlabappsettings-customimages
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomImage
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.DomainTypes.CustomImage>, IReadOnlyList<Union<Humidifier.SageMaker.DomainTypes.CustomImage, BaseFunction>>, BaseFunction>? CustomImages { get; set; }
            /// <summary>
            /// AppLifecycleManagement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-jupyterlabappsettings.html#cfn-sagemaker-domain-jupyterlabappsettings-applifecyclemanagement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AppLifecycleManagement
            /// </summary>
            public Union<Humidifier.SageMaker.DomainTypes.AppLifecycleManagement, BaseFunction>? AppLifecycleManagement { get; set; }
            /// <summary>
            /// DefaultResourceSpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-jupyterlabappsettings.html#cfn-sagemaker-domain-jupyterlabappsettings-defaultresourcespec
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResourceSpec
            /// </summary>
            public Union<Humidifier.SageMaker.DomainTypes.ResourceSpec, BaseFunction>? DefaultResourceSpec { get; set; }
            /// <summary>
            /// LifecycleConfigArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-jupyterlabappsettings.html#cfn-sagemaker-domain-jupyterlabappsettings-lifecycleconfigarns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LifecycleConfigArns { get; set; }
        }

        public class JupyterServerAppSettings : Humidifier.Base.BaseSubResource, IHaveSageMakerDomainTypesResourceSpecDefaultResourceSpec, IHaveStringListOfLifecycleConfigArns
        {
            /// <summary>
            /// DefaultResourceSpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-jupyterserverappsettings.html#cfn-sagemaker-domain-jupyterserverappsettings-defaultresourcespec
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResourceSpec
            /// </summary>
            public Union<Humidifier.SageMaker.DomainTypes.ResourceSpec, BaseFunction>? DefaultResourceSpec { get; set; }
            /// <summary>
            /// LifecycleConfigArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-jupyterserverappsettings.html#cfn-sagemaker-domain-jupyterserverappsettings-lifecycleconfigarns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LifecycleConfigArns { get; set; }
        }

        public class KernelGatewayAppSettings : Humidifier.Base.BaseSubResource, IHaveListOfSageMakerDomainTypesCustomImageCustomImages, IHaveSageMakerDomainTypesResourceSpecDefaultResourceSpec, IHaveStringListOfLifecycleConfigArns
        {
            /// <summary>
            /// CustomImages
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-kernelgatewayappsettings.html#cfn-sagemaker-domain-kernelgatewayappsettings-customimages
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomImage
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.DomainTypes.CustomImage>, IReadOnlyList<Union<Humidifier.SageMaker.DomainTypes.CustomImage, BaseFunction>>, BaseFunction>? CustomImages { get; set; }
            /// <summary>
            /// DefaultResourceSpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-kernelgatewayappsettings.html#cfn-sagemaker-domain-kernelgatewayappsettings-defaultresourcespec
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResourceSpec
            /// </summary>
            public Union<Humidifier.SageMaker.DomainTypes.ResourceSpec, BaseFunction>? DefaultResourceSpec { get; set; }
            /// <summary>
            /// LifecycleConfigArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-kernelgatewayappsettings.html#cfn-sagemaker-domain-kernelgatewayappsettings-lifecycleconfigarns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LifecycleConfigArns { get; set; }
        }

        public class RSessionAppSettings : Humidifier.Base.BaseSubResource, IHaveListOfSageMakerDomainTypesCustomImageCustomImages, IHaveSageMakerDomainTypesResourceSpecDefaultResourceSpec
        {
            /// <summary>
            /// CustomImages
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-rsessionappsettings.html#cfn-sagemaker-domain-rsessionappsettings-customimages
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomImage
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.DomainTypes.CustomImage>, IReadOnlyList<Union<Humidifier.SageMaker.DomainTypes.CustomImage, BaseFunction>>, BaseFunction>? CustomImages { get; set; }
            /// <summary>
            /// DefaultResourceSpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-rsessionappsettings.html#cfn-sagemaker-domain-rsessionappsettings-defaultresourcespec
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResourceSpec
            /// </summary>
            public Union<Humidifier.SageMaker.DomainTypes.ResourceSpec, BaseFunction>? DefaultResourceSpec { get; set; }
        }

        public class RStudioServerProAppSettings : Humidifier.Base.BaseSubResource, IHaveAccessStatus, IHaveUserGroup
        {
            /// <summary>
            /// AccessStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-rstudioserverproappsettings.html#cfn-sagemaker-domain-rstudioserverproappsettings-accessstatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccessStatus { get; set; }
            /// <summary>
            /// UserGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-rstudioserverproappsettings.html#cfn-sagemaker-domain-rstudioserverproappsettings-usergroup
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserGroup { get; set; }
        }

        public class RStudioServerProDomainSettings : Humidifier.Base.BaseSubResource, IHaveDomainExecutionRoleArn, IHaveRStudioConnectUrl, IHaveSageMakerDomainTypesResourceSpecDefaultResourceSpec, IHaveRStudioPackageManagerUrl
        {
            /// <summary>
            /// DomainExecutionRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-rstudioserverprodomainsettings.html#cfn-sagemaker-domain-rstudioserverprodomainsettings-domainexecutionrolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DomainExecutionRoleArn { get; set; }
            /// <summary>
            /// RStudioConnectUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-rstudioserverprodomainsettings.html#cfn-sagemaker-domain-rstudioserverprodomainsettings-rstudioconnecturl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RStudioConnectUrl { get; set; }
            /// <summary>
            /// DefaultResourceSpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-rstudioserverprodomainsettings.html#cfn-sagemaker-domain-rstudioserverprodomainsettings-defaultresourcespec
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ResourceSpec
            /// </summary>
            public Union<Humidifier.SageMaker.DomainTypes.ResourceSpec, BaseFunction>? DefaultResourceSpec { get; set; }
            /// <summary>
            /// RStudioPackageManagerUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-rstudioserverprodomainsettings.html#cfn-sagemaker-domain-rstudioserverprodomainsettings-rstudiopackagemanagerurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RStudioPackageManagerUrl { get; set; }
        }

        public class ResourceSpec : Humidifier.Base.BaseSubResource, IHaveSageMakerImageArn, IHaveTrainingPlanArn, IHaveInstanceType, IHaveLifecycleConfigArn, IHaveSageMakerImageVersionArn
        {
            /// <summary>
            /// SageMakerImageArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-resourcespec.html#cfn-sagemaker-domain-resourcespec-sagemakerimagearn
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SageMakerImageArn { get; set; }
            /// <summary>
            /// TrainingPlanArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-resourcespec.html#cfn-sagemaker-domain-resourcespec-trainingplanarn
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TrainingPlanArn { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-resourcespec.html#cfn-sagemaker-domain-resourcespec-instancetype
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceType { get; set; }
            /// <summary>
            /// LifecycleConfigArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-resourcespec.html#cfn-sagemaker-domain-resourcespec-lifecycleconfigarn
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LifecycleConfigArn { get; set; }
            /// <summary>
            /// SageMakerImageVersionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-resourcespec.html#cfn-sagemaker-domain-resourcespec-sagemakerimageversionarn
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SageMakerImageVersionArn { get; set; }
        }

        public class S3FileSystemConfig : Humidifier.Base.BaseSubResource, IHaveMountPath, IHaveS3Uri
        {
            /// <summary>
            /// MountPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-s3filesystemconfig.html#cfn-sagemaker-domain-s3filesystemconfig-mountpath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MountPath { get; set; }
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-s3filesystemconfig.html#cfn-sagemaker-domain-s3filesystemconfig-s3uri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
        }

        public class SharingSettings : Humidifier.Base.BaseSubResource, IHaveNotebookOutputOption, IHaveS3KmsKeyId, IHaveS3OutputPath
        {
            /// <summary>
            /// NotebookOutputOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-sharingsettings.html#cfn-sagemaker-domain-sharingsettings-notebookoutputoption
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NotebookOutputOption { get; set; }
            /// <summary>
            /// S3KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-sharingsettings.html#cfn-sagemaker-domain-sharingsettings-s3kmskeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3KmsKeyId { get; set; }
            /// <summary>
            /// S3OutputPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-sharingsettings.html#cfn-sagemaker-domain-sharingsettings-s3outputpath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3OutputPath { get; set; }
        }

        public class StudioWebPortalSettings : Humidifier.Base.BaseSubResource, IHaveListOfSageMakerDomainTypesHiddenSageMakerImageHiddenSageMakerImageVersionAliases, IHaveStringListOfHiddenAppTypes, IHaveStringListOfHiddenInstanceTypes, IHaveStringListOfHiddenMlTools
        {
            /// <summary>
            /// HiddenSageMakerImageVersionAliases
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-studiowebportalsettings.html#cfn-sagemaker-domain-studiowebportalsettings-hiddensagemakerimageversionaliases
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: HiddenSageMakerImage
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.DomainTypes.HiddenSageMakerImage>, IReadOnlyList<Union<Humidifier.SageMaker.DomainTypes.HiddenSageMakerImage, BaseFunction>>, BaseFunction>? HiddenSageMakerImageVersionAliases { get; set; }
            /// <summary>
            /// HiddenAppTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-studiowebportalsettings.html#cfn-sagemaker-domain-studiowebportalsettings-hiddenapptypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? HiddenAppTypes { get; set; }
            /// <summary>
            /// HiddenInstanceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-studiowebportalsettings.html#cfn-sagemaker-domain-studiowebportalsettings-hiddeninstancetypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? HiddenInstanceTypes { get; set; }
            /// <summary>
            /// HiddenMlTools
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-studiowebportalsettings.html#cfn-sagemaker-domain-studiowebportalsettings-hiddenmltools
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? HiddenMlTools { get; set; }
        }

        public class UnifiedStudioSettings : Humidifier.Base.BaseSubResource, IHaveEnvironmentId, IHaveDomainId, IHaveProjectS3Path, IHaveDomainAccountId, IHaveProjectId, IHaveDomainRegion, IHaveStudioWebPortalAccess
        {
            /// <summary>
            /// EnvironmentId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-unifiedstudiosettings.html#cfn-sagemaker-domain-unifiedstudiosettings-environmentid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EnvironmentId { get; set; }
            /// <summary>
            /// DomainId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-unifiedstudiosettings.html#cfn-sagemaker-domain-unifiedstudiosettings-domainid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DomainId { get; set; }
            /// <summary>
            /// ProjectS3Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-unifiedstudiosettings.html#cfn-sagemaker-domain-unifiedstudiosettings-projects3path
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProjectS3Path { get; set; }
            /// <summary>
            /// DomainAccountId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-unifiedstudiosettings.html#cfn-sagemaker-domain-unifiedstudiosettings-domainaccountid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DomainAccountId { get; set; }
            /// <summary>
            /// ProjectId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-unifiedstudiosettings.html#cfn-sagemaker-domain-unifiedstudiosettings-projectid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProjectId { get; set; }
            /// <summary>
            /// DomainRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-unifiedstudiosettings.html#cfn-sagemaker-domain-unifiedstudiosettings-domainregion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DomainRegion { get; set; }
            /// <summary>
            /// StudioWebPortalAccess
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-unifiedstudiosettings.html#cfn-sagemaker-domain-unifiedstudiosettings-studiowebportalaccess
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StudioWebPortalAccess { get; set; }
        }

        public class UserSettings : Humidifier.Base.BaseSubResource, IHaveStringListOfSecurityGroups, IHaveSageMakerDomainTypesJupyterLabAppSettingsJupyterLabAppSettings, IHaveSageMakerDomainTypesKernelGatewayAppSettingsKernelGatewayAppSettings, IHaveSageMakerDomainTypesStudioWebPortalSettingsStudioWebPortalSettings, IHaveListOfSageMakerDomainTypesCustomFileSystemConfigCustomFileSystemConfigs, IHaveSageMakerDomainTypesCustomPosixUserConfigCustomPosixUserConfig, IHaveSageMakerDomainTypesCodeEditorAppSettingsCodeEditorAppSettings, IHaveSageMakerDomainTypesRStudioServerProAppSettingsRStudioServerProAppSettings, IHaveStudioWebPortal, IHaveSageMakerDomainTypesRSessionAppSettingsRSessionAppSettings, IHaveSageMakerDomainTypesJupyterServerAppSettingsJupyterServerAppSettings, IHaveAutoMountHomeEFS, IHaveDefaultLandingUri, IHaveExecutionRole, IHaveSageMakerDomainTypesDefaultSpaceStorageSettingsSpaceStorageSettings, IHaveSageMakerDomainTypesSharingSettingsSharingSettings
        {
            /// <summary>
            /// SecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-usersettings.html#cfn-sagemaker-domain-usersettings-securitygroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroups { get; set; }
            /// <summary>
            /// JupyterLabAppSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-usersettings.html#cfn-sagemaker-domain-usersettings-jupyterlabappsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JupyterLabAppSettings
            /// </summary>
            public Union<Humidifier.SageMaker.DomainTypes.JupyterLabAppSettings, BaseFunction>? JupyterLabAppSettings { get; set; }
            /// <summary>
            /// KernelGatewayAppSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-usersettings.html#cfn-sagemaker-domain-usersettings-kernelgatewayappsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KernelGatewayAppSettings
            /// </summary>
            public Union<Humidifier.SageMaker.DomainTypes.KernelGatewayAppSettings, BaseFunction>? KernelGatewayAppSettings { get; set; }
            /// <summary>
            /// StudioWebPortalSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-usersettings.html#cfn-sagemaker-domain-usersettings-studiowebportalsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StudioWebPortalSettings
            /// </summary>
            public Union<Humidifier.SageMaker.DomainTypes.StudioWebPortalSettings, BaseFunction>? StudioWebPortalSettings { get; set; }
            /// <summary>
            /// CustomFileSystemConfigs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-usersettings.html#cfn-sagemaker-domain-usersettings-customfilesystemconfigs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomFileSystemConfig
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.DomainTypes.CustomFileSystemConfig>, IReadOnlyList<Union<Humidifier.SageMaker.DomainTypes.CustomFileSystemConfig, BaseFunction>>, BaseFunction>? CustomFileSystemConfigs { get; set; }
            /// <summary>
            /// CustomPosixUserConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-usersettings.html#cfn-sagemaker-domain-usersettings-customposixuserconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomPosixUserConfig
            /// </summary>
            public Union<Humidifier.SageMaker.DomainTypes.CustomPosixUserConfig, BaseFunction>? CustomPosixUserConfig { get; set; }
            /// <summary>
            /// CodeEditorAppSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-usersettings.html#cfn-sagemaker-domain-usersettings-codeeditorappsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CodeEditorAppSettings
            /// </summary>
            public Union<Humidifier.SageMaker.DomainTypes.CodeEditorAppSettings, BaseFunction>? CodeEditorAppSettings { get; set; }
            /// <summary>
            /// RStudioServerProAppSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-usersettings.html#cfn-sagemaker-domain-usersettings-rstudioserverproappsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RStudioServerProAppSettings
            /// </summary>
            public Union<Humidifier.SageMaker.DomainTypes.RStudioServerProAppSettings, BaseFunction>? RStudioServerProAppSettings { get; set; }
            /// <summary>
            /// StudioWebPortal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-usersettings.html#cfn-sagemaker-domain-usersettings-studiowebportal
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StudioWebPortal { get; set; }
            /// <summary>
            /// RSessionAppSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-usersettings.html#cfn-sagemaker-domain-usersettings-rsessionappsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RSessionAppSettings
            /// </summary>
            public Union<Humidifier.SageMaker.DomainTypes.RSessionAppSettings, BaseFunction>? RSessionAppSettings { get; set; }
            /// <summary>
            /// JupyterServerAppSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-usersettings.html#cfn-sagemaker-domain-usersettings-jupyterserverappsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JupyterServerAppSettings
            /// </summary>
            public Union<Humidifier.SageMaker.DomainTypes.JupyterServerAppSettings, BaseFunction>? JupyterServerAppSettings { get; set; }
            /// <summary>
            /// AutoMountHomeEFS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-usersettings.html#cfn-sagemaker-domain-usersettings-automounthomeefs
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AutoMountHomeEFS { get; set; }
            /// <summary>
            /// DefaultLandingUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-usersettings.html#cfn-sagemaker-domain-usersettings-defaultlandinguri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DefaultLandingUri { get; set; }
            /// <summary>
            /// ExecutionRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-usersettings.html#cfn-sagemaker-domain-usersettings-executionrole
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExecutionRole { get; set; }
            /// <summary>
            /// SpaceStorageSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-usersettings.html#cfn-sagemaker-domain-usersettings-spacestoragesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultSpaceStorageSettings
            /// </summary>
            public Union<Humidifier.SageMaker.DomainTypes.DefaultSpaceStorageSettings, BaseFunction>? SpaceStorageSettings { get; set; }
            /// <summary>
            /// SharingSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-usersettings.html#cfn-sagemaker-domain-usersettings-sharingsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SharingSettings
            /// </summary>
            public Union<Humidifier.SageMaker.DomainTypes.SharingSettings, BaseFunction>? SharingSettings { get; set; }
        }
    }
}