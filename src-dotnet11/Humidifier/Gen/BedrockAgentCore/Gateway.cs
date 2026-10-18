namespace Humidifier.BedrockAgentCore
{
    using global::System.Collections.Generic;
    using GatewayTypes;

    public class Gateway : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription, IHaveAuthorizerType, IHaveRoleArn, IHaveName, IHaveBedrockAgentCoreGatewayTypesGatewayPolicyEngineConfigurationPolicyEngineConfiguration, IHaveBedrockAgentCoreGatewayTypesGatewayProtocolConfigurationProtocolConfiguration, IHaveExceptionLevel, IHaveKmsKeyArn, IHaveProtocolType_Json, IHaveListOfBedrockAgentCoreGatewayTypesGatewayInterceptorConfigurationInterceptorConfigurations, IHaveBedrockAgentCoreGatewayTypesWafConfigurationWafConfiguration, IHaveStringDictionaryOfTags, IHaveBedrockAgentCoreGatewayTypesAuthorizerConfigurationAuthorizerConfiguration
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string GatewayArn =  "GatewayArn" ;
            public static string GatewayUrl =  "GatewayUrl" ;
            public static string StatusReasons =  "StatusReasons" ;
            public static string GatewayIdentifier =  "GatewayIdentifier" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string WebAclArn =  "WebAclArn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string WorkloadIdentityDetails =  "WorkloadIdentityDetails" ;
        }

        public override string AWSTypeName { get => AWS.BedrockAgentCore.Gateway; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-gateway.html#cfn-bedrockagentcore-gateway-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// AuthorizerType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-gateway.html#cfn-bedrockagentcore-gateway-authorizertype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AuthorizerType { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-gateway.html#cfn-bedrockagentcore-gateway-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// PolicyEngineConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-gateway.html#cfn-bedrockagentcore-gateway-policyengineconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: GatewayPolicyEngineConfiguration
        /// </summary>
        public Union<Humidifier.BedrockAgentCore.GatewayTypes.GatewayPolicyEngineConfiguration, BaseFunction>? PolicyEngineConfiguration { get; set; }
        /// <summary>
        /// ProtocolConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-gateway.html#cfn-bedrockagentcore-gateway-protocolconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: GatewayProtocolConfiguration
        /// </summary>
        public Union<Humidifier.BedrockAgentCore.GatewayTypes.GatewayProtocolConfiguration, BaseFunction>? ProtocolConfiguration { get; set; }
        /// <summary>
        /// ExceptionLevel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-gateway.html#cfn-bedrockagentcore-gateway-exceptionlevel
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ExceptionLevel { get; set; }
        /// <summary>
        /// KmsKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-gateway.html#cfn-bedrockagentcore-gateway-kmskeyarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyArn { get; set; }
        /// <summary>
        /// ProtocolType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-gateway.html#cfn-bedrockagentcore-gateway-protocoltype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? ProtocolType { get; set; }
        /// <summary>
        /// InterceptorConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-gateway.html#cfn-bedrockagentcore-gateway-interceptorconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: GatewayInterceptorConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.BedrockAgentCore.GatewayTypes.GatewayInterceptorConfiguration>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.GatewayTypes.GatewayInterceptorConfiguration, BaseFunction>>, BaseFunction>? InterceptorConfigurations { get; set; }
        /// <summary>
        /// WafConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-gateway.html#cfn-bedrockagentcore-gateway-wafconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: WafConfiguration
        /// </summary>
        public Union<Humidifier.BedrockAgentCore.GatewayTypes.WafConfiguration, BaseFunction>? WafConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-gateway.html#cfn-bedrockagentcore-gateway-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// AuthorizerConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-gateway.html#cfn-bedrockagentcore-gateway-authorizerconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AuthorizerConfiguration
        /// </summary>
        public Union<Humidifier.BedrockAgentCore.GatewayTypes.AuthorizerConfiguration, BaseFunction>? AuthorizerConfiguration { get; set; }
    }

    namespace GatewayTypes
    {
        public class AuthorizerConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreGatewayTypesCustomJWTAuthorizerConfigurationCustomJWTAuthorizer
        {
            /// <summary>
            /// CustomJWTAuthorizer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gateway-authorizerconfiguration.html#cfn-bedrockagentcore-gateway-authorizerconfiguration-customjwtauthorizer
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CustomJWTAuthorizerConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTypes.CustomJWTAuthorizerConfiguration, BaseFunction>? CustomJWTAuthorizer { get; set; }
        }

        public class AuthorizingClaimMatchValueType : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreGatewayTypesClaimMatchValueTypeClaimMatchValue, IHaveClaimMatchOperator
        {
            /// <summary>
            /// ClaimMatchValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gateway-authorizingclaimmatchvaluetype.html#cfn-bedrockagentcore-gateway-authorizingclaimmatchvaluetype-claimmatchvalue
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ClaimMatchValueType
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTypes.ClaimMatchValueType, BaseFunction>? ClaimMatchValue { get; set; }
            /// <summary>
            /// ClaimMatchOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gateway-authorizingclaimmatchvaluetype.html#cfn-bedrockagentcore-gateway-authorizingclaimmatchvaluetype-claimmatchoperator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClaimMatchOperator { get; set; }
        }

        public class ClaimMatchValueType : Humidifier.Base.BaseSubResource, IHaveMatchValueString, IHaveStringListOfMatchValueStringList
        {
            /// <summary>
            /// MatchValueString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gateway-claimmatchvaluetype.html#cfn-bedrockagentcore-gateway-claimmatchvaluetype-matchvaluestring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MatchValueString { get; set; }
            /// <summary>
            /// MatchValueStringList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gateway-claimmatchvaluetype.html#cfn-bedrockagentcore-gateway-claimmatchvaluetype-matchvaluestringlist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? MatchValueStringList { get; set; }
        }

        public class CustomClaimValidationType : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreGatewayTypesAuthorizingClaimMatchValueTypeAuthorizingClaimMatchValue, IHaveInboundTokenClaimName, IHaveInboundTokenClaimValueType
        {
            /// <summary>
            /// AuthorizingClaimMatchValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gateway-customclaimvalidationtype.html#cfn-bedrockagentcore-gateway-customclaimvalidationtype-authorizingclaimmatchvalue
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AuthorizingClaimMatchValueType
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTypes.AuthorizingClaimMatchValueType, BaseFunction>? AuthorizingClaimMatchValue { get; set; }
            /// <summary>
            /// InboundTokenClaimName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gateway-customclaimvalidationtype.html#cfn-bedrockagentcore-gateway-customclaimvalidationtype-inboundtokenclaimname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InboundTokenClaimName { get; set; }
            /// <summary>
            /// InboundTokenClaimValueType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gateway-customclaimvalidationtype.html#cfn-bedrockagentcore-gateway-customclaimvalidationtype-inboundtokenclaimvaluetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InboundTokenClaimValueType { get; set; }
        }

        public class CustomJWTAuthorizerConfiguration : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfAdvertisedScopeMapping, IHaveDiscoveryUrl, IHaveStringListOfAllowedAudience, IHaveListOfBedrockAgentCoreGatewayTypesCustomClaimValidationTypeCustomClaims, IHaveBedrockAgentCoreGatewayTypesPrivateEndpointPrivateEndpoint, IHaveStringListOfAllowedClients, IHaveStringListOfAllowedScopes
        {
            /// <summary>
            /// AdvertisedScopeMapping
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gateway-customjwtauthorizerconfiguration.html#cfn-bedrockagentcore-gateway-customjwtauthorizerconfiguration-advertisedscopemapping
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? AdvertisedScopeMapping { get; set; }
            /// <summary>
            /// DiscoveryUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gateway-customjwtauthorizerconfiguration.html#cfn-bedrockagentcore-gateway-customjwtauthorizerconfiguration-discoveryurl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DiscoveryUrl { get; set; }
            /// <summary>
            /// AllowedAudience
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gateway-customjwtauthorizerconfiguration.html#cfn-bedrockagentcore-gateway-customjwtauthorizerconfiguration-allowedaudience
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedAudience { get; set; }
            /// <summary>
            /// CustomClaims
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gateway-customjwtauthorizerconfiguration.html#cfn-bedrockagentcore-gateway-customjwtauthorizerconfiguration-customclaims
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomClaimValidationType
            /// </summary>
            public Union<IReadOnlyList<Humidifier.BedrockAgentCore.GatewayTypes.CustomClaimValidationType>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.GatewayTypes.CustomClaimValidationType, BaseFunction>>, BaseFunction>? CustomClaims { get; set; }
            /// <summary>
            /// PrivateEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gateway-customjwtauthorizerconfiguration.html#cfn-bedrockagentcore-gateway-customjwtauthorizerconfiguration-privateendpoint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PrivateEndpoint
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTypes.PrivateEndpoint, BaseFunction>? PrivateEndpoint { get; set; }
            /// <summary>
            /// AllowedClients
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gateway-customjwtauthorizerconfiguration.html#cfn-bedrockagentcore-gateway-customjwtauthorizerconfiguration-allowedclients
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedClients { get; set; }
            /// <summary>
            /// AllowedScopes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gateway-customjwtauthorizerconfiguration.html#cfn-bedrockagentcore-gateway-customjwtauthorizerconfiguration-allowedscopes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedScopes { get; set; }
        }

        public class GatewayInterceptorConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfInterceptionPoints, IHaveBedrockAgentCoreGatewayTypesInterceptorConfigurationInterceptor, IHaveBedrockAgentCoreGatewayTypesInterceptorInputConfigurationInputConfiguration
        {
            /// <summary>
            /// InterceptionPoints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gateway-gatewayinterceptorconfiguration.html#cfn-bedrockagentcore-gateway-gatewayinterceptorconfiguration-interceptionpoints
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? InterceptionPoints { get; set; }
            /// <summary>
            /// Interceptor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gateway-gatewayinterceptorconfiguration.html#cfn-bedrockagentcore-gateway-gatewayinterceptorconfiguration-interceptor
            /// Required: True
            /// UpdateType: Mutable
            /// Type: InterceptorConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTypes.InterceptorConfiguration, BaseFunction>? Interceptor { get; set; }
            /// <summary>
            /// InputConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gateway-gatewayinterceptorconfiguration.html#cfn-bedrockagentcore-gateway-gatewayinterceptorconfiguration-inputconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InterceptorInputConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTypes.InterceptorInputConfiguration, BaseFunction>? InputConfiguration { get; set; }
        }

        public class GatewayPolicyEngineConfiguration : Humidifier.Base.BaseSubResource, IHaveMode, IHaveArn
        {
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gateway-gatewaypolicyengineconfiguration.html#cfn-bedrockagentcore-gateway-gatewaypolicyengineconfiguration-mode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Mode { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gateway-gatewaypolicyengineconfiguration.html#cfn-bedrockagentcore-gateway-gatewaypolicyengineconfiguration-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
        }

        public class GatewayProtocolConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreGatewayTypesMCPGatewayConfigurationMcp
        {
            /// <summary>
            /// Mcp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gateway-gatewayprotocolconfiguration.html#cfn-bedrockagentcore-gateway-gatewayprotocolconfiguration-mcp
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MCPGatewayConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTypes.MCPGatewayConfiguration, BaseFunction>? Mcp { get; set; }
        }

        public class InterceptorConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreGatewayTypesLambdaInterceptorConfigurationLambda
        {
            /// <summary>
            /// Lambda
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gateway-interceptorconfiguration.html#cfn-bedrockagentcore-gateway-interceptorconfiguration-lambda
            /// Required: True
            /// UpdateType: Mutable
            /// Type: LambdaInterceptorConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTypes.LambdaInterceptorConfiguration, BaseFunction>? Lambda { get; set; }
        }

        public class InterceptorInputConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreGatewayTypesInterceptorPayloadFilterPayloadFilter, IHavePassRequestHeaders_Boolean
        {
            /// <summary>
            /// PayloadFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gateway-interceptorinputconfiguration.html#cfn-bedrockagentcore-gateway-interceptorinputconfiguration-payloadfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InterceptorPayloadFilter
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTypes.InterceptorPayloadFilter, BaseFunction>? PayloadFilter { get; set; }
            /// <summary>
            /// PassRequestHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gateway-interceptorinputconfiguration.html#cfn-bedrockagentcore-gateway-interceptorinputconfiguration-passrequestheaders
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? PassRequestHeaders { get; set; }
        }

        public class InterceptorPayloadExclusionSelector : Humidifier.Base.BaseSubResource, IHaveField
        {
            /// <summary>
            /// Field
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gateway-interceptorpayloadexclusionselector.html#cfn-bedrockagentcore-gateway-interceptorpayloadexclusionselector-field
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Field { get; set; }
        }

        public class InterceptorPayloadFilter : Humidifier.Base.BaseSubResource, IHaveListOfBedrockAgentCoreGatewayTypesInterceptorPayloadExclusionSelectorExclude
        {
            /// <summary>
            /// Exclude
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gateway-interceptorpayloadfilter.html#cfn-bedrockagentcore-gateway-interceptorpayloadfilter-exclude
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: InterceptorPayloadExclusionSelector
            /// </summary>
            public Union<IReadOnlyList<Humidifier.BedrockAgentCore.GatewayTypes.InterceptorPayloadExclusionSelector>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.GatewayTypes.InterceptorPayloadExclusionSelector, BaseFunction>>, BaseFunction>? Exclude { get; set; }
        }

        public class LambdaInterceptorConfiguration : Humidifier.Base.BaseSubResource, IHaveArn
        {
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gateway-lambdainterceptorconfiguration.html#cfn-bedrockagentcore-gateway-lambdainterceptorconfiguration-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
        }

        public class MCPGatewayConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfSupportedVersions, IHaveInstructions, IHaveSearchType, IHaveBedrockAgentCoreGatewayTypesStreamingConfigurationStreamingConfiguration, IHaveBedrockAgentCoreGatewayTypesSessionConfigurationSessionConfiguration
        {
            /// <summary>
            /// SupportedVersions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gateway-mcpgatewayconfiguration.html#cfn-bedrockagentcore-gateway-mcpgatewayconfiguration-supportedversions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SupportedVersions { get; set; }
            /// <summary>
            /// Instructions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gateway-mcpgatewayconfiguration.html#cfn-bedrockagentcore-gateway-mcpgatewayconfiguration-instructions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Instructions { get; set; }
            /// <summary>
            /// SearchType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gateway-mcpgatewayconfiguration.html#cfn-bedrockagentcore-gateway-mcpgatewayconfiguration-searchtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SearchType { get; set; }
            /// <summary>
            /// StreamingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gateway-mcpgatewayconfiguration.html#cfn-bedrockagentcore-gateway-mcpgatewayconfiguration-streamingconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StreamingConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTypes.StreamingConfiguration, BaseFunction>? StreamingConfiguration { get; set; }
            /// <summary>
            /// SessionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gateway-mcpgatewayconfiguration.html#cfn-bedrockagentcore-gateway-mcpgatewayconfiguration-sessionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SessionConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTypes.SessionConfiguration, BaseFunction>? SessionConfiguration { get; set; }
        }

        public class ManagedVpcResource : Humidifier.Base.BaseSubResource, IHaveRoutingDomain, IHaveVpcIdentifier, IHaveStringListOfSubnetIds, IHaveEndpointIpAddressType, IHaveStringListOfSecurityGroupIds, IHaveStringDictionaryOfTags
        {
            /// <summary>
            /// RoutingDomain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gateway-managedvpcresource.html#cfn-bedrockagentcore-gateway-managedvpcresource-routingdomain
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoutingDomain { get; set; }
            /// <summary>
            /// VpcIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gateway-managedvpcresource.html#cfn-bedrockagentcore-gateway-managedvpcresource-vpcidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VpcIdentifier { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gateway-managedvpcresource.html#cfn-bedrockagentcore-gateway-managedvpcresource-subnetids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
            /// <summary>
            /// EndpointIpAddressType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gateway-managedvpcresource.html#cfn-bedrockagentcore-gateway-managedvpcresource-endpointipaddresstype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndpointIpAddressType { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gateway-managedvpcresource.html#cfn-bedrockagentcore-gateway-managedvpcresource-securitygroupids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gateway-managedvpcresource.html#cfn-bedrockagentcore-gateway-managedvpcresource-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        }

        public class PrivateEndpoint : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreGatewayTypesManagedVpcResourceManagedVpcResource, IHaveBedrockAgentCoreGatewayTypesSelfManagedLatticeResourceSelfManagedLatticeResource
        {
            /// <summary>
            /// ManagedVpcResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gateway-privateendpoint.html#cfn-bedrockagentcore-gateway-privateendpoint-managedvpcresource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ManagedVpcResource
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTypes.ManagedVpcResource, BaseFunction>? ManagedVpcResource { get; set; }
            /// <summary>
            /// SelfManagedLatticeResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gateway-privateendpoint.html#cfn-bedrockagentcore-gateway-privateendpoint-selfmanagedlatticeresource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SelfManagedLatticeResource
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTypes.SelfManagedLatticeResource, BaseFunction>? SelfManagedLatticeResource { get; set; }
        }

        public class SelfManagedLatticeResource : Humidifier.Base.BaseSubResource, IHaveResourceConfigurationIdentifier
        {
            /// <summary>
            /// ResourceConfigurationIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gateway-selfmanagedlatticeresource.html#cfn-bedrockagentcore-gateway-selfmanagedlatticeresource-resourceconfigurationidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceConfigurationIdentifier { get; set; }
        }

        public class SessionConfiguration : Humidifier.Base.BaseSubResource, IHaveSessionTimeoutInSeconds_Double
        {
            /// <summary>
            /// SessionTimeoutInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gateway-sessionconfiguration.html#cfn-bedrockagentcore-gateway-sessionconfiguration-sessiontimeoutinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? SessionTimeoutInSeconds { get; set; }
        }

        public class StreamingConfiguration : Humidifier.Base.BaseSubResource, IHaveEnableResponseStreaming_Boolean
        {
            /// <summary>
            /// EnableResponseStreaming
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gateway-streamingconfiguration.html#cfn-bedrockagentcore-gateway-streamingconfiguration-enableresponsestreaming
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableResponseStreaming { get; set; }
        }

        public class WafConfiguration : Humidifier.Base.BaseSubResource, IHaveFailureMode
        {
            /// <summary>
            /// FailureMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gateway-wafconfiguration.html#cfn-bedrockagentcore-gateway-wafconfiguration-failuremode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FailureMode { get; set; }
        }

        public class WorkloadIdentityDetails : Humidifier.Base.BaseSubResource, IHaveWorkloadIdentityArn
        {
            /// <summary>
            /// WorkloadIdentityArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gateway-workloadidentitydetails.html#cfn-bedrockagentcore-gateway-workloadidentitydetails-workloadidentityarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WorkloadIdentityArn { get; set; }
        }
    }
}