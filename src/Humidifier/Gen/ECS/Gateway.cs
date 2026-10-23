namespace Humidifier.ECS
{
    using global::System.Collections.Generic;
    using GatewayTypes;

    public class Gateway : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDeletionProtection, IHavePropagateTags
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
        public dynamic InfrastructureRoleArn { get; set; }

        /// <summary>
        /// Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-gateway.html#cfn-ecs-gateway-configuration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: GatewayConfiguration
        /// </summary>
        [Required]
        public Humidifier.ECS.GatewayTypes.GatewayConfiguration Configuration { get; set; }
        /// <summary>
        /// PropagateTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-gateway.html#cfn-ecs-gateway-propagatetags
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PropagateTags { get; set; }
        public dynamic GatewayName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// DeletionProtection
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-gateway.html#cfn-ecs-gateway-deletionprotection
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic DeletionProtection { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-gateway.html#cfn-ecs-gateway-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace GatewayTypes
    {
        public class GatewayAlbTestTrafficRules : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Header
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-gateway-gatewayalbtesttrafficrules.html#cfn-ecs-gateway-gatewayalbtesttrafficrules-header
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GatewayTestTrafficHeader
            /// </summary>
            public Humidifier.ECS.GatewayTypes.GatewayTestTrafficHeader Header { get; set; }
        }

        public class GatewayConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// HostSharedAlb
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-gateway-gatewayconfiguration.html#cfn-ecs-gateway-gatewayconfiguration-hostsharedalb
            /// Required: True
            /// UpdateType: Mutable
            /// Type: HostSharedAlbConfiguration
            /// </summary>
            public Humidifier.ECS.GatewayTypes.HostSharedAlbConfiguration HostSharedAlb { get; set; }
        }

        public class GatewayElbAccessLogConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-gateway-gatewayelbaccesslogconfiguration.html#cfn-ecs-gateway-gatewayelbaccesslogconfiguration-destination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GatewayElbAccessLogDestination
            /// </summary>
            public Humidifier.ECS.GatewayTypes.GatewayElbAccessLogDestination Destination { get; set; }
        }

        public class GatewayElbAccessLogDestination : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-gateway-gatewayelbaccesslogdestination.html#cfn-ecs-gateway-gatewayelbaccesslogdestination-s3
            /// Required: True
            /// UpdateType: Mutable
            /// Type: GatewayElbAccessLogS3Destination
            /// </summary>
            public Humidifier.ECS.GatewayTypes.GatewayElbAccessLogS3Destination S3 { get; set; }
        }

        public class GatewayElbAccessLogS3Destination : Humidifier.Base.BaseSubResource, IHavePrefix, IHaveBucket
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-gateway-gatewayelbaccesslogs3destination.html#cfn-ecs-gateway-gatewayelbaccesslogs3destination-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Bucket { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-gateway-gatewayelbaccesslogs3destination.html#cfn-ecs-gateway-gatewayelbaccesslogs3destination-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix { get; set; }
        }

        public class GatewayElbNetworkConfiguration : Humidifier.Base.BaseSubResource, IHaveSubnets, IHaveIpAddressType
        {
            /// <summary>
            /// IpAddressType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-gateway-gatewayelbnetworkconfiguration.html#cfn-ecs-gateway-gatewayelbnetworkconfiguration-ipaddresstype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IpAddressType { get; set; }
            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-gateway-gatewayelbnetworkconfiguration.html#cfn-ecs-gateway-gatewayelbnetworkconfiguration-subnets
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Subnets { get; set; }
            /// <summary>
            /// InboundSecurityGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-gateway-gatewayelbnetworkconfiguration.html#cfn-ecs-gateway-gatewayelbnetworkconfiguration-inboundsecuritygroup
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InboundSecurityGroup { get; set; }
        }

        public class GatewayTestTrafficHeader : Humidifier.Base.BaseSubResource, IHaveName, IHaveValues
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-gateway-gatewaytesttrafficheader.html#cfn-ecs-gateway-gatewaytesttrafficheader-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Values { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-gateway-gatewaytesttrafficheader.html#cfn-ecs-gateway-gatewaytesttrafficheader-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class HostSharedAlbConfiguration : Humidifier.Base.BaseSubResource, IHavePort, IHaveProtocol, IHaveScheme
        {
            /// <summary>
            /// MaxAlbCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-gateway-hostsharedalbconfiguration.html#cfn-ecs-gateway-hostsharedalbconfiguration-maxalbcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxAlbCount { get; set; }
            /// <summary>
            /// Scheme
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-gateway-hostsharedalbconfiguration.html#cfn-ecs-gateway-hostsharedalbconfiguration-scheme
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Scheme { get; set; }
            /// <summary>
            /// TestTrafficRules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-gateway-hostsharedalbconfiguration.html#cfn-ecs-gateway-hostsharedalbconfiguration-testtrafficrules
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GatewayAlbTestTrafficRules
            /// </summary>
            public Humidifier.ECS.GatewayTypes.GatewayAlbTestTrafficRules TestTrafficRules { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-gateway-hostsharedalbconfiguration.html#cfn-ecs-gateway-hostsharedalbconfiguration-port
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Port { get; set; }
            /// <summary>
            /// CurrentAlbCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-gateway-hostsharedalbconfiguration.html#cfn-ecs-gateway-hostsharedalbconfiguration-currentalbcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic CurrentAlbCount { get; set; }
            /// <summary>
            /// NetworkConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-gateway-hostsharedalbconfiguration.html#cfn-ecs-gateway-hostsharedalbconfiguration-networkconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GatewayElbNetworkConfiguration
            /// </summary>
            public Humidifier.ECS.GatewayTypes.GatewayElbNetworkConfiguration NetworkConfiguration { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-gateway-hostsharedalbconfiguration.html#cfn-ecs-gateway-hostsharedalbconfiguration-protocol
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Protocol { get; set; }
            /// <summary>
            /// WebACLArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-gateway-hostsharedalbconfiguration.html#cfn-ecs-gateway-hostsharedalbconfiguration-webaclarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WebACLArn { get; set; }
            /// <summary>
            /// AccessLogs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-gateway-hostsharedalbconfiguration.html#cfn-ecs-gateway-hostsharedalbconfiguration-accesslogs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GatewayElbAccessLogConfiguration
            /// </summary>
            public Humidifier.ECS.GatewayTypes.GatewayElbAccessLogConfiguration AccessLogs { get; set; }
            /// <summary>
            /// HttpDesync
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-gateway-hostsharedalbconfiguration.html#cfn-ecs-gateway-hostsharedalbconfiguration-httpdesync
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HttpDesync { get; set; }
        }
    }
}