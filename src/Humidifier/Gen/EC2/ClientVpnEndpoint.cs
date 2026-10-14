namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using ClientVpnEndpointTypes;

    public class ClientVpnEndpoint : Humidifier.Base.BaseResource, IHaveDescription, IHaveSecurityGroupIds, IHaveVpcId, IHaveServerCertificateArn, IHaveDnsServers
    {
        public override string AWSTypeName { get => AWS.EC2.ClientVpnEndpoint; }
        /// <summary>
        /// ClientCidrBlock
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnendpoint.html#cfn-ec2-clientvpnendpoint-clientcidrblock
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ClientCidrBlock { get; set; }
        /// <summary>
        /// ClientConnectOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnendpoint.html#cfn-ec2-clientvpnendpoint-clientconnectoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ClientConnectOptions
        /// </summary>
        public Humidifier.EC2.ClientVpnEndpointTypes.ClientConnectOptions ClientConnectOptions { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnendpoint.html#cfn-ec2-clientvpnendpoint-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// ClientRouteEnforcementOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnendpoint.html#cfn-ec2-clientvpnendpoint-clientrouteenforcementoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ClientRouteEnforcementOptions
        /// </summary>
        public Humidifier.EC2.ClientVpnEndpointTypes.ClientRouteEnforcementOptions ClientRouteEnforcementOptions { get; set; }
        /// <summary>
        /// TagSpecifications
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnendpoint.html#cfn-ec2-clientvpnendpoint-tagspecifications
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: TagSpecification
        /// </summary>
        public List<Humidifier.EC2.ClientVpnEndpointTypes.TagSpecification> TagSpecifications { get; set; }

        /// <summary>
        /// AuthenticationOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnendpoint.html#cfn-ec2-clientvpnendpoint-authenticationoptions
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: ClientAuthenticationRequest
        /// </summary>
        [Required]
        public List<Humidifier.EC2.ClientVpnEndpointTypes.ClientAuthenticationRequest> AuthenticationOptions { get; set; }

        /// <summary>
        /// ServerCertificateArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnendpoint.html#cfn-ec2-clientvpnendpoint-servercertificatearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ServerCertificateArn { get; set; }
        /// <summary>
        /// SessionTimeoutHours
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnendpoint.html#cfn-ec2-clientvpnendpoint-sessiontimeouthours
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic SessionTimeoutHours { get; set; }
        /// <summary>
        /// DnsServers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnendpoint.html#cfn-ec2-clientvpnendpoint-dnsservers
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic DnsServers { get; set; }
        /// <summary>
        /// DevicePostureOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnendpoint.html#cfn-ec2-clientvpnendpoint-devicepostureoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DevicePostureOptions
        /// </summary>
        public Humidifier.EC2.ClientVpnEndpointTypes.DevicePostureOptions DevicePostureOptions { get; set; }
        /// <summary>
        /// SecurityGroupIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnendpoint.html#cfn-ec2-clientvpnendpoint-securitygroupids
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic SecurityGroupIds { get; set; }
        /// <summary>
        /// DisconnectOnSessionTimeout
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnendpoint.html#cfn-ec2-clientvpnendpoint-disconnectonsessiontimeout
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic DisconnectOnSessionTimeout { get; set; }

        /// <summary>
        /// ConnectionLogOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnendpoint.html#cfn-ec2-clientvpnendpoint-connectionlogoptions
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ConnectionLogOptions
        /// </summary>
        [Required]
        public Humidifier.EC2.ClientVpnEndpointTypes.ConnectionLogOptions ConnectionLogOptions { get; set; }
        /// <summary>
        /// AuthorizationPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnendpoint.html#cfn-ec2-clientvpnendpoint-authorizationpolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AuthorizationPolicy
        /// </summary>
        public Humidifier.EC2.ClientVpnEndpointTypes.AuthorizationPolicy AuthorizationPolicy { get; set; }
        /// <summary>
        /// SplitTunnel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnendpoint.html#cfn-ec2-clientvpnendpoint-splittunnel
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic SplitTunnel { get; set; }
        /// <summary>
        /// TrafficIpAddressType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnendpoint.html#cfn-ec2-clientvpnendpoint-trafficipaddresstype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TrafficIpAddressType { get; set; }
        /// <summary>
        /// ClientLoginBannerOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnendpoint.html#cfn-ec2-clientvpnendpoint-clientloginbanneroptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ClientLoginBannerOptions
        /// </summary>
        public Humidifier.EC2.ClientVpnEndpointTypes.ClientLoginBannerOptions ClientLoginBannerOptions { get; set; }
        /// <summary>
        /// VpcId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnendpoint.html#cfn-ec2-clientvpnendpoint-vpcid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic VpcId { get; set; }
        /// <summary>
        /// SelfServicePortal
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnendpoint.html#cfn-ec2-clientvpnendpoint-selfserviceportal
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SelfServicePortal { get; set; }
        /// <summary>
        /// TransitGatewayConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnendpoint.html#cfn-ec2-clientvpnendpoint-transitgatewayconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: TransitGatewayConfiguration
        /// </summary>
        public Humidifier.EC2.ClientVpnEndpointTypes.TransitGatewayConfiguration TransitGatewayConfiguration { get; set; }
        /// <summary>
        /// TransportProtocol
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnendpoint.html#cfn-ec2-clientvpnendpoint-transportprotocol
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TransportProtocol { get; set; }
        /// <summary>
        /// EndpointIpAddressType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnendpoint.html#cfn-ec2-clientvpnendpoint-endpointipaddresstype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic EndpointIpAddressType { get; set; }
        /// <summary>
        /// VpnPort
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnendpoint.html#cfn-ec2-clientvpnendpoint-vpnport
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic VpnPort { get; set; }
    }

    namespace ClientVpnEndpointTypes
    {
        public class AuthorizationPolicy : Humidifier.Base.BaseSubResource, IHaveDescription, IHavePolicyDocument
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-authorizationpolicy.html#cfn-ec2-clientvpnendpoint-authorizationpolicy-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// PolicyDocument
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-authorizationpolicy.html#cfn-ec2-clientvpnendpoint-authorizationpolicy-policydocument
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PolicyDocument { get; set; }
            /// <summary>
            /// ShadowMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-authorizationpolicy.html#cfn-ec2-clientvpnendpoint-authorizationpolicy-shadowmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShadowMode { get; set; }
        }

        public class CertificateAuthenticationRequest : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ClientRootCertificateChainArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-certificateauthenticationrequest.html#cfn-ec2-clientvpnendpoint-certificateauthenticationrequest-clientrootcertificatechainarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientRootCertificateChainArn { get; set; }
        }

        public class ClientAuthenticationRequest : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// MutualAuthentication
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-clientauthenticationrequest.html#cfn-ec2-clientvpnendpoint-clientauthenticationrequest-mutualauthentication
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CertificateAuthenticationRequest
            /// </summary>
            public Humidifier.EC2.ClientVpnEndpointTypes.CertificateAuthenticationRequest MutualAuthentication { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-clientauthenticationrequest.html#cfn-ec2-clientvpnendpoint-clientauthenticationrequest-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// FederatedAuthentication
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-clientauthenticationrequest.html#cfn-ec2-clientvpnendpoint-clientauthenticationrequest-federatedauthentication
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FederatedAuthenticationRequest
            /// </summary>
            public Humidifier.EC2.ClientVpnEndpointTypes.FederatedAuthenticationRequest FederatedAuthentication { get; set; }
            /// <summary>
            /// ActiveDirectory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-clientauthenticationrequest.html#cfn-ec2-clientvpnendpoint-clientauthenticationrequest-activedirectory
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DirectoryServiceAuthenticationRequest
            /// </summary>
            public Humidifier.EC2.ClientVpnEndpointTypes.DirectoryServiceAuthenticationRequest ActiveDirectory { get; set; }
        }

        public class ClientConnectOptions : Humidifier.Base.BaseSubResource, IHaveEnabled, IHaveLambdaFunctionArn
        {
            /// <summary>
            /// LambdaFunctionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-clientconnectoptions.html#cfn-ec2-clientvpnendpoint-clientconnectoptions-lambdafunctionarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LambdaFunctionArn { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-clientconnectoptions.html#cfn-ec2-clientvpnendpoint-clientconnectoptions-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
        }

        public class ClientLoginBannerOptions : Humidifier.Base.BaseSubResource, IHaveEnabled
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-clientloginbanneroptions.html#cfn-ec2-clientvpnendpoint-clientloginbanneroptions-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
            /// <summary>
            /// BannerText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-clientloginbanneroptions.html#cfn-ec2-clientvpnendpoint-clientloginbanneroptions-bannertext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BannerText { get; set; }
        }

        public class ClientRouteEnforcementOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Enforced
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-clientrouteenforcementoptions.html#cfn-ec2-clientvpnendpoint-clientrouteenforcementoptions-enforced
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enforced { get; set; }
        }

        public class ConnectionLogOptions : Humidifier.Base.BaseSubResource, IHaveEnabled
        {
            /// <summary>
            /// IncludeAuthorizationPolicyContext
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-connectionlogoptions.html#cfn-ec2-clientvpnendpoint-connectionlogoptions-includeauthorizationpolicycontext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IncludeAuthorizationPolicyContext { get; set; }
            /// <summary>
            /// CloudwatchLogStream
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-connectionlogoptions.html#cfn-ec2-clientvpnendpoint-connectionlogoptions-cloudwatchlogstream
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CloudwatchLogStream { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-connectionlogoptions.html#cfn-ec2-clientvpnendpoint-connectionlogoptions-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
            /// <summary>
            /// CloudwatchLogGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-connectionlogoptions.html#cfn-ec2-clientvpnendpoint-connectionlogoptions-cloudwatchloggroup
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CloudwatchLogGroup { get; set; }
        }

        public class DevicePostureOptions : Humidifier.Base.BaseSubResource, IHaveEnabled
        {
            /// <summary>
            /// TrustProviders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-devicepostureoptions.html#cfn-ec2-clientvpnendpoint-devicepostureoptions-trustproviders
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DevicePostureTrustProvider
            /// </summary>
            public List<Humidifier.EC2.ClientVpnEndpointTypes.DevicePostureTrustProvider> TrustProviders { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-devicepostureoptions.html#cfn-ec2-clientvpnendpoint-devicepostureoptions-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
        }

        public class DevicePostureTrustProvider : Humidifier.Base.BaseSubResource, IHaveTrustProviderType, IHaveTenantId
        {
            /// <summary>
            /// TenantId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-deviceposturetrustprovider.html#cfn-ec2-clientvpnendpoint-deviceposturetrustprovider-tenantid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TenantId { get; set; }
            /// <summary>
            /// TrustProviderType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-deviceposturetrustprovider.html#cfn-ec2-clientvpnendpoint-deviceposturetrustprovider-trustprovidertype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TrustProviderType { get; set; }
            /// <summary>
            /// PublicSigningKeyUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-deviceposturetrustprovider.html#cfn-ec2-clientvpnendpoint-deviceposturetrustprovider-publicsigningkeyurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PublicSigningKeyUrl { get; set; }
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
            public dynamic DirectoryId { get; set; }
        }

        public class FederatedAuthenticationRequest : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SelfServiceSAMLProviderArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-federatedauthenticationrequest.html#cfn-ec2-clientvpnendpoint-federatedauthenticationrequest-selfservicesamlproviderarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SelfServiceSAMLProviderArn { get; set; }
            /// <summary>
            /// SAMLProviderArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-federatedauthenticationrequest.html#cfn-ec2-clientvpnendpoint-federatedauthenticationrequest-samlproviderarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SAMLProviderArn { get; set; }
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
            public dynamic ResourceType { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-tagspecification.html#cfn-ec2-clientvpnendpoint-tagspecification-tags
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public List<Humidifier.Tag> Tags { get; set; }
        }

        public class TransitGatewayConfiguration : Humidifier.Base.BaseSubResource, IHaveAvailabilityZones, IHaveTransitGatewayId
        {
            /// <summary>
            /// TransitGatewayId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-transitgatewayconfiguration.html#cfn-ec2-clientvpnendpoint-transitgatewayconfiguration-transitgatewayid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TransitGatewayId { get; set; }
            /// <summary>
            /// AvailabilityZoneIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-transitgatewayconfiguration.html#cfn-ec2-clientvpnendpoint-transitgatewayconfiguration-availabilityzoneids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AvailabilityZoneIds { get; set; }
            /// <summary>
            /// AvailabilityZones
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-clientvpnendpoint-transitgatewayconfiguration.html#cfn-ec2-clientvpnendpoint-transitgatewayconfiguration-availabilityzones
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AvailabilityZones { get; set; }
        }
    }
}