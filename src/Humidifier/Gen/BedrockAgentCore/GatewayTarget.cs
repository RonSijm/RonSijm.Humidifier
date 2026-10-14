namespace Humidifier.BedrockAgentCore
{
    using global::System.Collections.Generic;
    using GatewayTargetTypes;

    public class GatewayTarget : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveDescription
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
        public dynamic Description { get; set; }

        /// <summary>
        /// TargetConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-gatewaytarget.html#cfn-bedrockagentcore-gatewaytarget-targetconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: TargetConfiguration
        /// </summary>
        [Required]
        public Humidifier.BedrockAgentCore.GatewayTargetTypes.TargetConfiguration TargetConfiguration { get; set; }
        /// <summary>
        /// GatewayIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-gatewaytarget.html#cfn-bedrockagentcore-gatewaytarget-gatewayidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic GatewayIdentifier { get; set; }
        /// <summary>
        /// MetadataConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-gatewaytarget.html#cfn-bedrockagentcore-gatewaytarget-metadataconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MetadataConfiguration
        /// </summary>
        public Humidifier.BedrockAgentCore.GatewayTargetTypes.MetadataConfiguration MetadataConfiguration { get; set; }
        /// <summary>
        /// CredentialProviderConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-gatewaytarget.html#cfn-bedrockagentcore-gatewaytarget-credentialproviderconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: CredentialProviderConfiguration
        /// </summary>
        public List<Humidifier.BedrockAgentCore.GatewayTargetTypes.CredentialProviderConfiguration> CredentialProviderConfigurations { get; set; }
        /// <summary>
        /// PrivateEndpoint
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-gatewaytarget.html#cfn-bedrockagentcore-gatewaytarget-privateendpoint
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PrivateEndpoint
        /// </summary>
        public Humidifier.BedrockAgentCore.GatewayTargetTypes.PrivateEndpoint PrivateEndpoint { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace GatewayTargetTypes
    {
        public class ApiGatewayTargetConfiguration : Humidifier.Base.BaseSubResource, IHaveRestApiId, IHaveStage
        {
            /// <summary>
            /// ApiGatewayToolConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-apigatewaytargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-apigatewaytargetconfiguration-apigatewaytoolconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ApiGatewayToolConfiguration
            /// </summary>
            public Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiGatewayToolConfiguration ApiGatewayToolConfiguration { get; set; }
            /// <summary>
            /// RestApiId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-apigatewaytargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-apigatewaytargetconfiguration-restapiid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RestApiId { get; set; }
            /// <summary>
            /// Stage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-apigatewaytargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-apigatewaytargetconfiguration-stage
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Stage { get; set; }
        }

        public class ApiGatewayToolConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ToolFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-apigatewaytoolconfiguration.html#cfn-bedrockagentcore-gatewaytarget-apigatewaytoolconfiguration-toolfilters
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ApiGatewayToolFilter
            /// </summary>
            public List<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiGatewayToolFilter> ToolFilters { get; set; }
            /// <summary>
            /// ToolOverrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-apigatewaytoolconfiguration.html#cfn-bedrockagentcore-gatewaytarget-apigatewaytoolconfiguration-tooloverrides
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ApiGatewayToolOverride
            /// </summary>
            public List<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiGatewayToolOverride> ToolOverrides { get; set; }
        }

        public class ApiGatewayToolFilter : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FilterPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-apigatewaytoolfilter.html#cfn-bedrockagentcore-gatewaytarget-apigatewaytoolfilter-filterpath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterPath { get; set; }
            /// <summary>
            /// Methods
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-apigatewaytoolfilter.html#cfn-bedrockagentcore-gatewaytarget-apigatewaytoolfilter-methods
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Methods { get; set; }
        }

        public class ApiGatewayToolOverride : Humidifier.Base.BaseSubResource, IHaveName, IHaveDescription, IHavePath, IHaveMethod
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-apigatewaytooloverride.html#cfn-bedrockagentcore-gatewaytarget-apigatewaytooloverride-path
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Path { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-apigatewaytooloverride.html#cfn-bedrockagentcore-gatewaytarget-apigatewaytooloverride-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// Method
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-apigatewaytooloverride.html#cfn-bedrockagentcore-gatewaytarget-apigatewaytooloverride-method
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Method { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-apigatewaytooloverride.html#cfn-bedrockagentcore-gatewaytarget-apigatewaytooloverride-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class ApiKeyCredentialProvider : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ProviderArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-apikeycredentialprovider.html#cfn-bedrockagentcore-gatewaytarget-apikeycredentialprovider-providerarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ProviderArn { get; set; }
            /// <summary>
            /// CredentialLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-apikeycredentialprovider.html#cfn-bedrockagentcore-gatewaytarget-apikeycredentialprovider-credentiallocation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CredentialLocation { get; set; }
            /// <summary>
            /// CredentialPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-apikeycredentialprovider.html#cfn-bedrockagentcore-gatewaytarget-apikeycredentialprovider-credentialprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CredentialPrefix { get; set; }
            /// <summary>
            /// CredentialParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-apikeycredentialprovider.html#cfn-bedrockagentcore-gatewaytarget-apikeycredentialprovider-credentialparametername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CredentialParameterName { get; set; }
        }

        public class ApiSchemaConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-apischemaconfiguration.html#cfn-bedrockagentcore-gatewaytarget-apischemaconfiguration-s3
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Configuration
            /// </summary>
            public Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration S3 { get; set; }
            /// <summary>
            /// InlinePayload
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-apischemaconfiguration.html#cfn-bedrockagentcore-gatewaytarget-apischemaconfiguration-inlinepayload
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InlinePayload { get; set; }
        }

        public class AuthorizationData : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Oauth2
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-authorizationdata.html#cfn-bedrockagentcore-gatewaytarget-authorizationdata-oauth2
            /// Required: True
            /// UpdateType: Mutable
            /// Type: OAuth2AuthorizationData
            /// </summary>
            public Humidifier.BedrockAgentCore.GatewayTargetTypes.OAuth2AuthorizationData Oauth2 { get; set; }
        }

        public class ConnectorConfiguration : Humidifier.Base.BaseSubResource, IHaveName, IHaveDescription
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-connectorconfiguration.html#cfn-bedrockagentcore-gatewaytarget-connectorconfiguration-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// ParameterOverrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-connectorconfiguration.html#cfn-bedrockagentcore-gatewaytarget-connectorconfiguration-parameteroverrides
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ConnectorParameterOverride
            /// </summary>
            public List<Humidifier.BedrockAgentCore.GatewayTargetTypes.ConnectorParameterOverride> ParameterOverrides { get; set; }
            /// <summary>
            /// ParameterValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-connectorconfiguration.html#cfn-bedrockagentcore-gatewaytarget-connectorconfiguration-parametervalues
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic ParameterValues { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-connectorconfiguration.html#cfn-bedrockagentcore-gatewaytarget-connectorconfiguration-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class ConnectorParameterOverride : Humidifier.Base.BaseSubResource, IHaveDescription, IHavePath
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-connectorparameteroverride.html#cfn-bedrockagentcore-gatewaytarget-connectorparameteroverride-path
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Path { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-connectorparameteroverride.html#cfn-bedrockagentcore-gatewaytarget-connectorparameteroverride-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// Visible
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-connectorparameteroverride.html#cfn-bedrockagentcore-gatewaytarget-connectorparameteroverride-visible
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Visible { get; set; }
        }

        public class ConnectorSource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ConnectorId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-connectorsource.html#cfn-bedrockagentcore-gatewaytarget-connectorsource-connectorid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConnectorId { get; set; }
        }

        public class ConnectorTargetConfiguration : Humidifier.Base.BaseSubResource, IHaveEnabled
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-connectortargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-connectortargetconfiguration-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Enabled { get; set; }
            /// <summary>
            /// Configurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-connectortargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-connectortargetconfiguration-configurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ConnectorConfiguration
            /// </summary>
            public List<Humidifier.BedrockAgentCore.GatewayTargetTypes.ConnectorConfiguration> Configurations { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-connectortargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-connectortargetconfiguration-source
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ConnectorSource
            /// </summary>
            public Humidifier.BedrockAgentCore.GatewayTargetTypes.ConnectorSource Source { get; set; }
        }

        public class CredentialProvider : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// OauthCredentialProvider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-credentialprovider.html#cfn-bedrockagentcore-gatewaytarget-credentialprovider-oauthcredentialprovider
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OAuthCredentialProvider
            /// </summary>
            public Humidifier.BedrockAgentCore.GatewayTargetTypes.OAuthCredentialProvider OauthCredentialProvider { get; set; }
            /// <summary>
            /// IamCredentialProvider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-credentialprovider.html#cfn-bedrockagentcore-gatewaytarget-credentialprovider-iamcredentialprovider
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IamCredentialProvider
            /// </summary>
            public Humidifier.BedrockAgentCore.GatewayTargetTypes.IamCredentialProvider IamCredentialProvider { get; set; }
            /// <summary>
            /// ApiKeyCredentialProvider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-credentialprovider.html#cfn-bedrockagentcore-gatewaytarget-credentialprovider-apikeycredentialprovider
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ApiKeyCredentialProvider
            /// </summary>
            public Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiKeyCredentialProvider ApiKeyCredentialProvider { get; set; }
        }

        public class CredentialProviderConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CredentialProvider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-credentialproviderconfiguration.html#cfn-bedrockagentcore-gatewaytarget-credentialproviderconfiguration-credentialprovider
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CredentialProvider
            /// </summary>
            public Humidifier.BedrockAgentCore.GatewayTargetTypes.CredentialProvider CredentialProvider { get; set; }
            /// <summary>
            /// CredentialProviderType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-credentialproviderconfiguration.html#cfn-bedrockagentcore-gatewaytarget-credentialproviderconfiguration-credentialprovidertype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CredentialProviderType { get; set; }
        }

        public class HttpApiSchemaConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-httpapischemaconfiguration.html#cfn-bedrockagentcore-gatewaytarget-httpapischemaconfiguration-source
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ApiSchemaConfiguration
            /// </summary>
            public Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiSchemaConfiguration Source { get; set; }
        }

        public class HttpConnectorSource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ConnectorId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-httpconnectorsource.html#cfn-bedrockagentcore-gatewaytarget-httpconnectorsource-connectorid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConnectorId { get; set; }
        }

        public class HttpConnectorTargetConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-httpconnectortargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-httpconnectortargetconfiguration-parameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> Parameters { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-httpconnectortargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-httpconnectortargetconfiguration-source
            /// Required: True
            /// UpdateType: Mutable
            /// Type: HttpConnectorSource
            /// </summary>
            public Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpConnectorSource Source { get; set; }
        }

        public class HttpTargetConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Connector
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-httptargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-httptargetconfiguration-connector
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpConnectorTargetConfiguration
            /// </summary>
            public Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpConnectorTargetConfiguration Connector { get; set; }
            /// <summary>
            /// Passthrough
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-httptargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-httptargetconfiguration-passthrough
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PassthroughTargetConfiguration
            /// </summary>
            public Humidifier.BedrockAgentCore.GatewayTargetTypes.PassthroughTargetConfiguration Passthrough { get; set; }
            /// <summary>
            /// AgentcoreRuntime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-httptargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-httptargetconfiguration-agentcoreruntime
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RuntimeTargetConfiguration
            /// </summary>
            public Humidifier.BedrockAgentCore.GatewayTargetTypes.RuntimeTargetConfiguration AgentcoreRuntime { get; set; }
        }

        public class IamCredentialProvider : Humidifier.Base.BaseSubResource, IHaveRegion, IHaveService
        {
            /// <summary>
            /// Service
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-iamcredentialprovider.html#cfn-bedrockagentcore-gatewaytarget-iamcredentialprovider-service
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Service { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-iamcredentialprovider.html#cfn-bedrockagentcore-gatewaytarget-iamcredentialprovider-region
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Region { get; set; }
        }

        public class InferenceConnectorSource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ConnectorId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-inferenceconnectorsource.html#cfn-bedrockagentcore-gatewaytarget-inferenceconnectorsource-connectorid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConnectorId { get; set; }
        }

        public class InferenceConnectorTargetConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-inferenceconnectortargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-inferenceconnectortargetconfiguration-source
            /// Required: True
            /// UpdateType: Mutable
            /// Type: InferenceConnectorSource
            /// </summary>
            public Humidifier.BedrockAgentCore.GatewayTargetTypes.InferenceConnectorSource Source { get; set; }
        }

        public class InferenceOperationConfiguration : Humidifier.Base.BaseSubResource, IHavePath
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-inferenceoperationconfiguration.html#cfn-bedrockagentcore-gatewaytarget-inferenceoperationconfiguration-path
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Path { get; set; }
            /// <summary>
            /// ProviderPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-inferenceoperationconfiguration.html#cfn-bedrockagentcore-gatewaytarget-inferenceoperationconfiguration-providerpath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ProviderPath { get; set; }
            /// <summary>
            /// Models
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-inferenceoperationconfiguration.html#cfn-bedrockagentcore-gatewaytarget-inferenceoperationconfiguration-models
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ModelEntry
            /// </summary>
            public List<Humidifier.BedrockAgentCore.GatewayTargetTypes.ModelEntry> Models { get; set; }
        }

        public class InferenceProviderTargetConfiguration : Humidifier.Base.BaseSubResource, IHaveEndpoint
        {
            /// <summary>
            /// Endpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-inferenceprovidertargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-inferenceprovidertargetconfiguration-endpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Endpoint { get; set; }
            /// <summary>
            /// Operations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-inferenceprovidertargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-inferenceprovidertargetconfiguration-operations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: InferenceOperationConfiguration
            /// </summary>
            public List<Humidifier.BedrockAgentCore.GatewayTargetTypes.InferenceOperationConfiguration> Operations { get; set; }
            /// <summary>
            /// ModelMapping
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-inferenceprovidertargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-inferenceprovidertargetconfiguration-modelmapping
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ModelMapping
            /// </summary>
            public Humidifier.BedrockAgentCore.GatewayTargetTypes.ModelMapping ModelMapping { get; set; }
        }

        public class InferenceTargetConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Connector
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-inferencetargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-inferencetargetconfiguration-connector
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InferenceConnectorTargetConfiguration
            /// </summary>
            public Humidifier.BedrockAgentCore.GatewayTargetTypes.InferenceConnectorTargetConfiguration Connector { get; set; }
            /// <summary>
            /// Provider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-inferencetargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-inferencetargetconfiguration-provider
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InferenceProviderTargetConfiguration
            /// </summary>
            public Humidifier.BedrockAgentCore.GatewayTargetTypes.InferenceProviderTargetConfiguration Provider { get; set; }
        }

        public class ManagedResourceDetails : Humidifier.Base.BaseSubResource, IHaveDomain
        {
            /// <summary>
            /// ResourceGatewayArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-managedresourcedetails.html#cfn-bedrockagentcore-gatewaytarget-managedresourcedetails-resourcegatewayarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResourceGatewayArn { get; set; }
            /// <summary>
            /// ResourceAssociationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-managedresourcedetails.html#cfn-bedrockagentcore-gatewaytarget-managedresourcedetails-resourceassociationarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResourceAssociationArn { get; set; }
            /// <summary>
            /// Domain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-managedresourcedetails.html#cfn-bedrockagentcore-gatewaytarget-managedresourcedetails-domain
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Domain { get; set; }
        }

        public class ManagedVpcResource : Humidifier.Base.BaseSubResource, IHaveSecurityGroupIds, IHaveSubnetIds, IHaveVpcIdentifier
        {
            /// <summary>
            /// RoutingDomain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-managedvpcresource.html#cfn-bedrockagentcore-gatewaytarget-managedvpcresource-routingdomain
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoutingDomain { get; set; }
            /// <summary>
            /// VpcIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-managedvpcresource.html#cfn-bedrockagentcore-gatewaytarget-managedvpcresource-vpcidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VpcIdentifier { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-managedvpcresource.html#cfn-bedrockagentcore-gatewaytarget-managedvpcresource-subnetids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SubnetIds { get; set; }
            /// <summary>
            /// EndpointIpAddressType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-managedvpcresource.html#cfn-bedrockagentcore-gatewaytarget-managedvpcresource-endpointipaddresstype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EndpointIpAddressType { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-managedvpcresource.html#cfn-bedrockagentcore-gatewaytarget-managedvpcresource-securitygroupids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroupIds { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-managedvpcresource.html#cfn-bedrockagentcore-gatewaytarget-managedvpcresource-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> Tags { get; set; }
        }

        public class McpLambdaTargetConfiguration : Humidifier.Base.BaseSubResource, IHaveLambdaArn
        {
            /// <summary>
            /// LambdaArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-mcplambdatargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-mcplambdatargetconfiguration-lambdaarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LambdaArn { get; set; }
            /// <summary>
            /// ToolSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-mcplambdatargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-mcplambdatargetconfiguration-toolschema
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ToolSchema
            /// </summary>
            public Humidifier.BedrockAgentCore.GatewayTargetTypes.ToolSchema ToolSchema { get; set; }
        }

        public class McpServerTargetConfiguration : Humidifier.Base.BaseSubResource, IHaveEndpoint
        {
            /// <summary>
            /// Endpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-mcpservertargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-mcpservertargetconfiguration-endpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Endpoint { get; set; }
            /// <summary>
            /// ListingMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-mcpservertargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-mcpservertargetconfiguration-listingmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ListingMode { get; set; }
            /// <summary>
            /// McpToolSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-mcpservertargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-mcpservertargetconfiguration-mcptoolschema
            /// Required: False
            /// UpdateType: Mutable
            /// Type: McpToolSchemaConfiguration
            /// </summary>
            public Humidifier.BedrockAgentCore.GatewayTargetTypes.McpToolSchemaConfiguration McpToolSchema { get; set; }
            /// <summary>
            /// ResourcePriority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-mcpservertargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-mcpservertargetconfiguration-resourcepriority
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ResourcePriority { get; set; }
        }

        public class McpTargetConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Connector
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-mcptargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-mcptargetconfiguration-connector
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConnectorTargetConfiguration
            /// </summary>
            public Humidifier.BedrockAgentCore.GatewayTargetTypes.ConnectorTargetConfiguration Connector { get; set; }
            /// <summary>
            /// McpServer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-mcptargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-mcptargetconfiguration-mcpserver
            /// Required: False
            /// UpdateType: Mutable
            /// Type: McpServerTargetConfiguration
            /// </summary>
            public Humidifier.BedrockAgentCore.GatewayTargetTypes.McpServerTargetConfiguration McpServer { get; set; }
            /// <summary>
            /// OpenApiSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-mcptargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-mcptargetconfiguration-openapischema
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ApiSchemaConfiguration
            /// </summary>
            public Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiSchemaConfiguration OpenApiSchema { get; set; }
            /// <summary>
            /// SmithyModel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-mcptargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-mcptargetconfiguration-smithymodel
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ApiSchemaConfiguration
            /// </summary>
            public Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiSchemaConfiguration SmithyModel { get; set; }
            /// <summary>
            /// Lambda
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-mcptargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-mcptargetconfiguration-lambda
            /// Required: False
            /// UpdateType: Mutable
            /// Type: McpLambdaTargetConfiguration
            /// </summary>
            public Humidifier.BedrockAgentCore.GatewayTargetTypes.McpLambdaTargetConfiguration Lambda { get; set; }
            /// <summary>
            /// ApiGateway
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-mcptargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-mcptargetconfiguration-apigateway
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ApiGatewayTargetConfiguration
            /// </summary>
            public Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiGatewayTargetConfiguration ApiGateway { get; set; }
        }

        public class McpToolSchemaConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-mcptoolschemaconfiguration.html#cfn-bedrockagentcore-gatewaytarget-mcptoolschemaconfiguration-s3
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Configuration
            /// </summary>
            public Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration S3 { get; set; }
            /// <summary>
            /// InlinePayload
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-mcptoolschemaconfiguration.html#cfn-bedrockagentcore-gatewaytarget-mcptoolschemaconfiguration-inlinepayload
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InlinePayload { get; set; }
        }

        public class MetadataConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AllowedQueryParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-metadataconfiguration.html#cfn-bedrockagentcore-gatewaytarget-metadataconfiguration-allowedqueryparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AllowedQueryParameters { get; set; }
            /// <summary>
            /// AllowedResponseHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-metadataconfiguration.html#cfn-bedrockagentcore-gatewaytarget-metadataconfiguration-allowedresponseheaders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AllowedResponseHeaders { get; set; }
            /// <summary>
            /// AllowedRequestHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-metadataconfiguration.html#cfn-bedrockagentcore-gatewaytarget-metadataconfiguration-allowedrequestheaders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AllowedRequestHeaders { get; set; }
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
            public dynamic Model { get; set; }
        }

        public class ModelMapping : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ProviderPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-modelmapping.html#cfn-bedrockagentcore-gatewaytarget-modelmapping-providerprefix
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ProviderPrefix
            /// </summary>
            public Humidifier.BedrockAgentCore.GatewayTargetTypes.ProviderPrefix ProviderPrefix { get; set; }
        }

        public class OAuth2AuthorizationData : Humidifier.Base.BaseSubResource, IHaveUserId
        {
            /// <summary>
            /// AuthorizationUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-oauth2authorizationdata.html#cfn-bedrockagentcore-gatewaytarget-oauth2authorizationdata-authorizationurl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AuthorizationUrl { get; set; }
            /// <summary>
            /// UserId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-oauth2authorizationdata.html#cfn-bedrockagentcore-gatewaytarget-oauth2authorizationdata-userid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UserId { get; set; }
        }

        public class OAuthCredentialProvider : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DefaultReturnUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-oauthcredentialprovider.html#cfn-bedrockagentcore-gatewaytarget-oauthcredentialprovider-defaultreturnurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DefaultReturnUrl { get; set; }
            /// <summary>
            /// ProviderArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-oauthcredentialprovider.html#cfn-bedrockagentcore-gatewaytarget-oauthcredentialprovider-providerarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ProviderArn { get; set; }
            /// <summary>
            /// Scopes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-oauthcredentialprovider.html#cfn-bedrockagentcore-gatewaytarget-oauthcredentialprovider-scopes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Scopes { get; set; }
            /// <summary>
            /// GrantType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-oauthcredentialprovider.html#cfn-bedrockagentcore-gatewaytarget-oauthcredentialprovider-granttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic GrantType { get; set; }
            /// <summary>
            /// CustomParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-oauthcredentialprovider.html#cfn-bedrockagentcore-gatewaytarget-oauthcredentialprovider-customparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> CustomParameters { get; set; }
        }

        public class PassthroughTargetConfiguration : Humidifier.Base.BaseSubResource, IHaveEndpoint, IHaveProtocolType
        {
            /// <summary>
            /// Endpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-passthroughtargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-passthroughtargetconfiguration-endpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Endpoint { get; set; }
            /// <summary>
            /// ProtocolType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-passthroughtargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-passthroughtargetconfiguration-protocoltype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ProtocolType { get; set; }
            /// <summary>
            /// Schema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-passthroughtargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-passthroughtargetconfiguration-schema
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpApiSchemaConfiguration
            /// </summary>
            public Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpApiSchemaConfiguration Schema { get; set; }
            /// <summary>
            /// StickinessConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-passthroughtargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-passthroughtargetconfiguration-stickinessconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StickinessConfiguration
            /// </summary>
            public Humidifier.BedrockAgentCore.GatewayTargetTypes.StickinessConfiguration StickinessConfiguration { get; set; }
        }

        public class PrivateEndpoint : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ManagedVpcResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-privateendpoint.html#cfn-bedrockagentcore-gatewaytarget-privateendpoint-managedvpcresource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ManagedVpcResource
            /// </summary>
            public Humidifier.BedrockAgentCore.GatewayTargetTypes.ManagedVpcResource ManagedVpcResource { get; set; }
            /// <summary>
            /// SelfManagedLatticeResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-privateendpoint.html#cfn-bedrockagentcore-gatewaytarget-privateendpoint-selfmanagedlatticeresource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SelfManagedLatticeResource
            /// </summary>
            public Humidifier.BedrockAgentCore.GatewayTargetTypes.SelfManagedLatticeResource SelfManagedLatticeResource { get; set; }
        }

        public class ProviderPrefix : Humidifier.Base.BaseSubResource, IHaveSeparator
        {
            /// <summary>
            /// Strip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-providerprefix.html#cfn-bedrockagentcore-gatewaytarget-providerprefix-strip
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Strip { get; set; }
            /// <summary>
            /// Separator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-providerprefix.html#cfn-bedrockagentcore-gatewaytarget-providerprefix-separator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Separator { get; set; }
        }

        public class RuntimeTargetConfiguration : Humidifier.Base.BaseSubResource, IHaveArn, IHaveQualifier
        {
            /// <summary>
            /// Schema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-runtimetargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-runtimetargetconfiguration-schema
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpApiSchemaConfiguration
            /// </summary>
            public Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpApiSchemaConfiguration Schema { get; set; }
            /// <summary>
            /// Qualifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-runtimetargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-runtimetargetconfiguration-qualifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Qualifier { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-runtimetargetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-runtimetargetconfiguration-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
        }

        public class S3Configuration : Humidifier.Base.BaseSubResource, IHaveUri
        {
            /// <summary>
            /// BucketOwnerAccountId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-s3configuration.html#cfn-bedrockagentcore-gatewaytarget-s3configuration-bucketowneraccountid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketOwnerAccountId { get; set; }
            /// <summary>
            /// Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-s3configuration.html#cfn-bedrockagentcore-gatewaytarget-s3configuration-uri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Uri { get; set; }
        }

        public class SchemaDefinition : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveType, IHaveRequired
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-schemadefinition.html#cfn-bedrockagentcore-gatewaytarget-schemadefinition-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Items
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-schemadefinition.html#cfn-bedrockagentcore-gatewaytarget-schemadefinition-items
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SchemaDefinition
            /// </summary>
            public Humidifier.BedrockAgentCore.GatewayTargetTypes.SchemaDefinition Items { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-schemadefinition.html#cfn-bedrockagentcore-gatewaytarget-schemadefinition-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// Required
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-schemadefinition.html#cfn-bedrockagentcore-gatewaytarget-schemadefinition-required
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Required { get; set; }
            /// <summary>
            /// Properties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-schemadefinition.html#cfn-bedrockagentcore-gatewaytarget-schemadefinition-properties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: SchemaDefinition
            /// </summary>
            public Dictionary<string, Humidifier.BedrockAgentCore.GatewayTargetTypes.SchemaDefinition> Properties { get; set; }
        }

        public class SelfManagedLatticeResource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ResourceConfigurationIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-selfmanagedlatticeresource.html#cfn-bedrockagentcore-gatewaytarget-selfmanagedlatticeresource-resourceconfigurationidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResourceConfigurationIdentifier { get; set; }
        }

        public class StickinessConfiguration : Humidifier.Base.BaseSubResource, IHaveTimeout, IHaveIdentifier
        {
            /// <summary>
            /// Identifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-stickinessconfiguration.html#cfn-bedrockagentcore-gatewaytarget-stickinessconfiguration-identifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Identifier { get; set; }
            /// <summary>
            /// Timeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-stickinessconfiguration.html#cfn-bedrockagentcore-gatewaytarget-stickinessconfiguration-timeout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Timeout { get; set; }
        }

        public class TargetConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Inference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-targetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-targetconfiguration-inference
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InferenceTargetConfiguration
            /// </summary>
            public Humidifier.BedrockAgentCore.GatewayTargetTypes.InferenceTargetConfiguration Inference { get; set; }
            /// <summary>
            /// Http
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-targetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-targetconfiguration-http
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpTargetConfiguration
            /// </summary>
            public Humidifier.BedrockAgentCore.GatewayTargetTypes.HttpTargetConfiguration Http { get; set; }
            /// <summary>
            /// Mcp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-targetconfiguration.html#cfn-bedrockagentcore-gatewaytarget-targetconfiguration-mcp
            /// Required: False
            /// UpdateType: Mutable
            /// Type: McpTargetConfiguration
            /// </summary>
            public Humidifier.BedrockAgentCore.GatewayTargetTypes.McpTargetConfiguration Mcp { get; set; }
        }

        public class ToolDefinition : Humidifier.Base.BaseSubResource, IHaveName, IHaveDescription
        {
            /// <summary>
            /// OutputSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-tooldefinition.html#cfn-bedrockagentcore-gatewaytarget-tooldefinition-outputschema
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SchemaDefinition
            /// </summary>
            public Humidifier.BedrockAgentCore.GatewayTargetTypes.SchemaDefinition OutputSchema { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-tooldefinition.html#cfn-bedrockagentcore-gatewaytarget-tooldefinition-description
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// InputSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-tooldefinition.html#cfn-bedrockagentcore-gatewaytarget-tooldefinition-inputschema
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SchemaDefinition
            /// </summary>
            public Humidifier.BedrockAgentCore.GatewayTargetTypes.SchemaDefinition InputSchema { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-tooldefinition.html#cfn-bedrockagentcore-gatewaytarget-tooldefinition-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class ToolSchema : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-toolschema.html#cfn-bedrockagentcore-gatewaytarget-toolschema-s3
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Configuration
            /// </summary>
            public Humidifier.BedrockAgentCore.GatewayTargetTypes.S3Configuration S3 { get; set; }
            /// <summary>
            /// InlinePayload
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-gatewaytarget-toolschema.html#cfn-bedrockagentcore-gatewaytarget-toolschema-inlinepayload
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ToolDefinition
            /// </summary>
            public List<Humidifier.BedrockAgentCore.GatewayTargetTypes.ToolDefinition> InlinePayload { get; set; }
        }
    }
}