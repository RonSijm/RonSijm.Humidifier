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
        public class AdvancedConfiguration : Humidifier.Base.BaseSubResource, IHaveRoleArn
        {
            /// <summary>
            /// TestListenerRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-advancedconfiguration.html#cfn-ecs-servicerevision-advancedconfiguration-testlistenerrule
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TestListenerRule { get; set; }
            /// <summary>
            /// AlternateTargetGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-advancedconfiguration.html#cfn-ecs-servicerevision-advancedconfiguration-alternatetargetgrouparn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AlternateTargetGroupArn { get; set; }
            /// <summary>
            /// ProductionListenerRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-advancedconfiguration.html#cfn-ecs-servicerevision-advancedconfiguration-productionlistenerrule
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ProductionListenerRule { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-advancedconfiguration.html#cfn-ecs-servicerevision-advancedconfiguration-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn { get; set; }
        }

        public class AwsVpcConfiguration : Humidifier.Base.BaseSubResource, IHaveSubnets, IHaveSecurityGroups, IHaveAssignPublicIp
        {
            /// <summary>
            /// SecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-awsvpcconfiguration.html#cfn-ecs-servicerevision-awsvpcconfiguration-securitygroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroups { get; set; }
            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-awsvpcconfiguration.html#cfn-ecs-servicerevision-awsvpcconfiguration-subnets
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Subnets { get; set; }
            /// <summary>
            /// AssignPublicIp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-awsvpcconfiguration.html#cfn-ecs-servicerevision-awsvpcconfiguration-assignpublicip
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AssignPublicIp { get; set; }
        }

        public class CapacityProviderStrategyItem : Humidifier.Base.BaseSubResource, IHaveWeight, IHaveBase, IHaveCapacityProvider
        {
            /// <summary>
            /// CapacityProvider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-capacityproviderstrategyitem.html#cfn-ecs-servicerevision-capacityproviderstrategyitem-capacityprovider
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CapacityProvider { get; set; }
            /// <summary>
            /// Weight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-capacityproviderstrategyitem.html#cfn-ecs-servicerevision-capacityproviderstrategyitem-weight
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Weight { get; set; }
            /// <summary>
            /// Base
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-capacityproviderstrategyitem.html#cfn-ecs-servicerevision-capacityproviderstrategyitem-base
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Base { get; set; }
        }

        public class ContainerImage : Humidifier.Base.BaseSubResource, IHaveContainerName, IHaveImage
        {
            /// <summary>
            /// ContainerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-containerimage.html#cfn-ecs-servicerevision-containerimage-containername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContainerName { get; set; }
            /// <summary>
            /// ImageDigest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-containerimage.html#cfn-ecs-servicerevision-containerimage-imagedigest
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ImageDigest { get; set; }
            /// <summary>
            /// Image
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-containerimage.html#cfn-ecs-servicerevision-containerimage-image
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Image { get; set; }
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
            public dynamic KmsKeyId { get; set; }
        }

        public class EBSTagSpecification : Humidifier.Base.BaseSubResource, IHaveTags, IHaveResourceType, IHavePropagateTags
        {
            /// <summary>
            /// PropagateTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-ebstagspecification.html#cfn-ecs-servicerevision-ebstagspecification-propagatetags
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PropagateTags { get; set; }
            /// <summary>
            /// ResourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-ebstagspecification.html#cfn-ecs-servicerevision-ebstagspecification-resourcetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResourceType { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-ebstagspecification.html#cfn-ecs-servicerevision-ebstagspecification-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public List<Humidifier.Tag> Tags { get; set; }
        }

        public class EcsManagedResources : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LogGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-ecsmanagedresources.html#cfn-ecs-servicerevision-ecsmanagedresources-loggroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ManagedLogGroup
            /// </summary>
            public List<Humidifier.ECS.ServiceRevisionTypes.ManagedLogGroup> LogGroups { get; set; }
            /// <summary>
            /// IngressPaths
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-ecsmanagedresources.html#cfn-ecs-servicerevision-ecsmanagedresources-ingresspaths
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ManagedIngressPath
            /// </summary>
            public List<Humidifier.ECS.ServiceRevisionTypes.ManagedIngressPath> IngressPaths { get; set; }
            /// <summary>
            /// ServiceSecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-ecsmanagedresources.html#cfn-ecs-servicerevision-ecsmanagedresources-servicesecuritygroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ManagedSecurityGroup
            /// </summary>
            public List<Humidifier.ECS.ServiceRevisionTypes.ManagedSecurityGroup> ServiceSecurityGroups { get; set; }
            /// <summary>
            /// MetricAlarms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-ecsmanagedresources.html#cfn-ecs-servicerevision-ecsmanagedresources-metricalarms
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ManagedMetricAlarm
            /// </summary>
            public List<Humidifier.ECS.ServiceRevisionTypes.ManagedMetricAlarm> MetricAlarms { get; set; }
            /// <summary>
            /// AutoScaling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-ecsmanagedresources.html#cfn-ecs-servicerevision-ecsmanagedresources-autoscaling
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ManagedAutoScaling
            /// </summary>
            public Humidifier.ECS.ServiceRevisionTypes.ManagedAutoScaling AutoScaling { get; set; }
        }

        public class LoadBalancer : Humidifier.Base.BaseSubResource, IHaveContainerName, IHaveTargetGroupArn, IHaveContainerPort, IHaveLoadBalancerName
        {
            /// <summary>
            /// TargetGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-loadbalancer.html#cfn-ecs-servicerevision-loadbalancer-targetgrouparn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetGroupArn { get; set; }
            /// <summary>
            /// LoadBalancerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-loadbalancer.html#cfn-ecs-servicerevision-loadbalancer-loadbalancername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LoadBalancerName { get; set; }
            /// <summary>
            /// ContainerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-loadbalancer.html#cfn-ecs-servicerevision-loadbalancer-containername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContainerName { get; set; }
            /// <summary>
            /// ContainerPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-loadbalancer.html#cfn-ecs-servicerevision-loadbalancer-containerport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ContainerPort { get; set; }
            /// <summary>
            /// AdvancedConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-loadbalancer.html#cfn-ecs-servicerevision-loadbalancer-advancedconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AdvancedConfiguration
            /// </summary>
            public Humidifier.ECS.ServiceRevisionTypes.AdvancedConfiguration AdvancedConfiguration { get; set; }
        }

        public class LogConfiguration : Humidifier.Base.BaseSubResource, IHaveLogDriver
        {
            /// <summary>
            /// SecretOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-logconfiguration.html#cfn-ecs-servicerevision-logconfiguration-secretoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Secret
            /// </summary>
            public List<Humidifier.ECS.ServiceRevisionTypes.Secret> SecretOptions { get; set; }
            /// <summary>
            /// Options
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-logconfiguration.html#cfn-ecs-servicerevision-logconfiguration-options
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> Options { get; set; }
            /// <summary>
            /// LogDriver
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-logconfiguration.html#cfn-ecs-servicerevision-logconfiguration-logdriver
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogDriver { get; set; }
        }

        public class ManagedApplicationAutoScalingPolicy : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveArn, IHaveTargetValue, IHavePolicyType, IHaveMetric
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedapplicationautoscalingpolicy.html#cfn-ecs-servicerevision-managedapplicationautoscalingpolicy-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// PolicyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedapplicationautoscalingpolicy.html#cfn-ecs-servicerevision-managedapplicationautoscalingpolicy-policytype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PolicyType { get; set; }
            /// <summary>
            /// TargetValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedapplicationautoscalingpolicy.html#cfn-ecs-servicerevision-managedapplicationautoscalingpolicy-targetvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TargetValue { get; set; }
            /// <summary>
            /// StatusReason
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedapplicationautoscalingpolicy.html#cfn-ecs-servicerevision-managedapplicationautoscalingpolicy-statusreason
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StatusReason { get; set; }
            /// <summary>
            /// Metric
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedapplicationautoscalingpolicy.html#cfn-ecs-servicerevision-managedapplicationautoscalingpolicy-metric
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Metric { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedapplicationautoscalingpolicy.html#cfn-ecs-servicerevision-managedapplicationautoscalingpolicy-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
            /// <summary>
            /// UpdatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedapplicationautoscalingpolicy.html#cfn-ecs-servicerevision-managedapplicationautoscalingpolicy-updatedat
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdatedAt { get; set; }
        }

        public class ManagedAutoScaling : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ScalableTarget
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedautoscaling.html#cfn-ecs-servicerevision-managedautoscaling-scalabletarget
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ManagedScalableTarget
            /// </summary>
            public Humidifier.ECS.ServiceRevisionTypes.ManagedScalableTarget ScalableTarget { get; set; }
            /// <summary>
            /// ApplicationAutoScalingPolicies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedautoscaling.html#cfn-ecs-servicerevision-managedautoscaling-applicationautoscalingpolicies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ManagedApplicationAutoScalingPolicy
            /// </summary>
            public List<Humidifier.ECS.ServiceRevisionTypes.ManagedApplicationAutoScalingPolicy> ApplicationAutoScalingPolicies { get; set; }
        }

        public class ManagedCertificate : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveArn, IHaveDomainName
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedcertificate.html#cfn-ecs-servicerevision-managedcertificate-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// DomainName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedcertificate.html#cfn-ecs-servicerevision-managedcertificate-domainname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DomainName { get; set; }
            /// <summary>
            /// StatusReason
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedcertificate.html#cfn-ecs-servicerevision-managedcertificate-statusreason
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StatusReason { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedcertificate.html#cfn-ecs-servicerevision-managedcertificate-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
            /// <summary>
            /// UpdatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedcertificate.html#cfn-ecs-servicerevision-managedcertificate-updatedat
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdatedAt { get; set; }
        }

        public class ManagedIngressPath : Humidifier.Base.BaseSubResource, IHaveEndpoint, IHaveAccessType
        {
            /// <summary>
            /// Listener
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedingresspath.html#cfn-ecs-servicerevision-managedingresspath-listener
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ManagedListener
            /// </summary>
            public Humidifier.ECS.ServiceRevisionTypes.ManagedListener Listener { get; set; }
            /// <summary>
            /// Endpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedingresspath.html#cfn-ecs-servicerevision-managedingresspath-endpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Endpoint { get; set; }
            /// <summary>
            /// LoadBalancer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedingresspath.html#cfn-ecs-servicerevision-managedingresspath-loadbalancer
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ManagedLoadBalancer
            /// </summary>
            public Humidifier.ECS.ServiceRevisionTypes.ManagedLoadBalancer LoadBalancer { get; set; }
            /// <summary>
            /// LoadBalancerSecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedingresspath.html#cfn-ecs-servicerevision-managedingresspath-loadbalancersecuritygroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ManagedSecurityGroup
            /// </summary>
            public List<Humidifier.ECS.ServiceRevisionTypes.ManagedSecurityGroup> LoadBalancerSecurityGroups { get; set; }
            /// <summary>
            /// Rule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedingresspath.html#cfn-ecs-servicerevision-managedingresspath-rule
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ManagedListenerRule
            /// </summary>
            public Humidifier.ECS.ServiceRevisionTypes.ManagedListenerRule Rule { get; set; }
            /// <summary>
            /// AccessType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedingresspath.html#cfn-ecs-servicerevision-managedingresspath-accesstype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AccessType { get; set; }
            /// <summary>
            /// TargetGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedingresspath.html#cfn-ecs-servicerevision-managedingresspath-targetgroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ManagedTargetGroup
            /// </summary>
            public List<Humidifier.ECS.ServiceRevisionTypes.ManagedTargetGroup> TargetGroups { get; set; }
            /// <summary>
            /// Certificate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedingresspath.html#cfn-ecs-servicerevision-managedingresspath-certificate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ManagedCertificate
            /// </summary>
            public Humidifier.ECS.ServiceRevisionTypes.ManagedCertificate Certificate { get; set; }
        }

        public class ManagedListener : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveArn
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedlistener.html#cfn-ecs-servicerevision-managedlistener-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// StatusReason
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedlistener.html#cfn-ecs-servicerevision-managedlistener-statusreason
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StatusReason { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedlistener.html#cfn-ecs-servicerevision-managedlistener-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
            /// <summary>
            /// UpdatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedlistener.html#cfn-ecs-servicerevision-managedlistener-updatedat
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdatedAt { get; set; }
        }

        public class ManagedListenerRule : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveArn
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedlistenerrule.html#cfn-ecs-servicerevision-managedlistenerrule-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// StatusReason
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedlistenerrule.html#cfn-ecs-servicerevision-managedlistenerrule-statusreason
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StatusReason { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedlistenerrule.html#cfn-ecs-servicerevision-managedlistenerrule-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
            /// <summary>
            /// UpdatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedlistenerrule.html#cfn-ecs-servicerevision-managedlistenerrule-updatedat
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdatedAt { get; set; }
        }

        public class ManagedLoadBalancer : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveSecurityGroupIds, IHaveSubnetIds, IHaveArn, IHaveScheme
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedloadbalancer.html#cfn-ecs-servicerevision-managedloadbalancer-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// Scheme
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedloadbalancer.html#cfn-ecs-servicerevision-managedloadbalancer-scheme
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Scheme { get; set; }
            /// <summary>
            /// StatusReason
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedloadbalancer.html#cfn-ecs-servicerevision-managedloadbalancer-statusreason
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StatusReason { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedloadbalancer.html#cfn-ecs-servicerevision-managedloadbalancer-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
            /// <summary>
            /// UpdatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedloadbalancer.html#cfn-ecs-servicerevision-managedloadbalancer-updatedat
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdatedAt { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedloadbalancer.html#cfn-ecs-servicerevision-managedloadbalancer-subnetids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SubnetIds { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedloadbalancer.html#cfn-ecs-servicerevision-managedloadbalancer-securitygroupids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroupIds { get; set; }
        }

        public class ManagedLogGroup : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveArn, IHaveLogGroupName
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedloggroup.html#cfn-ecs-servicerevision-managedloggroup-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// StatusReason
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedloggroup.html#cfn-ecs-servicerevision-managedloggroup-statusreason
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StatusReason { get; set; }
            /// <summary>
            /// LogGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedloggroup.html#cfn-ecs-servicerevision-managedloggroup-loggroupname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogGroupName { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedloggroup.html#cfn-ecs-servicerevision-managedloggroup-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
            /// <summary>
            /// UpdatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedloggroup.html#cfn-ecs-servicerevision-managedloggroup-updatedat
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdatedAt { get; set; }
        }

        public class ManagedMetricAlarm : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveArn
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedmetricalarm.html#cfn-ecs-servicerevision-managedmetricalarm-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// StatusReason
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedmetricalarm.html#cfn-ecs-servicerevision-managedmetricalarm-statusreason
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StatusReason { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedmetricalarm.html#cfn-ecs-servicerevision-managedmetricalarm-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
            /// <summary>
            /// UpdatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedmetricalarm.html#cfn-ecs-servicerevision-managedmetricalarm-updatedat
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdatedAt { get; set; }
        }

        public class ManagedScalableTarget : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveArn, IHaveMaxCapacity, IHaveMinCapacity
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedscalabletarget.html#cfn-ecs-servicerevision-managedscalabletarget-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// StatusReason
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedscalabletarget.html#cfn-ecs-servicerevision-managedscalabletarget-statusreason
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StatusReason { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedscalabletarget.html#cfn-ecs-servicerevision-managedscalabletarget-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
            /// <summary>
            /// MinCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedscalabletarget.html#cfn-ecs-servicerevision-managedscalabletarget-mincapacity
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinCapacity { get; set; }
            /// <summary>
            /// UpdatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedscalabletarget.html#cfn-ecs-servicerevision-managedscalabletarget-updatedat
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdatedAt { get; set; }
            /// <summary>
            /// MaxCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedscalabletarget.html#cfn-ecs-servicerevision-managedscalabletarget-maxcapacity
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxCapacity { get; set; }
        }

        public class ManagedSecurityGroup : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveArn
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedsecuritygroup.html#cfn-ecs-servicerevision-managedsecuritygroup-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedsecuritygroup.html#cfn-ecs-servicerevision-managedsecuritygroup-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
            /// <summary>
            /// UpdatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedsecuritygroup.html#cfn-ecs-servicerevision-managedsecuritygroup-updatedat
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdatedAt { get; set; }
            /// <summary>
            /// StatusReason
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedsecuritygroup.html#cfn-ecs-servicerevision-managedsecuritygroup-statusreason
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StatusReason { get; set; }
        }

        public class ManagedTargetGroup : Humidifier.Base.BaseSubResource, IHaveStatus, IHavePort, IHaveArn, IHaveHealthCheckPath, IHaveHealthCheckPort
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedtargetgroup.html#cfn-ecs-servicerevision-managedtargetgroup-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// StatusReason
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedtargetgroup.html#cfn-ecs-servicerevision-managedtargetgroup-statusreason
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StatusReason { get; set; }
            /// <summary>
            /// HealthCheckPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedtargetgroup.html#cfn-ecs-servicerevision-managedtargetgroup-healthcheckpath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HealthCheckPath { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedtargetgroup.html#cfn-ecs-servicerevision-managedtargetgroup-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Port { get; set; }
            /// <summary>
            /// HealthCheckPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedtargetgroup.html#cfn-ecs-servicerevision-managedtargetgroup-healthcheckport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic HealthCheckPort { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedtargetgroup.html#cfn-ecs-servicerevision-managedtargetgroup-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
            /// <summary>
            /// UpdatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-managedtargetgroup.html#cfn-ecs-servicerevision-managedtargetgroup-updatedat
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdatedAt { get; set; }
        }

        public class MetricConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ResolutionSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-metricconfiguration.html#cfn-ecs-servicerevision-metricconfiguration-resolutionseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ResolutionSeconds { get; set; }
            /// <summary>
            /// MetricNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-metricconfiguration.html#cfn-ecs-servicerevision-metricconfiguration-metricnames
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic MetricNames { get; set; }
        }

        public class MonitoringConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MetricConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-monitoringconfiguration.html#cfn-ecs-servicerevision-monitoringconfiguration-metricconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MetricConfiguration
            /// </summary>
            public List<Humidifier.ECS.ServiceRevisionTypes.MetricConfiguration> MetricConfigurations { get; set; }
        }

        public class NetworkConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AwsvpcConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-networkconfiguration.html#cfn-ecs-servicerevision-networkconfiguration-awsvpcconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AwsVpcConfiguration
            /// </summary>
            public Humidifier.ECS.ServiceRevisionTypes.AwsVpcConfiguration AwsvpcConfiguration { get; set; }
        }

        public class ResolvedConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LoadBalancers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-resolvedconfiguration.html#cfn-ecs-servicerevision-resolvedconfiguration-loadbalancers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ServiceRevisionLoadBalancer
            /// </summary>
            public List<Humidifier.ECS.ServiceRevisionTypes.ServiceRevisionLoadBalancer> LoadBalancers { get; set; }
        }

        public class Secret : Humidifier.Base.BaseSubResource, IHaveName, IHaveValueFrom
        {
            /// <summary>
            /// ValueFrom
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-secret.html#cfn-ecs-servicerevision-secret-valuefrom
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ValueFrom { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-secret.html#cfn-ecs-servicerevision-secret-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class ServiceConnectAccessLogConfiguration : Humidifier.Base.BaseSubResource, IHaveFormat
        {
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceconnectaccesslogconfiguration.html#cfn-ecs-servicerevision-serviceconnectaccesslogconfiguration-format
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Format { get; set; }
            /// <summary>
            /// IncludeQueryParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceconnectaccesslogconfiguration.html#cfn-ecs-servicerevision-serviceconnectaccesslogconfiguration-includequeryparameters
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IncludeQueryParameters { get; set; }
        }

        public class ServiceConnectClientAlias : Humidifier.Base.BaseSubResource, IHavePort, IHaveDnsName
        {
            /// <summary>
            /// DnsName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceconnectclientalias.html#cfn-ecs-servicerevision-serviceconnectclientalias-dnsname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DnsName { get; set; }
            /// <summary>
            /// TestTrafficRules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceconnectclientalias.html#cfn-ecs-servicerevision-serviceconnectclientalias-testtrafficrules
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ServiceConnectTestTrafficRules
            /// </summary>
            public Humidifier.ECS.ServiceRevisionTypes.ServiceConnectTestTrafficRules TestTrafficRules { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceconnectclientalias.html#cfn-ecs-servicerevision-serviceconnectclientalias-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Port { get; set; }
        }

        public class ServiceConnectConfiguration : Humidifier.Base.BaseSubResource, IHaveEnabled, IHaveNamespace_
        {
            /// <summary>
            /// Services
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceconnectconfiguration.html#cfn-ecs-servicerevision-serviceconnectconfiguration-services
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ServiceConnectService
            /// </summary>
            public List<Humidifier.ECS.ServiceRevisionTypes.ServiceConnectService> Services { get; set; }
            /// <summary>
            /// AccessLogConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceconnectconfiguration.html#cfn-ecs-servicerevision-serviceconnectconfiguration-accesslogconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ServiceConnectAccessLogConfiguration
            /// </summary>
            public Humidifier.ECS.ServiceRevisionTypes.ServiceConnectAccessLogConfiguration AccessLogConfiguration { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceconnectconfiguration.html#cfn-ecs-servicerevision-serviceconnectconfiguration-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
            /// <summary>
            /// LogConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceconnectconfiguration.html#cfn-ecs-servicerevision-serviceconnectconfiguration-logconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LogConfiguration
            /// </summary>
            public Humidifier.ECS.ServiceRevisionTypes.LogConfiguration LogConfiguration { get; set; }
            /// <summary>
            /// Namespace_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceconnectconfiguration.html#cfn-ecs-servicerevision-serviceconnectconfiguration-namespace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Namespace_ { get; set; }
        }

        public class ServiceConnectService : Humidifier.Base.BaseSubResource, IHavePortName
        {
            /// <summary>
            /// Timeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceconnectservice.html#cfn-ecs-servicerevision-serviceconnectservice-timeout
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimeoutConfiguration
            /// </summary>
            public Humidifier.ECS.ServiceRevisionTypes.TimeoutConfiguration Timeout { get; set; }
            /// <summary>
            /// IngressPortOverride
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceconnectservice.html#cfn-ecs-servicerevision-serviceconnectservice-ingressportoverride
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic IngressPortOverride { get; set; }
            /// <summary>
            /// ClientAliases
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceconnectservice.html#cfn-ecs-servicerevision-serviceconnectservice-clientaliases
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ServiceConnectClientAlias
            /// </summary>
            public List<Humidifier.ECS.ServiceRevisionTypes.ServiceConnectClientAlias> ClientAliases { get; set; }
            /// <summary>
            /// Tls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceconnectservice.html#cfn-ecs-servicerevision-serviceconnectservice-tls
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ServiceConnectTlsConfiguration
            /// </summary>
            public Humidifier.ECS.ServiceRevisionTypes.ServiceConnectTlsConfiguration Tls { get; set; }
            /// <summary>
            /// DiscoveryName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceconnectservice.html#cfn-ecs-servicerevision-serviceconnectservice-discoveryname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DiscoveryName { get; set; }
            /// <summary>
            /// PortName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceconnectservice.html#cfn-ecs-servicerevision-serviceconnectservice-portname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PortName { get; set; }
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
            public dynamic Exact { get; set; }
        }

        public class ServiceConnectTestTrafficHeaderRules : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceconnecttesttrafficheaderrules.html#cfn-ecs-servicerevision-serviceconnecttesttrafficheaderrules-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ServiceConnectTestTrafficHeaderMatchRules
            /// </summary>
            public Humidifier.ECS.ServiceRevisionTypes.ServiceConnectTestTrafficHeaderMatchRules Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceconnecttesttrafficheaderrules.html#cfn-ecs-servicerevision-serviceconnecttesttrafficheaderrules-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class ServiceConnectTestTrafficRules : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Header
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceconnecttesttrafficrules.html#cfn-ecs-servicerevision-serviceconnecttesttrafficrules-header
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ServiceConnectTestTrafficHeaderRules
            /// </summary>
            public Humidifier.ECS.ServiceRevisionTypes.ServiceConnectTestTrafficHeaderRules Header { get; set; }
        }

        public class ServiceConnectTlsCertificateAuthority : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AwsPcaAuthorityArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceconnecttlscertificateauthority.html#cfn-ecs-servicerevision-serviceconnecttlscertificateauthority-awspcaauthorityarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AwsPcaAuthorityArn { get; set; }
        }

        public class ServiceConnectTlsConfiguration : Humidifier.Base.BaseSubResource, IHaveRoleArn, IHaveKmsKey
        {
            /// <summary>
            /// IssuerCertificateAuthority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceconnecttlsconfiguration.html#cfn-ecs-servicerevision-serviceconnecttlsconfiguration-issuercertificateauthority
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ServiceConnectTlsCertificateAuthority
            /// </summary>
            public Humidifier.ECS.ServiceRevisionTypes.ServiceConnectTlsCertificateAuthority IssuerCertificateAuthority { get; set; }
            /// <summary>
            /// KmsKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceconnecttlsconfiguration.html#cfn-ecs-servicerevision-serviceconnecttlsconfiguration-kmskey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKey { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceconnecttlsconfiguration.html#cfn-ecs-servicerevision-serviceconnecttlsconfiguration-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn { get; set; }
        }

        public class ServiceManagedEBSVolumeConfiguration : Humidifier.Base.BaseSubResource, IHaveRoleArn, IHaveKmsKeyId, IHaveIops, IHaveVolumeType, IHaveEncrypted, IHaveThroughput, IHaveSnapshotId, IHaveSizeInGiB
        {
            /// <summary>
            /// SnapshotId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-servicemanagedebsvolumeconfiguration.html#cfn-ecs-servicerevision-servicemanagedebsvolumeconfiguration-snapshotid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SnapshotId { get; set; }
            /// <summary>
            /// VolumeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-servicemanagedebsvolumeconfiguration.html#cfn-ecs-servicerevision-servicemanagedebsvolumeconfiguration-volumetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VolumeType { get; set; }
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-servicemanagedebsvolumeconfiguration.html#cfn-ecs-servicerevision-servicemanagedebsvolumeconfiguration-kmskeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKeyId { get; set; }
            /// <summary>
            /// TagSpecifications
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-servicemanagedebsvolumeconfiguration.html#cfn-ecs-servicerevision-servicemanagedebsvolumeconfiguration-tagspecifications
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EBSTagSpecification
            /// </summary>
            public List<Humidifier.ECS.ServiceRevisionTypes.EBSTagSpecification> TagSpecifications { get; set; }
            /// <summary>
            /// FilesystemType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-servicemanagedebsvolumeconfiguration.html#cfn-ecs-servicerevision-servicemanagedebsvolumeconfiguration-filesystemtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilesystemType { get; set; }
            /// <summary>
            /// Encrypted
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-servicemanagedebsvolumeconfiguration.html#cfn-ecs-servicerevision-servicemanagedebsvolumeconfiguration-encrypted
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Encrypted { get; set; }
            /// <summary>
            /// Throughput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-servicemanagedebsvolumeconfiguration.html#cfn-ecs-servicerevision-servicemanagedebsvolumeconfiguration-throughput
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Throughput { get; set; }
            /// <summary>
            /// VolumeInitializationRate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-servicemanagedebsvolumeconfiguration.html#cfn-ecs-servicerevision-servicemanagedebsvolumeconfiguration-volumeinitializationrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic VolumeInitializationRate { get; set; }
            /// <summary>
            /// Iops
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-servicemanagedebsvolumeconfiguration.html#cfn-ecs-servicerevision-servicemanagedebsvolumeconfiguration-iops
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Iops { get; set; }
            /// <summary>
            /// SizeInGiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-servicemanagedebsvolumeconfiguration.html#cfn-ecs-servicerevision-servicemanagedebsvolumeconfiguration-sizeingib
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic SizeInGiB { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-servicemanagedebsvolumeconfiguration.html#cfn-ecs-servicerevision-servicemanagedebsvolumeconfiguration-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn { get; set; }
        }

        public class ServiceRegistry : Humidifier.Base.BaseSubResource, IHavePort, IHaveContainerName, IHaveContainerPort, IHaveRegistryArn
        {
            /// <summary>
            /// ContainerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceregistry.html#cfn-ecs-servicerevision-serviceregistry-containername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContainerName { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceregistry.html#cfn-ecs-servicerevision-serviceregistry-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Port { get; set; }
            /// <summary>
            /// ContainerPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceregistry.html#cfn-ecs-servicerevision-serviceregistry-containerport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ContainerPort { get; set; }
            /// <summary>
            /// RegistryArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-serviceregistry.html#cfn-ecs-servicerevision-serviceregistry-registryarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RegistryArn { get; set; }
        }

        public class ServiceRevisionLoadBalancer : Humidifier.Base.BaseSubResource, IHaveTargetGroupArn
        {
            /// <summary>
            /// TargetGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-servicerevisionloadbalancer.html#cfn-ecs-servicerevision-servicerevisionloadbalancer-targetgrouparn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetGroupArn { get; set; }
            /// <summary>
            /// ProductionListenerRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-servicerevisionloadbalancer.html#cfn-ecs-servicerevision-servicerevisionloadbalancer-productionlistenerrule
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ProductionListenerRule { get; set; }
        }

        public class ServiceVolumeConfiguration : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// ManagedEBSVolume
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-servicevolumeconfiguration.html#cfn-ecs-servicerevision-servicevolumeconfiguration-managedebsvolume
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ServiceManagedEBSVolumeConfiguration
            /// </summary>
            public Humidifier.ECS.ServiceRevisionTypes.ServiceManagedEBSVolumeConfiguration ManagedEBSVolume { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-servicevolumeconfiguration.html#cfn-ecs-servicerevision-servicevolumeconfiguration-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class TimeoutConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PerRequestTimeoutSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-timeoutconfiguration.html#cfn-ecs-servicerevision-timeoutconfiguration-perrequesttimeoutseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic PerRequestTimeoutSeconds { get; set; }
            /// <summary>
            /// IdleTimeoutSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-timeoutconfiguration.html#cfn-ecs-servicerevision-timeoutconfiguration-idletimeoutseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic IdleTimeoutSeconds { get; set; }
        }

        public class VpcLatticeConfiguration : Humidifier.Base.BaseSubResource, IHaveRoleArn, IHaveTargetGroupArn, IHavePortName
        {
            /// <summary>
            /// TargetGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-vpclatticeconfiguration.html#cfn-ecs-servicerevision-vpclatticeconfiguration-targetgrouparn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetGroupArn { get; set; }
            /// <summary>
            /// PortName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-vpclatticeconfiguration.html#cfn-ecs-servicerevision-vpclatticeconfiguration-portname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PortName { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-servicerevision-vpclatticeconfiguration.html#cfn-ecs-servicerevision-vpclatticeconfiguration-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn { get; set; }
        }
    }
}