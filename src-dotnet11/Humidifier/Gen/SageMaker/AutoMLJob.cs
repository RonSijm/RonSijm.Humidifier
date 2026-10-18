namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using AutoMLJobTypes;

    public class AutoMLJob : Humidifier.Base.BaseResource, IHaveTags, IHaveSageMakerAutoMLJobTypesAutoMLComputeConfigAutoMLComputeConfig, IHaveListOfSageMakerAutoMLJobTypesAutoMLJobChannelAutoMLJobInputDataConfig, IHaveSageMakerAutoMLJobTypesAutoMLOutputDataConfigOutputDataConfig, IHaveSageMakerAutoMLJobTypesAutoMLSecurityConfigSecurityConfig, IHaveSageMakerAutoMLJobTypesAutoMLJobObjectiveAutoMLJobObjective, IHaveSageMakerAutoMLJobTypesAutoMLDataSplitConfigDataSplitConfig, IHaveSageMakerAutoMLJobTypesAutoMLProblemTypeConfigAutoMLProblemTypeConfig, IHaveRoleArn
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
        public Union<Humidifier.SageMaker.AutoMLJobTypes.AutoMLComputeConfig, BaseFunction>? AutoMLComputeConfig { get; set; }
        /// <summary>
        /// AutoMLJobInputDataConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-automljob.html#cfn-sagemaker-automljob-automljobinputdataconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: AutoMLJobChannel
        /// </summary>
        public Union<IReadOnlyList<Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobChannel>, IReadOnlyList<Union<Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobChannel, BaseFunction>>, BaseFunction>? AutoMLJobInputDataConfig { get; set; }
        /// <summary>
        /// OutputDataConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-automljob.html#cfn-sagemaker-automljob-outputdataconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: AutoMLOutputDataConfig
        /// </summary>
        public Union<Humidifier.SageMaker.AutoMLJobTypes.AutoMLOutputDataConfig, BaseFunction>? OutputDataConfig { get; set; }
        /// <summary>
        /// SecurityConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-automljob.html#cfn-sagemaker-automljob-securityconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: AutoMLSecurityConfig
        /// </summary>
        public Union<Humidifier.SageMaker.AutoMLJobTypes.AutoMLSecurityConfig, BaseFunction>? SecurityConfig { get; set; }
        /// <summary>
        /// AutoMLJobObjective
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-automljob.html#cfn-sagemaker-automljob-automljobobjective
        /// Required: False
        /// UpdateType: Immutable
        /// Type: AutoMLJobObjective
        /// </summary>
        public Union<Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobObjective, BaseFunction>? AutoMLJobObjective { get; set; }
        /// <summary>
        /// DataSplitConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-automljob.html#cfn-sagemaker-automljob-datasplitconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: AutoMLDataSplitConfig
        /// </summary>
        public Union<Humidifier.SageMaker.AutoMLJobTypes.AutoMLDataSplitConfig, BaseFunction>? DataSplitConfig { get; set; }
        /// <summary>
        /// AutoMLProblemTypeConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-automljob.html#cfn-sagemaker-automljob-automlproblemtypeconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: AutoMLProblemTypeConfig
        /// </summary>
        public Union<Humidifier.SageMaker.AutoMLJobTypes.AutoMLProblemTypeConfig, BaseFunction>? AutoMLProblemTypeConfig { get; set; }
        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-automljob.html#cfn-sagemaker-automljob-rolearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-automljob.html#cfn-sagemaker-automljob-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace AutoMLJobTypes
    {
        public class AutoMLAlgorithmConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfAutoMLAlgorithms
        {
            /// <summary>
            /// AutoMLAlgorithms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-automlalgorithmconfig.html#cfn-sagemaker-automljob-automlalgorithmconfig-automlalgorithms
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AutoMLAlgorithms { get; set; }
        }

        public class AutoMLComputeConfig : Humidifier.Base.BaseSubResource, IHaveSageMakerAutoMLJobTypesEmrServerlessComputeConfigEmrServerlessComputeConfig
        {
            /// <summary>
            /// EmrServerlessComputeConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-automlcomputeconfig.html#cfn-sagemaker-automljob-automlcomputeconfig-emrserverlesscomputeconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: EmrServerlessComputeConfig
            /// </summary>
            public Union<Humidifier.SageMaker.AutoMLJobTypes.EmrServerlessComputeConfig, BaseFunction>? EmrServerlessComputeConfig { get; set; }
        }

        public class AutoMLDataSource : Humidifier.Base.BaseSubResource, IHaveSageMakerAutoMLJobTypesAutoMLS3DataSourceS3DataSource
        {
            /// <summary>
            /// S3DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-automldatasource.html#cfn-sagemaker-automljob-automldatasource-s3datasource
            /// Required: True
            /// UpdateType: Immutable
            /// Type: AutoMLS3DataSource
            /// </summary>
            public Union<Humidifier.SageMaker.AutoMLJobTypes.AutoMLS3DataSource, BaseFunction>? S3DataSource { get; set; }
        }

        public class AutoMLDataSplitConfig : Humidifier.Base.BaseSubResource, IHaveValidationFraction_Double
        {
            /// <summary>
            /// ValidationFraction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-automldatasplitconfig.html#cfn-sagemaker-automljob-automldatasplitconfig-validationfraction
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? ValidationFraction { get; set; }
        }

        public class AutoMLJobChannel : Humidifier.Base.BaseSubResource, IHaveContentType, IHaveChannelType, IHaveCompressionType, IHaveSageMakerAutoMLJobTypesAutoMLDataSourceDataSource
        {
            /// <summary>
            /// ContentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-automljobchannel.html#cfn-sagemaker-automljob-automljobchannel-contenttype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContentType { get; set; }
            /// <summary>
            /// ChannelType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-automljobchannel.html#cfn-sagemaker-automljob-automljobchannel-channeltype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ChannelType { get; set; }
            /// <summary>
            /// CompressionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-automljobchannel.html#cfn-sagemaker-automljob-automljobchannel-compressiontype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CompressionType { get; set; }
            /// <summary>
            /// DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-automljobchannel.html#cfn-sagemaker-automljob-automljobchannel-datasource
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AutoMLDataSource
            /// </summary>
            public Union<Humidifier.SageMaker.AutoMLJobTypes.AutoMLDataSource, BaseFunction>? DataSource { get; set; }
        }

        public class AutoMLJobCompletionCriteria : Humidifier.Base.BaseSubResource, IHaveMaxAutoMLJobRuntimeInSeconds_Integer, IHaveMaxRuntimePerTrainingJobInSeconds_Integer, IHaveMaxCandidates_Integer
        {
            /// <summary>
            /// MaxAutoMLJobRuntimeInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-automljobcompletioncriteria.html#cfn-sagemaker-automljob-automljobcompletioncriteria-maxautomljobruntimeinseconds
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxAutoMLJobRuntimeInSeconds { get; set; }
            /// <summary>
            /// MaxRuntimePerTrainingJobInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-automljobcompletioncriteria.html#cfn-sagemaker-automljob-automljobcompletioncriteria-maxruntimepertrainingjobinseconds
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxRuntimePerTrainingJobInSeconds { get; set; }
            /// <summary>
            /// MaxCandidates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-automljobcompletioncriteria.html#cfn-sagemaker-automljob-automljobcompletioncriteria-maxcandidates
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxCandidates { get; set; }
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
            public Union<string, BaseFunction>? MetricName { get; set; }
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
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
            /// <summary>
            /// S3OutputPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-automloutputdataconfig.html#cfn-sagemaker-automljob-automloutputdataconfig-s3outputpath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3OutputPath { get; set; }
        }

        public class AutoMLProblemTypeConfig : Humidifier.Base.BaseSubResource, IHaveSageMakerAutoMLJobTypesImageClassificationJobConfigImageClassificationJobConfig, IHaveSageMakerAutoMLJobTypesTimeSeriesForecastingJobConfigTimeSeriesForecastingJobConfig, IHaveSageMakerAutoMLJobTypesTextGenerationJobConfigTextGenerationJobConfig, IHaveSageMakerAutoMLJobTypesTextClassificationJobConfigTextClassificationJobConfig, IHaveSageMakerAutoMLJobTypesTabularJobConfigTabularJobConfig
        {
            /// <summary>
            /// ImageClassificationJobConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-automlproblemtypeconfig.html#cfn-sagemaker-automljob-automlproblemtypeconfig-imageclassificationjobconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ImageClassificationJobConfig
            /// </summary>
            public Union<Humidifier.SageMaker.AutoMLJobTypes.ImageClassificationJobConfig, BaseFunction>? ImageClassificationJobConfig { get; set; }
            /// <summary>
            /// TimeSeriesForecastingJobConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-automlproblemtypeconfig.html#cfn-sagemaker-automljob-automlproblemtypeconfig-timeseriesforecastingjobconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: TimeSeriesForecastingJobConfig
            /// </summary>
            public Union<Humidifier.SageMaker.AutoMLJobTypes.TimeSeriesForecastingJobConfig, BaseFunction>? TimeSeriesForecastingJobConfig { get; set; }
            /// <summary>
            /// TextGenerationJobConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-automlproblemtypeconfig.html#cfn-sagemaker-automljob-automlproblemtypeconfig-textgenerationjobconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: TextGenerationJobConfig
            /// </summary>
            public Union<Humidifier.SageMaker.AutoMLJobTypes.TextGenerationJobConfig, BaseFunction>? TextGenerationJobConfig { get; set; }
            /// <summary>
            /// TextClassificationJobConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-automlproblemtypeconfig.html#cfn-sagemaker-automljob-automlproblemtypeconfig-textclassificationjobconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: TextClassificationJobConfig
            /// </summary>
            public Union<Humidifier.SageMaker.AutoMLJobTypes.TextClassificationJobConfig, BaseFunction>? TextClassificationJobConfig { get; set; }
            /// <summary>
            /// TabularJobConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-automlproblemtypeconfig.html#cfn-sagemaker-automljob-automlproblemtypeconfig-tabularjobconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: TabularJobConfig
            /// </summary>
            public Union<Humidifier.SageMaker.AutoMLJobTypes.TabularJobConfig, BaseFunction>? TabularJobConfig { get; set; }
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
            public Union<string, BaseFunction>? S3Uri { get; set; }
            /// <summary>
            /// S3DataType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-automls3datasource.html#cfn-sagemaker-automljob-automls3datasource-s3datatype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3DataType { get; set; }
        }

        public class AutoMLSecurityConfig : Humidifier.Base.BaseSubResource, IHaveEnableInterContainerTrafficEncryption_Boolean, IHaveSageMakerAutoMLJobTypesVpcConfigVpcConfig, IHaveVolumeKmsKeyId
        {
            /// <summary>
            /// EnableInterContainerTrafficEncryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-automlsecurityconfig.html#cfn-sagemaker-automljob-automlsecurityconfig-enableintercontainertrafficencryption
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableInterContainerTrafficEncryption { get; set; }
            /// <summary>
            /// VpcConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-automlsecurityconfig.html#cfn-sagemaker-automljob-automlsecurityconfig-vpcconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: VpcConfig
            /// </summary>
            public Union<Humidifier.SageMaker.AutoMLJobTypes.VpcConfig, BaseFunction>? VpcConfig { get; set; }
            /// <summary>
            /// VolumeKmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-automlsecurityconfig.html#cfn-sagemaker-automljob-automlsecurityconfig-volumekmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VolumeKmsKeyId { get; set; }
        }

        public class CandidateGenerationConfig : Humidifier.Base.BaseSubResource, IHaveListOfSageMakerAutoMLJobTypesAutoMLAlgorithmConfigAlgorithmsConfig
        {
            /// <summary>
            /// AlgorithmsConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-candidategenerationconfig.html#cfn-sagemaker-automljob-candidategenerationconfig-algorithmsconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: AutoMLAlgorithmConfig
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.AutoMLJobTypes.AutoMLAlgorithmConfig>, IReadOnlyList<Union<Humidifier.SageMaker.AutoMLJobTypes.AutoMLAlgorithmConfig, BaseFunction>>, BaseFunction>? AlgorithmsConfig { get; set; }
        }

        public class EmrServerlessComputeConfig : Humidifier.Base.BaseSubResource, IHaveExecutionRoleARN
        {
            /// <summary>
            /// ExecutionRoleARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-emrserverlesscomputeconfig.html#cfn-sagemaker-automljob-emrserverlesscomputeconfig-executionrolearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExecutionRoleARN { get; set; }
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
            public Union<string, BaseFunction>? CountryCode { get; set; }
        }

        public class ImageClassificationJobConfig : Humidifier.Base.BaseSubResource, IHaveSageMakerAutoMLJobTypesAutoMLJobCompletionCriteriaCompletionCriteria
        {
            /// <summary>
            /// CompletionCriteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-imageclassificationjobconfig.html#cfn-sagemaker-automljob-imageclassificationjobconfig-completioncriteria
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AutoMLJobCompletionCriteria
            /// </summary>
            public Union<Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobCompletionCriteria, BaseFunction>? CompletionCriteria { get; set; }
        }

        public class ModelAccessConfig : Humidifier.Base.BaseSubResource, IHaveAcceptEula_Boolean
        {
            /// <summary>
            /// AcceptEula
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-modelaccessconfig.html#cfn-sagemaker-automljob-modelaccessconfig-accepteula
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AcceptEula { get; set; }
        }

        public class TabularJobConfig : Humidifier.Base.BaseSubResource, IHaveSageMakerAutoMLJobTypesCandidateGenerationConfigCandidateGenerationConfig, IHaveFeatureSpecificationS3Uri, IHaveMode, IHaveProblemType, IHaveTargetAttributeName, IHaveSampleWeightAttributeName, IHaveSageMakerAutoMLJobTypesAutoMLJobCompletionCriteriaCompletionCriteria, IHaveGenerateCandidateDefinitionsOnly_Boolean
        {
            /// <summary>
            /// CandidateGenerationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-tabularjobconfig.html#cfn-sagemaker-automljob-tabularjobconfig-candidategenerationconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CandidateGenerationConfig
            /// </summary>
            public Union<Humidifier.SageMaker.AutoMLJobTypes.CandidateGenerationConfig, BaseFunction>? CandidateGenerationConfig { get; set; }
            /// <summary>
            /// FeatureSpecificationS3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-tabularjobconfig.html#cfn-sagemaker-automljob-tabularjobconfig-featurespecifications3uri
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FeatureSpecificationS3Uri { get; set; }
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-tabularjobconfig.html#cfn-sagemaker-automljob-tabularjobconfig-mode
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Mode { get; set; }
            /// <summary>
            /// ProblemType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-tabularjobconfig.html#cfn-sagemaker-automljob-tabularjobconfig-problemtype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProblemType { get; set; }
            /// <summary>
            /// TargetAttributeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-tabularjobconfig.html#cfn-sagemaker-automljob-tabularjobconfig-targetattributename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetAttributeName { get; set; }
            /// <summary>
            /// SampleWeightAttributeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-tabularjobconfig.html#cfn-sagemaker-automljob-tabularjobconfig-sampleweightattributename
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SampleWeightAttributeName { get; set; }
            /// <summary>
            /// CompletionCriteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-tabularjobconfig.html#cfn-sagemaker-automljob-tabularjobconfig-completioncriteria
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AutoMLJobCompletionCriteria
            /// </summary>
            public Union<Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobCompletionCriteria, BaseFunction>? CompletionCriteria { get; set; }
            /// <summary>
            /// GenerateCandidateDefinitionsOnly
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-tabularjobconfig.html#cfn-sagemaker-automljob-tabularjobconfig-generatecandidatedefinitionsonly
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? GenerateCandidateDefinitionsOnly { get; set; }
        }

        public class TextClassificationJobConfig : Humidifier.Base.BaseSubResource, IHaveTargetLabelColumn, IHaveSageMakerAutoMLJobTypesAutoMLJobCompletionCriteriaCompletionCriteria, IHaveContentColumn
        {
            /// <summary>
            /// TargetLabelColumn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-textclassificationjobconfig.html#cfn-sagemaker-automljob-textclassificationjobconfig-targetlabelcolumn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetLabelColumn { get; set; }
            /// <summary>
            /// CompletionCriteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-textclassificationjobconfig.html#cfn-sagemaker-automljob-textclassificationjobconfig-completioncriteria
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AutoMLJobCompletionCriteria
            /// </summary>
            public Union<Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobCompletionCriteria, BaseFunction>? CompletionCriteria { get; set; }
            /// <summary>
            /// ContentColumn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-textclassificationjobconfig.html#cfn-sagemaker-automljob-textclassificationjobconfig-contentcolumn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContentColumn { get; set; }
        }

        public class TextGenerationJobConfig : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfTextGenerationHyperParameters, IHaveSageMakerAutoMLJobTypesModelAccessConfigModelAccessConfig, IHaveBaseModelName, IHaveSageMakerAutoMLJobTypesAutoMLJobCompletionCriteriaCompletionCriteria
        {
            /// <summary>
            /// TextGenerationHyperParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-textgenerationjobconfig.html#cfn-sagemaker-automljob-textgenerationjobconfig-textgenerationhyperparameters
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? TextGenerationHyperParameters { get; set; }
            /// <summary>
            /// ModelAccessConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-textgenerationjobconfig.html#cfn-sagemaker-automljob-textgenerationjobconfig-modelaccessconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ModelAccessConfig
            /// </summary>
            public Union<Humidifier.SageMaker.AutoMLJobTypes.ModelAccessConfig, BaseFunction>? ModelAccessConfig { get; set; }
            /// <summary>
            /// BaseModelName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-textgenerationjobconfig.html#cfn-sagemaker-automljob-textgenerationjobconfig-basemodelname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BaseModelName { get; set; }
            /// <summary>
            /// CompletionCriteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-textgenerationjobconfig.html#cfn-sagemaker-automljob-textgenerationjobconfig-completioncriteria
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AutoMLJobCompletionCriteria
            /// </summary>
            public Union<Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobCompletionCriteria, BaseFunction>? CompletionCriteria { get; set; }
        }

        public class TimeSeriesConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfGroupingAttributeNames, IHaveTargetAttributeName, IHaveTimestampAttributeName, IHaveItemIdentifierAttributeName
        {
            /// <summary>
            /// GroupingAttributeNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-timeseriesconfig.html#cfn-sagemaker-automljob-timeseriesconfig-groupingattributenames
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? GroupingAttributeNames { get; set; }
            /// <summary>
            /// TargetAttributeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-timeseriesconfig.html#cfn-sagemaker-automljob-timeseriesconfig-targetattributename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetAttributeName { get; set; }
            /// <summary>
            /// TimestampAttributeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-timeseriesconfig.html#cfn-sagemaker-automljob-timeseriesconfig-timestampattributename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimestampAttributeName { get; set; }
            /// <summary>
            /// ItemIdentifierAttributeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-timeseriesconfig.html#cfn-sagemaker-automljob-timeseriesconfig-itemidentifierattributename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ItemIdentifierAttributeName { get; set; }
        }

        public class TimeSeriesForecastingJobConfig : Humidifier.Base.BaseSubResource, IHaveSageMakerAutoMLJobTypesCandidateGenerationConfigCandidateGenerationConfig, IHaveFeatureSpecificationS3Uri, IHaveStringListOfForecastQuantiles, IHaveListOfSageMakerAutoMLJobTypesHolidayConfigAttributesHolidayConfig, IHaveForecastHorizon_Integer, IHaveSageMakerAutoMLJobTypesAutoMLJobCompletionCriteriaCompletionCriteria, IHaveSageMakerAutoMLJobTypesTimeSeriesTransformationsTransformations, IHaveSageMakerAutoMLJobTypesTimeSeriesConfigTimeSeriesConfig, IHaveForecastFrequency
        {
            /// <summary>
            /// CandidateGenerationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-timeseriesforecastingjobconfig.html#cfn-sagemaker-automljob-timeseriesforecastingjobconfig-candidategenerationconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CandidateGenerationConfig
            /// </summary>
            public Union<Humidifier.SageMaker.AutoMLJobTypes.CandidateGenerationConfig, BaseFunction>? CandidateGenerationConfig { get; set; }
            /// <summary>
            /// FeatureSpecificationS3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-timeseriesforecastingjobconfig.html#cfn-sagemaker-automljob-timeseriesforecastingjobconfig-featurespecifications3uri
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FeatureSpecificationS3Uri { get; set; }
            /// <summary>
            /// ForecastQuantiles
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-timeseriesforecastingjobconfig.html#cfn-sagemaker-automljob-timeseriesforecastingjobconfig-forecastquantiles
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ForecastQuantiles { get; set; }
            /// <summary>
            /// HolidayConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-timeseriesforecastingjobconfig.html#cfn-sagemaker-automljob-timeseriesforecastingjobconfig-holidayconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: HolidayConfigAttributes
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.AutoMLJobTypes.HolidayConfigAttributes>, IReadOnlyList<Union<Humidifier.SageMaker.AutoMLJobTypes.HolidayConfigAttributes, BaseFunction>>, BaseFunction>? HolidayConfig { get; set; }
            /// <summary>
            /// ForecastHorizon
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-timeseriesforecastingjobconfig.html#cfn-sagemaker-automljob-timeseriesforecastingjobconfig-forecasthorizon
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ForecastHorizon { get; set; }
            /// <summary>
            /// CompletionCriteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-timeseriesforecastingjobconfig.html#cfn-sagemaker-automljob-timeseriesforecastingjobconfig-completioncriteria
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AutoMLJobCompletionCriteria
            /// </summary>
            public Union<Humidifier.SageMaker.AutoMLJobTypes.AutoMLJobCompletionCriteria, BaseFunction>? CompletionCriteria { get; set; }
            /// <summary>
            /// Transformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-timeseriesforecastingjobconfig.html#cfn-sagemaker-automljob-timeseriesforecastingjobconfig-transformations
            /// Required: False
            /// UpdateType: Immutable
            /// Type: TimeSeriesTransformations
            /// </summary>
            public Union<Humidifier.SageMaker.AutoMLJobTypes.TimeSeriesTransformations, BaseFunction>? Transformations { get; set; }
            /// <summary>
            /// TimeSeriesConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-timeseriesforecastingjobconfig.html#cfn-sagemaker-automljob-timeseriesforecastingjobconfig-timeseriesconfig
            /// Required: True
            /// UpdateType: Immutable
            /// Type: TimeSeriesConfig
            /// </summary>
            public Union<Humidifier.SageMaker.AutoMLJobTypes.TimeSeriesConfig, BaseFunction>? TimeSeriesConfig { get; set; }
            /// <summary>
            /// ForecastFrequency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-timeseriesforecastingjobconfig.html#cfn-sagemaker-automljob-timeseriesforecastingjobconfig-forecastfrequency
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ForecastFrequency { get; set; }
        }

        public class TimeSeriesTransformations : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfAggregation, IHaveFilling_Json
        {
            /// <summary>
            /// Aggregation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-timeseriestransformations.html#cfn-sagemaker-automljob-timeseriestransformations-aggregation
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Aggregation { get; set; }
            /// <summary>
            /// Filling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-timeseriestransformations.html#cfn-sagemaker-automljob-timeseriestransformations-filling
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Filling { get; set; }
        }

        public class VpcConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfSubnets, IHaveStringListOfSecurityGroupIds
        {
            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-vpcconfig.html#cfn-sagemaker-automljob-vpcconfig-subnets
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Subnets { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-automljob-vpcconfig.html#cfn-sagemaker-automljob-vpcconfig-securitygroupids
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        }
    }
}