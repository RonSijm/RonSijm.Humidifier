namespace Humidifier.AppMesh
{
    using global::System.Collections.Generic;
    using RouteTypes;

    public class Route : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveMeshName, IHaveVirtualRouterName, IHaveMeshOwner, IHaveRouteName, IHaveAppMeshRouteTypesRouteSpecSpec
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
        public Union<string, BaseFunction>? MeshName { get; set; }

        /// <summary>
        /// VirtualRouterName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-route.html#cfn-appmesh-route-virtualroutername
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? VirtualRouterName { get; set; }
        /// <summary>
        /// MeshOwner
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-route.html#cfn-appmesh-route-meshowner
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? MeshOwner { get; set; }
        public Union<string, BaseFunction>? RouteName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// Spec
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-route.html#cfn-appmesh-route-spec
        /// Required: True
        /// UpdateType: Mutable
        /// Type: RouteSpec
        /// </summary>
        [Required]
        public Union<Humidifier.AppMesh.RouteTypes.RouteSpec, BaseFunction>? Spec { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-route.html#cfn-appmesh-route-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace RouteTypes
    {
        public class Duration : Humidifier.Base.BaseSubResource, IHaveValue_Integer, IHaveUnit
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-duration.html#cfn-appmesh-route-duration-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-duration.html#cfn-appmesh-route-duration-unit
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Unit { get; set; }
        }

        public class GrpcRetryPolicy : Humidifier.Base.BaseSubResource, IHaveMaxRetries_Integer, IHaveAppMeshRouteTypesDurationPerRetryTimeout, IHaveStringListOfGrpcRetryEvents, IHaveStringListOfHttpRetryEvents, IHaveStringListOfTcpRetryEvents
        {
            /// <summary>
            /// MaxRetries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcretrypolicy.html#cfn-appmesh-route-grpcretrypolicy-maxretries
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxRetries { get; set; }
            /// <summary>
            /// PerRetryTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcretrypolicy.html#cfn-appmesh-route-grpcretrypolicy-perretrytimeout
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Duration
            /// </summary>
            public Union<Humidifier.AppMesh.RouteTypes.Duration, BaseFunction>? PerRetryTimeout { get; set; }
            /// <summary>
            /// GrpcRetryEvents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcretrypolicy.html#cfn-appmesh-route-grpcretrypolicy-grpcretryevents
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? GrpcRetryEvents { get; set; }
            /// <summary>
            /// HttpRetryEvents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcretrypolicy.html#cfn-appmesh-route-grpcretrypolicy-httpretryevents
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? HttpRetryEvents { get; set; }
            /// <summary>
            /// TcpRetryEvents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcretrypolicy.html#cfn-appmesh-route-grpcretrypolicy-tcpretryevents
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? TcpRetryEvents { get; set; }
        }

        public class GrpcRoute : Humidifier.Base.BaseSubResource, IHaveAppMeshRouteTypesGrpcRouteActionAction, IHaveAppMeshRouteTypesGrpcTimeoutTimeout, IHaveAppMeshRouteTypesGrpcRetryPolicyRetryPolicy, IHaveAppMeshRouteTypesGrpcRouteMatchMatch
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroute.html#cfn-appmesh-route-grpcroute-action
            /// Required: True
            /// UpdateType: Mutable
            /// Type: GrpcRouteAction
            /// </summary>
            public Union<Humidifier.AppMesh.RouteTypes.GrpcRouteAction, BaseFunction>? Action { get; set; }
            /// <summary>
            /// Timeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroute.html#cfn-appmesh-route-grpcroute-timeout
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GrpcTimeout
            /// </summary>
            public Union<Humidifier.AppMesh.RouteTypes.GrpcTimeout, BaseFunction>? Timeout { get; set; }
            /// <summary>
            /// RetryPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroute.html#cfn-appmesh-route-grpcroute-retrypolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GrpcRetryPolicy
            /// </summary>
            public Union<Humidifier.AppMesh.RouteTypes.GrpcRetryPolicy, BaseFunction>? RetryPolicy { get; set; }
            /// <summary>
            /// Match
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroute.html#cfn-appmesh-route-grpcroute-match
            /// Required: True
            /// UpdateType: Mutable
            /// Type: GrpcRouteMatch
            /// </summary>
            public Union<Humidifier.AppMesh.RouteTypes.GrpcRouteMatch, BaseFunction>? Match { get; set; }
        }

        public class GrpcRouteAction : Humidifier.Base.BaseSubResource, IHaveListOfAppMeshRouteTypesWeightedTargetWeightedTargets
        {
            /// <summary>
            /// WeightedTargets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcrouteaction.html#cfn-appmesh-route-grpcrouteaction-weightedtargets
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: WeightedTarget
            /// </summary>
            public Union<IReadOnlyList<Humidifier.AppMesh.RouteTypes.WeightedTarget>, IReadOnlyList<Union<Humidifier.AppMesh.RouteTypes.WeightedTarget, BaseFunction>>, BaseFunction>? WeightedTargets { get; set; }
        }

        public class GrpcRouteMatch : Humidifier.Base.BaseSubResource, IHaveServiceName, IHavePort_Integer, IHaveListOfAppMeshRouteTypesGrpcRouteMetadataMetadata, IHaveMethodName
        {
            /// <summary>
            /// ServiceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroutematch.html#cfn-appmesh-route-grpcroutematch-servicename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServiceName { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroutematch.html#cfn-appmesh-route-grpcroutematch-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Port { get; set; }
            /// <summary>
            /// Metadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroutematch.html#cfn-appmesh-route-grpcroutematch-metadata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: GrpcRouteMetadata
            /// </summary>
            public Union<IReadOnlyList<Humidifier.AppMesh.RouteTypes.GrpcRouteMetadata>, IReadOnlyList<Union<Humidifier.AppMesh.RouteTypes.GrpcRouteMetadata, BaseFunction>>, BaseFunction>? Metadata { get; set; }
            /// <summary>
            /// MethodName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroutematch.html#cfn-appmesh-route-grpcroutematch-methodname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MethodName { get; set; }
        }

        public class GrpcRouteMetadata : Humidifier.Base.BaseSubResource, IHaveInvert_Boolean, IHaveName, IHaveAppMeshRouteTypesGrpcRouteMetadataMatchMethodMatch
        {
            /// <summary>
            /// Invert
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroutemetadata.html#cfn-appmesh-route-grpcroutemetadata-invert
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Invert { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroutemetadata.html#cfn-appmesh-route-grpcroutemetadata-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
            /// <summary>
            /// Match
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroutemetadata.html#cfn-appmesh-route-grpcroutemetadata-match
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GrpcRouteMetadataMatchMethod
            /// </summary>
            public Union<Humidifier.AppMesh.RouteTypes.GrpcRouteMetadataMatchMethod, BaseFunction>? Match { get; set; }
        }

        public class GrpcRouteMetadataMatchMethod : Humidifier.Base.BaseSubResource, IHaveSuffix, IHaveRegex, IHaveExact, IHavePrefix, IHaveAppMeshRouteTypesMatchRangeRange
        {
            /// <summary>
            /// Suffix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroutemetadatamatchmethod.html#cfn-appmesh-route-grpcroutemetadatamatchmethod-suffix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Suffix { get; set; }
            /// <summary>
            /// Regex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroutemetadatamatchmethod.html#cfn-appmesh-route-grpcroutemetadatamatchmethod-regex
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Regex { get; set; }
            /// <summary>
            /// Exact
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroutemetadatamatchmethod.html#cfn-appmesh-route-grpcroutemetadatamatchmethod-exact
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Exact { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroutemetadatamatchmethod.html#cfn-appmesh-route-grpcroutemetadatamatchmethod-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Prefix { get; set; }
            /// <summary>
            /// Range
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpcroutemetadatamatchmethod.html#cfn-appmesh-route-grpcroutemetadatamatchmethod-range
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MatchRange
            /// </summary>
            public Union<Humidifier.AppMesh.RouteTypes.MatchRange, BaseFunction>? Range { get; set; }
        }

        public class GrpcTimeout : Humidifier.Base.BaseSubResource, IHaveAppMeshRouteTypesDurationPerRequest, IHaveAppMeshRouteTypesDurationIdle
        {
            /// <summary>
            /// PerRequest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpctimeout.html#cfn-appmesh-route-grpctimeout-perrequest
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Duration
            /// </summary>
            public Union<Humidifier.AppMesh.RouteTypes.Duration, BaseFunction>? PerRequest { get; set; }
            /// <summary>
            /// Idle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-grpctimeout.html#cfn-appmesh-route-grpctimeout-idle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Duration
            /// </summary>
            public Union<Humidifier.AppMesh.RouteTypes.Duration, BaseFunction>? Idle { get; set; }
        }

        public class HeaderMatchMethod : Humidifier.Base.BaseSubResource, IHaveSuffix, IHaveRegex, IHaveExact, IHavePrefix, IHaveAppMeshRouteTypesMatchRangeRange
        {
            /// <summary>
            /// Suffix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-headermatchmethod.html#cfn-appmesh-route-headermatchmethod-suffix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Suffix { get; set; }
            /// <summary>
            /// Regex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-headermatchmethod.html#cfn-appmesh-route-headermatchmethod-regex
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Regex { get; set; }
            /// <summary>
            /// Exact
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-headermatchmethod.html#cfn-appmesh-route-headermatchmethod-exact
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Exact { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-headermatchmethod.html#cfn-appmesh-route-headermatchmethod-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Prefix { get; set; }
            /// <summary>
            /// Range
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-headermatchmethod.html#cfn-appmesh-route-headermatchmethod-range
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MatchRange
            /// </summary>
            public Union<Humidifier.AppMesh.RouteTypes.MatchRange, BaseFunction>? Range { get; set; }
        }

        public class HttpPathMatch : Humidifier.Base.BaseSubResource, IHaveRegex, IHaveExact
        {
            /// <summary>
            /// Regex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httppathmatch.html#cfn-appmesh-route-httppathmatch-regex
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Regex { get; set; }
            /// <summary>
            /// Exact
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httppathmatch.html#cfn-appmesh-route-httppathmatch-exact
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Exact { get; set; }
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
            public Union<string, BaseFunction>? Exact { get; set; }
        }

        public class HttpRetryPolicy : Humidifier.Base.BaseSubResource, IHaveMaxRetries_Integer, IHaveAppMeshRouteTypesDurationPerRetryTimeout, IHaveStringListOfHttpRetryEvents, IHaveStringListOfTcpRetryEvents
        {
            /// <summary>
            /// MaxRetries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httpretrypolicy.html#cfn-appmesh-route-httpretrypolicy-maxretries
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxRetries { get; set; }
            /// <summary>
            /// PerRetryTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httpretrypolicy.html#cfn-appmesh-route-httpretrypolicy-perretrytimeout
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Duration
            /// </summary>
            public Union<Humidifier.AppMesh.RouteTypes.Duration, BaseFunction>? PerRetryTimeout { get; set; }
            /// <summary>
            /// HttpRetryEvents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httpretrypolicy.html#cfn-appmesh-route-httpretrypolicy-httpretryevents
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? HttpRetryEvents { get; set; }
            /// <summary>
            /// TcpRetryEvents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httpretrypolicy.html#cfn-appmesh-route-httpretrypolicy-tcpretryevents
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? TcpRetryEvents { get; set; }
        }

        public class HttpRoute : Humidifier.Base.BaseSubResource, IHaveAppMeshRouteTypesHttpRouteActionAction, IHaveAppMeshRouteTypesHttpTimeoutTimeout, IHaveAppMeshRouteTypesHttpRetryPolicyRetryPolicy, IHaveAppMeshRouteTypesHttpRouteMatchMatch
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httproute.html#cfn-appmesh-route-httproute-action
            /// Required: True
            /// UpdateType: Mutable
            /// Type: HttpRouteAction
            /// </summary>
            public Union<Humidifier.AppMesh.RouteTypes.HttpRouteAction, BaseFunction>? Action { get; set; }
            /// <summary>
            /// Timeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httproute.html#cfn-appmesh-route-httproute-timeout
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpTimeout
            /// </summary>
            public Union<Humidifier.AppMesh.RouteTypes.HttpTimeout, BaseFunction>? Timeout { get; set; }
            /// <summary>
            /// RetryPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httproute.html#cfn-appmesh-route-httproute-retrypolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpRetryPolicy
            /// </summary>
            public Union<Humidifier.AppMesh.RouteTypes.HttpRetryPolicy, BaseFunction>? RetryPolicy { get; set; }
            /// <summary>
            /// Match
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httproute.html#cfn-appmesh-route-httproute-match
            /// Required: True
            /// UpdateType: Mutable
            /// Type: HttpRouteMatch
            /// </summary>
            public Union<Humidifier.AppMesh.RouteTypes.HttpRouteMatch, BaseFunction>? Match { get; set; }
        }

        public class HttpRouteAction : Humidifier.Base.BaseSubResource, IHaveListOfAppMeshRouteTypesWeightedTargetWeightedTargets
        {
            /// <summary>
            /// WeightedTargets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httprouteaction.html#cfn-appmesh-route-httprouteaction-weightedtargets
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: WeightedTarget
            /// </summary>
            public Union<IReadOnlyList<Humidifier.AppMesh.RouteTypes.WeightedTarget>, IReadOnlyList<Union<Humidifier.AppMesh.RouteTypes.WeightedTarget, BaseFunction>>, BaseFunction>? WeightedTargets { get; set; }
        }

        public class HttpRouteHeader : Humidifier.Base.BaseSubResource, IHaveInvert_Boolean, IHaveName, IHaveAppMeshRouteTypesHeaderMatchMethodMatch
        {
            /// <summary>
            /// Invert
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httprouteheader.html#cfn-appmesh-route-httprouteheader-invert
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Invert { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httprouteheader.html#cfn-appmesh-route-httprouteheader-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
            /// <summary>
            /// Match
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httprouteheader.html#cfn-appmesh-route-httprouteheader-match
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HeaderMatchMethod
            /// </summary>
            public Union<Humidifier.AppMesh.RouteTypes.HeaderMatchMethod, BaseFunction>? Match { get; set; }
        }

        public class HttpRouteMatch : Humidifier.Base.BaseSubResource, IHaveAppMeshRouteTypesHttpPathMatchPath, IHaveScheme, IHaveListOfAppMeshRouteTypesHttpRouteHeaderHeaders, IHavePort_Integer, IHavePrefix, IHaveMethod, IHaveListOfAppMeshRouteTypesQueryParameterQueryParameters
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httproutematch.html#cfn-appmesh-route-httproutematch-path
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpPathMatch
            /// </summary>
            public Union<Humidifier.AppMesh.RouteTypes.HttpPathMatch, BaseFunction>? Path { get; set; }
            /// <summary>
            /// Scheme
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httproutematch.html#cfn-appmesh-route-httproutematch-scheme
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Scheme { get; set; }
            /// <summary>
            /// Headers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httproutematch.html#cfn-appmesh-route-httproutematch-headers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: HttpRouteHeader
            /// </summary>
            public Union<IReadOnlyList<Humidifier.AppMesh.RouteTypes.HttpRouteHeader>, IReadOnlyList<Union<Humidifier.AppMesh.RouteTypes.HttpRouteHeader, BaseFunction>>, BaseFunction>? Headers { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httproutematch.html#cfn-appmesh-route-httproutematch-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Port { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httproutematch.html#cfn-appmesh-route-httproutematch-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Prefix { get; set; }
            /// <summary>
            /// Method
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httproutematch.html#cfn-appmesh-route-httproutematch-method
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Method { get; set; }
            /// <summary>
            /// QueryParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httproutematch.html#cfn-appmesh-route-httproutematch-queryparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: QueryParameter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.AppMesh.RouteTypes.QueryParameter>, IReadOnlyList<Union<Humidifier.AppMesh.RouteTypes.QueryParameter, BaseFunction>>, BaseFunction>? QueryParameters { get; set; }
        }

        public class HttpTimeout : Humidifier.Base.BaseSubResource, IHaveAppMeshRouteTypesDurationPerRequest, IHaveAppMeshRouteTypesDurationIdle
        {
            /// <summary>
            /// PerRequest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httptimeout.html#cfn-appmesh-route-httptimeout-perrequest
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Duration
            /// </summary>
            public Union<Humidifier.AppMesh.RouteTypes.Duration, BaseFunction>? PerRequest { get; set; }
            /// <summary>
            /// Idle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-httptimeout.html#cfn-appmesh-route-httptimeout-idle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Duration
            /// </summary>
            public Union<Humidifier.AppMesh.RouteTypes.Duration, BaseFunction>? Idle { get; set; }
        }

        public class MatchRange : Humidifier.Base.BaseSubResource, IHaveStart_Integer, IHaveEnd_Integer
        {
            /// <summary>
            /// Start
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-matchrange.html#cfn-appmesh-route-matchrange-start
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Start { get; set; }
            /// <summary>
            /// End
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-matchrange.html#cfn-appmesh-route-matchrange-end
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? End { get; set; }
        }

        public class QueryParameter : Humidifier.Base.BaseSubResource, IHaveName, IHaveAppMeshRouteTypesHttpQueryParameterMatchMatch
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-queryparameter.html#cfn-appmesh-route-queryparameter-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
            /// <summary>
            /// Match
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-queryparameter.html#cfn-appmesh-route-queryparameter-match
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpQueryParameterMatch
            /// </summary>
            public Union<Humidifier.AppMesh.RouteTypes.HttpQueryParameterMatch, BaseFunction>? Match { get; set; }
        }

        public class RouteSpec : Humidifier.Base.BaseSubResource, IHaveAppMeshRouteTypesHttpRouteHttpRoute, IHavePriority_Integer, IHaveAppMeshRouteTypesHttpRouteHttp2Route, IHaveAppMeshRouteTypesGrpcRouteGrpcRoute, IHaveAppMeshRouteTypesTcpRouteTcpRoute
        {
            /// <summary>
            /// HttpRoute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-routespec.html#cfn-appmesh-route-routespec-httproute
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpRoute
            /// </summary>
            public Union<Humidifier.AppMesh.RouteTypes.HttpRoute, BaseFunction>? HttpRoute { get; set; }
            /// <summary>
            /// Priority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-routespec.html#cfn-appmesh-route-routespec-priority
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Priority { get; set; }
            /// <summary>
            /// Http2Route
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-routespec.html#cfn-appmesh-route-routespec-http2route
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpRoute
            /// </summary>
            public Union<Humidifier.AppMesh.RouteTypes.HttpRoute, BaseFunction>? Http2Route { get; set; }
            /// <summary>
            /// GrpcRoute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-routespec.html#cfn-appmesh-route-routespec-grpcroute
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GrpcRoute
            /// </summary>
            public Union<Humidifier.AppMesh.RouteTypes.GrpcRoute, BaseFunction>? GrpcRoute { get; set; }
            /// <summary>
            /// TcpRoute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-routespec.html#cfn-appmesh-route-routespec-tcproute
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TcpRoute
            /// </summary>
            public Union<Humidifier.AppMesh.RouteTypes.TcpRoute, BaseFunction>? TcpRoute { get; set; }
        }

        public class TcpRoute : Humidifier.Base.BaseSubResource, IHaveAppMeshRouteTypesTcpRouteActionAction, IHaveAppMeshRouteTypesTcpTimeoutTimeout, IHaveAppMeshRouteTypesTcpRouteMatchMatch
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-tcproute.html#cfn-appmesh-route-tcproute-action
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TcpRouteAction
            /// </summary>
            public Union<Humidifier.AppMesh.RouteTypes.TcpRouteAction, BaseFunction>? Action { get; set; }
            /// <summary>
            /// Timeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-tcproute.html#cfn-appmesh-route-tcproute-timeout
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TcpTimeout
            /// </summary>
            public Union<Humidifier.AppMesh.RouteTypes.TcpTimeout, BaseFunction>? Timeout { get; set; }
            /// <summary>
            /// Match
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-tcproute.html#cfn-appmesh-route-tcproute-match
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TcpRouteMatch
            /// </summary>
            public Union<Humidifier.AppMesh.RouteTypes.TcpRouteMatch, BaseFunction>? Match { get; set; }
        }

        public class TcpRouteAction : Humidifier.Base.BaseSubResource, IHaveListOfAppMeshRouteTypesWeightedTargetWeightedTargets
        {
            /// <summary>
            /// WeightedTargets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-tcprouteaction.html#cfn-appmesh-route-tcprouteaction-weightedtargets
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: WeightedTarget
            /// </summary>
            public Union<IReadOnlyList<Humidifier.AppMesh.RouteTypes.WeightedTarget>, IReadOnlyList<Union<Humidifier.AppMesh.RouteTypes.WeightedTarget, BaseFunction>>, BaseFunction>? WeightedTargets { get; set; }
        }

        public class TcpRouteMatch : Humidifier.Base.BaseSubResource, IHavePort_Integer
        {
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-tcproutematch.html#cfn-appmesh-route-tcproutematch-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Port { get; set; }
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
            public Union<Humidifier.AppMesh.RouteTypes.Duration, BaseFunction>? Idle { get; set; }
        }

        public class WeightedTarget : Humidifier.Base.BaseSubResource, IHaveVirtualNode, IHavePort_Integer, IHaveWeight_Integer
        {
            /// <summary>
            /// VirtualNode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-weightedtarget.html#cfn-appmesh-route-weightedtarget-virtualnode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VirtualNode { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-weightedtarget.html#cfn-appmesh-route-weightedtarget-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Port { get; set; }
            /// <summary>
            /// Weight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-route-weightedtarget.html#cfn-appmesh-route-weightedtarget-weight
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Weight { get; set; }
        }
    }
}