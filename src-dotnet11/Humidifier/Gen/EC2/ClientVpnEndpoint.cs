namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using ClientVpnEndpointTypes;

    public class ClientVpnEndpoint : Humidifier.Base.BaseResource, IHaveClientCidrBlock, IHaveEC2ClientVpnEndpointTypesClientConnectOptionsClientConnectOptions, IHaveDescription, IHaveEC2ClientVpnEndpointTypesClientRouteEnforcementOptionsClientRouteEnforcementOptions, IHaveListOfEC2ClientVpnEndpointTypesTagSpecificationTagSpecifications, IHaveListOfEC2ClientVpnEndpointTypesClientAuthenticationRequestAuthenticationOptions, IHaveServerCertificateArn, IHaveSessionTimeoutHours_Integer, IHaveStringListOfDnsServers, IHaveEC2ClientVpnEndpointTypesDevicePostureOptionsDevicePostureOptions, IHaveStringListOfSecurityGroupIds, IHaveDisconnectOnSessionTimeout_Boolean, IHaveEC2ClientVpnEndpointTypesConnectionLogOptionsConnectionLogOptions, IHaveEC2ClientVpnEndpointTypesAuthorizationPolicyAuthorizationPolicy, IHaveSplitTunnel_Boolean, IHaveTrafficIpAddressType, IHaveEC2ClientVpnEndpointTypesClientLoginBannerOptionsClientLoginBannerOptions, IHaveVpcId, IHaveSelfServicePortal, IHaveEC2ClientVpnEndpointTypesTransitGatewayConfigurationTransitGatewayConfiguration, IHaveTransportProtocol, IHaveEndpointIpAddressType, IHaveVpnPort_Integer
    {
        public override string AWSTypeName { get => AWS.EC2.ClientVpnEndpoint; }
        /// <summary>
        /// ClientCidrBlock
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnendpoint.html#cfn-ec2-clientvpnendpoint-clientcidrblock
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ClientCidrBlock { get; set; }
        /// <summary>
        /// ClientConnectOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnendpoint.html#cfn-ec2-clientvpnendpoint-clientconnectoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ClientConnectOptions
        /// </summary>
        public Union<Humidifier.EC2.ClientVpnEndpointTypes.ClientConnectOptions, BaseFunction>? ClientConnectOptions { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnendpoint.html#cfn-ec2-clientvpnendpoint-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// ClientRouteEnforcementOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnendpoint.html#cfn-ec2-clientvpnendpoint-clientrouteenforcementoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ClientRouteEnforcementOptions
        /// </summary>
        public Union<Humidifier.EC2.ClientVpnEndpointTypes.ClientRouteEnforcementOptions, BaseFunction>? ClientRouteEnforcementOptions { get; set; }
        /// <summary>
        /// TagSpecifications
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnendpoint.html#cfn-ec2-clientvpnendpoint-tagspecifications
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: TagSpecification
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EC2.ClientVpnEndpointTypes.TagSpecification>, IReadOnlyList<Union<Humidifier.EC2.ClientVpnEndpointTypes.TagSpecification, BaseFunction>>, BaseFunction>? TagSpecifications { get; set; }

        /// <summary>
        /// AuthenticationOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnendpoint.html#cfn-ec2-clientvpnendpoint-authenticationoptions
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: ClientAuthenticationRequest
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.EC2.ClientVpnEndpointTypes.ClientAuthenticationRequest>, IReadOnlyList<Union<Humidifier.EC2.ClientVpnEndpointTypes.ClientAuthenticationRequest, BaseFunction>>, BaseFunction>? AuthenticationOptions { get; set; }

        /// <summary>
        /// ServerCertificateArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnendpoint.html#cfn-ec2-clientvpnendpoint-servercertificatearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ServerCertificateArn { get; set; }
        /// <summary>
        /// SessionTimeoutHours
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnendpoint.html#cfn-ec2-clientvpnendpoint-sessiontimeouthours
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? SessionTimeoutHours { get; set; }
        /// <summary>
        /// DnsServers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnendpoint.html#cfn-ec2-clientvpnendpoint-dnsservers
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DnsServers { get; set; }
        /// <summary>
        /// DevicePostureOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnendpoint.html#cfn-ec2-clientvpnendpoint-devicepostureoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DevicePostureOptions
        /// </summary>
        public Union<Humidifier.EC2.ClientVpnEndpointTypes.DevicePostureOptions, BaseFunction>? DevicePostureOptions { get; set; }
        /// <summary>
        /// SecurityGroupIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnendpoint.html#cfn-ec2-clientvpnendpoint-securitygroupids
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        /// <summary>
        /// DisconnectOnSessionTimeout
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnendpoint.html#cfn-ec2-clientvpnendpoint-disconnectonsessiontimeout
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? DisconnectOnSessionTimeout { get; set; }

        /// <summary>
        /// ConnectionLogOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnendpoint.html#cfn-ec2-clientvpnendpoint-connectionlogoptions
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ConnectionLogOptions
        /// </summary>
        [Required]
        public Union<Humidifier.EC2.ClientVpnEndpointTypes.ConnectionLogOptions, BaseFunction>? ConnectionLogOptions { get; set; }
        /// <summary>
        /// AuthorizationPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnendpoint.html#cfn-ec2-clientvpnendpoint-authorizationpolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AuthorizationPolicy
        /// </summary>
        public Union<Humidifier.EC2.ClientVpnEndpointTypes.AuthorizationPolicy, BaseFunction>? AuthorizationPolicy { get; set; }
        /// <summary>
        /// SplitTunnel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnendpoint.html#cfn-ec2-clientvpnendpoint-splittunnel
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? SplitTunnel { get; set; }
        /// <summary>
        /// TrafficIpAddressType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnendpoint.html#cfn-ec2-clientvpnendpoint-trafficipaddresstype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TrafficIpAddressType { get; set; }
        /// <summary>
        /// ClientLoginBannerOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnendpoint.html#cfn-ec2-clientvpnendpoint-clientloginbanneroptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ClientLoginBannerOptions
        /// </summary>
        public Union<Humidifier.EC2.ClientVpnEndpointTypes.ClientLoginBannerOptions, BaseFunction>? ClientLoginBannerOptions { get; set; }
        /// <summary>
        /// VpcId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnendpoint.html#cfn-ec2-clientvpnendpoint-vpcid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VpcId { get; set; }
        /// <summary>
        /// SelfServicePortal
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnendpoint.html#cfn-ec2-clientvpnendpoint-selfserviceportal
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SelfServicePortal { get; set; }
        /// <summary>
        /// TransitGatewayConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnendpoint.html#cfn-ec2-clientvpnendpoint-transitgatewayconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: TransitGatewayConfiguration
        /// </summary>
        public Union<Humidifier.EC2.ClientVpnEndpointTypes.TransitGatewayConfiguration, BaseFunction>? TransitGatewayConfiguration { get; set; }
        /// <summary>
        /// TransportProtocol
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnendpoint.html#cfn-ec2-clientvpnendpoint-transportprotocol
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TransportProtocol { get; set; }
        /// <summary>
        /// EndpointIpAddressType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnendpoint.html#cfn-ec2-clientvpnendpoint-endpointipaddresstype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EndpointIpAddressType { get; set; }
        /// <summary>
        /// VpnPort
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnendpoint.html#cfn-ec2-clientvpnendpoint-vpnport
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? VpnPort { get; set; }
    }

    namespace ClientVpnEndpointTypes
    {
        public class AuthorizationPolicy : Humidifier.Base.BaseSubResource, IHaveDescription, IHavePolicyDocument, IHaveShadowMode
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-authorizationpolicy.html#cfn-ec2-clientvpnendpoint-authorizationpolicy-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// PolicyDocument
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-authorizationpolicy.html#cfn-ec2-clientvpnendpoint-authorizationpolicy-policydocument
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PolicyDocument { get; set; }
            /// <summary>
            /// ShadowMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-authorizationpolicy.html#cfn-ec2-clientvpnendpoint-authorizationpolicy-shadowmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShadowMode { get; set; }
        }

        public class CertificateAuthenticationRequest : Humidifier.Base.BaseSubResource, IHaveClientRootCertificateChainArn
        {
            /// <summary>
            /// ClientRootCertificateChainArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-certificateauthenticationrequest.html#cfn-ec2-clientvpnendpoint-certificateauthenticationrequest-clientrootcertificatechainarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientRootCertificateChainArn { get; set; }
        }

        public class ClientAuthenticationRequest : Humidifier.Base.BaseSubResource, IHaveEC2ClientVpnEndpointTypesCertificateAuthenticationRequestMutualAuthentication, IHaveType, IHaveEC2ClientVpnEndpointTypesFederatedAuthenticationRequestFederatedAuthentication, IHaveEC2ClientVpnEndpointTypesDirectoryServiceAuthenticationRequestActiveDirectory
        {
            /// <summary>
            /// MutualAuthentication
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-clientauthenticationrequest.html#cfn-ec2-clientvpnendpoint-clientauthenticationrequest-mutualauthentication
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CertificateAuthenticationRequest
            /// </summary>
            public Union<Humidifier.EC2.ClientVpnEndpointTypes.CertificateAuthenticationRequest, BaseFunction>? MutualAuthentication { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-clientauthenticationrequest.html#cfn-ec2-clientvpnendpoint-clientauthenticationrequest-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// FederatedAuthentication
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-clientauthenticationrequest.html#cfn-ec2-clientvpnendpoint-clientauthenticationrequest-federatedauthentication
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FederatedAuthenticationRequest
            /// </summary>
            public Union<Humidifier.EC2.ClientVpnEndpointTypes.FederatedAuthenticationRequest, BaseFunction>? FederatedAuthentication { get; set; }
            /// <summary>
            /// ActiveDirectory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-clientauthenticationrequest.html#cfn-ec2-clientvpnendpoint-clientauthenticationrequest-activedirectory
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DirectoryServiceAuthenticationRequest
            /// </summary>
            public Union<Humidifier.EC2.ClientVpnEndpointTypes.DirectoryServiceAuthenticationRequest, BaseFunction>? ActiveDirectory { get; set; }
        }

        public class ClientConnectOptions : Humidifier.Base.BaseSubResource, IHaveLambdaFunctionArn, IHaveEnabled_Boolean
        {
            /// <summary>
            /// LambdaFunctionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-clientconnectoptions.html#cfn-ec2-clientvpnendpoint-clientconnectoptions-lambdafunctionarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LambdaFunctionArn { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-clientconnectoptions.html#cfn-ec2-clientvpnendpoint-clientconnectoptions-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class ClientLoginBannerOptions : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean, IHaveBannerText
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-clientloginbanneroptions.html#cfn-ec2-clientvpnendpoint-clientloginbanneroptions-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// BannerText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-clientloginbanneroptions.html#cfn-ec2-clientvpnendpoint-clientloginbanneroptions-bannertext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BannerText { get; set; }
        }

        public class ClientRouteEnforcementOptions : Humidifier.Base.BaseSubResource, IHaveEnforced_Boolean
        {
            /// <summary>
            /// Enforced
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-clientrouteenforcementoptions.html#cfn-ec2-clientvpnendpoint-clientrouteenforcementoptions-enforced
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enforced { get; set; }
        }

        public class ConnectionLogOptions : Humidifier.Base.BaseSubResource, IHaveIncludeAuthorizationPolicyContext_Boolean, IHaveCloudwatchLogStream, IHaveEnabled_Boolean, IHaveCloudwatchLogGroup
        {
            /// <summary>
            /// IncludeAuthorizationPolicyContext
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-connectionlogoptions.html#cfn-ec2-clientvpnendpoint-connectionlogoptions-includeauthorizationpolicycontext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeAuthorizationPolicyContext { get; set; }
            /// <summary>
            /// CloudwatchLogStream
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-connectionlogoptions.html#cfn-ec2-clientvpnendpoint-connectionlogoptions-cloudwatchlogstream
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CloudwatchLogStream { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-connectionlogoptions.html#cfn-ec2-clientvpnendpoint-connectionlogoptions-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// CloudwatchLogGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-connectionlogoptions.html#cfn-ec2-clientvpnendpoint-connectionlogoptions-cloudwatchloggroup
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CloudwatchLogGroup { get; set; }
        }

        public class DevicePostureOptions : Humidifier.Base.BaseSubResource, IHaveListOfEC2ClientVpnEndpointTypesDevicePostureTrustProviderTrustProviders, IHaveEnabled_Boolean
        {
            /// <summary>
            /// TrustProviders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-devicepostureoptions.html#cfn-ec2-clientvpnendpoint-devicepostureoptions-trustproviders
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DevicePostureTrustProvider
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.ClientVpnEndpointTypes.DevicePostureTrustProvider>, IReadOnlyList<Union<Humidifier.EC2.ClientVpnEndpointTypes.DevicePostureTrustProvider, BaseFunction>>, BaseFunction>? TrustProviders { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-devicepostureoptions.html#cfn-ec2-clientvpnendpoint-devicepostureoptions-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class DevicePostureTrustProvider : Humidifier.Base.BaseSubResource, IHaveTenantId, IHaveTrustProviderType, IHavePublicSigningKeyUrl
        {
            /// <summary>
            /// TenantId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-deviceposturetrustprovider.html#cfn-ec2-clientvpnendpoint-deviceposturetrustprovider-tenantid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TenantId { get; set; }
            /// <summary>
            /// TrustProviderType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-deviceposturetrustprovider.html#cfn-ec2-clientvpnendpoint-deviceposturetrustprovider-trustprovidertype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TrustProviderType { get; set; }
            /// <summary>
            /// PublicSigningKeyUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-deviceposturetrustprovider.html#cfn-ec2-clientvpnendpoint-deviceposturetrustprovider-publicsigningkeyurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PublicSigningKeyUrl { get; set; }
        }

        public class DirectoryServiceAuthenticationRequest : Humidifier.Base.BaseSubResource, IHaveDirectoryId
        {
            /// <summary>
            /// DirectoryId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-directoryserviceauthenticationrequest.html#cfn-ec2-clientvpnendpoint-directoryserviceauthenticationrequest-directoryid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DirectoryId { get; set; }
        }

        public class FederatedAuthenticationRequest : Humidifier.Base.BaseSubResource, IHaveSelfServiceSAMLProviderArn, IHaveSAMLProviderArn
        {
            /// <summary>
            /// SelfServiceSAMLProviderArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-federatedauthenticationrequest.html#cfn-ec2-clientvpnendpoint-federatedauthenticationrequest-selfservicesamlproviderarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SelfServiceSAMLProviderArn { get; set; }
            /// <summary>
            /// SAMLProviderArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-federatedauthenticationrequest.html#cfn-ec2-clientvpnendpoint-federatedauthenticationrequest-samlproviderarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SAMLProviderArn { get; set; }
        }

        public class TagSpecification : Humidifier.Base.BaseSubResource, IHaveTags, IHaveResourceType
        {
            /// <summary>
            /// ResourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-tagspecification.html#cfn-ec2-clientvpnendpoint-tagspecification-resourcetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceType { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-tagspecification.html#cfn-ec2-clientvpnendpoint-tagspecification-tags
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        }

        public class TransitGatewayConfiguration : Humidifier.Base.BaseSubResource, IHaveTransitGatewayId, IHaveStringListOfAvailabilityZoneIds, IHaveStringListOfAvailabilityZones
        {
            /// <summary>
            /// TransitGatewayId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-transitgatewayconfiguration.html#cfn-ec2-clientvpnendpoint-transitgatewayconfiguration-transitgatewayid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TransitGatewayId { get; set; }
            /// <summary>
            /// AvailabilityZoneIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-transitgatewayconfiguration.html#cfn-ec2-clientvpnendpoint-transitgatewayconfiguration-availabilityzoneids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AvailabilityZoneIds { get; set; }
            /// <summary>
            /// AvailabilityZones
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-transitgatewayconfiguration.html#cfn-ec2-clientvpnendpoint-transitgatewayconfiguration-availabilityzones
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AvailabilityZones { get; set; }
        }
    }
}