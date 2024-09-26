namespace Humidifier.Batch
{
    using System.Collections.Generic;
    using JobDefinitionTypes;

    public class JobDefinition : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveType, IHaveDynamicTags, IHaveParameters, IHavePropagateTags, IHaveJobDefinitionName
    {
        public override string AWSTypeName { get => AWS.Batch.JobDefinition; }
        /// <summary>
        /// Parameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-jobdefinition.html#cfn-batch-jobdefinition-parameters
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic Parameters { get; set; }
        /// <summary>
        /// Timeout
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-jobdefinition.html#cfn-batch-jobdefinition-timeout
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Timeout
        /// </summary>
        public Humidifier.Batch.JobDefinitionTypes.Timeout Timeout { get; set; }
        public dynamic JobDefinitionName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// PropagateTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-jobdefinition.html#cfn-batch-jobdefinition-propagatetags
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic PropagateTags { get; set; }
        /// <summary>
        /// PlatformCapabilities
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-jobdefinition.html#cfn-batch-jobdefinition-platformcapabilities
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic PlatformCapabilities { get; set; }
        /// <summary>
        /// EksProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-jobdefinition.html#cfn-batch-jobdefinition-eksproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EksProperties
        /// </summary>
        public Humidifier.Batch.JobDefinitionTypes.EksProperties EksProperties { get; set; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-jobdefinition.html#cfn-batch-jobdefinition-type
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Type { get; set; }
        /// <summary>
        /// NodeProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-jobdefinition.html#cfn-batch-jobdefinition-nodeproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: NodeProperties
        /// </summary>
        public Humidifier.Batch.JobDefinitionTypes.NodeProperties NodeProperties { get; set; }
        /// <summary>
        /// SchedulingPriority
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-jobdefinition.html#cfn-batch-jobdefinition-schedulingpriority
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic SchedulingPriority { get; set; }
        /// <summary>
        /// ContainerProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-jobdefinition.html#cfn-batch-jobdefinition-containerproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ContainerProperties
        /// </summary>
        public Humidifier.Batch.JobDefinitionTypes.ContainerProperties ContainerProperties { get; set; }
        /// <summary>
        /// EcsProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-jobdefinition.html#cfn-batch-jobdefinition-ecsproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EcsProperties
        /// </summary>
        public Humidifier.Batch.JobDefinitionTypes.EcsProperties EcsProperties { get; set; }
        /// <summary>
        /// RetryStrategy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-jobdefinition.html#cfn-batch-jobdefinition-retrystrategy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RetryStrategy
        /// </summary>
        public Humidifier.Batch.JobDefinitionTypes.RetryStrategy RetryStrategy { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-jobdefinition.html#cfn-batch-jobdefinition-tags
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic Tags { get; set; }
    }

    namespace JobDefinitionTypes
    {
        public class AuthorizationConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Iam
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-authorizationconfig.html#cfn-batch-jobdefinition-authorizationconfig-iam
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Iam { get; set; }
            /// <summary>
            /// AccessPointId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-authorizationconfig.html#cfn-batch-jobdefinition-authorizationconfig-accesspointid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AccessPointId { get; set; }
        }

        public class ContainerProperties : Humidifier.Base.BaseSubResource, IHaveInstanceType, IHaveExecutionRoleArn, IHaveImage, IHaveCommand, IHaveUser, IHaveMemory, IHavePrivileged, IHaveReadonlyRootFilesystem
        {
            /// <summary>
            /// RepositoryCredentials
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties.html#cfn-batch-jobdefinition-containerproperties-repositorycredentials
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RepositoryCredentials
            /// </summary>
            public Humidifier.Batch.JobDefinitionTypes.RepositoryCredentials RepositoryCredentials { get; set; }
            /// <summary>
            /// User
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties.html#cfn-batch-jobdefinition-containerproperties-user
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic User { get; set; }
            /// <summary>
            /// Secrets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties.html#cfn-batch-jobdefinition-containerproperties-secrets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Secret
            /// </summary>
            public List<Humidifier.Batch.JobDefinitionTypes.Secret> Secrets { get; set; }
            /// <summary>
            /// Memory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties.html#cfn-batch-jobdefinition-containerproperties-memory
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Memory { get; set; }
            /// <summary>
            /// Privileged
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties.html#cfn-batch-jobdefinition-containerproperties-privileged
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Privileged { get; set; }
            /// <summary>
            /// LinuxParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties.html#cfn-batch-jobdefinition-containerproperties-linuxparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LinuxParameters
            /// </summary>
            public Humidifier.Batch.JobDefinitionTypes.LinuxParameters LinuxParameters { get; set; }
            /// <summary>
            /// FargatePlatformConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties.html#cfn-batch-jobdefinition-containerproperties-fargateplatformconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FargatePlatformConfiguration
            /// </summary>
            public Humidifier.Batch.JobDefinitionTypes.FargatePlatformConfiguration FargatePlatformConfiguration { get; set; }
            /// <summary>
            /// JobRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties.html#cfn-batch-jobdefinition-containerproperties-jobrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic JobRoleArn { get; set; }
            /// <summary>
            /// ReadonlyRootFilesystem
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties.html#cfn-batch-jobdefinition-containerproperties-readonlyrootfilesystem
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ReadonlyRootFilesystem { get; set; }
            /// <summary>
            /// Vcpus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties.html#cfn-batch-jobdefinition-containerproperties-vcpus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Vcpus { get; set; }
            /// <summary>
            /// Image
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties.html#cfn-batch-jobdefinition-containerproperties-image
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Image { get; set; }
            /// <summary>
            /// ResourceRequirements
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties.html#cfn-batch-jobdefinition-containerproperties-resourcerequirements
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ResourceRequirement
            /// </summary>
            public List<Humidifier.Batch.JobDefinitionTypes.ResourceRequirement> ResourceRequirements { get; set; }
            /// <summary>
            /// LogConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties.html#cfn-batch-jobdefinition-containerproperties-logconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LogConfiguration
            /// </summary>
            public Humidifier.Batch.JobDefinitionTypes.LogConfiguration LogConfiguration { get; set; }
            /// <summary>
            /// MountPoints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties.html#cfn-batch-jobdefinition-containerproperties-mountpoints
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MountPoints
            /// </summary>
            public List<Humidifier.Batch.JobDefinitionTypes.MountPoints> MountPoints { get; set; }
            /// <summary>
            /// ExecutionRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties.html#cfn-batch-jobdefinition-containerproperties-executionrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExecutionRoleArn { get; set; }
            /// <summary>
            /// RuntimePlatform
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties.html#cfn-batch-jobdefinition-containerproperties-runtimeplatform
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RuntimePlatform
            /// </summary>
            public Humidifier.Batch.JobDefinitionTypes.RuntimePlatform RuntimePlatform { get; set; }
            /// <summary>
            /// Volumes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties.html#cfn-batch-jobdefinition-containerproperties-volumes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Volumes
            /// </summary>
            public List<Humidifier.Batch.JobDefinitionTypes.Volumes> Volumes { get; set; }
            /// <summary>
            /// Command
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties.html#cfn-batch-jobdefinition-containerproperties-command
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Command { get; set; }
            /// <summary>
            /// Environment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties.html#cfn-batch-jobdefinition-containerproperties-environment
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Environment
            /// </summary>
            public List<Humidifier.Batch.JobDefinitionTypes.Environment> Environment { get; set; }
            /// <summary>
            /// Ulimits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties.html#cfn-batch-jobdefinition-containerproperties-ulimits
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Ulimit
            /// </summary>
            public List<Humidifier.Batch.JobDefinitionTypes.Ulimit> Ulimits { get; set; }
            /// <summary>
            /// NetworkConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties.html#cfn-batch-jobdefinition-containerproperties-networkconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NetworkConfiguration
            /// </summary>
            public Humidifier.Batch.JobDefinitionTypes.NetworkConfiguration NetworkConfiguration { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties.html#cfn-batch-jobdefinition-containerproperties-instancetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InstanceType { get; set; }
            /// <summary>
            /// EphemeralStorage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties.html#cfn-batch-jobdefinition-containerproperties-ephemeralstorage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EphemeralStorage
            /// </summary>
            public Humidifier.Batch.JobDefinitionTypes.EphemeralStorage EphemeralStorage { get; set; }
        }

        public class Device : Humidifier.Base.BaseSubResource, IHavePermissions, IHaveContainerPath
        {
            /// <summary>
            /// HostPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-device.html#cfn-batch-jobdefinition-device-hostpath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HostPath { get; set; }
            /// <summary>
            /// Permissions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-device.html#cfn-batch-jobdefinition-device-permissions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Permissions { get; set; }
            /// <summary>
            /// ContainerPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-device.html#cfn-batch-jobdefinition-device-containerpath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContainerPath { get; set; }
        }

        public class EcsProperties : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TaskProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-ecsproperties.html#cfn-batch-jobdefinition-ecsproperties-taskproperties
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EcsTaskProperties
            /// </summary>
            public List<Humidifier.Batch.JobDefinitionTypes.EcsTaskProperties> TaskProperties { get; set; }
        }

        public class EcsTaskProperties : Humidifier.Base.BaseSubResource, IHaveExecutionRoleArn, IHavePlatformVersion, IHaveTaskRoleArn
        {
            /// <summary>
            /// PlatformVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-ecstaskproperties.html#cfn-batch-jobdefinition-ecstaskproperties-platformversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PlatformVersion { get; set; }
            /// <summary>
            /// ExecutionRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-ecstaskproperties.html#cfn-batch-jobdefinition-ecstaskproperties-executionrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExecutionRoleArn { get; set; }
            /// <summary>
            /// RuntimePlatform
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-ecstaskproperties.html#cfn-batch-jobdefinition-ecstaskproperties-runtimeplatform
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RuntimePlatform
            /// </summary>
            public Humidifier.Batch.JobDefinitionTypes.RuntimePlatform RuntimePlatform { get; set; }
            /// <summary>
            /// TaskRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-ecstaskproperties.html#cfn-batch-jobdefinition-ecstaskproperties-taskrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TaskRoleArn { get; set; }
            /// <summary>
            /// IpcMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-ecstaskproperties.html#cfn-batch-jobdefinition-ecstaskproperties-ipcmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IpcMode { get; set; }
            /// <summary>
            /// Volumes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-ecstaskproperties.html#cfn-batch-jobdefinition-ecstaskproperties-volumes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Volumes
            /// </summary>
            public List<Humidifier.Batch.JobDefinitionTypes.Volumes> Volumes { get; set; }
            /// <summary>
            /// Containers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-ecstaskproperties.html#cfn-batch-jobdefinition-ecstaskproperties-containers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TaskContainerProperties
            /// </summary>
            public List<Humidifier.Batch.JobDefinitionTypes.TaskContainerProperties> Containers { get; set; }
            /// <summary>
            /// NetworkConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-ecstaskproperties.html#cfn-batch-jobdefinition-ecstaskproperties-networkconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NetworkConfiguration
            /// </summary>
            public Humidifier.Batch.JobDefinitionTypes.NetworkConfiguration NetworkConfiguration { get; set; }
            /// <summary>
            /// PidMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-ecstaskproperties.html#cfn-batch-jobdefinition-ecstaskproperties-pidmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PidMode { get; set; }
            /// <summary>
            /// EphemeralStorage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-ecstaskproperties.html#cfn-batch-jobdefinition-ecstaskproperties-ephemeralstorage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EphemeralStorage
            /// </summary>
            public Humidifier.Batch.JobDefinitionTypes.EphemeralStorage EphemeralStorage { get; set; }
        }

        public class EfsVolumeConfiguration : Humidifier.Base.BaseSubResource, IHaveFileSystemId, IHaveRootDirectory
        {
            /// <summary>
            /// TransitEncryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-efsvolumeconfiguration.html#cfn-batch-jobdefinition-efsvolumeconfiguration-transitencryption
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TransitEncryption { get; set; }
            /// <summary>
            /// AuthorizationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-efsvolumeconfiguration.html#cfn-batch-jobdefinition-efsvolumeconfiguration-authorizationconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuthorizationConfig
            /// </summary>
            public Humidifier.Batch.JobDefinitionTypes.AuthorizationConfig AuthorizationConfig { get; set; }
            /// <summary>
            /// FileSystemId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-efsvolumeconfiguration.html#cfn-batch-jobdefinition-efsvolumeconfiguration-filesystemid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FileSystemId { get; set; }
            /// <summary>
            /// RootDirectory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-efsvolumeconfiguration.html#cfn-batch-jobdefinition-efsvolumeconfiguration-rootdirectory
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RootDirectory { get; set; }
            /// <summary>
            /// TransitEncryptionPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-efsvolumeconfiguration.html#cfn-batch-jobdefinition-efsvolumeconfiguration-transitencryptionport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TransitEncryptionPort { get; set; }
        }

        public class EksContainer : Humidifier.Base.BaseSubResource, IHaveName, IHaveImage, IHaveCommand, IHaveArgs
        {
            /// <summary>
            /// Args
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-ekscontainer.html#cfn-batch-jobdefinition-ekscontainer-args
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Args { get; set; }
            /// <summary>
            /// VolumeMounts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-ekscontainer.html#cfn-batch-jobdefinition-ekscontainer-volumemounts
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EksContainerVolumeMount
            /// </summary>
            public List<Humidifier.Batch.JobDefinitionTypes.EksContainerVolumeMount> VolumeMounts { get; set; }
            /// <summary>
            /// ImagePullPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-ekscontainer.html#cfn-batch-jobdefinition-ekscontainer-imagepullpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ImagePullPolicy { get; set; }
            /// <summary>
            /// Command
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-ekscontainer.html#cfn-batch-jobdefinition-ekscontainer-command
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Command { get; set; }
            /// <summary>
            /// SecurityContext
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-ekscontainer.html#cfn-batch-jobdefinition-ekscontainer-securitycontext
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EksContainerSecurityContext
            /// </summary>
            public Humidifier.Batch.JobDefinitionTypes.EksContainerSecurityContext SecurityContext { get; set; }
            /// <summary>
            /// Resources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-ekscontainer.html#cfn-batch-jobdefinition-ekscontainer-resources
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EksContainerResourceRequirements
            /// </summary>
            public Humidifier.Batch.JobDefinitionTypes.EksContainerResourceRequirements Resources { get; set; }
            /// <summary>
            /// Image
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-ekscontainer.html#cfn-batch-jobdefinition-ekscontainer-image
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Image { get; set; }
            /// <summary>
            /// Env
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-ekscontainer.html#cfn-batch-jobdefinition-ekscontainer-env
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EksContainerEnvironmentVariable
            /// </summary>
            public List<Humidifier.Batch.JobDefinitionTypes.EksContainerEnvironmentVariable> Env { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-ekscontainer.html#cfn-batch-jobdefinition-ekscontainer-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class EksContainerEnvironmentVariable : Humidifier.Base.BaseSubResource, IHaveName, IHaveValue
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-ekscontainerenvironmentvariable.html#cfn-batch-jobdefinition-ekscontainerenvironmentvariable-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-ekscontainerenvironmentvariable.html#cfn-batch-jobdefinition-ekscontainerenvironmentvariable-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class EksContainerResourceRequirements : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Limits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-ekscontainerresourcerequirements.html#cfn-batch-jobdefinition-ekscontainerresourcerequirements-limits
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Limits { get; set; }
            /// <summary>
            /// Requests
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-ekscontainerresourcerequirements.html#cfn-batch-jobdefinition-ekscontainerresourcerequirements-requests
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Requests { get; set; }
        }

        public class EksContainerSecurityContext : Humidifier.Base.BaseSubResource, IHavePrivileged
        {
            /// <summary>
            /// RunAsUser
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-ekscontainersecuritycontext.html#cfn-batch-jobdefinition-ekscontainersecuritycontext-runasuser
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RunAsUser { get; set; }
            /// <summary>
            /// AllowPrivilegeEscalation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-ekscontainersecuritycontext.html#cfn-batch-jobdefinition-ekscontainersecuritycontext-allowprivilegeescalation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AllowPrivilegeEscalation { get; set; }
            /// <summary>
            /// RunAsNonRoot
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-ekscontainersecuritycontext.html#cfn-batch-jobdefinition-ekscontainersecuritycontext-runasnonroot
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic RunAsNonRoot { get; set; }
            /// <summary>
            /// Privileged
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-ekscontainersecuritycontext.html#cfn-batch-jobdefinition-ekscontainersecuritycontext-privileged
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Privileged { get; set; }
            /// <summary>
            /// ReadOnlyRootFilesystem
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-ekscontainersecuritycontext.html#cfn-batch-jobdefinition-ekscontainersecuritycontext-readonlyrootfilesystem
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ReadOnlyRootFilesystem { get; set; }
            /// <summary>
            /// RunAsGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-ekscontainersecuritycontext.html#cfn-batch-jobdefinition-ekscontainersecuritycontext-runasgroup
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RunAsGroup { get; set; }
        }

        public class EksContainerVolumeMount : Humidifier.Base.BaseSubResource, IHaveName, IHaveReadOnly
        {
            /// <summary>
            /// MountPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-ekscontainervolumemount.html#cfn-batch-jobdefinition-ekscontainervolumemount-mountpath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MountPath { get; set; }
            /// <summary>
            /// ReadOnly
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-ekscontainervolumemount.html#cfn-batch-jobdefinition-ekscontainervolumemount-readonly
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ReadOnly { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-ekscontainervolumemount.html#cfn-batch-jobdefinition-ekscontainervolumemount-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class EksEmptyDir : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Medium
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-eksemptydir.html#cfn-batch-jobdefinition-eksemptydir-medium
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Medium { get; set; }
            /// <summary>
            /// SizeLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-eksemptydir.html#cfn-batch-jobdefinition-eksemptydir-sizelimit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SizeLimit { get; set; }
        }

        public class EksHostPath : Humidifier.Base.BaseSubResource, IHavePath
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-ekshostpath.html#cfn-batch-jobdefinition-ekshostpath-path
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Path { get; set; }
        }

        public class EksProperties : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PodProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-eksproperties.html#cfn-batch-jobdefinition-eksproperties-podproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PodProperties
            /// </summary>
            public Humidifier.Batch.JobDefinitionTypes.PodProperties PodProperties { get; set; }
        }

        public class EksSecret : Humidifier.Base.BaseSubResource, IHaveSecretName
        {
            /// <summary>
            /// SecretName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-ekssecret.html#cfn-batch-jobdefinition-ekssecret-secretname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecretName { get; set; }
            /// <summary>
            /// Optional
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-ekssecret.html#cfn-batch-jobdefinition-ekssecret-optional
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Optional { get; set; }
        }

        public class EksVolume : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Secret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-eksvolume.html#cfn-batch-jobdefinition-eksvolume-secret
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EksSecret
            /// </summary>
            public Humidifier.Batch.JobDefinitionTypes.EksSecret Secret { get; set; }
            /// <summary>
            /// EmptyDir
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-eksvolume.html#cfn-batch-jobdefinition-eksvolume-emptydir
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EksEmptyDir
            /// </summary>
            public Humidifier.Batch.JobDefinitionTypes.EksEmptyDir EmptyDir { get; set; }
            /// <summary>
            /// HostPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-eksvolume.html#cfn-batch-jobdefinition-eksvolume-hostpath
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EksHostPath
            /// </summary>
            public Humidifier.Batch.JobDefinitionTypes.EksHostPath HostPath { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-eksvolume.html#cfn-batch-jobdefinition-eksvolume-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class Environment : Humidifier.Base.BaseSubResource, IHaveName, IHaveValue
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-environment.html#cfn-batch-jobdefinition-environment-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-environment.html#cfn-batch-jobdefinition-environment-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class EphemeralStorage : Humidifier.Base.BaseSubResource, IHaveSizeInGiB
        {
            /// <summary>
            /// SizeInGiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-ecstaskproperties-ephemeralstorage.html#cfn-batch-jobdefinition-ecstaskproperties-ephemeralstorage-sizeingib
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic SizeInGiB { get; set; }
        }

        public class EvaluateOnExit : Humidifier.Base.BaseSubResource, IHaveAction
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-evaluateonexit.html#cfn-batch-jobdefinition-evaluateonexit-action
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Action { get; set; }
            /// <summary>
            /// OnExitCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-evaluateonexit.html#cfn-batch-jobdefinition-evaluateonexit-onexitcode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OnExitCode { get; set; }
            /// <summary>
            /// OnReason
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-evaluateonexit.html#cfn-batch-jobdefinition-evaluateonexit-onreason
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OnReason { get; set; }
            /// <summary>
            /// OnStatusReason
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-evaluateonexit.html#cfn-batch-jobdefinition-evaluateonexit-onstatusreason
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OnStatusReason { get; set; }
        }

        public class FargatePlatformConfiguration : Humidifier.Base.BaseSubResource, IHavePlatformVersion
        {
            /// <summary>
            /// PlatformVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties-fargateplatformconfiguration.html#cfn-batch-jobdefinition-containerproperties-fargateplatformconfiguration-platformversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PlatformVersion { get; set; }
        }

        public class ImagePullSecret : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-imagepullsecret.html#cfn-batch-jobdefinition-imagepullsecret-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class LinuxParameters : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Swappiness
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-taskcontainerproperties-linuxparameters.html#cfn-batch-jobdefinition-taskcontainerproperties-linuxparameters-swappiness
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Swappiness { get; set; }
            /// <summary>
            /// Tmpfs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-taskcontainerproperties-linuxparameters.html#cfn-batch-jobdefinition-taskcontainerproperties-linuxparameters-tmpfs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tmpfs
            /// </summary>
            public List<Humidifier.Batch.JobDefinitionTypes.Tmpfs> Tmpfs { get; set; }
            /// <summary>
            /// SharedMemorySize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-taskcontainerproperties-linuxparameters.html#cfn-batch-jobdefinition-taskcontainerproperties-linuxparameters-sharedmemorysize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic SharedMemorySize { get; set; }
            /// <summary>
            /// Devices
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-taskcontainerproperties-linuxparameters.html#cfn-batch-jobdefinition-taskcontainerproperties-linuxparameters-devices
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Device
            /// </summary>
            public List<Humidifier.Batch.JobDefinitionTypes.Device> Devices { get; set; }
            /// <summary>
            /// InitProcessEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-taskcontainerproperties-linuxparameters.html#cfn-batch-jobdefinition-taskcontainerproperties-linuxparameters-initprocessenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic InitProcessEnabled { get; set; }
            /// <summary>
            /// MaxSwap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-taskcontainerproperties-linuxparameters.html#cfn-batch-jobdefinition-taskcontainerproperties-linuxparameters-maxswap
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxSwap { get; set; }
        }

        public class LogConfiguration : Humidifier.Base.BaseSubResource, IHaveOptions, IHaveLogDriver
        {
            /// <summary>
            /// SecretOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-taskcontainerproperties-logconfiguration.html#cfn-batch-jobdefinition-taskcontainerproperties-logconfiguration-secretoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Secret
            /// </summary>
            public List<Humidifier.Batch.JobDefinitionTypes.Secret> SecretOptions { get; set; }
            /// <summary>
            /// Options
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-taskcontainerproperties-logconfiguration.html#cfn-batch-jobdefinition-taskcontainerproperties-logconfiguration-options
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Options { get; set; }
            /// <summary>
            /// LogDriver
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-taskcontainerproperties-logconfiguration.html#cfn-batch-jobdefinition-taskcontainerproperties-logconfiguration-logdriver
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogDriver { get; set; }
        }

        public class Metadata : Humidifier.Base.BaseSubResource, IHaveLabels
        {
            /// <summary>
            /// Labels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-podproperties-metadata.html#cfn-batch-jobdefinition-podproperties-metadata-labels
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Labels { get; set; }
        }

        public class MountPoints : Humidifier.Base.BaseSubResource, IHaveReadOnly, IHaveContainerPath
        {
            /// <summary>
            /// ReadOnly
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-mountpoints.html#cfn-batch-jobdefinition-mountpoints-readonly
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ReadOnly { get; set; }
            /// <summary>
            /// SourceVolume
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-mountpoints.html#cfn-batch-jobdefinition-mountpoints-sourcevolume
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceVolume { get; set; }
            /// <summary>
            /// ContainerPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-mountpoints.html#cfn-batch-jobdefinition-mountpoints-containerpath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContainerPath { get; set; }
        }

        public class NetworkConfiguration : Humidifier.Base.BaseSubResource, IHaveAssignPublicIp
        {
            /// <summary>
            /// AssignPublicIp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-ecstaskproperties-networkconfiguration.html#cfn-batch-jobdefinition-ecstaskproperties-networkconfiguration-assignpublicip
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AssignPublicIp { get; set; }
        }

        public class NodeProperties : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MainNode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-nodeproperties.html#cfn-batch-jobdefinition-nodeproperties-mainnode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MainNode { get; set; }
            /// <summary>
            /// NodeRangeProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-nodeproperties.html#cfn-batch-jobdefinition-nodeproperties-noderangeproperties
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: NodeRangeProperty
            /// </summary>
            public List<Humidifier.Batch.JobDefinitionTypes.NodeRangeProperty> NodeRangeProperties { get; set; }
            /// <summary>
            /// NumNodes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-nodeproperties.html#cfn-batch-jobdefinition-nodeproperties-numnodes
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic NumNodes { get; set; }
        }

        public class NodeRangeProperty : Humidifier.Base.BaseSubResource, IHaveInstanceTypes
        {
            /// <summary>
            /// Container
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-noderangeproperty.html#cfn-batch-jobdefinition-noderangeproperty-container
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ContainerProperties
            /// </summary>
            public Humidifier.Batch.JobDefinitionTypes.ContainerProperties Container { get; set; }
            /// <summary>
            /// TargetNodes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-noderangeproperty.html#cfn-batch-jobdefinition-noderangeproperty-targetnodes
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetNodes { get; set; }
            /// <summary>
            /// EcsProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-noderangeproperty.html#cfn-batch-jobdefinition-noderangeproperty-ecsproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EcsProperties
            /// </summary>
            public Humidifier.Batch.JobDefinitionTypes.EcsProperties EcsProperties { get; set; }
            /// <summary>
            /// InstanceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-noderangeproperty.html#cfn-batch-jobdefinition-noderangeproperty-instancetypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic InstanceTypes { get; set; }
            /// <summary>
            /// EksProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-noderangeproperty.html#cfn-batch-jobdefinition-noderangeproperty-eksproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EksProperties
            /// </summary>
            public Humidifier.Batch.JobDefinitionTypes.EksProperties EksProperties { get; set; }
        }

        public class PodProperties : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// InitContainers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-podproperties.html#cfn-batch-jobdefinition-podproperties-initcontainers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EksContainer
            /// </summary>
            public List<Humidifier.Batch.JobDefinitionTypes.EksContainer> InitContainers { get; set; }
            /// <summary>
            /// Volumes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-podproperties.html#cfn-batch-jobdefinition-podproperties-volumes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EksVolume
            /// </summary>
            public List<Humidifier.Batch.JobDefinitionTypes.EksVolume> Volumes { get; set; }
            /// <summary>
            /// DnsPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-podproperties.html#cfn-batch-jobdefinition-podproperties-dnspolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DnsPolicy { get; set; }
            /// <summary>
            /// Containers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-podproperties.html#cfn-batch-jobdefinition-podproperties-containers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EksContainer
            /// </summary>
            public List<Humidifier.Batch.JobDefinitionTypes.EksContainer> Containers { get; set; }
            /// <summary>
            /// Metadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-podproperties.html#cfn-batch-jobdefinition-podproperties-metadata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Metadata
            /// </summary>
            public Humidifier.Batch.JobDefinitionTypes.Metadata Metadata { get; set; }
            /// <summary>
            /// ServiceAccountName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-podproperties.html#cfn-batch-jobdefinition-podproperties-serviceaccountname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ServiceAccountName { get; set; }
            /// <summary>
            /// ImagePullSecrets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-podproperties.html#cfn-batch-jobdefinition-podproperties-imagepullsecrets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ImagePullSecret
            /// </summary>
            public List<Humidifier.Batch.JobDefinitionTypes.ImagePullSecret> ImagePullSecrets { get; set; }
            /// <summary>
            /// HostNetwork
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-podproperties.html#cfn-batch-jobdefinition-podproperties-hostnetwork
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic HostNetwork { get; set; }
            /// <summary>
            /// ShareProcessNamespace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-podproperties.html#cfn-batch-jobdefinition-podproperties-shareprocessnamespace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ShareProcessNamespace { get; set; }
        }

        public class RepositoryCredentials : Humidifier.Base.BaseSubResource, IHaveCredentialsParameter
        {
            /// <summary>
            /// CredentialsParameter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-taskcontainerproperties-repositorycredentials.html#cfn-batch-jobdefinition-taskcontainerproperties-repositorycredentials-credentialsparameter
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CredentialsParameter { get; set; }
        }

        public class ResourceRequirement : Humidifier.Base.BaseSubResource, IHaveType, IHaveValue
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-resourcerequirement.html#cfn-batch-jobdefinition-resourcerequirement-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-resourcerequirement.html#cfn-batch-jobdefinition-resourcerequirement-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
        }

        public class RetryStrategy : Humidifier.Base.BaseSubResource, IHaveAttempts
        {
            /// <summary>
            /// EvaluateOnExit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-retrystrategy.html#cfn-batch-jobdefinition-retrystrategy-evaluateonexit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EvaluateOnExit
            /// </summary>
            public List<Humidifier.Batch.JobDefinitionTypes.EvaluateOnExit> EvaluateOnExit { get; set; }
            /// <summary>
            /// Attempts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-retrystrategy.html#cfn-batch-jobdefinition-retrystrategy-attempts
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Attempts { get; set; }
        }

        public class RuntimePlatform : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// OperatingSystemFamily
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-ecstaskproperties-runtimeplatform.html#cfn-batch-jobdefinition-ecstaskproperties-runtimeplatform-operatingsystemfamily
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OperatingSystemFamily { get; set; }
            /// <summary>
            /// CpuArchitecture
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-ecstaskproperties-runtimeplatform.html#cfn-batch-jobdefinition-ecstaskproperties-runtimeplatform-cpuarchitecture
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CpuArchitecture { get; set; }
        }

        public class Secret : Humidifier.Base.BaseSubResource, IHaveName, IHaveValueFrom
        {
            /// <summary>
            /// ValueFrom
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-secret.html#cfn-batch-jobdefinition-secret-valuefrom
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ValueFrom { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-secret.html#cfn-batch-jobdefinition-secret-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class TaskContainerDependency : Humidifier.Base.BaseSubResource, IHaveCondition, IHaveContainerName
        {
            /// <summary>
            /// Condition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-taskcontainerdependency.html#cfn-batch-jobdefinition-taskcontainerdependency-condition
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Condition { get; set; }
            /// <summary>
            /// ContainerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-taskcontainerdependency.html#cfn-batch-jobdefinition-taskcontainerdependency-containername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContainerName { get; set; }
        }

        public class TaskContainerProperties : Humidifier.Base.BaseSubResource, IHaveName, IHaveImage, IHaveCommand, IHaveUser, IHavePrivileged, IHaveReadonlyRootFilesystem, IHaveEssential
        {
            /// <summary>
            /// RepositoryCredentials
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-taskcontainerproperties.html#cfn-batch-jobdefinition-taskcontainerproperties-repositorycredentials
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RepositoryCredentials
            /// </summary>
            public Humidifier.Batch.JobDefinitionTypes.RepositoryCredentials RepositoryCredentials { get; set; }
            /// <summary>
            /// User
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-taskcontainerproperties.html#cfn-batch-jobdefinition-taskcontainerproperties-user
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic User { get; set; }
            /// <summary>
            /// Secrets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-taskcontainerproperties.html#cfn-batch-jobdefinition-taskcontainerproperties-secrets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Secret
            /// </summary>
            public List<Humidifier.Batch.JobDefinitionTypes.Secret> Secrets { get; set; }
            /// <summary>
            /// Privileged
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-taskcontainerproperties.html#cfn-batch-jobdefinition-taskcontainerproperties-privileged
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Privileged { get; set; }
            /// <summary>
            /// LinuxParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-taskcontainerproperties.html#cfn-batch-jobdefinition-taskcontainerproperties-linuxparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LinuxParameters
            /// </summary>
            public Humidifier.Batch.JobDefinitionTypes.LinuxParameters LinuxParameters { get; set; }
            /// <summary>
            /// ReadonlyRootFilesystem
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-taskcontainerproperties.html#cfn-batch-jobdefinition-taskcontainerproperties-readonlyrootfilesystem
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ReadonlyRootFilesystem { get; set; }
            /// <summary>
            /// Image
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-taskcontainerproperties.html#cfn-batch-jobdefinition-taskcontainerproperties-image
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Image { get; set; }
            /// <summary>
            /// LogConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-taskcontainerproperties.html#cfn-batch-jobdefinition-taskcontainerproperties-logconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LogConfiguration
            /// </summary>
            public Humidifier.Batch.JobDefinitionTypes.LogConfiguration LogConfiguration { get; set; }
            /// <summary>
            /// Essential
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-taskcontainerproperties.html#cfn-batch-jobdefinition-taskcontainerproperties-essential
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Essential { get; set; }
            /// <summary>
            /// ResourceRequirements
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-taskcontainerproperties.html#cfn-batch-jobdefinition-taskcontainerproperties-resourcerequirements
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ResourceRequirement
            /// </summary>
            public List<Humidifier.Batch.JobDefinitionTypes.ResourceRequirement> ResourceRequirements { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-taskcontainerproperties.html#cfn-batch-jobdefinition-taskcontainerproperties-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
            /// <summary>
            /// MountPoints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-taskcontainerproperties.html#cfn-batch-jobdefinition-taskcontainerproperties-mountpoints
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MountPoints
            /// </summary>
            public List<Humidifier.Batch.JobDefinitionTypes.MountPoints> MountPoints { get; set; }
            /// <summary>
            /// DependsOn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-taskcontainerproperties.html#cfn-batch-jobdefinition-taskcontainerproperties-dependson
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TaskContainerDependency
            /// </summary>
            public List<Humidifier.Batch.JobDefinitionTypes.TaskContainerDependency> DependsOn { get; set; }
            /// <summary>
            /// Command
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-taskcontainerproperties.html#cfn-batch-jobdefinition-taskcontainerproperties-command
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Command { get; set; }
            /// <summary>
            /// Environment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-taskcontainerproperties.html#cfn-batch-jobdefinition-taskcontainerproperties-environment
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Environment
            /// </summary>
            public List<Humidifier.Batch.JobDefinitionTypes.Environment> Environment { get; set; }
            /// <summary>
            /// Ulimits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-taskcontainerproperties.html#cfn-batch-jobdefinition-taskcontainerproperties-ulimits
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Ulimit
            /// </summary>
            public List<Humidifier.Batch.JobDefinitionTypes.Ulimit> Ulimits { get; set; }
        }

        public class Timeout : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AttemptDurationSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-timeout.html#cfn-batch-jobdefinition-timeout-attemptdurationseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic AttemptDurationSeconds { get; set; }
        }

        public class Tmpfs : Humidifier.Base.BaseSubResource, IHaveSize, IHaveContainerPath, IHaveMountOptions
        {
            /// <summary>
            /// Size
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-tmpfs.html#cfn-batch-jobdefinition-tmpfs-size
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Size { get; set; }
            /// <summary>
            /// ContainerPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-tmpfs.html#cfn-batch-jobdefinition-tmpfs-containerpath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContainerPath { get; set; }
            /// <summary>
            /// MountOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-tmpfs.html#cfn-batch-jobdefinition-tmpfs-mountoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic MountOptions { get; set; }
        }

        public class Ulimit : Humidifier.Base.BaseSubResource, IHaveName, IHaveSoftLimit, IHaveHardLimit
        {
            /// <summary>
            /// SoftLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-ulimit.html#cfn-batch-jobdefinition-ulimit-softlimit
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic SoftLimit { get; set; }
            /// <summary>
            /// HardLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-ulimit.html#cfn-batch-jobdefinition-ulimit-hardlimit
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic HardLimit { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-ulimit.html#cfn-batch-jobdefinition-ulimit-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class Volumes : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Host
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-volumes.html#cfn-batch-jobdefinition-volumes-host
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VolumesHost
            /// </summary>
            public Humidifier.Batch.JobDefinitionTypes.VolumesHost Host { get; set; }
            /// <summary>
            /// EfsVolumeConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-volumes.html#cfn-batch-jobdefinition-volumes-efsvolumeconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EfsVolumeConfiguration
            /// </summary>
            public Humidifier.Batch.JobDefinitionTypes.EfsVolumeConfiguration EfsVolumeConfiguration { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-volumes.html#cfn-batch-jobdefinition-volumes-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class VolumesHost : Humidifier.Base.BaseSubResource, IHaveSourcePath
        {
            /// <summary>
            /// SourcePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-volumeshost.html#cfn-batch-jobdefinition-volumeshost-sourcepath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourcePath { get; set; }
        }
    }
}