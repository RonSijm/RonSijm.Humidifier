namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using ProcessingJobTypes;

    public class ProcessingJob : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveSageMakerProcessingJobTypesProcessingResourcesProcessingResources, IHaveSageMakerProcessingJobTypesStoppingConditionStoppingCondition, IHaveSageMakerProcessingJobTypesExperimentConfigExperimentConfig, IHaveListOfSageMakerProcessingJobTypesProcessingInputsObjectProcessingInputs, IHaveSageMakerProcessingJobTypesNetworkConfigNetworkConfig, IHaveSageMakerProcessingJobTypesProcessingOutputConfigProcessingOutputConfig, IHaveStringDictionaryOfEnvironment, IHaveSageMakerProcessingJobTypesAppSpecificationAppSpecification, IHaveProcessingJobName, IHaveRoleArn
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
        public Union<Humidifier.SageMaker.ProcessingJobTypes.ProcessingResources, BaseFunction>? ProcessingResources { get; set; }
        /// <summary>
        /// StoppingCondition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-processingjob.html#cfn-sagemaker-processingjob-stoppingcondition
        /// Required: False
        /// UpdateType: Immutable
        /// Type: StoppingCondition
        /// </summary>
        public Union<Humidifier.SageMaker.ProcessingJobTypes.StoppingCondition, BaseFunction>? StoppingCondition { get; set; }
        /// <summary>
        /// ExperimentConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-processingjob.html#cfn-sagemaker-processingjob-experimentconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ExperimentConfig
        /// </summary>
        public Union<Humidifier.SageMaker.ProcessingJobTypes.ExperimentConfig, BaseFunction>? ExperimentConfig { get; set; }
        /// <summary>
        /// ProcessingInputs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-processingjob.html#cfn-sagemaker-processingjob-processinginputs
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: ProcessingInputsObject
        /// </summary>
        public Union<IReadOnlyList<Humidifier.SageMaker.ProcessingJobTypes.ProcessingInputsObject>, IReadOnlyList<Union<Humidifier.SageMaker.ProcessingJobTypes.ProcessingInputsObject, BaseFunction>>, BaseFunction>? ProcessingInputs { get; set; }
        /// <summary>
        /// NetworkConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-processingjob.html#cfn-sagemaker-processingjob-networkconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: NetworkConfig
        /// </summary>
        public Union<Humidifier.SageMaker.ProcessingJobTypes.NetworkConfig, BaseFunction>? NetworkConfig { get; set; }
        /// <summary>
        /// ProcessingOutputConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-processingjob.html#cfn-sagemaker-processingjob-processingoutputconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ProcessingOutputConfig
        /// </summary>
        public Union<Humidifier.SageMaker.ProcessingJobTypes.ProcessingOutputConfig, BaseFunction>? ProcessingOutputConfig { get; set; }
        /// <summary>
        /// Environment
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-processingjob.html#cfn-sagemaker-processingjob-environment
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Environment { get; set; }

        /// <summary>
        /// AppSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-processingjob.html#cfn-sagemaker-processingjob-appspecification
        /// Required: True
        /// UpdateType: Immutable
        /// Type: AppSpecification
        /// </summary>
        [Required]
        public Union<Humidifier.SageMaker.ProcessingJobTypes.AppSpecification, BaseFunction>? AppSpecification { get; set; }
        public Union<string, BaseFunction>? ProcessingJobName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-processingjob.html#cfn-sagemaker-processingjob-rolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-processingjob.html#cfn-sagemaker-processingjob-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ProcessingJobTypes
    {
        public class AppSpecification : Humidifier.Base.BaseSubResource, IHaveStringListOfContainerEntrypoint, IHaveImageUri, IHaveStringListOfContainerArguments
        {
            /// <summary>
            /// ContainerEntrypoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-appspecification.html#cfn-sagemaker-processingjob-appspecification-containerentrypoint
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ContainerEntrypoint { get; set; }
            /// <summary>
            /// ImageUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-appspecification.html#cfn-sagemaker-processingjob-appspecification-imageuri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImageUri { get; set; }
            /// <summary>
            /// ContainerArguments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-appspecification.html#cfn-sagemaker-processingjob-appspecification-containerarguments
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ContainerArguments { get; set; }
        }

        public class AthenaDatasetDefinition : Humidifier.Base.BaseSubResource, IHaveWorkGroup, IHaveOutputS3Uri, IHaveKmsKeyId, IHaveQueryString, IHaveDatabase, IHaveOutputFormat, IHaveOutputCompression, IHaveCatalog
        {
            /// <summary>
            /// WorkGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-athenadatasetdefinition.html#cfn-sagemaker-processingjob-athenadatasetdefinition-workgroup
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WorkGroup { get; set; }
            /// <summary>
            /// OutputS3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-athenadatasetdefinition.html#cfn-sagemaker-processingjob-athenadatasetdefinition-outputs3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputS3Uri { get; set; }
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-athenadatasetdefinition.html#cfn-sagemaker-processingjob-athenadatasetdefinition-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
            /// <summary>
            /// QueryString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-athenadatasetdefinition.html#cfn-sagemaker-processingjob-athenadatasetdefinition-querystring
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? QueryString { get; set; }
            /// <summary>
            /// Database
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-athenadatasetdefinition.html#cfn-sagemaker-processingjob-athenadatasetdefinition-database
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Database { get; set; }
            /// <summary>
            /// OutputFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-athenadatasetdefinition.html#cfn-sagemaker-processingjob-athenadatasetdefinition-outputformat
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputFormat { get; set; }
            /// <summary>
            /// OutputCompression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-athenadatasetdefinition.html#cfn-sagemaker-processingjob-athenadatasetdefinition-outputcompression
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputCompression { get; set; }
            /// <summary>
            /// Catalog
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-athenadatasetdefinition.html#cfn-sagemaker-processingjob-athenadatasetdefinition-catalog
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Catalog { get; set; }
        }

        public class ClusterConfig : Humidifier.Base.BaseSubResource, IHaveInstanceCount_Integer, IHaveVolumeSizeInGB_Integer, IHaveVolumeKmsKeyId, IHaveInstanceType
        {
            /// <summary>
            /// InstanceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-clusterconfig.html#cfn-sagemaker-processingjob-clusterconfig-instancecount
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? InstanceCount { get; set; }
            /// <summary>
            /// VolumeSizeInGB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-clusterconfig.html#cfn-sagemaker-processingjob-clusterconfig-volumesizeingb
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? VolumeSizeInGB { get; set; }
            /// <summary>
            /// VolumeKmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-clusterconfig.html#cfn-sagemaker-processingjob-clusterconfig-volumekmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VolumeKmsKeyId { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-clusterconfig.html#cfn-sagemaker-processingjob-clusterconfig-instancetype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceType { get; set; }
        }

        public class DatasetDefinition : Humidifier.Base.BaseSubResource, IHaveInputMode, IHaveSageMakerProcessingJobTypesRedshiftDatasetDefinitionRedshiftDatasetDefinition, IHaveSageMakerProcessingJobTypesAthenaDatasetDefinitionAthenaDatasetDefinition, IHaveLocalPath, IHaveDataDistributionType
        {
            /// <summary>
            /// InputMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-datasetdefinition.html#cfn-sagemaker-processingjob-datasetdefinition-inputmode
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputMode { get; set; }
            /// <summary>
            /// RedshiftDatasetDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-datasetdefinition.html#cfn-sagemaker-processingjob-datasetdefinition-redshiftdatasetdefinition
            /// Required: False
            /// UpdateType: Immutable
            /// Type: RedshiftDatasetDefinition
            /// </summary>
            public Union<Humidifier.SageMaker.ProcessingJobTypes.RedshiftDatasetDefinition, BaseFunction>? RedshiftDatasetDefinition { get; set; }
            /// <summary>
            /// AthenaDatasetDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-datasetdefinition.html#cfn-sagemaker-processingjob-datasetdefinition-athenadatasetdefinition
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AthenaDatasetDefinition
            /// </summary>
            public Union<Humidifier.SageMaker.ProcessingJobTypes.AthenaDatasetDefinition, BaseFunction>? AthenaDatasetDefinition { get; set; }
            /// <summary>
            /// LocalPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-datasetdefinition.html#cfn-sagemaker-processingjob-datasetdefinition-localpath
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LocalPath { get; set; }
            /// <summary>
            /// DataDistributionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-datasetdefinition.html#cfn-sagemaker-processingjob-datasetdefinition-datadistributiontype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataDistributionType { get; set; }
        }

        public class ExperimentConfig : Humidifier.Base.BaseSubResource, IHaveTrialName, IHaveExperimentName, IHaveTrialComponentDisplayName, IHaveRunName
        {
            /// <summary>
            /// TrialName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-experimentconfig.html#cfn-sagemaker-processingjob-experimentconfig-trialname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TrialName { get; set; }
            /// <summary>
            /// ExperimentName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-experimentconfig.html#cfn-sagemaker-processingjob-experimentconfig-experimentname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExperimentName { get; set; }
            /// <summary>
            /// TrialComponentDisplayName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-experimentconfig.html#cfn-sagemaker-processingjob-experimentconfig-trialcomponentdisplayname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TrialComponentDisplayName { get; set; }
            /// <summary>
            /// RunName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-experimentconfig.html#cfn-sagemaker-processingjob-experimentconfig-runname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RunName { get; set; }
        }

        public class FeatureStoreOutput : Humidifier.Base.BaseSubResource, IHaveFeatureGroupName
        {
            /// <summary>
            /// FeatureGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-featurestoreoutput.html#cfn-sagemaker-processingjob-featurestoreoutput-featuregroupname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FeatureGroupName { get; set; }
        }

        public class NetworkConfig : Humidifier.Base.BaseSubResource, IHaveEnableNetworkIsolation_Boolean, IHaveEnableInterContainerTrafficEncryption_Boolean, IHaveSageMakerProcessingJobTypesVpcConfigVpcConfig
        {
            /// <summary>
            /// EnableNetworkIsolation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-networkconfig.html#cfn-sagemaker-processingjob-networkconfig-enablenetworkisolation
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableNetworkIsolation { get; set; }
            /// <summary>
            /// EnableInterContainerTrafficEncryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-networkconfig.html#cfn-sagemaker-processingjob-networkconfig-enableintercontainertrafficencryption
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableInterContainerTrafficEncryption { get; set; }
            /// <summary>
            /// VpcConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-networkconfig.html#cfn-sagemaker-processingjob-networkconfig-vpcconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: VpcConfig
            /// </summary>
            public Union<Humidifier.SageMaker.ProcessingJobTypes.VpcConfig, BaseFunction>? VpcConfig { get; set; }
        }

        public class ProcessingInputsObject : Humidifier.Base.BaseSubResource, IHaveAppManaged_Boolean, IHaveInputName, IHaveSageMakerProcessingJobTypesDatasetDefinitionDatasetDefinition, IHaveSageMakerProcessingJobTypesS3InputS3Input
        {
            /// <summary>
            /// AppManaged
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-processinginputsobject.html#cfn-sagemaker-processingjob-processinginputsobject-appmanaged
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AppManaged { get; set; }
            /// <summary>
            /// InputName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-processinginputsobject.html#cfn-sagemaker-processingjob-processinginputsobject-inputname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputName { get; set; }
            /// <summary>
            /// DatasetDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-processinginputsobject.html#cfn-sagemaker-processingjob-processinginputsobject-datasetdefinition
            /// Required: False
            /// UpdateType: Immutable
            /// Type: DatasetDefinition
            /// </summary>
            public Union<Humidifier.SageMaker.ProcessingJobTypes.DatasetDefinition, BaseFunction>? DatasetDefinition { get; set; }
            /// <summary>
            /// S3Input
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-processinginputsobject.html#cfn-sagemaker-processingjob-processinginputsobject-s3input
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3Input
            /// </summary>
            public Union<Humidifier.SageMaker.ProcessingJobTypes.S3Input, BaseFunction>? S3Input { get; set; }
        }

        public class ProcessingOutputConfig : Humidifier.Base.BaseSubResource, IHaveKmsKeyId, IHaveListOfSageMakerProcessingJobTypesProcessingOutputsObjectOutputs
        {
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-processingoutputconfig.html#cfn-sagemaker-processingjob-processingoutputconfig-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
            /// <summary>
            /// Outputs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-processingoutputconfig.html#cfn-sagemaker-processingjob-processingoutputconfig-outputs
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ProcessingOutputsObject
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.ProcessingJobTypes.ProcessingOutputsObject>, IReadOnlyList<Union<Humidifier.SageMaker.ProcessingJobTypes.ProcessingOutputsObject, BaseFunction>>, BaseFunction>? Outputs { get; set; }
        }

        public class ProcessingOutputsObject : Humidifier.Base.BaseSubResource, IHaveSageMakerProcessingJobTypesS3OutputS3Output, IHaveAppManaged_Boolean, IHaveSageMakerProcessingJobTypesFeatureStoreOutputFeatureStoreOutput, IHaveOutputName
        {
            /// <summary>
            /// S3Output
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-processingoutputsobject.html#cfn-sagemaker-processingjob-processingoutputsobject-s3output
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3Output
            /// </summary>
            public Union<Humidifier.SageMaker.ProcessingJobTypes.S3Output, BaseFunction>? S3Output { get; set; }
            /// <summary>
            /// AppManaged
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-processingoutputsobject.html#cfn-sagemaker-processingjob-processingoutputsobject-appmanaged
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AppManaged { get; set; }
            /// <summary>
            /// FeatureStoreOutput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-processingoutputsobject.html#cfn-sagemaker-processingjob-processingoutputsobject-featurestoreoutput
            /// Required: False
            /// UpdateType: Immutable
            /// Type: FeatureStoreOutput
            /// </summary>
            public Union<Humidifier.SageMaker.ProcessingJobTypes.FeatureStoreOutput, BaseFunction>? FeatureStoreOutput { get; set; }
            /// <summary>
            /// OutputName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-processingoutputsobject.html#cfn-sagemaker-processingjob-processingoutputsobject-outputname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputName { get; set; }
        }

        public class ProcessingResources : Humidifier.Base.BaseSubResource, IHaveSageMakerProcessingJobTypesClusterConfigClusterConfig
        {
            /// <summary>
            /// ClusterConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-processingresources.html#cfn-sagemaker-processingjob-processingresources-clusterconfig
            /// Required: True
            /// UpdateType: Immutable
            /// Type: ClusterConfig
            /// </summary>
            public Union<Humidifier.SageMaker.ProcessingJobTypes.ClusterConfig, BaseFunction>? ClusterConfig { get; set; }
        }

        public class RedshiftDatasetDefinition : Humidifier.Base.BaseSubResource, IHaveOutputS3Uri, IHaveKmsKeyId, IHaveClusterId, IHaveQueryString, IHaveDatabase, IHaveOutputFormat, IHaveOutputCompression, IHaveClusterRoleArn, IHaveDbUser
        {
            /// <summary>
            /// OutputS3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-redshiftdatasetdefinition.html#cfn-sagemaker-processingjob-redshiftdatasetdefinition-outputs3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputS3Uri { get; set; }
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-redshiftdatasetdefinition.html#cfn-sagemaker-processingjob-redshiftdatasetdefinition-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
            /// <summary>
            /// ClusterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-redshiftdatasetdefinition.html#cfn-sagemaker-processingjob-redshiftdatasetdefinition-clusterid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClusterId { get; set; }
            /// <summary>
            /// QueryString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-redshiftdatasetdefinition.html#cfn-sagemaker-processingjob-redshiftdatasetdefinition-querystring
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? QueryString { get; set; }
            /// <summary>
            /// Database
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-redshiftdatasetdefinition.html#cfn-sagemaker-processingjob-redshiftdatasetdefinition-database
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Database { get; set; }
            /// <summary>
            /// OutputFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-redshiftdatasetdefinition.html#cfn-sagemaker-processingjob-redshiftdatasetdefinition-outputformat
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputFormat { get; set; }
            /// <summary>
            /// OutputCompression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-redshiftdatasetdefinition.html#cfn-sagemaker-processingjob-redshiftdatasetdefinition-outputcompression
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputCompression { get; set; }
            /// <summary>
            /// ClusterRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-redshiftdatasetdefinition.html#cfn-sagemaker-processingjob-redshiftdatasetdefinition-clusterrolearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClusterRoleArn { get; set; }
            /// <summary>
            /// DbUser
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-redshiftdatasetdefinition.html#cfn-sagemaker-processingjob-redshiftdatasetdefinition-dbuser
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DbUser { get; set; }
        }

        public class S3Input : Humidifier.Base.BaseSubResource, IHaveS3CompressionType, IHaveS3DataDistributionType, IHaveS3Uri, IHaveS3InputMode, IHaveLocalPath, IHaveS3DataType
        {
            /// <summary>
            /// S3CompressionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-s3input.html#cfn-sagemaker-processingjob-s3input-s3compressiontype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3CompressionType { get; set; }
            /// <summary>
            /// S3DataDistributionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-s3input.html#cfn-sagemaker-processingjob-s3input-s3datadistributiontype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3DataDistributionType { get; set; }
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-s3input.html#cfn-sagemaker-processingjob-s3input-s3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
            /// <summary>
            /// S3InputMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-s3input.html#cfn-sagemaker-processingjob-s3input-s3inputmode
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3InputMode { get; set; }
            /// <summary>
            /// LocalPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-s3input.html#cfn-sagemaker-processingjob-s3input-localpath
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LocalPath { get; set; }
            /// <summary>
            /// S3DataType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-s3input.html#cfn-sagemaker-processingjob-s3input-s3datatype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3DataType { get; set; }
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
            public Union<string, BaseFunction>? S3Uri { get; set; }
            /// <summary>
            /// LocalPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-s3output.html#cfn-sagemaker-processingjob-s3output-localpath
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LocalPath { get; set; }
            /// <summary>
            /// S3UploadMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-s3output.html#cfn-sagemaker-processingjob-s3output-s3uploadmode
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3UploadMode { get; set; }
        }

        public class StoppingCondition : Humidifier.Base.BaseSubResource, IHaveMaxRuntimeInSeconds_Integer
        {
            /// <summary>
            /// MaxRuntimeInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-stoppingcondition.html#cfn-sagemaker-processingjob-stoppingcondition-maxruntimeinseconds
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-vpcconfig.html#cfn-sagemaker-processingjob-vpcconfig-subnets
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Subnets { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-processingjob-vpcconfig.html#cfn-sagemaker-processingjob-vpcconfig-securitygroupids
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        }
    }
}