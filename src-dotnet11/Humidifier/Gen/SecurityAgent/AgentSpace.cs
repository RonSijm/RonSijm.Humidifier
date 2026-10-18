namespace Humidifier.SecurityAgent
{
    using global::System.Collections.Generic;
    using AgentSpaceTypes;

    public class AgentSpace : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveListOfSecurityAgentAgentSpaceTypesIntegratedResourceIntegratedResources, IHaveDescription, IHaveKmsKeyId, IHaveStringListOfTargetDomainIds, IHaveSecurityAgentAgentSpaceTypesCodeReviewSettingsCodeReviewSettings, IHaveSecurityAgentAgentSpaceTypesAWSResourcesAwsResources, IHaveName
    {
        public class Attributes
        {
            public static string CreatedAt =  "CreatedAt" ;
            public static string AgentSpaceId =  "AgentSpaceId" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.SecurityAgent.AgentSpace; }
        /// <summary>
        /// IntegratedResources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityagent-agentspace.html#cfn-securityagent-agentspace-integratedresources
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: IntegratedResource
        /// </summary>
        public Union<IReadOnlyList<Humidifier.SecurityAgent.AgentSpaceTypes.IntegratedResource>, IReadOnlyList<Union<Humidifier.SecurityAgent.AgentSpaceTypes.IntegratedResource, BaseFunction>>, BaseFunction>? IntegratedResources { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityagent-agentspace.html#cfn-securityagent-agentspace-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityagent-agentspace.html#cfn-securityagent-agentspace-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyId { get; set; }
        /// <summary>
        /// TargetDomainIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityagent-agentspace.html#cfn-securityagent-agentspace-targetdomainids
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? TargetDomainIds { get; set; }
        /// <summary>
        /// CodeReviewSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityagent-agentspace.html#cfn-securityagent-agentspace-codereviewsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CodeReviewSettings
        /// </summary>
        public Union<Humidifier.SecurityAgent.AgentSpaceTypes.CodeReviewSettings, BaseFunction>? CodeReviewSettings { get; set; }
        /// <summary>
        /// AwsResources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityagent-agentspace.html#cfn-securityagent-agentspace-awsresources
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AWSResources
        /// </summary>
        public Union<Humidifier.SecurityAgent.AgentSpaceTypes.AWSResources, BaseFunction>? AwsResources { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityagent-agentspace.html#cfn-securityagent-agentspace-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace AgentSpaceTypes
    {
        public class AWSResources : Humidifier.Base.BaseSubResource, IHaveStringListOfLogGroups, IHaveListOfSecurityAgentAgentSpaceTypesVpcConfigVpcs, IHaveStringListOfIamRoles, IHaveStringListOfSecretArns, IHaveStringListOfS3Buckets, IHaveStringListOfLambdaFunctionArns
        {
            /// <summary>
            /// LogGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-awsresources.html#cfn-securityagent-agentspace-awsresources-loggroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LogGroups { get; set; }
            /// <summary>
            /// Vpcs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-awsresources.html#cfn-securityagent-agentspace-awsresources-vpcs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VpcConfig
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SecurityAgent.AgentSpaceTypes.VpcConfig>, IReadOnlyList<Union<Humidifier.SecurityAgent.AgentSpaceTypes.VpcConfig, BaseFunction>>, BaseFunction>? Vpcs { get; set; }
            /// <summary>
            /// IamRoles
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-awsresources.html#cfn-securityagent-agentspace-awsresources-iamroles
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? IamRoles { get; set; }
            /// <summary>
            /// SecretArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-awsresources.html#cfn-securityagent-agentspace-awsresources-secretarns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecretArns { get; set; }
            /// <summary>
            /// S3Buckets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-awsresources.html#cfn-securityagent-agentspace-awsresources-s3buckets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? S3Buckets { get; set; }
            /// <summary>
            /// LambdaFunctionArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-awsresources.html#cfn-securityagent-agentspace-awsresources-lambdafunctionarns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LambdaFunctionArns { get; set; }
        }

        public class BitbucketCapabilitiesResource : Humidifier.Base.BaseSubResource, IHaveRemediateCode_Boolean, IHaveLeaveComments_Boolean
        {
            /// <summary>
            /// RemediateCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-bitbucketcapabilitiesresource.html#cfn-securityagent-agentspace-bitbucketcapabilitiesresource-remediatecode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? RemediateCode { get; set; }
            /// <summary>
            /// LeaveComments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-bitbucketcapabilitiesresource.html#cfn-securityagent-agentspace-bitbucketcapabilitiesresource-leavecomments
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? LeaveComments { get; set; }
        }

        public class BitbucketRepositoryResource : Humidifier.Base.BaseSubResource, IHaveName, IHaveWorkspace
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-bitbucketrepositoryresource.html#cfn-securityagent-agentspace-bitbucketrepositoryresource-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
            /// <summary>
            /// Workspace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-bitbucketrepositoryresource.html#cfn-securityagent-agentspace-bitbucketrepositoryresource-workspace
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Workspace { get; set; }
        }

        public class CodeReviewSettings : Humidifier.Base.BaseSubResource, IHaveControlsScanning_Boolean, IHaveGeneralPurposeScanning_Boolean
        {
            /// <summary>
            /// ControlsScanning
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-codereviewsettings.html#cfn-securityagent-agentspace-codereviewsettings-controlsscanning
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ControlsScanning { get; set; }
            /// <summary>
            /// GeneralPurposeScanning
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-codereviewsettings.html#cfn-securityagent-agentspace-codereviewsettings-generalpurposescanning
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? GeneralPurposeScanning { get; set; }
        }

        public class ConfluenceCapabilitiesResource : Humidifier.Base.BaseSubResource, IHaveFetchDocument_Boolean, IHaveUpdateDocument_Boolean, IHaveCreateDocument_Boolean
        {
            /// <summary>
            /// FetchDocument
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-confluencecapabilitiesresource.html#cfn-securityagent-agentspace-confluencecapabilitiesresource-fetchdocument
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? FetchDocument { get; set; }
            /// <summary>
            /// UpdateDocument
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-confluencecapabilitiesresource.html#cfn-securityagent-agentspace-confluencecapabilitiesresource-updatedocument
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? UpdateDocument { get; set; }
            /// <summary>
            /// CreateDocument
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-confluencecapabilitiesresource.html#cfn-securityagent-agentspace-confluencecapabilitiesresource-createdocument
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? CreateDocument { get; set; }
        }

        public class ConfluenceDocumentResource : Humidifier.Base.BaseSubResource, IHavePageId, IHaveSpaceTitle, IHaveTitle, IHaveSpaceKey, IHaveName
        {
            /// <summary>
            /// PageId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-confluencedocumentresource.html#cfn-securityagent-agentspace-confluencedocumentresource-pageid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PageId { get; set; }
            /// <summary>
            /// SpaceTitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-confluencedocumentresource.html#cfn-securityagent-agentspace-confluencedocumentresource-spacetitle
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SpaceTitle { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-confluencedocumentresource.html#cfn-securityagent-agentspace-confluencedocumentresource-title
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Title { get; set; }
            /// <summary>
            /// SpaceKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-confluencedocumentresource.html#cfn-securityagent-agentspace-confluencedocumentresource-spacekey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SpaceKey { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-confluencedocumentresource.html#cfn-securityagent-agentspace-confluencedocumentresource-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class GitHubCapabilitiesResource : Humidifier.Base.BaseSubResource, IHaveRemediateCode_Boolean, IHaveLeaveComments_Boolean
        {
            /// <summary>
            /// RemediateCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-githubcapabilitiesresource.html#cfn-securityagent-agentspace-githubcapabilitiesresource-remediatecode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? RemediateCode { get; set; }
            /// <summary>
            /// LeaveComments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-githubcapabilitiesresource.html#cfn-securityagent-agentspace-githubcapabilitiesresource-leavecomments
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? LeaveComments { get; set; }
        }

        public class GitHubRepositoryResource : Humidifier.Base.BaseSubResource, IHaveOwner, IHaveName
        {
            /// <summary>
            /// Owner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-githubrepositoryresource.html#cfn-securityagent-agentspace-githubrepositoryresource-owner
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Owner { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-githubrepositoryresource.html#cfn-securityagent-agentspace-githubrepositoryresource-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class GitLabCapabilitiesResource : Humidifier.Base.BaseSubResource, IHaveRemediateCode_Boolean, IHaveLeaveComments_Boolean
        {
            /// <summary>
            /// RemediateCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-gitlabcapabilitiesresource.html#cfn-securityagent-agentspace-gitlabcapabilitiesresource-remediatecode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? RemediateCode { get; set; }
            /// <summary>
            /// LeaveComments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-gitlabcapabilitiesresource.html#cfn-securityagent-agentspace-gitlabcapabilitiesresource-leavecomments
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? LeaveComments { get; set; }
        }

        public class GitLabRepositoryResource : Humidifier.Base.BaseSubResource, IHaveNamespace_, IHaveName
        {
            /// <summary>
            /// Namespace_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-gitlabrepositoryresource.html#cfn-securityagent-agentspace-gitlabrepositoryresource-namespace
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Namespace_ { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-gitlabrepositoryresource.html#cfn-securityagent-agentspace-gitlabrepositoryresource-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class IntegratedResource : Humidifier.Base.BaseSubResource, IHaveIntegration, IHaveListOfSecurityAgentAgentSpaceTypesProviderResourceProviderResources
        {
            /// <summary>
            /// Integration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-integratedresource.html#cfn-securityagent-agentspace-integratedresource-integration
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Integration { get; set; }
            /// <summary>
            /// ProviderResources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-integratedresource.html#cfn-securityagent-agentspace-integratedresource-providerresources
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ProviderResource
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SecurityAgent.AgentSpaceTypes.ProviderResource>, IReadOnlyList<Union<Humidifier.SecurityAgent.AgentSpaceTypes.ProviderResource, BaseFunction>>, BaseFunction>? ProviderResources { get; set; }
        }

        public class ProviderResource : Humidifier.Base.BaseSubResource, IHaveSecurityAgentAgentSpaceTypesBitbucketCapabilitiesResourceBitbucketCapabilities, IHaveSecurityAgentAgentSpaceTypesGitLabCapabilitiesResourceGitLabCapabilities, IHaveSecurityAgentAgentSpaceTypesBitbucketRepositoryResourceBitbucketRepository, IHaveSecurityAgentAgentSpaceTypesConfluenceCapabilitiesResourceConfluenceCapabilities, IHaveSecurityAgentAgentSpaceTypesGitLabRepositoryResourceGitLabRepository, IHaveSecurityAgentAgentSpaceTypesConfluenceDocumentResourceConfluenceDocument, IHaveSecurityAgentAgentSpaceTypesGitHubRepositoryResourceGitHubRepository, IHaveSecurityAgentAgentSpaceTypesGitHubCapabilitiesResourceGitHubCapabilities
        {
            /// <summary>
            /// BitbucketCapabilities
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-providerresource.html#cfn-securityagent-agentspace-providerresource-bitbucketcapabilities
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BitbucketCapabilitiesResource
            /// </summary>
            public Union<Humidifier.SecurityAgent.AgentSpaceTypes.BitbucketCapabilitiesResource, BaseFunction>? BitbucketCapabilities { get; set; }
            /// <summary>
            /// GitLabCapabilities
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-providerresource.html#cfn-securityagent-agentspace-providerresource-gitlabcapabilities
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GitLabCapabilitiesResource
            /// </summary>
            public Union<Humidifier.SecurityAgent.AgentSpaceTypes.GitLabCapabilitiesResource, BaseFunction>? GitLabCapabilities { get; set; }
            /// <summary>
            /// BitbucketRepository
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-providerresource.html#cfn-securityagent-agentspace-providerresource-bitbucketrepository
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BitbucketRepositoryResource
            /// </summary>
            public Union<Humidifier.SecurityAgent.AgentSpaceTypes.BitbucketRepositoryResource, BaseFunction>? BitbucketRepository { get; set; }
            /// <summary>
            /// ConfluenceCapabilities
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-providerresource.html#cfn-securityagent-agentspace-providerresource-confluencecapabilities
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConfluenceCapabilitiesResource
            /// </summary>
            public Union<Humidifier.SecurityAgent.AgentSpaceTypes.ConfluenceCapabilitiesResource, BaseFunction>? ConfluenceCapabilities { get; set; }
            /// <summary>
            /// GitLabRepository
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-providerresource.html#cfn-securityagent-agentspace-providerresource-gitlabrepository
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GitLabRepositoryResource
            /// </summary>
            public Union<Humidifier.SecurityAgent.AgentSpaceTypes.GitLabRepositoryResource, BaseFunction>? GitLabRepository { get; set; }
            /// <summary>
            /// ConfluenceDocument
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-providerresource.html#cfn-securityagent-agentspace-providerresource-confluencedocument
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConfluenceDocumentResource
            /// </summary>
            public Union<Humidifier.SecurityAgent.AgentSpaceTypes.ConfluenceDocumentResource, BaseFunction>? ConfluenceDocument { get; set; }
            /// <summary>
            /// GitHubRepository
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-providerresource.html#cfn-securityagent-agentspace-providerresource-githubrepository
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GitHubRepositoryResource
            /// </summary>
            public Union<Humidifier.SecurityAgent.AgentSpaceTypes.GitHubRepositoryResource, BaseFunction>? GitHubRepository { get; set; }
            /// <summary>
            /// GitHubCapabilities
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-providerresource.html#cfn-securityagent-agentspace-providerresource-githubcapabilities
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GitHubCapabilitiesResource
            /// </summary>
            public Union<Humidifier.SecurityAgent.AgentSpaceTypes.GitHubCapabilitiesResource, BaseFunction>? GitHubCapabilities { get; set; }
        }

        public class VpcConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfSubnetArns, IHaveVpcArn, IHaveStringListOfSecurityGroupArns
        {
            /// <summary>
            /// SubnetArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-vpcconfig.html#cfn-securityagent-agentspace-vpcconfig-subnetarns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetArns { get; set; }
            /// <summary>
            /// VpcArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-vpcconfig.html#cfn-securityagent-agentspace-vpcconfig-vpcarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VpcArn { get; set; }
            /// <summary>
            /// SecurityGroupArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-vpcconfig.html#cfn-securityagent-agentspace-vpcconfig-securitygrouparns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupArns { get; set; }
        }
    }
}