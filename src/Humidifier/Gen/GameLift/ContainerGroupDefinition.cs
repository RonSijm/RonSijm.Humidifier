namespace Humidifier.GameLift
{
    using System.Collections.Generic;
    using ContainerGroupDefinitionTypes;

    public class ContainerGroupDefinition : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveVersionDescription, IHaveOperatingSystem
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string ContainerGroupDefinitionArn =  "ContainerGroupDefinitionArn" ;
            public static string StatusReason =  "StatusReason" ;
            public static string CreationTime =  "CreationTime" ;
            public static string VersionNumber =  "VersionNumber" ;
        }

        public override string AWSTypeName { get => AWS.GameLift.ContainerGroupDefinition; }

        /// <summary>
        /// OperatingSystem
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containergroupdefinition.html#cfn-gamelift-containergroupdefinition-operatingsystem
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic OperatingSystem { get; set; }
        /// <summary>
        /// VersionDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containergroupdefinition.html#cfn-gamelift-containergroupdefinition-versiondescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic VersionDescription { get; set; }
        /// <summary>
        /// GameServerContainerDefinition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containergroupdefinition.html#cfn-gamelift-containergroupdefinition-gameservercontainerdefinition
        /// Required: False
        /// UpdateType: Mutable
        /// Type: GameServerContainerDefinition
        /// </summary>
        public Humidifier.GameLift.ContainerGroupDefinitionTypes.GameServerContainerDefinition GameServerContainerDefinition { get; set; }

        /// <summary>
        /// TotalMemoryLimitMebibytes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containergroupdefinition.html#cfn-gamelift-containergroupdefinition-totalmemorylimitmebibytes
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public dynamic TotalMemoryLimitMebibytes { get; set; }
        /// <summary>
        /// SourceVersionNumber
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containergroupdefinition.html#cfn-gamelift-containergroupdefinition-sourceversionnumber
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic SourceVersionNumber { get; set; }

        /// <summary>
        /// TotalVcpuLimit
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containergroupdefinition.html#cfn-gamelift-containergroupdefinition-totalvcpulimit
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Double
        /// </summary>
        [Required]
        public dynamic TotalVcpuLimit { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containergroupdefinition.html#cfn-gamelift-containergroupdefinition-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ContainerGroupType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containergroupdefinition.html#cfn-gamelift-containergroupdefinition-containergrouptype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ContainerGroupType { get; set; }
        /// <summary>
        /// SupportContainerDefinitions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containergroupdefinition.html#cfn-gamelift-containergroupdefinition-supportcontainerdefinitions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: SupportContainerDefinition
        /// </summary>
        public List<Humidifier.GameLift.ContainerGroupDefinitionTypes.SupportContainerDefinition> SupportContainerDefinitions { get; set; }
    }

    namespace ContainerGroupDefinitionTypes
    {
        public class ContainerDependency : Humidifier.Base.BaseSubResource, IHaveContainerName, IHaveCondition
        {
            /// <summary>
            /// Condition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-containerdependency.html#cfn-gamelift-containergroupdefinition-containerdependency-condition
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Condition { get; set; }
            /// <summary>
            /// ContainerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-containerdependency.html#cfn-gamelift-containergroupdefinition-containerdependency-containername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContainerName { get; set; }
        }

        public class ContainerEnvironment : Humidifier.Base.BaseSubResource, IHaveName, IHaveValue
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-containerenvironment.html#cfn-gamelift-containergroupdefinition-containerenvironment-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-containerenvironment.html#cfn-gamelift-containergroupdefinition-containerenvironment-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class ContainerHealthCheck : Humidifier.Base.BaseSubResource, IHaveInterval, IHaveTimeout, IHaveCommand, IHaveRetries, IHaveStartPeriod
        {
            /// <summary>
            /// Command
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-containerhealthcheck.html#cfn-gamelift-containergroupdefinition-containerhealthcheck-command
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Command { get; set; }
            /// <summary>
            /// Timeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-containerhealthcheck.html#cfn-gamelift-containergroupdefinition-containerhealthcheck-timeout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Timeout { get; set; }
            /// <summary>
            /// Retries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-containerhealthcheck.html#cfn-gamelift-containergroupdefinition-containerhealthcheck-retries
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Retries { get; set; }
            /// <summary>
            /// Interval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-containerhealthcheck.html#cfn-gamelift-containergroupdefinition-containerhealthcheck-interval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Interval { get; set; }
            /// <summary>
            /// StartPeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-containerhealthcheck.html#cfn-gamelift-containergroupdefinition-containerhealthcheck-startperiod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic StartPeriod { get; set; }
        }

        public class ContainerMountPoint : Humidifier.Base.BaseSubResource, IHaveContainerPath, IHaveAccessLevel
        {
            /// <summary>
            /// InstancePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-containermountpoint.html#cfn-gamelift-containergroupdefinition-containermountpoint-instancepath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InstancePath { get; set; }
            /// <summary>
            /// ContainerPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-containermountpoint.html#cfn-gamelift-containergroupdefinition-containermountpoint-containerpath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContainerPath { get; set; }
            /// <summary>
            /// AccessLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-containermountpoint.html#cfn-gamelift-containergroupdefinition-containermountpoint-accesslevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AccessLevel { get; set; }
        }

        public class ContainerPortRange : Humidifier.Base.BaseSubResource, IHaveProtocol, IHaveFromPort, IHaveToPort
        {
            /// <summary>
            /// FromPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-containerportrange.html#cfn-gamelift-containergroupdefinition-containerportrange-fromport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic FromPort { get; set; }
            /// <summary>
            /// ToPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-containerportrange.html#cfn-gamelift-containergroupdefinition-containerportrange-toport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ToPort { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-containerportrange.html#cfn-gamelift-containergroupdefinition-containerportrange-protocol
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Protocol { get; set; }
        }

        public class GameServerContainerDefinition : Humidifier.Base.BaseSubResource, IHaveContainerName, IHaveImageUri, IHaveServerSdkVersion, IHaveResolvedImageDigest, IHaveGameLiftContainerGroupDefinitionTypesPortConfigurationPortConfiguration
        {
            /// <summary>
            /// MountPoints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-gameservercontainerdefinition.html#cfn-gamelift-containergroupdefinition-gameservercontainerdefinition-mountpoints
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ContainerMountPoint
            /// </summary>
            public List<Humidifier.GameLift.ContainerGroupDefinitionTypes.ContainerMountPoint> MountPoints { get; set; }
            /// <summary>
            /// DependsOn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-gameservercontainerdefinition.html#cfn-gamelift-containergroupdefinition-gameservercontainerdefinition-dependson
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ContainerDependency
            /// </summary>
            public List<Humidifier.GameLift.ContainerGroupDefinitionTypes.ContainerDependency> DependsOn { get; set; }
            /// <summary>
            /// ContainerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-gameservercontainerdefinition.html#cfn-gamelift-containergroupdefinition-gameservercontainerdefinition-containername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContainerName { get; set; }
            /// <summary>
            /// EnvironmentOverride
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-gameservercontainerdefinition.html#cfn-gamelift-containergroupdefinition-gameservercontainerdefinition-environmentoverride
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ContainerEnvironment
            /// </summary>
            public List<Humidifier.GameLift.ContainerGroupDefinitionTypes.ContainerEnvironment> EnvironmentOverride { get; set; }
            /// <summary>
            /// ServerSdkVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-gameservercontainerdefinition.html#cfn-gamelift-containergroupdefinition-gameservercontainerdefinition-serversdkversion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ServerSdkVersion { get; set; }
            /// <summary>
            /// ImageUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-gameservercontainerdefinition.html#cfn-gamelift-containergroupdefinition-gameservercontainerdefinition-imageuri
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ImageUri { get; set; }
            /// <summary>
            /// ResolvedImageDigest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-gameservercontainerdefinition.html#cfn-gamelift-containergroupdefinition-gameservercontainerdefinition-resolvedimagedigest
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResolvedImageDigest { get; set; }
            /// <summary>
            /// PortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-gameservercontainerdefinition.html#cfn-gamelift-containergroupdefinition-gameservercontainerdefinition-portconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PortConfiguration
            /// </summary>
            public Humidifier.GameLift.ContainerGroupDefinitionTypes.PortConfiguration PortConfiguration { get; set; }
        }

        public class PortConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ContainerPortRanges
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-portconfiguration.html#cfn-gamelift-containergroupdefinition-portconfiguration-containerportranges
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ContainerPortRange
            /// </summary>
            public List<Humidifier.GameLift.ContainerGroupDefinitionTypes.ContainerPortRange> ContainerPortRanges { get; set; }
        }

        public class SupportContainerDefinition : Humidifier.Base.BaseSubResource, IHaveContainerName, IHaveImageUri, IHaveEssential, IHaveResolvedImageDigest, IHaveGameLiftContainerGroupDefinitionTypesPortConfigurationPortConfiguration
        {
            /// <summary>
            /// MountPoints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-supportcontainerdefinition.html#cfn-gamelift-containergroupdefinition-supportcontainerdefinition-mountpoints
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ContainerMountPoint
            /// </summary>
            public List<Humidifier.GameLift.ContainerGroupDefinitionTypes.ContainerMountPoint> MountPoints { get; set; }
            /// <summary>
            /// DependsOn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-supportcontainerdefinition.html#cfn-gamelift-containergroupdefinition-supportcontainerdefinition-dependson
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ContainerDependency
            /// </summary>
            public List<Humidifier.GameLift.ContainerGroupDefinitionTypes.ContainerDependency> DependsOn { get; set; }
            /// <summary>
            /// ContainerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-supportcontainerdefinition.html#cfn-gamelift-containergroupdefinition-supportcontainerdefinition-containername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContainerName { get; set; }
            /// <summary>
            /// MemoryHardLimitMebibytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-supportcontainerdefinition.html#cfn-gamelift-containergroupdefinition-supportcontainerdefinition-memoryhardlimitmebibytes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MemoryHardLimitMebibytes { get; set; }
            /// <summary>
            /// EnvironmentOverride
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-supportcontainerdefinition.html#cfn-gamelift-containergroupdefinition-supportcontainerdefinition-environmentoverride
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ContainerEnvironment
            /// </summary>
            public List<Humidifier.GameLift.ContainerGroupDefinitionTypes.ContainerEnvironment> EnvironmentOverride { get; set; }
            /// <summary>
            /// HealthCheck
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-supportcontainerdefinition.html#cfn-gamelift-containergroupdefinition-supportcontainerdefinition-healthcheck
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ContainerHealthCheck
            /// </summary>
            public Humidifier.GameLift.ContainerGroupDefinitionTypes.ContainerHealthCheck HealthCheck { get; set; }
            /// <summary>
            /// Vcpu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-supportcontainerdefinition.html#cfn-gamelift-containergroupdefinition-supportcontainerdefinition-vcpu
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Vcpu { get; set; }
            /// <summary>
            /// ImageUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-supportcontainerdefinition.html#cfn-gamelift-containergroupdefinition-supportcontainerdefinition-imageuri
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ImageUri { get; set; }
            /// <summary>
            /// ResolvedImageDigest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-supportcontainerdefinition.html#cfn-gamelift-containergroupdefinition-supportcontainerdefinition-resolvedimagedigest
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResolvedImageDigest { get; set; }
            /// <summary>
            /// Essential
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-supportcontainerdefinition.html#cfn-gamelift-containergroupdefinition-supportcontainerdefinition-essential
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Essential { get; set; }
            /// <summary>
            /// PortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-supportcontainerdefinition.html#cfn-gamelift-containergroupdefinition-supportcontainerdefinition-portconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PortConfiguration
            /// </summary>
            public Humidifier.GameLift.ContainerGroupDefinitionTypes.PortConfiguration PortConfiguration { get; set; }
        }
    }
}