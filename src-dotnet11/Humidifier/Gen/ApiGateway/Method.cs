namespace Humidifier.ApiGateway
{
    using global::System.Collections.Generic;
    using MethodTypes;

    public class Method : Humidifier.Base.BaseResource, IHaveApiGatewayMethodTypesIntegrationIntegration, IHaveOperationName, IHaveStringDictionaryOfRequestModels, IHaveRestApiId, IHaveStringListOfAuthorizationScopes, IHaveRequestValidatorId, IHaveStringDictionaryOfRequestParameters, IHaveListOfApiGatewayMethodTypesMethodResponseMethodResponses, IHaveAuthorizerId, IHaveResourceId, IHaveApiKeyRequired_Boolean, IHaveAuthorizationType, IHaveHttpMethod
    {
        public override string AWSTypeName { get => AWS.ApiGateway.Method; }
        /// <summary>
        /// Integration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-method.html#cfn-apigateway-method-integration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Integration
        /// </summary>
        public Union<Humidifier.ApiGateway.MethodTypes.Integration, BaseFunction>? Integration { get; set; }
        /// <summary>
        /// OperationName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-method.html#cfn-apigateway-method-operationname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? OperationName { get; set; }
        /// <summary>
        /// RequestModels
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-method.html#cfn-apigateway-method-requestmodels
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? RequestModels { get; set; }

        /// <summary>
        /// RestApiId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-method.html#cfn-apigateway-method-restapiid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RestApiId { get; set; }
        /// <summary>
        /// AuthorizationScopes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-method.html#cfn-apigateway-method-authorizationscopes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AuthorizationScopes { get; set; }
        /// <summary>
        /// RequestValidatorId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-method.html#cfn-apigateway-method-requestvalidatorid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RequestValidatorId { get; set; }
        /// <summary>
        /// RequestParameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-method.html#cfn-apigateway-method-requestparameters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? RequestParameters { get; set; }
        /// <summary>
        /// MethodResponses
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-method.html#cfn-apigateway-method-methodresponses
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: MethodResponse
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ApiGateway.MethodTypes.MethodResponse>, IReadOnlyList<Union<Humidifier.ApiGateway.MethodTypes.MethodResponse, BaseFunction>>, BaseFunction>? MethodResponses { get; set; }
        /// <summary>
        /// AuthorizerId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-method.html#cfn-apigateway-method-authorizerid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AuthorizerId { get; set; }

        /// <summary>
        /// ResourceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-method.html#cfn-apigateway-method-resourceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ResourceId { get; set; }
        /// <summary>
        /// ApiKeyRequired
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-method.html#cfn-apigateway-method-apikeyrequired
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? ApiKeyRequired { get; set; }
        /// <summary>
        /// AuthorizationType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-method.html#cfn-apigateway-method-authorizationtype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AuthorizationType { get; set; }

        /// <summary>
        /// HttpMethod
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-method.html#cfn-apigateway-method-httpmethod
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? HttpMethod { get; set; }
    }

    namespace MethodTypes
    {
        public class Integration : Humidifier.Base.BaseSubResource, IHaveCacheNamespace, IHaveConnectionType, IHaveListOfApiGatewayMethodTypesIntegrationResponseIntegrationResponses, IHaveIntegrationHttpMethod, IHaveResponseTransferMode, IHaveUri, IHavePassthroughBehavior, IHaveStringDictionaryOfRequestParameters, IHaveConnectionId, IHaveType, IHaveStringListOfCacheKeyParameters, IHaveIntegrationTarget, IHaveContentHandling, IHaveStringDictionaryOfRequestTemplates, IHaveTimeoutInMillis_Integer, IHaveCredentials
        {
            /// <summary>
            /// CacheNamespace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-method-integration.html#cfn-apigateway-method-integration-cachenamespace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CacheNamespace { get; set; }
            /// <summary>
            /// ConnectionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-method-integration.html#cfn-apigateway-method-integration-connectiontype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectionType { get; set; }
            /// <summary>
            /// IntegrationResponses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-method-integration.html#cfn-apigateway-method-integration-integrationresponses
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: IntegrationResponse
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ApiGateway.MethodTypes.IntegrationResponse>, IReadOnlyList<Union<Humidifier.ApiGateway.MethodTypes.IntegrationResponse, BaseFunction>>, BaseFunction>? IntegrationResponses { get; set; }
            /// <summary>
            /// IntegrationHttpMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-method-integration.html#cfn-apigateway-method-integration-integrationhttpmethod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IntegrationHttpMethod { get; set; }
            /// <summary>
            /// ResponseTransferMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-method-integration.html#cfn-apigateway-method-integration-responsetransfermode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResponseTransferMode { get; set; }
            /// <summary>
            /// Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-method-integration.html#cfn-apigateway-method-integration-uri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Uri { get; set; }
            /// <summary>
            /// PassthroughBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-method-integration.html#cfn-apigateway-method-integration-passthroughbehavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PassthroughBehavior { get; set; }
            /// <summary>
            /// RequestParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-method-integration.html#cfn-apigateway-method-integration-requestparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? RequestParameters { get; set; }
            /// <summary>
            /// ConnectionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-method-integration.html#cfn-apigateway-method-integration-connectionid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectionId { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-method-integration.html#cfn-apigateway-method-integration-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// CacheKeyParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-method-integration.html#cfn-apigateway-method-integration-cachekeyparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CacheKeyParameters { get; set; }
            /// <summary>
            /// IntegrationTarget
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-method-integration.html#cfn-apigateway-method-integration-integrationtarget
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IntegrationTarget { get; set; }
            /// <summary>
            /// ContentHandling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-method-integration.html#cfn-apigateway-method-integration-contenthandling
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContentHandling { get; set; }
            /// <summary>
            /// RequestTemplates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-method-integration.html#cfn-apigateway-method-integration-requesttemplates
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? RequestTemplates { get; set; }
            /// <summary>
            /// TimeoutInMillis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-method-integration.html#cfn-apigateway-method-integration-timeoutinmillis
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimeoutInMillis { get; set; }
            /// <summary>
            /// Credentials
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-method-integration.html#cfn-apigateway-method-integration-credentials
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Credentials { get; set; }
        }

        public class IntegrationResponse : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfResponseTemplates, IHaveSelectionPattern, IHaveContentHandling, IHaveStringDictionaryOfResponseParameters, IHaveStatusCode
        {
            /// <summary>
            /// ResponseTemplates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-method-integrationresponse.html#cfn-apigateway-method-integrationresponse-responsetemplates
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? ResponseTemplates { get; set; }
            /// <summary>
            /// SelectionPattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-method-integrationresponse.html#cfn-apigateway-method-integrationresponse-selectionpattern
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SelectionPattern { get; set; }
            /// <summary>
            /// ContentHandling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-method-integrationresponse.html#cfn-apigateway-method-integrationresponse-contenthandling
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContentHandling { get; set; }
            /// <summary>
            /// ResponseParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-method-integrationresponse.html#cfn-apigateway-method-integrationresponse-responseparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? ResponseParameters { get; set; }
            /// <summary>
            /// StatusCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-method-integrationresponse.html#cfn-apigateway-method-integrationresponse-statuscode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StatusCode { get; set; }
        }

        public class MethodResponse : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfResponseParameters, IHaveStatusCode, IHaveStringDictionaryOfResponseModels
        {
            /// <summary>
            /// ResponseParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-method-methodresponse.html#cfn-apigateway-method-methodresponse-responseparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? ResponseParameters { get; set; }
            /// <summary>
            /// StatusCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-method-methodresponse.html#cfn-apigateway-method-methodresponse-statuscode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StatusCode { get; set; }
            /// <summary>
            /// ResponseModels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-method-methodresponse.html#cfn-apigateway-method-methodresponse-responsemodels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? ResponseModels { get; set; }
        }
    }
}