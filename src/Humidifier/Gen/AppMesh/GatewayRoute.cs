namespace Humidifier.AppMesh
{
    using System.Collections.Generic;
    using GatewayRouteTypes;

    public class GatewayRoute : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags
    {
        public class Attributes
        {
            public static string Uid =  "Uid" ;
            public static string MeshName =  "MeshName" ;
            public static string VirtualGatewayName =  "VirtualGatewayName" ;
            public static string MeshOwner =  "MeshOwner" ;
            public static string ResourceOwner =  "ResourceOwner" ;
            public static string GatewayRouteName =  "GatewayRouteName" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.AppMesh.GatewayRoute; }

        /// <summary>
        /// MeshName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-gatewayroute.html#cfn-appmesh-gatewayroute-meshname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic MeshName { get; set; }

        /// <summary>
        /// VirtualGatewayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-gatewayroute.html#cfn-appmesh-gatewayroute-virtualgatewayname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic VirtualGatewayName { get; set; }
        /// <summary>
        /// MeshOwner
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-gatewayroute.html#cfn-appmesh-gatewayroute-meshowner
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic MeshOwner { get; set; }
        public dynamic GatewayRouteName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// Spec
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-gatewayroute.html#cfn-appmesh-gatewayroute-spec
        /// Required: True
        /// UpdateType: Mutable
        /// Type: GatewayRouteSpec
        /// </summary>
        [Required]
        public GatewayRouteTypes.GatewayRouteSpec Spec { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-gatewayroute.html#cfn-appmesh-gatewayroute-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace GatewayRouteTypes
    {
        public class GatewayRouteHostnameMatch : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Suffix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-gatewayroutehostnamematch.html#cfn-appmesh-gatewayroute-gatewayroutehostnamematch-suffix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Suffix { get; set; }
            /// <summary>
            /// Exact
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-gatewayroutehostnamematch.html#cfn-appmesh-gatewayroute-gatewayroutehostnamematch-exact
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Exact { get; set; }
        }

        public class GatewayRouteHostnameRewrite : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DefaultTargetHostname
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-gatewayroutehostnamerewrite.html#cfn-appmesh-gatewayroute-gatewayroutehostnamerewrite-defaulttargethostname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DefaultTargetHostname { get; set; }
        }

        public class GatewayRouteMetadataMatch : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Suffix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-gatewayroutemetadatamatch.html#cfn-appmesh-gatewayroute-gatewayroutemetadatamatch-suffix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Suffix { get; set; }
            /// <summary>
            /// Regex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-gatewayroutemetadatamatch.html#cfn-appmesh-gatewayroute-gatewayroutemetadatamatch-regex
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Regex { get; set; }
            /// <summary>
            /// Exact
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-gatewayroutemetadatamatch.html#cfn-appmesh-gatewayroute-gatewayroutemetadatamatch-exact
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Exact { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-gatewayroutemetadatamatch.html#cfn-appmesh-gatewayroute-gatewayroutemetadatamatch-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix { get; set; }
            /// <summary>
            /// Range
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-gatewayroutemetadatamatch.html#cfn-appmesh-gatewayroute-gatewayroutemetadatamatch-range
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GatewayRouteRangeMatch
            /// </summary>
            public GatewayRouteTypes.GatewayRouteRangeMatch Range { get; set; }
        }

        public class GatewayRouteRangeMatch : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Start
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-gatewayrouterangematch.html#cfn-appmesh-gatewayroute-gatewayrouterangematch-start
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Start { get; set; }
            /// <summary>
            /// End
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-gatewayrouterangematch.html#cfn-appmesh-gatewayroute-gatewayrouterangematch-end
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic End { get; set; }
        }

        public class GatewayRouteSpec : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// HttpRoute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-gatewayroutespec.html#cfn-appmesh-gatewayroute-gatewayroutespec-httproute
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpGatewayRoute
            /// </summary>
            public GatewayRouteTypes.HttpGatewayRoute HttpRoute { get; set; }
            /// <summary>
            /// Priority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-gatewayroutespec.html#cfn-appmesh-gatewayroute-gatewayroutespec-priority
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Priority { get; set; }
            /// <summary>
            /// Http2Route
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-gatewayroutespec.html#cfn-appmesh-gatewayroute-gatewayroutespec-http2route
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpGatewayRoute
            /// </summary>
            public GatewayRouteTypes.HttpGatewayRoute Http2Route { get; set; }
            /// <summary>
            /// GrpcRoute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-gatewayroutespec.html#cfn-appmesh-gatewayroute-gatewayroutespec-grpcroute
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GrpcGatewayRoute
            /// </summary>
            public GatewayRouteTypes.GrpcGatewayRoute GrpcRoute { get; set; }
        }

        public class GatewayRouteTarget : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-gatewayroutetarget.html#cfn-appmesh-gatewayroute-gatewayroutetarget-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Port { get; set; }
            /// <summary>
            /// VirtualService
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-gatewayroutetarget.html#cfn-appmesh-gatewayroute-gatewayroutetarget-virtualservice
            /// Required: True
            /// UpdateType: Mutable
            /// Type: GatewayRouteVirtualService
            /// </summary>
            public GatewayRouteTypes.GatewayRouteVirtualService VirtualService { get; set; }
        }

        public class GatewayRouteVirtualService : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// VirtualServiceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-gatewayroutevirtualservice.html#cfn-appmesh-gatewayroute-gatewayroutevirtualservice-virtualservicename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VirtualServiceName { get; set; }
        }

        public class GrpcGatewayRoute : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-grpcgatewayroute.html#cfn-appmesh-gatewayroute-grpcgatewayroute-action
            /// Required: True
            /// UpdateType: Mutable
            /// Type: GrpcGatewayRouteAction
            /// </summary>
            public GatewayRouteTypes.GrpcGatewayRouteAction Action { get; set; }
            /// <summary>
            /// Match
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-grpcgatewayroute.html#cfn-appmesh-gatewayroute-grpcgatewayroute-match
            /// Required: True
            /// UpdateType: Mutable
            /// Type: GrpcGatewayRouteMatch
            /// </summary>
            public GatewayRouteTypes.GrpcGatewayRouteMatch Match { get; set; }
        }

        public class GrpcGatewayRouteAction : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Target
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-grpcgatewayrouteaction.html#cfn-appmesh-gatewayroute-grpcgatewayrouteaction-target
            /// Required: True
            /// UpdateType: Mutable
            /// Type: GatewayRouteTarget
            /// </summary>
            public GatewayRouteTypes.GatewayRouteTarget Target { get; set; }
            /// <summary>
            /// Rewrite
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-grpcgatewayrouteaction.html#cfn-appmesh-gatewayroute-grpcgatewayrouteaction-rewrite
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GrpcGatewayRouteRewrite
            /// </summary>
            public GatewayRouteTypes.GrpcGatewayRouteRewrite Rewrite { get; set; }
        }

        public class GrpcGatewayRouteMatch : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ServiceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-grpcgatewayroutematch.html#cfn-appmesh-gatewayroute-grpcgatewayroutematch-servicename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ServiceName { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-grpcgatewayroutematch.html#cfn-appmesh-gatewayroute-grpcgatewayroutematch-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Port { get; set; }
            /// <summary>
            /// Hostname
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-grpcgatewayroutematch.html#cfn-appmesh-gatewayroute-grpcgatewayroutematch-hostname
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GatewayRouteHostnameMatch
            /// </summary>
            public GatewayRouteTypes.GatewayRouteHostnameMatch Hostname { get; set; }
            /// <summary>
            /// Metadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-grpcgatewayroutematch.html#cfn-appmesh-gatewayroute-grpcgatewayroutematch-metadata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: GrpcGatewayRouteMetadata
            /// </summary>
            public List<GatewayRouteTypes.GrpcGatewayRouteMetadata> Metadata { get; set; }
        }

        public class GrpcGatewayRouteMetadata : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Invert
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-grpcgatewayroutemetadata.html#cfn-appmesh-gatewayroute-grpcgatewayroutemetadata-invert
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Invert { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-grpcgatewayroutemetadata.html#cfn-appmesh-gatewayroute-grpcgatewayroutemetadata-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
            /// <summary>
            /// Match
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-grpcgatewayroutemetadata.html#cfn-appmesh-gatewayroute-grpcgatewayroutemetadata-match
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GatewayRouteMetadataMatch
            /// </summary>
            public GatewayRouteTypes.GatewayRouteMetadataMatch Match { get; set; }
        }

        public class GrpcGatewayRouteRewrite : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Hostname
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-grpcgatewayrouterewrite.html#cfn-appmesh-gatewayroute-grpcgatewayrouterewrite-hostname
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GatewayRouteHostnameRewrite
            /// </summary>
            public GatewayRouteTypes.GatewayRouteHostnameRewrite Hostname { get; set; }
        }

        public class HttpGatewayRoute : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-httpgatewayroute.html#cfn-appmesh-gatewayroute-httpgatewayroute-action
            /// Required: True
            /// UpdateType: Mutable
            /// Type: HttpGatewayRouteAction
            /// </summary>
            public GatewayRouteTypes.HttpGatewayRouteAction Action { get; set; }
            /// <summary>
            /// Match
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-httpgatewayroute.html#cfn-appmesh-gatewayroute-httpgatewayroute-match
            /// Required: True
            /// UpdateType: Mutable
            /// Type: HttpGatewayRouteMatch
            /// </summary>
            public GatewayRouteTypes.HttpGatewayRouteMatch Match { get; set; }
        }

        public class HttpGatewayRouteAction : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Target
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-httpgatewayrouteaction.html#cfn-appmesh-gatewayroute-httpgatewayrouteaction-target
            /// Required: True
            /// UpdateType: Mutable
            /// Type: GatewayRouteTarget
            /// </summary>
            public GatewayRouteTypes.GatewayRouteTarget Target { get; set; }
            /// <summary>
            /// Rewrite
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-httpgatewayrouteaction.html#cfn-appmesh-gatewayroute-httpgatewayrouteaction-rewrite
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpGatewayRouteRewrite
            /// </summary>
            public GatewayRouteTypes.HttpGatewayRouteRewrite Rewrite { get; set; }
        }

        public class HttpGatewayRouteHeader : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Invert
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-httpgatewayrouteheader.html#cfn-appmesh-gatewayroute-httpgatewayrouteheader-invert
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Invert { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-httpgatewayrouteheader.html#cfn-appmesh-gatewayroute-httpgatewayrouteheader-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
            /// <summary>
            /// Match
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-httpgatewayrouteheader.html#cfn-appmesh-gatewayroute-httpgatewayrouteheader-match
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpGatewayRouteHeaderMatch
            /// </summary>
            public GatewayRouteTypes.HttpGatewayRouteHeaderMatch Match { get; set; }
        }

        public class HttpGatewayRouteHeaderMatch : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Suffix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-httpgatewayrouteheadermatch.html#cfn-appmesh-gatewayroute-httpgatewayrouteheadermatch-suffix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Suffix { get; set; }
            /// <summary>
            /// Regex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-httpgatewayrouteheadermatch.html#cfn-appmesh-gatewayroute-httpgatewayrouteheadermatch-regex
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Regex { get; set; }
            /// <summary>
            /// Exact
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-httpgatewayrouteheadermatch.html#cfn-appmesh-gatewayroute-httpgatewayrouteheadermatch-exact
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Exact { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-httpgatewayrouteheadermatch.html#cfn-appmesh-gatewayroute-httpgatewayrouteheadermatch-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix { get; set; }
            /// <summary>
            /// Range
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-httpgatewayrouteheadermatch.html#cfn-appmesh-gatewayroute-httpgatewayrouteheadermatch-range
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GatewayRouteRangeMatch
            /// </summary>
            public GatewayRouteTypes.GatewayRouteRangeMatch Range { get; set; }
        }

        public class HttpGatewayRouteMatch : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-httpgatewayroutematch.html#cfn-appmesh-gatewayroute-httpgatewayroutematch-path
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpPathMatch
            /// </summary>
            public GatewayRouteTypes.HttpPathMatch Path { get; set; }
            /// <summary>
            /// Headers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-httpgatewayroutematch.html#cfn-appmesh-gatewayroute-httpgatewayroutematch-headers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: HttpGatewayRouteHeader
            /// </summary>
            public List<GatewayRouteTypes.HttpGatewayRouteHeader> Headers { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-httpgatewayroutematch.html#cfn-appmesh-gatewayroute-httpgatewayroutematch-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Port { get; set; }
            /// <summary>
            /// Hostname
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-httpgatewayroutematch.html#cfn-appmesh-gatewayroute-httpgatewayroutematch-hostname
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GatewayRouteHostnameMatch
            /// </summary>
            public GatewayRouteTypes.GatewayRouteHostnameMatch Hostname { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-httpgatewayroutematch.html#cfn-appmesh-gatewayroute-httpgatewayroutematch-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix { get; set; }
            /// <summary>
            /// Method
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-httpgatewayroutematch.html#cfn-appmesh-gatewayroute-httpgatewayroutematch-method
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Method { get; set; }
            /// <summary>
            /// QueryParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-httpgatewayroutematch.html#cfn-appmesh-gatewayroute-httpgatewayroutematch-queryparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: QueryParameter
            /// </summary>
            public List<GatewayRouteTypes.QueryParameter> QueryParameters { get; set; }
        }

        public class HttpGatewayRoutePathRewrite : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Exact
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-httpgatewayroutepathrewrite.html#cfn-appmesh-gatewayroute-httpgatewayroutepathrewrite-exact
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Exact { get; set; }
        }

        public class HttpGatewayRoutePrefixRewrite : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-httpgatewayrouteprefixrewrite.html#cfn-appmesh-gatewayroute-httpgatewayrouteprefixrewrite-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// DefaultPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-httpgatewayrouteprefixrewrite.html#cfn-appmesh-gatewayroute-httpgatewayrouteprefixrewrite-defaultprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DefaultPrefix { get; set; }
        }

        public class HttpGatewayRouteRewrite : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-httpgatewayrouterewrite.html#cfn-appmesh-gatewayroute-httpgatewayrouterewrite-path
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpGatewayRoutePathRewrite
            /// </summary>
            public GatewayRouteTypes.HttpGatewayRoutePathRewrite Path { get; set; }
            /// <summary>
            /// Hostname
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-httpgatewayrouterewrite.html#cfn-appmesh-gatewayroute-httpgatewayrouterewrite-hostname
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GatewayRouteHostnameRewrite
            /// </summary>
            public GatewayRouteTypes.GatewayRouteHostnameRewrite Hostname { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-httpgatewayrouterewrite.html#cfn-appmesh-gatewayroute-httpgatewayrouterewrite-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpGatewayRoutePrefixRewrite
            /// </summary>
            public GatewayRouteTypes.HttpGatewayRoutePrefixRewrite Prefix { get; set; }
        }

        public class HttpPathMatch : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Regex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-httppathmatch.html#cfn-appmesh-gatewayroute-httppathmatch-regex
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Regex { get; set; }
            /// <summary>
            /// Exact
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-httppathmatch.html#cfn-appmesh-gatewayroute-httppathmatch-exact
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Exact { get; set; }
        }

        public class HttpQueryParameterMatch : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Exact
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-httpqueryparametermatch.html#cfn-appmesh-gatewayroute-httpqueryparametermatch-exact
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Exact { get; set; }
        }

        public class QueryParameter : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-queryparameter.html#cfn-appmesh-gatewayroute-queryparameter-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
            /// <summary>
            /// Match
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-gatewayroute-queryparameter.html#cfn-appmesh-gatewayroute-queryparameter-match
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpQueryParameterMatch
            /// </summary>
            public GatewayRouteTypes.HttpQueryParameterMatch Match { get; set; }
        }
    }
}