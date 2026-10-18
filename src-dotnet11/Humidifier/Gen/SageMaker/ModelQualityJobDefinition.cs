namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using ModelQualityJobDefinitionTypes;

    public class ModelQualityJobDefinition : Humidifier.Base.BaseResource, IHaveTags, IHaveSageMakerModelQualityJobDefinitionTypesModelQualityAppSpecificationModelQualityAppSpecification, IHaveEndpointName, IHaveSageMakerModelQualityJobDefinitionTypesStoppingConditionStoppingCondition, IHaveSageMakerModelQualityJobDefinitionTypesModelQualityBaselineConfigModelQualityBaselineConfig, IHaveJobDefinitionName, IHaveSageMakerModelQualityJobDefinitionTypesModelQualityJobInputModelQualityJobInput, IHaveSageMakerModelQualityJobDefinitionTypesMonitoringResourcesJobResources, IHaveSageMakerModelQualityJobDefinitionTypesNetworkConfigNetworkConfig, IHaveSageMakerModelQualityJobDefinitionTypesMonitoringOutputConfigModelQualityJobOutputConfig, IHaveRoleArn
    {
        public class Attributes
        {
            public static string JobDefinitionArn =  "JobDefinitionArn" ;
            public static string CreationTime =  "CreationTime" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.ModelQualityJobDefinition; }

        /// <summary>
        /// ModelQualityAppSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelqualityjobdefinition.html#cfn-sagemaker-modelqualityjobdefinition-modelqualityappspecification
        /// Required: True
        /// UpdateType: Immutable
        /// Type: ModelQualityAppSpecification
        /// </summary>
        [Required]
        public Union<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ModelQualityAppSpecification, BaseFunction>? ModelQualityAppSpecification { get; set; }
        /// <summary>
        /// EndpointName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelqualityjobdefinition.html#cfn-sagemaker-modelqualityjobdefinition-endpointname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EndpointName { get; set; }
        /// <summary>
        /// StoppingCondition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelqualityjobdefinition.html#cfn-sagemaker-modelqualityjobdefinition-stoppingcondition
        /// Required: False
        /// UpdateType: Immutable
        /// Type: StoppingCondition
        /// </summary>
        public Union<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.StoppingCondition, BaseFunction>? StoppingCondition { get; set; }
        /// <summary>
        /// ModelQualityBaselineConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelqualityjobdefinition.html#cfn-sagemaker-modelqualityjobdefinition-modelqualitybaselineconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ModelQualityBaselineConfig
        /// </summary>
        public Union<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ModelQualityBaselineConfig, BaseFunction>? ModelQualityBaselineConfig { get; set; }
        /// <summary>
        /// JobDefinitionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelqualityjobdefinition.html#cfn-sagemaker-modelqualityjobdefinition-jobdefinitionname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? JobDefinitionName { get; set; }

        /// <summary>
        /// ModelQualityJobInput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelqualityjobdefinition.html#cfn-sagemaker-modelqualityjobdefinition-modelqualityjobinput
        /// Required: True
        /// UpdateType: Immutable
        /// Type: ModelQualityJobInput
        /// </summary>
        [Required]
        public Union<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ModelQualityJobInput, BaseFunction>? ModelQualityJobInput { get; set; }

        /// <summary>
        /// JobResources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelqualityjobdefinition.html#cfn-sagemaker-modelqualityjobdefinition-jobresources
        /// Required: True
        /// UpdateType: Immutable
        /// Type: MonitoringResources
        /// </summary>
        [Required]
        public Union<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.MonitoringResources, BaseFunction>? JobResources { get; set; }
        /// <summary>
        /// NetworkConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelqualityjobdefinition.html#cfn-sagemaker-modelqualityjobdefinition-networkconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: NetworkConfig
        /// </summary>
        public Union<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.NetworkConfig, BaseFunction>? NetworkConfig { get; set; }

        /// <summary>
        /// ModelQualityJobOutputConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelqualityjobdefinition.html#cfn-sagemaker-modelqualityjobdefinition-modelqualityjoboutputconfig
        /// Required: True
        /// UpdateType: Immutable
        /// Type: MonitoringOutputConfig
        /// </summary>
        [Required]
        public Union<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.MonitoringOutputConfig, BaseFunction>? ModelQualityJobOutputConfig { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelqualityjobdefinition.html#cfn-sagemaker-modelqualityjobdefinition-rolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelqualityjobdefinition.html#cfn-sagemaker-modelqualityjobdefinition-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ModelQualityJobDefinitionTypes
    {
        public class BatchTransformInput : Humidifier.Base.BaseSubResource, IHaveSageMakerModelQualityJobDefinitionTypesDatasetFormatDatasetFormat, IHaveS3DataDistributionType, IHaveStartTimeOffset, IHaveEndTimeOffset, IHaveProbabilityThresholdAttribute_Double, IHaveInferenceAttribute, IHaveDataCapturedDestinationS3Uri, IHaveS3InputMode, IHaveLocalPath, IHaveProbabilityAttribute
        {
            /// <summary>
            /// DatasetFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-batchtransforminput.html#cfn-sagemaker-modelqualityjobdefinition-batchtransforminput-datasetformat
            /// Required: True
            /// UpdateType: Immutable
            /// Type: DatasetFormat
            /// </summary>
            public Union<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.DatasetFormat, BaseFunction>? DatasetFormat { get; set; }
            /// <summary>
            /// S3DataDistributionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-batchtransforminput.html#cfn-sagemaker-modelqualityjobdefinition-batchtransforminput-s3datadistributiontype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3DataDistributionType { get; set; }
            /// <summary>
            /// StartTimeOffset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-batchtransforminput.html#cfn-sagemaker-modelqualityjobdefinition-batchtransforminput-starttimeoffset
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StartTimeOffset { get; set; }
            /// <summary>
            /// EndTimeOffset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-batchtransforminput.html#cfn-sagemaker-modelqualityjobdefinition-batchtransforminput-endtimeoffset
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndTimeOffset { get; set; }
            /// <summary>
            /// ProbabilityThresholdAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-batchtransforminput.html#cfn-sagemaker-modelqualityjobdefinition-batchtransforminput-probabilitythresholdattribute
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? ProbabilityThresholdAttribute { get; set; }
            /// <summary>
            /// InferenceAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-batchtransforminput.html#cfn-sagemaker-modelqualityjobdefinition-batchtransforminput-inferenceattribute
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InferenceAttribute { get; set; }
            /// <summary>
            /// DataCapturedDestinationS3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-batchtransforminput.html#cfn-sagemaker-modelqualityjobdefinition-batchtransforminput-datacaptureddestinations3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataCapturedDestinationS3Uri { get; set; }
            /// <summary>
            /// S3InputMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-batchtransforminput.html#cfn-sagemaker-modelqualityjobdefinition-batchtransforminput-s3inputmode
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3InputMode { get; set; }
            /// <summary>
            /// LocalPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-batchtransforminput.html#cfn-sagemaker-modelqualityjobdefinition-batchtransforminput-localpath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LocalPath { get; set; }
            /// <summary>
            /// ProbabilityAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-batchtransforminput.html#cfn-sagemaker-modelqualityjobdefinition-batchtransforminput-probabilityattribute
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProbabilityAttribute { get; set; }
        }

        public class ClusterConfig : Humidifier.Base.BaseSubResource, IHaveInstanceCount_Integer, IHaveVolumeSizeInGB_Integer, IHaveVolumeKmsKeyId, IHaveInstanceType
        {
            /// <summary>
            /// InstanceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-clusterconfig.html#cfn-sagemaker-modelqualityjobdefinition-clusterconfig-instancecount
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? InstanceCount { get; set; }
            /// <summary>
            /// VolumeSizeInGB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-clusterconfig.html#cfn-sagemaker-modelqualityjobdefinition-clusterconfig-volumesizeingb
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? VolumeSizeInGB { get; set; }
            /// <summary>
            /// VolumeKmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-clusterconfig.html#cfn-sagemaker-modelqualityjobdefinition-clusterconfig-volumekmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VolumeKmsKeyId { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-clusterconfig.html#cfn-sagemaker-modelqualityjobdefinition-clusterconfig-instancetype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceType { get; set; }
        }

        public class ConstraintsResource : Humidifier.Base.BaseSubResource, IHaveS3Uri
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-constraintsresource.html#cfn-sagemaker-modelqualityjobdefinition-constraintsresource-s3uri
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
        }

        public class Csv : Humidifier.Base.BaseSubResource, IHaveHeader_Boolean
        {
            /// <summary>
            /// Header
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-csv.html#cfn-sagemaker-modelqualityjobdefinition-csv-header
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Header { get; set; }
        }

        public class DatasetFormat : Humidifier.Base.BaseSubResource, IHaveParquet_Boolean, IHaveSageMakerModelQualityJobDefinitionTypesCsvCsv, IHaveSageMakerModelQualityJobDefinitionTypesJsonJson
        {
            /// <summary>
            /// Parquet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-datasetformat.html#cfn-sagemaker-modelqualityjobdefinition-datasetformat-parquet
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Parquet { get; set; }
            /// <summary>
            /// Csv
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-datasetformat.html#cfn-sagemaker-modelqualityjobdefinition-datasetformat-csv
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Csv
            /// </summary>
            public Union<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.Csv, BaseFunction>? Csv { get; set; }
            /// <summary>
            /// Json
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-datasetformat.html#cfn-sagemaker-modelqualityjobdefinition-datasetformat-json
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Json
            /// </summary>
            public Union<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.Json, BaseFunction>? Json { get; set; }
        }

        public class EndpointInput : Humidifier.Base.BaseSubResource, IHaveS3DataDistributionType, IHaveStartTimeOffset, IHaveEndTimeOffset, IHaveProbabilityThresholdAttribute_Double, IHaveEndpointName, IHaveInferenceAttribute, IHaveS3InputMode, IHaveLocalPath, IHaveProbabilityAttribute
        {
            /// <summary>
            /// S3DataDistributionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-endpointinput.html#cfn-sagemaker-modelqualityjobdefinition-endpointinput-s3datadistributiontype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3DataDistributionType { get; set; }
            /// <summary>
            /// StartTimeOffset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-endpointinput.html#cfn-sagemaker-modelqualityjobdefinition-endpointinput-starttimeoffset
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StartTimeOffset { get; set; }
            /// <summary>
            /// EndTimeOffset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-endpointinput.html#cfn-sagemaker-modelqualityjobdefinition-endpointinput-endtimeoffset
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndTimeOffset { get; set; }
            /// <summary>
            /// ProbabilityThresholdAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-endpointinput.html#cfn-sagemaker-modelqualityjobdefinition-endpointinput-probabilitythresholdattribute
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? ProbabilityThresholdAttribute { get; set; }
            /// <summary>
            /// EndpointName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-endpointinput.html#cfn-sagemaker-modelqualityjobdefinition-endpointinput-endpointname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndpointName { get; set; }
            /// <summary>
            /// InferenceAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-endpointinput.html#cfn-sagemaker-modelqualityjobdefinition-endpointinput-inferenceattribute
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InferenceAttribute { get; set; }
            /// <summary>
            /// S3InputMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-endpointinput.html#cfn-sagemaker-modelqualityjobdefinition-endpointinput-s3inputmode
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3InputMode { get; set; }
            /// <summary>
            /// LocalPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-endpointinput.html#cfn-sagemaker-modelqualityjobdefinition-endpointinput-localpath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LocalPath { get; set; }
            /// <summary>
            /// ProbabilityAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-endpointinput.html#cfn-sagemaker-modelqualityjobdefinition-endpointinput-probabilityattribute
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProbabilityAttribute { get; set; }
        }

        public class Json : Humidifier.Base.BaseSubResource, IHaveLine_Boolean
        {
            /// <summary>
            /// Line
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-json.html#cfn-sagemaker-modelqualityjobdefinition-json-line
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Line { get; set; }
        }

        public class ModelQualityAppSpecification : Humidifier.Base.BaseSubResource, IHaveStringListOfContainerEntrypoint, IHaveProblemType, IHavePostAnalyticsProcessorSourceUri, IHaveRecordPreprocessorSourceUri, IHaveStringDictionaryOfEnvironment, IHaveImageUri, IHaveStringListOfContainerArguments
        {
            /// <summary>
            /// ContainerEntrypoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-modelqualityappspecification.html#cfn-sagemaker-modelqualityjobdefinition-modelqualityappspecification-containerentrypoint
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ContainerEntrypoint { get; set; }
            /// <summary>
            /// ProblemType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-modelqualityappspecification.html#cfn-sagemaker-modelqualityjobdefinition-modelqualityappspecification-problemtype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProblemType { get; set; }
            /// <summary>
            /// PostAnalyticsProcessorSourceUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-modelqualityappspecification.html#cfn-sagemaker-modelqualityjobdefinition-modelqualityappspecification-postanalyticsprocessorsourceuri
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PostAnalyticsProcessorSourceUri { get; set; }
            /// <summary>
            /// RecordPreprocessorSourceUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-modelqualityappspecification.html#cfn-sagemaker-modelqualityjobdefinition-modelqualityappspecification-recordpreprocessorsourceuri
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RecordPreprocessorSourceUri { get; set; }
            /// <summary>
            /// Environment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-modelqualityappspecification.html#cfn-sagemaker-modelqualityjobdefinition-modelqualityappspecification-environment
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Environment { get; set; }
            /// <summary>
            /// ImageUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-modelqualityappspecification.html#cfn-sagemaker-modelqualityjobdefinition-modelqualityappspecification-imageuri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImageUri { get; set; }
            /// <summary>
            /// ContainerArguments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-modelqualityappspecification.html#cfn-sagemaker-modelqualityjobdefinition-modelqualityappspecification-containerarguments
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ContainerArguments { get; set; }
        }

        public class ModelQualityBaselineConfig : Humidifier.Base.BaseSubResource, IHaveSageMakerModelQualityJobDefinitionTypesConstraintsResourceConstraintsResource, IHaveBaseliningJobName
        {
            /// <summary>
            /// ConstraintsResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-modelqualitybaselineconfig.html#cfn-sagemaker-modelqualityjobdefinition-modelqualitybaselineconfig-constraintsresource
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ConstraintsResource
            /// </summary>
            public Union<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ConstraintsResource, BaseFunction>? ConstraintsResource { get; set; }
            /// <summary>
            /// BaseliningJobName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-modelqualitybaselineconfig.html#cfn-sagemaker-modelqualityjobdefinition-modelqualitybaselineconfig-baseliningjobname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BaseliningJobName { get; set; }
        }

        public class ModelQualityJobInput : Humidifier.Base.BaseSubResource, IHaveSageMakerModelQualityJobDefinitionTypesMonitoringGroundTruthS3InputGroundTruthS3Input, IHaveSageMakerModelQualityJobDefinitionTypesBatchTransformInputBatchTransformInput, IHaveSageMakerModelQualityJobDefinitionTypesEndpointInputEndpointInput
        {
            /// <summary>
            /// GroundTruthS3Input
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-modelqualityjobinput.html#cfn-sagemaker-modelqualityjobdefinition-modelqualityjobinput-groundtruths3input
            /// Required: True
            /// UpdateType: Immutable
            /// Type: MonitoringGroundTruthS3Input
            /// </summary>
            public Union<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.MonitoringGroundTruthS3Input, BaseFunction>? GroundTruthS3Input { get; set; }
            /// <summary>
            /// BatchTransformInput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-modelqualityjobinput.html#cfn-sagemaker-modelqualityjobdefinition-modelqualityjobinput-batchtransforminput
            /// Required: False
            /// UpdateType: Immutable
            /// Type: BatchTransformInput
            /// </summary>
            public Union<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.BatchTransformInput, BaseFunction>? BatchTransformInput { get; set; }
            /// <summary>
            /// EndpointInput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-modelqualityjobinput.html#cfn-sagemaker-modelqualityjobdefinition-modelqualityjobinput-endpointinput
            /// Required: False
            /// UpdateType: Immutable
            /// Type: EndpointInput
            /// </summary>
            public Union<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.EndpointInput, BaseFunction>? EndpointInput { get; set; }
        }

        public class MonitoringGroundTruthS3Input : Humidifier.Base.BaseSubResource, IHaveS3Uri
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-monitoringgroundtruths3input.html#cfn-sagemaker-modelqualityjobdefinition-monitoringgroundtruths3input-s3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
        }

        public class MonitoringOutput : Humidifier.Base.BaseSubResource, IHaveSageMakerModelQualityJobDefinitionTypesS3OutputS3Output
        {
            /// <summary>
            /// S3Output
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-monitoringoutput.html#cfn-sagemaker-modelqualityjobdefinition-monitoringoutput-s3output
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3Output
            /// </summary>
            public Union<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.S3Output, BaseFunction>? S3Output { get; set; }
        }

        public class MonitoringOutputConfig : Humidifier.Base.BaseSubResource, IHaveKmsKeyId, IHaveListOfSageMakerModelQualityJobDefinitionTypesMonitoringOutputMonitoringOutputs
        {
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-monitoringoutputconfig.html#cfn-sagemaker-modelqualityjobdefinition-monitoringoutputconfig-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
            /// <summary>
            /// MonitoringOutputs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-monitoringoutputconfig.html#cfn-sagemaker-modelqualityjobdefinition-monitoringoutputconfig-monitoringoutputs
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: MonitoringOutput
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.MonitoringOutput>, IReadOnlyList<Union<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.MonitoringOutput, BaseFunction>>, BaseFunction>? MonitoringOutputs { get; set; }
        }

        public class MonitoringResources : Humidifier.Base.BaseSubResource, IHaveSageMakerModelQualityJobDefinitionTypesClusterConfigClusterConfig
        {
            /// <summary>
            /// ClusterConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-monitoringresources.html#cfn-sagemaker-modelqualityjobdefinition-monitoringresources-clusterconfig
            /// Required: True
            /// UpdateType: Immutable
            /// Type: ClusterConfig
            /// </summary>
            public Union<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ClusterConfig, BaseFunction>? ClusterConfig { get; set; }
        }

        public class NetworkConfig : Humidifier.Base.BaseSubResource, IHaveEnableNetworkIsolation_Boolean, IHaveEnableInterContainerTrafficEncryption_Boolean, IHaveSageMakerModelQualityJobDefinitionTypesVpcConfigVpcConfig
        {
            /// <summary>
            /// EnableNetworkIsolation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-networkconfig.html#cfn-sagemaker-modelqualityjobdefinition-networkconfig-enablenetworkisolation
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableNetworkIsolation { get; set; }
            /// <summary>
            /// EnableInterContainerTrafficEncryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-networkconfig.html#cfn-sagemaker-modelqualityjobdefinition-networkconfig-enableintercontainertrafficencryption
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableInterContainerTrafficEncryption { get; set; }
            /// <summary>
            /// VpcConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-networkconfig.html#cfn-sagemaker-modelqualityjobdefinition-networkconfig-vpcconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: VpcConfig
            /// </summary>
            public Union<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.VpcConfig, BaseFunction>? VpcConfig { get; set; }
        }

        public class S3Output : Humidifier.Base.BaseSubResource, IHaveS3Uri, IHaveLocalPath, IHaveS3UploadMode
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-s3output.html#cfn-sagemaker-modelqualityjobdefinition-s3output-s3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
            /// <summary>
            /// LocalPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-s3output.html#cfn-sagemaker-modelqualityjobdefinition-s3output-localpath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LocalPath { get; set; }
            /// <summary>
            /// S3UploadMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-s3output.html#cfn-sagemaker-modelqualityjobdefinition-s3output-s3uploadmode
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3UploadMode { get; set; }
        }

        public class StoppingCondition : Humidifier.Base.BaseSubResource, IHaveMaxRuntimeInSeconds_Integer
        {
            /// <summary>
            /// MaxRuntimeInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-stoppingcondition.html#cfn-sagemaker-modelqualityjobdefinition-stoppingcondition-maxruntimeinseconds
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxRuntimeInSeconds { get; set; }
        }

        public class VpcConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfSubnets, IHaveStringListOfSecurityGroupIds
        {
            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-vpcconfig.html#cfn-sagemaker-modelqualityjobdefinition-vpcconfig-subnets
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Subnets { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelqualityjobdefinition-vpcconfig.html#cfn-sagemaker-modelqualityjobdefinition-vpcconfig-securitygroupids
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        }
    }
}