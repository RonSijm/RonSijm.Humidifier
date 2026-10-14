namespace Humidifier.SecurityAgent
{
    using global::System.Collections.Generic;
    using AgentSpaceTypes;

    public class AgentSpace : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription, IHaveKmsKeyId
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
        public List<Humidifier.SecurityAgent.AgentSpaceTypes.IntegratedResource> IntegratedResources { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityagent-agentspace.html#cfn-securityagent-agentspace-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityagent-agentspace.html#cfn-securityagent-agentspace-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KmsKeyId { get; set; }
        /// <summary>
        /// TargetDomainIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityagent-agentspace.html#cfn-securityagent-agentspace-targetdomainids
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic TargetDomainIds { get; set; }
        /// <summary>
        /// CodeReviewSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityagent-agentspace.html#cfn-securityagent-agentspace-codereviewsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CodeReviewSettings
        /// </summary>
        public Humidifier.SecurityAgent.AgentSpaceTypes.CodeReviewSettings CodeReviewSettings { get; set; }
        /// <summary>
        /// AwsResources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityagent-agentspace.html#cfn-securityagent-agentspace-awsresources
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AWSResources
        /// </summary>
        public Humidifier.SecurityAgent.AgentSpaceTypes.AWSResources AwsResources { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityagent-agentspace.html#cfn-securityagent-agentspace-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace AgentSpaceTypes
    {
        public class AWSResources : Humidifier.Base.BaseSubResource, IHaveIamRoles
        {
            /// <summary>
            /// LogGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-awsresources.html#cfn-securityagent-agentspace-awsresources-loggroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic LogGroups { get; set; }
            /// <summary>
            /// Vpcs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-awsresources.html#cfn-securityagent-agentspace-awsresources-vpcs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VpcConfig
            /// </summary>
            public List<Humidifier.SecurityAgent.AgentSpaceTypes.VpcConfig> Vpcs { get; set; }
            /// <summary>
            /// IamRoles
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-awsresources.html#cfn-securityagent-agentspace-awsresources-iamroles
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic IamRoles { get; set; }
            /// <summary>
            /// SecretArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-awsresources.html#cfn-securityagent-agentspace-awsresources-secretarns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecretArns { get; set; }
            /// <summary>
            /// S3Buckets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-awsresources.html#cfn-securityagent-agentspace-awsresources-s3buckets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic S3Buckets { get; set; }
            /// <summary>
            /// LambdaFunctionArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-awsresources.html#cfn-securityagent-agentspace-awsresources-lambdafunctionarns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic LambdaFunctionArns { get; set; }
        }

        public class BitbucketCapabilitiesResource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RemediateCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-bitbucketcapabilitiesresource.html#cfn-securityagent-agentspace-bitbucketcapabilitiesresource-remediatecode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic RemediateCode { get; set; }
            /// <summary>
            /// LeaveComments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-bitbucketcapabilitiesresource.html#cfn-securityagent-agentspace-bitbucketcapabilitiesresource-leavecomments
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic LeaveComments { get; set; }
        }

        public class BitbucketRepositoryResource : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-bitbucketrepositoryresource.html#cfn-securityagent-agentspace-bitbucketrepositoryresource-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
            /// <summary>
            /// Workspace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-bitbucketrepositoryresource.html#cfn-securityagent-agentspace-bitbucketrepositoryresource-workspace
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Workspace { get; set; }
        }

        public class CodeReviewSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ControlsScanning
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-codereviewsettings.html#cfn-securityagent-agentspace-codereviewsettings-controlsscanning
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ControlsScanning { get; set; }
            /// <summary>
            /// GeneralPurposeScanning
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-codereviewsettings.html#cfn-securityagent-agentspace-codereviewsettings-generalpurposescanning
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic GeneralPurposeScanning { get; set; }
        }

        public class ConfluenceCapabilitiesResource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FetchDocument
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-confluencecapabilitiesresource.html#cfn-securityagent-agentspace-confluencecapabilitiesresource-fetchdocument
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic FetchDocument { get; set; }
            /// <summary>
            /// UpdateDocument
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-confluencecapabilitiesresource.html#cfn-securityagent-agentspace-confluencecapabilitiesresource-updatedocument
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic UpdateDocument { get; set; }
            /// <summary>
            /// CreateDocument
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-confluencecapabilitiesresource.html#cfn-securityagent-agentspace-confluencecapabilitiesresource-createdocument
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic CreateDocument { get; set; }
        }

        public class ConfluenceDocumentResource : Humidifier.Base.BaseSubResource, IHaveName, IHaveTitle
        {
            /// <summary>
            /// PageId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-confluencedocumentresource.html#cfn-securityagent-agentspace-confluencedocumentresource-pageid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PageId { get; set; }
            /// <summary>
            /// SpaceTitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-confluencedocumentresource.html#cfn-securityagent-agentspace-confluencedocumentresource-spacetitle
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SpaceTitle { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-confluencedocumentresource.html#cfn-securityagent-agentspace-confluencedocumentresource-title
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
            /// <summary>
            /// SpaceKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-confluencedocumentresource.html#cfn-securityagent-agentspace-confluencedocumentresource-spacekey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SpaceKey { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-confluencedocumentresource.html#cfn-securityagent-agentspace-confluencedocumentresource-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class GitHubCapabilitiesResource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RemediateCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-githubcapabilitiesresource.html#cfn-securityagent-agentspace-githubcapabilitiesresource-remediatecode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic RemediateCode { get; set; }
            /// <summary>
            /// LeaveComments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-githubcapabilitiesresource.html#cfn-securityagent-agentspace-githubcapabilitiesresource-leavecomments
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic LeaveComments { get; set; }
        }

        public class GitHubRepositoryResource : Humidifier.Base.BaseSubResource, IHaveName, IHaveOwner
        {
            /// <summary>
            /// Owner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-githubrepositoryresource.html#cfn-securityagent-agentspace-githubrepositoryresource-owner
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Owner { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-githubrepositoryresource.html#cfn-securityagent-agentspace-githubrepositoryresource-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class GitLabCapabilitiesResource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RemediateCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-gitlabcapabilitiesresource.html#cfn-securityagent-agentspace-gitlabcapabilitiesresource-remediatecode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic RemediateCode { get; set; }
            /// <summary>
            /// LeaveComments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-gitlabcapabilitiesresource.html#cfn-securityagent-agentspace-gitlabcapabilitiesresource-leavecomments
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic LeaveComments { get; set; }
        }

        public class GitLabRepositoryResource : Humidifier.Base.BaseSubResource, IHaveName, IHaveNamespace_
        {
            /// <summary>
            /// Namespace_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-gitlabrepositoryresource.html#cfn-securityagent-agentspace-gitlabrepositoryresource-namespace
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Namespace_ { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-gitlabrepositoryresource.html#cfn-securityagent-agentspace-gitlabrepositoryresource-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class IntegratedResource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Integration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-integratedresource.html#cfn-securityagent-agentspace-integratedresource-integration
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Integration { get; set; }
            /// <summary>
            /// ProviderResources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-integratedresource.html#cfn-securityagent-agentspace-integratedresource-providerresources
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ProviderResource
            /// </summary>
            public List<Humidifier.SecurityAgent.AgentSpaceTypes.ProviderResource> ProviderResources { get; set; }
        }

        public class ProviderResource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// BitbucketCapabilities
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-providerresource.html#cfn-securityagent-agentspace-providerresource-bitbucketcapabilities
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BitbucketCapabilitiesResource
            /// </summary>
            public Humidifier.SecurityAgent.AgentSpaceTypes.BitbucketCapabilitiesResource BitbucketCapabilities { get; set; }
            /// <summary>
            /// GitLabCapabilities
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-providerresource.html#cfn-securityagent-agentspace-providerresource-gitlabcapabilities
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GitLabCapabilitiesResource
            /// </summary>
            public Humidifier.SecurityAgent.AgentSpaceTypes.GitLabCapabilitiesResource GitLabCapabilities { get; set; }
            /// <summary>
            /// BitbucketRepository
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-providerresource.html#cfn-securityagent-agentspace-providerresource-bitbucketrepository
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BitbucketRepositoryResource
            /// </summary>
            public Humidifier.SecurityAgent.AgentSpaceTypes.BitbucketRepositoryResource BitbucketRepository { get; set; }
            /// <summary>
            /// ConfluenceCapabilities
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-providerresource.html#cfn-securityagent-agentspace-providerresource-confluencecapabilities
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConfluenceCapabilitiesResource
            /// </summary>
            public Humidifier.SecurityAgent.AgentSpaceTypes.ConfluenceCapabilitiesResource ConfluenceCapabilities { get; set; }
            /// <summary>
            /// GitLabRepository
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-providerresource.html#cfn-securityagent-agentspace-providerresource-gitlabrepository
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GitLabRepositoryResource
            /// </summary>
            public Humidifier.SecurityAgent.AgentSpaceTypes.GitLabRepositoryResource GitLabRepository { get; set; }
            /// <summary>
            /// ConfluenceDocument
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-providerresource.html#cfn-securityagent-agentspace-providerresource-confluencedocument
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConfluenceDocumentResource
            /// </summary>
            public Humidifier.SecurityAgent.AgentSpaceTypes.ConfluenceDocumentResource ConfluenceDocument { get; set; }
            /// <summary>
            /// GitHubRepository
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-providerresource.html#cfn-securityagent-agentspace-providerresource-githubrepository
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GitHubRepositoryResource
            /// </summary>
            public Humidifier.SecurityAgent.AgentSpaceTypes.GitHubRepositoryResource GitHubRepository { get; set; }
            /// <summary>
            /// GitHubCapabilities
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-providerresource.html#cfn-securityagent-agentspace-providerresource-githubcapabilities
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GitHubCapabilitiesResource
            /// </summary>
            public Humidifier.SecurityAgent.AgentSpaceTypes.GitHubCapabilitiesResource GitHubCapabilities { get; set; }
        }

        public class VpcConfig : Humidifier.Base.BaseSubResource, IHaveSecurityGroupArns, IHaveSubnetArns
        {
            /// <summary>
            /// SubnetArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-vpcconfig.html#cfn-securityagent-agentspace-vpcconfig-subnetarns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SubnetArns { get; set; }
            /// <summary>
            /// VpcArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-vpcconfig.html#cfn-securityagent-agentspace-vpcconfig-vpcarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VpcArn { get; set; }
            /// <summary>
            /// SecurityGroupArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityagent-agentspace-vpcconfig.html#cfn-securityagent-agentspace-vpcconfig-securitygrouparns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroupArns { get; set; }
        }
    }
}