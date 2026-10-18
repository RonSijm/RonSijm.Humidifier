namespace Humidifier.BedrockAgentCore
{
    using global::System.Collections.Generic;
    using PaymentManagerTypes;

    public class PaymentManager : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveAuthorizerType, IHaveRoleArn, IHaveName, IHaveBedrockAgentCorePaymentManagerTypesAuthorizerConfigurationAuthorizerConfiguration
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string LastUpdatedAt =  "LastUpdatedAt" ;
            public static string PaymentManagerArn =  "PaymentManagerArn" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string PaymentManagerId =  "PaymentManagerId" ;
            public static string WorkloadIdentityDetails =  "WorkloadIdentityDetails" ;
        }

        public override string AWSTypeName { get => AWS.BedrockAgentCore.PaymentManager; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-paymentmanager.html#cfn-bedrockagentcore-paymentmanager-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// AuthorizerType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-paymentmanager.html#cfn-bedrockagentcore-paymentmanager-authorizertype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AuthorizerType { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-paymentmanager.html#cfn-bedrockagentcore-paymentmanager-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-paymentmanager.html#cfn-bedrockagentcore-paymentmanager-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// AuthorizerConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-paymentmanager.html#cfn-bedrockagentcore-paymentmanager-authorizerconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: AuthorizerConfiguration
        /// </summary>
        public Union<Humidifier.BedrockAgentCore.PaymentManagerTypes.AuthorizerConfiguration, BaseFunction>? AuthorizerConfiguration { get; set; }
    }

    namespace PaymentManagerTypes
    {
        public class AuthorizerConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCorePaymentManagerTypesCustomJWTAuthorizerConfigurationCustomJWTAuthorizer
        {
            /// <summary>
            /// CustomJWTAuthorizer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentmanager-authorizerconfiguration.html#cfn-bedrockagentcore-paymentmanager-authorizerconfiguration-customjwtauthorizer
            /// Required: True
            /// UpdateType: Immutable
            /// Type: CustomJWTAuthorizerConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.PaymentManagerTypes.CustomJWTAuthorizerConfiguration, BaseFunction>? CustomJWTAuthorizer { get; set; }
        }

        public class AuthorizingClaimMatchValueType : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCorePaymentManagerTypesClaimMatchValueTypeClaimMatchValue, IHaveClaimMatchOperator
        {
            /// <summary>
            /// ClaimMatchValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentmanager-authorizingclaimmatchvaluetype.html#cfn-bedrockagentcore-paymentmanager-authorizingclaimmatchvaluetype-claimmatchvalue
            /// Required: True
            /// UpdateType: Immutable
            /// Type: ClaimMatchValueType
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.PaymentManagerTypes.ClaimMatchValueType, BaseFunction>? ClaimMatchValue { get; set; }
            /// <summary>
            /// ClaimMatchOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentmanager-authorizingclaimmatchvaluetype.html#cfn-bedrockagentcore-paymentmanager-authorizingclaimmatchvaluetype-claimmatchoperator
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClaimMatchOperator { get; set; }
        }

        public class ClaimMatchValueType : Humidifier.Base.BaseSubResource, IHaveMatchValueString, IHaveStringListOfMatchValueStringList
        {
            /// <summary>
            /// MatchValueString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentmanager-claimmatchvaluetype.html#cfn-bedrockagentcore-paymentmanager-claimmatchvaluetype-matchvaluestring
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MatchValueString { get; set; }
            /// <summary>
            /// MatchValueStringList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentmanager-claimmatchvaluetype.html#cfn-bedrockagentcore-paymentmanager-claimmatchvaluetype-matchvaluestringlist
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? MatchValueStringList { get; set; }
        }

        public class CustomClaimValidationType : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCorePaymentManagerTypesAuthorizingClaimMatchValueTypeAuthorizingClaimMatchValue, IHaveInboundTokenClaimName, IHaveInboundTokenClaimValueType
        {
            /// <summary>
            /// AuthorizingClaimMatchValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentmanager-customclaimvalidationtype.html#cfn-bedrockagentcore-paymentmanager-customclaimvalidationtype-authorizingclaimmatchvalue
            /// Required: True
            /// UpdateType: Immutable
            /// Type: AuthorizingClaimMatchValueType
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.PaymentManagerTypes.AuthorizingClaimMatchValueType, BaseFunction>? AuthorizingClaimMatchValue { get; set; }
            /// <summary>
            /// InboundTokenClaimName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentmanager-customclaimvalidationtype.html#cfn-bedrockagentcore-paymentmanager-customclaimvalidationtype-inboundtokenclaimname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InboundTokenClaimName { get; set; }
            /// <summary>
            /// InboundTokenClaimValueType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentmanager-customclaimvalidationtype.html#cfn-bedrockagentcore-paymentmanager-customclaimvalidationtype-inboundtokenclaimvaluetype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InboundTokenClaimValueType { get; set; }
        }

        public class CustomJWTAuthorizerConfiguration : Humidifier.Base.BaseSubResource, IHaveDiscoveryUrl, IHaveStringListOfAllowedAudience, IHaveListOfBedrockAgentCorePaymentManagerTypesCustomClaimValidationTypeCustomClaims, IHaveStringListOfAllowedClients, IHaveStringListOfAllowedScopes
        {
            /// <summary>
            /// DiscoveryUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentmanager-customjwtauthorizerconfiguration.html#cfn-bedrockagentcore-paymentmanager-customjwtauthorizerconfiguration-discoveryurl
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DiscoveryUrl { get; set; }
            /// <summary>
            /// AllowedAudience
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentmanager-customjwtauthorizerconfiguration.html#cfn-bedrockagentcore-paymentmanager-customjwtauthorizerconfiguration-allowedaudience
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedAudience { get; set; }
            /// <summary>
            /// CustomClaims
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentmanager-customjwtauthorizerconfiguration.html#cfn-bedrockagentcore-paymentmanager-customjwtauthorizerconfiguration-customclaims
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: CustomClaimValidationType
            /// </summary>
            public Union<IReadOnlyList<Humidifier.BedrockAgentCore.PaymentManagerTypes.CustomClaimValidationType>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.PaymentManagerTypes.CustomClaimValidationType, BaseFunction>>, BaseFunction>? CustomClaims { get; set; }
            /// <summary>
            /// AllowedClients
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentmanager-customjwtauthorizerconfiguration.html#cfn-bedrockagentcore-paymentmanager-customjwtauthorizerconfiguration-allowedclients
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedClients { get; set; }
            /// <summary>
            /// AllowedScopes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentmanager-customjwtauthorizerconfiguration.html#cfn-bedrockagentcore-paymentmanager-customjwtauthorizerconfiguration-allowedscopes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedScopes { get; set; }
        }

        public class WorkloadIdentityDetails : Humidifier.Base.BaseSubResource, IHaveWorkloadIdentityArn
        {
            /// <summary>
            /// WorkloadIdentityArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentmanager-workloadidentitydetails.html#cfn-bedrockagentcore-paymentmanager-workloadidentitydetails-workloadidentityarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WorkloadIdentityArn { get; set; }
        }
    }
}