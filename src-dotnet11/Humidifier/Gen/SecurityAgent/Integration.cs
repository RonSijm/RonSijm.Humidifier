namespace Humidifier.SecurityAgent
{
    using global::System.Collections.Generic;
    using IntegrationTypes;

    public class Integration : Humidifier.Base.BaseResource, IHaveTags, IHavePrivateConnectionName, IHaveKmsKeyId, IHaveSecurityAgentIntegrationTypesProviderInputProviderInput, IHaveDisplayName, IHaveProvider
    {
        public class Attributes
        {
            public static string InstallationId =  "InstallationId" ;
            public static string IntegrationId =  "IntegrationId" ;
            public static string ProviderType =  "ProviderType" ;
            public static string TargetUrl =  "TargetUrl" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.SecurityAgent.Integration; }
        /// <summary>
        /// PrivateConnectionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityagent-integration.html#cfn-securityagent-integration-privateconnectionname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PrivateConnectionName { get; set; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityagent-integration.html#cfn-securityagent-integration-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyId { get; set; }
        /// <summary>
        /// ProviderInput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityagent-integration.html#cfn-securityagent-integration-providerinput
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ProviderInput
        /// </summary>
        public Union<Humidifier.SecurityAgent.IntegrationTypes.ProviderInput, BaseFunction>? ProviderInput { get; set; }

        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityagent-integration.html#cfn-securityagent-integration-displayname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DisplayName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityagent-integration.html#cfn-securityagent-integration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// Provider
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityagent-integration.html#cfn-securityagent-integration-provider
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Provider { get; set; }
    }

    namespace IntegrationTypes
    {
        public class BitbucketInput : Humidifier.Base.BaseSubResource, IHaveInstallationId, IHaveState, IHaveCode, IHaveWorkspace
        {
            /// <summary>
            /// InstallationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-integration-bitbucketinput.html#cfn-securityagent-integration-bitbucketinput-installationid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstallationId { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-integration-bitbucketinput.html#cfn-securityagent-integration-bitbucketinput-state
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
            /// <summary>
            /// Code
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-integration-bitbucketinput.html#cfn-securityagent-integration-bitbucketinput-code
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Code { get; set; }
            /// <summary>
            /// Workspace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-integration-bitbucketinput.html#cfn-securityagent-integration-bitbucketinput-workspace
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Workspace { get; set; }
        }

        public class ConfluenceInput : Humidifier.Base.BaseSubResource, IHaveInstallationId, IHaveState, IHaveSiteUrl, IHaveCode
        {
            /// <summary>
            /// InstallationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-integration-confluenceinput.html#cfn-securityagent-integration-confluenceinput-installationid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstallationId { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-integration-confluenceinput.html#cfn-securityagent-integration-confluenceinput-state
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
            /// <summary>
            /// SiteUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-integration-confluenceinput.html#cfn-securityagent-integration-confluenceinput-siteurl
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SiteUrl { get; set; }
            /// <summary>
            /// Code
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-integration-confluenceinput.html#cfn-securityagent-integration-confluenceinput-code
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Code { get; set; }
        }

        public class GitHubInput : Humidifier.Base.BaseSubResource, IHaveOrganizationName, IHaveInstallationId, IHaveState, IHaveTargetUrl, IHaveCode
        {
            /// <summary>
            /// OrganizationName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-integration-githubinput.html#cfn-securityagent-integration-githubinput-organizationname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OrganizationName { get; set; }
            /// <summary>
            /// InstallationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-integration-githubinput.html#cfn-securityagent-integration-githubinput-installationid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstallationId { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-integration-githubinput.html#cfn-securityagent-integration-githubinput-state
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
            /// <summary>
            /// TargetUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-integration-githubinput.html#cfn-securityagent-integration-githubinput-targeturl
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetUrl { get; set; }
            /// <summary>
            /// Code
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-integration-githubinput.html#cfn-securityagent-integration-githubinput-code
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Code { get; set; }
        }

        public class GitLabInput : Humidifier.Base.BaseSubResource, IHaveTokenType, IHaveAccessToken, IHaveTargetUrl, IHaveGroupId
        {
            /// <summary>
            /// TokenType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-integration-gitlabinput.html#cfn-securityagent-integration-gitlabinput-tokentype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TokenType { get; set; }
            /// <summary>
            /// AccessToken
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-integration-gitlabinput.html#cfn-securityagent-integration-gitlabinput-accesstoken
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccessToken { get; set; }
            /// <summary>
            /// TargetUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-integration-gitlabinput.html#cfn-securityagent-integration-gitlabinput-targeturl
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetUrl { get; set; }
            /// <summary>
            /// GroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-integration-gitlabinput.html#cfn-securityagent-integration-gitlabinput-groupid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GroupId { get; set; }
        }

        public class ProviderInput : Humidifier.Base.BaseSubResource, IHaveSecurityAgentIntegrationTypesGitHubInputGithub, IHaveSecurityAgentIntegrationTypesConfluenceInputConfluence, IHaveSecurityAgentIntegrationTypesBitbucketInputBitbucket, IHaveSecurityAgentIntegrationTypesGitLabInputGitlab
        {
            /// <summary>
            /// Github
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-integration-providerinput.html#cfn-securityagent-integration-providerinput-github
            /// Required: False
            /// UpdateType: Immutable
            /// Type: GitHubInput
            /// </summary>
            public Union<Humidifier.SecurityAgent.IntegrationTypes.GitHubInput, BaseFunction>? Github { get; set; }
            /// <summary>
            /// Confluence
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-integration-providerinput.html#cfn-securityagent-integration-providerinput-confluence
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ConfluenceInput
            /// </summary>
            public Union<Humidifier.SecurityAgent.IntegrationTypes.ConfluenceInput, BaseFunction>? Confluence { get; set; }
            /// <summary>
            /// Bitbucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-integration-providerinput.html#cfn-securityagent-integration-providerinput-bitbucket
            /// Required: False
            /// UpdateType: Immutable
            /// Type: BitbucketInput
            /// </summary>
            public Union<Humidifier.SecurityAgent.IntegrationTypes.BitbucketInput, BaseFunction>? Bitbucket { get; set; }
            /// <summary>
            /// Gitlab
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-integration-providerinput.html#cfn-securityagent-integration-providerinput-gitlab
            /// Required: False
            /// UpdateType: Immutable
            /// Type: GitLabInput
            /// </summary>
            public Union<Humidifier.SecurityAgent.IntegrationTypes.GitLabInput, BaseFunction>? Gitlab { get; set; }
        }
    }
}