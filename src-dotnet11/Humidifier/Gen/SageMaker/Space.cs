namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using SpaceTypes;

    public class Space : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDomainId, IHaveSpaceName, IHaveSageMakerSpaceTypesSpaceSettingsSpaceSettings, IHaveSpaceDisplayName, IHaveSageMakerSpaceTypesSpaceSharingSettingsSpaceSharingSettings, IHaveSageMakerSpaceTypesOwnershipSettingsOwnershipSettings
    {
        public class Attributes
        {
            public static string SpaceArn =  "SpaceArn" ;
            public static string Url =  "Url" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.Space; }

        /// <summary>
        /// DomainId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-space.html#cfn-sagemaker-space-domainid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DomainId { get; set; }
        public Union<string, BaseFunction>? SpaceName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// SpaceSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-space.html#cfn-sagemaker-space-spacesettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SpaceSettings
        /// </summary>
        public Union<Humidifier.SageMaker.SpaceTypes.SpaceSettings, BaseFunction>? SpaceSettings { get; set; }
        /// <summary>
        /// SpaceDisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-space.html#cfn-sagemaker-space-spacedisplayname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SpaceDisplayName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-space.html#cfn-sagemaker-space-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// SpaceSharingSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-space.html#cfn-sagemaker-space-spacesharingsettings
        /// Required: False
        /// UpdateType: Immutable
        /// Type: SpaceSharingSettings
        /// </summary>
        public Union<Humidifier.SageMaker.SpaceTypes.SpaceSharingSettings, BaseFunction>? SpaceSharingSettings { get; set; }
        /// <summary>
        /// OwnershipSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-space.html#cfn-sagemaker-space-ownershipsettings
        /// Required: False
        /// UpdateType: Immutable
        /// Type: OwnershipSettings
        /// </summary>
        public Union<Humidifier.SageMaker.SpaceTypes.OwnershipSettings, BaseFunction>? OwnershipSettings { get; set; }
    }

    namespace SpaceTypes
    {
        public class CodeRepository : Humidifier.Base.BaseSubResource, IHaveRepositoryUrl
        {
            /// <summary>
            /// RepositoryUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-coderepository.html#cfn-sagemaker-space-coderepository-repositoryurl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RepositoryUrl { get; set; }
        }

        public class CustomFileSystem : Humidifier.Base.BaseSubResource, IHaveSageMakerSpaceTypesFSxLustreFileSystemFSxLustreFileSystem, IHaveSageMakerSpaceTypesEFSFileSystemEFSFileSystem, IHaveSageMakerSpaceTypesS3FileSystemS3FileSystem
        {
            /// <summary>
            /// FSxLustreFileSystem
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-customfilesystem.html#cfn-sagemaker-space-customfilesystem-fsxlustrefilesystem
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FSxLustreFileSystem
            /// </summary>
            public Union<Humidifier.SageMaker.SpaceTypes.FSxLustreFileSystem, BaseFunction>? FSxLustreFileSystem { get; set; }
            /// <summary>
            /// EFSFileSystem
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-customfilesystem.html#cfn-sagemaker-space-customfilesystem-efsfilesystem
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EFSFileSystem
            /// </summary>
            public Union<Humidifier.SageMaker.SpaceTypes.EFSFileSystem, BaseFunction>? EFSFileSystem { get; set; }
            /// <summary>
            /// S3FileSystem
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-customfilesystem.html#cfn-sagemaker-space-customfilesystem-s3filesystem
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3FileSystem
            /// </summary>
            public Union<Humidifier.SageMaker.SpaceTypes.S3FileSystem, BaseFunction>? S3FileSystem { get; set; }
        }

        public class CustomImage : Humidifier.Base.BaseSubResource, IHaveImageName, IHaveAppImageConfigName, IHaveImageVersionNumber_Integer
        {
            /// <summary>
            /// ImageName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-customimage.html#cfn-sagemaker-space-customimage-imagename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImageName { get; set; }
            /// <summary>
            /// AppImageConfigName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-customimage.html#cfn-sagemaker-space-customimage-appimageconfigname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AppImageConfigName { get; set; }
            /// <summary>
            /// ImageVersionNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-customimage.html#cfn-sagemaker-space-customimage-imageversionnumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ImageVersionNumber { get; set; }
        }

        public class EFSFileSystem : Humidifier.Base.BaseSubResource, IHaveFileSystemId
        {
            /// <summary>
            /// FileSystemId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-efsfilesystem.html#cfn-sagemaker-space-efsfilesystem-filesystemid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FileSystemId { get; set; }
        }

        public class EbsStorageSettings : Humidifier.Base.BaseSubResource, IHaveEbsVolumeSizeInGb_Integer
        {
            /// <summary>
            /// EbsVolumeSizeInGb
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-ebsstoragesettings.html#cfn-sagemaker-space-ebsstoragesettings-ebsvolumesizeingb
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? EbsVolumeSizeInGb { get; set; }
        }

        public class FSxLustreFileSystem : Humidifier.Base.BaseSubResource, IHaveFileSystemId
        {
            /// <summary>
            /// FileSystemId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-fsxlustrefilesystem.html#cfn-sagemaker-space-fsxlustrefilesystem-filesystemid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FileSystemId { get; set; }
        }

        public class JupyterServerAppSettings : Humidifier.Base.BaseSubResource, IHaveSageMakerSpaceTypesResourceSpecDefaultResourceSpec, IHaveStringListOfLifecycleConfigArns
        {
            /// <summary>
            /// DefaultResourceSpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-jupyterserverappsettings.html#cfn-sagemaker-space-jupyterserverappsettings-defaultresourcespec
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResourceSpec
            /// </summary>
            public Union<Humidifier.SageMaker.SpaceTypes.ResourceSpec, BaseFunction>? DefaultResourceSpec { get; set; }
            /// <summary>
            /// LifecycleConfigArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-jupyterserverappsettings.html#cfn-sagemaker-space-jupyterserverappsettings-lifecycleconfigarns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LifecycleConfigArns { get; set; }
        }

        public class KernelGatewayAppSettings : Humidifier.Base.BaseSubResource, IHaveListOfSageMakerSpaceTypesCustomImageCustomImages, IHaveSageMakerSpaceTypesResourceSpecDefaultResourceSpec, IHaveStringListOfLifecycleConfigArns
        {
            /// <summary>
            /// CustomImages
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-kernelgatewayappsettings.html#cfn-sagemaker-space-kernelgatewayappsettings-customimages
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomImage
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.SpaceTypes.CustomImage>, IReadOnlyList<Union<Humidifier.SageMaker.SpaceTypes.CustomImage, BaseFunction>>, BaseFunction>? CustomImages { get; set; }
            /// <summary>
            /// DefaultResourceSpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-kernelgatewayappsettings.html#cfn-sagemaker-space-kernelgatewayappsettings-defaultresourcespec
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResourceSpec
            /// </summary>
            public Union<Humidifier.SageMaker.SpaceTypes.ResourceSpec, BaseFunction>? DefaultResourceSpec { get; set; }
            /// <summary>
            /// LifecycleConfigArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-kernelgatewayappsettings.html#cfn-sagemaker-space-kernelgatewayappsettings-lifecycleconfigarns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LifecycleConfigArns { get; set; }
        }

        public class OwnershipSettings : Humidifier.Base.BaseSubResource, IHaveOwnerUserProfileName
        {
            /// <summary>
            /// OwnerUserProfileName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-ownershipsettings.html#cfn-sagemaker-space-ownershipsettings-owneruserprofilename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OwnerUserProfileName { get; set; }
        }

        public class ResourceSpec : Humidifier.Base.BaseSubResource, IHaveSageMakerImageArn, IHaveInstanceType, IHaveLifecycleConfigArn, IHaveSageMakerImageVersionArn
        {
            /// <summary>
            /// SageMakerImageArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-resourcespec.html#cfn-sagemaker-space-resourcespec-sagemakerimagearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SageMakerImageArn { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-resourcespec.html#cfn-sagemaker-space-resourcespec-instancetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceType { get; set; }
            /// <summary>
            /// LifecycleConfigArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-resourcespec.html#cfn-sagemaker-space-resourcespec-lifecycleconfigarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LifecycleConfigArn { get; set; }
            /// <summary>
            /// SageMakerImageVersionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-resourcespec.html#cfn-sagemaker-space-resourcespec-sagemakerimageversionarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SageMakerImageVersionArn { get; set; }
        }

        public class S3FileSystem : Humidifier.Base.BaseSubResource, IHaveS3Uri
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-s3filesystem.html#cfn-sagemaker-space-s3filesystem-s3uri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
        }

        public class SpaceAppLifecycleManagement : Humidifier.Base.BaseSubResource, IHaveSageMakerSpaceTypesSpaceIdleSettingsIdleSettings
        {
            /// <summary>
            /// IdleSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-spaceapplifecyclemanagement.html#cfn-sagemaker-space-spaceapplifecyclemanagement-idlesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SpaceIdleSettings
            /// </summary>
            public Union<Humidifier.SageMaker.SpaceTypes.SpaceIdleSettings, BaseFunction>? IdleSettings { get; set; }
        }

        public class SpaceCodeEditorAppSettings : Humidifier.Base.BaseSubResource, IHaveSageMakerSpaceTypesResourceSpecDefaultResourceSpec, IHaveSageMakerSpaceTypesSpaceAppLifecycleManagementAppLifecycleManagement
        {
            /// <summary>
            /// DefaultResourceSpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-spacecodeeditorappsettings.html#cfn-sagemaker-space-spacecodeeditorappsettings-defaultresourcespec
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResourceSpec
            /// </summary>
            public Union<Humidifier.SageMaker.SpaceTypes.ResourceSpec, BaseFunction>? DefaultResourceSpec { get; set; }
            /// <summary>
            /// AppLifecycleManagement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-spacecodeeditorappsettings.html#cfn-sagemaker-space-spacecodeeditorappsettings-applifecyclemanagement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SpaceAppLifecycleManagement
            /// </summary>
            public Union<Humidifier.SageMaker.SpaceTypes.SpaceAppLifecycleManagement, BaseFunction>? AppLifecycleManagement { get; set; }
        }

        public class SpaceIdleSettings : Humidifier.Base.BaseSubResource, IHaveIdleTimeoutInMinutes_Integer
        {
            /// <summary>
            /// IdleTimeoutInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-spaceidlesettings.html#cfn-sagemaker-space-spaceidlesettings-idletimeoutinminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? IdleTimeoutInMinutes { get; set; }
        }

        public class SpaceJupyterLabAppSettings : Humidifier.Base.BaseSubResource, IHaveSageMakerSpaceTypesResourceSpecDefaultResourceSpec, IHaveListOfSageMakerSpaceTypesCodeRepositoryCodeRepositories, IHaveSageMakerSpaceTypesSpaceAppLifecycleManagementAppLifecycleManagement
        {
            /// <summary>
            /// DefaultResourceSpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-spacejupyterlabappsettings.html#cfn-sagemaker-space-spacejupyterlabappsettings-defaultresourcespec
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResourceSpec
            /// </summary>
            public Union<Humidifier.SageMaker.SpaceTypes.ResourceSpec, BaseFunction>? DefaultResourceSpec { get; set; }
            /// <summary>
            /// CodeRepositories
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-spacejupyterlabappsettings.html#cfn-sagemaker-space-spacejupyterlabappsettings-coderepositories
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CodeRepository
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.SpaceTypes.CodeRepository>, IReadOnlyList<Union<Humidifier.SageMaker.SpaceTypes.CodeRepository, BaseFunction>>, BaseFunction>? CodeRepositories { get; set; }
            /// <summary>
            /// AppLifecycleManagement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-spacejupyterlabappsettings.html#cfn-sagemaker-space-spacejupyterlabappsettings-applifecyclemanagement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SpaceAppLifecycleManagement
            /// </summary>
            public Union<Humidifier.SageMaker.SpaceTypes.SpaceAppLifecycleManagement, BaseFunction>? AppLifecycleManagement { get; set; }
        }

        public class SpaceSettings : Humidifier.Base.BaseSubResource, IHaveSageMakerSpaceTypesSpaceJupyterLabAppSettingsJupyterLabAppSettings, IHaveSageMakerSpaceTypesKernelGatewayAppSettingsKernelGatewayAppSettings, IHaveSageMakerSpaceTypesSpaceCodeEditorAppSettingsCodeEditorAppSettings, IHaveSpaceManagedResources, IHaveRemoteAccess, IHaveSageMakerSpaceTypesJupyterServerAppSettingsJupyterServerAppSettings, IHaveListOfSageMakerSpaceTypesCustomFileSystemCustomFileSystems, IHaveAppType, IHaveSageMakerSpaceTypesSpaceStorageSettingsSpaceStorageSettings
        {
            /// <summary>
            /// JupyterLabAppSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-spacesettings.html#cfn-sagemaker-space-spacesettings-jupyterlabappsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SpaceJupyterLabAppSettings
            /// </summary>
            public Union<Humidifier.SageMaker.SpaceTypes.SpaceJupyterLabAppSettings, BaseFunction>? JupyterLabAppSettings { get; set; }
            /// <summary>
            /// KernelGatewayAppSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-spacesettings.html#cfn-sagemaker-space-spacesettings-kernelgatewayappsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KernelGatewayAppSettings
            /// </summary>
            public Union<Humidifier.SageMaker.SpaceTypes.KernelGatewayAppSettings, BaseFunction>? KernelGatewayAppSettings { get; set; }
            /// <summary>
            /// CodeEditorAppSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-spacesettings.html#cfn-sagemaker-space-spacesettings-codeeditorappsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SpaceCodeEditorAppSettings
            /// </summary>
            public Union<Humidifier.SageMaker.SpaceTypes.SpaceCodeEditorAppSettings, BaseFunction>? CodeEditorAppSettings { get; set; }
            /// <summary>
            /// SpaceManagedResources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-spacesettings.html#cfn-sagemaker-space-spacesettings-spacemanagedresources
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SpaceManagedResources { get; set; }
            /// <summary>
            /// RemoteAccess
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-spacesettings.html#cfn-sagemaker-space-spacesettings-remoteaccess
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RemoteAccess { get; set; }
            /// <summary>
            /// JupyterServerAppSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-spacesettings.html#cfn-sagemaker-space-spacesettings-jupyterserverappsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JupyterServerAppSettings
            /// </summary>
            public Union<Humidifier.SageMaker.SpaceTypes.JupyterServerAppSettings, BaseFunction>? JupyterServerAppSettings { get; set; }
            /// <summary>
            /// CustomFileSystems
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-spacesettings.html#cfn-sagemaker-space-spacesettings-customfilesystems
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomFileSystem
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.SpaceTypes.CustomFileSystem>, IReadOnlyList<Union<Humidifier.SageMaker.SpaceTypes.CustomFileSystem, BaseFunction>>, BaseFunction>? CustomFileSystems { get; set; }
            /// <summary>
            /// AppType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-spacesettings.html#cfn-sagemaker-space-spacesettings-apptype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AppType { get; set; }
            /// <summary>
            /// SpaceStorageSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-spacesettings.html#cfn-sagemaker-space-spacesettings-spacestoragesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SpaceStorageSettings
            /// </summary>
            public Union<Humidifier.SageMaker.SpaceTypes.SpaceStorageSettings, BaseFunction>? SpaceStorageSettings { get; set; }
        }

        public class SpaceSharingSettings : Humidifier.Base.BaseSubResource, IHaveSharingType
        {
            /// <summary>
            /// SharingType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-spacesharingsettings.html#cfn-sagemaker-space-spacesharingsettings-sharingtype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SharingType { get; set; }
        }

        public class SpaceStorageSettings : Humidifier.Base.BaseSubResource, IHaveSageMakerSpaceTypesEbsStorageSettingsEbsStorageSettings
        {
            /// <summary>
            /// EbsStorageSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-spacestoragesettings.html#cfn-sagemaker-space-spacestoragesettings-ebsstoragesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EbsStorageSettings
            /// </summary>
            public Union<Humidifier.SageMaker.SpaceTypes.EbsStorageSettings, BaseFunction>? EbsStorageSettings { get; set; }
        }
    }
}