namespace Humidifier.SageMaker
{
    using System.Collections.Generic;
    using ModelBiasJobDefinitionTypes;

    public class ModelBiasJobDefinition : Humidifier.Resource, IHaveTags
    {
        public class Attributes
        {
            public static string JobDefinitionArn =  "JobDefinitionArn" ;
            public static string CreationTime =  "CreationTime" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::SageMaker::ModelBiasJobDefinition";
            }
        }

        /// <summary>
        /// ModelBiasJobInput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelbiasjobdefinition.html#cfn-sagemaker-modelbiasjobdefinition-modelbiasjobinput
        /// Required: True
        /// UpdateType: Immutable
        /// Type: ModelBiasJobInput
        /// </summary>
        public ModelBiasJobInput ModelBiasJobInput { get; set; }
        /// <summary>
        /// ModelBiasJobOutputConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelbiasjobdefinition.html#cfn-sagemaker-modelbiasjobdefinition-modelbiasjoboutputconfig
        /// Required: True
        /// UpdateType: Immutable
        /// Type: MonitoringOutputConfig
        /// </summary>
        public MonitoringOutputConfig ModelBiasJobOutputConfig { get; set; }
        /// <summary>
        /// EndpointName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelbiasjobdefinition.html#cfn-sagemaker-modelbiasjobdefinition-endpointname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic EndpointName { get; set; }
        /// <summary>
        /// StoppingCondition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelbiasjobdefinition.html#cfn-sagemaker-modelbiasjobdefinition-stoppingcondition
        /// Required: False
        /// UpdateType: Immutable
        /// Type: StoppingCondition
        /// </summary>
        public StoppingCondition StoppingCondition { get; set; }
        /// <summary>
        /// JobDefinitionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelbiasjobdefinition.html#cfn-sagemaker-modelbiasjobdefinition-jobdefinitionname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic JobDefinitionName { get; set; }
        /// <summary>
        /// JobResources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelbiasjobdefinition.html#cfn-sagemaker-modelbiasjobdefinition-jobresources
        /// Required: True
        /// UpdateType: Immutable
        /// Type: MonitoringResources
        /// </summary>
        public MonitoringResources JobResources { get; set; }
        /// <summary>
        /// NetworkConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelbiasjobdefinition.html#cfn-sagemaker-modelbiasjobdefinition-networkconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: NetworkConfig
        /// </summary>
        public NetworkConfig NetworkConfig { get; set; }
        /// <summary>
        /// ModelBiasBaselineConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelbiasjobdefinition.html#cfn-sagemaker-modelbiasjobdefinition-modelbiasbaselineconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ModelBiasBaselineConfig
        /// </summary>
        public ModelBiasBaselineConfig ModelBiasBaselineConfig { get; set; }
        /// <summary>
        /// ModelBiasAppSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelbiasjobdefinition.html#cfn-sagemaker-modelbiasjobdefinition-modelbiasappspecification
        /// Required: True
        /// UpdateType: Immutable
        /// Type: ModelBiasAppSpecification
        /// </summary>
        public ModelBiasAppSpecification ModelBiasAppSpecification { get; set; }
        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelbiasjobdefinition.html#cfn-sagemaker-modelbiasjobdefinition-rolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-modelbiasjobdefinition.html#cfn-sagemaker-modelbiasjobdefinition-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace ModelBiasJobDefinitionTypes
    {
        public class BatchTransformInput
        {
            /// <summary>
            /// DatasetFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-batchtransforminput.html#cfn-sagemaker-modelbiasjobdefinition-batchtransforminput-datasetformat
            /// Required: True
            /// UpdateType: Immutable
            /// Type: DatasetFormat
            /// </summary>
            public DatasetFormat DatasetFormat { get; set; }
            /// <summary>
            /// S3DataDistributionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-batchtransforminput.html#cfn-sagemaker-modelbiasjobdefinition-batchtransforminput-s3datadistributiontype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3DataDistributionType { get; set; }
            /// <summary>
            /// StartTimeOffset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-batchtransforminput.html#cfn-sagemaker-modelbiasjobdefinition-batchtransforminput-starttimeoffset
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StartTimeOffset { get; set; }
            /// <summary>
            /// EndTimeOffset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-batchtransforminput.html#cfn-sagemaker-modelbiasjobdefinition-batchtransforminput-endtimeoffset
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EndTimeOffset { get; set; }
            /// <summary>
            /// ProbabilityThresholdAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-batchtransforminput.html#cfn-sagemaker-modelbiasjobdefinition-batchtransforminput-probabilitythresholdattribute
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ProbabilityThresholdAttribute { get; set; }
            /// <summary>
            /// InferenceAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-batchtransforminput.html#cfn-sagemaker-modelbiasjobdefinition-batchtransforminput-inferenceattribute
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InferenceAttribute { get; set; }
            /// <summary>
            /// DataCapturedDestinationS3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-batchtransforminput.html#cfn-sagemaker-modelbiasjobdefinition-batchtransforminput-datacaptureddestinations3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataCapturedDestinationS3Uri { get; set; }
            /// <summary>
            /// S3InputMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-batchtransforminput.html#cfn-sagemaker-modelbiasjobdefinition-batchtransforminput-s3inputmode
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3InputMode { get; set; }
            /// <summary>
            /// LocalPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-batchtransforminput.html#cfn-sagemaker-modelbiasjobdefinition-batchtransforminput-localpath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LocalPath { get; set; }
            /// <summary>
            /// ProbabilityAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-batchtransforminput.html#cfn-sagemaker-modelbiasjobdefinition-batchtransforminput-probabilityattribute
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ProbabilityAttribute { get; set; }
            /// <summary>
            /// FeaturesAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-batchtransforminput.html#cfn-sagemaker-modelbiasjobdefinition-batchtransforminput-featuresattribute
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FeaturesAttribute { get; set; }
        }

        public class ClusterConfig
        {
            /// <summary>
            /// InstanceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-clusterconfig.html#cfn-sagemaker-modelbiasjobdefinition-clusterconfig-instancecount
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic InstanceCount { get; set; }
            /// <summary>
            /// VolumeSizeInGB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-clusterconfig.html#cfn-sagemaker-modelbiasjobdefinition-clusterconfig-volumesizeingb
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic VolumeSizeInGB { get; set; }
            /// <summary>
            /// VolumeKmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-clusterconfig.html#cfn-sagemaker-modelbiasjobdefinition-clusterconfig-volumekmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VolumeKmsKeyId { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-clusterconfig.html#cfn-sagemaker-modelbiasjobdefinition-clusterconfig-instancetype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InstanceType { get; set; }
        }

        public class ConstraintsResource
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-constraintsresource.html#cfn-sagemaker-modelbiasjobdefinition-constraintsresource-s3uri
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3Uri { get; set; }
        }

        public class Csv
        {
            /// <summary>
            /// Header
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-csv.html#cfn-sagemaker-modelbiasjobdefinition-csv-header
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Header { get; set; }
        }

        public class DatasetFormat
        {
            /// <summary>
            /// Parquet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-datasetformat.html#cfn-sagemaker-modelbiasjobdefinition-datasetformat-parquet
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Parquet { get; set; }
            /// <summary>
            /// Csv
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-datasetformat.html#cfn-sagemaker-modelbiasjobdefinition-datasetformat-csv
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Csv
            /// </summary>
            public Csv Csv { get; set; }
            /// <summary>
            /// Json
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-datasetformat.html#cfn-sagemaker-modelbiasjobdefinition-datasetformat-json
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Json
            /// </summary>
            public Json Json { get; set; }
        }

        public class EndpointInput
        {
            /// <summary>
            /// S3DataDistributionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-endpointinput.html#cfn-sagemaker-modelbiasjobdefinition-endpointinput-s3datadistributiontype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3DataDistributionType { get; set; }
            /// <summary>
            /// StartTimeOffset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-endpointinput.html#cfn-sagemaker-modelbiasjobdefinition-endpointinput-starttimeoffset
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StartTimeOffset { get; set; }
            /// <summary>
            /// EndTimeOffset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-endpointinput.html#cfn-sagemaker-modelbiasjobdefinition-endpointinput-endtimeoffset
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EndTimeOffset { get; set; }
            /// <summary>
            /// ProbabilityThresholdAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-endpointinput.html#cfn-sagemaker-modelbiasjobdefinition-endpointinput-probabilitythresholdattribute
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ProbabilityThresholdAttribute { get; set; }
            /// <summary>
            /// EndpointName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-endpointinput.html#cfn-sagemaker-modelbiasjobdefinition-endpointinput-endpointname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EndpointName { get; set; }
            /// <summary>
            /// InferenceAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-endpointinput.html#cfn-sagemaker-modelbiasjobdefinition-endpointinput-inferenceattribute
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InferenceAttribute { get; set; }
            /// <summary>
            /// S3InputMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-endpointinput.html#cfn-sagemaker-modelbiasjobdefinition-endpointinput-s3inputmode
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3InputMode { get; set; }
            /// <summary>
            /// LocalPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-endpointinput.html#cfn-sagemaker-modelbiasjobdefinition-endpointinput-localpath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LocalPath { get; set; }
            /// <summary>
            /// ProbabilityAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-endpointinput.html#cfn-sagemaker-modelbiasjobdefinition-endpointinput-probabilityattribute
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ProbabilityAttribute { get; set; }
            /// <summary>
            /// FeaturesAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-endpointinput.html#cfn-sagemaker-modelbiasjobdefinition-endpointinput-featuresattribute
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FeaturesAttribute { get; set; }
        }

        public class Json
        {
            /// <summary>
            /// Line
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-json.html#cfn-sagemaker-modelbiasjobdefinition-json-line
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Line { get; set; }
        }

        public class ModelBiasAppSpecification
        {
            /// <summary>
            /// ConfigUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-modelbiasappspecification.html#cfn-sagemaker-modelbiasjobdefinition-modelbiasappspecification-configuri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConfigUri { get; set; }
            /// <summary>
            /// Environment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-modelbiasappspecification.html#cfn-sagemaker-modelbiasjobdefinition-modelbiasappspecification-environment
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> Environment { get; set; }
            /// <summary>
            /// ImageUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-modelbiasappspecification.html#cfn-sagemaker-modelbiasjobdefinition-modelbiasappspecification-imageuri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ImageUri { get; set; }
        }

        public class ModelBiasBaselineConfig
        {
            /// <summary>
            /// ConstraintsResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-modelbiasbaselineconfig.html#cfn-sagemaker-modelbiasjobdefinition-modelbiasbaselineconfig-constraintsresource
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ConstraintsResource
            /// </summary>
            public ConstraintsResource ConstraintsResource { get; set; }
            /// <summary>
            /// BaseliningJobName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-modelbiasbaselineconfig.html#cfn-sagemaker-modelbiasjobdefinition-modelbiasbaselineconfig-baseliningjobname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BaseliningJobName { get; set; }
        }

        public class ModelBiasJobInput
        {
            /// <summary>
            /// GroundTruthS3Input
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-modelbiasjobinput.html#cfn-sagemaker-modelbiasjobdefinition-modelbiasjobinput-groundtruths3input
            /// Required: True
            /// UpdateType: Immutable
            /// Type: MonitoringGroundTruthS3Input
            /// </summary>
            public MonitoringGroundTruthS3Input GroundTruthS3Input { get; set; }
            /// <summary>
            /// BatchTransformInput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-modelbiasjobinput.html#cfn-sagemaker-modelbiasjobdefinition-modelbiasjobinput-batchtransforminput
            /// Required: False
            /// UpdateType: Immutable
            /// Type: BatchTransformInput
            /// </summary>
            public BatchTransformInput BatchTransformInput { get; set; }
            /// <summary>
            /// EndpointInput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-modelbiasjobinput.html#cfn-sagemaker-modelbiasjobdefinition-modelbiasjobinput-endpointinput
            /// Required: False
            /// UpdateType: Immutable
            /// Type: EndpointInput
            /// </summary>
            public EndpointInput EndpointInput { get; set; }
        }

        public class MonitoringGroundTruthS3Input
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-monitoringgroundtruths3input.html#cfn-sagemaker-modelbiasjobdefinition-monitoringgroundtruths3input-s3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3Uri { get; set; }
        }

        public class MonitoringOutput
        {
            /// <summary>
            /// S3Output
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-monitoringoutput.html#cfn-sagemaker-modelbiasjobdefinition-monitoringoutput-s3output
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3Output
            /// </summary>
            public S3Output S3Output { get; set; }
        }

        public class MonitoringOutputConfig
        {
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-monitoringoutputconfig.html#cfn-sagemaker-modelbiasjobdefinition-monitoringoutputconfig-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKeyId { get; set; }
            /// <summary>
            /// MonitoringOutputs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-monitoringoutputconfig.html#cfn-sagemaker-modelbiasjobdefinition-monitoringoutputconfig-monitoringoutputs
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: MonitoringOutput
            /// </summary>
            public List<MonitoringOutput> MonitoringOutputs { get; set; }
        }

        public class MonitoringResources
        {
            /// <summary>
            /// ClusterConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-monitoringresources.html#cfn-sagemaker-modelbiasjobdefinition-monitoringresources-clusterconfig
            /// Required: True
            /// UpdateType: Immutable
            /// Type: ClusterConfig
            /// </summary>
            public ClusterConfig ClusterConfig { get; set; }
        }

        public class NetworkConfig
        {
            /// <summary>
            /// EnableNetworkIsolation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-networkconfig.html#cfn-sagemaker-modelbiasjobdefinition-networkconfig-enablenetworkisolation
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EnableNetworkIsolation { get; set; }
            /// <summary>
            /// EnableInterContainerTrafficEncryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-networkconfig.html#cfn-sagemaker-modelbiasjobdefinition-networkconfig-enableintercontainertrafficencryption
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EnableInterContainerTrafficEncryption { get; set; }
            /// <summary>
            /// VpcConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-networkconfig.html#cfn-sagemaker-modelbiasjobdefinition-networkconfig-vpcconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: VpcConfig
            /// </summary>
            public VpcConfig VpcConfig { get; set; }
        }

        public class S3Output
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-s3output.html#cfn-sagemaker-modelbiasjobdefinition-s3output-s3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3Uri { get; set; }
            /// <summary>
            /// LocalPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-s3output.html#cfn-sagemaker-modelbiasjobdefinition-s3output-localpath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LocalPath { get; set; }
            /// <summary>
            /// S3UploadMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-s3output.html#cfn-sagemaker-modelbiasjobdefinition-s3output-s3uploadmode
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3UploadMode { get; set; }
        }

        public class StoppingCondition
        {
            /// <summary>
            /// MaxRuntimeInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-stoppingcondition.html#cfn-sagemaker-modelbiasjobdefinition-stoppingcondition-maxruntimeinseconds
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxRuntimeInSeconds { get; set; }
        }

        public class VpcConfig
        {
            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-vpcconfig.html#cfn-sagemaker-modelbiasjobdefinition-vpcconfig-subnets
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Subnets { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-modelbiasjobdefinition-vpcconfig.html#cfn-sagemaker-modelbiasjobdefinition-vpcconfig-securitygroupids
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroupIds { get; set; }
        }
    }
}