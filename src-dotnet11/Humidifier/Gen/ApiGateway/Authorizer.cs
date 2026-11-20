namespace Humidifier.ApiGateway
{
    using global::System.Collections.Generic;
    using AuthorizerTypes;

    public class Authorizer : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveStringListOfProviderARNs, IHaveAuthorizerCredentials, IHaveIdentityValidationExpression, IHaveType, IHaveAuthorizerUri, IHaveApiGatewayAuthorizerTypesJwtConfigurationJwtConfiguration, IHaveAuthorizerResultTtlInSeconds_Integer, IHaveRestApiId, IHaveIdentitySource, IHaveAuthType, IHaveName
    {
        public class Attributes
        {
            public static string AuthorizerId =  "AuthorizerId" ;
        }

        public override string AWSTypeName { get => AWS.ApiGateway.Authorizer; }
        /// <summary>
        /// ProviderARNs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-authorizer.html#cfn-apigateway-authorizer-providerarns
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ProviderARNs { get; set; }
        /// <summary>
        /// AuthorizerCredentials
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-authorizer.html#cfn-apigateway-authorizer-authorizercredentials
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AuthorizerCredentials { get; set; }
        /// <summary>
        /// IdentityValidationExpression
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-authorizer.html#cfn-apigateway-authorizer-identityvalidationexpression
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? IdentityValidationExpression { get; set; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-authorizer.html#cfn-apigateway-authorizer-type
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Type { get; set; }
        /// <summary>
        /// AuthorizerUri
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-authorizer.html#cfn-apigateway-authorizer-authorizeruri
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AuthorizerUri { get; set; }
        /// <summary>
        /// JwtConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-authorizer.html#cfn-apigateway-authorizer-jwtconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: JwtConfiguration
        /// </summary>
        public Union<Humidifier.ApiGateway.AuthorizerTypes.JwtConfiguration, BaseFunction>? JwtConfiguration { get; set; }
        /// <summary>
        /// AuthorizerResultTtlInSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-authorizer.html#cfn-apigateway-authorizer-authorizerresultttlinseconds
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? AuthorizerResultTtlInSeconds { get; set; }

        /// <summary>
        /// RestApiId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-authorizer.html#cfn-apigateway-authorizer-restapiid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RestApiId { get; set; }
        /// <summary>
        /// IdentitySource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-authorizer.html#cfn-apigateway-authorizer-identitysource
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? IdentitySource { get; set; }
        /// <summary>
        /// AuthType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-authorizer.html#cfn-apigateway-authorizer-authtype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AuthType { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace AuthorizerTypes
    {
        public class JwtAdditionalClaim : Humidifier.Base.BaseSubResource, IHaveClaimName, IHaveFormat, IHaveRequired_Boolean, IHaveStringListOfExpectedValues
        {
            /// <summary>
            /// ClaimName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-authorizer-jwtadditionalclaim.html#cfn-apigateway-authorizer-jwtadditionalclaim-claimname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClaimName { get; set; }
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-authorizer-jwtadditionalclaim.html#cfn-apigateway-authorizer-jwtadditionalclaim-format
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Format { get; set; }
            /// <summary>
            /// Required
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-authorizer-jwtadditionalclaim.html#cfn-apigateway-authorizer-jwtadditionalclaim-required
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Required { get; set; }
            /// <summary>
            /// ExpectedValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-authorizer-jwtadditionalclaim.html#cfn-apigateway-authorizer-jwtadditionalclaim-expectedvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ExpectedValues { get; set; }
        }

        public class JwtConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfApiGatewayAuthorizerTypesJwtIssuerIssuers, IHaveStringListOfDefaultAlgorithms
        {
            /// <summary>
            /// Issuers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-authorizer-jwtconfiguration.html#cfn-apigateway-authorizer-jwtconfiguration-issuers
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: JwtIssuer
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ApiGateway.AuthorizerTypes.JwtIssuer>, IReadOnlyList<Union<Humidifier.ApiGateway.AuthorizerTypes.JwtIssuer, BaseFunction>>, BaseFunction>? Issuers { get; set; }
            /// <summary>
            /// DefaultAlgorithms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-authorizer-jwtconfiguration.html#cfn-apigateway-authorizer-jwtconfiguration-defaultalgorithms
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DefaultAlgorithms { get; set; }
        }

        public class JwtIssuer : Humidifier.Base.BaseSubResource, IHaveIssuer, IHaveStringListOfAudiences, IHaveListOfApiGatewayAuthorizerTypesJwtAdditionalClaimAdditionalClaims
        {
            /// <summary>
            /// Issuer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-authorizer-jwtissuer.html#cfn-apigateway-authorizer-jwtissuer-issuer
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Issuer { get; set; }
            /// <summary>
            /// Audiences
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-authorizer-jwtissuer.html#cfn-apigateway-authorizer-jwtissuer-audiences
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Audiences { get; set; }
            /// <summary>
            /// AdditionalClaims
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-authorizer-jwtissuer.html#cfn-apigateway-authorizer-jwtissuer-additionalclaims
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: JwtAdditionalClaim
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ApiGateway.AuthorizerTypes.JwtAdditionalClaim>, IReadOnlyList<Union<Humidifier.ApiGateway.AuthorizerTypes.JwtAdditionalClaim, BaseFunction>>, BaseFunction>? AdditionalClaims { get; set; }
        }
    }
}