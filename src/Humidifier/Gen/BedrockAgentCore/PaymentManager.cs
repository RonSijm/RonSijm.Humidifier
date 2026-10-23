namespace Humidifier.BedrockAgentCore
{
    using global::System.Collections.Generic;
    using PaymentManagerTypes;

    public class PaymentManager : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription, IHaveRoleArn
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
        public dynamic Description { get; set; }

        /// <summary>
        /// AuthorizerType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-paymentmanager.html#cfn-bedrockagentcore-paymentmanager-authorizertype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AuthorizerType { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-paymentmanager.html#cfn-bedrockagentcore-paymentmanager-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-paymentmanager.html#cfn-bedrockagentcore-paymentmanager-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// AuthorizerConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-paymentmanager.html#cfn-bedrockagentcore-paymentmanager-authorizerconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: AuthorizerConfiguration
        /// </summary>
        public Humidifier.BedrockAgentCore.PaymentManagerTypes.AuthorizerConfiguration AuthorizerConfiguration { get; set; }
    }

    namespace PaymentManagerTypes
    {
        public class AuthorizerConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CustomJWTAuthorizer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentmanager-authorizerconfiguration.html#cfn-bedrockagentcore-paymentmanager-authorizerconfiguration-customjwtauthorizer
            /// Required: True
            /// UpdateType: Immutable
            /// Type: CustomJWTAuthorizer
            /// </summary>
            public Humidifier.BedrockAgentCore.PaymentManagerTypes.CustomJWTAuthorizer CustomJWTAuthorizer { get; set; }
        }

        public class AuthorizingClaimMatchValue : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ClaimMatchValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentmanager-authorizingclaimmatchvalue.html#cfn-bedrockagentcore-paymentmanager-authorizingclaimmatchvalue-claimmatchvalue
            /// Required: True
            /// UpdateType: Immutable
            /// Type: ClaimMatchValue
            /// </summary>
            public Humidifier.BedrockAgentCore.PaymentManagerTypes.ClaimMatchValue ClaimMatchValue { get; set; }
            /// <summary>
            /// ClaimMatchOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentmanager-authorizingclaimmatchvalue.html#cfn-bedrockagentcore-paymentmanager-authorizingclaimmatchvalue-claimmatchoperator
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClaimMatchOperator { get; set; }
        }

        public class ClaimMatchValue : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MatchValueString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentmanager-claimmatchvalue.html#cfn-bedrockagentcore-paymentmanager-claimmatchvalue-matchvaluestring
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MatchValueString { get; set; }
            /// <summary>
            /// MatchValueStringList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentmanager-claimmatchvalue.html#cfn-bedrockagentcore-paymentmanager-claimmatchvalue-matchvaluestringlist
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic MatchValueStringList { get; set; }
        }

        public class CustomClaimValidationType : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AuthorizingClaimMatchValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentmanager-customclaimvalidationtype.html#cfn-bedrockagentcore-paymentmanager-customclaimvalidationtype-authorizingclaimmatchvalue
            /// Required: True
            /// UpdateType: Immutable
            /// Type: AuthorizingClaimMatchValue
            /// </summary>
            public Humidifier.BedrockAgentCore.PaymentManagerTypes.AuthorizingClaimMatchValue AuthorizingClaimMatchValue { get; set; }
            /// <summary>
            /// InboundTokenClaimName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentmanager-customclaimvalidationtype.html#cfn-bedrockagentcore-paymentmanager-customclaimvalidationtype-inboundtokenclaimname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InboundTokenClaimName { get; set; }
            /// <summary>
            /// InboundTokenClaimValueType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentmanager-customclaimvalidationtype.html#cfn-bedrockagentcore-paymentmanager-customclaimvalidationtype-inboundtokenclaimvaluetype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InboundTokenClaimValueType { get; set; }
        }

        public class CustomJWTAuthorizer : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DiscoveryUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentmanager-customjwtauthorizer.html#cfn-bedrockagentcore-paymentmanager-customjwtauthorizer-discoveryurl
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DiscoveryUrl { get; set; }
            /// <summary>
            /// AllowedAudience
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentmanager-customjwtauthorizer.html#cfn-bedrockagentcore-paymentmanager-customjwtauthorizer-allowedaudience
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AllowedAudience { get; set; }
            /// <summary>
            /// CustomClaims
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentmanager-customjwtauthorizer.html#cfn-bedrockagentcore-paymentmanager-customjwtauthorizer-customclaims
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: CustomClaimValidationType
            /// </summary>
            public List<Humidifier.BedrockAgentCore.PaymentManagerTypes.CustomClaimValidationType> CustomClaims { get; set; }
            /// <summary>
            /// AllowedClients
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentmanager-customjwtauthorizer.html#cfn-bedrockagentcore-paymentmanager-customjwtauthorizer-allowedclients
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AllowedClients { get; set; }
            /// <summary>
            /// AllowedScopes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentmanager-customjwtauthorizer.html#cfn-bedrockagentcore-paymentmanager-customjwtauthorizer-allowedscopes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AllowedScopes { get; set; }
        }

        public class WorkloadIdentityDetails : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// WorkloadIdentityArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentmanager-workloadidentitydetails.html#cfn-bedrockagentcore-paymentmanager-workloadidentitydetails-workloadidentityarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WorkloadIdentityArn { get; set; }
        }
    }
}