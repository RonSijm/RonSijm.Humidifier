namespace Humidifier.AgentRegistry
{
    using global::System.Collections.Generic;
    using RegistryTypes;

    public class Registry : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string AutoDetectionStatus =  "AutoDetectionStatus" ;
            public static string RegistryId =  "RegistryId" ;
            public static string RegistryArn =  "RegistryArn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.AgentRegistry.Registry; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-agentregistry-registry.html#cfn-agentregistry-registry-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// ApprovalConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-agentregistry-registry.html#cfn-agentregistry-registry-approvalconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ApprovalConfiguration
        /// </summary>
        public Humidifier.AgentRegistry.RegistryTypes.ApprovalConfiguration ApprovalConfiguration { get; set; }
        /// <summary>
        /// AutoDetectionScope
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-agentregistry-registry.html#cfn-agentregistry-registry-autodetectionscope
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AutoDetectionScope { get; set; }
        /// <summary>
        /// AuthorizerType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-agentregistry-registry.html#cfn-agentregistry-registry-authorizertype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AuthorizerType { get; set; }
        /// <summary>
        /// EncryptionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-agentregistry-registry.html#cfn-agentregistry-registry-encryptionconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: EncryptionConfiguration
        /// </summary>
        public Humidifier.AgentRegistry.RegistryTypes.EncryptionConfiguration EncryptionConfiguration { get; set; }
        /// <summary>
        /// DiscoveryConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-agentregistry-registry.html#cfn-agentregistry-registry-discoveryconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DiscoveryConfiguration
        /// </summary>
        public Humidifier.AgentRegistry.RegistryTypes.DiscoveryConfiguration DiscoveryConfiguration { get; set; }
        /// <summary>
        /// AutoDetectionEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-agentregistry-registry.html#cfn-agentregistry-registry-autodetectionenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic AutoDetectionEnabled { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-agentregistry-registry.html#cfn-agentregistry-registry-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace RegistryTypes
    {
        public class ApprovalConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AutoApprovalRules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registry-approvalconfiguration.html#cfn-agentregistry-registry-approvalconfiguration-autoapprovalrules
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AutoApprovalRules { get; set; }
        }

        public class AuthorizerConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CustomJWTAuthorizer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registry-authorizerconfiguration.html#cfn-agentregistry-registry-authorizerconfiguration-customjwtauthorizer
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CustomJWTAuthorizerConfiguration
            /// </summary>
            public Humidifier.AgentRegistry.RegistryTypes.CustomJWTAuthorizerConfiguration CustomJWTAuthorizer { get; set; }
        }

        public class AuthorizingClaimMatchValueType : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ClaimMatchValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registry-authorizingclaimmatchvaluetype.html#cfn-agentregistry-registry-authorizingclaimmatchvaluetype-claimmatchvalue
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ClaimMatchValueType
            /// </summary>
            public Humidifier.AgentRegistry.RegistryTypes.ClaimMatchValueType ClaimMatchValue { get; set; }
            /// <summary>
            /// ClaimMatchOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registry-authorizingclaimmatchvaluetype.html#cfn-agentregistry-registry-authorizingclaimmatchvaluetype-claimmatchoperator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClaimMatchOperator { get; set; }
        }

        public class ClaimMatchValueType : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MatchValueString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registry-claimmatchvaluetype.html#cfn-agentregistry-registry-claimmatchvaluetype-matchvaluestring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MatchValueString { get; set; }
            /// <summary>
            /// MatchValueStringList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registry-claimmatchvaluetype.html#cfn-agentregistry-registry-claimmatchvaluetype-matchvaluestringlist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic MatchValueStringList { get; set; }
        }

        public class CustomClaimValidationType : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AuthorizingClaimMatchValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registry-customclaimvalidationtype.html#cfn-agentregistry-registry-customclaimvalidationtype-authorizingclaimmatchvalue
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AuthorizingClaimMatchValueType
            /// </summary>
            public Humidifier.AgentRegistry.RegistryTypes.AuthorizingClaimMatchValueType AuthorizingClaimMatchValue { get; set; }
            /// <summary>
            /// InboundTokenClaimName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registry-customclaimvalidationtype.html#cfn-agentregistry-registry-customclaimvalidationtype-inboundtokenclaimname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InboundTokenClaimName { get; set; }
            /// <summary>
            /// InboundTokenClaimValueType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registry-customclaimvalidationtype.html#cfn-agentregistry-registry-customclaimvalidationtype-inboundtokenclaimvaluetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InboundTokenClaimValueType { get; set; }
        }

        public class CustomJWTAuthorizerConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DiscoveryUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registry-customjwtauthorizerconfiguration.html#cfn-agentregistry-registry-customjwtauthorizerconfiguration-discoveryurl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DiscoveryUrl { get; set; }
            /// <summary>
            /// AllowedAudience
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registry-customjwtauthorizerconfiguration.html#cfn-agentregistry-registry-customjwtauthorizerconfiguration-allowedaudience
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AllowedAudience { get; set; }
            /// <summary>
            /// CustomClaims
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registry-customjwtauthorizerconfiguration.html#cfn-agentregistry-registry-customjwtauthorizerconfiguration-customclaims
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomClaimValidationType
            /// </summary>
            public List<Humidifier.AgentRegistry.RegistryTypes.CustomClaimValidationType> CustomClaims { get; set; }
            /// <summary>
            /// AllowedClients
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registry-customjwtauthorizerconfiguration.html#cfn-agentregistry-registry-customjwtauthorizerconfiguration-allowedclients
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AllowedClients { get; set; }
            /// <summary>
            /// AllowedScopes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registry-customjwtauthorizerconfiguration.html#cfn-agentregistry-registry-customjwtauthorizerconfiguration-allowedscopes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AllowedScopes { get; set; }
        }

        public class DiscoveryConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AuthorizerConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registry-discoveryconfiguration.html#cfn-agentregistry-registry-discoveryconfiguration-authorizerconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuthorizerConfiguration
            /// </summary>
            public Humidifier.AgentRegistry.RegistryTypes.AuthorizerConfiguration AuthorizerConfiguration { get; set; }
        }

        public class EncryptionConfiguration : Humidifier.Base.BaseSubResource, IHaveKmsKeyArn
        {
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registry-encryptionconfiguration.html#cfn-agentregistry-registry-encryptionconfiguration-kmskeyarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKeyArn { get; set; }
        }
    }
}