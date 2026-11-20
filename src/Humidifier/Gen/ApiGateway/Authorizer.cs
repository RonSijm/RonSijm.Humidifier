namespace Humidifier.ApiGateway
{
    using global::System.Collections.Generic;
    using AuthorizerTypes;

    public class Authorizer : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveType, IHaveAuthType, IHaveRestApiId, IHaveIdentityValidationExpression, IHaveAuthorizerUri, IHaveAuthorizerResultTtlInSeconds, IHaveIdentitySource
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
        public dynamic ProviderARNs { get; set; }
        /// <summary>
        /// AuthorizerCredentials
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-authorizer.html#cfn-apigateway-authorizer-authorizercredentials
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AuthorizerCredentials { get; set; }
        /// <summary>
        /// IdentityValidationExpression
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-authorizer.html#cfn-apigateway-authorizer-identityvalidationexpression
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic IdentityValidationExpression { get; set; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-authorizer.html#cfn-apigateway-authorizer-type
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Type { get; set; }
        /// <summary>
        /// AuthorizerUri
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-authorizer.html#cfn-apigateway-authorizer-authorizeruri
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AuthorizerUri { get; set; }
        /// <summary>
        /// JwtConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-authorizer.html#cfn-apigateway-authorizer-jwtconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: JwtConfiguration
        /// </summary>
        public Humidifier.ApiGateway.AuthorizerTypes.JwtConfiguration JwtConfiguration { get; set; }
        /// <summary>
        /// AuthorizerResultTtlInSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-authorizer.html#cfn-apigateway-authorizer-authorizerresultttlinseconds
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic AuthorizerResultTtlInSeconds { get; set; }

        /// <summary>
        /// RestApiId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-authorizer.html#cfn-apigateway-authorizer-restapiid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RestApiId { get; set; }
        /// <summary>
        /// IdentitySource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-authorizer.html#cfn-apigateway-authorizer-identitysource
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic IdentitySource { get; set; }
        /// <summary>
        /// AuthType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-authorizer.html#cfn-apigateway-authorizer-authtype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AuthType { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace AuthorizerTypes
    {
        public class JwtAdditionalClaim : Humidifier.Base.BaseSubResource, IHaveFormat, IHaveRequired
        {
            /// <summary>
            /// ClaimName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-authorizer-jwtadditionalclaim.html#cfn-apigateway-authorizer-jwtadditionalclaim-claimname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClaimName { get; set; }
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-authorizer-jwtadditionalclaim.html#cfn-apigateway-authorizer-jwtadditionalclaim-format
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Format { get; set; }
            /// <summary>
            /// Required
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-authorizer-jwtadditionalclaim.html#cfn-apigateway-authorizer-jwtadditionalclaim-required
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Required { get; set; }
            /// <summary>
            /// ExpectedValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-authorizer-jwtadditionalclaim.html#cfn-apigateway-authorizer-jwtadditionalclaim-expectedvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ExpectedValues { get; set; }
        }

        public class JwtConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Issuers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-authorizer-jwtconfiguration.html#cfn-apigateway-authorizer-jwtconfiguration-issuers
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: JwtIssuer
            /// </summary>
            public List<Humidifier.ApiGateway.AuthorizerTypes.JwtIssuer> Issuers { get; set; }
            /// <summary>
            /// DefaultAlgorithms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-authorizer-jwtconfiguration.html#cfn-apigateway-authorizer-jwtconfiguration-defaultalgorithms
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic DefaultAlgorithms { get; set; }
        }

        public class JwtIssuer : Humidifier.Base.BaseSubResource, IHaveIssuer, IHaveAudiences
        {
            /// <summary>
            /// Issuer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-authorizer-jwtissuer.html#cfn-apigateway-authorizer-jwtissuer-issuer
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Issuer { get; set; }
            /// <summary>
            /// Audiences
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-authorizer-jwtissuer.html#cfn-apigateway-authorizer-jwtissuer-audiences
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Audiences { get; set; }
            /// <summary>
            /// AdditionalClaims
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-authorizer-jwtissuer.html#cfn-apigateway-authorizer-jwtissuer-additionalclaims
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: JwtAdditionalClaim
            /// </summary>
            public List<Humidifier.ApiGateway.AuthorizerTypes.JwtAdditionalClaim> AdditionalClaims { get; set; }
        }
    }
}