namespace Humidifier.BedrockAgentCore
{
    using global::System.Collections.Generic;
    using MemoryTypes;

    public class Memory : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveDescription, IHaveEncryptionKeyArn
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
        public dynamic Description { get; set; }
        /// <summary>
        /// IndexedKeys
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-memory.html#cfn-bedrockagentcore-memory-indexedkeys
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: IndexedKey
        /// </summary>
        public List<Humidifier.BedrockAgentCore.MemoryTypes.IndexedKey> IndexedKeys { get; set; }
        /// <summary>
        /// EncryptionKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-memory.html#cfn-bedrockagentcore-memory-encryptionkeyarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic EncryptionKeyArn { get; set; }
        /// <summary>
        /// NamespaceKeys
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-memory.html#cfn-bedrockagentcore-memory-namespacekeys
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: NamespaceKeyEntry
        /// </summary>
        public List<Humidifier.BedrockAgentCore.MemoryTypes.NamespaceKeyEntry> NamespaceKeys { get; set; }
        /// <summary>
        /// MemoryExecutionRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-memory.html#cfn-bedrockagentcore-memory-memoryexecutionrolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic MemoryExecutionRoleArn { get; set; }
        /// <summary>
        /// MemoryStrategies
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-memory.html#cfn-bedrockagentcore-memory-memorystrategies
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: MemoryStrategy
        /// </summary>
        public List<Humidifier.BedrockAgentCore.MemoryTypes.MemoryStrategy> MemoryStrategies { get; set; }

        /// <summary>
        /// EventExpiryDuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-memory.html#cfn-bedrockagentcore-memory-eventexpiryduration
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public dynamic EventExpiryDuration { get; set; }
        /// <summary>
        /// StreamDeliveryResources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-memory.html#cfn-bedrockagentcore-memory-streamdeliveryresources
        /// Required: False
        /// UpdateType: Mutable
        /// Type: StreamDeliveryResources
        /// </summary>
        public Humidifier.BedrockAgentCore.MemoryTypes.StreamDeliveryResources StreamDeliveryResources { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-memory.html#cfn-bedrockagentcore-memory-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
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
            public dynamic Type { get; set; }
            /// <summary>
            /// Level
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-contentconfiguration.html#cfn-bedrockagentcore-memory-contentconfiguration-level
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Level { get; set; }
        }

        public class CustomConfigurationInput : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SummaryOverride
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-customconfigurationinput.html#cfn-bedrockagentcore-memory-customconfigurationinput-summaryoverride
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SummaryOverride
            /// </summary>
            public Humidifier.BedrockAgentCore.MemoryTypes.SummaryOverride SummaryOverride { get; set; }
            /// <summary>
            /// UserPreferenceOverride
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-customconfigurationinput.html#cfn-bedrockagentcore-memory-customconfigurationinput-userpreferenceoverride
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UserPreferenceOverride
            /// </summary>
            public Humidifier.BedrockAgentCore.MemoryTypes.UserPreferenceOverride UserPreferenceOverride { get; set; }
            /// <summary>
            /// EpisodicOverride
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-customconfigurationinput.html#cfn-bedrockagentcore-memory-customconfigurationinput-episodicoverride
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EpisodicOverride
            /// </summary>
            public Humidifier.BedrockAgentCore.MemoryTypes.EpisodicOverride EpisodicOverride { get; set; }
            /// <summary>
            /// SemanticOverride
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-customconfigurationinput.html#cfn-bedrockagentcore-memory-customconfigurationinput-semanticoverride
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SemanticOverride
            /// </summary>
            public Humidifier.BedrockAgentCore.MemoryTypes.SemanticOverride SemanticOverride { get; set; }
            /// <summary>
            /// SelfManagedConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-customconfigurationinput.html#cfn-bedrockagentcore-memory-customconfigurationinput-selfmanagedconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SelfManagedConfiguration
            /// </summary>
            public Humidifier.BedrockAgentCore.MemoryTypes.SelfManagedConfiguration SelfManagedConfiguration { get; set; }
        }

        public class CustomMemoryStrategy : Humidifier.Base.BaseSubResource, IHaveName, IHaveDescription, IHaveType, IHaveStatus, IHaveCreatedAt
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-custommemorystrategy.html#cfn-bedrockagentcore-memory-custommemorystrategy-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// Namespaces
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-custommemorystrategy.html#cfn-bedrockagentcore-memory-custommemorystrategy-namespaces
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Namespaces { get; set; }
            /// <summary>
            /// NamespaceTemplates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-custommemorystrategy.html#cfn-bedrockagentcore-memory-custommemorystrategy-namespacetemplates
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic NamespaceTemplates { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-custommemorystrategy.html#cfn-bedrockagentcore-memory-custommemorystrategy-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-custommemorystrategy.html#cfn-bedrockagentcore-memory-custommemorystrategy-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-custommemorystrategy.html#cfn-bedrockagentcore-memory-custommemorystrategy-configuration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomConfigurationInput
            /// </summary>
            public Humidifier.BedrockAgentCore.MemoryTypes.CustomConfigurationInput Configuration { get; set; }
            /// <summary>
            /// MemoryRecordSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-custommemorystrategy.html#cfn-bedrockagentcore-memory-custommemorystrategy-memoryrecordschema
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MemoryRecordSchema
            /// </summary>
            public Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema MemoryRecordSchema { get; set; }
            /// <summary>
            /// CreatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-custommemorystrategy.html#cfn-bedrockagentcore-memory-custommemorystrategy-createdat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreatedAt { get; set; }
            /// <summary>
            /// StrategyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-custommemorystrategy.html#cfn-bedrockagentcore-memory-custommemorystrategy-strategyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StrategyId { get; set; }
            /// <summary>
            /// UpdatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-custommemorystrategy.html#cfn-bedrockagentcore-memory-custommemorystrategy-updatedat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdatedAt { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-custommemorystrategy.html#cfn-bedrockagentcore-memory-custommemorystrategy-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class EpisodicMemoryStrategy : Humidifier.Base.BaseSubResource, IHaveName, IHaveDescription, IHaveType, IHaveStatus, IHaveCreatedAt
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicmemorystrategy.html#cfn-bedrockagentcore-memory-episodicmemorystrategy-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// Namespaces
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicmemorystrategy.html#cfn-bedrockagentcore-memory-episodicmemorystrategy-namespaces
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Namespaces { get; set; }
            /// <summary>
            /// NamespaceTemplates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicmemorystrategy.html#cfn-bedrockagentcore-memory-episodicmemorystrategy-namespacetemplates
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic NamespaceTemplates { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicmemorystrategy.html#cfn-bedrockagentcore-memory-episodicmemorystrategy-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicmemorystrategy.html#cfn-bedrockagentcore-memory-episodicmemorystrategy-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// ReflectionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicmemorystrategy.html#cfn-bedrockagentcore-memory-episodicmemorystrategy-reflectionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EpisodicReflectionConfigurationInput
            /// </summary>
            public Humidifier.BedrockAgentCore.MemoryTypes.EpisodicReflectionConfigurationInput ReflectionConfiguration { get; set; }
            /// <summary>
            /// MemoryRecordSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicmemorystrategy.html#cfn-bedrockagentcore-memory-episodicmemorystrategy-memoryrecordschema
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MemoryRecordSchema
            /// </summary>
            public Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema MemoryRecordSchema { get; set; }
            /// <summary>
            /// CreatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicmemorystrategy.html#cfn-bedrockagentcore-memory-episodicmemorystrategy-createdat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreatedAt { get; set; }
            /// <summary>
            /// StrategyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicmemorystrategy.html#cfn-bedrockagentcore-memory-episodicmemorystrategy-strategyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StrategyId { get; set; }
            /// <summary>
            /// UpdatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicmemorystrategy.html#cfn-bedrockagentcore-memory-episodicmemorystrategy-updatedat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdatedAt { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicmemorystrategy.html#cfn-bedrockagentcore-memory-episodicmemorystrategy-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class EpisodicOverride : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Consolidation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicoverride.html#cfn-bedrockagentcore-memory-episodicoverride-consolidation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EpisodicOverrideConsolidationConfigurationInput
            /// </summary>
            public Humidifier.BedrockAgentCore.MemoryTypes.EpisodicOverrideConsolidationConfigurationInput Consolidation { get; set; }
            /// <summary>
            /// Extraction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicoverride.html#cfn-bedrockagentcore-memory-episodicoverride-extraction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EpisodicOverrideExtractionConfigurationInput
            /// </summary>
            public Humidifier.BedrockAgentCore.MemoryTypes.EpisodicOverrideExtractionConfigurationInput Extraction { get; set; }
            /// <summary>
            /// Reflection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicoverride.html#cfn-bedrockagentcore-memory-episodicoverride-reflection
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EpisodicOverrideReflectionConfigurationInput
            /// </summary>
            public Humidifier.BedrockAgentCore.MemoryTypes.EpisodicOverrideReflectionConfigurationInput Reflection { get; set; }
        }

        public class EpisodicOverrideConsolidationConfigurationInput : Humidifier.Base.BaseSubResource, IHaveModelId
        {
            /// <summary>
            /// AppendToPrompt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicoverrideconsolidationconfigurationinput.html#cfn-bedrockagentcore-memory-episodicoverrideconsolidationconfigurationinput-appendtoprompt
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AppendToPrompt { get; set; }
            /// <summary>
            /// ModelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicoverrideconsolidationconfigurationinput.html#cfn-bedrockagentcore-memory-episodicoverrideconsolidationconfigurationinput-modelid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ModelId { get; set; }
        }

        public class EpisodicOverrideExtractionConfigurationInput : Humidifier.Base.BaseSubResource, IHaveModelId
        {
            /// <summary>
            /// AppendToPrompt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicoverrideextractionconfigurationinput.html#cfn-bedrockagentcore-memory-episodicoverrideextractionconfigurationinput-appendtoprompt
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AppendToPrompt { get; set; }
            /// <summary>
            /// ModelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicoverrideextractionconfigurationinput.html#cfn-bedrockagentcore-memory-episodicoverrideextractionconfigurationinput-modelid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ModelId { get; set; }
        }

        public class EpisodicOverrideReflectionConfigurationInput : Humidifier.Base.BaseSubResource, IHaveModelId
        {
            /// <summary>
            /// Namespaces
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicoverridereflectionconfigurationinput.html#cfn-bedrockagentcore-memory-episodicoverridereflectionconfigurationinput-namespaces
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Namespaces { get; set; }
            /// <summary>
            /// NamespaceTemplates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicoverridereflectionconfigurationinput.html#cfn-bedrockagentcore-memory-episodicoverridereflectionconfigurationinput-namespacetemplates
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic NamespaceTemplates { get; set; }
            /// <summary>
            /// MemoryRecordSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicoverridereflectionconfigurationinput.html#cfn-bedrockagentcore-memory-episodicoverridereflectionconfigurationinput-memoryrecordschema
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MemoryRecordSchema
            /// </summary>
            public Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema MemoryRecordSchema { get; set; }
            /// <summary>
            /// AppendToPrompt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicoverridereflectionconfigurationinput.html#cfn-bedrockagentcore-memory-episodicoverridereflectionconfigurationinput-appendtoprompt
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AppendToPrompt { get; set; }
            /// <summary>
            /// ModelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicoverridereflectionconfigurationinput.html#cfn-bedrockagentcore-memory-episodicoverridereflectionconfigurationinput-modelid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ModelId { get; set; }
        }

        public class EpisodicReflectionConfigurationInput : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Namespaces
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicreflectionconfigurationinput.html#cfn-bedrockagentcore-memory-episodicreflectionconfigurationinput-namespaces
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Namespaces { get; set; }
            /// <summary>
            /// NamespaceTemplates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicreflectionconfigurationinput.html#cfn-bedrockagentcore-memory-episodicreflectionconfigurationinput-namespacetemplates
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic NamespaceTemplates { get; set; }
            /// <summary>
            /// MemoryRecordSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-episodicreflectionconfigurationinput.html#cfn-bedrockagentcore-memory-episodicreflectionconfigurationinput-memoryrecordschema
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MemoryRecordSchema
            /// </summary>
            public Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema MemoryRecordSchema { get; set; }
        }

        public class ExtractionConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LlmExtractionConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-extractionconfig.html#cfn-bedrockagentcore-memory-extractionconfig-llmextractionconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LlmExtractionConfig
            /// </summary>
            public Humidifier.BedrockAgentCore.MemoryTypes.LlmExtractionConfig LlmExtractionConfig { get; set; }
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
            public dynamic Type { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-indexedkey.html#cfn-bedrockagentcore-memory-indexedkey-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class InvocationConfigurationInput : Humidifier.Base.BaseSubResource, IHaveTopicArn
        {
            /// <summary>
            /// TopicArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-invocationconfigurationinput.html#cfn-bedrockagentcore-memory-invocationconfigurationinput-topicarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TopicArn { get; set; }
            /// <summary>
            /// PayloadDeliveryBucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-invocationconfigurationinput.html#cfn-bedrockagentcore-memory-invocationconfigurationinput-payloaddeliverybucketname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PayloadDeliveryBucketName { get; set; }
        }

        public class KinesisResource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DataStreamArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-kinesisresource.html#cfn-bedrockagentcore-memory-kinesisresource-datastreamarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataStreamArn { get; set; }
            /// <summary>
            /// ContentConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-kinesisresource.html#cfn-bedrockagentcore-memory-kinesisresource-contentconfigurations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ContentConfiguration
            /// </summary>
            public List<Humidifier.BedrockAgentCore.MemoryTypes.ContentConfiguration> ContentConfigurations { get; set; }
        }

        public class LlmExtractionConfig : Humidifier.Base.BaseSubResource, IHaveDefinition
        {
            /// <summary>
            /// Validation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-llmextractionconfig.html#cfn-bedrockagentcore-memory-llmextractionconfig-validation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Validation
            /// </summary>
            public Humidifier.BedrockAgentCore.MemoryTypes.Validation Validation { get; set; }
            /// <summary>
            /// Definition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-llmextractionconfig.html#cfn-bedrockagentcore-memory-llmextractionconfig-definition
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Definition { get; set; }
            /// <summary>
            /// LlmExtractionInstruction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-llmextractionconfig.html#cfn-bedrockagentcore-memory-llmextractionconfig-llmextractioninstruction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LlmExtractionInstruction { get; set; }
        }

        public class MemoryRecordSchema : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MetadataSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-memoryrecordschema.html#cfn-bedrockagentcore-memory-memoryrecordschema-metadataschema
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MetadataSchemaEntry
            /// </summary>
            public List<Humidifier.BedrockAgentCore.MemoryTypes.MetadataSchemaEntry> MetadataSchema { get; set; }
        }

        public class MemoryStrategy : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SummaryMemoryStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-memorystrategy.html#cfn-bedrockagentcore-memory-memorystrategy-summarymemorystrategy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SummaryMemoryStrategy
            /// </summary>
            public Humidifier.BedrockAgentCore.MemoryTypes.SummaryMemoryStrategy SummaryMemoryStrategy { get; set; }
            /// <summary>
            /// CustomMemoryStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-memorystrategy.html#cfn-bedrockagentcore-memory-memorystrategy-custommemorystrategy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomMemoryStrategy
            /// </summary>
            public Humidifier.BedrockAgentCore.MemoryTypes.CustomMemoryStrategy CustomMemoryStrategy { get; set; }
            /// <summary>
            /// SemanticMemoryStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-memorystrategy.html#cfn-bedrockagentcore-memory-memorystrategy-semanticmemorystrategy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SemanticMemoryStrategy
            /// </summary>
            public Humidifier.BedrockAgentCore.MemoryTypes.SemanticMemoryStrategy SemanticMemoryStrategy { get; set; }
            /// <summary>
            /// UserPreferenceMemoryStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-memorystrategy.html#cfn-bedrockagentcore-memory-memorystrategy-userpreferencememorystrategy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UserPreferenceMemoryStrategy
            /// </summary>
            public Humidifier.BedrockAgentCore.MemoryTypes.UserPreferenceMemoryStrategy UserPreferenceMemoryStrategy { get; set; }
            /// <summary>
            /// EpisodicMemoryStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-memorystrategy.html#cfn-bedrockagentcore-memory-memorystrategy-episodicmemorystrategy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EpisodicMemoryStrategy
            /// </summary>
            public Humidifier.BedrockAgentCore.MemoryTypes.EpisodicMemoryStrategy EpisodicMemoryStrategy { get; set; }
        }

        public class MessageBasedTriggerInput : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MessageCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-messagebasedtriggerinput.html#cfn-bedrockagentcore-memory-messagebasedtriggerinput-messagecount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MessageCount { get; set; }
        }

        public class MetadataSchemaEntry : Humidifier.Base.BaseSubResource, IHaveType, IHaveKey
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-metadataschemaentry.html#cfn-bedrockagentcore-memory-metadataschemaentry-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// ExtractionConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-metadataschemaentry.html#cfn-bedrockagentcore-memory-metadataschemaentry-extractionconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ExtractionConfig
            /// </summary>
            public Humidifier.BedrockAgentCore.MemoryTypes.ExtractionConfig ExtractionConfig { get; set; }
            /// <summary>
            /// ExtractionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-metadataschemaentry.html#cfn-bedrockagentcore-memory-metadataschemaentry-extractiontype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExtractionType { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-metadataschemaentry.html#cfn-bedrockagentcore-memory-metadataschemaentry-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class NamespaceKeyEntry : Humidifier.Base.BaseSubResource, IHaveKey
        {
            /// <summary>
            /// Validation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-namespacekeyentry.html#cfn-bedrockagentcore-memory-namespacekeyentry-validation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NamespaceKeyValidation
            /// </summary>
            public Humidifier.BedrockAgentCore.MemoryTypes.NamespaceKeyValidation Validation { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-namespacekeyentry.html#cfn-bedrockagentcore-memory-namespacekeyentry-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class NamespaceKeyValidation : Humidifier.Base.BaseSubResource, IHaveAllowedValues
        {
            /// <summary>
            /// AllowedValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-namespacekeyvalidation.html#cfn-bedrockagentcore-memory-namespacekeyvalidation-allowedvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AllowedValues { get; set; }
            /// <summary>
            /// RegexPattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-namespacekeyvalidation.html#cfn-bedrockagentcore-memory-namespacekeyvalidation-regexpattern
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RegexPattern { get; set; }
        }

        public class NumberValidation : Humidifier.Base.BaseSubResource, IHaveMaxValue, IHaveMinValue
        {
            /// <summary>
            /// MinValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-numbervalidation.html#cfn-bedrockagentcore-memory-numbervalidation-minvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MinValue { get; set; }
            /// <summary>
            /// MaxValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-numbervalidation.html#cfn-bedrockagentcore-memory-numbervalidation-maxvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MaxValue { get; set; }
        }

        public class SelfManagedConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TriggerConditions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-selfmanagedconfiguration.html#cfn-bedrockagentcore-memory-selfmanagedconfiguration-triggerconditions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TriggerConditionInput
            /// </summary>
            public List<Humidifier.BedrockAgentCore.MemoryTypes.TriggerConditionInput> TriggerConditions { get; set; }
            /// <summary>
            /// InvocationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-selfmanagedconfiguration.html#cfn-bedrockagentcore-memory-selfmanagedconfiguration-invocationconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InvocationConfigurationInput
            /// </summary>
            public Humidifier.BedrockAgentCore.MemoryTypes.InvocationConfigurationInput InvocationConfiguration { get; set; }
            /// <summary>
            /// HistoricalContextWindowSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-selfmanagedconfiguration.html#cfn-bedrockagentcore-memory-selfmanagedconfiguration-historicalcontextwindowsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic HistoricalContextWindowSize { get; set; }
        }

        public class SemanticMemoryStrategy : Humidifier.Base.BaseSubResource, IHaveName, IHaveDescription, IHaveType, IHaveStatus, IHaveCreatedAt
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-semanticmemorystrategy.html#cfn-bedrockagentcore-memory-semanticmemorystrategy-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// Namespaces
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-semanticmemorystrategy.html#cfn-bedrockagentcore-memory-semanticmemorystrategy-namespaces
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Namespaces { get; set; }
            /// <summary>
            /// NamespaceTemplates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-semanticmemorystrategy.html#cfn-bedrockagentcore-memory-semanticmemorystrategy-namespacetemplates
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic NamespaceTemplates { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-semanticmemorystrategy.html#cfn-bedrockagentcore-memory-semanticmemorystrategy-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-semanticmemorystrategy.html#cfn-bedrockagentcore-memory-semanticmemorystrategy-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// MemoryRecordSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-semanticmemorystrategy.html#cfn-bedrockagentcore-memory-semanticmemorystrategy-memoryrecordschema
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MemoryRecordSchema
            /// </summary>
            public Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema MemoryRecordSchema { get; set; }
            /// <summary>
            /// CreatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-semanticmemorystrategy.html#cfn-bedrockagentcore-memory-semanticmemorystrategy-createdat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreatedAt { get; set; }
            /// <summary>
            /// StrategyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-semanticmemorystrategy.html#cfn-bedrockagentcore-memory-semanticmemorystrategy-strategyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StrategyId { get; set; }
            /// <summary>
            /// UpdatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-semanticmemorystrategy.html#cfn-bedrockagentcore-memory-semanticmemorystrategy-updatedat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdatedAt { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-semanticmemorystrategy.html#cfn-bedrockagentcore-memory-semanticmemorystrategy-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class SemanticOverride : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Consolidation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-semanticoverride.html#cfn-bedrockagentcore-memory-semanticoverride-consolidation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SemanticOverrideConsolidationConfigurationInput
            /// </summary>
            public Humidifier.BedrockAgentCore.MemoryTypes.SemanticOverrideConsolidationConfigurationInput Consolidation { get; set; }
            /// <summary>
            /// Extraction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-semanticoverride.html#cfn-bedrockagentcore-memory-semanticoverride-extraction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SemanticOverrideExtractionConfigurationInput
            /// </summary>
            public Humidifier.BedrockAgentCore.MemoryTypes.SemanticOverrideExtractionConfigurationInput Extraction { get; set; }
        }

        public class SemanticOverrideConsolidationConfigurationInput : Humidifier.Base.BaseSubResource, IHaveModelId
        {
            /// <summary>
            /// AppendToPrompt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-semanticoverrideconsolidationconfigurationinput.html#cfn-bedrockagentcore-memory-semanticoverrideconsolidationconfigurationinput-appendtoprompt
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AppendToPrompt { get; set; }
            /// <summary>
            /// ModelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-semanticoverrideconsolidationconfigurationinput.html#cfn-bedrockagentcore-memory-semanticoverrideconsolidationconfigurationinput-modelid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ModelId { get; set; }
        }

        public class SemanticOverrideExtractionConfigurationInput : Humidifier.Base.BaseSubResource, IHaveModelId
        {
            /// <summary>
            /// AppendToPrompt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-semanticoverrideextractionconfigurationinput.html#cfn-bedrockagentcore-memory-semanticoverrideextractionconfigurationinput-appendtoprompt
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AppendToPrompt { get; set; }
            /// <summary>
            /// ModelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-semanticoverrideextractionconfigurationinput.html#cfn-bedrockagentcore-memory-semanticoverrideextractionconfigurationinput-modelid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ModelId { get; set; }
        }

        public class StreamDeliveryResource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Kinesis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-streamdeliveryresource.html#cfn-bedrockagentcore-memory-streamdeliveryresource-kinesis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KinesisResource
            /// </summary>
            public Humidifier.BedrockAgentCore.MemoryTypes.KinesisResource Kinesis { get; set; }
        }

        public class StreamDeliveryResources : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Resources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-streamdeliveryresources.html#cfn-bedrockagentcore-memory-streamdeliveryresources-resources
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StreamDeliveryResource
            /// </summary>
            public List<Humidifier.BedrockAgentCore.MemoryTypes.StreamDeliveryResource> Resources { get; set; }
        }

        public class StringListValidation : Humidifier.Base.BaseSubResource, IHaveAllowedValues
        {
            /// <summary>
            /// AllowedValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-stringlistvalidation.html#cfn-bedrockagentcore-memory-stringlistvalidation-allowedvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AllowedValues { get; set; }
            /// <summary>
            /// MaxItems
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-stringlistvalidation.html#cfn-bedrockagentcore-memory-stringlistvalidation-maxitems
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxItems { get; set; }
        }

        public class StringValidation : Humidifier.Base.BaseSubResource, IHaveAllowedValues
        {
            /// <summary>
            /// AllowedValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-stringvalidation.html#cfn-bedrockagentcore-memory-stringvalidation-allowedvalues
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AllowedValues { get; set; }
        }

        public class SummaryMemoryStrategy : Humidifier.Base.BaseSubResource, IHaveName, IHaveDescription, IHaveType, IHaveStatus, IHaveCreatedAt
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-summarymemorystrategy.html#cfn-bedrockagentcore-memory-summarymemorystrategy-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// Namespaces
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-summarymemorystrategy.html#cfn-bedrockagentcore-memory-summarymemorystrategy-namespaces
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Namespaces { get; set; }
            /// <summary>
            /// NamespaceTemplates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-summarymemorystrategy.html#cfn-bedrockagentcore-memory-summarymemorystrategy-namespacetemplates
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic NamespaceTemplates { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-summarymemorystrategy.html#cfn-bedrockagentcore-memory-summarymemorystrategy-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-summarymemorystrategy.html#cfn-bedrockagentcore-memory-summarymemorystrategy-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// MemoryRecordSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-summarymemorystrategy.html#cfn-bedrockagentcore-memory-summarymemorystrategy-memoryrecordschema
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MemoryRecordSchema
            /// </summary>
            public Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema MemoryRecordSchema { get; set; }
            /// <summary>
            /// CreatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-summarymemorystrategy.html#cfn-bedrockagentcore-memory-summarymemorystrategy-createdat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreatedAt { get; set; }
            /// <summary>
            /// StrategyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-summarymemorystrategy.html#cfn-bedrockagentcore-memory-summarymemorystrategy-strategyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StrategyId { get; set; }
            /// <summary>
            /// UpdatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-summarymemorystrategy.html#cfn-bedrockagentcore-memory-summarymemorystrategy-updatedat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdatedAt { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-summarymemorystrategy.html#cfn-bedrockagentcore-memory-summarymemorystrategy-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class SummaryOverride : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Consolidation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-summaryoverride.html#cfn-bedrockagentcore-memory-summaryoverride-consolidation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SummaryOverrideConsolidationConfigurationInput
            /// </summary>
            public Humidifier.BedrockAgentCore.MemoryTypes.SummaryOverrideConsolidationConfigurationInput Consolidation { get; set; }
        }

        public class SummaryOverrideConsolidationConfigurationInput : Humidifier.Base.BaseSubResource, IHaveModelId
        {
            /// <summary>
            /// AppendToPrompt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-summaryoverrideconsolidationconfigurationinput.html#cfn-bedrockagentcore-memory-summaryoverrideconsolidationconfigurationinput-appendtoprompt
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AppendToPrompt { get; set; }
            /// <summary>
            /// ModelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-summaryoverrideconsolidationconfigurationinput.html#cfn-bedrockagentcore-memory-summaryoverrideconsolidationconfigurationinput-modelid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ModelId { get; set; }
        }

        public class TimeBasedTriggerInput : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// IdleSessionTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-timebasedtriggerinput.html#cfn-bedrockagentcore-memory-timebasedtriggerinput-idlesessiontimeout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic IdleSessionTimeout { get; set; }
        }

        public class TokenBasedTriggerInput : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TokenCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-tokenbasedtriggerinput.html#cfn-bedrockagentcore-memory-tokenbasedtriggerinput-tokencount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TokenCount { get; set; }
        }

        public class TriggerConditionInput : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MessageBasedTrigger
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-triggerconditioninput.html#cfn-bedrockagentcore-memory-triggerconditioninput-messagebasedtrigger
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MessageBasedTriggerInput
            /// </summary>
            public Humidifier.BedrockAgentCore.MemoryTypes.MessageBasedTriggerInput MessageBasedTrigger { get; set; }
            /// <summary>
            /// TokenBasedTrigger
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-triggerconditioninput.html#cfn-bedrockagentcore-memory-triggerconditioninput-tokenbasedtrigger
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TokenBasedTriggerInput
            /// </summary>
            public Humidifier.BedrockAgentCore.MemoryTypes.TokenBasedTriggerInput TokenBasedTrigger { get; set; }
            /// <summary>
            /// TimeBasedTrigger
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-triggerconditioninput.html#cfn-bedrockagentcore-memory-triggerconditioninput-timebasedtrigger
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimeBasedTriggerInput
            /// </summary>
            public Humidifier.BedrockAgentCore.MemoryTypes.TimeBasedTriggerInput TimeBasedTrigger { get; set; }
        }

        public class UserPreferenceMemoryStrategy : Humidifier.Base.BaseSubResource, IHaveName, IHaveDescription, IHaveType, IHaveStatus, IHaveCreatedAt
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-userpreferencememorystrategy.html#cfn-bedrockagentcore-memory-userpreferencememorystrategy-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// Namespaces
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-userpreferencememorystrategy.html#cfn-bedrockagentcore-memory-userpreferencememorystrategy-namespaces
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Namespaces { get; set; }
            /// <summary>
            /// NamespaceTemplates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-userpreferencememorystrategy.html#cfn-bedrockagentcore-memory-userpreferencememorystrategy-namespacetemplates
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic NamespaceTemplates { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-userpreferencememorystrategy.html#cfn-bedrockagentcore-memory-userpreferencememorystrategy-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-userpreferencememorystrategy.html#cfn-bedrockagentcore-memory-userpreferencememorystrategy-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// MemoryRecordSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-userpreferencememorystrategy.html#cfn-bedrockagentcore-memory-userpreferencememorystrategy-memoryrecordschema
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MemoryRecordSchema
            /// </summary>
            public Humidifier.BedrockAgentCore.MemoryTypes.MemoryRecordSchema MemoryRecordSchema { get; set; }
            /// <summary>
            /// CreatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-userpreferencememorystrategy.html#cfn-bedrockagentcore-memory-userpreferencememorystrategy-createdat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreatedAt { get; set; }
            /// <summary>
            /// StrategyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-userpreferencememorystrategy.html#cfn-bedrockagentcore-memory-userpreferencememorystrategy-strategyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StrategyId { get; set; }
            /// <summary>
            /// UpdatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-userpreferencememorystrategy.html#cfn-bedrockagentcore-memory-userpreferencememorystrategy-updatedat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdatedAt { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-userpreferencememorystrategy.html#cfn-bedrockagentcore-memory-userpreferencememorystrategy-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class UserPreferenceOverride : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Consolidation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-userpreferenceoverride.html#cfn-bedrockagentcore-memory-userpreferenceoverride-consolidation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UserPreferenceOverrideConsolidationConfigurationInput
            /// </summary>
            public Humidifier.BedrockAgentCore.MemoryTypes.UserPreferenceOverrideConsolidationConfigurationInput Consolidation { get; set; }
            /// <summary>
            /// Extraction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-userpreferenceoverride.html#cfn-bedrockagentcore-memory-userpreferenceoverride-extraction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UserPreferenceOverrideExtractionConfigurationInput
            /// </summary>
            public Humidifier.BedrockAgentCore.MemoryTypes.UserPreferenceOverrideExtractionConfigurationInput Extraction { get; set; }
        }

        public class UserPreferenceOverrideConsolidationConfigurationInput : Humidifier.Base.BaseSubResource, IHaveModelId
        {
            /// <summary>
            /// AppendToPrompt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-userpreferenceoverrideconsolidationconfigurationinput.html#cfn-bedrockagentcore-memory-userpreferenceoverrideconsolidationconfigurationinput-appendtoprompt
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AppendToPrompt { get; set; }
            /// <summary>
            /// ModelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-userpreferenceoverrideconsolidationconfigurationinput.html#cfn-bedrockagentcore-memory-userpreferenceoverrideconsolidationconfigurationinput-modelid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ModelId { get; set; }
        }

        public class UserPreferenceOverrideExtractionConfigurationInput : Humidifier.Base.BaseSubResource, IHaveModelId
        {
            /// <summary>
            /// AppendToPrompt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-userpreferenceoverrideextractionconfigurationinput.html#cfn-bedrockagentcore-memory-userpreferenceoverrideextractionconfigurationinput-appendtoprompt
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AppendToPrompt { get; set; }
            /// <summary>
            /// ModelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-userpreferenceoverrideextractionconfigurationinput.html#cfn-bedrockagentcore-memory-userpreferenceoverrideextractionconfigurationinput-modelid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ModelId { get; set; }
        }

        public class Validation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StringValidation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-validation.html#cfn-bedrockagentcore-memory-validation-stringvalidation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StringValidation
            /// </summary>
            public Humidifier.BedrockAgentCore.MemoryTypes.StringValidation StringValidation { get; set; }
            /// <summary>
            /// NumberValidation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-validation.html#cfn-bedrockagentcore-memory-validation-numbervalidation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumberValidation
            /// </summary>
            public Humidifier.BedrockAgentCore.MemoryTypes.NumberValidation NumberValidation { get; set; }
            /// <summary>
            /// StringListValidation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-memory-validation.html#cfn-bedrockagentcore-memory-validation-stringlistvalidation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StringListValidation
            /// </summary>
            public Humidifier.BedrockAgentCore.MemoryTypes.StringListValidation StringListValidation { get; set; }
        }
    }
}