namespace Humidifier.SageMaker
{
    using System.Collections.Generic;
    using SpaceTypes;

    public class Space : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags
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
        public dynamic DomainId { get; set; }
        public dynamic SpaceName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// SpaceSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-space.html#cfn-sagemaker-space-spacesettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SpaceSettings
        /// </summary>
        public SpaceTypes.SpaceSettings SpaceSettings { get; set; }
        /// <summary>
        /// SpaceDisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-space.html#cfn-sagemaker-space-spacedisplayname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SpaceDisplayName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-space.html#cfn-sagemaker-space-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// SpaceSharingSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-space.html#cfn-sagemaker-space-spacesharingsettings
        /// Required: False
        /// UpdateType: Immutable
        /// Type: SpaceSharingSettings
        /// </summary>
        public SpaceTypes.SpaceSharingSettings SpaceSharingSettings { get; set; }
        /// <summary>
        /// OwnershipSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-space.html#cfn-sagemaker-space-ownershipsettings
        /// Required: False
        /// UpdateType: Immutable
        /// Type: OwnershipSettings
        /// </summary>
        public SpaceTypes.OwnershipSettings OwnershipSettings { get; set; }
    }

    namespace SpaceTypes
    {
        public class CodeRepository : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RepositoryUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-coderepository.html#cfn-sagemaker-space-coderepository-repositoryurl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RepositoryUrl { get; set; }
        }

        public class CustomFileSystem : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EFSFileSystem
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-customfilesystem.html#cfn-sagemaker-space-customfilesystem-efsfilesystem
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EFSFileSystem
            /// </summary>
            public SpaceTypes.EFSFileSystem EFSFileSystem { get; set; }
        }

        public class CustomImage : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ImageName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-customimage.html#cfn-sagemaker-space-customimage-imagename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ImageName { get; set; }
            /// <summary>
            /// AppImageConfigName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-customimage.html#cfn-sagemaker-space-customimage-appimageconfigname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AppImageConfigName { get; set; }
            /// <summary>
            /// ImageVersionNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-customimage.html#cfn-sagemaker-space-customimage-imageversionnumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ImageVersionNumber { get; set; }
        }

        public class EFSFileSystem : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FileSystemId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-efsfilesystem.html#cfn-sagemaker-space-efsfilesystem-filesystemid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FileSystemId { get; set; }
        }

        public class EbsStorageSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EbsVolumeSizeInGb
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-ebsstoragesettings.html#cfn-sagemaker-space-ebsstoragesettings-ebsvolumesizeingb
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic EbsVolumeSizeInGb { get; set; }
        }

        public class JupyterServerAppSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DefaultResourceSpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-jupyterserverappsettings.html#cfn-sagemaker-space-jupyterserverappsettings-defaultresourcespec
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResourceSpec
            /// </summary>
            public SpaceTypes.ResourceSpec DefaultResourceSpec { get; set; }
        }

        public class KernelGatewayAppSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CustomImages
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-kernelgatewayappsettings.html#cfn-sagemaker-space-kernelgatewayappsettings-customimages
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomImage
            /// </summary>
            public List<SpaceTypes.CustomImage> CustomImages { get; set; }
            /// <summary>
            /// DefaultResourceSpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-kernelgatewayappsettings.html#cfn-sagemaker-space-kernelgatewayappsettings-defaultresourcespec
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResourceSpec
            /// </summary>
            public SpaceTypes.ResourceSpec DefaultResourceSpec { get; set; }
        }

        public class OwnershipSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// OwnerUserProfileName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-ownershipsettings.html#cfn-sagemaker-space-ownershipsettings-owneruserprofilename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OwnerUserProfileName { get; set; }
        }

        public class ResourceSpec : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SageMakerImageArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-resourcespec.html#cfn-sagemaker-space-resourcespec-sagemakerimagearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SageMakerImageArn { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-resourcespec.html#cfn-sagemaker-space-resourcespec-instancetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InstanceType { get; set; }
            /// <summary>
            /// SageMakerImageVersionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-resourcespec.html#cfn-sagemaker-space-resourcespec-sagemakerimageversionarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SageMakerImageVersionArn { get; set; }
        }

        public class SpaceCodeEditorAppSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DefaultResourceSpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-spacecodeeditorappsettings.html#cfn-sagemaker-space-spacecodeeditorappsettings-defaultresourcespec
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResourceSpec
            /// </summary>
            public SpaceTypes.ResourceSpec DefaultResourceSpec { get; set; }
        }

        public class SpaceJupyterLabAppSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DefaultResourceSpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-spacejupyterlabappsettings.html#cfn-sagemaker-space-spacejupyterlabappsettings-defaultresourcespec
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResourceSpec
            /// </summary>
            public SpaceTypes.ResourceSpec DefaultResourceSpec { get; set; }
            /// <summary>
            /// CodeRepositories
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-spacejupyterlabappsettings.html#cfn-sagemaker-space-spacejupyterlabappsettings-coderepositories
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CodeRepository
            /// </summary>
            public List<SpaceTypes.CodeRepository> CodeRepositories { get; set; }
        }

        public class SpaceSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// JupyterLabAppSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-spacesettings.html#cfn-sagemaker-space-spacesettings-jupyterlabappsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SpaceJupyterLabAppSettings
            /// </summary>
            public SpaceTypes.SpaceJupyterLabAppSettings JupyterLabAppSettings { get; set; }
            /// <summary>
            /// KernelGatewayAppSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-spacesettings.html#cfn-sagemaker-space-spacesettings-kernelgatewayappsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KernelGatewayAppSettings
            /// </summary>
            public SpaceTypes.KernelGatewayAppSettings KernelGatewayAppSettings { get; set; }
            /// <summary>
            /// CodeEditorAppSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-spacesettings.html#cfn-sagemaker-space-spacesettings-codeeditorappsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SpaceCodeEditorAppSettings
            /// </summary>
            public SpaceTypes.SpaceCodeEditorAppSettings CodeEditorAppSettings { get; set; }
            /// <summary>
            /// JupyterServerAppSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-spacesettings.html#cfn-sagemaker-space-spacesettings-jupyterserverappsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JupyterServerAppSettings
            /// </summary>
            public SpaceTypes.JupyterServerAppSettings JupyterServerAppSettings { get; set; }
            /// <summary>
            /// CustomFileSystems
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-spacesettings.html#cfn-sagemaker-space-spacesettings-customfilesystems
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomFileSystem
            /// </summary>
            public List<SpaceTypes.CustomFileSystem> CustomFileSystems { get; set; }
            /// <summary>
            /// AppType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-spacesettings.html#cfn-sagemaker-space-spacesettings-apptype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AppType { get; set; }
            /// <summary>
            /// SpaceStorageSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-spacesettings.html#cfn-sagemaker-space-spacesettings-spacestoragesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SpaceStorageSettings
            /// </summary>
            public SpaceTypes.SpaceStorageSettings SpaceStorageSettings { get; set; }
        }

        public class SpaceSharingSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SharingType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-spacesharingsettings.html#cfn-sagemaker-space-spacesharingsettings-sharingtype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SharingType { get; set; }
        }

        public class SpaceStorageSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EbsStorageSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-space-spacestoragesettings.html#cfn-sagemaker-space-spacestoragesettings-ebsstoragesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EbsStorageSettings
            /// </summary>
            public SpaceTypes.EbsStorageSettings EbsStorageSettings { get; set; }
        }
    }
}