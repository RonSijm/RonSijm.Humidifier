namespace Humidifier.CodeBuild
{
    using global::System.Collections.Generic;
    using ProjectTypes;

    public class Project : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveResourceAccessRole, IHaveCodeBuildProjectTypesVpcConfigVpcConfig, IHaveListOfCodeBuildProjectTypesSourceSecondarySources, IHaveEncryptionKey, IHaveListOfCodeBuildProjectTypesArtifactsSecondaryArtifacts, IHaveCodeBuildProjectTypesSourceSource, IHaveName, IHaveCodeBuildProjectTypesLogsConfigLogsConfig, IHaveServiceRole, IHaveQueuedTimeoutInMinutes_Integer, IHaveListOfCodeBuildProjectTypesProjectSourceVersionSecondarySourceVersions, IHaveAutoRetryLimit_Integer, IHaveSourceVersion, IHaveCodeBuildProjectTypesProjectTriggersTriggers, IHaveCodeBuildProjectTypesArtifactsArtifacts, IHaveBadgeEnabled_Boolean, IHaveListOfCodeBuildProjectTypesProjectFileSystemLocationFileSystemLocations, IHaveCodeBuildProjectTypesEnvironmentEnvironment, IHaveConcurrentBuildLimit_Integer, IHaveVisibility, IHaveCodeBuildProjectTypesProjectBuildBatchConfigBuildBatchConfig, IHaveTimeoutInMinutes_Integer, IHaveCodeBuildProjectTypesProjectCacheCache
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.CodeBuild.Project; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-project.html#cfn-codebuild-project-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// ResourceAccessRole
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-project.html#cfn-codebuild-project-resourceaccessrole
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ResourceAccessRole { get; set; }
        /// <summary>
        /// VpcConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-project.html#cfn-codebuild-project-vpcconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: VpcConfig
        /// </summary>
        public Union<Humidifier.CodeBuild.ProjectTypes.VpcConfig, BaseFunction>? VpcConfig { get; set; }
        /// <summary>
        /// SecondarySources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-project.html#cfn-codebuild-project-secondarysources
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Source
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CodeBuild.ProjectTypes.Source>, IReadOnlyList<Union<Humidifier.CodeBuild.ProjectTypes.Source, BaseFunction>>, BaseFunction>? SecondarySources { get; set; }
        /// <summary>
        /// EncryptionKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-project.html#cfn-codebuild-project-encryptionkey
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EncryptionKey { get; set; }
        /// <summary>
        /// SecondaryArtifacts
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-project.html#cfn-codebuild-project-secondaryartifacts
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Artifacts
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CodeBuild.ProjectTypes.Artifacts>, IReadOnlyList<Union<Humidifier.CodeBuild.ProjectTypes.Artifacts, BaseFunction>>, BaseFunction>? SecondaryArtifacts { get; set; }

        /// <summary>
        /// Source
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-project.html#cfn-codebuild-project-source
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Source
        /// </summary>
        [Required]
        public Union<Humidifier.CodeBuild.ProjectTypes.Source, BaseFunction>? Source { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// LogsConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-project.html#cfn-codebuild-project-logsconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LogsConfig
        /// </summary>
        public Union<Humidifier.CodeBuild.ProjectTypes.LogsConfig, BaseFunction>? LogsConfig { get; set; }

        /// <summary>
        /// ServiceRole
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-project.html#cfn-codebuild-project-servicerole
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ServiceRole { get; set; }
        /// <summary>
        /// QueuedTimeoutInMinutes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-project.html#cfn-codebuild-project-queuedtimeoutinminutes
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? QueuedTimeoutInMinutes { get; set; }
        /// <summary>
        /// SecondarySourceVersions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-project.html#cfn-codebuild-project-secondarysourceversions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ProjectSourceVersion
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CodeBuild.ProjectTypes.ProjectSourceVersion>, IReadOnlyList<Union<Humidifier.CodeBuild.ProjectTypes.ProjectSourceVersion, BaseFunction>>, BaseFunction>? SecondarySourceVersions { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-project.html#cfn-codebuild-project-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// AutoRetryLimit
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-project.html#cfn-codebuild-project-autoretrylimit
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? AutoRetryLimit { get; set; }
        /// <summary>
        /// SourceVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-project.html#cfn-codebuild-project-sourceversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SourceVersion { get; set; }
        /// <summary>
        /// Triggers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-project.html#cfn-codebuild-project-triggers
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ProjectTriggers
        /// </summary>
        public Union<Humidifier.CodeBuild.ProjectTypes.ProjectTriggers, BaseFunction>? Triggers { get; set; }

        /// <summary>
        /// Artifacts
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-project.html#cfn-codebuild-project-artifacts
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Artifacts
        /// </summary>
        [Required]
        public Union<Humidifier.CodeBuild.ProjectTypes.Artifacts, BaseFunction>? Artifacts { get; set; }
        /// <summary>
        /// BadgeEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-project.html#cfn-codebuild-project-badgeenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? BadgeEnabled { get; set; }
        /// <summary>
        /// FileSystemLocations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-project.html#cfn-codebuild-project-filesystemlocations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ProjectFileSystemLocation
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CodeBuild.ProjectTypes.ProjectFileSystemLocation>, IReadOnlyList<Union<Humidifier.CodeBuild.ProjectTypes.ProjectFileSystemLocation, BaseFunction>>, BaseFunction>? FileSystemLocations { get; set; }

        /// <summary>
        /// Environment
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-project.html#cfn-codebuild-project-environment
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Environment
        /// </summary>
        [Required]
        public Union<Humidifier.CodeBuild.ProjectTypes.Environment, BaseFunction>? Environment { get; set; }
        /// <summary>
        /// ConcurrentBuildLimit
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-project.html#cfn-codebuild-project-concurrentbuildlimit
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? ConcurrentBuildLimit { get; set; }
        /// <summary>
        /// Visibility
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-project.html#cfn-codebuild-project-visibility
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Visibility { get; set; }
        /// <summary>
        /// BuildBatchConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-project.html#cfn-codebuild-project-buildbatchconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ProjectBuildBatchConfig
        /// </summary>
        public Union<Humidifier.CodeBuild.ProjectTypes.ProjectBuildBatchConfig, BaseFunction>? BuildBatchConfig { get; set; }
        /// <summary>
        /// TimeoutInMinutes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-project.html#cfn-codebuild-project-timeoutinminutes
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? TimeoutInMinutes { get; set; }
        /// <summary>
        /// Cache
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-project.html#cfn-codebuild-project-cache
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ProjectCache
        /// </summary>
        public Union<Humidifier.CodeBuild.ProjectTypes.ProjectCache, BaseFunction>? Cache { get; set; }
    }

    namespace ProjectTypes
    {
        public class Artifacts : Humidifier.Base.BaseSubResource, IHavePath, IHaveType, IHaveArtifactIdentifier, IHaveOverrideArtifactName_Boolean, IHavePackaging, IHaveEncryptionDisabled_Boolean, IHaveLocation, IHaveName, IHaveNamespaceType
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-artifacts.html#cfn-codebuild-project-artifacts-path
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Path { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-artifacts.html#cfn-codebuild-project-artifacts-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// ArtifactIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-artifacts.html#cfn-codebuild-project-artifacts-artifactidentifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ArtifactIdentifier { get; set; }
            /// <summary>
            /// OverrideArtifactName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-artifacts.html#cfn-codebuild-project-artifacts-overrideartifactname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? OverrideArtifactName { get; set; }
            /// <summary>
            /// Packaging
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-artifacts.html#cfn-codebuild-project-artifacts-packaging
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Packaging { get; set; }
            /// <summary>
            /// EncryptionDisabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-artifacts.html#cfn-codebuild-project-artifacts-encryptiondisabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EncryptionDisabled { get; set; }
            /// <summary>
            /// Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-artifacts.html#cfn-codebuild-project-artifacts-location
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Location { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-artifacts.html#cfn-codebuild-project-artifacts-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
            /// <summary>
            /// NamespaceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-artifacts.html#cfn-codebuild-project-artifacts-namespacetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NamespaceType { get; set; }
        }

        public class BatchRestrictions : Humidifier.Base.BaseSubResource, IHaveStringListOfComputeTypesAllowed, IHaveMaximumBuildsAllowed_Integer, IHaveStringListOfFleetsAllowed
        {
            /// <summary>
            /// ComputeTypesAllowed
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-batchrestrictions.html#cfn-codebuild-project-batchrestrictions-computetypesallowed
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ComputeTypesAllowed { get; set; }
            /// <summary>
            /// MaximumBuildsAllowed
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-batchrestrictions.html#cfn-codebuild-project-batchrestrictions-maximumbuildsallowed
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaximumBuildsAllowed { get; set; }
            /// <summary>
            /// FleetsAllowed
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-batchrestrictions.html#cfn-codebuild-project-batchrestrictions-fleetsallowed
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? FleetsAllowed { get; set; }
        }

        public class BuildStatusConfig : Humidifier.Base.BaseSubResource, IHaveContext, IHaveTargetUrl
        {
            /// <summary>
            /// Context
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-buildstatusconfig.html#cfn-codebuild-project-buildstatusconfig-context
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Context { get; set; }
            /// <summary>
            /// TargetUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-buildstatusconfig.html#cfn-codebuild-project-buildstatusconfig-targeturl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetUrl { get; set; }
        }

        public class CloudWatchLogsConfig : Humidifier.Base.BaseSubResource, IHaveGroupName, IHaveStatus, IHaveStreamName
        {
            /// <summary>
            /// GroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-cloudwatchlogsconfig.html#cfn-codebuild-project-cloudwatchlogsconfig-groupname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GroupName { get; set; }
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-cloudwatchlogsconfig.html#cfn-codebuild-project-cloudwatchlogsconfig-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// StreamName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-cloudwatchlogsconfig.html#cfn-codebuild-project-cloudwatchlogsconfig-streamname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StreamName { get; set; }
        }

        public class DockerServer : Humidifier.Base.BaseSubResource, IHaveComputeType, IHaveStringListOfSecurityGroupIds
        {
            /// <summary>
            /// ComputeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-dockerserver.html#cfn-codebuild-project-dockerserver-computetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComputeType { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-dockerserver.html#cfn-codebuild-project-dockerserver-securitygroupids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        }

        public class Environment : Humidifier.Base.BaseSubResource, IHaveType, IHaveListOfCodeBuildProjectTypesEnvironmentVariableEnvironmentVariables, IHaveCodeBuildProjectTypesProjectFleetFleet, IHavePrivilegedMode_Boolean, IHaveImagePullCredentialsType, IHaveHostKernel, IHaveImage, IHaveCodeBuildProjectTypesRegistryCredentialRegistryCredential, IHaveComputeType, IHaveCodeBuildProjectTypesDockerServerDockerServer, IHaveCertificate
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-environment.html#cfn-codebuild-project-environment-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// EnvironmentVariables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-environment.html#cfn-codebuild-project-environment-environmentvariables
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EnvironmentVariable
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CodeBuild.ProjectTypes.EnvironmentVariable>, IReadOnlyList<Union<Humidifier.CodeBuild.ProjectTypes.EnvironmentVariable, BaseFunction>>, BaseFunction>? EnvironmentVariables { get; set; }
            /// <summary>
            /// Fleet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-environment.html#cfn-codebuild-project-environment-fleet
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ProjectFleet
            /// </summary>
            public Union<Humidifier.CodeBuild.ProjectTypes.ProjectFleet, BaseFunction>? Fleet { get; set; }
            /// <summary>
            /// PrivilegedMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-environment.html#cfn-codebuild-project-environment-privilegedmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? PrivilegedMode { get; set; }
            /// <summary>
            /// ImagePullCredentialsType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-environment.html#cfn-codebuild-project-environment-imagepullcredentialstype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImagePullCredentialsType { get; set; }
            /// <summary>
            /// HostKernel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-environment.html#cfn-codebuild-project-environment-hostkernel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HostKernel { get; set; }
            /// <summary>
            /// Image
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-environment.html#cfn-codebuild-project-environment-image
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Image { get; set; }
            /// <summary>
            /// RegistryCredential
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-environment.html#cfn-codebuild-project-environment-registrycredential
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RegistryCredential
            /// </summary>
            public Union<Humidifier.CodeBuild.ProjectTypes.RegistryCredential, BaseFunction>? RegistryCredential { get; set; }
            /// <summary>
            /// ComputeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-environment.html#cfn-codebuild-project-environment-computetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComputeType { get; set; }
            /// <summary>
            /// DockerServer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-environment.html#cfn-codebuild-project-environment-dockerserver
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DockerServer
            /// </summary>
            public Union<Humidifier.CodeBuild.ProjectTypes.DockerServer, BaseFunction>? DockerServer { get; set; }
            /// <summary>
            /// Certificate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-environment.html#cfn-codebuild-project-environment-certificate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Certificate { get; set; }
        }

        public class EnvironmentVariable : Humidifier.Base.BaseSubResource, IHaveType, IHaveValue, IHaveName
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-environmentvariable.html#cfn-codebuild-project-environmentvariable-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-environmentvariable.html#cfn-codebuild-project-environmentvariable-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-environmentvariable.html#cfn-codebuild-project-environmentvariable-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class GitSubmodulesConfig : Humidifier.Base.BaseSubResource, IHaveFetchSubmodules_Boolean
        {
            /// <summary>
            /// FetchSubmodules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-gitsubmodulesconfig.html#cfn-codebuild-project-gitsubmodulesconfig-fetchsubmodules
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? FetchSubmodules { get; set; }
        }

        public class LogsConfig : Humidifier.Base.BaseSubResource, IHaveCodeBuildProjectTypesCloudWatchLogsConfigCloudWatchLogs, IHaveCodeBuildProjectTypesS3LogsConfigS3Logs
        {
            /// <summary>
            /// CloudWatchLogs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-logsconfig.html#cfn-codebuild-project-logsconfig-cloudwatchlogs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudWatchLogsConfig
            /// </summary>
            public Union<Humidifier.CodeBuild.ProjectTypes.CloudWatchLogsConfig, BaseFunction>? CloudWatchLogs { get; set; }
            /// <summary>
            /// S3Logs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-logsconfig.html#cfn-codebuild-project-logsconfig-s3logs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3LogsConfig
            /// </summary>
            public Union<Humidifier.CodeBuild.ProjectTypes.S3LogsConfig, BaseFunction>? S3Logs { get; set; }
        }

        public class ProjectBuildBatchConfig : Humidifier.Base.BaseSubResource, IHaveCombineArtifacts_Boolean, IHaveServiceRole, IHaveBatchReportMode, IHaveTimeoutInMins_Integer, IHaveCodeBuildProjectTypesBatchRestrictionsRestrictions
        {
            /// <summary>
            /// CombineArtifacts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-projectbuildbatchconfig.html#cfn-codebuild-project-projectbuildbatchconfig-combineartifacts
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? CombineArtifacts { get; set; }
            /// <summary>
            /// ServiceRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-projectbuildbatchconfig.html#cfn-codebuild-project-projectbuildbatchconfig-servicerole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServiceRole { get; set; }
            /// <summary>
            /// BatchReportMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-projectbuildbatchconfig.html#cfn-codebuild-project-projectbuildbatchconfig-batchreportmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BatchReportMode { get; set; }
            /// <summary>
            /// TimeoutInMins
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-projectbuildbatchconfig.html#cfn-codebuild-project-projectbuildbatchconfig-timeoutinmins
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimeoutInMins { get; set; }
            /// <summary>
            /// Restrictions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-projectbuildbatchconfig.html#cfn-codebuild-project-projectbuildbatchconfig-restrictions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BatchRestrictions
            /// </summary>
            public Union<Humidifier.CodeBuild.ProjectTypes.BatchRestrictions, BaseFunction>? Restrictions { get; set; }
        }

        public class ProjectCache : Humidifier.Base.BaseSubResource, IHaveStringListOfModes, IHaveType, IHaveCacheNamespace, IHaveLocation
        {
            /// <summary>
            /// Modes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-projectcache.html#cfn-codebuild-project-projectcache-modes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Modes { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-projectcache.html#cfn-codebuild-project-projectcache-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// CacheNamespace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-projectcache.html#cfn-codebuild-project-projectcache-cachenamespace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CacheNamespace { get; set; }
            /// <summary>
            /// Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-projectcache.html#cfn-codebuild-project-projectcache-location
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Location { get; set; }
        }

        public class ProjectFileSystemLocation : Humidifier.Base.BaseSubResource, IHaveMountPoint, IHaveType, IHaveIdentifier, IHaveMountOptions, IHaveLocation
        {
            /// <summary>
            /// MountPoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-projectfilesystemlocation.html#cfn-codebuild-project-projectfilesystemlocation-mountpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MountPoint { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-projectfilesystemlocation.html#cfn-codebuild-project-projectfilesystemlocation-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Identifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-projectfilesystemlocation.html#cfn-codebuild-project-projectfilesystemlocation-identifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Identifier { get; set; }
            /// <summary>
            /// MountOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-projectfilesystemlocation.html#cfn-codebuild-project-projectfilesystemlocation-mountoptions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MountOptions { get; set; }
            /// <summary>
            /// Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-projectfilesystemlocation.html#cfn-codebuild-project-projectfilesystemlocation-location
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Location { get; set; }
        }

        public class ProjectFleet : Humidifier.Base.BaseSubResource, IHaveFleetArn
        {
            /// <summary>
            /// FleetArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-projectfleet.html#cfn-codebuild-project-projectfleet-fleetarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FleetArn { get; set; }
        }

        public class ProjectSourceVersion : Humidifier.Base.BaseSubResource, IHaveSourceIdentifier, IHaveSourceVersion
        {
            /// <summary>
            /// SourceIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-projectsourceversion.html#cfn-codebuild-project-projectsourceversion-sourceidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceIdentifier { get; set; }
            /// <summary>
            /// SourceVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-projectsourceversion.html#cfn-codebuild-project-projectsourceversion-sourceversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceVersion { get; set; }
        }

        public class ProjectTriggers : Humidifier.Base.BaseSubResource, IHaveFilterGroups_Json, IHaveBuildType, IHaveWebhook_Boolean, IHaveCodeBuildProjectTypesScopeConfigurationScopeConfiguration, IHaveCodeBuildProjectTypesPullRequestBuildPolicyPullRequestBuildPolicy
        {
            /// <summary>
            /// FilterGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-projecttriggers.html#cfn-codebuild-project-projecttriggers-filtergroups
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? FilterGroups { get; set; }
            /// <summary>
            /// BuildType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-projecttriggers.html#cfn-codebuild-project-projecttriggers-buildtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BuildType { get; set; }
            /// <summary>
            /// Webhook
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-projecttriggers.html#cfn-codebuild-project-projecttriggers-webhook
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Webhook { get; set; }
            /// <summary>
            /// ScopeConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-projecttriggers.html#cfn-codebuild-project-projecttriggers-scopeconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScopeConfiguration
            /// </summary>
            public Union<Humidifier.CodeBuild.ProjectTypes.ScopeConfiguration, BaseFunction>? ScopeConfiguration { get; set; }
            /// <summary>
            /// PullRequestBuildPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-projecttriggers.html#cfn-codebuild-project-projecttriggers-pullrequestbuildpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PullRequestBuildPolicy
            /// </summary>
            public Union<Humidifier.CodeBuild.ProjectTypes.PullRequestBuildPolicy, BaseFunction>? PullRequestBuildPolicy { get; set; }
        }

        public class PullRequestBuildPolicy : Humidifier.Base.BaseSubResource, IHaveRequiresCommentApproval, IHaveStringListOfApproverRoles
        {
            /// <summary>
            /// RequiresCommentApproval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-pullrequestbuildpolicy.html#cfn-codebuild-project-pullrequestbuildpolicy-requirescommentapproval
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RequiresCommentApproval { get; set; }
            /// <summary>
            /// ApproverRoles
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-pullrequestbuildpolicy.html#cfn-codebuild-project-pullrequestbuildpolicy-approverroles
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ApproverRoles { get; set; }
        }

        public class RegistryCredential : Humidifier.Base.BaseSubResource, IHaveCredential, IHaveCredentialProvider
        {
            /// <summary>
            /// Credential
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-registrycredential.html#cfn-codebuild-project-registrycredential-credential
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Credential { get; set; }
            /// <summary>
            /// CredentialProvider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-registrycredential.html#cfn-codebuild-project-registrycredential-credentialprovider
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CredentialProvider { get; set; }
        }

        public class S3LogsConfig : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveEncryptionDisabled_Boolean, IHaveLocation
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-s3logsconfig.html#cfn-codebuild-project-s3logsconfig-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// EncryptionDisabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-s3logsconfig.html#cfn-codebuild-project-s3logsconfig-encryptiondisabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EncryptionDisabled { get; set; }
            /// <summary>
            /// Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-s3logsconfig.html#cfn-codebuild-project-s3logsconfig-location
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Location { get; set; }
        }

        public class ScopeConfiguration : Humidifier.Base.BaseSubResource, IHaveScope, IHaveDomain, IHaveName
        {
            /// <summary>
            /// Scope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-scopeconfiguration.html#cfn-codebuild-project-scopeconfiguration-scope
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Scope { get; set; }
            /// <summary>
            /// Domain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-scopeconfiguration.html#cfn-codebuild-project-scopeconfiguration-domain
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Domain { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-scopeconfiguration.html#cfn-codebuild-project-scopeconfiguration-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class Source : Humidifier.Base.BaseSubResource, IHaveType, IHaveReportBuildStatus_Boolean, IHaveCodeBuildProjectTypesSourceAuthAuth, IHaveSourceIdentifier, IHaveBuildSpec, IHaveGitCloneDepth_Integer, IHaveCodeBuildProjectTypesBuildStatusConfigBuildStatusConfig, IHaveCodeBuildProjectTypesGitSubmodulesConfigGitSubmodulesConfig, IHaveInsecureSsl_Boolean, IHaveLocation
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-source.html#cfn-codebuild-project-source-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// ReportBuildStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-source.html#cfn-codebuild-project-source-reportbuildstatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ReportBuildStatus { get; set; }
            /// <summary>
            /// Auth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-source.html#cfn-codebuild-project-source-auth
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SourceAuth
            /// </summary>
            public Union<Humidifier.CodeBuild.ProjectTypes.SourceAuth, BaseFunction>? Auth { get; set; }
            /// <summary>
            /// SourceIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-source.html#cfn-codebuild-project-source-sourceidentifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceIdentifier { get; set; }
            /// <summary>
            /// BuildSpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-source.html#cfn-codebuild-project-source-buildspec
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BuildSpec { get; set; }
            /// <summary>
            /// GitCloneDepth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-source.html#cfn-codebuild-project-source-gitclonedepth
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? GitCloneDepth { get; set; }
            /// <summary>
            /// BuildStatusConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-source.html#cfn-codebuild-project-source-buildstatusconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BuildStatusConfig
            /// </summary>
            public Union<Humidifier.CodeBuild.ProjectTypes.BuildStatusConfig, BaseFunction>? BuildStatusConfig { get; set; }
            /// <summary>
            /// GitSubmodulesConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-source.html#cfn-codebuild-project-source-gitsubmodulesconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GitSubmodulesConfig
            /// </summary>
            public Union<Humidifier.CodeBuild.ProjectTypes.GitSubmodulesConfig, BaseFunction>? GitSubmodulesConfig { get; set; }
            /// <summary>
            /// InsecureSsl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-source.html#cfn-codebuild-project-source-insecuressl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? InsecureSsl { get; set; }
            /// <summary>
            /// Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-source.html#cfn-codebuild-project-source-location
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Location { get; set; }
        }

        public class SourceAuth : Humidifier.Base.BaseSubResource, IHaveType, IHaveResource
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-sourceauth.html#cfn-codebuild-project-sourceauth-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Resource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-sourceauth.html#cfn-codebuild-project-sourceauth-resource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Resource { get; set; }
        }

        public class VpcConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfSubnets, IHaveVpcId, IHaveStringListOfSecurityGroupIds
        {
            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-vpcconfig.html#cfn-codebuild-project-vpcconfig-subnets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Subnets { get; set; }
            /// <summary>
            /// VpcId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-vpcconfig.html#cfn-codebuild-project-vpcconfig-vpcid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VpcId { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codebuild-project-vpcconfig.html#cfn-codebuild-project-vpcconfig-securitygroupids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        }
    }
}