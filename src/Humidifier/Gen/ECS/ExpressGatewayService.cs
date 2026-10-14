namespace Humidifier.ECS
{
    using global::System.Collections.Generic;
    using ExpressGatewayServiceTypes;

    public class ExpressGatewayService : Humidifier.Base.BaseResource, IHaveTags, IHaveExecutionRoleArn, IHaveServiceName, IHaveMemory, IHaveCpu, IHaveCluster, IHaveTaskRoleArn, IHaveHealthCheckPath, IHaveTaskDefinitionArn
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string ServiceArn =  "ServiceArn" ;
            public static string ECSManagedResourceArns =  "ECSManagedResourceArns" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string ActiveConfigurations =  "ActiveConfigurations" ;
            public static string Endpoint =  "Endpoint" ;
        }

        public override string AWSTypeName { get => AWS.ECS.ExpressGatewayService; }
        /// <summary>
        /// TaskRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-expressgatewayservice.html#cfn-ecs-expressgatewayservice-taskrolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TaskRoleArn { get; set; }
        /// <summary>
        /// PrimaryContainer
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-expressgatewayservice.html#cfn-ecs-expressgatewayservice-primarycontainer
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ExpressGatewayContainer
        /// </summary>
        public Humidifier.ECS.ExpressGatewayServiceTypes.ExpressGatewayContainer PrimaryContainer { get; set; }
        /// <summary>
        /// Memory
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-expressgatewayservice.html#cfn-ecs-expressgatewayservice-memory
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Memory { get; set; }
        /// <summary>
        /// HealthCheckPath
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-expressgatewayservice.html#cfn-ecs-expressgatewayservice-healthcheckpath
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic HealthCheckPath { get; set; }
        /// <summary>
        /// Cluster
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-expressgatewayservice.html#cfn-ecs-expressgatewayservice-cluster
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Cluster { get; set; }
        /// <summary>
        /// Cpu
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-expressgatewayservice.html#cfn-ecs-expressgatewayservice-cpu
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Cpu { get; set; }
        /// <summary>
        /// ExecutionRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-expressgatewayservice.html#cfn-ecs-expressgatewayservice-executionrolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ExecutionRoleArn { get; set; }

        /// <summary>
        /// InfrastructureRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-expressgatewayservice.html#cfn-ecs-expressgatewayservice-infrastructurerolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic InfrastructureRoleArn { get; set; }
        /// <summary>
        /// ScalingTarget
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-expressgatewayservice.html#cfn-ecs-expressgatewayservice-scalingtarget
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ExpressGatewayScalingTarget
        /// </summary>
        public Humidifier.ECS.ExpressGatewayServiceTypes.ExpressGatewayScalingTarget ScalingTarget { get; set; }
        /// <summary>
        /// ServiceName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-expressgatewayservice.html#cfn-ecs-expressgatewayservice-servicename
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ServiceName { get; set; }
        /// <summary>
        /// NetworkConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-expressgatewayservice.html#cfn-ecs-expressgatewayservice-networkconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ExpressGatewayServiceNetworkConfiguration
        /// </summary>
        public Humidifier.ECS.ExpressGatewayServiceTypes.ExpressGatewayServiceNetworkConfiguration NetworkConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-expressgatewayservice.html#cfn-ecs-expressgatewayservice-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        /// <summary>
        /// TaskDefinitionArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-expressgatewayservice.html#cfn-ecs-expressgatewayservice-taskdefinitionarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TaskDefinitionArn { get; set; }
    }

    namespace ExpressGatewayServiceTypes
    {
        public class AutoScalingArns : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ScalableTarget
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-autoscalingarns.html#cfn-ecs-expressgatewayservice-autoscalingarns-scalabletarget
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ScalableTarget { get; set; }
            /// <summary>
            /// ApplicationAutoScalingPolicies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-autoscalingarns.html#cfn-ecs-expressgatewayservice-autoscalingarns-applicationautoscalingpolicies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ApplicationAutoScalingPolicies { get; set; }
        }

        public class ECSManagedResourceArns : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LogGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-ecsmanagedresourcearns.html#cfn-ecs-expressgatewayservice-ecsmanagedresourcearns-loggroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic LogGroups { get; set; }
            /// <summary>
            /// ServiceSecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-ecsmanagedresourcearns.html#cfn-ecs-expressgatewayservice-ecsmanagedresourcearns-servicesecuritygroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ServiceSecurityGroups { get; set; }
            /// <summary>
            /// MetricAlarms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-ecsmanagedresourcearns.html#cfn-ecs-expressgatewayservice-ecsmanagedresourcearns-metricalarms
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic MetricAlarms { get; set; }
            /// <summary>
            /// IngressPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-ecsmanagedresourcearns.html#cfn-ecs-expressgatewayservice-ecsmanagedresourcearns-ingresspath
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IngressPathArns
            /// </summary>
            public Humidifier.ECS.ExpressGatewayServiceTypes.IngressPathArns IngressPath { get; set; }
            /// <summary>
            /// AutoScaling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-ecsmanagedresourcearns.html#cfn-ecs-expressgatewayservice-ecsmanagedresourcearns-autoscaling
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AutoScalingArns
            /// </summary>
            public Humidifier.ECS.ExpressGatewayServiceTypes.AutoScalingArns AutoScaling { get; set; }
        }

        public class ExpressGatewayContainer : Humidifier.Base.BaseSubResource, IHaveImage, IHaveCommand, IHaveContainerPort
        {
            /// <summary>
            /// RepositoryCredentials
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewaycontainer.html#cfn-ecs-expressgatewayservice-expressgatewaycontainer-repositorycredentials
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ExpressGatewayRepositoryCredentials
            /// </summary>
            public Humidifier.ECS.ExpressGatewayServiceTypes.ExpressGatewayRepositoryCredentials RepositoryCredentials { get; set; }
            /// <summary>
            /// Secrets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewaycontainer.html#cfn-ecs-expressgatewayservice-expressgatewaycontainer-secrets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Secret
            /// </summary>
            public List<Humidifier.ECS.ExpressGatewayServiceTypes.Secret> Secrets { get; set; }
            /// <summary>
            /// Command
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewaycontainer.html#cfn-ecs-expressgatewayservice-expressgatewaycontainer-command
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Command { get; set; }
            /// <summary>
            /// AwsLogsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewaycontainer.html#cfn-ecs-expressgatewayservice-expressgatewaycontainer-awslogsconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ExpressGatewayServiceAwsLogsConfiguration
            /// </summary>
            public Humidifier.ECS.ExpressGatewayServiceTypes.ExpressGatewayServiceAwsLogsConfiguration AwsLogsConfiguration { get; set; }
            /// <summary>
            /// ContainerPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewaycontainer.html#cfn-ecs-expressgatewayservice-expressgatewaycontainer-containerport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ContainerPort { get; set; }
            /// <summary>
            /// Environment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewaycontainer.html#cfn-ecs-expressgatewayservice-expressgatewaycontainer-environment
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: KeyValuePair
            /// </summary>
            public List<Humidifier.ECS.ExpressGatewayServiceTypes.KeyValuePair> Environment { get; set; }
            /// <summary>
            /// Image
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewaycontainer.html#cfn-ecs-expressgatewayservice-expressgatewaycontainer-image
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Image { get; set; }
        }

        public class ExpressGatewayRepositoryCredentials : Humidifier.Base.BaseSubResource, IHaveCredentialsParameter
        {
            /// <summary>
            /// CredentialsParameter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewayrepositorycredentials.html#cfn-ecs-expressgatewayservice-expressgatewayrepositorycredentials-credentialsparameter
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CredentialsParameter { get; set; }
        }

        public class ExpressGatewayScalingTarget : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MinTaskCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewayscalingtarget.html#cfn-ecs-expressgatewayservice-expressgatewayscalingtarget-mintaskcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinTaskCount { get; set; }
            /// <summary>
            /// AutoScalingMetric
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewayscalingtarget.html#cfn-ecs-expressgatewayservice-expressgatewayscalingtarget-autoscalingmetric
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AutoScalingMetric { get; set; }
            /// <summary>
            /// AutoScalingTargetValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewayscalingtarget.html#cfn-ecs-expressgatewayservice-expressgatewayscalingtarget-autoscalingtargetvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic AutoScalingTargetValue { get; set; }
            /// <summary>
            /// MaxTaskCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewayscalingtarget.html#cfn-ecs-expressgatewayservice-expressgatewayscalingtarget-maxtaskcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxTaskCount { get; set; }
        }

        public class ExpressGatewayServiceAwsLogsConfiguration : Humidifier.Base.BaseSubResource, IHaveLogGroup
        {
            /// <summary>
            /// LogStreamPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewayserviceawslogsconfiguration.html#cfn-ecs-expressgatewayservice-expressgatewayserviceawslogsconfiguration-logstreamprefix
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogStreamPrefix { get; set; }
            /// <summary>
            /// LogGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewayserviceawslogsconfiguration.html#cfn-ecs-expressgatewayservice-expressgatewayserviceawslogsconfiguration-loggroup
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogGroup { get; set; }
        }

        public class ExpressGatewayServiceConfiguration : Humidifier.Base.BaseSubResource, IHaveExecutionRoleArn, IHaveMemory, IHaveCpu, IHaveTaskRoleArn, IHaveHealthCheckPath, IHaveTaskDefinitionArn, IHaveCreatedAt
        {
            /// <summary>
            /// ServiceRevisionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewayserviceconfiguration.html#cfn-ecs-expressgatewayservice-expressgatewayserviceconfiguration-servicerevisionarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ServiceRevisionArn { get; set; }
            /// <summary>
            /// TaskRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewayserviceconfiguration.html#cfn-ecs-expressgatewayservice-expressgatewayserviceconfiguration-taskrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TaskRoleArn { get; set; }
            /// <summary>
            /// ExecutionRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewayserviceconfiguration.html#cfn-ecs-expressgatewayservice-expressgatewayserviceconfiguration-executionrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExecutionRoleArn { get; set; }
            /// <summary>
            /// ScalingTarget
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewayserviceconfiguration.html#cfn-ecs-expressgatewayservice-expressgatewayserviceconfiguration-scalingtarget
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ExpressGatewayScalingTarget
            /// </summary>
            public Humidifier.ECS.ExpressGatewayServiceTypes.ExpressGatewayScalingTarget ScalingTarget { get; set; }
            /// <summary>
            /// IngressPaths
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewayserviceconfiguration.html#cfn-ecs-expressgatewayservice-expressgatewayserviceconfiguration-ingresspaths
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: IngressPathSummary
            /// </summary>
            public List<Humidifier.ECS.ExpressGatewayServiceTypes.IngressPathSummary> IngressPaths { get; set; }
            /// <summary>
            /// PrimaryContainer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewayserviceconfiguration.html#cfn-ecs-expressgatewayservice-expressgatewayserviceconfiguration-primarycontainer
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ExpressGatewayContainer
            /// </summary>
            public Humidifier.ECS.ExpressGatewayServiceTypes.ExpressGatewayContainer PrimaryContainer { get; set; }
            /// <summary>
            /// Memory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewayserviceconfiguration.html#cfn-ecs-expressgatewayservice-expressgatewayserviceconfiguration-memory
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Memory { get; set; }
            /// <summary>
            /// HealthCheckPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewayserviceconfiguration.html#cfn-ecs-expressgatewayservice-expressgatewayserviceconfiguration-healthcheckpath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HealthCheckPath { get; set; }
            /// <summary>
            /// CreatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewayserviceconfiguration.html#cfn-ecs-expressgatewayservice-expressgatewayserviceconfiguration-createdat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreatedAt { get; set; }
            /// <summary>
            /// Cpu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewayserviceconfiguration.html#cfn-ecs-expressgatewayservice-expressgatewayserviceconfiguration-cpu
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Cpu { get; set; }
            /// <summary>
            /// NetworkConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewayserviceconfiguration.html#cfn-ecs-expressgatewayservice-expressgatewayserviceconfiguration-networkconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ExpressGatewayServiceNetworkConfiguration
            /// </summary>
            public Humidifier.ECS.ExpressGatewayServiceTypes.ExpressGatewayServiceNetworkConfiguration NetworkConfiguration { get; set; }
            /// <summary>
            /// TaskDefinitionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewayserviceconfiguration.html#cfn-ecs-expressgatewayservice-expressgatewayserviceconfiguration-taskdefinitionarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TaskDefinitionArn { get; set; }
        }

        public class ExpressGatewayServiceNetworkConfiguration : Humidifier.Base.BaseSubResource, IHaveSubnets, IHaveSecurityGroups
        {
            /// <summary>
            /// SecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewayservicenetworkconfiguration.html#cfn-ecs-expressgatewayservice-expressgatewayservicenetworkconfiguration-securitygroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroups { get; set; }
            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewayservicenetworkconfiguration.html#cfn-ecs-expressgatewayservice-expressgatewayservicenetworkconfiguration-subnets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Subnets { get; set; }
        }

        public class ExpressGatewayServiceStatus : Humidifier.Base.BaseSubResource, IHaveStatusCode
        {
            /// <summary>
            /// StatusCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewayservicestatus.html#cfn-ecs-expressgatewayservice-expressgatewayservicestatus-statuscode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StatusCode { get; set; }
        }

        public class IngressPathArns : Humidifier.Base.BaseSubResource, IHaveCertificateArn, IHaveLoadBalancerArn, IHaveListenerArn
        {
            /// <summary>
            /// ListenerArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-ingresspatharns.html#cfn-ecs-expressgatewayservice-ingresspatharns-listenerarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ListenerArn { get; set; }
            /// <summary>
            /// LoadBalancerArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-ingresspatharns.html#cfn-ecs-expressgatewayservice-ingresspatharns-loadbalancerarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LoadBalancerArn { get; set; }
            /// <summary>
            /// TargetGroupArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-ingresspatharns.html#cfn-ecs-expressgatewayservice-ingresspatharns-targetgrouparns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic TargetGroupArns { get; set; }
            /// <summary>
            /// ListenerRuleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-ingresspatharns.html#cfn-ecs-expressgatewayservice-ingresspatharns-listenerrulearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ListenerRuleArn { get; set; }
            /// <summary>
            /// LoadBalancerSecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-ingresspatharns.html#cfn-ecs-expressgatewayservice-ingresspatharns-loadbalancersecuritygroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic LoadBalancerSecurityGroups { get; set; }
            /// <summary>
            /// CertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-ingresspatharns.html#cfn-ecs-expressgatewayservice-ingresspatharns-certificatearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CertificateArn { get; set; }
        }

        public class IngressPathSummary : Humidifier.Base.BaseSubResource, IHaveEndpoint, IHaveAccessType
        {
            /// <summary>
            /// Endpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-ingresspathsummary.html#cfn-ecs-expressgatewayservice-ingresspathsummary-endpoint
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Endpoint { get; set; }
            /// <summary>
            /// AccessType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-ingresspathsummary.html#cfn-ecs-expressgatewayservice-ingresspathsummary-accesstype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AccessType { get; set; }
        }

        public class KeyValuePair : Humidifier.Base.BaseSubResource, IHaveName, IHaveValue
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-keyvaluepair.html#cfn-ecs-expressgatewayservice-keyvaluepair-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-keyvaluepair.html#cfn-ecs-expressgatewayservice-keyvaluepair-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class Secret : Humidifier.Base.BaseSubResource, IHaveName, IHaveValueFrom
        {
            /// <summary>
            /// ValueFrom
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-secret.html#cfn-ecs-expressgatewayservice-secret-valuefrom
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ValueFrom { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-secret.html#cfn-ecs-expressgatewayservice-secret-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }
    }
}