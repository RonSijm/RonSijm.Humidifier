namespace Humidifier.Wisdom
{
    using global::System.Collections.Generic;
    using AIAgentTypes;

    public class AIAgent : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveType, IHaveDescription, IHaveWisdomAIAgentTypesAIAgentConfigurationConfiguration, IHaveAssistantId, IHaveStringDictionaryOfTags, IHaveName
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
        public Union<string, BaseFunction>? Type { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-aiagent.html#cfn-wisdom-aiagent-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-aiagent.html#cfn-wisdom-aiagent-configuration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: AIAgentConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.Wisdom.AIAgentTypes.AIAgentConfiguration, BaseFunction>? Configuration { get; set; }

        /// <summary>
        /// AssistantId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-aiagent.html#cfn-wisdom-aiagent-assistantid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AssistantId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-aiagent.html#cfn-wisdom-aiagent-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace AIAgentTypes
    {
        public class AIAgentConfiguration : Humidifier.Base.BaseSubResource, IHaveWisdomAIAgentTypesCaseSummarizationAIAgentConfigurationCaseSummarizationAIAgentConfiguration, IHaveWisdomAIAgentTypesManualSearchAIAgentConfigurationManualSearchAIAgentConfiguration, IHaveWisdomAIAgentTypesEmailOverviewAIAgentConfigurationEmailOverviewAIAgentConfiguration, IHaveWisdomAIAgentTypesOrchestrationAIAgentConfigurationOrchestrationAIAgentConfiguration, IHaveWisdomAIAgentTypesSelfServiceAIAgentConfigurationSelfServiceAIAgentConfiguration, IHaveWisdomAIAgentTypesEmailResponseAIAgentConfigurationEmailResponseAIAgentConfiguration, IHaveWisdomAIAgentTypesNoteTakingAIAgentConfigurationNoteTakingAIAgentConfiguration, IHaveWisdomAIAgentTypesAnswerRecommendationAIAgentConfigurationAnswerRecommendationAIAgentConfiguration, IHaveWisdomAIAgentTypesEmailGenerativeAnswerAIAgentConfigurationEmailGenerativeAnswerAIAgentConfiguration
        {
            /// <summary>
            /// CaseSummarizationAIAgentConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-aiagentconfiguration.html#cfn-wisdom-aiagent-aiagentconfiguration-casesummarizationaiagentconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CaseSummarizationAIAgentConfiguration
            /// </summary>
            public Union<Humidifier.Wisdom.AIAgentTypes.CaseSummarizationAIAgentConfiguration, BaseFunction>? CaseSummarizationAIAgentConfiguration { get; set; }
            /// <summary>
            /// ManualSearchAIAgentConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-aiagentconfiguration.html#cfn-wisdom-aiagent-aiagentconfiguration-manualsearchaiagentconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ManualSearchAIAgentConfiguration
            /// </summary>
            public Union<Humidifier.Wisdom.AIAgentTypes.ManualSearchAIAgentConfiguration, BaseFunction>? ManualSearchAIAgentConfiguration { get; set; }
            /// <summary>
            /// EmailOverviewAIAgentConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-aiagentconfiguration.html#cfn-wisdom-aiagent-aiagentconfiguration-emailoverviewaiagentconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EmailOverviewAIAgentConfiguration
            /// </summary>
            public Union<Humidifier.Wisdom.AIAgentTypes.EmailOverviewAIAgentConfiguration, BaseFunction>? EmailOverviewAIAgentConfiguration { get; set; }
            /// <summary>
            /// OrchestrationAIAgentConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-aiagentconfiguration.html#cfn-wisdom-aiagent-aiagentconfiguration-orchestrationaiagentconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OrchestrationAIAgentConfiguration
            /// </summary>
            public Union<Humidifier.Wisdom.AIAgentTypes.OrchestrationAIAgentConfiguration, BaseFunction>? OrchestrationAIAgentConfiguration { get; set; }
            /// <summary>
            /// SelfServiceAIAgentConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-aiagentconfiguration.html#cfn-wisdom-aiagent-aiagentconfiguration-selfserviceaiagentconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SelfServiceAIAgentConfiguration
            /// </summary>
            public Union<Humidifier.Wisdom.AIAgentTypes.SelfServiceAIAgentConfiguration, BaseFunction>? SelfServiceAIAgentConfiguration { get; set; }
            /// <summary>
            /// EmailResponseAIAgentConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-aiagentconfiguration.html#cfn-wisdom-aiagent-aiagentconfiguration-emailresponseaiagentconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EmailResponseAIAgentConfiguration
            /// </summary>
            public Union<Humidifier.Wisdom.AIAgentTypes.EmailResponseAIAgentConfiguration, BaseFunction>? EmailResponseAIAgentConfiguration { get; set; }
            /// <summary>
            /// NoteTakingAIAgentConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-aiagentconfiguration.html#cfn-wisdom-aiagent-aiagentconfiguration-notetakingaiagentconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NoteTakingAIAgentConfiguration
            /// </summary>
            public Union<Humidifier.Wisdom.AIAgentTypes.NoteTakingAIAgentConfiguration, BaseFunction>? NoteTakingAIAgentConfiguration { get; set; }
            /// <summary>
            /// AnswerRecommendationAIAgentConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-aiagentconfiguration.html#cfn-wisdom-aiagent-aiagentconfiguration-answerrecommendationaiagentconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AnswerRecommendationAIAgentConfiguration
            /// </summary>
            public Union<Humidifier.Wisdom.AIAgentTypes.AnswerRecommendationAIAgentConfiguration, BaseFunction>? AnswerRecommendationAIAgentConfiguration { get; set; }
            /// <summary>
            /// EmailGenerativeAnswerAIAgentConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-aiagentconfiguration.html#cfn-wisdom-aiagent-aiagentconfiguration-emailgenerativeansweraiagentconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EmailGenerativeAnswerAIAgentConfiguration
            /// </summary>
            public Union<Humidifier.Wisdom.AIAgentTypes.EmailGenerativeAnswerAIAgentConfiguration, BaseFunction>? EmailGenerativeAnswerAIAgentConfiguration { get; set; }
        }

        public class AnswerRecommendationAIAgentConfiguration : Humidifier.Base.BaseSubResource, IHaveLocale, IHaveAnswerGenerationAIPromptId, IHaveIntentLabelingGenerationAIPromptId, IHaveQueryReformulationAIPromptId, IHaveAnswerGenerationAIGuardrailId, IHaveListOfWisdomAIAgentTypesAssociationConfigurationAssociationConfigurations
        {
            /// <summary>
            /// Locale
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-answerrecommendationaiagentconfiguration.html#cfn-wisdom-aiagent-answerrecommendationaiagentconfiguration-locale
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Locale { get; set; }
            /// <summary>
            /// AnswerGenerationAIPromptId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-answerrecommendationaiagentconfiguration.html#cfn-wisdom-aiagent-answerrecommendationaiagentconfiguration-answergenerationaipromptid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AnswerGenerationAIPromptId { get; set; }
            /// <summary>
            /// IntentLabelingGenerationAIPromptId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-answerrecommendationaiagentconfiguration.html#cfn-wisdom-aiagent-answerrecommendationaiagentconfiguration-intentlabelinggenerationaipromptid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IntentLabelingGenerationAIPromptId { get; set; }
            /// <summary>
            /// QueryReformulationAIPromptId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-answerrecommendationaiagentconfiguration.html#cfn-wisdom-aiagent-answerrecommendationaiagentconfiguration-queryreformulationaipromptid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? QueryReformulationAIPromptId { get; set; }
            /// <summary>
            /// AnswerGenerationAIGuardrailId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-answerrecommendationaiagentconfiguration.html#cfn-wisdom-aiagent-answerrecommendationaiagentconfiguration-answergenerationaiguardrailid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AnswerGenerationAIGuardrailId { get; set; }
            /// <summary>
            /// AssociationConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-answerrecommendationaiagentconfiguration.html#cfn-wisdom-aiagent-answerrecommendationaiagentconfiguration-associationconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AssociationConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Wisdom.AIAgentTypes.AssociationConfiguration>, IReadOnlyList<Union<Humidifier.Wisdom.AIAgentTypes.AssociationConfiguration, BaseFunction>>, BaseFunction>? AssociationConfigurations { get; set; }
        }

        public class AssociationConfiguration : Humidifier.Base.BaseSubResource, IHaveAssociationType, IHaveWisdomAIAgentTypesAssociationConfigurationDataAssociationConfigurationData, IHaveAssociationId
        {
            /// <summary>
            /// AssociationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-associationconfiguration.html#cfn-wisdom-aiagent-associationconfiguration-associationtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AssociationType { get; set; }
            /// <summary>
            /// AssociationConfigurationData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-associationconfiguration.html#cfn-wisdom-aiagent-associationconfiguration-associationconfigurationdata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AssociationConfigurationData
            /// </summary>
            public Union<Humidifier.Wisdom.AIAgentTypes.AssociationConfigurationData, BaseFunction>? AssociationConfigurationData { get; set; }
            /// <summary>
            /// AssociationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-associationconfiguration.html#cfn-wisdom-aiagent-associationconfiguration-associationid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AssociationId { get; set; }
        }

        public class AssociationConfigurationData : Humidifier.Base.BaseSubResource, IHaveWisdomAIAgentTypesKnowledgeBaseAssociationConfigurationDataKnowledgeBaseAssociationConfigurationData
        {
            /// <summary>
            /// KnowledgeBaseAssociationConfigurationData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-associationconfigurationdata.html#cfn-wisdom-aiagent-associationconfigurationdata-knowledgebaseassociationconfigurationdata
            /// Required: True
            /// UpdateType: Mutable
            /// Type: KnowledgeBaseAssociationConfigurationData
            /// </summary>
            public Union<Humidifier.Wisdom.AIAgentTypes.KnowledgeBaseAssociationConfigurationData, BaseFunction>? KnowledgeBaseAssociationConfigurationData { get; set; }
        }

        public class CaseSummarizationAIAgentConfiguration : Humidifier.Base.BaseSubResource, IHaveLocale, IHaveCaseSummarizationAIPromptId, IHaveCaseSummarizationAIGuardrailId
        {
            /// <summary>
            /// Locale
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-casesummarizationaiagentconfiguration.html#cfn-wisdom-aiagent-casesummarizationaiagentconfiguration-locale
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Locale { get; set; }
            /// <summary>
            /// CaseSummarizationAIPromptId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-casesummarizationaiagentconfiguration.html#cfn-wisdom-aiagent-casesummarizationaiagentconfiguration-casesummarizationaipromptid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CaseSummarizationAIPromptId { get; set; }
            /// <summary>
            /// CaseSummarizationAIGuardrailId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-casesummarizationaiagentconfiguration.html#cfn-wisdom-aiagent-casesummarizationaiagentconfiguration-casesummarizationaiguardrailid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CaseSummarizationAIGuardrailId { get; set; }
        }

        public class EmailGenerativeAnswerAIAgentConfiguration : Humidifier.Base.BaseSubResource, IHaveEmailGenerativeAnswerAIPromptId, IHaveLocale, IHaveEmailQueryReformulationAIPromptId, IHaveListOfWisdomAIAgentTypesAssociationConfigurationAssociationConfigurations
        {
            /// <summary>
            /// EmailGenerativeAnswerAIPromptId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-emailgenerativeansweraiagentconfiguration.html#cfn-wisdom-aiagent-emailgenerativeansweraiagentconfiguration-emailgenerativeansweraipromptid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EmailGenerativeAnswerAIPromptId { get; set; }
            /// <summary>
            /// Locale
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-emailgenerativeansweraiagentconfiguration.html#cfn-wisdom-aiagent-emailgenerativeansweraiagentconfiguration-locale
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Locale { get; set; }
            /// <summary>
            /// EmailQueryReformulationAIPromptId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-emailgenerativeansweraiagentconfiguration.html#cfn-wisdom-aiagent-emailgenerativeansweraiagentconfiguration-emailqueryreformulationaipromptid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EmailQueryReformulationAIPromptId { get; set; }
            /// <summary>
            /// AssociationConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-emailgenerativeansweraiagentconfiguration.html#cfn-wisdom-aiagent-emailgenerativeansweraiagentconfiguration-associationconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AssociationConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Wisdom.AIAgentTypes.AssociationConfiguration>, IReadOnlyList<Union<Humidifier.Wisdom.AIAgentTypes.AssociationConfiguration, BaseFunction>>, BaseFunction>? AssociationConfigurations { get; set; }
        }

        public class EmailOverviewAIAgentConfiguration : Humidifier.Base.BaseSubResource, IHaveLocale, IHaveEmailOverviewAIPromptId
        {
            /// <summary>
            /// Locale
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-emailoverviewaiagentconfiguration.html#cfn-wisdom-aiagent-emailoverviewaiagentconfiguration-locale
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Locale { get; set; }
            /// <summary>
            /// EmailOverviewAIPromptId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-emailoverviewaiagentconfiguration.html#cfn-wisdom-aiagent-emailoverviewaiagentconfiguration-emailoverviewaipromptid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EmailOverviewAIPromptId { get; set; }
        }

        public class EmailResponseAIAgentConfiguration : Humidifier.Base.BaseSubResource, IHaveLocale, IHaveEmailResponseAIPromptId, IHaveEmailQueryReformulationAIPromptId, IHaveListOfWisdomAIAgentTypesAssociationConfigurationAssociationConfigurations
        {
            /// <summary>
            /// Locale
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-emailresponseaiagentconfiguration.html#cfn-wisdom-aiagent-emailresponseaiagentconfiguration-locale
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Locale { get; set; }
            /// <summary>
            /// EmailResponseAIPromptId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-emailresponseaiagentconfiguration.html#cfn-wisdom-aiagent-emailresponseaiagentconfiguration-emailresponseaipromptid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EmailResponseAIPromptId { get; set; }
            /// <summary>
            /// EmailQueryReformulationAIPromptId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-emailresponseaiagentconfiguration.html#cfn-wisdom-aiagent-emailresponseaiagentconfiguration-emailqueryreformulationaipromptid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EmailQueryReformulationAIPromptId { get; set; }
            /// <summary>
            /// AssociationConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-emailresponseaiagentconfiguration.html#cfn-wisdom-aiagent-emailresponseaiagentconfiguration-associationconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AssociationConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Wisdom.AIAgentTypes.AssociationConfiguration>, IReadOnlyList<Union<Humidifier.Wisdom.AIAgentTypes.AssociationConfiguration, BaseFunction>>, BaseFunction>? AssociationConfigurations { get; set; }
        }

        public class KnowledgeBaseAssociationConfigurationData : Humidifier.Base.BaseSubResource, IHaveMaxResults_Double, IHaveWisdomAIAgentTypesTagFilterContentTagFilter, IHaveOverrideKnowledgeBaseSearchType
        {
            /// <summary>
            /// MaxResults
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-knowledgebaseassociationconfigurationdata.html#cfn-wisdom-aiagent-knowledgebaseassociationconfigurationdata-maxresults
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MaxResults { get; set; }
            /// <summary>
            /// ContentTagFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-knowledgebaseassociationconfigurationdata.html#cfn-wisdom-aiagent-knowledgebaseassociationconfigurationdata-contenttagfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TagFilter
            /// </summary>
            public Union<Humidifier.Wisdom.AIAgentTypes.TagFilter, BaseFunction>? ContentTagFilter { get; set; }
            /// <summary>
            /// OverrideKnowledgeBaseSearchType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-knowledgebaseassociationconfigurationdata.html#cfn-wisdom-aiagent-knowledgebaseassociationconfigurationdata-overrideknowledgebasesearchtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OverrideKnowledgeBaseSearchType { get; set; }
        }

        public class ManualSearchAIAgentConfiguration : Humidifier.Base.BaseSubResource, IHaveLocale, IHaveAnswerGenerationAIPromptId, IHaveAnswerGenerationAIGuardrailId, IHaveListOfWisdomAIAgentTypesAssociationConfigurationAssociationConfigurations
        {
            /// <summary>
            /// Locale
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-manualsearchaiagentconfiguration.html#cfn-wisdom-aiagent-manualsearchaiagentconfiguration-locale
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Locale { get; set; }
            /// <summary>
            /// AnswerGenerationAIPromptId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-manualsearchaiagentconfiguration.html#cfn-wisdom-aiagent-manualsearchaiagentconfiguration-answergenerationaipromptid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AnswerGenerationAIPromptId { get; set; }
            /// <summary>
            /// AnswerGenerationAIGuardrailId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-manualsearchaiagentconfiguration.html#cfn-wisdom-aiagent-manualsearchaiagentconfiguration-answergenerationaiguardrailid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AnswerGenerationAIGuardrailId { get; set; }
            /// <summary>
            /// AssociationConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-manualsearchaiagentconfiguration.html#cfn-wisdom-aiagent-manualsearchaiagentconfiguration-associationconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AssociationConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Wisdom.AIAgentTypes.AssociationConfiguration>, IReadOnlyList<Union<Humidifier.Wisdom.AIAgentTypes.AssociationConfiguration, BaseFunction>>, BaseFunction>? AssociationConfigurations { get; set; }
        }

        public class NoteTakingAIAgentConfiguration : Humidifier.Base.BaseSubResource, IHaveLocale, IHaveNoteTakingAIGuardrailId, IHaveNoteTakingAIPromptId
        {
            /// <summary>
            /// Locale
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-notetakingaiagentconfiguration.html#cfn-wisdom-aiagent-notetakingaiagentconfiguration-locale
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Locale { get; set; }
            /// <summary>
            /// NoteTakingAIGuardrailId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-notetakingaiagentconfiguration.html#cfn-wisdom-aiagent-notetakingaiagentconfiguration-notetakingaiguardrailid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NoteTakingAIGuardrailId { get; set; }
            /// <summary>
            /// NoteTakingAIPromptId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-notetakingaiagentconfiguration.html#cfn-wisdom-aiagent-notetakingaiagentconfiguration-notetakingaipromptid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NoteTakingAIPromptId { get; set; }
        }

        public class OrCondition : Humidifier.Base.BaseSubResource, IHaveListOfWisdomAIAgentTypesTagConditionAndConditions, IHaveWisdomAIAgentTypesTagConditionTagCondition
        {
            /// <summary>
            /// AndConditions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-orcondition.html#cfn-wisdom-aiagent-orcondition-andconditions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TagCondition
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Wisdom.AIAgentTypes.TagCondition>, IReadOnlyList<Union<Humidifier.Wisdom.AIAgentTypes.TagCondition, BaseFunction>>, BaseFunction>? AndConditions { get; set; }
            /// <summary>
            /// TagCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-orcondition.html#cfn-wisdom-aiagent-orcondition-tagcondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TagCondition
            /// </summary>
            public Union<Humidifier.Wisdom.AIAgentTypes.TagCondition, BaseFunction>? TagCondition { get; set; }
        }

        public class OrchestrationAIAgentConfiguration : Humidifier.Base.BaseSubResource, IHaveOrchestrationAIPromptId, IHaveLocale, IHaveListOfWisdomAIAgentTypesToolConfigurationToolConfigurations, IHaveOrchestrationAIGuardrailId, IHaveConnectInstanceArn
        {
            /// <summary>
            /// OrchestrationAIPromptId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-orchestrationaiagentconfiguration.html#cfn-wisdom-aiagent-orchestrationaiagentconfiguration-orchestrationaipromptid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OrchestrationAIPromptId { get; set; }
            /// <summary>
            /// Locale
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-orchestrationaiagentconfiguration.html#cfn-wisdom-aiagent-orchestrationaiagentconfiguration-locale
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Locale { get; set; }
            /// <summary>
            /// ToolConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-orchestrationaiagentconfiguration.html#cfn-wisdom-aiagent-orchestrationaiagentconfiguration-toolconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ToolConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Wisdom.AIAgentTypes.ToolConfiguration>, IReadOnlyList<Union<Humidifier.Wisdom.AIAgentTypes.ToolConfiguration, BaseFunction>>, BaseFunction>? ToolConfigurations { get; set; }
            /// <summary>
            /// OrchestrationAIGuardrailId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-orchestrationaiagentconfiguration.html#cfn-wisdom-aiagent-orchestrationaiagentconfiguration-orchestrationaiguardrailid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OrchestrationAIGuardrailId { get; set; }
            /// <summary>
            /// ConnectInstanceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-orchestrationaiagentconfiguration.html#cfn-wisdom-aiagent-orchestrationaiagentconfiguration-connectinstancearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectInstanceArn { get; set; }
        }

        public class SelfServiceAIAgentConfiguration : Humidifier.Base.BaseSubResource, IHaveSelfServiceAIGuardrailId, IHaveSelfServicePreProcessingAIPromptId, IHaveSelfServiceAnswerGenerationAIPromptId, IHaveListOfWisdomAIAgentTypesAssociationConfigurationAssociationConfigurations
        {
            /// <summary>
            /// SelfServiceAIGuardrailId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-selfserviceaiagentconfiguration.html#cfn-wisdom-aiagent-selfserviceaiagentconfiguration-selfserviceaiguardrailid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SelfServiceAIGuardrailId { get; set; }
            /// <summary>
            /// SelfServicePreProcessingAIPromptId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-selfserviceaiagentconfiguration.html#cfn-wisdom-aiagent-selfserviceaiagentconfiguration-selfservicepreprocessingaipromptid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SelfServicePreProcessingAIPromptId { get; set; }
            /// <summary>
            /// SelfServiceAnswerGenerationAIPromptId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-selfserviceaiagentconfiguration.html#cfn-wisdom-aiagent-selfserviceaiagentconfiguration-selfserviceanswergenerationaipromptid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SelfServiceAnswerGenerationAIPromptId { get; set; }
            /// <summary>
            /// AssociationConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-selfserviceaiagentconfiguration.html#cfn-wisdom-aiagent-selfserviceaiagentconfiguration-associationconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AssociationConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Wisdom.AIAgentTypes.AssociationConfiguration>, IReadOnlyList<Union<Humidifier.Wisdom.AIAgentTypes.AssociationConfiguration, BaseFunction>>, BaseFunction>? AssociationConfigurations { get; set; }
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
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-tagcondition.html#cfn-wisdom-aiagent-tagcondition-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class TagFilter : Humidifier.Base.BaseSubResource, IHaveListOfWisdomAIAgentTypesOrConditionOrConditions, IHaveListOfWisdomAIAgentTypesTagConditionAndConditions, IHaveWisdomAIAgentTypesTagConditionTagCondition
        {
            /// <summary>
            /// OrConditions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-tagfilter.html#cfn-wisdom-aiagent-tagfilter-orconditions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: OrCondition
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Wisdom.AIAgentTypes.OrCondition>, IReadOnlyList<Union<Humidifier.Wisdom.AIAgentTypes.OrCondition, BaseFunction>>, BaseFunction>? OrConditions { get; set; }
            /// <summary>
            /// AndConditions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-tagfilter.html#cfn-wisdom-aiagent-tagfilter-andconditions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TagCondition
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Wisdom.AIAgentTypes.TagCondition>, IReadOnlyList<Union<Humidifier.Wisdom.AIAgentTypes.TagCondition, BaseFunction>>, BaseFunction>? AndConditions { get; set; }
            /// <summary>
            /// TagCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-tagfilter.html#cfn-wisdom-aiagent-tagfilter-tagcondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TagCondition
            /// </summary>
            public Union<Humidifier.Wisdom.AIAgentTypes.TagCondition, BaseFunction>? TagCondition { get; set; }
        }

        public class ToolConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfWisdomAIAgentTypesToolOutputFilterOutputFilters, IHaveOutputSchema_Json, IHaveWisdomAIAgentTypesUserInteractionConfigurationUserInteractionConfiguration, IHaveDescription, IHaveInputSchema_Json, IHaveAnnotations_Json, IHaveToolName, IHaveToolId, IHaveToolType, IHaveTitle, IHaveListOfWisdomAIAgentTypesToolOverrideInputValueOverrideInputValues, IHaveWisdomAIAgentTypesToolInstructionInstruction
        {
            /// <summary>
            /// OutputFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-toolconfiguration.html#cfn-wisdom-aiagent-toolconfiguration-outputfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ToolOutputFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Wisdom.AIAgentTypes.ToolOutputFilter>, IReadOnlyList<Union<Humidifier.Wisdom.AIAgentTypes.ToolOutputFilter, BaseFunction>>, BaseFunction>? OutputFilters { get; set; }
            /// <summary>
            /// OutputSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-toolconfiguration.html#cfn-wisdom-aiagent-toolconfiguration-outputschema
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? OutputSchema { get; set; }
            /// <summary>
            /// UserInteractionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-toolconfiguration.html#cfn-wisdom-aiagent-toolconfiguration-userinteractionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UserInteractionConfiguration
            /// </summary>
            public Union<Humidifier.Wisdom.AIAgentTypes.UserInteractionConfiguration, BaseFunction>? UserInteractionConfiguration { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-toolconfiguration.html#cfn-wisdom-aiagent-toolconfiguration-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// InputSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-toolconfiguration.html#cfn-wisdom-aiagent-toolconfiguration-inputschema
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? InputSchema { get; set; }
            /// <summary>
            /// Annotations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-toolconfiguration.html#cfn-wisdom-aiagent-toolconfiguration-annotations
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Annotations { get; set; }
            /// <summary>
            /// ToolName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-toolconfiguration.html#cfn-wisdom-aiagent-toolconfiguration-toolname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ToolName { get; set; }
            /// <summary>
            /// ToolId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-toolconfiguration.html#cfn-wisdom-aiagent-toolconfiguration-toolid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ToolId { get; set; }
            /// <summary>
            /// ToolType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-toolconfiguration.html#cfn-wisdom-aiagent-toolconfiguration-tooltype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ToolType { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-toolconfiguration.html#cfn-wisdom-aiagent-toolconfiguration-title
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Title { get; set; }
            /// <summary>
            /// OverrideInputValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-toolconfiguration.html#cfn-wisdom-aiagent-toolconfiguration-overrideinputvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ToolOverrideInputValue
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Wisdom.AIAgentTypes.ToolOverrideInputValue>, IReadOnlyList<Union<Humidifier.Wisdom.AIAgentTypes.ToolOverrideInputValue, BaseFunction>>, BaseFunction>? OverrideInputValues { get; set; }
            /// <summary>
            /// Instruction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-toolconfiguration.html#cfn-wisdom-aiagent-toolconfiguration-instruction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ToolInstruction
            /// </summary>
            public Union<Humidifier.Wisdom.AIAgentTypes.ToolInstruction, BaseFunction>? Instruction { get; set; }
        }

        public class ToolInstruction : Humidifier.Base.BaseSubResource, IHaveInstruction, IHaveStringListOfExamples
        {
            /// <summary>
            /// Instruction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-toolinstruction.html#cfn-wisdom-aiagent-toolinstruction-instruction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Instruction { get; set; }
            /// <summary>
            /// Examples
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-toolinstruction.html#cfn-wisdom-aiagent-toolinstruction-examples
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Examples { get; set; }
        }

        public class ToolOutputConfiguration : Humidifier.Base.BaseSubResource, IHaveSessionDataNamespace, IHaveOutputVariableNameOverride
        {
            /// <summary>
            /// SessionDataNamespace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-tooloutputconfiguration.html#cfn-wisdom-aiagent-tooloutputconfiguration-sessiondatanamespace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SessionDataNamespace { get; set; }
            /// <summary>
            /// OutputVariableNameOverride
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-tooloutputconfiguration.html#cfn-wisdom-aiagent-tooloutputconfiguration-outputvariablenameoverride
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputVariableNameOverride { get; set; }
        }

        public class ToolOutputFilter : Humidifier.Base.BaseSubResource, IHaveWisdomAIAgentTypesToolOutputConfigurationOutputConfiguration, IHaveJsonPath
        {
            /// <summary>
            /// OutputConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-tooloutputfilter.html#cfn-wisdom-aiagent-tooloutputfilter-outputconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ToolOutputConfiguration
            /// </summary>
            public Union<Humidifier.Wisdom.AIAgentTypes.ToolOutputConfiguration, BaseFunction>? OutputConfiguration { get; set; }
            /// <summary>
            /// JsonPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-tooloutputfilter.html#cfn-wisdom-aiagent-tooloutputfilter-jsonpath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? JsonPath { get; set; }
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
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-tooloverrideconstantinputvalue.html#cfn-wisdom-aiagent-tooloverrideconstantinputvalue-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
        }

        public class ToolOverrideInputValue : Humidifier.Base.BaseSubResource, IHaveWisdomAIAgentTypesToolOverrideInputValueConfigurationValue, IHaveJsonPath
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-tooloverrideinputvalue.html#cfn-wisdom-aiagent-tooloverrideinputvalue-value
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ToolOverrideInputValueConfiguration
            /// </summary>
            public Union<Humidifier.Wisdom.AIAgentTypes.ToolOverrideInputValueConfiguration, BaseFunction>? Value { get; set; }
            /// <summary>
            /// JsonPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-tooloverrideinputvalue.html#cfn-wisdom-aiagent-tooloverrideinputvalue-jsonpath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? JsonPath { get; set; }
        }

        public class ToolOverrideInputValueConfiguration : Humidifier.Base.BaseSubResource, IHaveWisdomAIAgentTypesToolOverrideConstantInputValueConstant
        {
            /// <summary>
            /// Constant
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-tooloverrideinputvalueconfiguration.html#cfn-wisdom-aiagent-tooloverrideinputvalueconfiguration-constant
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ToolOverrideConstantInputValue
            /// </summary>
            public Union<Humidifier.Wisdom.AIAgentTypes.ToolOverrideConstantInputValue, BaseFunction>? Constant { get; set; }
        }

        public class UserInteractionConfiguration : Humidifier.Base.BaseSubResource, IHaveIsUserConfirmationRequired_Boolean
        {
            /// <summary>
            /// IsUserConfirmationRequired
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiagent-userinteractionconfiguration.html#cfn-wisdom-aiagent-userinteractionconfiguration-isuserconfirmationrequired
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsUserConfirmationRequired { get; set; }
        }
    }
}