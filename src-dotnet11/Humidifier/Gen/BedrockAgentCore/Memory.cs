namespace Humidifier.BedrockAgentCore
{
    using global::System.Collections.Generic;
    using MemoryTypes;

    public class Memory : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription, IHaveListOfBedrockAgentCoreMemoryTypesIndexedKeyIndexedKeys, IHaveEncryptionKeyArn, IHaveListOfBedrockAgentCoreMemoryTypesNamespaceKeyEntryNamespaceKeys, IHaveMemoryExecutionRoleArn, IHaveListOfBedrockAgentCoreMemoryTypesMemoryStrategyMemoryStrategies, IHaveEventExpiryDuration_Integer, IHaveBedrockAgentCoreMemoryTypesStreamDeliveryResourcesStreamDeliveryResources, IHaveStringDictionaryOfTags, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string MemoryArn =  "MemoryArn" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string FailureReason =  "FailureReason" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string MemoryId =  "MemoryId" ;
        }

        public override string AWSTypeName { get => AWS.BedrockAgentCore.Memory; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-memory.html#cfn-bedrockagentcore-memory-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// IndexedKeys
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-memory.html#cfn-bedrockagentcore-memory-indexedkeys
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: IndexedKey
        /// </summary>
        public Union<IReadOnlyList<Humidifier.BedrockAgentCore.MemoryTypes.IndexedKey>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.MemoryTypes.IndexedKey, BaseFunction>>, BaseFunction>? IndexedKeys { get; set; }
        /// <summary>
        /// EncryptionKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-memory.html#cfn-bedrockagentcore-memory-encryptionkeyarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EncryptionKeyArn { get; set; }
        /// <summary>
        /// NamespaceKeys
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-memory.html#cfn-bedrockagentcore-memory-namespacekeys
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: NamespaceKeyEntry
        /// </summary>
        public Union<IReadOnlyList<Humidifier.BedrockAgentCore.MemoryTypes.NamespaceKeyEntry>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.MemoryTypes.NamespaceKeyEntry, BaseFunction>>, BaseFunction>? NamespaceKeys { get; set; }
        /// <summary>
        /// MemoryExecutionRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-memory.html#cfn-bedrockagentcore-memory-memoryexecutionrolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? MemoryExecutionRoleArn { get; set; }
        /// <summary>
        /// MemoryStrategies
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-memory.html#cfn-bedrockagentcore-memory-memorystrategies
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: MemoryStrategy
        /// </summary>
        public Union<IReadOnlyList<Humidifier.BedrockAgentCore.MemoryTypes.MemoryStrategy>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.MemoryTypes.MemoryStrategy, BaseFunction>>, BaseFunction>? MemoryStrategies { get; set; }

        /// <summary>
        /// EventExpiryDuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-memory.html#cfn-bedrockagentcore-memory-eventexpiryduration
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? EventExpiryDuration { get; set; }
        /// <summary>
        /// StreamDeliveryResources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-memory.html#cfn-bedrockagentcore-memory-streamdeliveryresources
        /// Required: False
        /// UpdateType: Mutable
        /// Type: StreamDeliveryResources
        /// </summary>
        public Union<Humidifier.BedrockAgentCore.MemoryTypes.StreamDeliveryResources, BaseFunction>? StreamDeliveryResources { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-memory.html#cfn-bedrockagentcore-memory-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace MemoryTypes
    {
        public class ContentConfiguration : Humidifier.Base.BaseSubResource, IHaveType, IHaveLevel
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-contentconfiguration.html#cfn-bedrockagentcore-memory-contentconfiguration-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Level
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-contentconfiguration.html#cfn-bedrockagentcore-memory-contentconfiguration-level
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Level { get; set; }
        }

        public class CustomConfigurationInput : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreMemoryTypesSummaryOverrideSummaryOverride, IHaveBedrockAgentCoreMemoryTypesUserPreferenceOverrideUserPreferenceOverride, IHaveBedrockAgentCoreMemoryTypesEpisodicOverrideEpisodicOverride, IHaveBedrockAgentCoreMemoryTypesSemanticOverrideSemanticOverride, IHaveBedrockAgentCoreMemoryTypesSelfManagedConfigurationSelfManagedConfiguration
        {
            /// <summary>
            /// SummaryOverride
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-customconfigurationinput.html#cfn-bedrockagentcore-memory-customconfigurationinput-summaryoverride
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SummaryOverride
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.MemoryTypes.SummaryOverride, BaseFunction>? SummaryOverride { get; set; }
            /// <summary>
            /// UserPreferenceOverride
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-customconfigurationinput.html#cfn-bedrockagentcore-memory-customconfigurationinput-userpreferenceoverride
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UserPreferenceOverride
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.MemoryTypes.UserPreferenceOverride, BaseFunction>? UserPreferenceOverride { get; set; }
            /// <summary>
            /// EpisodicOverride
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-customconfigurationinput.html#cfn-bedrockagentcore-memory-customconfigurationinput-episodicoverride
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EpisodicOverride
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.MemoryTypes.EpisodicOverride, BaseFunction>? EpisodicOverride { get; set; }
            /// <summary>
            /// SemanticOverride
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-customconfigurationinput.html#cfn-bedrockagentcore-memory-customconfigurationinput-semanticoverride
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SemanticOverride
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.MemoryTypes.SemanticOverride, BaseFunction>? SemanticOverride { get; set; }
            /// <summary>
            /// SelfManagedConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-customconfigurationinput.html#cfn-bedrockagentcore-memory-customconfigurationinput-selfmanagedconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SelfManagedConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.MemoryTypes.SelfManagedConfiguration, BaseFunction>? SelfManagedConfiguration { get; set; }
        }

        public class CustomMemoryStrategy : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveStringListOfNamespaces, IHaveStringListOfNamespaceTemplates, IHaveType, IHaveDescription, IHaveBedrockAgentCoreMemoryTypesCustomConfigurationInputConfiguration, IHaveBedrockAgentCoreMemoryTypesMemoryRecordSchemaMemoryRecordSchema, IHaveCreatedAt, IHaveStrategyId, IHaveUpdatedAt, IHaveName
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-custommemorystrategy.html#cfn-bedrockagentcore-memory-custommemorystrategy-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// Namespaces
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-custommemorystrategy.html#cfn-bedrockagentcore-memory-custommemorystrategy-namespaces
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Namespaces { get; set; }
            /// <summary>
            /// NamespaceTemplates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-custommemorystrategy.html#cfn-bedrockagentcore-memory-custommemorystrategy-namespacetemplates
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? NamespaceTemplates { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-custommemorystrategy.html#cfn-bedrockagentcore-memory-custommemorystrategy-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-custommemorystrategy.html#cfn-bedrockagentcore-memory-custommemorystrategy-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-custommemorystrategy.html#cfn-bedrockagentcore-memory-custommemorystrategy-configuration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomConfigurationInput
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.MemoryTypes.CustomConfigurationInput, BaseFunction>? Configuration { get; set; }
            /// <summary>
            /// MemoryRecordSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-custommemorystrategy.html#cfn-bedrockagentcore-memory-custommemorystrategy-memoryrecordschema
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MemoryRecordSchema
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema, BaseFunction>? MemoryRecordSchema { get; set; }
            /// <summary>
            /// CreatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-custommemorystrategy.html#cfn-bedrockagentcore-memory-custommemorystrategy-createdat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreatedAt { get; set; }
            /// <summary>
            /// StrategyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-custommemorystrategy.html#cfn-bedrockagentcore-memory-custommemorystrategy-strategyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StrategyId { get; set; }
            /// <summary>
            /// UpdatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-custommemorystrategy.html#cfn-bedrockagentcore-memory-custommemorystrategy-updatedat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdatedAt { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-custommemorystrategy.html#cfn-bedrockagentcore-memory-custommemorystrategy-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class EpisodicMemoryStrategy : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveStringListOfNamespaces, IHaveStringListOfNamespaceTemplates, IHaveType, IHaveDescription, IHaveBedrockAgentCoreMemoryTypesEpisodicReflectionConfigurationInputReflectionConfiguration, IHaveBedrockAgentCoreMemoryTypesMemoryRecordSchemaMemoryRecordSchema, IHaveCreatedAt, IHaveStrategyId, IHaveUpdatedAt, IHaveName
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicmemorystrategy.html#cfn-bedrockagentcore-memory-episodicmemorystrategy-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// Namespaces
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicmemorystrategy.html#cfn-bedrockagentcore-memory-episodicmemorystrategy-namespaces
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Namespaces { get; set; }
            /// <summary>
            /// NamespaceTemplates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicmemorystrategy.html#cfn-bedrockagentcore-memory-episodicmemorystrategy-namespacetemplates
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? NamespaceTemplates { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicmemorystrategy.html#cfn-bedrockagentcore-memory-episodicmemorystrategy-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicmemorystrategy.html#cfn-bedrockagentcore-memory-episodicmemorystrategy-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// ReflectionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicmemorystrategy.html#cfn-bedrockagentcore-memory-episodicmemorystrategy-reflectionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EpisodicReflectionConfigurationInput
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.MemoryTypes.EpisodicReflectionConfigurationInput, BaseFunction>? ReflectionConfiguration { get; set; }
            /// <summary>
            /// MemoryRecordSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicmemorystrategy.html#cfn-bedrockagentcore-memory-episodicmemorystrategy-memoryrecordschema
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MemoryRecordSchema
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema, BaseFunction>? MemoryRecordSchema { get; set; }
            /// <summary>
            /// CreatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicmemorystrategy.html#cfn-bedrockagentcore-memory-episodicmemorystrategy-createdat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreatedAt { get; set; }
            /// <summary>
            /// StrategyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicmemorystrategy.html#cfn-bedrockagentcore-memory-episodicmemorystrategy-strategyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StrategyId { get; set; }
            /// <summary>
            /// UpdatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicmemorystrategy.html#cfn-bedrockagentcore-memory-episodicmemorystrategy-updatedat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdatedAt { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicmemorystrategy.html#cfn-bedrockagentcore-memory-episodicmemorystrategy-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class EpisodicOverride : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreMemoryTypesEpisodicOverrideConsolidationConfigurationInputConsolidation, IHaveBedrockAgentCoreMemoryTypesEpisodicOverrideExtractionConfigurationInputExtraction, IHaveBedrockAgentCoreMemoryTypesEpisodicOverrideReflectionConfigurationInputReflection
        {
            /// <summary>
            /// Consolidation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicoverride.html#cfn-bedrockagentcore-memory-episodicoverride-consolidation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EpisodicOverrideConsolidationConfigurationInput
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.MemoryTypes.EpisodicOverrideConsolidationConfigurationInput, BaseFunction>? Consolidation { get; set; }
            /// <summary>
            /// Extraction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicoverride.html#cfn-bedrockagentcore-memory-episodicoverride-extraction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EpisodicOverrideExtractionConfigurationInput
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.MemoryTypes.EpisodicOverrideExtractionConfigurationInput, BaseFunction>? Extraction { get; set; }
            /// <summary>
            /// Reflection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicoverride.html#cfn-bedrockagentcore-memory-episodicoverride-reflection
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EpisodicOverrideReflectionConfigurationInput
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.MemoryTypes.EpisodicOverrideReflectionConfigurationInput, BaseFunction>? Reflection { get; set; }
        }

        public class EpisodicOverrideConsolidationConfigurationInput : Humidifier.Base.BaseSubResource, IHaveAppendToPrompt, IHaveModelId
        {
            /// <summary>
            /// AppendToPrompt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicoverrideconsolidationconfigurationinput.html#cfn-bedrockagentcore-memory-episodicoverrideconsolidationconfigurationinput-appendtoprompt
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AppendToPrompt { get; set; }
            /// <summary>
            /// ModelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicoverrideconsolidationconfigurationinput.html#cfn-bedrockagentcore-memory-episodicoverrideconsolidationconfigurationinput-modelid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelId { get; set; }
        }

        public class EpisodicOverrideExtractionConfigurationInput : Humidifier.Base.BaseSubResource, IHaveAppendToPrompt, IHaveModelId
        {
            /// <summary>
            /// AppendToPrompt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicoverrideextractionconfigurationinput.html#cfn-bedrockagentcore-memory-episodicoverrideextractionconfigurationinput-appendtoprompt
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AppendToPrompt { get; set; }
            /// <summary>
            /// ModelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicoverrideextractionconfigurationinput.html#cfn-bedrockagentcore-memory-episodicoverrideextractionconfigurationinput-modelid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelId { get; set; }
        }

        public class EpisodicOverrideReflectionConfigurationInput : Humidifier.Base.BaseSubResource, IHaveStringListOfNamespaces, IHaveStringListOfNamespaceTemplates, IHaveBedrockAgentCoreMemoryTypesMemoryRecordSchemaMemoryRecordSchema, IHaveAppendToPrompt, IHaveModelId
        {
            /// <summary>
            /// Namespaces
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicoverridereflectionconfigurationinput.html#cfn-bedrockagentcore-memory-episodicoverridereflectionconfigurationinput-namespaces
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Namespaces { get; set; }
            /// <summary>
            /// NamespaceTemplates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicoverridereflectionconfigurationinput.html#cfn-bedrockagentcore-memory-episodicoverridereflectionconfigurationinput-namespacetemplates
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? NamespaceTemplates { get; set; }
            /// <summary>
            /// MemoryRecordSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicoverridereflectionconfigurationinput.html#cfn-bedrockagentcore-memory-episodicoverridereflectionconfigurationinput-memoryrecordschema
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MemoryRecordSchema
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema, BaseFunction>? MemoryRecordSchema { get; set; }
            /// <summary>
            /// AppendToPrompt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicoverridereflectionconfigurationinput.html#cfn-bedrockagentcore-memory-episodicoverridereflectionconfigurationinput-appendtoprompt
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AppendToPrompt { get; set; }
            /// <summary>
            /// ModelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicoverridereflectionconfigurationinput.html#cfn-bedrockagentcore-memory-episodicoverridereflectionconfigurationinput-modelid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelId { get; set; }
        }

        public class EpisodicReflectionConfigurationInput : Humidifier.Base.BaseSubResource, IHaveStringListOfNamespaces, IHaveStringListOfNamespaceTemplates, IHaveBedrockAgentCoreMemoryTypesMemoryRecordSchemaMemoryRecordSchema
        {
            /// <summary>
            /// Namespaces
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicreflectionconfigurationinput.html#cfn-bedrockagentcore-memory-episodicreflectionconfigurationinput-namespaces
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Namespaces { get; set; }
            /// <summary>
            /// NamespaceTemplates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicreflectionconfigurationinput.html#cfn-bedrockagentcore-memory-episodicreflectionconfigurationinput-namespacetemplates
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? NamespaceTemplates { get; set; }
            /// <summary>
            /// MemoryRecordSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicreflectionconfigurationinput.html#cfn-bedrockagentcore-memory-episodicreflectionconfigurationinput-memoryrecordschema
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MemoryRecordSchema
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema, BaseFunction>? MemoryRecordSchema { get; set; }
        }

        public class ExtractionConfig : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreMemoryTypesLlmExtractionConfigLlmExtractionConfig
        {
            /// <summary>
            /// LlmExtractionConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-extractionconfig.html#cfn-bedrockagentcore-memory-extractionconfig-llmextractionconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LlmExtractionConfig
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.MemoryTypes.LlmExtractionConfig, BaseFunction>? LlmExtractionConfig { get; set; }
        }

        public class IndexedKey : Humidifier.Base.BaseSubResource, IHaveType, IHaveKey
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-indexedkey.html#cfn-bedrockagentcore-memory-indexedkey-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-indexedkey.html#cfn-bedrockagentcore-memory-indexedkey-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class InvocationConfigurationInput : Humidifier.Base.BaseSubResource, IHaveTopicArn, IHavePayloadDeliveryBucketName
        {
            /// <summary>
            /// TopicArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-invocationconfigurationinput.html#cfn-bedrockagentcore-memory-invocationconfigurationinput-topicarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TopicArn { get; set; }
            /// <summary>
            /// PayloadDeliveryBucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-invocationconfigurationinput.html#cfn-bedrockagentcore-memory-invocationconfigurationinput-payloaddeliverybucketname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PayloadDeliveryBucketName { get; set; }
        }

        public class KinesisResource : Humidifier.Base.BaseSubResource, IHaveDataStreamArn, IHaveListOfBedrockAgentCoreMemoryTypesContentConfigurationContentConfigurations
        {
            /// <summary>
            /// DataStreamArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-kinesisresource.html#cfn-bedrockagentcore-memory-kinesisresource-datastreamarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataStreamArn { get; set; }
            /// <summary>
            /// ContentConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-kinesisresource.html#cfn-bedrockagentcore-memory-kinesisresource-contentconfigurations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ContentConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.BedrockAgentCore.MemoryTypes.ContentConfiguration>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.MemoryTypes.ContentConfiguration, BaseFunction>>, BaseFunction>? ContentConfigurations { get; set; }
        }

        public class LlmExtractionConfig : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreMemoryTypesValidationValidation, IHaveDefinition, IHaveLlmExtractionInstruction
        {
            /// <summary>
            /// Validation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-llmextractionconfig.html#cfn-bedrockagentcore-memory-llmextractionconfig-validation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Validation
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.MemoryTypes.Validation, BaseFunction>? Validation { get; set; }
            /// <summary>
            /// Definition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-llmextractionconfig.html#cfn-bedrockagentcore-memory-llmextractionconfig-definition
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Definition { get; set; }
            /// <summary>
            /// LlmExtractionInstruction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-llmextractionconfig.html#cfn-bedrockagentcore-memory-llmextractionconfig-llmextractioninstruction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LlmExtractionInstruction { get; set; }
        }

        public class MemoryRecordSchema : Humidifier.Base.BaseSubResource, IHaveListOfBedrockAgentCoreMemoryTypesMetadataSchemaEntryMetadataSchema
        {
            /// <summary>
            /// MetadataSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-memoryrecordschema.html#cfn-bedrockagentcore-memory-memoryrecordschema-metadataschema
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MetadataSchemaEntry
            /// </summary>
            public Union<IReadOnlyList<Humidifier.BedrockAgentCore.MemoryTypes.MetadataSchemaEntry>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.MemoryTypes.MetadataSchemaEntry, BaseFunction>>, BaseFunction>? MetadataSchema { get; set; }
        }

        public class MemoryStrategy : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreMemoryTypesSummaryMemoryStrategySummaryMemoryStrategy, IHaveBedrockAgentCoreMemoryTypesCustomMemoryStrategyCustomMemoryStrategy, IHaveBedrockAgentCoreMemoryTypesSemanticMemoryStrategySemanticMemoryStrategy, IHaveBedrockAgentCoreMemoryTypesUserPreferenceMemoryStrategyUserPreferenceMemoryStrategy, IHaveBedrockAgentCoreMemoryTypesEpisodicMemoryStrategyEpisodicMemoryStrategy
        {
            /// <summary>
            /// SummaryMemoryStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-memorystrategy.html#cfn-bedrockagentcore-memory-memorystrategy-summarymemorystrategy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SummaryMemoryStrategy
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.MemoryTypes.SummaryMemoryStrategy, BaseFunction>? SummaryMemoryStrategy { get; set; }
            /// <summary>
            /// CustomMemoryStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-memorystrategy.html#cfn-bedrockagentcore-memory-memorystrategy-custommemorystrategy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomMemoryStrategy
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.MemoryTypes.CustomMemoryStrategy, BaseFunction>? CustomMemoryStrategy { get; set; }
            /// <summary>
            /// SemanticMemoryStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-memorystrategy.html#cfn-bedrockagentcore-memory-memorystrategy-semanticmemorystrategy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SemanticMemoryStrategy
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.MemoryTypes.SemanticMemoryStrategy, BaseFunction>? SemanticMemoryStrategy { get; set; }
            /// <summary>
            /// UserPreferenceMemoryStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-memorystrategy.html#cfn-bedrockagentcore-memory-memorystrategy-userpreferencememorystrategy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UserPreferenceMemoryStrategy
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.MemoryTypes.UserPreferenceMemoryStrategy, BaseFunction>? UserPreferenceMemoryStrategy { get; set; }
            /// <summary>
            /// EpisodicMemoryStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-memorystrategy.html#cfn-bedrockagentcore-memory-memorystrategy-episodicmemorystrategy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EpisodicMemoryStrategy
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.MemoryTypes.EpisodicMemoryStrategy, BaseFunction>? EpisodicMemoryStrategy { get; set; }
        }

        public class MessageBasedTriggerInput : Humidifier.Base.BaseSubResource, IHaveMessageCount_Integer
        {
            /// <summary>
            /// MessageCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-messagebasedtriggerinput.html#cfn-bedrockagentcore-memory-messagebasedtriggerinput-messagecount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MessageCount { get; set; }
        }

        public class MetadataSchemaEntry : Humidifier.Base.BaseSubResource, IHaveType, IHaveBedrockAgentCoreMemoryTypesExtractionConfigExtractionConfig, IHaveExtractionType, IHaveKey
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-metadataschemaentry.html#cfn-bedrockagentcore-memory-metadataschemaentry-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// ExtractionConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-metadataschemaentry.html#cfn-bedrockagentcore-memory-metadataschemaentry-extractionconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ExtractionConfig
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.MemoryTypes.ExtractionConfig, BaseFunction>? ExtractionConfig { get; set; }
            /// <summary>
            /// ExtractionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-metadataschemaentry.html#cfn-bedrockagentcore-memory-metadataschemaentry-extractiontype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExtractionType { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-metadataschemaentry.html#cfn-bedrockagentcore-memory-metadataschemaentry-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class NamespaceKeyEntry : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreMemoryTypesNamespaceKeyValidationValidation, IHaveKey
        {
            /// <summary>
            /// Validation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-namespacekeyentry.html#cfn-bedrockagentcore-memory-namespacekeyentry-validation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NamespaceKeyValidation
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.MemoryTypes.NamespaceKeyValidation, BaseFunction>? Validation { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-namespacekeyentry.html#cfn-bedrockagentcore-memory-namespacekeyentry-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class NamespaceKeyValidation : Humidifier.Base.BaseSubResource, IHaveStringListOfAllowedValues, IHaveRegexPattern
        {
            /// <summary>
            /// AllowedValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-namespacekeyvalidation.html#cfn-bedrockagentcore-memory-namespacekeyvalidation-allowedvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedValues { get; set; }
            /// <summary>
            /// RegexPattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-namespacekeyvalidation.html#cfn-bedrockagentcore-memory-namespacekeyvalidation-regexpattern
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RegexPattern { get; set; }
        }

        public class NumberValidation : Humidifier.Base.BaseSubResource, IHaveMinValue_Double, IHaveMaxValue_Double
        {
            /// <summary>
            /// MinValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-numbervalidation.html#cfn-bedrockagentcore-memory-numbervalidation-minvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MinValue { get; set; }
            /// <summary>
            /// MaxValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-numbervalidation.html#cfn-bedrockagentcore-memory-numbervalidation-maxvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MaxValue { get; set; }
        }

        public class SelfManagedConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfBedrockAgentCoreMemoryTypesTriggerConditionInputTriggerConditions, IHaveBedrockAgentCoreMemoryTypesInvocationConfigurationInputInvocationConfiguration, IHaveHistoricalContextWindowSize_Integer
        {
            /// <summary>
            /// TriggerConditions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-selfmanagedconfiguration.html#cfn-bedrockagentcore-memory-selfmanagedconfiguration-triggerconditions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TriggerConditionInput
            /// </summary>
            public Union<IReadOnlyList<Humidifier.BedrockAgentCore.MemoryTypes.TriggerConditionInput>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.MemoryTypes.TriggerConditionInput, BaseFunction>>, BaseFunction>? TriggerConditions { get; set; }
            /// <summary>
            /// InvocationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-selfmanagedconfiguration.html#cfn-bedrockagentcore-memory-selfmanagedconfiguration-invocationconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InvocationConfigurationInput
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.MemoryTypes.InvocationConfigurationInput, BaseFunction>? InvocationConfiguration { get; set; }
            /// <summary>
            /// HistoricalContextWindowSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-selfmanagedconfiguration.html#cfn-bedrockagentcore-memory-selfmanagedconfiguration-historicalcontextwindowsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? HistoricalContextWindowSize { get; set; }
        }

        public class SemanticMemoryStrategy : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveStringListOfNamespaces, IHaveStringListOfNamespaceTemplates, IHaveType, IHaveDescription, IHaveBedrockAgentCoreMemoryTypesMemoryRecordSchemaMemoryRecordSchema, IHaveCreatedAt, IHaveStrategyId, IHaveUpdatedAt, IHaveName
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-semanticmemorystrategy.html#cfn-bedrockagentcore-memory-semanticmemorystrategy-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// Namespaces
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-semanticmemorystrategy.html#cfn-bedrockagentcore-memory-semanticmemorystrategy-namespaces
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Namespaces { get; set; }
            /// <summary>
            /// NamespaceTemplates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-semanticmemorystrategy.html#cfn-bedrockagentcore-memory-semanticmemorystrategy-namespacetemplates
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? NamespaceTemplates { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-semanticmemorystrategy.html#cfn-bedrockagentcore-memory-semanticmemorystrategy-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-semanticmemorystrategy.html#cfn-bedrockagentcore-memory-semanticmemorystrategy-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// MemoryRecordSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-semanticmemorystrategy.html#cfn-bedrockagentcore-memory-semanticmemorystrategy-memoryrecordschema
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MemoryRecordSchema
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema, BaseFunction>? MemoryRecordSchema { get; set; }
            /// <summary>
            /// CreatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-semanticmemorystrategy.html#cfn-bedrockagentcore-memory-semanticmemorystrategy-createdat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreatedAt { get; set; }
            /// <summary>
            /// StrategyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-semanticmemorystrategy.html#cfn-bedrockagentcore-memory-semanticmemorystrategy-strategyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StrategyId { get; set; }
            /// <summary>
            /// UpdatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-semanticmemorystrategy.html#cfn-bedrockagentcore-memory-semanticmemorystrategy-updatedat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdatedAt { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-semanticmemorystrategy.html#cfn-bedrockagentcore-memory-semanticmemorystrategy-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class SemanticOverride : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreMemoryTypesSemanticOverrideConsolidationConfigurationInputConsolidation, IHaveBedrockAgentCoreMemoryTypesSemanticOverrideExtractionConfigurationInputExtraction
        {
            /// <summary>
            /// Consolidation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-semanticoverride.html#cfn-bedrockagentcore-memory-semanticoverride-consolidation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SemanticOverrideConsolidationConfigurationInput
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.MemoryTypes.SemanticOverrideConsolidationConfigurationInput, BaseFunction>? Consolidation { get; set; }
            /// <summary>
            /// Extraction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-semanticoverride.html#cfn-bedrockagentcore-memory-semanticoverride-extraction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SemanticOverrideExtractionConfigurationInput
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.MemoryTypes.SemanticOverrideExtractionConfigurationInput, BaseFunction>? Extraction { get; set; }
        }

        public class SemanticOverrideConsolidationConfigurationInput : Humidifier.Base.BaseSubResource, IHaveAppendToPrompt, IHaveModelId
        {
            /// <summary>
            /// AppendToPrompt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-semanticoverrideconsolidationconfigurationinput.html#cfn-bedrockagentcore-memory-semanticoverrideconsolidationconfigurationinput-appendtoprompt
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AppendToPrompt { get; set; }
            /// <summary>
            /// ModelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-semanticoverrideconsolidationconfigurationinput.html#cfn-bedrockagentcore-memory-semanticoverrideconsolidationconfigurationinput-modelid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelId { get; set; }
        }

        public class SemanticOverrideExtractionConfigurationInput : Humidifier.Base.BaseSubResource, IHaveAppendToPrompt, IHaveModelId
        {
            /// <summary>
            /// AppendToPrompt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-semanticoverrideextractionconfigurationinput.html#cfn-bedrockagentcore-memory-semanticoverrideextractionconfigurationinput-appendtoprompt
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AppendToPrompt { get; set; }
            /// <summary>
            /// ModelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-semanticoverrideextractionconfigurationinput.html#cfn-bedrockagentcore-memory-semanticoverrideextractionconfigurationinput-modelid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelId { get; set; }
        }

        public class StreamDeliveryResource : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreMemoryTypesKinesisResourceKinesis
        {
            /// <summary>
            /// Kinesis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-streamdeliveryresource.html#cfn-bedrockagentcore-memory-streamdeliveryresource-kinesis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KinesisResource
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.MemoryTypes.KinesisResource, BaseFunction>? Kinesis { get; set; }
        }

        public class StreamDeliveryResources : Humidifier.Base.BaseSubResource, IHaveListOfBedrockAgentCoreMemoryTypesStreamDeliveryResourceResources
        {
            /// <summary>
            /// Resources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-streamdeliveryresources.html#cfn-bedrockagentcore-memory-streamdeliveryresources-resources
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StreamDeliveryResource
            /// </summary>
            public Union<IReadOnlyList<Humidifier.BedrockAgentCore.MemoryTypes.StreamDeliveryResource>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.MemoryTypes.StreamDeliveryResource, BaseFunction>>, BaseFunction>? Resources { get; set; }
        }

        public class StringListValidation : Humidifier.Base.BaseSubResource, IHaveStringListOfAllowedValues, IHaveMaxItems_Integer
        {
            /// <summary>
            /// AllowedValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-stringlistvalidation.html#cfn-bedrockagentcore-memory-stringlistvalidation-allowedvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedValues { get; set; }
            /// <summary>
            /// MaxItems
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-stringlistvalidation.html#cfn-bedrockagentcore-memory-stringlistvalidation-maxitems
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxItems { get; set; }
        }

        public class StringValidation : Humidifier.Base.BaseSubResource, IHaveStringListOfAllowedValues
        {
            /// <summary>
            /// AllowedValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-stringvalidation.html#cfn-bedrockagentcore-memory-stringvalidation-allowedvalues
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedValues { get; set; }
        }

        public class SummaryMemoryStrategy : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveStringListOfNamespaces, IHaveStringListOfNamespaceTemplates, IHaveType, IHaveDescription, IHaveBedrockAgentCoreMemoryTypesMemoryRecordSchemaMemoryRecordSchema, IHaveCreatedAt, IHaveStrategyId, IHaveUpdatedAt, IHaveName
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-summarymemorystrategy.html#cfn-bedrockagentcore-memory-summarymemorystrategy-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// Namespaces
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-summarymemorystrategy.html#cfn-bedrockagentcore-memory-summarymemorystrategy-namespaces
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Namespaces { get; set; }
            /// <summary>
            /// NamespaceTemplates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-summarymemorystrategy.html#cfn-bedrockagentcore-memory-summarymemorystrategy-namespacetemplates
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? NamespaceTemplates { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-summarymemorystrategy.html#cfn-bedrockagentcore-memory-summarymemorystrategy-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-summarymemorystrategy.html#cfn-bedrockagentcore-memory-summarymemorystrategy-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// MemoryRecordSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-summarymemorystrategy.html#cfn-bedrockagentcore-memory-summarymemorystrategy-memoryrecordschema
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MemoryRecordSchema
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema, BaseFunction>? MemoryRecordSchema { get; set; }
            /// <summary>
            /// CreatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-summarymemorystrategy.html#cfn-bedrockagentcore-memory-summarymemorystrategy-createdat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreatedAt { get; set; }
            /// <summary>
            /// StrategyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-summarymemorystrategy.html#cfn-bedrockagentcore-memory-summarymemorystrategy-strategyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StrategyId { get; set; }
            /// <summary>
            /// UpdatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-summarymemorystrategy.html#cfn-bedrockagentcore-memory-summarymemorystrategy-updatedat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdatedAt { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-summarymemorystrategy.html#cfn-bedrockagentcore-memory-summarymemorystrategy-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class SummaryOverride : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreMemoryTypesSummaryOverrideConsolidationConfigurationInputConsolidation
        {
            /// <summary>
            /// Consolidation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-summaryoverride.html#cfn-bedrockagentcore-memory-summaryoverride-consolidation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SummaryOverrideConsolidationConfigurationInput
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.MemoryTypes.SummaryOverrideConsolidationConfigurationInput, BaseFunction>? Consolidation { get; set; }
        }

        public class SummaryOverrideConsolidationConfigurationInput : Humidifier.Base.BaseSubResource, IHaveAppendToPrompt, IHaveModelId
        {
            /// <summary>
            /// AppendToPrompt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-summaryoverrideconsolidationconfigurationinput.html#cfn-bedrockagentcore-memory-summaryoverrideconsolidationconfigurationinput-appendtoprompt
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AppendToPrompt { get; set; }
            /// <summary>
            /// ModelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-summaryoverrideconsolidationconfigurationinput.html#cfn-bedrockagentcore-memory-summaryoverrideconsolidationconfigurationinput-modelid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelId { get; set; }
        }

        public class TimeBasedTriggerInput : Humidifier.Base.BaseSubResource, IHaveIdleSessionTimeout_Integer
        {
            /// <summary>
            /// IdleSessionTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-timebasedtriggerinput.html#cfn-bedrockagentcore-memory-timebasedtriggerinput-idlesessiontimeout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? IdleSessionTimeout { get; set; }
        }

        public class TokenBasedTriggerInput : Humidifier.Base.BaseSubResource, IHaveTokenCount_Integer
        {
            /// <summary>
            /// TokenCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-tokenbasedtriggerinput.html#cfn-bedrockagentcore-memory-tokenbasedtriggerinput-tokencount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TokenCount { get; set; }
        }

        public class TriggerConditionInput : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreMemoryTypesMessageBasedTriggerInputMessageBasedTrigger, IHaveBedrockAgentCoreMemoryTypesTokenBasedTriggerInputTokenBasedTrigger, IHaveBedrockAgentCoreMemoryTypesTimeBasedTriggerInputTimeBasedTrigger
        {
            /// <summary>
            /// MessageBasedTrigger
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-triggerconditioninput.html#cfn-bedrockagentcore-memory-triggerconditioninput-messagebasedtrigger
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MessageBasedTriggerInput
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.MemoryTypes.MessageBasedTriggerInput, BaseFunction>? MessageBasedTrigger { get; set; }
            /// <summary>
            /// TokenBasedTrigger
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-triggerconditioninput.html#cfn-bedrockagentcore-memory-triggerconditioninput-tokenbasedtrigger
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TokenBasedTriggerInput
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.MemoryTypes.TokenBasedTriggerInput, BaseFunction>? TokenBasedTrigger { get; set; }
            /// <summary>
            /// TimeBasedTrigger
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-triggerconditioninput.html#cfn-bedrockagentcore-memory-triggerconditioninput-timebasedtrigger
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimeBasedTriggerInput
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.MemoryTypes.TimeBasedTriggerInput, BaseFunction>? TimeBasedTrigger { get; set; }
        }

        public class UserPreferenceMemoryStrategy : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveStringListOfNamespaces, IHaveStringListOfNamespaceTemplates, IHaveType, IHaveDescription, IHaveBedrockAgentCoreMemoryTypesMemoryRecordSchemaMemoryRecordSchema, IHaveCreatedAt, IHaveStrategyId, IHaveUpdatedAt, IHaveName
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-userpreferencememorystrategy.html#cfn-bedrockagentcore-memory-userpreferencememorystrategy-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// Namespaces
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-userpreferencememorystrategy.html#cfn-bedrockagentcore-memory-userpreferencememorystrategy-namespaces
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Namespaces { get; set; }
            /// <summary>
            /// NamespaceTemplates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-userpreferencememorystrategy.html#cfn-bedrockagentcore-memory-userpreferencememorystrategy-namespacetemplates
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? NamespaceTemplates { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-userpreferencememorystrategy.html#cfn-bedrockagentcore-memory-userpreferencememorystrategy-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-userpreferencememorystrategy.html#cfn-bedrockagentcore-memory-userpreferencememorystrategy-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// MemoryRecordSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-userpreferencememorystrategy.html#cfn-bedrockagentcore-memory-userpreferencememorystrategy-memoryrecordschema
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MemoryRecordSchema
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema, BaseFunction>? MemoryRecordSchema { get; set; }
            /// <summary>
            /// CreatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-userpreferencememorystrategy.html#cfn-bedrockagentcore-memory-userpreferencememorystrategy-createdat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreatedAt { get; set; }
            /// <summary>
            /// StrategyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-userpreferencememorystrategy.html#cfn-bedrockagentcore-memory-userpreferencememorystrategy-strategyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StrategyId { get; set; }
            /// <summary>
            /// UpdatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-userpreferencememorystrategy.html#cfn-bedrockagentcore-memory-userpreferencememorystrategy-updatedat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdatedAt { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-userpreferencememorystrategy.html#cfn-bedrockagentcore-memory-userpreferencememorystrategy-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class UserPreferenceOverride : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreMemoryTypesUserPreferenceOverrideConsolidationConfigurationInputConsolidation, IHaveBedrockAgentCoreMemoryTypesUserPreferenceOverrideExtractionConfigurationInputExtraction
        {
            /// <summary>
            /// Consolidation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-userpreferenceoverride.html#cfn-bedrockagentcore-memory-userpreferenceoverride-consolidation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UserPreferenceOverrideConsolidationConfigurationInput
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.MemoryTypes.UserPreferenceOverrideConsolidationConfigurationInput, BaseFunction>? Consolidation { get; set; }
            /// <summary>
            /// Extraction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-userpreferenceoverride.html#cfn-bedrockagentcore-memory-userpreferenceoverride-extraction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UserPreferenceOverrideExtractionConfigurationInput
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.MemoryTypes.UserPreferenceOverrideExtractionConfigurationInput, BaseFunction>? Extraction { get; set; }
        }

        public class UserPreferenceOverrideConsolidationConfigurationInput : Humidifier.Base.BaseSubResource, IHaveAppendToPrompt, IHaveModelId
        {
            /// <summary>
            /// AppendToPrompt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-userpreferenceoverrideconsolidationconfigurationinput.html#cfn-bedrockagentcore-memory-userpreferenceoverrideconsolidationconfigurationinput-appendtoprompt
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AppendToPrompt { get; set; }
            /// <summary>
            /// ModelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-userpreferenceoverrideconsolidationconfigurationinput.html#cfn-bedrockagentcore-memory-userpreferenceoverrideconsolidationconfigurationinput-modelid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelId { get; set; }
        }

        public class UserPreferenceOverrideExtractionConfigurationInput : Humidifier.Base.BaseSubResource, IHaveAppendToPrompt, IHaveModelId
        {
            /// <summary>
            /// AppendToPrompt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-userpreferenceoverrideextractionconfigurationinput.html#cfn-bedrockagentcore-memory-userpreferenceoverrideextractionconfigurationinput-appendtoprompt
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AppendToPrompt { get; set; }
            /// <summary>
            /// ModelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-userpreferenceoverrideextractionconfigurationinput.html#cfn-bedrockagentcore-memory-userpreferenceoverrideextractionconfigurationinput-modelid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelId { get; set; }
        }

        public class Validation : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreMemoryTypesStringValidationStringValidation, IHaveBedrockAgentCoreMemoryTypesNumberValidationNumberValidation, IHaveBedrockAgentCoreMemoryTypesStringListValidationStringListValidation
        {
            /// <summary>
            /// StringValidation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-validation.html#cfn-bedrockagentcore-memory-validation-stringvalidation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StringValidation
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.MemoryTypes.StringValidation, BaseFunction>? StringValidation { get; set; }
            /// <summary>
            /// NumberValidation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-validation.html#cfn-bedrockagentcore-memory-validation-numbervalidation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumberValidation
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.MemoryTypes.NumberValidation, BaseFunction>? NumberValidation { get; set; }
            /// <summary>
            /// StringListValidation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-validation.html#cfn-bedrockagentcore-memory-validation-stringlistvalidation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StringListValidation
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.MemoryTypes.StringListValidation, BaseFunction>? StringListValidation { get; set; }
        }
    }
}