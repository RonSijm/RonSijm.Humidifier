namespace Humidifier.Wisdom
{
    using System.Collections.Generic;
    using AIAgentTypes;

    public class AIAgent : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveDescription, IHaveType
    {
        public class Attributes
        {
            public static string AIAgentArn =  "AIAgentArn" ;
            public static string AssistantArn =  "AssistantArn" ;
            public static string AIAgentId =  "AIAgentId" ;
        }

        public override string AWSTypeName { get => AWS.Wisdom.AIAgent; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-aiagent.html#cfn-wisdom-aiagent-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Type { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-aiagent.html#cfn-wisdom-aiagent-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-aiagent.html#cfn-wisdom-aiagent-configuration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: AIAgentConfiguration
        /// </summary>
        [Required]
        public Humidifier.Wisdom.AIAgentTypes.AIAgentConfiguration Configuration { get; set; }

        /// <summary>
        /// AssistantId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-aiagent.html#cfn-wisdom-aiagent-assistantid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AssistantId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-aiagent.html#cfn-wisdom-aiagent-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace AIAgentTypes
    {
        public class AIAgentConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ManualSearchAIAgentConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-aiagentconfiguration.html#cfn-wisdom-aiagent-aiagentconfiguration-manualsearchaiagentconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ManualSearchAIAgentConfiguration
            /// </summary>
            public Humidifier.Wisdom.AIAgentTypes.ManualSearchAIAgentConfiguration ManualSearchAIAgentConfiguration { get; set; }
            /// <summary>
            /// SelfServiceAIAgentConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-aiagentconfiguration.html#cfn-wisdom-aiagent-aiagentconfiguration-selfserviceaiagentconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SelfServiceAIAgentConfiguration
            /// </summary>
            public Humidifier.Wisdom.AIAgentTypes.SelfServiceAIAgentConfiguration SelfServiceAIAgentConfiguration { get; set; }
            /// <summary>
            /// AnswerRecommendationAIAgentConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-aiagentconfiguration.html#cfn-wisdom-aiagent-aiagentconfiguration-answerrecommendationaiagentconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnswerRecommendationAIAgentConfiguration
            /// </summary>
            public Humidifier.Wisdom.AIAgentTypes.AnswerRecommendationAIAgentConfiguration AnswerRecommendationAIAgentConfiguration { get; set; }
        }

        public class AnswerRecommendationAIAgentConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AnswerGenerationAIPromptId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-answerrecommendationaiagentconfiguration.html#cfn-wisdom-aiagent-answerrecommendationaiagentconfiguration-answergenerationaipromptid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AnswerGenerationAIPromptId { get; set; }
            /// <summary>
            /// IntentLabelingGenerationAIPromptId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-answerrecommendationaiagentconfiguration.html#cfn-wisdom-aiagent-answerrecommendationaiagentconfiguration-intentlabelinggenerationaipromptid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IntentLabelingGenerationAIPromptId { get; set; }
            /// <summary>
            /// QueryReformulationAIPromptId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-answerrecommendationaiagentconfiguration.html#cfn-wisdom-aiagent-answerrecommendationaiagentconfiguration-queryreformulationaipromptid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic QueryReformulationAIPromptId { get; set; }
            /// <summary>
            /// AnswerGenerationAIGuardrailId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-answerrecommendationaiagentconfiguration.html#cfn-wisdom-aiagent-answerrecommendationaiagentconfiguration-answergenerationaiguardrailid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AnswerGenerationAIGuardrailId { get; set; }
            /// <summary>
            /// AssociationConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-answerrecommendationaiagentconfiguration.html#cfn-wisdom-aiagent-answerrecommendationaiagentconfiguration-associationconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AssociationConfiguration
            /// </summary>
            public List<Humidifier.Wisdom.AIAgentTypes.AssociationConfiguration> AssociationConfigurations { get; set; }
        }

        public class AssociationConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AssociationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-associationconfiguration.html#cfn-wisdom-aiagent-associationconfiguration-associationtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AssociationType { get; set; }
            /// <summary>
            /// AssociationConfigurationData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-associationconfiguration.html#cfn-wisdom-aiagent-associationconfiguration-associationconfigurationdata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AssociationConfigurationData
            /// </summary>
            public Humidifier.Wisdom.AIAgentTypes.AssociationConfigurationData AssociationConfigurationData { get; set; }
            /// <summary>
            /// AssociationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-associationconfiguration.html#cfn-wisdom-aiagent-associationconfiguration-associationid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AssociationId { get; set; }
        }

        public class AssociationConfigurationData : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// KnowledgeBaseAssociationConfigurationData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-associationconfigurationdata.html#cfn-wisdom-aiagent-associationconfigurationdata-knowledgebaseassociationconfigurationdata
            /// Required: True
            /// UpdateType: Mutable
            /// Type: KnowledgeBaseAssociationConfigurationData
            /// </summary>
            public Humidifier.Wisdom.AIAgentTypes.KnowledgeBaseAssociationConfigurationData KnowledgeBaseAssociationConfigurationData { get; set; }
        }

        public class KnowledgeBaseAssociationConfigurationData : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MaxResults
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-knowledgebaseassociationconfigurationdata.html#cfn-wisdom-aiagent-knowledgebaseassociationconfigurationdata-maxresults
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MaxResults { get; set; }
            /// <summary>
            /// ContentTagFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-knowledgebaseassociationconfigurationdata.html#cfn-wisdom-aiagent-knowledgebaseassociationconfigurationdata-contenttagfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TagFilter
            /// </summary>
            public Humidifier.Wisdom.AIAgentTypes.TagFilter ContentTagFilter { get; set; }
            /// <summary>
            /// OverrideKnowledgeBaseSearchType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-knowledgebaseassociationconfigurationdata.html#cfn-wisdom-aiagent-knowledgebaseassociationconfigurationdata-overrideknowledgebasesearchtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OverrideKnowledgeBaseSearchType { get; set; }
        }

        public class ManualSearchAIAgentConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AnswerGenerationAIPromptId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-manualsearchaiagentconfiguration.html#cfn-wisdom-aiagent-manualsearchaiagentconfiguration-answergenerationaipromptid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AnswerGenerationAIPromptId { get; set; }
            /// <summary>
            /// AnswerGenerationAIGuardrailId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-manualsearchaiagentconfiguration.html#cfn-wisdom-aiagent-manualsearchaiagentconfiguration-answergenerationaiguardrailid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AnswerGenerationAIGuardrailId { get; set; }
            /// <summary>
            /// AssociationConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-manualsearchaiagentconfiguration.html#cfn-wisdom-aiagent-manualsearchaiagentconfiguration-associationconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AssociationConfiguration
            /// </summary>
            public List<Humidifier.Wisdom.AIAgentTypes.AssociationConfiguration> AssociationConfigurations { get; set; }
        }

        public class OrCondition : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AndConditions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-orcondition.html#cfn-wisdom-aiagent-orcondition-andconditions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TagCondition
            /// </summary>
            public List<Humidifier.Wisdom.AIAgentTypes.TagCondition> AndConditions { get; set; }
            /// <summary>
            /// TagCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-orcondition.html#cfn-wisdom-aiagent-orcondition-tagcondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TagCondition
            /// </summary>
            public Humidifier.Wisdom.AIAgentTypes.TagCondition TagCondition { get; set; }
        }

        public class SelfServiceAIAgentConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SelfServiceAIGuardrailId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-selfserviceaiagentconfiguration.html#cfn-wisdom-aiagent-selfserviceaiagentconfiguration-selfserviceaiguardrailid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SelfServiceAIGuardrailId { get; set; }
            /// <summary>
            /// SelfServicePreProcessingAIPromptId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-selfserviceaiagentconfiguration.html#cfn-wisdom-aiagent-selfserviceaiagentconfiguration-selfservicepreprocessingaipromptid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SelfServicePreProcessingAIPromptId { get; set; }
            /// <summary>
            /// SelfServiceAnswerGenerationAIPromptId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-selfserviceaiagentconfiguration.html#cfn-wisdom-aiagent-selfserviceaiagentconfiguration-selfserviceanswergenerationaipromptid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SelfServiceAnswerGenerationAIPromptId { get; set; }
            /// <summary>
            /// AssociationConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-selfserviceaiagentconfiguration.html#cfn-wisdom-aiagent-selfserviceaiagentconfiguration-associationconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AssociationConfiguration
            /// </summary>
            public List<Humidifier.Wisdom.AIAgentTypes.AssociationConfiguration> AssociationConfigurations { get; set; }
        }

        public class TagCondition : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-tagcondition.html#cfn-wisdom-aiagent-tagcondition-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-tagcondition.html#cfn-wisdom-aiagent-tagcondition-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class TagFilter : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// OrConditions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-tagfilter.html#cfn-wisdom-aiagent-tagfilter-orconditions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: OrCondition
            /// </summary>
            public List<Humidifier.Wisdom.AIAgentTypes.OrCondition> OrConditions { get; set; }
            /// <summary>
            /// AndConditions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-tagfilter.html#cfn-wisdom-aiagent-tagfilter-andconditions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TagCondition
            /// </summary>
            public List<Humidifier.Wisdom.AIAgentTypes.TagCondition> AndConditions { get; set; }
            /// <summary>
            /// TagCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-tagfilter.html#cfn-wisdom-aiagent-tagfilter-tagcondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TagCondition
            /// </summary>
            public Humidifier.Wisdom.AIAgentTypes.TagCondition TagCondition { get; set; }
        }
    }
}