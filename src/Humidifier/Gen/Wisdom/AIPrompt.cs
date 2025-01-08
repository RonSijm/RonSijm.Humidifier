namespace Humidifier.Wisdom
{
    using System.Collections.Generic;
    using AIPromptTypes;

    public class AIPrompt : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveDescription, IHaveType, IHaveModelId, IHaveTemplateType, IHaveAssistantId
    {
        public class Attributes
        {
            public static string AssistantArn =  "AssistantArn" ;
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
        public dynamic Type { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-aiprompt.html#cfn-wisdom-aiprompt-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// ApiFormat
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-aiprompt.html#cfn-wisdom-aiprompt-apiformat
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ApiFormat { get; set; }
        /// <summary>
        /// AssistantId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-aiprompt.html#cfn-wisdom-aiprompt-assistantid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AssistantId { get; set; }

        /// <summary>
        /// TemplateConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-aiprompt.html#cfn-wisdom-aiprompt-templateconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: AIPromptTemplateConfiguration
        /// </summary>
        [Required]
        public Humidifier.Wisdom.AIPromptTypes.AIPromptTemplateConfiguration TemplateConfiguration { get; set; }

        /// <summary>
        /// TemplateType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-aiprompt.html#cfn-wisdom-aiprompt-templatetype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic TemplateType { get; set; }

        /// <summary>
        /// ModelId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-aiprompt.html#cfn-wisdom-aiprompt-modelid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ModelId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-aiprompt.html#cfn-wisdom-aiprompt-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace AIPromptTypes
    {
        public class AIPromptTemplateConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TextFullAIPromptEditTemplateConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiprompt-aiprompttemplateconfiguration.html#cfn-wisdom-aiprompt-aiprompttemplateconfiguration-textfullaipromptedittemplateconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TextFullAIPromptEditTemplateConfiguration
            /// </summary>
            public Humidifier.Wisdom.AIPromptTypes.TextFullAIPromptEditTemplateConfiguration TextFullAIPromptEditTemplateConfiguration { get; set; }
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
            public dynamic Text { get; set; }
        }
    }
}