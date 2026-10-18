namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using MonitoringScheduleTypes;

    public class MonitoringSchedule : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveMonitoringScheduleStatus, IHaveSageMakerMonitoringScheduleTypesMonitoringScheduleConfigMonitoringScheduleConfig, IHaveMonitoringScheduleName, IHaveEndpointName, IHaveFailureReason, IHaveSageMakerMonitoringScheduleTypesMonitoringExecutionSummaryLastMonitoringExecutionSummary
    {
        public class Attributes
        {
            public static string MonitoringScheduleArn =  "MonitoringScheduleArn" ;
            public static string CreationTime =  "CreationTime" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.MonitoringSchedule; }
        /// <summary>
        /// MonitoringScheduleStatus
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-monitoringschedule.html#cfn-sagemaker-monitoringschedule-monitoringschedulestatus
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? MonitoringScheduleStatus { get; set; }

        /// <summary>
        /// MonitoringScheduleConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-monitoringschedule.html#cfn-sagemaker-monitoringschedule-monitoringscheduleconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: MonitoringScheduleConfig
        /// </summary>
        [Required]
        public Union<Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringScheduleConfig, BaseFunction>? MonitoringScheduleConfig { get; set; }
        public Union<string, BaseFunction>? MonitoringScheduleName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// EndpointName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-monitoringschedule.html#cfn-sagemaker-monitoringschedule-endpointname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EndpointName { get; set; }
        /// <summary>
        /// FailureReason
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-monitoringschedule.html#cfn-sagemaker-monitoringschedule-failurereason
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? FailureReason { get; set; }
        /// <summary>
        /// LastMonitoringExecutionSummary
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-monitoringschedule.html#cfn-sagemaker-monitoringschedule-lastmonitoringexecutionsummary
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MonitoringExecutionSummary
        /// </summary>
        public Union<Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringExecutionSummary, BaseFunction>? LastMonitoringExecutionSummary { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-monitoringschedule.html#cfn-sagemaker-monitoringschedule-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace MonitoringScheduleTypes
    {
        public class BaselineConfig : Humidifier.Base.BaseSubResource, IHaveSageMakerMonitoringScheduleTypesStatisticsResourceStatisticsResource, IHaveSageMakerMonitoringScheduleTypesConstraintsResourceConstraintsResource
        {
            /// <summary>
            /// StatisticsResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-baselineconfig.html#cfn-sagemaker-monitoringschedule-baselineconfig-statisticsresource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StatisticsResource
            /// </summary>
            public Union<Humidifier.SageMaker.MonitoringScheduleTypes.StatisticsResource, BaseFunction>? StatisticsResource { get; set; }
            /// <summary>
            /// ConstraintsResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-baselineconfig.html#cfn-sagemaker-monitoringschedule-baselineconfig-constraintsresource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConstraintsResource
            /// </summary>
            public Union<Humidifier.SageMaker.MonitoringScheduleTypes.ConstraintsResource, BaseFunction>? ConstraintsResource { get; set; }
        }

        public class BatchTransformInput : Humidifier.Base.BaseSubResource, IHaveSageMakerMonitoringScheduleTypesDatasetFormatDatasetFormat, IHaveS3DataDistributionType, IHaveDataCapturedDestinationS3Uri, IHaveS3InputMode, IHaveLocalPath, IHaveExcludeFeaturesAttribute
        {
            /// <summary>
            /// DatasetFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-batchtransforminput.html#cfn-sagemaker-monitoringschedule-batchtransforminput-datasetformat
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DatasetFormat
            /// </summary>
            public Union<Humidifier.SageMaker.MonitoringScheduleTypes.DatasetFormat, BaseFunction>? DatasetFormat { get; set; }
            /// <summary>
            /// S3DataDistributionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-batchtransforminput.html#cfn-sagemaker-monitoringschedule-batchtransforminput-s3datadistributiontype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3DataDistributionType { get; set; }
            /// <summary>
            /// DataCapturedDestinationS3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-batchtransforminput.html#cfn-sagemaker-monitoringschedule-batchtransforminput-datacaptureddestinations3uri
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataCapturedDestinationS3Uri { get; set; }
            /// <summary>
            /// S3InputMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-batchtransforminput.html#cfn-sagemaker-monitoringschedule-batchtransforminput-s3inputmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3InputMode { get; set; }
            /// <summary>
            /// LocalPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-batchtransforminput.html#cfn-sagemaker-monitoringschedule-batchtransforminput-localpath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LocalPath { get; set; }
            /// <summary>
            /// ExcludeFeaturesAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-batchtransforminput.html#cfn-sagemaker-monitoringschedule-batchtransforminput-excludefeaturesattribute
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExcludeFeaturesAttribute { get; set; }
        }

        public class ClusterConfig : Humidifier.Base.BaseSubResource, IHaveInstanceCount_Integer, IHaveVolumeSizeInGB_Integer, IHaveVolumeKmsKeyId, IHaveInstanceType
        {
            /// <summary>
            /// InstanceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-clusterconfig.html#cfn-sagemaker-monitoringschedule-clusterconfig-instancecount
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? InstanceCount { get; set; }
            /// <summary>
            /// VolumeSizeInGB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-clusterconfig.html#cfn-sagemaker-monitoringschedule-clusterconfig-volumesizeingb
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? VolumeSizeInGB { get; set; }
            /// <summary>
            /// VolumeKmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-clusterconfig.html#cfn-sagemaker-monitoringschedule-clusterconfig-volumekmskeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VolumeKmsKeyId { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-clusterconfig.html#cfn-sagemaker-monitoringschedule-clusterconfig-instancetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceType { get; set; }
        }

        public class ConstraintsResource : Humidifier.Base.BaseSubResource, IHaveS3Uri
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-constraintsresource.html#cfn-sagemaker-monitoringschedule-constraintsresource-s3uri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
        }

        public class Csv : Humidifier.Base.BaseSubResource, IHaveHeader_Boolean
        {
            /// <summary>
            /// Header
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-csv.html#cfn-sagemaker-monitoringschedule-csv-header
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Header { get; set; }
        }

        public class DatasetFormat : Humidifier.Base.BaseSubResource, IHaveParquet_Boolean, IHaveSageMakerMonitoringScheduleTypesCsvCsv, IHaveSageMakerMonitoringScheduleTypesJsonJson
        {
            /// <summary>
            /// Parquet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-datasetformat.html#cfn-sagemaker-monitoringschedule-datasetformat-parquet
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Parquet { get; set; }
            /// <summary>
            /// Csv
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-datasetformat.html#cfn-sagemaker-monitoringschedule-datasetformat-csv
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Csv
            /// </summary>
            public Union<Humidifier.SageMaker.MonitoringScheduleTypes.Csv, BaseFunction>? Csv { get; set; }
            /// <summary>
            /// Json
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-datasetformat.html#cfn-sagemaker-monitoringschedule-datasetformat-json
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Json
            /// </summary>
            public Union<Humidifier.SageMaker.MonitoringScheduleTypes.Json, BaseFunction>? Json { get; set; }
        }

        public class EndpointInput : Humidifier.Base.BaseSubResource, IHaveS3DataDistributionType, IHaveEndpointName, IHaveS3InputMode, IHaveLocalPath, IHaveExcludeFeaturesAttribute
        {
            /// <summary>
            /// S3DataDistributionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-endpointinput.html#cfn-sagemaker-monitoringschedule-endpointinput-s3datadistributiontype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3DataDistributionType { get; set; }
            /// <summary>
            /// EndpointName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-endpointinput.html#cfn-sagemaker-monitoringschedule-endpointinput-endpointname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndpointName { get; set; }
            /// <summary>
            /// S3InputMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-endpointinput.html#cfn-sagemaker-monitoringschedule-endpointinput-s3inputmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3InputMode { get; set; }
            /// <summary>
            /// LocalPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-endpointinput.html#cfn-sagemaker-monitoringschedule-endpointinput-localpath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LocalPath { get; set; }
            /// <summary>
            /// ExcludeFeaturesAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-endpointinput.html#cfn-sagemaker-monitoringschedule-endpointinput-excludefeaturesattribute
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExcludeFeaturesAttribute { get; set; }
        }

        public class Json : Humidifier.Base.BaseSubResource, IHaveLine_Boolean
        {
            /// <summary>
            /// Line
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-json.html#cfn-sagemaker-monitoringschedule-json-line
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Line { get; set; }
        }

        public class MonitoringAppSpecification : Humidifier.Base.BaseSubResource, IHaveStringListOfContainerEntrypoint, IHavePostAnalyticsProcessorSourceUri, IHaveRecordPreprocessorSourceUri, IHaveImageUri, IHaveStringListOfContainerArguments
        {
            /// <summary>
            /// ContainerEntrypoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-monitoringappspecification.html#cfn-sagemaker-monitoringschedule-monitoringappspecification-containerentrypoint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ContainerEntrypoint { get; set; }
            /// <summary>
            /// PostAnalyticsProcessorSourceUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-monitoringappspecification.html#cfn-sagemaker-monitoringschedule-monitoringappspecification-postanalyticsprocessorsourceuri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PostAnalyticsProcessorSourceUri { get; set; }
            /// <summary>
            /// RecordPreprocessorSourceUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-monitoringappspecification.html#cfn-sagemaker-monitoringschedule-monitoringappspecification-recordpreprocessorsourceuri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RecordPreprocessorSourceUri { get; set; }
            /// <summary>
            /// ImageUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-monitoringappspecification.html#cfn-sagemaker-monitoringschedule-monitoringappspecification-imageuri
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImageUri { get; set; }
            /// <summary>
            /// ContainerArguments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-monitoringappspecification.html#cfn-sagemaker-monitoringschedule-monitoringappspecification-containerarguments
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ContainerArguments { get; set; }
        }

        public class MonitoringExecutionSummary : Humidifier.Base.BaseSubResource, IHaveScheduledTime, IHaveEndpointName, IHaveMonitoringScheduleName, IHaveProcessingJobArn, IHaveFailureReason, IHaveCreationTime, IHaveLastModifiedTime, IHaveMonitoringExecutionStatus
        {
            /// <summary>
            /// ScheduledTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-monitoringexecutionsummary.html#cfn-sagemaker-monitoringschedule-monitoringexecutionsummary-scheduledtime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScheduledTime { get; set; }
            /// <summary>
            /// EndpointName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-monitoringexecutionsummary.html#cfn-sagemaker-monitoringschedule-monitoringexecutionsummary-endpointname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndpointName { get; set; }
            /// <summary>
            /// MonitoringScheduleName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-monitoringexecutionsummary.html#cfn-sagemaker-monitoringschedule-monitoringexecutionsummary-monitoringschedulename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MonitoringScheduleName { get; set; }
            /// <summary>
            /// ProcessingJobArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-monitoringexecutionsummary.html#cfn-sagemaker-monitoringschedule-monitoringexecutionsummary-processingjobarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProcessingJobArn { get; set; }
            /// <summary>
            /// FailureReason
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-monitoringexecutionsummary.html#cfn-sagemaker-monitoringschedule-monitoringexecutionsummary-failurereason
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FailureReason { get; set; }
            /// <summary>
            /// CreationTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-monitoringexecutionsummary.html#cfn-sagemaker-monitoringschedule-monitoringexecutionsummary-creationtime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreationTime { get; set; }
            /// <summary>
            /// LastModifiedTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-monitoringexecutionsummary.html#cfn-sagemaker-monitoringschedule-monitoringexecutionsummary-lastmodifiedtime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LastModifiedTime { get; set; }
            /// <summary>
            /// MonitoringExecutionStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-monitoringexecutionsummary.html#cfn-sagemaker-monitoringschedule-monitoringexecutionsummary-monitoringexecutionstatus
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MonitoringExecutionStatus { get; set; }
        }

        public class MonitoringInput : Humidifier.Base.BaseSubResource, IHaveSageMakerMonitoringScheduleTypesBatchTransformInputBatchTransformInput, IHaveSageMakerMonitoringScheduleTypesEndpointInputEndpointInput
        {
            /// <summary>
            /// BatchTransformInput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-monitoringinput.html#cfn-sagemaker-monitoringschedule-monitoringinput-batchtransforminput
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BatchTransformInput
            /// </summary>
            public Union<Humidifier.SageMaker.MonitoringScheduleTypes.BatchTransformInput, BaseFunction>? BatchTransformInput { get; set; }
            /// <summary>
            /// EndpointInput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-monitoringinput.html#cfn-sagemaker-monitoringschedule-monitoringinput-endpointinput
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EndpointInput
            /// </summary>
            public Union<Humidifier.SageMaker.MonitoringScheduleTypes.EndpointInput, BaseFunction>? EndpointInput { get; set; }
        }

        public class MonitoringJobDefinition : Humidifier.Base.BaseSubResource, IHaveListOfSageMakerMonitoringScheduleTypesMonitoringInputMonitoringInputs, IHaveSageMakerMonitoringScheduleTypesMonitoringResourcesMonitoringResources, IHaveSageMakerMonitoringScheduleTypesBaselineConfigBaselineConfig, IHaveSageMakerMonitoringScheduleTypesStoppingConditionStoppingCondition, IHaveSageMakerMonitoringScheduleTypesMonitoringAppSpecificationMonitoringAppSpecification, IHaveSageMakerMonitoringScheduleTypesNetworkConfigNetworkConfig, IHaveStringDictionaryOfEnvironment, IHaveSageMakerMonitoringScheduleTypesMonitoringOutputConfigMonitoringOutputConfig, IHaveRoleArn
        {
            /// <summary>
            /// MonitoringInputs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-monitoringjobdefinition.html#cfn-sagemaker-monitoringschedule-monitoringjobdefinition-monitoringinputs
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MonitoringInput
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringInput>, IReadOnlyList<Union<Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringInput, BaseFunction>>, BaseFunction>? MonitoringInputs { get; set; }
            /// <summary>
            /// MonitoringResources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-monitoringjobdefinition.html#cfn-sagemaker-monitoringschedule-monitoringjobdefinition-monitoringresources
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MonitoringResources
            /// </summary>
            public Union<Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringResources, BaseFunction>? MonitoringResources { get; set; }
            /// <summary>
            /// BaselineConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-monitoringjobdefinition.html#cfn-sagemaker-monitoringschedule-monitoringjobdefinition-baselineconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BaselineConfig
            /// </summary>
            public Union<Humidifier.SageMaker.MonitoringScheduleTypes.BaselineConfig, BaseFunction>? BaselineConfig { get; set; }
            /// <summary>
            /// StoppingCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-monitoringjobdefinition.html#cfn-sagemaker-monitoringschedule-monitoringjobdefinition-stoppingcondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StoppingCondition
            /// </summary>
            public Union<Humidifier.SageMaker.MonitoringScheduleTypes.StoppingCondition, BaseFunction>? StoppingCondition { get; set; }
            /// <summary>
            /// MonitoringAppSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-monitoringjobdefinition.html#cfn-sagemaker-monitoringschedule-monitoringjobdefinition-monitoringappspecification
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MonitoringAppSpecification
            /// </summary>
            public Union<Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringAppSpecification, BaseFunction>? MonitoringAppSpecification { get; set; }
            /// <summary>
            /// NetworkConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-monitoringjobdefinition.html#cfn-sagemaker-monitoringschedule-monitoringjobdefinition-networkconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NetworkConfig
            /// </summary>
            public Union<Humidifier.SageMaker.MonitoringScheduleTypes.NetworkConfig, BaseFunction>? NetworkConfig { get; set; }
            /// <summary>
            /// Environment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-monitoringjobdefinition.html#cfn-sagemaker-monitoringschedule-monitoringjobdefinition-environment
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Environment { get; set; }
            /// <summary>
            /// MonitoringOutputConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-monitoringjobdefinition.html#cfn-sagemaker-monitoringschedule-monitoringjobdefinition-monitoringoutputconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MonitoringOutputConfig
            /// </summary>
            public Union<Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringOutputConfig, BaseFunction>? MonitoringOutputConfig { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-monitoringjobdefinition.html#cfn-sagemaker-monitoringschedule-monitoringjobdefinition-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class MonitoringOutput : Humidifier.Base.BaseSubResource, IHaveSageMakerMonitoringScheduleTypesS3OutputS3Output
        {
            /// <summary>
            /// S3Output
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-monitoringoutput.html#cfn-sagemaker-monitoringschedule-monitoringoutput-s3output
            /// Required: True
            /// UpdateType: Mutable
            /// Type: S3Output
            /// </summary>
            public Union<Humidifier.SageMaker.MonitoringScheduleTypes.S3Output, BaseFunction>? S3Output { get; set; }
        }

        public class MonitoringOutputConfig : Humidifier.Base.BaseSubResource, IHaveKmsKeyId, IHaveListOfSageMakerMonitoringScheduleTypesMonitoringOutputMonitoringOutputs
        {
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-monitoringoutputconfig.html#cfn-sagemaker-monitoringschedule-monitoringoutputconfig-kmskeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
            /// <summary>
            /// MonitoringOutputs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-monitoringoutputconfig.html#cfn-sagemaker-monitoringschedule-monitoringoutputconfig-monitoringoutputs
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MonitoringOutput
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringOutput>, IReadOnlyList<Union<Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringOutput, BaseFunction>>, BaseFunction>? MonitoringOutputs { get; set; }
        }

        public class MonitoringResources : Humidifier.Base.BaseSubResource, IHaveSageMakerMonitoringScheduleTypesClusterConfigClusterConfig
        {
            /// <summary>
            /// ClusterConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-monitoringresources.html#cfn-sagemaker-monitoringschedule-monitoringresources-clusterconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ClusterConfig
            /// </summary>
            public Union<Humidifier.SageMaker.MonitoringScheduleTypes.ClusterConfig, BaseFunction>? ClusterConfig { get; set; }
        }

        public class MonitoringScheduleConfig : Humidifier.Base.BaseSubResource, IHaveSageMakerMonitoringScheduleTypesScheduleConfigScheduleConfig, IHaveSageMakerMonitoringScheduleTypesMonitoringJobDefinitionMonitoringJobDefinition, IHaveMonitoringJobDefinitionName, IHaveMonitoringType
        {
            /// <summary>
            /// ScheduleConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-monitoringscheduleconfig.html#cfn-sagemaker-monitoringschedule-monitoringscheduleconfig-scheduleconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScheduleConfig
            /// </summary>
            public Union<Humidifier.SageMaker.MonitoringScheduleTypes.ScheduleConfig, BaseFunction>? ScheduleConfig { get; set; }
            /// <summary>
            /// MonitoringJobDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-monitoringscheduleconfig.html#cfn-sagemaker-monitoringschedule-monitoringscheduleconfig-monitoringjobdefinition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MonitoringJobDefinition
            /// </summary>
            public Union<Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringJobDefinition, BaseFunction>? MonitoringJobDefinition { get; set; }
            /// <summary>
            /// MonitoringJobDefinitionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-monitoringscheduleconfig.html#cfn-sagemaker-monitoringschedule-monitoringscheduleconfig-monitoringjobdefinitionname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MonitoringJobDefinitionName { get; set; }
            /// <summary>
            /// MonitoringType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-monitoringscheduleconfig.html#cfn-sagemaker-monitoringschedule-monitoringscheduleconfig-monitoringtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MonitoringType { get; set; }
        }

        public class NetworkConfig : Humidifier.Base.BaseSubResource, IHaveEnableNetworkIsolation_Boolean, IHaveEnableInterContainerTrafficEncryption_Boolean, IHaveSageMakerMonitoringScheduleTypesVpcConfigVpcConfig
        {
            /// <summary>
            /// EnableNetworkIsolation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-networkconfig.html#cfn-sagemaker-monitoringschedule-networkconfig-enablenetworkisolation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableNetworkIsolation { get; set; }
            /// <summary>
            /// EnableInterContainerTrafficEncryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-networkconfig.html#cfn-sagemaker-monitoringschedule-networkconfig-enableintercontainertrafficencryption
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableInterContainerTrafficEncryption { get; set; }
            /// <summary>
            /// VpcConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-networkconfig.html#cfn-sagemaker-monitoringschedule-networkconfig-vpcconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VpcConfig
            /// </summary>
            public Union<Humidifier.SageMaker.MonitoringScheduleTypes.VpcConfig, BaseFunction>? VpcConfig { get; set; }
        }

        public class S3Output : Humidifier.Base.BaseSubResource, IHaveS3Uri, IHaveLocalPath, IHaveS3UploadMode
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-s3output.html#cfn-sagemaker-monitoringschedule-s3output-s3uri
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
            /// <summary>
            /// LocalPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-s3output.html#cfn-sagemaker-monitoringschedule-s3output-localpath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LocalPath { get; set; }
            /// <summary>
            /// S3UploadMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-s3output.html#cfn-sagemaker-monitoringschedule-s3output-s3uploadmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3UploadMode { get; set; }
        }

        public class ScheduleConfig : Humidifier.Base.BaseSubResource, IHaveScheduleExpression, IHaveDataAnalysisStartTime, IHaveDataAnalysisEndTime
        {
            /// <summary>
            /// ScheduleExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-scheduleconfig.html#cfn-sagemaker-monitoringschedule-scheduleconfig-scheduleexpression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScheduleExpression { get; set; }
            /// <summary>
            /// DataAnalysisStartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-scheduleconfig.html#cfn-sagemaker-monitoringschedule-scheduleconfig-dataanalysisstarttime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataAnalysisStartTime { get; set; }
            /// <summary>
            /// DataAnalysisEndTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-scheduleconfig.html#cfn-sagemaker-monitoringschedule-scheduleconfig-dataanalysisendtime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataAnalysisEndTime { get; set; }
        }

        public class StatisticsResource : Humidifier.Base.BaseSubResource, IHaveS3Uri
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-statisticsresource.html#cfn-sagemaker-monitoringschedule-statisticsresource-s3uri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
        }

        public class StoppingCondition : Humidifier.Base.BaseSubResource, IHaveMaxRuntimeInSeconds_Integer
        {
            /// <summary>
            /// MaxRuntimeInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-stoppingcondition.html#cfn-sagemaker-monitoringschedule-stoppingcondition-maxruntimeinseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxRuntimeInSeconds { get; set; }
        }

        public class VpcConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfSubnets, IHaveStringListOfSecurityGroupIds
        {
            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-vpcconfig.html#cfn-sagemaker-monitoringschedule-vpcconfig-subnets
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Subnets { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-monitoringschedule-vpcconfig.html#cfn-sagemaker-monitoringschedule-vpcconfig-securitygroupids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        }
    }
}