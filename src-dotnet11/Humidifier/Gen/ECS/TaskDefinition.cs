namespace Humidifier.ECS
{
    using global::System.Collections.Generic;
    using TaskDefinitionTypes;

    public class TaskDefinition : Humidifier.Base.BaseResource, IHaveTags, IHaveTaskRoleArn, IHaveIpcMode, IHaveMemory, IHaveListOfECSTaskDefinitionTypesTaskDefinitionPlacementConstraintPlacementConstraints, IHaveCpu, IHaveStringListOfRequiresCompatibilities, IHaveNetworkMode, IHavePidMode, IHaveEnableFaultInjection_Boolean, IHaveExecutionRoleArn, IHaveECSTaskDefinitionTypesRuntimePlatformRuntimePlatform, IHaveECSTaskDefinitionTypesProxyConfigurationProxyConfiguration, IHaveListOfECSTaskDefinitionTypesVolumeVolumes, IHaveListOfECSTaskDefinitionTypesContainerDefinitionContainerDefinitions, IHaveFamily, IHaveECSTaskDefinitionTypesEphemeralStorageEphemeralStorage
    {
        public class Attributes
        {
            public static string TaskDefinitionArn =  "TaskDefinitionArn" ;
        }

        public override string AWSTypeName { get => AWS.ECS.TaskDefinition; }
        /// <summary>
        /// TaskRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-taskdefinition.html#cfn-ecs-taskdefinition-taskrolearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TaskRoleArn { get; set; }
        /// <summary>
        /// IpcMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-taskdefinition.html#cfn-ecs-taskdefinition-ipcmode
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? IpcMode { get; set; }
        /// <summary>
        /// Memory
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-taskdefinition.html#cfn-ecs-taskdefinition-memory
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Memory { get; set; }
        /// <summary>
        /// PlacementConstraints
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-taskdefinition.html#cfn-ecs-taskdefinition-placementconstraints
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: TaskDefinitionPlacementConstraint
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ECS.TaskDefinitionTypes.TaskDefinitionPlacementConstraint>, IReadOnlyList<Union<Humidifier.ECS.TaskDefinitionTypes.TaskDefinitionPlacementConstraint, BaseFunction>>, BaseFunction>? PlacementConstraints { get; set; }
        /// <summary>
        /// Cpu
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-taskdefinition.html#cfn-ecs-taskdefinition-cpu
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Cpu { get; set; }
        /// <summary>
        /// RequiresCompatibilities
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-taskdefinition.html#cfn-ecs-taskdefinition-requirescompatibilities
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? RequiresCompatibilities { get; set; }
        /// <summary>
        /// NetworkMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-taskdefinition.html#cfn-ecs-taskdefinition-networkmode
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? NetworkMode { get; set; }
        /// <summary>
        /// PidMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-taskdefinition.html#cfn-ecs-taskdefinition-pidmode
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PidMode { get; set; }
        /// <summary>
        /// EnableFaultInjection
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-taskdefinition.html#cfn-ecs-taskdefinition-enablefaultinjection
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? EnableFaultInjection { get; set; }
        /// <summary>
        /// ExecutionRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-taskdefinition.html#cfn-ecs-taskdefinition-executionrolearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ExecutionRoleArn { get; set; }
        /// <summary>
        /// RuntimePlatform
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-taskdefinition.html#cfn-ecs-taskdefinition-runtimeplatform
        /// Required: False
        /// UpdateType: Immutable
        /// Type: RuntimePlatform
        /// </summary>
        public Union<Humidifier.ECS.TaskDefinitionTypes.RuntimePlatform, BaseFunction>? RuntimePlatform { get; set; }
        /// <summary>
        /// ProxyConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-taskdefinition.html#cfn-ecs-taskdefinition-proxyconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ProxyConfiguration
        /// </summary>
        public Union<Humidifier.ECS.TaskDefinitionTypes.ProxyConfiguration, BaseFunction>? ProxyConfiguration { get; set; }
        /// <summary>
        /// Volumes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-taskdefinition.html#cfn-ecs-taskdefinition-volumes
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Volume
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ECS.TaskDefinitionTypes.Volume>, IReadOnlyList<Union<Humidifier.ECS.TaskDefinitionTypes.Volume, BaseFunction>>, BaseFunction>? Volumes { get; set; }
        /// <summary>
        /// ContainerDefinitions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-taskdefinition.html#cfn-ecs-taskdefinition-containerdefinitions
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: ContainerDefinition
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ECS.TaskDefinitionTypes.ContainerDefinition>, IReadOnlyList<Union<Humidifier.ECS.TaskDefinitionTypes.ContainerDefinition, BaseFunction>>, BaseFunction>? ContainerDefinitions { get; set; }
        /// <summary>
        /// Family
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-taskdefinition.html#cfn-ecs-taskdefinition-family
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Family { get; set; }
        /// <summary>
        /// EphemeralStorage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-taskdefinition.html#cfn-ecs-taskdefinition-ephemeralstorage
        /// Required: False
        /// UpdateType: Immutable
        /// Type: EphemeralStorage
        /// </summary>
        public Union<Humidifier.ECS.TaskDefinitionTypes.EphemeralStorage, BaseFunction>? EphemeralStorage { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-taskdefinition.html#cfn-ecs-taskdefinition-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace TaskDefinitionTypes
    {
        public class AuthorizationConfig : Humidifier.Base.BaseSubResource, IHaveIAM, IHaveAccessPointId
        {
            /// <summary>
            /// IAM
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-authorizationconfig.html#cfn-ecs-taskdefinition-authorizationconfig-iam
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IAM { get; set; }
            /// <summary>
            /// AccessPointId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-authorizationconfig.html#cfn-ecs-taskdefinition-authorizationconfig-accesspointid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccessPointId { get; set; }
        }

        public class ContainerDefinition : Humidifier.Base.BaseSubResource, IHaveUser, IHaveListOfECSTaskDefinitionTypesSecretSecrets, IHaveMemory_Integer, IHavePrivileged_Boolean, IHaveECSTaskDefinitionTypesHealthCheckHealthCheck, IHaveStartTimeout_Integer, IHaveListOfECSTaskDefinitionTypesVolumeFromVolumesFrom, IHaveCpu_Integer, IHaveStringListOfEntryPoint, IHaveStringListOfDnsServers, IHaveReadonlyRootFilesystem_Boolean, IHaveImage, IHaveEssential_Boolean, IHaveECSTaskDefinitionTypesLogConfigurationLogConfiguration, IHaveListOfECSTaskDefinitionTypesResourceRequirementResourceRequirements, IHaveListOfECSTaskDefinitionTypesEnvironmentFileEnvironmentFiles, IHaveName, IHaveECSTaskDefinitionTypesFirelensConfigurationFirelensConfiguration, IHaveStringListOfDockerSecurityOptions, IHaveListOfECSTaskDefinitionTypesSystemControlSystemControls, IHaveInteractive_Boolean, IHaveStringListOfDnsSearchDomains, IHaveStringListOfCredentialSpecs, IHaveListOfECSTaskDefinitionTypesUlimitUlimits, IHaveStopTimeout_Integer, IHaveWorkingDirectory, IHaveMemoryReservation_Integer, IHaveECSTaskDefinitionTypesRepositoryCredentialsRepositoryCredentials, IHaveListOfECSTaskDefinitionTypesHostEntryExtraHosts, IHaveHostname, IHaveECSTaskDefinitionTypesLinuxParametersLinuxParameters, IHaveVersionConsistency, IHaveECSTaskDefinitionTypesRestartPolicyRestartPolicy, IHaveDisableNetworking_Boolean, IHavePseudoTerminal_Boolean, IHaveListOfECSTaskDefinitionTypesMountPointMountPoints, IHaveListOfECSTaskDefinitionTypesContainerDependencyDependsOn, IHaveStringDictionaryOfDockerLabels, IHaveListOfECSTaskDefinitionTypesPortMappingPortMappings, IHaveStringListOfCommand, IHaveListOfECSTaskDefinitionTypesKeyValuePairEnvironment, IHaveStringListOfLinks
        {
            /// <summary>
            /// User
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinition.html#cfn-ecs-taskdefinition-containerdefinition-user
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? User { get; set; }
            /// <summary>
            /// Secrets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinition.html#cfn-ecs-taskdefinition-containerdefinition-secrets
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Secret
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECS.TaskDefinitionTypes.Secret>, IReadOnlyList<Union<Humidifier.ECS.TaskDefinitionTypes.Secret, BaseFunction>>, BaseFunction>? Secrets { get; set; }
            /// <summary>
            /// Memory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinition.html#cfn-ecs-taskdefinition-containerdefinition-memory
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Memory { get; set; }
            /// <summary>
            /// Privileged
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinition.html#cfn-ecs-taskdefinition-containerdefinition-privileged
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Privileged { get; set; }
            /// <summary>
            /// HealthCheck
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinition.html#cfn-ecs-taskdefinition-containerdefinition-healthcheck
            /// Required: False
            /// UpdateType: Immutable
            /// Type: HealthCheck
            /// </summary>
            public Union<Humidifier.ECS.TaskDefinitionTypes.HealthCheck, BaseFunction>? HealthCheck { get; set; }
            /// <summary>
            /// StartTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinition.html#cfn-ecs-taskdefinition-containerdefinition-starttimeout
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? StartTimeout { get; set; }
            /// <summary>
            /// VolumesFrom
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinition.html#cfn-ecs-taskdefinition-containerdefinition-volumesfrom
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: VolumeFrom
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECS.TaskDefinitionTypes.VolumeFrom>, IReadOnlyList<Union<Humidifier.ECS.TaskDefinitionTypes.VolumeFrom, BaseFunction>>, BaseFunction>? VolumesFrom { get; set; }
            /// <summary>
            /// Cpu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinition.html#cfn-ecs-taskdefinition-containerdefinition-cpu
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Cpu { get; set; }
            /// <summary>
            /// EntryPoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinition.html#cfn-ecs-taskdefinition-containerdefinition-entrypoint
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EntryPoint { get; set; }
            /// <summary>
            /// DnsServers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinition.html#cfn-ecs-taskdefinition-containerdefinition-dnsservers
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DnsServers { get; set; }
            /// <summary>
            /// ReadonlyRootFilesystem
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinition.html#cfn-ecs-taskdefinition-containerdefinition-readonlyrootfilesystem
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ReadonlyRootFilesystem { get; set; }
            /// <summary>
            /// Image
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinition.html#cfn-ecs-taskdefinition-containerdefinition-image
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Image { get; set; }
            /// <summary>
            /// Essential
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinition.html#cfn-ecs-taskdefinition-containerdefinition-essential
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Essential { get; set; }
            /// <summary>
            /// LogConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinition.html#cfn-ecs-taskdefinition-containerdefinition-logconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: LogConfiguration
            /// </summary>
            public Union<Humidifier.ECS.TaskDefinitionTypes.LogConfiguration, BaseFunction>? LogConfiguration { get; set; }
            /// <summary>
            /// ResourceRequirements
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinition.html#cfn-ecs-taskdefinition-containerdefinition-resourcerequirements
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ResourceRequirement
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECS.TaskDefinitionTypes.ResourceRequirement>, IReadOnlyList<Union<Humidifier.ECS.TaskDefinitionTypes.ResourceRequirement, BaseFunction>>, BaseFunction>? ResourceRequirements { get; set; }
            /// <summary>
            /// EnvironmentFiles
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinition.html#cfn-ecs-taskdefinition-containerdefinition-environmentfiles
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: EnvironmentFile
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECS.TaskDefinitionTypes.EnvironmentFile>, IReadOnlyList<Union<Humidifier.ECS.TaskDefinitionTypes.EnvironmentFile, BaseFunction>>, BaseFunction>? EnvironmentFiles { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinition.html#cfn-ecs-taskdefinition-containerdefinition-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
            /// <summary>
            /// FirelensConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinition.html#cfn-ecs-taskdefinition-containerdefinition-firelensconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: FirelensConfiguration
            /// </summary>
            public Union<Humidifier.ECS.TaskDefinitionTypes.FirelensConfiguration, BaseFunction>? FirelensConfiguration { get; set; }
            /// <summary>
            /// DockerSecurityOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinition.html#cfn-ecs-taskdefinition-containerdefinition-dockersecurityoptions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DockerSecurityOptions { get; set; }
            /// <summary>
            /// SystemControls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinition.html#cfn-ecs-taskdefinition-containerdefinition-systemcontrols
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: SystemControl
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECS.TaskDefinitionTypes.SystemControl>, IReadOnlyList<Union<Humidifier.ECS.TaskDefinitionTypes.SystemControl, BaseFunction>>, BaseFunction>? SystemControls { get; set; }
            /// <summary>
            /// Interactive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinition.html#cfn-ecs-taskdefinition-containerdefinition-interactive
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Interactive { get; set; }
            /// <summary>
            /// DnsSearchDomains
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinition.html#cfn-ecs-taskdefinition-containerdefinition-dnssearchdomains
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DnsSearchDomains { get; set; }
            /// <summary>
            /// CredentialSpecs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinition.html#cfn-ecs-taskdefinition-containerdefinition-credentialspecs
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CredentialSpecs { get; set; }
            /// <summary>
            /// Ulimits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinition.html#cfn-ecs-taskdefinition-containerdefinition-ulimits
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Ulimit
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECS.TaskDefinitionTypes.Ulimit>, IReadOnlyList<Union<Humidifier.ECS.TaskDefinitionTypes.Ulimit, BaseFunction>>, BaseFunction>? Ulimits { get; set; }
            /// <summary>
            /// StopTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinition.html#cfn-ecs-taskdefinition-containerdefinition-stoptimeout
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? StopTimeout { get; set; }
            /// <summary>
            /// WorkingDirectory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinition.html#cfn-ecs-taskdefinition-containerdefinition-workingdirectory
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WorkingDirectory { get; set; }
            /// <summary>
            /// MemoryReservation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinition.html#cfn-ecs-taskdefinition-containerdefinition-memoryreservation
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MemoryReservation { get; set; }
            /// <summary>
            /// RepositoryCredentials
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinition.html#cfn-ecs-taskdefinition-containerdefinition-repositorycredentials
            /// Required: False
            /// UpdateType: Immutable
            /// Type: RepositoryCredentials
            /// </summary>
            public Union<Humidifier.ECS.TaskDefinitionTypes.RepositoryCredentials, BaseFunction>? RepositoryCredentials { get; set; }
            /// <summary>
            /// ExtraHosts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinition.html#cfn-ecs-taskdefinition-containerdefinition-extrahosts
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: HostEntry
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECS.TaskDefinitionTypes.HostEntry>, IReadOnlyList<Union<Humidifier.ECS.TaskDefinitionTypes.HostEntry, BaseFunction>>, BaseFunction>? ExtraHosts { get; set; }
            /// <summary>
            /// Hostname
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinition.html#cfn-ecs-taskdefinition-containerdefinition-hostname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Hostname { get; set; }
            /// <summary>
            /// LinuxParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinition.html#cfn-ecs-taskdefinition-containerdefinition-linuxparameters
            /// Required: False
            /// UpdateType: Immutable
            /// Type: LinuxParameters
            /// </summary>
            public Union<Humidifier.ECS.TaskDefinitionTypes.LinuxParameters, BaseFunction>? LinuxParameters { get; set; }
            /// <summary>
            /// VersionConsistency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinition.html#cfn-ecs-taskdefinition-containerdefinition-versionconsistency
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VersionConsistency { get; set; }
            /// <summary>
            /// RestartPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinition.html#cfn-ecs-taskdefinition-containerdefinition-restartpolicy
            /// Required: False
            /// UpdateType: Immutable
            /// Type: RestartPolicy
            /// </summary>
            public Union<Humidifier.ECS.TaskDefinitionTypes.RestartPolicy, BaseFunction>? RestartPolicy { get; set; }
            /// <summary>
            /// DisableNetworking
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinition.html#cfn-ecs-taskdefinition-containerdefinition-disablenetworking
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DisableNetworking { get; set; }
            /// <summary>
            /// PseudoTerminal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinition.html#cfn-ecs-taskdefinition-containerdefinition-pseudoterminal
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? PseudoTerminal { get; set; }
            /// <summary>
            /// MountPoints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinition.html#cfn-ecs-taskdefinition-containerdefinition-mountpoints
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: MountPoint
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECS.TaskDefinitionTypes.MountPoint>, IReadOnlyList<Union<Humidifier.ECS.TaskDefinitionTypes.MountPoint, BaseFunction>>, BaseFunction>? MountPoints { get; set; }
            /// <summary>
            /// DependsOn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinition.html#cfn-ecs-taskdefinition-containerdefinition-dependson
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ContainerDependency
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECS.TaskDefinitionTypes.ContainerDependency>, IReadOnlyList<Union<Humidifier.ECS.TaskDefinitionTypes.ContainerDependency, BaseFunction>>, BaseFunction>? DependsOn { get; set; }
            /// <summary>
            /// DockerLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinition.html#cfn-ecs-taskdefinition-containerdefinition-dockerlabels
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? DockerLabels { get; set; }
            /// <summary>
            /// PortMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinition.html#cfn-ecs-taskdefinition-containerdefinition-portmappings
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: PortMapping
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECS.TaskDefinitionTypes.PortMapping>, IReadOnlyList<Union<Humidifier.ECS.TaskDefinitionTypes.PortMapping, BaseFunction>>, BaseFunction>? PortMappings { get; set; }
            /// <summary>
            /// Command
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinition.html#cfn-ecs-taskdefinition-containerdefinition-command
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Command { get; set; }
            /// <summary>
            /// Environment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinition.html#cfn-ecs-taskdefinition-containerdefinition-environment
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: KeyValuePair
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECS.TaskDefinitionTypes.KeyValuePair>, IReadOnlyList<Union<Humidifier.ECS.TaskDefinitionTypes.KeyValuePair, BaseFunction>>, BaseFunction>? Environment { get; set; }
            /// <summary>
            /// Links
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdefinition.html#cfn-ecs-taskdefinition-containerdefinition-links
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Links { get; set; }
        }

        public class ContainerDependency : Humidifier.Base.BaseSubResource, IHaveCondition, IHaveContainerName
        {
            /// <summary>
            /// Condition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdependency.html#cfn-ecs-taskdefinition-containerdependency-condition
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Condition { get; set; }
            /// <summary>
            /// ContainerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-containerdependency.html#cfn-ecs-taskdefinition-containerdependency-containername
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContainerName { get; set; }
        }

        public class Device : Humidifier.Base.BaseSubResource, IHaveHostPath, IHaveStringListOfPermissions, IHaveContainerPath
        {
            /// <summary>
            /// HostPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-device.html#cfn-ecs-taskdefinition-device-hostpath
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HostPath { get; set; }
            /// <summary>
            /// Permissions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-device.html#cfn-ecs-taskdefinition-device-permissions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Permissions { get; set; }
            /// <summary>
            /// ContainerPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-device.html#cfn-ecs-taskdefinition-device-containerpath
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContainerPath { get; set; }
        }

        public class DockerVolumeConfiguration : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfDriverOpts, IHaveScope, IHaveAutoprovision_Boolean, IHaveDriver, IHaveStringDictionaryOfLabels
        {
            /// <summary>
            /// DriverOpts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-dockervolumeconfiguration.html#cfn-ecs-taskdefinition-dockervolumeconfiguration-driveropts
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? DriverOpts { get; set; }
            /// <summary>
            /// Scope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-dockervolumeconfiguration.html#cfn-ecs-taskdefinition-dockervolumeconfiguration-scope
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Scope { get; set; }
            /// <summary>
            /// Autoprovision
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-dockervolumeconfiguration.html#cfn-ecs-taskdefinition-dockervolumeconfiguration-autoprovision
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Autoprovision { get; set; }
            /// <summary>
            /// Driver
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-dockervolumeconfiguration.html#cfn-ecs-taskdefinition-dockervolumeconfiguration-driver
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Driver { get; set; }
            /// <summary>
            /// Labels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-dockervolumeconfiguration.html#cfn-ecs-taskdefinition-dockervolumeconfiguration-labels
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Labels { get; set; }
        }

        public class EFSVolumeConfiguration : Humidifier.Base.BaseSubResource, IHaveFilesystemId, IHaveTransitEncryption, IHaveECSTaskDefinitionTypesAuthorizationConfigAuthorizationConfig, IHaveRootDirectory, IHaveTransitEncryptionPort_Integer
        {
            /// <summary>
            /// FilesystemId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-efsvolumeconfiguration.html#cfn-ecs-taskdefinition-efsvolumeconfiguration-filesystemid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FilesystemId { get; set; }
            /// <summary>
            /// TransitEncryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-efsvolumeconfiguration.html#cfn-ecs-taskdefinition-efsvolumeconfiguration-transitencryption
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TransitEncryption { get; set; }
            /// <summary>
            /// AuthorizationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-efsvolumeconfiguration.html#cfn-ecs-taskdefinition-efsvolumeconfiguration-authorizationconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AuthorizationConfig
            /// </summary>
            public Union<Humidifier.ECS.TaskDefinitionTypes.AuthorizationConfig, BaseFunction>? AuthorizationConfig { get; set; }
            /// <summary>
            /// RootDirectory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-efsvolumeconfiguration.html#cfn-ecs-taskdefinition-efsvolumeconfiguration-rootdirectory
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RootDirectory { get; set; }
            /// <summary>
            /// TransitEncryptionPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-efsvolumeconfiguration.html#cfn-ecs-taskdefinition-efsvolumeconfiguration-transitencryptionport
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TransitEncryptionPort { get; set; }
        }

        public class EnvironmentFile : Humidifier.Base.BaseSubResource, IHaveType, IHaveValue
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-environmentfile.html#cfn-ecs-taskdefinition-environmentfile-type
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-environmentfile.html#cfn-ecs-taskdefinition-environmentfile-value
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
        }

        public class EphemeralStorage : Humidifier.Base.BaseSubResource, IHaveSizeInGiB_Integer
        {
            /// <summary>
            /// SizeInGiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-ephemeralstorage.html#cfn-ecs-taskdefinition-ephemeralstorage-sizeingib
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SizeInGiB { get; set; }
        }

        public class FSxAuthorizationConfig : Humidifier.Base.BaseSubResource, IHaveCredentialsParameter, IHaveDomain
        {
            /// <summary>
            /// CredentialsParameter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-fsxauthorizationconfig.html#cfn-ecs-taskdefinition-fsxauthorizationconfig-credentialsparameter
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CredentialsParameter { get; set; }
            /// <summary>
            /// Domain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-fsxauthorizationconfig.html#cfn-ecs-taskdefinition-fsxauthorizationconfig-domain
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Domain { get; set; }
        }

        public class FSxWindowsFileServerVolumeConfiguration : Humidifier.Base.BaseSubResource, IHaveECSTaskDefinitionTypesFSxAuthorizationConfigAuthorizationConfig, IHaveFileSystemId, IHaveRootDirectory
        {
            /// <summary>
            /// AuthorizationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-fsxwindowsfileservervolumeconfiguration.html#cfn-ecs-taskdefinition-fsxwindowsfileservervolumeconfiguration-authorizationconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: FSxAuthorizationConfig
            /// </summary>
            public Union<Humidifier.ECS.TaskDefinitionTypes.FSxAuthorizationConfig, BaseFunction>? AuthorizationConfig { get; set; }
            /// <summary>
            /// FileSystemId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-fsxwindowsfileservervolumeconfiguration.html#cfn-ecs-taskdefinition-fsxwindowsfileservervolumeconfiguration-filesystemid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FileSystemId { get; set; }
            /// <summary>
            /// RootDirectory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-fsxwindowsfileservervolumeconfiguration.html#cfn-ecs-taskdefinition-fsxwindowsfileservervolumeconfiguration-rootdirectory
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RootDirectory { get; set; }
        }

        public class FirelensConfiguration : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfOptions, IHaveType
        {
            /// <summary>
            /// Options
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-firelensconfiguration.html#cfn-ecs-taskdefinition-firelensconfiguration-options
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Options { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-firelensconfiguration.html#cfn-ecs-taskdefinition-firelensconfiguration-type
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
        }

        public class HealthCheck : Humidifier.Base.BaseSubResource, IHaveStringListOfCommand, IHaveTimeout_Integer, IHaveRetries_Integer, IHaveInterval_Integer, IHaveStartPeriod_Integer
        {
            /// <summary>
            /// Command
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-healthcheck.html#cfn-ecs-taskdefinition-healthcheck-command
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Command { get; set; }
            /// <summary>
            /// Timeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-healthcheck.html#cfn-ecs-taskdefinition-healthcheck-timeout
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Timeout { get; set; }
            /// <summary>
            /// Retries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-healthcheck.html#cfn-ecs-taskdefinition-healthcheck-retries
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Retries { get; set; }
            /// <summary>
            /// Interval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-healthcheck.html#cfn-ecs-taskdefinition-healthcheck-interval
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Interval { get; set; }
            /// <summary>
            /// StartPeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-healthcheck.html#cfn-ecs-taskdefinition-healthcheck-startperiod
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? StartPeriod { get; set; }
        }

        public class HostEntry : Humidifier.Base.BaseSubResource, IHaveHostname, IHaveIpAddress
        {
            /// <summary>
            /// Hostname
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-hostentry.html#cfn-ecs-taskdefinition-hostentry-hostname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Hostname { get; set; }
            /// <summary>
            /// IpAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-hostentry.html#cfn-ecs-taskdefinition-hostentry-ipaddress
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IpAddress { get; set; }
        }

        public class HostVolumeProperties : Humidifier.Base.BaseSubResource, IHaveSourcePath
        {
            /// <summary>
            /// SourcePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-hostvolumeproperties.html#cfn-ecs-taskdefinition-hostvolumeproperties-sourcepath
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourcePath { get; set; }
        }

        public class KernelCapabilities : Humidifier.Base.BaseSubResource, IHaveStringListOfAdd, IHaveStringListOfDrop
        {
            /// <summary>
            /// Add
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-kernelcapabilities.html#cfn-ecs-taskdefinition-kernelcapabilities-add
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Add { get; set; }
            /// <summary>
            /// Drop
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-kernelcapabilities.html#cfn-ecs-taskdefinition-kernelcapabilities-drop
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Drop { get; set; }
        }

        public class KeyValuePair : Humidifier.Base.BaseSubResource, IHaveValue, IHaveName
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-keyvaluepair.html#cfn-ecs-taskdefinition-keyvaluepair-value
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-keyvaluepair.html#cfn-ecs-taskdefinition-keyvaluepair-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class LinuxParameters : Humidifier.Base.BaseSubResource, IHaveECSTaskDefinitionTypesKernelCapabilitiesCapabilities, IHaveSwappiness_Integer, IHaveListOfECSTaskDefinitionTypesTmpfsTmpfs, IHaveSharedMemorySize_Integer, IHaveListOfECSTaskDefinitionTypesDeviceDevices, IHaveInitProcessEnabled_Boolean, IHaveMaxSwap_Integer
        {
            /// <summary>
            /// Capabilities
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-linuxparameters.html#cfn-ecs-taskdefinition-linuxparameters-capabilities
            /// Required: False
            /// UpdateType: Immutable
            /// Type: KernelCapabilities
            /// </summary>
            public Union<Humidifier.ECS.TaskDefinitionTypes.KernelCapabilities, BaseFunction>? Capabilities { get; set; }
            /// <summary>
            /// Swappiness
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-linuxparameters.html#cfn-ecs-taskdefinition-linuxparameters-swappiness
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Swappiness { get; set; }
            /// <summary>
            /// Tmpfs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-linuxparameters.html#cfn-ecs-taskdefinition-linuxparameters-tmpfs
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Tmpfs
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECS.TaskDefinitionTypes.Tmpfs>, IReadOnlyList<Union<Humidifier.ECS.TaskDefinitionTypes.Tmpfs, BaseFunction>>, BaseFunction>? Tmpfs { get; set; }
            /// <summary>
            /// SharedMemorySize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-linuxparameters.html#cfn-ecs-taskdefinition-linuxparameters-sharedmemorysize
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SharedMemorySize { get; set; }
            /// <summary>
            /// Devices
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-linuxparameters.html#cfn-ecs-taskdefinition-linuxparameters-devices
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Device
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECS.TaskDefinitionTypes.Device>, IReadOnlyList<Union<Humidifier.ECS.TaskDefinitionTypes.Device, BaseFunction>>, BaseFunction>? Devices { get; set; }
            /// <summary>
            /// InitProcessEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-linuxparameters.html#cfn-ecs-taskdefinition-linuxparameters-initprocessenabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? InitProcessEnabled { get; set; }
            /// <summary>
            /// MaxSwap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-linuxparameters.html#cfn-ecs-taskdefinition-linuxparameters-maxswap
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxSwap { get; set; }
        }

        public class LogConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfECSTaskDefinitionTypesSecretSecretOptions, IHaveStringDictionaryOfOptions, IHaveLogDriver
        {
            /// <summary>
            /// SecretOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-logconfiguration.html#cfn-ecs-taskdefinition-logconfiguration-secretoptions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Secret
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECS.TaskDefinitionTypes.Secret>, IReadOnlyList<Union<Humidifier.ECS.TaskDefinitionTypes.Secret, BaseFunction>>, BaseFunction>? SecretOptions { get; set; }
            /// <summary>
            /// Options
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-logconfiguration.html#cfn-ecs-taskdefinition-logconfiguration-options
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Options { get; set; }
            /// <summary>
            /// LogDriver
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-logconfiguration.html#cfn-ecs-taskdefinition-logconfiguration-logdriver
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogDriver { get; set; }
        }

        public class MountPoint : Humidifier.Base.BaseSubResource, IHaveReadOnly_Boolean, IHaveSourceVolume, IHaveContainerPath
        {
            /// <summary>
            /// ReadOnly
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-mountpoint.html#cfn-ecs-taskdefinition-mountpoint-readonly
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ReadOnly { get; set; }
            /// <summary>
            /// SourceVolume
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-mountpoint.html#cfn-ecs-taskdefinition-mountpoint-sourcevolume
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceVolume { get; set; }
            /// <summary>
            /// ContainerPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-mountpoint.html#cfn-ecs-taskdefinition-mountpoint-containerpath
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContainerPath { get; set; }
        }

        public class NvidiaMpsAllocation : Humidifier.Base.BaseSubResource, IHaveMemory_Integer, IHaveMaxComputePercent_Integer
        {
            /// <summary>
            /// Memory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-nvidiampsallocation.html#cfn-ecs-taskdefinition-nvidiampsallocation-memory
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Memory { get; set; }
            /// <summary>
            /// MaxComputePercent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-nvidiampsallocation.html#cfn-ecs-taskdefinition-nvidiampsallocation-maxcomputepercent
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxComputePercent { get; set; }
        }

        public class PortMapping : Humidifier.Base.BaseSubResource, IHaveAppProtocol, IHaveContainerPortRange, IHaveHostPort_Integer, IHaveContainerPort_Integer, IHaveProtocol, IHaveName
        {
            /// <summary>
            /// AppProtocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-portmapping.html#cfn-ecs-taskdefinition-portmapping-appprotocol
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AppProtocol { get; set; }
            /// <summary>
            /// ContainerPortRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-portmapping.html#cfn-ecs-taskdefinition-portmapping-containerportrange
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContainerPortRange { get; set; }
            /// <summary>
            /// HostPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-portmapping.html#cfn-ecs-taskdefinition-portmapping-hostport
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? HostPort { get; set; }
            /// <summary>
            /// ContainerPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-portmapping.html#cfn-ecs-taskdefinition-portmapping-containerport
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ContainerPort { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-portmapping.html#cfn-ecs-taskdefinition-portmapping-protocol
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Protocol { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-portmapping.html#cfn-ecs-taskdefinition-portmapping-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class ProxyConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfECSTaskDefinitionTypesKeyValuePairProxyConfigurationProperties, IHaveType, IHaveContainerName
        {
            /// <summary>
            /// ProxyConfigurationProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-proxyconfiguration.html#cfn-ecs-taskdefinition-proxyconfiguration-proxyconfigurationproperties
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: KeyValuePair
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECS.TaskDefinitionTypes.KeyValuePair>, IReadOnlyList<Union<Humidifier.ECS.TaskDefinitionTypes.KeyValuePair, BaseFunction>>, BaseFunction>? ProxyConfigurationProperties { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-proxyconfiguration.html#cfn-ecs-taskdefinition-proxyconfiguration-type
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// ContainerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-proxyconfiguration.html#cfn-ecs-taskdefinition-proxyconfiguration-containername
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContainerName { get; set; }
        }

        public class RepositoryCredentials : Humidifier.Base.BaseSubResource, IHaveCredentialsParameter
        {
            /// <summary>
            /// CredentialsParameter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-repositorycredentials.html#cfn-ecs-taskdefinition-repositorycredentials-credentialsparameter
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CredentialsParameter { get; set; }
        }

        public class ResourceRequirement : Humidifier.Base.BaseSubResource, IHaveType, IHaveECSTaskDefinitionTypesSharingStrategySharingStrategy, IHaveValue
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-resourcerequirement.html#cfn-ecs-taskdefinition-resourcerequirement-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// SharingStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-resourcerequirement.html#cfn-ecs-taskdefinition-resourcerequirement-sharingstrategy
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SharingStrategy
            /// </summary>
            public Union<Humidifier.ECS.TaskDefinitionTypes.SharingStrategy, BaseFunction>? SharingStrategy { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-resourcerequirement.html#cfn-ecs-taskdefinition-resourcerequirement-value
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
        }

        public class RestartPolicy : Humidifier.Base.BaseSubResource, IHaveIntegerListOfIgnoredExitCodes, IHaveRestartAttemptPeriod_Integer, IHaveEnabled_Boolean
        {
            /// <summary>
            /// IgnoredExitCodes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-restartpolicy.html#cfn-ecs-taskdefinition-restartpolicy-ignoredexitcodes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public Union<IReadOnlyList<int>, IReadOnlyList<Union<int, BaseFunction>>, BaseFunction>? IgnoredExitCodes { get; set; }
            /// <summary>
            /// RestartAttemptPeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-restartpolicy.html#cfn-ecs-taskdefinition-restartpolicy-restartattemptperiod
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RestartAttemptPeriod { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-restartpolicy.html#cfn-ecs-taskdefinition-restartpolicy-enabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class RuntimePlatform : Humidifier.Base.BaseSubResource, IHaveOperatingSystemFamily, IHaveCpuArchitecture
        {
            /// <summary>
            /// OperatingSystemFamily
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-runtimeplatform.html#cfn-ecs-taskdefinition-runtimeplatform-operatingsystemfamily
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OperatingSystemFamily { get; set; }
            /// <summary>
            /// CpuArchitecture
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-runtimeplatform.html#cfn-ecs-taskdefinition-runtimeplatform-cpuarchitecture
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CpuArchitecture { get; set; }
        }

        public class S3FilesVolumeConfiguration : Humidifier.Base.BaseSubResource, IHaveFileSystemArn, IHaveAccessPointArn, IHaveRootDirectory, IHaveTransitEncryptionPort_Integer
        {
            /// <summary>
            /// FileSystemArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-s3filesvolumeconfiguration.html#cfn-ecs-taskdefinition-s3filesvolumeconfiguration-filesystemarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FileSystemArn { get; set; }
            /// <summary>
            /// AccessPointArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-s3filesvolumeconfiguration.html#cfn-ecs-taskdefinition-s3filesvolumeconfiguration-accesspointarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccessPointArn { get; set; }
            /// <summary>
            /// RootDirectory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-s3filesvolumeconfiguration.html#cfn-ecs-taskdefinition-s3filesvolumeconfiguration-rootdirectory
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RootDirectory { get; set; }
            /// <summary>
            /// TransitEncryptionPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-s3filesvolumeconfiguration.html#cfn-ecs-taskdefinition-s3filesvolumeconfiguration-transitencryptionport
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TransitEncryptionPort { get; set; }
        }

        public class Secret : Humidifier.Base.BaseSubResource, IHaveValueFrom, IHaveName
        {
            /// <summary>
            /// ValueFrom
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-secret.html#cfn-ecs-taskdefinition-secret-valuefrom
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ValueFrom { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-secret.html#cfn-ecs-taskdefinition-secret-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class SharingStrategy : Humidifier.Base.BaseSubResource, IHaveECSTaskDefinitionTypesNvidiaMpsAllocationNvidiaMps
        {
            /// <summary>
            /// NvidiaMps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-sharingstrategy.html#cfn-ecs-taskdefinition-sharingstrategy-nvidiamps
            /// Required: True
            /// UpdateType: Immutable
            /// Type: NvidiaMpsAllocation
            /// </summary>
            public Union<Humidifier.ECS.TaskDefinitionTypes.NvidiaMpsAllocation, BaseFunction>? NvidiaMps { get; set; }
        }

        public class SystemControl : Humidifier.Base.BaseSubResource, IHaveValue, IHaveNamespace_
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-systemcontrol.html#cfn-ecs-taskdefinition-systemcontrol-value
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Namespace_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-systemcontrol.html#cfn-ecs-taskdefinition-systemcontrol-namespace
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Namespace_ { get; set; }
        }

        public class TaskDefinitionPlacementConstraint : Humidifier.Base.BaseSubResource, IHaveType, IHaveExpression
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-taskdefinitionplacementconstraint.html#cfn-ecs-taskdefinition-taskdefinitionplacementconstraint-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-taskdefinitionplacementconstraint.html#cfn-ecs-taskdefinition-taskdefinitionplacementconstraint-expression
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Expression { get; set; }
        }

        public class Tmpfs : Humidifier.Base.BaseSubResource, IHaveSize_Integer, IHaveContainerPath, IHaveStringListOfMountOptions
        {
            /// <summary>
            /// Size
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-tmpfs.html#cfn-ecs-taskdefinition-tmpfs-size
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Size { get; set; }
            /// <summary>
            /// ContainerPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-tmpfs.html#cfn-ecs-taskdefinition-tmpfs-containerpath
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContainerPath { get; set; }
            /// <summary>
            /// MountOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-tmpfs.html#cfn-ecs-taskdefinition-tmpfs-mountoptions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? MountOptions { get; set; }
        }

        public class Ulimit : Humidifier.Base.BaseSubResource, IHaveSoftLimit_Integer, IHaveHardLimit_Integer, IHaveName
        {
            /// <summary>
            /// SoftLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-ulimit.html#cfn-ecs-taskdefinition-ulimit-softlimit
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SoftLimit { get; set; }
            /// <summary>
            /// HardLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-ulimit.html#cfn-ecs-taskdefinition-ulimit-hardlimit
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? HardLimit { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-ulimit.html#cfn-ecs-taskdefinition-ulimit-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class Volume : Humidifier.Base.BaseSubResource, IHaveECSTaskDefinitionTypesEFSVolumeConfigurationEFSVolumeConfiguration, IHaveECSTaskDefinitionTypesS3FilesVolumeConfigurationS3FilesVolumeConfiguration, IHaveECSTaskDefinitionTypesHostVolumePropertiesHost, IHaveConfiguredAtLaunch_Boolean, IHaveECSTaskDefinitionTypesDockerVolumeConfigurationDockerVolumeConfiguration, IHaveECSTaskDefinitionTypesFSxWindowsFileServerVolumeConfigurationFSxWindowsFileServerVolumeConfiguration, IHaveName
        {
            /// <summary>
            /// EFSVolumeConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-volume.html#cfn-ecs-taskdefinition-volume-efsvolumeconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: EFSVolumeConfiguration
            /// </summary>
            public Union<Humidifier.ECS.TaskDefinitionTypes.EFSVolumeConfiguration, BaseFunction>? EFSVolumeConfiguration { get; set; }
            /// <summary>
            /// S3FilesVolumeConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-volume.html#cfn-ecs-taskdefinition-volume-s3filesvolumeconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3FilesVolumeConfiguration
            /// </summary>
            public Union<Humidifier.ECS.TaskDefinitionTypes.S3FilesVolumeConfiguration, BaseFunction>? S3FilesVolumeConfiguration { get; set; }
            /// <summary>
            /// Host
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-volume.html#cfn-ecs-taskdefinition-volume-host
            /// Required: False
            /// UpdateType: Immutable
            /// Type: HostVolumeProperties
            /// </summary>
            public Union<Humidifier.ECS.TaskDefinitionTypes.HostVolumeProperties, BaseFunction>? Host { get; set; }
            /// <summary>
            /// ConfiguredAtLaunch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-volume.html#cfn-ecs-taskdefinition-volume-configuredatlaunch
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ConfiguredAtLaunch { get; set; }
            /// <summary>
            /// DockerVolumeConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-volume.html#cfn-ecs-taskdefinition-volume-dockervolumeconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: DockerVolumeConfiguration
            /// </summary>
            public Union<Humidifier.ECS.TaskDefinitionTypes.DockerVolumeConfiguration, BaseFunction>? DockerVolumeConfiguration { get; set; }
            /// <summary>
            /// FSxWindowsFileServerVolumeConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-volume.html#cfn-ecs-taskdefinition-volume-fsxwindowsfileservervolumeconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: FSxWindowsFileServerVolumeConfiguration
            /// </summary>
            public Union<Humidifier.ECS.TaskDefinitionTypes.FSxWindowsFileServerVolumeConfiguration, BaseFunction>? FSxWindowsFileServerVolumeConfiguration { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-volume.html#cfn-ecs-taskdefinition-volume-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class VolumeFrom : Humidifier.Base.BaseSubResource, IHaveReadOnly_Boolean, IHaveSourceContainer
        {
            /// <summary>
            /// ReadOnly
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-volumefrom.html#cfn-ecs-taskdefinition-volumefrom-readonly
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ReadOnly { get; set; }
            /// <summary>
            /// SourceContainer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-volumefrom.html#cfn-ecs-taskdefinition-volumefrom-sourcecontainer
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceContainer { get; set; }
        }
    }
}