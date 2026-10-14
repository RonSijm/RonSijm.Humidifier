namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using AutoMLJobTypes;

    public class AutoMLJob : Humidifier.Base.BaseResource, IHaveTags, IHaveRoleArn
    {
        public class Attributes
        {
            public static string AutoMLJobStatus =  "AutoMLJobStatus" ;
            public static string EndTime =  "EndTime" ;
            public static string AutoMLJobArn =  "AutoMLJobArn" ;
            public static string AutoMLJobName =  "AutoMLJobName" ;
            public static string CreationTime =  "CreationTime" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string AutoMLJobSecondaryStatus =  "AutoMLJobSecondaryStatus" ;
            public static string AutoMLProblemTypeConfigName =  "AutoMLProblemTypeConfigName" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.AutoMLJob; }
        /// <summary>
        /// AutoMLComputeConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-automljob.html#cfn-sagemaker-automljob-automlcomputeconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: AutoMLComputeConfig
        /// </summary>
        public Humidifier.SageMaker.AutoMLJobTypes.AutoMLComputeConfig AutoMLComputeConfig { get; set; }
        /// <summary>
        /// AutoMLJobInputDataConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-automljob.html#cfn-sagemaker-automljob-automljobinputdataconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: AutoMLJobChannel
        /// </summary>
        public List<Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobChannel> AutoMLJobInputDataConfig { get; set; }
        /// <summary>
        /// OutputDataConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-automljob.html#cfn-sagemaker-automljob-outputdataconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: AutoMLOutputDataConfig
        /// </summary>
        public Humidifier.SageMaker.AutoMLJobTypes.AutoMLOutputDataConfig OutputDataConfig { get; set; }
        /// <summary>
        /// SecurityConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-automljob.html#cfn-sagemaker-automljob-securityconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: AutoMLSecurityConfig
        /// </summary>
        public Humidifier.SageMaker.AutoMLJobTypes.AutoMLSecurityConfig SecurityConfig { get; set; }
        /// <summary>
        /// AutoMLJobObjective
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-automljob.html#cfn-sagemaker-automljob-automljobobjective
        /// Required: False
        /// UpdateType: Immutable
        /// Type: AutoMLJobObjective
        /// </summary>
        public Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobObjective AutoMLJobObjective { get; set; }
        /// <summary>
        /// DataSplitConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-automljob.html#cfn-sagemaker-automljob-datasplitconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: AutoMLDataSplitConfig
        /// </summary>
        public Humidifier.SageMaker.AutoMLJobTypes.AutoMLDataSplitConfig DataSplitConfig { get; set; }
        /// <summary>
        /// AutoMLProblemTypeConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-automljob.html#cfn-sagemaker-automljob-automlproblemtypeconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: AutoMLProblemTypeConfig
        /// </summary>
        public Humidifier.SageMaker.AutoMLJobTypes.AutoMLProblemTypeConfig AutoMLProblemTypeConfig { get; set; }
        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-automljob.html#cfn-sagemaker-automljob-rolearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-automljob.html#cfn-sagemaker-automljob-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace AutoMLJobTypes
    {
        public class AutoMLAlgorithmConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AutoMLAlgorithms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-automlalgorithmconfig.html#cfn-sagemaker-automljob-automlalgorithmconfig-automlalgorithms
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AutoMLAlgorithms { get; set; }
        }

        public class AutoMLComputeConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EmrServerlessComputeConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-automlcomputeconfig.html#cfn-sagemaker-automljob-automlcomputeconfig-emrserverlesscomputeconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: EmrServerlessComputeConfig
            /// </summary>
            public Humidifier.SageMaker.AutoMLJobTypes.EmrServerlessComputeConfig EmrServerlessComputeConfig { get; set; }
        }

        public class AutoMLDataSource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-automldatasource.html#cfn-sagemaker-automljob-automldatasource-s3datasource
            /// Required: True
            /// UpdateType: Immutable
            /// Type: AutoMLS3DataSource
            /// </summary>
            public Humidifier.SageMaker.AutoMLJobTypes.AutoMLS3DataSource S3DataSource { get; set; }
        }

        public class AutoMLDataSplitConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ValidationFraction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-automldatasplitconfig.html#cfn-sagemaker-automljob-automldatasplitconfig-validationfraction
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ValidationFraction { get; set; }
        }

        public class AutoMLJobChannel : Humidifier.Base.BaseSubResource, IHaveContentType, IHaveCompressionType
        {
            /// <summary>
            /// ContentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-automljobchannel.html#cfn-sagemaker-automljob-automljobchannel-contenttype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentType { get; set; }
            /// <summary>
            /// ChannelType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-automljobchannel.html#cfn-sagemaker-automljob-automljobchannel-channeltype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ChannelType { get; set; }
            /// <summary>
            /// CompressionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-automljobchannel.html#cfn-sagemaker-automljob-automljobchannel-compressiontype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CompressionType { get; set; }
            /// <summary>
            /// DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-automljobchannel.html#cfn-sagemaker-automljob-automljobchannel-datasource
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AutoMLDataSource
            /// </summary>
            public Humidifier.SageMaker.AutoMLJobTypes.AutoMLDataSource DataSource { get; set; }
        }

        public class AutoMLJobCompletionCriteria : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MaxAutoMLJobRuntimeInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-automljobcompletioncriteria.html#cfn-sagemaker-automljob-automljobcompletioncriteria-maxautomljobruntimeinseconds
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxAutoMLJobRuntimeInSeconds { get; set; }
            /// <summary>
            /// MaxRuntimePerTrainingJobInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-automljobcompletioncriteria.html#cfn-sagemaker-automljob-automljobcompletioncriteria-maxruntimepertrainingjobinseconds
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxRuntimePerTrainingJobInSeconds { get; set; }
            /// <summary>
            /// MaxCandidates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-automljobcompletioncriteria.html#cfn-sagemaker-automljob-automljobcompletioncriteria-maxcandidates
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxCandidates { get; set; }
        }

        public class AutoMLJobObjective : Humidifier.Base.BaseSubResource, IHaveMetricName
        {
            /// <summary>
            /// MetricName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-automljobobjective.html#cfn-sagemaker-automljob-automljobobjective-metricname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MetricName { get; set; }
        }

        public class AutoMLOutputDataConfig : Humidifier.Base.BaseSubResource, IHaveKmsKeyId, IHaveS3OutputPath
        {
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-automloutputdataconfig.html#cfn-sagemaker-automljob-automloutputdataconfig-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKeyId { get; set; }
            /// <summary>
            /// S3OutputPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-automloutputdataconfig.html#cfn-sagemaker-automljob-automloutputdataconfig-s3outputpath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3OutputPath { get; set; }
        }

        public class AutoMLProblemTypeConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ImageClassificationJobConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-automlproblemtypeconfig.html#cfn-sagemaker-automljob-automlproblemtypeconfig-imageclassificationjobconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ImageClassificationJobConfig
            /// </summary>
            public Humidifier.SageMaker.AutoMLJobTypes.ImageClassificationJobConfig ImageClassificationJobConfig { get; set; }
            /// <summary>
            /// TimeSeriesForecastingJobConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-automlproblemtypeconfig.html#cfn-sagemaker-automljob-automlproblemtypeconfig-timeseriesforecastingjobconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: TimeSeriesForecastingJobConfig
            /// </summary>
            public Humidifier.SageMaker.AutoMLJobTypes.TimeSeriesForecastingJobConfig TimeSeriesForecastingJobConfig { get; set; }
            /// <summary>
            /// TextGenerationJobConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-automlproblemtypeconfig.html#cfn-sagemaker-automljob-automlproblemtypeconfig-textgenerationjobconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: TextGenerationJobConfig
            /// </summary>
            public Humidifier.SageMaker.AutoMLJobTypes.TextGenerationJobConfig TextGenerationJobConfig { get; set; }
            /// <summary>
            /// TextClassificationJobConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-automlproblemtypeconfig.html#cfn-sagemaker-automljob-automlproblemtypeconfig-textclassificationjobconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: TextClassificationJobConfig
            /// </summary>
            public Humidifier.SageMaker.AutoMLJobTypes.TextClassificationJobConfig TextClassificationJobConfig { get; set; }
            /// <summary>
            /// TabularJobConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-automlproblemtypeconfig.html#cfn-sagemaker-automljob-automlproblemtypeconfig-tabularjobconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: TabularJobConfig
            /// </summary>
            public Humidifier.SageMaker.AutoMLJobTypes.TabularJobConfig TabularJobConfig { get; set; }
        }

        public class AutoMLS3DataSource : Humidifier.Base.BaseSubResource, IHaveS3Uri, IHaveS3DataType
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-automls3datasource.html#cfn-sagemaker-automljob-automls3datasource-s3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3Uri { get; set; }
            /// <summary>
            /// S3DataType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-automls3datasource.html#cfn-sagemaker-automljob-automls3datasource-s3datatype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3DataType { get; set; }
        }

        public class AutoMLSecurityConfig : Humidifier.Base.BaseSubResource, IHaveVolumeKmsKeyId, IHaveEnableInterContainerTrafficEncryption
        {
            /// <summary>
            /// EnableInterContainerTrafficEncryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-automlsecurityconfig.html#cfn-sagemaker-automljob-automlsecurityconfig-enableintercontainertrafficencryption
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EnableInterContainerTrafficEncryption { get; set; }
            /// <summary>
            /// VpcConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-automlsecurityconfig.html#cfn-sagemaker-automljob-automlsecurityconfig-vpcconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: VpcConfig
            /// </summary>
            public Humidifier.SageMaker.AutoMLJobTypes.VpcConfig VpcConfig { get; set; }
            /// <summary>
            /// VolumeKmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-automlsecurityconfig.html#cfn-sagemaker-automljob-automlsecurityconfig-volumekmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VolumeKmsKeyId { get; set; }
        }

        public class CandidateGenerationConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AlgorithmsConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-candidategenerationconfig.html#cfn-sagemaker-automljob-candidategenerationconfig-algorithmsconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: AutoMLAlgorithmConfig
            /// </summary>
            public List<Humidifier.SageMaker.AutoMLJobTypes.AutoMLAlgorithmConfig> AlgorithmsConfig { get; set; }
        }

        public class EmrServerlessComputeConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ExecutionRoleARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-emrserverlesscomputeconfig.html#cfn-sagemaker-automljob-emrserverlesscomputeconfig-executionrolearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExecutionRoleARN { get; set; }
        }

        public class HolidayConfigAttributes : Humidifier.Base.BaseSubResource, IHaveCountryCode
        {
            /// <summary>
            /// CountryCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-holidayconfigattributes.html#cfn-sagemaker-automljob-holidayconfigattributes-countrycode
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CountryCode { get; set; }
        }

        public class ImageClassificationJobConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CompletionCriteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-imageclassificationjobconfig.html#cfn-sagemaker-automljob-imageclassificationjobconfig-completioncriteria
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AutoMLJobCompletionCriteria
            /// </summary>
            public Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobCompletionCriteria CompletionCriteria { get; set; }
        }

        public class ModelAccessConfig : Humidifier.Base.BaseSubResource, IHaveAcceptEula
        {
            /// <summary>
            /// AcceptEula
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-modelaccessconfig.html#cfn-sagemaker-automljob-modelaccessconfig-accepteula
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AcceptEula { get; set; }
        }

        public class TabularJobConfig : Humidifier.Base.BaseSubResource, IHaveMode, IHaveProblemType
        {
            /// <summary>
            /// CandidateGenerationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-tabularjobconfig.html#cfn-sagemaker-automljob-tabularjobconfig-candidategenerationconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CandidateGenerationConfig
            /// </summary>
            public Humidifier.SageMaker.AutoMLJobTypes.CandidateGenerationConfig CandidateGenerationConfig { get; set; }
            /// <summary>
            /// FeatureSpecificationS3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-tabularjobconfig.html#cfn-sagemaker-automljob-tabularjobconfig-featurespecifications3uri
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FeatureSpecificationS3Uri { get; set; }
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-tabularjobconfig.html#cfn-sagemaker-automljob-tabularjobconfig-mode
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Mode { get; set; }
            /// <summary>
            /// ProblemType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-tabularjobconfig.html#cfn-sagemaker-automljob-tabularjobconfig-problemtype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ProblemType { get; set; }
            /// <summary>
            /// TargetAttributeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-tabularjobconfig.html#cfn-sagemaker-automljob-tabularjobconfig-targetattributename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetAttributeName { get; set; }
            /// <summary>
            /// SampleWeightAttributeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-tabularjobconfig.html#cfn-sagemaker-automljob-tabularjobconfig-sampleweightattributename
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SampleWeightAttributeName { get; set; }
            /// <summary>
            /// CompletionCriteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-tabularjobconfig.html#cfn-sagemaker-automljob-tabularjobconfig-completioncriteria
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AutoMLJobCompletionCriteria
            /// </summary>
            public Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobCompletionCriteria CompletionCriteria { get; set; }
            /// <summary>
            /// GenerateCandidateDefinitionsOnly
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-tabularjobconfig.html#cfn-sagemaker-automljob-tabularjobconfig-generatecandidatedefinitionsonly
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic GenerateCandidateDefinitionsOnly { get; set; }
        }

        public class TextClassificationJobConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TargetLabelColumn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-textclassificationjobconfig.html#cfn-sagemaker-automljob-textclassificationjobconfig-targetlabelcolumn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetLabelColumn { get; set; }
            /// <summary>
            /// CompletionCriteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-textclassificationjobconfig.html#cfn-sagemaker-automljob-textclassificationjobconfig-completioncriteria
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AutoMLJobCompletionCriteria
            /// </summary>
            public Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobCompletionCriteria CompletionCriteria { get; set; }
            /// <summary>
            /// ContentColumn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-textclassificationjobconfig.html#cfn-sagemaker-automljob-textclassificationjobconfig-contentcolumn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentColumn { get; set; }
        }

        public class TextGenerationJobConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TextGenerationHyperParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-textgenerationjobconfig.html#cfn-sagemaker-automljob-textgenerationjobconfig-textgenerationhyperparameters
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> TextGenerationHyperParameters { get; set; }
            /// <summary>
            /// ModelAccessConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-textgenerationjobconfig.html#cfn-sagemaker-automljob-textgenerationjobconfig-modelaccessconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ModelAccessConfig
            /// </summary>
            public Humidifier.SageMaker.AutoMLJobTypes.ModelAccessConfig ModelAccessConfig { get; set; }
            /// <summary>
            /// BaseModelName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-textgenerationjobconfig.html#cfn-sagemaker-automljob-textgenerationjobconfig-basemodelname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BaseModelName { get; set; }
            /// <summary>
            /// CompletionCriteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-textgenerationjobconfig.html#cfn-sagemaker-automljob-textgenerationjobconfig-completioncriteria
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AutoMLJobCompletionCriteria
            /// </summary>
            public Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobCompletionCriteria CompletionCriteria { get; set; }
        }

        public class TimeSeriesConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// GroupingAttributeNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-timeseriesconfig.html#cfn-sagemaker-automljob-timeseriesconfig-groupingattributenames
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic GroupingAttributeNames { get; set; }
            /// <summary>
            /// TargetAttributeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-timeseriesconfig.html#cfn-sagemaker-automljob-timeseriesconfig-targetattributename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetAttributeName { get; set; }
            /// <summary>
            /// TimestampAttributeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-timeseriesconfig.html#cfn-sagemaker-automljob-timeseriesconfig-timestampattributename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimestampAttributeName { get; set; }
            /// <summary>
            /// ItemIdentifierAttributeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-timeseriesconfig.html#cfn-sagemaker-automljob-timeseriesconfig-itemidentifierattributename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ItemIdentifierAttributeName { get; set; }
        }

        public class TimeSeriesForecastingJobConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CandidateGenerationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-timeseriesforecastingjobconfig.html#cfn-sagemaker-automljob-timeseriesforecastingjobconfig-candidategenerationconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CandidateGenerationConfig
            /// </summary>
            public Humidifier.SageMaker.AutoMLJobTypes.CandidateGenerationConfig CandidateGenerationConfig { get; set; }
            /// <summary>
            /// FeatureSpecificationS3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-timeseriesforecastingjobconfig.html#cfn-sagemaker-automljob-timeseriesforecastingjobconfig-featurespecifications3uri
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FeatureSpecificationS3Uri { get; set; }
            /// <summary>
            /// ForecastQuantiles
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-timeseriesforecastingjobconfig.html#cfn-sagemaker-automljob-timeseriesforecastingjobconfig-forecastquantiles
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ForecastQuantiles { get; set; }
            /// <summary>
            /// HolidayConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-timeseriesforecastingjobconfig.html#cfn-sagemaker-automljob-timeseriesforecastingjobconfig-holidayconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: HolidayConfigAttributes
            /// </summary>
            public List<Humidifier.SageMaker.AutoMLJobTypes.HolidayConfigAttributes> HolidayConfig { get; set; }
            /// <summary>
            /// ForecastHorizon
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-timeseriesforecastingjobconfig.html#cfn-sagemaker-automljob-timeseriesforecastingjobconfig-forecasthorizon
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ForecastHorizon { get; set; }
            /// <summary>
            /// CompletionCriteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-timeseriesforecastingjobconfig.html#cfn-sagemaker-automljob-timeseriesforecastingjobconfig-completioncriteria
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AutoMLJobCompletionCriteria
            /// </summary>
            public Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobCompletionCriteria CompletionCriteria { get; set; }
            /// <summary>
            /// Transformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-timeseriesforecastingjobconfig.html#cfn-sagemaker-automljob-timeseriesforecastingjobconfig-transformations
            /// Required: False
            /// UpdateType: Immutable
            /// Type: TimeSeriesTransformations
            /// </summary>
            public Humidifier.SageMaker.AutoMLJobTypes.TimeSeriesTransformations Transformations { get; set; }
            /// <summary>
            /// TimeSeriesConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-timeseriesforecastingjobconfig.html#cfn-sagemaker-automljob-timeseriesforecastingjobconfig-timeseriesconfig
            /// Required: True
            /// UpdateType: Immutable
            /// Type: TimeSeriesConfig
            /// </summary>
            public Humidifier.SageMaker.AutoMLJobTypes.TimeSeriesConfig TimeSeriesConfig { get; set; }
            /// <summary>
            /// ForecastFrequency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-timeseriesforecastingjobconfig.html#cfn-sagemaker-automljob-timeseriesforecastingjobconfig-forecastfrequency
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ForecastFrequency { get; set; }
        }

        public class TimeSeriesTransformations : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Aggregation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-timeseriestransformations.html#cfn-sagemaker-automljob-timeseriestransformations-aggregation
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> Aggregation { get; set; }
            /// <summary>
            /// Filling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-timeseriestransformations.html#cfn-sagemaker-automljob-timeseriestransformations-filling
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Filling { get; set; }
        }

        public class VpcConfig : Humidifier.Base.BaseSubResource, IHaveSecurityGroupIds, IHaveSubnets
        {
            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-vpcconfig.html#cfn-sagemaker-automljob-vpcconfig-subnets
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Subnets { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-vpcconfig.html#cfn-sagemaker-automljob-vpcconfig-securitygroupids
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroupIds { get; set; }
        }
    }
}