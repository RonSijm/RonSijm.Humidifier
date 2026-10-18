namespace Humidifier.RTBFabric
{
    using global::System.Collections.Generic;
    using ResponderGatewayTypes;

    public class ResponderGateway : Humidifier.Base.BaseResource, IHaveTags, IHaveRTBFabricResponderGatewayTypesTrustStoreConfigurationTrustStoreConfiguration, IHaveDescription, IHaveDomainName, IHavePort_Integer, IHaveGatewayType, IHaveRTBFabricResponderGatewayTypesManagedEndpointConfigurationManagedEndpointConfiguration, IHaveStringListOfSubnetIds, IHaveStringListOfSecurityGroupIds, IHaveRTBFabricResponderGatewayTypesListenerConfigListenerConfig, IHaveVpcId, IHaveProtocol, IHaveAcmCertificateArn
    {
        public class Attributes
        {
            public static string UpdatedTimestamp =  "UpdatedTimestamp" ;
            public static string CreatedTimestamp =  "CreatedTimestamp" ;
            public static string ResponderGatewayStatus =  "ResponderGatewayStatus" ;
            public static string ExternalInboundEndpoint =  "ExternalInboundEndpoint" ;
            public static string CertificateAssociationStatus =  "CertificateAssociationStatus" ;
            public static string GatewayId =  "GatewayId" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.RTBFabric.ResponderGateway; }
        /// <summary>
        /// TrustStoreConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rtbfabric-respondergateway.html#cfn-rtbfabric-respondergateway-truststoreconfiguration
        /// Required: False
        /// UpdateType: Conditional
        /// Type: TrustStoreConfiguration
        /// </summary>
        public Union<Humidifier.RTBFabric.ResponderGatewayTypes.TrustStoreConfiguration, BaseFunction>? TrustStoreConfiguration { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rtbfabric-respondergateway.html#cfn-rtbfabric-respondergateway-description
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// DomainName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rtbfabric-respondergateway.html#cfn-rtbfabric-respondergateway-domainname
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DomainName { get; set; }

        /// <summary>
        /// Port
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rtbfabric-respondergateway.html#cfn-rtbfabric-respondergateway-port
        /// Required: True
        /// UpdateType: Conditional
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? Port { get; set; }
        /// <summary>
        /// GatewayType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rtbfabric-respondergateway.html#cfn-rtbfabric-respondergateway-gatewaytype
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? GatewayType { get; set; }
        /// <summary>
        /// ManagedEndpointConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rtbfabric-respondergateway.html#cfn-rtbfabric-respondergateway-managedendpointconfiguration
        /// Required: False
        /// UpdateType: Conditional
        /// Type: ManagedEndpointConfiguration
        /// </summary>
        public Union<Humidifier.RTBFabric.ResponderGatewayTypes.ManagedEndpointConfiguration, BaseFunction>? ManagedEndpointConfiguration { get; set; }

        /// <summary>
        /// SubnetIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rtbfabric-respondergateway.html#cfn-rtbfabric-respondergateway-subnetids
        /// Required: True
        /// UpdateType: Conditional
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }

        /// <summary>
        /// SecurityGroupIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rtbfabric-respondergateway.html#cfn-rtbfabric-respondergateway-securitygroupids
        /// Required: True
        /// UpdateType: Conditional
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        /// <summary>
        /// ListenerConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rtbfabric-respondergateway.html#cfn-rtbfabric-respondergateway-listenerconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ListenerConfig
        /// </summary>
        public Union<Humidifier.RTBFabric.ResponderGatewayTypes.ListenerConfig, BaseFunction>? ListenerConfig { get; set; }

        /// <summary>
        /// VpcId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rtbfabric-respondergateway.html#cfn-rtbfabric-respondergateway-vpcid
        /// Required: True
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? VpcId { get; set; }

        /// <summary>
        /// Protocol
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rtbfabric-respondergateway.html#cfn-rtbfabric-respondergateway-protocol
        /// Required: True
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Protocol { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rtbfabric-respondergateway.html#cfn-rtbfabric-respondergateway-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// AcmCertificateArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rtbfabric-respondergateway.html#cfn-rtbfabric-respondergateway-acmcertificatearn
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AcmCertificateArn { get; set; }
    }

    namespace ResponderGatewayTypes
    {
        public class AutoScalingGroupsConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfAutoScalingGroupNameList, IHaveRTBFabricResponderGatewayTypesHealthCheckConfigHealthCheckConfig, IHaveRoleArn
        {
            /// <summary>
            /// AutoScalingGroupNameList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-respondergateway-autoscalinggroupsconfiguration.html#cfn-rtbfabric-respondergateway-autoscalinggroupsconfiguration-autoscalinggroupnamelist
            /// Required: True
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AutoScalingGroupNameList { get; set; }
            /// <summary>
            /// HealthCheckConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-respondergateway-autoscalinggroupsconfiguration.html#cfn-rtbfabric-respondergateway-autoscalinggroupsconfiguration-healthcheckconfig
            /// Required: False
            /// UpdateType: Conditional
            /// Type: HealthCheckConfig
            /// </summary>
            public Union<Humidifier.RTBFabric.ResponderGatewayTypes.HealthCheckConfig, BaseFunction>? HealthCheckConfig { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-respondergateway-autoscalinggroupsconfiguration.html#cfn-rtbfabric-respondergateway-autoscalinggroupsconfiguration-rolearn
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class EksEndpointsConfiguration : Humidifier.Base.BaseSubResource, IHaveClusterApiServerCaCertificateChain, IHaveEndpointsResourceName, IHaveClusterApiServerEndpointUri, IHaveClusterName, IHaveEndpointsResourceNamespace, IHaveRoleArn
        {
            /// <summary>
            /// ClusterApiServerCaCertificateChain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-respondergateway-eksendpointsconfiguration.html#cfn-rtbfabric-respondergateway-eksendpointsconfiguration-clusterapiservercacertificatechain
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClusterApiServerCaCertificateChain { get; set; }
            /// <summary>
            /// EndpointsResourceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-respondergateway-eksendpointsconfiguration.html#cfn-rtbfabric-respondergateway-eksendpointsconfiguration-endpointsresourcename
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndpointsResourceName { get; set; }
            /// <summary>
            /// ClusterApiServerEndpointUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-respondergateway-eksendpointsconfiguration.html#cfn-rtbfabric-respondergateway-eksendpointsconfiguration-clusterapiserverendpointuri
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClusterApiServerEndpointUri { get; set; }
            /// <summary>
            /// ClusterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-respondergateway-eksendpointsconfiguration.html#cfn-rtbfabric-respondergateway-eksendpointsconfiguration-clustername
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClusterName { get; set; }
            /// <summary>
            /// EndpointsResourceNamespace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-respondergateway-eksendpointsconfiguration.html#cfn-rtbfabric-respondergateway-eksendpointsconfiguration-endpointsresourcenamespace
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndpointsResourceNamespace { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-respondergateway-eksendpointsconfiguration.html#cfn-rtbfabric-respondergateway-eksendpointsconfiguration-rolearn
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class HealthCheckConfig : Humidifier.Base.BaseSubResource, IHavePath, IHaveTimeoutMs_Integer, IHaveHealthyThresholdCount_Integer, IHavePort_Integer, IHaveStatusCodeMatcher, IHaveProtocol, IHaveUnhealthyThresholdCount_Integer, IHaveIntervalSeconds_Integer
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-respondergateway-healthcheckconfig.html#cfn-rtbfabric-respondergateway-healthcheckconfig-path
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Path { get; set; }
            /// <summary>
            /// TimeoutMs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-respondergateway-healthcheckconfig.html#cfn-rtbfabric-respondergateway-healthcheckconfig-timeoutms
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimeoutMs { get; set; }
            /// <summary>
            /// HealthyThresholdCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-respondergateway-healthcheckconfig.html#cfn-rtbfabric-respondergateway-healthcheckconfig-healthythresholdcount
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? HealthyThresholdCount { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-respondergateway-healthcheckconfig.html#cfn-rtbfabric-respondergateway-healthcheckconfig-port
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Port { get; set; }
            /// <summary>
            /// StatusCodeMatcher
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-respondergateway-healthcheckconfig.html#cfn-rtbfabric-respondergateway-healthcheckconfig-statuscodematcher
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StatusCodeMatcher { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-respondergateway-healthcheckconfig.html#cfn-rtbfabric-respondergateway-healthcheckconfig-protocol
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Protocol { get; set; }
            /// <summary>
            /// UnhealthyThresholdCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-respondergateway-healthcheckconfig.html#cfn-rtbfabric-respondergateway-healthcheckconfig-unhealthythresholdcount
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? UnhealthyThresholdCount { get; set; }
            /// <summary>
            /// IntervalSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-respondergateway-healthcheckconfig.html#cfn-rtbfabric-respondergateway-healthcheckconfig-intervalseconds
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? IntervalSeconds { get; set; }
        }

        public class ListenerConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfProtocols
        {
            /// <summary>
            /// Protocols
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-respondergateway-listenerconfig.html#cfn-rtbfabric-respondergateway-listenerconfig-protocols
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Protocols { get; set; }
        }

        public class ManagedEndpointConfiguration : Humidifier.Base.BaseSubResource, IHaveRTBFabricResponderGatewayTypesEksEndpointsConfigurationEksEndpointsConfiguration, IHaveRTBFabricResponderGatewayTypesAutoScalingGroupsConfigurationAutoScalingGroupsConfiguration
        {
            /// <summary>
            /// EksEndpointsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-respondergateway-managedendpointconfiguration.html#cfn-rtbfabric-respondergateway-managedendpointconfiguration-eksendpointsconfiguration
            /// Required: False
            /// UpdateType: Conditional
            /// Type: EksEndpointsConfiguration
            /// </summary>
            public Union<Humidifier.RTBFabric.ResponderGatewayTypes.EksEndpointsConfiguration, BaseFunction>? EksEndpointsConfiguration { get; set; }
            /// <summary>
            /// AutoScalingGroupsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-respondergateway-managedendpointconfiguration.html#cfn-rtbfabric-respondergateway-managedendpointconfiguration-autoscalinggroupsconfiguration
            /// Required: False
            /// UpdateType: Conditional
            /// Type: AutoScalingGroupsConfiguration
            /// </summary>
            public Union<Humidifier.RTBFabric.ResponderGatewayTypes.AutoScalingGroupsConfiguration, BaseFunction>? AutoScalingGroupsConfiguration { get; set; }
        }

        public class TrustStoreConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfCertificateAuthorityCertificates
        {
            /// <summary>
            /// CertificateAuthorityCertificates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rtbfabric-respondergateway-truststoreconfiguration.html#cfn-rtbfabric-respondergateway-truststoreconfiguration-certificateauthoritycertificates
            /// Required: True
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CertificateAuthorityCertificates { get; set; }
        }
    }
}