namespace Humidifier.AgentRegistry
{
    using global::System.Collections.Generic;
    using RegistryRecordTypes;

    public class RegistryRecord : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveRecordVersion, IHaveRecordType, IHaveDisplayName, IHaveRegistryId, IHaveAgentRegistryRegistryRecordTypesDescriptorsDescriptors, IHaveName, IHaveCustomMetadata_Json
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
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// RecordVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-agentregistry-registryrecord.html#cfn-agentregistry-registryrecord-recordversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RecordVersion { get; set; }

        /// <summary>
        /// RecordType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-agentregistry-registryrecord.html#cfn-agentregistry-registryrecord-recordtype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RecordType { get; set; }
        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-agentregistry-registryrecord.html#cfn-agentregistry-registryrecord-displayname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DisplayName { get; set; }
        /// <summary>
        /// RegistryId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-agentregistry-registryrecord.html#cfn-agentregistry-registryrecord-registryid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RegistryId { get; set; }

        /// <summary>
        /// Descriptors
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-agentregistry-registryrecord.html#cfn-agentregistry-registryrecord-descriptors
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Descriptors
        /// </summary>
        [Required]
        public Union<Humidifier.AgentRegistry.RegistryRecordTypes.Descriptors, BaseFunction>? Descriptors { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-agentregistry-registryrecord.html#cfn-agentregistry-registryrecord-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// CustomMetadata
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-agentregistry-registryrecord.html#cfn-agentregistry-registryrecord-custommetadata
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? CustomMetadata { get; set; }
    }

    namespace RegistryRecordTypes
    {
        public class A2aAgentCardDescriptor : Humidifier.Base.BaseSubResource, IHaveDataSchemaVersion, IHaveData, IHaveAgentRegistryRegistryRecordTypesDescriptorSourceSource
        {
            /// <summary>
            /// DataSchemaVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-a2aagentcarddescriptor.html#cfn-agentregistry-registryrecord-a2aagentcarddescriptor-dataschemaversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataSchemaVersion { get; set; }
            /// <summary>
            /// Data
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-a2aagentcarddescriptor.html#cfn-agentregistry-registryrecord-a2aagentcarddescriptor-data
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Data { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-a2aagentcarddescriptor.html#cfn-agentregistry-registryrecord-a2aagentcarddescriptor-source
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DescriptorSource
            /// </summary>
            public Union<Humidifier.AgentRegistry.RegistryRecordTypes.DescriptorSource, BaseFunction>? Source { get; set; }
        }

        public class AgUiDescriptor : Humidifier.Base.BaseSubResource, IHaveAgentRegistryRegistryRecordTypesSourceOnlyDescriptorSourceSource
        {
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-aguidescriptor.html#cfn-agentregistry-registryrecord-aguidescriptor-source
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SourceOnlyDescriptorSource
            /// </summary>
            public Union<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSource, BaseFunction>? Source { get; set; }
        }

        public class AgentSkillsAdditionalData : Humidifier.Base.BaseSubResource, IHaveAgentRegistryRegistryRecordTypesAgentSkillsMdDescriptorSkillMd
        {
            /// <summary>
            /// SkillMd
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-agentskillsadditionaldata.html#cfn-agentregistry-registryrecord-agentskillsadditionaldata-skillmd
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AgentSkillsMdDescriptor
            /// </summary>
            public Union<Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsMdDescriptor, BaseFunction>? SkillMd { get; set; }
        }

        public class AgentSkillsDefinitionDescriptor : Humidifier.Base.BaseSubResource, IHaveAgentRegistryRegistryRecordTypesAgentSkillsAdditionalDataAdditionalData, IHaveDataSchemaVersion, IHaveData
        {
            /// <summary>
            /// AdditionalData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-agentskillsdefinitiondescriptor.html#cfn-agentregistry-registryrecord-agentskillsdefinitiondescriptor-additionaldata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AgentSkillsAdditionalData
            /// </summary>
            public Union<Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsAdditionalData, BaseFunction>? AdditionalData { get; set; }
            /// <summary>
            /// DataSchemaVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-agentskillsdefinitiondescriptor.html#cfn-agentregistry-registryrecord-agentskillsdefinitiondescriptor-dataschemaversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataSchemaVersion { get; set; }
            /// <summary>
            /// Data
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-agentskillsdefinitiondescriptor.html#cfn-agentregistry-registryrecord-agentskillsdefinitiondescriptor-data
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Data { get; set; }
        }

        public class AgentSkillsMdDescriptor : Humidifier.Base.BaseSubResource, IHaveDataSchemaVersion, IHaveData, IHaveAgentRegistryRegistryRecordTypesSkillMdSourceSource
        {
            /// <summary>
            /// DataSchemaVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-agentskillsmddescriptor.html#cfn-agentregistry-registryrecord-agentskillsmddescriptor-dataschemaversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataSchemaVersion { get; set; }
            /// <summary>
            /// Data
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-agentskillsmddescriptor.html#cfn-agentregistry-registryrecord-agentskillsmddescriptor-data
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Data { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-agentskillsmddescriptor.html#cfn-agentregistry-registryrecord-agentskillsmddescriptor-source
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SkillMdSource
            /// </summary>
            public Union<Humidifier.AgentRegistry.RegistryRecordTypes.SkillMdSource, BaseFunction>? Source { get; set; }
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
            public Union<string, BaseFunction>? Data { get; set; }
        }

        public class DescriptorSource : Humidifier.Base.BaseSubResource, IHaveAgentRegistryRegistryRecordTypesDescriptorSourceFromUrlFromUrl
        {
            /// <summary>
            /// FromUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-descriptorsource.html#cfn-agentregistry-registryrecord-descriptorsource-fromurl
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DescriptorSourceFromUrl
            /// </summary>
            public Union<Humidifier.AgentRegistry.RegistryRecordTypes.DescriptorSourceFromUrl, BaseFunction>? FromUrl { get; set; }
        }

        public class DescriptorSourceFromUrl : Humidifier.Base.BaseSubResource, IHaveListOfAgentRegistryRegistryRecordTypesRegistryRecordCredentialProviderConfigurationCredentialProviderConfigurations, IHaveUrl
        {
            /// <summary>
            /// CredentialProviderConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-descriptorsourcefromurl.html#cfn-agentregistry-registryrecord-descriptorsourcefromurl-credentialproviderconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RegistryRecordCredentialProviderConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.AgentRegistry.RegistryRecordTypes.RegistryRecordCredentialProviderConfiguration>, IReadOnlyList<Union<Humidifier.AgentRegistry.RegistryRecordTypes.RegistryRecordCredentialProviderConfiguration, BaseFunction>>, BaseFunction>? CredentialProviderConfigurations { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-descriptorsourcefromurl.html#cfn-agentregistry-registryrecord-descriptorsourcefromurl-url
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Url { get; set; }
        }

        public class Descriptors : Humidifier.Base.BaseSubResource, IHaveAgentRegistryRegistryRecordTypesAgentSkillsDefinitionDescriptorAgentSkillsDefinition, IHaveAgentRegistryRegistryRecordTypesA2aAgentCardDescriptorA2aAgentCard, IHaveAgentRegistryRegistryRecordTypesAgUiDescriptorAgui, IHaveAgentRegistryRegistryRecordTypesMcpServerDescriptorMcpServer, IHaveAgentRegistryRegistryRecordTypesCustomDescriptorCustom, IHaveAgentRegistryRegistryRecordTypesHttpDescriptorHttp
        {
            /// <summary>
            /// AgentSkillsDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-descriptors.html#cfn-agentregistry-registryrecord-descriptors-agentskillsdefinition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AgentSkillsDefinitionDescriptor
            /// </summary>
            public Union<Humidifier.AgentRegistry.RegistryRecordTypes.AgentSkillsDefinitionDescriptor, BaseFunction>? AgentSkillsDefinition { get; set; }
            /// <summary>
            /// A2aAgentCard
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-descriptors.html#cfn-agentregistry-registryrecord-descriptors-a2aagentcard
            /// Required: False
            /// UpdateType: Mutable
            /// Type: A2aAgentCardDescriptor
            /// </summary>
            public Union<Humidifier.AgentRegistry.RegistryRecordTypes.A2aAgentCardDescriptor, BaseFunction>? A2aAgentCard { get; set; }
            /// <summary>
            /// Agui
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-descriptors.html#cfn-agentregistry-registryrecord-descriptors-agui
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AgUiDescriptor
            /// </summary>
            public Union<Humidifier.AgentRegistry.RegistryRecordTypes.AgUiDescriptor, BaseFunction>? Agui { get; set; }
            /// <summary>
            /// McpServer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-descriptors.html#cfn-agentregistry-registryrecord-descriptors-mcpserver
            /// Required: False
            /// UpdateType: Mutable
            /// Type: McpServerDescriptor
            /// </summary>
            public Union<Humidifier.AgentRegistry.RegistryRecordTypes.McpServerDescriptor, BaseFunction>? McpServer { get; set; }
            /// <summary>
            /// Custom
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-descriptors.html#cfn-agentregistry-registryrecord-descriptors-custom
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomDescriptor
            /// </summary>
            public Union<Humidifier.AgentRegistry.RegistryRecordTypes.CustomDescriptor, BaseFunction>? Custom { get; set; }
            /// <summary>
            /// Http
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-descriptors.html#cfn-agentregistry-registryrecord-descriptors-http
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpDescriptor
            /// </summary>
            public Union<Humidifier.AgentRegistry.RegistryRecordTypes.HttpDescriptor, BaseFunction>? Http { get; set; }
        }

        public class HttpDescriptor : Humidifier.Base.BaseSubResource, IHaveAgentRegistryRegistryRecordTypesSourceOnlyDescriptorSourceSource
        {
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-httpdescriptor.html#cfn-agentregistry-registryrecord-httpdescriptor-source
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SourceOnlyDescriptorSource
            /// </summary>
            public Union<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSource, BaseFunction>? Source { get; set; }
        }

        public class McpServerAdditionalData : Humidifier.Base.BaseSubResource, IHaveAgentRegistryRegistryRecordTypesMcpToolsDescriptorTools
        {
            /// <summary>
            /// Tools
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-mcpserveradditionaldata.html#cfn-agentregistry-registryrecord-mcpserveradditionaldata-tools
            /// Required: False
            /// UpdateType: Mutable
            /// Type: McpToolsDescriptor
            /// </summary>
            public Union<Humidifier.AgentRegistry.RegistryRecordTypes.McpToolsDescriptor, BaseFunction>? Tools { get; set; }
        }

        public class McpServerDescriptor : Humidifier.Base.BaseSubResource, IHaveAgentRegistryRegistryRecordTypesMcpServerAdditionalDataAdditionalData, IHaveDataSchemaVersion, IHaveData, IHaveAgentRegistryRegistryRecordTypesDescriptorSourceSource
        {
            /// <summary>
            /// AdditionalData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-mcpserverdescriptor.html#cfn-agentregistry-registryrecord-mcpserverdescriptor-additionaldata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: McpServerAdditionalData
            /// </summary>
            public Union<Humidifier.AgentRegistry.RegistryRecordTypes.McpServerAdditionalData, BaseFunction>? AdditionalData { get; set; }
            /// <summary>
            /// DataSchemaVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-mcpserverdescriptor.html#cfn-agentregistry-registryrecord-mcpserverdescriptor-dataschemaversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataSchemaVersion { get; set; }
            /// <summary>
            /// Data
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-mcpserverdescriptor.html#cfn-agentregistry-registryrecord-mcpserverdescriptor-data
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Data { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-mcpserverdescriptor.html#cfn-agentregistry-registryrecord-mcpserverdescriptor-source
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DescriptorSource
            /// </summary>
            public Union<Humidifier.AgentRegistry.RegistryRecordTypes.DescriptorSource, BaseFunction>? Source { get; set; }
        }

        public class McpToolsDescriptor : Humidifier.Base.BaseSubResource, IHaveDataSchemaVersion, IHaveData
        {
            /// <summary>
            /// DataSchemaVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-mcptoolsdescriptor.html#cfn-agentregistry-registryrecord-mcptoolsdescriptor-dataschemaversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataSchemaVersion { get; set; }
            /// <summary>
            /// Data
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-mcptoolsdescriptor.html#cfn-agentregistry-registryrecord-mcptoolsdescriptor-data
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Data { get; set; }
        }

        public class RegistryRecordCredentialProviderConfiguration : Humidifier.Base.BaseSubResource, IHaveAgentRegistryRegistryRecordTypesRegistryRecordCredentialProviderUnionCredentialProvider, IHaveCredentialProviderType
        {
            /// <summary>
            /// CredentialProvider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-registryrecordcredentialproviderconfiguration.html#cfn-agentregistry-registryrecord-registryrecordcredentialproviderconfiguration-credentialprovider
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RegistryRecordCredentialProviderUnion
            /// </summary>
            public Union<Humidifier.AgentRegistry.RegistryRecordTypes.RegistryRecordCredentialProviderUnion, BaseFunction>? CredentialProvider { get; set; }
            /// <summary>
            /// CredentialProviderType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-registryrecordcredentialproviderconfiguration.html#cfn-agentregistry-registryrecord-registryrecordcredentialproviderconfiguration-credentialprovidertype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CredentialProviderType { get; set; }
        }

        public class RegistryRecordCredentialProviderUnion : Humidifier.Base.BaseSubResource, IHaveAgentRegistryRegistryRecordTypesRegistryRecordOAuthCredentialProviderOauthCredentialProvider, IHaveAgentRegistryRegistryRecordTypesRegistryRecordIamCredentialProviderIamCredentialProvider
        {
            /// <summary>
            /// OauthCredentialProvider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-registryrecordcredentialproviderunion.html#cfn-agentregistry-registryrecord-registryrecordcredentialproviderunion-oauthcredentialprovider
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RegistryRecordOAuthCredentialProvider
            /// </summary>
            public Union<Humidifier.AgentRegistry.RegistryRecordTypes.RegistryRecordOAuthCredentialProvider, BaseFunction>? OauthCredentialProvider { get; set; }
            /// <summary>
            /// IamCredentialProvider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-registryrecordcredentialproviderunion.html#cfn-agentregistry-registryrecord-registryrecordcredentialproviderunion-iamcredentialprovider
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RegistryRecordIamCredentialProvider
            /// </summary>
            public Union<Humidifier.AgentRegistry.RegistryRecordTypes.RegistryRecordIamCredentialProvider, BaseFunction>? IamCredentialProvider { get; set; }
        }

        public class RegistryRecordIamCredentialProvider : Humidifier.Base.BaseSubResource, IHaveService, IHaveRegion, IHaveRoleArn
        {
            /// <summary>
            /// Service
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-registryrecordiamcredentialprovider.html#cfn-agentregistry-registryrecord-registryrecordiamcredentialprovider-service
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Service { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-registryrecordiamcredentialprovider.html#cfn-agentregistry-registryrecord-registryrecordiamcredentialprovider-region
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Region { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-registryrecordiamcredentialprovider.html#cfn-agentregistry-registryrecord-registryrecordiamcredentialprovider-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class RegistryRecordOAuthCredentialProvider : Humidifier.Base.BaseSubResource, IHaveProviderArn, IHaveStringListOfScopes, IHaveGrantType, IHaveStringDictionaryOfCustomParameters
        {
            /// <summary>
            /// ProviderArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-registryrecordoauthcredentialprovider.html#cfn-agentregistry-registryrecord-registryrecordoauthcredentialprovider-providerarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProviderArn { get; set; }
            /// <summary>
            /// Scopes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-registryrecordoauthcredentialprovider.html#cfn-agentregistry-registryrecord-registryrecordoauthcredentialprovider-scopes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Scopes { get; set; }
            /// <summary>
            /// GrantType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-registryrecordoauthcredentialprovider.html#cfn-agentregistry-registryrecord-registryrecordoauthcredentialprovider-granttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GrantType { get; set; }
            /// <summary>
            /// CustomParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-registryrecordoauthcredentialprovider.html#cfn-agentregistry-registryrecord-registryrecordoauthcredentialprovider-customparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? CustomParameters { get; set; }
        }

        public class SkillMdSource : Humidifier.Base.BaseSubResource, IHaveAgentRegistryRegistryRecordTypesSkillMdSourceFromUrlFromUrl
        {
            /// <summary>
            /// FromUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-skillmdsource.html#cfn-agentregistry-registryrecord-skillmdsource-fromurl
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SkillMdSourceFromUrl
            /// </summary>
            public Union<Humidifier.AgentRegistry.RegistryRecordTypes.SkillMdSourceFromUrl, BaseFunction>? FromUrl { get; set; }
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
            public Union<string, BaseFunction>? Url { get; set; }
        }

        public class SourceOnlyDescriptorSource : Humidifier.Base.BaseSubResource, IHaveAgentRegistryRegistryRecordTypesSourceOnlyDescriptorSourceFromUrlFromUrl
        {
            /// <summary>
            /// FromUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-agentregistry-registryrecord-sourceonlydescriptorsource.html#cfn-agentregistry-registryrecord-sourceonlydescriptorsource-fromurl
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SourceOnlyDescriptorSourceFromUrl
            /// </summary>
            public Union<Humidifier.AgentRegistry.RegistryRecordTypes.SourceOnlyDescriptorSourceFromUrl, BaseFunction>? FromUrl { get; set; }
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
            public Union<string, BaseFunction>? Url { get; set; }
        }
    }
}