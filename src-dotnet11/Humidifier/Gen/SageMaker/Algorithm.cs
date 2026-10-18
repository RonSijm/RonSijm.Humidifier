namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using AlgorithmTypes;

    public class Algorithm : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveSageMakerAlgorithmTypesInferenceSpecificationInferenceSpecification, IHaveAlgorithmDescription, IHaveSageMakerAlgorithmTypesTrainingSpecificationTrainingSpecification, IHaveAlgorithmName, IHaveCertifyForMarketplace_Boolean, IHaveDescription
    {
        public class Attributes
        {
            public static string CreationTime =  "CreationTime" ;
            public static string AlgorithmArn =  "AlgorithmArn" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.Algorithm; }
        /// <summary>
        /// InferenceSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-algorithm.html#cfn-sagemaker-algorithm-inferencespecification
        /// Required: False
        /// UpdateType: Immutable
        /// Type: InferenceSpecification
        /// </summary>
        public Union<Humidifier.SageMaker.AlgorithmTypes.InferenceSpecification, BaseFunction>? InferenceSpecification { get; set; }
        /// <summary>
        /// AlgorithmDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-algorithm.html#cfn-sagemaker-algorithm-algorithmdescription
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AlgorithmDescription { get; set; }

        [Ignore]
        public Union<string, BaseFunction>? Description { get => AlgorithmDescription; set => AlgorithmDescription = value; }

        /// <summary>
        /// TrainingSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-algorithm.html#cfn-sagemaker-algorithm-trainingspecification
        /// Required: True
        /// UpdateType: Immutable
        /// Type: TrainingSpecification
        /// </summary>
        [Required]
        public Union<Humidifier.SageMaker.AlgorithmTypes.TrainingSpecification, BaseFunction>? TrainingSpecification { get; set; }
        public Union<string, BaseFunction>? AlgorithmName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-algorithm.html#cfn-sagemaker-algorithm-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// CertifyForMarketplace
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-algorithm.html#cfn-sagemaker-algorithm-certifyformarketplace
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? CertifyForMarketplace { get; set; }
    }

    namespace AlgorithmTypes
    {
        public class CategoricalParameterRangeSpecification : Humidifier.Base.BaseSubResource, IHaveStringListOfValues
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-categoricalparameterrangespecification.html#cfn-sagemaker-algorithm-categoricalparameterrangespecification-values
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
        }

        public class ChannelSpecification : Humidifier.Base.BaseSubResource, IHaveStringListOfSupportedInputModes, IHaveDescription, IHaveIsRequired_Boolean, IHaveStringListOfSupportedContentTypes, IHaveStringListOfSupportedCompressionTypes, IHaveName
        {
            /// <summary>
            /// SupportedInputModes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-channelspecification.html#cfn-sagemaker-algorithm-channelspecification-supportedinputmodes
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SupportedInputModes { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-channelspecification.html#cfn-sagemaker-algorithm-channelspecification-description
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// IsRequired
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-channelspecification.html#cfn-sagemaker-algorithm-channelspecification-isrequired
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsRequired { get; set; }
            /// <summary>
            /// SupportedContentTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-channelspecification.html#cfn-sagemaker-algorithm-channelspecification-supportedcontenttypes
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SupportedContentTypes { get; set; }
            /// <summary>
            /// SupportedCompressionTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-channelspecification.html#cfn-sagemaker-algorithm-channelspecification-supportedcompressiontypes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SupportedCompressionTypes { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-channelspecification.html#cfn-sagemaker-algorithm-channelspecification-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class ContinuousParameterRangeSpecification : Humidifier.Base.BaseSubResource, IHaveMinValue, IHaveMaxValue
        {
            /// <summary>
            /// MinValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-continuousparameterrangespecification.html#cfn-sagemaker-algorithm-continuousparameterrangespecification-minvalue
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MinValue { get; set; }
            /// <summary>
            /// MaxValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-continuousparameterrangespecification.html#cfn-sagemaker-algorithm-continuousparameterrangespecification-maxvalue
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MaxValue { get; set; }
        }

        public class HyperParameterSpecification : Humidifier.Base.BaseSubResource, IHaveDefaultValue, IHaveType, IHaveDescription, IHaveIsRequired_Boolean, IHaveIsTunable_Boolean, IHaveSageMakerAlgorithmTypesParameterRangeRange, IHaveName
        {
            /// <summary>
            /// DefaultValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-hyperparameterspecification.html#cfn-sagemaker-algorithm-hyperparameterspecification-defaultvalue
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DefaultValue { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-hyperparameterspecification.html#cfn-sagemaker-algorithm-hyperparameterspecification-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-hyperparameterspecification.html#cfn-sagemaker-algorithm-hyperparameterspecification-description
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// IsRequired
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-hyperparameterspecification.html#cfn-sagemaker-algorithm-hyperparameterspecification-isrequired
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsRequired { get; set; }
            /// <summary>
            /// IsTunable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-hyperparameterspecification.html#cfn-sagemaker-algorithm-hyperparameterspecification-istunable
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsTunable { get; set; }
            /// <summary>
            /// Range
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-hyperparameterspecification.html#cfn-sagemaker-algorithm-hyperparameterspecification-range
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ParameterRange
            /// </summary>
            public Union<Humidifier.SageMaker.AlgorithmTypes.ParameterRange, BaseFunction>? Range { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-hyperparameterspecification.html#cfn-sagemaker-algorithm-hyperparameterspecification-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class HyperParameterTuningJobObjective : Humidifier.Base.BaseSubResource, IHaveMetricName, IHaveType
        {
            /// <summary>
            /// MetricName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-hyperparametertuningjobobjective.html#cfn-sagemaker-algorithm-hyperparametertuningjobobjective-metricname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetricName { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-hyperparametertuningjobobjective.html#cfn-sagemaker-algorithm-hyperparametertuningjobobjective-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
        }

        public class InferenceSpecification : Humidifier.Base.BaseSubResource, IHaveStringListOfSupportedContentTypes, IHaveStringListOfSupportedRealtimeInferenceInstanceTypes, IHaveListOfSageMakerAlgorithmTypesModelPackageContainerDefinitionContainers, IHaveStringListOfSupportedTransformInstanceTypes, IHaveStringListOfSupportedResponseMIMETypes
        {
            /// <summary>
            /// SupportedContentTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-inferencespecification.html#cfn-sagemaker-algorithm-inferencespecification-supportedcontenttypes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SupportedContentTypes { get; set; }
            /// <summary>
            /// SupportedRealtimeInferenceInstanceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-inferencespecification.html#cfn-sagemaker-algorithm-inferencespecification-supportedrealtimeinferenceinstancetypes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SupportedRealtimeInferenceInstanceTypes { get; set; }
            /// <summary>
            /// Containers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-inferencespecification.html#cfn-sagemaker-algorithm-inferencespecification-containers
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ModelPackageContainerDefinition
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.AlgorithmTypes.ModelPackageContainerDefinition>, IReadOnlyList<Union<Humidifier.SageMaker.AlgorithmTypes.ModelPackageContainerDefinition, BaseFunction>>, BaseFunction>? Containers { get; set; }
            /// <summary>
            /// SupportedTransformInstanceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-inferencespecification.html#cfn-sagemaker-algorithm-inferencespecification-supportedtransforminstancetypes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SupportedTransformInstanceTypes { get; set; }
            /// <summary>
            /// SupportedResponseMIMETypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-inferencespecification.html#cfn-sagemaker-algorithm-inferencespecification-supportedresponsemimetypes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SupportedResponseMIMETypes { get; set; }
        }

        public class IntegerParameterRangeSpecification : Humidifier.Base.BaseSubResource, IHaveMinValue, IHaveMaxValue
        {
            /// <summary>
            /// MinValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-integerparameterrangespecification.html#cfn-sagemaker-algorithm-integerparameterrangespecification-minvalue
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MinValue { get; set; }
            /// <summary>
            /// MaxValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-integerparameterrangespecification.html#cfn-sagemaker-algorithm-integerparameterrangespecification-maxvalue
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MaxValue { get; set; }
        }

        public class MetricDefinition : Humidifier.Base.BaseSubResource, IHaveRegex, IHaveName
        {
            /// <summary>
            /// Regex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-metricdefinition.html#cfn-sagemaker-algorithm-metricdefinition-regex
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Regex { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-metricdefinition.html#cfn-sagemaker-algorithm-metricdefinition-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class ModelInput : Humidifier.Base.BaseSubResource, IHaveDataInputConfig
        {
            /// <summary>
            /// DataInputConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-modelinput.html#cfn-sagemaker-algorithm-modelinput-datainputconfig
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataInputConfig { get; set; }
        }

        public class ModelPackageContainerDefinition : Humidifier.Base.BaseSubResource, IHaveSageMakerAlgorithmTypesModelInputModelInput, IHaveNearestModelName, IHaveContainerHostname, IHaveImageDigest, IHaveFrameworkVersion, IHaveStringDictionaryOfEnvironment, IHaveImage, IHaveIsCheckpoint_Boolean, IHaveFramework
        {
            /// <summary>
            /// ModelInput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-modelpackagecontainerdefinition.html#cfn-sagemaker-algorithm-modelpackagecontainerdefinition-modelinput
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ModelInput
            /// </summary>
            public Union<Humidifier.SageMaker.AlgorithmTypes.ModelInput, BaseFunction>? ModelInput { get; set; }
            /// <summary>
            /// NearestModelName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-modelpackagecontainerdefinition.html#cfn-sagemaker-algorithm-modelpackagecontainerdefinition-nearestmodelname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NearestModelName { get; set; }
            /// <summary>
            /// ContainerHostname
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-modelpackagecontainerdefinition.html#cfn-sagemaker-algorithm-modelpackagecontainerdefinition-containerhostname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContainerHostname { get; set; }
            /// <summary>
            /// ImageDigest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-modelpackagecontainerdefinition.html#cfn-sagemaker-algorithm-modelpackagecontainerdefinition-imagedigest
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImageDigest { get; set; }
            /// <summary>
            /// FrameworkVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-modelpackagecontainerdefinition.html#cfn-sagemaker-algorithm-modelpackagecontainerdefinition-frameworkversion
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FrameworkVersion { get; set; }
            /// <summary>
            /// Environment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-modelpackagecontainerdefinition.html#cfn-sagemaker-algorithm-modelpackagecontainerdefinition-environment
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Environment { get; set; }
            /// <summary>
            /// Image
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-modelpackagecontainerdefinition.html#cfn-sagemaker-algorithm-modelpackagecontainerdefinition-image
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Image { get; set; }
            /// <summary>
            /// IsCheckpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-modelpackagecontainerdefinition.html#cfn-sagemaker-algorithm-modelpackagecontainerdefinition-ischeckpoint
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsCheckpoint { get; set; }
            /// <summary>
            /// Framework
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-modelpackagecontainerdefinition.html#cfn-sagemaker-algorithm-modelpackagecontainerdefinition-framework
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Framework { get; set; }
        }

        public class ParameterRange : Humidifier.Base.BaseSubResource, IHaveSageMakerAlgorithmTypesIntegerParameterRangeSpecificationIntegerParameterRangeSpecification, IHaveSageMakerAlgorithmTypesCategoricalParameterRangeSpecificationCategoricalParameterRangeSpecification, IHaveSageMakerAlgorithmTypesContinuousParameterRangeSpecificationContinuousParameterRangeSpecification
        {
            /// <summary>
            /// IntegerParameterRangeSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-parameterrange.html#cfn-sagemaker-algorithm-parameterrange-integerparameterrangespecification
            /// Required: False
            /// UpdateType: Immutable
            /// Type: IntegerParameterRangeSpecification
            /// </summary>
            public Union<Humidifier.SageMaker.AlgorithmTypes.IntegerParameterRangeSpecification, BaseFunction>? IntegerParameterRangeSpecification { get; set; }
            /// <summary>
            /// CategoricalParameterRangeSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-parameterrange.html#cfn-sagemaker-algorithm-parameterrange-categoricalparameterrangespecification
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CategoricalParameterRangeSpecification
            /// </summary>
            public Union<Humidifier.SageMaker.AlgorithmTypes.CategoricalParameterRangeSpecification, BaseFunction>? CategoricalParameterRangeSpecification { get; set; }
            /// <summary>
            /// ContinuousParameterRangeSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-parameterrange.html#cfn-sagemaker-algorithm-parameterrange-continuousparameterrangespecification
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ContinuousParameterRangeSpecification
            /// </summary>
            public Union<Humidifier.SageMaker.AlgorithmTypes.ContinuousParameterRangeSpecification, BaseFunction>? ContinuousParameterRangeSpecification { get; set; }
        }

        public class TrainingSpecification : Humidifier.Base.BaseSubResource, IHaveStringListOfSupportedTrainingInstanceTypes, IHaveTrainingImageDigest, IHaveListOfSageMakerAlgorithmTypesHyperParameterSpecificationSupportedHyperParameters, IHaveSupportsDistributedTraining_Boolean, IHaveListOfSageMakerAlgorithmTypesMetricDefinitionMetricDefinitions, IHaveListOfSageMakerAlgorithmTypesChannelSpecificationTrainingChannels, IHaveTrainingImage, IHaveListOfSageMakerAlgorithmTypesHyperParameterTuningJobObjectiveSupportedTuningJobObjectiveMetrics
        {
            /// <summary>
            /// SupportedTrainingInstanceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-trainingspecification.html#cfn-sagemaker-algorithm-trainingspecification-supportedtraininginstancetypes
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SupportedTrainingInstanceTypes { get; set; }
            /// <summary>
            /// TrainingImageDigest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-trainingspecification.html#cfn-sagemaker-algorithm-trainingspecification-trainingimagedigest
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TrainingImageDigest { get; set; }
            /// <summary>
            /// SupportedHyperParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-trainingspecification.html#cfn-sagemaker-algorithm-trainingspecification-supportedhyperparameters
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: HyperParameterSpecification
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.AlgorithmTypes.HyperParameterSpecification>, IReadOnlyList<Union<Humidifier.SageMaker.AlgorithmTypes.HyperParameterSpecification, BaseFunction>>, BaseFunction>? SupportedHyperParameters { get; set; }
            /// <summary>
            /// SupportsDistributedTraining
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-trainingspecification.html#cfn-sagemaker-algorithm-trainingspecification-supportsdistributedtraining
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? SupportsDistributedTraining { get; set; }
            /// <summary>
            /// MetricDefinitions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-trainingspecification.html#cfn-sagemaker-algorithm-trainingspecification-metricdefinitions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: MetricDefinition
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.AlgorithmTypes.MetricDefinition>, IReadOnlyList<Union<Humidifier.SageMaker.AlgorithmTypes.MetricDefinition, BaseFunction>>, BaseFunction>? MetricDefinitions { get; set; }
            /// <summary>
            /// TrainingChannels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-trainingspecification.html#cfn-sagemaker-algorithm-trainingspecification-trainingchannels
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ChannelSpecification
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.AlgorithmTypes.ChannelSpecification>, IReadOnlyList<Union<Humidifier.SageMaker.AlgorithmTypes.ChannelSpecification, BaseFunction>>, BaseFunction>? TrainingChannels { get; set; }
            /// <summary>
            /// TrainingImage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-trainingspecification.html#cfn-sagemaker-algorithm-trainingspecification-trainingimage
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TrainingImage { get; set; }
            /// <summary>
            /// SupportedTuningJobObjectiveMetrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-trainingspecification.html#cfn-sagemaker-algorithm-trainingspecification-supportedtuningjobobjectivemetrics
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: HyperParameterTuningJobObjective
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.AlgorithmTypes.HyperParameterTuningJobObjective>, IReadOnlyList<Union<Humidifier.SageMaker.AlgorithmTypes.HyperParameterTuningJobObjective, BaseFunction>>, BaseFunction>? SupportedTuningJobObjectiveMetrics { get; set; }
        }
    }
}