namespace Humidifier.Wisdom
{
    using global::System.Collections.Generic;
    using AIPromptTypes;

    public class AIPrompt : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveType, IHaveDescription, IHaveApiFormat, IHaveAssistantId, IHaveWisdomAIPromptTypesAIPromptInferenceConfigurationInferenceConfiguration, IHaveWisdomAIPromptTypesAIPromptTemplateConfigurationTemplateConfiguration, IHaveTemplateType, IHaveModelId, IHaveStringDictionaryOfTags, IHaveName
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
        /// InferenceConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-aiprompt.html#cfn-wisdom-aiprompt-inferenceconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AIPromptInferenceConfiguration
        /// </summary>
        public Union<Humidifier.Wisdom.AIPromptTypes.AIPromptInferenceConfiguration, BaseFunction>? InferenceConfiguration { get; set; }

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
        public class AIPromptInferenceConfiguration : Humidifier.Base.BaseSubResource, IHaveTopK_Integer, IHaveTemperature_Double, IHaveMaxTokensToSample_Integer, IHaveTopP_Double
        {
            /// <summary>
            /// TopK
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiprompt-aipromptinferenceconfiguration.html#cfn-wisdom-aiprompt-aipromptinferenceconfiguration-topk
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TopK { get; set; }
            /// <summary>
            /// Temperature
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiprompt-aipromptinferenceconfiguration.html#cfn-wisdom-aiprompt-aipromptinferenceconfiguration-temperature
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Temperature { get; set; }
            /// <summary>
            /// MaxTokensToSample
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiprompt-aipromptinferenceconfiguration.html#cfn-wisdom-aiprompt-aipromptinferenceconfiguration-maxtokenstosample
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxTokensToSample { get; set; }
            /// <summary>
            /// TopP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiprompt-aipromptinferenceconfiguration.html#cfn-wisdom-aiprompt-aipromptinferenceconfiguration-topp
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TopP { get; set; }
        }

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