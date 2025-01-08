namespace Humidifier.GroundStation
{
    using System.Collections.Generic;
    using DataflowEndpointGroupTypes;

    public class DataflowEndpointGroup : Humidifier.Base.BaseResource, IHaveTags, IHaveContactPostPassDurationSeconds, IHaveContactPrePassDurationSeconds
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
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic ContactPostPassDurationSeconds { get; set; }

        /// <summary>
        /// EndpointDetails
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-groundstation-dataflowendpointgroup.html#cfn-groundstation-dataflowendpointgroup-endpointdetails
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: EndpointDetails
        /// </summary>
        [Required]
        public List<Humidifier.GroundStation.DataflowEndpointGroupTypes.EndpointDetails> EndpointDetails { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-groundstation-dataflowendpointgroup.html#cfn-groundstation-dataflowendpointgroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// ContactPrePassDurationSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-groundstation-dataflowendpointgroup.html#cfn-groundstation-dataflowendpointgroup-contactprepassdurationseconds
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic ContactPrePassDurationSeconds { get; set; }
    }

    namespace DataflowEndpointGroupTypes
    {
        public class AwsGroundStationAgentEndpoint : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// AgentStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-awsgroundstationagentendpoint.html#cfn-groundstation-dataflowendpointgroup-awsgroundstationagentendpoint-agentstatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AgentStatus { get; set; }
            /// <summary>
            /// IngressAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-awsgroundstationagentendpoint.html#cfn-groundstation-dataflowendpointgroup-awsgroundstationagentendpoint-ingressaddress
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RangedConnectionDetails
            /// </summary>
            public Humidifier.GroundStation.DataflowEndpointGroupTypes.RangedConnectionDetails IngressAddress { get; set; }
            /// <summary>
            /// AuditResults
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-awsgroundstationagentendpoint.html#cfn-groundstation-dataflowendpointgroup-awsgroundstationagentendpoint-auditresults
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AuditResults { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-awsgroundstationagentendpoint.html#cfn-groundstation-dataflowendpointgroup-awsgroundstationagentendpoint-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
            /// <summary>
            /// EgressAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-awsgroundstationagentendpoint.html#cfn-groundstation-dataflowendpointgroup-awsgroundstationagentendpoint-egressaddress
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConnectionDetails
            /// </summary>
            public Humidifier.GroundStation.DataflowEndpointGroupTypes.ConnectionDetails EgressAddress { get; set; }
        }

        public class ConnectionDetails : Humidifier.Base.BaseSubResource, IHaveMtu
        {
            /// <summary>
            /// SocketAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-connectiondetails.html#cfn-groundstation-dataflowendpointgroup-connectiondetails-socketaddress
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SocketAddress
            /// </summary>
            public Humidifier.GroundStation.DataflowEndpointGroupTypes.SocketAddress SocketAddress { get; set; }
            /// <summary>
            /// Mtu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-connectiondetails.html#cfn-groundstation-dataflowendpointgroup-connectiondetails-mtu
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Mtu { get; set; }
        }

        public class DataflowEndpoint : Humidifier.Base.BaseSubResource, IHaveName, IHaveMtu
        {
            /// <summary>
            /// Address
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-dataflowendpoint.html#cfn-groundstation-dataflowendpointgroup-dataflowendpoint-address
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SocketAddress
            /// </summary>
            public Humidifier.GroundStation.DataflowEndpointGroupTypes.SocketAddress Address { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-dataflowendpoint.html#cfn-groundstation-dataflowendpointgroup-dataflowendpoint-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
            /// <summary>
            /// Mtu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-dataflowendpoint.html#cfn-groundstation-dataflowendpointgroup-dataflowendpoint-mtu
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Mtu { get; set; }
        }

        public class EndpointDetails : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Endpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-endpointdetails.html#cfn-groundstation-dataflowendpointgroup-endpointdetails-endpoint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataflowEndpoint
            /// </summary>
            public Humidifier.GroundStation.DataflowEndpointGroupTypes.DataflowEndpoint Endpoint { get; set; }
            /// <summary>
            /// AwsGroundStationAgentEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-endpointdetails.html#cfn-groundstation-dataflowendpointgroup-endpointdetails-awsgroundstationagentendpoint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AwsGroundStationAgentEndpoint
            /// </summary>
            public Humidifier.GroundStation.DataflowEndpointGroupTypes.AwsGroundStationAgentEndpoint AwsGroundStationAgentEndpoint { get; set; }
            /// <summary>
            /// SecurityDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-endpointdetails.html#cfn-groundstation-dataflowendpointgroup-endpointdetails-securitydetails
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecurityDetails
            /// </summary>
            public Humidifier.GroundStation.DataflowEndpointGroupTypes.SecurityDetails SecurityDetails { get; set; }
        }

        public class IntegerRange : Humidifier.Base.BaseSubResource, IHaveMinimum, IHaveMaximum
        {
            /// <summary>
            /// Minimum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-integerrange.html#cfn-groundstation-dataflowendpointgroup-integerrange-minimum
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Minimum { get; set; }
            /// <summary>
            /// Maximum
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-integerrange.html#cfn-groundstation-dataflowendpointgroup-integerrange-maximum
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Maximum { get; set; }
        }

        public class RangedConnectionDetails : Humidifier.Base.BaseSubResource, IHaveMtu
        {
            /// <summary>
            /// SocketAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-rangedconnectiondetails.html#cfn-groundstation-dataflowendpointgroup-rangedconnectiondetails-socketaddress
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RangedSocketAddress
            /// </summary>
            public Humidifier.GroundStation.DataflowEndpointGroupTypes.RangedSocketAddress SocketAddress { get; set; }
            /// <summary>
            /// Mtu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-rangedconnectiondetails.html#cfn-groundstation-dataflowendpointgroup-rangedconnectiondetails-mtu
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-rangedsocketaddress.html#cfn-groundstation-dataflowendpointgroup-rangedsocketaddress-portrange
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IntegerRange
            /// </summary>
            public Humidifier.GroundStation.DataflowEndpointGroupTypes.IntegerRange PortRange { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-rangedsocketaddress.html#cfn-groundstation-dataflowendpointgroup-rangedsocketaddress-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class SecurityDetails : Humidifier.Base.BaseSubResource, IHaveRoleArn, IHaveSecurityGroupIds, IHaveSubnetIds
        {
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-securitydetails.html#cfn-groundstation-dataflowendpointgroup-securitydetails-subnetids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SubnetIds { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-securitydetails.html#cfn-groundstation-dataflowendpointgroup-securitydetails-securitygroupids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroupIds { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-securitydetails.html#cfn-groundstation-dataflowendpointgroup-securitydetails-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn { get; set; }
        }

        public class SocketAddress : Humidifier.Base.BaseSubResource, IHaveName, IHavePort
        {
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-socketaddress.html#cfn-groundstation-dataflowendpointgroup-socketaddress-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Port { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-dataflowendpointgroup-socketaddress.html#cfn-groundstation-dataflowendpointgroup-socketaddress-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }
    }
}