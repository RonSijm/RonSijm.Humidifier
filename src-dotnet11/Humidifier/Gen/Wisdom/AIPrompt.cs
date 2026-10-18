namespace Humidifier.Wisdom
{
    using global::System.Collections.Generic;
    using AIPromptTypes;

    public class AIPrompt : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveType, IHaveDescription, IHaveApiFormat, IHaveAssistantId, IHaveWisdomAIPromptTypesAIPromptTemplateConfigurationTemplateConfiguration, IHaveTemplateType, IHaveModelId, IHaveStringDictionaryOfTags, IHaveName
    {
        public class Attributes
        {
            public static string AssistantArn =  "AssistantArn" ;
            public static string ModifiedTimeSeconds =  "ModifiedTimeSeconds" ;
            public static string AIPromptId =  "AIPromptId" ;
            public static string AIPromptArn =  "AIPromptArn" ;
        }

        public override string AWSTypeName { get => AWS.Wisdom.AIPrompt; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-aiprompt.html#cfn-wisdom-aiprompt-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Type { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-aiprompt.html#cfn-wisdom-aiprompt-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// ApiFormat
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-aiprompt.html#cfn-wisdom-aiprompt-apiformat
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ApiFormat { get; set; }
        /// <summary>
        /// AssistantId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-aiprompt.html#cfn-wisdom-aiprompt-assistantid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AssistantId { get; set; }

        /// <summary>
        /// TemplateConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-aiprompt.html#cfn-wisdom-aiprompt-templateconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: AIPromptTemplateConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.Wisdom.AIPromptTypes.AIPromptTemplateConfiguration, BaseFunction>? TemplateConfiguration { get; set; }

        /// <summary>
        /// TemplateType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-aiprompt.html#cfn-wisdom-aiprompt-templatetype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TemplateType { get; set; }

        /// <summary>
        /// ModelId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-aiprompt.html#cfn-wisdom-aiprompt-modelid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ModelId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-aiprompt.html#cfn-wisdom-aiprompt-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace AIPromptTypes
    {
        public class AIPromptTemplateConfiguration : Humidifier.Base.BaseSubResource, IHaveWisdomAIPromptTypesTextFullAIPromptEditTemplateConfigurationTextFullAIPromptEditTemplateConfiguration
        {
            /// <summary>
            /// TextFullAIPromptEditTemplateConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiprompt-aiprompttemplateconfiguration.html#cfn-wisdom-aiprompt-aiprompttemplateconfiguration-textfullaipromptedittemplateconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TextFullAIPromptEditTemplateConfiguration
            /// </summary>
            public Union<Humidifier.Wisdom.AIPromptTypes.TextFullAIPromptEditTemplateConfiguration, BaseFunction>? TextFullAIPromptEditTemplateConfiguration { get; set; }
        }

        public class TextFullAIPromptEditTemplateConfiguration : Humidifier.Base.BaseSubResource, IHaveText
        {
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiprompt-textfullaipromptedittemplateconfiguration.html#cfn-wisdom-aiprompt-textfullaipromptedittemplateconfiguration-text
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Text { get; set; }
        }
    }
}