namespace Humidifier.ECS
{
    using global::System.Collections.Generic;
    using ServiceRevisionTypes;

    public class ServiceRevision : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string ClusterArn =  "ClusterArn" ;
            public static string PlatformVersion =  "PlatformVersion" ;
            public static string ServiceRevisionArn =  "ServiceRevisionArn" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string ServiceArn =  "ServiceArn" ;
            public static string ServiceRegistries =  "ServiceRegistries" ;
            public static string VolumeConfigurations =  "VolumeConfigurations" ;
            public static string CapacityProviderStrategy =  "CapacityProviderStrategy" ;
            public static string PlatformFamily =  "PlatformFamily" ;
            public static string ContainerImages =  "ContainerImages" ;
            public static string NetworkConfiguration =  "NetworkConfiguration" ;
            public static string FargateEphemeralStorage =  "FargateEphemeralStorage" ;
            public static string LoadBalancers =  "LoadBalancers" ;
            public static string ServiceConnectConfiguration =  "ServiceConnectConfiguration" ;
            public static string ResolvedConfiguration =  "ResolvedConfiguration" ;
            public static string GuardDutyEnabled =  "GuardDutyEnabled" ;
            public static string LaunchType =  "LaunchType" ;
            public static string Monitoring =  "Monitoring" ;
            public static string EcsManagedResources =  "EcsManagedResources" ;
            public static string Cluster =  "Cluster" ;
            public static string Service =  "Service" ;
            public static string VpcLatticeConfigurations =  "VpcLatticeConfigurations" ;
            public static string TaskDefinition =  "TaskDefinition" ;
            public static string ServiceRevisionId =  "ServiceRevisionId" ;
        }

        public override string AWSTypeName { get => AWS.ECS.ServiceRevision; }
    }

    namespace ServiceRevisionTypes
    {
        public class AdvancedConfiguration : Humidifier.Base.BaseSubResource, IHaveTestListenerRule, IHaveAlternateTargetGroupArn, IHaveProductionListenerRule, IHaveRoleArn
        {
            /// <summary>
            /// TestListenerRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-advancedconfiguration.html#cfn-ecs-servicerevision-advancedconfiguration-testlistenerrule
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TestListenerRule { get; set; }
            /// <summary>
            /// AlternateTargetGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-advancedconfiguration.html#cfn-ecs-servicerevision-advancedconfiguration-alternatetargetgrouparn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AlternateTargetGroupArn { get; set; }
            /// <summary>
            /// ProductionListenerRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-advancedconfiguration.html#cfn-ecs-servicerevision-advancedconfiguration-productionlistenerrule
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProductionListenerRule { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-advancedconfiguration.html#cfn-ecs-servicerevision-advancedconfiguration-rolearn
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-awsvpcconfiguration.html#cfn-ecs-servicerevision-awsvpcconfiguration-securitygroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroups { get; set; }
            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-awsvpcconfiguration.html#cfn-ecs-servicerevision-awsvpcconfiguration-subnets
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Subnets { get; set; }
            /// <summary>
            /// AssignPublicIp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-awsvpcconfiguration.html#cfn-ecs-servicerevision-awsvpcconfiguration-assignpublicip
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AssignPublicIp { get; set; }
        }

        public class CapacityProviderStrategyItem : Humidifier.Base.BaseSubResource, IHaveCapacityProvider, IHaveWeight_Integer, IHaveBase_Integer
        {
            /// <summary>
            /// CapacityProvider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-capacityproviderstrategyitem.html#cfn-ecs-servicerevision-capacityproviderstrategyitem-capacityprovider
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CapacityProvider { get; set; }
            /// <summary>
            /// Weight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-capacityproviderstrategyitem.html#cfn-ecs-servicerevision-capacityproviderstrategyitem-weight
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Weight { get; set; }
            /// <summary>
            /// Base
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-capacityproviderstrategyitem.html#cfn-ecs-servicerevision-capacityproviderstrategyitem-base
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Base { get; set; }
        }

        public class ContainerImage : Humidifier.Base.BaseSubResource, IHaveContainerName, IHaveImageDigest, IHaveImage
        {
            /// <summary>
            /// ContainerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-containerimage.html#cfn-ecs-servicerevision-containerimage-containername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContainerName { get; set; }
            /// <summary>
            /// ImageDigest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-containerimage.html#cfn-ecs-servicerevision-containerimage-imagedigest
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImageDigest { get; set; }
            /// <summary>
            /// Image
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-containerimage.html#cfn-ecs-servicerevision-containerimage-image
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Image { get; set; }
        }

        public class DeploymentEphemeralStorage : Humidifier.Base.BaseSubResource, IHaveKmsKeyId
        {
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-deploymentephemeralstorage.html#cfn-ecs-servicerevision-deploymentephemeralstorage-kmskeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
        }

        public class EBSTagSpecification : Humidifier.Base.BaseSubResource, IHaveTags, IHavePropagateTags, IHaveResourceType
        {
            /// <summary>
            /// PropagateTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-ebstagspecification.html#cfn-ecs-servicerevision-ebstagspecification-propagatetags
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PropagateTags { get; set; }
            /// <summary>
            /// ResourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-ebstagspecification.html#cfn-ecs-servicerevision-ebstagspecification-resourcetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceType { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-ebstagspecification.html#cfn-ecs-servicerevision-ebstagspecification-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        }

        public class EcsManagedResources : Humidifier.Base.BaseSubResource, IHaveListOfECSServiceRevisionTypesManagedLogGroupLogGroups, IHaveListOfECSServiceRevisionTypesManagedIngressPathIngressPaths, IHaveListOfECSServiceRevisionTypesManagedSecurityGroupServiceSecurityGroups, IHaveListOfECSServiceRevisionTypesManagedMetricAlarmMetricAlarms, IHaveECSServiceRevisionTypesManagedAutoScalingAutoScaling
        {
            /// <summary>
            /// LogGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-ecsmanagedresources.html#cfn-ecs-servicerevision-ecsmanagedresources-loggroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ManagedLogGroup
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECS.ServiceRevisionTypes.ManagedLogGroup>, IReadOnlyList<Union<Humidifier.ECS.ServiceRevisionTypes.ManagedLogGroup, BaseFunction>>, BaseFunction>? LogGroups { get; set; }
            /// <summary>
            /// IngressPaths
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-ecsmanagedresources.html#cfn-ecs-servicerevision-ecsmanagedresources-ingresspaths
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ManagedIngressPath
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECS.ServiceRevisionTypes.ManagedIngressPath>, IReadOnlyList<Union<Humidifier.ECS.ServiceRevisionTypes.ManagedIngressPath, BaseFunction>>, BaseFunction>? IngressPaths { get; set; }
            /// <summary>
            /// ServiceSecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-ecsmanagedresources.html#cfn-ecs-servicerevision-ecsmanagedresources-servicesecuritygroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ManagedSecurityGroup
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECS.ServiceRevisionTypes.ManagedSecurityGroup>, IReadOnlyList<Union<Humidifier.ECS.ServiceRevisionTypes.ManagedSecurityGroup, BaseFunction>>, BaseFunction>? ServiceSecurityGroups { get; set; }
            /// <summary>
            /// MetricAlarms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-ecsmanagedresources.html#cfn-ecs-servicerevision-ecsmanagedresources-metricalarms
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ManagedMetricAlarm
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECS.ServiceRevisionTypes.ManagedMetricAlarm>, IReadOnlyList<Union<Humidifier.ECS.ServiceRevisionTypes.ManagedMetricAlarm, BaseFunction>>, BaseFunction>? MetricAlarms { get; set; }
            /// <summary>
            /// AutoScaling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-ecsmanagedresources.html#cfn-ecs-servicerevision-ecsmanagedresources-autoscaling
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ManagedAutoScaling
            /// </summary>
            public Union<Humidifier.ECS.ServiceRevisionTypes.ManagedAutoScaling, BaseFunction>? AutoScaling { get; set; }
        }

        public class LoadBalancer : Humidifier.Base.BaseSubResource, IHaveTargetGroupArn, IHaveLoadBalancerName, IHaveContainerName, IHaveContainerPort_Integer, IHaveECSServiceRevisionTypesAdvancedConfigurationAdvancedConfiguration
        {
            /// <summary>
            /// TargetGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-loadbalancer.html#cfn-ecs-servicerevision-loadbalancer-targetgrouparn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetGroupArn { get; set; }
            /// <summary>
            /// LoadBalancerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-loadbalancer.html#cfn-ecs-servicerevision-loadbalancer-loadbalancername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LoadBalancerName { get; set; }
            /// <summary>
            /// ContainerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-loadbalancer.html#cfn-ecs-servicerevision-loadbalancer-containername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContainerName { get; set; }
            /// <summary>
            /// ContainerPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-loadbalancer.html#cfn-ecs-servicerevision-loadbalancer-containerport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ContainerPort { get; set; }
            /// <summary>
            /// AdvancedConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-loadbalancer.html#cfn-ecs-servicerevision-loadbalancer-advancedconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AdvancedConfiguration
            /// </summary>
            public Union<Humidifier.ECS.ServiceRevisionTypes.AdvancedConfiguration, BaseFunction>? AdvancedConfiguration { get; set; }
        }

        public class LogConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfECSServiceRevisionTypesSecretSecretOptions, IHaveStringDictionaryOfOptions, IHaveLogDriver
        {
            /// <summary>
            /// SecretOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-logconfiguration.html#cfn-ecs-servicerevision-logconfiguration-secretoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Secret
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECS.ServiceRevisionTypes.Secret>, IReadOnlyList<Union<Humidifier.ECS.ServiceRevisionTypes.Secret, BaseFunction>>, BaseFunction>? SecretOptions { get; set; }
            /// <summary>
            /// Options
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-logconfiguration.html#cfn-ecs-servicerevision-logconfiguration-options
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Options { get; set; }
            /// <summary>
            /// LogDriver
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-logconfiguration.html#cfn-ecs-servicerevision-logconfiguration-logdriver
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogDriver { get; set; }
        }

        public class ManagedApplicationAutoScalingPolicy : Humidifier.Base.BaseSubResource, IHaveStatus, IHavePolicyType, IHaveTargetValue_Double, IHaveStatusReason, IHaveMetric, IHaveArn, IHaveUpdatedAt
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedapplicationautoscalingpolicy.html#cfn-ecs-servicerevision-managedapplicationautoscalingpolicy-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// PolicyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedapplicationautoscalingpolicy.html#cfn-ecs-servicerevision-managedapplicationautoscalingpolicy-policytype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PolicyType { get; set; }
            /// <summary>
            /// TargetValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedapplicationautoscalingpolicy.html#cfn-ecs-servicerevision-managedapplicationautoscalingpolicy-targetvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TargetValue { get; set; }
            /// <summary>
            /// StatusReason
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedapplicationautoscalingpolicy.html#cfn-ecs-servicerevision-managedapplicationautoscalingpolicy-statusreason
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StatusReason { get; set; }
            /// <summary>
            /// Metric
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedapplicationautoscalingpolicy.html#cfn-ecs-servicerevision-managedapplicationautoscalingpolicy-metric
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Metric { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedapplicationautoscalingpolicy.html#cfn-ecs-servicerevision-managedapplicationautoscalingpolicy-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
            /// <summary>
            /// UpdatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedapplicationautoscalingpolicy.html#cfn-ecs-servicerevision-managedapplicationautoscalingpolicy-updatedat
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdatedAt { get; set; }
        }

        public class ManagedAutoScaling : Humidifier.Base.BaseSubResource, IHaveECSServiceRevisionTypesManagedScalableTargetScalableTarget, IHaveListOfECSServiceRevisionTypesManagedApplicationAutoScalingPolicyApplicationAutoScalingPolicies
        {
            /// <summary>
            /// ScalableTarget
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedautoscaling.html#cfn-ecs-servicerevision-managedautoscaling-scalabletarget
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ManagedScalableTarget
            /// </summary>
            public Union<Humidifier.ECS.ServiceRevisionTypes.ManagedScalableTarget, BaseFunction>? ScalableTarget { get; set; }
            /// <summary>
            /// ApplicationAutoScalingPolicies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedautoscaling.html#cfn-ecs-servicerevision-managedautoscaling-applicationautoscalingpolicies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ManagedApplicationAutoScalingPolicy
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECS.ServiceRevisionTypes.ManagedApplicationAutoScalingPolicy>, IReadOnlyList<Union<Humidifier.ECS.ServiceRevisionTypes.ManagedApplicationAutoScalingPolicy, BaseFunction>>, BaseFunction>? ApplicationAutoScalingPolicies { get; set; }
        }

        public class ManagedCertificate : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveDomainName, IHaveStatusReason, IHaveArn, IHaveUpdatedAt
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedcertificate.html#cfn-ecs-servicerevision-managedcertificate-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// DomainName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedcertificate.html#cfn-ecs-servicerevision-managedcertificate-domainname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DomainName { get; set; }
            /// <summary>
            /// StatusReason
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedcertificate.html#cfn-ecs-servicerevision-managedcertificate-statusreason
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StatusReason { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedcertificate.html#cfn-ecs-servicerevision-managedcertificate-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
            /// <summary>
            /// UpdatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedcertificate.html#cfn-ecs-servicerevision-managedcertificate-updatedat
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdatedAt { get; set; }
        }

        public class ManagedIngressPath : Humidifier.Base.BaseSubResource, IHaveECSServiceRevisionTypesManagedListenerListener, IHaveEndpoint, IHaveECSServiceRevisionTypesManagedLoadBalancerLoadBalancer, IHaveListOfECSServiceRevisionTypesManagedSecurityGroupLoadBalancerSecurityGroups, IHaveECSServiceRevisionTypesManagedListenerRuleRule, IHaveAccessType, IHaveListOfECSServiceRevisionTypesManagedTargetGroupTargetGroups, IHaveECSServiceRevisionTypesManagedCertificateCertificate
        {
            /// <summary>
            /// Listener
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedingresspath.html#cfn-ecs-servicerevision-managedingresspath-listener
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ManagedListener
            /// </summary>
            public Union<Humidifier.ECS.ServiceRevisionTypes.ManagedListener, BaseFunction>? Listener { get; set; }
            /// <summary>
            /// Endpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedingresspath.html#cfn-ecs-servicerevision-managedingresspath-endpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Endpoint { get; set; }
            /// <summary>
            /// LoadBalancer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedingresspath.html#cfn-ecs-servicerevision-managedingresspath-loadbalancer
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ManagedLoadBalancer
            /// </summary>
            public Union<Humidifier.ECS.ServiceRevisionTypes.ManagedLoadBalancer, BaseFunction>? LoadBalancer { get; set; }
            /// <summary>
            /// LoadBalancerSecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedingresspath.html#cfn-ecs-servicerevision-managedingresspath-loadbalancersecuritygroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ManagedSecurityGroup
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECS.ServiceRevisionTypes.ManagedSecurityGroup>, IReadOnlyList<Union<Humidifier.ECS.ServiceRevisionTypes.ManagedSecurityGroup, BaseFunction>>, BaseFunction>? LoadBalancerSecurityGroups { get; set; }
            /// <summary>
            /// Rule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedingresspath.html#cfn-ecs-servicerevision-managedingresspath-rule
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ManagedListenerRule
            /// </summary>
            public Union<Humidifier.ECS.ServiceRevisionTypes.ManagedListenerRule, BaseFunction>? Rule { get; set; }
            /// <summary>
            /// AccessType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedingresspath.html#cfn-ecs-servicerevision-managedingresspath-accesstype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccessType { get; set; }
            /// <summary>
            /// TargetGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedingresspath.html#cfn-ecs-servicerevision-managedingresspath-targetgroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ManagedTargetGroup
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECS.ServiceRevisionTypes.ManagedTargetGroup>, IReadOnlyList<Union<Humidifier.ECS.ServiceRevisionTypes.ManagedTargetGroup, BaseFunction>>, BaseFunction>? TargetGroups { get; set; }
            /// <summary>
            /// Certificate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedingresspath.html#cfn-ecs-servicerevision-managedingresspath-certificate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ManagedCertificate
            /// </summary>
            public Union<Humidifier.ECS.ServiceRevisionTypes.ManagedCertificate, BaseFunction>? Certificate { get; set; }
        }

        public class ManagedListener : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveStatusReason, IHaveArn, IHaveUpdatedAt
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedlistener.html#cfn-ecs-servicerevision-managedlistener-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// StatusReason
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedlistener.html#cfn-ecs-servicerevision-managedlistener-statusreason
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StatusReason { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedlistener.html#cfn-ecs-servicerevision-managedlistener-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
            /// <summary>
            /// UpdatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedlistener.html#cfn-ecs-servicerevision-managedlistener-updatedat
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdatedAt { get; set; }
        }

        public class ManagedListenerRule : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveStatusReason, IHaveArn, IHaveUpdatedAt
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedlistenerrule.html#cfn-ecs-servicerevision-managedlistenerrule-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// StatusReason
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedlistenerrule.html#cfn-ecs-servicerevision-managedlistenerrule-statusreason
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StatusReason { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedlistenerrule.html#cfn-ecs-servicerevision-managedlistenerrule-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
            /// <summary>
            /// UpdatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedlistenerrule.html#cfn-ecs-servicerevision-managedlistenerrule-updatedat
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdatedAt { get; set; }
        }

        public class ManagedLoadBalancer : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveScheme, IHaveStatusReason, IHaveArn, IHaveUpdatedAt, IHaveStringListOfSubnetIds, IHaveStringListOfSecurityGroupIds
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedloadbalancer.html#cfn-ecs-servicerevision-managedloadbalancer-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// Scheme
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedloadbalancer.html#cfn-ecs-servicerevision-managedloadbalancer-scheme
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Scheme { get; set; }
            /// <summary>
            /// StatusReason
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedloadbalancer.html#cfn-ecs-servicerevision-managedloadbalancer-statusreason
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StatusReason { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedloadbalancer.html#cfn-ecs-servicerevision-managedloadbalancer-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
            /// <summary>
            /// UpdatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedloadbalancer.html#cfn-ecs-servicerevision-managedloadbalancer-updatedat
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdatedAt { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedloadbalancer.html#cfn-ecs-servicerevision-managedloadbalancer-subnetids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedloadbalancer.html#cfn-ecs-servicerevision-managedloadbalancer-securitygroupids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        }

        public class ManagedLogGroup : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveStatusReason, IHaveLogGroupName, IHaveArn, IHaveUpdatedAt
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedloggroup.html#cfn-ecs-servicerevision-managedloggroup-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// StatusReason
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedloggroup.html#cfn-ecs-servicerevision-managedloggroup-statusreason
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StatusReason { get; set; }
            /// <summary>
            /// LogGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedloggroup.html#cfn-ecs-servicerevision-managedloggroup-loggroupname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogGroupName { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedloggroup.html#cfn-ecs-servicerevision-managedloggroup-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
            /// <summary>
            /// UpdatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedloggroup.html#cfn-ecs-servicerevision-managedloggroup-updatedat
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdatedAt { get; set; }
        }

        public class ManagedMetricAlarm : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveStatusReason, IHaveArn, IHaveUpdatedAt
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedmetricalarm.html#cfn-ecs-servicerevision-managedmetricalarm-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// StatusReason
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedmetricalarm.html#cfn-ecs-servicerevision-managedmetricalarm-statusreason
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StatusReason { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedmetricalarm.html#cfn-ecs-servicerevision-managedmetricalarm-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
            /// <summary>
            /// UpdatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedmetricalarm.html#cfn-ecs-servicerevision-managedmetricalarm-updatedat
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdatedAt { get; set; }
        }

        public class ManagedScalableTarget : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveStatusReason, IHaveArn, IHaveMinCapacity_Integer, IHaveUpdatedAt, IHaveMaxCapacity_Integer
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedscalabletarget.html#cfn-ecs-servicerevision-managedscalabletarget-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// StatusReason
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedscalabletarget.html#cfn-ecs-servicerevision-managedscalabletarget-statusreason
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StatusReason { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedscalabletarget.html#cfn-ecs-servicerevision-managedscalabletarget-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
            /// <summary>
            /// MinCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedscalabletarget.html#cfn-ecs-servicerevision-managedscalabletarget-mincapacity
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinCapacity { get; set; }
            /// <summary>
            /// UpdatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedscalabletarget.html#cfn-ecs-servicerevision-managedscalabletarget-updatedat
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdatedAt { get; set; }
            /// <summary>
            /// MaxCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedscalabletarget.html#cfn-ecs-servicerevision-managedscalabletarget-maxcapacity
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxCapacity { get; set; }
        }

        public class ManagedSecurityGroup : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveArn, IHaveUpdatedAt, IHaveStatusReason
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedsecuritygroup.html#cfn-ecs-servicerevision-managedsecuritygroup-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedsecuritygroup.html#cfn-ecs-servicerevision-managedsecuritygroup-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
            /// <summary>
            /// UpdatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedsecuritygroup.html#cfn-ecs-servicerevision-managedsecuritygroup-updatedat
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdatedAt { get; set; }
            /// <summary>
            /// StatusReason
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedsecuritygroup.html#cfn-ecs-servicerevision-managedsecuritygroup-statusreason
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StatusReason { get; set; }
        }

        public class ManagedTargetGroup : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveStatusReason, IHaveHealthCheckPath, IHavePort_Integer, IHaveHealthCheckPort_Integer, IHaveArn, IHaveUpdatedAt
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedtargetgroup.html#cfn-ecs-servicerevision-managedtargetgroup-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// StatusReason
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedtargetgroup.html#cfn-ecs-servicerevision-managedtargetgroup-statusreason
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StatusReason { get; set; }
            /// <summary>
            /// HealthCheckPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedtargetgroup.html#cfn-ecs-servicerevision-managedtargetgroup-healthcheckpath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HealthCheckPath { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedtargetgroup.html#cfn-ecs-servicerevision-managedtargetgroup-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Port { get; set; }
            /// <summary>
            /// HealthCheckPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedtargetgroup.html#cfn-ecs-servicerevision-managedtargetgroup-healthcheckport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? HealthCheckPort { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedtargetgroup.html#cfn-ecs-servicerevision-managedtargetgroup-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
            /// <summary>
            /// UpdatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedtargetgroup.html#cfn-ecs-servicerevision-managedtargetgroup-updatedat
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdatedAt { get; set; }
        }

        public class MetricConfiguration : Humidifier.Base.BaseSubResource, IHaveResolutionSeconds_Integer, IHaveStringListOfMetricNames
        {
            /// <summary>
            /// ResolutionSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-metricconfiguration.html#cfn-ecs-servicerevision-metricconfiguration-resolutionseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ResolutionSeconds { get; set; }
            /// <summary>
            /// MetricNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-metricconfiguration.html#cfn-ecs-servicerevision-metricconfiguration-metricnames
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? MetricNames { get; set; }
        }

        public class MonitoringConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfECSServiceRevisionTypesMetricConfigurationMetricConfigurations
        {
            /// <summary>
            /// MetricConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-monitoringconfiguration.html#cfn-ecs-servicerevision-monitoringconfiguration-metricconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MetricConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECS.ServiceRevisionTypes.MetricConfiguration>, IReadOnlyList<Union<Humidifier.ECS.ServiceRevisionTypes.MetricConfiguration, BaseFunction>>, BaseFunction>? MetricConfigurations { get; set; }
        }

        public class NetworkConfiguration : Humidifier.Base.BaseSubResource, IHaveECSServiceRevisionTypesAwsVpcConfigurationAwsvpcConfiguration
        {
            /// <summary>
            /// AwsvpcConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-networkconfiguration.html#cfn-ecs-servicerevision-networkconfiguration-awsvpcconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AwsVpcConfiguration
            /// </summary>
            public Union<Humidifier.ECS.ServiceRevisionTypes.AwsVpcConfiguration, BaseFunction>? AwsvpcConfiguration { get; set; }
        }

        public class ResolvedConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfECSServiceRevisionTypesServiceRevisionLoadBalancerLoadBalancers
        {
            /// <summary>
            /// LoadBalancers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-resolvedconfiguration.html#cfn-ecs-servicerevision-resolvedconfiguration-loadbalancers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ServiceRevisionLoadBalancer
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECS.ServiceRevisionTypes.ServiceRevisionLoadBalancer>, IReadOnlyList<Union<Humidifier.ECS.ServiceRevisionTypes.ServiceRevisionLoadBalancer, BaseFunction>>, BaseFunction>? LoadBalancers { get; set; }
        }

        public class Secret : Humidifier.Base.BaseSubResource, IHaveValueFrom, IHaveName
        {
            /// <summary>
            /// ValueFrom
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-secret.html#cfn-ecs-servicerevision-secret-valuefrom
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ValueFrom { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-secret.html#cfn-ecs-servicerevision-secret-name
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceconnectaccesslogconfiguration.html#cfn-ecs-servicerevision-serviceconnectaccesslogconfiguration-format
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Format { get; set; }
            /// <summary>
            /// IncludeQueryParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceconnectaccesslogconfiguration.html#cfn-ecs-servicerevision-serviceconnectaccesslogconfiguration-includequeryparameters
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IncludeQueryParameters { get; set; }
        }

        public class ServiceConnectClientAlias : Humidifier.Base.BaseSubResource, IHaveDnsName, IHaveECSServiceRevisionTypesServiceConnectTestTrafficRulesTestTrafficRules, IHavePort_Integer
        {
            /// <summary>
            /// DnsName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceconnectclientalias.html#cfn-ecs-servicerevision-serviceconnectclientalias-dnsname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DnsName { get; set; }
            /// <summary>
            /// TestTrafficRules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceconnectclientalias.html#cfn-ecs-servicerevision-serviceconnectclientalias-testtrafficrules
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ServiceConnectTestTrafficRules
            /// </summary>
            public Union<Humidifier.ECS.ServiceRevisionTypes.ServiceConnectTestTrafficRules, BaseFunction>? TestTrafficRules { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceconnectclientalias.html#cfn-ecs-servicerevision-serviceconnectclientalias-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Port { get; set; }
        }

        public class ServiceConnectConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfECSServiceRevisionTypesServiceConnectServiceServices, IHaveECSServiceRevisionTypesServiceConnectAccessLogConfigurationAccessLogConfiguration, IHaveEnabled_Boolean, IHaveECSServiceRevisionTypesLogConfigurationLogConfiguration, IHaveNamespace_
        {
            /// <summary>
            /// Services
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceconnectconfiguration.html#cfn-ecs-servicerevision-serviceconnectconfiguration-services
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ServiceConnectService
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECS.ServiceRevisionTypes.ServiceConnectService>, IReadOnlyList<Union<Humidifier.ECS.ServiceRevisionTypes.ServiceConnectService, BaseFunction>>, BaseFunction>? Services { get; set; }
            /// <summary>
            /// AccessLogConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceconnectconfiguration.html#cfn-ecs-servicerevision-serviceconnectconfiguration-accesslogconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ServiceConnectAccessLogConfiguration
            /// </summary>
            public Union<Humidifier.ECS.ServiceRevisionTypes.ServiceConnectAccessLogConfiguration, BaseFunction>? AccessLogConfiguration { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceconnectconfiguration.html#cfn-ecs-servicerevision-serviceconnectconfiguration-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// LogConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceconnectconfiguration.html#cfn-ecs-servicerevision-serviceconnectconfiguration-logconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LogConfiguration
            /// </summary>
            public Union<Humidifier.ECS.ServiceRevisionTypes.LogConfiguration, BaseFunction>? LogConfiguration { get; set; }
            /// <summary>
            /// Namespace_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceconnectconfiguration.html#cfn-ecs-servicerevision-serviceconnectconfiguration-namespace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Namespace_ { get; set; }
        }

        public class ServiceConnectService : Humidifier.Base.BaseSubResource, IHaveECSServiceRevisionTypesTimeoutConfigurationTimeout, IHaveIngressPortOverride_Integer, IHaveListOfECSServiceRevisionTypesServiceConnectClientAliasClientAliases, IHaveECSServiceRevisionTypesServiceConnectTlsConfigurationTls, IHaveDiscoveryName, IHavePortName
        {
            /// <summary>
            /// Timeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceconnectservice.html#cfn-ecs-servicerevision-serviceconnectservice-timeout
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimeoutConfiguration
            /// </summary>
            public Union<Humidifier.ECS.ServiceRevisionTypes.TimeoutConfiguration, BaseFunction>? Timeout { get; set; }
            /// <summary>
            /// IngressPortOverride
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceconnectservice.html#cfn-ecs-servicerevision-serviceconnectservice-ingressportoverride
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? IngressPortOverride { get; set; }
            /// <summary>
            /// ClientAliases
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceconnectservice.html#cfn-ecs-servicerevision-serviceconnectservice-clientaliases
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ServiceConnectClientAlias
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECS.ServiceRevisionTypes.ServiceConnectClientAlias>, IReadOnlyList<Union<Humidifier.ECS.ServiceRevisionTypes.ServiceConnectClientAlias, BaseFunction>>, BaseFunction>? ClientAliases { get; set; }
            /// <summary>
            /// Tls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceconnectservice.html#cfn-ecs-servicerevision-serviceconnectservice-tls
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ServiceConnectTlsConfiguration
            /// </summary>
            public Union<Humidifier.ECS.ServiceRevisionTypes.ServiceConnectTlsConfiguration, BaseFunction>? Tls { get; set; }
            /// <summary>
            /// DiscoveryName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceconnectservice.html#cfn-ecs-servicerevision-serviceconnectservice-discoveryname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DiscoveryName { get; set; }
            /// <summary>
            /// PortName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceconnectservice.html#cfn-ecs-servicerevision-serviceconnectservice-portname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PortName { get; set; }
        }

        public class ServiceConnectTestTrafficHeaderMatchRules : Humidifier.Base.BaseSubResource, IHaveExact
        {
            /// <summary>
            /// Exact
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceconnecttesttrafficheadermatchrules.html#cfn-ecs-servicerevision-serviceconnecttesttrafficheadermatchrules-exact
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Exact { get; set; }
        }

        public class ServiceConnectTestTrafficHeaderRules : Humidifier.Base.BaseSubResource, IHaveECSServiceRevisionTypesServiceConnectTestTrafficHeaderMatchRulesValue, IHaveName
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceconnecttesttrafficheaderrules.html#cfn-ecs-servicerevision-serviceconnecttesttrafficheaderrules-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ServiceConnectTestTrafficHeaderMatchRules
            /// </summary>
            public Union<Humidifier.ECS.ServiceRevisionTypes.ServiceConnectTestTrafficHeaderMatchRules, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceconnecttesttrafficheaderrules.html#cfn-ecs-servicerevision-serviceconnecttesttrafficheaderrules-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class ServiceConnectTestTrafficRules : Humidifier.Base.BaseSubResource, IHaveECSServiceRevisionTypesServiceConnectTestTrafficHeaderRulesHeader
        {
            /// <summary>
            /// Header
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceconnecttesttrafficrules.html#cfn-ecs-servicerevision-serviceconnecttesttrafficrules-header
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ServiceConnectTestTrafficHeaderRules
            /// </summary>
            public Union<Humidifier.ECS.ServiceRevisionTypes.ServiceConnectTestTrafficHeaderRules, BaseFunction>? Header { get; set; }
        }

        public class ServiceConnectTlsCertificateAuthority : Humidifier.Base.BaseSubResource, IHaveAwsPcaAuthorityArn
        {
            /// <summary>
            /// AwsPcaAuthorityArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceconnecttlscertificateauthority.html#cfn-ecs-servicerevision-serviceconnecttlscertificateauthority-awspcaauthorityarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AwsPcaAuthorityArn { get; set; }
        }

        public class ServiceConnectTlsConfiguration : Humidifier.Base.BaseSubResource, IHaveECSServiceRevisionTypesServiceConnectTlsCertificateAuthorityIssuerCertificateAuthority, IHaveKmsKey, IHaveRoleArn
        {
            /// <summary>
            /// IssuerCertificateAuthority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceconnecttlsconfiguration.html#cfn-ecs-servicerevision-serviceconnecttlsconfiguration-issuercertificateauthority
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ServiceConnectTlsCertificateAuthority
            /// </summary>
            public Union<Humidifier.ECS.ServiceRevisionTypes.ServiceConnectTlsCertificateAuthority, BaseFunction>? IssuerCertificateAuthority { get; set; }
            /// <summary>
            /// KmsKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceconnecttlsconfiguration.html#cfn-ecs-servicerevision-serviceconnecttlsconfiguration-kmskey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKey { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceconnecttlsconfiguration.html#cfn-ecs-servicerevision-serviceconnecttlsconfiguration-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class ServiceManagedEBSVolumeConfiguration : Humidifier.Base.BaseSubResource, IHaveSnapshotId, IHaveVolumeType, IHaveKmsKeyId, IHaveListOfECSServiceRevisionTypesEBSTagSpecificationTagSpecifications, IHaveFilesystemType, IHaveEncrypted_Boolean, IHaveThroughput_Integer, IHaveVolumeInitializationRate_Integer, IHaveIops_Integer, IHaveSizeInGiB_Integer, IHaveRoleArn
        {
            /// <summary>
            /// SnapshotId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-servicemanagedebsvolumeconfiguration.html#cfn-ecs-servicerevision-servicemanagedebsvolumeconfiguration-snapshotid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SnapshotId { get; set; }
            /// <summary>
            /// VolumeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-servicemanagedebsvolumeconfiguration.html#cfn-ecs-servicerevision-servicemanagedebsvolumeconfiguration-volumetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VolumeType { get; set; }
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-servicemanagedebsvolumeconfiguration.html#cfn-ecs-servicerevision-servicemanagedebsvolumeconfiguration-kmskeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
            /// <summary>
            /// TagSpecifications
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-servicemanagedebsvolumeconfiguration.html#cfn-ecs-servicerevision-servicemanagedebsvolumeconfiguration-tagspecifications
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EBSTagSpecification
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ECS.ServiceRevisionTypes.EBSTagSpecification>, IReadOnlyList<Union<Humidifier.ECS.ServiceRevisionTypes.EBSTagSpecification, BaseFunction>>, BaseFunction>? TagSpecifications { get; set; }
            /// <summary>
            /// FilesystemType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-servicemanagedebsvolumeconfiguration.html#cfn-ecs-servicerevision-servicemanagedebsvolumeconfiguration-filesystemtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FilesystemType { get; set; }
            /// <summary>
            /// Encrypted
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-servicemanagedebsvolumeconfiguration.html#cfn-ecs-servicerevision-servicemanagedebsvolumeconfiguration-encrypted
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Encrypted { get; set; }
            /// <summary>
            /// Throughput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-servicemanagedebsvolumeconfiguration.html#cfn-ecs-servicerevision-servicemanagedebsvolumeconfiguration-throughput
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Throughput { get; set; }
            /// <summary>
            /// VolumeInitializationRate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-servicemanagedebsvolumeconfiguration.html#cfn-ecs-servicerevision-servicemanagedebsvolumeconfiguration-volumeinitializationrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? VolumeInitializationRate { get; set; }
            /// <summary>
            /// Iops
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-servicemanagedebsvolumeconfiguration.html#cfn-ecs-servicerevision-servicemanagedebsvolumeconfiguration-iops
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Iops { get; set; }
            /// <summary>
            /// SizeInGiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-servicemanagedebsvolumeconfiguration.html#cfn-ecs-servicerevision-servicemanagedebsvolumeconfiguration-sizeingib
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SizeInGiB { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-servicemanagedebsvolumeconfiguration.html#cfn-ecs-servicerevision-servicemanagedebsvolumeconfiguration-rolearn
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceregistry.html#cfn-ecs-servicerevision-serviceregistry-containername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContainerName { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceregistry.html#cfn-ecs-servicerevision-serviceregistry-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Port { get; set; }
            /// <summary>
            /// ContainerPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceregistry.html#cfn-ecs-servicerevision-serviceregistry-containerport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ContainerPort { get; set; }
            /// <summary>
            /// RegistryArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceregistry.html#cfn-ecs-servicerevision-serviceregistry-registryarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RegistryArn { get; set; }
        }

        public class ServiceRevisionLoadBalancer : Humidifier.Base.BaseSubResource, IHaveTargetGroupArn, IHaveProductionListenerRule
        {
            /// <summary>
            /// TargetGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-servicerevisionloadbalancer.html#cfn-ecs-servicerevision-servicerevisionloadbalancer-targetgrouparn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetGroupArn { get; set; }
            /// <summary>
            /// ProductionListenerRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-servicerevisionloadbalancer.html#cfn-ecs-servicerevision-servicerevisionloadbalancer-productionlistenerrule
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProductionListenerRule { get; set; }
        }

        public class ServiceVolumeConfiguration : Humidifier.Base.BaseSubResource, IHaveECSServiceRevisionTypesServiceManagedEBSVolumeConfigurationManagedEBSVolume, IHaveName
        {
            /// <summary>
            /// ManagedEBSVolume
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-servicevolumeconfiguration.html#cfn-ecs-servicerevision-servicevolumeconfiguration-managedebsvolume
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ServiceManagedEBSVolumeConfiguration
            /// </summary>
            public Union<Humidifier.ECS.ServiceRevisionTypes.ServiceManagedEBSVolumeConfiguration, BaseFunction>? ManagedEBSVolume { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-servicevolumeconfiguration.html#cfn-ecs-servicerevision-servicevolumeconfiguration-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class TimeoutConfiguration : Humidifier.Base.BaseSubResource, IHavePerRequestTimeoutSeconds_Integer, IHaveIdleTimeoutSeconds_Integer
        {
            /// <summary>
            /// PerRequestTimeoutSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-timeoutconfiguration.html#cfn-ecs-servicerevision-timeoutconfiguration-perrequesttimeoutseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? PerRequestTimeoutSeconds { get; set; }
            /// <summary>
            /// IdleTimeoutSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-timeoutconfiguration.html#cfn-ecs-servicerevision-timeoutconfiguration-idletimeoutseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? IdleTimeoutSeconds { get; set; }
        }

        public class VpcLatticeConfiguration : Humidifier.Base.BaseSubResource, IHaveTargetGroupArn, IHavePortName, IHaveRoleArn
        {
            /// <summary>
            /// TargetGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-vpclatticeconfiguration.html#cfn-ecs-servicerevision-vpclatticeconfiguration-targetgrouparn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetGroupArn { get; set; }
            /// <summary>
            /// PortName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-vpclatticeconfiguration.html#cfn-ecs-servicerevision-vpclatticeconfiguration-portname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PortName { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-vpclatticeconfiguration.html#cfn-ecs-servicerevision-vpclatticeconfiguration-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }
    }
}