namespace Humidifier.BedrockAgentCore
{
    using global::System.Collections.Generic;
    using ConsentPortalTypes;

    public class ConsentPortal : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription, IHaveExecutionRoleArn
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
        public Humidifier.BedrockAgentCore.ConsentPortalTypes.IdpConfig IdpConfig { get; set; }

        /// <summary>
        /// ExecutionRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-consentportal.html#cfn-bedrockagentcore-consentportal-executionrolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ExecutionRoleArn { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-consentportal.html#cfn-bedrockagentcore-consentportal-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// Sources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-consentportal.html#cfn-bedrockagentcore-consentportal-sources
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: ConsentPortalSource
        /// </summary>
        [Required]
        public List<Humidifier.BedrockAgentCore.ConsentPortalTypes.ConsentPortalSource> Sources { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-consentportal.html#cfn-bedrockagentcore-consentportal-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
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
            public dynamic Type { get; set; }
            /// <summary>
            /// Identifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-consentportal-consentportalsource.html#cfn-bedrockagentcore-consentportal-consentportalsource-identifier
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Identifier { get; set; }
        }

        public class IdpConfig : Humidifier.Base.BaseSubResource, IHaveAudience
        {
            /// <summary>
            /// CredentialProviderArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-consentportal-idpconfig.html#cfn-bedrockagentcore-consentportal-idpconfig-credentialproviderarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CredentialProviderArn { get; set; }
            /// <summary>
            /// Audience
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-consentportal-idpconfig.html#cfn-bedrockagentcore-consentportal-idpconfig-audience
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Audience { get; set; }
            /// <summary>
            /// Scopes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-consentportal-idpconfig.html#cfn-bedrockagentcore-consentportal-idpconfig-scopes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Scopes { get; set; }
        }
    }
}