namespace Humidifier.Bedrock
{
    using System.Collections.Generic;
    using PromptVersionTypes;

    public class PromptVersion : Humidifier.Base.BaseResource, IHaveDescription, IHavePromptArn
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
        public dynamic Description { get; set; }

        /// <summary>
        /// PromptArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-promptversion.html#cfn-bedrock-promptversion-promptarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic PromptArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-promptversion.html#cfn-bedrock-promptversion-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Tags { get; set; }
    }

    namespace PromptVersionTypes
    {
        public class ChatPromptTemplateConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Messages
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-chatprompttemplateconfiguration.html#cfn-bedrock-promptversion-chatprompttemplateconfiguration-messages
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Message
            /// </summary>
            public List<Humidifier.Bedrock.PromptVersionTypes.Message> Messages { get; set; }
            /// <summary>
            /// InputVariables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-chatprompttemplateconfiguration.html#cfn-bedrock-promptversion-chatprompttemplateconfiguration-inputvariables
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PromptInputVariable
            /// </summary>
            public List<Humidifier.Bedrock.PromptVersionTypes.PromptInputVariable> InputVariables { get; set; }
            /// <summary>
            /// ToolConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-chatprompttemplateconfiguration.html#cfn-bedrock-promptversion-chatprompttemplateconfiguration-toolconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ToolConfiguration
            /// </summary>
            public Humidifier.Bedrock.PromptVersionTypes.ToolConfiguration ToolConfiguration { get; set; }
            /// <summary>
            /// System
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-chatprompttemplateconfiguration.html#cfn-bedrock-promptversion-chatprompttemplateconfiguration-system
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SystemContentBlock
            /// </summary>
            public List<Humidifier.Bedrock.PromptVersionTypes.SystemContentBlock> System { get; set; }
        }

        public class ContentBlock : Humidifier.Base.BaseSubResource, IHaveText
        {
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-contentblock.html#cfn-bedrock-promptversion-contentblock-text
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Text { get; set; }
        }

        public class Message : Humidifier.Base.BaseSubResource, IHaveRole
        {
            /// <summary>
            /// Role
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-message.html#cfn-bedrock-promptversion-message-role
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Role { get; set; }
            /// <summary>
            /// Content
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-message.html#cfn-bedrock-promptversion-message-content
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ContentBlock
            /// </summary>
            public List<Humidifier.Bedrock.PromptVersionTypes.ContentBlock> Content { get; set; }
        }

        public class PromptAgentResource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AgentIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-promptagentresource.html#cfn-bedrock-promptversion-promptagentresource-agentidentifier
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-promptgenairesource.html#cfn-bedrock-promptversion-promptgenairesource-agent
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PromptAgentResource
            /// </summary>
            public Humidifier.Bedrock.PromptVersionTypes.PromptAgentResource Agent { get; set; }
        }

        public class PromptInferenceConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-promptinferenceconfiguration.html#cfn-bedrock-promptversion-promptinferenceconfiguration-text
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PromptModelInferenceConfiguration
            /// </summary>
            public Humidifier.Bedrock.PromptVersionTypes.PromptModelInferenceConfiguration Text { get; set; }
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
            public dynamic Name { get; set; }
        }

        public class PromptModelInferenceConfiguration : Humidifier.Base.BaseSubResource, IHaveMaxTokens, IHaveTemperature, IHaveStopSequences, IHaveTopP
        {
            /// <summary>
            /// Temperature
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-promptmodelinferenceconfiguration.html#cfn-bedrock-promptversion-promptmodelinferenceconfiguration-temperature
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Temperature { get; set; }
            /// <summary>
            /// StopSequences
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-promptmodelinferenceconfiguration.html#cfn-bedrock-promptversion-promptmodelinferenceconfiguration-stopsequences
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic StopSequences { get; set; }
            /// <summary>
            /// MaxTokens
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-promptmodelinferenceconfiguration.html#cfn-bedrock-promptversion-promptmodelinferenceconfiguration-maxtokens
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MaxTokens { get; set; }
            /// <summary>
            /// TopP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-promptmodelinferenceconfiguration.html#cfn-bedrock-promptversion-promptmodelinferenceconfiguration-topp
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-prompttemplateconfiguration.html#cfn-bedrock-promptversion-prompttemplateconfiguration-chat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChatPromptTemplateConfiguration
            /// </summary>
            public Humidifier.Bedrock.PromptVersionTypes.ChatPromptTemplateConfiguration Chat { get; set; }
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-prompttemplateconfiguration.html#cfn-bedrock-promptversion-prompttemplateconfiguration-text
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TextPromptTemplateConfiguration
            /// </summary>
            public Humidifier.Bedrock.PromptVersionTypes.TextPromptTemplateConfiguration Text { get; set; }
        }

        public class PromptVariant : Humidifier.Base.BaseSubResource, IHaveName, IHaveModelId, IHaveTemplateType
        {
            /// <summary>
            /// InferenceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-promptvariant.html#cfn-bedrock-promptversion-promptvariant-inferenceconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PromptInferenceConfiguration
            /// </summary>
            public Humidifier.Bedrock.PromptVersionTypes.PromptInferenceConfiguration InferenceConfiguration { get; set; }
            /// <summary>
            /// GenAiResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-promptvariant.html#cfn-bedrock-promptversion-promptvariant-genairesource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PromptGenAiResource
            /// </summary>
            public Humidifier.Bedrock.PromptVersionTypes.PromptGenAiResource GenAiResource { get; set; }
            /// <summary>
            /// TemplateConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-promptvariant.html#cfn-bedrock-promptversion-promptvariant-templateconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PromptTemplateConfiguration
            /// </summary>
            public Humidifier.Bedrock.PromptVersionTypes.PromptTemplateConfiguration TemplateConfiguration { get; set; }
            /// <summary>
            /// TemplateType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-promptvariant.html#cfn-bedrock-promptversion-promptvariant-templatetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TemplateType { get; set; }
            /// <summary>
            /// ModelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-promptvariant.html#cfn-bedrock-promptversion-promptvariant-modelid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ModelId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-promptvariant.html#cfn-bedrock-promptversion-promptvariant-name
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-specifictoolchoice.html#cfn-bedrock-promptversion-specifictoolchoice-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class SystemContentBlock : Humidifier.Base.BaseSubResource, IHaveText
        {
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-systemcontentblock.html#cfn-bedrock-promptversion-systemcontentblock-text
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Text { get; set; }
        }

        public class TextPromptTemplateConfiguration : Humidifier.Base.BaseSubResource, IHaveText
        {
            /// <summary>
            /// InputVariables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-textprompttemplateconfiguration.html#cfn-bedrock-promptversion-textprompttemplateconfiguration-inputvariables
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PromptInputVariable
            /// </summary>
            public List<Humidifier.Bedrock.PromptVersionTypes.PromptInputVariable> InputVariables { get; set; }
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-textprompttemplateconfiguration.html#cfn-bedrock-promptversion-textprompttemplateconfiguration-text
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Text { get; set; }
        }

        public class Tool : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ToolSpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-tool.html#cfn-bedrock-promptversion-tool-toolspec
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ToolSpecification
            /// </summary>
            public Humidifier.Bedrock.PromptVersionTypes.ToolSpecification ToolSpec { get; set; }
        }

        public class ToolChoice : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Auto
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-toolchoice.html#cfn-bedrock-promptversion-toolchoice-auto
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Auto { get; set; }
            /// <summary>
            /// Any
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-toolchoice.html#cfn-bedrock-promptversion-toolchoice-any
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Any { get; set; }
            /// <summary>
            /// Tool
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-toolchoice.html#cfn-bedrock-promptversion-toolchoice-tool
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SpecificToolChoice
            /// </summary>
            public Humidifier.Bedrock.PromptVersionTypes.SpecificToolChoice Tool { get; set; }
        }

        public class ToolConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ToolChoice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-toolconfiguration.html#cfn-bedrock-promptversion-toolconfiguration-toolchoice
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ToolChoice
            /// </summary>
            public Humidifier.Bedrock.PromptVersionTypes.ToolChoice ToolChoice { get; set; }
            /// <summary>
            /// Tools
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-toolconfiguration.html#cfn-bedrock-promptversion-toolconfiguration-tools
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tool
            /// </summary>
            public List<Humidifier.Bedrock.PromptVersionTypes.Tool> Tools { get; set; }
        }

        public class ToolInputSchema : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Json
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-toolinputschema.html#cfn-bedrock-promptversion-toolinputschema-json
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-toolspecification.html#cfn-bedrock-promptversion-toolspecification-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// InputSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-toolspecification.html#cfn-bedrock-promptversion-toolspecification-inputschema
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ToolInputSchema
            /// </summary>
            public Humidifier.Bedrock.PromptVersionTypes.ToolInputSchema InputSchema { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-promptversion-toolspecification.html#cfn-bedrock-promptversion-toolspecification-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }
    }
}