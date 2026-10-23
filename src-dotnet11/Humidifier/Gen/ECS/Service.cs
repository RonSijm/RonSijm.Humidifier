namespace Humidifier.ECS
{
    using global::System.Collections.Generic;
    using ServiceTypes;

    public class Service : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHavePlatformVersion, IHavePropagateTags, IHaveListOfECSServiceTypesPlacementStrategyPlacementStrategies, IHaveListOfECSServiceTypesServiceRegistryServiceRegistries, IHaveListOfECSServiceTypesServiceVolumeConfigurationVolumeConfigurations, IHaveListOfECSServiceTypesCapacityProviderStrategyItemCapacityProviderStrategy, IHaveLaunchType, IHaveAvailabilityZoneRebalancing, IHaveSchedulingStrategy, IHaveECSServiceTypesNetworkConfigurationNetworkConfiguration, IHaveECSServiceTypesMonitoringConfigurationMonitoring, IHaveECSServiceTypesForceNewDeploymentForceNewDeployment, IHaveHealthCheckGracePeriodSeconds_Integer, IHaveEnableECSManagedTags_Boolean, IHaveEnableExecuteCommand_Boolean, IHaveListOfECSServiceTypesPlacementConstraintPlacementConstraints, IHaveCluster, IHaveListOfECSServiceTypesLoadBalancerLoadBalancers, IHaveECSServiceTypesServiceConnectConfigurationServiceConnectConfiguration, IHaveDesiredCount_Integer, IHaveListOfECSServiceTypesVpcLatticeConfigurationVpcLatticeConfigurations, IHaveECSServiceTypesDeploymentControllerDeploymentController, IHaveRole, IHaveTaskDefinition, IHaveServiceName, IHaveECSServiceTypesDeploymentConfigurationDeploymentConfiguration, IHaveListOfECSServiceTypesGatewayConnectorGatewayConnectors
    {
        public class Attributes
        {
            public static string ServiceArn =  "ServiceArn" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.ECS.Service; }
        /// <summary>
        /// PlatformVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-platformversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PlatformVersion { get; set; }
        /// <summary>
        /// PropagateTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-propagatetags
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PropagateTags { get; set; }
        /// <summary>
        /// PlacementStrategies
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-placementstrategies
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: PlacementStrategy
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ECS.ServiceTypes.PlacementStrategy>, IReadOnlyList<Union<Humidifier.ECS.ServiceTypes.PlacementStrategy, BaseFunction>>, BaseFunction>? PlacementStrategies { get; set; }
        /// <summary>
        /// ServiceRegistries
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-serviceregistries
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ServiceRegistry
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ECS.ServiceTypes.ServiceRegistry>, IReadOnlyList<Union<Humidifier.ECS.ServiceTypes.ServiceRegistry, BaseFunction>>, BaseFunction>? ServiceRegistries { get; set; }
        /// <summary>
        /// VolumeConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-volumeconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ServiceVolumeConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ECS.ServiceTypes.ServiceVolumeConfiguration>, IReadOnlyList<Union<Humidifier.ECS.ServiceTypes.ServiceVolumeConfiguration, BaseFunction>>, BaseFunction>? VolumeConfigurations { get; set; }
        /// <summary>
        /// CapacityProviderStrategy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-capacityproviderstrategy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: CapacityProviderStrategyItem
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ECS.ServiceTypes.CapacityProviderStrategyItem>, IReadOnlyList<Union<Humidifier.ECS.ServiceTypes.CapacityProviderStrategyItem, BaseFunction>>, BaseFunction>? CapacityProviderStrategy { get; set; }
        /// <summary>
        /// LaunchType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-launchtype
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LaunchType { get; set; }
        /// <summary>
        /// AvailabilityZoneRebalancing
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-availabilityzonerebalancing
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AvailabilityZoneRebalancing { get; set; }
        /// <summary>
        /// SchedulingStrategy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-schedulingstrategy
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SchedulingStrategy { get; set; }
        /// <summary>
        /// NetworkConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-networkconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: NetworkConfiguration
        /// </summary>
        public Union<Humidifier.ECS.ServiceTypes.NetworkConfiguration, BaseFunction>? NetworkConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// Monitoring
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-monitoring
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MonitoringConfiguration
        /// </summary>
        public Union<Humidifier.ECS.ServiceTypes.MonitoringConfiguration, BaseFunction>? Monitoring { get; set; }
        /// <summary>
        /// ForceNewDeployment
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-forcenewdeployment
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ForceNewDeployment
        /// </summary>
        public Union<Humidifier.ECS.ServiceTypes.ForceNewDeployment, BaseFunction>? ForceNewDeployment { get; set; }
        /// <summary>
        /// HealthCheckGracePeriodSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-healthcheckgraceperiodseconds
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? HealthCheckGracePeriodSeconds { get; set; }
        /// <summary>
        /// EnableECSManagedTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-enableecsmanagedtags
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? EnableECSManagedTags { get; set; }
        /// <summary>
        /// EnableExecuteCommand
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-enableexecutecommand
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? EnableExecuteCommand { get; set; }
        /// <summary>
        /// PlacementConstraints
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-placementconstraints
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: PlacementConstraint
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ECS.ServiceTypes.PlacementConstraint>, IReadOnlyList<Union<Humidifier.ECS.ServiceTypes.PlacementConstraint, BaseFunction>>, BaseFunction>? PlacementConstraints { get; set; }
        /// <summary>
        /// Cluster
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-cluster
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Cluster { get; set; }
        /// <summary>
        /// LoadBalancers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-loadbalancers
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: LoadBalancer
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ECS.ServiceTypes.LoadBalancer>, IReadOnlyList<Union<Humidifier.ECS.ServiceTypes.LoadBalancer, BaseFunction>>, BaseFunction>? LoadBalancers { get; set; }
        /// <summary>
        /// ServiceConnectConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-serviceconnectconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ServiceConnectConfiguration
        /// </summary>
        public Union<Humidifier.ECS.ServiceTypes.ServiceConnectConfiguration, BaseFunction>? ServiceConnectConfiguration { get; set; }
        /// <summary>
        /// DesiredCount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-desiredcount
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? DesiredCount { get; set; }
        /// <summary>
        /// VpcLatticeConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-vpclatticeconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: VpcLatticeConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ECS.ServiceTypes.VpcLatticeConfiguration>, IReadOnlyList<Union<Humidifier.ECS.ServiceTypes.VpcLatticeConfiguration, BaseFunction>>, BaseFunction>? VpcLatticeConfigurations { get; set; }
        /// <summary>
        /// DeploymentController
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-deploymentcontroller
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DeploymentController
        /// </summary>
        public Union<Humidifier.ECS.ServiceTypes.DeploymentController, BaseFunction>? DeploymentController { get; set; }
        /// <summary>
        /// Role
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-role
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Role { get; set; }
        /// <summary>
        /// TaskDefinition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-taskdefinition
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TaskDefinition { get; set; }
        public Union<string, BaseFunction>? ServiceName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// DeploymentConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-deploymentconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DeploymentConfiguration
        /// </summary>
        public Union<Humidifier.ECS.ServiceTypes.DeploymentConfiguration, BaseFunction>? DeploymentConfiguration { get; set; }
        /// <summary>
        /// GatewayConnectors
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-service.html#cfn-ecs-service-gatewayconnectors
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: GatewayConnector
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ECS.ServiceTypes.GatewayConnector>, IReadOnlyList<Union<Humidifier.ECS.ServiceTypes.GatewayConnector, BaseFunction>>, BaseFunction>? GatewayConnectors { get; set; }
    }

    namespace ServiceTypes
    {
        public class AdvancedConfiguration : Humidifier.Base.BaseSubResource, IHaveTestListenerRule, IHaveAlternateTargetGroupArn, IHaveProductionListenerRule, IHaveRoleArn
        {
            /// <summary>
            /// TestListenerRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-advancedconfiguration.html#cfn-ecs-service-advancedconfiguration-testlistenerrule
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TestListenerRule { get; set; }
            /// <summary>
            /// AlternateTargetGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-advancedconfiguration.html#cfn-ecs-service-advancedconfiguration-alternatetargetgrouparn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AlternateTargetGroupArn { get; set; }
            /// <summary>
            /// ProductionListenerRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-advancedconfiguration.html#cfn-ecs-service-advancedconfiguration-productionlistenerrule
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProductionListenerRule { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-advancedconfiguration.html#cfn-ecs-service-advancedconfiguration-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class AwsVpcConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfSecurityGroups, IHaveStringListOfSubnets, IHaveAssignPublicIp
        {
            /// <summary>
            /// SecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-awsvpcconfiguration.html#cfn-ecs-service-awsvpcconfiguration-securitygroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroups { get; set; }
            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-awsvpcconfiguration.html#cfn-ecs-service-awsvpcconfiguration-subnets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Subnets { get; set; }
            /// <summary>
            /// AssignPublicIp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-awsvpcconfiguration.html#cfn-ecs-service-awsvpcconfiguration-assignpublicip
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AssignPublicIp { get; set; }
        }

        public class CanaryConfiguration : Humidifier.Base.BaseSubResource, IHaveCanaryPercent_Double, IHaveCanaryBakeTimeInMinutes_Integer
        {
            /// <summary>
            /// CanaryPercent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-canaryconfiguration.html#cfn-ecs-service-canaryconfiguration-canarypercent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? CanaryPercent { get; set; }
            /// <summary>
            /// CanaryBakeTimeInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-canaryconfiguration.html#cfn-ecs-service-canaryconfiguration-canarybaketimeinminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? CanaryBakeTimeInMinutes { get; set; }
        }

        public class CapacityProviderStrategyItem : Humidifier.Base.BaseSubResource, IHaveCapacityProvider, IHaveBase_Integer, IHaveWeight_Integer
        {
            /// <summary>
            /// CapacityProvider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-capacityproviderstrategyitem.html#cfn-ecs-service-capacityproviderstrategyitem-capacityprovider
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CapacityProvider { get; set; }
            /// <summary>
            /// Base
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-capacityproviderstrategyitem.html#cfn-ecs-service-capacityproviderstrategyitem-base
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Base { get; set; }
            /// <summary>
            /// Weight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-capacityproviderstrategyitem.html#cfn-ecs-service-capacityproviderstrategyitem-weight
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Weight { get; set; }
        }

        public class DeploymentAlarms : Humidifier.Base.BaseSubResource, IHaveStringListOfAlarmNames, IHaveEnable_Boolean, IHaveRollback_Boolean
        {
            /// <summary>
            /// AlarmNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-deploymentalarms.html#cfn-ecs-service-deploymentalarms-alarmnames
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AlarmNames { get; set; }
            /// <summary>
            /// Enable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-deploymentalarms.html#cfn-ecs-service-deploymentalarms-enable
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enable { get; set; }
            /// <summary>
            /// Rollback
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-deploymentalarms.html#cfn-ecs-service-deploymentalarms-rollback
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Rollback { get; set; }
        }

        public class DeploymentCircuitBreaker : Humidifier.Base.BaseSubResource, IHaveECSServiceTypesThresholdConfigurationThresholdConfiguration, IHaveEnable_Boolean, IHaveResetOnHealthyTask_Boolean, IHaveRollback_Boolean
        {
            /// <summary>
            /// ThresholdConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-deploymentcircuitbreaker.html#cfn-ecs-service-deploymentcircuitbreaker-thresholdconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ThresholdConfiguration
            /// </summary>
            public Union<Humidifier.ECS.ServiceTypes.ThresholdConfiguration, BaseFunction>? ThresholdConfiguration { get; set; }
            /// <summary>
            /// Enable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-deploymentcircuitbreaker.html#cfn-ecs-service-deploymentcircuitbreaker-enable
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enable { get; set; }
            /// <summary>
            /// ResetOnHealthyTask
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-deploymentcircuitbreaker.html#cfn-ecs-service-deploymentcircuitbreaker-resetonhealthytask
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ResetOnHealthyTask { get; set; }
            /// <summary>
            /// Rollback
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-deploymentcircuitbreaker.html#cfn-ecs-service-deploymentcircuitbreaker-rollback
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Rollback { get; set; }
        }

        public class DeploymentConfiguration : Humidifier.Base.BaseSubResource, IHaveECSServiceTypesCanaryConfigurationCanaryConfiguration, IHaveBakeTimeInMinutes_Integer, IHaveListOfECSServiceTypesDeploymentLifecycleHookLifecycleHooks, IHaveECSServiceTypesDeploymentEarlySuccessCriteriaEarlySuccessCriteria, IHaveECSServiceTypesDeploymentAlarmsAlarms, IHaveStrategy, IHaveECSServiceTypesDeploymentCircuitBreakerDeploymentCircuitBreaker, IHaveMaximumPercent_Integer, IHaveMinimumHealthyPercent_Integer, IHaveECSServiceTypesLinearConfigurationLinearConfiguration
        {
            /// <summary>
            /// CanaryConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-deploymentconfiguration.html#cfn-ecs-service-deploymentconfiguration-canaryconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CanaryConfiguration
            /// </summary>
            public Union<Humidifier.ECS.ServiceTypes.CanaryConfiguration, BaseFunction>? CanaryConfiguration { get; set; }
            /// <summary>
            /// BakeTimeInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-deploymentconfiguration.html#cfn-ecs-service-deploymentconfiguration-baketimeinminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? BakeTimeInMinutes { get; set; }
            /// <summary>
            /// LifecycleHooks
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-deploymentconfiguration.html#cfn-ecs-service-deploymentconfiguration-lifecyclehooks
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DeploymentLifecycleHook
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECS.ServiceTypes.DeploymentLifecycleHook>, IReadOnlyList<Union<Humidifier.ECS.ServiceTypes.DeploymentLifecycleHook, BaseFunction>>, BaseFunction>? LifecycleHooks { get; set; }
            /// <summary>
            /// EarlySuccessCriteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-deploymentconfiguration.html#cfn-ecs-service-deploymentconfiguration-earlysuccesscriteria
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DeploymentEarlySuccessCriteria
            /// </summary>
            public Union<Humidifier.ECS.ServiceTypes.DeploymentEarlySuccessCriteria, BaseFunction>? EarlySuccessCriteria { get; set; }
            /// <summary>
            /// Alarms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-deploymentconfiguration.html#cfn-ecs-service-deploymentconfiguration-alarms
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DeploymentAlarms
            /// </summary>
            public Union<Humidifier.ECS.ServiceTypes.DeploymentAlarms, BaseFunction>? Alarms { get; set; }
            /// <summary>
            /// Strategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-deploymentconfiguration.html#cfn-ecs-service-deploymentconfiguration-strategy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Strategy { get; set; }
            /// <summary>
            /// DeploymentCircuitBreaker
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-deploymentconfiguration.html#cfn-ecs-service-deploymentconfiguration-deploymentcircuitbreaker
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DeploymentCircuitBreaker
            /// </summary>
            public Union<Humidifier.ECS.ServiceTypes.DeploymentCircuitBreaker, BaseFunction>? DeploymentCircuitBreaker { get; set; }
            /// <summary>
            /// MaximumPercent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-deploymentconfiguration.html#cfn-ecs-service-deploymentconfiguration-maximumpercent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaximumPercent { get; set; }
            /// <summary>
            /// MinimumHealthyPercent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-deploymentconfiguration.html#cfn-ecs-service-deploymentconfiguration-minimumhealthypercent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinimumHealthyPercent { get; set; }
            /// <summary>
            /// LinearConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-deploymentconfiguration.html#cfn-ecs-service-deploymentconfiguration-linearconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LinearConfiguration
            /// </summary>
            public Union<Humidifier.ECS.ServiceTypes.LinearConfiguration, BaseFunction>? LinearConfiguration { get; set; }
        }

        public class DeploymentController : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-deploymentcontroller.html#cfn-ecs-service-deploymentcontroller-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
        }

        public class DeploymentEarlySuccessCriteria : Humidifier.Base.BaseSubResource, IHaveSourceServiceRevisionCleanup, IHaveHealthyPercent_Integer, IHaveEnable_Boolean
        {
            /// <summary>
            /// SourceServiceRevisionCleanup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-deploymentearlysuccesscriteria.html#cfn-ecs-service-deploymentearlysuccesscriteria-sourceservicerevisioncleanup
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceServiceRevisionCleanup { get; set; }
            /// <summary>
            /// HealthyPercent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-deploymentearlysuccesscriteria.html#cfn-ecs-service-deploymentearlysuccesscriteria-healthypercent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? HealthyPercent { get; set; }
            /// <summary>
            /// Enable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-deploymentearlysuccesscriteria.html#cfn-ecs-service-deploymentearlysuccesscriteria-enable
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enable { get; set; }
        }

        public class DeploymentLifecycleHook : Humidifier.Base.BaseSubResource, IHaveECSServiceTypesHookTimeoutConfigTimeoutConfiguration, IHaveStringListOfLifecycleStages, IHaveTargetType, IHaveHookTargetArn, IHaveHookDetails_Json, IHaveRoleArn
        {
            /// <summary>
            /// TimeoutConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-deploymentlifecyclehook.html#cfn-ecs-service-deploymentlifecyclehook-timeoutconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HookTimeoutConfig
            /// </summary>
            public Union<Humidifier.ECS.ServiceTypes.HookTimeoutConfig, BaseFunction>? TimeoutConfiguration { get; set; }
            /// <summary>
            /// LifecycleStages
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-deploymentlifecyclehook.html#cfn-ecs-service-deploymentlifecyclehook-lifecyclestages
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LifecycleStages { get; set; }
            /// <summary>
            /// TargetType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-deploymentlifecyclehook.html#cfn-ecs-service-deploymentlifecyclehook-targettype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetType { get; set; }
            /// <summary>
            /// HookTargetArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-deploymentlifecyclehook.html#cfn-ecs-service-deploymentlifecyclehook-hooktargetarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HookTargetArn { get; set; }
            /// <summary>
            /// HookDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-deploymentlifecyclehook.html#cfn-ecs-service-deploymentlifecyclehook-hookdetails
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? HookDetails { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-deploymentlifecyclehook.html#cfn-ecs-service-deploymentlifecyclehook-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class EBSTagSpecification : Humidifier.Base.BaseSubResource, IHaveTags, IHavePropagateTags, IHaveResourceType
        {
            /// <summary>
            /// PropagateTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-ebstagspecification.html#cfn-ecs-service-ebstagspecification-propagatetags
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PropagateTags { get; set; }
            /// <summary>
            /// ResourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-ebstagspecification.html#cfn-ecs-service-ebstagspecification-resourcetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceType { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-ebstagspecification.html#cfn-ecs-service-ebstagspecification-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        }

        public class ForceNewDeployment : Humidifier.Base.BaseSubResource, IHaveEnableForceNewDeployment_Boolean, IHaveForceNewDeploymentNonce
        {
            /// <summary>
            /// EnableForceNewDeployment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-forcenewdeployment.html#cfn-ecs-service-forcenewdeployment-enableforcenewdeployment
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableForceNewDeployment { get; set; }
            /// <summary>
            /// ForceNewDeploymentNonce
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-forcenewdeployment.html#cfn-ecs-service-forcenewdeployment-forcenewdeploymentnonce
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ForceNewDeploymentNonce { get; set; }
        }

        public class GatewayConnector : Humidifier.Base.BaseSubResource, IHaveECSServiceTypesGatewayConnectorFiltersFilters, IHaveECSServiceTypesGatewayConnectorHealthCheckHealthCheck, IHavePortName
        {
            /// <summary>
            /// Filters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-gatewayconnector.html#cfn-ecs-service-gatewayconnector-filters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GatewayConnectorFilters
            /// </summary>
            public Union<Humidifier.ECS.ServiceTypes.GatewayConnectorFilters, BaseFunction>? Filters { get; set; }
            /// <summary>
            /// HealthCheck
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-gatewayconnector.html#cfn-ecs-service-gatewayconnector-healthcheck
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GatewayConnectorHealthCheck
            /// </summary>
            public Union<Humidifier.ECS.ServiceTypes.GatewayConnectorHealthCheck, BaseFunction>? HealthCheck { get; set; }
            /// <summary>
            /// PortName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-gatewayconnector.html#cfn-ecs-service-gatewayconnector-portname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PortName { get; set; }
        }

        public class GatewayConnectorFilters : Humidifier.Base.BaseSubResource, IHaveStringListOfAccessTypes
        {
            /// <summary>
            /// AccessTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-gatewayconnectorfilters.html#cfn-ecs-service-gatewayconnectorfilters-accesstypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AccessTypes { get; set; }
        }

        public class GatewayConnectorHealthCheck : Humidifier.Base.BaseSubResource, IHaveHealthCheckIntervalSeconds_Integer, IHaveECSServiceTypesGatewayConnectorHealthCheckMatcherMatcher, IHaveHealthyThresholdCount_Integer, IHaveHealthCheckPath, IHaveHealthCheckProtocol, IHaveHealthCheckPort_Integer, IHaveUnhealthyThresholdCount_Integer, IHaveHealthCheckTimeoutSeconds_Integer
        {
            /// <summary>
            /// HealthCheckIntervalSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-gatewayconnectorhealthcheck.html#cfn-ecs-service-gatewayconnectorhealthcheck-healthcheckintervalseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? HealthCheckIntervalSeconds { get; set; }
            /// <summary>
            /// Matcher
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-gatewayconnectorhealthcheck.html#cfn-ecs-service-gatewayconnectorhealthcheck-matcher
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GatewayConnectorHealthCheckMatcher
            /// </summary>
            public Union<Humidifier.ECS.ServiceTypes.GatewayConnectorHealthCheckMatcher, BaseFunction>? Matcher { get; set; }
            /// <summary>
            /// HealthyThresholdCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-gatewayconnectorhealthcheck.html#cfn-ecs-service-gatewayconnectorhealthcheck-healthythresholdcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? HealthyThresholdCount { get; set; }
            /// <summary>
            /// HealthCheckPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-gatewayconnectorhealthcheck.html#cfn-ecs-service-gatewayconnectorhealthcheck-healthcheckpath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HealthCheckPath { get; set; }
            /// <summary>
            /// HealthCheckProtocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-gatewayconnectorhealthcheck.html#cfn-ecs-service-gatewayconnectorhealthcheck-healthcheckprotocol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HealthCheckProtocol { get; set; }
            /// <summary>
            /// HealthCheckPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-gatewayconnectorhealthcheck.html#cfn-ecs-service-gatewayconnectorhealthcheck-healthcheckport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? HealthCheckPort { get; set; }
            /// <summary>
            /// UnhealthyThresholdCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-gatewayconnectorhealthcheck.html#cfn-ecs-service-gatewayconnectorhealthcheck-unhealthythresholdcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? UnhealthyThresholdCount { get; set; }
            /// <summary>
            /// HealthCheckTimeoutSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-gatewayconnectorhealthcheck.html#cfn-ecs-service-gatewayconnectorhealthcheck-healthchecktimeoutseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? HealthCheckTimeoutSeconds { get; set; }
        }

        public class GatewayConnectorHealthCheckMatcher : Humidifier.Base.BaseSubResource, IHaveGrpcCode, IHaveHttpCode
        {
            /// <summary>
            /// GrpcCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-gatewayconnectorhealthcheckmatcher.html#cfn-ecs-service-gatewayconnectorhealthcheckmatcher-grpccode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GrpcCode { get; set; }
            /// <summary>
            /// HttpCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-gatewayconnectorhealthcheckmatcher.html#cfn-ecs-service-gatewayconnectorhealthcheckmatcher-httpcode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HttpCode { get; set; }
        }

        public class HookTimeoutConfig : Humidifier.Base.BaseSubResource, IHaveAction, IHaveTimeoutInMinutes_Integer
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-hooktimeoutconfig.html#cfn-ecs-service-hooktimeoutconfig-action
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Action { get; set; }
            /// <summary>
            /// TimeoutInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-hooktimeoutconfig.html#cfn-ecs-service-hooktimeoutconfig-timeoutinminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimeoutInMinutes { get; set; }
        }

        public class LinearConfiguration : Humidifier.Base.BaseSubResource, IHaveStepBakeTimeInMinutes_Integer, IHaveStepPercent_Double
        {
            /// <summary>
            /// StepBakeTimeInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-linearconfiguration.html#cfn-ecs-service-linearconfiguration-stepbaketimeinminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? StepBakeTimeInMinutes { get; set; }
            /// <summary>
            /// StepPercent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-linearconfiguration.html#cfn-ecs-service-linearconfiguration-steppercent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? StepPercent { get; set; }
        }

        public class LoadBalancer : Humidifier.Base.BaseSubResource, IHaveTargetGroupArn, IHaveLoadBalancerName, IHaveContainerName, IHaveContainerPort_Integer, IHaveECSServiceTypesAdvancedConfigurationAdvancedConfiguration
        {
            /// <summary>
            /// TargetGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-loadbalancer.html#cfn-ecs-service-loadbalancer-targetgrouparn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetGroupArn { get; set; }
            /// <summary>
            /// LoadBalancerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-loadbalancer.html#cfn-ecs-service-loadbalancer-loadbalancername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LoadBalancerName { get; set; }
            /// <summary>
            /// ContainerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-loadbalancer.html#cfn-ecs-service-loadbalancer-containername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContainerName { get; set; }
            /// <summary>
            /// ContainerPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-loadbalancer.html#cfn-ecs-service-loadbalancer-containerport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ContainerPort { get; set; }
            /// <summary>
            /// AdvancedConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-loadbalancer.html#cfn-ecs-service-loadbalancer-advancedconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AdvancedConfiguration
            /// </summary>
            public Union<Humidifier.ECS.ServiceTypes.AdvancedConfiguration, BaseFunction>? AdvancedConfiguration { get; set; }
        }

        public class LogConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfECSServiceTypesSecretSecretOptions, IHaveStringDictionaryOfOptions, IHaveLogDriver
        {
            /// <summary>
            /// SecretOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-logconfiguration.html#cfn-ecs-service-logconfiguration-secretoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Secret
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECS.ServiceTypes.Secret>, IReadOnlyList<Union<Humidifier.ECS.ServiceTypes.Secret, BaseFunction>>, BaseFunction>? SecretOptions { get; set; }
            /// <summary>
            /// Options
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-logconfiguration.html#cfn-ecs-service-logconfiguration-options
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Options { get; set; }
            /// <summary>
            /// LogDriver
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-logconfiguration.html#cfn-ecs-service-logconfiguration-logdriver
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogDriver { get; set; }
        }

        public class MetricConfiguration : Humidifier.Base.BaseSubResource, IHaveResolutionSeconds_Integer, IHaveStringListOfMetricNames
        {
            /// <summary>
            /// ResolutionSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-metricconfiguration.html#cfn-ecs-service-metricconfiguration-resolutionseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ResolutionSeconds { get; set; }
            /// <summary>
            /// MetricNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-metricconfiguration.html#cfn-ecs-service-metricconfiguration-metricnames
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? MetricNames { get; set; }
        }

        public class MonitoringConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfECSServiceTypesMetricConfigurationMetricConfigurations
        {
            /// <summary>
            /// MetricConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-monitoringconfiguration.html#cfn-ecs-service-monitoringconfiguration-metricconfigurations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MetricConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECS.ServiceTypes.MetricConfiguration>, IReadOnlyList<Union<Humidifier.ECS.ServiceTypes.MetricConfiguration, BaseFunction>>, BaseFunction>? MetricConfigurations { get; set; }
        }

        public class NetworkConfiguration : Humidifier.Base.BaseSubResource, IHaveECSServiceTypesAwsVpcConfigurationAwsvpcConfiguration
        {
            /// <summary>
            /// AwsvpcConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-networkconfiguration.html#cfn-ecs-service-networkconfiguration-awsvpcconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AwsVpcConfiguration
            /// </summary>
            public Union<Humidifier.ECS.ServiceTypes.AwsVpcConfiguration, BaseFunction>? AwsvpcConfiguration { get; set; }
        }

        public class PlacementConstraint : Humidifier.Base.BaseSubResource, IHaveType, IHaveExpression
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-placementconstraint.html#cfn-ecs-service-placementconstraint-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-placementconstraint.html#cfn-ecs-service-placementconstraint-expression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Expression { get; set; }
        }

        public class PlacementStrategy : Humidifier.Base.BaseSubResource, IHaveField, IHaveType
        {
            /// <summary>
            /// Field
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-placementstrategy.html#cfn-ecs-service-placementstrategy-field
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Field { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-placementstrategy.html#cfn-ecs-service-placementstrategy-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
        }

        public class Secret : Humidifier.Base.BaseSubResource, IHaveValueFrom, IHaveName
        {
            /// <summary>
            /// ValueFrom
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-secret.html#cfn-ecs-service-secret-valuefrom
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ValueFrom { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-secret.html#cfn-ecs-service-secret-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class ServiceConnectAccessLogConfiguration : Humidifier.Base.BaseSubResource, IHaveFormat, IHaveIncludeQueryParameters
        {
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-serviceconnectaccesslogconfiguration.html#cfn-ecs-service-serviceconnectaccesslogconfiguration-format
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Format { get; set; }
            /// <summary>
            /// IncludeQueryParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-serviceconnectaccesslogconfiguration.html#cfn-ecs-service-serviceconnectaccesslogconfiguration-includequeryparameters
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IncludeQueryParameters { get; set; }
        }

        public class ServiceConnectClientAlias : Humidifier.Base.BaseSubResource, IHaveDnsName, IHaveECSServiceTypesServiceConnectTestTrafficRulesTestTrafficRules, IHavePort_Integer
        {
            /// <summary>
            /// DnsName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-serviceconnectclientalias.html#cfn-ecs-service-serviceconnectclientalias-dnsname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DnsName { get; set; }
            /// <summary>
            /// TestTrafficRules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-serviceconnectclientalias.html#cfn-ecs-service-serviceconnectclientalias-testtrafficrules
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ServiceConnectTestTrafficRules
            /// </summary>
            public Union<Humidifier.ECS.ServiceTypes.ServiceConnectTestTrafficRules, BaseFunction>? TestTrafficRules { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-serviceconnectclientalias.html#cfn-ecs-service-serviceconnectclientalias-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Port { get; set; }
        }

        public class ServiceConnectConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfECSServiceTypesServiceConnectServiceServices, IHaveListOfECSServiceTypesServiceConnectContainerConfigurationContainerConfigurations, IHaveECSServiceTypesServiceConnectAccessLogConfigurationAccessLogConfiguration, IHaveEnabled_Boolean, IHaveECSServiceTypesLogConfigurationLogConfiguration, IHaveNamespace_
        {
            /// <summary>
            /// Services
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-serviceconnectconfiguration.html#cfn-ecs-service-serviceconnectconfiguration-services
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ServiceConnectService
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECS.ServiceTypes.ServiceConnectService>, IReadOnlyList<Union<Humidifier.ECS.ServiceTypes.ServiceConnectService, BaseFunction>>, BaseFunction>? Services { get; set; }
            /// <summary>
            /// ContainerConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-serviceconnectconfiguration.html#cfn-ecs-service-serviceconnectconfiguration-containerconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ServiceConnectContainerConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECS.ServiceTypes.ServiceConnectContainerConfiguration>, IReadOnlyList<Union<Humidifier.ECS.ServiceTypes.ServiceConnectContainerConfiguration, BaseFunction>>, BaseFunction>? ContainerConfigurations { get; set; }
            /// <summary>
            /// AccessLogConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-serviceconnectconfiguration.html#cfn-ecs-service-serviceconnectconfiguration-accesslogconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ServiceConnectAccessLogConfiguration
            /// </summary>
            public Union<Humidifier.ECS.ServiceTypes.ServiceConnectAccessLogConfiguration, BaseFunction>? AccessLogConfiguration { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-serviceconnectconfiguration.html#cfn-ecs-service-serviceconnectconfiguration-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// LogConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-serviceconnectconfiguration.html#cfn-ecs-service-serviceconnectconfiguration-logconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LogConfiguration
            /// </summary>
            public Union<Humidifier.ECS.ServiceTypes.LogConfiguration, BaseFunction>? LogConfiguration { get; set; }
            /// <summary>
            /// Namespace_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-serviceconnectconfiguration.html#cfn-ecs-service-serviceconnectconfiguration-namespace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Namespace_ { get; set; }
        }

        public class ServiceConnectContainerConfiguration : Humidifier.Base.BaseSubResource, IHaveLogLevel
        {
            /// <summary>
            /// LogLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-serviceconnectcontainerconfiguration.html#cfn-ecs-service-serviceconnectcontainerconfiguration-loglevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogLevel { get; set; }
        }

        public class ServiceConnectService : Humidifier.Base.BaseSubResource, IHaveECSServiceTypesTimeoutConfigurationTimeout, IHaveIngressPortOverride_Integer, IHaveListOfECSServiceTypesServiceConnectClientAliasClientAliases, IHaveECSServiceTypesServiceConnectTlsConfigurationTls, IHaveDiscoveryName, IHavePortName
        {
            /// <summary>
            /// Timeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-serviceconnectservice.html#cfn-ecs-service-serviceconnectservice-timeout
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimeoutConfiguration
            /// </summary>
            public Union<Humidifier.ECS.ServiceTypes.TimeoutConfiguration, BaseFunction>? Timeout { get; set; }
            /// <summary>
            /// IngressPortOverride
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-serviceconnectservice.html#cfn-ecs-service-serviceconnectservice-ingressportoverride
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? IngressPortOverride { get; set; }
            /// <summary>
            /// ClientAliases
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-serviceconnectservice.html#cfn-ecs-service-serviceconnectservice-clientaliases
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ServiceConnectClientAlias
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECS.ServiceTypes.ServiceConnectClientAlias>, IReadOnlyList<Union<Humidifier.ECS.ServiceTypes.ServiceConnectClientAlias, BaseFunction>>, BaseFunction>? ClientAliases { get; set; }
            /// <summary>
            /// Tls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-serviceconnectservice.html#cfn-ecs-service-serviceconnectservice-tls
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ServiceConnectTlsConfiguration
            /// </summary>
            public Union<Humidifier.ECS.ServiceTypes.ServiceConnectTlsConfiguration, BaseFunction>? Tls { get; set; }
            /// <summary>
            /// DiscoveryName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-serviceconnectservice.html#cfn-ecs-service-serviceconnectservice-discoveryname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DiscoveryName { get; set; }
            /// <summary>
            /// PortName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-serviceconnectservice.html#cfn-ecs-service-serviceconnectservice-portname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PortName { get; set; }
        }

        public class ServiceConnectTestTrafficRules : Humidifier.Base.BaseSubResource, IHaveECSServiceTypesServiceConnectTestTrafficRulesHeaderHeader
        {
            /// <summary>
            /// Header
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-serviceconnecttesttrafficrules.html#cfn-ecs-service-serviceconnecttesttrafficrules-header
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ServiceConnectTestTrafficRulesHeader
            /// </summary>
            public Union<Humidifier.ECS.ServiceTypes.ServiceConnectTestTrafficRulesHeader, BaseFunction>? Header { get; set; }
        }

        public class ServiceConnectTestTrafficRulesHeader : Humidifier.Base.BaseSubResource, IHaveECSServiceTypesServiceConnectTestTrafficRulesHeaderValueValue, IHaveName
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-serviceconnecttesttrafficrulesheader.html#cfn-ecs-service-serviceconnecttesttrafficrulesheader-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ServiceConnectTestTrafficRulesHeaderValue
            /// </summary>
            public Union<Humidifier.ECS.ServiceTypes.ServiceConnectTestTrafficRulesHeaderValue, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-serviceconnecttesttrafficrulesheader.html#cfn-ecs-service-serviceconnecttesttrafficrulesheader-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class ServiceConnectTestTrafficRulesHeaderValue : Humidifier.Base.BaseSubResource, IHaveExact
        {
            /// <summary>
            /// Exact
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-serviceconnecttesttrafficrulesheadervalue.html#cfn-ecs-service-serviceconnecttesttrafficrulesheadervalue-exact
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Exact { get; set; }
        }

        public class ServiceConnectTlsCertificateAuthority : Humidifier.Base.BaseSubResource, IHaveAwsPcaAuthorityArn
        {
            /// <summary>
            /// AwsPcaAuthorityArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-serviceconnecttlscertificateauthority.html#cfn-ecs-service-serviceconnecttlscertificateauthority-awspcaauthorityarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AwsPcaAuthorityArn { get; set; }
        }

        public class ServiceConnectTlsConfiguration : Humidifier.Base.BaseSubResource, IHaveECSServiceTypesServiceConnectTlsCertificateAuthorityIssuerCertificateAuthority, IHaveKmsKey, IHaveRoleArn
        {
            /// <summary>
            /// IssuerCertificateAuthority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-serviceconnecttlsconfiguration.html#cfn-ecs-service-serviceconnecttlsconfiguration-issuercertificateauthority
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ServiceConnectTlsCertificateAuthority
            /// </summary>
            public Union<Humidifier.ECS.ServiceTypes.ServiceConnectTlsCertificateAuthority, BaseFunction>? IssuerCertificateAuthority { get; set; }
            /// <summary>
            /// KmsKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-serviceconnecttlsconfiguration.html#cfn-ecs-service-serviceconnecttlsconfiguration-kmskey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKey { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-serviceconnecttlsconfiguration.html#cfn-ecs-service-serviceconnecttlsconfiguration-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class ServiceManagedEBSVolumeConfiguration : Humidifier.Base.BaseSubResource, IHaveSnapshotId, IHaveVolumeType, IHaveKmsKeyId, IHaveListOfECSServiceTypesEBSTagSpecificationTagSpecifications, IHaveFilesystemType, IHaveEncrypted_Boolean, IHaveThroughput_Integer, IHaveVolumeInitializationRate_Integer, IHaveIops_Integer, IHaveSizeInGiB_Integer, IHaveRoleArn
        {
            /// <summary>
            /// SnapshotId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-servicemanagedebsvolumeconfiguration.html#cfn-ecs-service-servicemanagedebsvolumeconfiguration-snapshotid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SnapshotId { get; set; }
            /// <summary>
            /// VolumeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-servicemanagedebsvolumeconfiguration.html#cfn-ecs-service-servicemanagedebsvolumeconfiguration-volumetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VolumeType { get; set; }
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-servicemanagedebsvolumeconfiguration.html#cfn-ecs-service-servicemanagedebsvolumeconfiguration-kmskeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
            /// <summary>
            /// TagSpecifications
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-servicemanagedebsvolumeconfiguration.html#cfn-ecs-service-servicemanagedebsvolumeconfiguration-tagspecifications
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EBSTagSpecification
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECS.ServiceTypes.EBSTagSpecification>, IReadOnlyList<Union<Humidifier.ECS.ServiceTypes.EBSTagSpecification, BaseFunction>>, BaseFunction>? TagSpecifications { get; set; }
            /// <summary>
            /// FilesystemType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-servicemanagedebsvolumeconfiguration.html#cfn-ecs-service-servicemanagedebsvolumeconfiguration-filesystemtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FilesystemType { get; set; }
            /// <summary>
            /// Encrypted
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-servicemanagedebsvolumeconfiguration.html#cfn-ecs-service-servicemanagedebsvolumeconfiguration-encrypted
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Encrypted { get; set; }
            /// <summary>
            /// Throughput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-servicemanagedebsvolumeconfiguration.html#cfn-ecs-service-servicemanagedebsvolumeconfiguration-throughput
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Throughput { get; set; }
            /// <summary>
            /// VolumeInitializationRate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-servicemanagedebsvolumeconfiguration.html#cfn-ecs-service-servicemanagedebsvolumeconfiguration-volumeinitializationrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? VolumeInitializationRate { get; set; }
            /// <summary>
            /// Iops
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-servicemanagedebsvolumeconfiguration.html#cfn-ecs-service-servicemanagedebsvolumeconfiguration-iops
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Iops { get; set; }
            /// <summary>
            /// SizeInGiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-servicemanagedebsvolumeconfiguration.html#cfn-ecs-service-servicemanagedebsvolumeconfiguration-sizeingib
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SizeInGiB { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-servicemanagedebsvolumeconfiguration.html#cfn-ecs-service-servicemanagedebsvolumeconfiguration-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class ServiceRegistry : Humidifier.Base.BaseSubResource, IHaveContainerName, IHavePort_Integer, IHaveContainerPort_Integer, IHaveRegistryArn
        {
            /// <summary>
            /// ContainerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-serviceregistry.html#cfn-ecs-service-serviceregistry-containername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContainerName { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-serviceregistry.html#cfn-ecs-service-serviceregistry-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Port { get; set; }
            /// <summary>
            /// ContainerPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-serviceregistry.html#cfn-ecs-service-serviceregistry-containerport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ContainerPort { get; set; }
            /// <summary>
            /// RegistryArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-serviceregistry.html#cfn-ecs-service-serviceregistry-registryarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RegistryArn { get; set; }
        }

        public class ServiceVolumeConfiguration : Humidifier.Base.BaseSubResource, IHaveECSServiceTypesServiceManagedEBSVolumeConfigurationManagedEBSVolume, IHaveName
        {
            /// <summary>
            /// ManagedEBSVolume
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-servicevolumeconfiguration.html#cfn-ecs-service-servicevolumeconfiguration-managedebsvolume
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ServiceManagedEBSVolumeConfiguration
            /// </summary>
            public Union<Humidifier.ECS.ServiceTypes.ServiceManagedEBSVolumeConfiguration, BaseFunction>? ManagedEBSVolume { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-servicevolumeconfiguration.html#cfn-ecs-service-servicevolumeconfiguration-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class ThresholdConfiguration : Humidifier.Base.BaseSubResource, IHaveType, IHaveValue_Integer
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-thresholdconfiguration.html#cfn-ecs-service-thresholdconfiguration-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-thresholdconfiguration.html#cfn-ecs-service-thresholdconfiguration-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Value { get; set; }
        }

        public class TimeoutConfiguration : Humidifier.Base.BaseSubResource, IHavePerRequestTimeoutSeconds_Integer, IHaveIdleTimeoutSeconds_Integer
        {
            /// <summary>
            /// PerRequestTimeoutSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-timeoutconfiguration.html#cfn-ecs-service-timeoutconfiguration-perrequesttimeoutseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? PerRequestTimeoutSeconds { get; set; }
            /// <summary>
            /// IdleTimeoutSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-timeoutconfiguration.html#cfn-ecs-service-timeoutconfiguration-idletimeoutseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? IdleTimeoutSeconds { get; set; }
        }

        public class VpcLatticeAdvancedConfiguration : Humidifier.Base.BaseSubResource, IHaveTestListenerRule, IHaveAlternateTargetGroupArn, IHaveProductionListenerRule
        {
            /// <summary>
            /// TestListenerRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-vpclatticeadvancedconfiguration.html#cfn-ecs-service-vpclatticeadvancedconfiguration-testlistenerrule
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TestListenerRule { get; set; }
            /// <summary>
            /// AlternateTargetGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-vpclatticeadvancedconfiguration.html#cfn-ecs-service-vpclatticeadvancedconfiguration-alternatetargetgrouparn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AlternateTargetGroupArn { get; set; }
            /// <summary>
            /// ProductionListenerRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-vpclatticeadvancedconfiguration.html#cfn-ecs-service-vpclatticeadvancedconfiguration-productionlistenerrule
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProductionListenerRule { get; set; }
        }

        public class VpcLatticeConfiguration : Humidifier.Base.BaseSubResource, IHaveTargetGroupArn, IHavePortName, IHaveRoleArn, IHaveECSServiceTypesVpcLatticeAdvancedConfigurationAdvancedConfiguration
        {
            /// <summary>
            /// TargetGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-vpclatticeconfiguration.html#cfn-ecs-service-vpclatticeconfiguration-targetgrouparn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetGroupArn { get; set; }
            /// <summary>
            /// PortName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-vpclatticeconfiguration.html#cfn-ecs-service-vpclatticeconfiguration-portname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PortName { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-vpclatticeconfiguration.html#cfn-ecs-service-vpclatticeconfiguration-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
            /// <summary>
            /// AdvancedConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-service-vpclatticeconfiguration.html#cfn-ecs-service-vpclatticeconfiguration-advancedconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VpcLatticeAdvancedConfiguration
            /// </summary>
            public Union<Humidifier.ECS.ServiceTypes.VpcLatticeAdvancedConfiguration, BaseFunction>? AdvancedConfiguration { get; set; }
        }
    }
}