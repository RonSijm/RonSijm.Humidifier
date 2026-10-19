namespace Humidifier.AgentRegistry
{
    using global::System.Collections.Generic;
    using RegistryRecordTypes;

    public class RegistryRecord : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription, IHaveDisplayName, IHaveRegistryId
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CreatedBy =  "CreatedBy" ;
            public static string RecordArn =  "RecordArn" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string RecordId =  "RecordId" ;
            public static string RegistryArn =  "RegistryArn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.AgentRegistry.RegistryRecord; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-agentregistry-registryrecord.html#cfn-agentregistry-registryrecord-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// RecordVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-agentregistry-registryrecord.html#cfn-agentregistry-registryrecord-recordversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RecordVersion { get; set; }

        /// <summary>
        /// RecordType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-agentregistry-registryrecord.html#cfn-agentregistry-registryrecord-recordtype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RecordType { get; set; }
        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-agentregistry-registryrecord.html#cfn-agentregistry-registryrecord-displayname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DisplayName { get; set; }
        /// <summary>
        /// RegistryId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-agentregistry-registryrecord.html#cfn-agentregistry-registryrecord-registryid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RegistryId { get; set; }

        /// <summary>
        /// Descriptors
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-agentregistry-registryrecord.html#cfn-agentregistry-registryrecord-descriptors
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Descriptors
        /// </summary>
        [Required]
        public Humidifier.AgentRegistry.RegistryRecordTypes.Descriptors Descriptors { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-agentregistry-registryrecord.html#cfn-agentregistry-registryrecord-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// CustomMetadata
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-agentregistry-registryrecord.html#cfn-agentregistry-registryrecord-custommetadata
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic CustomMetadata { get; set; }
    }

    namespace RegistryRecordTypes
    {
        public class A2aAgentCardDescriptor : Humidifier.Base.BaseSubResource, IHaveData
        {
            /// <summary>
            /// DataSchemaVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-a2aagentcarddescriptor.html#cfn-agentregistry-registryrecord-a2aagentcarddescriptor-dataschemaversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSchemaVersion { get; set; }
            /// <summary>
            /// Data
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-a2aagentcarddescriptor.html#cfn-agentregistry-registryrecord-a2aagentcarddescriptor-data
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Data { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-a2aagentcarddescriptor.html#cfn-agentregistry-registryrecord-a2aagentcarddescriptor-source
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DescriptorSource
            /// </summary>
            public Humidifier.AgentRegistry.RegistryRecordTypes.DescriptorSource Source { get; set; }
        }

        public class AgUiDescriptor : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-aguidescriptor.html#cfn-agentregistry-registryrecord-aguidescriptor-source
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SourceOnlyDescriptorSource
            /// </summary>
            public Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSource Source { get; set; }
        }

        public class AgentSkillsAdditionalData : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SkillMd
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-agentskillsadditionaldata.html#cfn-agentregistry-registryrecord-agentskillsadditionaldata-skillmd
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AgentSkillsMdDescriptor
            /// </summary>
            public Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsMdDescriptor SkillMd { get; set; }
        }

        public class AgentSkillsDefinitionDescriptor : Humidifier.Base.BaseSubResource, IHaveData
        {
            /// <summary>
            /// AdditionalData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-agentskillsdefinitiondescriptor.html#cfn-agentregistry-registryrecord-agentskillsdefinitiondescriptor-additionaldata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AgentSkillsAdditionalData
            /// </summary>
            public Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsAdditionalData AdditionalData { get; set; }
            /// <summary>
            /// DataSchemaVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-agentskillsdefinitiondescriptor.html#cfn-agentregistry-registryrecord-agentskillsdefinitiondescriptor-dataschemaversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSchemaVersion { get; set; }
            /// <summary>
            /// Data
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-agentskillsdefinitiondescriptor.html#cfn-agentregistry-registryrecord-agentskillsdefinitiondescriptor-data
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Data { get; set; }
        }

        public class AgentSkillsMdDescriptor : Humidifier.Base.BaseSubResource, IHaveData
        {
            /// <summary>
            /// DataSchemaVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-agentskillsmddescriptor.html#cfn-agentregistry-registryrecord-agentskillsmddescriptor-dataschemaversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSchemaVersion { get; set; }
            /// <summary>
            /// Data
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-agentskillsmddescriptor.html#cfn-agentregistry-registryrecord-agentskillsmddescriptor-data
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Data { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-agentskillsmddescriptor.html#cfn-agentregistry-registryrecord-agentskillsmddescriptor-source
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SkillMdSource
            /// </summary>
            public Humidifier.AgentRegistry.RegistryRecordTypes.SkillMdSource Source { get; set; }
        }

        public class CustomDescriptor : Humidifier.Base.BaseSubResource, IHaveData
        {
            /// <summary>
            /// Data
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-customdescriptor.html#cfn-agentregistry-registryrecord-customdescriptor-data
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Data { get; set; }
        }

        public class DescriptorSource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FromUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-descriptorsource.html#cfn-agentregistry-registryrecord-descriptorsource-fromurl
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DescriptorSourceFromUrl
            /// </summary>
            public Humidifier.AgentRegistry.RegistryRecordTypes.DescriptorSourceFromUrl FromUrl { get; set; }
        }

        public class DescriptorSourceFromUrl : Humidifier.Base.BaseSubResource, IHaveUrl
        {
            /// <summary>
            /// CredentialProviderConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-descriptorsourcefromurl.html#cfn-agentregistry-registryrecord-descriptorsourcefromurl-credentialproviderconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RegistryRecordCredentialProviderConfiguration
            /// </summary>
            public List<Humidifier.AgentRegistry.RegistryRecordTypes.RegistryRecordCredentialProviderConfiguration> CredentialProviderConfigurations { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-descriptorsourcefromurl.html#cfn-agentregistry-registryrecord-descriptorsourcefromurl-url
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Url { get; set; }
        }

        public class Descriptors : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AgentSkillsDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-descriptors.html#cfn-agentregistry-registryrecord-descriptors-agentskillsdefinition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AgentSkillsDefinitionDescriptor
            /// </summary>
            public Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsDefinitionDescriptor AgentSkillsDefinition { get; set; }
            /// <summary>
            /// A2aAgentCard
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-descriptors.html#cfn-agentregistry-registryrecord-descriptors-a2aagentcard
            /// Required: False
            /// UpdateType: Mutable
            /// Type: A2aAgentCardDescriptor
            /// </summary>
            public Humidifier.AgentRegistry.RegistryRecordTypes.A2aAgentCardDescriptor A2aAgentCard { get; set; }
            /// <summary>
            /// Agui
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-descriptors.html#cfn-agentregistry-registryrecord-descriptors-agui
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AgUiDescriptor
            /// </summary>
            public Humidifier.AgentRegistry.RegistryRecordTypes.AgUiDescriptor Agui { get; set; }
            /// <summary>
            /// McpServer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-descriptors.html#cfn-agentregistry-registryrecord-descriptors-mcpserver
            /// Required: False
            /// UpdateType: Mutable
            /// Type: McpServerDescriptor
            /// </summary>
            public Humidifier.AgentRegistry.RegistryRecordTypes.McpServerDescriptor McpServer { get; set; }
            /// <summary>
            /// Custom
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-descriptors.html#cfn-agentregistry-registryrecord-descriptors-custom
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomDescriptor
            /// </summary>
            public Humidifier.AgentRegistry.RegistryRecordTypes.CustomDescriptor Custom { get; set; }
            /// <summary>
            /// Http
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-descriptors.html#cfn-agentregistry-registryrecord-descriptors-http
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpDescriptor
            /// </summary>
            public Humidifier.AgentRegistry.RegistryRecordTypes.HttpDescriptor Http { get; set; }
        }

        public class HttpDescriptor : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-httpdescriptor.html#cfn-agentregistry-registryrecord-httpdescriptor-source
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SourceOnlyDescriptorSource
            /// </summary>
            public Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSource Source { get; set; }
        }

        public class McpServerAdditionalData : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Tools
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-mcpserveradditionaldata.html#cfn-agentregistry-registryrecord-mcpserveradditionaldata-tools
            /// Required: False
            /// UpdateType: Mutable
            /// Type: McpToolsDescriptor
            /// </summary>
            public Humidifier.AgentRegistry.RegistryRecordTypes.McpToolsDescriptor Tools { get; set; }
        }

        public class McpServerDescriptor : Humidifier.Base.BaseSubResource, IHaveData
        {
            /// <summary>
            /// AdditionalData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-mcpserverdescriptor.html#cfn-agentregistry-registryrecord-mcpserverdescriptor-additionaldata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: McpServerAdditionalData
            /// </summary>
            public Humidifier.AgentRegistry.RegistryRecordTypes.McpServerAdditionalData AdditionalData { get; set; }
            /// <summary>
            /// DataSchemaVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-mcpserverdescriptor.html#cfn-agentregistry-registryrecord-mcpserverdescriptor-dataschemaversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSchemaVersion { get; set; }
            /// <summary>
            /// Data
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-mcpserverdescriptor.html#cfn-agentregistry-registryrecord-mcpserverdescriptor-data
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Data { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-mcpserverdescriptor.html#cfn-agentregistry-registryrecord-mcpserverdescriptor-source
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DescriptorSource
            /// </summary>
            public Humidifier.AgentRegistry.RegistryRecordTypes.DescriptorSource Source { get; set; }
        }

        public class McpToolsDescriptor : Humidifier.Base.BaseSubResource, IHaveData
        {
            /// <summary>
            /// DataSchemaVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-mcptoolsdescriptor.html#cfn-agentregistry-registryrecord-mcptoolsdescriptor-dataschemaversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSchemaVersion { get; set; }
            /// <summary>
            /// Data
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-mcptoolsdescriptor.html#cfn-agentregistry-registryrecord-mcptoolsdescriptor-data
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Data { get; set; }
        }

        public class RegistryRecordCredentialProviderConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CredentialProvider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-registryrecordcredentialproviderconfiguration.html#cfn-agentregistry-registryrecord-registryrecordcredentialproviderconfiguration-credentialprovider
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RegistryRecordCredentialProviderUnion
            /// </summary>
            public Humidifier.AgentRegistry.RegistryRecordTypes.RegistryRecordCredentialProviderUnion CredentialProvider { get; set; }
            /// <summary>
            /// CredentialProviderType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-registryrecordcredentialproviderconfiguration.html#cfn-agentregistry-registryrecord-registryrecordcredentialproviderconfiguration-credentialprovidertype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CredentialProviderType { get; set; }
        }

        public class RegistryRecordCredentialProviderUnion : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// OauthCredentialProvider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-registryrecordcredentialproviderunion.html#cfn-agentregistry-registryrecord-registryrecordcredentialproviderunion-oauthcredentialprovider
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RegistryRecordOAuthCredentialProvider
            /// </summary>
            public Humidifier.AgentRegistry.RegistryRecordTypes.RegistryRecordOAuthCredentialProvider OauthCredentialProvider { get; set; }
            /// <summary>
            /// IamCredentialProvider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-registryrecordcredentialproviderunion.html#cfn-agentregistry-registryrecord-registryrecordcredentialproviderunion-iamcredentialprovider
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RegistryRecordIamCredentialProvider
            /// </summary>
            public Humidifier.AgentRegistry.RegistryRecordTypes.RegistryRecordIamCredentialProvider IamCredentialProvider { get; set; }
        }

        public class RegistryRecordIamCredentialProvider : Humidifier.Base.BaseSubResource, IHaveRoleArn, IHaveRegion, IHaveService
        {
            /// <summary>
            /// Service
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-registryrecordiamcredentialprovider.html#cfn-agentregistry-registryrecord-registryrecordiamcredentialprovider-service
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Service { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-registryrecordiamcredentialprovider.html#cfn-agentregistry-registryrecord-registryrecordiamcredentialprovider-region
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Region { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-registryrecordiamcredentialprovider.html#cfn-agentregistry-registryrecord-registryrecordiamcredentialprovider-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn { get; set; }
        }

        public class RegistryRecordOAuthCredentialProvider : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ProviderArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-registryrecordoauthcredentialprovider.html#cfn-agentregistry-registryrecord-registryrecordoauthcredentialprovider-providerarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ProviderArn { get; set; }
            /// <summary>
            /// Scopes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-registryrecordoauthcredentialprovider.html#cfn-agentregistry-registryrecord-registryrecordoauthcredentialprovider-scopes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Scopes { get; set; }
            /// <summary>
            /// GrantType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-registryrecordoauthcredentialprovider.html#cfn-agentregistry-registryrecord-registryrecordoauthcredentialprovider-granttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GrantType { get; set; }
            /// <summary>
            /// CustomParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-registryrecordoauthcredentialprovider.html#cfn-agentregistry-registryrecord-registryrecordoauthcredentialprovider-customparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> CustomParameters { get; set; }
        }

        public class SkillMdSource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FromUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-skillmdsource.html#cfn-agentregistry-registryrecord-skillmdsource-fromurl
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SkillMdSourceFromUrl
            /// </summary>
            public Humidifier.AgentRegistry.RegistryRecordTypes.SkillMdSourceFromUrl FromUrl { get; set; }
        }

        public class SkillMdSourceFromUrl : Humidifier.Base.BaseSubResource, IHaveUrl
        {
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-skillmdsourcefromurl.html#cfn-agentregistry-registryrecord-skillmdsourcefromurl-url
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Url { get; set; }
        }

        public class SourceOnlyDescriptorSource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FromUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-sourceonlydescriptorsource.html#cfn-agentregistry-registryrecord-sourceonlydescriptorsource-fromurl
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SourceOnlyDescriptorSourceFromUrl
            /// </summary>
            public Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSourceFromUrl FromUrl { get; set; }
        }

        public class SourceOnlyDescriptorSourceFromUrl : Humidifier.Base.BaseSubResource, IHaveUrl
        {
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-sourceonlydescriptorsourcefromurl.html#cfn-agentregistry-registryrecord-sourceonlydescriptorsourcefromurl-url
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Url { get; set; }
        }
    }
}