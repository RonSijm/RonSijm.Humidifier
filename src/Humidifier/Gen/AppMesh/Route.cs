namespace Humidifier.AppMesh
{
    using System.Collections.Generic;
    using RouteTypes;

    public class Route : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveMeshName, IHaveMeshOwner, IHaveVirtualRouterName
    {
        public class Attributes
        {
            public static string Uid =  "Uid" ;
            public static string MeshName =  "MeshName" ;
            public static string VirtualRouterName =  "VirtualRouterName" ;
            public static string MeshOwner =  "MeshOwner" ;
            public static string ResourceOwner =  "ResourceOwner" ;
            public static string RouteName =  "RouteName" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.AppMesh.Route; }

        /// <summary>
        /// MeshName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-route.html#cfn-appmesh-route-meshname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic MeshName { get; set; }

        /// <summary>
        /// VirtualRouterName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-route.html#cfn-appmesh-route-virtualroutername
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic VirtualRouterName { get; set; }
        /// <summary>
        /// MeshOwner
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-route.html#cfn-appmesh-route-meshowner
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic MeshOwner { get; set; }
        public dynamic RouteName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// Spec
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-route.html#cfn-appmesh-route-spec
        /// Required: True
        /// UpdateType: Mutable
        /// Type: RouteSpec
        /// </summary>
        [Required]
        public Humidifier.AppMesh.RouteTypes.RouteSpec Spec { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-route.html#cfn-appmesh-route-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace RouteTypes
    {
        public class Duration : Humidifier.Base.BaseSubResource, IHaveValue, IHaveUnit
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-duration.html#cfn-appmesh-route-duration-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-duration.html#cfn-appmesh-route-duration-unit
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Unit { get; set; }
        }

        public class GrpcRetryPolicy : Humidifier.Base.BaseSubResource, IHaveMaxRetries, IHaveAppMeshRouteTypesDurationPerRetryTimeout, IHaveHttpRetryEvents, IHaveTcpRetryEvents
        {
            /// <summary>
            /// MaxRetries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcretrypolicy.html#cfn-appmesh-route-grpcretrypolicy-maxretries
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxRetries { get; set; }
            /// <summary>
            /// PerRetryTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcretrypolicy.html#cfn-appmesh-route-grpcretrypolicy-perretrytimeout
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Duration
            /// </summary>
            public Humidifier.AppMesh.RouteTypes.Duration PerRetryTimeout { get; set; }
            /// <summary>
            /// GrpcRetryEvents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcretrypolicy.html#cfn-appmesh-route-grpcretrypolicy-grpcretryevents
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic GrpcRetryEvents { get; set; }
            /// <summary>
            /// HttpRetryEvents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcretrypolicy.html#cfn-appmesh-route-grpcretrypolicy-httpretryevents
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic HttpRetryEvents { get; set; }
            /// <summary>
            /// TcpRetryEvents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcretrypolicy.html#cfn-appmesh-route-grpcretrypolicy-tcpretryevents
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic TcpRetryEvents { get; set; }
        }

        public class GrpcRoute : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroute.html#cfn-appmesh-route-grpcroute-action
            /// Required: True
            /// UpdateType: Mutable
            /// Type: GrpcRouteAction
            /// </summary>
            public Humidifier.AppMesh.RouteTypes.GrpcRouteAction Action { get; set; }
            /// <summary>
            /// Timeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroute.html#cfn-appmesh-route-grpcroute-timeout
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GrpcTimeout
            /// </summary>
            public Humidifier.AppMesh.RouteTypes.GrpcTimeout Timeout { get; set; }
            /// <summary>
            /// RetryPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroute.html#cfn-appmesh-route-grpcroute-retrypolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GrpcRetryPolicy
            /// </summary>
            public Humidifier.AppMesh.RouteTypes.GrpcRetryPolicy RetryPolicy { get; set; }
            /// <summary>
            /// Match
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroute.html#cfn-appmesh-route-grpcroute-match
            /// Required: True
            /// UpdateType: Mutable
            /// Type: GrpcRouteMatch
            /// </summary>
            public Humidifier.AppMesh.RouteTypes.GrpcRouteMatch Match { get; set; }
        }

        public class GrpcRouteAction : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// WeightedTargets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcrouteaction.html#cfn-appmesh-route-grpcrouteaction-weightedtargets
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: WeightedTarget
            /// </summary>
            public List<Humidifier.AppMesh.RouteTypes.WeightedTarget> WeightedTargets { get; set; }
        }

        public class GrpcRouteMatch : Humidifier.Base.BaseSubResource, IHavePort, IHaveServiceName
        {
            /// <summary>
            /// ServiceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroutematch.html#cfn-appmesh-route-grpcroutematch-servicename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ServiceName { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroutematch.html#cfn-appmesh-route-grpcroutematch-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Port { get; set; }
            /// <summary>
            /// Metadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroutematch.html#cfn-appmesh-route-grpcroutematch-metadata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: GrpcRouteMetadata
            /// </summary>
            public List<Humidifier.AppMesh.RouteTypes.GrpcRouteMetadata> Metadata { get; set; }
            /// <summary>
            /// MethodName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroutematch.html#cfn-appmesh-route-grpcroutematch-methodname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MethodName { get; set; }
        }

        public class GrpcRouteMetadata : Humidifier.Base.BaseSubResource, IHaveName, IHaveInvert
        {
            /// <summary>
            /// Invert
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroutemetadata.html#cfn-appmesh-route-grpcroutemetadata-invert
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Invert { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroutemetadata.html#cfn-appmesh-route-grpcroutemetadata-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
            /// <summary>
            /// Match
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroutemetadata.html#cfn-appmesh-route-grpcroutemetadata-match
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GrpcRouteMetadataMatchMethod
            /// </summary>
            public Humidifier.AppMesh.RouteTypes.GrpcRouteMetadataMatchMethod Match { get; set; }
        }

        public class GrpcRouteMetadataMatchMethod : Humidifier.Base.BaseSubResource, IHavePrefix, IHaveSuffix, IHaveExact, IHaveRegex, IHaveAppMeshRouteTypesMatchRangeRange
        {
            /// <summary>
            /// Suffix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroutemetadatamatchmethod.html#cfn-appmesh-route-grpcroutemetadatamatchmethod-suffix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Suffix { get; set; }
            /// <summary>
            /// Regex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroutemetadatamatchmethod.html#cfn-appmesh-route-grpcroutemetadatamatchmethod-regex
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Regex { get; set; }
            /// <summary>
            /// Exact
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroutemetadatamatchmethod.html#cfn-appmesh-route-grpcroutemetadatamatchmethod-exact
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Exact { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroutemetadatamatchmethod.html#cfn-appmesh-route-grpcroutemetadatamatchmethod-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix { get; set; }
            /// <summary>
            /// Range
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroutemetadatamatchmethod.html#cfn-appmesh-route-grpcroutemetadatamatchmethod-range
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MatchRange
            /// </summary>
            public Humidifier.AppMesh.RouteTypes.MatchRange Range { get; set; }
        }

        public class GrpcTimeout : Humidifier.Base.BaseSubResource, IHaveAppMeshRouteTypesDurationIdle, IHaveAppMeshRouteTypesDurationPerRequest
        {
            /// <summary>
            /// PerRequest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpctimeout.html#cfn-appmesh-route-grpctimeout-perrequest
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Duration
            /// </summary>
            public Humidifier.AppMesh.RouteTypes.Duration PerRequest { get; set; }
            /// <summary>
            /// Idle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpctimeout.html#cfn-appmesh-route-grpctimeout-idle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Duration
            /// </summary>
            public Humidifier.AppMesh.RouteTypes.Duration Idle { get; set; }
        }

        public class HeaderMatchMethod : Humidifier.Base.BaseSubResource, IHavePrefix, IHaveSuffix, IHaveExact, IHaveRegex, IHaveAppMeshRouteTypesMatchRangeRange
        {
            /// <summary>
            /// Suffix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-headermatchmethod.html#cfn-appmesh-route-headermatchmethod-suffix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Suffix { get; set; }
            /// <summary>
            /// Regex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-headermatchmethod.html#cfn-appmesh-route-headermatchmethod-regex
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Regex { get; set; }
            /// <summary>
            /// Exact
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-headermatchmethod.html#cfn-appmesh-route-headermatchmethod-exact
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Exact { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-headermatchmethod.html#cfn-appmesh-route-headermatchmethod-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix { get; set; }
            /// <summary>
            /// Range
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-headermatchmethod.html#cfn-appmesh-route-headermatchmethod-range
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MatchRange
            /// </summary>
            public Humidifier.AppMesh.RouteTypes.MatchRange Range { get; set; }
        }

        public class HttpPathMatch : Humidifier.Base.BaseSubResource, IHaveExact, IHaveRegex
        {
            /// <summary>
            /// Regex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httppathmatch.html#cfn-appmesh-route-httppathmatch-regex
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Regex { get; set; }
            /// <summary>
            /// Exact
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httppathmatch.html#cfn-appmesh-route-httppathmatch-exact
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Exact { get; set; }
        }

        public class HttpQueryParameterMatch : Humidifier.Base.BaseSubResource, IHaveExact
        {
            /// <summary>
            /// Exact
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httpqueryparametermatch.html#cfn-appmesh-route-httpqueryparametermatch-exact
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Exact { get; set; }
        }

        public class HttpRetryPolicy : Humidifier.Base.BaseSubResource, IHaveMaxRetries, IHaveAppMeshRouteTypesDurationPerRetryTimeout, IHaveHttpRetryEvents, IHaveTcpRetryEvents
        {
            /// <summary>
            /// MaxRetries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httpretrypolicy.html#cfn-appmesh-route-httpretrypolicy-maxretries
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxRetries { get; set; }
            /// <summary>
            /// PerRetryTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httpretrypolicy.html#cfn-appmesh-route-httpretrypolicy-perretrytimeout
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Duration
            /// </summary>
            public Humidifier.AppMesh.RouteTypes.Duration PerRetryTimeout { get; set; }
            /// <summary>
            /// HttpRetryEvents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httpretrypolicy.html#cfn-appmesh-route-httpretrypolicy-httpretryevents
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic HttpRetryEvents { get; set; }
            /// <summary>
            /// TcpRetryEvents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httpretrypolicy.html#cfn-appmesh-route-httpretrypolicy-tcpretryevents
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic TcpRetryEvents { get; set; }
        }

        public class HttpRoute : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httproute.html#cfn-appmesh-route-httproute-action
            /// Required: True
            /// UpdateType: Mutable
            /// Type: HttpRouteAction
            /// </summary>
            public Humidifier.AppMesh.RouteTypes.HttpRouteAction Action { get; set; }
            /// <summary>
            /// Timeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httproute.html#cfn-appmesh-route-httproute-timeout
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpTimeout
            /// </summary>
            public Humidifier.AppMesh.RouteTypes.HttpTimeout Timeout { get; set; }
            /// <summary>
            /// RetryPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httproute.html#cfn-appmesh-route-httproute-retrypolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpRetryPolicy
            /// </summary>
            public Humidifier.AppMesh.RouteTypes.HttpRetryPolicy RetryPolicy { get; set; }
            /// <summary>
            /// Match
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httproute.html#cfn-appmesh-route-httproute-match
            /// Required: True
            /// UpdateType: Mutable
            /// Type: HttpRouteMatch
            /// </summary>
            public Humidifier.AppMesh.RouteTypes.HttpRouteMatch Match { get; set; }
        }

        public class HttpRouteAction : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// WeightedTargets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httprouteaction.html#cfn-appmesh-route-httprouteaction-weightedtargets
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: WeightedTarget
            /// </summary>
            public List<Humidifier.AppMesh.RouteTypes.WeightedTarget> WeightedTargets { get; set; }
        }

        public class HttpRouteHeader : Humidifier.Base.BaseSubResource, IHaveName, IHaveInvert
        {
            /// <summary>
            /// Invert
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httprouteheader.html#cfn-appmesh-route-httprouteheader-invert
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Invert { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httprouteheader.html#cfn-appmesh-route-httprouteheader-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
            /// <summary>
            /// Match
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httprouteheader.html#cfn-appmesh-route-httprouteheader-match
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HeaderMatchMethod
            /// </summary>
            public Humidifier.AppMesh.RouteTypes.HeaderMatchMethod Match { get; set; }
        }

        public class HttpRouteMatch : Humidifier.Base.BaseSubResource, IHavePort, IHavePrefix, IHaveMethod, IHaveScheme
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httproutematch.html#cfn-appmesh-route-httproutematch-path
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpPathMatch
            /// </summary>
            public Humidifier.AppMesh.RouteTypes.HttpPathMatch Path { get; set; }
            /// <summary>
            /// Scheme
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httproutematch.html#cfn-appmesh-route-httproutematch-scheme
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Scheme { get; set; }
            /// <summary>
            /// Headers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httproutematch.html#cfn-appmesh-route-httproutematch-headers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: HttpRouteHeader
            /// </summary>
            public List<Humidifier.AppMesh.RouteTypes.HttpRouteHeader> Headers { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httproutematch.html#cfn-appmesh-route-httproutematch-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Port { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httproutematch.html#cfn-appmesh-route-httproutematch-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix { get; set; }
            /// <summary>
            /// Method
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httproutematch.html#cfn-appmesh-route-httproutematch-method
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Method { get; set; }
            /// <summary>
            /// QueryParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httproutematch.html#cfn-appmesh-route-httproutematch-queryparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: QueryParameter
            /// </summary>
            public List<Humidifier.AppMesh.RouteTypes.QueryParameter> QueryParameters { get; set; }
        }

        public class HttpTimeout : Humidifier.Base.BaseSubResource, IHaveAppMeshRouteTypesDurationIdle, IHaveAppMeshRouteTypesDurationPerRequest
        {
            /// <summary>
            /// PerRequest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httptimeout.html#cfn-appmesh-route-httptimeout-perrequest
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Duration
            /// </summary>
            public Humidifier.AppMesh.RouteTypes.Duration PerRequest { get; set; }
            /// <summary>
            /// Idle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httptimeout.html#cfn-appmesh-route-httptimeout-idle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Duration
            /// </summary>
            public Humidifier.AppMesh.RouteTypes.Duration Idle { get; set; }
        }

        public class MatchRange : Humidifier.Base.BaseSubResource, IHaveEnd, IHaveStart
        {
            /// <summary>
            /// Start
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-matchrange.html#cfn-appmesh-route-matchrange-start
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Start { get; set; }
            /// <summary>
            /// End
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-matchrange.html#cfn-appmesh-route-matchrange-end
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic End { get; set; }
        }

        public class QueryParameter : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-queryparameter.html#cfn-appmesh-route-queryparameter-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
            /// <summary>
            /// Match
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-queryparameter.html#cfn-appmesh-route-queryparameter-match
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpQueryParameterMatch
            /// </summary>
            public Humidifier.AppMesh.RouteTypes.HttpQueryParameterMatch Match { get; set; }
        }

        public class RouteSpec : Humidifier.Base.BaseSubResource, IHavePriority
        {
            /// <summary>
            /// HttpRoute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-routespec.html#cfn-appmesh-route-routespec-httproute
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpRoute
            /// </summary>
            public Humidifier.AppMesh.RouteTypes.HttpRoute HttpRoute { get; set; }
            /// <summary>
            /// Priority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-routespec.html#cfn-appmesh-route-routespec-priority
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Priority { get; set; }
            /// <summary>
            /// Http2Route
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-routespec.html#cfn-appmesh-route-routespec-http2route
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpRoute
            /// </summary>
            public Humidifier.AppMesh.RouteTypes.HttpRoute Http2Route { get; set; }
            /// <summary>
            /// GrpcRoute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-routespec.html#cfn-appmesh-route-routespec-grpcroute
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GrpcRoute
            /// </summary>
            public Humidifier.AppMesh.RouteTypes.GrpcRoute GrpcRoute { get; set; }
            /// <summary>
            /// TcpRoute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-routespec.html#cfn-appmesh-route-routespec-tcproute
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TcpRoute
            /// </summary>
            public Humidifier.AppMesh.RouteTypes.TcpRoute TcpRoute { get; set; }
        }

        public class TcpRoute : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-tcproute.html#cfn-appmesh-route-tcproute-action
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TcpRouteAction
            /// </summary>
            public Humidifier.AppMesh.RouteTypes.TcpRouteAction Action { get; set; }
            /// <summary>
            /// Timeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-tcproute.html#cfn-appmesh-route-tcproute-timeout
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TcpTimeout
            /// </summary>
            public Humidifier.AppMesh.RouteTypes.TcpTimeout Timeout { get; set; }
            /// <summary>
            /// Match
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-tcproute.html#cfn-appmesh-route-tcproute-match
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TcpRouteMatch
            /// </summary>
            public Humidifier.AppMesh.RouteTypes.TcpRouteMatch Match { get; set; }
        }

        public class TcpRouteAction : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// WeightedTargets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-tcprouteaction.html#cfn-appmesh-route-tcprouteaction-weightedtargets
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: WeightedTarget
            /// </summary>
            public List<Humidifier.AppMesh.RouteTypes.WeightedTarget> WeightedTargets { get; set; }
        }

        public class TcpRouteMatch : Humidifier.Base.BaseSubResource, IHavePort
        {
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-tcproutematch.html#cfn-appmesh-route-tcproutematch-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Port { get; set; }
        }

        public class TcpTimeout : Humidifier.Base.BaseSubResource, IHaveAppMeshRouteTypesDurationIdle
        {
            /// <summary>
            /// Idle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-tcptimeout.html#cfn-appmesh-route-tcptimeout-idle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Duration
            /// </summary>
            public Humidifier.AppMesh.RouteTypes.Duration Idle { get; set; }
        }

        public class WeightedTarget : Humidifier.Base.BaseSubResource, IHavePort, IHaveWeight
        {
            /// <summary>
            /// VirtualNode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-weightedtarget.html#cfn-appmesh-route-weightedtarget-virtualnode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VirtualNode { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-weightedtarget.html#cfn-appmesh-route-weightedtarget-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Port { get; set; }
            /// <summary>
            /// Weight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-weightedtarget.html#cfn-appmesh-route-weightedtarget-weight
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Weight { get; set; }
        }
    }
}