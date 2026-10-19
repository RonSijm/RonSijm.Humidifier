namespace Humidifier.Transfer
{
    using global::System.Collections.Generic;
    using ServerTypes;

    public class Server : Humidifier.Base.BaseResource, IHaveTags, IHaveIpAddressType, IHaveLoggingRole, IHaveStringListOfProtocols, IHaveTransferServerTypesIdentityProviderDetailsIdentityProviderDetails, IHaveTransferServerTypesEndpointDetailsEndpointDetails, IHaveStringListOfStructuredLogDestinations, IHavePreAuthenticationLoginBanner, IHavePostAuthenticationLoginBanner, IHaveCreateWithHostKey_Boolean, IHaveEndpointType, IHaveSecurityPolicyName, IHaveTransferServerTypesProtocolDetailsProtocolDetails, IHaveTransferServerTypesS3StorageOptionsS3StorageOptions, IHaveTransferServerTypesWorkflowDetailsWorkflowDetails, IHaveDomain, IHaveIdentityProviderType, IHaveCertificate
    {
        public class Attributes
        {
            public static string ServerId =  "ServerId" ;
            public static string As2ServiceManagedEgressIpAddresses =  "As2ServiceManagedEgressIpAddresses" ;
            public static string State =  "State" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Transfer.Server; }
        /// <summary>
        /// IpAddressType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-server.html#cfn-transfer-server-ipaddresstype
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? IpAddressType { get; set; }
        /// <summary>
        /// LoggingRole
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-server.html#cfn-transfer-server-loggingrole
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LoggingRole { get; set; }
        /// <summary>
        /// Protocols
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-server.html#cfn-transfer-server-protocols
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Protocols { get; set; }
        /// <summary>
        /// IdentityProviderDetails
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-server.html#cfn-transfer-server-identityproviderdetails
        /// Required: False
        /// UpdateType: Mutable
        /// Type: IdentityProviderDetails
        /// </summary>
        public Union<Humidifier.Transfer.ServerTypes.IdentityProviderDetails, BaseFunction>? IdentityProviderDetails { get; set; }
        /// <summary>
        /// EndpointDetails
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-server.html#cfn-transfer-server-endpointdetails
        /// Required: False
        /// UpdateType: Conditional
        /// Type: EndpointDetails
        /// </summary>
        public Union<Humidifier.Transfer.ServerTypes.EndpointDetails, BaseFunction>? EndpointDetails { get; set; }
        /// <summary>
        /// StructuredLogDestinations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-server.html#cfn-transfer-server-structuredlogdestinations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? StructuredLogDestinations { get; set; }
        /// <summary>
        /// PreAuthenticationLoginBanner
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-server.html#cfn-transfer-server-preauthenticationloginbanner
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PreAuthenticationLoginBanner { get; set; }
        /// <summary>
        /// PostAuthenticationLoginBanner
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-server.html#cfn-transfer-server-postauthenticationloginbanner
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PostAuthenticationLoginBanner { get; set; }
        /// <summary>
        /// CreateWithHostKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-server.html#cfn-transfer-server-createwithhostkey
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? CreateWithHostKey { get; set; }
        /// <summary>
        /// EndpointType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-server.html#cfn-transfer-server-endpointtype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EndpointType { get; set; }
        /// <summary>
        /// SecurityPolicyName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-server.html#cfn-transfer-server-securitypolicyname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SecurityPolicyName { get; set; }
        /// <summary>
        /// ProtocolDetails
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-server.html#cfn-transfer-server-protocoldetails
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ProtocolDetails
        /// </summary>
        public Union<Humidifier.Transfer.ServerTypes.ProtocolDetails, BaseFunction>? ProtocolDetails { get; set; }
        /// <summary>
        /// S3StorageOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-server.html#cfn-transfer-server-s3storageoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: S3StorageOptions
        /// </summary>
        public Union<Humidifier.Transfer.ServerTypes.S3StorageOptions, BaseFunction>? S3StorageOptions { get; set; }
        /// <summary>
        /// WorkflowDetails
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-server.html#cfn-transfer-server-workflowdetails
        /// Required: False
        /// UpdateType: Mutable
        /// Type: WorkflowDetails
        /// </summary>
        public Union<Humidifier.Transfer.ServerTypes.WorkflowDetails, BaseFunction>? WorkflowDetails { get; set; }
        /// <summary>
        /// Domain
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-server.html#cfn-transfer-server-domain
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Domain { get; set; }
        /// <summary>
        /// IdentityProviderType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-server.html#cfn-transfer-server-identityprovidertype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? IdentityProviderType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-server.html#cfn-transfer-server-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// Certificate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transfer-server.html#cfn-transfer-server-certificate
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Certificate { get; set; }
    }

    namespace ServerTypes
    {
        public class EndpointDetails : Humidifier.Base.BaseSubResource, IHaveStringListOfAddressAllocationIds, IHaveVpcId, IHaveVpcEndpointId, IHaveStringListOfSubnetIds, IHaveStringListOfSecurityGroupIds
        {
            /// <summary>
            /// AddressAllocationIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-server-endpointdetails.html#cfn-transfer-server-endpointdetails-addressallocationids
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AddressAllocationIds { get; set; }
            /// <summary>
            /// VpcId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-server-endpointdetails.html#cfn-transfer-server-endpointdetails-vpcid
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VpcId { get; set; }
            /// <summary>
            /// VpcEndpointId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-server-endpointdetails.html#cfn-transfer-server-endpointdetails-vpcendpointid
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VpcEndpointId { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-server-endpointdetails.html#cfn-transfer-server-endpointdetails-subnetids
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-server-endpointdetails.html#cfn-transfer-server-endpointdetails-securitygroupids
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        }

        public class IdentityProviderDetails : Humidifier.Base.BaseSubResource, IHaveFunction, IHaveDirectoryId, IHaveInvocationRole, IHaveUrl, IHaveSftpAuthenticationMethods
        {
            /// <summary>
            /// Function
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-server-identityproviderdetails.html#cfn-transfer-server-identityproviderdetails-function
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Function { get; set; }
            /// <summary>
            /// DirectoryId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-server-identityproviderdetails.html#cfn-transfer-server-identityproviderdetails-directoryid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DirectoryId { get; set; }
            /// <summary>
            /// InvocationRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-server-identityproviderdetails.html#cfn-transfer-server-identityproviderdetails-invocationrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InvocationRole { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-server-identityproviderdetails.html#cfn-transfer-server-identityproviderdetails-url
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Url { get; set; }
            /// <summary>
            /// SftpAuthenticationMethods
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-server-identityproviderdetails.html#cfn-transfer-server-identityproviderdetails-sftpauthenticationmethods
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SftpAuthenticationMethods { get; set; }
        }

        public class ProtocolDetails : Humidifier.Base.BaseSubResource, IHaveStringListOfAs2Transports, IHavePassiveIp, IHaveSetStatOption, IHaveTlsSessionResumptionMode, IHaveTransferServerTypesProxyConfigProxyConfig
        {
            /// <summary>
            /// As2Transports
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-server-protocoldetails.html#cfn-transfer-server-protocoldetails-as2transports
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? As2Transports { get; set; }
            /// <summary>
            /// PassiveIp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-server-protocoldetails.html#cfn-transfer-server-protocoldetails-passiveip
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PassiveIp { get; set; }
            /// <summary>
            /// SetStatOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-server-protocoldetails.html#cfn-transfer-server-protocoldetails-setstatoption
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SetStatOption { get; set; }
            /// <summary>
            /// TlsSessionResumptionMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-server-protocoldetails.html#cfn-transfer-server-protocoldetails-tlssessionresumptionmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TlsSessionResumptionMode { get; set; }
            /// <summary>
            /// ProxyConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-server-protocoldetails.html#cfn-transfer-server-protocoldetails-proxyconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ProxyConfig
            /// </summary>
            public Union<Humidifier.Transfer.ServerTypes.ProxyConfig, BaseFunction>? ProxyConfig { get; set; }
        }

        public class ProxyConfig : Humidifier.Base.BaseSubResource, IHaveSftpMode
        {
            /// <summary>
            /// SftpMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-server-proxyconfig.html#cfn-transfer-server-proxyconfig-sftpmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SftpMode { get; set; }
        }

        public class S3StorageOptions : Humidifier.Base.BaseSubResource, IHaveDirectoryListingOptimization
        {
            /// <summary>
            /// DirectoryListingOptimization
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-server-s3storageoptions.html#cfn-transfer-server-s3storageoptions-directorylistingoptimization
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DirectoryListingOptimization { get; set; }
        }

        public class WorkflowDetail : Humidifier.Base.BaseSubResource, IHaveWorkflowId, IHaveExecutionRole
        {
            /// <summary>
            /// WorkflowId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-server-workflowdetail.html#cfn-transfer-server-workflowdetail-workflowid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WorkflowId { get; set; }
            /// <summary>
            /// ExecutionRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-server-workflowdetail.html#cfn-transfer-server-workflowdetail-executionrole
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExecutionRole { get; set; }
        }

        public class WorkflowDetails : Humidifier.Base.BaseSubResource, IHaveListOfTransferServerTypesWorkflowDetailOnUpload, IHaveListOfTransferServerTypesWorkflowDetailOnPartialUpload
        {
            /// <summary>
            /// OnUpload
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-server-workflowdetails.html#cfn-transfer-server-workflowdetails-onupload
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: WorkflowDetail
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Transfer.ServerTypes.WorkflowDetail>, IReadOnlyList<Union<Humidifier.Transfer.ServerTypes.WorkflowDetail, BaseFunction>>, BaseFunction>? OnUpload { get; set; }
            /// <summary>
            /// OnPartialUpload
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-server-workflowdetails.html#cfn-transfer-server-workflowdetails-onpartialupload
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: WorkflowDetail
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Transfer.ServerTypes.WorkflowDetail>, IReadOnlyList<Union<Humidifier.Transfer.ServerTypes.WorkflowDetail, BaseFunction>>, BaseFunction>? OnPartialUpload { get; set; }
        }
    }
}