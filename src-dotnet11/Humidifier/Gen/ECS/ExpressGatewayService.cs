namespace Humidifier.ECS
{
    using global::System.Collections.Generic;
    using ExpressGatewayServiceTypes;

    public class ExpressGatewayService : Humidifier.Base.BaseResource, IHaveTags, IHaveTaskRoleArn, IHaveECSExpressGatewayServiceTypesExpressGatewayContainerPrimaryContainer, IHaveMemory, IHaveHealthCheckPath, IHaveCluster, IHaveCpu, IHaveExecutionRoleArn, IHaveInfrastructureRoleArn, IHaveECSExpressGatewayServiceTypesExpressGatewayScalingTargetScalingTarget, IHaveServiceName, IHaveECSExpressGatewayServiceTypesExpressGatewayServiceNetworkConfigurationNetworkConfiguration, IHaveTaskDefinitionArn
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
        public Union<string, BaseFunction>? TaskRoleArn { get; set; }
        /// <summary>
        /// PrimaryContainer
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-expressgatewayservice.html#cfn-ecs-expressgatewayservice-primarycontainer
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ExpressGatewayContainer
        /// </summary>
        public Union<Humidifier.ECS.ExpressGatewayServiceTypes.ExpressGatewayContainer, BaseFunction>? PrimaryContainer { get; set; }
        /// <summary>
        /// Memory
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-expressgatewayservice.html#cfn-ecs-expressgatewayservice-memory
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Memory { get; set; }
        /// <summary>
        /// HealthCheckPath
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-expressgatewayservice.html#cfn-ecs-expressgatewayservice-healthcheckpath
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? HealthCheckPath { get; set; }
        /// <summary>
        /// Cluster
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-expressgatewayservice.html#cfn-ecs-expressgatewayservice-cluster
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Cluster { get; set; }
        /// <summary>
        /// Cpu
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-expressgatewayservice.html#cfn-ecs-expressgatewayservice-cpu
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Cpu { get; set; }
        /// <summary>
        /// ExecutionRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-expressgatewayservice.html#cfn-ecs-expressgatewayservice-executionrolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ExecutionRoleArn { get; set; }

        /// <summary>
        /// InfrastructureRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-expressgatewayservice.html#cfn-ecs-expressgatewayservice-infrastructurerolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? InfrastructureRoleArn { get; set; }
        /// <summary>
        /// ScalingTarget
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-expressgatewayservice.html#cfn-ecs-expressgatewayservice-scalingtarget
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ExpressGatewayScalingTarget
        /// </summary>
        public Union<Humidifier.ECS.ExpressGatewayServiceTypes.ExpressGatewayScalingTarget, BaseFunction>? ScalingTarget { get; set; }
        /// <summary>
        /// ServiceName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-expressgatewayservice.html#cfn-ecs-expressgatewayservice-servicename
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ServiceName { get; set; }
        /// <summary>
        /// NetworkConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-expressgatewayservice.html#cfn-ecs-expressgatewayservice-networkconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ExpressGatewayServiceNetworkConfiguration
        /// </summary>
        public Union<Humidifier.ECS.ExpressGatewayServiceTypes.ExpressGatewayServiceNetworkConfiguration, BaseFunction>? NetworkConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-expressgatewayservice.html#cfn-ecs-expressgatewayservice-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// TaskDefinitionArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-expressgatewayservice.html#cfn-ecs-expressgatewayservice-taskdefinitionarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TaskDefinitionArn { get; set; }
    }

    namespace ExpressGatewayServiceTypes
    {
        public class AutoScalingArns : Humidifier.Base.BaseSubResource, IHaveScalableTarget, IHaveStringListOfApplicationAutoScalingPolicies
        {
            /// <summary>
            /// ScalableTarget
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-autoscalingarns.html#cfn-ecs-expressgatewayservice-autoscalingarns-scalabletarget
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScalableTarget { get; set; }
            /// <summary>
            /// ApplicationAutoScalingPolicies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-autoscalingarns.html#cfn-ecs-expressgatewayservice-autoscalingarns-applicationautoscalingpolicies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ApplicationAutoScalingPolicies { get; set; }
        }

        public class ECSManagedResourceArns : Humidifier.Base.BaseSubResource, IHaveStringListOfLogGroups, IHaveStringListOfServiceSecurityGroups, IHaveStringListOfMetricAlarms, IHaveECSExpressGatewayServiceTypesIngressPathArnsIngressPath, IHaveECSExpressGatewayServiceTypesAutoScalingArnsAutoScaling
        {
            /// <summary>
            /// LogGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-ecsmanagedresourcearns.html#cfn-ecs-expressgatewayservice-ecsmanagedresourcearns-loggroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LogGroups { get; set; }
            /// <summary>
            /// ServiceSecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-ecsmanagedresourcearns.html#cfn-ecs-expressgatewayservice-ecsmanagedresourcearns-servicesecuritygroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ServiceSecurityGroups { get; set; }
            /// <summary>
            /// MetricAlarms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-ecsmanagedresourcearns.html#cfn-ecs-expressgatewayservice-ecsmanagedresourcearns-metricalarms
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? MetricAlarms { get; set; }
            /// <summary>
            /// IngressPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-ecsmanagedresourcearns.html#cfn-ecs-expressgatewayservice-ecsmanagedresourcearns-ingresspath
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IngressPathArns
            /// </summary>
            public Union<Humidifier.ECS.ExpressGatewayServiceTypes.IngressPathArns, BaseFunction>? IngressPath { get; set; }
            /// <summary>
            /// AutoScaling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-ecsmanagedresourcearns.html#cfn-ecs-expressgatewayservice-ecsmanagedresourcearns-autoscaling
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AutoScalingArns
            /// </summary>
            public Union<Humidifier.ECS.ExpressGatewayServiceTypes.AutoScalingArns, BaseFunction>? AutoScaling { get; set; }
        }

        public class ExpressGatewayContainer : Humidifier.Base.BaseSubResource, IHaveECSExpressGatewayServiceTypesExpressGatewayRepositoryCredentialsRepositoryCredentials, IHaveListOfECSExpressGatewayServiceTypesSecretSecrets, IHaveStringListOfCommand, IHaveECSExpressGatewayServiceTypesExpressGatewayServiceAwsLogsConfigurationAwsLogsConfiguration, IHaveContainerPort_Integer, IHaveListOfECSExpressGatewayServiceTypesKeyValuePairEnvironment, IHaveImage
        {
            /// <summary>
            /// RepositoryCredentials
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewaycontainer.html#cfn-ecs-expressgatewayservice-expressgatewaycontainer-repositorycredentials
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ExpressGatewayRepositoryCredentials
            /// </summary>
            public Union<Humidifier.ECS.ExpressGatewayServiceTypes.ExpressGatewayRepositoryCredentials, BaseFunction>? RepositoryCredentials { get; set; }
            /// <summary>
            /// Secrets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewaycontainer.html#cfn-ecs-expressgatewayservice-expressgatewaycontainer-secrets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Secret
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECS.ExpressGatewayServiceTypes.Secret>, IReadOnlyList<Union<Humidifier.ECS.ExpressGatewayServiceTypes.Secret, BaseFunction>>, BaseFunction>? Secrets { get; set; }
            /// <summary>
            /// Command
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewaycontainer.html#cfn-ecs-expressgatewayservice-expressgatewaycontainer-command
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Command { get; set; }
            /// <summary>
            /// AwsLogsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewaycontainer.html#cfn-ecs-expressgatewayservice-expressgatewaycontainer-awslogsconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ExpressGatewayServiceAwsLogsConfiguration
            /// </summary>
            public Union<Humidifier.ECS.ExpressGatewayServiceTypes.ExpressGatewayServiceAwsLogsConfiguration, BaseFunction>? AwsLogsConfiguration { get; set; }
            /// <summary>
            /// ContainerPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewaycontainer.html#cfn-ecs-expressgatewayservice-expressgatewaycontainer-containerport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ContainerPort { get; set; }
            /// <summary>
            /// Environment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewaycontainer.html#cfn-ecs-expressgatewayservice-expressgatewaycontainer-environment
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: KeyValuePair
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECS.ExpressGatewayServiceTypes.KeyValuePair>, IReadOnlyList<Union<Humidifier.ECS.ExpressGatewayServiceTypes.KeyValuePair, BaseFunction>>, BaseFunction>? Environment { get; set; }
            /// <summary>
            /// Image
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewaycontainer.html#cfn-ecs-expressgatewayservice-expressgatewaycontainer-image
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Image { get; set; }
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
            public Union<string, BaseFunction>? CredentialsParameter { get; set; }
        }

        public class ExpressGatewayScalingTarget : Humidifier.Base.BaseSubResource, IHaveMinTaskCount_Integer, IHaveAutoScalingMetric, IHaveAutoScalingTargetValue_Integer, IHaveMaxTaskCount_Integer
        {
            /// <summary>
            /// MinTaskCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewayscalingtarget.html#cfn-ecs-expressgatewayservice-expressgatewayscalingtarget-mintaskcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinTaskCount { get; set; }
            /// <summary>
            /// AutoScalingMetric
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewayscalingtarget.html#cfn-ecs-expressgatewayservice-expressgatewayscalingtarget-autoscalingmetric
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AutoScalingMetric { get; set; }
            /// <summary>
            /// AutoScalingTargetValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewayscalingtarget.html#cfn-ecs-expressgatewayservice-expressgatewayscalingtarget-autoscalingtargetvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? AutoScalingTargetValue { get; set; }
            /// <summary>
            /// MaxTaskCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewayscalingtarget.html#cfn-ecs-expressgatewayservice-expressgatewayscalingtarget-maxtaskcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxTaskCount { get; set; }
        }

        public class ExpressGatewayServiceAwsLogsConfiguration : Humidifier.Base.BaseSubResource, IHaveLogStreamPrefix, IHaveLogGroup
        {
            /// <summary>
            /// LogStreamPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewayserviceawslogsconfiguration.html#cfn-ecs-expressgatewayservice-expressgatewayserviceawslogsconfiguration-logstreamprefix
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogStreamPrefix { get; set; }
            /// <summary>
            /// LogGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewayserviceawslogsconfiguration.html#cfn-ecs-expressgatewayservice-expressgatewayserviceawslogsconfiguration-loggroup
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogGroup { get; set; }
        }

        public class ExpressGatewayServiceConfiguration : Humidifier.Base.BaseSubResource, IHaveServiceRevisionArn, IHaveTaskRoleArn, IHaveExecutionRoleArn, IHaveECSExpressGatewayServiceTypesExpressGatewayScalingTargetScalingTarget, IHaveListOfECSExpressGatewayServiceTypesIngressPathSummaryIngressPaths, IHaveECSExpressGatewayServiceTypesExpressGatewayContainerPrimaryContainer, IHaveMemory, IHaveHealthCheckPath, IHaveCreatedAt, IHaveCpu, IHaveECSExpressGatewayServiceTypesExpressGatewayServiceNetworkConfigurationNetworkConfiguration, IHaveTaskDefinitionArn
        {
            /// <summary>
            /// ServiceRevisionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewayserviceconfiguration.html#cfn-ecs-expressgatewayservice-expressgatewayserviceconfiguration-servicerevisionarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServiceRevisionArn { get; set; }
            /// <summary>
            /// TaskRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewayserviceconfiguration.html#cfn-ecs-expressgatewayservice-expressgatewayserviceconfiguration-taskrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TaskRoleArn { get; set; }
            /// <summary>
            /// ExecutionRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewayserviceconfiguration.html#cfn-ecs-expressgatewayservice-expressgatewayserviceconfiguration-executionrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExecutionRoleArn { get; set; }
            /// <summary>
            /// ScalingTarget
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewayserviceconfiguration.html#cfn-ecs-expressgatewayservice-expressgatewayserviceconfiguration-scalingtarget
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ExpressGatewayScalingTarget
            /// </summary>
            public Union<Humidifier.ECS.ExpressGatewayServiceTypes.ExpressGatewayScalingTarget, BaseFunction>? ScalingTarget { get; set; }
            /// <summary>
            /// IngressPaths
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewayserviceconfiguration.html#cfn-ecs-expressgatewayservice-expressgatewayserviceconfiguration-ingresspaths
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: IngressPathSummary
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECS.ExpressGatewayServiceTypes.IngressPathSummary>, IReadOnlyList<Union<Humidifier.ECS.ExpressGatewayServiceTypes.IngressPathSummary, BaseFunction>>, BaseFunction>? IngressPaths { get; set; }
            /// <summary>
            /// PrimaryContainer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewayserviceconfiguration.html#cfn-ecs-expressgatewayservice-expressgatewayserviceconfiguration-primarycontainer
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ExpressGatewayContainer
            /// </summary>
            public Union<Humidifier.ECS.ExpressGatewayServiceTypes.ExpressGatewayContainer, BaseFunction>? PrimaryContainer { get; set; }
            /// <summary>
            /// Memory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewayserviceconfiguration.html#cfn-ecs-expressgatewayservice-expressgatewayserviceconfiguration-memory
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Memory { get; set; }
            /// <summary>
            /// HealthCheckPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewayserviceconfiguration.html#cfn-ecs-expressgatewayservice-expressgatewayserviceconfiguration-healthcheckpath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HealthCheckPath { get; set; }
            /// <summary>
            /// CreatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewayserviceconfiguration.html#cfn-ecs-expressgatewayservice-expressgatewayserviceconfiguration-createdat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreatedAt { get; set; }
            /// <summary>
            /// Cpu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewayserviceconfiguration.html#cfn-ecs-expressgatewayservice-expressgatewayserviceconfiguration-cpu
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Cpu { get; set; }
            /// <summary>
            /// NetworkConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewayserviceconfiguration.html#cfn-ecs-expressgatewayservice-expressgatewayserviceconfiguration-networkconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ExpressGatewayServiceNetworkConfiguration
            /// </summary>
            public Union<Humidifier.ECS.ExpressGatewayServiceTypes.ExpressGatewayServiceNetworkConfiguration, BaseFunction>? NetworkConfiguration { get; set; }
            /// <summary>
            /// TaskDefinitionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewayserviceconfiguration.html#cfn-ecs-expressgatewayservice-expressgatewayserviceconfiguration-taskdefinitionarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TaskDefinitionArn { get; set; }
        }

        public class ExpressGatewayServiceNetworkConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfSecurityGroups, IHaveStringListOfSubnets
        {
            /// <summary>
            /// SecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewayservicenetworkconfiguration.html#cfn-ecs-expressgatewayservice-expressgatewayservicenetworkconfiguration-securitygroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroups { get; set; }
            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-expressgatewayservicenetworkconfiguration.html#cfn-ecs-expressgatewayservice-expressgatewayservicenetworkconfiguration-subnets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Subnets { get; set; }
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
            public Union<string, BaseFunction>? StatusCode { get; set; }
        }

        public class IngressPathArns : Humidifier.Base.BaseSubResource, IHaveListenerArn, IHaveLoadBalancerArn, IHaveStringListOfTargetGroupArns, IHaveListenerRuleArn, IHaveStringListOfLoadBalancerSecurityGroups, IHaveCertificateArn
        {
            /// <summary>
            /// ListenerArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-ingresspatharns.html#cfn-ecs-expressgatewayservice-ingresspatharns-listenerarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ListenerArn { get; set; }
            /// <summary>
            /// LoadBalancerArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-ingresspatharns.html#cfn-ecs-expressgatewayservice-ingresspatharns-loadbalancerarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LoadBalancerArn { get; set; }
            /// <summary>
            /// TargetGroupArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-ingresspatharns.html#cfn-ecs-expressgatewayservice-ingresspatharns-targetgrouparns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? TargetGroupArns { get; set; }
            /// <summary>
            /// ListenerRuleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-ingresspatharns.html#cfn-ecs-expressgatewayservice-ingresspatharns-listenerrulearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ListenerRuleArn { get; set; }
            /// <summary>
            /// LoadBalancerSecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-ingresspatharns.html#cfn-ecs-expressgatewayservice-ingresspatharns-loadbalancersecuritygroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LoadBalancerSecurityGroups { get; set; }
            /// <summary>
            /// CertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-ingresspatharns.html#cfn-ecs-expressgatewayservice-ingresspatharns-certificatearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CertificateArn { get; set; }
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
            public Union<string, BaseFunction>? Endpoint { get; set; }
            /// <summary>
            /// AccessType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-ingresspathsummary.html#cfn-ecs-expressgatewayservice-ingresspathsummary-accesstype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccessType { get; set; }
        }

        public class KeyValuePair : Humidifier.Base.BaseSubResource, IHaveValue, IHaveName
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-keyvaluepair.html#cfn-ecs-expressgatewayservice-keyvaluepair-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-keyvaluepair.html#cfn-ecs-expressgatewayservice-keyvaluepair-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class Secret : Humidifier.Base.BaseSubResource, IHaveValueFrom, IHaveName
        {
            /// <summary>
            /// ValueFrom
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-secret.html#cfn-ecs-expressgatewayservice-secret-valuefrom
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ValueFrom { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-expressgatewayservice-secret.html#cfn-ecs-expressgatewayservice-secret-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }
    }
}