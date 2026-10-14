namespace Humidifier.GroundStation
{
    using global::System.Collections.Generic;
    using DataflowEndpointGroupV2Types;

    public class DataflowEndpointGroupV2 : Humidifier.Base.BaseResource, IHaveTags, IHaveContactPostPassDurationSeconds, IHaveContactPrePassDurationSeconds
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
        public List<Humidifier.GroundStation.DataflowEndpointGroupV2Types.CreateEndpointDetails> Endpoints { get; set; }
        /// <summary>
        /// ContactPostPassDurationSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-groundstation-dataflowendpointgroupv2.html#cfn-groundstation-dataflowendpointgroupv2-contactpostpassdurationseconds
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic ContactPostPassDurationSeconds { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-groundstation-dataflowendpointgroupv2.html#cfn-groundstation-dataflowendpointgroupv2-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        /// <summary>
        /// ContactPrePassDurationSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-groundstation-dataflowendpointgroupv2.html#cfn-groundstation-dataflowendpointgroupv2-contactprepassdurationseconds
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic ContactPrePassDurationSeconds { get; set; }
    }

    namespace DataflowEndpointGroupV2Types
    {
        public class ConnectionDetails : Humidifier.Base.BaseSubResource, IHaveMtu
        {
            /// <summary>
            /// SocketAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-connectiondetails.html#cfn-groundstation-dataflowendpointgroupv2-connectiondetails-socketaddress
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SocketAddress
            /// </summary>
            public Humidifier.GroundStation.DataflowEndpointGroupV2Types.SocketAddress SocketAddress { get; set; }
            /// <summary>
            /// Mtu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-connectiondetails.html#cfn-groundstation-dataflowendpointgroupv2-connectiondetails-mtu
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Mtu { get; set; }
        }

        public class CreateEndpointDetails : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// UplinkAwsGroundStationAgentEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-createendpointdetails.html#cfn-groundstation-dataflowendpointgroupv2-createendpointdetails-uplinkawsgroundstationagentendpoint
            /// Required: False
            /// UpdateType: Immutable
            /// Type: UplinkAwsGroundStationAgentEndpoint
            /// </summary>
            public Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkAwsGroundStationAgentEndpoint UplinkAwsGroundStationAgentEndpoint { get; set; }
            /// <summary>
            /// DownlinkAwsGroundStationAgentEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-createendpointdetails.html#cfn-groundstation-dataflowendpointgroupv2-createendpointdetails-downlinkawsgroundstationagentendpoint
            /// Required: False
            /// UpdateType: Immutable
            /// Type: DownlinkAwsGroundStationAgentEndpoint
            /// </summary>
            public Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkAwsGroundStationAgentEndpoint DownlinkAwsGroundStationAgentEndpoint { get; set; }
        }

        public class DownlinkAwsGroundStationAgentEndpoint : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// DataflowDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-downlinkawsgroundstationagentendpoint.html#cfn-groundstation-dataflowendpointgroupv2-downlinkawsgroundstationagentendpoint-dataflowdetails
            /// Required: True
            /// UpdateType: Immutable
            /// Type: DownlinkDataflowDetails
            /// </summary>
            public Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkDataflowDetails DataflowDetails { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-downlinkawsgroundstationagentendpoint.html#cfn-groundstation-dataflowendpointgroupv2-downlinkawsgroundstationagentendpoint-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class DownlinkAwsGroundStationAgentEndpointDetails : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// AgentStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-downlinkawsgroundstationagentendpointdetails.html#cfn-groundstation-dataflowendpointgroupv2-downlinkawsgroundstationagentendpointdetails-agentstatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AgentStatus { get; set; }
            /// <summary>
            /// AuditResults
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-downlinkawsgroundstationagentendpointdetails.html#cfn-groundstation-dataflowendpointgroupv2-downlinkawsgroundstationagentendpointdetails-auditresults
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AuditResults { get; set; }
            /// <summary>
            /// DataflowDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-downlinkawsgroundstationagentendpointdetails.html#cfn-groundstation-dataflowendpointgroupv2-downlinkawsgroundstationagentendpointdetails-dataflowdetails
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DownlinkDataflowDetails
            /// </summary>
            public Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkDataflowDetails DataflowDetails { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-downlinkawsgroundstationagentendpointdetails.html#cfn-groundstation-dataflowendpointgroupv2-downlinkawsgroundstationagentendpointdetails-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class DownlinkConnectionDetails : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EgressAddressAndPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-downlinkconnectiondetails.html#cfn-groundstation-dataflowendpointgroupv2-downlinkconnectiondetails-egressaddressandport
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ConnectionDetails
            /// </summary>
            public Humidifier.GroundStation.DataflowEndpointGroupV2Types.ConnectionDetails EgressAddressAndPort { get; set; }
            /// <summary>
            /// AgentIpAndPortAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-downlinkconnectiondetails.html#cfn-groundstation-dataflowendpointgroupv2-downlinkconnectiondetails-agentipandportaddress
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RangedConnectionDetails
            /// </summary>
            public Humidifier.GroundStation.DataflowEndpointGroupV2Types.RangedConnectionDetails AgentIpAndPortAddress { get; set; }
        }

        public class DownlinkDataflowDetails : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AgentConnectionDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-downlinkdataflowdetails.html#cfn-groundstation-dataflowendpointgroupv2-downlinkdataflowdetails-agentconnectiondetails
            /// Required: True
            /// UpdateType: Conditional
            /// Type: DownlinkConnectionDetails
            /// </summary>
            public Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkConnectionDetails AgentConnectionDetails { get; set; }
        }

        public class EndpointDetails : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// UplinkAwsGroundStationAgentEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-endpointdetails.html#cfn-groundstation-dataflowendpointgroupv2-endpointdetails-uplinkawsgroundstationagentendpoint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UplinkAwsGroundStationAgentEndpointDetails
            /// </summary>
            public Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkAwsGroundStationAgentEndpointDetails UplinkAwsGroundStationAgentEndpoint { get; set; }
            /// <summary>
            /// DownlinkAwsGroundStationAgentEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-endpointdetails.html#cfn-groundstation-dataflowendpointgroupv2-endpointdetails-downlinkawsgroundstationagentendpoint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DownlinkAwsGroundStationAgentEndpointDetails
            /// </summary>
            public Humidifier.GroundStation.DataflowEndpointGroupV2Types.DownlinkAwsGroundStationAgentEndpointDetails DownlinkAwsGroundStationAgentEndpoint { get; set; }
        }

        public class IntegerRange : Humidifier.Base.BaseSubResource, IHaveMinimum, IHaveMaximum
        {
            /// <summary>
            /// Minimum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-integerrange.html#cfn-groundstation-dataflowendpointgroupv2-integerrange-minimum
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Minimum { get; set; }
            /// <summary>
            /// Maximum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-integerrange.html#cfn-groundstation-dataflowendpointgroupv2-integerrange-maximum
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Maximum { get; set; }
        }

        public class RangedConnectionDetails : Humidifier.Base.BaseSubResource, IHaveMtu
        {
            /// <summary>
            /// SocketAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-rangedconnectiondetails.html#cfn-groundstation-dataflowendpointgroupv2-rangedconnectiondetails-socketaddress
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RangedSocketAddress
            /// </summary>
            public Humidifier.GroundStation.DataflowEndpointGroupV2Types.RangedSocketAddress SocketAddress { get; set; }
            /// <summary>
            /// Mtu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-rangedconnectiondetails.html#cfn-groundstation-dataflowendpointgroupv2-rangedconnectiondetails-mtu
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Mtu { get; set; }
        }

        public class RangedSocketAddress : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// PortRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-rangedsocketaddress.html#cfn-groundstation-dataflowendpointgroupv2-rangedsocketaddress-portrange
            /// Required: True
            /// UpdateType: Mutable
            /// Type: IntegerRange
            /// </summary>
            public Humidifier.GroundStation.DataflowEndpointGroupV2Types.IntegerRange PortRange { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-rangedsocketaddress.html#cfn-groundstation-dataflowendpointgroupv2-rangedsocketaddress-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class SocketAddress : Humidifier.Base.BaseSubResource, IHaveName, IHavePort
        {
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-socketaddress.html#cfn-groundstation-dataflowendpointgroupv2-socketaddress-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Port { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-socketaddress.html#cfn-groundstation-dataflowendpointgroupv2-socketaddress-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class UplinkAwsGroundStationAgentEndpoint : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// DataflowDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-uplinkawsgroundstationagentendpoint.html#cfn-groundstation-dataflowendpointgroupv2-uplinkawsgroundstationagentendpoint-dataflowdetails
            /// Required: True
            /// UpdateType: Immutable
            /// Type: UplinkDataflowDetails
            /// </summary>
            public Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkDataflowDetails DataflowDetails { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-uplinkawsgroundstationagentendpoint.html#cfn-groundstation-dataflowendpointgroupv2-uplinkawsgroundstationagentendpoint-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class UplinkAwsGroundStationAgentEndpointDetails : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// AgentStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-uplinkawsgroundstationagentendpointdetails.html#cfn-groundstation-dataflowendpointgroupv2-uplinkawsgroundstationagentendpointdetails-agentstatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AgentStatus { get; set; }
            /// <summary>
            /// AuditResults
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-uplinkawsgroundstationagentendpointdetails.html#cfn-groundstation-dataflowendpointgroupv2-uplinkawsgroundstationagentendpointdetails-auditresults
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AuditResults { get; set; }
            /// <summary>
            /// DataflowDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-uplinkawsgroundstationagentendpointdetails.html#cfn-groundstation-dataflowendpointgroupv2-uplinkawsgroundstationagentendpointdetails-dataflowdetails
            /// Required: True
            /// UpdateType: Mutable
            /// Type: UplinkDataflowDetails
            /// </summary>
            public Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkDataflowDetails DataflowDetails { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-uplinkawsgroundstationagentendpointdetails.html#cfn-groundstation-dataflowendpointgroupv2-uplinkawsgroundstationagentendpointdetails-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class UplinkConnectionDetails : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AgentIpAndPortAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-uplinkconnectiondetails.html#cfn-groundstation-dataflowendpointgroupv2-uplinkconnectiondetails-agentipandportaddress
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RangedConnectionDetails
            /// </summary>
            public Humidifier.GroundStation.DataflowEndpointGroupV2Types.RangedConnectionDetails AgentIpAndPortAddress { get; set; }
            /// <summary>
            /// IngressAddressAndPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-uplinkconnectiondetails.html#cfn-groundstation-dataflowendpointgroupv2-uplinkconnectiondetails-ingressaddressandport
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ConnectionDetails
            /// </summary>
            public Humidifier.GroundStation.DataflowEndpointGroupV2Types.ConnectionDetails IngressAddressAndPort { get; set; }
        }

        public class UplinkDataflowDetails : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AgentConnectionDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroupv2-uplinkdataflowdetails.html#cfn-groundstation-dataflowendpointgroupv2-uplinkdataflowdetails-agentconnectiondetails
            /// Required: True
            /// UpdateType: Conditional
            /// Type: UplinkConnectionDetails
            /// </summary>
            public Humidifier.GroundStation.DataflowEndpointGroupV2Types.UplinkConnectionDetails AgentConnectionDetails { get; set; }
        }
    }
}