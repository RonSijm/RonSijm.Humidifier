namespace Humidifier.Bedrock
{
    using System.Collections.Generic;
    using PromptTypes;

    public class Prompt : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription
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
        public List<PromptTypes.PromptVariant> Variants { get; set; }
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
        public class PromptInferenceConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-promptinferenceconfiguration.html#cfn-bedrock-prompt-promptinferenceconfiguration-text
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PromptModelInferenceConfiguration
            /// </summary>
            public PromptTypes.PromptModelInferenceConfiguration Text { get; set; }
        }

        public class PromptInputVariable : Humidifier.Base.BaseSubResource
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

        public class PromptModelInferenceConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TopK
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-promptmodelinferenceconfiguration.html#cfn-bedrock-prompt-promptmodelinferenceconfiguration-topk
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TopK { get; set; }
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
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-prompttemplateconfiguration.html#cfn-bedrock-prompt-prompttemplateconfiguration-text
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TextPromptTemplateConfiguration
            /// </summary>
            public PromptTypes.TextPromptTemplateConfiguration Text { get; set; }
        }

        public class PromptVariant : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// InferenceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-promptvariant.html#cfn-bedrock-prompt-promptvariant-inferenceconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PromptInferenceConfiguration
            /// </summary>
            public PromptTypes.PromptInferenceConfiguration InferenceConfiguration { get; set; }
            /// <summary>
            /// TemplateConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-promptvariant.html#cfn-bedrock-prompt-promptvariant-templateconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PromptTemplateConfiguration
            /// </summary>
            public PromptTypes.PromptTemplateConfiguration TemplateConfiguration { get; set; }
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

        public class TextPromptTemplateConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// InputVariables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-textprompttemplateconfiguration.html#cfn-bedrock-prompt-textprompttemplateconfiguration-inputvariables
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PromptInputVariable
            /// </summary>
            public List<PromptTypes.PromptInputVariable> InputVariables { get; set; }
            /// <summary>
            /// TextS3Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-textprompttemplateconfiguration.html#cfn-bedrock-prompt-textprompttemplateconfiguration-texts3location
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TextS3Location
            /// </summary>
            public PromptTypes.TextS3Location TextS3Location { get; set; }
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-prompt-textprompttemplateconfiguration.html#cfn-bedrock-prompt-textprompttemplateconfiguration-text
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Text { get; set; }
        }

        public class TextS3Location : Humidifier.Base.BaseSubResource
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
    }
}