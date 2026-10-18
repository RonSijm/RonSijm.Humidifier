namespace Humidifier.BedrockAgentCore
{
    using global::System.Collections.Generic;
    using EvaluatorTypes;

    public class Evaluator : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveKmsKeyArn, IHaveLevel, IHaveEvaluatorName, IHaveBedrockAgentCoreEvaluatorTypesEvaluatorConfigEvaluatorConfig
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
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// KmsKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-evaluator.html#cfn-bedrockagentcore-evaluator-kmskeyarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyArn { get; set; }

        /// <summary>
        /// Level
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-evaluator.html#cfn-bedrockagentcore-evaluator-level
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Level { get; set; }
        public Union<string, BaseFunction>? EvaluatorName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-evaluator.html#cfn-bedrockagentcore-evaluator-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// EvaluatorConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-evaluator.html#cfn-bedrockagentcore-evaluator-evaluatorconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: EvaluatorConfig
        /// </summary>
        [Required]
        public Union<Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorConfig, BaseFunction>? EvaluatorConfig { get; set; }
    }

    namespace EvaluatorTypes
    {
        public class BedrockEvaluatorModelConfig : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreEvaluatorTypesInferenceConfigurationInferenceConfig, IHaveAdditionalModelRequestFields_Json, IHaveModelId
        {
            /// <summary>
            /// InferenceConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-bedrockevaluatormodelconfig.html#cfn-bedrockagentcore-evaluator-bedrockevaluatormodelconfig-inferenceconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InferenceConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.EvaluatorTypes.InferenceConfiguration, BaseFunction>? InferenceConfig { get; set; }
            /// <summary>
            /// AdditionalModelRequestFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-bedrockevaluatormodelconfig.html#cfn-bedrockagentcore-evaluator-bedrockevaluatormodelconfig-additionalmodelrequestfields
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? AdditionalModelRequestFields { get; set; }
            /// <summary>
            /// ModelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-bedrockevaluatormodelconfig.html#cfn-bedrockagentcore-evaluator-bedrockevaluatormodelconfig-modelid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelId { get; set; }
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
            public Union<string, BaseFunction>? Label { get; set; }
            /// <summary>
            /// Definition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-categoricalscaledefinition.html#cfn-bedrockagentcore-evaluator-categoricalscaledefinition-definition
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Definition { get; set; }
        }

        public class CodeBasedEvaluatorConfig : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreEvaluatorTypesLambdaEvaluatorConfigLambdaConfig
        {
            /// <summary>
            /// LambdaConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-codebasedevaluatorconfig.html#cfn-bedrockagentcore-evaluator-codebasedevaluatorconfig-lambdaconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: LambdaEvaluatorConfig
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.EvaluatorTypes.LambdaEvaluatorConfig, BaseFunction>? LambdaConfig { get; set; }
        }

        public class DerivedEvaluatorConfig : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreEvaluatorTypesEvaluatorModelConfigModelConfig, IHaveBaseEvaluatorId
        {
            /// <summary>
            /// ModelConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-derivedevaluatorconfig.html#cfn-bedrockagentcore-evaluator-derivedevaluatorconfig-modelconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: EvaluatorModelConfig
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorModelConfig, BaseFunction>? ModelConfig { get; set; }
            /// <summary>
            /// BaseEvaluatorId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-derivedevaluatorconfig.html#cfn-bedrockagentcore-evaluator-derivedevaluatorconfig-baseevaluatorid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BaseEvaluatorId { get; set; }
        }

        public class EvaluatorConfig : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreEvaluatorTypesCodeBasedEvaluatorConfigCodeBased, IHaveBedrockAgentCoreEvaluatorTypesLlmAsAJudgeEvaluatorConfigLlmAsAJudge, IHaveBedrockAgentCoreEvaluatorTypesDerivedEvaluatorConfigDerived
        {
            /// <summary>
            /// CodeBased
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-evaluatorconfig.html#cfn-bedrockagentcore-evaluator-evaluatorconfig-codebased
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CodeBasedEvaluatorConfig
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.EvaluatorTypes.CodeBasedEvaluatorConfig, BaseFunction>? CodeBased { get; set; }
            /// <summary>
            /// LlmAsAJudge
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-evaluatorconfig.html#cfn-bedrockagentcore-evaluator-evaluatorconfig-llmasajudge
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LlmAsAJudgeEvaluatorConfig
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.EvaluatorTypes.LlmAsAJudgeEvaluatorConfig, BaseFunction>? LlmAsAJudge { get; set; }
            /// <summary>
            /// Derived
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-evaluatorconfig.html#cfn-bedrockagentcore-evaluator-evaluatorconfig-derived
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DerivedEvaluatorConfig
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.EvaluatorTypes.DerivedEvaluatorConfig, BaseFunction>? Derived { get; set; }
        }

        public class EvaluatorModelConfig : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreEvaluatorTypesBedrockEvaluatorModelConfigBedrockEvaluatorModelConfig, IHaveBedrockAgentCoreEvaluatorTypesOpenResponsesEvaluatorModelConfigResponsesEvaluatorModelConfig
        {
            /// <summary>
            /// BedrockEvaluatorModelConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-evaluatormodelconfig.html#cfn-bedrockagentcore-evaluator-evaluatormodelconfig-bedrockevaluatormodelconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BedrockEvaluatorModelConfig
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.EvaluatorTypes.BedrockEvaluatorModelConfig, BaseFunction>? BedrockEvaluatorModelConfig { get; set; }
            /// <summary>
            /// ResponsesEvaluatorModelConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-evaluatormodelconfig.html#cfn-bedrockagentcore-evaluator-evaluatormodelconfig-responsesevaluatormodelconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OpenResponsesEvaluatorModelConfig
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.EvaluatorTypes.OpenResponsesEvaluatorModelConfig, BaseFunction>? ResponsesEvaluatorModelConfig { get; set; }
        }

        public class InferenceConfiguration : Humidifier.Base.BaseSubResource, IHaveTemperature_Double, IHaveMaxTokens_Integer, IHaveTopP_Double
        {
            /// <summary>
            /// Temperature
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-inferenceconfiguration.html#cfn-bedrockagentcore-evaluator-inferenceconfiguration-temperature
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Temperature { get; set; }
            /// <summary>
            /// MaxTokens
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-inferenceconfiguration.html#cfn-bedrockagentcore-evaluator-inferenceconfiguration-maxtokens
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxTokens { get; set; }
            /// <summary>
            /// TopP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-inferenceconfiguration.html#cfn-bedrockagentcore-evaluator-inferenceconfiguration-topp
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TopP { get; set; }
        }

        public class LambdaEvaluatorConfig : Humidifier.Base.BaseSubResource, IHaveLambdaArn, IHaveLambdaTimeoutInSeconds_Integer
        {
            /// <summary>
            /// LambdaArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-lambdaevaluatorconfig.html#cfn-bedrockagentcore-evaluator-lambdaevaluatorconfig-lambdaarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LambdaArn { get; set; }
            /// <summary>
            /// LambdaTimeoutInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-lambdaevaluatorconfig.html#cfn-bedrockagentcore-evaluator-lambdaevaluatorconfig-lambdatimeoutinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? LambdaTimeoutInSeconds { get; set; }
        }

        public class LlmAsAJudgeEvaluatorConfig : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreEvaluatorTypesEvaluatorModelConfigModelConfig, IHaveInstructions, IHaveBedrockAgentCoreEvaluatorTypesRatingScaleRatingScale
        {
            /// <summary>
            /// ModelConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-llmasajudgeevaluatorconfig.html#cfn-bedrockagentcore-evaluator-llmasajudgeevaluatorconfig-modelconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: EvaluatorModelConfig
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.EvaluatorTypes.EvaluatorModelConfig, BaseFunction>? ModelConfig { get; set; }
            /// <summary>
            /// Instructions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-llmasajudgeevaluatorconfig.html#cfn-bedrockagentcore-evaluator-llmasajudgeevaluatorconfig-instructions
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Instructions { get; set; }
            /// <summary>
            /// RatingScale
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-llmasajudgeevaluatorconfig.html#cfn-bedrockagentcore-evaluator-llmasajudgeevaluatorconfig-ratingscale
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RatingScale
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.EvaluatorTypes.RatingScale, BaseFunction>? RatingScale { get; set; }
        }

        public class NumericalScaleDefinition : Humidifier.Base.BaseSubResource, IHaveValue_Double, IHaveLabel, IHaveDefinition
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-numericalscaledefinition.html#cfn-bedrockagentcore-evaluator-numericalscaledefinition-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Label
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-numericalscaledefinition.html#cfn-bedrockagentcore-evaluator-numericalscaledefinition-label
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Label { get; set; }
            /// <summary>
            /// Definition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-numericalscaledefinition.html#cfn-bedrockagentcore-evaluator-numericalscaledefinition-definition
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Definition { get; set; }
        }

        public class OpenResponsesEvaluatorModelConfig : Humidifier.Base.BaseSubResource, IHaveTemperature_Double, IHaveBedrockAgentCoreEvaluatorTypesReasoningConfigurationReasoning, IHaveMaxOutputTokens_Integer, IHaveTopP_Double, IHaveModelId
        {
            /// <summary>
            /// Temperature
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-openresponsesevaluatormodelconfig.html#cfn-bedrockagentcore-evaluator-openresponsesevaluatormodelconfig-temperature
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Temperature { get; set; }
            /// <summary>
            /// Reasoning
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-openresponsesevaluatormodelconfig.html#cfn-bedrockagentcore-evaluator-openresponsesevaluatormodelconfig-reasoning
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReasoningConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.EvaluatorTypes.ReasoningConfiguration, BaseFunction>? Reasoning { get; set; }
            /// <summary>
            /// MaxOutputTokens
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-openresponsesevaluatormodelconfig.html#cfn-bedrockagentcore-evaluator-openresponsesevaluatormodelconfig-maxoutputtokens
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxOutputTokens { get; set; }
            /// <summary>
            /// TopP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-openresponsesevaluatormodelconfig.html#cfn-bedrockagentcore-evaluator-openresponsesevaluatormodelconfig-topp
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TopP { get; set; }
            /// <summary>
            /// ModelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-openresponsesevaluatormodelconfig.html#cfn-bedrockagentcore-evaluator-openresponsesevaluatormodelconfig-modelid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelId { get; set; }
        }

        public class RatingScale : Humidifier.Base.BaseSubResource, IHaveListOfBedrockAgentCoreEvaluatorTypesNumericalScaleDefinitionNumerical, IHaveListOfBedrockAgentCoreEvaluatorTypesCategoricalScaleDefinitionCategorical
        {
            /// <summary>
            /// Numerical
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-ratingscale.html#cfn-bedrockagentcore-evaluator-ratingscale-numerical
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: NumericalScaleDefinition
            /// </summary>
            public Union<IReadOnlyList<Humidifier.BedrockAgentCore.EvaluatorTypes.NumericalScaleDefinition>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.EvaluatorTypes.NumericalScaleDefinition, BaseFunction>>, BaseFunction>? Numerical { get; set; }
            /// <summary>
            /// Categorical
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-ratingscale.html#cfn-bedrockagentcore-evaluator-ratingscale-categorical
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CategoricalScaleDefinition
            /// </summary>
            public Union<IReadOnlyList<Humidifier.BedrockAgentCore.EvaluatorTypes.CategoricalScaleDefinition>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.EvaluatorTypes.CategoricalScaleDefinition, BaseFunction>>, BaseFunction>? Categorical { get; set; }
        }

        public class ReasoningConfiguration : Humidifier.Base.BaseSubResource, IHaveEffort
        {
            /// <summary>
            /// Effort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-evaluator-reasoningconfiguration.html#cfn-bedrockagentcore-evaluator-reasoningconfiguration-effort
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Effort { get; set; }
        }
    }
}