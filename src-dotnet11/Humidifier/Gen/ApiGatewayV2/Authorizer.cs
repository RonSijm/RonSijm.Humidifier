namespace Humidifier.ApiGatewayV2
{
    using global::System.Collections.Generic;
    using AuthorizerTypes;

    public class Authorizer : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveIdentityValidationExpression, IHaveAuthorizerUri, IHaveAuthorizerCredentialsArn, IHaveAuthorizerType, IHaveApiGatewayV2AuthorizerTypesJWTConfigurationJwtConfiguration, IHaveAuthorizerResultTtlInSeconds_Integer, IHaveStringListOfIdentitySource, IHaveAuthorizerPayloadFormatVersion, IHaveEnableSimpleResponses_Boolean, IHaveApiId, IHaveName
    {
        public class Attributes
        {
            public static string AuthorizerId =  "AuthorizerId" ;
        }

        public override string AWSTypeName { get => AWS.ApiGatewayV2.Authorizer; }
        /// <summary>
        /// IdentityValidationExpression
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-authorizer.html#cfn-apigatewayv2-authorizer-identityvalidationexpression
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? IdentityValidationExpression { get; set; }
        /// <summary>
        /// AuthorizerUri
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-authorizer.html#cfn-apigatewayv2-authorizer-authorizeruri
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AuthorizerUri { get; set; }
        /// <summary>
        /// AuthorizerCredentialsArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-authorizer.html#cfn-apigatewayv2-authorizer-authorizercredentialsarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AuthorizerCredentialsArn { get; set; }

        /// <summary>
        /// AuthorizerType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-authorizer.html#cfn-apigatewayv2-authorizer-authorizertype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AuthorizerType { get; set; }
        /// <summary>
        /// JwtConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-authorizer.html#cfn-apigatewayv2-authorizer-jwtconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: JWTConfiguration
        /// </summary>
        public Union<Humidifier.ApiGatewayV2.AuthorizerTypes.JWTConfiguration, BaseFunction>? JwtConfiguration { get; set; }
        /// <summary>
        /// AuthorizerResultTtlInSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-authorizer.html#cfn-apigatewayv2-authorizer-authorizerresultttlinseconds
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? AuthorizerResultTtlInSeconds { get; set; }
        /// <summary>
        /// IdentitySource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-authorizer.html#cfn-apigatewayv2-authorizer-identitysource
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? IdentitySource { get; set; }
        /// <summary>
        /// AuthorizerPayloadFormatVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-authorizer.html#cfn-apigatewayv2-authorizer-authorizerpayloadformatversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AuthorizerPayloadFormatVersion { get; set; }
        /// <summary>
        /// EnableSimpleResponses
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-authorizer.html#cfn-apigatewayv2-authorizer-enablesimpleresponses
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? EnableSimpleResponses { get; set; }

        /// <summary>
        /// ApiId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-authorizer.html#cfn-apigatewayv2-authorizer-apiid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ApiId { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace AuthorizerTypes
    {
        public class JWTConfiguration : Humidifier.Base.BaseSubResource, IHaveIssuer, IHaveStringListOfAudience
        {
            /// <summary>
            /// Issuer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-authorizer-jwtconfiguration.html#cfn-apigatewayv2-authorizer-jwtconfiguration-issuer
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Issuer { get; set; }
            /// <summary>
            /// Audience
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-authorizer-jwtconfiguration.html#cfn-apigatewayv2-authorizer-jwtconfiguration-audience
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Audience { get; set; }
        }
    }
}