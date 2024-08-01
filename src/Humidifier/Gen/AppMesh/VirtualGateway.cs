namespace Humidifier.AppMesh
{
    using System.Collections.Generic;
    using VirtualGatewayTypes;

    public class VirtualGateway : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags
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
        public dynamic VirtualGatewayName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// MeshName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-virtualgateway.html#cfn-appmesh-virtualgateway-meshname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic MeshName { get; set; }
        /// <summary>
        /// MeshOwner
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-virtualgateway.html#cfn-appmesh-virtualgateway-meshowner
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic MeshOwner { get; set; }

        /// <summary>
        /// Spec
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-virtualgateway.html#cfn-appmesh-virtualgateway-spec
        /// Required: True
        /// UpdateType: Mutable
        /// Type: VirtualGatewaySpec
        /// </summary>
        [Required]
        public VirtualGatewayTypes.VirtualGatewaySpec Spec { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-virtualgateway.html#cfn-appmesh-virtualgateway-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace VirtualGatewayTypes
    {
        public class JsonFormatRef : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-jsonformatref.html#cfn-appmesh-virtualgateway-jsonformatref-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-jsonformatref.html#cfn-appmesh-virtualgateway-jsonformatref-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class LoggingFormat : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-loggingformat.html#cfn-appmesh-virtualgateway-loggingformat-text
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Text { get; set; }
            /// <summary>
            /// Json
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-loggingformat.html#cfn-appmesh-virtualgateway-loggingformat-json
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: JsonFormatRef
            /// </summary>
            public List<VirtualGatewayTypes.JsonFormatRef> Json { get; set; }
        }

        public class SubjectAlternativeNameMatchers : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Exact
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-subjectalternativenamematchers.html#cfn-appmesh-virtualgateway-subjectalternativenamematchers-exact
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Exact { get; set; }
        }

        public class SubjectAlternativeNames : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Match
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-subjectalternativenames.html#cfn-appmesh-virtualgateway-subjectalternativenames-match
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SubjectAlternativeNameMatchers
            /// </summary>
            public VirtualGatewayTypes.SubjectAlternativeNameMatchers Match { get; set; }
        }

        public class VirtualGatewayAccessLog : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// File
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayaccesslog.html#cfn-appmesh-virtualgateway-virtualgatewayaccesslog-file
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayFileAccessLog
            /// </summary>
            public VirtualGatewayTypes.VirtualGatewayFileAccessLog File { get; set; }
        }

        public class VirtualGatewayBackendDefaults : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ClientPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaybackenddefaults.html#cfn-appmesh-virtualgateway-virtualgatewaybackenddefaults-clientpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayClientPolicy
            /// </summary>
            public VirtualGatewayTypes.VirtualGatewayClientPolicy ClientPolicy { get; set; }
        }

        public class VirtualGatewayClientPolicy : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TLS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayclientpolicy.html#cfn-appmesh-virtualgateway-virtualgatewayclientpolicy-tls
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayClientPolicyTls
            /// </summary>
            public VirtualGatewayTypes.VirtualGatewayClientPolicyTls TLS { get; set; }
        }

        public class VirtualGatewayClientPolicyTls : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Validation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayclientpolicytls.html#cfn-appmesh-virtualgateway-virtualgatewayclientpolicytls-validation
            /// Required: True
            /// UpdateType: Mutable
            /// Type: VirtualGatewayTlsValidationContext
            /// </summary>
            public VirtualGatewayTypes.VirtualGatewayTlsValidationContext Validation { get; set; }
            /// <summary>
            /// Enforce
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayclientpolicytls.html#cfn-appmesh-virtualgateway-virtualgatewayclientpolicytls-enforce
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enforce { get; set; }
            /// <summary>
            /// Ports
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayclientpolicytls.html#cfn-appmesh-virtualgateway-virtualgatewayclientpolicytls-ports
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public List<int> Ports { get; set; }
            /// <summary>
            /// Certificate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayclientpolicytls.html#cfn-appmesh-virtualgateway-virtualgatewayclientpolicytls-certificate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayClientTlsCertificate
            /// </summary>
            public VirtualGatewayTypes.VirtualGatewayClientTlsCertificate Certificate { get; set; }
        }

        public class VirtualGatewayClientTlsCertificate : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SDS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayclienttlscertificate.html#cfn-appmesh-virtualgateway-virtualgatewayclienttlscertificate-sds
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayListenerTlsSdsCertificate
            /// </summary>
            public VirtualGatewayTypes.VirtualGatewayListenerTlsSdsCertificate SDS { get; set; }
            /// <summary>
            /// File
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayclienttlscertificate.html#cfn-appmesh-virtualgateway-virtualgatewayclienttlscertificate-file
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayListenerTlsFileCertificate
            /// </summary>
            public VirtualGatewayTypes.VirtualGatewayListenerTlsFileCertificate File { get; set; }
        }

        public class VirtualGatewayConnectionPool : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// HTTP2
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayconnectionpool.html#cfn-appmesh-virtualgateway-virtualgatewayconnectionpool-http2
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayHttp2ConnectionPool
            /// </summary>
            public VirtualGatewayTypes.VirtualGatewayHttp2ConnectionPool HTTP2 { get; set; }
            /// <summary>
            /// HTTP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayconnectionpool.html#cfn-appmesh-virtualgateway-virtualgatewayconnectionpool-http
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayHttpConnectionPool
            /// </summary>
            public VirtualGatewayTypes.VirtualGatewayHttpConnectionPool HTTP { get; set; }
            /// <summary>
            /// GRPC
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayconnectionpool.html#cfn-appmesh-virtualgateway-virtualgatewayconnectionpool-grpc
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayGrpcConnectionPool
            /// </summary>
            public VirtualGatewayTypes.VirtualGatewayGrpcConnectionPool GRPC { get; set; }
        }

        public class VirtualGatewayFileAccessLog : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayfileaccesslog.html#cfn-appmesh-virtualgateway-virtualgatewayfileaccesslog-path
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Path { get; set; }
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayfileaccesslog.html#cfn-appmesh-virtualgateway-virtualgatewayfileaccesslog-format
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LoggingFormat
            /// </summary>
            public VirtualGatewayTypes.LoggingFormat Format { get; set; }
        }

        public class VirtualGatewayGrpcConnectionPool : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MaxRequests
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaygrpcconnectionpool.html#cfn-appmesh-virtualgateway-virtualgatewaygrpcconnectionpool-maxrequests
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxRequests { get; set; }
        }

        public class VirtualGatewayHealthCheckPolicy : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayhealthcheckpolicy.html#cfn-appmesh-virtualgateway-virtualgatewayhealthcheckpolicy-path
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Path { get; set; }
            /// <summary>
            /// UnhealthyThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayhealthcheckpolicy.html#cfn-appmesh-virtualgateway-virtualgatewayhealthcheckpolicy-unhealthythreshold
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic UnhealthyThreshold { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayhealthcheckpolicy.html#cfn-appmesh-virtualgateway-virtualgatewayhealthcheckpolicy-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Port { get; set; }
            /// <summary>
            /// HealthyThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayhealthcheckpolicy.html#cfn-appmesh-virtualgateway-virtualgatewayhealthcheckpolicy-healthythreshold
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic HealthyThreshold { get; set; }
            /// <summary>
            /// TimeoutMillis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayhealthcheckpolicy.html#cfn-appmesh-virtualgateway-virtualgatewayhealthcheckpolicy-timeoutmillis
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TimeoutMillis { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayhealthcheckpolicy.html#cfn-appmesh-virtualgateway-virtualgatewayhealthcheckpolicy-protocol
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Protocol { get; set; }
            /// <summary>
            /// IntervalMillis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayhealthcheckpolicy.html#cfn-appmesh-virtualgateway-virtualgatewayhealthcheckpolicy-intervalmillis
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic IntervalMillis { get; set; }
        }

        public class VirtualGatewayHttp2ConnectionPool : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MaxRequests
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayhttp2connectionpool.html#cfn-appmesh-virtualgateway-virtualgatewayhttp2connectionpool-maxrequests
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxRequests { get; set; }
        }

        public class VirtualGatewayHttpConnectionPool : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MaxConnections
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayhttpconnectionpool.html#cfn-appmesh-virtualgateway-virtualgatewayhttpconnectionpool-maxconnections
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxConnections { get; set; }
            /// <summary>
            /// MaxPendingRequests
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayhttpconnectionpool.html#cfn-appmesh-virtualgateway-virtualgatewayhttpconnectionpool-maxpendingrequests
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxPendingRequests { get; set; }
        }

        public class VirtualGatewayListener : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ConnectionPool
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistener.html#cfn-appmesh-virtualgateway-virtualgatewaylistener-connectionpool
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayConnectionPool
            /// </summary>
            public VirtualGatewayTypes.VirtualGatewayConnectionPool ConnectionPool { get; set; }
            /// <summary>
            /// HealthCheck
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistener.html#cfn-appmesh-virtualgateway-virtualgatewaylistener-healthcheck
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayHealthCheckPolicy
            /// </summary>
            public VirtualGatewayTypes.VirtualGatewayHealthCheckPolicy HealthCheck { get; set; }
            /// <summary>
            /// TLS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistener.html#cfn-appmesh-virtualgateway-virtualgatewaylistener-tls
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayListenerTls
            /// </summary>
            public VirtualGatewayTypes.VirtualGatewayListenerTls TLS { get; set; }
            /// <summary>
            /// PortMapping
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistener.html#cfn-appmesh-virtualgateway-virtualgatewaylistener-portmapping
            /// Required: True
            /// UpdateType: Mutable
            /// Type: VirtualGatewayPortMapping
            /// </summary>
            public VirtualGatewayTypes.VirtualGatewayPortMapping PortMapping { get; set; }
        }

        public class VirtualGatewayListenerTls : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Validation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistenertls.html#cfn-appmesh-virtualgateway-virtualgatewaylistenertls-validation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayListenerTlsValidationContext
            /// </summary>
            public VirtualGatewayTypes.VirtualGatewayListenerTlsValidationContext Validation { get; set; }
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistenertls.html#cfn-appmesh-virtualgateway-virtualgatewaylistenertls-mode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Mode { get; set; }
            /// <summary>
            /// Certificate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistenertls.html#cfn-appmesh-virtualgateway-virtualgatewaylistenertls-certificate
            /// Required: True
            /// UpdateType: Mutable
            /// Type: VirtualGatewayListenerTlsCertificate
            /// </summary>
            public VirtualGatewayTypes.VirtualGatewayListenerTlsCertificate Certificate { get; set; }
        }

        public class VirtualGatewayListenerTlsAcmCertificate : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistenertlsacmcertificate.html#cfn-appmesh-virtualgateway-virtualgatewaylistenertlsacmcertificate-certificatearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CertificateArn { get; set; }
        }

        public class VirtualGatewayListenerTlsCertificate : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SDS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistenertlscertificate.html#cfn-appmesh-virtualgateway-virtualgatewaylistenertlscertificate-sds
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayListenerTlsSdsCertificate
            /// </summary>
            public VirtualGatewayTypes.VirtualGatewayListenerTlsSdsCertificate SDS { get; set; }
            /// <summary>
            /// ACM
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistenertlscertificate.html#cfn-appmesh-virtualgateway-virtualgatewaylistenertlscertificate-acm
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayListenerTlsAcmCertificate
            /// </summary>
            public VirtualGatewayTypes.VirtualGatewayListenerTlsAcmCertificate ACM { get; set; }
            /// <summary>
            /// File
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistenertlscertificate.html#cfn-appmesh-virtualgateway-virtualgatewaylistenertlscertificate-file
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayListenerTlsFileCertificate
            /// </summary>
            public VirtualGatewayTypes.VirtualGatewayListenerTlsFileCertificate File { get; set; }
        }

        public class VirtualGatewayListenerTlsFileCertificate : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PrivateKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistenertlsfilecertificate.html#cfn-appmesh-virtualgateway-virtualgatewaylistenertlsfilecertificate-privatekey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PrivateKey { get; set; }
            /// <summary>
            /// CertificateChain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistenertlsfilecertificate.html#cfn-appmesh-virtualgateway-virtualgatewaylistenertlsfilecertificate-certificatechain
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CertificateChain { get; set; }
        }

        public class VirtualGatewayListenerTlsSdsCertificate : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SecretName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistenertlssdscertificate.html#cfn-appmesh-virtualgateway-virtualgatewaylistenertlssdscertificate-secretname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecretName { get; set; }
        }

        public class VirtualGatewayListenerTlsValidationContext : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SubjectAlternativeNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistenertlsvalidationcontext.html#cfn-appmesh-virtualgateway-virtualgatewaylistenertlsvalidationcontext-subjectalternativenames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SubjectAlternativeNames
            /// </summary>
            public VirtualGatewayTypes.SubjectAlternativeNames SubjectAlternativeNames { get; set; }
            /// <summary>
            /// Trust
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistenertlsvalidationcontext.html#cfn-appmesh-virtualgateway-virtualgatewaylistenertlsvalidationcontext-trust
            /// Required: True
            /// UpdateType: Mutable
            /// Type: VirtualGatewayListenerTlsValidationContextTrust
            /// </summary>
            public VirtualGatewayTypes.VirtualGatewayListenerTlsValidationContextTrust Trust { get; set; }
        }

        public class VirtualGatewayListenerTlsValidationContextTrust : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SDS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistenertlsvalidationcontexttrust.html#cfn-appmesh-virtualgateway-virtualgatewaylistenertlsvalidationcontexttrust-sds
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayTlsValidationContextSdsTrust
            /// </summary>
            public VirtualGatewayTypes.VirtualGatewayTlsValidationContextSdsTrust SDS { get; set; }
            /// <summary>
            /// File
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistenertlsvalidationcontexttrust.html#cfn-appmesh-virtualgateway-virtualgatewaylistenertlsvalidationcontexttrust-file
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayTlsValidationContextFileTrust
            /// </summary>
            public VirtualGatewayTypes.VirtualGatewayTlsValidationContextFileTrust File { get; set; }
        }

        public class VirtualGatewayLogging : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AccessLog
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylogging.html#cfn-appmesh-virtualgateway-virtualgatewaylogging-accesslog
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayAccessLog
            /// </summary>
            public VirtualGatewayTypes.VirtualGatewayAccessLog AccessLog { get; set; }
        }

        public class VirtualGatewayPortMapping : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayportmapping.html#cfn-appmesh-virtualgateway-virtualgatewayportmapping-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Port { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayportmapping.html#cfn-appmesh-virtualgateway-virtualgatewayportmapping-protocol
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Protocol { get; set; }
        }

        public class VirtualGatewaySpec : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Logging
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayspec.html#cfn-appmesh-virtualgateway-virtualgatewayspec-logging
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayLogging
            /// </summary>
            public VirtualGatewayTypes.VirtualGatewayLogging Logging { get; set; }
            /// <summary>
            /// Listeners
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayspec.html#cfn-appmesh-virtualgateway-virtualgatewayspec-listeners
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VirtualGatewayListener
            /// </summary>
            public List<VirtualGatewayTypes.VirtualGatewayListener> Listeners { get; set; }
            /// <summary>
            /// BackendDefaults
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayspec.html#cfn-appmesh-virtualgateway-virtualgatewayspec-backenddefaults
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayBackendDefaults
            /// </summary>
            public VirtualGatewayTypes.VirtualGatewayBackendDefaults BackendDefaults { get; set; }
        }

        public class VirtualGatewayTlsValidationContext : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SubjectAlternativeNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaytlsvalidationcontext.html#cfn-appmesh-virtualgateway-virtualgatewaytlsvalidationcontext-subjectalternativenames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SubjectAlternativeNames
            /// </summary>
            public VirtualGatewayTypes.SubjectAlternativeNames SubjectAlternativeNames { get; set; }
            /// <summary>
            /// Trust
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaytlsvalidationcontext.html#cfn-appmesh-virtualgateway-virtualgatewaytlsvalidationcontext-trust
            /// Required: True
            /// UpdateType: Mutable
            /// Type: VirtualGatewayTlsValidationContextTrust
            /// </summary>
            public VirtualGatewayTypes.VirtualGatewayTlsValidationContextTrust Trust { get; set; }
        }

        public class VirtualGatewayTlsValidationContextAcmTrust : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CertificateAuthorityArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaytlsvalidationcontextacmtrust.html#cfn-appmesh-virtualgateway-virtualgatewaytlsvalidationcontextacmtrust-certificateauthorityarns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic CertificateAuthorityArns { get; set; }
        }

        public class VirtualGatewayTlsValidationContextFileTrust : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CertificateChain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaytlsvalidationcontextfiletrust.html#cfn-appmesh-virtualgateway-virtualgatewaytlsvalidationcontextfiletrust-certificatechain
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CertificateChain { get; set; }
        }

        public class VirtualGatewayTlsValidationContextSdsTrust : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SecretName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaytlsvalidationcontextsdstrust.html#cfn-appmesh-virtualgateway-virtualgatewaytlsvalidationcontextsdstrust-secretname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecretName { get; set; }
        }

        public class VirtualGatewayTlsValidationContextTrust : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SDS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaytlsvalidationcontexttrust.html#cfn-appmesh-virtualgateway-virtualgatewaytlsvalidationcontexttrust-sds
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayTlsValidationContextSdsTrust
            /// </summary>
            public VirtualGatewayTypes.VirtualGatewayTlsValidationContextSdsTrust SDS { get; set; }
            /// <summary>
            /// ACM
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaytlsvalidationcontexttrust.html#cfn-appmesh-virtualgateway-virtualgatewaytlsvalidationcontexttrust-acm
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayTlsValidationContextAcmTrust
            /// </summary>
            public VirtualGatewayTypes.VirtualGatewayTlsValidationContextAcmTrust ACM { get; set; }
            /// <summary>
            /// File
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaytlsvalidationcontexttrust.html#cfn-appmesh-virtualgateway-virtualgatewaytlsvalidationcontexttrust-file
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayTlsValidationContextFileTrust
            /// </summary>
            public VirtualGatewayTypes.VirtualGatewayTlsValidationContextFileTrust File { get; set; }
        }
    }
}