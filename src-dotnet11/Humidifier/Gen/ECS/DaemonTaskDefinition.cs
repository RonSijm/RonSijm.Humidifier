namespace Humidifier.ECS
{
    using global::System.Collections.Generic;
    using DaemonTaskDefinitionTypes;

    public class DaemonTaskDefinition : Humidifier.Base.BaseResource, IHaveTags, IHaveExecutionRoleArn, IHaveTaskRoleArn, IHaveIpcMode, IHaveListOfECSDaemonTaskDefinitionTypesVolumeVolumes, IHaveMemory, IHaveListOfECSDaemonTaskDefinitionTypesDaemonContainerDefinitionContainerDefinitions, IHaveFamily, IHaveCpu, IHavePidMode
    {
        public class Attributes
        {
            public static string DaemonTaskDefinitionArn =  "DaemonTaskDefinitionArn" ;
        }

        public override string AWSTypeName { get => AWS.ECS.DaemonTaskDefinition; }
        /// <summary>
        /// ExecutionRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-daemontaskdefinition.html#cfn-ecs-daemontaskdefinition-executionrolearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ExecutionRoleArn { get; set; }
        /// <summary>
        /// TaskRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-daemontaskdefinition.html#cfn-ecs-daemontaskdefinition-taskrolearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TaskRoleArn { get; set; }
        /// <summary>
        /// IpcMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-daemontaskdefinition.html#cfn-ecs-daemontaskdefinition-ipcmode
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? IpcMode { get; set; }
        /// <summary>
        /// Volumes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-daemontaskdefinition.html#cfn-ecs-daemontaskdefinition-volumes
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Volume
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ECS.DaemonTaskDefinitionTypes.Volume>, IReadOnlyList<Union<Humidifier.ECS.DaemonTaskDefinitionTypes.Volume, BaseFunction>>, BaseFunction>? Volumes { get; set; }
        /// <summary>
        /// Memory
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-daemontaskdefinition.html#cfn-ecs-daemontaskdefinition-memory
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Memory { get; set; }
        /// <summary>
        /// ContainerDefinitions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-daemontaskdefinition.html#cfn-ecs-daemontaskdefinition-containerdefinitions
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: DaemonContainerDefinition
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ECS.DaemonTaskDefinitionTypes.DaemonContainerDefinition>, IReadOnlyList<Union<Humidifier.ECS.DaemonTaskDefinitionTypes.DaemonContainerDefinition, BaseFunction>>, BaseFunction>? ContainerDefinitions { get; set; }
        /// <summary>
        /// Family
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-daemontaskdefinition.html#cfn-ecs-daemontaskdefinition-family
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Family { get; set; }
        /// <summary>
        /// Cpu
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-daemontaskdefinition.html#cfn-ecs-daemontaskdefinition-cpu
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Cpu { get; set; }
        /// <summary>
        /// PidMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-daemontaskdefinition.html#cfn-ecs-daemontaskdefinition-pidmode
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PidMode { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-daemontaskdefinition.html#cfn-ecs-daemontaskdefinition-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace DaemonTaskDefinitionTypes
    {
        public class ContainerDependency : Humidifier.Base.BaseSubResource, IHaveCondition, IHaveContainerName
        {
            /// <summary>
            /// Condition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-containerdependency.html#cfn-ecs-daemontaskdefinition-containerdependency-condition
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Condition { get; set; }
            /// <summary>
            /// ContainerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-containerdependency.html#cfn-ecs-daemontaskdefinition-containerdependency-containername
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContainerName { get; set; }
        }

        public class DaemonContainerDefinition : Humidifier.Base.BaseSubResource, IHaveUser, IHaveListOfECSDaemonTaskDefinitionTypesSecretSecrets, IHaveMemory_Integer, IHavePrivileged_Boolean, IHaveStartTimeout_Integer, IHaveECSDaemonTaskDefinitionTypesHealthCheckHealthCheck, IHaveCpu_Integer, IHaveStringListOfEntryPoint, IHaveReadonlyRootFilesystem_Boolean, IHaveImage, IHaveEssential_Boolean, IHaveECSDaemonTaskDefinitionTypesLogConfigurationLogConfiguration, IHaveListOfECSDaemonTaskDefinitionTypesEnvironmentFileEnvironmentFiles, IHaveName, IHaveECSDaemonTaskDefinitionTypesFirelensConfigurationFirelensConfiguration, IHaveListOfECSDaemonTaskDefinitionTypesSystemControlSystemControls, IHaveInteractive_Boolean, IHaveListOfECSDaemonTaskDefinitionTypesUlimitUlimits, IHaveStopTimeout_Integer, IHaveWorkingDirectory, IHaveMemoryReservation_Integer, IHaveECSDaemonTaskDefinitionTypesRepositoryCredentialsRepositoryCredentials, IHaveECSDaemonTaskDefinitionTypesLinuxParametersLinuxParameters, IHaveECSDaemonTaskDefinitionTypesRestartPolicyRestartPolicy, IHavePseudoTerminal_Boolean, IHaveListOfECSDaemonTaskDefinitionTypesMountPointMountPoints, IHaveListOfECSDaemonTaskDefinitionTypesContainerDependencyDependsOn, IHaveStringListOfCommand, IHaveListOfECSDaemonTaskDefinitionTypesKeyValuePairEnvironment
        {
            /// <summary>
            /// User
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-user
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? User { get; set; }
            /// <summary>
            /// Secrets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-secrets
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Secret
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECS.DaemonTaskDefinitionTypes.Secret>, IReadOnlyList<Union<Humidifier.ECS.DaemonTaskDefinitionTypes.Secret, BaseFunction>>, BaseFunction>? Secrets { get; set; }
            /// <summary>
            /// Memory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-memory
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Memory { get; set; }
            /// <summary>
            /// Privileged
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-privileged
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Privileged { get; set; }
            /// <summary>
            /// StartTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-starttimeout
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? StartTimeout { get; set; }
            /// <summary>
            /// HealthCheck
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-healthcheck
            /// Required: False
            /// UpdateType: Immutable
            /// Type: HealthCheck
            /// </summary>
            public Union<Humidifier.ECS.DaemonTaskDefinitionTypes.HealthCheck, BaseFunction>? HealthCheck { get; set; }
            /// <summary>
            /// Cpu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-cpu
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Cpu { get; set; }
            /// <summary>
            /// EntryPoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-entrypoint
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EntryPoint { get; set; }
            /// <summary>
            /// ReadonlyRootFilesystem
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-readonlyrootfilesystem
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ReadonlyRootFilesystem { get; set; }
            /// <summary>
            /// Image
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-image
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Image { get; set; }
            /// <summary>
            /// Essential
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-essential
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Essential { get; set; }
            /// <summary>
            /// LogConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-logconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: LogConfiguration
            /// </summary>
            public Union<Humidifier.ECS.DaemonTaskDefinitionTypes.LogConfiguration, BaseFunction>? LogConfiguration { get; set; }
            /// <summary>
            /// EnvironmentFiles
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-environmentfiles
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: EnvironmentFile
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECS.DaemonTaskDefinitionTypes.EnvironmentFile>, IReadOnlyList<Union<Humidifier.ECS.DaemonTaskDefinitionTypes.EnvironmentFile, BaseFunction>>, BaseFunction>? EnvironmentFiles { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
            /// <summary>
            /// FirelensConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-firelensconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: FirelensConfiguration
            /// </summary>
            public Union<Humidifier.ECS.DaemonTaskDefinitionTypes.FirelensConfiguration, BaseFunction>? FirelensConfiguration { get; set; }
            /// <summary>
            /// SystemControls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-systemcontrols
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: SystemControl
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECS.DaemonTaskDefinitionTypes.SystemControl>, IReadOnlyList<Union<Humidifier.ECS.DaemonTaskDefinitionTypes.SystemControl, BaseFunction>>, BaseFunction>? SystemControls { get; set; }
            /// <summary>
            /// Interactive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-interactive
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Interactive { get; set; }
            /// <summary>
            /// Ulimits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-ulimits
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Ulimit
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECS.DaemonTaskDefinitionTypes.Ulimit>, IReadOnlyList<Union<Humidifier.ECS.DaemonTaskDefinitionTypes.Ulimit, BaseFunction>>, BaseFunction>? Ulimits { get; set; }
            /// <summary>
            /// StopTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-stoptimeout
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? StopTimeout { get; set; }
            /// <summary>
            /// WorkingDirectory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-workingdirectory
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WorkingDirectory { get; set; }
            /// <summary>
            /// MemoryReservation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-memoryreservation
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MemoryReservation { get; set; }
            /// <summary>
            /// RepositoryCredentials
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-repositorycredentials
            /// Required: False
            /// UpdateType: Immutable
            /// Type: RepositoryCredentials
            /// </summary>
            public Union<Humidifier.ECS.DaemonTaskDefinitionTypes.RepositoryCredentials, BaseFunction>? RepositoryCredentials { get; set; }
            /// <summary>
            /// LinuxParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-linuxparameters
            /// Required: False
            /// UpdateType: Immutable
            /// Type: LinuxParameters
            /// </summary>
            public Union<Humidifier.ECS.DaemonTaskDefinitionTypes.LinuxParameters, BaseFunction>? LinuxParameters { get; set; }
            /// <summary>
            /// RestartPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-restartpolicy
            /// Required: False
            /// UpdateType: Immutable
            /// Type: RestartPolicy
            /// </summary>
            public Union<Humidifier.ECS.DaemonTaskDefinitionTypes.RestartPolicy, BaseFunction>? RestartPolicy { get; set; }
            /// <summary>
            /// PseudoTerminal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-pseudoterminal
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? PseudoTerminal { get; set; }
            /// <summary>
            /// MountPoints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-mountpoints
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: MountPoint
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECS.DaemonTaskDefinitionTypes.MountPoint>, IReadOnlyList<Union<Humidifier.ECS.DaemonTaskDefinitionTypes.MountPoint, BaseFunction>>, BaseFunction>? MountPoints { get; set; }
            /// <summary>
            /// DependsOn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-dependson
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ContainerDependency
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECS.DaemonTaskDefinitionTypes.ContainerDependency>, IReadOnlyList<Union<Humidifier.ECS.DaemonTaskDefinitionTypes.ContainerDependency, BaseFunction>>, BaseFunction>? DependsOn { get; set; }
            /// <summary>
            /// Command
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-command
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Command { get; set; }
            /// <summary>
            /// Environment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-environment
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: KeyValuePair
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECS.DaemonTaskDefinitionTypes.KeyValuePair>, IReadOnlyList<Union<Humidifier.ECS.DaemonTaskDefinitionTypes.KeyValuePair, BaseFunction>>, BaseFunction>? Environment { get; set; }
        }

        public class Device : Humidifier.Base.BaseSubResource, IHaveHostPath, IHaveStringListOfPermissions, IHaveContainerPath
        {
            /// <summary>
            /// HostPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-device.html#cfn-ecs-daemontaskdefinition-device-hostpath
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HostPath { get; set; }
            /// <summary>
            /// Permissions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-device.html#cfn-ecs-daemontaskdefinition-device-permissions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Permissions { get; set; }
            /// <summary>
            /// ContainerPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-device.html#cfn-ecs-daemontaskdefinition-device-containerpath
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContainerPath { get; set; }
        }

        public class EnvironmentFile : Humidifier.Base.BaseSubResource, IHaveType, IHaveValue
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-environmentfile.html#cfn-ecs-daemontaskdefinition-environmentfile-type
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-environmentfile.html#cfn-ecs-daemontaskdefinition-environmentfile-value
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
        }

        public class FirelensConfiguration : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfOptions, IHaveType
        {
            /// <summary>
            /// Options
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-firelensconfiguration.html#cfn-ecs-daemontaskdefinition-firelensconfiguration-options
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Options { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-firelensconfiguration.html#cfn-ecs-daemontaskdefinition-firelensconfiguration-type
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-healthcheck.html#cfn-ecs-daemontaskdefinition-healthcheck-command
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Command { get; set; }
            /// <summary>
            /// Timeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-healthcheck.html#cfn-ecs-daemontaskdefinition-healthcheck-timeout
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Timeout { get; set; }
            /// <summary>
            /// Retries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-healthcheck.html#cfn-ecs-daemontaskdefinition-healthcheck-retries
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Retries { get; set; }
            /// <summary>
            /// Interval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-healthcheck.html#cfn-ecs-daemontaskdefinition-healthcheck-interval
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Interval { get; set; }
            /// <summary>
            /// StartPeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-healthcheck.html#cfn-ecs-daemontaskdefinition-healthcheck-startperiod
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? StartPeriod { get; set; }
        }

        public class HostVolumeProperties : Humidifier.Base.BaseSubResource, IHaveSourcePath
        {
            /// <summary>
            /// SourcePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-hostvolumeproperties.html#cfn-ecs-daemontaskdefinition-hostvolumeproperties-sourcepath
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-kernelcapabilities.html#cfn-ecs-daemontaskdefinition-kernelcapabilities-add
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Add { get; set; }
            /// <summary>
            /// Drop
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-kernelcapabilities.html#cfn-ecs-daemontaskdefinition-kernelcapabilities-drop
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-keyvaluepair.html#cfn-ecs-daemontaskdefinition-keyvaluepair-value
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-keyvaluepair.html#cfn-ecs-daemontaskdefinition-keyvaluepair-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class LinuxParameters : Humidifier.Base.BaseSubResource, IHaveECSDaemonTaskDefinitionTypesKernelCapabilitiesCapabilities, IHaveListOfECSDaemonTaskDefinitionTypesTmpfsTmpfs, IHaveListOfECSDaemonTaskDefinitionTypesDeviceDevices, IHaveInitProcessEnabled_Boolean
        {
            /// <summary>
            /// Capabilities
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-linuxparameters.html#cfn-ecs-daemontaskdefinition-linuxparameters-capabilities
            /// Required: False
            /// UpdateType: Immutable
            /// Type: KernelCapabilities
            /// </summary>
            public Union<Humidifier.ECS.DaemonTaskDefinitionTypes.KernelCapabilities, BaseFunction>? Capabilities { get; set; }
            /// <summary>
            /// Tmpfs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-linuxparameters.html#cfn-ecs-daemontaskdefinition-linuxparameters-tmpfs
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Tmpfs
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECS.DaemonTaskDefinitionTypes.Tmpfs>, IReadOnlyList<Union<Humidifier.ECS.DaemonTaskDefinitionTypes.Tmpfs, BaseFunction>>, BaseFunction>? Tmpfs { get; set; }
            /// <summary>
            /// Devices
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-linuxparameters.html#cfn-ecs-daemontaskdefinition-linuxparameters-devices
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Device
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECS.DaemonTaskDefinitionTypes.Device>, IReadOnlyList<Union<Humidifier.ECS.DaemonTaskDefinitionTypes.Device, BaseFunction>>, BaseFunction>? Devices { get; set; }
            /// <summary>
            /// InitProcessEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-linuxparameters.html#cfn-ecs-daemontaskdefinition-linuxparameters-initprocessenabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? InitProcessEnabled { get; set; }
        }

        public class LogConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfECSDaemonTaskDefinitionTypesSecretSecretOptions, IHaveStringDictionaryOfOptions, IHaveLogDriver
        {
            /// <summary>
            /// SecretOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-logconfiguration.html#cfn-ecs-daemontaskdefinition-logconfiguration-secretoptions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Secret
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECS.DaemonTaskDefinitionTypes.Secret>, IReadOnlyList<Union<Humidifier.ECS.DaemonTaskDefinitionTypes.Secret, BaseFunction>>, BaseFunction>? SecretOptions { get; set; }
            /// <summary>
            /// Options
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-logconfiguration.html#cfn-ecs-daemontaskdefinition-logconfiguration-options
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Options { get; set; }
            /// <summary>
            /// LogDriver
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-logconfiguration.html#cfn-ecs-daemontaskdefinition-logconfiguration-logdriver
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-mountpoint.html#cfn-ecs-daemontaskdefinition-mountpoint-readonly
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ReadOnly { get; set; }
            /// <summary>
            /// SourceVolume
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-mountpoint.html#cfn-ecs-daemontaskdefinition-mountpoint-sourcevolume
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceVolume { get; set; }
            /// <summary>
            /// ContainerPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-mountpoint.html#cfn-ecs-daemontaskdefinition-mountpoint-containerpath
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContainerPath { get; set; }
        }

        public class RepositoryCredentials : Humidifier.Base.BaseSubResource, IHaveCredentialsParameter
        {
            /// <summary>
            /// CredentialsParameter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-repositorycredentials.html#cfn-ecs-daemontaskdefinition-repositorycredentials-credentialsparameter
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CredentialsParameter { get; set; }
        }

        public class RestartPolicy : Humidifier.Base.BaseSubResource, IHaveIntegerListOfIgnoredExitCodes, IHaveRestartAttemptPeriod_Integer, IHaveEnabled_Boolean
        {
            /// <summary>
            /// IgnoredExitCodes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-restartpolicy.html#cfn-ecs-daemontaskdefinition-restartpolicy-ignoredexitcodes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public Union<IReadOnlyList<int>, IReadOnlyList<Union<int, BaseFunction>>, BaseFunction>? IgnoredExitCodes { get; set; }
            /// <summary>
            /// RestartAttemptPeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-restartpolicy.html#cfn-ecs-daemontaskdefinition-restartpolicy-restartattemptperiod
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RestartAttemptPeriod { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-restartpolicy.html#cfn-ecs-daemontaskdefinition-restartpolicy-enabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class Secret : Humidifier.Base.BaseSubResource, IHaveValueFrom, IHaveName
        {
            /// <summary>
            /// ValueFrom
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-secret.html#cfn-ecs-daemontaskdefinition-secret-valuefrom
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ValueFrom { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-secret.html#cfn-ecs-daemontaskdefinition-secret-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class SystemControl : Humidifier.Base.BaseSubResource, IHaveValue, IHaveNamespace_
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-systemcontrol.html#cfn-ecs-daemontaskdefinition-systemcontrol-value
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Namespace_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-systemcontrol.html#cfn-ecs-daemontaskdefinition-systemcontrol-namespace
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Namespace_ { get; set; }
        }

        public class Tmpfs : Humidifier.Base.BaseSubResource, IHaveSize_Integer, IHaveContainerPath, IHaveStringListOfMountOptions
        {
            /// <summary>
            /// Size
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-tmpfs.html#cfn-ecs-daemontaskdefinition-tmpfs-size
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Size { get; set; }
            /// <summary>
            /// ContainerPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-tmpfs.html#cfn-ecs-daemontaskdefinition-tmpfs-containerpath
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContainerPath { get; set; }
            /// <summary>
            /// MountOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-tmpfs.html#cfn-ecs-daemontaskdefinition-tmpfs-mountoptions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-ulimit.html#cfn-ecs-daemontaskdefinition-ulimit-softlimit
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SoftLimit { get; set; }
            /// <summary>
            /// HardLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-ulimit.html#cfn-ecs-daemontaskdefinition-ulimit-hardlimit
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? HardLimit { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-ulimit.html#cfn-ecs-daemontaskdefinition-ulimit-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class Volume : Humidifier.Base.BaseSubResource, IHaveECSDaemonTaskDefinitionTypesHostVolumePropertiesHost, IHaveName
        {
            /// <summary>
            /// Host
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-volume.html#cfn-ecs-daemontaskdefinition-volume-host
            /// Required: False
            /// UpdateType: Immutable
            /// Type: HostVolumeProperties
            /// </summary>
            public Union<Humidifier.ECS.DaemonTaskDefinitionTypes.HostVolumeProperties, BaseFunction>? Host { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-volume.html#cfn-ecs-daemontaskdefinition-volume-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }
    }
}