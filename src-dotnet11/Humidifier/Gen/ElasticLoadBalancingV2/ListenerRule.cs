namespace Humidifier.ElasticLoadBalancingV2
{
    using global::System.Collections.Generic;
    using ListenerRuleTypes;

    public class ListenerRule : Humidifier.Base.BaseResource, IHaveTags, IHaveListenerArn, IHaveListOfElasticLoadBalancingV2ListenerRuleTypesActionActions, IHavePriority_Integer, IHaveListOfElasticLoadBalancingV2ListenerRuleTypesTransformTransforms, IHaveListOfElasticLoadBalancingV2ListenerRuleTypesRuleConditionConditions
    {
        public class Attributes
        {
            public static string IsDefault =  "IsDefault" ;
            public static string RuleArn =  "RuleArn" ;
        }

        public override string AWSTypeName { get => AWS.ElasticLoadBalancingV2.ListenerRule; }
        /// <summary>
        /// ListenerArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-listenerrule.html#cfn-elasticloadbalancingv2-listenerrule-listenerarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ListenerArn { get; set; }

        /// <summary>
        /// Actions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-listenerrule.html#cfn-elasticloadbalancingv2-listenerrule-actions
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Action
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.Action>, IReadOnlyList<Union<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.Action, BaseFunction>>, BaseFunction>? Actions { get; set; }

        /// <summary>
        /// Priority
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-listenerrule.html#cfn-elasticloadbalancingv2-listenerrule-priority
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? Priority { get; set; }
        /// <summary>
        /// Transforms
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-listenerrule.html#cfn-elasticloadbalancingv2-listenerrule-transforms
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Transform
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.Transform>, IReadOnlyList<Union<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.Transform, BaseFunction>>, BaseFunction>? Transforms { get; set; }

        /// <summary>
        /// Conditions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-listenerrule.html#cfn-elasticloadbalancingv2-listenerrule-conditions
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: RuleCondition
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.RuleCondition>, IReadOnlyList<Union<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.RuleCondition, BaseFunction>>, BaseFunction>? Conditions { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticloadbalancingv2-listenerrule.html#cfn-elasticloadbalancingv2-listenerrule-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ListenerRuleTypes
    {
        public class Action : Humidifier.Base.BaseSubResource, IHaveOrder_Integer, IHaveTargetGroupArn, IHaveElasticLoadBalancingV2ListenerRuleTypesFixedResponseConfigFixedResponseConfig, IHaveElasticLoadBalancingV2ListenerRuleTypesAuthenticateCognitoConfigAuthenticateCognitoConfig, IHaveType, IHaveElasticLoadBalancingV2ListenerRuleTypesRedirectConfigRedirectConfig, IHaveElasticLoadBalancingV2ListenerRuleTypesJwtValidationConfigJwtValidationConfig, IHaveElasticLoadBalancingV2ListenerRuleTypesForwardConfigForwardConfig, IHaveElasticLoadBalancingV2ListenerRuleTypesAuthenticateOidcConfigAuthenticateOidcConfig
        {
            /// <summary>
            /// Order
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-action.html#cfn-elasticloadbalancingv2-listenerrule-action-order
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Order { get; set; }
            /// <summary>
            /// TargetGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-action.html#cfn-elasticloadbalancingv2-listenerrule-action-targetgrouparn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetGroupArn { get; set; }
            /// <summary>
            /// FixedResponseConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-action.html#cfn-elasticloadbalancingv2-listenerrule-action-fixedresponseconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FixedResponseConfig
            /// </summary>
            public Union<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.FixedResponseConfig, BaseFunction>? FixedResponseConfig { get; set; }
            /// <summary>
            /// AuthenticateCognitoConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-action.html#cfn-elasticloadbalancingv2-listenerrule-action-authenticatecognitoconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuthenticateCognitoConfig
            /// </summary>
            public Union<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.AuthenticateCognitoConfig, BaseFunction>? AuthenticateCognitoConfig { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-action.html#cfn-elasticloadbalancingv2-listenerrule-action-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// RedirectConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-action.html#cfn-elasticloadbalancingv2-listenerrule-action-redirectconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RedirectConfig
            /// </summary>
            public Union<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.RedirectConfig, BaseFunction>? RedirectConfig { get; set; }
            /// <summary>
            /// JwtValidationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-action.html#cfn-elasticloadbalancingv2-listenerrule-action-jwtvalidationconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JwtValidationConfig
            /// </summary>
            public Union<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.JwtValidationConfig, BaseFunction>? JwtValidationConfig { get; set; }
            /// <summary>
            /// ForwardConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-action.html#cfn-elasticloadbalancingv2-listenerrule-action-forwardconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ForwardConfig
            /// </summary>
            public Union<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.ForwardConfig, BaseFunction>? ForwardConfig { get; set; }
            /// <summary>
            /// AuthenticateOidcConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-action.html#cfn-elasticloadbalancingv2-listenerrule-action-authenticateoidcconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuthenticateOidcConfig
            /// </summary>
            public Union<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.AuthenticateOidcConfig, BaseFunction>? AuthenticateOidcConfig { get; set; }
        }

        public class AuthenticateCognitoConfig : Humidifier.Base.BaseSubResource, IHaveOnUnauthenticatedRequest, IHaveUserPoolClientId, IHaveUserPoolDomain, IHaveSessionTimeout_Integer, IHaveScope, IHaveSessionCookieName, IHaveUserPoolArn, IHaveStringDictionaryOfAuthenticationRequestExtraParams
        {
            /// <summary>
            /// OnUnauthenticatedRequest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-authenticatecognitoconfig.html#cfn-elasticloadbalancingv2-listenerrule-authenticatecognitoconfig-onunauthenticatedrequest
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OnUnauthenticatedRequest { get; set; }
            /// <summary>
            /// UserPoolClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-authenticatecognitoconfig.html#cfn-elasticloadbalancingv2-listenerrule-authenticatecognitoconfig-userpoolclientid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserPoolClientId { get; set; }
            /// <summary>
            /// UserPoolDomain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-authenticatecognitoconfig.html#cfn-elasticloadbalancingv2-listenerrule-authenticatecognitoconfig-userpooldomain
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserPoolDomain { get; set; }
            /// <summary>
            /// SessionTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-authenticatecognitoconfig.html#cfn-elasticloadbalancingv2-listenerrule-authenticatecognitoconfig-sessiontimeout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SessionTimeout { get; set; }
            /// <summary>
            /// Scope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-authenticatecognitoconfig.html#cfn-elasticloadbalancingv2-listenerrule-authenticatecognitoconfig-scope
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Scope { get; set; }
            /// <summary>
            /// SessionCookieName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-authenticatecognitoconfig.html#cfn-elasticloadbalancingv2-listenerrule-authenticatecognitoconfig-sessioncookiename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SessionCookieName { get; set; }
            /// <summary>
            /// UserPoolArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-authenticatecognitoconfig.html#cfn-elasticloadbalancingv2-listenerrule-authenticatecognitoconfig-userpoolarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserPoolArn { get; set; }
            /// <summary>
            /// AuthenticationRequestExtraParams
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-authenticatecognitoconfig.html#cfn-elasticloadbalancingv2-listenerrule-authenticatecognitoconfig-authenticationrequestextraparams
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? AuthenticationRequestExtraParams { get; set; }
        }

        public class AuthenticateOidcConfig : Humidifier.Base.BaseSubResource, IHaveOnUnauthenticatedRequest, IHaveTokenEndpoint, IHaveUseExistingClientSecret_Boolean, IHaveSessionTimeout_Integer, IHaveScope, IHaveIssuer, IHaveClientSecret, IHaveUserInfoEndpoint, IHaveClientId, IHaveAuthorizationEndpoint, IHaveSessionCookieName, IHaveStringDictionaryOfAuthenticationRequestExtraParams
        {
            /// <summary>
            /// OnUnauthenticatedRequest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-authenticateoidcconfig.html#cfn-elasticloadbalancingv2-listenerrule-authenticateoidcconfig-onunauthenticatedrequest
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OnUnauthenticatedRequest { get; set; }
            /// <summary>
            /// TokenEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-authenticateoidcconfig.html#cfn-elasticloadbalancingv2-listenerrule-authenticateoidcconfig-tokenendpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TokenEndpoint { get; set; }
            /// <summary>
            /// UseExistingClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-authenticateoidcconfig.html#cfn-elasticloadbalancingv2-listenerrule-authenticateoidcconfig-useexistingclientsecret
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? UseExistingClientSecret { get; set; }
            /// <summary>
            /// SessionTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-authenticateoidcconfig.html#cfn-elasticloadbalancingv2-listenerrule-authenticateoidcconfig-sessiontimeout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SessionTimeout { get; set; }
            /// <summary>
            /// Scope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-authenticateoidcconfig.html#cfn-elasticloadbalancingv2-listenerrule-authenticateoidcconfig-scope
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Scope { get; set; }
            /// <summary>
            /// Issuer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-authenticateoidcconfig.html#cfn-elasticloadbalancingv2-listenerrule-authenticateoidcconfig-issuer
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Issuer { get; set; }
            /// <summary>
            /// ClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-authenticateoidcconfig.html#cfn-elasticloadbalancingv2-listenerrule-authenticateoidcconfig-clientsecret
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientSecret { get; set; }
            /// <summary>
            /// UserInfoEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-authenticateoidcconfig.html#cfn-elasticloadbalancingv2-listenerrule-authenticateoidcconfig-userinfoendpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserInfoEndpoint { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-authenticateoidcconfig.html#cfn-elasticloadbalancingv2-listenerrule-authenticateoidcconfig-clientid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientId { get; set; }
            /// <summary>
            /// AuthorizationEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-authenticateoidcconfig.html#cfn-elasticloadbalancingv2-listenerrule-authenticateoidcconfig-authorizationendpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthorizationEndpoint { get; set; }
            /// <summary>
            /// SessionCookieName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-authenticateoidcconfig.html#cfn-elasticloadbalancingv2-listenerrule-authenticateoidcconfig-sessioncookiename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SessionCookieName { get; set; }
            /// <summary>
            /// AuthenticationRequestExtraParams
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-authenticateoidcconfig.html#cfn-elasticloadbalancingv2-listenerrule-authenticateoidcconfig-authenticationrequestextraparams
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? AuthenticationRequestExtraParams { get; set; }
        }

        public class FixedResponseConfig : Humidifier.Base.BaseSubResource, IHaveContentType, IHaveStatusCode, IHaveMessageBody
        {
            /// <summary>
            /// ContentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-fixedresponseconfig.html#cfn-elasticloadbalancingv2-listenerrule-fixedresponseconfig-contenttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContentType { get; set; }
            /// <summary>
            /// StatusCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-fixedresponseconfig.html#cfn-elasticloadbalancingv2-listenerrule-fixedresponseconfig-statuscode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StatusCode { get; set; }
            /// <summary>
            /// MessageBody
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-fixedresponseconfig.html#cfn-elasticloadbalancingv2-listenerrule-fixedresponseconfig-messagebody
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MessageBody { get; set; }
        }

        public class ForwardConfig : Humidifier.Base.BaseSubResource, IHaveElasticLoadBalancingV2ListenerRuleTypesTargetGroupStickinessConfigTargetGroupStickinessConfig, IHaveListOfElasticLoadBalancingV2ListenerRuleTypesTargetGroupTupleTargetGroups
        {
            /// <summary>
            /// TargetGroupStickinessConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-forwardconfig.html#cfn-elasticloadbalancingv2-listenerrule-forwardconfig-targetgroupstickinessconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TargetGroupStickinessConfig
            /// </summary>
            public Union<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.TargetGroupStickinessConfig, BaseFunction>? TargetGroupStickinessConfig { get; set; }
            /// <summary>
            /// TargetGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-forwardconfig.html#cfn-elasticloadbalancingv2-listenerrule-forwardconfig-targetgroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TargetGroupTuple
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.TargetGroupTuple>, IReadOnlyList<Union<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.TargetGroupTuple, BaseFunction>>, BaseFunction>? TargetGroups { get; set; }
        }

        public class HostHeaderConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfValues, IHaveStringListOfRegexValues
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-hostheaderconfig.html#cfn-elasticloadbalancingv2-listenerrule-hostheaderconfig-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
            /// <summary>
            /// RegexValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-hostheaderconfig.html#cfn-elasticloadbalancingv2-listenerrule-hostheaderconfig-regexvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? RegexValues { get; set; }
        }

        public class HttpHeaderConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfValues, IHaveStringListOfRegexValues, IHaveHttpHeaderName
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-httpheaderconfig.html#cfn-elasticloadbalancingv2-listenerrule-httpheaderconfig-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
            /// <summary>
            /// RegexValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-httpheaderconfig.html#cfn-elasticloadbalancingv2-listenerrule-httpheaderconfig-regexvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? RegexValues { get; set; }
            /// <summary>
            /// HttpHeaderName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-httpheaderconfig.html#cfn-elasticloadbalancingv2-listenerrule-httpheaderconfig-httpheadername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HttpHeaderName { get; set; }
        }

        public class HttpRequestMethodConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfValues
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-httprequestmethodconfig.html#cfn-elasticloadbalancingv2-listenerrule-httprequestmethodconfig-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
        }

        public class JwtValidationActionAdditionalClaim : Humidifier.Base.BaseSubResource, IHaveFormat, IHaveStringListOfValues, IHaveName
        {
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-jwtvalidationactionadditionalclaim.html#cfn-elasticloadbalancingv2-listenerrule-jwtvalidationactionadditionalclaim-format
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Format { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-jwtvalidationactionadditionalclaim.html#cfn-elasticloadbalancingv2-listenerrule-jwtvalidationactionadditionalclaim-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-jwtvalidationactionadditionalclaim.html#cfn-elasticloadbalancingv2-listenerrule-jwtvalidationactionadditionalclaim-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class JwtValidationConfig : Humidifier.Base.BaseSubResource, IHaveJwksEndpoint, IHaveIssuer, IHaveListOfElasticLoadBalancingV2ListenerRuleTypesJwtValidationActionAdditionalClaimAdditionalClaims
        {
            /// <summary>
            /// JwksEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-jwtvalidationconfig.html#cfn-elasticloadbalancingv2-listenerrule-jwtvalidationconfig-jwksendpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? JwksEndpoint { get; set; }
            /// <summary>
            /// Issuer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-jwtvalidationconfig.html#cfn-elasticloadbalancingv2-listenerrule-jwtvalidationconfig-issuer
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Issuer { get; set; }
            /// <summary>
            /// AdditionalClaims
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-jwtvalidationconfig.html#cfn-elasticloadbalancingv2-listenerrule-jwtvalidationconfig-additionalclaims
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: JwtValidationActionAdditionalClaim
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.JwtValidationActionAdditionalClaim>, IReadOnlyList<Union<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.JwtValidationActionAdditionalClaim, BaseFunction>>, BaseFunction>? AdditionalClaims { get; set; }
        }

        public class PathPatternConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfValues, IHaveStringListOfRegexValues
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-pathpatternconfig.html#cfn-elasticloadbalancingv2-listenerrule-pathpatternconfig-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
            /// <summary>
            /// RegexValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-pathpatternconfig.html#cfn-elasticloadbalancingv2-listenerrule-pathpatternconfig-regexvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? RegexValues { get; set; }
        }

        public class QueryStringConfig : Humidifier.Base.BaseSubResource, IHaveListOfElasticLoadBalancingV2ListenerRuleTypesQueryStringKeyValueValues
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-querystringconfig.html#cfn-elasticloadbalancingv2-listenerrule-querystringconfig-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: QueryStringKeyValue
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.QueryStringKeyValue>, IReadOnlyList<Union<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.QueryStringKeyValue, BaseFunction>>, BaseFunction>? Values { get; set; }
        }

        public class QueryStringKeyValue : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-querystringkeyvalue.html#cfn-elasticloadbalancingv2-listenerrule-querystringkeyvalue-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-querystringkeyvalue.html#cfn-elasticloadbalancingv2-listenerrule-querystringkeyvalue-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class RedirectConfig : Humidifier.Base.BaseSubResource, IHavePath, IHaveQuery, IHavePort, IHaveHost, IHaveProtocol, IHaveStatusCode
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-redirectconfig.html#cfn-elasticloadbalancingv2-listenerrule-redirectconfig-path
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Path { get; set; }
            /// <summary>
            /// Query
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-redirectconfig.html#cfn-elasticloadbalancingv2-listenerrule-redirectconfig-query
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Query { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-redirectconfig.html#cfn-elasticloadbalancingv2-listenerrule-redirectconfig-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Port { get; set; }
            /// <summary>
            /// Host
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-redirectconfig.html#cfn-elasticloadbalancingv2-listenerrule-redirectconfig-host
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Host { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-redirectconfig.html#cfn-elasticloadbalancingv2-listenerrule-redirectconfig-protocol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Protocol { get; set; }
            /// <summary>
            /// StatusCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-redirectconfig.html#cfn-elasticloadbalancingv2-listenerrule-redirectconfig-statuscode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StatusCode { get; set; }
        }

        public class RewriteConfig : Humidifier.Base.BaseSubResource, IHaveReplace, IHaveRegex
        {
            /// <summary>
            /// Replace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-rewriteconfig.html#cfn-elasticloadbalancingv2-listenerrule-rewriteconfig-replace
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Replace { get; set; }
            /// <summary>
            /// Regex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-rewriteconfig.html#cfn-elasticloadbalancingv2-listenerrule-rewriteconfig-regex
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Regex { get; set; }
        }

        public class RewriteConfigObject : Humidifier.Base.BaseSubResource, IHaveListOfElasticLoadBalancingV2ListenerRuleTypesRewriteConfigRewrites
        {
            /// <summary>
            /// Rewrites
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-rewriteconfigobject.html#cfn-elasticloadbalancingv2-listenerrule-rewriteconfigobject-rewrites
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RewriteConfig
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.RewriteConfig>, IReadOnlyList<Union<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.RewriteConfig, BaseFunction>>, BaseFunction>? Rewrites { get; set; }
        }

        public class RuleCondition : Humidifier.Base.BaseSubResource, IHaveField, IHaveElasticLoadBalancingV2ListenerRuleTypesHttpHeaderConfigHttpHeaderConfig, IHaveStringListOfValues, IHaveElasticLoadBalancingV2ListenerRuleTypesQueryStringConfigQueryStringConfig, IHaveStringListOfRegexValues, IHaveElasticLoadBalancingV2ListenerRuleTypesHostHeaderConfigHostHeaderConfig, IHaveElasticLoadBalancingV2ListenerRuleTypesHttpRequestMethodConfigHttpRequestMethodConfig, IHaveElasticLoadBalancingV2ListenerRuleTypesPathPatternConfigPathPatternConfig, IHaveElasticLoadBalancingV2ListenerRuleTypesSourceIpConfigSourceIpConfig
        {
            /// <summary>
            /// Field
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-rulecondition.html#cfn-elasticloadbalancingv2-listenerrule-rulecondition-field
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Field { get; set; }
            /// <summary>
            /// HttpHeaderConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-rulecondition.html#cfn-elasticloadbalancingv2-listenerrule-rulecondition-httpheaderconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpHeaderConfig
            /// </summary>
            public Union<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.HttpHeaderConfig, BaseFunction>? HttpHeaderConfig { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-rulecondition.html#cfn-elasticloadbalancingv2-listenerrule-rulecondition-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
            /// <summary>
            /// QueryStringConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-rulecondition.html#cfn-elasticloadbalancingv2-listenerrule-rulecondition-querystringconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: QueryStringConfig
            /// </summary>
            public Union<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.QueryStringConfig, BaseFunction>? QueryStringConfig { get; set; }
            /// <summary>
            /// RegexValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-rulecondition.html#cfn-elasticloadbalancingv2-listenerrule-rulecondition-regexvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? RegexValues { get; set; }
            /// <summary>
            /// HostHeaderConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-rulecondition.html#cfn-elasticloadbalancingv2-listenerrule-rulecondition-hostheaderconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HostHeaderConfig
            /// </summary>
            public Union<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.HostHeaderConfig, BaseFunction>? HostHeaderConfig { get; set; }
            /// <summary>
            /// HttpRequestMethodConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-rulecondition.html#cfn-elasticloadbalancingv2-listenerrule-rulecondition-httprequestmethodconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpRequestMethodConfig
            /// </summary>
            public Union<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.HttpRequestMethodConfig, BaseFunction>? HttpRequestMethodConfig { get; set; }
            /// <summary>
            /// PathPatternConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-rulecondition.html#cfn-elasticloadbalancingv2-listenerrule-rulecondition-pathpatternconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PathPatternConfig
            /// </summary>
            public Union<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.PathPatternConfig, BaseFunction>? PathPatternConfig { get; set; }
            /// <summary>
            /// SourceIpConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-rulecondition.html#cfn-elasticloadbalancingv2-listenerrule-rulecondition-sourceipconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SourceIpConfig
            /// </summary>
            public Union<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.SourceIpConfig, BaseFunction>? SourceIpConfig { get; set; }
        }

        public class SourceIpConfig : Humidifier.Base.BaseSubResource, IHaveIpAddressType, IHaveStringListOfValues
        {
            /// <summary>
            /// IpAddressType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-sourceipconfig.html#cfn-elasticloadbalancingv2-listenerrule-sourceipconfig-ipaddresstype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IpAddressType { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-sourceipconfig.html#cfn-elasticloadbalancingv2-listenerrule-sourceipconfig-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
        }

        public class TargetGroupStickinessConfig : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean, IHaveDurationSeconds_Integer
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-targetgroupstickinessconfig.html#cfn-elasticloadbalancingv2-listenerrule-targetgroupstickinessconfig-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// DurationSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-targetgroupstickinessconfig.html#cfn-elasticloadbalancingv2-listenerrule-targetgroupstickinessconfig-durationseconds
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-targetgrouptuple.html#cfn-elasticloadbalancingv2-listenerrule-targetgrouptuple-targetgrouparn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetGroupArn { get; set; }
            /// <summary>
            /// Weight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-targetgrouptuple.html#cfn-elasticloadbalancingv2-listenerrule-targetgrouptuple-weight
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Weight { get; set; }
        }

        public class Transform : Humidifier.Base.BaseSubResource, IHaveType, IHaveElasticLoadBalancingV2ListenerRuleTypesRewriteConfigObjectUrlRewriteConfig, IHaveElasticLoadBalancingV2ListenerRuleTypesRewriteConfigObjectHostHeaderRewriteConfig
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-transform.html#cfn-elasticloadbalancingv2-listenerrule-transform-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// UrlRewriteConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-transform.html#cfn-elasticloadbalancingv2-listenerrule-transform-urlrewriteconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RewriteConfigObject
            /// </summary>
            public Union<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.RewriteConfigObject, BaseFunction>? UrlRewriteConfig { get; set; }
            /// <summary>
            /// HostHeaderRewriteConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticloadbalancingv2-listenerrule-transform.html#cfn-elasticloadbalancingv2-listenerrule-transform-hostheaderrewriteconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RewriteConfigObject
            /// </summary>
            public Union<Humidifier.ElasticLoadBalancingV2.ListenerRuleTypes.RewriteConfigObject, BaseFunction>? HostHeaderRewriteConfig { get; set; }
        }
    }
}