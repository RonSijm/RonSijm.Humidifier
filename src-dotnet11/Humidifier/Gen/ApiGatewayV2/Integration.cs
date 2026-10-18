namespace Humidifier.ApiGatewayV2
{
    using global::System.Collections.Generic;
    using IntegrationTypes;

    public class Integration : Humidifier.Base.BaseResource, IHaveDescription, IHaveTemplateSelectionExpression, IHaveConnectionType, IHaveMapOfApiGatewayV2IntegrationTypesResponseParameterMapResponseParameters, IHaveIntegrationMethod, IHavePassthroughBehavior, IHaveStringDictionaryOfRequestParameters, IHaveConnectionId, IHaveIntegrationUri, IHavePayloadFormatVersion, IHaveCredentialsArn, IHaveStringDictionaryOfRequestTemplates, IHaveTimeoutInMillis_Integer, IHaveApiGatewayV2IntegrationTypesTlsConfigTlsConfig, IHaveContentHandlingStrategy, IHaveIntegrationSubtype, IHaveApiId, IHaveIntegrationType
    {
        public class Attributes
        {
            public static string IntegrationId =  "IntegrationId" ;
        }

        public override string AWSTypeName { get => AWS.ApiGatewayV2.Integration; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-integration.html#cfn-apigatewayv2-integration-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// TemplateSelectionExpression
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-integration.html#cfn-apigatewayv2-integration-templateselectionexpression
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TemplateSelectionExpression { get; set; }
        /// <summary>
        /// ConnectionType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-integration.html#cfn-apigatewayv2-integration-connectiontype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ConnectionType { get; set; }
        /// <summary>
        /// ResponseParameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-integration.html#cfn-apigatewayv2-integration-responseparameters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// ItemType: ResponseParameterMap
        /// </summary>
        public Union<IReadOnlyDictionary<string, Humidifier.ApiGatewayV2.IntegrationTypes.ResponseParameterMap>, IReadOnlyDictionary<string, Union<Humidifier.ApiGatewayV2.IntegrationTypes.ResponseParameterMap, BaseFunction>>, BaseFunction>? ResponseParameters { get; set; }
        /// <summary>
        /// IntegrationMethod
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-integration.html#cfn-apigatewayv2-integration-integrationmethod
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? IntegrationMethod { get; set; }
        /// <summary>
        /// PassthroughBehavior
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-integration.html#cfn-apigatewayv2-integration-passthroughbehavior
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PassthroughBehavior { get; set; }
        /// <summary>
        /// RequestParameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-integration.html#cfn-apigatewayv2-integration-requestparameters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? RequestParameters { get; set; }
        /// <summary>
        /// ConnectionId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-integration.html#cfn-apigatewayv2-integration-connectionid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ConnectionId { get; set; }
        /// <summary>
        /// IntegrationUri
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-integration.html#cfn-apigatewayv2-integration-integrationuri
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? IntegrationUri { get; set; }
        /// <summary>
        /// PayloadFormatVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-integration.html#cfn-apigatewayv2-integration-payloadformatversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PayloadFormatVersion { get; set; }
        /// <summary>
        /// CredentialsArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-integration.html#cfn-apigatewayv2-integration-credentialsarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CredentialsArn { get; set; }
        /// <summary>
        /// RequestTemplates
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-integration.html#cfn-apigatewayv2-integration-requesttemplates
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? RequestTemplates { get; set; }
        /// <summary>
        /// TimeoutInMillis
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-integration.html#cfn-apigatewayv2-integration-timeoutinmillis
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? TimeoutInMillis { get; set; }
        /// <summary>
        /// TlsConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-integration.html#cfn-apigatewayv2-integration-tlsconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TlsConfig
        /// </summary>
        public Union<Humidifier.ApiGatewayV2.IntegrationTypes.TlsConfig, BaseFunction>? TlsConfig { get; set; }
        /// <summary>
        /// ContentHandlingStrategy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-integration.html#cfn-apigatewayv2-integration-contenthandlingstrategy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ContentHandlingStrategy { get; set; }
        /// <summary>
        /// IntegrationSubtype
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-integration.html#cfn-apigatewayv2-integration-integrationsubtype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? IntegrationSubtype { get; set; }

        /// <summary>
        /// ApiId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-integration.html#cfn-apigatewayv2-integration-apiid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ApiId { get; set; }

        /// <summary>
        /// IntegrationType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-integration.html#cfn-apigatewayv2-integration-integrationtype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? IntegrationType { get; set; }
    }

    namespace IntegrationTypes
    {
        public class ResponseParameter : Humidifier.Base.BaseSubResource, IHaveDestination, IHaveSource
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-integration-responseparameter.html#cfn-apigatewayv2-integration-responseparameter-destination
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Destination { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-integration-responseparameter.html#cfn-apigatewayv2-integration-responseparameter-source
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Source { get; set; }
        }

        public class ResponseParameterMap : Humidifier.Base.BaseSubResource, IHaveListOfApiGatewayV2IntegrationTypesResponseParameterResponseParameters
        {
            /// <summary>
            /// ResponseParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-integration-responseparametermap.html#cfn-apigatewayv2-integration-responseparametermap-responseparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ResponseParameter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ApiGatewayV2.IntegrationTypes.ResponseParameter>, IReadOnlyList<Union<Humidifier.ApiGatewayV2.IntegrationTypes.ResponseParameter, BaseFunction>>, BaseFunction>? ResponseParameters { get; set; }
        }

        public class TlsConfig : Humidifier.Base.BaseSubResource, IHaveServerNameToVerify
        {
            /// <summary>
            /// ServerNameToVerify
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-integration-tlsconfig.html#cfn-apigatewayv2-integration-tlsconfig-servernametoverify
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServerNameToVerify { get; set; }
        }
    }
}