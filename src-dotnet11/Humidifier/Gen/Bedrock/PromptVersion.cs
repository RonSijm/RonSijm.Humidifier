namespace Humidifier.Bedrock
{
    using global::System.Collections.Generic;
    using PromptVersionTypes;

    public class PromptVersion : Humidifier.Base.BaseResource, IHaveDescription, IHavePromptArn, IHaveStringDictionaryOfTags
    {
        public class Attributes
        {
            public static string Variants =  "Variants" ;
            public static string Version =  "Version" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string CustomerEncryptionKeyArn =  "CustomerEncryptionKeyArn" ;
            public static string Arn =  "Arn" ;
            public static string DefaultVariant =  "DefaultVariant" ;
            public static string PromptId =  "PromptId" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.Bedrock.PromptVersion; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-promptversion.html#cfn-bedrock-promptversion-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// PromptArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-promptversion.html#cfn-bedrock-promptversion-promptarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PromptArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-promptversion.html#cfn-bedrock-promptversion-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace PromptVersionTypes
    {
        public class CachePointBlock : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-cachepointblock.html#cfn-bedrock-promptversion-cachepointblock-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
        }

        public class ChatPromptTemplateConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfBedrockPromptVersionTypesMessageMessages, IHaveListOfBedrockPromptVersionTypesPromptInputVariableInputVariables, IHaveBedrockPromptVersionTypesToolConfigurationToolConfiguration, IHaveListOfBedrockPromptVersionTypesSystemContentBlockSystem
        {
            /// <summary>
            /// Messages
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-chatprompttemplateconfiguration.html#cfn-bedrock-promptversion-chatprompttemplateconfiguration-messages
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Message
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.PromptVersionTypes.Message>, IReadOnlyList<Union<Humidifier.Bedrock.PromptVersionTypes.Message, BaseFunction>>, BaseFunction>? Messages { get; set; }
            /// <summary>
            /// InputVariables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-chatprompttemplateconfiguration.html#cfn-bedrock-promptversion-chatprompttemplateconfiguration-inputvariables
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PromptInputVariable
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.PromptVersionTypes.PromptInputVariable>, IReadOnlyList<Union<Humidifier.Bedrock.PromptVersionTypes.PromptInputVariable, BaseFunction>>, BaseFunction>? InputVariables { get; set; }
            /// <summary>
            /// ToolConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-chatprompttemplateconfiguration.html#cfn-bedrock-promptversion-chatprompttemplateconfiguration-toolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ToolConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.PromptVersionTypes.ToolConfiguration, BaseFunction>? ToolConfiguration { get; set; }
            /// <summary>
            /// System
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-chatprompttemplateconfiguration.html#cfn-bedrock-promptversion-chatprompttemplateconfiguration-system
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SystemContentBlock
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.PromptVersionTypes.SystemContentBlock>, IReadOnlyList<Union<Humidifier.Bedrock.PromptVersionTypes.SystemContentBlock, BaseFunction>>, BaseFunction>? System { get; set; }
        }

        public class ContentBlock : Humidifier.Base.BaseSubResource, IHaveBedrockPromptVersionTypesCachePointBlockCachePoint, IHaveText
        {
            /// <summary>
            /// CachePoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-contentblock.html#cfn-bedrock-promptversion-contentblock-cachepoint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CachePointBlock
            /// </summary>
            public Union<Humidifier.Bedrock.PromptVersionTypes.CachePointBlock, BaseFunction>? CachePoint { get; set; }
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-contentblock.html#cfn-bedrock-promptversion-contentblock-text
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Text { get; set; }
        }

        public class Message : Humidifier.Base.BaseSubResource, IHaveRole, IHaveListOfBedrockPromptVersionTypesContentBlockContent
        {
            /// <summary>
            /// Role
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-message.html#cfn-bedrock-promptversion-message-role
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Role { get; set; }
            /// <summary>
            /// Content
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-message.html#cfn-bedrock-promptversion-message-content
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ContentBlock
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.PromptVersionTypes.ContentBlock>, IReadOnlyList<Union<Humidifier.Bedrock.PromptVersionTypes.ContentBlock, BaseFunction>>, BaseFunction>? Content { get; set; }
        }

        public class PromptAgentResource : Humidifier.Base.BaseSubResource, IHaveAgentIdentifier
        {
            /// <summary>
            /// AgentIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-promptagentresource.html#cfn-bedrock-promptversion-promptagentresource-agentidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AgentIdentifier { get; set; }
        }

        public class PromptGenAiResource : Humidifier.Base.BaseSubResource, IHaveBedrockPromptVersionTypesPromptAgentResourceAgent
        {
            /// <summary>
            /// Agent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-promptgenairesource.html#cfn-bedrock-promptversion-promptgenairesource-agent
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PromptAgentResource
            /// </summary>
            public Union<Humidifier.Bedrock.PromptVersionTypes.PromptAgentResource, BaseFunction>? Agent { get; set; }
        }

        public class PromptInferenceConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockPromptVersionTypesPromptModelInferenceConfigurationText
        {
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-promptinferenceconfiguration.html#cfn-bedrock-promptversion-promptinferenceconfiguration-text
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PromptModelInferenceConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.PromptVersionTypes.PromptModelInferenceConfiguration, BaseFunction>? Text { get; set; }
        }

        public class PromptInputVariable : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-promptinputvariable.html#cfn-bedrock-promptversion-promptinputvariable-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class PromptMetadataEntry : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-promptmetadataentry.html#cfn-bedrock-promptversion-promptmetadataentry-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-promptmetadataentry.html#cfn-bedrock-promptversion-promptmetadataentry-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class PromptModelInferenceConfiguration : Humidifier.Base.BaseSubResource, IHaveTemperature_Double, IHaveStringListOfStopSequences, IHaveMaxTokens_Double, IHaveTopP_Double
        {
            /// <summary>
            /// Temperature
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-promptmodelinferenceconfiguration.html#cfn-bedrock-promptversion-promptmodelinferenceconfiguration-temperature
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Temperature { get; set; }
            /// <summary>
            /// StopSequences
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-promptmodelinferenceconfiguration.html#cfn-bedrock-promptversion-promptmodelinferenceconfiguration-stopsequences
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? StopSequences { get; set; }
            /// <summary>
            /// MaxTokens
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-promptmodelinferenceconfiguration.html#cfn-bedrock-promptversion-promptmodelinferenceconfiguration-maxtokens
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MaxTokens { get; set; }
            /// <summary>
            /// TopP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-promptmodelinferenceconfiguration.html#cfn-bedrock-promptversion-promptmodelinferenceconfiguration-topp
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TopP { get; set; }
        }

        public class PromptTemplateConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockPromptVersionTypesChatPromptTemplateConfigurationChat, IHaveBedrockPromptVersionTypesTextPromptTemplateConfigurationText
        {
            /// <summary>
            /// Chat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-prompttemplateconfiguration.html#cfn-bedrock-promptversion-prompttemplateconfiguration-chat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChatPromptTemplateConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.PromptVersionTypes.ChatPromptTemplateConfiguration, BaseFunction>? Chat { get; set; }
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-prompttemplateconfiguration.html#cfn-bedrock-promptversion-prompttemplateconfiguration-text
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TextPromptTemplateConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.PromptVersionTypes.TextPromptTemplateConfiguration, BaseFunction>? Text { get; set; }
        }

        public class PromptVariant : Humidifier.Base.BaseSubResource, IHaveAdditionalModelRequestFields_Json, IHaveBedrockPromptVersionTypesPromptInferenceConfigurationInferenceConfiguration, IHaveListOfBedrockPromptVersionTypesPromptMetadataEntryMetadata, IHaveBedrockPromptVersionTypesPromptGenAiResourceGenAiResource, IHaveBedrockPromptVersionTypesPromptTemplateConfigurationTemplateConfiguration, IHaveTemplateType, IHaveModelId, IHaveName
        {
            /// <summary>
            /// AdditionalModelRequestFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-promptvariant.html#cfn-bedrock-promptversion-promptvariant-additionalmodelrequestfields
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? AdditionalModelRequestFields { get; set; }
            /// <summary>
            /// InferenceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-promptvariant.html#cfn-bedrock-promptversion-promptvariant-inferenceconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PromptInferenceConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.PromptVersionTypes.PromptInferenceConfiguration, BaseFunction>? InferenceConfiguration { get; set; }
            /// <summary>
            /// Metadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-promptvariant.html#cfn-bedrock-promptversion-promptvariant-metadata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PromptMetadataEntry
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.PromptVersionTypes.PromptMetadataEntry>, IReadOnlyList<Union<Humidifier.Bedrock.PromptVersionTypes.PromptMetadataEntry, BaseFunction>>, BaseFunction>? Metadata { get; set; }
            /// <summary>
            /// GenAiResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-promptvariant.html#cfn-bedrock-promptversion-promptvariant-genairesource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PromptGenAiResource
            /// </summary>
            public Union<Humidifier.Bedrock.PromptVersionTypes.PromptGenAiResource, BaseFunction>? GenAiResource { get; set; }
            /// <summary>
            /// TemplateConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-promptvariant.html#cfn-bedrock-promptversion-promptvariant-templateconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PromptTemplateConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.PromptVersionTypes.PromptTemplateConfiguration, BaseFunction>? TemplateConfiguration { get; set; }
            /// <summary>
            /// TemplateType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-promptvariant.html#cfn-bedrock-promptversion-promptvariant-templatetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TemplateType { get; set; }
            /// <summary>
            /// ModelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-promptvariant.html#cfn-bedrock-promptversion-promptvariant-modelid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-promptvariant.html#cfn-bedrock-promptversion-promptvariant-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class SpecificToolChoice : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-specifictoolchoice.html#cfn-bedrock-promptversion-specifictoolchoice-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class SystemContentBlock : Humidifier.Base.BaseSubResource, IHaveBedrockPromptVersionTypesCachePointBlockCachePoint, IHaveText
        {
            /// <summary>
            /// CachePoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-systemcontentblock.html#cfn-bedrock-promptversion-systemcontentblock-cachepoint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CachePointBlock
            /// </summary>
            public Union<Humidifier.Bedrock.PromptVersionTypes.CachePointBlock, BaseFunction>? CachePoint { get; set; }
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-systemcontentblock.html#cfn-bedrock-promptversion-systemcontentblock-text
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Text { get; set; }
        }

        public class TextPromptTemplateConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfBedrockPromptVersionTypesPromptInputVariableInputVariables, IHaveBedrockPromptVersionTypesCachePointBlockCachePoint, IHaveText
        {
            /// <summary>
            /// InputVariables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-textprompttemplateconfiguration.html#cfn-bedrock-promptversion-textprompttemplateconfiguration-inputvariables
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PromptInputVariable
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.PromptVersionTypes.PromptInputVariable>, IReadOnlyList<Union<Humidifier.Bedrock.PromptVersionTypes.PromptInputVariable, BaseFunction>>, BaseFunction>? InputVariables { get; set; }
            /// <summary>
            /// CachePoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-textprompttemplateconfiguration.html#cfn-bedrock-promptversion-textprompttemplateconfiguration-cachepoint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CachePointBlock
            /// </summary>
            public Union<Humidifier.Bedrock.PromptVersionTypes.CachePointBlock, BaseFunction>? CachePoint { get; set; }
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-textprompttemplateconfiguration.html#cfn-bedrock-promptversion-textprompttemplateconfiguration-text
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Text { get; set; }
        }

        public class Tool : Humidifier.Base.BaseSubResource, IHaveBedrockPromptVersionTypesCachePointBlockCachePoint, IHaveBedrockPromptVersionTypesToolSpecificationToolSpec
        {
            /// <summary>
            /// CachePoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-tool.html#cfn-bedrock-promptversion-tool-cachepoint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CachePointBlock
            /// </summary>
            public Union<Humidifier.Bedrock.PromptVersionTypes.CachePointBlock, BaseFunction>? CachePoint { get; set; }
            /// <summary>
            /// ToolSpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-tool.html#cfn-bedrock-promptversion-tool-toolspec
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ToolSpecification
            /// </summary>
            public Union<Humidifier.Bedrock.PromptVersionTypes.ToolSpecification, BaseFunction>? ToolSpec { get; set; }
        }

        public class ToolChoice : Humidifier.Base.BaseSubResource, IHaveAuto_Json, IHaveAny_Json, IHaveBedrockPromptVersionTypesSpecificToolChoiceTool
        {
            /// <summary>
            /// Auto
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-toolchoice.html#cfn-bedrock-promptversion-toolchoice-auto
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Auto { get; set; }
            /// <summary>
            /// Any
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-toolchoice.html#cfn-bedrock-promptversion-toolchoice-any
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Any { get; set; }
            /// <summary>
            /// Tool
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-toolchoice.html#cfn-bedrock-promptversion-toolchoice-tool
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SpecificToolChoice
            /// </summary>
            public Union<Humidifier.Bedrock.PromptVersionTypes.SpecificToolChoice, BaseFunction>? Tool { get; set; }
        }

        public class ToolConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockPromptVersionTypesToolChoiceToolChoice, IHaveListOfBedrockPromptVersionTypesToolTools
        {
            /// <summary>
            /// ToolChoice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-toolconfiguration.html#cfn-bedrock-promptversion-toolconfiguration-toolchoice
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ToolChoice
            /// </summary>
            public Union<Humidifier.Bedrock.PromptVersionTypes.ToolChoice, BaseFunction>? ToolChoice { get; set; }
            /// <summary>
            /// Tools
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-toolconfiguration.html#cfn-bedrock-promptversion-toolconfiguration-tools
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tool
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.PromptVersionTypes.Tool>, IReadOnlyList<Union<Humidifier.Bedrock.PromptVersionTypes.Tool, BaseFunction>>, BaseFunction>? Tools { get; set; }
        }

        public class ToolInputSchema : Humidifier.Base.BaseSubResource, IHaveJson_Json
        {
            /// <summary>
            /// Json
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-toolinputschema.html#cfn-bedrock-promptversion-toolinputschema-json
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Json { get; set; }
        }

        public class ToolSpecification : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveBedrockPromptVersionTypesToolInputSchemaInputSchema, IHaveName
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-toolspecification.html#cfn-bedrock-promptversion-toolspecification-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// InputSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-toolspecification.html#cfn-bedrock-promptversion-toolspecification-inputschema
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ToolInputSchema
            /// </summary>
            public Union<Humidifier.Bedrock.PromptVersionTypes.ToolInputSchema, BaseFunction>? InputSchema { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-toolspecification.html#cfn-bedrock-promptversion-toolspecification-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }
    }
}