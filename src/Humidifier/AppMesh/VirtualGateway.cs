namespace Humidifier.AppMesh
{
    using System.Collections.Generic;
    using VirtualGatewayTypes;

    public class VirtualGateway : Humidifier.Resource
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

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::AppMesh::VirtualGateway";
            }
        }

        /// <summary>
        /// VirtualGatewayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-virtualgateway.html#cfn-appmesh-virtualgateway-virtualgatewayname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic VirtualGatewayName { get; set; }
        /// <summary>
        /// MeshName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-virtualgateway.html#cfn-appmesh-virtualgateway-meshname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
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
        public VirtualGatewaySpec Spec { get; set; }
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
        public class JsonFormatRef
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

        public class LoggingFormat
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
            public List<JsonFormatRef> Json { get; set; }
        }

        public class SubjectAlternativeNameMatchers
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

        public class SubjectAlternativeNames
        {
            /// <summary>
            /// Match
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-subjectalternativenames.html#cfn-appmesh-virtualgateway-subjectalternativenames-match
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SubjectAlternativeNameMatchers
            /// </summary>
            public SubjectAlternativeNameMatchers Match { get; set; }
        }

        public class VirtualGatewayAccessLog
        {
            /// <summary>
            /// File
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayaccesslog.html#cfn-appmesh-virtualgateway-virtualgatewayaccesslog-file
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayFileAccessLog
            /// </summary>
            public VirtualGatewayFileAccessLog File { get; set; }
        }

        public class VirtualGatewayBackendDefaults
        {
            /// <summary>
            /// ClientPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaybackenddefaults.html#cfn-appmesh-virtualgateway-virtualgatewaybackenddefaults-clientpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayClientPolicy
            /// </summary>
            public VirtualGatewayClientPolicy ClientPolicy { get; set; }
        }

        public class VirtualGatewayClientPolicy
        {
            /// <summary>
            /// TLS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayclientpolicy.html#cfn-appmesh-virtualgateway-virtualgatewayclientpolicy-tls
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayClientPolicyTls
            /// </summary>
            public VirtualGatewayClientPolicyTls TLS { get; set; }
        }

        public class VirtualGatewayClientPolicyTls
        {
            /// <summary>
            /// Validation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayclientpolicytls.html#cfn-appmesh-virtualgateway-virtualgatewayclientpolicytls-validation
            /// Required: True
            /// UpdateType: Mutable
            /// Type: VirtualGatewayTlsValidationContext
            /// </summary>
            public VirtualGatewayTlsValidationContext Validation { get; set; }
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
            public VirtualGatewayClientTlsCertificate Certificate { get; set; }
        }

        public class VirtualGatewayClientTlsCertificate
        {
            /// <summary>
            /// SDS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayclienttlscertificate.html#cfn-appmesh-virtualgateway-virtualgatewayclienttlscertificate-sds
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayListenerTlsSdsCertificate
            /// </summary>
            public VirtualGatewayListenerTlsSdsCertificate SDS { get; set; }
            /// <summary>
            /// File
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayclienttlscertificate.html#cfn-appmesh-virtualgateway-virtualgatewayclienttlscertificate-file
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayListenerTlsFileCertificate
            /// </summary>
            public VirtualGatewayListenerTlsFileCertificate File { get; set; }
        }

        public class VirtualGatewayConnectionPool
        {
            /// <summary>
            /// HTTP2
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayconnectionpool.html#cfn-appmesh-virtualgateway-virtualgatewayconnectionpool-http2
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayHttp2ConnectionPool
            /// </summary>
            public VirtualGatewayHttp2ConnectionPool HTTP2 { get; set; }
            /// <summary>
            /// HTTP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayconnectionpool.html#cfn-appmesh-virtualgateway-virtualgatewayconnectionpool-http
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayHttpConnectionPool
            /// </summary>
            public VirtualGatewayHttpConnectionPool HTTP { get; set; }
            /// <summary>
            /// GRPC
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayconnectionpool.html#cfn-appmesh-virtualgateway-virtualgatewayconnectionpool-grpc
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayGrpcConnectionPool
            /// </summary>
            public VirtualGatewayGrpcConnectionPool GRPC { get; set; }
        }

        public class VirtualGatewayFileAccessLog
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
            public LoggingFormat Format { get; set; }
        }

        public class VirtualGatewayGrpcConnectionPool
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

        public class VirtualGatewayHealthCheckPolicy
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

        public class VirtualGatewayHttp2ConnectionPool
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

        public class VirtualGatewayHttpConnectionPool
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

        public class VirtualGatewayListener
        {
            /// <summary>
            /// ConnectionPool
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistener.html#cfn-appmesh-virtualgateway-virtualgatewaylistener-connectionpool
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayConnectionPool
            /// </summary>
            public VirtualGatewayConnectionPool ConnectionPool { get; set; }
            /// <summary>
            /// HealthCheck
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistener.html#cfn-appmesh-virtualgateway-virtualgatewaylistener-healthcheck
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayHealthCheckPolicy
            /// </summary>
            public VirtualGatewayHealthCheckPolicy HealthCheck { get; set; }
            /// <summary>
            /// TLS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistener.html#cfn-appmesh-virtualgateway-virtualgatewaylistener-tls
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayListenerTls
            /// </summary>
            public VirtualGatewayListenerTls TLS { get; set; }
            /// <summary>
            /// PortMapping
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistener.html#cfn-appmesh-virtualgateway-virtualgatewaylistener-portmapping
            /// Required: True
            /// UpdateType: Mutable
            /// Type: VirtualGatewayPortMapping
            /// </summary>
            public VirtualGatewayPortMapping PortMapping { get; set; }
        }

        public class VirtualGatewayListenerTls
        {
            /// <summary>
            /// Validation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistenertls.html#cfn-appmesh-virtualgateway-virtualgatewaylistenertls-validation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayListenerTlsValidationContext
            /// </summary>
            public VirtualGatewayListenerTlsValidationContext Validation { get; set; }
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
            public VirtualGatewayListenerTlsCertificate Certificate { get; set; }
        }

        public class VirtualGatewayListenerTlsAcmCertificate
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

        public class VirtualGatewayListenerTlsCertificate
        {
            /// <summary>
            /// SDS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistenertlscertificate.html#cfn-appmesh-virtualgateway-virtualgatewaylistenertlscertificate-sds
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayListenerTlsSdsCertificate
            /// </summary>
            public VirtualGatewayListenerTlsSdsCertificate SDS { get; set; }
            /// <summary>
            /// ACM
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistenertlscertificate.html#cfn-appmesh-virtualgateway-virtualgatewaylistenertlscertificate-acm
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayListenerTlsAcmCertificate
            /// </summary>
            public VirtualGatewayListenerTlsAcmCertificate ACM { get; set; }
            /// <summary>
            /// File
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistenertlscertificate.html#cfn-appmesh-virtualgateway-virtualgatewaylistenertlscertificate-file
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayListenerTlsFileCertificate
            /// </summary>
            public VirtualGatewayListenerTlsFileCertificate File { get; set; }
        }

        public class VirtualGatewayListenerTlsFileCertificate
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

        public class VirtualGatewayListenerTlsSdsCertificate
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

        public class VirtualGatewayListenerTlsValidationContext
        {
            /// <summary>
            /// SubjectAlternativeNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistenertlsvalidationcontext.html#cfn-appmesh-virtualgateway-virtualgatewaylistenertlsvalidationcontext-subjectalternativenames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SubjectAlternativeNames
            /// </summary>
            public SubjectAlternativeNames SubjectAlternativeNames { get; set; }
            /// <summary>
            /// Trust
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistenertlsvalidationcontext.html#cfn-appmesh-virtualgateway-virtualgatewaylistenertlsvalidationcontext-trust
            /// Required: True
            /// UpdateType: Mutable
            /// Type: VirtualGatewayListenerTlsValidationContextTrust
            /// </summary>
            public VirtualGatewayListenerTlsValidationContextTrust Trust { get; set; }
        }

        public class VirtualGatewayListenerTlsValidationContextTrust
        {
            /// <summary>
            /// SDS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistenertlsvalidationcontexttrust.html#cfn-appmesh-virtualgateway-virtualgatewaylistenertlsvalidationcontexttrust-sds
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayTlsValidationContextSdsTrust
            /// </summary>
            public VirtualGatewayTlsValidationContextSdsTrust SDS { get; set; }
            /// <summary>
            /// File
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylistenertlsvalidationcontexttrust.html#cfn-appmesh-virtualgateway-virtualgatewaylistenertlsvalidationcontexttrust-file
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayTlsValidationContextFileTrust
            /// </summary>
            public VirtualGatewayTlsValidationContextFileTrust File { get; set; }
        }

        public class VirtualGatewayLogging
        {
            /// <summary>
            /// AccessLog
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaylogging.html#cfn-appmesh-virtualgateway-virtualgatewaylogging-accesslog
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayAccessLog
            /// </summary>
            public VirtualGatewayAccessLog AccessLog { get; set; }
        }

        public class VirtualGatewayPortMapping
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

        public class VirtualGatewaySpec
        {
            /// <summary>
            /// Logging
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayspec.html#cfn-appmesh-virtualgateway-virtualgatewayspec-logging
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayLogging
            /// </summary>
            public VirtualGatewayLogging Logging { get; set; }
            /// <summary>
            /// Listeners
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayspec.html#cfn-appmesh-virtualgateway-virtualgatewayspec-listeners
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VirtualGatewayListener
            /// </summary>
            public List<VirtualGatewayListener> Listeners { get; set; }
            /// <summary>
            /// BackendDefaults
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewayspec.html#cfn-appmesh-virtualgateway-virtualgatewayspec-backenddefaults
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayBackendDefaults
            /// </summary>
            public VirtualGatewayBackendDefaults BackendDefaults { get; set; }
        }

        public class VirtualGatewayTlsValidationContext
        {
            /// <summary>
            /// SubjectAlternativeNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaytlsvalidationcontext.html#cfn-appmesh-virtualgateway-virtualgatewaytlsvalidationcontext-subjectalternativenames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SubjectAlternativeNames
            /// </summary>
            public SubjectAlternativeNames SubjectAlternativeNames { get; set; }
            /// <summary>
            /// Trust
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaytlsvalidationcontext.html#cfn-appmesh-virtualgateway-virtualgatewaytlsvalidationcontext-trust
            /// Required: True
            /// UpdateType: Mutable
            /// Type: VirtualGatewayTlsValidationContextTrust
            /// </summary>
            public VirtualGatewayTlsValidationContextTrust Trust { get; set; }
        }

        public class VirtualGatewayTlsValidationContextAcmTrust
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

        public class VirtualGatewayTlsValidationContextFileTrust
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

        public class VirtualGatewayTlsValidationContextSdsTrust
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

        public class VirtualGatewayTlsValidationContextTrust
        {
            /// <summary>
            /// SDS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaytlsvalidationcontexttrust.html#cfn-appmesh-virtualgateway-virtualgatewaytlsvalidationcontexttrust-sds
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayTlsValidationContextSdsTrust
            /// </summary>
            public VirtualGatewayTlsValidationContextSdsTrust SDS { get; set; }
            /// <summary>
            /// ACM
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaytlsvalidationcontexttrust.html#cfn-appmesh-virtualgateway-virtualgatewaytlsvalidationcontexttrust-acm
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayTlsValidationContextAcmTrust
            /// </summary>
            public VirtualGatewayTlsValidationContextAcmTrust ACM { get; set; }
            /// <summary>
            /// File
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualgateway-virtualgatewaytlsvalidationcontexttrust.html#cfn-appmesh-virtualgateway-virtualgatewaytlsvalidationcontexttrust-file
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualGatewayTlsValidationContextFileTrust
            /// </summary>
            public VirtualGatewayTlsValidationContextFileTrust File { get; set; }
        }
    }
}