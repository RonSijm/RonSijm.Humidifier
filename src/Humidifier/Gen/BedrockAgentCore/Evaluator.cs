namespace Humidifier.BedrockAgentCore
{
    using global::System.Collections.Generic;
    using EvaluatorTypes;

    public class Evaluator : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveKmsKeyArn, IHaveLevel
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string EvaluatorType =  "EvaluatorType" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string EvaluatorArn =  "EvaluatorArn" ;
            public static string EvaluatorId =  "EvaluatorId" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string Provider =  "Provider" ;
        }

        public override string AWSTypeName { get => AWS.BedrockAgentCore.Evaluator; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-evaluator.html#cfn-bedrockagentcore-evaluator-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// KmsKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-evaluator.html#cfn-bedrockagentcore-evaluator-kmskeyarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KmsKeyArn { get; set; }

        /// <summary>
        /// Level
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-evaluator.html#cfn-bedrockagentcore-evaluator-level
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Level { get; set; }
        public dynamic EvaluatorName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-evaluator.html#cfn-bedrockagentcore-evaluator-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }

        /// <summary>
        /// EvaluatorConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-evaluator.html#cfn-bedrockagentcore-evaluator-evaluatorconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: EvaluatorConfig
        /// </summary>
        [Required]
        public Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorConfig EvaluatorConfig { get; set; }
    }

    namespace EvaluatorTypes
    {
        public class BedrockEvaluatorModelConfig : Humidifier.Base.BaseSubResource, IHaveModelId
        {
            /// <summary>
            /// InferenceConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-bedrockevaluatormodelconfig.html#cfn-bedrockagentcore-evaluator-bedrockevaluatormodelconfig-inferenceconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InferenceConfiguration
            /// </summary>
            public Humidifier.BedrockAgentCore.EvaluatorTypes.InferenceConfiguration InferenceConfig { get; set; }
            /// <summary>
            /// AdditionalModelRequestFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-bedrockevaluatormodelconfig.html#cfn-bedrockagentcore-evaluator-bedrockevaluatormodelconfig-additionalmodelrequestfields
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic AdditionalModelRequestFields { get; set; }
            /// <summary>
            /// ModelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-bedrockevaluatormodelconfig.html#cfn-bedrockagentcore-evaluator-bedrockevaluatormodelconfig-modelid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ModelId { get; set; }
        }

        public class CategoricalScaleDefinition : Humidifier.Base.BaseSubResource, IHaveLabel, IHaveDefinition
        {
            /// <summary>
            /// Label
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-categoricalscaledefinition.html#cfn-bedrockagentcore-evaluator-categoricalscaledefinition-label
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Label { get; set; }
            /// <summary>
            /// Definition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-categoricalscaledefinition.html#cfn-bedrockagentcore-evaluator-categoricalscaledefinition-definition
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Definition { get; set; }
        }

        public class CodeBasedEvaluatorConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LambdaConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-codebasedevaluatorconfig.html#cfn-bedrockagentcore-evaluator-codebasedevaluatorconfig-lambdaconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: LambdaEvaluatorConfig
            /// </summary>
            public Humidifier.BedrockAgentCore.EvaluatorTypes.LambdaEvaluatorConfig LambdaConfig { get; set; }
        }

        public class DerivedEvaluatorConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ModelConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-derivedevaluatorconfig.html#cfn-bedrockagentcore-evaluator-derivedevaluatorconfig-modelconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: EvaluatorModelConfig
            /// </summary>
            public Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorModelConfig ModelConfig { get; set; }
            /// <summary>
            /// BaseEvaluatorId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-derivedevaluatorconfig.html#cfn-bedrockagentcore-evaluator-derivedevaluatorconfig-baseevaluatorid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BaseEvaluatorId { get; set; }
        }

        public class EvaluatorConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CodeBased
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-evaluatorconfig.html#cfn-bedrockagentcore-evaluator-evaluatorconfig-codebased
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CodeBasedEvaluatorConfig
            /// </summary>
            public Humidifier.BedrockAgentCore.EvaluatorTypes.CodeBasedEvaluatorConfig CodeBased { get; set; }
            /// <summary>
            /// LlmAsAJudge
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-evaluatorconfig.html#cfn-bedrockagentcore-evaluator-evaluatorconfig-llmasajudge
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LlmAsAJudgeEvaluatorConfig
            /// </summary>
            public Humidifier.BedrockAgentCore.EvaluatorTypes.LlmAsAJudgeEvaluatorConfig LlmAsAJudge { get; set; }
            /// <summary>
            /// Derived
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-evaluatorconfig.html#cfn-bedrockagentcore-evaluator-evaluatorconfig-derived
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DerivedEvaluatorConfig
            /// </summary>
            public Humidifier.BedrockAgentCore.EvaluatorTypes.DerivedEvaluatorConfig Derived { get; set; }
        }

        public class EvaluatorModelConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// BedrockEvaluatorModelConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-evaluatormodelconfig.html#cfn-bedrockagentcore-evaluator-evaluatormodelconfig-bedrockevaluatormodelconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BedrockEvaluatorModelConfig
            /// </summary>
            public Humidifier.BedrockAgentCore.EvaluatorTypes.BedrockEvaluatorModelConfig BedrockEvaluatorModelConfig { get; set; }
            /// <summary>
            /// ResponsesEvaluatorModelConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-evaluatormodelconfig.html#cfn-bedrockagentcore-evaluator-evaluatormodelconfig-responsesevaluatormodelconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OpenResponsesEvaluatorModelConfig
            /// </summary>
            public Humidifier.BedrockAgentCore.EvaluatorTypes.OpenResponsesEvaluatorModelConfig ResponsesEvaluatorModelConfig { get; set; }
        }

        public class InferenceConfiguration : Humidifier.Base.BaseSubResource, IHaveMaxTokens, IHaveTemperature, IHaveStopSequences, IHaveTopP
        {
            /// <summary>
            /// Temperature
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-inferenceconfiguration.html#cfn-bedrockagentcore-evaluator-inferenceconfiguration-temperature
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Temperature { get; set; }
            /// <summary>
            /// StopSequences
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-inferenceconfiguration.html#cfn-bedrockagentcore-evaluator-inferenceconfiguration-stopsequences
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic StopSequences { get; set; }
            /// <summary>
            /// MaxTokens
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-inferenceconfiguration.html#cfn-bedrockagentcore-evaluator-inferenceconfiguration-maxtokens
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxTokens { get; set; }
            /// <summary>
            /// TopP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-inferenceconfiguration.html#cfn-bedrockagentcore-evaluator-inferenceconfiguration-topp
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TopP { get; set; }
        }

        public class LambdaEvaluatorConfig : Humidifier.Base.BaseSubResource, IHaveLambdaArn
        {
            /// <summary>
            /// LambdaArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-lambdaevaluatorconfig.html#cfn-bedrockagentcore-evaluator-lambdaevaluatorconfig-lambdaarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LambdaArn { get; set; }
            /// <summary>
            /// LambdaTimeoutInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-lambdaevaluatorconfig.html#cfn-bedrockagentcore-evaluator-lambdaevaluatorconfig-lambdatimeoutinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic LambdaTimeoutInSeconds { get; set; }
        }

        public class LlmAsAJudgeEvaluatorConfig : Humidifier.Base.BaseSubResource, IHaveInstructions
        {
            /// <summary>
            /// ModelConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-llmasajudgeevaluatorconfig.html#cfn-bedrockagentcore-evaluator-llmasajudgeevaluatorconfig-modelconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: EvaluatorModelConfig
            /// </summary>
            public Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorModelConfig ModelConfig { get; set; }
            /// <summary>
            /// Instructions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-llmasajudgeevaluatorconfig.html#cfn-bedrockagentcore-evaluator-llmasajudgeevaluatorconfig-instructions
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Instructions { get; set; }
            /// <summary>
            /// RatingScale
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-llmasajudgeevaluatorconfig.html#cfn-bedrockagentcore-evaluator-llmasajudgeevaluatorconfig-ratingscale
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RatingScale
            /// </summary>
            public Humidifier.BedrockAgentCore.EvaluatorTypes.RatingScale RatingScale { get; set; }
        }

        public class NumericalScaleDefinition : Humidifier.Base.BaseSubResource, IHaveValue, IHaveLabel, IHaveDefinition
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-numericalscaledefinition.html#cfn-bedrockagentcore-evaluator-numericalscaledefinition-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Label
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-numericalscaledefinition.html#cfn-bedrockagentcore-evaluator-numericalscaledefinition-label
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Label { get; set; }
            /// <summary>
            /// Definition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-numericalscaledefinition.html#cfn-bedrockagentcore-evaluator-numericalscaledefinition-definition
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Definition { get; set; }
        }

        public class OpenResponsesEvaluatorModelConfig : Humidifier.Base.BaseSubResource, IHaveModelId, IHaveTemperature, IHaveTopP
        {
            /// <summary>
            /// Temperature
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-openresponsesevaluatormodelconfig.html#cfn-bedrockagentcore-evaluator-openresponsesevaluatormodelconfig-temperature
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Temperature { get; set; }
            /// <summary>
            /// Reasoning
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-openresponsesevaluatormodelconfig.html#cfn-bedrockagentcore-evaluator-openresponsesevaluatormodelconfig-reasoning
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReasoningConfiguration
            /// </summary>
            public Humidifier.BedrockAgentCore.EvaluatorTypes.ReasoningConfiguration Reasoning { get; set; }
            /// <summary>
            /// MaxOutputTokens
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-openresponsesevaluatormodelconfig.html#cfn-bedrockagentcore-evaluator-openresponsesevaluatormodelconfig-maxoutputtokens
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxOutputTokens { get; set; }
            /// <summary>
            /// TopP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-openresponsesevaluatormodelconfig.html#cfn-bedrockagentcore-evaluator-openresponsesevaluatormodelconfig-topp
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TopP { get; set; }
            /// <summary>
            /// ModelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-openresponsesevaluatormodelconfig.html#cfn-bedrockagentcore-evaluator-openresponsesevaluatormodelconfig-modelid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ModelId { get; set; }
        }

        public class RatingScale : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Numerical
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-ratingscale.html#cfn-bedrockagentcore-evaluator-ratingscale-numerical
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: NumericalScaleDefinition
            /// </summary>
            public List<Humidifier.BedrockAgentCore.EvaluatorTypes.NumericalScaleDefinition> Numerical { get; set; }
            /// <summary>
            /// Categorical
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-ratingscale.html#cfn-bedrockagentcore-evaluator-ratingscale-categorical
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CategoricalScaleDefinition
            /// </summary>
            public List<Humidifier.BedrockAgentCore.EvaluatorTypes.CategoricalScaleDefinition> Categorical { get; set; }
        }

        public class ReasoningConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Effort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-reasoningconfiguration.html#cfn-bedrockagentcore-evaluator-reasoningconfiguration-effort
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Effort { get; set; }
        }
    }
}