namespace Humidifier.Wisdom
{
    using global::System.Collections.Generic;
    using AIAgentTypes;

    public class AIAgent : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveDescription, IHaveType, IHaveAssistantId
    {
        public class Attributes
        {
            public static string AIAgentArn =  "AIAgentArn" ;
            public static string AssistantArn =  "AssistantArn" ;
            public static string AIAgentId =  "AIAgentId" ;
            public static string ModifiedTimeSeconds =  "ModifiedTimeSeconds" ;
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
            /// CaseSummarizationAIAgentConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-aiagentconfiguration.html#cfn-wisdom-aiagent-aiagentconfiguration-casesummarizationaiagentconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CaseSummarizationAIAgentConfiguration
            /// </summary>
            public Humidifier.Wisdom.AIAgentTypes.CaseSummarizationAIAgentConfiguration CaseSummarizationAIAgentConfiguration { get; set; }
            /// <summary>
            /// ManualSearchAIAgentConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-aiagentconfiguration.html#cfn-wisdom-aiagent-aiagentconfiguration-manualsearchaiagentconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ManualSearchAIAgentConfiguration
            /// </summary>
            public Humidifier.Wisdom.AIAgentTypes.ManualSearchAIAgentConfiguration ManualSearchAIAgentConfiguration { get; set; }
            /// <summary>
            /// EmailOverviewAIAgentConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-aiagentconfiguration.html#cfn-wisdom-aiagent-aiagentconfiguration-emailoverviewaiagentconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EmailOverviewAIAgentConfiguration
            /// </summary>
            public Humidifier.Wisdom.AIAgentTypes.EmailOverviewAIAgentConfiguration EmailOverviewAIAgentConfiguration { get; set; }
            /// <summary>
            /// OrchestrationAIAgentConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-aiagentconfiguration.html#cfn-wisdom-aiagent-aiagentconfiguration-orchestrationaiagentconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OrchestrationAIAgentConfiguration
            /// </summary>
            public Humidifier.Wisdom.AIAgentTypes.OrchestrationAIAgentConfiguration OrchestrationAIAgentConfiguration { get; set; }
            /// <summary>
            /// SelfServiceAIAgentConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-aiagentconfiguration.html#cfn-wisdom-aiagent-aiagentconfiguration-selfserviceaiagentconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SelfServiceAIAgentConfiguration
            /// </summary>
            public Humidifier.Wisdom.AIAgentTypes.SelfServiceAIAgentConfiguration SelfServiceAIAgentConfiguration { get; set; }
            /// <summary>
            /// EmailResponseAIAgentConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-aiagentconfiguration.html#cfn-wisdom-aiagent-aiagentconfiguration-emailresponseaiagentconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EmailResponseAIAgentConfiguration
            /// </summary>
            public Humidifier.Wisdom.AIAgentTypes.EmailResponseAIAgentConfiguration EmailResponseAIAgentConfiguration { get; set; }
            /// <summary>
            /// NoteTakingAIAgentConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-aiagentconfiguration.html#cfn-wisdom-aiagent-aiagentconfiguration-notetakingaiagentconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NoteTakingAIAgentConfiguration
            /// </summary>
            public Humidifier.Wisdom.AIAgentTypes.NoteTakingAIAgentConfiguration NoteTakingAIAgentConfiguration { get; set; }
            /// <summary>
            /// AnswerRecommendationAIAgentConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-aiagentconfiguration.html#cfn-wisdom-aiagent-aiagentconfiguration-answerrecommendationaiagentconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnswerRecommendationAIAgentConfiguration
            /// </summary>
            public Humidifier.Wisdom.AIAgentTypes.AnswerRecommendationAIAgentConfiguration AnswerRecommendationAIAgentConfiguration { get; set; }
            /// <summary>
            /// EmailGenerativeAnswerAIAgentConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-aiagentconfiguration.html#cfn-wisdom-aiagent-aiagentconfiguration-emailgenerativeansweraiagentconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EmailGenerativeAnswerAIAgentConfiguration
            /// </summary>
            public Humidifier.Wisdom.AIAgentTypes.EmailGenerativeAnswerAIAgentConfiguration EmailGenerativeAnswerAIAgentConfiguration { get; set; }
        }

        public class AnswerRecommendationAIAgentConfiguration : Humidifier.Base.BaseSubResource, IHaveLocale, IHaveAnswerGenerationAIPromptId, IHaveAnswerGenerationAIGuardrailId
        {
            /// <summary>
            /// Locale
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-answerrecommendationaiagentconfiguration.html#cfn-wisdom-aiagent-answerrecommendationaiagentconfiguration-locale
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Locale { get; set; }
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

        public class AssociationConfiguration : Humidifier.Base.BaseSubResource, IHaveAssociationType
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

        public class CaseSummarizationAIAgentConfiguration : Humidifier.Base.BaseSubResource, IHaveLocale
        {
            /// <summary>
            /// Locale
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-casesummarizationaiagentconfiguration.html#cfn-wisdom-aiagent-casesummarizationaiagentconfiguration-locale
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Locale { get; set; }
            /// <summary>
            /// CaseSummarizationAIPromptId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-casesummarizationaiagentconfiguration.html#cfn-wisdom-aiagent-casesummarizationaiagentconfiguration-casesummarizationaipromptid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CaseSummarizationAIPromptId { get; set; }
            /// <summary>
            /// CaseSummarizationAIGuardrailId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-casesummarizationaiagentconfiguration.html#cfn-wisdom-aiagent-casesummarizationaiagentconfiguration-casesummarizationaiguardrailid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CaseSummarizationAIGuardrailId { get; set; }
        }

        public class EmailGenerativeAnswerAIAgentConfiguration : Humidifier.Base.BaseSubResource, IHaveLocale
        {
            /// <summary>
            /// EmailGenerativeAnswerAIPromptId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-emailgenerativeansweraiagentconfiguration.html#cfn-wisdom-aiagent-emailgenerativeansweraiagentconfiguration-emailgenerativeansweraipromptid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EmailGenerativeAnswerAIPromptId { get; set; }
            /// <summary>
            /// Locale
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-emailgenerativeansweraiagentconfiguration.html#cfn-wisdom-aiagent-emailgenerativeansweraiagentconfiguration-locale
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Locale { get; set; }
            /// <summary>
            /// EmailQueryReformulationAIPromptId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-emailgenerativeansweraiagentconfiguration.html#cfn-wisdom-aiagent-emailgenerativeansweraiagentconfiguration-emailqueryreformulationaipromptid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EmailQueryReformulationAIPromptId { get; set; }
            /// <summary>
            /// AssociationConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-emailgenerativeansweraiagentconfiguration.html#cfn-wisdom-aiagent-emailgenerativeansweraiagentconfiguration-associationconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AssociationConfiguration
            /// </summary>
            public List<Humidifier.Wisdom.AIAgentTypes.AssociationConfiguration> AssociationConfigurations { get; set; }
        }

        public class EmailOverviewAIAgentConfiguration : Humidifier.Base.BaseSubResource, IHaveLocale
        {
            /// <summary>
            /// Locale
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-emailoverviewaiagentconfiguration.html#cfn-wisdom-aiagent-emailoverviewaiagentconfiguration-locale
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Locale { get; set; }
            /// <summary>
            /// EmailOverviewAIPromptId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-emailoverviewaiagentconfiguration.html#cfn-wisdom-aiagent-emailoverviewaiagentconfiguration-emailoverviewaipromptid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EmailOverviewAIPromptId { get; set; }
        }

        public class EmailResponseAIAgentConfiguration : Humidifier.Base.BaseSubResource, IHaveLocale
        {
            /// <summary>
            /// Locale
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-emailresponseaiagentconfiguration.html#cfn-wisdom-aiagent-emailresponseaiagentconfiguration-locale
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Locale { get; set; }
            /// <summary>
            /// EmailResponseAIPromptId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-emailresponseaiagentconfiguration.html#cfn-wisdom-aiagent-emailresponseaiagentconfiguration-emailresponseaipromptid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EmailResponseAIPromptId { get; set; }
            /// <summary>
            /// EmailQueryReformulationAIPromptId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-emailresponseaiagentconfiguration.html#cfn-wisdom-aiagent-emailresponseaiagentconfiguration-emailqueryreformulationaipromptid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EmailQueryReformulationAIPromptId { get; set; }
            /// <summary>
            /// AssociationConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-emailresponseaiagentconfiguration.html#cfn-wisdom-aiagent-emailresponseaiagentconfiguration-associationconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AssociationConfiguration
            /// </summary>
            public List<Humidifier.Wisdom.AIAgentTypes.AssociationConfiguration> AssociationConfigurations { get; set; }
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

        public class ManualSearchAIAgentConfiguration : Humidifier.Base.BaseSubResource, IHaveLocale, IHaveAnswerGenerationAIPromptId, IHaveAnswerGenerationAIGuardrailId
        {
            /// <summary>
            /// Locale
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-manualsearchaiagentconfiguration.html#cfn-wisdom-aiagent-manualsearchaiagentconfiguration-locale
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Locale { get; set; }
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

        public class NoteTakingAIAgentConfiguration : Humidifier.Base.BaseSubResource, IHaveLocale
        {
            /// <summary>
            /// Locale
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-notetakingaiagentconfiguration.html#cfn-wisdom-aiagent-notetakingaiagentconfiguration-locale
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Locale { get; set; }
            /// <summary>
            /// NoteTakingAIGuardrailId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-notetakingaiagentconfiguration.html#cfn-wisdom-aiagent-notetakingaiagentconfiguration-notetakingaiguardrailid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NoteTakingAIGuardrailId { get; set; }
            /// <summary>
            /// NoteTakingAIPromptId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-notetakingaiagentconfiguration.html#cfn-wisdom-aiagent-notetakingaiagentconfiguration-notetakingaipromptid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NoteTakingAIPromptId { get; set; }
        }

        public class OrCondition : Humidifier.Base.BaseSubResource, IHaveWisdomAIAgentTypesTagConditionTagCondition
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

        public class OrchestrationAIAgentConfiguration : Humidifier.Base.BaseSubResource, IHaveLocale
        {
            /// <summary>
            /// OrchestrationAIPromptId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-orchestrationaiagentconfiguration.html#cfn-wisdom-aiagent-orchestrationaiagentconfiguration-orchestrationaipromptid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OrchestrationAIPromptId { get; set; }
            /// <summary>
            /// Locale
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-orchestrationaiagentconfiguration.html#cfn-wisdom-aiagent-orchestrationaiagentconfiguration-locale
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Locale { get; set; }
            /// <summary>
            /// ToolConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-orchestrationaiagentconfiguration.html#cfn-wisdom-aiagent-orchestrationaiagentconfiguration-toolconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ToolConfiguration
            /// </summary>
            public List<Humidifier.Wisdom.AIAgentTypes.ToolConfiguration> ToolConfigurations { get; set; }
            /// <summary>
            /// OrchestrationAIGuardrailId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-orchestrationaiagentconfiguration.html#cfn-wisdom-aiagent-orchestrationaiagentconfiguration-orchestrationaiguardrailid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OrchestrationAIGuardrailId { get; set; }
            /// <summary>
            /// ConnectInstanceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-orchestrationaiagentconfiguration.html#cfn-wisdom-aiagent-orchestrationaiagentconfiguration-connectinstancearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConnectInstanceArn { get; set; }
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

        public class TagFilter : Humidifier.Base.BaseSubResource, IHaveWisdomAIAgentTypesTagConditionTagCondition
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

        public class ToolConfiguration : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveTitle
        {
            /// <summary>
            /// OutputFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-toolconfiguration.html#cfn-wisdom-aiagent-toolconfiguration-outputfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ToolOutputFilter
            /// </summary>
            public List<Humidifier.Wisdom.AIAgentTypes.ToolOutputFilter> OutputFilters { get; set; }
            /// <summary>
            /// OutputSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-toolconfiguration.html#cfn-wisdom-aiagent-toolconfiguration-outputschema
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic OutputSchema { get; set; }
            /// <summary>
            /// UserInteractionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-toolconfiguration.html#cfn-wisdom-aiagent-toolconfiguration-userinteractionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UserInteractionConfiguration
            /// </summary>
            public Humidifier.Wisdom.AIAgentTypes.UserInteractionConfiguration UserInteractionConfiguration { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-toolconfiguration.html#cfn-wisdom-aiagent-toolconfiguration-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// InputSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-toolconfiguration.html#cfn-wisdom-aiagent-toolconfiguration-inputschema
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic InputSchema { get; set; }
            /// <summary>
            /// Annotations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-toolconfiguration.html#cfn-wisdom-aiagent-toolconfiguration-annotations
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Annotations { get; set; }
            /// <summary>
            /// ToolName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-toolconfiguration.html#cfn-wisdom-aiagent-toolconfiguration-toolname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ToolName { get; set; }
            /// <summary>
            /// ToolId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-toolconfiguration.html#cfn-wisdom-aiagent-toolconfiguration-toolid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ToolId { get; set; }
            /// <summary>
            /// ToolType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-toolconfiguration.html#cfn-wisdom-aiagent-toolconfiguration-tooltype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ToolType { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-toolconfiguration.html#cfn-wisdom-aiagent-toolconfiguration-title
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
            /// <summary>
            /// OverrideInputValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-toolconfiguration.html#cfn-wisdom-aiagent-toolconfiguration-overrideinputvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ToolOverrideInputValue
            /// </summary>
            public List<Humidifier.Wisdom.AIAgentTypes.ToolOverrideInputValue> OverrideInputValues { get; set; }
            /// <summary>
            /// Instruction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-toolconfiguration.html#cfn-wisdom-aiagent-toolconfiguration-instruction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ToolInstruction
            /// </summary>
            public Humidifier.Wisdom.AIAgentTypes.ToolInstruction Instruction { get; set; }
        }

        public class ToolInstruction : Humidifier.Base.BaseSubResource, IHaveExamples
        {
            /// <summary>
            /// Instruction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-toolinstruction.html#cfn-wisdom-aiagent-toolinstruction-instruction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Instruction { get; set; }
            /// <summary>
            /// Examples
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-toolinstruction.html#cfn-wisdom-aiagent-toolinstruction-examples
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Examples { get; set; }
        }

        public class ToolOutputConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SessionDataNamespace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-tooloutputconfiguration.html#cfn-wisdom-aiagent-tooloutputconfiguration-sessiondatanamespace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SessionDataNamespace { get; set; }
            /// <summary>
            /// OutputVariableNameOverride
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-tooloutputconfiguration.html#cfn-wisdom-aiagent-tooloutputconfiguration-outputvariablenameoverride
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OutputVariableNameOverride { get; set; }
        }

        public class ToolOutputFilter : Humidifier.Base.BaseSubResource, IHaveJsonPath
        {
            /// <summary>
            /// OutputConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-tooloutputfilter.html#cfn-wisdom-aiagent-tooloutputfilter-outputconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ToolOutputConfiguration
            /// </summary>
            public Humidifier.Wisdom.AIAgentTypes.ToolOutputConfiguration OutputConfiguration { get; set; }
            /// <summary>
            /// JsonPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-tooloutputfilter.html#cfn-wisdom-aiagent-tooloutputfilter-jsonpath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic JsonPath { get; set; }
        }

        public class ToolOverrideConstantInputValue : Humidifier.Base.BaseSubResource, IHaveType, IHaveValue
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-tooloverrideconstantinputvalue.html#cfn-wisdom-aiagent-tooloverrideconstantinputvalue-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-tooloverrideconstantinputvalue.html#cfn-wisdom-aiagent-tooloverrideconstantinputvalue-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
        }

        public class ToolOverrideInputValue : Humidifier.Base.BaseSubResource, IHaveJsonPath
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-tooloverrideinputvalue.html#cfn-wisdom-aiagent-tooloverrideinputvalue-value
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ToolOverrideInputValueConfiguration
            /// </summary>
            public Humidifier.Wisdom.AIAgentTypes.ToolOverrideInputValueConfiguration Value { get; set; }
            /// <summary>
            /// JsonPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-tooloverrideinputvalue.html#cfn-wisdom-aiagent-tooloverrideinputvalue-jsonpath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic JsonPath { get; set; }
        }

        public class ToolOverrideInputValueConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Constant
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-tooloverrideinputvalueconfiguration.html#cfn-wisdom-aiagent-tooloverrideinputvalueconfiguration-constant
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ToolOverrideConstantInputValue
            /// </summary>
            public Humidifier.Wisdom.AIAgentTypes.ToolOverrideConstantInputValue Constant { get; set; }
        }

        public class UserInteractionConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// IsUserConfirmationRequired
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-userinteractionconfiguration.html#cfn-wisdom-aiagent-userinteractionconfiguration-isuserconfirmationrequired
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsUserConfirmationRequired { get; set; }
        }
    }
}