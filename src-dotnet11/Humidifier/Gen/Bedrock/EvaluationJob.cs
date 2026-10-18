namespace Humidifier.Bedrock
{
    using global::System.Collections.Generic;
    using EvaluationJobTypes;

    public class EvaluationJob : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string OutputDataConfig =  "OutputDataConfig" ;
            public static string JobName =  "JobName" ;
            public static string JobArn =  "JobArn" ;
            public static string JobDescription =  "JobDescription" ;
            public static string EvaluationConfig =  "EvaluationConfig" ;
            public static string Tags =  "Tags" ;
            public static string Status =  "Status" ;
            public static string RoleArn =  "RoleArn" ;
            public static string ApplicationType =  "ApplicationType" ;
            public static string JobType =  "JobType" ;
            public static string InferenceConfig =  "InferenceConfig" ;
            public static string CreationTime =  "CreationTime" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string CustomerEncryptionKeyId =  "CustomerEncryptionKeyId" ;
        }

        public override string AWSTypeName { get => AWS.Bedrock.EvaluationJob; }
    }

    namespace EvaluationJobTypes
    {
        public class AutomatedEvaluationConfig : Humidifier.Base.BaseSubResource, IHaveBedrockEvaluationJobTypesEvaluatorModelConfigEvaluatorModelConfig, IHaveListOfBedrockEvaluationJobTypesEvaluationDatasetMetricConfigDatasetMetricConfigs
        {
            /// <summary>
            /// EvaluatorModelConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-automatedevaluationconfig.html#cfn-bedrock-evaluationjob-automatedevaluationconfig-evaluatormodelconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluatorModelConfig
            /// </summary>
            public Union<Humidifier.Bedrock.EvaluationJobTypes.EvaluatorModelConfig, BaseFunction>? EvaluatorModelConfig { get; set; }
            /// <summary>
            /// DatasetMetricConfigs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-automatedevaluationconfig.html#cfn-bedrock-evaluationjob-automatedevaluationconfig-datasetmetricconfigs
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EvaluationDatasetMetricConfig
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.EvaluationJobTypes.EvaluationDatasetMetricConfig>, IReadOnlyList<Union<Humidifier.Bedrock.EvaluationJobTypes.EvaluationDatasetMetricConfig, BaseFunction>>, BaseFunction>? DatasetMetricConfigs { get; set; }
        }

        public class BedrockEvaluatorModel : Humidifier.Base.BaseSubResource, IHaveModelIdentifier
        {
            /// <summary>
            /// ModelIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-bedrockevaluatormodel.html#cfn-bedrock-evaluationjob-bedrockevaluatormodel-modelidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelIdentifier { get; set; }
        }

        public class EvaluationBedrockModel : Humidifier.Base.BaseSubResource, IHaveInferenceParams, IHaveModelIdentifier
        {
            /// <summary>
            /// InferenceParams
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-evaluationbedrockmodel.html#cfn-bedrock-evaluationjob-evaluationbedrockmodel-inferenceparams
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InferenceParams { get; set; }
            /// <summary>
            /// ModelIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-evaluationbedrockmodel.html#cfn-bedrock-evaluationjob-evaluationbedrockmodel-modelidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelIdentifier { get; set; }
        }

        public class EvaluationConfig : Humidifier.Base.BaseSubResource, IHaveBedrockEvaluationJobTypesHumanEvaluationConfigHuman, IHaveBedrockEvaluationJobTypesAutomatedEvaluationConfigAutomated
        {
            /// <summary>
            /// Human
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-evaluationconfig.html#cfn-bedrock-evaluationjob-evaluationconfig-human
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HumanEvaluationConfig
            /// </summary>
            public Union<Humidifier.Bedrock.EvaluationJobTypes.HumanEvaluationConfig, BaseFunction>? Human { get; set; }
            /// <summary>
            /// Automated
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-evaluationconfig.html#cfn-bedrock-evaluationjob-evaluationconfig-automated
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AutomatedEvaluationConfig
            /// </summary>
            public Union<Humidifier.Bedrock.EvaluationJobTypes.AutomatedEvaluationConfig, BaseFunction>? Automated { get; set; }
        }

        public class EvaluationDataset : Humidifier.Base.BaseSubResource, IHaveName, IHaveBedrockEvaluationJobTypesEvaluationDatasetLocationDatasetLocation
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-evaluationdataset.html#cfn-bedrock-evaluationjob-evaluationdataset-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
            /// <summary>
            /// DatasetLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-evaluationdataset.html#cfn-bedrock-evaluationjob-evaluationdataset-datasetlocation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluationDatasetLocation
            /// </summary>
            public Union<Humidifier.Bedrock.EvaluationJobTypes.EvaluationDatasetLocation, BaseFunction>? DatasetLocation { get; set; }
        }

        public class EvaluationDatasetLocation : Humidifier.Base.BaseSubResource, IHaveS3Uri
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-evaluationdatasetlocation.html#cfn-bedrock-evaluationjob-evaluationdatasetlocation-s3uri
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
        }

        public class EvaluationDatasetMetricConfig : Humidifier.Base.BaseSubResource, IHaveBedrockEvaluationJobTypesEvaluationDatasetDataset, IHaveStringListOfMetricNames, IHaveTaskType
        {
            /// <summary>
            /// Dataset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-evaluationdatasetmetricconfig.html#cfn-bedrock-evaluationjob-evaluationdatasetmetricconfig-dataset
            /// Required: True
            /// UpdateType: Mutable
            /// Type: EvaluationDataset
            /// </summary>
            public Union<Humidifier.Bedrock.EvaluationJobTypes.EvaluationDataset, BaseFunction>? Dataset { get; set; }
            /// <summary>
            /// MetricNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-evaluationdatasetmetricconfig.html#cfn-bedrock-evaluationjob-evaluationdatasetmetricconfig-metricnames
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? MetricNames { get; set; }
            /// <summary>
            /// TaskType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-evaluationdatasetmetricconfig.html#cfn-bedrock-evaluationjob-evaluationdatasetmetricconfig-tasktype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TaskType { get; set; }
        }

        public class EvaluationInferenceConfig : Humidifier.Base.BaseSubResource, IHaveListOfBedrockEvaluationJobTypesEvaluationModelConfigModels, IHaveListOfBedrockEvaluationJobTypesRAGConfigRagConfigs
        {
            /// <summary>
            /// Models
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-evaluationinferenceconfig.html#cfn-bedrock-evaluationjob-evaluationinferenceconfig-models
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EvaluationModelConfig
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.EvaluationJobTypes.EvaluationModelConfig>, IReadOnlyList<Union<Humidifier.Bedrock.EvaluationJobTypes.EvaluationModelConfig, BaseFunction>>, BaseFunction>? Models { get; set; }
            /// <summary>
            /// RagConfigs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-evaluationinferenceconfig.html#cfn-bedrock-evaluationjob-evaluationinferenceconfig-ragconfigs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RAGConfig
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.EvaluationJobTypes.RAGConfig>, IReadOnlyList<Union<Humidifier.Bedrock.EvaluationJobTypes.RAGConfig, BaseFunction>>, BaseFunction>? RagConfigs { get; set; }
        }

        public class EvaluationModelConfig : Humidifier.Base.BaseSubResource, IHaveBedrockEvaluationJobTypesEvaluationBedrockModelBedrockModel
        {
            /// <summary>
            /// BedrockModel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-evaluationmodelconfig.html#cfn-bedrock-evaluationjob-evaluationmodelconfig-bedrockmodel
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluationBedrockModel
            /// </summary>
            public Union<Humidifier.Bedrock.EvaluationJobTypes.EvaluationBedrockModel, BaseFunction>? BedrockModel { get; set; }
        }

        public class EvaluationOutputDataConfig : Humidifier.Base.BaseSubResource, IHaveS3Uri
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-evaluationoutputdataconfig.html#cfn-bedrock-evaluationjob-evaluationoutputdataconfig-s3uri
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
        }

        public class EvaluatorModelConfig : Humidifier.Base.BaseSubResource, IHaveListOfBedrockEvaluationJobTypesBedrockEvaluatorModelBedrockEvaluatorModels
        {
            /// <summary>
            /// BedrockEvaluatorModels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-evaluatormodelconfig.html#cfn-bedrock-evaluationjob-evaluatormodelconfig-bedrockevaluatormodels
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: BedrockEvaluatorModel
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.EvaluationJobTypes.BedrockEvaluatorModel>, IReadOnlyList<Union<Humidifier.Bedrock.EvaluationJobTypes.BedrockEvaluatorModel, BaseFunction>>, BaseFunction>? BedrockEvaluatorModels { get; set; }
        }

        public class HumanEvaluationConfig : Humidifier.Base.BaseSubResource, IHaveBedrockEvaluationJobTypesHumanWorkflowConfigHumanWorkflowConfig, IHaveListOfBedrockEvaluationJobTypesEvaluationDatasetMetricConfigDatasetMetricConfigs, IHaveListOfBedrockEvaluationJobTypesHumanEvaluationCustomMetricCustomMetrics
        {
            /// <summary>
            /// HumanWorkflowConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-humanevaluationconfig.html#cfn-bedrock-evaluationjob-humanevaluationconfig-humanworkflowconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HumanWorkflowConfig
            /// </summary>
            public Union<Humidifier.Bedrock.EvaluationJobTypes.HumanWorkflowConfig, BaseFunction>? HumanWorkflowConfig { get; set; }
            /// <summary>
            /// DatasetMetricConfigs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-humanevaluationconfig.html#cfn-bedrock-evaluationjob-humanevaluationconfig-datasetmetricconfigs
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EvaluationDatasetMetricConfig
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.EvaluationJobTypes.EvaluationDatasetMetricConfig>, IReadOnlyList<Union<Humidifier.Bedrock.EvaluationJobTypes.EvaluationDatasetMetricConfig, BaseFunction>>, BaseFunction>? DatasetMetricConfigs { get; set; }
            /// <summary>
            /// CustomMetrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-humanevaluationconfig.html#cfn-bedrock-evaluationjob-humanevaluationconfig-custommetrics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: HumanEvaluationCustomMetric
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.EvaluationJobTypes.HumanEvaluationCustomMetric>, IReadOnlyList<Union<Humidifier.Bedrock.EvaluationJobTypes.HumanEvaluationCustomMetric, BaseFunction>>, BaseFunction>? CustomMetrics { get; set; }
        }

        public class HumanEvaluationCustomMetric : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveRatingMethod, IHaveName
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-humanevaluationcustommetric.html#cfn-bedrock-evaluationjob-humanevaluationcustommetric-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// RatingMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-humanevaluationcustommetric.html#cfn-bedrock-evaluationjob-humanevaluationcustommetric-ratingmethod
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RatingMethod { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-humanevaluationcustommetric.html#cfn-bedrock-evaluationjob-humanevaluationcustommetric-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class HumanWorkflowConfig : Humidifier.Base.BaseSubResource, IHaveFlowDefinitionArn, IHaveInstructions
        {
            /// <summary>
            /// FlowDefinitionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-humanworkflowconfig.html#cfn-bedrock-evaluationjob-humanworkflowconfig-flowdefinitionarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FlowDefinitionArn { get; set; }
            /// <summary>
            /// Instructions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-humanworkflowconfig.html#cfn-bedrock-evaluationjob-humanworkflowconfig-instructions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Instructions { get; set; }
        }

        public class KnowledgeBaseConfig : Humidifier.Base.BaseSubResource, IHaveBedrockEvaluationJobTypesRetrieveAndGenerateConfigRetrieveAndGenerateConfig, IHaveBedrockEvaluationJobTypesRetrieveConfigRetrieveConfig
        {
            /// <summary>
            /// RetrieveAndGenerateConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-knowledgebaseconfig.html#cfn-bedrock-evaluationjob-knowledgebaseconfig-retrieveandgenerateconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RetrieveAndGenerateConfig
            /// </summary>
            public Union<Humidifier.Bedrock.EvaluationJobTypes.RetrieveAndGenerateConfig, BaseFunction>? RetrieveAndGenerateConfig { get; set; }
            /// <summary>
            /// RetrieveConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-knowledgebaseconfig.html#cfn-bedrock-evaluationjob-knowledgebaseconfig-retrieveconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RetrieveConfig
            /// </summary>
            public Union<Humidifier.Bedrock.EvaluationJobTypes.RetrieveConfig, BaseFunction>? RetrieveConfig { get; set; }
        }

        public class KnowledgeBaseRetrievalConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockEvaluationJobTypesKnowledgeBaseVectorSearchConfigurationVectorSearchConfiguration
        {
            /// <summary>
            /// VectorSearchConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-knowledgebaseretrievalconfiguration.html#cfn-bedrock-evaluationjob-knowledgebaseretrievalconfiguration-vectorsearchconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: KnowledgeBaseVectorSearchConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.EvaluationJobTypes.KnowledgeBaseVectorSearchConfiguration, BaseFunction>? VectorSearchConfiguration { get; set; }
        }

        public class KnowledgeBaseRetrieveAndGenerateConfiguration : Humidifier.Base.BaseSubResource, IHaveModelArn, IHaveBedrockEvaluationJobTypesKnowledgeBaseRetrievalConfigurationRetrievalConfiguration, IHaveKnowledgeBaseId
        {
            /// <summary>
            /// ModelArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-knowledgebaseretrieveandgenerateconfiguration.html#cfn-bedrock-evaluationjob-knowledgebaseretrieveandgenerateconfiguration-modelarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelArn { get; set; }
            /// <summary>
            /// RetrievalConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-knowledgebaseretrieveandgenerateconfiguration.html#cfn-bedrock-evaluationjob-knowledgebaseretrieveandgenerateconfiguration-retrievalconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KnowledgeBaseRetrievalConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.EvaluationJobTypes.KnowledgeBaseRetrievalConfiguration, BaseFunction>? RetrievalConfiguration { get; set; }
            /// <summary>
            /// KnowledgeBaseId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-knowledgebaseretrieveandgenerateconfiguration.html#cfn-bedrock-evaluationjob-knowledgebaseretrieveandgenerateconfiguration-knowledgebaseid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KnowledgeBaseId { get; set; }
        }

        public class KnowledgeBaseVectorSearchConfiguration : Humidifier.Base.BaseSubResource, IHaveNumberOfResults_Integer
        {
            /// <summary>
            /// NumberOfResults
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-knowledgebasevectorsearchconfiguration.html#cfn-bedrock-evaluationjob-knowledgebasevectorsearchconfiguration-numberofresults
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? NumberOfResults { get; set; }
        }

        public class RAGConfig : Humidifier.Base.BaseSubResource, IHaveBedrockEvaluationJobTypesKnowledgeBaseConfigKnowledgeBaseConfig
        {
            /// <summary>
            /// KnowledgeBaseConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-ragconfig.html#cfn-bedrock-evaluationjob-ragconfig-knowledgebaseconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KnowledgeBaseConfig
            /// </summary>
            public Union<Humidifier.Bedrock.EvaluationJobTypes.KnowledgeBaseConfig, BaseFunction>? KnowledgeBaseConfig { get; set; }
        }

        public class RetrieveAndGenerateConfig : Humidifier.Base.BaseSubResource, IHaveType, IHaveBedrockEvaluationJobTypesKnowledgeBaseRetrieveAndGenerateConfigurationKnowledgeBaseConfiguration
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-retrieveandgenerateconfig.html#cfn-bedrock-evaluationjob-retrieveandgenerateconfig-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// KnowledgeBaseConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-retrieveandgenerateconfig.html#cfn-bedrock-evaluationjob-retrieveandgenerateconfig-knowledgebaseconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: KnowledgeBaseRetrieveAndGenerateConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.EvaluationJobTypes.KnowledgeBaseRetrieveAndGenerateConfiguration, BaseFunction>? KnowledgeBaseConfiguration { get; set; }
        }

        public class RetrieveConfig : Humidifier.Base.BaseSubResource, IHaveBedrockEvaluationJobTypesKnowledgeBaseRetrievalConfigurationKnowledgeBaseRetrievalConfiguration, IHaveKnowledgeBaseId
        {
            /// <summary>
            /// KnowledgeBaseRetrievalConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-retrieveconfig.html#cfn-bedrock-evaluationjob-retrieveconfig-knowledgebaseretrievalconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: KnowledgeBaseRetrievalConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.EvaluationJobTypes.KnowledgeBaseRetrievalConfiguration, BaseFunction>? KnowledgeBaseRetrievalConfiguration { get; set; }
            /// <summary>
            /// KnowledgeBaseId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-retrieveconfig.html#cfn-bedrock-evaluationjob-retrieveconfig-knowledgebaseid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KnowledgeBaseId { get; set; }
        }
    }
}