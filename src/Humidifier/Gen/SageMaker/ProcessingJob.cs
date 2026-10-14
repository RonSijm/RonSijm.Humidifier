namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using ProcessingJobTypes;

    public class ProcessingJob : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveRoleArn
    {
        public class Attributes
        {
            public static string MonitoringScheduleArn =  "MonitoringScheduleArn" ;
            public static string TrainingJobArn =  "TrainingJobArn" ;
            public static string ProcessingStartTime =  "ProcessingStartTime" ;
            public static string ProcessingJobArn =  "ProcessingJobArn" ;
            public static string AutoMLJobArn =  "AutoMLJobArn" ;
            public static string ExitMessage =  "ExitMessage" ;
            public static string FailureReason =  "FailureReason" ;
            public static string CreationTime =  "CreationTime" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string ProcessingEndTime =  "ProcessingEndTime" ;
            public static string ProcessingJobStatus =  "ProcessingJobStatus" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.ProcessingJob; }

        /// <summary>
        /// ProcessingResources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-processingjob.html#cfn-sagemaker-processingjob-processingresources
        /// Required: True
        /// UpdateType: Immutable
        /// Type: ProcessingResources
        /// </summary>
        [Required]
        public Humidifier.SageMaker.ProcessingJobTypes.ProcessingResources ProcessingResources { get; set; }
        /// <summary>
        /// StoppingCondition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-processingjob.html#cfn-sagemaker-processingjob-stoppingcondition
        /// Required: False
        /// UpdateType: Immutable
        /// Type: StoppingCondition
        /// </summary>
        public Humidifier.SageMaker.ProcessingJobTypes.StoppingCondition StoppingCondition { get; set; }
        /// <summary>
        /// ExperimentConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-processingjob.html#cfn-sagemaker-processingjob-experimentconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ExperimentConfig
        /// </summary>
        public Humidifier.SageMaker.ProcessingJobTypes.ExperimentConfig ExperimentConfig { get; set; }
        /// <summary>
        /// ProcessingInputs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-processingjob.html#cfn-sagemaker-processingjob-processinginputs
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: ProcessingInputsObject
        /// </summary>
        public List<Humidifier.SageMaker.ProcessingJobTypes.ProcessingInputsObject> ProcessingInputs { get; set; }
        /// <summary>
        /// NetworkConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-processingjob.html#cfn-sagemaker-processingjob-networkconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: NetworkConfig
        /// </summary>
        public Humidifier.SageMaker.ProcessingJobTypes.NetworkConfig NetworkConfig { get; set; }
        /// <summary>
        /// ProcessingOutputConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-processingjob.html#cfn-sagemaker-processingjob-processingoutputconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ProcessingOutputConfig
        /// </summary>
        public Humidifier.SageMaker.ProcessingJobTypes.ProcessingOutputConfig ProcessingOutputConfig { get; set; }
        /// <summary>
        /// Environment
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-processingjob.html#cfn-sagemaker-processingjob-environment
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Environment { get; set; }

        /// <summary>
        /// AppSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-processingjob.html#cfn-sagemaker-processingjob-appspecification
        /// Required: True
        /// UpdateType: Immutable
        /// Type: AppSpecification
        /// </summary>
        [Required]
        public Humidifier.SageMaker.ProcessingJobTypes.AppSpecification AppSpecification { get; set; }
        public dynamic ProcessingJobName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-processingjob.html#cfn-sagemaker-processingjob-rolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-processingjob.html#cfn-sagemaker-processingjob-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace ProcessingJobTypes
    {
        public class AppSpecification : Humidifier.Base.BaseSubResource, IHaveImageUri, IHaveContainerEntrypoint, IHaveContainerArguments
        {
            /// <summary>
            /// ContainerEntrypoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-appspecification.html#cfn-sagemaker-processingjob-appspecification-containerentrypoint
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ContainerEntrypoint { get; set; }
            /// <summary>
            /// ImageUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-appspecification.html#cfn-sagemaker-processingjob-appspecification-imageuri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ImageUri { get; set; }
            /// <summary>
            /// ContainerArguments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-appspecification.html#cfn-sagemaker-processingjob-appspecification-containerarguments
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ContainerArguments { get; set; }
        }

        public class AthenaDatasetDefinition : Humidifier.Base.BaseSubResource, IHaveKmsKeyId, IHaveDatabase, IHaveQueryString, IHaveCatalog, IHaveOutputFormat, IHaveWorkGroup
        {
            /// <summary>
            /// WorkGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-athenadatasetdefinition.html#cfn-sagemaker-processingjob-athenadatasetdefinition-workgroup
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WorkGroup { get; set; }
            /// <summary>
            /// OutputS3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-athenadatasetdefinition.html#cfn-sagemaker-processingjob-athenadatasetdefinition-outputs3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OutputS3Uri { get; set; }
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-athenadatasetdefinition.html#cfn-sagemaker-processingjob-athenadatasetdefinition-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKeyId { get; set; }
            /// <summary>
            /// QueryString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-athenadatasetdefinition.html#cfn-sagemaker-processingjob-athenadatasetdefinition-querystring
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic QueryString { get; set; }
            /// <summary>
            /// Database
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-athenadatasetdefinition.html#cfn-sagemaker-processingjob-athenadatasetdefinition-database
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Database { get; set; }
            /// <summary>
            /// OutputFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-athenadatasetdefinition.html#cfn-sagemaker-processingjob-athenadatasetdefinition-outputformat
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OutputFormat { get; set; }
            /// <summary>
            /// OutputCompression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-athenadatasetdefinition.html#cfn-sagemaker-processingjob-athenadatasetdefinition-outputcompression
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OutputCompression { get; set; }
            /// <summary>
            /// Catalog
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-athenadatasetdefinition.html#cfn-sagemaker-processingjob-athenadatasetdefinition-catalog
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Catalog { get; set; }
        }

        public class ClusterConfig : Humidifier.Base.BaseSubResource, IHaveInstanceType, IHaveInstanceCount, IHaveVolumeSizeInGB, IHaveVolumeKmsKeyId
        {
            /// <summary>
            /// InstanceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-clusterconfig.html#cfn-sagemaker-processingjob-clusterconfig-instancecount
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic InstanceCount { get; set; }
            /// <summary>
            /// VolumeSizeInGB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-clusterconfig.html#cfn-sagemaker-processingjob-clusterconfig-volumesizeingb
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic VolumeSizeInGB { get; set; }
            /// <summary>
            /// VolumeKmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-clusterconfig.html#cfn-sagemaker-processingjob-clusterconfig-volumekmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VolumeKmsKeyId { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-clusterconfig.html#cfn-sagemaker-processingjob-clusterconfig-instancetype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InstanceType { get; set; }
        }

        public class DatasetDefinition : Humidifier.Base.BaseSubResource, IHaveLocalPath
        {
            /// <summary>
            /// InputMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-datasetdefinition.html#cfn-sagemaker-processingjob-datasetdefinition-inputmode
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InputMode { get; set; }
            /// <summary>
            /// RedshiftDatasetDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-datasetdefinition.html#cfn-sagemaker-processingjob-datasetdefinition-redshiftdatasetdefinition
            /// Required: False
            /// UpdateType: Immutable
            /// Type: RedshiftDatasetDefinition
            /// </summary>
            public Humidifier.SageMaker.ProcessingJobTypes.RedshiftDatasetDefinition RedshiftDatasetDefinition { get; set; }
            /// <summary>
            /// AthenaDatasetDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-datasetdefinition.html#cfn-sagemaker-processingjob-datasetdefinition-athenadatasetdefinition
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AthenaDatasetDefinition
            /// </summary>
            public Humidifier.SageMaker.ProcessingJobTypes.AthenaDatasetDefinition AthenaDatasetDefinition { get; set; }
            /// <summary>
            /// LocalPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-datasetdefinition.html#cfn-sagemaker-processingjob-datasetdefinition-localpath
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LocalPath { get; set; }
            /// <summary>
            /// DataDistributionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-datasetdefinition.html#cfn-sagemaker-processingjob-datasetdefinition-datadistributiontype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataDistributionType { get; set; }
        }

        public class ExperimentConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TrialName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-experimentconfig.html#cfn-sagemaker-processingjob-experimentconfig-trialname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TrialName { get; set; }
            /// <summary>
            /// ExperimentName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-experimentconfig.html#cfn-sagemaker-processingjob-experimentconfig-experimentname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExperimentName { get; set; }
            /// <summary>
            /// TrialComponentDisplayName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-experimentconfig.html#cfn-sagemaker-processingjob-experimentconfig-trialcomponentdisplayname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TrialComponentDisplayName { get; set; }
            /// <summary>
            /// RunName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-experimentconfig.html#cfn-sagemaker-processingjob-experimentconfig-runname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RunName { get; set; }
        }

        public class FeatureStoreOutput : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FeatureGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-featurestoreoutput.html#cfn-sagemaker-processingjob-featurestoreoutput-featuregroupname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FeatureGroupName { get; set; }
        }

        public class NetworkConfig : Humidifier.Base.BaseSubResource, IHaveEnableNetworkIsolation, IHaveEnableInterContainerTrafficEncryption
        {
            /// <summary>
            /// EnableNetworkIsolation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-networkconfig.html#cfn-sagemaker-processingjob-networkconfig-enablenetworkisolation
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EnableNetworkIsolation { get; set; }
            /// <summary>
            /// EnableInterContainerTrafficEncryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-networkconfig.html#cfn-sagemaker-processingjob-networkconfig-enableintercontainertrafficencryption
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EnableInterContainerTrafficEncryption { get; set; }
            /// <summary>
            /// VpcConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-networkconfig.html#cfn-sagemaker-processingjob-networkconfig-vpcconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: VpcConfig
            /// </summary>
            public Humidifier.SageMaker.ProcessingJobTypes.VpcConfig VpcConfig { get; set; }
        }

        public class ProcessingInputsObject : Humidifier.Base.BaseSubResource, IHaveInputName
        {
            /// <summary>
            /// AppManaged
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-processinginputsobject.html#cfn-sagemaker-processingjob-processinginputsobject-appmanaged
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AppManaged { get; set; }
            /// <summary>
            /// InputName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-processinginputsobject.html#cfn-sagemaker-processingjob-processinginputsobject-inputname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InputName { get; set; }
            /// <summary>
            /// DatasetDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-processinginputsobject.html#cfn-sagemaker-processingjob-processinginputsobject-datasetdefinition
            /// Required: False
            /// UpdateType: Immutable
            /// Type: DatasetDefinition
            /// </summary>
            public Humidifier.SageMaker.ProcessingJobTypes.DatasetDefinition DatasetDefinition { get; set; }
            /// <summary>
            /// S3Input
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-processinginputsobject.html#cfn-sagemaker-processingjob-processinginputsobject-s3input
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3Input
            /// </summary>
            public Humidifier.SageMaker.ProcessingJobTypes.S3Input S3Input { get; set; }
        }

        public class ProcessingOutputConfig : Humidifier.Base.BaseSubResource, IHaveKmsKeyId
        {
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-processingoutputconfig.html#cfn-sagemaker-processingjob-processingoutputconfig-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKeyId { get; set; }
            /// <summary>
            /// Outputs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-processingoutputconfig.html#cfn-sagemaker-processingjob-processingoutputconfig-outputs
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ProcessingOutputsObject
            /// </summary>
            public List<Humidifier.SageMaker.ProcessingJobTypes.ProcessingOutputsObject> Outputs { get; set; }
        }

        public class ProcessingOutputsObject : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3Output
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-processingoutputsobject.html#cfn-sagemaker-processingjob-processingoutputsobject-s3output
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3Output
            /// </summary>
            public Humidifier.SageMaker.ProcessingJobTypes.S3Output S3Output { get; set; }
            /// <summary>
            /// AppManaged
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-processingoutputsobject.html#cfn-sagemaker-processingjob-processingoutputsobject-appmanaged
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AppManaged { get; set; }
            /// <summary>
            /// FeatureStoreOutput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-processingoutputsobject.html#cfn-sagemaker-processingjob-processingoutputsobject-featurestoreoutput
            /// Required: False
            /// UpdateType: Immutable
            /// Type: FeatureStoreOutput
            /// </summary>
            public Humidifier.SageMaker.ProcessingJobTypes.FeatureStoreOutput FeatureStoreOutput { get; set; }
            /// <summary>
            /// OutputName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-processingoutputsobject.html#cfn-sagemaker-processingjob-processingoutputsobject-outputname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OutputName { get; set; }
        }

        public class ProcessingResources : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ClusterConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-processingresources.html#cfn-sagemaker-processingjob-processingresources-clusterconfig
            /// Required: True
            /// UpdateType: Immutable
            /// Type: ClusterConfig
            /// </summary>
            public Humidifier.SageMaker.ProcessingJobTypes.ClusterConfig ClusterConfig { get; set; }
        }

        public class RedshiftDatasetDefinition : Humidifier.Base.BaseSubResource, IHaveKmsKeyId, IHaveDatabase, IHaveQueryString, IHaveClusterId, IHaveOutputFormat, IHaveDbUser
        {
            /// <summary>
            /// OutputS3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-redshiftdatasetdefinition.html#cfn-sagemaker-processingjob-redshiftdatasetdefinition-outputs3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OutputS3Uri { get; set; }
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-redshiftdatasetdefinition.html#cfn-sagemaker-processingjob-redshiftdatasetdefinition-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKeyId { get; set; }
            /// <summary>
            /// ClusterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-redshiftdatasetdefinition.html#cfn-sagemaker-processingjob-redshiftdatasetdefinition-clusterid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClusterId { get; set; }
            /// <summary>
            /// QueryString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-redshiftdatasetdefinition.html#cfn-sagemaker-processingjob-redshiftdatasetdefinition-querystring
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic QueryString { get; set; }
            /// <summary>
            /// Database
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-redshiftdatasetdefinition.html#cfn-sagemaker-processingjob-redshiftdatasetdefinition-database
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Database { get; set; }
            /// <summary>
            /// OutputFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-redshiftdatasetdefinition.html#cfn-sagemaker-processingjob-redshiftdatasetdefinition-outputformat
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OutputFormat { get; set; }
            /// <summary>
            /// OutputCompression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-redshiftdatasetdefinition.html#cfn-sagemaker-processingjob-redshiftdatasetdefinition-outputcompression
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OutputCompression { get; set; }
            /// <summary>
            /// ClusterRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-redshiftdatasetdefinition.html#cfn-sagemaker-processingjob-redshiftdatasetdefinition-clusterrolearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClusterRoleArn { get; set; }
            /// <summary>
            /// DbUser
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-redshiftdatasetdefinition.html#cfn-sagemaker-processingjob-redshiftdatasetdefinition-dbuser
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DbUser { get; set; }
        }

        public class S3Input : Humidifier.Base.BaseSubResource, IHaveS3Uri, IHaveLocalPath, IHaveS3DataDistributionType, IHaveS3InputMode, IHaveS3DataType
        {
            /// <summary>
            /// S3CompressionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-s3input.html#cfn-sagemaker-processingjob-s3input-s3compressiontype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3CompressionType { get; set; }
            /// <summary>
            /// S3DataDistributionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-s3input.html#cfn-sagemaker-processingjob-s3input-s3datadistributiontype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3DataDistributionType { get; set; }
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-s3input.html#cfn-sagemaker-processingjob-s3input-s3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3Uri { get; set; }
            /// <summary>
            /// S3InputMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-s3input.html#cfn-sagemaker-processingjob-s3input-s3inputmode
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3InputMode { get; set; }
            /// <summary>
            /// LocalPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-s3input.html#cfn-sagemaker-processingjob-s3input-localpath
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LocalPath { get; set; }
            /// <summary>
            /// S3DataType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-s3input.html#cfn-sagemaker-processingjob-s3input-s3datatype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3DataType { get; set; }
        }

        public class S3Output : Humidifier.Base.BaseSubResource, IHaveS3Uri, IHaveLocalPath, IHaveS3UploadMode
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-s3output.html#cfn-sagemaker-processingjob-s3output-s3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3Uri { get; set; }
            /// <summary>
            /// LocalPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-s3output.html#cfn-sagemaker-processingjob-s3output-localpath
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LocalPath { get; set; }
            /// <summary>
            /// S3UploadMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-s3output.html#cfn-sagemaker-processingjob-s3output-s3uploadmode
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3UploadMode { get; set; }
        }

        public class StoppingCondition : Humidifier.Base.BaseSubResource, IHaveMaxRuntimeInSeconds
        {
            /// <summary>
            /// MaxRuntimeInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-stoppingcondition.html#cfn-sagemaker-processingjob-stoppingcondition-maxruntimeinseconds
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxRuntimeInSeconds { get; set; }
        }

        public class VpcConfig : Humidifier.Base.BaseSubResource, IHaveSecurityGroupIds, IHaveSubnets
        {
            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-vpcconfig.html#cfn-sagemaker-processingjob-vpcconfig-subnets
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Subnets { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-vpcconfig.html#cfn-sagemaker-processingjob-vpcconfig-securitygroupids
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroupIds { get; set; }
        }
    }
}