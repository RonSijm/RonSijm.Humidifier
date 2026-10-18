namespace Humidifier.Bedrock
{
    using global::System.Collections.Generic;
    using PromptTypes;

    public class Prompt : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveListOfBedrockPromptTypesPromptVariantVariants, IHaveDescription, IHaveCustomerEncryptionKeyArn, IHaveDefaultVariant, IHaveStringDictionaryOfTags, IHaveName
    {
        public class Attributes
        {
            public static string Version =  "Version" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.Bedrock.Prompt; }
        /// <summary>
        /// Variants
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-prompt.html#cfn-bedrock-prompt-variants
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: PromptVariant
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Bedrock.PromptTypes.PromptVariant>, IReadOnlyList<Union<Humidifier.Bedrock.PromptTypes.PromptVariant, BaseFunction>>, BaseFunction>? Variants { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-prompt.html#cfn-bedrock-prompt-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// CustomerEncryptionKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-prompt.html#cfn-bedrock-prompt-customerencryptionkeyarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CustomerEncryptionKeyArn { get; set; }
        /// <summary>
        /// DefaultVariant
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-prompt.html#cfn-bedrock-prompt-defaultvariant
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DefaultVariant { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-prompt.html#cfn-bedrock-prompt-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace PromptTypes
    {
        public class CachePointBlock : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-cachepointblock.html#cfn-bedrock-prompt-cachepointblock-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
        }

        public class ChatPromptTemplateConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfBedrockPromptTypesMessageMessages, IHaveListOfBedrockPromptTypesPromptInputVariableInputVariables, IHaveBedrockPromptTypesToolConfigurationToolConfiguration, IHaveListOfBedrockPromptTypesSystemContentBlockSystem
        {
            /// <summary>
            /// Messages
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-chatprompttemplateconfiguration.html#cfn-bedrock-prompt-chatprompttemplateconfiguration-messages
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Message
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.PromptTypes.Message>, IReadOnlyList<Union<Humidifier.Bedrock.PromptTypes.Message, BaseFunction>>, BaseFunction>? Messages { get; set; }
            /// <summary>
            /// InputVariables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-chatprompttemplateconfiguration.html#cfn-bedrock-prompt-chatprompttemplateconfiguration-inputvariables
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PromptInputVariable
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.PromptTypes.PromptInputVariable>, IReadOnlyList<Union<Humidifier.Bedrock.PromptTypes.PromptInputVariable, BaseFunction>>, BaseFunction>? InputVariables { get; set; }
            /// <summary>
            /// ToolConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-chatprompttemplateconfiguration.html#cfn-bedrock-prompt-chatprompttemplateconfiguration-toolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ToolConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.PromptTypes.ToolConfiguration, BaseFunction>? ToolConfiguration { get; set; }
            /// <summary>
            /// System
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-chatprompttemplateconfiguration.html#cfn-bedrock-prompt-chatprompttemplateconfiguration-system
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SystemContentBlock
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.PromptTypes.SystemContentBlock>, IReadOnlyList<Union<Humidifier.Bedrock.PromptTypes.SystemContentBlock, BaseFunction>>, BaseFunction>? System { get; set; }
        }

        public class ContentBlock : Humidifier.Base.BaseSubResource, IHaveBedrockPromptTypesCachePointBlockCachePoint, IHaveText
        {
            /// <summary>
            /// CachePoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-contentblock.html#cfn-bedrock-prompt-contentblock-cachepoint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CachePointBlock
            /// </summary>
            public Union<Humidifier.Bedrock.PromptTypes.CachePointBlock, BaseFunction>? CachePoint { get; set; }
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-contentblock.html#cfn-bedrock-prompt-contentblock-text
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Text { get; set; }
        }

        public class Message : Humidifier.Base.BaseSubResource, IHaveRole, IHaveListOfBedrockPromptTypesContentBlockContent
        {
            /// <summary>
            /// Role
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-message.html#cfn-bedrock-prompt-message-role
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Role { get; set; }
            /// <summary>
            /// Content
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-message.html#cfn-bedrock-prompt-message-content
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ContentBlock
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.PromptTypes.ContentBlock>, IReadOnlyList<Union<Humidifier.Bedrock.PromptTypes.ContentBlock, BaseFunction>>, BaseFunction>? Content { get; set; }
        }

        public class PromptAgentResource : Humidifier.Base.BaseSubResource, IHaveAgentIdentifier
        {
            /// <summary>
            /// AgentIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-promptagentresource.html#cfn-bedrock-prompt-promptagentresource-agentidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AgentIdentifier { get; set; }
        }

        public class PromptGenAiResource : Humidifier.Base.BaseSubResource, IHaveBedrockPromptTypesPromptAgentResourceAgent
        {
            /// <summary>
            /// Agent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-promptgenairesource.html#cfn-bedrock-prompt-promptgenairesource-agent
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PromptAgentResource
            /// </summary>
            public Union<Humidifier.Bedrock.PromptTypes.PromptAgentResource, BaseFunction>? Agent { get; set; }
        }

        public class PromptInferenceConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockPromptTypesPromptModelInferenceConfigurationText
        {
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-promptinferenceconfiguration.html#cfn-bedrock-prompt-promptinferenceconfiguration-text
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PromptModelInferenceConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.PromptTypes.PromptModelInferenceConfiguration, BaseFunction>? Text { get; set; }
        }

        public class PromptInputVariable : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-promptinputvariable.html#cfn-bedrock-prompt-promptinputvariable-name
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-promptmetadataentry.html#cfn-bedrock-prompt-promptmetadataentry-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-promptmetadataentry.html#cfn-bedrock-prompt-promptmetadataentry-key
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-promptmodelinferenceconfiguration.html#cfn-bedrock-prompt-promptmodelinferenceconfiguration-temperature
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Temperature { get; set; }
            /// <summary>
            /// StopSequences
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-promptmodelinferenceconfiguration.html#cfn-bedrock-prompt-promptmodelinferenceconfiguration-stopsequences
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? StopSequences { get; set; }
            /// <summary>
            /// MaxTokens
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-promptmodelinferenceconfiguration.html#cfn-bedrock-prompt-promptmodelinferenceconfiguration-maxtokens
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MaxTokens { get; set; }
            /// <summary>
            /// TopP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-promptmodelinferenceconfiguration.html#cfn-bedrock-prompt-promptmodelinferenceconfiguration-topp
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TopP { get; set; }
        }

        public class PromptTemplateConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockPromptTypesChatPromptTemplateConfigurationChat, IHaveBedrockPromptTypesTextPromptTemplateConfigurationText
        {
            /// <summary>
            /// Chat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-prompttemplateconfiguration.html#cfn-bedrock-prompt-prompttemplateconfiguration-chat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChatPromptTemplateConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.PromptTypes.ChatPromptTemplateConfiguration, BaseFunction>? Chat { get; set; }
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-prompttemplateconfiguration.html#cfn-bedrock-prompt-prompttemplateconfiguration-text
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TextPromptTemplateConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.PromptTypes.TextPromptTemplateConfiguration, BaseFunction>? Text { get; set; }
        }

        public class PromptVariant : Humidifier.Base.BaseSubResource, IHaveAdditionalModelRequestFields_Json, IHaveBedrockPromptTypesPromptInferenceConfigurationInferenceConfiguration, IHaveListOfBedrockPromptTypesPromptMetadataEntryMetadata, IHaveBedrockPromptTypesPromptGenAiResourceGenAiResource, IHaveBedrockPromptTypesPromptTemplateConfigurationTemplateConfiguration, IHaveTemplateType, IHaveModelId, IHaveName
        {
            /// <summary>
            /// AdditionalModelRequestFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-promptvariant.html#cfn-bedrock-prompt-promptvariant-additionalmodelrequestfields
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? AdditionalModelRequestFields { get; set; }
            /// <summary>
            /// InferenceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-promptvariant.html#cfn-bedrock-prompt-promptvariant-inferenceconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PromptInferenceConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.PromptTypes.PromptInferenceConfiguration, BaseFunction>? InferenceConfiguration { get; set; }
            /// <summary>
            /// Metadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-promptvariant.html#cfn-bedrock-prompt-promptvariant-metadata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PromptMetadataEntry
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.PromptTypes.PromptMetadataEntry>, IReadOnlyList<Union<Humidifier.Bedrock.PromptTypes.PromptMetadataEntry, BaseFunction>>, BaseFunction>? Metadata { get; set; }
            /// <summary>
            /// GenAiResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-promptvariant.html#cfn-bedrock-prompt-promptvariant-genairesource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PromptGenAiResource
            /// </summary>
            public Union<Humidifier.Bedrock.PromptTypes.PromptGenAiResource, BaseFunction>? GenAiResource { get; set; }
            /// <summary>
            /// TemplateConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-promptvariant.html#cfn-bedrock-prompt-promptvariant-templateconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PromptTemplateConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.PromptTypes.PromptTemplateConfiguration, BaseFunction>? TemplateConfiguration { get; set; }
            /// <summary>
            /// TemplateType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-promptvariant.html#cfn-bedrock-prompt-promptvariant-templatetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TemplateType { get; set; }
            /// <summary>
            /// ModelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-promptvariant.html#cfn-bedrock-prompt-promptvariant-modelid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-promptvariant.html#cfn-bedrock-prompt-promptvariant-name
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-specifictoolchoice.html#cfn-bedrock-prompt-specifictoolchoice-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class SystemContentBlock : Humidifier.Base.BaseSubResource, IHaveBedrockPromptTypesCachePointBlockCachePoint, IHaveText
        {
            /// <summary>
            /// CachePoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-systemcontentblock.html#cfn-bedrock-prompt-systemcontentblock-cachepoint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CachePointBlock
            /// </summary>
            public Union<Humidifier.Bedrock.PromptTypes.CachePointBlock, BaseFunction>? CachePoint { get; set; }
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-systemcontentblock.html#cfn-bedrock-prompt-systemcontentblock-text
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Text { get; set; }
        }

        public class TextPromptTemplateConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfBedrockPromptTypesPromptInputVariableInputVariables, IHaveBedrockPromptTypesTextS3LocationTextS3Location, IHaveBedrockPromptTypesCachePointBlockCachePoint, IHaveText
        {
            /// <summary>
            /// InputVariables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-textprompttemplateconfiguration.html#cfn-bedrock-prompt-textprompttemplateconfiguration-inputvariables
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PromptInputVariable
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.PromptTypes.PromptInputVariable>, IReadOnlyList<Union<Humidifier.Bedrock.PromptTypes.PromptInputVariable, BaseFunction>>, BaseFunction>? InputVariables { get; set; }
            /// <summary>
            /// TextS3Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-textprompttemplateconfiguration.html#cfn-bedrock-prompt-textprompttemplateconfiguration-texts3location
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TextS3Location
            /// </summary>
            public Union<Humidifier.Bedrock.PromptTypes.TextS3Location, BaseFunction>? TextS3Location { get; set; }
            /// <summary>
            /// CachePoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-textprompttemplateconfiguration.html#cfn-bedrock-prompt-textprompttemplateconfiguration-cachepoint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CachePointBlock
            /// </summary>
            public Union<Humidifier.Bedrock.PromptTypes.CachePointBlock, BaseFunction>? CachePoint { get; set; }
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-textprompttemplateconfiguration.html#cfn-bedrock-prompt-textprompttemplateconfiguration-text
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Text { get; set; }
        }

        public class TextS3Location : Humidifier.Base.BaseSubResource, IHaveBucket, IHaveVersion, IHaveKey
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-texts3location.html#cfn-bedrock-prompt-texts3location-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-texts3location.html#cfn-bedrock-prompt-texts3location-version
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Version { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-texts3location.html#cfn-bedrock-prompt-texts3location-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class Tool : Humidifier.Base.BaseSubResource, IHaveBedrockPromptTypesCachePointBlockCachePoint, IHaveBedrockPromptTypesToolSpecificationToolSpec
        {
            /// <summary>
            /// CachePoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-tool.html#cfn-bedrock-prompt-tool-cachepoint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CachePointBlock
            /// </summary>
            public Union<Humidifier.Bedrock.PromptTypes.CachePointBlock, BaseFunction>? CachePoint { get; set; }
            /// <summary>
            /// ToolSpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-tool.html#cfn-bedrock-prompt-tool-toolspec
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ToolSpecification
            /// </summary>
            public Union<Humidifier.Bedrock.PromptTypes.ToolSpecification, BaseFunction>? ToolSpec { get; set; }
        }

        public class ToolChoice : Humidifier.Base.BaseSubResource, IHaveAuto_Json, IHaveAny_Json, IHaveBedrockPromptTypesSpecificToolChoiceTool
        {
            /// <summary>
            /// Auto
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-toolchoice.html#cfn-bedrock-prompt-toolchoice-auto
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Auto { get; set; }
            /// <summary>
            /// Any
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-toolchoice.html#cfn-bedrock-prompt-toolchoice-any
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Any { get; set; }
            /// <summary>
            /// Tool
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-toolchoice.html#cfn-bedrock-prompt-toolchoice-tool
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SpecificToolChoice
            /// </summary>
            public Union<Humidifier.Bedrock.PromptTypes.SpecificToolChoice, BaseFunction>? Tool { get; set; }
        }

        public class ToolConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockPromptTypesToolChoiceToolChoice, IHaveListOfBedrockPromptTypesToolTools
        {
            /// <summary>
            /// ToolChoice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-toolconfiguration.html#cfn-bedrock-prompt-toolconfiguration-toolchoice
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ToolChoice
            /// </summary>
            public Union<Humidifier.Bedrock.PromptTypes.ToolChoice, BaseFunction>? ToolChoice { get; set; }
            /// <summary>
            /// Tools
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-toolconfiguration.html#cfn-bedrock-prompt-toolconfiguration-tools
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tool
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.PromptTypes.Tool>, IReadOnlyList<Union<Humidifier.Bedrock.PromptTypes.Tool, BaseFunction>>, BaseFunction>? Tools { get; set; }
        }

        public class ToolInputSchema : Humidifier.Base.BaseSubResource, IHaveJson_Json
        {
            /// <summary>
            /// Json
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-toolinputschema.html#cfn-bedrock-prompt-toolinputschema-json
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Json { get; set; }
        }

        public class ToolSpecification : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveBedrockPromptTypesToolInputSchemaInputSchema, IHaveName
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-toolspecification.html#cfn-bedrock-prompt-toolspecification-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// InputSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-toolspecification.html#cfn-bedrock-prompt-toolspecification-inputschema
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ToolInputSchema
            /// </summary>
            public Union<Humidifier.Bedrock.PromptTypes.ToolInputSchema, BaseFunction>? InputSchema { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-toolspecification.html#cfn-bedrock-prompt-toolspecification-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }
    }
}