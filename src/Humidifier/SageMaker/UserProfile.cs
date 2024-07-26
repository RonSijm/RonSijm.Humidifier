namespace Humidifier.SageMaker
{
    using System.Collections.Generic;
    using UserProfileTypes;

    public class UserProfile : Humidifier.Resource, IHaveTags
    {
        public class Attributes
        {
            public static string UserProfileArn =  "UserProfileArn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::SageMaker::UserProfile";
            }
        }

        /// <summary>
        /// DomainId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-userprofile.html#cfn-sagemaker-userprofile-domainid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DomainId { get; set; }
        /// <summary>
        /// SingleSignOnUserValue
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-userprofile.html#cfn-sagemaker-userprofile-singlesignonuservalue
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SingleSignOnUserValue { get; set; }
        /// <summary>
        /// UserSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-userprofile.html#cfn-sagemaker-userprofile-usersettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: UserSettings
        /// </summary>
        public UserSettings UserSettings { get; set; }
        /// <summary>
        /// SingleSignOnUserIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-userprofile.html#cfn-sagemaker-userprofile-singlesignonuseridentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SingleSignOnUserIdentifier { get; set; }
        /// <summary>
        /// UserProfileName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-userprofile.html#cfn-sagemaker-userprofile-userprofilename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic UserProfileName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-userprofile.html#cfn-sagemaker-userprofile-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace UserProfileTypes
    {
        public class CodeEditorAppSettings
        {
            /// <summary>
            /// CustomImages
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-codeeditorappsettings.html#cfn-sagemaker-userprofile-codeeditorappsettings-customimages
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomImage
            /// </summary>
            public List<CustomImage> CustomImages { get; set; }
            /// <summary>
            /// DefaultResourceSpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-codeeditorappsettings.html#cfn-sagemaker-userprofile-codeeditorappsettings-defaultresourcespec
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResourceSpec
            /// </summary>
            public ResourceSpec DefaultResourceSpec { get; set; }
            /// <summary>
            /// LifecycleConfigArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-codeeditorappsettings.html#cfn-sagemaker-userprofile-codeeditorappsettings-lifecycleconfigarns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic LifecycleConfigArns { get; set; }
        }

        public class CodeRepository
        {
            /// <summary>
            /// RepositoryUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-coderepository.html#cfn-sagemaker-userprofile-coderepository-repositoryurl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RepositoryUrl { get; set; }
        }

        public class CustomFileSystemConfig
        {
            /// <summary>
            /// EFSFileSystemConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-customfilesystemconfig.html#cfn-sagemaker-userprofile-customfilesystemconfig-efsfilesystemconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EFSFileSystemConfig
            /// </summary>
            public EFSFileSystemConfig EFSFileSystemConfig { get; set; }
        }

        public class CustomImage
        {
            /// <summary>
            /// ImageName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-customimage.html#cfn-sagemaker-userprofile-customimage-imagename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ImageName { get; set; }
            /// <summary>
            /// AppImageConfigName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-customimage.html#cfn-sagemaker-userprofile-customimage-appimageconfigname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AppImageConfigName { get; set; }
            /// <summary>
            /// ImageVersionNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-customimage.html#cfn-sagemaker-userprofile-customimage-imageversionnumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ImageVersionNumber { get; set; }
        }

        public class CustomPosixUserConfig
        {
            /// <summary>
            /// Uid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-customposixuserconfig.html#cfn-sagemaker-userprofile-customposixuserconfig-uid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Uid { get; set; }
            /// <summary>
            /// Gid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-customposixuserconfig.html#cfn-sagemaker-userprofile-customposixuserconfig-gid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Gid { get; set; }
        }

        public class DefaultEbsStorageSettings
        {
            /// <summary>
            /// MaximumEbsVolumeSizeInGb
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-defaultebsstoragesettings.html#cfn-sagemaker-userprofile-defaultebsstoragesettings-maximumebsvolumesizeingb
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaximumEbsVolumeSizeInGb { get; set; }
            /// <summary>
            /// DefaultEbsVolumeSizeInGb
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-defaultebsstoragesettings.html#cfn-sagemaker-userprofile-defaultebsstoragesettings-defaultebsvolumesizeingb
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DefaultEbsVolumeSizeInGb { get; set; }
        }

        public class DefaultSpaceStorageSettings
        {
            /// <summary>
            /// DefaultEbsStorageSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-defaultspacestoragesettings.html#cfn-sagemaker-userprofile-defaultspacestoragesettings-defaultebsstoragesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultEbsStorageSettings
            /// </summary>
            public DefaultEbsStorageSettings DefaultEbsStorageSettings { get; set; }
        }

        public class EFSFileSystemConfig
        {
            /// <summary>
            /// FileSystemPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-efsfilesystemconfig.html#cfn-sagemaker-userprofile-efsfilesystemconfig-filesystempath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FileSystemPath { get; set; }
            /// <summary>
            /// FileSystemId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-efsfilesystemconfig.html#cfn-sagemaker-userprofile-efsfilesystemconfig-filesystemid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FileSystemId { get; set; }
        }

        public class JupyterLabAppSettings
        {
            /// <summary>
            /// CustomImages
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-jupyterlabappsettings.html#cfn-sagemaker-userprofile-jupyterlabappsettings-customimages
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomImage
            /// </summary>
            public List<CustomImage> CustomImages { get; set; }
            /// <summary>
            /// DefaultResourceSpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-jupyterlabappsettings.html#cfn-sagemaker-userprofile-jupyterlabappsettings-defaultresourcespec
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResourceSpec
            /// </summary>
            public ResourceSpec DefaultResourceSpec { get; set; }
            /// <summary>
            /// LifecycleConfigArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-jupyterlabappsettings.html#cfn-sagemaker-userprofile-jupyterlabappsettings-lifecycleconfigarns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic LifecycleConfigArns { get; set; }
            /// <summary>
            /// CodeRepositories
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-jupyterlabappsettings.html#cfn-sagemaker-userprofile-jupyterlabappsettings-coderepositories
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CodeRepository
            /// </summary>
            public List<CodeRepository> CodeRepositories { get; set; }
        }

        public class JupyterServerAppSettings
        {
            /// <summary>
            /// DefaultResourceSpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-jupyterserverappsettings.html#cfn-sagemaker-userprofile-jupyterserverappsettings-defaultresourcespec
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResourceSpec
            /// </summary>
            public ResourceSpec DefaultResourceSpec { get; set; }
        }

        public class KernelGatewayAppSettings
        {
            /// <summary>
            /// CustomImages
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-kernelgatewayappsettings.html#cfn-sagemaker-userprofile-kernelgatewayappsettings-customimages
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomImage
            /// </summary>
            public List<CustomImage> CustomImages { get; set; }
            /// <summary>
            /// DefaultResourceSpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-kernelgatewayappsettings.html#cfn-sagemaker-userprofile-kernelgatewayappsettings-defaultresourcespec
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResourceSpec
            /// </summary>
            public ResourceSpec DefaultResourceSpec { get; set; }
        }

        public class RStudioServerProAppSettings
        {
            /// <summary>
            /// AccessStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-rstudioserverproappsettings.html#cfn-sagemaker-userprofile-rstudioserverproappsettings-accessstatus
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AccessStatus { get; set; }
            /// <summary>
            /// UserGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-rstudioserverproappsettings.html#cfn-sagemaker-userprofile-rstudioserverproappsettings-usergroup
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UserGroup { get; set; }
        }

        public class ResourceSpec
        {
            /// <summary>
            /// SageMakerImageArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-resourcespec.html#cfn-sagemaker-userprofile-resourcespec-sagemakerimagearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SageMakerImageArn { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-resourcespec.html#cfn-sagemaker-userprofile-resourcespec-instancetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InstanceType { get; set; }
            /// <summary>
            /// SageMakerImageVersionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-resourcespec.html#cfn-sagemaker-userprofile-resourcespec-sagemakerimageversionarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SageMakerImageVersionArn { get; set; }
        }

        public class SharingSettings
        {
            /// <summary>
            /// NotebookOutputOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-sharingsettings.html#cfn-sagemaker-userprofile-sharingsettings-notebookoutputoption
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NotebookOutputOption { get; set; }
            /// <summary>
            /// S3KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-sharingsettings.html#cfn-sagemaker-userprofile-sharingsettings-s3kmskeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3KmsKeyId { get; set; }
            /// <summary>
            /// S3OutputPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-sharingsettings.html#cfn-sagemaker-userprofile-sharingsettings-s3outputpath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3OutputPath { get; set; }
        }

        public class StudioWebPortalSettings
        {
            /// <summary>
            /// HiddenAppTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-studiowebportalsettings.html#cfn-sagemaker-userprofile-studiowebportalsettings-hiddenapptypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic HiddenAppTypes { get; set; }
            /// <summary>
            /// HiddenMlTools
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-studiowebportalsettings.html#cfn-sagemaker-userprofile-studiowebportalsettings-hiddenmltools
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic HiddenMlTools { get; set; }
        }

        public class UserSettings
        {
            /// <summary>
            /// SecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-usersettings.html#cfn-sagemaker-userprofile-usersettings-securitygroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroups { get; set; }
            /// <summary>
            /// JupyterLabAppSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-usersettings.html#cfn-sagemaker-userprofile-usersettings-jupyterlabappsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JupyterLabAppSettings
            /// </summary>
            public JupyterLabAppSettings JupyterLabAppSettings { get; set; }
            /// <summary>
            /// KernelGatewayAppSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-usersettings.html#cfn-sagemaker-userprofile-usersettings-kernelgatewayappsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KernelGatewayAppSettings
            /// </summary>
            public KernelGatewayAppSettings KernelGatewayAppSettings { get; set; }
            /// <summary>
            /// StudioWebPortalSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-usersettings.html#cfn-sagemaker-userprofile-usersettings-studiowebportalsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StudioWebPortalSettings
            /// </summary>
            public StudioWebPortalSettings StudioWebPortalSettings { get; set; }
            /// <summary>
            /// CustomFileSystemConfigs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-usersettings.html#cfn-sagemaker-userprofile-usersettings-customfilesystemconfigs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomFileSystemConfig
            /// </summary>
            public List<CustomFileSystemConfig> CustomFileSystemConfigs { get; set; }
            /// <summary>
            /// CustomPosixUserConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-usersettings.html#cfn-sagemaker-userprofile-usersettings-customposixuserconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomPosixUserConfig
            /// </summary>
            public CustomPosixUserConfig CustomPosixUserConfig { get; set; }
            /// <summary>
            /// CodeEditorAppSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-usersettings.html#cfn-sagemaker-userprofile-usersettings-codeeditorappsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CodeEditorAppSettings
            /// </summary>
            public CodeEditorAppSettings CodeEditorAppSettings { get; set; }
            /// <summary>
            /// RStudioServerProAppSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-usersettings.html#cfn-sagemaker-userprofile-usersettings-rstudioserverproappsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RStudioServerProAppSettings
            /// </summary>
            public RStudioServerProAppSettings RStudioServerProAppSettings { get; set; }
            /// <summary>
            /// StudioWebPortal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-usersettings.html#cfn-sagemaker-userprofile-usersettings-studiowebportal
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StudioWebPortal { get; set; }
            /// <summary>
            /// JupyterServerAppSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-usersettings.html#cfn-sagemaker-userprofile-usersettings-jupyterserverappsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JupyterServerAppSettings
            /// </summary>
            public JupyterServerAppSettings JupyterServerAppSettings { get; set; }
            /// <summary>
            /// DefaultLandingUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-usersettings.html#cfn-sagemaker-userprofile-usersettings-defaultlandinguri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DefaultLandingUri { get; set; }
            /// <summary>
            /// ExecutionRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-usersettings.html#cfn-sagemaker-userprofile-usersettings-executionrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExecutionRole { get; set; }
            /// <summary>
            /// SpaceStorageSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-usersettings.html#cfn-sagemaker-userprofile-usersettings-spacestoragesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultSpaceStorageSettings
            /// </summary>
            public DefaultSpaceStorageSettings SpaceStorageSettings { get; set; }
            /// <summary>
            /// SharingSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-usersettings.html#cfn-sagemaker-userprofile-usersettings-sharingsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SharingSettings
            /// </summary>
            public SharingSettings SharingSettings { get; set; }
        }
    }
}