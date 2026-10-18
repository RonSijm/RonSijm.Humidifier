namespace Humidifier.ECS
{
    using global::System.Collections.Generic;
    using TaskSetTypes;

    public class TaskSet : Humidifier.Base.BaseResource, IHaveTags, IHavePlatformVersion, IHaveTaskDefinition, IHaveExternalId, IHaveCluster, IHaveListOfECSTaskSetTypesLoadBalancerLoadBalancers, IHaveService, IHaveECSTaskSetTypesScaleScale, IHaveECSTaskSetTypesNetworkConfigurationNetworkConfiguration, IHaveListOfECSTaskSetTypesServiceRegistryServiceRegistries, IHaveListOfECSTaskSetTypesCapacityProviderStrategyItemCapacityProviderStrategy, IHaveLaunchType
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.ECS.TaskSet; }
        /// <summary>
        /// PlatformVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-taskset.html#cfn-ecs-taskset-platformversion
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PlatformVersion { get; set; }

        /// <summary>
        /// TaskDefinition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-taskset.html#cfn-ecs-taskset-taskdefinition
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TaskDefinition { get; set; }
        /// <summary>
        /// ExternalId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-taskset.html#cfn-ecs-taskset-externalid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ExternalId { get; set; }

        /// <summary>
        /// Cluster
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-taskset.html#cfn-ecs-taskset-cluster
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Cluster { get; set; }
        /// <summary>
        /// LoadBalancers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-taskset.html#cfn-ecs-taskset-loadbalancers
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: LoadBalancer
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ECS.TaskSetTypes.LoadBalancer>, IReadOnlyList<Union<Humidifier.ECS.TaskSetTypes.LoadBalancer, BaseFunction>>, BaseFunction>? LoadBalancers { get; set; }

        /// <summary>
        /// Service
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-taskset.html#cfn-ecs-taskset-service
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Service { get; set; }
        /// <summary>
        /// Scale
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-taskset.html#cfn-ecs-taskset-scale
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Scale
        /// </summary>
        public Union<Humidifier.ECS.TaskSetTypes.Scale, BaseFunction>? Scale { get; set; }
        /// <summary>
        /// NetworkConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-taskset.html#cfn-ecs-taskset-networkconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: NetworkConfiguration
        /// </summary>
        public Union<Humidifier.ECS.TaskSetTypes.NetworkConfiguration, BaseFunction>? NetworkConfiguration { get; set; }
        /// <summary>
        /// ServiceRegistries
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-taskset.html#cfn-ecs-taskset-serviceregistries
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: ServiceRegistry
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ECS.TaskSetTypes.ServiceRegistry>, IReadOnlyList<Union<Humidifier.ECS.TaskSetTypes.ServiceRegistry, BaseFunction>>, BaseFunction>? ServiceRegistries { get; set; }
        /// <summary>
        /// CapacityProviderStrategy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-taskset.html#cfn-ecs-taskset-capacityproviderstrategy
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: CapacityProviderStrategyItem
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ECS.TaskSetTypes.CapacityProviderStrategyItem>, IReadOnlyList<Union<Humidifier.ECS.TaskSetTypes.CapacityProviderStrategyItem, BaseFunction>>, BaseFunction>? CapacityProviderStrategy { get; set; }
        /// <summary>
        /// LaunchType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-taskset.html#cfn-ecs-taskset-launchtype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LaunchType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-taskset.html#cfn-ecs-taskset-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace TaskSetTypes
    {
        public class AwsVpcConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfSecurityGroups, IHaveStringListOfSubnets, IHaveAssignPublicIp
        {
            /// <summary>
            /// SecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskset-awsvpcconfiguration.html#cfn-ecs-taskset-awsvpcconfiguration-securitygroups
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroups { get; set; }
            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskset-awsvpcconfiguration.html#cfn-ecs-taskset-awsvpcconfiguration-subnets
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Subnets { get; set; }
            /// <summary>
            /// AssignPublicIp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskset-awsvpcconfiguration.html#cfn-ecs-taskset-awsvpcconfiguration-assignpublicip
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AssignPublicIp { get; set; }
        }

        public class CapacityProviderStrategyItem : Humidifier.Base.BaseSubResource, IHaveCapacityProvider, IHaveBase_Integer, IHaveWeight_Integer
        {
            /// <summary>
            /// CapacityProvider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskset-capacityproviderstrategyitem.html#cfn-ecs-taskset-capacityproviderstrategyitem-capacityprovider
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CapacityProvider { get; set; }
            /// <summary>
            /// Base
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskset-capacityproviderstrategyitem.html#cfn-ecs-taskset-capacityproviderstrategyitem-base
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Base { get; set; }
            /// <summary>
            /// Weight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskset-capacityproviderstrategyitem.html#cfn-ecs-taskset-capacityproviderstrategyitem-weight
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Weight { get; set; }
        }

        public class LoadBalancer : Humidifier.Base.BaseSubResource, IHaveTargetGroupArn, IHaveContainerName, IHaveContainerPort_Integer
        {
            /// <summary>
            /// TargetGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskset-loadbalancer.html#cfn-ecs-taskset-loadbalancer-targetgrouparn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetGroupArn { get; set; }
            /// <summary>
            /// ContainerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskset-loadbalancer.html#cfn-ecs-taskset-loadbalancer-containername
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContainerName { get; set; }
            /// <summary>
            /// ContainerPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskset-loadbalancer.html#cfn-ecs-taskset-loadbalancer-containerport
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ContainerPort { get; set; }
        }

        public class NetworkConfiguration : Humidifier.Base.BaseSubResource, IHaveECSTaskSetTypesAwsVpcConfigurationAwsVpcConfiguration
        {
            /// <summary>
            /// AwsVpcConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskset-networkconfiguration.html#cfn-ecs-taskset-networkconfiguration-awsvpcconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AwsVpcConfiguration
            /// </summary>
            public Union<Humidifier.ECS.TaskSetTypes.AwsVpcConfiguration, BaseFunction>? AwsVpcConfiguration { get; set; }
        }

        public class Scale : Humidifier.Base.BaseSubResource, IHaveValue_Double, IHaveUnit
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskset-scale.html#cfn-ecs-taskset-scale-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskset-scale.html#cfn-ecs-taskset-scale-unit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Unit { get; set; }
        }

        public class ServiceRegistry : Humidifier.Base.BaseSubResource, IHaveContainerName, IHavePort_Integer, IHaveContainerPort_Integer, IHaveRegistryArn
        {
            /// <summary>
            /// ContainerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskset-serviceregistry.html#cfn-ecs-taskset-serviceregistry-containername
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContainerName { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskset-serviceregistry.html#cfn-ecs-taskset-serviceregistry-port
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Port { get; set; }
            /// <summary>
            /// ContainerPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskset-serviceregistry.html#cfn-ecs-taskset-serviceregistry-containerport
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ContainerPort { get; set; }
            /// <summary>
            /// RegistryArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskset-serviceregistry.html#cfn-ecs-taskset-serviceregistry-registryarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RegistryArn { get; set; }
        }
    }
}