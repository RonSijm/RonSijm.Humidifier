namespace Humidifier.ECS
{
    using global::System.Collections.Generic;
    using DaemonTaskDefinitionTypes;

    public class DaemonTaskDefinition : Humidifier.Base.BaseResource, IHaveTags, IHaveExecutionRoleArn, IHaveMemory, IHaveFamily, IHaveCpu, IHaveTaskRoleArn, IHaveIpcMode, IHavePidMode
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
        public dynamic ExecutionRoleArn { get; set; }
        /// <summary>
        /// TaskRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-daemontaskdefinition.html#cfn-ecs-daemontaskdefinition-taskrolearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TaskRoleArn { get; set; }
        /// <summary>
        /// IpcMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-daemontaskdefinition.html#cfn-ecs-daemontaskdefinition-ipcmode
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic IpcMode { get; set; }
        /// <summary>
        /// Volumes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-daemontaskdefinition.html#cfn-ecs-daemontaskdefinition-volumes
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Volume
        /// </summary>
        public List<Humidifier.ECS.DaemonTaskDefinitionTypes.Volume> Volumes { get; set; }
        /// <summary>
        /// Memory
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-daemontaskdefinition.html#cfn-ecs-daemontaskdefinition-memory
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Memory { get; set; }
        /// <summary>
        /// ContainerDefinitions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-daemontaskdefinition.html#cfn-ecs-daemontaskdefinition-containerdefinitions
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: DaemonContainerDefinition
        /// </summary>
        public List<Humidifier.ECS.DaemonTaskDefinitionTypes.DaemonContainerDefinition> ContainerDefinitions { get; set; }
        /// <summary>
        /// Family
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-daemontaskdefinition.html#cfn-ecs-daemontaskdefinition-family
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Family { get; set; }
        /// <summary>
        /// Cpu
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-daemontaskdefinition.html#cfn-ecs-daemontaskdefinition-cpu
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Cpu { get; set; }
        /// <summary>
        /// PidMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-daemontaskdefinition.html#cfn-ecs-daemontaskdefinition-pidmode
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PidMode { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-daemontaskdefinition.html#cfn-ecs-daemontaskdefinition-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace DaemonTaskDefinitionTypes
    {
        public class ContainerDependency : Humidifier.Base.BaseSubResource, IHaveContainerName, IHaveCondition
        {
            /// <summary>
            /// Condition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-containerdependency.html#cfn-ecs-daemontaskdefinition-containerdependency-condition
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Condition { get; set; }
            /// <summary>
            /// ContainerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-containerdependency.html#cfn-ecs-daemontaskdefinition-containerdependency-containername
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContainerName { get; set; }
        }

        public class DaemonContainerDefinition : Humidifier.Base.BaseSubResource, IHaveName, IHaveImage, IHaveCommand, IHaveUser, IHaveMemory, IHaveCpu, IHaveWorkingDirectory, IHavePrivileged, IHaveReadonlyRootFilesystem, IHaveEssential, IHaveEntryPoint, IHaveMemoryReservation
        {
            /// <summary>
            /// User
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-user
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic User { get; set; }
            /// <summary>
            /// Secrets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-secrets
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Secret
            /// </summary>
            public List<Humidifier.ECS.DaemonTaskDefinitionTypes.Secret> Secrets { get; set; }
            /// <summary>
            /// Memory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-memory
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Memory { get; set; }
            /// <summary>
            /// Privileged
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-privileged
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Privileged { get; set; }
            /// <summary>
            /// StartTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-starttimeout
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic StartTimeout { get; set; }
            /// <summary>
            /// HealthCheck
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-healthcheck
            /// Required: False
            /// UpdateType: Immutable
            /// Type: HealthCheck
            /// </summary>
            public Humidifier.ECS.DaemonTaskDefinitionTypes.HealthCheck HealthCheck { get; set; }
            /// <summary>
            /// Cpu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-cpu
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Cpu { get; set; }
            /// <summary>
            /// EntryPoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-entrypoint
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic EntryPoint { get; set; }
            /// <summary>
            /// ReadonlyRootFilesystem
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-readonlyrootfilesystem
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ReadonlyRootFilesystem { get; set; }
            /// <summary>
            /// Image
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-image
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Image { get; set; }
            /// <summary>
            /// Essential
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-essential
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Essential { get; set; }
            /// <summary>
            /// LogConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-logconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: LogConfiguration
            /// </summary>
            public Humidifier.ECS.DaemonTaskDefinitionTypes.LogConfiguration LogConfiguration { get; set; }
            /// <summary>
            /// EnvironmentFiles
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-environmentfiles
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: EnvironmentFile
            /// </summary>
            public List<Humidifier.ECS.DaemonTaskDefinitionTypes.EnvironmentFile> EnvironmentFiles { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
            /// <summary>
            /// FirelensConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-firelensconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: FirelensConfiguration
            /// </summary>
            public Humidifier.ECS.DaemonTaskDefinitionTypes.FirelensConfiguration FirelensConfiguration { get; set; }
            /// <summary>
            /// SystemControls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-systemcontrols
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: SystemControl
            /// </summary>
            public List<Humidifier.ECS.DaemonTaskDefinitionTypes.SystemControl> SystemControls { get; set; }
            /// <summary>
            /// Interactive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-interactive
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Interactive { get; set; }
            /// <summary>
            /// Ulimits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-ulimits
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Ulimit
            /// </summary>
            public List<Humidifier.ECS.DaemonTaskDefinitionTypes.Ulimit> Ulimits { get; set; }
            /// <summary>
            /// StopTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-stoptimeout
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic StopTimeout { get; set; }
            /// <summary>
            /// WorkingDirectory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-workingdirectory
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WorkingDirectory { get; set; }
            /// <summary>
            /// MemoryReservation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-memoryreservation
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MemoryReservation { get; set; }
            /// <summary>
            /// RepositoryCredentials
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-repositorycredentials
            /// Required: False
            /// UpdateType: Immutable
            /// Type: RepositoryCredentials
            /// </summary>
            public Humidifier.ECS.DaemonTaskDefinitionTypes.RepositoryCredentials RepositoryCredentials { get; set; }
            /// <summary>
            /// LinuxParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-linuxparameters
            /// Required: False
            /// UpdateType: Immutable
            /// Type: LinuxParameters
            /// </summary>
            public Humidifier.ECS.DaemonTaskDefinitionTypes.LinuxParameters LinuxParameters { get; set; }
            /// <summary>
            /// RestartPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-restartpolicy
            /// Required: False
            /// UpdateType: Immutable
            /// Type: RestartPolicy
            /// </summary>
            public Humidifier.ECS.DaemonTaskDefinitionTypes.RestartPolicy RestartPolicy { get; set; }
            /// <summary>
            /// PseudoTerminal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-pseudoterminal
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic PseudoTerminal { get; set; }
            /// <summary>
            /// MountPoints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-mountpoints
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: MountPoint
            /// </summary>
            public List<Humidifier.ECS.DaemonTaskDefinitionTypes.MountPoint> MountPoints { get; set; }
            /// <summary>
            /// DependsOn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-dependson
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ContainerDependency
            /// </summary>
            public List<Humidifier.ECS.DaemonTaskDefinitionTypes.ContainerDependency> DependsOn { get; set; }
            /// <summary>
            /// Command
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-command
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Command { get; set; }
            /// <summary>
            /// Environment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-daemoncontainerdefinition.html#cfn-ecs-daemontaskdefinition-daemoncontainerdefinition-environment
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: KeyValuePair
            /// </summary>
            public List<Humidifier.ECS.DaemonTaskDefinitionTypes.KeyValuePair> Environment { get; set; }
        }

        public class Device : Humidifier.Base.BaseSubResource, IHavePermissions, IHaveContainerPath, IHaveHostPath
        {
            /// <summary>
            /// HostPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-device.html#cfn-ecs-daemontaskdefinition-device-hostpath
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HostPath { get; set; }
            /// <summary>
            /// Permissions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-device.html#cfn-ecs-daemontaskdefinition-device-permissions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Permissions { get; set; }
            /// <summary>
            /// ContainerPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-device.html#cfn-ecs-daemontaskdefinition-device-containerpath
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContainerPath { get; set; }
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
            public dynamic Type { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-environmentfile.html#cfn-ecs-daemontaskdefinition-environmentfile-value
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
        }

        public class FirelensConfiguration : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// Options
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-firelensconfiguration.html#cfn-ecs-daemontaskdefinition-firelensconfiguration-options
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> Options { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-firelensconfiguration.html#cfn-ecs-daemontaskdefinition-firelensconfiguration-type
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
        }

        public class HealthCheck : Humidifier.Base.BaseSubResource, IHaveInterval, IHaveTimeout, IHaveCommand, IHaveRetries, IHaveStartPeriod
        {
            /// <summary>
            /// Command
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-healthcheck.html#cfn-ecs-daemontaskdefinition-healthcheck-command
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Command { get; set; }
            /// <summary>
            /// Timeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-healthcheck.html#cfn-ecs-daemontaskdefinition-healthcheck-timeout
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Timeout { get; set; }
            /// <summary>
            /// Retries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-healthcheck.html#cfn-ecs-daemontaskdefinition-healthcheck-retries
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Retries { get; set; }
            /// <summary>
            /// Interval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-healthcheck.html#cfn-ecs-daemontaskdefinition-healthcheck-interval
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Interval { get; set; }
            /// <summary>
            /// StartPeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-healthcheck.html#cfn-ecs-daemontaskdefinition-healthcheck-startperiod
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic StartPeriod { get; set; }
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
            public dynamic SourcePath { get; set; }
        }

        public class KernelCapabilities : Humidifier.Base.BaseSubResource, IHaveDrop
        {
            /// <summary>
            /// Add
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-kernelcapabilities.html#cfn-ecs-daemontaskdefinition-kernelcapabilities-add
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Add { get; set; }
            /// <summary>
            /// Drop
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-kernelcapabilities.html#cfn-ecs-daemontaskdefinition-kernelcapabilities-drop
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Drop { get; set; }
        }

        public class KeyValuePair : Humidifier.Base.BaseSubResource, IHaveName, IHaveValue
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-keyvaluepair.html#cfn-ecs-daemontaskdefinition-keyvaluepair-value
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-keyvaluepair.html#cfn-ecs-daemontaskdefinition-keyvaluepair-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class LinuxParameters : Humidifier.Base.BaseSubResource, IHaveInitProcessEnabled
        {
            /// <summary>
            /// Capabilities
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-linuxparameters.html#cfn-ecs-daemontaskdefinition-linuxparameters-capabilities
            /// Required: False
            /// UpdateType: Immutable
            /// Type: KernelCapabilities
            /// </summary>
            public Humidifier.ECS.DaemonTaskDefinitionTypes.KernelCapabilities Capabilities { get; set; }
            /// <summary>
            /// Tmpfs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-linuxparameters.html#cfn-ecs-daemontaskdefinition-linuxparameters-tmpfs
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Tmpfs
            /// </summary>
            public List<Humidifier.ECS.DaemonTaskDefinitionTypes.Tmpfs> Tmpfs { get; set; }
            /// <summary>
            /// Devices
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-linuxparameters.html#cfn-ecs-daemontaskdefinition-linuxparameters-devices
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Device
            /// </summary>
            public List<Humidifier.ECS.DaemonTaskDefinitionTypes.Device> Devices { get; set; }
            /// <summary>
            /// InitProcessEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-linuxparameters.html#cfn-ecs-daemontaskdefinition-linuxparameters-initprocessenabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic InitProcessEnabled { get; set; }
        }

        public class LogConfiguration : Humidifier.Base.BaseSubResource, IHaveLogDriver
        {
            /// <summary>
            /// SecretOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-logconfiguration.html#cfn-ecs-daemontaskdefinition-logconfiguration-secretoptions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Secret
            /// </summary>
            public List<Humidifier.ECS.DaemonTaskDefinitionTypes.Secret> SecretOptions { get; set; }
            /// <summary>
            /// Options
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-logconfiguration.html#cfn-ecs-daemontaskdefinition-logconfiguration-options
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> Options { get; set; }
            /// <summary>
            /// LogDriver
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-logconfiguration.html#cfn-ecs-daemontaskdefinition-logconfiguration-logdriver
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogDriver { get; set; }
        }

        public class MountPoint : Humidifier.Base.BaseSubResource, IHaveReadOnly, IHaveContainerPath, IHaveSourceVolume
        {
            /// <summary>
            /// ReadOnly
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-mountpoint.html#cfn-ecs-daemontaskdefinition-mountpoint-readonly
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ReadOnly { get; set; }
            /// <summary>
            /// SourceVolume
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-mountpoint.html#cfn-ecs-daemontaskdefinition-mountpoint-sourcevolume
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceVolume { get; set; }
            /// <summary>
            /// ContainerPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-mountpoint.html#cfn-ecs-daemontaskdefinition-mountpoint-containerpath
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContainerPath { get; set; }
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
            public dynamic CredentialsParameter { get; set; }
        }

        public class RestartPolicy : Humidifier.Base.BaseSubResource, IHaveEnabled
        {
            /// <summary>
            /// IgnoredExitCodes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-restartpolicy.html#cfn-ecs-daemontaskdefinition-restartpolicy-ignoredexitcodes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public List<int> IgnoredExitCodes { get; set; }
            /// <summary>
            /// RestartAttemptPeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-restartpolicy.html#cfn-ecs-daemontaskdefinition-restartpolicy-restartattemptperiod
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RestartAttemptPeriod { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-restartpolicy.html#cfn-ecs-daemontaskdefinition-restartpolicy-enabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
        }

        public class Secret : Humidifier.Base.BaseSubResource, IHaveName, IHaveValueFrom
        {
            /// <summary>
            /// ValueFrom
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-secret.html#cfn-ecs-daemontaskdefinition-secret-valuefrom
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ValueFrom { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-secret.html#cfn-ecs-daemontaskdefinition-secret-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
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
            public dynamic Value { get; set; }
            /// <summary>
            /// Namespace_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-systemcontrol.html#cfn-ecs-daemontaskdefinition-systemcontrol-namespace
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Namespace_ { get; set; }
        }

        public class Tmpfs : Humidifier.Base.BaseSubResource, IHaveSize, IHaveContainerPath, IHaveMountOptions
        {
            /// <summary>
            /// Size
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-tmpfs.html#cfn-ecs-daemontaskdefinition-tmpfs-size
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Size { get; set; }
            /// <summary>
            /// ContainerPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-tmpfs.html#cfn-ecs-daemontaskdefinition-tmpfs-containerpath
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContainerPath { get; set; }
            /// <summary>
            /// MountOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-tmpfs.html#cfn-ecs-daemontaskdefinition-tmpfs-mountoptions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic MountOptions { get; set; }
        }

        public class Ulimit : Humidifier.Base.BaseSubResource, IHaveName, IHaveSoftLimit, IHaveHardLimit
        {
            /// <summary>
            /// SoftLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-ulimit.html#cfn-ecs-daemontaskdefinition-ulimit-softlimit
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic SoftLimit { get; set; }
            /// <summary>
            /// HardLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-ulimit.html#cfn-ecs-daemontaskdefinition-ulimit-hardlimit
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic HardLimit { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-ulimit.html#cfn-ecs-daemontaskdefinition-ulimit-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class Volume : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Host
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-volume.html#cfn-ecs-daemontaskdefinition-volume-host
            /// Required: False
            /// UpdateType: Immutable
            /// Type: HostVolumeProperties
            /// </summary>
            public Humidifier.ECS.DaemonTaskDefinitionTypes.HostVolumeProperties Host { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemontaskdefinition-volume.html#cfn-ecs-daemontaskdefinition-volume-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }
    }
}