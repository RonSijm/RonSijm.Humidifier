namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using DataQualityJobDefinitionTypes;

    public class DataQualityJobDefinition : Humidifier.Base.BaseResource, IHaveTags, IHaveSageMakerDataQualityJobDefinitionTypesDataQualityJobInputDataQualityJobInput, IHaveSageMakerDataQualityJobDefinitionTypesDataQualityAppSpecificationDataQualityAppSpecification, IHaveEndpointName, IHaveSageMakerDataQualityJobDefinitionTypesStoppingConditionStoppingCondition, IHaveJobDefinitionName, IHaveSageMakerDataQualityJobDefinitionTypesMonitoringResourcesJobResources, IHaveSageMakerDataQualityJobDefinitionTypesNetworkConfigNetworkConfig, IHaveSageMakerDataQualityJobDefinitionTypesMonitoringOutputConfigDataQualityJobOutputConfig, IHaveSageMakerDataQualityJobDefinitionTypesDataQualityBaselineConfigDataQualityBaselineConfig, IHaveRoleArn
    {
        public class Attributes
        {
            public static string JobDefinitionArn =  "JobDefinitionArn" ;
            public static string CreationTime =  "CreationTime" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.DataQualityJobDefinition; }

        /// <summary>
        /// DataQualityJobInput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-dataqualityjobdefinition.html#cfn-sagemaker-dataqualityjobdefinition-dataqualityjobinput
        /// Required: True
        /// UpdateType: Immutable
        /// Type: DataQualityJobInput
        /// </summary>
        [Required]
        public Union<Humidifier.SageMaker.DataQualityJobDefinitionTypes.DataQualityJobInput, BaseFunction>? DataQualityJobInput { get; set; }

        /// <summary>
        /// DataQualityAppSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-dataqualityjobdefinition.html#cfn-sagemaker-dataqualityjobdefinition-dataqualityappspecification
        /// Required: True
        /// UpdateType: Immutable
        /// Type: DataQualityAppSpecification
        /// </summary>
        [Required]
        public Union<Humidifier.SageMaker.DataQualityJobDefinitionTypes.DataQualityAppSpecification, BaseFunction>? DataQualityAppSpecification { get; set; }
        /// <summary>
        /// EndpointName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-dataqualityjobdefinition.html#cfn-sagemaker-dataqualityjobdefinition-endpointname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EndpointName { get; set; }
        /// <summary>
        /// StoppingCondition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-dataqualityjobdefinition.html#cfn-sagemaker-dataqualityjobdefinition-stoppingcondition
        /// Required: False
        /// UpdateType: Immutable
        /// Type: StoppingCondition
        /// </summary>
        public Union<Humidifier.SageMaker.DataQualityJobDefinitionTypes.StoppingCondition, BaseFunction>? StoppingCondition { get; set; }
        /// <summary>
        /// JobDefinitionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-dataqualityjobdefinition.html#cfn-sagemaker-dataqualityjobdefinition-jobdefinitionname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? JobDefinitionName { get; set; }

        /// <summary>
        /// JobResources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-dataqualityjobdefinition.html#cfn-sagemaker-dataqualityjobdefinition-jobresources
        /// Required: True
        /// UpdateType: Immutable
        /// Type: MonitoringResources
        /// </summary>
        [Required]
        public Union<Humidifier.SageMaker.DataQualityJobDefinitionTypes.MonitoringResources, BaseFunction>? JobResources { get; set; }
        /// <summary>
        /// NetworkConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-dataqualityjobdefinition.html#cfn-sagemaker-dataqualityjobdefinition-networkconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: NetworkConfig
        /// </summary>
        public Union<Humidifier.SageMaker.DataQualityJobDefinitionTypes.NetworkConfig, BaseFunction>? NetworkConfig { get; set; }

        /// <summary>
        /// DataQualityJobOutputConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-dataqualityjobdefinition.html#cfn-sagemaker-dataqualityjobdefinition-dataqualityjoboutputconfig
        /// Required: True
        /// UpdateType: Immutable
        /// Type: MonitoringOutputConfig
        /// </summary>
        [Required]
        public Union<Humidifier.SageMaker.DataQualityJobDefinitionTypes.MonitoringOutputConfig, BaseFunction>? DataQualityJobOutputConfig { get; set; }
        /// <summary>
        /// DataQualityBaselineConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-dataqualityjobdefinition.html#cfn-sagemaker-dataqualityjobdefinition-dataqualitybaselineconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: DataQualityBaselineConfig
        /// </summary>
        public Union<Humidifier.SageMaker.DataQualityJobDefinitionTypes.DataQualityBaselineConfig, BaseFunction>? DataQualityBaselineConfig { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-dataqualityjobdefinition.html#cfn-sagemaker-dataqualityjobdefinition-rolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-dataqualityjobdefinition.html#cfn-sagemaker-dataqualityjobdefinition-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace DataQualityJobDefinitionTypes
    {
        public class BatchTransformInput : Humidifier.Base.BaseSubResource, IHaveSageMakerDataQualityJobDefinitionTypesDatasetFormatDatasetFormat, IHaveS3DataDistributionType, IHaveDataCapturedDestinationS3Uri, IHaveS3InputMode, IHaveLocalPath, IHaveExcludeFeaturesAttribute
        {
            /// <summary>
            /// DatasetFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-batchtransforminput.html#cfn-sagemaker-dataqualityjobdefinition-batchtransforminput-datasetformat
            /// Required: True
            /// UpdateType: Immutable
            /// Type: DatasetFormat
            /// </summary>
            public Union<Humidifier.SageMaker.DataQualityJobDefinitionTypes.DatasetFormat, BaseFunction>? DatasetFormat { get; set; }
            /// <summary>
            /// S3DataDistributionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-batchtransforminput.html#cfn-sagemaker-dataqualityjobdefinition-batchtransforminput-s3datadistributiontype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3DataDistributionType { get; set; }
            /// <summary>
            /// DataCapturedDestinationS3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-batchtransforminput.html#cfn-sagemaker-dataqualityjobdefinition-batchtransforminput-datacaptureddestinations3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataCapturedDestinationS3Uri { get; set; }
            /// <summary>
            /// S3InputMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-batchtransforminput.html#cfn-sagemaker-dataqualityjobdefinition-batchtransforminput-s3inputmode
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3InputMode { get; set; }
            /// <summary>
            /// LocalPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-batchtransforminput.html#cfn-sagemaker-dataqualityjobdefinition-batchtransforminput-localpath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LocalPath { get; set; }
            /// <summary>
            /// ExcludeFeaturesAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-batchtransforminput.html#cfn-sagemaker-dataqualityjobdefinition-batchtransforminput-excludefeaturesattribute
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExcludeFeaturesAttribute { get; set; }
        }

        public class ClusterConfig : Humidifier.Base.BaseSubResource, IHaveInstanceCount_Integer, IHaveVolumeSizeInGB_Integer, IHaveVolumeKmsKeyId, IHaveInstanceType
        {
            /// <summary>
            /// InstanceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-clusterconfig.html#cfn-sagemaker-dataqualityjobdefinition-clusterconfig-instancecount
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? InstanceCount { get; set; }
            /// <summary>
            /// VolumeSizeInGB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-clusterconfig.html#cfn-sagemaker-dataqualityjobdefinition-clusterconfig-volumesizeingb
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? VolumeSizeInGB { get; set; }
            /// <summary>
            /// VolumeKmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-clusterconfig.html#cfn-sagemaker-dataqualityjobdefinition-clusterconfig-volumekmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VolumeKmsKeyId { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-clusterconfig.html#cfn-sagemaker-dataqualityjobdefinition-clusterconfig-instancetype
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-constraintsresource.html#cfn-sagemaker-dataqualityjobdefinition-constraintsresource-s3uri
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-csv.html#cfn-sagemaker-dataqualityjobdefinition-csv-header
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Header { get; set; }
        }

        public class DataQualityAppSpecification : Humidifier.Base.BaseSubResource, IHaveStringListOfContainerEntrypoint, IHavePostAnalyticsProcessorSourceUri, IHaveRecordPreprocessorSourceUri, IHaveStringDictionaryOfEnvironment, IHaveImageUri, IHaveStringListOfContainerArguments
        {
            /// <summary>
            /// ContainerEntrypoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-dataqualityappspecification.html#cfn-sagemaker-dataqualityjobdefinition-dataqualityappspecification-containerentrypoint
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ContainerEntrypoint { get; set; }
            /// <summary>
            /// PostAnalyticsProcessorSourceUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-dataqualityappspecification.html#cfn-sagemaker-dataqualityjobdefinition-dataqualityappspecification-postanalyticsprocessorsourceuri
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PostAnalyticsProcessorSourceUri { get; set; }
            /// <summary>
            /// RecordPreprocessorSourceUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-dataqualityappspecification.html#cfn-sagemaker-dataqualityjobdefinition-dataqualityappspecification-recordpreprocessorsourceuri
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RecordPreprocessorSourceUri { get; set; }
            /// <summary>
            /// Environment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-dataqualityappspecification.html#cfn-sagemaker-dataqualityjobdefinition-dataqualityappspecification-environment
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Environment { get; set; }
            /// <summary>
            /// ImageUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-dataqualityappspecification.html#cfn-sagemaker-dataqualityjobdefinition-dataqualityappspecification-imageuri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImageUri { get; set; }
            /// <summary>
            /// ContainerArguments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-dataqualityappspecification.html#cfn-sagemaker-dataqualityjobdefinition-dataqualityappspecification-containerarguments
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ContainerArguments { get; set; }
        }

        public class DataQualityBaselineConfig : Humidifier.Base.BaseSubResource, IHaveSageMakerDataQualityJobDefinitionTypesStatisticsResourceStatisticsResource, IHaveSageMakerDataQualityJobDefinitionTypesConstraintsResourceConstraintsResource, IHaveBaseliningJobName
        {
            /// <summary>
            /// StatisticsResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-dataqualitybaselineconfig.html#cfn-sagemaker-dataqualityjobdefinition-dataqualitybaselineconfig-statisticsresource
            /// Required: False
            /// UpdateType: Immutable
            /// Type: StatisticsResource
            /// </summary>
            public Union<Humidifier.SageMaker.DataQualityJobDefinitionTypes.StatisticsResource, BaseFunction>? StatisticsResource { get; set; }
            /// <summary>
            /// ConstraintsResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-dataqualitybaselineconfig.html#cfn-sagemaker-dataqualityjobdefinition-dataqualitybaselineconfig-constraintsresource
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ConstraintsResource
            /// </summary>
            public Union<Humidifier.SageMaker.DataQualityJobDefinitionTypes.ConstraintsResource, BaseFunction>? ConstraintsResource { get; set; }
            /// <summary>
            /// BaseliningJobName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-dataqualitybaselineconfig.html#cfn-sagemaker-dataqualityjobdefinition-dataqualitybaselineconfig-baseliningjobname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BaseliningJobName { get; set; }
        }

        public class DataQualityJobInput : Humidifier.Base.BaseSubResource, IHaveSageMakerDataQualityJobDefinitionTypesBatchTransformInputBatchTransformInput, IHaveSageMakerDataQualityJobDefinitionTypesEndpointInputEndpointInput
        {
            /// <summary>
            /// BatchTransformInput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-dataqualityjobinput.html#cfn-sagemaker-dataqualityjobdefinition-dataqualityjobinput-batchtransforminput
            /// Required: False
            /// UpdateType: Immutable
            /// Type: BatchTransformInput
            /// </summary>
            public Union<Humidifier.SageMaker.DataQualityJobDefinitionTypes.BatchTransformInput, BaseFunction>? BatchTransformInput { get; set; }
            /// <summary>
            /// EndpointInput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-dataqualityjobinput.html#cfn-sagemaker-dataqualityjobdefinition-dataqualityjobinput-endpointinput
            /// Required: False
            /// UpdateType: Immutable
            /// Type: EndpointInput
            /// </summary>
            public Union<Humidifier.SageMaker.DataQualityJobDefinitionTypes.EndpointInput, BaseFunction>? EndpointInput { get; set; }
        }

        public class DatasetFormat : Humidifier.Base.BaseSubResource, IHaveParquet_Boolean, IHaveSageMakerDataQualityJobDefinitionTypesCsvCsv, IHaveSageMakerDataQualityJobDefinitionTypesJsonJson
        {
            /// <summary>
            /// Parquet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-datasetformat.html#cfn-sagemaker-dataqualityjobdefinition-datasetformat-parquet
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Parquet { get; set; }
            /// <summary>
            /// Csv
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-datasetformat.html#cfn-sagemaker-dataqualityjobdefinition-datasetformat-csv
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Csv
            /// </summary>
            public Union<Humidifier.SageMaker.DataQualityJobDefinitionTypes.Csv, BaseFunction>? Csv { get; set; }
            /// <summary>
            /// Json
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-datasetformat.html#cfn-sagemaker-dataqualityjobdefinition-datasetformat-json
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Json
            /// </summary>
            public Union<Humidifier.SageMaker.DataQualityJobDefinitionTypes.Json, BaseFunction>? Json { get; set; }
        }

        public class EndpointInput : Humidifier.Base.BaseSubResource, IHaveS3DataDistributionType, IHaveEndpointName, IHaveS3InputMode, IHaveLocalPath, IHaveExcludeFeaturesAttribute
        {
            /// <summary>
            /// S3DataDistributionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-endpointinput.html#cfn-sagemaker-dataqualityjobdefinition-endpointinput-s3datadistributiontype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3DataDistributionType { get; set; }
            /// <summary>
            /// EndpointName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-endpointinput.html#cfn-sagemaker-dataqualityjobdefinition-endpointinput-endpointname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndpointName { get; set; }
            /// <summary>
            /// S3InputMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-endpointinput.html#cfn-sagemaker-dataqualityjobdefinition-endpointinput-s3inputmode
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3InputMode { get; set; }
            /// <summary>
            /// LocalPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-endpointinput.html#cfn-sagemaker-dataqualityjobdefinition-endpointinput-localpath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LocalPath { get; set; }
            /// <summary>
            /// ExcludeFeaturesAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-endpointinput.html#cfn-sagemaker-dataqualityjobdefinition-endpointinput-excludefeaturesattribute
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExcludeFeaturesAttribute { get; set; }
        }

        public class Json : Humidifier.Base.BaseSubResource, IHaveLine_Boolean
        {
            /// <summary>
            /// Line
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-json.html#cfn-sagemaker-dataqualityjobdefinition-json-line
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Line { get; set; }
        }

        public class MonitoringOutput : Humidifier.Base.BaseSubResource, IHaveSageMakerDataQualityJobDefinitionTypesS3OutputS3Output
        {
            /// <summary>
            /// S3Output
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-monitoringoutput.html#cfn-sagemaker-dataqualityjobdefinition-monitoringoutput-s3output
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3Output
            /// </summary>
            public Union<Humidifier.SageMaker.DataQualityJobDefinitionTypes.S3Output, BaseFunction>? S3Output { get; set; }
        }

        public class MonitoringOutputConfig : Humidifier.Base.BaseSubResource, IHaveKmsKeyId, IHaveListOfSageMakerDataQualityJobDefinitionTypesMonitoringOutputMonitoringOutputs
        {
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-monitoringoutputconfig.html#cfn-sagemaker-dataqualityjobdefinition-monitoringoutputconfig-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
            /// <summary>
            /// MonitoringOutputs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-monitoringoutputconfig.html#cfn-sagemaker-dataqualityjobdefinition-monitoringoutputconfig-monitoringoutputs
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: MonitoringOutput
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.DataQualityJobDefinitionTypes.MonitoringOutput>, IReadOnlyList<Union<Humidifier.SageMaker.DataQualityJobDefinitionTypes.MonitoringOutput, BaseFunction>>, BaseFunction>? MonitoringOutputs { get; set; }
        }

        public class MonitoringResources : Humidifier.Base.BaseSubResource, IHaveSageMakerDataQualityJobDefinitionTypesClusterConfigClusterConfig
        {
            /// <summary>
            /// ClusterConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-monitoringresources.html#cfn-sagemaker-dataqualityjobdefinition-monitoringresources-clusterconfig
            /// Required: True
            /// UpdateType: Immutable
            /// Type: ClusterConfig
            /// </summary>
            public Union<Humidifier.SageMaker.DataQualityJobDefinitionTypes.ClusterConfig, BaseFunction>? ClusterConfig { get; set; }
        }

        public class NetworkConfig : Humidifier.Base.BaseSubResource, IHaveEnableNetworkIsolation_Boolean, IHaveEnableInterContainerTrafficEncryption_Boolean, IHaveSageMakerDataQualityJobDefinitionTypesVpcConfigVpcConfig
        {
            /// <summary>
            /// EnableNetworkIsolation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-networkconfig.html#cfn-sagemaker-dataqualityjobdefinition-networkconfig-enablenetworkisolation
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableNetworkIsolation { get; set; }
            /// <summary>
            /// EnableInterContainerTrafficEncryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-networkconfig.html#cfn-sagemaker-dataqualityjobdefinition-networkconfig-enableintercontainertrafficencryption
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableInterContainerTrafficEncryption { get; set; }
            /// <summary>
            /// VpcConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-networkconfig.html#cfn-sagemaker-dataqualityjobdefinition-networkconfig-vpcconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: VpcConfig
            /// </summary>
            public Union<Humidifier.SageMaker.DataQualityJobDefinitionTypes.VpcConfig, BaseFunction>? VpcConfig { get; set; }
        }

        public class S3Output : Humidifier.Base.BaseSubResource, IHaveS3Uri, IHaveLocalPath, IHaveS3UploadMode
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-s3output.html#cfn-sagemaker-dataqualityjobdefinition-s3output-s3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
            /// <summary>
            /// LocalPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-s3output.html#cfn-sagemaker-dataqualityjobdefinition-s3output-localpath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LocalPath { get; set; }
            /// <summary>
            /// S3UploadMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-s3output.html#cfn-sagemaker-dataqualityjobdefinition-s3output-s3uploadmode
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3UploadMode { get; set; }
        }

        public class StatisticsResource : Humidifier.Base.BaseSubResource, IHaveS3Uri
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-statisticsresource.html#cfn-sagemaker-dataqualityjobdefinition-statisticsresource-s3uri
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
        }

        public class StoppingCondition : Humidifier.Base.BaseSubResource, IHaveMaxRuntimeInSeconds_Integer
        {
            /// <summary>
            /// MaxRuntimeInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-stoppingcondition.html#cfn-sagemaker-dataqualityjobdefinition-stoppingcondition-maxruntimeinseconds
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-vpcconfig.html#cfn-sagemaker-dataqualityjobdefinition-vpcconfig-subnets
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Subnets { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-dataqualityjobdefinition-vpcconfig.html#cfn-sagemaker-dataqualityjobdefinition-vpcconfig-securitygroupids
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        }
    }
}