namespace Humidifier.AppMesh
{
    using System.Collections.Generic;
    using VirtualNodeTypes;

    public class VirtualNode : Humidifier.Resource
    {
        public class Attributes
        {
            public static string Uid =  "Uid" ;
            public static string MeshName =  "MeshName" ;
            public static string MeshOwner =  "MeshOwner" ;
            public static string ResourceOwner =  "ResourceOwner" ;
            public static string Arn =  "Arn" ;
            public static string VirtualNodeName =  "VirtualNodeName" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::AppMesh::VirtualNode";
            }
        }

        /// <summary>
        /// MeshName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-virtualnode.html#cfn-appmesh-virtualnode-meshname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic MeshName { get; set; }
        /// <summary>
        /// MeshOwner
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-virtualnode.html#cfn-appmesh-virtualnode-meshowner
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic MeshOwner { get; set; }
        /// <summary>
        /// Spec
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-virtualnode.html#cfn-appmesh-virtualnode-spec
        /// Required: True
        /// UpdateType: Mutable
        /// Type: VirtualNodeSpec
        /// </summary>
        public VirtualNodeSpec Spec { get; set; }
        /// <summary>
        /// VirtualNodeName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-virtualnode.html#cfn-appmesh-virtualnode-virtualnodename
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic VirtualNodeName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-virtualnode.html#cfn-appmesh-virtualnode-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace VirtualNodeTypes
    {
        public class AccessLog
        {
            /// <summary>
            /// File
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-accesslog.html#cfn-appmesh-virtualnode-accesslog-file
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FileAccessLog
            /// </summary>
            public FileAccessLog File { get; set; }
        }

        public class AwsCloudMapInstanceAttribute
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-awscloudmapinstanceattribute.html#cfn-appmesh-virtualnode-awscloudmapinstanceattribute-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-awscloudmapinstanceattribute.html#cfn-appmesh-virtualnode-awscloudmapinstanceattribute-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class AwsCloudMapServiceDiscovery
        {
            /// <summary>
            /// NamespaceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-awscloudmapservicediscovery.html#cfn-appmesh-virtualnode-awscloudmapservicediscovery-namespacename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NamespaceName { get; set; }
            /// <summary>
            /// ServiceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-awscloudmapservicediscovery.html#cfn-appmesh-virtualnode-awscloudmapservicediscovery-servicename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ServiceName { get; set; }
            /// <summary>
            /// IpPreference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-awscloudmapservicediscovery.html#cfn-appmesh-virtualnode-awscloudmapservicediscovery-ippreference
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IpPreference { get; set; }
            /// <summary>
            /// Attributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-awscloudmapservicediscovery.html#cfn-appmesh-virtualnode-awscloudmapservicediscovery-attributes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AwsCloudMapInstanceAttribute
            /// </summary>
            public List<AwsCloudMapInstanceAttribute> Attributes_ { get; set; }
        }

        public class Backend
        {
            /// <summary>
            /// VirtualService
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-backend.html#cfn-appmesh-virtualnode-backend-virtualservice
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualServiceBackend
            /// </summary>
            public VirtualServiceBackend VirtualService { get; set; }
        }

        public class BackendDefaults
        {
            /// <summary>
            /// ClientPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-backenddefaults.html#cfn-appmesh-virtualnode-backenddefaults-clientpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ClientPolicy
            /// </summary>
            public ClientPolicy ClientPolicy { get; set; }
        }

        public class ClientPolicy
        {
            /// <summary>
            /// TLS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-clientpolicy.html#cfn-appmesh-virtualnode-clientpolicy-tls
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ClientPolicyTls
            /// </summary>
            public ClientPolicyTls TLS { get; set; }
        }

        public class ClientPolicyTls
        {
            /// <summary>
            /// Validation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-clientpolicytls.html#cfn-appmesh-virtualnode-clientpolicytls-validation
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TlsValidationContext
            /// </summary>
            public TlsValidationContext Validation { get; set; }
            /// <summary>
            /// Enforce
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-clientpolicytls.html#cfn-appmesh-virtualnode-clientpolicytls-enforce
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enforce { get; set; }
            /// <summary>
            /// Ports
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-clientpolicytls.html#cfn-appmesh-virtualnode-clientpolicytls-ports
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public List<int> Ports { get; set; }
            /// <summary>
            /// Certificate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-clientpolicytls.html#cfn-appmesh-virtualnode-clientpolicytls-certificate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ClientTlsCertificate
            /// </summary>
            public ClientTlsCertificate Certificate { get; set; }
        }

        public class ClientTlsCertificate
        {
            /// <summary>
            /// SDS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-clienttlscertificate.html#cfn-appmesh-virtualnode-clienttlscertificate-sds
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ListenerTlsSdsCertificate
            /// </summary>
            public ListenerTlsSdsCertificate SDS { get; set; }
            /// <summary>
            /// File
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-clienttlscertificate.html#cfn-appmesh-virtualnode-clienttlscertificate-file
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ListenerTlsFileCertificate
            /// </summary>
            public ListenerTlsFileCertificate File { get; set; }
        }

        public class DnsServiceDiscovery
        {
            /// <summary>
            /// IpPreference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-dnsservicediscovery.html#cfn-appmesh-virtualnode-dnsservicediscovery-ippreference
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IpPreference { get; set; }
            /// <summary>
            /// Hostname
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-dnsservicediscovery.html#cfn-appmesh-virtualnode-dnsservicediscovery-hostname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Hostname { get; set; }
            /// <summary>
            /// ResponseType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-dnsservicediscovery.html#cfn-appmesh-virtualnode-dnsservicediscovery-responsetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResponseType { get; set; }
        }

        public class Duration
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-duration.html#cfn-appmesh-virtualnode-duration-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-duration.html#cfn-appmesh-virtualnode-duration-unit
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Unit { get; set; }
        }

        public class FileAccessLog
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-fileaccesslog.html#cfn-appmesh-virtualnode-fileaccesslog-path
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Path { get; set; }
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-fileaccesslog.html#cfn-appmesh-virtualnode-fileaccesslog-format
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LoggingFormat
            /// </summary>
            public LoggingFormat Format { get; set; }
        }

        public class GrpcTimeout
        {
            /// <summary>
            /// PerRequest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-grpctimeout.html#cfn-appmesh-virtualnode-grpctimeout-perrequest
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Duration
            /// </summary>
            public Duration PerRequest { get; set; }
            /// <summary>
            /// Idle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-grpctimeout.html#cfn-appmesh-virtualnode-grpctimeout-idle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Duration
            /// </summary>
            public Duration Idle { get; set; }
        }

        public class HealthCheck
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-healthcheck.html#cfn-appmesh-virtualnode-healthcheck-path
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Path { get; set; }
            /// <summary>
            /// UnhealthyThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-healthcheck.html#cfn-appmesh-virtualnode-healthcheck-unhealthythreshold
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic UnhealthyThreshold { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-healthcheck.html#cfn-appmesh-virtualnode-healthcheck-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Port { get; set; }
            /// <summary>
            /// HealthyThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-healthcheck.html#cfn-appmesh-virtualnode-healthcheck-healthythreshold
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic HealthyThreshold { get; set; }
            /// <summary>
            /// TimeoutMillis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-healthcheck.html#cfn-appmesh-virtualnode-healthcheck-timeoutmillis
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TimeoutMillis { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-healthcheck.html#cfn-appmesh-virtualnode-healthcheck-protocol
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Protocol { get; set; }
            /// <summary>
            /// IntervalMillis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-healthcheck.html#cfn-appmesh-virtualnode-healthcheck-intervalmillis
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic IntervalMillis { get; set; }
        }

        public class HttpTimeout
        {
            /// <summary>
            /// PerRequest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-httptimeout.html#cfn-appmesh-virtualnode-httptimeout-perrequest
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Duration
            /// </summary>
            public Duration PerRequest { get; set; }
            /// <summary>
            /// Idle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-httptimeout.html#cfn-appmesh-virtualnode-httptimeout-idle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Duration
            /// </summary>
            public Duration Idle { get; set; }
        }

        public class JsonFormatRef
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-jsonformatref.html#cfn-appmesh-virtualnode-jsonformatref-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-jsonformatref.html#cfn-appmesh-virtualnode-jsonformatref-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class Listener
        {
            /// <summary>
            /// ConnectionPool
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listener.html#cfn-appmesh-virtualnode-listener-connectionpool
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualNodeConnectionPool
            /// </summary>
            public VirtualNodeConnectionPool ConnectionPool { get; set; }
            /// <summary>
            /// Timeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listener.html#cfn-appmesh-virtualnode-listener-timeout
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ListenerTimeout
            /// </summary>
            public ListenerTimeout Timeout { get; set; }
            /// <summary>
            /// HealthCheck
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listener.html#cfn-appmesh-virtualnode-listener-healthcheck
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HealthCheck
            /// </summary>
            public HealthCheck HealthCheck { get; set; }
            /// <summary>
            /// TLS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listener.html#cfn-appmesh-virtualnode-listener-tls
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ListenerTls
            /// </summary>
            public ListenerTls TLS { get; set; }
            /// <summary>
            /// PortMapping
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listener.html#cfn-appmesh-virtualnode-listener-portmapping
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PortMapping
            /// </summary>
            public PortMapping PortMapping { get; set; }
            /// <summary>
            /// OutlierDetection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listener.html#cfn-appmesh-virtualnode-listener-outlierdetection
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OutlierDetection
            /// </summary>
            public OutlierDetection OutlierDetection { get; set; }
        }

        public class ListenerTimeout
        {
            /// <summary>
            /// TCP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listenertimeout.html#cfn-appmesh-virtualnode-listenertimeout-tcp
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TcpTimeout
            /// </summary>
            public TcpTimeout TCP { get; set; }
            /// <summary>
            /// HTTP2
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listenertimeout.html#cfn-appmesh-virtualnode-listenertimeout-http2
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpTimeout
            /// </summary>
            public HttpTimeout HTTP2 { get; set; }
            /// <summary>
            /// HTTP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listenertimeout.html#cfn-appmesh-virtualnode-listenertimeout-http
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpTimeout
            /// </summary>
            public HttpTimeout HTTP { get; set; }
            /// <summary>
            /// GRPC
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listenertimeout.html#cfn-appmesh-virtualnode-listenertimeout-grpc
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GrpcTimeout
            /// </summary>
            public GrpcTimeout GRPC { get; set; }
        }

        public class ListenerTls
        {
            /// <summary>
            /// Validation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listenertls.html#cfn-appmesh-virtualnode-listenertls-validation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ListenerTlsValidationContext
            /// </summary>
            public ListenerTlsValidationContext Validation { get; set; }
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listenertls.html#cfn-appmesh-virtualnode-listenertls-mode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Mode { get; set; }
            /// <summary>
            /// Certificate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listenertls.html#cfn-appmesh-virtualnode-listenertls-certificate
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ListenerTlsCertificate
            /// </summary>
            public ListenerTlsCertificate Certificate { get; set; }
        }

        public class ListenerTlsAcmCertificate
        {
            /// <summary>
            /// CertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listenertlsacmcertificate.html#cfn-appmesh-virtualnode-listenertlsacmcertificate-certificatearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CertificateArn { get; set; }
        }

        public class ListenerTlsCertificate
        {
            /// <summary>
            /// SDS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listenertlscertificate.html#cfn-appmesh-virtualnode-listenertlscertificate-sds
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ListenerTlsSdsCertificate
            /// </summary>
            public ListenerTlsSdsCertificate SDS { get; set; }
            /// <summary>
            /// ACM
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listenertlscertificate.html#cfn-appmesh-virtualnode-listenertlscertificate-acm
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ListenerTlsAcmCertificate
            /// </summary>
            public ListenerTlsAcmCertificate ACM { get; set; }
            /// <summary>
            /// File
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listenertlscertificate.html#cfn-appmesh-virtualnode-listenertlscertificate-file
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ListenerTlsFileCertificate
            /// </summary>
            public ListenerTlsFileCertificate File { get; set; }
        }

        public class ListenerTlsFileCertificate
        {
            /// <summary>
            /// PrivateKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listenertlsfilecertificate.html#cfn-appmesh-virtualnode-listenertlsfilecertificate-privatekey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PrivateKey { get; set; }
            /// <summary>
            /// CertificateChain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listenertlsfilecertificate.html#cfn-appmesh-virtualnode-listenertlsfilecertificate-certificatechain
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CertificateChain { get; set; }
        }

        public class ListenerTlsSdsCertificate
        {
            /// <summary>
            /// SecretName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listenertlssdscertificate.html#cfn-appmesh-virtualnode-listenertlssdscertificate-secretname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecretName { get; set; }
        }

        public class ListenerTlsValidationContext
        {
            /// <summary>
            /// SubjectAlternativeNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listenertlsvalidationcontext.html#cfn-appmesh-virtualnode-listenertlsvalidationcontext-subjectalternativenames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SubjectAlternativeNames
            /// </summary>
            public SubjectAlternativeNames SubjectAlternativeNames { get; set; }
            /// <summary>
            /// Trust
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listenertlsvalidationcontext.html#cfn-appmesh-virtualnode-listenertlsvalidationcontext-trust
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ListenerTlsValidationContextTrust
            /// </summary>
            public ListenerTlsValidationContextTrust Trust { get; set; }
        }

        public class ListenerTlsValidationContextTrust
        {
            /// <summary>
            /// SDS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listenertlsvalidationcontexttrust.html#cfn-appmesh-virtualnode-listenertlsvalidationcontexttrust-sds
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TlsValidationContextSdsTrust
            /// </summary>
            public TlsValidationContextSdsTrust SDS { get; set; }
            /// <summary>
            /// File
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listenertlsvalidationcontexttrust.html#cfn-appmesh-virtualnode-listenertlsvalidationcontexttrust-file
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TlsValidationContextFileTrust
            /// </summary>
            public TlsValidationContextFileTrust File { get; set; }
        }

        public class Logging
        {
            /// <summary>
            /// AccessLog
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-logging.html#cfn-appmesh-virtualnode-logging-accesslog
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AccessLog
            /// </summary>
            public AccessLog AccessLog { get; set; }
        }

        public class LoggingFormat
        {
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-loggingformat.html#cfn-appmesh-virtualnode-loggingformat-text
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Text { get; set; }
            /// <summary>
            /// Json
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-loggingformat.html#cfn-appmesh-virtualnode-loggingformat-json
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: JsonFormatRef
            /// </summary>
            public List<JsonFormatRef> Json { get; set; }
        }

        public class OutlierDetection
        {
            /// <summary>
            /// MaxEjectionPercent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-outlierdetection.html#cfn-appmesh-virtualnode-outlierdetection-maxejectionpercent
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxEjectionPercent { get; set; }
            /// <summary>
            /// BaseEjectionDuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-outlierdetection.html#cfn-appmesh-virtualnode-outlierdetection-baseejectionduration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Duration
            /// </summary>
            public Duration BaseEjectionDuration { get; set; }
            /// <summary>
            /// MaxServerErrors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-outlierdetection.html#cfn-appmesh-virtualnode-outlierdetection-maxservererrors
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxServerErrors { get; set; }
            /// <summary>
            /// Interval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-outlierdetection.html#cfn-appmesh-virtualnode-outlierdetection-interval
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Duration
            /// </summary>
            public Duration Interval { get; set; }
        }

        public class PortMapping
        {
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-portmapping.html#cfn-appmesh-virtualnode-portmapping-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Port { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-portmapping.html#cfn-appmesh-virtualnode-portmapping-protocol
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Protocol { get; set; }
        }

        public class ServiceDiscovery
        {
            /// <summary>
            /// DNS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-servicediscovery.html#cfn-appmesh-virtualnode-servicediscovery-dns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DnsServiceDiscovery
            /// </summary>
            public DnsServiceDiscovery DNS { get; set; }
            /// <summary>
            /// AWSCloudMap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-servicediscovery.html#cfn-appmesh-virtualnode-servicediscovery-awscloudmap
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AwsCloudMapServiceDiscovery
            /// </summary>
            public AwsCloudMapServiceDiscovery AWSCloudMap { get; set; }
        }

        public class SubjectAlternativeNameMatchers
        {
            /// <summary>
            /// Exact
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-subjectalternativenamematchers.html#cfn-appmesh-virtualnode-subjectalternativenamematchers-exact
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-subjectalternativenames.html#cfn-appmesh-virtualnode-subjectalternativenames-match
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SubjectAlternativeNameMatchers
            /// </summary>
            public SubjectAlternativeNameMatchers Match { get; set; }
        }

        public class TcpTimeout
        {
            /// <summary>
            /// Idle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-tcptimeout.html#cfn-appmesh-virtualnode-tcptimeout-idle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Duration
            /// </summary>
            public Duration Idle { get; set; }
        }

        public class TlsValidationContext
        {
            /// <summary>
            /// SubjectAlternativeNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-tlsvalidationcontext.html#cfn-appmesh-virtualnode-tlsvalidationcontext-subjectalternativenames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SubjectAlternativeNames
            /// </summary>
            public SubjectAlternativeNames SubjectAlternativeNames { get; set; }
            /// <summary>
            /// Trust
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-tlsvalidationcontext.html#cfn-appmesh-virtualnode-tlsvalidationcontext-trust
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TlsValidationContextTrust
            /// </summary>
            public TlsValidationContextTrust Trust { get; set; }
        }

        public class TlsValidationContextAcmTrust
        {
            /// <summary>
            /// CertificateAuthorityArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-tlsvalidationcontextacmtrust.html#cfn-appmesh-virtualnode-tlsvalidationcontextacmtrust-certificateauthorityarns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic CertificateAuthorityArns { get; set; }
        }

        public class TlsValidationContextFileTrust
        {
            /// <summary>
            /// CertificateChain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-tlsvalidationcontextfiletrust.html#cfn-appmesh-virtualnode-tlsvalidationcontextfiletrust-certificatechain
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CertificateChain { get; set; }
        }

        public class TlsValidationContextSdsTrust
        {
            /// <summary>
            /// SecretName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-tlsvalidationcontextsdstrust.html#cfn-appmesh-virtualnode-tlsvalidationcontextsdstrust-secretname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecretName { get; set; }
        }

        public class TlsValidationContextTrust
        {
            /// <summary>
            /// SDS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-tlsvalidationcontexttrust.html#cfn-appmesh-virtualnode-tlsvalidationcontexttrust-sds
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TlsValidationContextSdsTrust
            /// </summary>
            public TlsValidationContextSdsTrust SDS { get; set; }
            /// <summary>
            /// ACM
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-tlsvalidationcontexttrust.html#cfn-appmesh-virtualnode-tlsvalidationcontexttrust-acm
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TlsValidationContextAcmTrust
            /// </summary>
            public TlsValidationContextAcmTrust ACM { get; set; }
            /// <summary>
            /// File
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-tlsvalidationcontexttrust.html#cfn-appmesh-virtualnode-tlsvalidationcontexttrust-file
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TlsValidationContextFileTrust
            /// </summary>
            public TlsValidationContextFileTrust File { get; set; }
        }

        public class VirtualNodeConnectionPool
        {
            /// <summary>
            /// TCP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-virtualnodeconnectionpool.html#cfn-appmesh-virtualnode-virtualnodeconnectionpool-tcp
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualNodeTcpConnectionPool
            /// </summary>
            public VirtualNodeTcpConnectionPool TCP { get; set; }
            /// <summary>
            /// HTTP2
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-virtualnodeconnectionpool.html#cfn-appmesh-virtualnode-virtualnodeconnectionpool-http2
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualNodeHttp2ConnectionPool
            /// </summary>
            public VirtualNodeHttp2ConnectionPool HTTP2 { get; set; }
            /// <summary>
            /// HTTP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-virtualnodeconnectionpool.html#cfn-appmesh-virtualnode-virtualnodeconnectionpool-http
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualNodeHttpConnectionPool
            /// </summary>
            public VirtualNodeHttpConnectionPool HTTP { get; set; }
            /// <summary>
            /// GRPC
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-virtualnodeconnectionpool.html#cfn-appmesh-virtualnode-virtualnodeconnectionpool-grpc
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualNodeGrpcConnectionPool
            /// </summary>
            public VirtualNodeGrpcConnectionPool GRPC { get; set; }
        }

        public class VirtualNodeGrpcConnectionPool
        {
            /// <summary>
            /// MaxRequests
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-virtualnodegrpcconnectionpool.html#cfn-appmesh-virtualnode-virtualnodegrpcconnectionpool-maxrequests
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxRequests { get; set; }
        }

        public class VirtualNodeHttp2ConnectionPool
        {
            /// <summary>
            /// MaxRequests
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-virtualnodehttp2connectionpool.html#cfn-appmesh-virtualnode-virtualnodehttp2connectionpool-maxrequests
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxRequests { get; set; }
        }

        public class VirtualNodeHttpConnectionPool
        {
            /// <summary>
            /// MaxConnections
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-virtualnodehttpconnectionpool.html#cfn-appmesh-virtualnode-virtualnodehttpconnectionpool-maxconnections
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxConnections { get; set; }
            /// <summary>
            /// MaxPendingRequests
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-virtualnodehttpconnectionpool.html#cfn-appmesh-virtualnode-virtualnodehttpconnectionpool-maxpendingrequests
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxPendingRequests { get; set; }
        }

        public class VirtualNodeSpec
        {
            /// <summary>
            /// Logging
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-virtualnodespec.html#cfn-appmesh-virtualnode-virtualnodespec-logging
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Logging
            /// </summary>
            public Logging Logging { get; set; }
            /// <summary>
            /// Backends
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-virtualnodespec.html#cfn-appmesh-virtualnode-virtualnodespec-backends
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Backend
            /// </summary>
            public List<Backend> Backends { get; set; }
            /// <summary>
            /// Listeners
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-virtualnodespec.html#cfn-appmesh-virtualnode-virtualnodespec-listeners
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Listener
            /// </summary>
            public List<Listener> Listeners { get; set; }
            /// <summary>
            /// BackendDefaults
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-virtualnodespec.html#cfn-appmesh-virtualnode-virtualnodespec-backenddefaults
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BackendDefaults
            /// </summary>
            public BackendDefaults BackendDefaults { get; set; }
            /// <summary>
            /// ServiceDiscovery
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-virtualnodespec.html#cfn-appmesh-virtualnode-virtualnodespec-servicediscovery
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ServiceDiscovery
            /// </summary>
            public ServiceDiscovery ServiceDiscovery { get; set; }
        }

        public class VirtualNodeTcpConnectionPool
        {
            /// <summary>
            /// MaxConnections
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-virtualnodetcpconnectionpool.html#cfn-appmesh-virtualnode-virtualnodetcpconnectionpool-maxconnections
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxConnections { get; set; }
        }

        public class VirtualServiceBackend
        {
            /// <summary>
            /// ClientPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-virtualservicebackend.html#cfn-appmesh-virtualnode-virtualservicebackend-clientpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ClientPolicy
            /// </summary>
            public ClientPolicy ClientPolicy { get; set; }
            /// <summary>
            /// VirtualServiceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-virtualservicebackend.html#cfn-appmesh-virtualnode-virtualservicebackend-virtualservicename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VirtualServiceName { get; set; }
        }
    }
}