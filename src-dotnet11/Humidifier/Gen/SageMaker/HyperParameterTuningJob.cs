namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using HyperParameterTuningJobTypes;

    public class HyperParameterTuningJob : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveSageMakerHyperParameterTuningJobTypesHyperParameterTuningJobWarmStartConfigWarmStartConfig, IHaveListOfSageMakerHyperParameterTuningJobTypesTrainingJobDefinitionTrainingJobDefinitions, IHaveHyperParameterTuningJobName, IHaveSageMakerHyperParameterTuningJobTypesTrainingJobDefinitionTrainingJobDefinition, IHaveSageMakerHyperParameterTuningJobTypesAutotuneAutotune, IHaveSageMakerHyperParameterTuningJobTypesHyperParameterTuningJobConfigHyperParameterTuningJobConfig
    {
        public class Attributes
        {
            public static string HyperParameterTuningJobStatus =  "HyperParameterTuningJobStatus" ;
            public static string TrainingJobStatusCounters =  "TrainingJobStatusCounters" ;
            public static string CreationTime =  "CreationTime" ;
            public static string ObjectiveStatusCounters =  "ObjectiveStatusCounters" ;
            public static string HyperParameterTuningJobArn =  "HyperParameterTuningJobArn" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.HyperParameterTuningJob; }
        /// <summary>
        /// WarmStartConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-hyperparametertuningjob.html#cfn-sagemaker-hyperparametertuningjob-warmstartconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: HyperParameterTuningJobWarmStartConfig
        /// </summary>
        public Union<Humidifier.SageMaker.HyperParameterTuningJobTypes.HyperParameterTuningJobWarmStartConfig, BaseFunction>? WarmStartConfig { get; set; }
        /// <summary>
        /// TrainingJobDefinitions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-hyperparametertuningjob.html#cfn-sagemaker-hyperparametertuningjob-trainingjobdefinitions
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: TrainingJobDefinition
        /// </summary>
        public Union<IReadOnlyList<Humidifier.SageMaker.HyperParameterTuningJobTypes.TrainingJobDefinition>, IReadOnlyList<Union<Humidifier.SageMaker.HyperParameterTuningJobTypes.TrainingJobDefinition, BaseFunction>>, BaseFunction>? TrainingJobDefinitions { get; set; }
        public Union<string, BaseFunction>? HyperParameterTuningJobName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// TrainingJobDefinition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-hyperparametertuningjob.html#cfn-sagemaker-hyperparametertuningjob-trainingjobdefinition
        /// Required: False
        /// UpdateType: Immutable
        /// Type: TrainingJobDefinition
        /// </summary>
        public Union<Humidifier.SageMaker.HyperParameterTuningJobTypes.TrainingJobDefinition, BaseFunction>? TrainingJobDefinition { get; set; }
        /// <summary>
        /// Autotune
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-hyperparametertuningjob.html#cfn-sagemaker-hyperparametertuningjob-autotune
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Autotune
        /// </summary>
        public Union<Humidifier.SageMaker.HyperParameterTuningJobTypes.Autotune, BaseFunction>? Autotune { get; set; }

        /// <summary>
        /// HyperParameterTuningJobConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-hyperparametertuningjob.html#cfn-sagemaker-hyperparametertuningjob-hyperparametertuningjobconfig
        /// Required: True
        /// UpdateType: Immutable
        /// Type: HyperParameterTuningJobConfig
        /// </summary>
        [Required]
        public Union<Humidifier.SageMaker.HyperParameterTuningJobTypes.HyperParameterTuningJobConfig, BaseFunction>? HyperParameterTuningJobConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-hyperparametertuningjob.html#cfn-sagemaker-hyperparametertuningjob-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace HyperParameterTuningJobTypes
    {
        public class AlgorithmSpecification : Humidifier.Base.BaseSubResource, IHaveTrainingInputMode, IHaveListOfSageMakerHyperParameterTuningJobTypesMetricDefinitionsItemsMetricDefinitions, IHaveTrainingImage, IHaveAlgorithmName
        {
            /// <summary>
            /// TrainingInputMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-algorithmspecification.html#cfn-sagemaker-hyperparametertuningjob-algorithmspecification-traininginputmode
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TrainingInputMode { get; set; }
            /// <summary>
            /// MetricDefinitions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-algorithmspecification.html#cfn-sagemaker-hyperparametertuningjob-algorithmspecification-metricdefinitions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: MetricDefinitionsItems
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.HyperParameterTuningJobTypes.MetricDefinitionsItems>, IReadOnlyList<Union<Humidifier.SageMaker.HyperParameterTuningJobTypes.MetricDefinitionsItems, BaseFunction>>, BaseFunction>? MetricDefinitions { get; set; }
            /// <summary>
            /// TrainingImage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-algorithmspecification.html#cfn-sagemaker-hyperparametertuningjob-algorithmspecification-trainingimage
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TrainingImage { get; set; }
            /// <summary>
            /// AlgorithmName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-algorithmspecification.html#cfn-sagemaker-hyperparametertuningjob-algorithmspecification-algorithmname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AlgorithmName { get; set; }
        }

        public class AutoParametersItems : Humidifier.Base.BaseSubResource, IHaveValueHint, IHaveName
        {
            /// <summary>
            /// ValueHint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-autoparametersitems.html#cfn-sagemaker-hyperparametertuningjob-autoparametersitems-valuehint
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ValueHint { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-autoparametersitems.html#cfn-sagemaker-hyperparametertuningjob-autoparametersitems-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class Autotune : Humidifier.Base.BaseSubResource, IHaveMode
        {
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-autotune.html#cfn-sagemaker-hyperparametertuningjob-autotune-mode
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Mode { get; set; }
        }

        public class BestObjectiveNotImproving : Humidifier.Base.BaseSubResource, IHaveMaxNumberOfTrainingJobsNotImproving_Integer
        {
            /// <summary>
            /// MaxNumberOfTrainingJobsNotImproving
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-bestobjectivenotimproving.html#cfn-sagemaker-hyperparametertuningjob-bestobjectivenotimproving-maxnumberoftrainingjobsnotimproving
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxNumberOfTrainingJobsNotImproving { get; set; }
        }

        public class CategoricalParameterRangesItems : Humidifier.Base.BaseSubResource, IHaveStringListOfValues, IHaveName
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-categoricalparameterrangesitems.html#cfn-sagemaker-hyperparametertuningjob-categoricalparameterrangesitems-values
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-categoricalparameterrangesitems.html#cfn-sagemaker-hyperparametertuningjob-categoricalparameterrangesitems-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class CheckpointConfig : Humidifier.Base.BaseSubResource, IHaveS3Uri, IHaveLocalPath
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-checkpointconfig.html#cfn-sagemaker-hyperparametertuningjob-checkpointconfig-s3uri
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
            /// <summary>
            /// LocalPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-checkpointconfig.html#cfn-sagemaker-hyperparametertuningjob-checkpointconfig-localpath
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LocalPath { get; set; }
        }

        public class ContinuousParameterRangesItems : Humidifier.Base.BaseSubResource, IHaveScalingType, IHaveMinValue, IHaveMaxValue, IHaveName
        {
            /// <summary>
            /// ScalingType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-continuousparameterrangesitems.html#cfn-sagemaker-hyperparametertuningjob-continuousparameterrangesitems-scalingtype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScalingType { get; set; }
            /// <summary>
            /// MinValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-continuousparameterrangesitems.html#cfn-sagemaker-hyperparametertuningjob-continuousparameterrangesitems-minvalue
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MinValue { get; set; }
            /// <summary>
            /// MaxValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-continuousparameterrangesitems.html#cfn-sagemaker-hyperparametertuningjob-continuousparameterrangesitems-maxvalue
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MaxValue { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-continuousparameterrangesitems.html#cfn-sagemaker-hyperparametertuningjob-continuousparameterrangesitems-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class ConvergenceDetected : Humidifier.Base.BaseSubResource, IHaveCompleteOnConvergence
        {
            /// <summary>
            /// CompleteOnConvergence
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-convergencedetected.html#cfn-sagemaker-hyperparametertuningjob-convergencedetected-completeonconvergence
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CompleteOnConvergence { get; set; }
        }

        public class DataSource : Humidifier.Base.BaseSubResource, IHaveSageMakerHyperParameterTuningJobTypesS3DataSourceS3DataSource
        {
            /// <summary>
            /// S3DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-datasource.html#cfn-sagemaker-hyperparametertuningjob-datasource-s3datasource
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3DataSource
            /// </summary>
            public Union<Humidifier.SageMaker.HyperParameterTuningJobTypes.S3DataSource, BaseFunction>? S3DataSource { get; set; }
        }

        public class HyperParameterTuningJobConfig : Humidifier.Base.BaseSubResource, IHaveRandomSeed_Integer, IHaveTrainingJobEarlyStoppingType, IHaveSageMakerHyperParameterTuningJobTypesStrategyConfigStrategyConfig, IHaveSageMakerHyperParameterTuningJobTypesHyperParameterTuningJobObjectiveHyperParameterTuningJobObjective, IHaveSageMakerHyperParameterTuningJobTypesResourceLimitsResourceLimits, IHaveStrategy, IHaveSageMakerHyperParameterTuningJobTypesParameterRangesParameterRanges, IHaveSageMakerHyperParameterTuningJobTypesTuningJobCompletionCriteriaTuningJobCompletionCriteria
        {
            /// <summary>
            /// RandomSeed
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-hyperparametertuningjobconfig.html#cfn-sagemaker-hyperparametertuningjob-hyperparametertuningjobconfig-randomseed
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RandomSeed { get; set; }
            /// <summary>
            /// TrainingJobEarlyStoppingType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-hyperparametertuningjobconfig.html#cfn-sagemaker-hyperparametertuningjob-hyperparametertuningjobconfig-trainingjobearlystoppingtype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TrainingJobEarlyStoppingType { get; set; }
            /// <summary>
            /// StrategyConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-hyperparametertuningjobconfig.html#cfn-sagemaker-hyperparametertuningjob-hyperparametertuningjobconfig-strategyconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: StrategyConfig
            /// </summary>
            public Union<Humidifier.SageMaker.HyperParameterTuningJobTypes.StrategyConfig, BaseFunction>? StrategyConfig { get; set; }
            /// <summary>
            /// HyperParameterTuningJobObjective
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-hyperparametertuningjobconfig.html#cfn-sagemaker-hyperparametertuningjob-hyperparametertuningjobconfig-hyperparametertuningjobobjective
            /// Required: False
            /// UpdateType: Immutable
            /// Type: HyperParameterTuningJobObjective
            /// </summary>
            public Union<Humidifier.SageMaker.HyperParameterTuningJobTypes.HyperParameterTuningJobObjective, BaseFunction>? HyperParameterTuningJobObjective { get; set; }
            /// <summary>
            /// ResourceLimits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-hyperparametertuningjobconfig.html#cfn-sagemaker-hyperparametertuningjob-hyperparametertuningjobconfig-resourcelimits
            /// Required: True
            /// UpdateType: Immutable
            /// Type: ResourceLimits
            /// </summary>
            public Union<Humidifier.SageMaker.HyperParameterTuningJobTypes.ResourceLimits, BaseFunction>? ResourceLimits { get; set; }
            /// <summary>
            /// Strategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-hyperparametertuningjobconfig.html#cfn-sagemaker-hyperparametertuningjob-hyperparametertuningjobconfig-strategy
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Strategy { get; set; }
            /// <summary>
            /// ParameterRanges
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-hyperparametertuningjobconfig.html#cfn-sagemaker-hyperparametertuningjob-hyperparametertuningjobconfig-parameterranges
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ParameterRanges
            /// </summary>
            public Union<Humidifier.SageMaker.HyperParameterTuningJobTypes.ParameterRanges, BaseFunction>? ParameterRanges { get; set; }
            /// <summary>
            /// TuningJobCompletionCriteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-hyperparametertuningjobconfig.html#cfn-sagemaker-hyperparametertuningjob-hyperparametertuningjobconfig-tuningjobcompletioncriteria
            /// Required: False
            /// UpdateType: Immutable
            /// Type: TuningJobCompletionCriteria
            /// </summary>
            public Union<Humidifier.SageMaker.HyperParameterTuningJobTypes.TuningJobCompletionCriteria, BaseFunction>? TuningJobCompletionCriteria { get; set; }
        }

        public class HyperParameterTuningJobObjective : Humidifier.Base.BaseSubResource, IHaveMetricName, IHaveType
        {
            /// <summary>
            /// MetricName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-hyperparametertuningjobobjective.html#cfn-sagemaker-hyperparametertuningjob-hyperparametertuningjobobjective-metricname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetricName { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-hyperparametertuningjobobjective.html#cfn-sagemaker-hyperparametertuningjob-hyperparametertuningjobobjective-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
        }

        public class HyperParameterTuningJobWarmStartConfig : Humidifier.Base.BaseSubResource, IHaveListOfSageMakerHyperParameterTuningJobTypesParentHyperParameterTuningJobsItemsParentHyperParameterTuningJobs, IHaveWarmStartType
        {
            /// <summary>
            /// ParentHyperParameterTuningJobs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-hyperparametertuningjobwarmstartconfig.html#cfn-sagemaker-hyperparametertuningjob-hyperparametertuningjobwarmstartconfig-parenthyperparametertuningjobs
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ParentHyperParameterTuningJobsItems
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.HyperParameterTuningJobTypes.ParentHyperParameterTuningJobsItems>, IReadOnlyList<Union<Humidifier.SageMaker.HyperParameterTuningJobTypes.ParentHyperParameterTuningJobsItems, BaseFunction>>, BaseFunction>? ParentHyperParameterTuningJobs { get; set; }
            /// <summary>
            /// WarmStartType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-hyperparametertuningjobwarmstartconfig.html#cfn-sagemaker-hyperparametertuningjob-hyperparametertuningjobwarmstartconfig-warmstarttype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WarmStartType { get; set; }
        }

        public class HyperbandStrategyConfig : Humidifier.Base.BaseSubResource, IHaveMaxResource_Integer, IHaveMinResource_Integer
        {
            /// <summary>
            /// MaxResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-hyperbandstrategyconfig.html#cfn-sagemaker-hyperparametertuningjob-hyperbandstrategyconfig-maxresource
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxResource { get; set; }
            /// <summary>
            /// MinResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-hyperbandstrategyconfig.html#cfn-sagemaker-hyperparametertuningjob-hyperbandstrategyconfig-minresource
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinResource { get; set; }
        }

        public class InputDataConfigItems : Humidifier.Base.BaseSubResource, IHaveChannelName, IHaveSageMakerHyperParameterTuningJobTypesDataSourceDataSource
        {
            /// <summary>
            /// ChannelName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-inputdataconfigitems.html#cfn-sagemaker-hyperparametertuningjob-inputdataconfigitems-channelname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ChannelName { get; set; }
            /// <summary>
            /// DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-inputdataconfigitems.html#cfn-sagemaker-hyperparametertuningjob-inputdataconfigitems-datasource
            /// Required: True
            /// UpdateType: Immutable
            /// Type: DataSource
            /// </summary>
            public Union<Humidifier.SageMaker.HyperParameterTuningJobTypes.DataSource, BaseFunction>? DataSource { get; set; }
        }

        public class InstanceGroupsItems : Humidifier.Base.BaseSubResource, IHaveInstanceCount_Integer, IHaveInstanceGroupName, IHaveInstanceType
        {
            /// <summary>
            /// InstanceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-instancegroupsitems.html#cfn-sagemaker-hyperparametertuningjob-instancegroupsitems-instancecount
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? InstanceCount { get; set; }
            /// <summary>
            /// InstanceGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-instancegroupsitems.html#cfn-sagemaker-hyperparametertuningjob-instancegroupsitems-instancegroupname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceGroupName { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-instancegroupsitems.html#cfn-sagemaker-hyperparametertuningjob-instancegroupsitems-instancetype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceType { get; set; }
        }

        public class InstancePlacementConfig : Humidifier.Base.BaseSubResource, IHaveEnableMultipleJobs_Boolean, IHaveListOfSageMakerHyperParameterTuningJobTypesPlacementSpecificationsItemsPlacementSpecifications
        {
            /// <summary>
            /// EnableMultipleJobs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-instanceplacementconfig.html#cfn-sagemaker-hyperparametertuningjob-instanceplacementconfig-enablemultiplejobs
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableMultipleJobs { get; set; }
            /// <summary>
            /// PlacementSpecifications
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-instanceplacementconfig.html#cfn-sagemaker-hyperparametertuningjob-instanceplacementconfig-placementspecifications
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: PlacementSpecificationsItems
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.HyperParameterTuningJobTypes.PlacementSpecificationsItems>, IReadOnlyList<Union<Humidifier.SageMaker.HyperParameterTuningJobTypes.PlacementSpecificationsItems, BaseFunction>>, BaseFunction>? PlacementSpecifications { get; set; }
        }

        public class IntegerParameterRangesItems : Humidifier.Base.BaseSubResource, IHaveScalingType, IHaveMinValue, IHaveMaxValue, IHaveName
        {
            /// <summary>
            /// ScalingType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-integerparameterrangesitems.html#cfn-sagemaker-hyperparametertuningjob-integerparameterrangesitems-scalingtype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScalingType { get; set; }
            /// <summary>
            /// MinValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-integerparameterrangesitems.html#cfn-sagemaker-hyperparametertuningjob-integerparameterrangesitems-minvalue
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MinValue { get; set; }
            /// <summary>
            /// MaxValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-integerparameterrangesitems.html#cfn-sagemaker-hyperparametertuningjob-integerparameterrangesitems-maxvalue
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MaxValue { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-integerparameterrangesitems.html#cfn-sagemaker-hyperparametertuningjob-integerparameterrangesitems-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class MetricDefinitionsItems : Humidifier.Base.BaseSubResource, IHaveRegex, IHaveName
        {
            /// <summary>
            /// Regex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-metricdefinitionsitems.html#cfn-sagemaker-hyperparametertuningjob-metricdefinitionsitems-regex
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Regex { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-metricdefinitionsitems.html#cfn-sagemaker-hyperparametertuningjob-metricdefinitionsitems-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class ObjectiveStatusCounters : Humidifier.Base.BaseSubResource, IHaveSucceeded_Integer, IHaveFailed_Integer, IHavePending_Integer
        {
            /// <summary>
            /// Succeeded
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-objectivestatuscounters.html#cfn-sagemaker-hyperparametertuningjob-objectivestatuscounters-succeeded
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Succeeded { get; set; }
            /// <summary>
            /// Failed
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-objectivestatuscounters.html#cfn-sagemaker-hyperparametertuningjob-objectivestatuscounters-failed
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Failed { get; set; }
            /// <summary>
            /// Pending
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-objectivestatuscounters.html#cfn-sagemaker-hyperparametertuningjob-objectivestatuscounters-pending
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Pending { get; set; }
        }

        public class OutputDataConfig : Humidifier.Base.BaseSubResource, IHaveKmsKeyId, IHaveS3OutputPath, IHaveCompressionType
        {
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-outputdataconfig.html#cfn-sagemaker-hyperparametertuningjob-outputdataconfig-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
            /// <summary>
            /// S3OutputPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-outputdataconfig.html#cfn-sagemaker-hyperparametertuningjob-outputdataconfig-s3outputpath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3OutputPath { get; set; }
            /// <summary>
            /// CompressionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-outputdataconfig.html#cfn-sagemaker-hyperparametertuningjob-outputdataconfig-compressiontype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CompressionType { get; set; }
        }

        public class ParameterRanges : Humidifier.Base.BaseSubResource, IHaveListOfSageMakerHyperParameterTuningJobTypesIntegerParameterRangesItemsIntegerParameterRanges, IHaveListOfSageMakerHyperParameterTuningJobTypesCategoricalParameterRangesItemsCategoricalParameterRanges, IHaveListOfSageMakerHyperParameterTuningJobTypesContinuousParameterRangesItemsContinuousParameterRanges, IHaveListOfSageMakerHyperParameterTuningJobTypesAutoParametersItemsAutoParameters
        {
            /// <summary>
            /// IntegerParameterRanges
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-parameterranges.html#cfn-sagemaker-hyperparametertuningjob-parameterranges-integerparameterranges
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: IntegerParameterRangesItems
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.HyperParameterTuningJobTypes.IntegerParameterRangesItems>, IReadOnlyList<Union<Humidifier.SageMaker.HyperParameterTuningJobTypes.IntegerParameterRangesItems, BaseFunction>>, BaseFunction>? IntegerParameterRanges { get; set; }
            /// <summary>
            /// CategoricalParameterRanges
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-parameterranges.html#cfn-sagemaker-hyperparametertuningjob-parameterranges-categoricalparameterranges
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: CategoricalParameterRangesItems
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.HyperParameterTuningJobTypes.CategoricalParameterRangesItems>, IReadOnlyList<Union<Humidifier.SageMaker.HyperParameterTuningJobTypes.CategoricalParameterRangesItems, BaseFunction>>, BaseFunction>? CategoricalParameterRanges { get; set; }
            /// <summary>
            /// ContinuousParameterRanges
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-parameterranges.html#cfn-sagemaker-hyperparametertuningjob-parameterranges-continuousparameterranges
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ContinuousParameterRangesItems
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.HyperParameterTuningJobTypes.ContinuousParameterRangesItems>, IReadOnlyList<Union<Humidifier.SageMaker.HyperParameterTuningJobTypes.ContinuousParameterRangesItems, BaseFunction>>, BaseFunction>? ContinuousParameterRanges { get; set; }
            /// <summary>
            /// AutoParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-parameterranges.html#cfn-sagemaker-hyperparametertuningjob-parameterranges-autoparameters
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: AutoParametersItems
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.HyperParameterTuningJobTypes.AutoParametersItems>, IReadOnlyList<Union<Humidifier.SageMaker.HyperParameterTuningJobTypes.AutoParametersItems, BaseFunction>>, BaseFunction>? AutoParameters { get; set; }
        }

        public class ParentHyperParameterTuningJobsItems : Humidifier.Base.BaseSubResource, IHaveHyperParameterTuningJobName
        {
            /// <summary>
            /// HyperParameterTuningJobName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-parenthyperparametertuningjobsitems.html#cfn-sagemaker-hyperparametertuningjob-parenthyperparametertuningjobsitems-hyperparametertuningjobname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HyperParameterTuningJobName { get; set; }
        }

        public class PlacementSpecificationsItems : Humidifier.Base.BaseSubResource, IHaveInstanceCount_Integer, IHaveUltraServerId
        {
            /// <summary>
            /// InstanceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-placementspecificationsitems.html#cfn-sagemaker-hyperparametertuningjob-placementspecificationsitems-instancecount
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? InstanceCount { get; set; }
            /// <summary>
            /// UltraServerId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-placementspecificationsitems.html#cfn-sagemaker-hyperparametertuningjob-placementspecificationsitems-ultraserverid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UltraServerId { get; set; }
        }

        public class ResourceConfig : Humidifier.Base.BaseSubResource, IHaveInstanceCount_Integer, IHaveVolumeSizeInGB_Integer, IHaveSageMakerHyperParameterTuningJobTypesInstancePlacementConfigInstancePlacementConfig, IHaveKeepAlivePeriodInSeconds_Integer, IHaveListOfSageMakerHyperParameterTuningJobTypesInstanceGroupsItemsInstanceGroups, IHaveVolumeKmsKeyId, IHaveTrainingPlanArn, IHaveInstanceType
        {
            /// <summary>
            /// InstanceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-resourceconfig.html#cfn-sagemaker-hyperparametertuningjob-resourceconfig-instancecount
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? InstanceCount { get; set; }
            /// <summary>
            /// VolumeSizeInGB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-resourceconfig.html#cfn-sagemaker-hyperparametertuningjob-resourceconfig-volumesizeingb
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? VolumeSizeInGB { get; set; }
            /// <summary>
            /// InstancePlacementConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-resourceconfig.html#cfn-sagemaker-hyperparametertuningjob-resourceconfig-instanceplacementconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: InstancePlacementConfig
            /// </summary>
            public Union<Humidifier.SageMaker.HyperParameterTuningJobTypes.InstancePlacementConfig, BaseFunction>? InstancePlacementConfig { get; set; }
            /// <summary>
            /// KeepAlivePeriodInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-resourceconfig.html#cfn-sagemaker-hyperparametertuningjob-resourceconfig-keepaliveperiodinseconds
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? KeepAlivePeriodInSeconds { get; set; }
            /// <summary>
            /// InstanceGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-resourceconfig.html#cfn-sagemaker-hyperparametertuningjob-resourceconfig-instancegroups
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: InstanceGroupsItems
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.HyperParameterTuningJobTypes.InstanceGroupsItems>, IReadOnlyList<Union<Humidifier.SageMaker.HyperParameterTuningJobTypes.InstanceGroupsItems, BaseFunction>>, BaseFunction>? InstanceGroups { get; set; }
            /// <summary>
            /// VolumeKmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-resourceconfig.html#cfn-sagemaker-hyperparametertuningjob-resourceconfig-volumekmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VolumeKmsKeyId { get; set; }
            /// <summary>
            /// TrainingPlanArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-resourceconfig.html#cfn-sagemaker-hyperparametertuningjob-resourceconfig-trainingplanarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TrainingPlanArn { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-resourceconfig.html#cfn-sagemaker-hyperparametertuningjob-resourceconfig-instancetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceType { get; set; }
        }

        public class ResourceLimits : Humidifier.Base.BaseSubResource, IHaveMaxRuntimeInSeconds_Integer, IHaveMaxParallelTrainingJobs_Integer, IHaveMaxNumberOfTrainingJobs_Integer
        {
            /// <summary>
            /// MaxRuntimeInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-resourcelimits.html#cfn-sagemaker-hyperparametertuningjob-resourcelimits-maxruntimeinseconds
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxRuntimeInSeconds { get; set; }
            /// <summary>
            /// MaxParallelTrainingJobs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-resourcelimits.html#cfn-sagemaker-hyperparametertuningjob-resourcelimits-maxparalleltrainingjobs
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxParallelTrainingJobs { get; set; }
            /// <summary>
            /// MaxNumberOfTrainingJobs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-resourcelimits.html#cfn-sagemaker-hyperparametertuningjob-resourcelimits-maxnumberoftrainingjobs
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxNumberOfTrainingJobs { get; set; }
        }

        public class RetryStrategy : Humidifier.Base.BaseSubResource, IHaveMaximumRetryAttempts_Integer
        {
            /// <summary>
            /// MaximumRetryAttempts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-retrystrategy.html#cfn-sagemaker-hyperparametertuningjob-retrystrategy-maximumretryattempts
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaximumRetryAttempts { get; set; }
        }

        public class S3DataSource : Humidifier.Base.BaseSubResource, IHaveS3DataDistributionType, IHaveS3Uri, IHaveS3DataType
        {
            /// <summary>
            /// S3DataDistributionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-s3datasource.html#cfn-sagemaker-hyperparametertuningjob-s3datasource-s3datadistributiontype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3DataDistributionType { get; set; }
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-s3datasource.html#cfn-sagemaker-hyperparametertuningjob-s3datasource-s3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
            /// <summary>
            /// S3DataType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-s3datasource.html#cfn-sagemaker-hyperparametertuningjob-s3datasource-s3datatype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3DataType { get; set; }
        }

        public class StoppingCondition : Humidifier.Base.BaseSubResource, IHaveMaxRuntimeInSeconds_Integer, IHaveMaxPendingTimeInSeconds_Integer, IHaveMaxWaitTimeInSeconds_Integer
        {
            /// <summary>
            /// MaxRuntimeInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-stoppingcondition.html#cfn-sagemaker-hyperparametertuningjob-stoppingcondition-maxruntimeinseconds
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxRuntimeInSeconds { get; set; }
            /// <summary>
            /// MaxPendingTimeInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-stoppingcondition.html#cfn-sagemaker-hyperparametertuningjob-stoppingcondition-maxpendingtimeinseconds
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxPendingTimeInSeconds { get; set; }
            /// <summary>
            /// MaxWaitTimeInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-stoppingcondition.html#cfn-sagemaker-hyperparametertuningjob-stoppingcondition-maxwaittimeinseconds
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxWaitTimeInSeconds { get; set; }
        }

        public class StrategyConfig : Humidifier.Base.BaseSubResource, IHaveSageMakerHyperParameterTuningJobTypesHyperbandStrategyConfigHyperbandStrategyConfig
        {
            /// <summary>
            /// HyperbandStrategyConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-strategyconfig.html#cfn-sagemaker-hyperparametertuningjob-strategyconfig-hyperbandstrategyconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: HyperbandStrategyConfig
            /// </summary>
            public Union<Humidifier.SageMaker.HyperParameterTuningJobTypes.HyperbandStrategyConfig, BaseFunction>? HyperbandStrategyConfig { get; set; }
        }

        public class TrainingJobDefinition : Humidifier.Base.BaseSubResource, IHaveEnableManagedSpotTraining_Boolean, IHaveSageMakerHyperParameterTuningJobTypesAlgorithmSpecificationAlgorithmSpecification, IHaveSageMakerHyperParameterTuningJobTypesOutputDataConfigOutputDataConfig, IHaveSageMakerHyperParameterTuningJobTypesVpcConfigVpcConfig, IHaveSageMakerHyperParameterTuningJobTypesCheckpointConfigCheckpointConfig, IHaveListOfSageMakerHyperParameterTuningJobTypesInputDataConfigItemsInputDataConfig, IHaveRoleArn, IHaveEnableNetworkIsolation_Boolean, IHaveEnableInterContainerTrafficEncryption_Boolean, IHaveSageMakerHyperParameterTuningJobTypesStoppingConditionStoppingCondition, IHaveStringDictionaryOfStaticHyperParameters, IHaveStringDictionaryOfEnvironment, IHaveDefinitionName, IHaveSageMakerHyperParameterTuningJobTypesResourceConfigResourceConfig, IHaveSageMakerHyperParameterTuningJobTypesTuningObjectiveTuningObjective, IHaveSageMakerHyperParameterTuningJobTypesRetryStrategyRetryStrategy, IHaveSageMakerHyperParameterTuningJobTypesParameterRangesHyperParameterRanges
        {
            /// <summary>
            /// EnableManagedSpotTraining
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-trainingjobdefinition.html#cfn-sagemaker-hyperparametertuningjob-trainingjobdefinition-enablemanagedspottraining
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableManagedSpotTraining { get; set; }
            /// <summary>
            /// AlgorithmSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-trainingjobdefinition.html#cfn-sagemaker-hyperparametertuningjob-trainingjobdefinition-algorithmspecification
            /// Required: True
            /// UpdateType: Immutable
            /// Type: AlgorithmSpecification
            /// </summary>
            public Union<Humidifier.SageMaker.HyperParameterTuningJobTypes.AlgorithmSpecification, BaseFunction>? AlgorithmSpecification { get; set; }
            /// <summary>
            /// OutputDataConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-trainingjobdefinition.html#cfn-sagemaker-hyperparametertuningjob-trainingjobdefinition-outputdataconfig
            /// Required: True
            /// UpdateType: Immutable
            /// Type: OutputDataConfig
            /// </summary>
            public Union<Humidifier.SageMaker.HyperParameterTuningJobTypes.OutputDataConfig, BaseFunction>? OutputDataConfig { get; set; }
            /// <summary>
            /// VpcConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-trainingjobdefinition.html#cfn-sagemaker-hyperparametertuningjob-trainingjobdefinition-vpcconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: VpcConfig
            /// </summary>
            public Union<Humidifier.SageMaker.HyperParameterTuningJobTypes.VpcConfig, BaseFunction>? VpcConfig { get; set; }
            /// <summary>
            /// CheckpointConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-trainingjobdefinition.html#cfn-sagemaker-hyperparametertuningjob-trainingjobdefinition-checkpointconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CheckpointConfig
            /// </summary>
            public Union<Humidifier.SageMaker.HyperParameterTuningJobTypes.CheckpointConfig, BaseFunction>? CheckpointConfig { get; set; }
            /// <summary>
            /// InputDataConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-trainingjobdefinition.html#cfn-sagemaker-hyperparametertuningjob-trainingjobdefinition-inputdataconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: InputDataConfigItems
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.HyperParameterTuningJobTypes.InputDataConfigItems>, IReadOnlyList<Union<Humidifier.SageMaker.HyperParameterTuningJobTypes.InputDataConfigItems, BaseFunction>>, BaseFunction>? InputDataConfig { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-trainingjobdefinition.html#cfn-sagemaker-hyperparametertuningjob-trainingjobdefinition-rolearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
            /// <summary>
            /// EnableNetworkIsolation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-trainingjobdefinition.html#cfn-sagemaker-hyperparametertuningjob-trainingjobdefinition-enablenetworkisolation
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableNetworkIsolation { get; set; }
            /// <summary>
            /// EnableInterContainerTrafficEncryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-trainingjobdefinition.html#cfn-sagemaker-hyperparametertuningjob-trainingjobdefinition-enableintercontainertrafficencryption
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableInterContainerTrafficEncryption { get; set; }
            /// <summary>
            /// StoppingCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-trainingjobdefinition.html#cfn-sagemaker-hyperparametertuningjob-trainingjobdefinition-stoppingcondition
            /// Required: True
            /// UpdateType: Immutable
            /// Type: StoppingCondition
            /// </summary>
            public Union<Humidifier.SageMaker.HyperParameterTuningJobTypes.StoppingCondition, BaseFunction>? StoppingCondition { get; set; }
            /// <summary>
            /// StaticHyperParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-trainingjobdefinition.html#cfn-sagemaker-hyperparametertuningjob-trainingjobdefinition-statichyperparameters
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? StaticHyperParameters { get; set; }
            /// <summary>
            /// Environment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-trainingjobdefinition.html#cfn-sagemaker-hyperparametertuningjob-trainingjobdefinition-environment
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Environment { get; set; }
            /// <summary>
            /// DefinitionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-trainingjobdefinition.html#cfn-sagemaker-hyperparametertuningjob-trainingjobdefinition-definitionname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DefinitionName { get; set; }
            /// <summary>
            /// ResourceConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-trainingjobdefinition.html#cfn-sagemaker-hyperparametertuningjob-trainingjobdefinition-resourceconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ResourceConfig
            /// </summary>
            public Union<Humidifier.SageMaker.HyperParameterTuningJobTypes.ResourceConfig, BaseFunction>? ResourceConfig { get; set; }
            /// <summary>
            /// TuningObjective
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-trainingjobdefinition.html#cfn-sagemaker-hyperparametertuningjob-trainingjobdefinition-tuningobjective
            /// Required: False
            /// UpdateType: Immutable
            /// Type: TuningObjective
            /// </summary>
            public Union<Humidifier.SageMaker.HyperParameterTuningJobTypes.TuningObjective, BaseFunction>? TuningObjective { get; set; }
            /// <summary>
            /// RetryStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-trainingjobdefinition.html#cfn-sagemaker-hyperparametertuningjob-trainingjobdefinition-retrystrategy
            /// Required: False
            /// UpdateType: Immutable
            /// Type: RetryStrategy
            /// </summary>
            public Union<Humidifier.SageMaker.HyperParameterTuningJobTypes.RetryStrategy, BaseFunction>? RetryStrategy { get; set; }
            /// <summary>
            /// HyperParameterRanges
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-trainingjobdefinition.html#cfn-sagemaker-hyperparametertuningjob-trainingjobdefinition-hyperparameterranges
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ParameterRanges
            /// </summary>
            public Union<Humidifier.SageMaker.HyperParameterTuningJobTypes.ParameterRanges, BaseFunction>? HyperParameterRanges { get; set; }
        }

        public class TrainingJobStatusCounters : Humidifier.Base.BaseSubResource, IHaveRetryableError_Integer, IHaveStopped_Integer, IHaveCompleted_Integer, IHaveInProgress_Integer, IHaveNonRetryableError_Integer
        {
            /// <summary>
            /// RetryableError
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-trainingjobstatuscounters.html#cfn-sagemaker-hyperparametertuningjob-trainingjobstatuscounters-retryableerror
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RetryableError { get; set; }
            /// <summary>
            /// Stopped
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-trainingjobstatuscounters.html#cfn-sagemaker-hyperparametertuningjob-trainingjobstatuscounters-stopped
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Stopped { get; set; }
            /// <summary>
            /// Completed
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-trainingjobstatuscounters.html#cfn-sagemaker-hyperparametertuningjob-trainingjobstatuscounters-completed
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Completed { get; set; }
            /// <summary>
            /// InProgress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-trainingjobstatuscounters.html#cfn-sagemaker-hyperparametertuningjob-trainingjobstatuscounters-inprogress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? InProgress { get; set; }
            /// <summary>
            /// NonRetryableError
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-trainingjobstatuscounters.html#cfn-sagemaker-hyperparametertuningjob-trainingjobstatuscounters-nonretryableerror
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? NonRetryableError { get; set; }
        }

        public class TuningJobCompletionCriteria : Humidifier.Base.BaseSubResource, IHaveSageMakerHyperParameterTuningJobTypesBestObjectiveNotImprovingBestObjectiveNotImproving, IHaveSageMakerHyperParameterTuningJobTypesConvergenceDetectedConvergenceDetected, IHaveTargetObjectiveMetricValue_Double
        {
            /// <summary>
            /// BestObjectiveNotImproving
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-tuningjobcompletioncriteria.html#cfn-sagemaker-hyperparametertuningjob-tuningjobcompletioncriteria-bestobjectivenotimproving
            /// Required: False
            /// UpdateType: Immutable
            /// Type: BestObjectiveNotImproving
            /// </summary>
            public Union<Humidifier.SageMaker.HyperParameterTuningJobTypes.BestObjectiveNotImproving, BaseFunction>? BestObjectiveNotImproving { get; set; }
            /// <summary>
            /// ConvergenceDetected
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-tuningjobcompletioncriteria.html#cfn-sagemaker-hyperparametertuningjob-tuningjobcompletioncriteria-convergencedetected
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ConvergenceDetected
            /// </summary>
            public Union<Humidifier.SageMaker.HyperParameterTuningJobTypes.ConvergenceDetected, BaseFunction>? ConvergenceDetected { get; set; }
            /// <summary>
            /// TargetObjectiveMetricValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-tuningjobcompletioncriteria.html#cfn-sagemaker-hyperparametertuningjob-tuningjobcompletioncriteria-targetobjectivemetricvalue
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TargetObjectiveMetricValue { get; set; }
        }

        public class TuningObjective : Humidifier.Base.BaseSubResource, IHaveMetricName, IHaveType
        {
            /// <summary>
            /// MetricName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-tuningobjective.html#cfn-sagemaker-hyperparametertuningjob-tuningobjective-metricname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetricName { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-tuningobjective.html#cfn-sagemaker-hyperparametertuningjob-tuningobjective-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
        }

        public class VpcConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfSubnets, IHaveStringListOfSecurityGroupIds
        {
            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-vpcconfig.html#cfn-sagemaker-hyperparametertuningjob-vpcconfig-subnets
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Subnets { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-hyperparametertuningjob-vpcconfig.html#cfn-sagemaker-hyperparametertuningjob-vpcconfig-securitygroupids
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        }
    }
}