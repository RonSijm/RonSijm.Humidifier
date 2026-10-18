namespace Humidifier.ElasticLoadBalancingV2
{
    using global::System.Collections.Generic;
    using ListenerTypes;

    public class Listener : Humidifier.Base.BaseResource, IHaveTags, IHaveElasticLoadBalancingV2ListenerTypesMutualAuthenticationMutualAuthentication, IHaveListOfElasticLoadBalancingV2ListenerTypesListenerAttributeListenerAttributes, IHaveStringListOfAlpnPolicy, IHaveSslPolicy, IHaveLoadBalancerArn, IHaveListOfElasticLoadBalancingV2ListenerTypesActionDefaultActions, IHavePort_Integer, IHaveListOfElasticLoadBalancingV2ListenerTypesCertificateCertificates, IHaveProtocol
    {
        public class Attributes
        {
            public static string ListenerArn =  "ListenerArn" ;
        }

        public override string AWSTypeName { get => AWS.ElasticLoadBalancingV2.Listener; }
        /// <summary>
        /// MutualAuthentication
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-listener.html#cfn-elasticloadbalancingv2-listener-mutualauthentication
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MutualAuthentication
        /// </summary>
        public Union<Humidifier.ElasticLoadBalancingV2.ListenerTypes.MutualAuthentication, BaseFunction>? MutualAuthentication { get; set; }
        /// <summary>
        /// ListenerAttributes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-listener.html#cfn-elasticloadbalancingv2-listener-listenerattributes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ListenerAttribute
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ElasticLoadBalancingV2.ListenerTypes.ListenerAttribute>, IReadOnlyList<Union<Humidifier.ElasticLoadBalancingV2.ListenerTypes.ListenerAttribute, BaseFunction>>, BaseFunction>? ListenerAttributes { get; set; }
        /// <summary>
        /// AlpnPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-listener.html#cfn-elasticloadbalancingv2-listener-alpnpolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AlpnPolicy { get; set; }
        /// <summary>
        /// SslPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-listener.html#cfn-elasticloadbalancingv2-listener-sslpolicy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SslPolicy { get; set; }

        /// <summary>
        /// LoadBalancerArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-listener.html#cfn-elasticloadbalancingv2-listener-loadbalancerarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? LoadBalancerArn { get; set; }

        /// <summary>
        /// DefaultActions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-listener.html#cfn-elasticloadbalancingv2-listener-defaultactions
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Action
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.ElasticLoadBalancingV2.ListenerTypes.Action>, IReadOnlyList<Union<Humidifier.ElasticLoadBalancingV2.ListenerTypes.Action, BaseFunction>>, BaseFunction>? DefaultActions { get; set; }
        /// <summary>
        /// Port
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-listener.html#cfn-elasticloadbalancingv2-listener-port
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? Port { get; set; }
        /// <summary>
        /// Certificates
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-listener.html#cfn-elasticloadbalancingv2-listener-certificates
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Certificate
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ElasticLoadBalancingV2.ListenerTypes.Certificate>, IReadOnlyList<Union<Humidifier.ElasticLoadBalancingV2.ListenerTypes.Certificate, BaseFunction>>, BaseFunction>? Certificates { get; set; }
        /// <summary>
        /// Protocol
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-listener.html#cfn-elasticloadbalancingv2-listener-protocol
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Protocol { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-listener.html#cfn-elasticloadbalancingv2-listener-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ListenerTypes
    {
        public class Action : Humidifier.Base.BaseSubResource, IHaveOrder_Integer, IHaveTargetGroupArn, IHaveElasticLoadBalancingV2ListenerTypesFixedResponseConfigFixedResponseConfig, IHaveElasticLoadBalancingV2ListenerTypesAuthenticateCognitoConfigAuthenticateCognitoConfig, IHaveType, IHaveElasticLoadBalancingV2ListenerTypesRedirectConfigRedirectConfig, IHaveElasticLoadBalancingV2ListenerTypesJwtValidationConfigJwtValidationConfig, IHaveElasticLoadBalancingV2ListenerTypesForwardConfigForwardConfig, IHaveElasticLoadBalancingV2ListenerTypesAuthenticateOidcConfigAuthenticateOidcConfig
        {
            /// <summary>
            /// Order
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-action.html#cfn-elasticloadbalancingv2-listener-action-order
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Order { get; set; }
            /// <summary>
            /// TargetGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-action.html#cfn-elasticloadbalancingv2-listener-action-targetgrouparn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetGroupArn { get; set; }
            /// <summary>
            /// FixedResponseConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-action.html#cfn-elasticloadbalancingv2-listener-action-fixedresponseconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FixedResponseConfig
            /// </summary>
            public Union<Humidifier.ElasticLoadBalancingV2.ListenerTypes.FixedResponseConfig, BaseFunction>? FixedResponseConfig { get; set; }
            /// <summary>
            /// AuthenticateCognitoConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-action.html#cfn-elasticloadbalancingv2-listener-action-authenticatecognitoconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuthenticateCognitoConfig
            /// </summary>
            public Union<Humidifier.ElasticLoadBalancingV2.ListenerTypes.AuthenticateCognitoConfig, BaseFunction>? AuthenticateCognitoConfig { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-action.html#cfn-elasticloadbalancingv2-listener-action-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// RedirectConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-action.html#cfn-elasticloadbalancingv2-listener-action-redirectconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RedirectConfig
            /// </summary>
            public Union<Humidifier.ElasticLoadBalancingV2.ListenerTypes.RedirectConfig, BaseFunction>? RedirectConfig { get; set; }
            /// <summary>
            /// JwtValidationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-action.html#cfn-elasticloadbalancingv2-listener-action-jwtvalidationconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JwtValidationConfig
            /// </summary>
            public Union<Humidifier.ElasticLoadBalancingV2.ListenerTypes.JwtValidationConfig, BaseFunction>? JwtValidationConfig { get; set; }
            /// <summary>
            /// ForwardConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-action.html#cfn-elasticloadbalancingv2-listener-action-forwardconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ForwardConfig
            /// </summary>
            public Union<Humidifier.ElasticLoadBalancingV2.ListenerTypes.ForwardConfig, BaseFunction>? ForwardConfig { get; set; }
            /// <summary>
            /// AuthenticateOidcConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-action.html#cfn-elasticloadbalancingv2-listener-action-authenticateoidcconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuthenticateOidcConfig
            /// </summary>
            public Union<Humidifier.ElasticLoadBalancingV2.ListenerTypes.AuthenticateOidcConfig, BaseFunction>? AuthenticateOidcConfig { get; set; }
        }

        public class AuthenticateCognitoConfig : Humidifier.Base.BaseSubResource, IHaveOnUnauthenticatedRequest, IHaveUserPoolClientId, IHaveUserPoolDomain, IHaveSessionTimeout, IHaveScope, IHaveSessionCookieName, IHaveUserPoolArn, IHaveStringDictionaryOfAuthenticationRequestExtraParams
        {
            /// <summary>
            /// OnUnauthenticatedRequest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-authenticatecognitoconfig.html#cfn-elasticloadbalancingv2-listener-authenticatecognitoconfig-onunauthenticatedrequest
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OnUnauthenticatedRequest { get; set; }
            /// <summary>
            /// UserPoolClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-authenticatecognitoconfig.html#cfn-elasticloadbalancingv2-listener-authenticatecognitoconfig-userpoolclientid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserPoolClientId { get; set; }
            /// <summary>
            /// UserPoolDomain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-authenticatecognitoconfig.html#cfn-elasticloadbalancingv2-listener-authenticatecognitoconfig-userpooldomain
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserPoolDomain { get; set; }
            /// <summary>
            /// SessionTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-authenticatecognitoconfig.html#cfn-elasticloadbalancingv2-listener-authenticatecognitoconfig-sessiontimeout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SessionTimeout { get; set; }
            /// <summary>
            /// Scope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-authenticatecognitoconfig.html#cfn-elasticloadbalancingv2-listener-authenticatecognitoconfig-scope
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Scope { get; set; }
            /// <summary>
            /// SessionCookieName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-authenticatecognitoconfig.html#cfn-elasticloadbalancingv2-listener-authenticatecognitoconfig-sessioncookiename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SessionCookieName { get; set; }
            /// <summary>
            /// UserPoolArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-authenticatecognitoconfig.html#cfn-elasticloadbalancingv2-listener-authenticatecognitoconfig-userpoolarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserPoolArn { get; set; }
            /// <summary>
            /// AuthenticationRequestExtraParams
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-authenticatecognitoconfig.html#cfn-elasticloadbalancingv2-listener-authenticatecognitoconfig-authenticationrequestextraparams
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? AuthenticationRequestExtraParams { get; set; }
        }

        public class AuthenticateOidcConfig : Humidifier.Base.BaseSubResource, IHaveOnUnauthenticatedRequest, IHaveTokenEndpoint, IHaveUseExistingClientSecret_Boolean, IHaveSessionTimeout, IHaveScope, IHaveIssuer, IHaveClientSecret, IHaveUserInfoEndpoint, IHaveClientId, IHaveAuthorizationEndpoint, IHaveSessionCookieName, IHaveStringDictionaryOfAuthenticationRequestExtraParams
        {
            /// <summary>
            /// OnUnauthenticatedRequest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-authenticateoidcconfig.html#cfn-elasticloadbalancingv2-listener-authenticateoidcconfig-onunauthenticatedrequest
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OnUnauthenticatedRequest { get; set; }
            /// <summary>
            /// TokenEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-authenticateoidcconfig.html#cfn-elasticloadbalancingv2-listener-authenticateoidcconfig-tokenendpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TokenEndpoint { get; set; }
            /// <summary>
            /// UseExistingClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-authenticateoidcconfig.html#cfn-elasticloadbalancingv2-listener-authenticateoidcconfig-useexistingclientsecret
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? UseExistingClientSecret { get; set; }
            /// <summary>
            /// SessionTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-authenticateoidcconfig.html#cfn-elasticloadbalancingv2-listener-authenticateoidcconfig-sessiontimeout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SessionTimeout { get; set; }
            /// <summary>
            /// Scope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-authenticateoidcconfig.html#cfn-elasticloadbalancingv2-listener-authenticateoidcconfig-scope
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Scope { get; set; }
            /// <summary>
            /// Issuer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-authenticateoidcconfig.html#cfn-elasticloadbalancingv2-listener-authenticateoidcconfig-issuer
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Issuer { get; set; }
            /// <summary>
            /// ClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-authenticateoidcconfig.html#cfn-elasticloadbalancingv2-listener-authenticateoidcconfig-clientsecret
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientSecret { get; set; }
            /// <summary>
            /// UserInfoEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-authenticateoidcconfig.html#cfn-elasticloadbalancingv2-listener-authenticateoidcconfig-userinfoendpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserInfoEndpoint { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-authenticateoidcconfig.html#cfn-elasticloadbalancingv2-listener-authenticateoidcconfig-clientid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientId { get; set; }
            /// <summary>
            /// AuthorizationEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-authenticateoidcconfig.html#cfn-elasticloadbalancingv2-listener-authenticateoidcconfig-authorizationendpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthorizationEndpoint { get; set; }
            /// <summary>
            /// SessionCookieName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-authenticateoidcconfig.html#cfn-elasticloadbalancingv2-listener-authenticateoidcconfig-sessioncookiename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SessionCookieName { get; set; }
            /// <summary>
            /// AuthenticationRequestExtraParams
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-authenticateoidcconfig.html#cfn-elasticloadbalancingv2-listener-authenticateoidcconfig-authenticationrequestextraparams
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? AuthenticationRequestExtraParams { get; set; }
        }

        public class Certificate : Humidifier.Base.BaseSubResource, IHaveCertificateArn
        {
            /// <summary>
            /// CertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-certificate.html#cfn-elasticloadbalancingv2-listener-certificate-certificatearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CertificateArn { get; set; }
        }

        public class FixedResponseConfig : Humidifier.Base.BaseSubResource, IHaveContentType, IHaveStatusCode, IHaveMessageBody
        {
            /// <summary>
            /// ContentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-fixedresponseconfig.html#cfn-elasticloadbalancingv2-listener-fixedresponseconfig-contenttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContentType { get; set; }
            /// <summary>
            /// StatusCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-fixedresponseconfig.html#cfn-elasticloadbalancingv2-listener-fixedresponseconfig-statuscode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StatusCode { get; set; }
            /// <summary>
            /// MessageBody
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-fixedresponseconfig.html#cfn-elasticloadbalancingv2-listener-fixedresponseconfig-messagebody
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MessageBody { get; set; }
        }

        public class ForwardConfig : Humidifier.Base.BaseSubResource, IHaveElasticLoadBalancingV2ListenerTypesTargetGroupStickinessConfigTargetGroupStickinessConfig, IHaveListOfElasticLoadBalancingV2ListenerTypesTargetGroupTupleTargetGroups
        {
            /// <summary>
            /// TargetGroupStickinessConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-forwardconfig.html#cfn-elasticloadbalancingv2-listener-forwardconfig-targetgroupstickinessconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TargetGroupStickinessConfig
            /// </summary>
            public Union<Humidifier.ElasticLoadBalancingV2.ListenerTypes.TargetGroupStickinessConfig, BaseFunction>? TargetGroupStickinessConfig { get; set; }
            /// <summary>
            /// TargetGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-forwardconfig.html#cfn-elasticloadbalancingv2-listener-forwardconfig-targetgroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TargetGroupTuple
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ElasticLoadBalancingV2.ListenerTypes.TargetGroupTuple>, IReadOnlyList<Union<Humidifier.ElasticLoadBalancingV2.ListenerTypes.TargetGroupTuple, BaseFunction>>, BaseFunction>? TargetGroups { get; set; }
        }

        public class JwtValidationActionAdditionalClaim : Humidifier.Base.BaseSubResource, IHaveFormat, IHaveStringListOfValues, IHaveName
        {
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-jwtvalidationactionadditionalclaim.html#cfn-elasticloadbalancingv2-listener-jwtvalidationactionadditionalclaim-format
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Format { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-jwtvalidationactionadditionalclaim.html#cfn-elasticloadbalancingv2-listener-jwtvalidationactionadditionalclaim-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-jwtvalidationactionadditionalclaim.html#cfn-elasticloadbalancingv2-listener-jwtvalidationactionadditionalclaim-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class JwtValidationConfig : Humidifier.Base.BaseSubResource, IHaveJwksEndpoint, IHaveIssuer, IHaveListOfElasticLoadBalancingV2ListenerTypesJwtValidationActionAdditionalClaimAdditionalClaims
        {
            /// <summary>
            /// JwksEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-jwtvalidationconfig.html#cfn-elasticloadbalancingv2-listener-jwtvalidationconfig-jwksendpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? JwksEndpoint { get; set; }
            /// <summary>
            /// Issuer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-jwtvalidationconfig.html#cfn-elasticloadbalancingv2-listener-jwtvalidationconfig-issuer
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Issuer { get; set; }
            /// <summary>
            /// AdditionalClaims
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-jwtvalidationconfig.html#cfn-elasticloadbalancingv2-listener-jwtvalidationconfig-additionalclaims
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: JwtValidationActionAdditionalClaim
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ElasticLoadBalancingV2.ListenerTypes.JwtValidationActionAdditionalClaim>, IReadOnlyList<Union<Humidifier.ElasticLoadBalancingV2.ListenerTypes.JwtValidationActionAdditionalClaim, BaseFunction>>, BaseFunction>? AdditionalClaims { get; set; }
        }

        public class ListenerAttribute : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-listenerattribute.html#cfn-elasticloadbalancingv2-listener-listenerattribute-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-listenerattribute.html#cfn-elasticloadbalancingv2-listener-listenerattribute-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class MutualAuthentication : Humidifier.Base.BaseSubResource, IHaveIgnoreClientCertificateExpiry_Boolean, IHaveMode, IHaveTrustStoreArn, IHaveAdvertiseTrustStoreCaNames
        {
            /// <summary>
            /// IgnoreClientCertificateExpiry
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-mutualauthentication.html#cfn-elasticloadbalancingv2-listener-mutualauthentication-ignoreclientcertificateexpiry
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IgnoreClientCertificateExpiry { get; set; }
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-mutualauthentication.html#cfn-elasticloadbalancingv2-listener-mutualauthentication-mode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Mode { get; set; }
            /// <summary>
            /// TrustStoreArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-mutualauthentication.html#cfn-elasticloadbalancingv2-listener-mutualauthentication-truststorearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TrustStoreArn { get; set; }
            /// <summary>
            /// AdvertiseTrustStoreCaNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-mutualauthentication.html#cfn-elasticloadbalancingv2-listener-mutualauthentication-advertisetruststorecanames
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AdvertiseTrustStoreCaNames { get; set; }
        }

        public class RedirectConfig : Humidifier.Base.BaseSubResource, IHavePath, IHaveQuery, IHavePort, IHaveHost, IHaveProtocol, IHaveStatusCode
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-redirectconfig.html#cfn-elasticloadbalancingv2-listener-redirectconfig-path
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Path { get; set; }
            /// <summary>
            /// Query
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-redirectconfig.html#cfn-elasticloadbalancingv2-listener-redirectconfig-query
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Query { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-redirectconfig.html#cfn-elasticloadbalancingv2-listener-redirectconfig-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Port { get; set; }
            /// <summary>
            /// Host
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-redirectconfig.html#cfn-elasticloadbalancingv2-listener-redirectconfig-host
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Host { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-redirectconfig.html#cfn-elasticloadbalancingv2-listener-redirectconfig-protocol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Protocol { get; set; }
            /// <summary>
            /// StatusCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-redirectconfig.html#cfn-elasticloadbalancingv2-listener-redirectconfig-statuscode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StatusCode { get; set; }
        }

        public class TargetGroupStickinessConfig : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean, IHaveDurationSeconds_Integer
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-targetgroupstickinessconfig.html#cfn-elasticloadbalancingv2-listener-targetgroupstickinessconfig-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// DurationSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-targetgroupstickinessconfig.html#cfn-elasticloadbalancingv2-listener-targetgroupstickinessconfig-durationseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DurationSeconds { get; set; }
        }

        public class TargetGroupTuple : Humidifier.Base.BaseSubResource, IHaveTargetGroupArn, IHaveWeight_Integer
        {
            /// <summary>
            /// TargetGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-targetgrouptuple.html#cfn-elasticloadbalancingv2-listener-targetgrouptuple-targetgrouparn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetGroupArn { get; set; }
            /// <summary>
            /// Weight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listener-targetgrouptuple.html#cfn-elasticloadbalancingv2-listener-targetgrouptuple-weight
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Weight { get; set; }
        }
    }
}