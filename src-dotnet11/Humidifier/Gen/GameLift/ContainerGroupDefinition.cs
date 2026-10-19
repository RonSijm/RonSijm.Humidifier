namespace Humidifier.GameLift
{
    using global::System.Collections.Generic;
    using ContainerGroupDefinitionTypes;

    public class ContainerGroupDefinition : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveOperatingSystem, IHaveVersionDescription, IHaveGameLiftContainerGroupDefinitionTypesGameServerContainerDefinitionGameServerContainerDefinition, IHaveTotalMemoryLimitMebibytes_Integer, IHaveSourceVersionNumber_Integer, IHaveTotalVcpuLimit_Double, IHaveName, IHaveContainerGroupType, IHaveListOfGameLiftContainerGroupDefinitionTypesSupportContainerDefinitionSupportContainerDefinitions
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
        public Union<string, BaseFunction>? OperatingSystem { get; set; }
        /// <summary>
        /// VersionDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containergroupdefinition.html#cfn-gamelift-containergroupdefinition-versiondescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VersionDescription { get; set; }
        /// <summary>
        /// GameServerContainerDefinition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containergroupdefinition.html#cfn-gamelift-containergroupdefinition-gameservercontainerdefinition
        /// Required: False
        /// UpdateType: Mutable
        /// Type: GameServerContainerDefinition
        /// </summary>
        public Union<Humidifier.GameLift.ContainerGroupDefinitionTypes.GameServerContainerDefinition, BaseFunction>? GameServerContainerDefinition { get; set; }

        /// <summary>
        /// TotalMemoryLimitMebibytes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containergroupdefinition.html#cfn-gamelift-containergroupdefinition-totalmemorylimitmebibytes
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? TotalMemoryLimitMebibytes { get; set; }
        /// <summary>
        /// SourceVersionNumber
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containergroupdefinition.html#cfn-gamelift-containergroupdefinition-sourceversionnumber
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? SourceVersionNumber { get; set; }
        /// <summary>
        /// TotalVcpuLimit
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containergroupdefinition.html#cfn-gamelift-containergroupdefinition-totalvcpulimit
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Double
        /// </summary>
        public Union<double, BaseFunction>? TotalVcpuLimit { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containergroupdefinition.html#cfn-gamelift-containergroupdefinition-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ContainerGroupType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containergroupdefinition.html#cfn-gamelift-containergroupdefinition-containergrouptype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ContainerGroupType { get; set; }
        /// <summary>
        /// SupportContainerDefinitions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-containergroupdefinition.html#cfn-gamelift-containergroupdefinition-supportcontainerdefinitions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: SupportContainerDefinition
        /// </summary>
        public Union<IReadOnlyList<Humidifier.GameLift.ContainerGroupDefinitionTypes.SupportContainerDefinition>, IReadOnlyList<Union<Humidifier.GameLift.ContainerGroupDefinitionTypes.SupportContainerDefinition, BaseFunction>>, BaseFunction>? SupportContainerDefinitions { get; set; }
    }

    namespace ContainerGroupDefinitionTypes
    {
        public class ContainerDependency : Humidifier.Base.BaseSubResource, IHaveCondition, IHaveContainerName
        {
            /// <summary>
            /// Condition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-containerdependency.html#cfn-gamelift-containergroupdefinition-containerdependency-condition
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Condition { get; set; }
            /// <summary>
            /// ContainerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-containerdependency.html#cfn-gamelift-containergroupdefinition-containerdependency-containername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContainerName { get; set; }
        }

        public class ContainerEnvironment : Humidifier.Base.BaseSubResource, IHaveValue, IHaveName
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-containerenvironment.html#cfn-gamelift-containergroupdefinition-containerenvironment-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-containerenvironment.html#cfn-gamelift-containergroupdefinition-containerenvironment-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class ContainerHealthCheck : Humidifier.Base.BaseSubResource, IHaveStringListOfCommand, IHaveTimeout_Integer, IHaveRetries_Integer, IHaveInterval_Integer, IHaveStartPeriod_Integer
        {
            /// <summary>
            /// Command
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-containerhealthcheck.html#cfn-gamelift-containergroupdefinition-containerhealthcheck-command
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Command { get; set; }
            /// <summary>
            /// Timeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-containerhealthcheck.html#cfn-gamelift-containergroupdefinition-containerhealthcheck-timeout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Timeout { get; set; }
            /// <summary>
            /// Retries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-containerhealthcheck.html#cfn-gamelift-containergroupdefinition-containerhealthcheck-retries
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Retries { get; set; }
            /// <summary>
            /// Interval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-containerhealthcheck.html#cfn-gamelift-containergroupdefinition-containerhealthcheck-interval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Interval { get; set; }
            /// <summary>
            /// StartPeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-containerhealthcheck.html#cfn-gamelift-containergroupdefinition-containerhealthcheck-startperiod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? StartPeriod { get; set; }
        }

        public class ContainerMountPoint : Humidifier.Base.BaseSubResource, IHaveContainerPath, IHaveAccessLevel, IHaveInstancePath
        {
            /// <summary>
            /// ContainerPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-containermountpoint.html#cfn-gamelift-containergroupdefinition-containermountpoint-containerpath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContainerPath { get; set; }
            /// <summary>
            /// AccessLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-containermountpoint.html#cfn-gamelift-containergroupdefinition-containermountpoint-accesslevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccessLevel { get; set; }
            /// <summary>
            /// InstancePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-containermountpoint.html#cfn-gamelift-containergroupdefinition-containermountpoint-instancepath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstancePath { get; set; }
        }

        public class ContainerPortRange : Humidifier.Base.BaseSubResource, IHaveFromPort_Integer, IHaveToPort_Integer, IHaveProtocol
        {
            /// <summary>
            /// FromPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-containerportrange.html#cfn-gamelift-containergroupdefinition-containerportrange-fromport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FromPort { get; set; }
            /// <summary>
            /// ToPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-containerportrange.html#cfn-gamelift-containergroupdefinition-containerportrange-toport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ToPort { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-containerportrange.html#cfn-gamelift-containergroupdefinition-containerportrange-protocol
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Protocol { get; set; }
        }

        public class GameServerContainerDefinition : Humidifier.Base.BaseSubResource, IHaveListOfGameLiftContainerGroupDefinitionTypesContainerMountPointMountPoints, IHaveListOfGameLiftContainerGroupDefinitionTypesContainerDependencyDependsOn, IHaveContainerName, IHaveListOfGameLiftContainerGroupDefinitionTypesContainerEnvironmentEnvironmentOverride, IHaveGameLiftContainerGroupDefinitionTypesLinuxCapabilitiesLinuxCapabilities, IHaveServerSdkVersion, IHaveVcpu_Double, IHaveImageUri, IHaveResolvedImageDigest, IHaveGameLiftContainerGroupDefinitionTypesPortConfigurationPortConfiguration
        {
            /// <summary>
            /// MountPoints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-gameservercontainerdefinition.html#cfn-gamelift-containergroupdefinition-gameservercontainerdefinition-mountpoints
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ContainerMountPoint
            /// </summary>
            public Union<IReadOnlyList<Humidifier.GameLift.ContainerGroupDefinitionTypes.ContainerMountPoint>, IReadOnlyList<Union<Humidifier.GameLift.ContainerGroupDefinitionTypes.ContainerMountPoint, BaseFunction>>, BaseFunction>? MountPoints { get; set; }
            /// <summary>
            /// DependsOn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-gameservercontainerdefinition.html#cfn-gamelift-containergroupdefinition-gameservercontainerdefinition-dependson
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ContainerDependency
            /// </summary>
            public Union<IReadOnlyList<Humidifier.GameLift.ContainerGroupDefinitionTypes.ContainerDependency>, IReadOnlyList<Union<Humidifier.GameLift.ContainerGroupDefinitionTypes.ContainerDependency, BaseFunction>>, BaseFunction>? DependsOn { get; set; }
            /// <summary>
            /// ContainerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-gameservercontainerdefinition.html#cfn-gamelift-containergroupdefinition-gameservercontainerdefinition-containername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContainerName { get; set; }
            /// <summary>
            /// EnvironmentOverride
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-gameservercontainerdefinition.html#cfn-gamelift-containergroupdefinition-gameservercontainerdefinition-environmentoverride
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ContainerEnvironment
            /// </summary>
            public Union<IReadOnlyList<Humidifier.GameLift.ContainerGroupDefinitionTypes.ContainerEnvironment>, IReadOnlyList<Union<Humidifier.GameLift.ContainerGroupDefinitionTypes.ContainerEnvironment, BaseFunction>>, BaseFunction>? EnvironmentOverride { get; set; }
            /// <summary>
            /// LinuxCapabilities
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-gameservercontainerdefinition.html#cfn-gamelift-containergroupdefinition-gameservercontainerdefinition-linuxcapabilities
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LinuxCapabilities
            /// </summary>
            public Union<Humidifier.GameLift.ContainerGroupDefinitionTypes.LinuxCapabilities, BaseFunction>? LinuxCapabilities { get; set; }
            /// <summary>
            /// ServerSdkVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-gameservercontainerdefinition.html#cfn-gamelift-containergroupdefinition-gameservercontainerdefinition-serversdkversion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServerSdkVersion { get; set; }
            /// <summary>
            /// Vcpu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-gameservercontainerdefinition.html#cfn-gamelift-containergroupdefinition-gameservercontainerdefinition-vcpu
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Vcpu { get; set; }
            /// <summary>
            /// ImageUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-gameservercontainerdefinition.html#cfn-gamelift-containergroupdefinition-gameservercontainerdefinition-imageuri
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImageUri { get; set; }
            /// <summary>
            /// ResolvedImageDigest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-gameservercontainerdefinition.html#cfn-gamelift-containergroupdefinition-gameservercontainerdefinition-resolvedimagedigest
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResolvedImageDigest { get; set; }
            /// <summary>
            /// PortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-gameservercontainerdefinition.html#cfn-gamelift-containergroupdefinition-gameservercontainerdefinition-portconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PortConfiguration
            /// </summary>
            public Union<Humidifier.GameLift.ContainerGroupDefinitionTypes.PortConfiguration, BaseFunction>? PortConfiguration { get; set; }
        }

        public class LinuxCapabilities : Humidifier.Base.BaseSubResource, IHaveStringListOfInclude
        {
            /// <summary>
            /// Include
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-linuxcapabilities.html#cfn-gamelift-containergroupdefinition-linuxcapabilities-include
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Include { get; set; }
        }

        public class PortConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfGameLiftContainerGroupDefinitionTypesContainerPortRangeContainerPortRanges
        {
            /// <summary>
            /// ContainerPortRanges
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-portconfiguration.html#cfn-gamelift-containergroupdefinition-portconfiguration-containerportranges
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ContainerPortRange
            /// </summary>
            public Union<IReadOnlyList<Humidifier.GameLift.ContainerGroupDefinitionTypes.ContainerPortRange>, IReadOnlyList<Union<Humidifier.GameLift.ContainerGroupDefinitionTypes.ContainerPortRange, BaseFunction>>, BaseFunction>? ContainerPortRanges { get; set; }
        }

        public class SupportContainerDefinition : Humidifier.Base.BaseSubResource, IHaveListOfGameLiftContainerGroupDefinitionTypesContainerMountPointMountPoints, IHaveListOfGameLiftContainerGroupDefinitionTypesContainerDependencyDependsOn, IHaveContainerName, IHaveMemoryHardLimitMebibytes_Integer, IHaveListOfGameLiftContainerGroupDefinitionTypesContainerEnvironmentEnvironmentOverride, IHaveGameLiftContainerGroupDefinitionTypesContainerHealthCheckHealthCheck, IHaveGameLiftContainerGroupDefinitionTypesLinuxCapabilitiesLinuxCapabilities, IHaveVcpu_Double, IHaveImageUri, IHaveResolvedImageDigest, IHaveEssential_Boolean, IHaveGameLiftContainerGroupDefinitionTypesPortConfigurationPortConfiguration
        {
            /// <summary>
            /// MountPoints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-supportcontainerdefinition.html#cfn-gamelift-containergroupdefinition-supportcontainerdefinition-mountpoints
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ContainerMountPoint
            /// </summary>
            public Union<IReadOnlyList<Humidifier.GameLift.ContainerGroupDefinitionTypes.ContainerMountPoint>, IReadOnlyList<Union<Humidifier.GameLift.ContainerGroupDefinitionTypes.ContainerMountPoint, BaseFunction>>, BaseFunction>? MountPoints { get; set; }
            /// <summary>
            /// DependsOn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-supportcontainerdefinition.html#cfn-gamelift-containergroupdefinition-supportcontainerdefinition-dependson
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ContainerDependency
            /// </summary>
            public Union<IReadOnlyList<Humidifier.GameLift.ContainerGroupDefinitionTypes.ContainerDependency>, IReadOnlyList<Union<Humidifier.GameLift.ContainerGroupDefinitionTypes.ContainerDependency, BaseFunction>>, BaseFunction>? DependsOn { get; set; }
            /// <summary>
            /// ContainerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-supportcontainerdefinition.html#cfn-gamelift-containergroupdefinition-supportcontainerdefinition-containername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContainerName { get; set; }
            /// <summary>
            /// MemoryHardLimitMebibytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-supportcontainerdefinition.html#cfn-gamelift-containergroupdefinition-supportcontainerdefinition-memoryhardlimitmebibytes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MemoryHardLimitMebibytes { get; set; }
            /// <summary>
            /// EnvironmentOverride
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-supportcontainerdefinition.html#cfn-gamelift-containergroupdefinition-supportcontainerdefinition-environmentoverride
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ContainerEnvironment
            /// </summary>
            public Union<IReadOnlyList<Humidifier.GameLift.ContainerGroupDefinitionTypes.ContainerEnvironment>, IReadOnlyList<Union<Humidifier.GameLift.ContainerGroupDefinitionTypes.ContainerEnvironment, BaseFunction>>, BaseFunction>? EnvironmentOverride { get; set; }
            /// <summary>
            /// HealthCheck
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-supportcontainerdefinition.html#cfn-gamelift-containergroupdefinition-supportcontainerdefinition-healthcheck
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ContainerHealthCheck
            /// </summary>
            public Union<Humidifier.GameLift.ContainerGroupDefinitionTypes.ContainerHealthCheck, BaseFunction>? HealthCheck { get; set; }
            /// <summary>
            /// LinuxCapabilities
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-supportcontainerdefinition.html#cfn-gamelift-containergroupdefinition-supportcontainerdefinition-linuxcapabilities
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LinuxCapabilities
            /// </summary>
            public Union<Humidifier.GameLift.ContainerGroupDefinitionTypes.LinuxCapabilities, BaseFunction>? LinuxCapabilities { get; set; }
            /// <summary>
            /// Vcpu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-supportcontainerdefinition.html#cfn-gamelift-containergroupdefinition-supportcontainerdefinition-vcpu
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Vcpu { get; set; }
            /// <summary>
            /// ImageUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-supportcontainerdefinition.html#cfn-gamelift-containergroupdefinition-supportcontainerdefinition-imageuri
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImageUri { get; set; }
            /// <summary>
            /// ResolvedImageDigest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-supportcontainerdefinition.html#cfn-gamelift-containergroupdefinition-supportcontainerdefinition-resolvedimagedigest
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResolvedImageDigest { get; set; }
            /// <summary>
            /// Essential
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-supportcontainerdefinition.html#cfn-gamelift-containergroupdefinition-supportcontainerdefinition-essential
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Essential { get; set; }
            /// <summary>
            /// PortConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-containergroupdefinition-supportcontainerdefinition.html#cfn-gamelift-containergroupdefinition-supportcontainerdefinition-portconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PortConfiguration
            /// </summary>
            public Union<Humidifier.GameLift.ContainerGroupDefinitionTypes.PortConfiguration, BaseFunction>? PortConfiguration { get; set; }
        }
    }
}