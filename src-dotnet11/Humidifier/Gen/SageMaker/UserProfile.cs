namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using UserProfileTypes;

    public class UserProfile : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDomainId, IHaveSingleSignOnUserValue, IHaveSageMakerUserProfileTypesUserSettingsUserSettings, IHaveSingleSignOnUserIdentifier, IHaveUserProfileName
    {
        public class Attributes
        {
            public static string UserProfileArn =  "UserProfileArn" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.UserProfile; }

        /// <summary>
        /// DomainId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-userprofile.html#cfn-sagemaker-userprofile-domainid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DomainId { get; set; }
        /// <summary>
        /// SingleSignOnUserValue
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-userprofile.html#cfn-sagemaker-userprofile-singlesignonuservalue
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SingleSignOnUserValue { get; set; }
        /// <summary>
        /// UserSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-userprofile.html#cfn-sagemaker-userprofile-usersettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: UserSettings
        /// </summary>
        public Union<Humidifier.SageMaker.UserProfileTypes.UserSettings, BaseFunction>? UserSettings { get; set; }
        /// <summary>
        /// SingleSignOnUserIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-userprofile.html#cfn-sagemaker-userprofile-singlesignonuseridentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SingleSignOnUserIdentifier { get; set; }
        public Union<string, BaseFunction>? UserProfileName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-userprofile.html#cfn-sagemaker-userprofile-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace UserProfileTypes
    {
        public class AppLifecycleManagement : Humidifier.Base.BaseSubResource, IHaveSageMakerUserProfileTypesIdleSettingsIdleSettings
        {
            /// <summary>
            /// IdleSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-applifecyclemanagement.html#cfn-sagemaker-userprofile-applifecyclemanagement-idlesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IdleSettings
            /// </summary>
            public Union<Humidifier.SageMaker.UserProfileTypes.IdleSettings, BaseFunction>? IdleSettings { get; set; }
        }

        public class CodeEditorAppSettings : Humidifier.Base.BaseSubResource, IHaveListOfSageMakerUserProfileTypesCustomImageCustomImages, IHaveSageMakerUserProfileTypesResourceSpecDefaultResourceSpec, IHaveStringListOfLifecycleConfigArns, IHaveBuiltInLifecycleConfigArn, IHaveSageMakerUserProfileTypesAppLifecycleManagementAppLifecycleManagement
        {
            /// <summary>
            /// CustomImages
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-codeeditorappsettings.html#cfn-sagemaker-userprofile-codeeditorappsettings-customimages
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomImage
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.UserProfileTypes.CustomImage>, IReadOnlyList<Union<Humidifier.SageMaker.UserProfileTypes.CustomImage, BaseFunction>>, BaseFunction>? CustomImages { get; set; }
            /// <summary>
            /// DefaultResourceSpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-codeeditorappsettings.html#cfn-sagemaker-userprofile-codeeditorappsettings-defaultresourcespec
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResourceSpec
            /// </summary>
            public Union<Humidifier.SageMaker.UserProfileTypes.ResourceSpec, BaseFunction>? DefaultResourceSpec { get; set; }
            /// <summary>
            /// LifecycleConfigArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-codeeditorappsettings.html#cfn-sagemaker-userprofile-codeeditorappsettings-lifecycleconfigarns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LifecycleConfigArns { get; set; }
            /// <summary>
            /// BuiltInLifecycleConfigArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-codeeditorappsettings.html#cfn-sagemaker-userprofile-codeeditorappsettings-builtinlifecycleconfigarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BuiltInLifecycleConfigArn { get; set; }
            /// <summary>
            /// AppLifecycleManagement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-codeeditorappsettings.html#cfn-sagemaker-userprofile-codeeditorappsettings-applifecyclemanagement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AppLifecycleManagement
            /// </summary>
            public Union<Humidifier.SageMaker.UserProfileTypes.AppLifecycleManagement, BaseFunction>? AppLifecycleManagement { get; set; }
        }

        public class CodeRepository : Humidifier.Base.BaseSubResource, IHaveRepositoryUrl
        {
            /// <summary>
            /// RepositoryUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-coderepository.html#cfn-sagemaker-userprofile-coderepository-repositoryurl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RepositoryUrl { get; set; }
        }

        public class CustomFileSystemConfig : Humidifier.Base.BaseSubResource, IHaveSageMakerUserProfileTypesEFSFileSystemConfigEFSFileSystemConfig, IHaveSageMakerUserProfileTypesS3FileSystemConfigS3FileSystemConfig, IHaveSageMakerUserProfileTypesFSxLustreFileSystemConfigFSxLustreFileSystemConfig
        {
            /// <summary>
            /// EFSFileSystemConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-customfilesystemconfig.html#cfn-sagemaker-userprofile-customfilesystemconfig-efsfilesystemconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EFSFileSystemConfig
            /// </summary>
            public Union<Humidifier.SageMaker.UserProfileTypes.EFSFileSystemConfig, BaseFunction>? EFSFileSystemConfig { get; set; }
            /// <summary>
            /// S3FileSystemConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-customfilesystemconfig.html#cfn-sagemaker-userprofile-customfilesystemconfig-s3filesystemconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3FileSystemConfig
            /// </summary>
            public Union<Humidifier.SageMaker.UserProfileTypes.S3FileSystemConfig, BaseFunction>? S3FileSystemConfig { get; set; }
            /// <summary>
            /// FSxLustreFileSystemConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-customfilesystemconfig.html#cfn-sagemaker-userprofile-customfilesystemconfig-fsxlustrefilesystemconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FSxLustreFileSystemConfig
            /// </summary>
            public Union<Humidifier.SageMaker.UserProfileTypes.FSxLustreFileSystemConfig, BaseFunction>? FSxLustreFileSystemConfig { get; set; }
        }

        public class CustomImage : Humidifier.Base.BaseSubResource, IHaveImageName, IHaveAppImageConfigName, IHaveImageVersionNumber_Integer
        {
            /// <summary>
            /// ImageName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-customimage.html#cfn-sagemaker-userprofile-customimage-imagename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImageName { get; set; }
            /// <summary>
            /// AppImageConfigName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-customimage.html#cfn-sagemaker-userprofile-customimage-appimageconfigname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AppImageConfigName { get; set; }
            /// <summary>
            /// ImageVersionNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-customimage.html#cfn-sagemaker-userprofile-customimage-imageversionnumber
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-customposixuserconfig.html#cfn-sagemaker-userprofile-customposixuserconfig-uid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Uid { get; set; }
            /// <summary>
            /// Gid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-customposixuserconfig.html#cfn-sagemaker-userprofile-customposixuserconfig-gid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-defaultebsstoragesettings.html#cfn-sagemaker-userprofile-defaultebsstoragesettings-maximumebsvolumesizeingb
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaximumEbsVolumeSizeInGb { get; set; }
            /// <summary>
            /// DefaultEbsVolumeSizeInGb
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-defaultebsstoragesettings.html#cfn-sagemaker-userprofile-defaultebsstoragesettings-defaultebsvolumesizeingb
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DefaultEbsVolumeSizeInGb { get; set; }
        }

        public class DefaultSpaceStorageSettings : Humidifier.Base.BaseSubResource, IHaveSageMakerUserProfileTypesDefaultEbsStorageSettingsDefaultEbsStorageSettings
        {
            /// <summary>
            /// DefaultEbsStorageSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-defaultspacestoragesettings.html#cfn-sagemaker-userprofile-defaultspacestoragesettings-defaultebsstoragesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultEbsStorageSettings
            /// </summary>
            public Union<Humidifier.SageMaker.UserProfileTypes.DefaultEbsStorageSettings, BaseFunction>? DefaultEbsStorageSettings { get; set; }
        }

        public class EFSFileSystemConfig : Humidifier.Base.BaseSubResource, IHaveFileSystemPath, IHaveFileSystemId
        {
            /// <summary>
            /// FileSystemPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-efsfilesystemconfig.html#cfn-sagemaker-userprofile-efsfilesystemconfig-filesystempath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FileSystemPath { get; set; }
            /// <summary>
            /// FileSystemId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-efsfilesystemconfig.html#cfn-sagemaker-userprofile-efsfilesystemconfig-filesystemid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FileSystemId { get; set; }
        }

        public class EmrSettings : Humidifier.Base.BaseSubResource, IHaveStringListOfAssumableRoleArns, IHaveStringListOfExecutionRoleArns
        {
            /// <summary>
            /// AssumableRoleArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-emrsettings.html#cfn-sagemaker-userprofile-emrsettings-assumablerolearns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AssumableRoleArns { get; set; }
            /// <summary>
            /// ExecutionRoleArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-emrsettings.html#cfn-sagemaker-userprofile-emrsettings-executionrolearns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ExecutionRoleArns { get; set; }
        }

        public class FSxLustreFileSystemConfig : Humidifier.Base.BaseSubResource, IHaveFileSystemPath, IHaveFileSystemId
        {
            /// <summary>
            /// FileSystemPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-fsxlustrefilesystemconfig.html#cfn-sagemaker-userprofile-fsxlustrefilesystemconfig-filesystempath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FileSystemPath { get; set; }
            /// <summary>
            /// FileSystemId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-fsxlustrefilesystemconfig.html#cfn-sagemaker-userprofile-fsxlustrefilesystemconfig-filesystemid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-hiddensagemakerimage.html#cfn-sagemaker-userprofile-hiddensagemakerimage-sagemakerimagename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SageMakerImageName { get; set; }
            /// <summary>
            /// VersionAliases
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-hiddensagemakerimage.html#cfn-sagemaker-userprofile-hiddensagemakerimage-versionaliases
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-idlesettings.html#cfn-sagemaker-userprofile-idlesettings-maxidletimeoutinminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxIdleTimeoutInMinutes { get; set; }
            /// <summary>
            /// IdleTimeoutInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-idlesettings.html#cfn-sagemaker-userprofile-idlesettings-idletimeoutinminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? IdleTimeoutInMinutes { get; set; }
            /// <summary>
            /// MinIdleTimeoutInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-idlesettings.html#cfn-sagemaker-userprofile-idlesettings-minidletimeoutinminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinIdleTimeoutInMinutes { get; set; }
            /// <summary>
            /// LifecycleManagement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-idlesettings.html#cfn-sagemaker-userprofile-idlesettings-lifecyclemanagement
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LifecycleManagement { get; set; }
        }

        public class JupyterLabAppSettings : Humidifier.Base.BaseSubResource, IHaveSageMakerUserProfileTypesEmrSettingsEmrSettings, IHaveListOfSageMakerUserProfileTypesCustomImageCustomImages, IHaveSageMakerUserProfileTypesResourceSpecDefaultResourceSpec, IHaveStringListOfLifecycleConfigArns, IHaveBuiltInLifecycleConfigArn, IHaveListOfSageMakerUserProfileTypesCodeRepositoryCodeRepositories, IHaveSageMakerUserProfileTypesAppLifecycleManagementAppLifecycleManagement
        {
            /// <summary>
            /// EmrSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-jupyterlabappsettings.html#cfn-sagemaker-userprofile-jupyterlabappsettings-emrsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EmrSettings
            /// </summary>
            public Union<Humidifier.SageMaker.UserProfileTypes.EmrSettings, BaseFunction>? EmrSettings { get; set; }
            /// <summary>
            /// CustomImages
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-jupyterlabappsettings.html#cfn-sagemaker-userprofile-jupyterlabappsettings-customimages
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomImage
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.UserProfileTypes.CustomImage>, IReadOnlyList<Union<Humidifier.SageMaker.UserProfileTypes.CustomImage, BaseFunction>>, BaseFunction>? CustomImages { get; set; }
            /// <summary>
            /// DefaultResourceSpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-jupyterlabappsettings.html#cfn-sagemaker-userprofile-jupyterlabappsettings-defaultresourcespec
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResourceSpec
            /// </summary>
            public Union<Humidifier.SageMaker.UserProfileTypes.ResourceSpec, BaseFunction>? DefaultResourceSpec { get; set; }
            /// <summary>
            /// LifecycleConfigArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-jupyterlabappsettings.html#cfn-sagemaker-userprofile-jupyterlabappsettings-lifecycleconfigarns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LifecycleConfigArns { get; set; }
            /// <summary>
            /// BuiltInLifecycleConfigArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-jupyterlabappsettings.html#cfn-sagemaker-userprofile-jupyterlabappsettings-builtinlifecycleconfigarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BuiltInLifecycleConfigArn { get; set; }
            /// <summary>
            /// CodeRepositories
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-jupyterlabappsettings.html#cfn-sagemaker-userprofile-jupyterlabappsettings-coderepositories
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CodeRepository
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.UserProfileTypes.CodeRepository>, IReadOnlyList<Union<Humidifier.SageMaker.UserProfileTypes.CodeRepository, BaseFunction>>, BaseFunction>? CodeRepositories { get; set; }
            /// <summary>
            /// AppLifecycleManagement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-jupyterlabappsettings.html#cfn-sagemaker-userprofile-jupyterlabappsettings-applifecyclemanagement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AppLifecycleManagement
            /// </summary>
            public Union<Humidifier.SageMaker.UserProfileTypes.AppLifecycleManagement, BaseFunction>? AppLifecycleManagement { get; set; }
        }

        public class JupyterServerAppSettings : Humidifier.Base.BaseSubResource, IHaveSageMakerUserProfileTypesResourceSpecDefaultResourceSpec, IHaveStringListOfLifecycleConfigArns
        {
            /// <summary>
            /// DefaultResourceSpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-jupyterserverappsettings.html#cfn-sagemaker-userprofile-jupyterserverappsettings-defaultresourcespec
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResourceSpec
            /// </summary>
            public Union<Humidifier.SageMaker.UserProfileTypes.ResourceSpec, BaseFunction>? DefaultResourceSpec { get; set; }
            /// <summary>
            /// LifecycleConfigArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-jupyterserverappsettings.html#cfn-sagemaker-userprofile-jupyterserverappsettings-lifecycleconfigarns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LifecycleConfigArns { get; set; }
        }

        public class KernelGatewayAppSettings : Humidifier.Base.BaseSubResource, IHaveListOfSageMakerUserProfileTypesCustomImageCustomImages, IHaveSageMakerUserProfileTypesResourceSpecDefaultResourceSpec, IHaveStringListOfLifecycleConfigArns
        {
            /// <summary>
            /// CustomImages
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-kernelgatewayappsettings.html#cfn-sagemaker-userprofile-kernelgatewayappsettings-customimages
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomImage
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.UserProfileTypes.CustomImage>, IReadOnlyList<Union<Humidifier.SageMaker.UserProfileTypes.CustomImage, BaseFunction>>, BaseFunction>? CustomImages { get; set; }
            /// <summary>
            /// DefaultResourceSpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-kernelgatewayappsettings.html#cfn-sagemaker-userprofile-kernelgatewayappsettings-defaultresourcespec
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResourceSpec
            /// </summary>
            public Union<Humidifier.SageMaker.UserProfileTypes.ResourceSpec, BaseFunction>? DefaultResourceSpec { get; set; }
            /// <summary>
            /// LifecycleConfigArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-kernelgatewayappsettings.html#cfn-sagemaker-userprofile-kernelgatewayappsettings-lifecycleconfigarns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LifecycleConfigArns { get; set; }
        }

        public class RStudioServerProAppSettings : Humidifier.Base.BaseSubResource, IHaveAccessStatus, IHaveUserGroup
        {
            /// <summary>
            /// AccessStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-rstudioserverproappsettings.html#cfn-sagemaker-userprofile-rstudioserverproappsettings-accessstatus
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccessStatus { get; set; }
            /// <summary>
            /// UserGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-rstudioserverproappsettings.html#cfn-sagemaker-userprofile-rstudioserverproappsettings-usergroup
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserGroup { get; set; }
        }

        public class ResourceSpec : Humidifier.Base.BaseSubResource, IHaveSageMakerImageArn, IHaveTrainingPlanArn, IHaveInstanceType, IHaveLifecycleConfigArn, IHaveSageMakerImageVersionArn
        {
            /// <summary>
            /// SageMakerImageArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-resourcespec.html#cfn-sagemaker-userprofile-resourcespec-sagemakerimagearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SageMakerImageArn { get; set; }
            /// <summary>
            /// TrainingPlanArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-resourcespec.html#cfn-sagemaker-userprofile-resourcespec-trainingplanarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TrainingPlanArn { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-resourcespec.html#cfn-sagemaker-userprofile-resourcespec-instancetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceType { get; set; }
            /// <summary>
            /// LifecycleConfigArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-resourcespec.html#cfn-sagemaker-userprofile-resourcespec-lifecycleconfigarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LifecycleConfigArn { get; set; }
            /// <summary>
            /// SageMakerImageVersionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-resourcespec.html#cfn-sagemaker-userprofile-resourcespec-sagemakerimageversionarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SageMakerImageVersionArn { get; set; }
        }

        public class S3FileSystemConfig : Humidifier.Base.BaseSubResource, IHaveMountPath, IHaveS3Uri
        {
            /// <summary>
            /// MountPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-s3filesystemconfig.html#cfn-sagemaker-userprofile-s3filesystemconfig-mountpath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MountPath { get; set; }
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-s3filesystemconfig.html#cfn-sagemaker-userprofile-s3filesystemconfig-s3uri
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-sharingsettings.html#cfn-sagemaker-userprofile-sharingsettings-notebookoutputoption
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NotebookOutputOption { get; set; }
            /// <summary>
            /// S3KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-sharingsettings.html#cfn-sagemaker-userprofile-sharingsettings-s3kmskeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3KmsKeyId { get; set; }
            /// <summary>
            /// S3OutputPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-sharingsettings.html#cfn-sagemaker-userprofile-sharingsettings-s3outputpath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3OutputPath { get; set; }
        }

        public class StudioWebPortalSettings : Humidifier.Base.BaseSubResource, IHaveListOfSageMakerUserProfileTypesHiddenSageMakerImageHiddenSageMakerImageVersionAliases, IHaveStringListOfHiddenAppTypes, IHaveStringListOfHiddenInstanceTypes, IHaveStringListOfHiddenMlTools
        {
            /// <summary>
            /// HiddenSageMakerImageVersionAliases
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-studiowebportalsettings.html#cfn-sagemaker-userprofile-studiowebportalsettings-hiddensagemakerimageversionaliases
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: HiddenSageMakerImage
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.UserProfileTypes.HiddenSageMakerImage>, IReadOnlyList<Union<Humidifier.SageMaker.UserProfileTypes.HiddenSageMakerImage, BaseFunction>>, BaseFunction>? HiddenSageMakerImageVersionAliases { get; set; }
            /// <summary>
            /// HiddenAppTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-studiowebportalsettings.html#cfn-sagemaker-userprofile-studiowebportalsettings-hiddenapptypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? HiddenAppTypes { get; set; }
            /// <summary>
            /// HiddenInstanceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-studiowebportalsettings.html#cfn-sagemaker-userprofile-studiowebportalsettings-hiddeninstancetypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? HiddenInstanceTypes { get; set; }
            /// <summary>
            /// HiddenMlTools
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-studiowebportalsettings.html#cfn-sagemaker-userprofile-studiowebportalsettings-hiddenmltools
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? HiddenMlTools { get; set; }
        }

        public class UserSettings : Humidifier.Base.BaseSubResource, IHaveStringListOfSecurityGroups, IHaveSageMakerUserProfileTypesJupyterLabAppSettingsJupyterLabAppSettings, IHaveSageMakerUserProfileTypesKernelGatewayAppSettingsKernelGatewayAppSettings, IHaveSageMakerUserProfileTypesStudioWebPortalSettingsStudioWebPortalSettings, IHaveListOfSageMakerUserProfileTypesCustomFileSystemConfigCustomFileSystemConfigs, IHaveSageMakerUserProfileTypesCustomPosixUserConfigCustomPosixUserConfig, IHaveSageMakerUserProfileTypesCodeEditorAppSettingsCodeEditorAppSettings, IHaveSageMakerUserProfileTypesRStudioServerProAppSettingsRStudioServerProAppSettings, IHaveStudioWebPortal, IHaveSageMakerUserProfileTypesJupyterServerAppSettingsJupyterServerAppSettings, IHaveAutoMountHomeEFS, IHaveDefaultLandingUri, IHaveExecutionRole, IHaveSageMakerUserProfileTypesDefaultSpaceStorageSettingsSpaceStorageSettings, IHaveSageMakerUserProfileTypesSharingSettingsSharingSettings
        {
            /// <summary>
            /// SecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-usersettings.html#cfn-sagemaker-userprofile-usersettings-securitygroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroups { get; set; }
            /// <summary>
            /// JupyterLabAppSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-usersettings.html#cfn-sagemaker-userprofile-usersettings-jupyterlabappsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JupyterLabAppSettings
            /// </summary>
            public Union<Humidifier.SageMaker.UserProfileTypes.JupyterLabAppSettings, BaseFunction>? JupyterLabAppSettings { get; set; }
            /// <summary>
            /// KernelGatewayAppSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-usersettings.html#cfn-sagemaker-userprofile-usersettings-kernelgatewayappsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KernelGatewayAppSettings
            /// </summary>
            public Union<Humidifier.SageMaker.UserProfileTypes.KernelGatewayAppSettings, BaseFunction>? KernelGatewayAppSettings { get; set; }
            /// <summary>
            /// StudioWebPortalSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-usersettings.html#cfn-sagemaker-userprofile-usersettings-studiowebportalsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StudioWebPortalSettings
            /// </summary>
            public Union<Humidifier.SageMaker.UserProfileTypes.StudioWebPortalSettings, BaseFunction>? StudioWebPortalSettings { get; set; }
            /// <summary>
            /// CustomFileSystemConfigs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-usersettings.html#cfn-sagemaker-userprofile-usersettings-customfilesystemconfigs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomFileSystemConfig
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.UserProfileTypes.CustomFileSystemConfig>, IReadOnlyList<Union<Humidifier.SageMaker.UserProfileTypes.CustomFileSystemConfig, BaseFunction>>, BaseFunction>? CustomFileSystemConfigs { get; set; }
            /// <summary>
            /// CustomPosixUserConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-usersettings.html#cfn-sagemaker-userprofile-usersettings-customposixuserconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomPosixUserConfig
            /// </summary>
            public Union<Humidifier.SageMaker.UserProfileTypes.CustomPosixUserConfig, BaseFunction>? CustomPosixUserConfig { get; set; }
            /// <summary>
            /// CodeEditorAppSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-usersettings.html#cfn-sagemaker-userprofile-usersettings-codeeditorappsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CodeEditorAppSettings
            /// </summary>
            public Union<Humidifier.SageMaker.UserProfileTypes.CodeEditorAppSettings, BaseFunction>? CodeEditorAppSettings { get; set; }
            /// <summary>
            /// RStudioServerProAppSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-usersettings.html#cfn-sagemaker-userprofile-usersettings-rstudioserverproappsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RStudioServerProAppSettings
            /// </summary>
            public Union<Humidifier.SageMaker.UserProfileTypes.RStudioServerProAppSettings, BaseFunction>? RStudioServerProAppSettings { get; set; }
            /// <summary>
            /// StudioWebPortal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-usersettings.html#cfn-sagemaker-userprofile-usersettings-studiowebportal
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StudioWebPortal { get; set; }
            /// <summary>
            /// JupyterServerAppSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-usersettings.html#cfn-sagemaker-userprofile-usersettings-jupyterserverappsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JupyterServerAppSettings
            /// </summary>
            public Union<Humidifier.SageMaker.UserProfileTypes.JupyterServerAppSettings, BaseFunction>? JupyterServerAppSettings { get; set; }
            /// <summary>
            /// AutoMountHomeEFS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-usersettings.html#cfn-sagemaker-userprofile-usersettings-automounthomeefs
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AutoMountHomeEFS { get; set; }
            /// <summary>
            /// DefaultLandingUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-usersettings.html#cfn-sagemaker-userprofile-usersettings-defaultlandinguri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DefaultLandingUri { get; set; }
            /// <summary>
            /// ExecutionRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-usersettings.html#cfn-sagemaker-userprofile-usersettings-executionrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExecutionRole { get; set; }
            /// <summary>
            /// SpaceStorageSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-usersettings.html#cfn-sagemaker-userprofile-usersettings-spacestoragesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DefaultSpaceStorageSettings
            /// </summary>
            public Union<Humidifier.SageMaker.UserProfileTypes.DefaultSpaceStorageSettings, BaseFunction>? SpaceStorageSettings { get; set; }
            /// <summary>
            /// SharingSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-userprofile-usersettings.html#cfn-sagemaker-userprofile-usersettings-sharingsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SharingSettings
            /// </summary>
            public Union<Humidifier.SageMaker.UserProfileTypes.SharingSettings, BaseFunction>? SharingSettings { get; set; }
        }
    }
}