namespace Humidifier.IoTSiteWise
{
    using global::System.Collections.Generic;
    using TaskTypes;

    public class Task : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription
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
        public dynamic Description { get; set; }
        public dynamic TaskName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// WorkspaceName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-task.html#cfn-iotsitewise-task-workspacename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic WorkspaceName { get; set; }

        /// <summary>
        /// TaskConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-task.html#cfn-iotsitewise-task-taskconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: TaskConfiguration
        /// </summary>
        [Required]
        public Humidifier.IoTSiteWise.TaskTypes.TaskConfiguration TaskConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-task.html#cfn-iotsitewise-task-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace TaskTypes
    {
        public class ContainerTaskConfiguration : Humidifier.Base.BaseSubResource, IHaveCommand, IHaveTimeoutSeconds
        {
            /// <summary>
            /// TaskExecutionRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-task-containertaskconfiguration.html#cfn-iotsitewise-task-containertaskconfiguration-taskexecutionrole
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TaskExecutionRole { get; set; }
            /// <summary>
            /// TimeoutSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-task-containertaskconfiguration.html#cfn-iotsitewise-task-containertaskconfiguration-timeoutseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TimeoutSeconds { get; set; }
            /// <summary>
            /// ProcessingUnit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-task-containertaskconfiguration.html#cfn-iotsitewise-task-containertaskconfiguration-processingunit
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ProcessingUnit { get; set; }
            /// <summary>
            /// Mounts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-task-containertaskconfiguration.html#cfn-iotsitewise-task-containertaskconfiguration-mounts
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Mount
            /// </summary>
            public List<Humidifier.IoTSiteWise.TaskTypes.Mount> Mounts { get; set; }
            /// <summary>
            /// EnvironmentVariables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-task-containertaskconfiguration.html#cfn-iotsitewise-task-containertaskconfiguration-environmentvariables
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> EnvironmentVariables { get; set; }
            /// <summary>
            /// Command
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-task-containertaskconfiguration.html#cfn-iotsitewise-task-containertaskconfiguration-command
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Command { get; set; }
            /// <summary>
            /// ProcessingType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-task-containertaskconfiguration.html#cfn-iotsitewise-task-containertaskconfiguration-processingtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ProcessingType { get; set; }
            /// <summary>
            /// EphemeralStorageConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-task-containertaskconfiguration.html#cfn-iotsitewise-task-containertaskconfiguration-ephemeralstorageconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EphemeralStorageConfiguration
            /// </summary>
            public Humidifier.IoTSiteWise.TaskTypes.EphemeralStorageConfiguration EphemeralStorageConfiguration { get; set; }
            /// <summary>
            /// EcrUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-task-containertaskconfiguration.html#cfn-iotsitewise-task-containertaskconfiguration-ecruri
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EcrUri { get; set; }
        }

        public class EphemeralStorageConfiguration : Humidifier.Base.BaseSubResource, IHaveStorageClass
        {
            /// <summary>
            /// StorageSizeInGiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-task-ephemeralstorageconfiguration.html#cfn-iotsitewise-task-ephemeralstorageconfiguration-storagesizeingib
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic StorageSizeInGiB { get; set; }
            /// <summary>
            /// StorageClass
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-task-ephemeralstorageconfiguration.html#cfn-iotsitewise-task-ephemeralstorageconfiguration-storageclass
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StorageClass { get; set; }
        }

        public class Mount : Humidifier.Base.BaseSubResource, IHaveName, IHaveStorageType
        {
            /// <summary>
            /// RelativePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-task-mount.html#cfn-iotsitewise-task-mount-relativepath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RelativePath { get; set; }
            /// <summary>
            /// StorageType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-task-mount.html#cfn-iotsitewise-task-mount-storagetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StorageType { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-task-mount.html#cfn-iotsitewise-task-mount-source
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MountSource
            /// </summary>
            public Humidifier.IoTSiteWise.TaskTypes.MountSource Source { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-task-mount.html#cfn-iotsitewise-task-mount-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class MountSource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3AccessPoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-task-mountsource.html#cfn-iotsitewise-task-mountsource-s3accesspoint
            /// Required: True
            /// UpdateType: Mutable
            /// Type: S3AccessPointSource
            /// </summary>
            public Humidifier.IoTSiteWise.TaskTypes.S3AccessPointSource S3AccessPoint { get; set; }
        }

        public class S3AccessPointSource : Humidifier.Base.BaseSubResource, IHavePrefix, IHaveAccessPointArn
        {
            /// <summary>
            /// AccessPointArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-task-s3accesspointsource.html#cfn-iotsitewise-task-s3accesspointsource-accesspointarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AccessPointArn { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-task-s3accesspointsource.html#cfn-iotsitewise-task-s3accesspointsource-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix { get; set; }
        }

        public class TaskConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ContainerTaskConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-task-taskconfiguration.html#cfn-iotsitewise-task-taskconfiguration-containertaskconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ContainerTaskConfiguration
            /// </summary>
            public Humidifier.IoTSiteWise.TaskTypes.ContainerTaskConfiguration ContainerTaskConfiguration { get; set; }
        }
    }
}