namespace Humidifier.AppMesh
{
    using global::System.Collections.Generic;
    using VirtualNodeTypes;

    public class VirtualNode : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveMeshName, IHaveMeshOwner, IHaveAppMeshVirtualNodeTypesVirtualNodeSpecSpec, IHaveVirtualNodeName
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

        public override string AWSTypeName { get => AWS.AppMesh.VirtualNode; }

        /// <summary>
        /// MeshName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-virtualnode.html#cfn-appmesh-virtualnode-meshname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? MeshName { get; set; }
        /// <summary>
        /// MeshOwner
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-virtualnode.html#cfn-appmesh-virtualnode-meshowner
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? MeshOwner { get; set; }

        /// <summary>
        /// Spec
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-virtualnode.html#cfn-appmesh-virtualnode-spec
        /// Required: True
        /// UpdateType: Mutable
        /// Type: VirtualNodeSpec
        /// </summary>
        [Required]
        public Union<Humidifier.AppMesh.VirtualNodeTypes.VirtualNodeSpec, BaseFunction>? Spec { get; set; }
        public Union<string, BaseFunction>? VirtualNodeName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appmesh-virtualnode.html#cfn-appmesh-virtualnode-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace VirtualNodeTypes
    {
        public class AccessLog : Humidifier.Base.BaseSubResource, IHaveAppMeshVirtualNodeTypesFileAccessLogFile
        {
            /// <summary>
            /// File
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-accesslog.html#cfn-appmesh-virtualnode-accesslog-file
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FileAccessLog
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.FileAccessLog, BaseFunction>? File { get; set; }
        }

        public class AwsCloudMapInstanceAttribute : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-awscloudmapinstanceattribute.html#cfn-appmesh-virtualnode-awscloudmapinstanceattribute-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-awscloudmapinstanceattribute.html#cfn-appmesh-virtualnode-awscloudmapinstanceattribute-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class AwsCloudMapServiceDiscovery : Humidifier.Base.BaseSubResource, IHaveNamespaceName, IHaveServiceName, IHaveIpPreference, IHaveListOfAppMeshVirtualNodeTypesAwsCloudMapInstanceAttributeAttributes_
        {
            /// <summary>
            /// NamespaceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-awscloudmapservicediscovery.html#cfn-appmesh-virtualnode-awscloudmapservicediscovery-namespacename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NamespaceName { get; set; }
            /// <summary>
            /// ServiceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-awscloudmapservicediscovery.html#cfn-appmesh-virtualnode-awscloudmapservicediscovery-servicename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServiceName { get; set; }
            /// <summary>
            /// IpPreference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-awscloudmapservicediscovery.html#cfn-appmesh-virtualnode-awscloudmapservicediscovery-ippreference
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IpPreference { get; set; }
            /// <summary>
            /// Attributes_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-awscloudmapservicediscovery.html#cfn-appmesh-virtualnode-awscloudmapservicediscovery-attributes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AwsCloudMapInstanceAttribute
            /// </summary>
            public Union<IReadOnlyList<Humidifier.AppMesh.VirtualNodeTypes.AwsCloudMapInstanceAttribute>, IReadOnlyList<Union<Humidifier.AppMesh.VirtualNodeTypes.AwsCloudMapInstanceAttribute, BaseFunction>>, BaseFunction>? Attributes_ { get; set; }
        }

        public class Backend : Humidifier.Base.BaseSubResource, IHaveAppMeshVirtualNodeTypesVirtualServiceBackendVirtualService
        {
            /// <summary>
            /// VirtualService
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-backend.html#cfn-appmesh-virtualnode-backend-virtualservice
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualServiceBackend
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.VirtualServiceBackend, BaseFunction>? VirtualService { get; set; }
        }

        public class BackendDefaults : Humidifier.Base.BaseSubResource, IHaveAppMeshVirtualNodeTypesClientPolicyClientPolicy
        {
            /// <summary>
            /// ClientPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-backenddefaults.html#cfn-appmesh-virtualnode-backenddefaults-clientpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ClientPolicy
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.ClientPolicy, BaseFunction>? ClientPolicy { get; set; }
        }

        public class ClientPolicy : Humidifier.Base.BaseSubResource, IHaveAppMeshVirtualNodeTypesClientPolicyTlsTLS
        {
            /// <summary>
            /// TLS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-clientpolicy.html#cfn-appmesh-virtualnode-clientpolicy-tls
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ClientPolicyTls
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.ClientPolicyTls, BaseFunction>? TLS { get; set; }
        }

        public class ClientPolicyTls : Humidifier.Base.BaseSubResource, IHaveAppMeshVirtualNodeTypesTlsValidationContextValidation, IHaveEnforce_Boolean, IHaveIntegerListOfPorts, IHaveAppMeshVirtualNodeTypesClientTlsCertificateCertificate
        {
            /// <summary>
            /// Validation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-clientpolicytls.html#cfn-appmesh-virtualnode-clientpolicytls-validation
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TlsValidationContext
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContext, BaseFunction>? Validation { get; set; }
            /// <summary>
            /// Enforce
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-clientpolicytls.html#cfn-appmesh-virtualnode-clientpolicytls-enforce
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enforce { get; set; }
            /// <summary>
            /// Ports
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-clientpolicytls.html#cfn-appmesh-virtualnode-clientpolicytls-ports
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public Union<IReadOnlyList<int>, IReadOnlyList<Union<int, BaseFunction>>, BaseFunction>? Ports { get; set; }
            /// <summary>
            /// Certificate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-clientpolicytls.html#cfn-appmesh-virtualnode-clientpolicytls-certificate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ClientTlsCertificate
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.ClientTlsCertificate, BaseFunction>? Certificate { get; set; }
        }

        public class ClientTlsCertificate : Humidifier.Base.BaseSubResource, IHaveAppMeshVirtualNodeTypesListenerTlsSdsCertificateSDS, IHaveAppMeshVirtualNodeTypesListenerTlsFileCertificateFile
        {
            /// <summary>
            /// SDS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-clienttlscertificate.html#cfn-appmesh-virtualnode-clienttlscertificate-sds
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ListenerTlsSdsCertificate
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsSdsCertificate, BaseFunction>? SDS { get; set; }
            /// <summary>
            /// File
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-clienttlscertificate.html#cfn-appmesh-virtualnode-clienttlscertificate-file
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ListenerTlsFileCertificate
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsFileCertificate, BaseFunction>? File { get; set; }
        }

        public class DnsServiceDiscovery : Humidifier.Base.BaseSubResource, IHaveIpPreference, IHaveHostname, IHaveResponseType
        {
            /// <summary>
            /// IpPreference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-dnsservicediscovery.html#cfn-appmesh-virtualnode-dnsservicediscovery-ippreference
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IpPreference { get; set; }
            /// <summary>
            /// Hostname
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-dnsservicediscovery.html#cfn-appmesh-virtualnode-dnsservicediscovery-hostname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Hostname { get; set; }
            /// <summary>
            /// ResponseType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-dnsservicediscovery.html#cfn-appmesh-virtualnode-dnsservicediscovery-responsetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResponseType { get; set; }
        }

        public class Duration : Humidifier.Base.BaseSubResource, IHaveValue_Integer, IHaveUnit
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-duration.html#cfn-appmesh-virtualnode-duration-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-duration.html#cfn-appmesh-virtualnode-duration-unit
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Unit { get; set; }
        }

        public class FileAccessLog : Humidifier.Base.BaseSubResource, IHavePath, IHaveAppMeshVirtualNodeTypesLoggingFormatFormat
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-fileaccesslog.html#cfn-appmesh-virtualnode-fileaccesslog-path
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Path { get; set; }
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-fileaccesslog.html#cfn-appmesh-virtualnode-fileaccesslog-format
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LoggingFormat
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.LoggingFormat, BaseFunction>? Format { get; set; }
        }

        public class GrpcTimeout : Humidifier.Base.BaseSubResource, IHaveAppMeshVirtualNodeTypesDurationPerRequest, IHaveAppMeshVirtualNodeTypesDurationIdle
        {
            /// <summary>
            /// PerRequest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-grpctimeout.html#cfn-appmesh-virtualnode-grpctimeout-perrequest
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Duration
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.Duration, BaseFunction>? PerRequest { get; set; }
            /// <summary>
            /// Idle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-grpctimeout.html#cfn-appmesh-virtualnode-grpctimeout-idle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Duration
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.Duration, BaseFunction>? Idle { get; set; }
        }

        public class HealthCheck : Humidifier.Base.BaseSubResource, IHavePath, IHaveUnhealthyThreshold_Integer, IHavePort_Integer, IHaveHealthyThreshold_Integer, IHaveTimeoutMillis_Integer, IHaveProtocol, IHaveIntervalMillis_Integer
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-healthcheck.html#cfn-appmesh-virtualnode-healthcheck-path
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Path { get; set; }
            /// <summary>
            /// UnhealthyThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-healthcheck.html#cfn-appmesh-virtualnode-healthcheck-unhealthythreshold
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? UnhealthyThreshold { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-healthcheck.html#cfn-appmesh-virtualnode-healthcheck-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Port { get; set; }
            /// <summary>
            /// HealthyThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-healthcheck.html#cfn-appmesh-virtualnode-healthcheck-healthythreshold
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? HealthyThreshold { get; set; }
            /// <summary>
            /// TimeoutMillis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-healthcheck.html#cfn-appmesh-virtualnode-healthcheck-timeoutmillis
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimeoutMillis { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-healthcheck.html#cfn-appmesh-virtualnode-healthcheck-protocol
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Protocol { get; set; }
            /// <summary>
            /// IntervalMillis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-healthcheck.html#cfn-appmesh-virtualnode-healthcheck-intervalmillis
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? IntervalMillis { get; set; }
        }

        public class HttpTimeout : Humidifier.Base.BaseSubResource, IHaveAppMeshVirtualNodeTypesDurationPerRequest, IHaveAppMeshVirtualNodeTypesDurationIdle
        {
            /// <summary>
            /// PerRequest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-httptimeout.html#cfn-appmesh-virtualnode-httptimeout-perrequest
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Duration
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.Duration, BaseFunction>? PerRequest { get; set; }
            /// <summary>
            /// Idle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-httptimeout.html#cfn-appmesh-virtualnode-httptimeout-idle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Duration
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.Duration, BaseFunction>? Idle { get; set; }
        }

        public class JsonFormatRef : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-jsonformatref.html#cfn-appmesh-virtualnode-jsonformatref-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-jsonformatref.html#cfn-appmesh-virtualnode-jsonformatref-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class Listener : Humidifier.Base.BaseSubResource, IHaveAppMeshVirtualNodeTypesVirtualNodeConnectionPoolConnectionPool, IHaveAppMeshVirtualNodeTypesListenerTimeoutTimeout, IHaveAppMeshVirtualNodeTypesHealthCheckHealthCheck, IHaveAppMeshVirtualNodeTypesListenerTlsTLS, IHaveAppMeshVirtualNodeTypesPortMappingPortMapping, IHaveAppMeshVirtualNodeTypesOutlierDetectionOutlierDetection
        {
            /// <summary>
            /// ConnectionPool
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listener.html#cfn-appmesh-virtualnode-listener-connectionpool
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualNodeConnectionPool
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.VirtualNodeConnectionPool, BaseFunction>? ConnectionPool { get; set; }
            /// <summary>
            /// Timeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listener.html#cfn-appmesh-virtualnode-listener-timeout
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ListenerTimeout
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.ListenerTimeout, BaseFunction>? Timeout { get; set; }
            /// <summary>
            /// HealthCheck
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listener.html#cfn-appmesh-virtualnode-listener-healthcheck
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HealthCheck
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.HealthCheck, BaseFunction>? HealthCheck { get; set; }
            /// <summary>
            /// TLS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listener.html#cfn-appmesh-virtualnode-listener-tls
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ListenerTls
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.ListenerTls, BaseFunction>? TLS { get; set; }
            /// <summary>
            /// PortMapping
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listener.html#cfn-appmesh-virtualnode-listener-portmapping
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PortMapping
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.PortMapping, BaseFunction>? PortMapping { get; set; }
            /// <summary>
            /// OutlierDetection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listener.html#cfn-appmesh-virtualnode-listener-outlierdetection
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OutlierDetection
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.OutlierDetection, BaseFunction>? OutlierDetection { get; set; }
        }

        public class ListenerTimeout : Humidifier.Base.BaseSubResource, IHaveAppMeshVirtualNodeTypesTcpTimeoutTCP, IHaveAppMeshVirtualNodeTypesHttpTimeoutHTTP2, IHaveAppMeshVirtualNodeTypesHttpTimeoutHTTP, IHaveAppMeshVirtualNodeTypesGrpcTimeoutGRPC
        {
            /// <summary>
            /// TCP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listenertimeout.html#cfn-appmesh-virtualnode-listenertimeout-tcp
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TcpTimeout
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.TcpTimeout, BaseFunction>? TCP { get; set; }
            /// <summary>
            /// HTTP2
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listenertimeout.html#cfn-appmesh-virtualnode-listenertimeout-http2
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpTimeout
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.HttpTimeout, BaseFunction>? HTTP2 { get; set; }
            /// <summary>
            /// HTTP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listenertimeout.html#cfn-appmesh-virtualnode-listenertimeout-http
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpTimeout
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.HttpTimeout, BaseFunction>? HTTP { get; set; }
            /// <summary>
            /// GRPC
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listenertimeout.html#cfn-appmesh-virtualnode-listenertimeout-grpc
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GrpcTimeout
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.GrpcTimeout, BaseFunction>? GRPC { get; set; }
        }

        public class ListenerTls : Humidifier.Base.BaseSubResource, IHaveAppMeshVirtualNodeTypesListenerTlsValidationContextValidation, IHaveMode, IHaveAppMeshVirtualNodeTypesListenerTlsCertificateCertificate
        {
            /// <summary>
            /// Validation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listenertls.html#cfn-appmesh-virtualnode-listenertls-validation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ListenerTlsValidationContext
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsValidationContext, BaseFunction>? Validation { get; set; }
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listenertls.html#cfn-appmesh-virtualnode-listenertls-mode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Mode { get; set; }
            /// <summary>
            /// Certificate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listenertls.html#cfn-appmesh-virtualnode-listenertls-certificate
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ListenerTlsCertificate
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsCertificate, BaseFunction>? Certificate { get; set; }
        }

        public class ListenerTlsAcmCertificate : Humidifier.Base.BaseSubResource, IHaveCertificateArn
        {
            /// <summary>
            /// CertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listenertlsacmcertificate.html#cfn-appmesh-virtualnode-listenertlsacmcertificate-certificatearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CertificateArn { get; set; }
        }

        public class ListenerTlsCertificate : Humidifier.Base.BaseSubResource, IHaveAppMeshVirtualNodeTypesListenerTlsSdsCertificateSDS, IHaveAppMeshVirtualNodeTypesListenerTlsAcmCertificateACM, IHaveAppMeshVirtualNodeTypesListenerTlsFileCertificateFile
        {
            /// <summary>
            /// SDS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listenertlscertificate.html#cfn-appmesh-virtualnode-listenertlscertificate-sds
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ListenerTlsSdsCertificate
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsSdsCertificate, BaseFunction>? SDS { get; set; }
            /// <summary>
            /// ACM
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listenertlscertificate.html#cfn-appmesh-virtualnode-listenertlscertificate-acm
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ListenerTlsAcmCertificate
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsAcmCertificate, BaseFunction>? ACM { get; set; }
            /// <summary>
            /// File
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listenertlscertificate.html#cfn-appmesh-virtualnode-listenertlscertificate-file
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ListenerTlsFileCertificate
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsFileCertificate, BaseFunction>? File { get; set; }
        }

        public class ListenerTlsFileCertificate : Humidifier.Base.BaseSubResource, IHavePrivateKey, IHaveCertificateChain
        {
            /// <summary>
            /// PrivateKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listenertlsfilecertificate.html#cfn-appmesh-virtualnode-listenertlsfilecertificate-privatekey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrivateKey { get; set; }
            /// <summary>
            /// CertificateChain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listenertlsfilecertificate.html#cfn-appmesh-virtualnode-listenertlsfilecertificate-certificatechain
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CertificateChain { get; set; }
        }

        public class ListenerTlsSdsCertificate : Humidifier.Base.BaseSubResource, IHaveSecretName
        {
            /// <summary>
            /// SecretName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listenertlssdscertificate.html#cfn-appmesh-virtualnode-listenertlssdscertificate-secretname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretName { get; set; }
        }

        public class ListenerTlsValidationContext : Humidifier.Base.BaseSubResource, IHaveAppMeshVirtualNodeTypesSubjectAlternativeNamesSubjectAlternativeNames, IHaveAppMeshVirtualNodeTypesListenerTlsValidationContextTrustTrust
        {
            /// <summary>
            /// SubjectAlternativeNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listenertlsvalidationcontext.html#cfn-appmesh-virtualnode-listenertlsvalidationcontext-subjectalternativenames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SubjectAlternativeNames
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.SubjectAlternativeNames, BaseFunction>? SubjectAlternativeNames { get; set; }
            /// <summary>
            /// Trust
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listenertlsvalidationcontext.html#cfn-appmesh-virtualnode-listenertlsvalidationcontext-trust
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ListenerTlsValidationContextTrust
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.ListenerTlsValidationContextTrust, BaseFunction>? Trust { get; set; }
        }

        public class ListenerTlsValidationContextTrust : Humidifier.Base.BaseSubResource, IHaveAppMeshVirtualNodeTypesTlsValidationContextSdsTrustSDS, IHaveAppMeshVirtualNodeTypesTlsValidationContextFileTrustFile
        {
            /// <summary>
            /// SDS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listenertlsvalidationcontexttrust.html#cfn-appmesh-virtualnode-listenertlsvalidationcontexttrust-sds
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TlsValidationContextSdsTrust
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextSdsTrust, BaseFunction>? SDS { get; set; }
            /// <summary>
            /// File
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-listenertlsvalidationcontexttrust.html#cfn-appmesh-virtualnode-listenertlsvalidationcontexttrust-file
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TlsValidationContextFileTrust
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextFileTrust, BaseFunction>? File { get; set; }
        }

        public class Logging : Humidifier.Base.BaseSubResource, IHaveAppMeshVirtualNodeTypesAccessLogAccessLog
        {
            /// <summary>
            /// AccessLog
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-logging.html#cfn-appmesh-virtualnode-logging-accesslog
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AccessLog
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.AccessLog, BaseFunction>? AccessLog { get; set; }
        }

        public class LoggingFormat : Humidifier.Base.BaseSubResource, IHaveText, IHaveListOfAppMeshVirtualNodeTypesJsonFormatRefJson
        {
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-loggingformat.html#cfn-appmesh-virtualnode-loggingformat-text
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Text { get; set; }
            /// <summary>
            /// Json
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-loggingformat.html#cfn-appmesh-virtualnode-loggingformat-json
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: JsonFormatRef
            /// </summary>
            public Union<IReadOnlyList<Humidifier.AppMesh.VirtualNodeTypes.JsonFormatRef>, IReadOnlyList<Union<Humidifier.AppMesh.VirtualNodeTypes.JsonFormatRef, BaseFunction>>, BaseFunction>? Json { get; set; }
        }

        public class OutlierDetection : Humidifier.Base.BaseSubResource, IHaveMaxEjectionPercent_Integer, IHaveAppMeshVirtualNodeTypesDurationBaseEjectionDuration, IHaveMaxServerErrors_Integer, IHaveAppMeshVirtualNodeTypesDurationInterval
        {
            /// <summary>
            /// MaxEjectionPercent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-outlierdetection.html#cfn-appmesh-virtualnode-outlierdetection-maxejectionpercent
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxEjectionPercent { get; set; }
            /// <summary>
            /// BaseEjectionDuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-outlierdetection.html#cfn-appmesh-virtualnode-outlierdetection-baseejectionduration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Duration
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.Duration, BaseFunction>? BaseEjectionDuration { get; set; }
            /// <summary>
            /// MaxServerErrors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-outlierdetection.html#cfn-appmesh-virtualnode-outlierdetection-maxservererrors
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxServerErrors { get; set; }
            /// <summary>
            /// Interval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-outlierdetection.html#cfn-appmesh-virtualnode-outlierdetection-interval
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Duration
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.Duration, BaseFunction>? Interval { get; set; }
        }

        public class PortMapping : Humidifier.Base.BaseSubResource, IHavePort_Integer, IHaveProtocol
        {
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-portmapping.html#cfn-appmesh-virtualnode-portmapping-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Port { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-portmapping.html#cfn-appmesh-virtualnode-portmapping-protocol
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Protocol { get; set; }
        }

        public class ServiceDiscovery : Humidifier.Base.BaseSubResource, IHaveAppMeshVirtualNodeTypesDnsServiceDiscoveryDNS, IHaveAppMeshVirtualNodeTypesAwsCloudMapServiceDiscoveryAWSCloudMap
        {
            /// <summary>
            /// DNS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-servicediscovery.html#cfn-appmesh-virtualnode-servicediscovery-dns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DnsServiceDiscovery
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.DnsServiceDiscovery, BaseFunction>? DNS { get; set; }
            /// <summary>
            /// AWSCloudMap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-servicediscovery.html#cfn-appmesh-virtualnode-servicediscovery-awscloudmap
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AwsCloudMapServiceDiscovery
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.AwsCloudMapServiceDiscovery, BaseFunction>? AWSCloudMap { get; set; }
        }

        public class SubjectAlternativeNameMatchers : Humidifier.Base.BaseSubResource, IHaveStringListOfExact
        {
            /// <summary>
            /// Exact
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-subjectalternativenamematchers.html#cfn-appmesh-virtualnode-subjectalternativenamematchers-exact
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Exact { get; set; }
        }

        public class SubjectAlternativeNames : Humidifier.Base.BaseSubResource, IHaveAppMeshVirtualNodeTypesSubjectAlternativeNameMatchersMatch
        {
            /// <summary>
            /// Match
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-subjectalternativenames.html#cfn-appmesh-virtualnode-subjectalternativenames-match
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SubjectAlternativeNameMatchers
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.SubjectAlternativeNameMatchers, BaseFunction>? Match { get; set; }
        }

        public class TcpTimeout : Humidifier.Base.BaseSubResource, IHaveAppMeshVirtualNodeTypesDurationIdle
        {
            /// <summary>
            /// Idle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-tcptimeout.html#cfn-appmesh-virtualnode-tcptimeout-idle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Duration
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.Duration, BaseFunction>? Idle { get; set; }
        }

        public class TlsValidationContext : Humidifier.Base.BaseSubResource, IHaveAppMeshVirtualNodeTypesSubjectAlternativeNamesSubjectAlternativeNames, IHaveAppMeshVirtualNodeTypesTlsValidationContextTrustTrust
        {
            /// <summary>
            /// SubjectAlternativeNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-tlsvalidationcontext.html#cfn-appmesh-virtualnode-tlsvalidationcontext-subjectalternativenames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SubjectAlternativeNames
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.SubjectAlternativeNames, BaseFunction>? SubjectAlternativeNames { get; set; }
            /// <summary>
            /// Trust
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-tlsvalidationcontext.html#cfn-appmesh-virtualnode-tlsvalidationcontext-trust
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TlsValidationContextTrust
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextTrust, BaseFunction>? Trust { get; set; }
        }

        public class TlsValidationContextAcmTrust : Humidifier.Base.BaseSubResource, IHaveStringListOfCertificateAuthorityArns
        {
            /// <summary>
            /// CertificateAuthorityArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-tlsvalidationcontextacmtrust.html#cfn-appmesh-virtualnode-tlsvalidationcontextacmtrust-certificateauthorityarns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CertificateAuthorityArns { get; set; }
        }

        public class TlsValidationContextFileTrust : Humidifier.Base.BaseSubResource, IHaveCertificateChain
        {
            /// <summary>
            /// CertificateChain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-tlsvalidationcontextfiletrust.html#cfn-appmesh-virtualnode-tlsvalidationcontextfiletrust-certificatechain
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CertificateChain { get; set; }
        }

        public class TlsValidationContextSdsTrust : Humidifier.Base.BaseSubResource, IHaveSecretName
        {
            /// <summary>
            /// SecretName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-tlsvalidationcontextsdstrust.html#cfn-appmesh-virtualnode-tlsvalidationcontextsdstrust-secretname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretName { get; set; }
        }

        public class TlsValidationContextTrust : Humidifier.Base.BaseSubResource, IHaveAppMeshVirtualNodeTypesTlsValidationContextSdsTrustSDS, IHaveAppMeshVirtualNodeTypesTlsValidationContextAcmTrustACM, IHaveAppMeshVirtualNodeTypesTlsValidationContextFileTrustFile
        {
            /// <summary>
            /// SDS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-tlsvalidationcontexttrust.html#cfn-appmesh-virtualnode-tlsvalidationcontexttrust-sds
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TlsValidationContextSdsTrust
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextSdsTrust, BaseFunction>? SDS { get; set; }
            /// <summary>
            /// ACM
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-tlsvalidationcontexttrust.html#cfn-appmesh-virtualnode-tlsvalidationcontexttrust-acm
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TlsValidationContextAcmTrust
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextAcmTrust, BaseFunction>? ACM { get; set; }
            /// <summary>
            /// File
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-tlsvalidationcontexttrust.html#cfn-appmesh-virtualnode-tlsvalidationcontexttrust-file
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TlsValidationContextFileTrust
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.TlsValidationContextFileTrust, BaseFunction>? File { get; set; }
        }

        public class VirtualNodeConnectionPool : Humidifier.Base.BaseSubResource, IHaveAppMeshVirtualNodeTypesVirtualNodeTcpConnectionPoolTCP, IHaveAppMeshVirtualNodeTypesVirtualNodeHttp2ConnectionPoolHTTP2, IHaveAppMeshVirtualNodeTypesVirtualNodeHttpConnectionPoolHTTP, IHaveAppMeshVirtualNodeTypesVirtualNodeGrpcConnectionPoolGRPC
        {
            /// <summary>
            /// TCP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-virtualnodeconnectionpool.html#cfn-appmesh-virtualnode-virtualnodeconnectionpool-tcp
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualNodeTcpConnectionPool
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.VirtualNodeTcpConnectionPool, BaseFunction>? TCP { get; set; }
            /// <summary>
            /// HTTP2
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-virtualnodeconnectionpool.html#cfn-appmesh-virtualnode-virtualnodeconnectionpool-http2
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualNodeHttp2ConnectionPool
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.VirtualNodeHttp2ConnectionPool, BaseFunction>? HTTP2 { get; set; }
            /// <summary>
            /// HTTP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-virtualnodeconnectionpool.html#cfn-appmesh-virtualnode-virtualnodeconnectionpool-http
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualNodeHttpConnectionPool
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.VirtualNodeHttpConnectionPool, BaseFunction>? HTTP { get; set; }
            /// <summary>
            /// GRPC
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-virtualnodeconnectionpool.html#cfn-appmesh-virtualnode-virtualnodeconnectionpool-grpc
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VirtualNodeGrpcConnectionPool
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.VirtualNodeGrpcConnectionPool, BaseFunction>? GRPC { get; set; }
        }

        public class VirtualNodeGrpcConnectionPool : Humidifier.Base.BaseSubResource, IHaveMaxRequests_Integer
        {
            /// <summary>
            /// MaxRequests
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-virtualnodegrpcconnectionpool.html#cfn-appmesh-virtualnode-virtualnodegrpcconnectionpool-maxrequests
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxRequests { get; set; }
        }

        public class VirtualNodeHttp2ConnectionPool : Humidifier.Base.BaseSubResource, IHaveMaxRequests_Integer
        {
            /// <summary>
            /// MaxRequests
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-virtualnodehttp2connectionpool.html#cfn-appmesh-virtualnode-virtualnodehttp2connectionpool-maxrequests
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxRequests { get; set; }
        }

        public class VirtualNodeHttpConnectionPool : Humidifier.Base.BaseSubResource, IHaveMaxConnections_Integer, IHaveMaxPendingRequests_Integer
        {
            /// <summary>
            /// MaxConnections
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-virtualnodehttpconnectionpool.html#cfn-appmesh-virtualnode-virtualnodehttpconnectionpool-maxconnections
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxConnections { get; set; }
            /// <summary>
            /// MaxPendingRequests
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-virtualnodehttpconnectionpool.html#cfn-appmesh-virtualnode-virtualnodehttpconnectionpool-maxpendingrequests
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxPendingRequests { get; set; }
        }

        public class VirtualNodeSpec : Humidifier.Base.BaseSubResource, IHaveAppMeshVirtualNodeTypesLoggingLogging, IHaveListOfAppMeshVirtualNodeTypesBackendBackends, IHaveListOfAppMeshVirtualNodeTypesListenerListeners, IHaveAppMeshVirtualNodeTypesBackendDefaultsBackendDefaults, IHaveAppMeshVirtualNodeTypesServiceDiscoveryServiceDiscovery
        {
            /// <summary>
            /// Logging
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-virtualnodespec.html#cfn-appmesh-virtualnode-virtualnodespec-logging
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Logging
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.Logging, BaseFunction>? Logging { get; set; }
            /// <summary>
            /// Backends
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-virtualnodespec.html#cfn-appmesh-virtualnode-virtualnodespec-backends
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Backend
            /// </summary>
            public Union<IReadOnlyList<Humidifier.AppMesh.VirtualNodeTypes.Backend>, IReadOnlyList<Union<Humidifier.AppMesh.VirtualNodeTypes.Backend, BaseFunction>>, BaseFunction>? Backends { get; set; }
            /// <summary>
            /// Listeners
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-virtualnodespec.html#cfn-appmesh-virtualnode-virtualnodespec-listeners
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Listener
            /// </summary>
            public Union<IReadOnlyList<Humidifier.AppMesh.VirtualNodeTypes.Listener>, IReadOnlyList<Union<Humidifier.AppMesh.VirtualNodeTypes.Listener, BaseFunction>>, BaseFunction>? Listeners { get; set; }
            /// <summary>
            /// BackendDefaults
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-virtualnodespec.html#cfn-appmesh-virtualnode-virtualnodespec-backenddefaults
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BackendDefaults
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.BackendDefaults, BaseFunction>? BackendDefaults { get; set; }
            /// <summary>
            /// ServiceDiscovery
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-virtualnodespec.html#cfn-appmesh-virtualnode-virtualnodespec-servicediscovery
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ServiceDiscovery
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.ServiceDiscovery, BaseFunction>? ServiceDiscovery { get; set; }
        }

        public class VirtualNodeTcpConnectionPool : Humidifier.Base.BaseSubResource, IHaveMaxConnections_Integer
        {
            /// <summary>
            /// MaxConnections
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-virtualnodetcpconnectionpool.html#cfn-appmesh-virtualnode-virtualnodetcpconnectionpool-maxconnections
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxConnections { get; set; }
        }

        public class VirtualServiceBackend : Humidifier.Base.BaseSubResource, IHaveAppMeshVirtualNodeTypesClientPolicyClientPolicy, IHaveVirtualServiceName
        {
            /// <summary>
            /// ClientPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-virtualservicebackend.html#cfn-appmesh-virtualnode-virtualservicebackend-clientpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ClientPolicy
            /// </summary>
            public Union<Humidifier.AppMesh.VirtualNodeTypes.ClientPolicy, BaseFunction>? ClientPolicy { get; set; }
            /// <summary>
            /// VirtualServiceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-virtualservicebackend.html#cfn-appmesh-virtualnode-virtualservicebackend-virtualservicename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VirtualServiceName { get; set; }
        }
    }
}