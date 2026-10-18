namespace Humidifier.AgentRegistry
{
    using global::System.Collections.Generic;
    using RegistryTypes;

    public class Registry : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveAgentRegistryRegistryTypesApprovalConfigurationApprovalConfiguration, IHaveAutoDetectionScope, IHaveAuthorizerType, IHaveAgentRegistryRegistryTypesEncryptionConfigurationEncryptionConfiguration, IHaveAgentRegistryRegistryTypesDiscoveryConfigurationDiscoveryConfiguration, IHaveAutoDetectionEnabled_Boolean, IHaveName
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
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// ApprovalConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-agentregistry-registry.html#cfn-agentregistry-registry-approvalconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ApprovalConfiguration
        /// </summary>
        public Union<Humidifier.AgentRegistry.RegistryTypes.ApprovalConfiguration, BaseFunction>? ApprovalConfiguration { get; set; }
        /// <summary>
        /// AutoDetectionScope
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-agentregistry-registry.html#cfn-agentregistry-registry-autodetectionscope
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AutoDetectionScope { get; set; }
        /// <summary>
        /// AuthorizerType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-agentregistry-registry.html#cfn-agentregistry-registry-authorizertype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AuthorizerType { get; set; }
        /// <summary>
        /// EncryptionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-agentregistry-registry.html#cfn-agentregistry-registry-encryptionconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: EncryptionConfiguration
        /// </summary>
        public Union<Humidifier.AgentRegistry.RegistryTypes.EncryptionConfiguration, BaseFunction>? EncryptionConfiguration { get; set; }
        /// <summary>
        /// DiscoveryConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-agentregistry-registry.html#cfn-agentregistry-registry-discoveryconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DiscoveryConfiguration
        /// </summary>
        public Union<Humidifier.AgentRegistry.RegistryTypes.DiscoveryConfiguration, BaseFunction>? DiscoveryConfiguration { get; set; }
        /// <summary>
        /// AutoDetectionEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-agentregistry-registry.html#cfn-agentregistry-registry-autodetectionenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? AutoDetectionEnabled { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-agentregistry-registry.html#cfn-agentregistry-registry-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace RegistryTypes
    {
        public class ApprovalConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfAutoApprovalRules
        {
            /// <summary>
            /// AutoApprovalRules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registry-approvalconfiguration.html#cfn-agentregistry-registry-approvalconfiguration-autoapprovalrules
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AutoApprovalRules { get; set; }
        }

        public class AuthorizerConfiguration : Humidifier.Base.BaseSubResource, IHaveAgentRegistryRegistryTypesCustomJWTAuthorizerConfigurationCustomJWTAuthorizer
        {
            /// <summary>
            /// CustomJWTAuthorizer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registry-authorizerconfiguration.html#cfn-agentregistry-registry-authorizerconfiguration-customjwtauthorizer
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CustomJWTAuthorizerConfiguration
            /// </summary>
            public Union<Humidifier.AgentRegistry.RegistryTypes.CustomJWTAuthorizerConfiguration, BaseFunction>? CustomJWTAuthorizer { get; set; }
        }

        public class AuthorizingClaimMatchValueType : Humidifier.Base.BaseSubResource, IHaveAgentRegistryRegistryTypesClaimMatchValueTypeClaimMatchValue, IHaveClaimMatchOperator
        {
            /// <summary>
            /// ClaimMatchValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registry-authorizingclaimmatchvaluetype.html#cfn-agentregistry-registry-authorizingclaimmatchvaluetype-claimmatchvalue
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ClaimMatchValueType
            /// </summary>
            public Union<Humidifier.AgentRegistry.RegistryTypes.ClaimMatchValueType, BaseFunction>? ClaimMatchValue { get; set; }
            /// <summary>
            /// ClaimMatchOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registry-authorizingclaimmatchvaluetype.html#cfn-agentregistry-registry-authorizingclaimmatchvaluetype-claimmatchoperator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClaimMatchOperator { get; set; }
        }

        public class ClaimMatchValueType : Humidifier.Base.BaseSubResource, IHaveMatchValueString, IHaveStringListOfMatchValueStringList
        {
            /// <summary>
            /// MatchValueString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registry-claimmatchvaluetype.html#cfn-agentregistry-registry-claimmatchvaluetype-matchvaluestring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MatchValueString { get; set; }
            /// <summary>
            /// MatchValueStringList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registry-claimmatchvaluetype.html#cfn-agentregistry-registry-claimmatchvaluetype-matchvaluestringlist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? MatchValueStringList { get; set; }
        }

        public class CustomClaimValidationType : Humidifier.Base.BaseSubResource, IHaveAgentRegistryRegistryTypesAuthorizingClaimMatchValueTypeAuthorizingClaimMatchValue, IHaveInboundTokenClaimName, IHaveInboundTokenClaimValueType
        {
            /// <summary>
            /// AuthorizingClaimMatchValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registry-customclaimvalidationtype.html#cfn-agentregistry-registry-customclaimvalidationtype-authorizingclaimmatchvalue
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AuthorizingClaimMatchValueType
            /// </summary>
            public Union<Humidifier.AgentRegistry.RegistryTypes.AuthorizingClaimMatchValueType, BaseFunction>? AuthorizingClaimMatchValue { get; set; }
            /// <summary>
            /// InboundTokenClaimName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registry-customclaimvalidationtype.html#cfn-agentregistry-registry-customclaimvalidationtype-inboundtokenclaimname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InboundTokenClaimName { get; set; }
            /// <summary>
            /// InboundTokenClaimValueType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registry-customclaimvalidationtype.html#cfn-agentregistry-registry-customclaimvalidationtype-inboundtokenclaimvaluetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InboundTokenClaimValueType { get; set; }
        }

        public class CustomJWTAuthorizerConfiguration : Humidifier.Base.BaseSubResource, IHaveDiscoveryUrl, IHaveStringListOfAllowedAudience, IHaveListOfAgentRegistryRegistryTypesCustomClaimValidationTypeCustomClaims, IHaveStringListOfAllowedClients, IHaveStringListOfAllowedScopes
        {
            /// <summary>
            /// DiscoveryUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registry-customjwtauthorizerconfiguration.html#cfn-agentregistry-registry-customjwtauthorizerconfiguration-discoveryurl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DiscoveryUrl { get; set; }
            /// <summary>
            /// AllowedAudience
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registry-customjwtauthorizerconfiguration.html#cfn-agentregistry-registry-customjwtauthorizerconfiguration-allowedaudience
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedAudience { get; set; }
            /// <summary>
            /// CustomClaims
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registry-customjwtauthorizerconfiguration.html#cfn-agentregistry-registry-customjwtauthorizerconfiguration-customclaims
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomClaimValidationType
            /// </summary>
            public Union<IReadOnlyList<Humidifier.AgentRegistry.RegistryTypes.CustomClaimValidationType>, IReadOnlyList<Union<Humidifier.AgentRegistry.RegistryTypes.CustomClaimValidationType, BaseFunction>>, BaseFunction>? CustomClaims { get; set; }
            /// <summary>
            /// AllowedClients
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registry-customjwtauthorizerconfiguration.html#cfn-agentregistry-registry-customjwtauthorizerconfiguration-allowedclients
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedClients { get; set; }
            /// <summary>
            /// AllowedScopes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registry-customjwtauthorizerconfiguration.html#cfn-agentregistry-registry-customjwtauthorizerconfiguration-allowedscopes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedScopes { get; set; }
        }

        public class DiscoveryConfiguration : Humidifier.Base.BaseSubResource, IHaveAgentRegistryRegistryTypesAuthorizerConfigurationAuthorizerConfiguration
        {
            /// <summary>
            /// AuthorizerConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registry-discoveryconfiguration.html#cfn-agentregistry-registry-discoveryconfiguration-authorizerconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuthorizerConfiguration
            /// </summary>
            public Union<Humidifier.AgentRegistry.RegistryTypes.AuthorizerConfiguration, BaseFunction>? AuthorizerConfiguration { get; set; }
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
            public Union<string, BaseFunction>? KmsKeyArn { get; set; }
        }
    }
}