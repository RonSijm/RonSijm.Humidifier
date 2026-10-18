namespace Humidifier.BedrockAgentCore
{
    using global::System.Collections.Generic;
    using GatewayTargetTypes;

    public class GatewayTarget : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription, IHaveBedrockAgentCoreGatewayTargetTypesTargetConfigurationTargetConfiguration, IHaveGatewayIdentifier, IHaveBedrockAgentCoreGatewayTargetTypesMetadataConfigurationMetadataConfiguration, IHaveListOfBedrockAgentCoreGatewayTargetTypesCredentialProviderConfigurationCredentialProviderConfigurations, IHaveBedrockAgentCoreGatewayTargetTypesPrivateEndpointPrivateEndpoint, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string StatusReasons =  "StatusReasons" ;
            public static string AuthorizationData =  "AuthorizationData" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string PrivateEndpointManagedResources =  "PrivateEndpointManagedResources" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string TargetId =  "TargetId" ;
            public static string GatewayArn =  "GatewayArn" ;
            public static string LastSynchronizedAt =  "LastSynchronizedAt" ;
            public static string ProtocolType =  "ProtocolType" ;
        }

        public override string AWSTypeName { get => AWS.BedrockAgentCore.GatewayTarget; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-gatewaytarget.html#cfn-bedrockagentcore-gatewaytarget-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// TargetConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-gatewaytarget.html#cfn-bedrockagentcore-gatewaytarget-targetconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: TargetConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.TargetConfiguration, BaseFunction>? TargetConfiguration { get; set; }
        /// <summary>
        /// GatewayIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-gatewaytarget.html#cfn-bedrockagentcore-gatewaytarget-gatewayidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? GatewayIdentifier { get; set; }
        /// <summary>
        /// MetadataConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-gatewaytarget.html#cfn-bedrockagentcore-gatewaytarget-metadataconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MetadataConfiguration
        /// </summary>
        public Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.MetadataConfiguration, BaseFunction>? MetadataConfiguration { get; set; }
        /// <summary>
        /// CredentialProviderConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-gatewaytarget.html#cfn-bedrockagentcore-gatewaytarget-credentialproviderconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: CredentialProviderConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.BedrockAgentCore.GatewayTargetTypes.CredentialProviderConfiguration>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.CredentialProviderConfiguration, BaseFunction>>, BaseFunction>? CredentialProviderConfigurations { get; set; }
        /// <summary>
        /// PrivateEndpoint
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-gatewaytarget.html#cfn-bedrockagentcore-gatewaytarget-privateendpoint
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PrivateEndpoint
        /// </summary>
        public Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.PrivateEndpoint, BaseFunction>? PrivateEndpoint { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace GatewayTargetTypes
    {
        public class ApiGatewayTargetConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreGatewayTargetTypesApiGatewayToolConfigurationApiGatewayToolConfiguration, IHaveRestApiId, IHaveStage
        {
            /// <summary>
            /// ApiGatewayToolConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-apigatewaytargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-apigatewaytargetconfiguration-apigatewaytoolconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ApiGatewayToolConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiGatewayToolConfiguration, BaseFunction>? ApiGatewayToolConfiguration { get; set; }
            /// <summary>
            /// RestApiId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-apigatewaytargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-apigatewaytargetconfiguration-restapiid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RestApiId { get; set; }
            /// <summary>
            /// Stage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-apigatewaytargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-apigatewaytargetconfiguration-stage
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Stage { get; set; }
        }

        public class ApiGatewayToolConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfBedrockAgentCoreGatewayTargetTypesApiGatewayToolFilterToolFilters, IHaveListOfBedrockAgentCoreGatewayTargetTypesApiGatewayToolOverrideToolOverrides
        {
            /// <summary>
            /// ToolFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-apigatewaytoolconfiguration.html#cfn-bedrockagentcore-gatewaytarget-apigatewaytoolconfiguration-toolfilters
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ApiGatewayToolFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiGatewayToolFilter>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiGatewayToolFilter, BaseFunction>>, BaseFunction>? ToolFilters { get; set; }
            /// <summary>
            /// ToolOverrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-apigatewaytoolconfiguration.html#cfn-bedrockagentcore-gatewaytarget-apigatewaytoolconfiguration-tooloverrides
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ApiGatewayToolOverride
            /// </summary>
            public Union<IReadOnlyList<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiGatewayToolOverride>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiGatewayToolOverride, BaseFunction>>, BaseFunction>? ToolOverrides { get; set; }
        }

        public class ApiGatewayToolFilter : Humidifier.Base.BaseSubResource, IHaveFilterPath, IHaveStringListOfMethods
        {
            /// <summary>
            /// FilterPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-apigatewaytoolfilter.html#cfn-bedrockagentcore-gatewaytarget-apigatewaytoolfilter-filterpath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FilterPath { get; set; }
            /// <summary>
            /// Methods
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-apigatewaytoolfilter.html#cfn-bedrockagentcore-gatewaytarget-apigatewaytoolfilter-methods
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Methods { get; set; }
        }

        public class ApiGatewayToolOverride : Humidifier.Base.BaseSubResource, IHavePath, IHaveDescription, IHaveMethod, IHaveName
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-apigatewaytooloverride.html#cfn-bedrockagentcore-gatewaytarget-apigatewaytooloverride-path
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Path { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-apigatewaytooloverride.html#cfn-bedrockagentcore-gatewaytarget-apigatewaytooloverride-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Method
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-apigatewaytooloverride.html#cfn-bedrockagentcore-gatewaytarget-apigatewaytooloverride-method
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Method { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-apigatewaytooloverride.html#cfn-bedrockagentcore-gatewaytarget-apigatewaytooloverride-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class ApiKeyCredentialProvider : Humidifier.Base.BaseSubResource, IHaveProviderArn, IHaveCredentialLocation, IHaveCredentialPrefix, IHaveCredentialParameterName
        {
            /// <summary>
            /// ProviderArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-apikeycredentialprovider.html#cfn-bedrockagentcore-gatewaytarget-apikeycredentialprovider-providerarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProviderArn { get; set; }
            /// <summary>
            /// CredentialLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-apikeycredentialprovider.html#cfn-bedrockagentcore-gatewaytarget-apikeycredentialprovider-credentiallocation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CredentialLocation { get; set; }
            /// <summary>
            /// CredentialPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-apikeycredentialprovider.html#cfn-bedrockagentcore-gatewaytarget-apikeycredentialprovider-credentialprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CredentialPrefix { get; set; }
            /// <summary>
            /// CredentialParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-apikeycredentialprovider.html#cfn-bedrockagentcore-gatewaytarget-apikeycredentialprovider-credentialparametername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CredentialParameterName { get; set; }
        }

        public class ApiSchemaConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreGatewayTargetTypesS3ConfigurationS3, IHaveInlinePayload
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-apischemaconfiguration.html#cfn-bedrockagentcore-gatewaytarget-apischemaconfiguration-s3
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Configuration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration, BaseFunction>? S3 { get; set; }
            /// <summary>
            /// InlinePayload
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-apischemaconfiguration.html#cfn-bedrockagentcore-gatewaytarget-apischemaconfiguration-inlinepayload
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InlinePayload { get; set; }
        }

        public class AuthorizationData : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreGatewayTargetTypesOAuth2AuthorizationDataOauth2
        {
            /// <summary>
            /// Oauth2
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-authorizationdata.html#cfn-bedrockagentcore-gatewaytarget-authorizationdata-oauth2
            /// Required: True
            /// UpdateType: Mutable
            /// Type: OAuth2AuthorizationData
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.OAuth2AuthorizationData, BaseFunction>? Oauth2 { get; set; }
        }

        public class ConnectorConfiguration : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveListOfBedrockAgentCoreGatewayTargetTypesConnectorParameterOverrideParameterOverrides, IHaveParameterValues_Json, IHaveName
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-connectorconfiguration.html#cfn-bedrockagentcore-gatewaytarget-connectorconfiguration-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// ParameterOverrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-connectorconfiguration.html#cfn-bedrockagentcore-gatewaytarget-connectorconfiguration-parameteroverrides
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ConnectorParameterOverride
            /// </summary>
            public Union<IReadOnlyList<Humidifier.BedrockAgentCore.GatewayTargetTypes.ConnectorParameterOverride>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.ConnectorParameterOverride, BaseFunction>>, BaseFunction>? ParameterOverrides { get; set; }
            /// <summary>
            /// ParameterValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-connectorconfiguration.html#cfn-bedrockagentcore-gatewaytarget-connectorconfiguration-parametervalues
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? ParameterValues { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-connectorconfiguration.html#cfn-bedrockagentcore-gatewaytarget-connectorconfiguration-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class ConnectorParameterOverride : Humidifier.Base.BaseSubResource, IHavePath, IHaveDescription, IHaveVisible_Boolean
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-connectorparameteroverride.html#cfn-bedrockagentcore-gatewaytarget-connectorparameteroverride-path
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Path { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-connectorparameteroverride.html#cfn-bedrockagentcore-gatewaytarget-connectorparameteroverride-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Visible
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-connectorparameteroverride.html#cfn-bedrockagentcore-gatewaytarget-connectorparameteroverride-visible
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Visible { get; set; }
        }

        public class ConnectorSource : Humidifier.Base.BaseSubResource, IHaveConnectorId
        {
            /// <summary>
            /// ConnectorId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-connectorsource.html#cfn-bedrockagentcore-gatewaytarget-connectorsource-connectorid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectorId { get; set; }
        }

        public class ConnectorTargetConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfEnabled, IHaveListOfBedrockAgentCoreGatewayTargetTypesConnectorConfigurationConfigurations, IHaveBedrockAgentCoreGatewayTargetTypesConnectorSourceSource
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-connectortargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-connectortargetconfiguration-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// Configurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-connectortargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-connectortargetconfiguration-configurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ConnectorConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.BedrockAgentCore.GatewayTargetTypes.ConnectorConfiguration>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.ConnectorConfiguration, BaseFunction>>, BaseFunction>? Configurations { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-connectortargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-connectortargetconfiguration-source
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ConnectorSource
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.ConnectorSource, BaseFunction>? Source { get; set; }
        }

        public class CredentialProvider : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreGatewayTargetTypesOAuthCredentialProviderOauthCredentialProvider, IHaveBedrockAgentCoreGatewayTargetTypesIamCredentialProviderIamCredentialProvider, IHaveBedrockAgentCoreGatewayTargetTypesApiKeyCredentialProviderApiKeyCredentialProvider
        {
            /// <summary>
            /// OauthCredentialProvider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-credentialprovider.html#cfn-bedrockagentcore-gatewaytarget-credentialprovider-oauthcredentialprovider
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OAuthCredentialProvider
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.OAuthCredentialProvider, BaseFunction>? OauthCredentialProvider { get; set; }
            /// <summary>
            /// IamCredentialProvider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-credentialprovider.html#cfn-bedrockagentcore-gatewaytarget-credentialprovider-iamcredentialprovider
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IamCredentialProvider
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.IamCredentialProvider, BaseFunction>? IamCredentialProvider { get; set; }
            /// <summary>
            /// ApiKeyCredentialProvider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-credentialprovider.html#cfn-bedrockagentcore-gatewaytarget-credentialprovider-apikeycredentialprovider
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ApiKeyCredentialProvider
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiKeyCredentialProvider, BaseFunction>? ApiKeyCredentialProvider { get; set; }
        }

        public class CredentialProviderConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreGatewayTargetTypesCredentialProviderCredentialProvider, IHaveCredentialProviderType
        {
            /// <summary>
            /// CredentialProvider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-credentialproviderconfiguration.html#cfn-bedrockagentcore-gatewaytarget-credentialproviderconfiguration-credentialprovider
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CredentialProvider
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.CredentialProvider, BaseFunction>? CredentialProvider { get; set; }
            /// <summary>
            /// CredentialProviderType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-credentialproviderconfiguration.html#cfn-bedrockagentcore-gatewaytarget-credentialproviderconfiguration-credentialprovidertype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CredentialProviderType { get; set; }
        }

        public class HttpApiSchemaConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreGatewayTargetTypesApiSchemaConfigurationSource
        {
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-httpapischemaconfiguration.html#cfn-bedrockagentcore-gatewaytarget-httpapischemaconfiguration-source
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ApiSchemaConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiSchemaConfiguration, BaseFunction>? Source { get; set; }
        }

        public class HttpConnectorSource : Humidifier.Base.BaseSubResource, IHaveConnectorId
        {
            /// <summary>
            /// ConnectorId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-httpconnectorsource.html#cfn-bedrockagentcore-gatewaytarget-httpconnectorsource-connectorid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectorId { get; set; }
        }

        public class HttpConnectorTargetConfiguration : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfParameters, IHaveBedrockAgentCoreGatewayTargetTypesHttpConnectorSourceSource
        {
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-httpconnectortargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-httpconnectortargetconfiguration-parameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Parameters { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-httpconnectortargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-httpconnectortargetconfiguration-source
            /// Required: True
            /// UpdateType: Mutable
            /// Type: HttpConnectorSource
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpConnectorSource, BaseFunction>? Source { get; set; }
        }

        public class HttpTargetConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreGatewayTargetTypesHttpConnectorTargetConfigurationConnector, IHaveBedrockAgentCoreGatewayTargetTypesPassthroughTargetConfigurationPassthrough, IHaveBedrockAgentCoreGatewayTargetTypesRuntimeTargetConfigurationAgentcoreRuntime
        {
            /// <summary>
            /// Connector
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-httptargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-httptargetconfiguration-connector
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpConnectorTargetConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpConnectorTargetConfiguration, BaseFunction>? Connector { get; set; }
            /// <summary>
            /// Passthrough
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-httptargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-httptargetconfiguration-passthrough
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PassthroughTargetConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.PassthroughTargetConfiguration, BaseFunction>? Passthrough { get; set; }
            /// <summary>
            /// AgentcoreRuntime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-httptargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-httptargetconfiguration-agentcoreruntime
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RuntimeTargetConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.RuntimeTargetConfiguration, BaseFunction>? AgentcoreRuntime { get; set; }
        }

        public class IamCredentialProvider : Humidifier.Base.BaseSubResource, IHaveService, IHaveRegion
        {
            /// <summary>
            /// Service
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-iamcredentialprovider.html#cfn-bedrockagentcore-gatewaytarget-iamcredentialprovider-service
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Service { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-iamcredentialprovider.html#cfn-bedrockagentcore-gatewaytarget-iamcredentialprovider-region
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Region { get; set; }
        }

        public class InferenceConnectorSource : Humidifier.Base.BaseSubResource, IHaveConnectorId
        {
            /// <summary>
            /// ConnectorId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-inferenceconnectorsource.html#cfn-bedrockagentcore-gatewaytarget-inferenceconnectorsource-connectorid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectorId { get; set; }
        }

        public class InferenceConnectorTargetConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreGatewayTargetTypesInferenceConnectorSourceSource
        {
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-inferenceconnectortargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-inferenceconnectortargetconfiguration-source
            /// Required: True
            /// UpdateType: Mutable
            /// Type: InferenceConnectorSource
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.InferenceConnectorSource, BaseFunction>? Source { get; set; }
        }

        public class InferenceOperationConfiguration : Humidifier.Base.BaseSubResource, IHavePath, IHaveProviderPath, IHaveListOfBedrockAgentCoreGatewayTargetTypesModelEntryModels
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-inferenceoperationconfiguration.html#cfn-bedrockagentcore-gatewaytarget-inferenceoperationconfiguration-path
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Path { get; set; }
            /// <summary>
            /// ProviderPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-inferenceoperationconfiguration.html#cfn-bedrockagentcore-gatewaytarget-inferenceoperationconfiguration-providerpath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProviderPath { get; set; }
            /// <summary>
            /// Models
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-inferenceoperationconfiguration.html#cfn-bedrockagentcore-gatewaytarget-inferenceoperationconfiguration-models
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ModelEntry
            /// </summary>
            public Union<IReadOnlyList<Humidifier.BedrockAgentCore.GatewayTargetTypes.ModelEntry>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.ModelEntry, BaseFunction>>, BaseFunction>? Models { get; set; }
        }

        public class InferenceProviderTargetConfiguration : Humidifier.Base.BaseSubResource, IHaveEndpoint, IHaveListOfBedrockAgentCoreGatewayTargetTypesInferenceOperationConfigurationOperations, IHaveBedrockAgentCoreGatewayTargetTypesModelMappingModelMapping
        {
            /// <summary>
            /// Endpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-inferenceprovidertargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-inferenceprovidertargetconfiguration-endpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Endpoint { get; set; }
            /// <summary>
            /// Operations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-inferenceprovidertargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-inferenceprovidertargetconfiguration-operations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: InferenceOperationConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.BedrockAgentCore.GatewayTargetTypes.InferenceOperationConfiguration>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.InferenceOperationConfiguration, BaseFunction>>, BaseFunction>? Operations { get; set; }
            /// <summary>
            /// ModelMapping
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-inferenceprovidertargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-inferenceprovidertargetconfiguration-modelmapping
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ModelMapping
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.ModelMapping, BaseFunction>? ModelMapping { get; set; }
        }

        public class InferenceTargetConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreGatewayTargetTypesInferenceConnectorTargetConfigurationConnector, IHaveBedrockAgentCoreGatewayTargetTypesInferenceProviderTargetConfigurationProvider
        {
            /// <summary>
            /// Connector
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-inferencetargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-inferencetargetconfiguration-connector
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InferenceConnectorTargetConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.InferenceConnectorTargetConfiguration, BaseFunction>? Connector { get; set; }
            /// <summary>
            /// Provider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-inferencetargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-inferencetargetconfiguration-provider
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InferenceProviderTargetConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.InferenceProviderTargetConfiguration, BaseFunction>? Provider { get; set; }
        }

        public class ManagedResourceDetails : Humidifier.Base.BaseSubResource, IHaveResourceGatewayArn, IHaveResourceAssociationArn, IHaveDomain
        {
            /// <summary>
            /// ResourceGatewayArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-managedresourcedetails.html#cfn-bedrockagentcore-gatewaytarget-managedresourcedetails-resourcegatewayarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceGatewayArn { get; set; }
            /// <summary>
            /// ResourceAssociationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-managedresourcedetails.html#cfn-bedrockagentcore-gatewaytarget-managedresourcedetails-resourceassociationarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceAssociationArn { get; set; }
            /// <summary>
            /// Domain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-managedresourcedetails.html#cfn-bedrockagentcore-gatewaytarget-managedresourcedetails-domain
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Domain { get; set; }
        }

        public class ManagedVpcResource : Humidifier.Base.BaseSubResource, IHaveRoutingDomain, IHaveVpcIdentifier, IHaveStringListOfSubnetIds, IHaveEndpointIpAddressType, IHaveStringListOfSecurityGroupIds, IHaveStringDictionaryOfTags
        {
            /// <summary>
            /// RoutingDomain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-managedvpcresource.html#cfn-bedrockagentcore-gatewaytarget-managedvpcresource-routingdomain
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoutingDomain { get; set; }
            /// <summary>
            /// VpcIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-managedvpcresource.html#cfn-bedrockagentcore-gatewaytarget-managedvpcresource-vpcidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VpcIdentifier { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-managedvpcresource.html#cfn-bedrockagentcore-gatewaytarget-managedvpcresource-subnetids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
            /// <summary>
            /// EndpointIpAddressType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-managedvpcresource.html#cfn-bedrockagentcore-gatewaytarget-managedvpcresource-endpointipaddresstype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndpointIpAddressType { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-managedvpcresource.html#cfn-bedrockagentcore-gatewaytarget-managedvpcresource-securitygroupids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-managedvpcresource.html#cfn-bedrockagentcore-gatewaytarget-managedvpcresource-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        }

        public class McpLambdaTargetConfiguration : Humidifier.Base.BaseSubResource, IHaveLambdaArn, IHaveBedrockAgentCoreGatewayTargetTypesToolSchemaToolSchema
        {
            /// <summary>
            /// LambdaArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-mcplambdatargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-mcplambdatargetconfiguration-lambdaarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LambdaArn { get; set; }
            /// <summary>
            /// ToolSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-mcplambdatargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-mcplambdatargetconfiguration-toolschema
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ToolSchema
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.ToolSchema, BaseFunction>? ToolSchema { get; set; }
        }

        public class McpServerTargetConfiguration : Humidifier.Base.BaseSubResource, IHaveEndpoint, IHaveListingMode, IHaveBedrockAgentCoreGatewayTargetTypesMcpToolSchemaConfigurationMcpToolSchema, IHaveResourcePriority_Double
        {
            /// <summary>
            /// Endpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-mcpservertargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-mcpservertargetconfiguration-endpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Endpoint { get; set; }
            /// <summary>
            /// ListingMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-mcpservertargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-mcpservertargetconfiguration-listingmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ListingMode { get; set; }
            /// <summary>
            /// McpToolSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-mcpservertargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-mcpservertargetconfiguration-mcptoolschema
            /// Required: False
            /// UpdateType: Mutable
            /// Type: McpToolSchemaConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.McpToolSchemaConfiguration, BaseFunction>? McpToolSchema { get; set; }
            /// <summary>
            /// ResourcePriority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-mcpservertargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-mcpservertargetconfiguration-resourcepriority
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? ResourcePriority { get; set; }
        }

        public class McpTargetConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreGatewayTargetTypesConnectorTargetConfigurationConnector, IHaveBedrockAgentCoreGatewayTargetTypesMcpServerTargetConfigurationMcpServer, IHaveBedrockAgentCoreGatewayTargetTypesApiSchemaConfigurationOpenApiSchema, IHaveBedrockAgentCoreGatewayTargetTypesApiSchemaConfigurationSmithyModel, IHaveBedrockAgentCoreGatewayTargetTypesMcpLambdaTargetConfigurationLambda, IHaveBedrockAgentCoreGatewayTargetTypesApiGatewayTargetConfigurationApiGateway
        {
            /// <summary>
            /// Connector
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-mcptargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-mcptargetconfiguration-connector
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConnectorTargetConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.ConnectorTargetConfiguration, BaseFunction>? Connector { get; set; }
            /// <summary>
            /// McpServer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-mcptargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-mcptargetconfiguration-mcpserver
            /// Required: False
            /// UpdateType: Mutable
            /// Type: McpServerTargetConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.McpServerTargetConfiguration, BaseFunction>? McpServer { get; set; }
            /// <summary>
            /// OpenApiSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-mcptargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-mcptargetconfiguration-openapischema
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ApiSchemaConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiSchemaConfiguration, BaseFunction>? OpenApiSchema { get; set; }
            /// <summary>
            /// SmithyModel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-mcptargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-mcptargetconfiguration-smithymodel
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ApiSchemaConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiSchemaConfiguration, BaseFunction>? SmithyModel { get; set; }
            /// <summary>
            /// Lambda
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-mcptargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-mcptargetconfiguration-lambda
            /// Required: False
            /// UpdateType: Mutable
            /// Type: McpLambdaTargetConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.McpLambdaTargetConfiguration, BaseFunction>? Lambda { get; set; }
            /// <summary>
            /// ApiGateway
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-mcptargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-mcptargetconfiguration-apigateway
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ApiGatewayTargetConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiGatewayTargetConfiguration, BaseFunction>? ApiGateway { get; set; }
        }

        public class McpToolSchemaConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreGatewayTargetTypesS3ConfigurationS3, IHaveInlinePayload
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-mcptoolschemaconfiguration.html#cfn-bedrockagentcore-gatewaytarget-mcptoolschemaconfiguration-s3
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Configuration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration, BaseFunction>? S3 { get; set; }
            /// <summary>
            /// InlinePayload
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-mcptoolschemaconfiguration.html#cfn-bedrockagentcore-gatewaytarget-mcptoolschemaconfiguration-inlinepayload
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InlinePayload { get; set; }
        }

        public class MetadataConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfAllowedQueryParameters, IHaveStringListOfAllowedResponseHeaders, IHaveStringListOfAllowedRequestHeaders
        {
            /// <summary>
            /// AllowedQueryParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-metadataconfiguration.html#cfn-bedrockagentcore-gatewaytarget-metadataconfiguration-allowedqueryparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedQueryParameters { get; set; }
            /// <summary>
            /// AllowedResponseHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-metadataconfiguration.html#cfn-bedrockagentcore-gatewaytarget-metadataconfiguration-allowedresponseheaders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedResponseHeaders { get; set; }
            /// <summary>
            /// AllowedRequestHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-metadataconfiguration.html#cfn-bedrockagentcore-gatewaytarget-metadataconfiguration-allowedrequestheaders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedRequestHeaders { get; set; }
        }

        public class ModelEntry : Humidifier.Base.BaseSubResource, IHaveModel
        {
            /// <summary>
            /// Model
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-modelentry.html#cfn-bedrockagentcore-gatewaytarget-modelentry-model
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Model { get; set; }
        }

        public class ModelMapping : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreGatewayTargetTypesProviderPrefixProviderPrefix
        {
            /// <summary>
            /// ProviderPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-modelmapping.html#cfn-bedrockagentcore-gatewaytarget-modelmapping-providerprefix
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ProviderPrefix
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.ProviderPrefix, BaseFunction>? ProviderPrefix { get; set; }
        }

        public class OAuth2AuthorizationData : Humidifier.Base.BaseSubResource, IHaveAuthorizationUrl, IHaveUserId
        {
            /// <summary>
            /// AuthorizationUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-oauth2authorizationdata.html#cfn-bedrockagentcore-gatewaytarget-oauth2authorizationdata-authorizationurl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthorizationUrl { get; set; }
            /// <summary>
            /// UserId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-oauth2authorizationdata.html#cfn-bedrockagentcore-gatewaytarget-oauth2authorizationdata-userid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserId { get; set; }
        }

        public class OAuthCredentialProvider : Humidifier.Base.BaseSubResource, IHaveDefaultReturnUrl, IHaveProviderArn, IHaveStringListOfScopes, IHaveGrantType_Json, IHaveStringDictionaryOfCustomParameters
        {
            /// <summary>
            /// DefaultReturnUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-oauthcredentialprovider.html#cfn-bedrockagentcore-gatewaytarget-oauthcredentialprovider-defaultreturnurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DefaultReturnUrl { get; set; }
            /// <summary>
            /// ProviderArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-oauthcredentialprovider.html#cfn-bedrockagentcore-gatewaytarget-oauthcredentialprovider-providerarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProviderArn { get; set; }
            /// <summary>
            /// Scopes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-oauthcredentialprovider.html#cfn-bedrockagentcore-gatewaytarget-oauthcredentialprovider-scopes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Scopes { get; set; }
            /// <summary>
            /// GrantType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-oauthcredentialprovider.html#cfn-bedrockagentcore-gatewaytarget-oauthcredentialprovider-granttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? GrantType { get; set; }
            /// <summary>
            /// CustomParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-oauthcredentialprovider.html#cfn-bedrockagentcore-gatewaytarget-oauthcredentialprovider-customparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? CustomParameters { get; set; }
        }

        public class PassthroughTargetConfiguration : Humidifier.Base.BaseSubResource, IHaveEndpoint, IHaveProtocolType, IHaveBedrockAgentCoreGatewayTargetTypesHttpApiSchemaConfigurationSchema, IHaveBedrockAgentCoreGatewayTargetTypesStickinessConfigurationStickinessConfiguration
        {
            /// <summary>
            /// Endpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-passthroughtargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-passthroughtargetconfiguration-endpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Endpoint { get; set; }
            /// <summary>
            /// ProtocolType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-passthroughtargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-passthroughtargetconfiguration-protocoltype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProtocolType { get; set; }
            /// <summary>
            /// Schema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-passthroughtargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-passthroughtargetconfiguration-schema
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpApiSchemaConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpApiSchemaConfiguration, BaseFunction>? Schema { get; set; }
            /// <summary>
            /// StickinessConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-passthroughtargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-passthroughtargetconfiguration-stickinessconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StickinessConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.StickinessConfiguration, BaseFunction>? StickinessConfiguration { get; set; }
        }

        public class PrivateEndpoint : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreGatewayTargetTypesManagedVpcResourceManagedVpcResource, IHaveBedrockAgentCoreGatewayTargetTypesSelfManagedLatticeResourceSelfManagedLatticeResource
        {
            /// <summary>
            /// ManagedVpcResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-privateendpoint.html#cfn-bedrockagentcore-gatewaytarget-privateendpoint-managedvpcresource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ManagedVpcResource
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.ManagedVpcResource, BaseFunction>? ManagedVpcResource { get; set; }
            /// <summary>
            /// SelfManagedLatticeResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-privateendpoint.html#cfn-bedrockagentcore-gatewaytarget-privateendpoint-selfmanagedlatticeresource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SelfManagedLatticeResource
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.SelfManagedLatticeResource, BaseFunction>? SelfManagedLatticeResource { get; set; }
        }

        public class ProviderPrefix : Humidifier.Base.BaseSubResource, IHaveStrip_Boolean, IHaveSeparator
        {
            /// <summary>
            /// Strip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-providerprefix.html#cfn-bedrockagentcore-gatewaytarget-providerprefix-strip
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Strip { get; set; }
            /// <summary>
            /// Separator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-providerprefix.html#cfn-bedrockagentcore-gatewaytarget-providerprefix-separator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Separator { get; set; }
        }

        public class RuntimeTargetConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreGatewayTargetTypesHttpApiSchemaConfigurationSchema, IHaveQualifier, IHaveArn
        {
            /// <summary>
            /// Schema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-runtimetargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-runtimetargetconfiguration-schema
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpApiSchemaConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpApiSchemaConfiguration, BaseFunction>? Schema { get; set; }
            /// <summary>
            /// Qualifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-runtimetargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-runtimetargetconfiguration-qualifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Qualifier { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-runtimetargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-runtimetargetconfiguration-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
        }

        public class S3Configuration : Humidifier.Base.BaseSubResource, IHaveBucketOwnerAccountId, IHaveUri
        {
            /// <summary>
            /// BucketOwnerAccountId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-s3configuration.html#cfn-bedrockagentcore-gatewaytarget-s3configuration-bucketowneraccountid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketOwnerAccountId { get; set; }
            /// <summary>
            /// Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-s3configuration.html#cfn-bedrockagentcore-gatewaytarget-s3configuration-uri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Uri { get; set; }
        }

        public class SchemaDefinition : Humidifier.Base.BaseSubResource, IHaveType, IHaveBedrockAgentCoreGatewayTargetTypesSchemaDefinitionItems, IHaveDescription, IHaveStringListOfRequired, IHaveMapOfBedrockAgentCoreGatewayTargetTypesSchemaDefinitionProperties
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-schemadefinition.html#cfn-bedrockagentcore-gatewaytarget-schemadefinition-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Items
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-schemadefinition.html#cfn-bedrockagentcore-gatewaytarget-schemadefinition-items
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SchemaDefinition
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.SchemaDefinition, BaseFunction>? Items { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-schemadefinition.html#cfn-bedrockagentcore-gatewaytarget-schemadefinition-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Required
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-schemadefinition.html#cfn-bedrockagentcore-gatewaytarget-schemadefinition-required
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Required { get; set; }
            /// <summary>
            /// Properties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-schemadefinition.html#cfn-bedrockagentcore-gatewaytarget-schemadefinition-properties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: SchemaDefinition
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.BedrockAgentCore.GatewayTargetTypes.SchemaDefinition>, IReadOnlyDictionary<string, Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.SchemaDefinition, BaseFunction>>, BaseFunction>? Properties { get; set; }
        }

        public class SelfManagedLatticeResource : Humidifier.Base.BaseSubResource, IHaveResourceConfigurationIdentifier
        {
            /// <summary>
            /// ResourceConfigurationIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-selfmanagedlatticeresource.html#cfn-bedrockagentcore-gatewaytarget-selfmanagedlatticeresource-resourceconfigurationidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceConfigurationIdentifier { get; set; }
        }

        public class StickinessConfiguration : Humidifier.Base.BaseSubResource, IHaveIdentifier, IHaveTimeout_Double
        {
            /// <summary>
            /// Identifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-stickinessconfiguration.html#cfn-bedrockagentcore-gatewaytarget-stickinessconfiguration-identifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Identifier { get; set; }
            /// <summary>
            /// Timeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-stickinessconfiguration.html#cfn-bedrockagentcore-gatewaytarget-stickinessconfiguration-timeout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Timeout { get; set; }
        }

        public class TargetConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreGatewayTargetTypesInferenceTargetConfigurationInference, IHaveBedrockAgentCoreGatewayTargetTypesHttpTargetConfigurationHttp, IHaveBedrockAgentCoreGatewayTargetTypesMcpTargetConfigurationMcp
        {
            /// <summary>
            /// Inference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-targetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-targetconfiguration-inference
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InferenceTargetConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.InferenceTargetConfiguration, BaseFunction>? Inference { get; set; }
            /// <summary>
            /// Http
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-targetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-targetconfiguration-http
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpTargetConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpTargetConfiguration, BaseFunction>? Http { get; set; }
            /// <summary>
            /// Mcp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-targetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-targetconfiguration-mcp
            /// Required: False
            /// UpdateType: Mutable
            /// Type: McpTargetConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.McpTargetConfiguration, BaseFunction>? Mcp { get; set; }
        }

        public class ToolDefinition : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreGatewayTargetTypesSchemaDefinitionOutputSchema, IHaveDescription, IHaveBedrockAgentCoreGatewayTargetTypesSchemaDefinitionInputSchema, IHaveName
        {
            /// <summary>
            /// OutputSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-tooldefinition.html#cfn-bedrockagentcore-gatewaytarget-tooldefinition-outputschema
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SchemaDefinition
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.SchemaDefinition, BaseFunction>? OutputSchema { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-tooldefinition.html#cfn-bedrockagentcore-gatewaytarget-tooldefinition-description
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// InputSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-tooldefinition.html#cfn-bedrockagentcore-gatewaytarget-tooldefinition-inputschema
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SchemaDefinition
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.SchemaDefinition, BaseFunction>? InputSchema { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-tooldefinition.html#cfn-bedrockagentcore-gatewaytarget-tooldefinition-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class ToolSchema : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreGatewayTargetTypesS3ConfigurationS3, IHaveListOfBedrockAgentCoreGatewayTargetTypesToolDefinitionInlinePayload
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-toolschema.html#cfn-bedrockagentcore-gatewaytarget-toolschema-s3
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Configuration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration, BaseFunction>? S3 { get; set; }
            /// <summary>
            /// InlinePayload
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-toolschema.html#cfn-bedrockagentcore-gatewaytarget-toolschema-inlinepayload
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ToolDefinition
            /// </summary>
            public Union<IReadOnlyList<Humidifier.BedrockAgentCore.GatewayTargetTypes.ToolDefinition>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.GatewayTargetTypes.ToolDefinition, BaseFunction>>, BaseFunction>? InlinePayload { get; set; }
        }
    }
}