namespace Humidifier.SageMaker
{
    using System.Collections.Generic;
    using DomainTypes;

    public class Domain : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveKmsKeyId, IHaveSubnetIds, IHaveVpcId, IHaveDomainName, IHaveAuthMode
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
        public dynamic AppNetworkAccessType { get; set; }
        /// <summary>
        /// DefaultSpaceSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-domain.html#cfn-sagemaker-domain-defaultspacesettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DefaultSpaceSettings
        /// </summary>
        public Humidifier.SageMaker.DomainTypes.DefaultSpaceSettings DefaultSpaceSettings { get; set; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-domain.html#cfn-sagemaker-domain-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KmsKeyId { get; set; }

        /// <summary>
        /// VpcId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-domain.html#cfn-sagemaker-domain-vpcid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic VpcId { get; set; }
        public dynamic DomainName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// AppSecurityGroupManagement
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-domain.html#cfn-sagemaker-domain-appsecuritygroupmanagement
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AppSecurityGroupManagement { get; set; }

        /// <summary>
        /// DefaultUserSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-domain.html#cfn-sagemaker-domain-defaultusersettings
        /// Required: True
        /// UpdateType: Mutable
        /// Type: UserSettings
        /// </summary>
        [Required]
        public Humidifier.SageMaker.DomainTypes.UserSettings DefaultUserSettings { get; set; }

        /// <summary>
        /// SubnetIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-domain.html#cfn-sagemaker-domain-subnetids
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public dynamic SubnetIds { get; set; }

        /// <summary>
        /// AuthMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-domain.html#cfn-sagemaker-domain-authmode
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AuthMode { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-domain.html#cfn-sagemaker-domain-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// DomainSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-domain.html#cfn-sagemaker-domain-domainsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DomainSettings
        /// </summary>
        public Humidifier.SageMaker.DomainTypes.DomainSettings DomainSettings { get; set; }
        /// <summary>
        /// TagPropagation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-domain.html#cfn-sagemaker-domain-tagpropagation
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TagPropagation { get; set; }
    }

    namespace DomainTypes
    {
        public class AppLifecycleManagement : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// IdleSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-applifecyclemanagement.html#cfn-sagemaker-domain-applifecyclemanagement-idlesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IdleSettings
            /// </summary>
            public Humidifier.SageMaker.DomainTypes.IdleSettings IdleSettings { get; set; }
        }

        public class CodeEditorAppSettings : Humidifier.Base.BaseSubResource, IHaveLifecycleConfigArns, IHaveSageMakerDomainTypesResourceSpecDefaultResourceSpec, IHaveSageMakerDomainTypesAppLifecycleManagementAppLifecycleManagement
        {
            /// <summary>
            /// CustomImages
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-codeeditorappsettings.html#cfn-sagemaker-domain-codeeditorappsettings-customimages
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomImage
            /// </summary>
            public List<Humidifier.SageMaker.DomainTypes.CustomImage> CustomImages { get; set; }
            /// <summary>
            /// DefaultResourceSpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-codeeditorappsettings.html#cfn-sagemaker-domain-codeeditorappsettings-defaultresourcespec
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResourceSpec
            /// </summary>
            public Humidifier.SageMaker.DomainTypes.ResourceSpec DefaultResourceSpec { get; set; }
            /// <summary>
            /// LifecycleConfigArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-codeeditorappsettings.html#cfn-sagemaker-domain-codeeditorappsettings-lifecycleconfigarns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic LifecycleConfigArns { get; set; }
            /// <summary>
            /// AppLifecycleManagement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-codeeditorappsettings.html#cfn-sagemaker-domain-codeeditorappsettings-applifecyclemanagement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AppLifecycleManagement
            /// </summary>
            public Humidifier.SageMaker.DomainTypes.AppLifecycleManagement AppLifecycleManagement { get; set; }
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
            public dynamic RepositoryUrl { get; set; }
        }

        public class CustomFileSystemConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EFSFileSystemConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-customfilesystemconfig.html#cfn-sagemaker-domain-customfilesystemconfig-efsfilesystemconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EFSFileSystemConfig
            /// </summary>
            public Humidifier.SageMaker.DomainTypes.EFSFileSystemConfig EFSFileSystemConfig { get; set; }
            /// <summary>
            /// FSxLustreFileSystemConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-customfilesystemconfig.html#cfn-sagemaker-domain-customfilesystemconfig-fsxlustrefilesystemconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FSxLustreFileSystemConfig
            /// </summary>
            public Humidifier.SageMaker.DomainTypes.FSxLustreFileSystemConfig FSxLustreFileSystemConfig { get; set; }
        }

        public class CustomImage : Humidifier.Base.BaseSubResource, IHaveImageName, IHaveAppImageConfigName, IHaveImageVersionNumber
        {
            /// <summary>
            /// ImageName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-customimage.html#cfn-sagemaker-domain-customimage-imagename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ImageName { get; set; }
            /// <summary>
            /// AppImageConfigName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-customimage.html#cfn-sagemaker-domain-customimage-appimageconfigname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AppImageConfigName { get; set; }
            /// <summary>
            /// ImageVersionNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-customimage.html#cfn-sagemaker-domain-customimage-imageversionnumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ImageVersionNumber { get; set; }
        }

        public class CustomPosixUserConfig : Humidifier.Base.BaseSubResource, IHaveGid, IHaveUid
        {
            /// <summary>
            /// Uid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-customposixuserconfig.html#cfn-sagemaker-domain-customposixuserconfig-uid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Uid { get; set; }
            /// <summary>
            /// Gid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-customposixuserconfig.html#cfn-sagemaker-domain-customposixuserconfig-gid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Gid { get; set; }
        }

        public class DefaultEbsStorageSettings : Humidifier.Base.BaseSubResource, IHaveMaximumEbsVolumeSizeInGb, IHaveDefaultEbsVolumeSizeInGb
        {
            /// <summary>
            /// MaximumEbsVolumeSizeInGb
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-defaultebsstoragesettings.html#cfn-sagemaker-domain-defaultebsstoragesettings-maximumebsvolumesizeingb
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaximumEbsVolumeSizeInGb { get; set; }
            /// <summary>
            /// DefaultEbsVolumeSizeInGb
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-defaultebsstoragesettings.html#cfn-sagemaker-domain-defaultebsstoragesettings-defaultebsvolumesizeingb
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DefaultEbsVolumeSizeInGb { get; set; }
        }

        public class DefaultSpaceSettings : Humidifier.Base.BaseSubResource, IHaveSecurityGroups, IHaveExecutionRole, IHaveSageMakerDomainTypesJupyterLabAppSettingsJupyterLabAppSettings, IHaveSageMakerDomainTypesKernelGatewayAppSettingsKernelGatewayAppSettings, IHaveSageMakerDomainTypesJupyterServerAppSettingsJupyterServerAppSettings, IHaveSageMakerDomainTypesDefaultSpaceStorageSettingsSpaceStorageSettings, IHaveSageMakerDomainTypesCustomPosixUserConfigCustomPosixUserConfig
        {
            /// <summary>
            /// SecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-defaultspacesettings.html#cfn-sagemaker-domain-defaultspacesettings-securitygroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroups { get; set; }
            /// <summary>
            /// JupyterLabAppSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-defaultspacesettings.html#cfn-sagemaker-domain-defaultspacesettings-jupyterlabappsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JupyterLabAppSettings
            /// </summary>
            public Humidifier.SageMaker.DomainTypes.JupyterLabAppSettings JupyterLabAppSettings { get; set; }
            /// <summary>
            /// KernelGatewayAppSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-defaultspacesettings.html#cfn-sagemaker-domain-defaultspacesettings-kernelgatewayappsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KernelGatewayAppSettings
            /// </summary>
            public Humidifier.SageMaker.DomainTypes.KernelGatewayAppSettings KernelGatewayAppSettings { get; set; }
            /// <summary>
            /// JupyterServerAppSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-defaultspacesettings.html#cfn-sagemaker-domain-defaultspacesettings-jupyterserverappsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JupyterServerAppSettings
            /// </summary>
            public Humidifier.SageMaker.DomainTypes.JupyterServerAppSettings JupyterServerAppSettings { get; set; }
            /// <summary>
            /// CustomFileSystemConfigs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-defaultspacesettings.html#cfn-sagemaker-domain-defaultspacesettings-customfilesystemconfigs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomFileSystemConfig
            /// </summary>
            public List<Humidifier.SageMaker.DomainTypes.CustomFileSystemConfig> CustomFileSystemConfigs { get; set; }
            /// <summary>
            /// ExecutionRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-defaultspacesettings.html#cfn-sagemaker-domain-defaultspacesettings-executionrole
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExecutionRole { get; set; }
            /// <summary>
            /// SpaceStorageSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-defaultspacesettings.html#cfn-sagemaker-domain-defaultspacesettings-spacestoragesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultSpaceStorageSettings
            /// </summary>
            public Humidifier.SageMaker.DomainTypes.DefaultSpaceStorageSettings SpaceStorageSettings { get; set; }
            /// <summary>
            /// CustomPosixUserConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-defaultspacesettings.html#cfn-sagemaker-domain-defaultspacesettings-customposixuserconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomPosixUserConfig
            /// </summary>
            public Humidifier.SageMaker.DomainTypes.CustomPosixUserConfig CustomPosixUserConfig { get; set; }
        }

        public class DefaultSpaceStorageSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DefaultEbsStorageSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-defaultspacestoragesettings.html#cfn-sagemaker-domain-defaultspacestoragesettings-defaultebsstoragesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultEbsStorageSettings
            /// </summary>
            public Humidifier.SageMaker.DomainTypes.DefaultEbsStorageSettings DefaultEbsStorageSettings { get; set; }
        }

        public class DockerSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// VpcOnlyTrustedAccounts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-dockersettings.html#cfn-sagemaker-domain-dockersettings-vpconlytrustedaccounts
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic VpcOnlyTrustedAccounts { get; set; }
            /// <summary>
            /// EnableDockerAccess
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-dockersettings.html#cfn-sagemaker-domain-dockersettings-enabledockeraccess
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EnableDockerAccess { get; set; }
        }

        public class DomainSettings : Humidifier.Base.BaseSubResource, IHaveSecurityGroupIds
        {
            /// <summary>
            /// DockerSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-domainsettings.html#cfn-sagemaker-domain-domainsettings-dockersettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DockerSettings
            /// </summary>
            public Humidifier.SageMaker.DomainTypes.DockerSettings DockerSettings { get; set; }
            /// <summary>
            /// ExecutionRoleIdentityConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-domainsettings.html#cfn-sagemaker-domain-domainsettings-executionroleidentityconfig
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExecutionRoleIdentityConfig { get; set; }
            /// <summary>
            /// RStudioServerProDomainSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-domainsettings.html#cfn-sagemaker-domain-domainsettings-rstudioserverprodomainsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RStudioServerProDomainSettings
            /// </summary>
            public Humidifier.SageMaker.DomainTypes.RStudioServerProDomainSettings RStudioServerProDomainSettings { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-domainsettings.html#cfn-sagemaker-domain-domainsettings-securitygroupids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroupIds { get; set; }
        }

        public class EFSFileSystemConfig : Humidifier.Base.BaseSubResource, IHaveFileSystemId, IHaveFileSystemPath
        {
            /// <summary>
            /// FileSystemPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-efsfilesystemconfig.html#cfn-sagemaker-domain-efsfilesystemconfig-filesystempath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FileSystemPath { get; set; }
            /// <summary>
            /// FileSystemId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-efsfilesystemconfig.html#cfn-sagemaker-domain-efsfilesystemconfig-filesystemid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FileSystemId { get; set; }
        }

        public class FSxLustreFileSystemConfig : Humidifier.Base.BaseSubResource, IHaveFileSystemId, IHaveFileSystemPath
        {
            /// <summary>
            /// FileSystemPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-fsxlustrefilesystemconfig.html#cfn-sagemaker-domain-fsxlustrefilesystemconfig-filesystempath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FileSystemPath { get; set; }
            /// <summary>
            /// FileSystemId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-fsxlustrefilesystemconfig.html#cfn-sagemaker-domain-fsxlustrefilesystemconfig-filesystemid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FileSystemId { get; set; }
        }

        public class IdleSettings : Humidifier.Base.BaseSubResource, IHaveIdleTimeoutInMinutes, IHaveMaxIdleTimeoutInMinutes, IHaveMinIdleTimeoutInMinutes, IHaveLifecycleManagement
        {
            /// <summary>
            /// MaxIdleTimeoutInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-idlesettings.html#cfn-sagemaker-domain-idlesettings-maxidletimeoutinminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxIdleTimeoutInMinutes { get; set; }
            /// <summary>
            /// IdleTimeoutInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-idlesettings.html#cfn-sagemaker-domain-idlesettings-idletimeoutinminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic IdleTimeoutInMinutes { get; set; }
            /// <summary>
            /// MinIdleTimeoutInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-idlesettings.html#cfn-sagemaker-domain-idlesettings-minidletimeoutinminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinIdleTimeoutInMinutes { get; set; }
            /// <summary>
            /// LifecycleManagement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-idlesettings.html#cfn-sagemaker-domain-idlesettings-lifecyclemanagement
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LifecycleManagement { get; set; }
        }

        public class JupyterLabAppSettings : Humidifier.Base.BaseSubResource, IHaveLifecycleConfigArns, IHaveSageMakerDomainTypesResourceSpecDefaultResourceSpec, IHaveSageMakerDomainTypesAppLifecycleManagementAppLifecycleManagement
        {
            /// <summary>
            /// CustomImages
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-jupyterlabappsettings.html#cfn-sagemaker-domain-jupyterlabappsettings-customimages
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomImage
            /// </summary>
            public List<Humidifier.SageMaker.DomainTypes.CustomImage> CustomImages { get; set; }
            /// <summary>
            /// DefaultResourceSpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-jupyterlabappsettings.html#cfn-sagemaker-domain-jupyterlabappsettings-defaultresourcespec
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResourceSpec
            /// </summary>
            public Humidifier.SageMaker.DomainTypes.ResourceSpec DefaultResourceSpec { get; set; }
            /// <summary>
            /// LifecycleConfigArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-jupyterlabappsettings.html#cfn-sagemaker-domain-jupyterlabappsettings-lifecycleconfigarns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic LifecycleConfigArns { get; set; }
            /// <summary>
            /// CodeRepositories
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-jupyterlabappsettings.html#cfn-sagemaker-domain-jupyterlabappsettings-coderepositories
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CodeRepository
            /// </summary>
            public List<Humidifier.SageMaker.DomainTypes.CodeRepository> CodeRepositories { get; set; }
            /// <summary>
            /// AppLifecycleManagement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-jupyterlabappsettings.html#cfn-sagemaker-domain-jupyterlabappsettings-applifecyclemanagement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AppLifecycleManagement
            /// </summary>
            public Humidifier.SageMaker.DomainTypes.AppLifecycleManagement AppLifecycleManagement { get; set; }
        }

        public class JupyterServerAppSettings : Humidifier.Base.BaseSubResource, IHaveLifecycleConfigArns, IHaveSageMakerDomainTypesResourceSpecDefaultResourceSpec
        {
            /// <summary>
            /// DefaultResourceSpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-jupyterserverappsettings.html#cfn-sagemaker-domain-jupyterserverappsettings-defaultresourcespec
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResourceSpec
            /// </summary>
            public Humidifier.SageMaker.DomainTypes.ResourceSpec DefaultResourceSpec { get; set; }
            /// <summary>
            /// LifecycleConfigArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-jupyterserverappsettings.html#cfn-sagemaker-domain-jupyterserverappsettings-lifecycleconfigarns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic LifecycleConfigArns { get; set; }
        }

        public class KernelGatewayAppSettings : Humidifier.Base.BaseSubResource, IHaveLifecycleConfigArns, IHaveSageMakerDomainTypesResourceSpecDefaultResourceSpec
        {
            /// <summary>
            /// CustomImages
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-kernelgatewayappsettings.html#cfn-sagemaker-domain-kernelgatewayappsettings-customimages
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomImage
            /// </summary>
            public List<Humidifier.SageMaker.DomainTypes.CustomImage> CustomImages { get; set; }
            /// <summary>
            /// DefaultResourceSpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-kernelgatewayappsettings.html#cfn-sagemaker-domain-kernelgatewayappsettings-defaultresourcespec
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResourceSpec
            /// </summary>
            public Humidifier.SageMaker.DomainTypes.ResourceSpec DefaultResourceSpec { get; set; }
            /// <summary>
            /// LifecycleConfigArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-kernelgatewayappsettings.html#cfn-sagemaker-domain-kernelgatewayappsettings-lifecycleconfigarns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic LifecycleConfigArns { get; set; }
        }

        public class RSessionAppSettings : Humidifier.Base.BaseSubResource, IHaveSageMakerDomainTypesResourceSpecDefaultResourceSpec
        {
            /// <summary>
            /// CustomImages
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-rsessionappsettings.html#cfn-sagemaker-domain-rsessionappsettings-customimages
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomImage
            /// </summary>
            public List<Humidifier.SageMaker.DomainTypes.CustomImage> CustomImages { get; set; }
            /// <summary>
            /// DefaultResourceSpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-rsessionappsettings.html#cfn-sagemaker-domain-rsessionappsettings-defaultresourcespec
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResourceSpec
            /// </summary>
            public Humidifier.SageMaker.DomainTypes.ResourceSpec DefaultResourceSpec { get; set; }
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
            public dynamic AccessStatus { get; set; }
            /// <summary>
            /// UserGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-rstudioserverproappsettings.html#cfn-sagemaker-domain-rstudioserverproappsettings-usergroup
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UserGroup { get; set; }
        }

        public class RStudioServerProDomainSettings : Humidifier.Base.BaseSubResource, IHaveSageMakerDomainTypesResourceSpecDefaultResourceSpec
        {
            /// <summary>
            /// DomainExecutionRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-rstudioserverprodomainsettings.html#cfn-sagemaker-domain-rstudioserverprodomainsettings-domainexecutionrolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DomainExecutionRoleArn { get; set; }
            /// <summary>
            /// RStudioConnectUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-rstudioserverprodomainsettings.html#cfn-sagemaker-domain-rstudioserverprodomainsettings-rstudioconnecturl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RStudioConnectUrl { get; set; }
            /// <summary>
            /// DefaultResourceSpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-rstudioserverprodomainsettings.html#cfn-sagemaker-domain-rstudioserverprodomainsettings-defaultresourcespec
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ResourceSpec
            /// </summary>
            public Humidifier.SageMaker.DomainTypes.ResourceSpec DefaultResourceSpec { get; set; }
            /// <summary>
            /// RStudioPackageManagerUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-rstudioserverprodomainsettings.html#cfn-sagemaker-domain-rstudioserverprodomainsettings-rstudiopackagemanagerurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RStudioPackageManagerUrl { get; set; }
        }

        public class ResourceSpec : Humidifier.Base.BaseSubResource, IHaveInstanceType, IHaveLifecycleConfigArn, IHaveSageMakerImageArn, IHaveSageMakerImageVersionArn
        {
            /// <summary>
            /// SageMakerImageArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-resourcespec.html#cfn-sagemaker-domain-resourcespec-sagemakerimagearn
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic SageMakerImageArn { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-resourcespec.html#cfn-sagemaker-domain-resourcespec-instancetype
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic InstanceType { get; set; }
            /// <summary>
            /// LifecycleConfigArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-resourcespec.html#cfn-sagemaker-domain-resourcespec-lifecycleconfigarn
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic LifecycleConfigArn { get; set; }
            /// <summary>
            /// SageMakerImageVersionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-resourcespec.html#cfn-sagemaker-domain-resourcespec-sagemakerimageversionarn
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic SageMakerImageVersionArn { get; set; }
        }

        public class SharingSettings : Humidifier.Base.BaseSubResource, IHaveS3OutputPath, IHaveNotebookOutputOption, IHaveS3KmsKeyId
        {
            /// <summary>
            /// NotebookOutputOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-sharingsettings.html#cfn-sagemaker-domain-sharingsettings-notebookoutputoption
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NotebookOutputOption { get; set; }
            /// <summary>
            /// S3KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-sharingsettings.html#cfn-sagemaker-domain-sharingsettings-s3kmskeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3KmsKeyId { get; set; }
            /// <summary>
            /// S3OutputPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-sharingsettings.html#cfn-sagemaker-domain-sharingsettings-s3outputpath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3OutputPath { get; set; }
        }

        public class StudioWebPortalSettings : Humidifier.Base.BaseSubResource, IHaveHiddenAppTypes, IHaveHiddenMlTools
        {
            /// <summary>
            /// HiddenAppTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-studiowebportalsettings.html#cfn-sagemaker-domain-studiowebportalsettings-hiddenapptypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic HiddenAppTypes { get; set; }
            /// <summary>
            /// HiddenMlTools
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-studiowebportalsettings.html#cfn-sagemaker-domain-studiowebportalsettings-hiddenmltools
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic HiddenMlTools { get; set; }
        }

        public class UserSettings : Humidifier.Base.BaseSubResource, IHaveSecurityGroups, IHaveExecutionRole, IHaveSageMakerDomainTypesJupyterLabAppSettingsJupyterLabAppSettings, IHaveSageMakerDomainTypesKernelGatewayAppSettingsKernelGatewayAppSettings, IHaveSageMakerDomainTypesJupyterServerAppSettingsJupyterServerAppSettings, IHaveSageMakerDomainTypesDefaultSpaceStorageSettingsSpaceStorageSettings, IHaveSageMakerDomainTypesCustomPosixUserConfigCustomPosixUserConfig, IHaveStudioWebPortal, IHaveDefaultLandingUri
        {
            /// <summary>
            /// SecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-usersettings.html#cfn-sagemaker-domain-usersettings-securitygroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroups { get; set; }
            /// <summary>
            /// JupyterLabAppSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-usersettings.html#cfn-sagemaker-domain-usersettings-jupyterlabappsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JupyterLabAppSettings
            /// </summary>
            public Humidifier.SageMaker.DomainTypes.JupyterLabAppSettings JupyterLabAppSettings { get; set; }
            /// <summary>
            /// KernelGatewayAppSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-usersettings.html#cfn-sagemaker-domain-usersettings-kernelgatewayappsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KernelGatewayAppSettings
            /// </summary>
            public Humidifier.SageMaker.DomainTypes.KernelGatewayAppSettings KernelGatewayAppSettings { get; set; }
            /// <summary>
            /// StudioWebPortalSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-usersettings.html#cfn-sagemaker-domain-usersettings-studiowebportalsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StudioWebPortalSettings
            /// </summary>
            public Humidifier.SageMaker.DomainTypes.StudioWebPortalSettings StudioWebPortalSettings { get; set; }
            /// <summary>
            /// CustomFileSystemConfigs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-usersettings.html#cfn-sagemaker-domain-usersettings-customfilesystemconfigs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomFileSystemConfig
            /// </summary>
            public List<Humidifier.SageMaker.DomainTypes.CustomFileSystemConfig> CustomFileSystemConfigs { get; set; }
            /// <summary>
            /// CustomPosixUserConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-usersettings.html#cfn-sagemaker-domain-usersettings-customposixuserconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomPosixUserConfig
            /// </summary>
            public Humidifier.SageMaker.DomainTypes.CustomPosixUserConfig CustomPosixUserConfig { get; set; }
            /// <summary>
            /// CodeEditorAppSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-usersettings.html#cfn-sagemaker-domain-usersettings-codeeditorappsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CodeEditorAppSettings
            /// </summary>
            public Humidifier.SageMaker.DomainTypes.CodeEditorAppSettings CodeEditorAppSettings { get; set; }
            /// <summary>
            /// RStudioServerProAppSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-usersettings.html#cfn-sagemaker-domain-usersettings-rstudioserverproappsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RStudioServerProAppSettings
            /// </summary>
            public Humidifier.SageMaker.DomainTypes.RStudioServerProAppSettings RStudioServerProAppSettings { get; set; }
            /// <summary>
            /// StudioWebPortal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-usersettings.html#cfn-sagemaker-domain-usersettings-studiowebportal
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StudioWebPortal { get; set; }
            /// <summary>
            /// RSessionAppSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-usersettings.html#cfn-sagemaker-domain-usersettings-rsessionappsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RSessionAppSettings
            /// </summary>
            public Humidifier.SageMaker.DomainTypes.RSessionAppSettings RSessionAppSettings { get; set; }
            /// <summary>
            /// JupyterServerAppSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-usersettings.html#cfn-sagemaker-domain-usersettings-jupyterserverappsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JupyterServerAppSettings
            /// </summary>
            public Humidifier.SageMaker.DomainTypes.JupyterServerAppSettings JupyterServerAppSettings { get; set; }
            /// <summary>
            /// DefaultLandingUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-usersettings.html#cfn-sagemaker-domain-usersettings-defaultlandinguri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DefaultLandingUri { get; set; }
            /// <summary>
            /// ExecutionRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-usersettings.html#cfn-sagemaker-domain-usersettings-executionrole
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExecutionRole { get; set; }
            /// <summary>
            /// SpaceStorageSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-usersettings.html#cfn-sagemaker-domain-usersettings-spacestoragesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultSpaceStorageSettings
            /// </summary>
            public Humidifier.SageMaker.DomainTypes.DefaultSpaceStorageSettings SpaceStorageSettings { get; set; }
            /// <summary>
            /// SharingSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-domain-usersettings.html#cfn-sagemaker-domain-usersettings-sharingsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SharingSettings
            /// </summary>
            public Humidifier.SageMaker.DomainTypes.SharingSettings SharingSettings { get; set; }
        }
    }
}