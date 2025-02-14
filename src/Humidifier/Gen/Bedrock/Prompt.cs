namespace Humidifier.Bedrock
{
    using System.Collections.Generic;
    using PromptTypes;

    public class Prompt : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveDescription, IHaveCustomerEncryptionKeyArn
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
        public List<Humidifier.Bedrock.PromptTypes.PromptVariant> Variants { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-prompt.html#cfn-bedrock-prompt-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// CustomerEncryptionKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-prompt.html#cfn-bedrock-prompt-customerencryptionkeyarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CustomerEncryptionKeyArn { get; set; }
        /// <summary>
        /// DefaultVariant
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-prompt.html#cfn-bedrock-prompt-defaultvariant
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DefaultVariant { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-prompt.html#cfn-bedrock-prompt-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
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
            public dynamic Type { get; set; }
        }

        public class ChatPromptTemplateConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Messages
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-chatprompttemplateconfiguration.html#cfn-bedrock-prompt-chatprompttemplateconfiguration-messages
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Message
            /// </summary>
            public List<Humidifier.Bedrock.PromptTypes.Message> Messages { get; set; }
            /// <summary>
            /// InputVariables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-chatprompttemplateconfiguration.html#cfn-bedrock-prompt-chatprompttemplateconfiguration-inputvariables
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PromptInputVariable
            /// </summary>
            public List<Humidifier.Bedrock.PromptTypes.PromptInputVariable> InputVariables { get; set; }
            /// <summary>
            /// ToolConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-chatprompttemplateconfiguration.html#cfn-bedrock-prompt-chatprompttemplateconfiguration-toolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ToolConfiguration
            /// </summary>
            public Humidifier.Bedrock.PromptTypes.ToolConfiguration ToolConfiguration { get; set; }
            /// <summary>
            /// System
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-chatprompttemplateconfiguration.html#cfn-bedrock-prompt-chatprompttemplateconfiguration-system
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SystemContentBlock
            /// </summary>
            public List<Humidifier.Bedrock.PromptTypes.SystemContentBlock> System { get; set; }
        }

        public class ContentBlock : Humidifier.Base.BaseSubResource, IHaveText
        {
            /// <summary>
            /// CachePoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-contentblock.html#cfn-bedrock-prompt-contentblock-cachepoint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CachePointBlock
            /// </summary>
            public Humidifier.Bedrock.PromptTypes.CachePointBlock CachePoint { get; set; }
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-contentblock.html#cfn-bedrock-prompt-contentblock-text
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Text { get; set; }
        }

        public class Message : Humidifier.Base.BaseSubResource, IHaveRole
        {
            /// <summary>
            /// Role
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-message.html#cfn-bedrock-prompt-message-role
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Role { get; set; }
            /// <summary>
            /// Content
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-message.html#cfn-bedrock-prompt-message-content
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ContentBlock
            /// </summary>
            public List<Humidifier.Bedrock.PromptTypes.ContentBlock> Content { get; set; }
        }

        public class PromptAgentResource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AgentIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-promptagentresource.html#cfn-bedrock-prompt-promptagentresource-agentidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AgentIdentifier { get; set; }
        }

        public class PromptGenAiResource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Agent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-promptgenairesource.html#cfn-bedrock-prompt-promptgenairesource-agent
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PromptAgentResource
            /// </summary>
            public Humidifier.Bedrock.PromptTypes.PromptAgentResource Agent { get; set; }
        }

        public class PromptInferenceConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-promptinferenceconfiguration.html#cfn-bedrock-prompt-promptinferenceconfiguration-text
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PromptModelInferenceConfiguration
            /// </summary>
            public Humidifier.Bedrock.PromptTypes.PromptModelInferenceConfiguration Text { get; set; }
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
            public dynamic Name { get; set; }
        }

        public class PromptModelInferenceConfiguration : Humidifier.Base.BaseSubResource, IHaveMaxTokens, IHaveTemperature, IHaveStopSequences, IHaveTopP
        {
            /// <summary>
            /// Temperature
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-promptmodelinferenceconfiguration.html#cfn-bedrock-prompt-promptmodelinferenceconfiguration-temperature
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Temperature { get; set; }
            /// <summary>
            /// StopSequences
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-promptmodelinferenceconfiguration.html#cfn-bedrock-prompt-promptmodelinferenceconfiguration-stopsequences
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic StopSequences { get; set; }
            /// <summary>
            /// MaxTokens
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-promptmodelinferenceconfiguration.html#cfn-bedrock-prompt-promptmodelinferenceconfiguration-maxtokens
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MaxTokens { get; set; }
            /// <summary>
            /// TopP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-promptmodelinferenceconfiguration.html#cfn-bedrock-prompt-promptmodelinferenceconfiguration-topp
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TopP { get; set; }
        }

        public class PromptTemplateConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Chat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-prompttemplateconfiguration.html#cfn-bedrock-prompt-prompttemplateconfiguration-chat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChatPromptTemplateConfiguration
            /// </summary>
            public Humidifier.Bedrock.PromptTypes.ChatPromptTemplateConfiguration Chat { get; set; }
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-prompttemplateconfiguration.html#cfn-bedrock-prompt-prompttemplateconfiguration-text
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TextPromptTemplateConfiguration
            /// </summary>
            public Humidifier.Bedrock.PromptTypes.TextPromptTemplateConfiguration Text { get; set; }
        }

        public class PromptVariant : Humidifier.Base.BaseSubResource, IHaveName, IHaveModelId, IHaveTemplateType
        {
            /// <summary>
            /// AdditionalModelRequestFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-promptvariant.html#cfn-bedrock-prompt-promptvariant-additionalmodelrequestfields
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic AdditionalModelRequestFields { get; set; }
            /// <summary>
            /// InferenceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-promptvariant.html#cfn-bedrock-prompt-promptvariant-inferenceconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PromptInferenceConfiguration
            /// </summary>
            public Humidifier.Bedrock.PromptTypes.PromptInferenceConfiguration InferenceConfiguration { get; set; }
            /// <summary>
            /// GenAiResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-promptvariant.html#cfn-bedrock-prompt-promptvariant-genairesource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PromptGenAiResource
            /// </summary>
            public Humidifier.Bedrock.PromptTypes.PromptGenAiResource GenAiResource { get; set; }
            /// <summary>
            /// TemplateConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-promptvariant.html#cfn-bedrock-prompt-promptvariant-templateconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PromptTemplateConfiguration
            /// </summary>
            public Humidifier.Bedrock.PromptTypes.PromptTemplateConfiguration TemplateConfiguration { get; set; }
            /// <summary>
            /// TemplateType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-promptvariant.html#cfn-bedrock-prompt-promptvariant-templatetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TemplateType { get; set; }
            /// <summary>
            /// ModelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-promptvariant.html#cfn-bedrock-prompt-promptvariant-modelid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ModelId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-promptvariant.html#cfn-bedrock-prompt-promptvariant-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
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
            public dynamic Name { get; set; }
        }

        public class SystemContentBlock : Humidifier.Base.BaseSubResource, IHaveText
        {
            /// <summary>
            /// CachePoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-systemcontentblock.html#cfn-bedrock-prompt-systemcontentblock-cachepoint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CachePointBlock
            /// </summary>
            public Humidifier.Bedrock.PromptTypes.CachePointBlock CachePoint { get; set; }
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-systemcontentblock.html#cfn-bedrock-prompt-systemcontentblock-text
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Text { get; set; }
        }

        public class TextPromptTemplateConfiguration : Humidifier.Base.BaseSubResource, IHaveText
        {
            /// <summary>
            /// InputVariables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-textprompttemplateconfiguration.html#cfn-bedrock-prompt-textprompttemplateconfiguration-inputvariables
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PromptInputVariable
            /// </summary>
            public List<Humidifier.Bedrock.PromptTypes.PromptInputVariable> InputVariables { get; set; }
            /// <summary>
            /// TextS3Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-textprompttemplateconfiguration.html#cfn-bedrock-prompt-textprompttemplateconfiguration-texts3location
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TextS3Location
            /// </summary>
            public Humidifier.Bedrock.PromptTypes.TextS3Location TextS3Location { get; set; }
            /// <summary>
            /// CachePoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-textprompttemplateconfiguration.html#cfn-bedrock-prompt-textprompttemplateconfiguration-cachepoint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CachePointBlock
            /// </summary>
            public Humidifier.Bedrock.PromptTypes.CachePointBlock CachePoint { get; set; }
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-textprompttemplateconfiguration.html#cfn-bedrock-prompt-textprompttemplateconfiguration-text
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Text { get; set; }
        }

        public class TextS3Location : Humidifier.Base.BaseSubResource, IHaveKey, IHaveVersion, IHaveBucket
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-texts3location.html#cfn-bedrock-prompt-texts3location-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Bucket { get; set; }
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-texts3location.html#cfn-bedrock-prompt-texts3location-version
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Version { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-texts3location.html#cfn-bedrock-prompt-texts3location-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class Tool : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CachePoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-tool.html#cfn-bedrock-prompt-tool-cachepoint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CachePointBlock
            /// </summary>
            public Humidifier.Bedrock.PromptTypes.CachePointBlock CachePoint { get; set; }
            /// <summary>
            /// ToolSpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-tool.html#cfn-bedrock-prompt-tool-toolspec
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ToolSpecification
            /// </summary>
            public Humidifier.Bedrock.PromptTypes.ToolSpecification ToolSpec { get; set; }
        }

        public class ToolChoice : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Auto
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-toolchoice.html#cfn-bedrock-prompt-toolchoice-auto
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Auto { get; set; }
            /// <summary>
            /// Any
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-toolchoice.html#cfn-bedrock-prompt-toolchoice-any
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Any { get; set; }
            /// <summary>
            /// Tool
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-toolchoice.html#cfn-bedrock-prompt-toolchoice-tool
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SpecificToolChoice
            /// </summary>
            public Humidifier.Bedrock.PromptTypes.SpecificToolChoice Tool { get; set; }
        }

        public class ToolConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ToolChoice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-toolconfiguration.html#cfn-bedrock-prompt-toolconfiguration-toolchoice
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ToolChoice
            /// </summary>
            public Humidifier.Bedrock.PromptTypes.ToolChoice ToolChoice { get; set; }
            /// <summary>
            /// Tools
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-toolconfiguration.html#cfn-bedrock-prompt-toolconfiguration-tools
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tool
            /// </summary>
            public List<Humidifier.Bedrock.PromptTypes.Tool> Tools { get; set; }
        }

        public class ToolInputSchema : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Json
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-toolinputschema.html#cfn-bedrock-prompt-toolinputschema-json
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Json { get; set; }
        }

        public class ToolSpecification : Humidifier.Base.BaseSubResource, IHaveName, IHaveDescription
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-toolspecification.html#cfn-bedrock-prompt-toolspecification-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// InputSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-toolspecification.html#cfn-bedrock-prompt-toolspecification-inputschema
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ToolInputSchema
            /// </summary>
            public Humidifier.Bedrock.PromptTypes.ToolInputSchema InputSchema { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-toolspecification.html#cfn-bedrock-prompt-toolspecification-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }
    }
}