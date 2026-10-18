namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using ModelExplainabilityJobDefinitionTypes;

    public class ModelExplainabilityJobDefinition : Humidifier.Base.BaseResource, IHaveTags, IHaveSageMakerModelExplainabilityJobDefinitionTypesMonitoringOutputConfigModelExplainabilityJobOutputConfig, IHaveEndpointName, IHaveSageMakerModelExplainabilityJobDefinitionTypesStoppingConditionStoppingCondition, IHaveSageMakerModelExplainabilityJobDefinitionTypesModelExplainabilityBaselineConfigModelExplainabilityBaselineConfig, IHaveJobDefinitionName, IHaveSageMakerModelExplainabilityJobDefinitionTypesMonitoringResourcesJobResources, IHaveSageMakerModelExplainabilityJobDefinitionTypesNetworkConfigNetworkConfig, IHaveRoleArn, IHaveSageMakerModelExplainabilityJobDefinitionTypesModelExplainabilityJobInputModelExplainabilityJobInput, IHaveSageMakerModelExplainabilityJobDefinitionTypesModelExplainabilityAppSpecificationModelExplainabilityAppSpecification
    {
        public class Attributes
        {
            public static string JobDefinitionArn =  "JobDefinitionArn" ;
            public static string CreationTime =  "CreationTime" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.ModelExplainabilityJobDefinition; }

        /// <summary>
        /// ModelExplainabilityJobOutputConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelexplainabilityjobdefinition.html#cfn-sagemaker-modelexplainabilityjobdefinition-modelexplainabilityjoboutputconfig
        /// Required: True
        /// UpdateType: Immutable
        /// Type: MonitoringOutputConfig
        /// </summary>
        [Required]
        public Union<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.MonitoringOutputConfig, BaseFunction>? ModelExplainabilityJobOutputConfig { get; set; }
        /// <summary>
        /// EndpointName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelexplainabilityjobdefinition.html#cfn-sagemaker-modelexplainabilityjobdefinition-endpointname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EndpointName { get; set; }
        /// <summary>
        /// StoppingCondition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelexplainabilityjobdefinition.html#cfn-sagemaker-modelexplainabilityjobdefinition-stoppingcondition
        /// Required: False
        /// UpdateType: Immutable
        /// Type: StoppingCondition
        /// </summary>
        public Union<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.StoppingCondition, BaseFunction>? StoppingCondition { get; set; }
        /// <summary>
        /// ModelExplainabilityBaselineConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelexplainabilityjobdefinition.html#cfn-sagemaker-modelexplainabilityjobdefinition-modelexplainabilitybaselineconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ModelExplainabilityBaselineConfig
        /// </summary>
        public Union<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ModelExplainabilityBaselineConfig, BaseFunction>? ModelExplainabilityBaselineConfig { get; set; }
        /// <summary>
        /// JobDefinitionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelexplainabilityjobdefinition.html#cfn-sagemaker-modelexplainabilityjobdefinition-jobdefinitionname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? JobDefinitionName { get; set; }

        /// <summary>
        /// JobResources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelexplainabilityjobdefinition.html#cfn-sagemaker-modelexplainabilityjobdefinition-jobresources
        /// Required: True
        /// UpdateType: Immutable
        /// Type: MonitoringResources
        /// </summary>
        [Required]
        public Union<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.MonitoringResources, BaseFunction>? JobResources { get; set; }
        /// <summary>
        /// NetworkConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelexplainabilityjobdefinition.html#cfn-sagemaker-modelexplainabilityjobdefinition-networkconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: NetworkConfig
        /// </summary>
        public Union<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.NetworkConfig, BaseFunction>? NetworkConfig { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelexplainabilityjobdefinition.html#cfn-sagemaker-modelexplainabilityjobdefinition-rolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }

        /// <summary>
        /// ModelExplainabilityJobInput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelexplainabilityjobdefinition.html#cfn-sagemaker-modelexplainabilityjobdefinition-modelexplainabilityjobinput
        /// Required: True
        /// UpdateType: Immutable
        /// Type: ModelExplainabilityJobInput
        /// </summary>
        [Required]
        public Union<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ModelExplainabilityJobInput, BaseFunction>? ModelExplainabilityJobInput { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelexplainabilityjobdefinition.html#cfn-sagemaker-modelexplainabilityjobdefinition-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// ModelExplainabilityAppSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelexplainabilityjobdefinition.html#cfn-sagemaker-modelexplainabilityjobdefinition-modelexplainabilityappspecification
        /// Required: True
        /// UpdateType: Immutable
        /// Type: ModelExplainabilityAppSpecification
        /// </summary>
        [Required]
        public Union<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ModelExplainabilityAppSpecification, BaseFunction>? ModelExplainabilityAppSpecification { get; set; }
    }

    namespace ModelExplainabilityJobDefinitionTypes
    {
        public class BatchTransformInput : Humidifier.Base.BaseSubResource, IHaveSageMakerModelExplainabilityJobDefinitionTypesDatasetFormatDatasetFormat, IHaveS3DataDistributionType, IHaveInferenceAttribute, IHaveDataCapturedDestinationS3Uri, IHaveS3InputMode, IHaveLocalPath, IHaveProbabilityAttribute, IHaveFeaturesAttribute
        {
            /// <summary>
            /// DatasetFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-batchtransforminput.html#cfn-sagemaker-modelexplainabilityjobdefinition-batchtransforminput-datasetformat
            /// Required: True
            /// UpdateType: Immutable
            /// Type: DatasetFormat
            /// </summary>
            public Union<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.DatasetFormat, BaseFunction>? DatasetFormat { get; set; }
            /// <summary>
            /// S3DataDistributionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-batchtransforminput.html#cfn-sagemaker-modelexplainabilityjobdefinition-batchtransforminput-s3datadistributiontype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3DataDistributionType { get; set; }
            /// <summary>
            /// InferenceAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-batchtransforminput.html#cfn-sagemaker-modelexplainabilityjobdefinition-batchtransforminput-inferenceattribute
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InferenceAttribute { get; set; }
            /// <summary>
            /// DataCapturedDestinationS3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-batchtransforminput.html#cfn-sagemaker-modelexplainabilityjobdefinition-batchtransforminput-datacaptureddestinations3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataCapturedDestinationS3Uri { get; set; }
            /// <summary>
            /// S3InputMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-batchtransforminput.html#cfn-sagemaker-modelexplainabilityjobdefinition-batchtransforminput-s3inputmode
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3InputMode { get; set; }
            /// <summary>
            /// LocalPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-batchtransforminput.html#cfn-sagemaker-modelexplainabilityjobdefinition-batchtransforminput-localpath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LocalPath { get; set; }
            /// <summary>
            /// ProbabilityAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-batchtransforminput.html#cfn-sagemaker-modelexplainabilityjobdefinition-batchtransforminput-probabilityattribute
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProbabilityAttribute { get; set; }
            /// <summary>
            /// FeaturesAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-batchtransforminput.html#cfn-sagemaker-modelexplainabilityjobdefinition-batchtransforminput-featuresattribute
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FeaturesAttribute { get; set; }
        }

        public class ClusterConfig : Humidifier.Base.BaseSubResource, IHaveInstanceCount_Integer, IHaveVolumeSizeInGB_Integer, IHaveVolumeKmsKeyId, IHaveInstanceType
        {
            /// <summary>
            /// InstanceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-clusterconfig.html#cfn-sagemaker-modelexplainabilityjobdefinition-clusterconfig-instancecount
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? InstanceCount { get; set; }
            /// <summary>
            /// VolumeSizeInGB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-clusterconfig.html#cfn-sagemaker-modelexplainabilityjobdefinition-clusterconfig-volumesizeingb
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? VolumeSizeInGB { get; set; }
            /// <summary>
            /// VolumeKmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-clusterconfig.html#cfn-sagemaker-modelexplainabilityjobdefinition-clusterconfig-volumekmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VolumeKmsKeyId { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-clusterconfig.html#cfn-sagemaker-modelexplainabilityjobdefinition-clusterconfig-instancetype
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-constraintsresource.html#cfn-sagemaker-modelexplainabilityjobdefinition-constraintsresource-s3uri
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-csv.html#cfn-sagemaker-modelexplainabilityjobdefinition-csv-header
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Header { get; set; }
        }

        public class DatasetFormat : Humidifier.Base.BaseSubResource, IHaveParquet_Boolean, IHaveSageMakerModelExplainabilityJobDefinitionTypesCsvCsv, IHaveSageMakerModelExplainabilityJobDefinitionTypesJsonJson
        {
            /// <summary>
            /// Parquet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-datasetformat.html#cfn-sagemaker-modelexplainabilityjobdefinition-datasetformat-parquet
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Parquet { get; set; }
            /// <summary>
            /// Csv
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-datasetformat.html#cfn-sagemaker-modelexplainabilityjobdefinition-datasetformat-csv
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Csv
            /// </summary>
            public Union<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.Csv, BaseFunction>? Csv { get; set; }
            /// <summary>
            /// Json
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-datasetformat.html#cfn-sagemaker-modelexplainabilityjobdefinition-datasetformat-json
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Json
            /// </summary>
            public Union<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.Json, BaseFunction>? Json { get; set; }
        }

        public class EndpointInput : Humidifier.Base.BaseSubResource, IHaveS3DataDistributionType, IHaveEndpointName, IHaveInferenceAttribute, IHaveS3InputMode, IHaveLocalPath, IHaveProbabilityAttribute, IHaveFeaturesAttribute
        {
            /// <summary>
            /// S3DataDistributionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-endpointinput.html#cfn-sagemaker-modelexplainabilityjobdefinition-endpointinput-s3datadistributiontype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3DataDistributionType { get; set; }
            /// <summary>
            /// EndpointName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-endpointinput.html#cfn-sagemaker-modelexplainabilityjobdefinition-endpointinput-endpointname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndpointName { get; set; }
            /// <summary>
            /// InferenceAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-endpointinput.html#cfn-sagemaker-modelexplainabilityjobdefinition-endpointinput-inferenceattribute
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InferenceAttribute { get; set; }
            /// <summary>
            /// S3InputMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-endpointinput.html#cfn-sagemaker-modelexplainabilityjobdefinition-endpointinput-s3inputmode
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3InputMode { get; set; }
            /// <summary>
            /// LocalPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-endpointinput.html#cfn-sagemaker-modelexplainabilityjobdefinition-endpointinput-localpath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LocalPath { get; set; }
            /// <summary>
            /// ProbabilityAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-endpointinput.html#cfn-sagemaker-modelexplainabilityjobdefinition-endpointinput-probabilityattribute
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProbabilityAttribute { get; set; }
            /// <summary>
            /// FeaturesAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-endpointinput.html#cfn-sagemaker-modelexplainabilityjobdefinition-endpointinput-featuresattribute
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FeaturesAttribute { get; set; }
        }

        public class Json : Humidifier.Base.BaseSubResource, IHaveLine_Boolean
        {
            /// <summary>
            /// Line
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-json.html#cfn-sagemaker-modelexplainabilityjobdefinition-json-line
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Line { get; set; }
        }

        public class ModelExplainabilityAppSpecification : Humidifier.Base.BaseSubResource, IHaveConfigUri, IHaveStringDictionaryOfEnvironment, IHaveImageUri
        {
            /// <summary>
            /// ConfigUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-modelexplainabilityappspecification.html#cfn-sagemaker-modelexplainabilityjobdefinition-modelexplainabilityappspecification-configuri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConfigUri { get; set; }
            /// <summary>
            /// Environment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-modelexplainabilityappspecification.html#cfn-sagemaker-modelexplainabilityjobdefinition-modelexplainabilityappspecification-environment
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Environment { get; set; }
            /// <summary>
            /// ImageUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-modelexplainabilityappspecification.html#cfn-sagemaker-modelexplainabilityjobdefinition-modelexplainabilityappspecification-imageuri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImageUri { get; set; }
        }

        public class ModelExplainabilityBaselineConfig : Humidifier.Base.BaseSubResource, IHaveSageMakerModelExplainabilityJobDefinitionTypesConstraintsResourceConstraintsResource, IHaveBaseliningJobName
        {
            /// <summary>
            /// ConstraintsResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-modelexplainabilitybaselineconfig.html#cfn-sagemaker-modelexplainabilityjobdefinition-modelexplainabilitybaselineconfig-constraintsresource
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ConstraintsResource
            /// </summary>
            public Union<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ConstraintsResource, BaseFunction>? ConstraintsResource { get; set; }
            /// <summary>
            /// BaseliningJobName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-modelexplainabilitybaselineconfig.html#cfn-sagemaker-modelexplainabilityjobdefinition-modelexplainabilitybaselineconfig-baseliningjobname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BaseliningJobName { get; set; }
        }

        public class ModelExplainabilityJobInput : Humidifier.Base.BaseSubResource, IHaveSageMakerModelExplainabilityJobDefinitionTypesBatchTransformInputBatchTransformInput, IHaveSageMakerModelExplainabilityJobDefinitionTypesEndpointInputEndpointInput
        {
            /// <summary>
            /// BatchTransformInput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-modelexplainabilityjobinput.html#cfn-sagemaker-modelexplainabilityjobdefinition-modelexplainabilityjobinput-batchtransforminput
            /// Required: False
            /// UpdateType: Immutable
            /// Type: BatchTransformInput
            /// </summary>
            public Union<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.BatchTransformInput, BaseFunction>? BatchTransformInput { get; set; }
            /// <summary>
            /// EndpointInput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-modelexplainabilityjobinput.html#cfn-sagemaker-modelexplainabilityjobdefinition-modelexplainabilityjobinput-endpointinput
            /// Required: False
            /// UpdateType: Immutable
            /// Type: EndpointInput
            /// </summary>
            public Union<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.EndpointInput, BaseFunction>? EndpointInput { get; set; }
        }

        public class MonitoringOutput : Humidifier.Base.BaseSubResource, IHaveSageMakerModelExplainabilityJobDefinitionTypesS3OutputS3Output
        {
            /// <summary>
            /// S3Output
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-monitoringoutput.html#cfn-sagemaker-modelexplainabilityjobdefinition-monitoringoutput-s3output
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3Output
            /// </summary>
            public Union<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.S3Output, BaseFunction>? S3Output { get; set; }
        }

        public class MonitoringOutputConfig : Humidifier.Base.BaseSubResource, IHaveKmsKeyId, IHaveListOfSageMakerModelExplainabilityJobDefinitionTypesMonitoringOutputMonitoringOutputs
        {
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-monitoringoutputconfig.html#cfn-sagemaker-modelexplainabilityjobdefinition-monitoringoutputconfig-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
            /// <summary>
            /// MonitoringOutputs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-monitoringoutputconfig.html#cfn-sagemaker-modelexplainabilityjobdefinition-monitoringoutputconfig-monitoringoutputs
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: MonitoringOutput
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.MonitoringOutput>, IReadOnlyList<Union<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.MonitoringOutput, BaseFunction>>, BaseFunction>? MonitoringOutputs { get; set; }
        }

        public class MonitoringResources : Humidifier.Base.BaseSubResource, IHaveSageMakerModelExplainabilityJobDefinitionTypesClusterConfigClusterConfig
        {
            /// <summary>
            /// ClusterConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-monitoringresources.html#cfn-sagemaker-modelexplainabilityjobdefinition-monitoringresources-clusterconfig
            /// Required: True
            /// UpdateType: Immutable
            /// Type: ClusterConfig
            /// </summary>
            public Union<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ClusterConfig, BaseFunction>? ClusterConfig { get; set; }
        }

        public class NetworkConfig : Humidifier.Base.BaseSubResource, IHaveEnableNetworkIsolation_Boolean, IHaveEnableInterContainerTrafficEncryption_Boolean, IHaveSageMakerModelExplainabilityJobDefinitionTypesVpcConfigVpcConfig
        {
            /// <summary>
            /// EnableNetworkIsolation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-networkconfig.html#cfn-sagemaker-modelexplainabilityjobdefinition-networkconfig-enablenetworkisolation
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableNetworkIsolation { get; set; }
            /// <summary>
            /// EnableInterContainerTrafficEncryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-networkconfig.html#cfn-sagemaker-modelexplainabilityjobdefinition-networkconfig-enableintercontainertrafficencryption
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableInterContainerTrafficEncryption { get; set; }
            /// <summary>
            /// VpcConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-networkconfig.html#cfn-sagemaker-modelexplainabilityjobdefinition-networkconfig-vpcconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: VpcConfig
            /// </summary>
            public Union<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.VpcConfig, BaseFunction>? VpcConfig { get; set; }
        }

        public class S3Output : Humidifier.Base.BaseSubResource, IHaveS3Uri, IHaveLocalPath, IHaveS3UploadMode
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-s3output.html#cfn-sagemaker-modelexplainabilityjobdefinition-s3output-s3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
            /// <summary>
            /// LocalPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-s3output.html#cfn-sagemaker-modelexplainabilityjobdefinition-s3output-localpath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LocalPath { get; set; }
            /// <summary>
            /// S3UploadMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-s3output.html#cfn-sagemaker-modelexplainabilityjobdefinition-s3output-s3uploadmode
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-stoppingcondition.html#cfn-sagemaker-modelexplainabilityjobdefinition-stoppingcondition-maxruntimeinseconds
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-vpcconfig.html#cfn-sagemaker-modelexplainabilityjobdefinition-vpcconfig-subnets
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Subnets { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelexplainabilityjobdefinition-vpcconfig.html#cfn-sagemaker-modelexplainabilityjobdefinition-vpcconfig-securitygroupids
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        }
    }
}