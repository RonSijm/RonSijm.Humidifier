namespace Humidifier.ECS
{
    using global::System.Collections.Generic;
    using DaemonTypes;

    public class Daemon : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveClusterArn, IHaveDaemonTaskDefinitionArn, IHaveDaemonName, IHaveEnableECSManagedTags_Boolean, IHaveStringListOfCapacityProviderArns, IHaveEnableExecuteCommand_Boolean, IHavePropagateTags, IHaveECSDaemonTypesDaemonDeploymentConfigurationDeploymentConfiguration
    {
        public class Attributes
        {
            public static string DaemonStatus =  "DaemonStatus" ;
            public static string DeploymentArn =  "DeploymentArn" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string DaemonArn =  "DaemonArn" ;
        }

        public override string AWSTypeName { get => AWS.ECS.Daemon; }
        /// <summary>
        /// ClusterArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-daemon.html#cfn-ecs-daemon-clusterarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ClusterArn { get; set; }
        /// <summary>
        /// DaemonTaskDefinitionArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-daemon.html#cfn-ecs-daemon-daemontaskdefinitionarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DaemonTaskDefinitionArn { get; set; }
        public Union<string, BaseFunction>? DaemonName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// EnableECSManagedTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-daemon.html#cfn-ecs-daemon-enableecsmanagedtags
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? EnableECSManagedTags { get; set; }
        /// <summary>
        /// CapacityProviderArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-daemon.html#cfn-ecs-daemon-capacityproviderarns
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CapacityProviderArns { get; set; }
        /// <summary>
        /// EnableExecuteCommand
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-daemon.html#cfn-ecs-daemon-enableexecutecommand
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? EnableExecuteCommand { get; set; }
        /// <summary>
        /// PropagateTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-daemon.html#cfn-ecs-daemon-propagatetags
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PropagateTags { get; set; }
        /// <summary>
        /// DeploymentConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-daemon.html#cfn-ecs-daemon-deploymentconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DaemonDeploymentConfiguration
        /// </summary>
        public Union<Humidifier.ECS.DaemonTypes.DaemonDeploymentConfiguration, BaseFunction>? DeploymentConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-daemon.html#cfn-ecs-daemon-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace DaemonTypes
    {
        public class DaemonAlarmConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfAlarmNames, IHaveEnable_Boolean
        {
            /// <summary>
            /// AlarmNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemon-daemonalarmconfiguration.html#cfn-ecs-daemon-daemonalarmconfiguration-alarmnames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AlarmNames { get; set; }
            /// <summary>
            /// Enable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemon-daemonalarmconfiguration.html#cfn-ecs-daemon-daemonalarmconfiguration-enable
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enable { get; set; }
        }

        public class DaemonDeploymentConfiguration : Humidifier.Base.BaseSubResource, IHaveDrainPercent_Double, IHaveBakeTimeInMinutes_Integer, IHaveECSDaemonTypesDaemonAlarmConfigurationAlarms
        {
            /// <summary>
            /// DrainPercent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemon-daemondeploymentconfiguration.html#cfn-ecs-daemon-daemondeploymentconfiguration-drainpercent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? DrainPercent { get; set; }
            /// <summary>
            /// BakeTimeInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemon-daemondeploymentconfiguration.html#cfn-ecs-daemon-daemondeploymentconfiguration-baketimeinminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? BakeTimeInMinutes { get; set; }
            /// <summary>
            /// Alarms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemon-daemondeploymentconfiguration.html#cfn-ecs-daemon-daemondeploymentconfiguration-alarms
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DaemonAlarmConfiguration
            /// </summary>
            public Union<Humidifier.ECS.DaemonTypes.DaemonAlarmConfiguration, BaseFunction>? Alarms { get; set; }
        }
    }
}