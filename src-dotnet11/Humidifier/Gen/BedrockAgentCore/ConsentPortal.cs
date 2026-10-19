namespace Humidifier.BedrockAgentCore
{
    using global::System.Collections.Generic;
    using ConsentPortalTypes;

    public class ConsentPortal : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveBedrockAgentCoreConsentPortalTypesIdpConfigIdpConfig, IHaveExecutionRoleArn, IHaveDescription, IHaveListOfBedrockAgentCoreConsentPortalTypesConsentPortalSourceSources, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string PortalUrl =  "PortalUrl" ;
            public static string ConsentPortalId =  "ConsentPortalId" ;
            public static string ConsentPortalArn =  "ConsentPortalArn" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.BedrockAgentCore.ConsentPortal; }

        /// <summary>
        /// IdpConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-consentportal.html#cfn-bedrockagentcore-consentportal-idpconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: IdpConfig
        /// </summary>
        [Required]
        public Union<Humidifier.BedrockAgentCore.ConsentPortalTypes.IdpConfig, BaseFunction>? IdpConfig { get; set; }

        /// <summary>
        /// ExecutionRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-consentportal.html#cfn-bedrockagentcore-consentportal-executionrolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ExecutionRoleArn { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-consentportal.html#cfn-bedrockagentcore-consentportal-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// Sources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-consentportal.html#cfn-bedrockagentcore-consentportal-sources
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: ConsentPortalSource
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.BedrockAgentCore.ConsentPortalTypes.ConsentPortalSource>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.ConsentPortalTypes.ConsentPortalSource, BaseFunction>>, BaseFunction>? Sources { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-consentportal.html#cfn-bedrockagentcore-consentportal-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ConsentPortalTypes
    {
        public class ConsentPortalSource : Humidifier.Base.BaseSubResource, IHaveType, IHaveIdentifier
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-consentportal-consentportalsource.html#cfn-bedrockagentcore-consentportal-consentportalsource-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Identifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-consentportal-consentportalsource.html#cfn-bedrockagentcore-consentportal-consentportalsource-identifier
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Identifier { get; set; }
        }

        public class IdpConfig : Humidifier.Base.BaseSubResource, IHaveCredentialProviderArn, IHaveAudience, IHaveStringListOfScopes
        {
            /// <summary>
            /// CredentialProviderArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-consentportal-idpconfig.html#cfn-bedrockagentcore-consentportal-idpconfig-credentialproviderarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CredentialProviderArn { get; set; }
            /// <summary>
            /// Audience
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-consentportal-idpconfig.html#cfn-bedrockagentcore-consentportal-idpconfig-audience
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Audience { get; set; }
            /// <summary>
            /// Scopes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-consentportal-idpconfig.html#cfn-bedrockagentcore-consentportal-idpconfig-scopes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Scopes { get; set; }
        }
    }
}