namespace Humidifier.GroundStation
{
    using global::System.Collections.Generic;
    using DataflowEndpointGroupTypes;

    public class DataflowEndpointGroup : Humidifier.Base.BaseResource, IHaveTags, IHaveContactPostPassDurationSeconds_Integer, IHaveListOfGroundStationDataflowEndpointGroupTypesEndpointDetailsEndpointDetails, IHaveContactPrePassDurationSeconds_Integer
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.GroundStation.DataflowEndpointGroup; }
        /// <summary>
        /// ContactPostPassDurationSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-groundstation-dataflowendpointgroup.html#cfn-groundstation-dataflowendpointgroup-contactpostpassdurationseconds
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? ContactPostPassDurationSeconds { get; set; }

        /// <summary>
        /// EndpointDetails
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-groundstation-dataflowendpointgroup.html#cfn-groundstation-dataflowendpointgroup-endpointdetails
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: EndpointDetails
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.GroundStation.DataflowEndpointGroupTypes.EndpointDetails>, IReadOnlyList<Union<Humidifier.GroundStation.DataflowEndpointGroupTypes.EndpointDetails, BaseFunction>>, BaseFunction>? EndpointDetails { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-groundstation-dataflowendpointgroup.html#cfn-groundstation-dataflowendpointgroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// ContactPrePassDurationSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-groundstation-dataflowendpointgroup.html#cfn-groundstation-dataflowendpointgroup-contactprepassdurationseconds
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? ContactPrePassDurationSeconds { get; set; }
    }

    namespace DataflowEndpointGroupTypes
    {
        public class AwsGroundStationAgentEndpoint : Humidifier.Base.BaseSubResource, IHaveAgentStatus, IHaveGroundStationDataflowEndpointGroupTypesRangedConnectionDetailsIngressAddress, IHaveAuditResults, IHaveName, IHaveGroundStationDataflowEndpointGroupTypesConnectionDetailsEgressAddress
        {
            /// <summary>
            /// AgentStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-awsgroundstationagentendpoint.html#cfn-groundstation-dataflowendpointgroup-awsgroundstationagentendpoint-agentstatus
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AgentStatus { get; set; }
            /// <summary>
            /// IngressAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-awsgroundstationagentendpoint.html#cfn-groundstation-dataflowendpointgroup-awsgroundstationagentendpoint-ingressaddress
            /// Required: False
            /// UpdateType: Immutable
            /// Type: RangedConnectionDetails
            /// </summary>
            public Union<Humidifier.GroundStation.DataflowEndpointGroupTypes.RangedConnectionDetails, BaseFunction>? IngressAddress { get; set; }
            /// <summary>
            /// AuditResults
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-awsgroundstationagentendpoint.html#cfn-groundstation-dataflowendpointgroup-awsgroundstationagentendpoint-auditresults
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuditResults { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-awsgroundstationagentendpoint.html#cfn-groundstation-dataflowendpointgroup-awsgroundstationagentendpoint-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
            /// <summary>
            /// EgressAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-awsgroundstationagentendpoint.html#cfn-groundstation-dataflowendpointgroup-awsgroundstationagentendpoint-egressaddress
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ConnectionDetails
            /// </summary>
            public Union<Humidifier.GroundStation.DataflowEndpointGroupTypes.ConnectionDetails, BaseFunction>? EgressAddress { get; set; }
        }

        public class ConnectionDetails : Humidifier.Base.BaseSubResource, IHaveGroundStationDataflowEndpointGroupTypesSocketAddressSocketAddress, IHaveMtu_Integer
        {
            /// <summary>
            /// SocketAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-connectiondetails.html#cfn-groundstation-dataflowendpointgroup-connectiondetails-socketaddress
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SocketAddress
            /// </summary>
            public Union<Humidifier.GroundStation.DataflowEndpointGroupTypes.SocketAddress, BaseFunction>? SocketAddress { get; set; }
            /// <summary>
            /// Mtu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-connectiondetails.html#cfn-groundstation-dataflowendpointgroup-connectiondetails-mtu
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Mtu { get; set; }
        }

        public class DataflowEndpoint : Humidifier.Base.BaseSubResource, IHaveGroundStationDataflowEndpointGroupTypesSocketAddressAddress, IHaveName, IHaveMtu_Integer
        {
            /// <summary>
            /// Address
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-dataflowendpoint.html#cfn-groundstation-dataflowendpointgroup-dataflowendpoint-address
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SocketAddress
            /// </summary>
            public Union<Humidifier.GroundStation.DataflowEndpointGroupTypes.SocketAddress, BaseFunction>? Address { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-dataflowendpoint.html#cfn-groundstation-dataflowendpointgroup-dataflowendpoint-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
            /// <summary>
            /// Mtu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-dataflowendpoint.html#cfn-groundstation-dataflowendpointgroup-dataflowendpoint-mtu
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Mtu { get; set; }
        }

        public class EndpointDetails : Humidifier.Base.BaseSubResource, IHaveGroundStationDataflowEndpointGroupTypesDataflowEndpointEndpoint, IHaveGroundStationDataflowEndpointGroupTypesAwsGroundStationAgentEndpointAwsGroundStationAgentEndpoint, IHaveGroundStationDataflowEndpointGroupTypesSecurityDetailsSecurityDetails
        {
            /// <summary>
            /// Endpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-endpointdetails.html#cfn-groundstation-dataflowendpointgroup-endpointdetails-endpoint
            /// Required: False
            /// UpdateType: Immutable
            /// Type: DataflowEndpoint
            /// </summary>
            public Union<Humidifier.GroundStation.DataflowEndpointGroupTypes.DataflowEndpoint, BaseFunction>? Endpoint { get; set; }
            /// <summary>
            /// AwsGroundStationAgentEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-endpointdetails.html#cfn-groundstation-dataflowendpointgroup-endpointdetails-awsgroundstationagentendpoint
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AwsGroundStationAgentEndpoint
            /// </summary>
            public Union<Humidifier.GroundStation.DataflowEndpointGroupTypes.AwsGroundStationAgentEndpoint, BaseFunction>? AwsGroundStationAgentEndpoint { get; set; }
            /// <summary>
            /// SecurityDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-endpointdetails.html#cfn-groundstation-dataflowendpointgroup-endpointdetails-securitydetails
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SecurityDetails
            /// </summary>
            public Union<Humidifier.GroundStation.DataflowEndpointGroupTypes.SecurityDetails, BaseFunction>? SecurityDetails { get; set; }
        }

        public class IntegerRange : Humidifier.Base.BaseSubResource, IHaveMinimum_Integer, IHaveMaximum_Integer
        {
            /// <summary>
            /// Minimum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-integerrange.html#cfn-groundstation-dataflowendpointgroup-integerrange-minimum
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Minimum { get; set; }
            /// <summary>
            /// Maximum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-integerrange.html#cfn-groundstation-dataflowendpointgroup-integerrange-maximum
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Maximum { get; set; }
        }

        public class RangedConnectionDetails : Humidifier.Base.BaseSubResource, IHaveGroundStationDataflowEndpointGroupTypesRangedSocketAddressSocketAddress, IHaveMtu_Integer
        {
            /// <summary>
            /// SocketAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-rangedconnectiondetails.html#cfn-groundstation-dataflowendpointgroup-rangedconnectiondetails-socketaddress
            /// Required: False
            /// UpdateType: Immutable
            /// Type: RangedSocketAddress
            /// </summary>
            public Union<Humidifier.GroundStation.DataflowEndpointGroupTypes.RangedSocketAddress, BaseFunction>? SocketAddress { get; set; }
            /// <summary>
            /// Mtu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-rangedconnectiondetails.html#cfn-groundstation-dataflowendpointgroup-rangedconnectiondetails-mtu
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Mtu { get; set; }
        }

        public class RangedSocketAddress : Humidifier.Base.BaseSubResource, IHaveGroundStationDataflowEndpointGroupTypesIntegerRangePortRange, IHaveName
        {
            /// <summary>
            /// PortRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-rangedsocketaddress.html#cfn-groundstation-dataflowendpointgroup-rangedsocketaddress-portrange
            /// Required: False
            /// UpdateType: Immutable
            /// Type: IntegerRange
            /// </summary>
            public Union<Humidifier.GroundStation.DataflowEndpointGroupTypes.IntegerRange, BaseFunction>? PortRange { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-rangedsocketaddress.html#cfn-groundstation-dataflowendpointgroup-rangedsocketaddress-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class SecurityDetails : Humidifier.Base.BaseSubResource, IHaveStringListOfSubnetIds, IHaveStringListOfSecurityGroupIds, IHaveRoleArn
        {
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-securitydetails.html#cfn-groundstation-dataflowendpointgroup-securitydetails-subnetids
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-securitydetails.html#cfn-groundstation-dataflowendpointgroup-securitydetails-securitygroupids
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-securitydetails.html#cfn-groundstation-dataflowendpointgroup-securitydetails-rolearn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class SocketAddress : Humidifier.Base.BaseSubResource, IHavePort_Integer, IHaveName
        {
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-socketaddress.html#cfn-groundstation-dataflowendpointgroup-socketaddress-port
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Port { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-socketaddress.html#cfn-groundstation-dataflowendpointgroup-socketaddress-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }
    }
}