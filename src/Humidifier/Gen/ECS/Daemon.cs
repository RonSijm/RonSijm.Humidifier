namespace Humidifier.ECS
{
    using global::System.Collections.Generic;
    using DaemonTypes;

    public class Daemon : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHavePropagateTags, IHaveClusterArn, IHaveEnableECSManagedTags, IHaveEnableExecuteCommand, IHaveCritical
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
        public dynamic ClusterArn { get; set; }
        /// <summary>
        /// DaemonTaskDefinitionArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-daemon.html#cfn-ecs-daemon-daemontaskdefinitionarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DaemonTaskDefinitionArn { get; set; }
        public dynamic DaemonName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// EnableECSManagedTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-daemon.html#cfn-ecs-daemon-enableecsmanagedtags
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic EnableECSManagedTags { get; set; }
        /// <summary>
        /// CapacityProviderArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-daemon.html#cfn-ecs-daemon-capacityproviderarns
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic CapacityProviderArns { get; set; }
        /// <summary>
        /// EnableExecuteCommand
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-daemon.html#cfn-ecs-daemon-enableexecutecommand
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic EnableExecuteCommand { get; set; }
        /// <summary>
        /// PropagateTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-daemon.html#cfn-ecs-daemon-propagatetags
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PropagateTags { get; set; }
        /// <summary>
        /// Critical
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-daemon.html#cfn-ecs-daemon-critical
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic Critical { get; set; }
        /// <summary>
        /// DeploymentConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-daemon.html#cfn-ecs-daemon-deploymentconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DaemonDeploymentConfiguration
        /// </summary>
        public Humidifier.ECS.DaemonTypes.DaemonDeploymentConfiguration DeploymentConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-daemon.html#cfn-ecs-daemon-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace DaemonTypes
    {
        public class DaemonAlarmConfiguration : Humidifier.Base.BaseSubResource, IHaveEnable
        {
            /// <summary>
            /// AlarmNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemon-daemonalarmconfiguration.html#cfn-ecs-daemon-daemonalarmconfiguration-alarmnames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AlarmNames { get; set; }
            /// <summary>
            /// Enable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemon-daemonalarmconfiguration.html#cfn-ecs-daemon-daemonalarmconfiguration-enable
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enable { get; set; }
        }

        public class DaemonDeploymentConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DrainPercent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemon-daemondeploymentconfiguration.html#cfn-ecs-daemon-daemondeploymentconfiguration-drainpercent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic DrainPercent { get; set; }
            /// <summary>
            /// BakeTimeInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemon-daemondeploymentconfiguration.html#cfn-ecs-daemon-daemondeploymentconfiguration-baketimeinminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic BakeTimeInMinutes { get; set; }
            /// <summary>
            /// Alarms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemon-daemondeploymentconfiguration.html#cfn-ecs-daemon-daemondeploymentconfiguration-alarms
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DaemonAlarmConfiguration
            /// </summary>
            public Humidifier.ECS.DaemonTypes.DaemonAlarmConfiguration Alarms { get; set; }
        }
    }
}