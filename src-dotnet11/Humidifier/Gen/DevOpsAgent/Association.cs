namespace Humidifier.DevOpsAgent
{
    using global::System.Collections.Generic;
    using AssociationTypes;

    public class Association : Humidifier.Base.BaseResource, IHaveDevOpsAgentAssociationTypesServiceConfigurationConfiguration, IHaveStringListOfLinkedAssociationIds, IHaveAgentSpaceId, IHaveServiceId
    {
        public class Attributes
        {
            public static string CreatedAt =  "CreatedAt" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string AssociationId =  "AssociationId" ;
        }

        public override string AWSTypeName { get => AWS.DevOpsAgent.Association; }

        /// <summary>
        /// Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-devopsagent-association.html#cfn-devopsagent-association-configuration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ServiceConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.DevOpsAgent.AssociationTypes.ServiceConfiguration, BaseFunction>? Configuration { get; set; }
        /// <summary>
        /// LinkedAssociationIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-devopsagent-association.html#cfn-devopsagent-association-linkedassociationids
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LinkedAssociationIds { get; set; }

        /// <summary>
        /// AgentSpaceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-devopsagent-association.html#cfn-devopsagent-association-agentspaceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AgentSpaceId { get; set; }

        /// <summary>
        /// ServiceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-devopsagent-association.html#cfn-devopsagent-association-serviceid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ServiceId { get; set; }
    }

    namespace AssociationTypes
    {
        public class AWSConfiguration : Humidifier.Base.BaseSubResource, IHaveAssumableRoleArn, IHaveAccountId, IHaveAgentElevatedRoleArn, IHaveListOfDevOpsAgentAssociationTypesAWSResourceResources, IHaveAccountType, IHaveListOfDevOpsAgentAssociationTypesKeyValuePairTags
        {
            /// <summary>
            /// AssumableRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-awsconfiguration.html#cfn-devopsagent-association-awsconfiguration-assumablerolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AssumableRoleArn { get; set; }
            /// <summary>
            /// AccountId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-awsconfiguration.html#cfn-devopsagent-association-awsconfiguration-accountid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccountId { get; set; }
            /// <summary>
            /// AgentElevatedRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-awsconfiguration.html#cfn-devopsagent-association-awsconfiguration-agentelevatedrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AgentElevatedRoleArn { get; set; }
            /// <summary>
            /// Resources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-awsconfiguration.html#cfn-devopsagent-association-awsconfiguration-resources
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AWSResource
            /// </summary>
            public Union<IReadOnlyList<Humidifier.DevOpsAgent.AssociationTypes.AWSResource>, IReadOnlyList<Union<Humidifier.DevOpsAgent.AssociationTypes.AWSResource, BaseFunction>>, BaseFunction>? Resources { get; set; }
            /// <summary>
            /// AccountType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-awsconfiguration.html#cfn-devopsagent-association-awsconfiguration-accounttype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccountType { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-awsconfiguration.html#cfn-devopsagent-association-awsconfiguration-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: KeyValuePair
            /// </summary>
            public Union<IReadOnlyList<Humidifier.DevOpsAgent.AssociationTypes.KeyValuePair>, IReadOnlyList<Union<Humidifier.DevOpsAgent.AssociationTypes.KeyValuePair, BaseFunction>>, BaseFunction>? Tags { get; set; }
        }

        public class AWSResource : Humidifier.Base.BaseSubResource, IHaveResourceMetadata_Json, IHaveResourceArn, IHaveResourceType
        {
            /// <summary>
            /// ResourceMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-awsresource.html#cfn-devopsagent-association-awsresource-resourcemetadata
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? ResourceMetadata { get; set; }
            /// <summary>
            /// ResourceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-awsresource.html#cfn-devopsagent-association-awsresource-resourcearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceArn { get; set; }
            /// <summary>
            /// ResourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-awsresource.html#cfn-devopsagent-association-awsresource-resourcetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceType { get; set; }
        }

        public class AzureConfiguration : Humidifier.Base.BaseSubResource, IHaveSubscriptionId
        {
            /// <summary>
            /// SubscriptionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-azureconfiguration.html#cfn-devopsagent-association-azureconfiguration-subscriptionid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SubscriptionId { get; set; }
        }

        public class DynatraceConfiguration : Humidifier.Base.BaseSubResource, IHaveEnvId, IHaveStringListOfResources, IHaveEnableWebhookUpdates_Boolean
        {
            /// <summary>
            /// EnvId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-dynatraceconfiguration.html#cfn-devopsagent-association-dynatraceconfiguration-envid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EnvId { get; set; }
            /// <summary>
            /// Resources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-dynatraceconfiguration.html#cfn-devopsagent-association-dynatraceconfiguration-resources
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Resources { get; set; }
            /// <summary>
            /// EnableWebhookUpdates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-dynatraceconfiguration.html#cfn-devopsagent-association-dynatraceconfiguration-enablewebhookupdates
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableWebhookUpdates { get; set; }
        }

        public class EventChannelConfiguration : Humidifier.Base.BaseSubResource, IHaveEnableWebhookUpdates_Boolean
        {
            /// <summary>
            /// EnableWebhookUpdates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-eventchannelconfiguration.html#cfn-devopsagent-association-eventchannelconfiguration-enablewebhookupdates
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableWebhookUpdates { get; set; }
        }

        public class GitHubConfiguration : Humidifier.Base.BaseSubResource, IHaveOwner, IHaveOwnerType, IHaveRepoName, IHaveRepoId
        {
            /// <summary>
            /// Owner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-githubconfiguration.html#cfn-devopsagent-association-githubconfiguration-owner
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Owner { get; set; }
            /// <summary>
            /// OwnerType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-githubconfiguration.html#cfn-devopsagent-association-githubconfiguration-ownertype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OwnerType { get; set; }
            /// <summary>
            /// RepoName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-githubconfiguration.html#cfn-devopsagent-association-githubconfiguration-reponame
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RepoName { get; set; }
            /// <summary>
            /// RepoId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-githubconfiguration.html#cfn-devopsagent-association-githubconfiguration-repoid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RepoId { get; set; }
        }

        public class GitLabConfiguration : Humidifier.Base.BaseSubResource, IHaveProjectId, IHaveInstanceIdentifier, IHaveProjectPath, IHaveEnableWebhookUpdates_Boolean
        {
            /// <summary>
            /// ProjectId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-gitlabconfiguration.html#cfn-devopsagent-association-gitlabconfiguration-projectid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProjectId { get; set; }
            /// <summary>
            /// InstanceIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-gitlabconfiguration.html#cfn-devopsagent-association-gitlabconfiguration-instanceidentifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceIdentifier { get; set; }
            /// <summary>
            /// ProjectPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-gitlabconfiguration.html#cfn-devopsagent-association-gitlabconfiguration-projectpath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProjectPath { get; set; }
            /// <summary>
            /// EnableWebhookUpdates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-gitlabconfiguration.html#cfn-devopsagent-association-gitlabconfiguration-enablewebhookupdates
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableWebhookUpdates { get; set; }
        }

        public class KeyValuePair : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-keyvaluepair.html#cfn-devopsagent-association-keyvaluepair-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-keyvaluepair.html#cfn-devopsagent-association-keyvaluepair-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class MCPServerConfiguration : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveEndpoint, IHaveStringListOfTools, IHaveName, IHaveEnableWebhookUpdates_Boolean
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-mcpserverconfiguration.html#cfn-devopsagent-association-mcpserverconfiguration-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Endpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-mcpserverconfiguration.html#cfn-devopsagent-association-mcpserverconfiguration-endpoint
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Endpoint { get; set; }
            /// <summary>
            /// Tools
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-mcpserverconfiguration.html#cfn-devopsagent-association-mcpserverconfiguration-tools
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Tools { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-mcpserverconfiguration.html#cfn-devopsagent-association-mcpserverconfiguration-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
            /// <summary>
            /// EnableWebhookUpdates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-mcpserverconfiguration.html#cfn-devopsagent-association-mcpserverconfiguration-enablewebhookupdates
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableWebhookUpdates { get; set; }
        }

        public class MCPServerDatadogConfiguration : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveEndpoint, IHaveStringListOfEnabledElevatedTools, IHaveName, IHaveEnableWebhookUpdates_Boolean
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-mcpserverdatadogconfiguration.html#cfn-devopsagent-association-mcpserverdatadogconfiguration-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Endpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-mcpserverdatadogconfiguration.html#cfn-devopsagent-association-mcpserverdatadogconfiguration-endpoint
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Endpoint { get; set; }
            /// <summary>
            /// EnabledElevatedTools
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-mcpserverdatadogconfiguration.html#cfn-devopsagent-association-mcpserverdatadogconfiguration-enabledelevatedtools
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EnabledElevatedTools { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-mcpserverdatadogconfiguration.html#cfn-devopsagent-association-mcpserverdatadogconfiguration-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
            /// <summary>
            /// EnableWebhookUpdates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-mcpserverdatadogconfiguration.html#cfn-devopsagent-association-mcpserverdatadogconfiguration-enablewebhookupdates
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableWebhookUpdates { get; set; }
        }

        public class MCPServerGrafanaConfiguration : Humidifier.Base.BaseSubResource, IHaveEndpoint, IHaveStringListOfTools, IHaveStringListOfEnabledElevatedTools, IHaveEnableWebhookUpdates_Boolean
        {
            /// <summary>
            /// Endpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-mcpservergrafanaconfiguration.html#cfn-devopsagent-association-mcpservergrafanaconfiguration-endpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Endpoint { get; set; }
            /// <summary>
            /// Tools
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-mcpservergrafanaconfiguration.html#cfn-devopsagent-association-mcpservergrafanaconfiguration-tools
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Tools { get; set; }
            /// <summary>
            /// EnabledElevatedTools
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-mcpservergrafanaconfiguration.html#cfn-devopsagent-association-mcpservergrafanaconfiguration-enabledelevatedtools
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EnabledElevatedTools { get; set; }
            /// <summary>
            /// EnableWebhookUpdates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-mcpservergrafanaconfiguration.html#cfn-devopsagent-association-mcpservergrafanaconfiguration-enablewebhookupdates
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableWebhookUpdates { get; set; }
        }

        public class MCPServerNewRelicConfiguration : Humidifier.Base.BaseSubResource, IHaveAccountId, IHaveEndpoint
        {
            /// <summary>
            /// AccountId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-mcpservernewrelicconfiguration.html#cfn-devopsagent-association-mcpservernewrelicconfiguration-accountid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccountId { get; set; }
            /// <summary>
            /// Endpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-mcpservernewrelicconfiguration.html#cfn-devopsagent-association-mcpservernewrelicconfiguration-endpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Endpoint { get; set; }
        }

        public class MCPServerSigV4Configuration : Humidifier.Base.BaseSubResource, IHaveStringListOfTools
        {
            /// <summary>
            /// Tools
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-mcpserversigv4configuration.html#cfn-devopsagent-association-mcpserversigv4configuration-tools
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Tools { get; set; }
        }

        public class MCPServerSplunkConfiguration : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveEndpoint, IHaveName, IHaveEnableWebhookUpdates_Boolean
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-mcpserversplunkconfiguration.html#cfn-devopsagent-association-mcpserversplunkconfiguration-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Endpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-mcpserversplunkconfiguration.html#cfn-devopsagent-association-mcpserversplunkconfiguration-endpoint
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Endpoint { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-mcpserversplunkconfiguration.html#cfn-devopsagent-association-mcpserversplunkconfiguration-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
            /// <summary>
            /// EnableWebhookUpdates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-mcpserversplunkconfiguration.html#cfn-devopsagent-association-mcpserversplunkconfiguration-enablewebhookupdates
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableWebhookUpdates { get; set; }
        }

        public class PagerDutyConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfServices, IHaveCustomerEmail, IHaveEnableWebhookUpdates_Boolean
        {
            /// <summary>
            /// Services
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-pagerdutyconfiguration.html#cfn-devopsagent-association-pagerdutyconfiguration-services
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Services { get; set; }
            /// <summary>
            /// CustomerEmail
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-pagerdutyconfiguration.html#cfn-devopsagent-association-pagerdutyconfiguration-customeremail
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CustomerEmail { get; set; }
            /// <summary>
            /// EnableWebhookUpdates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-pagerdutyconfiguration.html#cfn-devopsagent-association-pagerdutyconfiguration-enablewebhookupdates
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableWebhookUpdates { get; set; }
        }

        public class ServiceConfiguration : Humidifier.Base.BaseSubResource, IHaveDevOpsAgentAssociationTypesMCPServerConfigurationMCPServer, IHaveDevOpsAgentAssociationTypesServiceNowConfigurationServiceNow, IHaveDevOpsAgentAssociationTypesAzureConfigurationAzure, IHaveDevOpsAgentAssociationTypesGitHubConfigurationGitHub, IHaveDevOpsAgentAssociationTypesMCPServerGrafanaConfigurationMCPServerGrafana, IHaveDevOpsAgentAssociationTypesMCPServerSplunkConfigurationMCPServerSplunk, IHaveDevOpsAgentAssociationTypesMCPServerNewRelicConfigurationMCPServerNewRelic, IHaveDevOpsAgentAssociationTypesPagerDutyConfigurationPagerDuty, IHaveDevOpsAgentAssociationTypesEventChannelConfigurationEventChannel, IHaveDevOpsAgentAssociationTypesSourceAwsConfigurationSourceAws, IHaveDevOpsAgentAssociationTypesSlackConfigurationSlack, IHaveDevOpsAgentAssociationTypesMCPServerDatadogConfigurationMCPServerDatadog, IHaveDevOpsAgentAssociationTypesDynatraceConfigurationDynatrace, IHaveDevOpsAgentAssociationTypesMCPServerSigV4ConfigurationMCPServerSigV4, IHaveDevOpsAgentAssociationTypesAWSConfigurationAws, IHaveDevOpsAgentAssociationTypesGitLabConfigurationGitLab
        {
            /// <summary>
            /// MCPServer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-serviceconfiguration.html#cfn-devopsagent-association-serviceconfiguration-mcpserver
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MCPServerConfiguration
            /// </summary>
            public Union<Humidifier.DevOpsAgent.AssociationTypes.MCPServerConfiguration, BaseFunction>? MCPServer { get; set; }
            /// <summary>
            /// ServiceNow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-serviceconfiguration.html#cfn-devopsagent-association-serviceconfiguration-servicenow
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ServiceNowConfiguration
            /// </summary>
            public Union<Humidifier.DevOpsAgent.AssociationTypes.ServiceNowConfiguration, BaseFunction>? ServiceNow { get; set; }
            /// <summary>
            /// Azure
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-serviceconfiguration.html#cfn-devopsagent-association-serviceconfiguration-azure
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AzureConfiguration
            /// </summary>
            public Union<Humidifier.DevOpsAgent.AssociationTypes.AzureConfiguration, BaseFunction>? Azure { get; set; }
            /// <summary>
            /// GitHub
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-serviceconfiguration.html#cfn-devopsagent-association-serviceconfiguration-github
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GitHubConfiguration
            /// </summary>
            public Union<Humidifier.DevOpsAgent.AssociationTypes.GitHubConfiguration, BaseFunction>? GitHub { get; set; }
            /// <summary>
            /// MCPServerGrafana
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-serviceconfiguration.html#cfn-devopsagent-association-serviceconfiguration-mcpservergrafana
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MCPServerGrafanaConfiguration
            /// </summary>
            public Union<Humidifier.DevOpsAgent.AssociationTypes.MCPServerGrafanaConfiguration, BaseFunction>? MCPServerGrafana { get; set; }
            /// <summary>
            /// MCPServerSplunk
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-serviceconfiguration.html#cfn-devopsagent-association-serviceconfiguration-mcpserversplunk
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MCPServerSplunkConfiguration
            /// </summary>
            public Union<Humidifier.DevOpsAgent.AssociationTypes.MCPServerSplunkConfiguration, BaseFunction>? MCPServerSplunk { get; set; }
            /// <summary>
            /// MCPServerNewRelic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-serviceconfiguration.html#cfn-devopsagent-association-serviceconfiguration-mcpservernewrelic
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MCPServerNewRelicConfiguration
            /// </summary>
            public Union<Humidifier.DevOpsAgent.AssociationTypes.MCPServerNewRelicConfiguration, BaseFunction>? MCPServerNewRelic { get; set; }
            /// <summary>
            /// PagerDuty
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-serviceconfiguration.html#cfn-devopsagent-association-serviceconfiguration-pagerduty
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PagerDutyConfiguration
            /// </summary>
            public Union<Humidifier.DevOpsAgent.AssociationTypes.PagerDutyConfiguration, BaseFunction>? PagerDuty { get; set; }
            /// <summary>
            /// EventChannel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-serviceconfiguration.html#cfn-devopsagent-association-serviceconfiguration-eventchannel
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EventChannelConfiguration
            /// </summary>
            public Union<Humidifier.DevOpsAgent.AssociationTypes.EventChannelConfiguration, BaseFunction>? EventChannel { get; set; }
            /// <summary>
            /// SourceAws
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-serviceconfiguration.html#cfn-devopsagent-association-serviceconfiguration-sourceaws
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SourceAwsConfiguration
            /// </summary>
            public Union<Humidifier.DevOpsAgent.AssociationTypes.SourceAwsConfiguration, BaseFunction>? SourceAws { get; set; }
            /// <summary>
            /// Slack
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-serviceconfiguration.html#cfn-devopsagent-association-serviceconfiguration-slack
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SlackConfiguration
            /// </summary>
            public Union<Humidifier.DevOpsAgent.AssociationTypes.SlackConfiguration, BaseFunction>? Slack { get; set; }
            /// <summary>
            /// MCPServerDatadog
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-serviceconfiguration.html#cfn-devopsagent-association-serviceconfiguration-mcpserverdatadog
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MCPServerDatadogConfiguration
            /// </summary>
            public Union<Humidifier.DevOpsAgent.AssociationTypes.MCPServerDatadogConfiguration, BaseFunction>? MCPServerDatadog { get; set; }
            /// <summary>
            /// Dynatrace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-serviceconfiguration.html#cfn-devopsagent-association-serviceconfiguration-dynatrace
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DynatraceConfiguration
            /// </summary>
            public Union<Humidifier.DevOpsAgent.AssociationTypes.DynatraceConfiguration, BaseFunction>? Dynatrace { get; set; }
            /// <summary>
            /// MCPServerSigV4
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-serviceconfiguration.html#cfn-devopsagent-association-serviceconfiguration-mcpserversigv4
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MCPServerSigV4Configuration
            /// </summary>
            public Union<Humidifier.DevOpsAgent.AssociationTypes.MCPServerSigV4Configuration, BaseFunction>? MCPServerSigV4 { get; set; }
            /// <summary>
            /// Aws
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-serviceconfiguration.html#cfn-devopsagent-association-serviceconfiguration-aws
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AWSConfiguration
            /// </summary>
            public Union<Humidifier.DevOpsAgent.AssociationTypes.AWSConfiguration, BaseFunction>? Aws { get; set; }
            /// <summary>
            /// GitLab
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-serviceconfiguration.html#cfn-devopsagent-association-serviceconfiguration-gitlab
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GitLabConfiguration
            /// </summary>
            public Union<Humidifier.DevOpsAgent.AssociationTypes.GitLabConfiguration, BaseFunction>? GitLab { get; set; }
        }

        public class ServiceNowConfiguration : Humidifier.Base.BaseSubResource, IHaveInstanceId, IHaveEnableWebhookUpdates_Boolean
        {
            /// <summary>
            /// InstanceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-servicenowconfiguration.html#cfn-devopsagent-association-servicenowconfiguration-instanceid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceId { get; set; }
            /// <summary>
            /// EnableWebhookUpdates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-servicenowconfiguration.html#cfn-devopsagent-association-servicenowconfiguration-enablewebhookupdates
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableWebhookUpdates { get; set; }
        }

        public class SlackBidirectionalConfiguration : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean, IHaveRoleArn
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-slackbidirectionalconfiguration.html#cfn-devopsagent-association-slackbidirectionalconfiguration-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-slackbidirectionalconfiguration.html#cfn-devopsagent-association-slackbidirectionalconfiguration-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class SlackChannel : Humidifier.Base.BaseSubResource, IHaveChannelName, IHaveChannelId
        {
            /// <summary>
            /// ChannelName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-slackchannel.html#cfn-devopsagent-association-slackchannel-channelname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ChannelName { get; set; }
            /// <summary>
            /// ChannelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-slackchannel.html#cfn-devopsagent-association-slackchannel-channelid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ChannelId { get; set; }
        }

        public class SlackConfiguration : Humidifier.Base.BaseSubResource, IHaveDevOpsAgentAssociationTypesSlackTransmissionTargetTransmissionTarget, IHaveDevOpsAgentAssociationTypesSlackBidirectionalConfigurationBidirectional, IHaveWorkspaceId, IHaveWorkspaceName
        {
            /// <summary>
            /// TransmissionTarget
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-slackconfiguration.html#cfn-devopsagent-association-slackconfiguration-transmissiontarget
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SlackTransmissionTarget
            /// </summary>
            public Union<Humidifier.DevOpsAgent.AssociationTypes.SlackTransmissionTarget, BaseFunction>? TransmissionTarget { get; set; }
            /// <summary>
            /// Bidirectional
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-slackconfiguration.html#cfn-devopsagent-association-slackconfiguration-bidirectional
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SlackBidirectionalConfiguration
            /// </summary>
            public Union<Humidifier.DevOpsAgent.AssociationTypes.SlackBidirectionalConfiguration, BaseFunction>? Bidirectional { get; set; }
            /// <summary>
            /// WorkspaceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-slackconfiguration.html#cfn-devopsagent-association-slackconfiguration-workspaceid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WorkspaceId { get; set; }
            /// <summary>
            /// WorkspaceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-slackconfiguration.html#cfn-devopsagent-association-slackconfiguration-workspacename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WorkspaceName { get; set; }
        }

        public class SlackTransmissionTarget : Humidifier.Base.BaseSubResource, IHaveDevOpsAgentAssociationTypesSlackChannelIncidentResponseTarget
        {
            /// <summary>
            /// IncidentResponseTarget
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-slacktransmissiontarget.html#cfn-devopsagent-association-slacktransmissiontarget-incidentresponsetarget
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SlackChannel
            /// </summary>
            public Union<Humidifier.DevOpsAgent.AssociationTypes.SlackChannel, BaseFunction>? IncidentResponseTarget { get; set; }
        }

        public class SourceAwsConfiguration : Humidifier.Base.BaseSubResource, IHaveAssumableRoleArn, IHaveAccountId, IHaveAgentElevatedRoleArn, IHaveListOfDevOpsAgentAssociationTypesAWSResourceResources, IHaveAccountType, IHaveListOfDevOpsAgentAssociationTypesKeyValuePairTags
        {
            /// <summary>
            /// AssumableRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-sourceawsconfiguration.html#cfn-devopsagent-association-sourceawsconfiguration-assumablerolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AssumableRoleArn { get; set; }
            /// <summary>
            /// AccountId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-sourceawsconfiguration.html#cfn-devopsagent-association-sourceawsconfiguration-accountid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccountId { get; set; }
            /// <summary>
            /// AgentElevatedRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-sourceawsconfiguration.html#cfn-devopsagent-association-sourceawsconfiguration-agentelevatedrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AgentElevatedRoleArn { get; set; }
            /// <summary>
            /// Resources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-sourceawsconfiguration.html#cfn-devopsagent-association-sourceawsconfiguration-resources
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AWSResource
            /// </summary>
            public Union<IReadOnlyList<Humidifier.DevOpsAgent.AssociationTypes.AWSResource>, IReadOnlyList<Union<Humidifier.DevOpsAgent.AssociationTypes.AWSResource, BaseFunction>>, BaseFunction>? Resources { get; set; }
            /// <summary>
            /// AccountType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-sourceawsconfiguration.html#cfn-devopsagent-association-sourceawsconfiguration-accounttype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccountType { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-association-sourceawsconfiguration.html#cfn-devopsagent-association-sourceawsconfiguration-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: KeyValuePair
            /// </summary>
            public Union<IReadOnlyList<Humidifier.DevOpsAgent.AssociationTypes.KeyValuePair>, IReadOnlyList<Union<Humidifier.DevOpsAgent.AssociationTypes.KeyValuePair, BaseFunction>>, BaseFunction>? Tags { get; set; }
        }
    }
}