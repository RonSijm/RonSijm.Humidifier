namespace Humidifier.ECS
{
    using global::System.Collections.Generic;
    using GatewayTypes;

    public class Gateway : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveInfrastructureRoleArn, IHaveECSGatewayTypesGatewayConfigurationConfiguration, IHavePropagateTags, IHaveGatewayName, IHaveDeletionProtection_Boolean
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Arn =  "Arn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string AccessType =  "AccessType" ;
        }

        public override string AWSTypeName { get => AWS.ECS.Gateway; }

        /// <summary>
        /// InfrastructureRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-gateway.html#cfn-ecs-gateway-infrastructurerolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? InfrastructureRoleArn { get; set; }

        /// <summary>
        /// Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-gateway.html#cfn-ecs-gateway-configuration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: GatewayConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.ECS.GatewayTypes.GatewayConfiguration, BaseFunction>? Configuration { get; set; }
        /// <summary>
        /// PropagateTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-gateway.html#cfn-ecs-gateway-propagatetags
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PropagateTags { get; set; }
        public Union<string, BaseFunction>? GatewayName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// DeletionProtection
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-gateway.html#cfn-ecs-gateway-deletionprotection
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? DeletionProtection { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-gateway.html#cfn-ecs-gateway-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace GatewayTypes
    {
        public class GatewayAlbTestTrafficRules : Humidifier.Base.BaseSubResource, IHaveECSGatewayTypesGatewayTestTrafficHeaderHeader
        {
            /// <summary>
            /// Header
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-gateway-gatewayalbtesttrafficrules.html#cfn-ecs-gateway-gatewayalbtesttrafficrules-header
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GatewayTestTrafficHeader
            /// </summary>
            public Union<Humidifier.ECS.GatewayTypes.GatewayTestTrafficHeader, BaseFunction>? Header { get; set; }
        }

        public class GatewayConfiguration : Humidifier.Base.BaseSubResource, IHaveECSGatewayTypesHostSharedAlbConfigurationHostSharedAlb
        {
            /// <summary>
            /// HostSharedAlb
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-gateway-gatewayconfiguration.html#cfn-ecs-gateway-gatewayconfiguration-hostsharedalb
            /// Required: True
            /// UpdateType: Mutable
            /// Type: HostSharedAlbConfiguration
            /// </summary>
            public Union<Humidifier.ECS.GatewayTypes.HostSharedAlbConfiguration, BaseFunction>? HostSharedAlb { get; set; }
        }

        public class GatewayElbAccessLogConfiguration : Humidifier.Base.BaseSubResource, IHaveECSGatewayTypesGatewayElbAccessLogDestinationDestination
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-gateway-gatewayelbaccesslogconfiguration.html#cfn-ecs-gateway-gatewayelbaccesslogconfiguration-destination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GatewayElbAccessLogDestination
            /// </summary>
            public Union<Humidifier.ECS.GatewayTypes.GatewayElbAccessLogDestination, BaseFunction>? Destination { get; set; }
        }

        public class GatewayElbAccessLogDestination : Humidifier.Base.BaseSubResource, IHaveECSGatewayTypesGatewayElbAccessLogS3DestinationS3
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-gateway-gatewayelbaccesslogdestination.html#cfn-ecs-gateway-gatewayelbaccesslogdestination-s3
            /// Required: True
            /// UpdateType: Mutable
            /// Type: GatewayElbAccessLogS3Destination
            /// </summary>
            public Union<Humidifier.ECS.GatewayTypes.GatewayElbAccessLogS3Destination, BaseFunction>? S3 { get; set; }
        }

        public class GatewayElbAccessLogS3Destination : Humidifier.Base.BaseSubResource, IHaveBucket, IHavePrefix
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-gateway-gatewayelbaccesslogs3destination.html#cfn-ecs-gateway-gatewayelbaccesslogs3destination-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-gateway-gatewayelbaccesslogs3destination.html#cfn-ecs-gateway-gatewayelbaccesslogs3destination-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Prefix { get; set; }
        }

        public class GatewayElbNetworkConfiguration : Humidifier.Base.BaseSubResource, IHaveIpAddressType, IHaveStringListOfSubnets, IHaveInboundSecurityGroup
        {
            /// <summary>
            /// IpAddressType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-gateway-gatewayelbnetworkconfiguration.html#cfn-ecs-gateway-gatewayelbnetworkconfiguration-ipaddresstype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IpAddressType { get; set; }
            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-gateway-gatewayelbnetworkconfiguration.html#cfn-ecs-gateway-gatewayelbnetworkconfiguration-subnets
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Subnets { get; set; }
            /// <summary>
            /// InboundSecurityGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-gateway-gatewayelbnetworkconfiguration.html#cfn-ecs-gateway-gatewayelbnetworkconfiguration-inboundsecuritygroup
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InboundSecurityGroup { get; set; }
        }

        public class GatewayTestTrafficHeader : Humidifier.Base.BaseSubResource, IHaveStringListOfValues, IHaveName
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-gateway-gatewaytesttrafficheader.html#cfn-ecs-gateway-gatewaytesttrafficheader-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-gateway-gatewaytesttrafficheader.html#cfn-ecs-gateway-gatewaytesttrafficheader-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class HostSharedAlbConfiguration : Humidifier.Base.BaseSubResource, IHaveMaxAlbCount_Integer, IHaveScheme, IHaveECSGatewayTypesGatewayAlbTestTrafficRulesTestTrafficRules, IHavePort_Integer, IHaveCurrentAlbCount_Integer, IHaveECSGatewayTypesGatewayElbNetworkConfigurationNetworkConfiguration, IHaveProtocol, IHaveWebACLArn, IHaveECSGatewayTypesGatewayElbAccessLogConfigurationAccessLogs, IHaveHttpDesync
        {
            /// <summary>
            /// MaxAlbCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-gateway-hostsharedalbconfiguration.html#cfn-ecs-gateway-hostsharedalbconfiguration-maxalbcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxAlbCount { get; set; }
            /// <summary>
            /// Scheme
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-gateway-hostsharedalbconfiguration.html#cfn-ecs-gateway-hostsharedalbconfiguration-scheme
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Scheme { get; set; }
            /// <summary>
            /// TestTrafficRules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-gateway-hostsharedalbconfiguration.html#cfn-ecs-gateway-hostsharedalbconfiguration-testtrafficrules
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GatewayAlbTestTrafficRules
            /// </summary>
            public Union<Humidifier.ECS.GatewayTypes.GatewayAlbTestTrafficRules, BaseFunction>? TestTrafficRules { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-gateway-hostsharedalbconfiguration.html#cfn-ecs-gateway-hostsharedalbconfiguration-port
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Port { get; set; }
            /// <summary>
            /// CurrentAlbCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-gateway-hostsharedalbconfiguration.html#cfn-ecs-gateway-hostsharedalbconfiguration-currentalbcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? CurrentAlbCount { get; set; }
            /// <summary>
            /// NetworkConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-gateway-hostsharedalbconfiguration.html#cfn-ecs-gateway-hostsharedalbconfiguration-networkconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GatewayElbNetworkConfiguration
            /// </summary>
            public Union<Humidifier.ECS.GatewayTypes.GatewayElbNetworkConfiguration, BaseFunction>? NetworkConfiguration { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-gateway-hostsharedalbconfiguration.html#cfn-ecs-gateway-hostsharedalbconfiguration-protocol
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Protocol { get; set; }
            /// <summary>
            /// WebACLArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-gateway-hostsharedalbconfiguration.html#cfn-ecs-gateway-hostsharedalbconfiguration-webaclarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WebACLArn { get; set; }
            /// <summary>
            /// AccessLogs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-gateway-hostsharedalbconfiguration.html#cfn-ecs-gateway-hostsharedalbconfiguration-accesslogs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GatewayElbAccessLogConfiguration
            /// </summary>
            public Union<Humidifier.ECS.GatewayTypes.GatewayElbAccessLogConfiguration, BaseFunction>? AccessLogs { get; set; }
            /// <summary>
            /// HttpDesync
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-gateway-hostsharedalbconfiguration.html#cfn-ecs-gateway-hostsharedalbconfiguration-httpdesync
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HttpDesync { get; set; }
        }
    }
}