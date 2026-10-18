namespace Humidifier.AppMesh
{
    using global::System.Collections.Generic;
    using VirtualGatewayTypes;

    public class VirtualGateway : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveVirtualGatewayName, IHaveMeshName, IHaveMeshOwner, IHaveAppMeshVirtualGatewayTypesVirtualGatewaySpecSpec
    {
        public class Attributes
        {
            public static string Uid =  "Uid" ;
            public static string VirtualGatewayName =  "VirtualGatewayName" ;
            public static string MeshName =  "MeshName" ;
            public static string MeshOwner =  "MeshOwner" ;
            public static string ResourceOwner =  "ResourceOwner" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.AppMesh.VirtualGateway; }
        public Union<string, BaseFunction>? VirtualGatewayName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// MeshName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-virtualgateway.html#cfn-appmesh-virtualgateway-meshname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? MeshName { get; set; }
        /// <summary>
        /// MeshOwner
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-virtualgateway.html#cfn-appmesh-virtualgateway-meshowner
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? MeshOwner { get; set; }

        /// <summary>
        /// Spec
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-virtualgateway.html#cfn-appmesh-virtualgateway-spec
        /// Required: True
        /// UpdateType: Mutable
        /// Type: VirtualGatewaySpec
        /// </summary>
        [Required]
        public Union<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewaySpec, BaseFunction>? Spec { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-virtualgateway.html#cfn-appmesh-virtualgateway-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace VirtualGatewayTypes
    {
        public class JsonFormatRef : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-jsonformatref.html#cfn-appmesh-virtualgateway-jsonformatref-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-jsonformatref.html#cfn-appmesh-virtualgateway-jsonformatref-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class LoggingFormat : Humidifier.Base.BaseSubResource, IHaveText, IHaveListOfAppMeshVirtualGatewayTypesJsonFormatRefJson
        {
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-loggingformat.html#cfn-appmesh-virtualgateway-loggingformat-text
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Text { get; set; }
            /// <summary>
            /// Json
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-loggingformat.html#cfn-appmesh-virtualgateway-loggingformat-json
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: JsonFormatRef
            /// </summary>
            public Union<IReadOnlyList<Humidifier.AppMesh.VirtualGatewayTypes.JsonFormatRef>, IReadOnlyList<Union<Humidifier.AppMesh.VirtualGatewayTypes.JsonFormatRef, BaseFunction>>, BaseFunction>? Json { get; set; }
        }

        public class SubjectAlternativeNameMatchers : Humidifier.Base.BaseSubResource, IHaveStringListOfExact
        {
            /// <summary>
            /// Exact
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-subjectalternativenamematchers.html#cfn-appmesh-virtualgateway-subjectalternativenamematchers-exact
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Exact { get; set; }
        }

        public class SubjectAlternativeNames : Humidifier.Base.BaseSubResource, IHaveAppMeshVirtualGatewayTypesSubjectAlternativeNameMatchersMatch
        {
            /// <summary>
            /// Match
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-subjectalternativenames.html#cfn-appmesh-virtualgateway-subjectalternativenames-match
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SubjectAlternativeNameMatchers
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualGatewayTypes.SubjectAlternativeNameMatchers, BaseFunction>? Match { get; set; }
        }

        public class VirtualGatewayAccessLog : Humidifier.Base.BaseSubResource, IHaveAppMeshVirtualGatewayTypesVirtualGatewayFileAccessLogFile
        {
            /// <summary>
            /// File
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayaccesslog.html#cfn-appmesh-virtualgateway-virtualgatewayaccesslog-file
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayFileAccessLog
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayFileAccessLog, BaseFunction>? File { get; set; }
        }

        public class VirtualGatewayBackendDefaults : Humidifier.Base.BaseSubResource, IHaveAppMeshVirtualGatewayTypesVirtualGatewayClientPolicyClientPolicy
        {
            /// <summary>
            /// ClientPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaybackenddefaults.html#cfn-appmesh-virtualgateway-virtualgatewaybackenddefaults-clientpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayClientPolicy
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayClientPolicy, BaseFunction>? ClientPolicy { get; set; }
        }

        public class VirtualGatewayClientPolicy : Humidifier.Base.BaseSubResource, IHaveAppMeshVirtualGatewayTypesVirtualGatewayClientPolicyTlsTLS
        {
            /// <summary>
            /// TLS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayclientpolicy.html#cfn-appmesh-virtualgateway-virtualgatewayclientpolicy-tls
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayClientPolicyTls
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayClientPolicyTls, BaseFunction>? TLS { get; set; }
        }

        public class VirtualGatewayClientPolicyTls : Humidifier.Base.BaseSubResource, IHaveAppMeshVirtualGatewayTypesVirtualGatewayTlsValidationContextValidation, IHaveEnforce_Boolean, IHaveIntegerListOfPorts, IHaveAppMeshVirtualGatewayTypesVirtualGatewayClientTlsCertificateCertificate
        {
            /// <summary>
            /// Validation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayclientpolicytls.html#cfn-appmesh-virtualgateway-virtualgatewayclientpolicytls-validation
            /// Required: True
            /// UpdateType: Mutable
            /// Type: VirtualGatewayTlsValidationContext
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayTlsValidationContext, BaseFunction>? Validation { get; set; }
            /// <summary>
            /// Enforce
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayclientpolicytls.html#cfn-appmesh-virtualgateway-virtualgatewayclientpolicytls-enforce
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enforce { get; set; }
            /// <summary>
            /// Ports
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayclientpolicytls.html#cfn-appmesh-virtualgateway-virtualgatewayclientpolicytls-ports
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public Union<IReadOnlyList<int>, IReadOnlyList<Union<int, BaseFunction>>, BaseFunction>? Ports { get; set; }
            /// <summary>
            /// Certificate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayclientpolicytls.html#cfn-appmesh-virtualgateway-virtualgatewayclientpolicytls-certificate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayClientTlsCertificate
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayClientTlsCertificate, BaseFunction>? Certificate { get; set; }
        }

        public class VirtualGatewayClientTlsCertificate : Humidifier.Base.BaseSubResource, IHaveAppMeshVirtualGatewayTypesVirtualGatewayListenerTlsSdsCertificateSDS, IHaveAppMeshVirtualGatewayTypesVirtualGatewayListenerTlsFileCertificateFile
        {
            /// <summary>
            /// SDS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayclienttlscertificate.html#cfn-appmesh-virtualgateway-virtualgatewayclienttlscertificate-sds
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayListenerTlsSdsCertificate
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayListenerTlsSdsCertificate, BaseFunction>? SDS { get; set; }
            /// <summary>
            /// File
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayclienttlscertificate.html#cfn-appmesh-virtualgateway-virtualgatewayclienttlscertificate-file
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayListenerTlsFileCertificate
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayListenerTlsFileCertificate, BaseFunction>? File { get; set; }
        }

        public class VirtualGatewayConnectionPool : Humidifier.Base.BaseSubResource, IHaveAppMeshVirtualGatewayTypesVirtualGatewayHttp2ConnectionPoolHTTP2, IHaveAppMeshVirtualGatewayTypesVirtualGatewayHttpConnectionPoolHTTP, IHaveAppMeshVirtualGatewayTypesVirtualGatewayGrpcConnectionPoolGRPC
        {
            /// <summary>
            /// HTTP2
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayconnectionpool.html#cfn-appmesh-virtualgateway-virtualgatewayconnectionpool-http2
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayHttp2ConnectionPool
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayHttp2ConnectionPool, BaseFunction>? HTTP2 { get; set; }
            /// <summary>
            /// HTTP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayconnectionpool.html#cfn-appmesh-virtualgateway-virtualgatewayconnectionpool-http
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayHttpConnectionPool
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayHttpConnectionPool, BaseFunction>? HTTP { get; set; }
            /// <summary>
            /// GRPC
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayconnectionpool.html#cfn-appmesh-virtualgateway-virtualgatewayconnectionpool-grpc
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayGrpcConnectionPool
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayGrpcConnectionPool, BaseFunction>? GRPC { get; set; }
        }

        public class VirtualGatewayFileAccessLog : Humidifier.Base.BaseSubResource, IHavePath, IHaveAppMeshVirtualGatewayTypesLoggingFormatFormat
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayfileaccesslog.html#cfn-appmesh-virtualgateway-virtualgatewayfileaccesslog-path
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Path { get; set; }
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayfileaccesslog.html#cfn-appmesh-virtualgateway-virtualgatewayfileaccesslog-format
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LoggingFormat
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualGatewayTypes.LoggingFormat, BaseFunction>? Format { get; set; }
        }

        public class VirtualGatewayGrpcConnectionPool : Humidifier.Base.BaseSubResource, IHaveMaxRequests_Integer
        {
            /// <summary>
            /// MaxRequests
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaygrpcconnectionpool.html#cfn-appmesh-virtualgateway-virtualgatewaygrpcconnectionpool-maxrequests
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxRequests { get; set; }
        }

        public class VirtualGatewayHealthCheckPolicy : Humidifier.Base.BaseSubResource, IHavePath, IHaveUnhealthyThreshold_Integer, IHavePort_Integer, IHaveHealthyThreshold_Integer, IHaveTimeoutMillis_Integer, IHaveProtocol, IHaveIntervalMillis_Integer
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayhealthcheckpolicy.html#cfn-appmesh-virtualgateway-virtualgatewayhealthcheckpolicy-path
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Path { get; set; }
            /// <summary>
            /// UnhealthyThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayhealthcheckpolicy.html#cfn-appmesh-virtualgateway-virtualgatewayhealthcheckpolicy-unhealthythreshold
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? UnhealthyThreshold { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayhealthcheckpolicy.html#cfn-appmesh-virtualgateway-virtualgatewayhealthcheckpolicy-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Port { get; set; }
            /// <summary>
            /// HealthyThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayhealthcheckpolicy.html#cfn-appmesh-virtualgateway-virtualgatewayhealthcheckpolicy-healthythreshold
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? HealthyThreshold { get; set; }
            /// <summary>
            /// TimeoutMillis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayhealthcheckpolicy.html#cfn-appmesh-virtualgateway-virtualgatewayhealthcheckpolicy-timeoutmillis
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimeoutMillis { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayhealthcheckpolicy.html#cfn-appmesh-virtualgateway-virtualgatewayhealthcheckpolicy-protocol
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Protocol { get; set; }
            /// <summary>
            /// IntervalMillis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayhealthcheckpolicy.html#cfn-appmesh-virtualgateway-virtualgatewayhealthcheckpolicy-intervalmillis
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? IntervalMillis { get; set; }
        }

        public class VirtualGatewayHttp2ConnectionPool : Humidifier.Base.BaseSubResource, IHaveMaxRequests_Integer
        {
            /// <summary>
            /// MaxRequests
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayhttp2connectionpool.html#cfn-appmesh-virtualgateway-virtualgatewayhttp2connectionpool-maxrequests
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxRequests { get; set; }
        }

        public class VirtualGatewayHttpConnectionPool : Humidifier.Base.BaseSubResource, IHaveMaxConnections_Integer, IHaveMaxPendingRequests_Integer
        {
            /// <summary>
            /// MaxConnections
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayhttpconnectionpool.html#cfn-appmesh-virtualgateway-virtualgatewayhttpconnectionpool-maxconnections
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxConnections { get; set; }
            /// <summary>
            /// MaxPendingRequests
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayhttpconnectionpool.html#cfn-appmesh-virtualgateway-virtualgatewayhttpconnectionpool-maxpendingrequests
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxPendingRequests { get; set; }
        }

        public class VirtualGatewayListener : Humidifier.Base.BaseSubResource, IHaveAppMeshVirtualGatewayTypesVirtualGatewayConnectionPoolConnectionPool, IHaveAppMeshVirtualGatewayTypesVirtualGatewayHealthCheckPolicyHealthCheck, IHaveAppMeshVirtualGatewayTypesVirtualGatewayListenerTlsTLS, IHaveAppMeshVirtualGatewayTypesVirtualGatewayPortMappingPortMapping
        {
            /// <summary>
            /// ConnectionPool
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistener.html#cfn-appmesh-virtualgateway-virtualgatewaylistener-connectionpool
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayConnectionPool
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayConnectionPool, BaseFunction>? ConnectionPool { get; set; }
            /// <summary>
            /// HealthCheck
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistener.html#cfn-appmesh-virtualgateway-virtualgatewaylistener-healthcheck
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayHealthCheckPolicy
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayHealthCheckPolicy, BaseFunction>? HealthCheck { get; set; }
            /// <summary>
            /// TLS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistener.html#cfn-appmesh-virtualgateway-virtualgatewaylistener-tls
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayListenerTls
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayListenerTls, BaseFunction>? TLS { get; set; }
            /// <summary>
            /// PortMapping
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistener.html#cfn-appmesh-virtualgateway-virtualgatewaylistener-portmapping
            /// Required: True
            /// UpdateType: Mutable
            /// Type: VirtualGatewayPortMapping
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayPortMapping, BaseFunction>? PortMapping { get; set; }
        }

        public class VirtualGatewayListenerTls : Humidifier.Base.BaseSubResource, IHaveAppMeshVirtualGatewayTypesVirtualGatewayListenerTlsValidationContextValidation, IHaveMode, IHaveAppMeshVirtualGatewayTypesVirtualGatewayListenerTlsCertificateCertificate
        {
            /// <summary>
            /// Validation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistenertls.html#cfn-appmesh-virtualgateway-virtualgatewaylistenertls-validation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayListenerTlsValidationContext
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayListenerTlsValidationContext, BaseFunction>? Validation { get; set; }
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistenertls.html#cfn-appmesh-virtualgateway-virtualgatewaylistenertls-mode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Mode { get; set; }
            /// <summary>
            /// Certificate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistenertls.html#cfn-appmesh-virtualgateway-virtualgatewaylistenertls-certificate
            /// Required: True
            /// UpdateType: Mutable
            /// Type: VirtualGatewayListenerTlsCertificate
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayListenerTlsCertificate, BaseFunction>? Certificate { get; set; }
        }

        public class VirtualGatewayListenerTlsAcmCertificate : Humidifier.Base.BaseSubResource, IHaveCertificateArn
        {
            /// <summary>
            /// CertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistenertlsacmcertificate.html#cfn-appmesh-virtualgateway-virtualgatewaylistenertlsacmcertificate-certificatearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CertificateArn { get; set; }
        }

        public class VirtualGatewayListenerTlsCertificate : Humidifier.Base.BaseSubResource, IHaveAppMeshVirtualGatewayTypesVirtualGatewayListenerTlsSdsCertificateSDS, IHaveAppMeshVirtualGatewayTypesVirtualGatewayListenerTlsAcmCertificateACM, IHaveAppMeshVirtualGatewayTypesVirtualGatewayListenerTlsFileCertificateFile
        {
            /// <summary>
            /// SDS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistenertlscertificate.html#cfn-appmesh-virtualgateway-virtualgatewaylistenertlscertificate-sds
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayListenerTlsSdsCertificate
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayListenerTlsSdsCertificate, BaseFunction>? SDS { get; set; }
            /// <summary>
            /// ACM
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistenertlscertificate.html#cfn-appmesh-virtualgateway-virtualgatewaylistenertlscertificate-acm
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayListenerTlsAcmCertificate
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayListenerTlsAcmCertificate, BaseFunction>? ACM { get; set; }
            /// <summary>
            /// File
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistenertlscertificate.html#cfn-appmesh-virtualgateway-virtualgatewaylistenertlscertificate-file
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayListenerTlsFileCertificate
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayListenerTlsFileCertificate, BaseFunction>? File { get; set; }
        }

        public class VirtualGatewayListenerTlsFileCertificate : Humidifier.Base.BaseSubResource, IHavePrivateKey, IHaveCertificateChain
        {
            /// <summary>
            /// PrivateKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistenertlsfilecertificate.html#cfn-appmesh-virtualgateway-virtualgatewaylistenertlsfilecertificate-privatekey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrivateKey { get; set; }
            /// <summary>
            /// CertificateChain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistenertlsfilecertificate.html#cfn-appmesh-virtualgateway-virtualgatewaylistenertlsfilecertificate-certificatechain
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CertificateChain { get; set; }
        }

        public class VirtualGatewayListenerTlsSdsCertificate : Humidifier.Base.BaseSubResource, IHaveSecretName
        {
            /// <summary>
            /// SecretName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistenertlssdscertificate.html#cfn-appmesh-virtualgateway-virtualgatewaylistenertlssdscertificate-secretname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretName { get; set; }
        }

        public class VirtualGatewayListenerTlsValidationContext : Humidifier.Base.BaseSubResource, IHaveAppMeshVirtualGatewayTypesSubjectAlternativeNamesSubjectAlternativeNames, IHaveAppMeshVirtualGatewayTypesVirtualGatewayListenerTlsValidationContextTrustTrust
        {
            /// <summary>
            /// SubjectAlternativeNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistenertlsvalidationcontext.html#cfn-appmesh-virtualgateway-virtualgatewaylistenertlsvalidationcontext-subjectalternativenames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SubjectAlternativeNames
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualGatewayTypes.SubjectAlternativeNames, BaseFunction>? SubjectAlternativeNames { get; set; }
            /// <summary>
            /// Trust
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistenertlsvalidationcontext.html#cfn-appmesh-virtualgateway-virtualgatewaylistenertlsvalidationcontext-trust
            /// Required: True
            /// UpdateType: Mutable
            /// Type: VirtualGatewayListenerTlsValidationContextTrust
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayListenerTlsValidationContextTrust, BaseFunction>? Trust { get; set; }
        }

        public class VirtualGatewayListenerTlsValidationContextTrust : Humidifier.Base.BaseSubResource, IHaveAppMeshVirtualGatewayTypesVirtualGatewayTlsValidationContextSdsTrustSDS, IHaveAppMeshVirtualGatewayTypesVirtualGatewayTlsValidationContextFileTrustFile
        {
            /// <summary>
            /// SDS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistenertlsvalidationcontexttrust.html#cfn-appmesh-virtualgateway-virtualgatewaylistenertlsvalidationcontexttrust-sds
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayTlsValidationContextSdsTrust
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayTlsValidationContextSdsTrust, BaseFunction>? SDS { get; set; }
            /// <summary>
            /// File
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistenertlsvalidationcontexttrust.html#cfn-appmesh-virtualgateway-virtualgatewaylistenertlsvalidationcontexttrust-file
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayTlsValidationContextFileTrust
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayTlsValidationContextFileTrust, BaseFunction>? File { get; set; }
        }

        public class VirtualGatewayLogging : Humidifier.Base.BaseSubResource, IHaveAppMeshVirtualGatewayTypesVirtualGatewayAccessLogAccessLog
        {
            /// <summary>
            /// AccessLog
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylogging.html#cfn-appmesh-virtualgateway-virtualgatewaylogging-accesslog
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayAccessLog
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayAccessLog, BaseFunction>? AccessLog { get; set; }
        }

        public class VirtualGatewayPortMapping : Humidifier.Base.BaseSubResource, IHavePort_Integer, IHaveProtocol
        {
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayportmapping.html#cfn-appmesh-virtualgateway-virtualgatewayportmapping-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Port { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayportmapping.html#cfn-appmesh-virtualgateway-virtualgatewayportmapping-protocol
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Protocol { get; set; }
        }

        public class VirtualGatewaySpec : Humidifier.Base.BaseSubResource, IHaveAppMeshVirtualGatewayTypesVirtualGatewayLoggingLogging, IHaveListOfAppMeshVirtualGatewayTypesVirtualGatewayListenerListeners, IHaveAppMeshVirtualGatewayTypesVirtualGatewayBackendDefaultsBackendDefaults
        {
            /// <summary>
            /// Logging
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayspec.html#cfn-appmesh-virtualgateway-virtualgatewayspec-logging
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayLogging
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayLogging, BaseFunction>? Logging { get; set; }
            /// <summary>
            /// Listeners
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayspec.html#cfn-appmesh-virtualgateway-virtualgatewayspec-listeners
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VirtualGatewayListener
            /// </summary>
            public Union<IReadOnlyList<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayListener>, IReadOnlyList<Union<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayListener, BaseFunction>>, BaseFunction>? Listeners { get; set; }
            /// <summary>
            /// BackendDefaults
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayspec.html#cfn-appmesh-virtualgateway-virtualgatewayspec-backenddefaults
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayBackendDefaults
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayBackendDefaults, BaseFunction>? BackendDefaults { get; set; }
        }

        public class VirtualGatewayTlsValidationContext : Humidifier.Base.BaseSubResource, IHaveAppMeshVirtualGatewayTypesSubjectAlternativeNamesSubjectAlternativeNames, IHaveAppMeshVirtualGatewayTypesVirtualGatewayTlsValidationContextTrustTrust
        {
            /// <summary>
            /// SubjectAlternativeNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaytlsvalidationcontext.html#cfn-appmesh-virtualgateway-virtualgatewaytlsvalidationcontext-subjectalternativenames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SubjectAlternativeNames
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualGatewayTypes.SubjectAlternativeNames, BaseFunction>? SubjectAlternativeNames { get; set; }
            /// <summary>
            /// Trust
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaytlsvalidationcontext.html#cfn-appmesh-virtualgateway-virtualgatewaytlsvalidationcontext-trust
            /// Required: True
            /// UpdateType: Mutable
            /// Type: VirtualGatewayTlsValidationContextTrust
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayTlsValidationContextTrust, BaseFunction>? Trust { get; set; }
        }

        public class VirtualGatewayTlsValidationContextAcmTrust : Humidifier.Base.BaseSubResource, IHaveStringListOfCertificateAuthorityArns
        {
            /// <summary>
            /// CertificateAuthorityArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaytlsvalidationcontextacmtrust.html#cfn-appmesh-virtualgateway-virtualgatewaytlsvalidationcontextacmtrust-certificateauthorityarns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CertificateAuthorityArns { get; set; }
        }

        public class VirtualGatewayTlsValidationContextFileTrust : Humidifier.Base.BaseSubResource, IHaveCertificateChain
        {
            /// <summary>
            /// CertificateChain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaytlsvalidationcontextfiletrust.html#cfn-appmesh-virtualgateway-virtualgatewaytlsvalidationcontextfiletrust-certificatechain
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CertificateChain { get; set; }
        }

        public class VirtualGatewayTlsValidationContextSdsTrust : Humidifier.Base.BaseSubResource, IHaveSecretName
        {
            /// <summary>
            /// SecretName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaytlsvalidationcontextsdstrust.html#cfn-appmesh-virtualgateway-virtualgatewaytlsvalidationcontextsdstrust-secretname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretName { get; set; }
        }

        public class VirtualGatewayTlsValidationContextTrust : Humidifier.Base.BaseSubResource, IHaveAppMeshVirtualGatewayTypesVirtualGatewayTlsValidationContextSdsTrustSDS, IHaveAppMeshVirtualGatewayTypesVirtualGatewayTlsValidationContextAcmTrustACM, IHaveAppMeshVirtualGatewayTypesVirtualGatewayTlsValidationContextFileTrustFile
        {
            /// <summary>
            /// SDS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaytlsvalidationcontexttrust.html#cfn-appmesh-virtualgateway-virtualgatewaytlsvalidationcontexttrust-sds
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayTlsValidationContextSdsTrust
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayTlsValidationContextSdsTrust, BaseFunction>? SDS { get; set; }
            /// <summary>
            /// ACM
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaytlsvalidationcontexttrust.html#cfn-appmesh-virtualgateway-virtualgatewaytlsvalidationcontexttrust-acm
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayTlsValidationContextAcmTrust
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayTlsValidationContextAcmTrust, BaseFunction>? ACM { get; set; }
            /// <summary>
            /// File
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaytlsvalidationcontexttrust.html#cfn-appmesh-virtualgateway-virtualgatewaytlsvalidationcontexttrust-file
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayTlsValidationContextFileTrust
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayTlsValidationContextFileTrust, BaseFunction>? File { get; set; }
        }
    }
}