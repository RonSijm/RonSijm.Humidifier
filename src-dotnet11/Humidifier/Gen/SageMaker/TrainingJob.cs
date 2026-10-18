namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using TrainingJobTypes;

    public class TrainingJob : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveEnableManagedSpotTraining_Boolean, IHaveStringDictionaryOfHyperParameters, IHaveSageMakerTrainingJobTypesDebugHookConfigDebugHookConfig, IHaveTrainingJobName, IHaveSageMakerTrainingJobTypesAlgorithmSpecificationAlgorithmSpecification, IHaveSageMakerTrainingJobTypesOutputDataConfigOutputDataConfig, IHaveSageMakerTrainingJobTypesVpcConfigVpcConfig, IHaveSageMakerTrainingJobTypesCheckpointConfigCheckpointConfig, IHaveSageMakerTrainingJobTypesProfilerConfigProfilerConfig, IHaveListOfSageMakerTrainingJobTypesChannelInputDataConfig, IHaveSageMakerTrainingJobTypesTensorBoardOutputConfigTensorBoardOutputConfig, IHaveListOfSageMakerTrainingJobTypesProfilerRuleConfigurationProfilerRuleConfigurations, IHaveRoleArn, IHaveSageMakerTrainingJobTypesInfraCheckConfigInfraCheckConfig, IHaveEnableNetworkIsolation_Boolean, IHaveEnableInterContainerTrafficEncryption_Boolean, IHaveSageMakerTrainingJobTypesRemoteDebugConfigRemoteDebugConfig, IHaveSageMakerTrainingJobTypesStoppingConditionStoppingCondition, IHaveSageMakerTrainingJobTypesExperimentConfigExperimentConfig, IHaveListOfSageMakerTrainingJobTypesDebugRuleConfigurationDebugRuleConfigurations, IHaveStringDictionaryOfEnvironment, IHaveSageMakerTrainingJobTypesResourceConfigResourceConfig, IHaveSageMakerTrainingJobTypesRetryStrategyRetryStrategy
    {
        public class Attributes
        {
            public static string TrainingJobStatus =  "TrainingJobStatus" ;
            public static string ProfilingStatus =  "ProfilingStatus" ;
            public static string SecondaryStatus =  "SecondaryStatus" ;
            public static string TrainingJobArn =  "TrainingJobArn" ;
            public static string TrainingTimeInSeconds =  "TrainingTimeInSeconds" ;
            public static string CreationTime =  "CreationTime" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string SecondaryStatusTransitions =  "SecondaryStatusTransitions" ;
            public static string BillableTimeInSeconds =  "BillableTimeInSeconds" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.TrainingJob; }
        /// <summary>
        /// EnableManagedSpotTraining
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-trainingjob.html#cfn-sagemaker-trainingjob-enablemanagedspottraining
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? EnableManagedSpotTraining { get; set; }
        /// <summary>
        /// HyperParameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-trainingjob.html#cfn-sagemaker-trainingjob-hyperparameters
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? HyperParameters { get; set; }
        /// <summary>
        /// DebugHookConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-trainingjob.html#cfn-sagemaker-trainingjob-debughookconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: DebugHookConfig
        /// </summary>
        public Union<Humidifier.SageMaker.TrainingJobTypes.DebugHookConfig, BaseFunction>? DebugHookConfig { get; set; }
        public Union<string, BaseFunction>? TrainingJobName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// AlgorithmSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-trainingjob.html#cfn-sagemaker-trainingjob-algorithmspecification
        /// Required: True
        /// UpdateType: Immutable
        /// Type: AlgorithmSpecification
        /// </summary>
        [Required]
        public Union<Humidifier.SageMaker.TrainingJobTypes.AlgorithmSpecification, BaseFunction>? AlgorithmSpecification { get; set; }

        /// <summary>
        /// OutputDataConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-trainingjob.html#cfn-sagemaker-trainingjob-outputdataconfig
        /// Required: True
        /// UpdateType: Immutable
        /// Type: OutputDataConfig
        /// </summary>
        [Required]
        public Union<Humidifier.SageMaker.TrainingJobTypes.OutputDataConfig, BaseFunction>? OutputDataConfig { get; set; }
        /// <summary>
        /// VpcConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-trainingjob.html#cfn-sagemaker-trainingjob-vpcconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: VpcConfig
        /// </summary>
        public Union<Humidifier.SageMaker.TrainingJobTypes.VpcConfig, BaseFunction>? VpcConfig { get; set; }
        /// <summary>
        /// CheckpointConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-trainingjob.html#cfn-sagemaker-trainingjob-checkpointconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: CheckpointConfig
        /// </summary>
        public Union<Humidifier.SageMaker.TrainingJobTypes.CheckpointConfig, BaseFunction>? CheckpointConfig { get; set; }
        /// <summary>
        /// ProfilerConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-trainingjob.html#cfn-sagemaker-trainingjob-profilerconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ProfilerConfig
        /// </summary>
        public Union<Humidifier.SageMaker.TrainingJobTypes.ProfilerConfig, BaseFunction>? ProfilerConfig { get; set; }
        /// <summary>
        /// InputDataConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-trainingjob.html#cfn-sagemaker-trainingjob-inputdataconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Channel
        /// </summary>
        public Union<IReadOnlyList<Humidifier.SageMaker.TrainingJobTypes.Channel>, IReadOnlyList<Union<Humidifier.SageMaker.TrainingJobTypes.Channel, BaseFunction>>, BaseFunction>? InputDataConfig { get; set; }
        /// <summary>
        /// TensorBoardOutputConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-trainingjob.html#cfn-sagemaker-trainingjob-tensorboardoutputconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: TensorBoardOutputConfig
        /// </summary>
        public Union<Humidifier.SageMaker.TrainingJobTypes.TensorBoardOutputConfig, BaseFunction>? TensorBoardOutputConfig { get; set; }
        /// <summary>
        /// ProfilerRuleConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-trainingjob.html#cfn-sagemaker-trainingjob-profilerruleconfigurations
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: ProfilerRuleConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.SageMaker.TrainingJobTypes.ProfilerRuleConfiguration>, IReadOnlyList<Union<Humidifier.SageMaker.TrainingJobTypes.ProfilerRuleConfiguration, BaseFunction>>, BaseFunction>? ProfilerRuleConfigurations { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-trainingjob.html#cfn-sagemaker-trainingjob-rolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// InfraCheckConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-trainingjob.html#cfn-sagemaker-trainingjob-infracheckconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: InfraCheckConfig
        /// </summary>
        public Union<Humidifier.SageMaker.TrainingJobTypes.InfraCheckConfig, BaseFunction>? InfraCheckConfig { get; set; }
        /// <summary>
        /// EnableNetworkIsolation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-trainingjob.html#cfn-sagemaker-trainingjob-enablenetworkisolation
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? EnableNetworkIsolation { get; set; }
        /// <summary>
        /// EnableInterContainerTrafficEncryption
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-trainingjob.html#cfn-sagemaker-trainingjob-enableintercontainertrafficencryption
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? EnableInterContainerTrafficEncryption { get; set; }
        /// <summary>
        /// RemoteDebugConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-trainingjob.html#cfn-sagemaker-trainingjob-remotedebugconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: RemoteDebugConfig
        /// </summary>
        public Union<Humidifier.SageMaker.TrainingJobTypes.RemoteDebugConfig, BaseFunction>? RemoteDebugConfig { get; set; }

        /// <summary>
        /// StoppingCondition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-trainingjob.html#cfn-sagemaker-trainingjob-stoppingcondition
        /// Required: True
        /// UpdateType: Immutable
        /// Type: StoppingCondition
        /// </summary>
        [Required]
        public Union<Humidifier.SageMaker.TrainingJobTypes.StoppingCondition, BaseFunction>? StoppingCondition { get; set; }
        /// <summary>
        /// ExperimentConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-trainingjob.html#cfn-sagemaker-trainingjob-experimentconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ExperimentConfig
        /// </summary>
        public Union<Humidifier.SageMaker.TrainingJobTypes.ExperimentConfig, BaseFunction>? ExperimentConfig { get; set; }
        /// <summary>
        /// DebugRuleConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-trainingjob.html#cfn-sagemaker-trainingjob-debugruleconfigurations
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: DebugRuleConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.SageMaker.TrainingJobTypes.DebugRuleConfiguration>, IReadOnlyList<Union<Humidifier.SageMaker.TrainingJobTypes.DebugRuleConfiguration, BaseFunction>>, BaseFunction>? DebugRuleConfigurations { get; set; }
        /// <summary>
        /// Environment
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-trainingjob.html#cfn-sagemaker-trainingjob-environment
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Environment { get; set; }

        /// <summary>
        /// ResourceConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-trainingjob.html#cfn-sagemaker-trainingjob-resourceconfig
        /// Required: True
        /// UpdateType: Immutable
        /// Type: ResourceConfig
        /// </summary>
        [Required]
        public Union<Humidifier.SageMaker.TrainingJobTypes.ResourceConfig, BaseFunction>? ResourceConfig { get; set; }
        /// <summary>
        /// RetryStrategy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-trainingjob.html#cfn-sagemaker-trainingjob-retrystrategy
        /// Required: False
        /// UpdateType: Immutable
        /// Type: RetryStrategy
        /// </summary>
        public Union<Humidifier.SageMaker.TrainingJobTypes.RetryStrategy, BaseFunction>? RetryStrategy { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-trainingjob.html#cfn-sagemaker-trainingjob-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace TrainingJobTypes
    {
        public class AlgorithmSpecification : Humidifier.Base.BaseSubResource, IHaveEnableSageMakerMetricsTimeSeries_Boolean, IHaveStringListOfContainerEntrypoint, IHaveSageMakerTrainingJobTypesTrainingImageConfigTrainingImageConfig, IHaveTrainingInputMode, IHaveListOfSageMakerTrainingJobTypesMetricDefinitionMetricDefinitions, IHaveTrainingImage, IHaveAlgorithmName, IHaveStringListOfContainerArguments
        {
            /// <summary>
            /// EnableSageMakerMetricsTimeSeries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-algorithmspecification.html#cfn-sagemaker-trainingjob-algorithmspecification-enablesagemakermetricstimeseries
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableSageMakerMetricsTimeSeries { get; set; }
            /// <summary>
            /// ContainerEntrypoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-algorithmspecification.html#cfn-sagemaker-trainingjob-algorithmspecification-containerentrypoint
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ContainerEntrypoint { get; set; }
            /// <summary>
            /// TrainingImageConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-algorithmspecification.html#cfn-sagemaker-trainingjob-algorithmspecification-trainingimageconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: TrainingImageConfig
            /// </summary>
            public Union<Humidifier.SageMaker.TrainingJobTypes.TrainingImageConfig, BaseFunction>? TrainingImageConfig { get; set; }
            /// <summary>
            /// TrainingInputMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-algorithmspecification.html#cfn-sagemaker-trainingjob-algorithmspecification-traininginputmode
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TrainingInputMode { get; set; }
            /// <summary>
            /// MetricDefinitions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-algorithmspecification.html#cfn-sagemaker-trainingjob-algorithmspecification-metricdefinitions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: MetricDefinition
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.TrainingJobTypes.MetricDefinition>, IReadOnlyList<Union<Humidifier.SageMaker.TrainingJobTypes.MetricDefinition, BaseFunction>>, BaseFunction>? MetricDefinitions { get; set; }
            /// <summary>
            /// TrainingImage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-algorithmspecification.html#cfn-sagemaker-trainingjob-algorithmspecification-trainingimage
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TrainingImage { get; set; }
            /// <summary>
            /// AlgorithmName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-algorithmspecification.html#cfn-sagemaker-trainingjob-algorithmspecification-algorithmname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AlgorithmName { get; set; }
            /// <summary>
            /// ContainerArguments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-algorithmspecification.html#cfn-sagemaker-trainingjob-algorithmspecification-containerarguments
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ContainerArguments { get; set; }
        }

        public class Channel : Humidifier.Base.BaseSubResource, IHaveInputMode, IHaveChannelName, IHaveContentType, IHaveRecordWrapperType, IHaveSageMakerTrainingJobTypesShuffleConfigShuffleConfig, IHaveCompressionType, IHaveSageMakerTrainingJobTypesDataSourceDataSource
        {
            /// <summary>
            /// InputMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-channel.html#cfn-sagemaker-trainingjob-channel-inputmode
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputMode { get; set; }
            /// <summary>
            /// ChannelName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-channel.html#cfn-sagemaker-trainingjob-channel-channelname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ChannelName { get; set; }
            /// <summary>
            /// ContentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-channel.html#cfn-sagemaker-trainingjob-channel-contenttype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContentType { get; set; }
            /// <summary>
            /// RecordWrapperType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-channel.html#cfn-sagemaker-trainingjob-channel-recordwrappertype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RecordWrapperType { get; set; }
            /// <summary>
            /// ShuffleConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-channel.html#cfn-sagemaker-trainingjob-channel-shuffleconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ShuffleConfig
            /// </summary>
            public Union<Humidifier.SageMaker.TrainingJobTypes.ShuffleConfig, BaseFunction>? ShuffleConfig { get; set; }
            /// <summary>
            /// CompressionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-channel.html#cfn-sagemaker-trainingjob-channel-compressiontype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CompressionType { get; set; }
            /// <summary>
            /// DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-channel.html#cfn-sagemaker-trainingjob-channel-datasource
            /// Required: True
            /// UpdateType: Immutable
            /// Type: DataSource
            /// </summary>
            public Union<Humidifier.SageMaker.TrainingJobTypes.DataSource, BaseFunction>? DataSource { get; set; }
        }

        public class CheckpointConfig : Humidifier.Base.BaseSubResource, IHaveS3Uri, IHaveLocalPath
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-checkpointconfig.html#cfn-sagemaker-trainingjob-checkpointconfig-s3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
            /// <summary>
            /// LocalPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-checkpointconfig.html#cfn-sagemaker-trainingjob-checkpointconfig-localpath
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LocalPath { get; set; }
        }

        public class CollectionConfiguration : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfCollectionParameters, IHaveCollectionName
        {
            /// <summary>
            /// CollectionParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-collectionconfiguration.html#cfn-sagemaker-trainingjob-collectionconfiguration-collectionparameters
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? CollectionParameters { get; set; }
            /// <summary>
            /// CollectionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-collectionconfiguration.html#cfn-sagemaker-trainingjob-collectionconfiguration-collectionname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CollectionName { get; set; }
        }

        public class DataSource : Humidifier.Base.BaseSubResource, IHaveSageMakerTrainingJobTypesFileSystemDataSourceFileSystemDataSource, IHaveSageMakerTrainingJobTypesS3DataSourceS3DataSource
        {
            /// <summary>
            /// FileSystemDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-datasource.html#cfn-sagemaker-trainingjob-datasource-filesystemdatasource
            /// Required: False
            /// UpdateType: Immutable
            /// Type: FileSystemDataSource
            /// </summary>
            public Union<Humidifier.SageMaker.TrainingJobTypes.FileSystemDataSource, BaseFunction>? FileSystemDataSource { get; set; }
            /// <summary>
            /// S3DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-datasource.html#cfn-sagemaker-trainingjob-datasource-s3datasource
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3DataSource
            /// </summary>
            public Union<Humidifier.SageMaker.TrainingJobTypes.S3DataSource, BaseFunction>? S3DataSource { get; set; }
        }

        public class DebugHookConfig : Humidifier.Base.BaseSubResource, IHaveListOfSageMakerTrainingJobTypesCollectionConfigurationCollectionConfigurations, IHaveLocalPath, IHaveStringDictionaryOfHookParameters, IHaveS3OutputPath
        {
            /// <summary>
            /// CollectionConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-debughookconfig.html#cfn-sagemaker-trainingjob-debughookconfig-collectionconfigurations
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: CollectionConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.TrainingJobTypes.CollectionConfiguration>, IReadOnlyList<Union<Humidifier.SageMaker.TrainingJobTypes.CollectionConfiguration, BaseFunction>>, BaseFunction>? CollectionConfigurations { get; set; }
            /// <summary>
            /// LocalPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-debughookconfig.html#cfn-sagemaker-trainingjob-debughookconfig-localpath
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LocalPath { get; set; }
            /// <summary>
            /// HookParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-debughookconfig.html#cfn-sagemaker-trainingjob-debughookconfig-hookparameters
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? HookParameters { get; set; }
            /// <summary>
            /// S3OutputPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-debughookconfig.html#cfn-sagemaker-trainingjob-debughookconfig-s3outputpath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3OutputPath { get; set; }
        }

        public class DebugRuleConfiguration : Humidifier.Base.BaseSubResource, IHaveRuleEvaluatorImage, IHaveVolumeSizeInGB_Integer, IHaveStringDictionaryOfRuleParameters, IHaveRuleConfigurationName, IHaveLocalPath, IHaveS3OutputPath, IHaveInstanceType
        {
            /// <summary>
            /// RuleEvaluatorImage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-debugruleconfiguration.html#cfn-sagemaker-trainingjob-debugruleconfiguration-ruleevaluatorimage
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RuleEvaluatorImage { get; set; }
            /// <summary>
            /// VolumeSizeInGB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-debugruleconfiguration.html#cfn-sagemaker-trainingjob-debugruleconfiguration-volumesizeingb
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? VolumeSizeInGB { get; set; }
            /// <summary>
            /// RuleParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-debugruleconfiguration.html#cfn-sagemaker-trainingjob-debugruleconfiguration-ruleparameters
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? RuleParameters { get; set; }
            /// <summary>
            /// RuleConfigurationName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-debugruleconfiguration.html#cfn-sagemaker-trainingjob-debugruleconfiguration-ruleconfigurationname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RuleConfigurationName { get; set; }
            /// <summary>
            /// LocalPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-debugruleconfiguration.html#cfn-sagemaker-trainingjob-debugruleconfiguration-localpath
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LocalPath { get; set; }
            /// <summary>
            /// S3OutputPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-debugruleconfiguration.html#cfn-sagemaker-trainingjob-debugruleconfiguration-s3outputpath
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3OutputPath { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-debugruleconfiguration.html#cfn-sagemaker-trainingjob-debugruleconfiguration-instancetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceType { get; set; }
        }

        public class ExperimentConfig : Humidifier.Base.BaseSubResource, IHaveTrialName, IHaveExperimentName, IHaveTrialComponentDisplayName, IHaveRunName
        {
            /// <summary>
            /// TrialName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-experimentconfig.html#cfn-sagemaker-trainingjob-experimentconfig-trialname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TrialName { get; set; }
            /// <summary>
            /// ExperimentName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-experimentconfig.html#cfn-sagemaker-trainingjob-experimentconfig-experimentname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExperimentName { get; set; }
            /// <summary>
            /// TrialComponentDisplayName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-experimentconfig.html#cfn-sagemaker-trainingjob-experimentconfig-trialcomponentdisplayname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TrialComponentDisplayName { get; set; }
            /// <summary>
            /// RunName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-experimentconfig.html#cfn-sagemaker-trainingjob-experimentconfig-runname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RunName { get; set; }
        }

        public class FileSystemDataSource : Humidifier.Base.BaseSubResource, IHaveFileSystemAccessMode, IHaveDirectoryPath, IHaveFileSystemType, IHaveFileSystemId
        {
            /// <summary>
            /// FileSystemAccessMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-filesystemdatasource.html#cfn-sagemaker-trainingjob-filesystemdatasource-filesystemaccessmode
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FileSystemAccessMode { get; set; }
            /// <summary>
            /// DirectoryPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-filesystemdatasource.html#cfn-sagemaker-trainingjob-filesystemdatasource-directorypath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DirectoryPath { get; set; }
            /// <summary>
            /// FileSystemType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-filesystemdatasource.html#cfn-sagemaker-trainingjob-filesystemdatasource-filesystemtype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FileSystemType { get; set; }
            /// <summary>
            /// FileSystemId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-filesystemdatasource.html#cfn-sagemaker-trainingjob-filesystemdatasource-filesystemid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FileSystemId { get; set; }
        }

        public class InfraCheckConfig : Humidifier.Base.BaseSubResource, IHaveEnableInfraCheck_Boolean
        {
            /// <summary>
            /// EnableInfraCheck
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-infracheckconfig.html#cfn-sagemaker-trainingjob-infracheckconfig-enableinfracheck
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableInfraCheck { get; set; }
        }

        public class InstanceGroup : Humidifier.Base.BaseSubResource, IHaveInstanceCount_Integer, IHaveInstanceGroupName, IHaveInstanceType
        {
            /// <summary>
            /// InstanceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-instancegroup.html#cfn-sagemaker-trainingjob-instancegroup-instancecount
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? InstanceCount { get; set; }
            /// <summary>
            /// InstanceGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-instancegroup.html#cfn-sagemaker-trainingjob-instancegroup-instancegroupname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceGroupName { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-instancegroup.html#cfn-sagemaker-trainingjob-instancegroup-instancetype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceType { get; set; }
        }

        public class MetricDefinition : Humidifier.Base.BaseSubResource, IHaveRegex, IHaveName
        {
            /// <summary>
            /// Regex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-metricdefinition.html#cfn-sagemaker-trainingjob-metricdefinition-regex
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Regex { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-metricdefinition.html#cfn-sagemaker-trainingjob-metricdefinition-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class OutputDataConfig : Humidifier.Base.BaseSubResource, IHaveKmsKeyId, IHaveS3OutputPath, IHaveCompressionType
        {
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-outputdataconfig.html#cfn-sagemaker-trainingjob-outputdataconfig-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
            /// <summary>
            /// S3OutputPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-outputdataconfig.html#cfn-sagemaker-trainingjob-outputdataconfig-s3outputpath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3OutputPath { get; set; }
            /// <summary>
            /// CompressionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-outputdataconfig.html#cfn-sagemaker-trainingjob-outputdataconfig-compressiontype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CompressionType { get; set; }
        }

        public class ProfilerConfig : Humidifier.Base.BaseSubResource, IHaveDisableProfiler_Boolean, IHaveProfilingIntervalInMilliseconds_Integer, IHaveStringDictionaryOfProfilingParameters, IHaveS3OutputPath
        {
            /// <summary>
            /// DisableProfiler
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-profilerconfig.html#cfn-sagemaker-trainingjob-profilerconfig-disableprofiler
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DisableProfiler { get; set; }
            /// <summary>
            /// ProfilingIntervalInMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-profilerconfig.html#cfn-sagemaker-trainingjob-profilerconfig-profilingintervalinmilliseconds
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ProfilingIntervalInMilliseconds { get; set; }
            /// <summary>
            /// ProfilingParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-profilerconfig.html#cfn-sagemaker-trainingjob-profilerconfig-profilingparameters
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? ProfilingParameters { get; set; }
            /// <summary>
            /// S3OutputPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-profilerconfig.html#cfn-sagemaker-trainingjob-profilerconfig-s3outputpath
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3OutputPath { get; set; }
        }

        public class ProfilerRuleConfiguration : Humidifier.Base.BaseSubResource, IHaveRuleEvaluatorImage, IHaveVolumeSizeInGB_Integer, IHaveStringDictionaryOfRuleParameters, IHaveRuleConfigurationName, IHaveLocalPath, IHaveS3OutputPath, IHaveInstanceType
        {
            /// <summary>
            /// RuleEvaluatorImage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-profilerruleconfiguration.html#cfn-sagemaker-trainingjob-profilerruleconfiguration-ruleevaluatorimage
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RuleEvaluatorImage { get; set; }
            /// <summary>
            /// VolumeSizeInGB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-profilerruleconfiguration.html#cfn-sagemaker-trainingjob-profilerruleconfiguration-volumesizeingb
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? VolumeSizeInGB { get; set; }
            /// <summary>
            /// RuleParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-profilerruleconfiguration.html#cfn-sagemaker-trainingjob-profilerruleconfiguration-ruleparameters
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? RuleParameters { get; set; }
            /// <summary>
            /// RuleConfigurationName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-profilerruleconfiguration.html#cfn-sagemaker-trainingjob-profilerruleconfiguration-ruleconfigurationname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RuleConfigurationName { get; set; }
            /// <summary>
            /// LocalPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-profilerruleconfiguration.html#cfn-sagemaker-trainingjob-profilerruleconfiguration-localpath
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LocalPath { get; set; }
            /// <summary>
            /// S3OutputPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-profilerruleconfiguration.html#cfn-sagemaker-trainingjob-profilerruleconfiguration-s3outputpath
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3OutputPath { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-profilerruleconfiguration.html#cfn-sagemaker-trainingjob-profilerruleconfiguration-instancetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceType { get; set; }
        }

        public class RemoteDebugConfig : Humidifier.Base.BaseSubResource, IHaveEnableRemoteDebug_Boolean
        {
            /// <summary>
            /// EnableRemoteDebug
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-remotedebugconfig.html#cfn-sagemaker-trainingjob-remotedebugconfig-enableremotedebug
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableRemoteDebug { get; set; }
        }

        public class ResourceConfig : Humidifier.Base.BaseSubResource, IHaveInstanceCount_Integer, IHaveVolumeSizeInGB_Integer, IHaveKeepAlivePeriodInSeconds_Integer, IHaveVolumeKmsKeyId, IHaveListOfSageMakerTrainingJobTypesInstanceGroupInstanceGroups, IHaveInstanceType
        {
            /// <summary>
            /// InstanceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-resourceconfig.html#cfn-sagemaker-trainingjob-resourceconfig-instancecount
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? InstanceCount { get; set; }
            /// <summary>
            /// VolumeSizeInGB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-resourceconfig.html#cfn-sagemaker-trainingjob-resourceconfig-volumesizeingb
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? VolumeSizeInGB { get; set; }
            /// <summary>
            /// KeepAlivePeriodInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-resourceconfig.html#cfn-sagemaker-trainingjob-resourceconfig-keepaliveperiodinseconds
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? KeepAlivePeriodInSeconds { get; set; }
            /// <summary>
            /// VolumeKmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-resourceconfig.html#cfn-sagemaker-trainingjob-resourceconfig-volumekmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VolumeKmsKeyId { get; set; }
            /// <summary>
            /// InstanceGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-resourceconfig.html#cfn-sagemaker-trainingjob-resourceconfig-instancegroups
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: InstanceGroup
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.TrainingJobTypes.InstanceGroup>, IReadOnlyList<Union<Humidifier.SageMaker.TrainingJobTypes.InstanceGroup, BaseFunction>>, BaseFunction>? InstanceGroups { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-resourceconfig.html#cfn-sagemaker-trainingjob-resourceconfig-instancetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceType { get; set; }
        }

        public class RetryStrategy : Humidifier.Base.BaseSubResource, IHaveMaximumRetryAttempts_Integer
        {
            /// <summary>
            /// MaximumRetryAttempts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-retrystrategy.html#cfn-sagemaker-trainingjob-retrystrategy-maximumretryattempts
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaximumRetryAttempts { get; set; }
        }

        public class S3DataSource : Humidifier.Base.BaseSubResource, IHaveS3DataDistributionType, IHaveS3Uri, IHaveStringListOfInstanceGroupNames, IHaveStringListOfAttributeNames, IHaveS3DataType
        {
            /// <summary>
            /// S3DataDistributionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-s3datasource.html#cfn-sagemaker-trainingjob-s3datasource-s3datadistributiontype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3DataDistributionType { get; set; }
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-s3datasource.html#cfn-sagemaker-trainingjob-s3datasource-s3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
            /// <summary>
            /// InstanceGroupNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-s3datasource.html#cfn-sagemaker-trainingjob-s3datasource-instancegroupnames
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? InstanceGroupNames { get; set; }
            /// <summary>
            /// AttributeNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-s3datasource.html#cfn-sagemaker-trainingjob-s3datasource-attributenames
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AttributeNames { get; set; }
            /// <summary>
            /// S3DataType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-s3datasource.html#cfn-sagemaker-trainingjob-s3datasource-s3datatype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3DataType { get; set; }
        }

        public class SecondaryStatusTransition : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveEndTime, IHaveStartTime, IHaveStatusMessage
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-secondarystatustransition.html#cfn-sagemaker-trainingjob-secondarystatustransition-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// EndTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-secondarystatustransition.html#cfn-sagemaker-trainingjob-secondarystatustransition-endtime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndTime { get; set; }
            /// <summary>
            /// StartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-secondarystatustransition.html#cfn-sagemaker-trainingjob-secondarystatustransition-starttime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StartTime { get; set; }
            /// <summary>
            /// StatusMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-secondarystatustransition.html#cfn-sagemaker-trainingjob-secondarystatustransition-statusmessage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StatusMessage { get; set; }
        }

        public class ShuffleConfig : Humidifier.Base.BaseSubResource, IHaveSeed_Integer
        {
            /// <summary>
            /// Seed
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-shuffleconfig.html#cfn-sagemaker-trainingjob-shuffleconfig-seed
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Seed { get; set; }
        }

        public class StoppingCondition : Humidifier.Base.BaseSubResource, IHaveMaxRuntimeInSeconds_Integer, IHaveMaxPendingTimeInSeconds_Integer, IHaveMaxWaitTimeInSeconds_Integer
        {
            /// <summary>
            /// MaxRuntimeInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-stoppingcondition.html#cfn-sagemaker-trainingjob-stoppingcondition-maxruntimeinseconds
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxRuntimeInSeconds { get; set; }
            /// <summary>
            /// MaxPendingTimeInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-stoppingcondition.html#cfn-sagemaker-trainingjob-stoppingcondition-maxpendingtimeinseconds
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxPendingTimeInSeconds { get; set; }
            /// <summary>
            /// MaxWaitTimeInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-stoppingcondition.html#cfn-sagemaker-trainingjob-stoppingcondition-maxwaittimeinseconds
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxWaitTimeInSeconds { get; set; }
        }

        public class TensorBoardOutputConfig : Humidifier.Base.BaseSubResource, IHaveLocalPath, IHaveS3OutputPath
        {
            /// <summary>
            /// LocalPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-tensorboardoutputconfig.html#cfn-sagemaker-trainingjob-tensorboardoutputconfig-localpath
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LocalPath { get; set; }
            /// <summary>
            /// S3OutputPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-tensorboardoutputconfig.html#cfn-sagemaker-trainingjob-tensorboardoutputconfig-s3outputpath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3OutputPath { get; set; }
        }

        public class TrainingImageConfig : Humidifier.Base.BaseSubResource, IHaveTrainingRepositoryAccessMode, IHaveSageMakerTrainingJobTypesTrainingRepositoryAuthConfigTrainingRepositoryAuthConfig
        {
            /// <summary>
            /// TrainingRepositoryAccessMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-trainingimageconfig.html#cfn-sagemaker-trainingjob-trainingimageconfig-trainingrepositoryaccessmode
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TrainingRepositoryAccessMode { get; set; }
            /// <summary>
            /// TrainingRepositoryAuthConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-trainingimageconfig.html#cfn-sagemaker-trainingjob-trainingimageconfig-trainingrepositoryauthconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: TrainingRepositoryAuthConfig
            /// </summary>
            public Union<Humidifier.SageMaker.TrainingJobTypes.TrainingRepositoryAuthConfig, BaseFunction>? TrainingRepositoryAuthConfig { get; set; }
        }

        public class TrainingRepositoryAuthConfig : Humidifier.Base.BaseSubResource, IHaveTrainingRepositoryCredentialsProviderArn
        {
            /// <summary>
            /// TrainingRepositoryCredentialsProviderArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-trainingrepositoryauthconfig.html#cfn-sagemaker-trainingjob-trainingrepositoryauthconfig-trainingrepositorycredentialsproviderarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TrainingRepositoryCredentialsProviderArn { get; set; }
        }

        public class VpcConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfSubnets, IHaveStringListOfSecurityGroupIds
        {
            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-vpcconfig.html#cfn-sagemaker-trainingjob-vpcconfig-subnets
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Subnets { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-trainingjob-vpcconfig.html#cfn-sagemaker-trainingjob-vpcconfig-securitygroupids
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        }
    }
}