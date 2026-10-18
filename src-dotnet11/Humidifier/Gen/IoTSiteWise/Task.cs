namespace Humidifier.IoTSiteWise
{
    using global::System.Collections.Generic;
    using TaskTypes;

    public class Task : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveTaskName, IHaveWorkspaceName, IHaveIoTSiteWiseTaskTypesTaskConfigurationTaskConfiguration
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string TaskArn =  "TaskArn" ;
        }

        public override string AWSTypeName { get => AWS.IoTSiteWise.Task; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-task.html#cfn-iotsitewise-task-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        public Union<string, BaseFunction>? TaskName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// WorkspaceName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-task.html#cfn-iotsitewise-task-workspacename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? WorkspaceName { get; set; }

        /// <summary>
        /// TaskConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-task.html#cfn-iotsitewise-task-taskconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: TaskConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.IoTSiteWise.TaskTypes.TaskConfiguration, BaseFunction>? TaskConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-task.html#cfn-iotsitewise-task-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace TaskTypes
    {
        public class ContainerTaskConfiguration : Humidifier.Base.BaseSubResource, IHaveTaskExecutionRole, IHaveTimeoutSeconds_Integer, IHaveProcessingUnit, IHaveListOfIoTSiteWiseTaskTypesMountMounts, IHaveStringDictionaryOfEnvironmentVariables, IHaveStringListOfCommand, IHaveProcessingType, IHaveIoTSiteWiseTaskTypesEphemeralStorageConfigurationEphemeralStorageConfiguration, IHaveEcrUri
        {
            /// <summary>
            /// TaskExecutionRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-task-containertaskconfiguration.html#cfn-iotsitewise-task-containertaskconfiguration-taskexecutionrole
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TaskExecutionRole { get; set; }
            /// <summary>
            /// TimeoutSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-task-containertaskconfiguration.html#cfn-iotsitewise-task-containertaskconfiguration-timeoutseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimeoutSeconds { get; set; }
            /// <summary>
            /// ProcessingUnit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-task-containertaskconfiguration.html#cfn-iotsitewise-task-containertaskconfiguration-processingunit
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProcessingUnit { get; set; }
            /// <summary>
            /// Mounts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-task-containertaskconfiguration.html#cfn-iotsitewise-task-containertaskconfiguration-mounts
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Mount
            /// </summary>
            public Union<IReadOnlyList<Humidifier.IoTSiteWise.TaskTypes.Mount>, IReadOnlyList<Union<Humidifier.IoTSiteWise.TaskTypes.Mount, BaseFunction>>, BaseFunction>? Mounts { get; set; }
            /// <summary>
            /// EnvironmentVariables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-task-containertaskconfiguration.html#cfn-iotsitewise-task-containertaskconfiguration-environmentvariables
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? EnvironmentVariables { get; set; }
            /// <summary>
            /// Command
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-task-containertaskconfiguration.html#cfn-iotsitewise-task-containertaskconfiguration-command
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Command { get; set; }
            /// <summary>
            /// ProcessingType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-task-containertaskconfiguration.html#cfn-iotsitewise-task-containertaskconfiguration-processingtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProcessingType { get; set; }
            /// <summary>
            /// EphemeralStorageConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-task-containertaskconfiguration.html#cfn-iotsitewise-task-containertaskconfiguration-ephemeralstorageconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EphemeralStorageConfiguration
            /// </summary>
            public Union<Humidifier.IoTSiteWise.TaskTypes.EphemeralStorageConfiguration, BaseFunction>? EphemeralStorageConfiguration { get; set; }
            /// <summary>
            /// EcrUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-task-containertaskconfiguration.html#cfn-iotsitewise-task-containertaskconfiguration-ecruri
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EcrUri { get; set; }
        }

        public class EphemeralStorageConfiguration : Humidifier.Base.BaseSubResource, IHaveStorageSizeInGiB_Integer, IHaveStorageClass
        {
            /// <summary>
            /// StorageSizeInGiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-task-ephemeralstorageconfiguration.html#cfn-iotsitewise-task-ephemeralstorageconfiguration-storagesizeingib
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? StorageSizeInGiB { get; set; }
            /// <summary>
            /// StorageClass
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-task-ephemeralstorageconfiguration.html#cfn-iotsitewise-task-ephemeralstorageconfiguration-storageclass
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StorageClass { get; set; }
        }

        public class Mount : Humidifier.Base.BaseSubResource, IHaveRelativePath, IHaveStorageType, IHaveIoTSiteWiseTaskTypesMountSourceSource, IHaveName
        {
            /// <summary>
            /// RelativePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-task-mount.html#cfn-iotsitewise-task-mount-relativepath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RelativePath { get; set; }
            /// <summary>
            /// StorageType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-task-mount.html#cfn-iotsitewise-task-mount-storagetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StorageType { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-task-mount.html#cfn-iotsitewise-task-mount-source
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MountSource
            /// </summary>
            public Union<Humidifier.IoTSiteWise.TaskTypes.MountSource, BaseFunction>? Source { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-task-mount.html#cfn-iotsitewise-task-mount-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class MountSource : Humidifier.Base.BaseSubResource, IHaveIoTSiteWiseTaskTypesS3AccessPointSourceS3AccessPoint
        {
            /// <summary>
            /// S3AccessPoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-task-mountsource.html#cfn-iotsitewise-task-mountsource-s3accesspoint
            /// Required: True
            /// UpdateType: Mutable
            /// Type: S3AccessPointSource
            /// </summary>
            public Union<Humidifier.IoTSiteWise.TaskTypes.S3AccessPointSource, BaseFunction>? S3AccessPoint { get; set; }
        }

        public class S3AccessPointSource : Humidifier.Base.BaseSubResource, IHaveAccessPointArn, IHavePrefix
        {
            /// <summary>
            /// AccessPointArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-task-s3accesspointsource.html#cfn-iotsitewise-task-s3accesspointsource-accesspointarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccessPointArn { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-task-s3accesspointsource.html#cfn-iotsitewise-task-s3accesspointsource-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Prefix { get; set; }
        }

        public class TaskConfiguration : Humidifier.Base.BaseSubResource, IHaveIoTSiteWiseTaskTypesContainerTaskConfigurationContainerTaskConfiguration
        {
            /// <summary>
            /// ContainerTaskConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-task-taskconfiguration.html#cfn-iotsitewise-task-taskconfiguration-containertaskconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ContainerTaskConfiguration
            /// </summary>
            public Union<Humidifier.IoTSiteWise.TaskTypes.ContainerTaskConfiguration, BaseFunction>? ContainerTaskConfiguration { get; set; }
        }
    }
}