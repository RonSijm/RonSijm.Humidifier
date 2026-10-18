namespace Humidifier.GroundStation
{
    using global::System.Collections.Generic;
    using DataflowEndpointGroupV2Types;

    public class DataflowEndpointGroupV2 : Humidifier.Base.BaseResource, IHaveTags, IHaveListOfGroundStationDataflowEndpointGroupV2TypesCreateEndpointDetailsEndpoints, IHaveContactPostPassDurationSeconds_Integer, IHaveContactPrePassDurationSeconds_Integer
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string EndpointDetails =  "EndpointDetails" ;
        }

        public override string AWSTypeName { get => AWS.GroundStation.DataflowEndpointGroupV2; }
        /// <summary>
        /// Endpoints
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-groundstation-dataflowendpointgroupv2.html#cfn-groundstation-dataflowendpointgroupv2-endpoints
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: CreateEndpointDetails
        /// </summary>
        public Union<IReadOnlyList<Humidifier.GroundStation.DataflowEndpointGroupV2Types.CreateEndpointDetails>, IReadOnlyList<Union<Humidifier.GroundStation.DataflowEndpointGroupV2Types.CreateEndpointDetails, BaseFunction>>, BaseFunction>? Endpoints { get; set; }
        /// <summary>
        /// ContactPostPassDurationSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-groundstation-dataflowendpointgroupv2.html#cfn-groundstation-dataflowendpointgroupv2-contactpostpassdurationseconds
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? ContactPostPassDurationSeconds { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-groundstation-dataflowendpointgroupv2.html#cfn-groundstation-dataflowendpointgroupv2-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// ContactPrePassDurationSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-groundstation-dataflowendpointgroupv2.html#cfn-groundstation-dataflowendpointgroupv2-contactprepassdurationseconds
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? ContactPrePassDurationSeconds { get; set; }
    }

    namespace DataflowEndpointGroupV2Types
    {
        public class ConnectionDetails : Humidifier.Base.BaseSubResource, IHaveGroundStationDataflowEndpointGroupV2TypesSocketAddressSocketAddress, IHaveMtu_Integer
        {
            /// <summary>
            /// SocketAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-connectiondetails.html#cfn-groundstation-dataflowendpointgroupv2-connectiondetails-socketaddress
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SocketAddress
            /// </summary>
            public Union<Humidifier.GroundStation.DataflowEndpointGroupV2Types.SocketAddress, BaseFunction>? SocketAddress { get; set; }
            /// <summary>
            /// Mtu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-connectiondetails.html#cfn-groundstation-dataflowendpointgroupv2-connectiondetails-mtu
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Mtu { get; set; }
        }

        public class CreateEndpointDetails : Humidifier.Base.BaseSubResource, IHaveGroundStationDataflowEndpointGroupV2TypesUplinkAwsGroundStationAgentEndpointUplinkAwsGroundStationAgentEndpoint, IHaveGroundStationDataflowEndpointGroupV2TypesDownlinkAwsGroundStationAgentEndpointDownlinkAwsGroundStationAgentEndpoint
        {
            /// <summary>
            /// UplinkAwsGroundStationAgentEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-createendpointdetails.html#cfn-groundstation-dataflowendpointgroupv2-createendpointdetails-uplinkawsgroundstationagentendpoint
            /// Required: False
            /// UpdateType: Immutable
            /// Type: UplinkAwsGroundStationAgentEndpoint
            /// </summary>
            public Union<Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkAwsGroundStationAgentEndpoint, BaseFunction>? UplinkAwsGroundStationAgentEndpoint { get; set; }
            /// <summary>
            /// DownlinkAwsGroundStationAgentEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-createendpointdetails.html#cfn-groundstation-dataflowendpointgroupv2-createendpointdetails-downlinkawsgroundstationagentendpoint
            /// Required: False
            /// UpdateType: Immutable
            /// Type: DownlinkAwsGroundStationAgentEndpoint
            /// </summary>
            public Union<Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkAwsGroundStationAgentEndpoint, BaseFunction>? DownlinkAwsGroundStationAgentEndpoint { get; set; }
        }

        public class DownlinkAwsGroundStationAgentEndpoint : Humidifier.Base.BaseSubResource, IHaveGroundStationDataflowEndpointGroupV2TypesDownlinkDataflowDetailsDataflowDetails, IHaveName
        {
            /// <summary>
            /// DataflowDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-downlinkawsgroundstationagentendpoint.html#cfn-groundstation-dataflowendpointgroupv2-downlinkawsgroundstationagentendpoint-dataflowdetails
            /// Required: True
            /// UpdateType: Immutable
            /// Type: DownlinkDataflowDetails
            /// </summary>
            public Union<Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkDataflowDetails, BaseFunction>? DataflowDetails { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-downlinkawsgroundstationagentendpoint.html#cfn-groundstation-dataflowendpointgroupv2-downlinkawsgroundstationagentendpoint-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class DownlinkAwsGroundStationAgentEndpointDetails : Humidifier.Base.BaseSubResource, IHaveAgentStatus, IHaveAuditResults, IHaveGroundStationDataflowEndpointGroupV2TypesDownlinkDataflowDetailsDataflowDetails, IHaveName
        {
            /// <summary>
            /// AgentStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-downlinkawsgroundstationagentendpointdetails.html#cfn-groundstation-dataflowendpointgroupv2-downlinkawsgroundstationagentendpointdetails-agentstatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AgentStatus { get; set; }
            /// <summary>
            /// AuditResults
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-downlinkawsgroundstationagentendpointdetails.html#cfn-groundstation-dataflowendpointgroupv2-downlinkawsgroundstationagentendpointdetails-auditresults
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuditResults { get; set; }
            /// <summary>
            /// DataflowDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-downlinkawsgroundstationagentendpointdetails.html#cfn-groundstation-dataflowendpointgroupv2-downlinkawsgroundstationagentendpointdetails-dataflowdetails
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DownlinkDataflowDetails
            /// </summary>
            public Union<Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkDataflowDetails, BaseFunction>? DataflowDetails { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-downlinkawsgroundstationagentendpointdetails.html#cfn-groundstation-dataflowendpointgroupv2-downlinkawsgroundstationagentendpointdetails-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class DownlinkConnectionDetails : Humidifier.Base.BaseSubResource, IHaveGroundStationDataflowEndpointGroupV2TypesConnectionDetailsEgressAddressAndPort, IHaveGroundStationDataflowEndpointGroupV2TypesRangedConnectionDetailsAgentIpAndPortAddress
        {
            /// <summary>
            /// EgressAddressAndPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-downlinkconnectiondetails.html#cfn-groundstation-dataflowendpointgroupv2-downlinkconnectiondetails-egressaddressandport
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ConnectionDetails
            /// </summary>
            public Union<Humidifier.GroundStation.DataflowEndpointGroupV2Types.ConnectionDetails, BaseFunction>? EgressAddressAndPort { get; set; }
            /// <summary>
            /// AgentIpAndPortAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-downlinkconnectiondetails.html#cfn-groundstation-dataflowendpointgroupv2-downlinkconnectiondetails-agentipandportaddress
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RangedConnectionDetails
            /// </summary>
            public Union<Humidifier.GroundStation.DataflowEndpointGroupV2Types.RangedConnectionDetails, BaseFunction>? AgentIpAndPortAddress { get; set; }
        }

        public class DownlinkDataflowDetails : Humidifier.Base.BaseSubResource, IHaveGroundStationDataflowEndpointGroupV2TypesDownlinkConnectionDetailsAgentConnectionDetails
        {
            /// <summary>
            /// AgentConnectionDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-downlinkdataflowdetails.html#cfn-groundstation-dataflowendpointgroupv2-downlinkdataflowdetails-agentconnectiondetails
            /// Required: True
            /// UpdateType: Conditional
            /// Type: DownlinkConnectionDetails
            /// </summary>
            public Union<Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkConnectionDetails, BaseFunction>? AgentConnectionDetails { get; set; }
        }

        public class EndpointDetails : Humidifier.Base.BaseSubResource, IHaveGroundStationDataflowEndpointGroupV2TypesUplinkAwsGroundStationAgentEndpointDetailsUplinkAwsGroundStationAgentEndpoint, IHaveGroundStationDataflowEndpointGroupV2TypesDownlinkAwsGroundStationAgentEndpointDetailsDownlinkAwsGroundStationAgentEndpoint
        {
            /// <summary>
            /// UplinkAwsGroundStationAgentEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-endpointdetails.html#cfn-groundstation-dataflowendpointgroupv2-endpointdetails-uplinkawsgroundstationagentendpoint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UplinkAwsGroundStationAgentEndpointDetails
            /// </summary>
            public Union<Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkAwsGroundStationAgentEndpointDetails, BaseFunction>? UplinkAwsGroundStationAgentEndpoint { get; set; }
            /// <summary>
            /// DownlinkAwsGroundStationAgentEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-endpointdetails.html#cfn-groundstation-dataflowendpointgroupv2-endpointdetails-downlinkawsgroundstationagentendpoint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DownlinkAwsGroundStationAgentEndpointDetails
            /// </summary>
            public Union<Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkAwsGroundStationAgentEndpointDetails, BaseFunction>? DownlinkAwsGroundStationAgentEndpoint { get; set; }
        }

        public class IntegerRange : Humidifier.Base.BaseSubResource, IHaveMinimum_Integer, IHaveMaximum_Integer
        {
            /// <summary>
            /// Minimum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-integerrange.html#cfn-groundstation-dataflowendpointgroupv2-integerrange-minimum
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Minimum { get; set; }
            /// <summary>
            /// Maximum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-integerrange.html#cfn-groundstation-dataflowendpointgroupv2-integerrange-maximum
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Maximum { get; set; }
        }

        public class RangedConnectionDetails : Humidifier.Base.BaseSubResource, IHaveGroundStationDataflowEndpointGroupV2TypesRangedSocketAddressSocketAddress, IHaveMtu_Integer
        {
            /// <summary>
            /// SocketAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-rangedconnectiondetails.html#cfn-groundstation-dataflowendpointgroupv2-rangedconnectiondetails-socketaddress
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RangedSocketAddress
            /// </summary>
            public Union<Humidifier.GroundStation.DataflowEndpointGroupV2Types.RangedSocketAddress, BaseFunction>? SocketAddress { get; set; }
            /// <summary>
            /// Mtu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-rangedconnectiondetails.html#cfn-groundstation-dataflowendpointgroupv2-rangedconnectiondetails-mtu
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Mtu { get; set; }
        }

        public class RangedSocketAddress : Humidifier.Base.BaseSubResource, IHaveGroundStationDataflowEndpointGroupV2TypesIntegerRangePortRange, IHaveName
        {
            /// <summary>
            /// PortRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-rangedsocketaddress.html#cfn-groundstation-dataflowendpointgroupv2-rangedsocketaddress-portrange
            /// Required: True
            /// UpdateType: Mutable
            /// Type: IntegerRange
            /// </summary>
            public Union<Humidifier.GroundStation.DataflowEndpointGroupV2Types.IntegerRange, BaseFunction>? PortRange { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-rangedsocketaddress.html#cfn-groundstation-dataflowendpointgroupv2-rangedsocketaddress-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class SocketAddress : Humidifier.Base.BaseSubResource, IHavePort_Integer, IHaveName
        {
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-socketaddress.html#cfn-groundstation-dataflowendpointgroupv2-socketaddress-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Port { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-socketaddress.html#cfn-groundstation-dataflowendpointgroupv2-socketaddress-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class UplinkAwsGroundStationAgentEndpoint : Humidifier.Base.BaseSubResource, IHaveGroundStationDataflowEndpointGroupV2TypesUplinkDataflowDetailsDataflowDetails, IHaveName
        {
            /// <summary>
            /// DataflowDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-uplinkawsgroundstationagentendpoint.html#cfn-groundstation-dataflowendpointgroupv2-uplinkawsgroundstationagentendpoint-dataflowdetails
            /// Required: True
            /// UpdateType: Immutable
            /// Type: UplinkDataflowDetails
            /// </summary>
            public Union<Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkDataflowDetails, BaseFunction>? DataflowDetails { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-uplinkawsgroundstationagentendpoint.html#cfn-groundstation-dataflowendpointgroupv2-uplinkawsgroundstationagentendpoint-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class UplinkAwsGroundStationAgentEndpointDetails : Humidifier.Base.BaseSubResource, IHaveAgentStatus, IHaveAuditResults, IHaveGroundStationDataflowEndpointGroupV2TypesUplinkDataflowDetailsDataflowDetails, IHaveName
        {
            /// <summary>
            /// AgentStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-uplinkawsgroundstationagentendpointdetails.html#cfn-groundstation-dataflowendpointgroupv2-uplinkawsgroundstationagentendpointdetails-agentstatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AgentStatus { get; set; }
            /// <summary>
            /// AuditResults
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-uplinkawsgroundstationagentendpointdetails.html#cfn-groundstation-dataflowendpointgroupv2-uplinkawsgroundstationagentendpointdetails-auditresults
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuditResults { get; set; }
            /// <summary>
            /// DataflowDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-uplinkawsgroundstationagentendpointdetails.html#cfn-groundstation-dataflowendpointgroupv2-uplinkawsgroundstationagentendpointdetails-dataflowdetails
            /// Required: True
            /// UpdateType: Mutable
            /// Type: UplinkDataflowDetails
            /// </summary>
            public Union<Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkDataflowDetails, BaseFunction>? DataflowDetails { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-uplinkawsgroundstationagentendpointdetails.html#cfn-groundstation-dataflowendpointgroupv2-uplinkawsgroundstationagentendpointdetails-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class UplinkConnectionDetails : Humidifier.Base.BaseSubResource, IHaveGroundStationDataflowEndpointGroupV2TypesRangedConnectionDetailsAgentIpAndPortAddress, IHaveGroundStationDataflowEndpointGroupV2TypesConnectionDetailsIngressAddressAndPort
        {
            /// <summary>
            /// AgentIpAndPortAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-uplinkconnectiondetails.html#cfn-groundstation-dataflowendpointgroupv2-uplinkconnectiondetails-agentipandportaddress
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RangedConnectionDetails
            /// </summary>
            public Union<Humidifier.GroundStation.DataflowEndpointGroupV2Types.RangedConnectionDetails, BaseFunction>? AgentIpAndPortAddress { get; set; }
            /// <summary>
            /// IngressAddressAndPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-uplinkconnectiondetails.html#cfn-groundstation-dataflowendpointgroupv2-uplinkconnectiondetails-ingressaddressandport
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ConnectionDetails
            /// </summary>
            public Union<Humidifier.GroundStation.DataflowEndpointGroupV2Types.ConnectionDetails, BaseFunction>? IngressAddressAndPort { get; set; }
        }

        public class UplinkDataflowDetails : Humidifier.Base.BaseSubResource, IHaveGroundStationDataflowEndpointGroupV2TypesUplinkConnectionDetailsAgentConnectionDetails
        {
            /// <summary>
            /// AgentConnectionDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-uplinkdataflowdetails.html#cfn-groundstation-dataflowendpointgroupv2-uplinkdataflowdetails-agentconnectiondetails
            /// Required: True
            /// UpdateType: Conditional
            /// Type: UplinkConnectionDetails
            /// </summary>
            public Union<Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkConnectionDetails, BaseFunction>? AgentConnectionDetails { get; set; }
        }
    }
}