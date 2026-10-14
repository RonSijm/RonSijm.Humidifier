namespace Humidifier.ECS
{
    using global::System.Collections.Generic;
    using DaemonDeploymentTypes;

    public class DaemonDeployment : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string ClusterArn =  "ClusterArn" ;
            public static string CircuitBreaker =  "CircuitBreaker" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string SourceDaemonRevisions =  "SourceDaemonRevisions" ;
            public static string DaemonDeploymentArn =  "DaemonDeploymentArn" ;
            public static string TargetDaemonRevision =  "TargetDaemonRevision" ;
            public static string ClusterName =  "ClusterName" ;
            public static string FinishedAt =  "FinishedAt" ;
            public static string Status =  "Status" ;
            public static string DaemonName =  "DaemonName" ;
            public static string Alarms =  "Alarms" ;
            public static string DaemonDeploymentId =  "DaemonDeploymentId" ;
            public static string StartedAt =  "StartedAt" ;
            public static string DeploymentConfiguration =  "DeploymentConfiguration" ;
        }

        public override string AWSTypeName { get => AWS.ECS.DaemonDeployment; }
    }

    namespace DaemonDeploymentTypes
    {
        public class DaemonAlarmConfiguration : Humidifier.Base.BaseSubResource, IHaveEnable
        {
            /// <summary>
            /// AlarmNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemondeployment-daemonalarmconfiguration.html#cfn-ecs-daemondeployment-daemonalarmconfiguration-alarmnames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AlarmNames { get; set; }
            /// <summary>
            /// Enable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemondeployment-daemonalarmconfiguration.html#cfn-ecs-daemondeployment-daemonalarmconfiguration-enable
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enable { get; set; }
        }

        public class DaemonCircuitBreaker : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveThreshold
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemondeployment-daemoncircuitbreaker.html#cfn-ecs-daemondeployment-daemoncircuitbreaker-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// FailureCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemondeployment-daemoncircuitbreaker.html#cfn-ecs-daemondeployment-daemoncircuitbreaker-failurecount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic FailureCount { get; set; }
            /// <summary>
            /// Threshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemondeployment-daemoncircuitbreaker.html#cfn-ecs-daemondeployment-daemoncircuitbreaker-threshold
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Threshold { get; set; }
        }

        public class DaemonDeploymentAlarms : Humidifier.Base.BaseSubResource, IHaveStatus
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemondeployment-daemondeploymentalarms.html#cfn-ecs-daemondeployment-daemondeploymentalarms-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// TriggeredAlarmNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemondeployment-daemondeploymentalarms.html#cfn-ecs-daemondeployment-daemondeploymentalarms-triggeredalarmnames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic TriggeredAlarmNames { get; set; }
            /// <summary>
            /// AlarmNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemondeployment-daemondeploymentalarms.html#cfn-ecs-daemondeployment-daemondeploymentalarms-alarmnames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AlarmNames { get; set; }
        }

        public class DaemonDeploymentCapacityProvider : Humidifier.Base.BaseSubResource, IHaveArn
        {
            /// <summary>
            /// DrainingInstanceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemondeployment-daemondeploymentcapacityprovider.html#cfn-ecs-daemondeployment-daemondeploymentcapacityprovider-draininginstancecount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DrainingInstanceCount { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemondeployment-daemondeploymentcapacityprovider.html#cfn-ecs-daemondeployment-daemondeploymentcapacityprovider-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
            /// <summary>
            /// RunningInstanceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemondeployment-daemondeploymentcapacityprovider.html#cfn-ecs-daemondeployment-daemondeploymentcapacityprovider-runninginstancecount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RunningInstanceCount { get; set; }
        }

        public class DaemonDeploymentConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DrainPercent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemondeployment-daemondeploymentconfiguration.html#cfn-ecs-daemondeployment-daemondeploymentconfiguration-drainpercent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic DrainPercent { get; set; }
            /// <summary>
            /// BakeTimeInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemondeployment-daemondeploymentconfiguration.html#cfn-ecs-daemondeployment-daemondeploymentconfiguration-baketimeinminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic BakeTimeInMinutes { get; set; }
            /// <summary>
            /// Alarms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemondeployment-daemondeploymentconfiguration.html#cfn-ecs-daemondeployment-daemondeploymentconfiguration-alarms
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DaemonAlarmConfiguration
            /// </summary>
            public Humidifier.ECS.DaemonDeploymentTypes.DaemonAlarmConfiguration Alarms { get; set; }
        }

        public class DaemonDeploymentRevisionDetail : Humidifier.Base.BaseSubResource, IHaveArn
        {
            /// <summary>
            /// CapacityProviders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemondeployment-daemondeploymentrevisiondetail.html#cfn-ecs-daemondeployment-daemondeploymentrevisiondetail-capacityproviders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DaemonDeploymentCapacityProvider
            /// </summary>
            public List<Humidifier.ECS.DaemonDeploymentTypes.DaemonDeploymentCapacityProvider> CapacityProviders { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemondeployment-daemondeploymentrevisiondetail.html#cfn-ecs-daemondeployment-daemondeploymentrevisiondetail-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
            /// <summary>
            /// TotalRunningInstanceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemondeployment-daemondeploymentrevisiondetail.html#cfn-ecs-daemondeployment-daemondeploymentrevisiondetail-totalrunninginstancecount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TotalRunningInstanceCount { get; set; }
            /// <summary>
            /// TotalDrainingInstanceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-daemondeployment-daemondeploymentrevisiondetail.html#cfn-ecs-daemondeployment-daemondeploymentrevisiondetail-totaldraininginstancecount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TotalDrainingInstanceCount { get; set; }
        }
    }
}