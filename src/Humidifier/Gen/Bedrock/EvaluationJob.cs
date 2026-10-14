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
        public class AutomatedEvaluationConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EvaluatorModelConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-automatedevaluationconfig.html#cfn-bedrock-evaluationjob-automatedevaluationconfig-evaluatormodelconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluatorModelConfig
            /// </summary>
            public Humidifier.Bedrock.EvaluationJobTypes.EvaluatorModelConfig EvaluatorModelConfig { get; set; }
            /// <summary>
            /// DatasetMetricConfigs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-automatedevaluationconfig.html#cfn-bedrock-evaluationjob-automatedevaluationconfig-datasetmetricconfigs
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EvaluationDatasetMetricConfig
            /// </summary>
            public List<Humidifier.Bedrock.EvaluationJobTypes.EvaluationDatasetMetricConfig> DatasetMetricConfigs { get; set; }
        }

        public class BedrockEvaluatorModel : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ModelIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-bedrockevaluatormodel.html#cfn-bedrock-evaluationjob-bedrockevaluatormodel-modelidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ModelIdentifier { get; set; }
        }

        public class EvaluationBedrockModel : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// InferenceParams
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-evaluationbedrockmodel.html#cfn-bedrock-evaluationjob-evaluationbedrockmodel-inferenceparams
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InferenceParams { get; set; }
            /// <summary>
            /// ModelIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-evaluationbedrockmodel.html#cfn-bedrock-evaluationjob-evaluationbedrockmodel-modelidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ModelIdentifier { get; set; }
        }

        public class EvaluationConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Human
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-evaluationconfig.html#cfn-bedrock-evaluationjob-evaluationconfig-human
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HumanEvaluationConfig
            /// </summary>
            public Humidifier.Bedrock.EvaluationJobTypes.HumanEvaluationConfig Human { get; set; }
            /// <summary>
            /// Automated
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-evaluationconfig.html#cfn-bedrock-evaluationjob-evaluationconfig-automated
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AutomatedEvaluationConfig
            /// </summary>
            public Humidifier.Bedrock.EvaluationJobTypes.AutomatedEvaluationConfig Automated { get; set; }
        }

        public class EvaluationDataset : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-evaluationdataset.html#cfn-bedrock-evaluationjob-evaluationdataset-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
            /// <summary>
            /// DatasetLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-evaluationdataset.html#cfn-bedrock-evaluationjob-evaluationdataset-datasetlocation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluationDatasetLocation
            /// </summary>
            public Humidifier.Bedrock.EvaluationJobTypes.EvaluationDatasetLocation DatasetLocation { get; set; }
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
            public dynamic S3Uri { get; set; }
        }

        public class EvaluationDatasetMetricConfig : Humidifier.Base.BaseSubResource, IHaveTaskType
        {
            /// <summary>
            /// Dataset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-evaluationdatasetmetricconfig.html#cfn-bedrock-evaluationjob-evaluationdatasetmetricconfig-dataset
            /// Required: True
            /// UpdateType: Mutable
            /// Type: EvaluationDataset
            /// </summary>
            public Humidifier.Bedrock.EvaluationJobTypes.EvaluationDataset Dataset { get; set; }
            /// <summary>
            /// MetricNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-evaluationdatasetmetricconfig.html#cfn-bedrock-evaluationjob-evaluationdatasetmetricconfig-metricnames
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic MetricNames { get; set; }
            /// <summary>
            /// TaskType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-evaluationdatasetmetricconfig.html#cfn-bedrock-evaluationjob-evaluationdatasetmetricconfig-tasktype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TaskType { get; set; }
        }

        public class EvaluationInferenceConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Models
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-evaluationinferenceconfig.html#cfn-bedrock-evaluationjob-evaluationinferenceconfig-models
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EvaluationModelConfig
            /// </summary>
            public List<Humidifier.Bedrock.EvaluationJobTypes.EvaluationModelConfig> Models { get; set; }
            /// <summary>
            /// RagConfigs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-evaluationinferenceconfig.html#cfn-bedrock-evaluationjob-evaluationinferenceconfig-ragconfigs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RAGConfig
            /// </summary>
            public List<Humidifier.Bedrock.EvaluationJobTypes.RAGConfig> RagConfigs { get; set; }
        }

        public class EvaluationModelConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// BedrockModel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-evaluationmodelconfig.html#cfn-bedrock-evaluationjob-evaluationmodelconfig-bedrockmodel
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EvaluationBedrockModel
            /// </summary>
            public Humidifier.Bedrock.EvaluationJobTypes.EvaluationBedrockModel BedrockModel { get; set; }
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
            public dynamic S3Uri { get; set; }
        }

        public class EvaluatorModelConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// BedrockEvaluatorModels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-evaluatormodelconfig.html#cfn-bedrock-evaluationjob-evaluatormodelconfig-bedrockevaluatormodels
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: BedrockEvaluatorModel
            /// </summary>
            public List<Humidifier.Bedrock.EvaluationJobTypes.BedrockEvaluatorModel> BedrockEvaluatorModels { get; set; }
        }

        public class HumanEvaluationConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// HumanWorkflowConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-humanevaluationconfig.html#cfn-bedrock-evaluationjob-humanevaluationconfig-humanworkflowconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HumanWorkflowConfig
            /// </summary>
            public Humidifier.Bedrock.EvaluationJobTypes.HumanWorkflowConfig HumanWorkflowConfig { get; set; }
            /// <summary>
            /// DatasetMetricConfigs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-humanevaluationconfig.html#cfn-bedrock-evaluationjob-humanevaluationconfig-datasetmetricconfigs
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EvaluationDatasetMetricConfig
            /// </summary>
            public List<Humidifier.Bedrock.EvaluationJobTypes.EvaluationDatasetMetricConfig> DatasetMetricConfigs { get; set; }
            /// <summary>
            /// CustomMetrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-humanevaluationconfig.html#cfn-bedrock-evaluationjob-humanevaluationconfig-custommetrics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: HumanEvaluationCustomMetric
            /// </summary>
            public List<Humidifier.Bedrock.EvaluationJobTypes.HumanEvaluationCustomMetric> CustomMetrics { get; set; }
        }

        public class HumanEvaluationCustomMetric : Humidifier.Base.BaseSubResource, IHaveName, IHaveDescription
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-humanevaluationcustommetric.html#cfn-bedrock-evaluationjob-humanevaluationcustommetric-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// RatingMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-humanevaluationcustommetric.html#cfn-bedrock-evaluationjob-humanevaluationcustommetric-ratingmethod
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RatingMethod { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-humanevaluationcustommetric.html#cfn-bedrock-evaluationjob-humanevaluationcustommetric-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class HumanWorkflowConfig : Humidifier.Base.BaseSubResource, IHaveInstructions
        {
            /// <summary>
            /// FlowDefinitionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-humanworkflowconfig.html#cfn-bedrock-evaluationjob-humanworkflowconfig-flowdefinitionarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FlowDefinitionArn { get; set; }
            /// <summary>
            /// Instructions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-humanworkflowconfig.html#cfn-bedrock-evaluationjob-humanworkflowconfig-instructions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Instructions { get; set; }
        }

        public class KnowledgeBaseConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RetrieveAndGenerateConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-knowledgebaseconfig.html#cfn-bedrock-evaluationjob-knowledgebaseconfig-retrieveandgenerateconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RetrieveAndGenerateConfig
            /// </summary>
            public Humidifier.Bedrock.EvaluationJobTypes.RetrieveAndGenerateConfig RetrieveAndGenerateConfig { get; set; }
            /// <summary>
            /// RetrieveConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-knowledgebaseconfig.html#cfn-bedrock-evaluationjob-knowledgebaseconfig-retrieveconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RetrieveConfig
            /// </summary>
            public Humidifier.Bedrock.EvaluationJobTypes.RetrieveConfig RetrieveConfig { get; set; }
        }

        public class KnowledgeBaseRetrievalConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// VectorSearchConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-knowledgebaseretrievalconfiguration.html#cfn-bedrock-evaluationjob-knowledgebaseretrievalconfiguration-vectorsearchconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: KnowledgeBaseVectorSearchConfiguration
            /// </summary>
            public Humidifier.Bedrock.EvaluationJobTypes.KnowledgeBaseVectorSearchConfiguration VectorSearchConfiguration { get; set; }
        }

        public class KnowledgeBaseRetrieveAndGenerateConfiguration : Humidifier.Base.BaseSubResource, IHaveKnowledgeBaseId, IHaveModelArn
        {
            /// <summary>
            /// ModelArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-knowledgebaseretrieveandgenerateconfiguration.html#cfn-bedrock-evaluationjob-knowledgebaseretrieveandgenerateconfiguration-modelarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ModelArn { get; set; }
            /// <summary>
            /// RetrievalConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-knowledgebaseretrieveandgenerateconfiguration.html#cfn-bedrock-evaluationjob-knowledgebaseretrieveandgenerateconfiguration-retrievalconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KnowledgeBaseRetrievalConfiguration
            /// </summary>
            public Humidifier.Bedrock.EvaluationJobTypes.KnowledgeBaseRetrievalConfiguration RetrievalConfiguration { get; set; }
            /// <summary>
            /// KnowledgeBaseId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-knowledgebaseretrieveandgenerateconfiguration.html#cfn-bedrock-evaluationjob-knowledgebaseretrieveandgenerateconfiguration-knowledgebaseid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KnowledgeBaseId { get; set; }
        }

        public class KnowledgeBaseVectorSearchConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// NumberOfResults
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-knowledgebasevectorsearchconfiguration.html#cfn-bedrock-evaluationjob-knowledgebasevectorsearchconfiguration-numberofresults
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic NumberOfResults { get; set; }
        }

        public class RAGConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// KnowledgeBaseConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-ragconfig.html#cfn-bedrock-evaluationjob-ragconfig-knowledgebaseconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KnowledgeBaseConfig
            /// </summary>
            public Humidifier.Bedrock.EvaluationJobTypes.KnowledgeBaseConfig KnowledgeBaseConfig { get; set; }
        }

        public class RetrieveAndGenerateConfig : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-retrieveandgenerateconfig.html#cfn-bedrock-evaluationjob-retrieveandgenerateconfig-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// KnowledgeBaseConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-retrieveandgenerateconfig.html#cfn-bedrock-evaluationjob-retrieveandgenerateconfig-knowledgebaseconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: KnowledgeBaseRetrieveAndGenerateConfiguration
            /// </summary>
            public Humidifier.Bedrock.EvaluationJobTypes.KnowledgeBaseRetrieveAndGenerateConfiguration KnowledgeBaseConfiguration { get; set; }
        }

        public class RetrieveConfig : Humidifier.Base.BaseSubResource, IHaveKnowledgeBaseId
        {
            /// <summary>
            /// KnowledgeBaseRetrievalConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-retrieveconfig.html#cfn-bedrock-evaluationjob-retrieveconfig-knowledgebaseretrievalconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: KnowledgeBaseRetrievalConfiguration
            /// </summary>
            public Humidifier.Bedrock.EvaluationJobTypes.KnowledgeBaseRetrievalConfiguration KnowledgeBaseRetrievalConfiguration { get; set; }
            /// <summary>
            /// KnowledgeBaseId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-evaluationjob-retrieveconfig.html#cfn-bedrock-evaluationjob-retrieveconfig-knowledgebaseid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KnowledgeBaseId { get; set; }
        }
    }
}